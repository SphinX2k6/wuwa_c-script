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
	// Token: 0x02007197 RID: 29079
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemTimeStopMachineComponent : EntityComponent
	{
		// Token: 0x06047255 RID: 291413 RVA: 0x01211B18 File Offset: 0x0120FD18
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TimeStopComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemTimeStopMachineComponent>() as TimeStopComponent;
			this.Config = config;
			this.TargetState = new int?(GameplayTagUtils.GetTagIdByName(this.Config.ActiveState));
			return true;
		}

		// Token: 0x06047256 RID: 291414 RVA: 0x01211B59 File Offset: 0x0120FD59
		protected override bool OnStart()
		{
			this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
			this.AddEventListener();
			this.CurrentAffectedEntity.Clear();
			this.WaitAddEntitiesSet.Clear();
			return true;
		}

		// Token: 0x06047257 RID: 291415 RVA: 0x01211B89 File Offset: 0x0120FD89
		protected override bool OnEnd()
		{
			this.RemoveEventListener();
			this.CurrentAffectedEntity.Clear();
			this.WaitAddEntitiesSet.Clear();
			return true;
		}

		// Token: 0x06047258 RID: 291416 RVA: 0x01211BA8 File Offset: 0x0120FDA8
		private void AddEventListener()
		{
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
		}

		// Token: 0x06047259 RID: 291417 RVA: 0x01211BCC File Offset: 0x0120FDCC
		private void RemoveEventListener()
		{
			EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			if (EventSystem.Instance.Has<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity)))
			{
				EventSystem.Instance.Remove<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity));
			}
		}

		// Token: 0x0604725A RID: 291418 RVA: 0x01211C40 File Offset: 0x0120FE40
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

		// Token: 0x0604725B RID: 291419 RVA: 0x01211CB0 File Offset: 0x0120FEB0
		private void OnEntityRemove(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (this.CurrentAffectedEntity.ContainsKey(handle))
			{
				this.EndTimeStopInternal(handle);
				this.CurrentAffectedEntity.Remove(handle);
				EventSystem.Instance.RemoveWithTargetUseKey(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnEntityRemove));
			}
		}

		// Token: 0x0604725C RID: 291420 RVA: 0x01211D00 File Offset: 0x0120FF00
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

		// Token: 0x0604725D RID: 291421 RVA: 0x01211D98 File Offset: 0x0120FF98
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

		// Token: 0x0604725E RID: 291422 RVA: 0x01211E9C File Offset: 0x0121009C
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

		// Token: 0x0604725F RID: 291423 RVA: 0x01211F44 File Offset: 0x01210144
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

		// Token: 0x06047260 RID: 291424 RVA: 0x01211FE9 File Offset: 0x012101E9
		private void TryListenAddEntityEvent()
		{
			if (!EventSystem.Instance.Has<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity)))
			{
				EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.WaitCreateEntity));
			}
		}

		// Token: 0x06047261 RID: 291425 RVA: 0x01212024 File Offset: 0x01210224
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

		// Token: 0x06047262 RID: 291426 RVA: 0x01212090 File Offset: 0x01210290
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTimeStopMachineComponent sceneItemTimeStopMachineComponent = (SceneItemTimeStopMachineComponent)componentTemplate;
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemTimeStopMachineComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimeStopComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetState"))
			{
				this.TargetState = sceneItemTimeStopMachineComponent.TargetState;
			}
			if (base.CanResetComponentProperty("CreatureDataComponent"))
			{
				if (sceneItemTimeStopMachineComponent.CreatureDataComponent == null)
				{
					this.CreatureDataComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentAffectedEntity") && sceneItemTimeStopMachineComponent.CurrentAffectedEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EntityHandle, TimeStopData>>(this.CurrentAffectedEntity), "CurrentAffectedEntity"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("WaitAddEntitiesSet") && sceneItemTimeStopMachineComponent.WaitAddEntitiesSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.WaitAddEntitiesSet), "WaitAddEntitiesSet"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("IsStopping"))
			{
				this.IsStopping = sceneItemTimeStopMachineComponent.IsStopping;
			}
			return true;
		}

		// Token: 0x04025675 RID: 153205
		private const int TOLERANCE_TIME = 3;

		// Token: 0x04025676 RID: 153206
		private const int TIME_STOP_BUFF_ID = 600000009;

		// Token: 0x04025677 RID: 153207
		[Nullable(2)]
		private TimeStopComponent Config;

		// Token: 0x04025678 RID: 153208
		private int? TargetState;

		// Token: 0x04025679 RID: 153209
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x0402567A RID: 153210
		private readonly Dictionary<EntityHandle, TimeStopData> CurrentAffectedEntity = new Dictionary<EntityHandle, TimeStopData>();

		// Token: 0x0402567B RID: 153211
		private readonly HashSet<int> WaitAddEntitiesSet = new HashSet<int>();

		// Token: 0x0402567C RID: 153212
		private bool IsStopping;
	}
}
