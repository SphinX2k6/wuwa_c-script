using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200624C RID: 25164
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemTimeStopMachineComponent : EntityComponent
	{
		// Token: 0x0603CB3E RID: 248638 RVA: 0x0116C07C File Offset: 0x0116A27C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TimeStopComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemTimeStopMachineComponent>() as TimeStopComponent;
			this.Config = config;
			this.TargetState = new int?(GameplayTagUtils.GetTagIdByName(this.Config.ActiveState));
			return true;
		}

		// Token: 0x0603CB3F RID: 248639 RVA: 0x0116C0BD File Offset: 0x0116A2BD
		protected override bool OnStart()
		{
			this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
			this.AddEventListener();
			this.CurrentAffectedEntity.Clear();
			this.WaitAddEntitiesSet.Clear();
			return true;
		}

		// Token: 0x0603CB40 RID: 248640 RVA: 0x0116C0ED File Offset: 0x0116A2ED
		protected override bool OnEnd()
		{
			this.RemoveEventListener();
			this.CurrentAffectedEntity.Clear();
			this.WaitAddEntitiesSet.Clear();
			return true;
		}

		// Token: 0x0603CB41 RID: 248641 RVA: 0x0116C10C File Offset: 0x0116A30C
		private void AddEventListener()
		{
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
		}

		// Token: 0x0603CB42 RID: 248642 RVA: 0x0116C130 File Offset: 0x0116A330
		private void RemoveEventListener()
		{
			EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			if (EventSystem.Instance.Has<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity)))
			{
				EventSystem.Instance.Remove<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity));
			}
		}

		// Token: 0x0603CB43 RID: 248643 RVA: 0x0116C1A4 File Offset: 0x0116A3A4
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			int? targetState = this.TargetState;
			if (!(stateId == targetState.GetValueOrDefault() & targetState != null) && this.IsStopping)
			{
				this.IsStopping = false;
				this.EndTimeStop();
				return;
			}
			targetState = this.TargetState;
			if ((stateId == targetState.GetValueOrDefault() & targetState != null) && !this.IsStopping)
			{
				this.IsStopping = true;
				this.StartTimeStop();
			}
		}

		// Token: 0x0603CB44 RID: 248644 RVA: 0x0116C214 File Offset: 0x0116A414
		private void OnEntityRemove(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (this.CurrentAffectedEntity.ContainsKey(handle))
			{
				this.EndTimeStopInternal(handle);
				this.CurrentAffectedEntity.Remove(handle);
				EventSystem.Instance.RemoveWithTargetUseKey(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnEntityRemove));
			}
		}

		// Token: 0x0603CB45 RID: 248645 RVA: 0x0116C264 File Offset: 0x0116A464
		private void StartTimeStop()
		{
			TimeStopComponent config = this.Config;
			List<int> list = (config != null) ? config.Target.EntityIds : null;
			if (list != null)
			{
				foreach (int num in list)
				{
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
					if (entityByPbDataId != null && entityByPbDataId.Valid)
					{
						this.StartTimeStopInternal(entityByPbDataId);
					}
					else
					{
						this.WaitAddEntitiesSet.Add(num);
						this.TryListenAddEntityEvent();
					}
				}
			}
		}

		// Token: 0x0603CB46 RID: 248646 RVA: 0x0116C2FC File Offset: 0x0116A4FC
		private void StartTimeStopInternal(EntityHandle entityHandle)
		{
			WorldEntity entity = entityHandle.Entity;
			PawnTimeScaleComponent pawnTimeScaleComponent = (entity != null) ? entity.GetComponent<PawnTimeScaleComponent>() : null;
			if (pawnTimeScaleComponent != null)
			{
				int timeScaleId = pawnTimeScaleComponent.SetTimeScale(1, 0f, null, (float)(this.Config.StopTime + 3), ETimeScaleSourceType.TimeStopMachine, false, false);
				EEntityType entityType = entityHandle.Entity.GetComponent<CreatureDataComponent>().GetEntityType();
				if (entityType == EEntityType.SceneItem)
				{
					LevelTagComponent component = entityHandle.Entity.GetComponent<LevelTagComponent>();
					if (component != null)
					{
						component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.时停中"]));
					}
				}
				else
				{
					BaseBuffComponent component2 = entityHandle.Entity.GetComponent<BaseBuffComponent>();
					if (component2 != null)
					{
						component2.AddBuff(600000009L, new AddBuffParam
						{
							InstigatorId = this.CreatureDataComponent.GetCreatureDataId(),
							Level = new int?(1),
							Reason = "TimeStopMachine"
						});
					}
				}
				EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, entityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnEntityRemove));
				this.CurrentAffectedEntity[entityHandle] = new TimeStopData(pawnTimeScaleComponent, timeScaleId, entityType == EEntityType.SceneItem);
			}
		}

		// Token: 0x0603CB47 RID: 248647 RVA: 0x0116C400 File Offset: 0x0116A600
		private void EndTimeStop()
		{
			foreach (KeyValuePair<EntityHandle, TimeStopData> keyValuePair in this.CurrentAffectedEntity)
			{
				this.EndTimeStopInternal(keyValuePair.Key);
			}
			this.CurrentAffectedEntity.Clear();
			if (EventSystem.Instance.Has<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity)))
			{
				EventSystem.Instance.Remove<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity));
				this.WaitAddEntitiesSet.Clear();
			}
		}

		// Token: 0x0603CB48 RID: 248648 RVA: 0x0116C4A8 File Offset: 0x0116A6A8
		private void EndTimeStopInternal(EntityHandle entityHandle)
		{
			TimeStopData timeStopData;
			if (this.CurrentAffectedEntity.TryGetValue(entityHandle, out timeStopData))
			{
				timeStopData.TimeScaleComponent.RemoveTimeScale(timeStopData.TimeScaleId.Value);
				if (timeStopData.IsSceneItem)
				{
					LevelTagComponent component = entityHandle.Entity.GetComponent<LevelTagComponent>();
					if (component == null)
					{
						return;
					}
					component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.时停中"]));
					return;
				}
				else
				{
					BaseBuffComponent component2 = entityHandle.Entity.GetComponent<BaseBuffComponent>();
					if (component2 == null)
					{
						return;
					}
					component2.RemoveBuff(600000009L, -1, "TimeStopMachine", null, null, null);
				}
			}
		}

		// Token: 0x0603CB49 RID: 248649 RVA: 0x0116C54D File Offset: 0x0116A74D
		private void TryListenAddEntityEvent()
		{
			if (!EventSystem.Instance.Has<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity)))
			{
				EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity));
			}
		}

		// Token: 0x0603CB4A RID: 248650 RVA: 0x0116C588 File Offset: 0x0116A788
		private void WaitCreateEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
		{
			int pbDataId = handle.Entity.GetComponent<CreatureDataComponent>().GetPbDataId();
			if (this.WaitAddEntitiesSet.Contains(pbDataId))
			{
				this.WaitAddEntitiesSet.Remove(pbDataId);
				this.StartTimeStopInternal(handle);
				if (this.WaitAddEntitiesSet.Count == 0)
				{
					EventSystem.Instance.Remove<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity));
				}
			}
		}

		// Token: 0x0603CB4B RID: 248651 RVA: 0x0116C5F4 File Offset: 0x0116A7F4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTimeStopMachineComponent sceneItemTimeStopMachineComponent = (SceneItemTimeStopMachineComponent)componentTemplate;
			if (sceneItemTimeStopMachineComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			this.TargetState = sceneItemTimeStopMachineComponent.TargetState;
			if (sceneItemTimeStopMachineComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
			if (sceneItemTimeStopMachineComponent.CurrentAffectedEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentAffectedEntity), "CurrentAffectedEntity"))
			{
				return false;
			}
			if (sceneItemTimeStopMachineComponent.WaitAddEntitiesSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.WaitAddEntitiesSet), "WaitAddEntitiesSet"))
			{
				return false;
			}
			this.IsStopping = sceneItemTimeStopMachineComponent.IsStopping;
			return true;
		}

		// Token: 0x170072D6 RID: 29398
		// (get) Token: 0x0603CB4C RID: 248652 RVA: 0x0116C6C6 File Offset: 0x0116A8C6
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072D7 RID: 29399
		// (get) Token: 0x0603CB4D RID: 248653 RVA: 0x0116C6C9 File Offset: 0x0116A8C9
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040202E5 RID: 131813
		private const int TOLERANCE_TIME = 3;

		// Token: 0x040202E6 RID: 131814
		private const int TIME_STOP_BUFF_ID = 600000009;

		// Token: 0x040202E7 RID: 131815
		[Nullable(2)]
		private TimeStopComponent Config;

		// Token: 0x040202E8 RID: 131816
		private int? TargetState;

		// Token: 0x040202E9 RID: 131817
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x040202EA RID: 131818
		private readonly Dictionary<EntityHandle, TimeStopData> CurrentAffectedEntity = new Dictionary<EntityHandle, TimeStopData>();

		// Token: 0x040202EB RID: 131819
		private readonly HashSet<int> WaitAddEntitiesSet = new HashSet<int>();

		// Token: 0x040202EC RID: 131820
		private bool IsStopping;
	}
}
