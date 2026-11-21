using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree;
using CSharpScript.Game.NewWorld.Character.Npc.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Npc.Component
{
	// Token: 0x02006301 RID: 25345
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcTimetableComponent : EntityComponent
	{
		// Token: 0x17007408 RID: 29704
		// (get) Token: 0x0603D4D0 RID: 251088 RVA: 0x011B6711 File Offset: 0x011B4911
		[Nullable(1)]
		public override Type[] Dependencies
		{
			[NullableContext(1)]
			get
			{
				return new Type[]
				{
					typeof(CharacterActorComponent),
					typeof(CharacterAiComponent)
				};
			}
		}

		// Token: 0x0603D4D1 RID: 251089 RVA: 0x011B6734 File Offset: 0x011B4934
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			this.CreatureId = component.GetCreatureDataId();
			return true;
		}

		// Token: 0x0603D4D2 RID: 251090 RVA: 0x011B675C File Offset: 0x011B495C
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
			this.AiComp = base.Entity.CheckGetComponent<CharacterAiComponent>();
			this.PatrolComp = base.Entity.GetComponent<CharacterPatrolComponent>();
			this.PerformComp = base.Entity.GetComponent<BasePerformComponent>();
			this.AddEvents();
			return true;
		}

		// Token: 0x0603D4D3 RID: 251091 RVA: 0x011B67B4 File Offset: 0x011B49B4
		protected override void OnActivate()
		{
			TimetableConfigData timeScheduleByCreatureId = NpcTimetableController.Instance.GetTimeScheduleByCreatureId(this.CreatureId);
			if (timeScheduleByCreatureId == null)
			{
				return;
			}
			this.SwitchTimetable(timeScheduleByCreatureId, "Activate", false);
		}

		// Token: 0x0603D4D4 RID: 251092 RVA: 0x011B67E3 File Offset: 0x011B49E3
		protected override bool OnClear()
		{
			this.RemoveEvents();
			TimerHandle delaySwitchHandle = this.DelaySwitchHandle;
			if (delaySwitchHandle != null)
			{
				delaySwitchHandle.Remove();
			}
			this.DelaySwitchHandle = null;
			this.SendTimetableSavedDataToExternal();
			return true;
		}

		// Token: 0x0603D4D5 RID: 251093 RVA: 0x011B680C File Offset: 0x011B4A0C
		protected void AddEvents()
		{
			if (this.IsEventAdded)
			{
				return;
			}
			this.IsEventAdded = true;
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnRunBehaviorTree, new Action(this.OnRunBehaviorTree));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnBeforeAiDisable, new Action(this.OnBeforeAiDisable));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnAiEnable, new Action(this.OnAiEnable));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnPatrolStart, new Action<int>(this.OnPatrolStartOrResume));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnPatrolResume, new Action<int>(this.OnPatrolStartOrResume));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnPatrolPause, new Action<int>(this.OnPatrolPauseOrStop));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnPatrolStop, new Action<int>(this.OnPatrolPauseOrStop));
		}

		// Token: 0x0603D4D6 RID: 251094 RVA: 0x011B6918 File Offset: 0x011B4B18
		protected void RemoveEvents()
		{
			if (!this.IsEventAdded)
			{
				return;
			}
			this.IsEventAdded = false;
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRunBehaviorTree, new Action(this.OnRunBehaviorTree));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnBeforeAiDisable, new Action(this.OnBeforeAiDisable));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnAiEnable, new Action(this.OnAiEnable));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnPatrolStart, new Action<int>(this.OnPatrolStartOrResume));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnPatrolResume, new Action<int>(this.OnPatrolStartOrResume));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnPatrolPause, new Action<int>(this.OnPatrolPauseOrStop));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnPatrolStop, new Action<int>(this.OnPatrolPauseOrStop));
		}

		// Token: 0x0603D4D7 RID: 251095 RVA: 0x011B6A24 File Offset: 0x011B4C24
		protected unsafe void OnRunBehaviorTree()
		{
			bool flag = this.TryLoadTimetableSavedData();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.YY;
			string message = "[OnRunBehaviorTree链路] NpcTimetableComponent处理完成";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "EntityName";
			CharacterActorComponent actorComp = this.ActorComp;
			object item2;
			if (actorComp == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item3 = "PbDataId";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item3, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("LoadSavedDataResult", flag);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.IsBehaviorTreeRunning = true;
		}

		// Token: 0x0603D4D8 RID: 251096 RVA: 0x011B6B1B File Offset: 0x011B4D1B
		protected void OnBeforeAiDisable()
		{
			this.TrySaveTimetableSavedData();
			this.IsBehaviorTreeRunning = false;
		}

		// Token: 0x0603D4D9 RID: 251097 RVA: 0x011B6B2B File Offset: 0x011B4D2B
		protected void OnAiEnable()
		{
			this.LastSavedData = null;
			this.IsBehaviorTreeRunning = true;
		}

		// Token: 0x0603D4DA RID: 251098 RVA: 0x011B6B3B File Offset: 0x011B4D3B
		protected void OnPatrolStartOrResume(int splineId)
		{
			if (this.IsBehaviorTreeRunning)
			{
				return;
			}
			this.LastSavedPatrolData = null;
			this.LastSavedPatrolIsAiSpline = false;
		}

		// Token: 0x0603D4DB RID: 251099 RVA: 0x011B6B54 File Offset: 0x011B4D54
		protected void OnPatrolPauseOrStop(int splineId)
		{
			if (this.IsBehaviorTreeRunning)
			{
				return;
			}
			TimetableConfigData curTimetableData = this.CurTimetableData;
			if (curTimetableData == null || curTimetableData.SplineId != splineId)
			{
				return;
			}
			CharacterPatrolComponent patrolComp = this.PatrolComp;
			this.LastSavedPatrolData = ((patrolComp != null) ? patrolComp.SavePatrolData() : null);
			this.LastSavedPatrolIsAiSpline = false;
		}

		// Token: 0x0603D4DC RID: 251100 RVA: 0x011B6BA4 File Offset: 0x011B4DA4
		protected bool TrySaveTimetableSavedData()
		{
			if (this.CurTimetableData == null)
			{
				return false;
			}
			CharacterPatrolComponent patrolComp = this.PatrolComp;
			this.LastSavedPatrolData = ((patrolComp != null) ? patrolComp.SavePatrolData() : null);
			this.LastSavedPatrolIsAiSpline = this.IsBehaviorTreeRunning;
			CharacterAiComponent aiComp = this.AiComp;
			bool flag;
			if (aiComp == null)
			{
				flag = true;
			}
			else
			{
				UBrainComponent brainComponent = aiComp.TsAiController.BrainComponent;
				flag = !((brainComponent != null) ? new bool?(brainComponent.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return false;
			}
			if (this.CurrentSelectedBTPath != this.AiComp.CurrentAiBehaviorTree)
			{
				return false;
			}
			UBehaviorTreeComponent ubehaviorTreeComponent = this.AiComp.TsAiController.BrainComponent as UBehaviorTreeComponent;
			if (ubehaviorTreeComponent == null)
			{
				return false;
			}
			FBtSaveLoadRecord btRecord = new FBtSaveLoadRecord();
			if (!UKuroAILibrary.SaveBehaviorTreeNodeInfoWithSubtree(ubehaviorTreeComponent, ref btRecord))
			{
				return true;
			}
			TimetableSavedData timetableSavedData = new TimetableSavedData(this.CurTimetableData);
			timetableSavedData.BehaviorTreeData.Path = this.AiComp.CurrentAiBehaviorTree;
			timetableSavedData.BehaviorTreeData.BtRecord = btRecord;
			TimetableSavedData timetableSavedData2 = timetableSavedData;
			PatrolSavedData lastSavedPatrolData = this.LastSavedPatrolData;
			timetableSavedData2.PatrolData = ((lastSavedPatrolData != null) ? lastSavedPatrolData.DeepCopy() : null);
			timetableSavedData.SavedSelectedBTPath = this.CurrentSelectedBTPath;
			this.LastSavedData = timetableSavedData;
			return true;
		}

		// Token: 0x0603D4DD RID: 251101 RVA: 0x011B6CC0 File Offset: 0x011B4EC0
		public bool CanLoadTimetableSavedData()
		{
			if (this.CurTimetableData == null)
			{
				return false;
			}
			CharacterAiComponent aiComp = this.AiComp;
			bool flag;
			if (aiComp == null)
			{
				flag = true;
			}
			else
			{
				UBrainComponent brainComponent = aiComp.TsAiController.BrainComponent;
				flag = !((brainComponent != null) ? new bool?(brainComponent.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return false;
			}
			if (!(this.AiComp.TsAiController.BrainComponent is UBehaviorTreeComponent))
			{
				return false;
			}
			TimetableSavedData timetableSavedData = NpcTimetableController.Instance.GetTimetableSavedData(this.CreatureId);
			return timetableSavedData != null && timetableSavedData.IsValid() && !(timetableSavedData.BehaviorTreeData.Path != this.AiComp.CurrentAiBehaviorTree);
		}

		// Token: 0x0603D4DE RID: 251102 RVA: 0x011B6D74 File Offset: 0x011B4F74
		protected bool TryLoadTimetableSavedData()
		{
			if (!this.CanLoadTimetableSavedData())
			{
				NpcTimetableController.Instance.ClearTimetableSavedData(this.CreatureId, "NoNeedLoad");
				return false;
			}
			TimetableSavedData timetableSavedData = NpcTimetableController.Instance.GetTimetableSavedData(this.CreatureId);
			this.LoadBehaviorSavedData(timetableSavedData.BehaviorTreeData);
			CharacterPatrolComponent patrolComp = this.PatrolComp;
			if (patrolComp != null)
			{
				patrolComp.LoadPatrolData(timetableSavedData.PatrolData);
			}
			return true;
		}

		// Token: 0x0603D4DF RID: 251103 RVA: 0x011B6DD8 File Offset: 0x011B4FD8
		[NullableContext(1)]
		protected void LoadBehaviorSavedData(BehaviorTreeSavedData savedData)
		{
			if (!savedData.IsValid())
			{
				return;
			}
			UBrainComponent brainComponent = this.AiComp.TsAiController.BrainComponent;
			FBtSaveLoadRecordItem fbtSaveLoadRecordItem = savedData.ConsumeRecord();
			UKuroAILibrary.LoadBehaviorTreeNodeInfoFromRecordItem((UBehaviorTreeComponent)brainComponent, fbtSaveLoadRecordItem);
			if (!savedData.IsValid())
			{
				NpcTimetableController.Instance.ClearTimetableSavedData(this.CreatureId, "NoNextRecord");
			}
		}

		// Token: 0x0603D4E0 RID: 251104 RVA: 0x011B6E30 File Offset: 0x011B5030
		protected void SendTimetableSavedDataToExternal()
		{
			if (this.CurTimetableData == null)
			{
				return;
			}
			if (this.LastSavedData != null && this.LastSavedData.TimetableConfig == this.CurTimetableData)
			{
				NpcTimetableController.Instance.SaveTimetableSavedData(this.CreatureId, this.LastSavedData);
			}
			PatrolSavedData lastSavedPatrolData = this.LastSavedPatrolData;
			bool flag;
			if (lastSavedPatrolData == null)
			{
				flag = false;
			}
			else
			{
				int splineId = lastSavedPatrolData.SplineId;
				flag = true;
			}
			if (flag && this.LastSavedPatrolData.State == EPatrolState.PatrolMove)
			{
				long creatureDataId = this.ActorComp.CreatureData.GetCreatureDataId();
				SplinePositionUpdateRequest splinePositionUpdateRequest = SplinePositionUpdateRequest.Create();
				splinePositionUpdateRequest.InstId = GameModeModel.Instance.InstanceDungeon.Value.Id;
				splinePositionUpdateRequest.SplineId = this.LastSavedPatrolData.SplineId;
				splinePositionUpdateRequest.SplineIdx = this.LastSavedPatrolData.PointId;
				splinePositionUpdateRequest.Dir = this.LastSavedPatrolData.Direction;
				splinePositionUpdateRequest.EntityId = MathUtils.Instance.NumberToLong(creatureDataId);
				splinePositionUpdateRequest.SplineType = (this.LastSavedPatrolIsAiSpline ? NpcTimeScheduleSplineType.AiSpline : NpcTimeScheduleSplineType.PathSpline);
				Net.Instance.Call(ERequestMessageId.SplinePositionUpdateRequest, splinePositionUpdateRequest, null, 0);
			}
		}

		// Token: 0x0603D4E1 RID: 251105 RVA: 0x011B6F40 File Offset: 0x011B5140
		[NullableContext(1)]
		public void SwitchTimetable(TimetableConfigData timetableData, string reason = "", bool bDelay = false)
		{
			TimerHandle delaySwitchHandle = this.DelaySwitchHandle;
			if (delaySwitchHandle != null)
			{
				delaySwitchHandle.Remove();
			}
			this.DelaySwitchHandle = null;
			float max = bDelay ? NpcTimetableController.Instance.GetMaxDelaySwitchTime() : 0f;
			float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(0f, max);
			if (randomFloatNumber < 20f)
			{
				this.SwitchTimetableInternal(timetableData);
				return;
			}
			this.DelaySwitchHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.DelaySwitchHandle = null;
				this.SwitchTimetableInternal(timetableData);
			}, randomFloatNumber, null, null, true, 1f);
		}

		// Token: 0x0603D4E2 RID: 251106 RVA: 0x011B6FDC File Offset: 0x011B51DC
		[NullableContext(1)]
		protected void SwitchTimetableInternal(TimetableConfigData timetableData)
		{
			this.CurTimetableData = timetableData;
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnNpcSwitchTimetable);
			string selectedBTPath = timetableData.BehaviorTreePath;
			bool selectCommonBT = false;
			string text = BehaviorTreeDefines.TryGetBtPathFromOverrideConfig(timetableData.CommonBtOverride);
			if (!string.IsNullOrEmpty(text))
			{
				selectedBTPath = text;
				selectCommonBT = true;
			}
			this.CurrentSelectedBTPath = selectedBTPath;
			TimetableSavedData timetableSavedData = NpcTimetableController.Instance.GetTimetableSavedData(this.CreatureId);
			if (timetableData.SplineId == 0 || ((timetableSavedData != null) ? timetableSavedData.BehaviorTreeData.Path : null) == selectedBTPath)
			{
				if (selectCommonBT)
				{
					CharacterAiComponent aiComp = this.AiComp;
					if (aiComp != null)
					{
						aiComp.ChangeAiBehaviorTreeByCommonBt(timetableData.CommonBtOverride);
					}
				}
				else
				{
					CharacterAiComponent aiComp2 = this.AiComp;
					if (aiComp2 != null)
					{
						aiComp2.ChangeAiBehaviorTree(selectedBTPath);
					}
				}
				CharacterAiComponent aiComp3 = this.AiComp;
				if (aiComp3 == null)
				{
					return;
				}
				aiComp3.TrySetLevelAiController();
				return;
			}
			else
			{
				CharacterAiComponent aiComp4 = this.AiComp;
				if (aiComp4 != null)
				{
					aiComp4.DisableAi("NpcTimetableComp.SwitchTimetable");
				}
				Action<ELevelEventState> onPatrolEndHandle = delegate(ELevelEventState result)
				{
					CharacterAiComponent aiComp5 = this.AiComp;
					if (aiComp5 != null)
					{
						aiComp5.EnableAi("NpcTimetableComp.SwitchTimetable");
					}
					if (result != ELevelEventState.Success)
					{
						return;
					}
					if (selectCommonBT)
					{
						CharacterAiComponent aiComp6 = this.AiComp;
						if (aiComp6 != null)
						{
							aiComp6.ChangeAiBehaviorTreeByCommonBt(timetableData.CommonBtOverride);
						}
					}
					else
					{
						CharacterAiComponent aiComp7 = this.AiComp;
						if (aiComp7 != null)
						{
							aiComp7.ChangeAiBehaviorTree(selectedBTPath);
						}
					}
					CharacterAiComponent aiComp8 = this.AiComp;
					if (aiComp8 == null)
					{
						return;
					}
					aiComp8.TrySetLevelAiController();
				};
				IStartMoveParams param = new IStartMoveParams
				{
					SplineId = timetableData.SplineId,
					Context = "SwitchTimetable",
					DebugMode = new bool?(false),
					StartMode = new EPatrolStartMode?(EPatrolStartMode.NearestPoint),
					ReturnFalseWhenNavigationFailed = new bool?(false),
					OnPatrolEndHandle = onPatrolEndHandle
				};
				BasePerformComponent performComp = this.PerformComp;
				if (performComp == null)
				{
					return;
				}
				performComp.PerformStartMove(EPerformMode.Ecology, param, null, null);
				return;
			}
		}

		// Token: 0x0603D4E3 RID: 251107 RVA: 0x011B717C File Offset: 0x011B537C
		[NullableContext(1)]
		public void StopTimetable(string reason = "", bool bDelay = false)
		{
			if (this.CurTimetableData == null)
			{
				return;
			}
			TimerHandle delaySwitchHandle = this.DelaySwitchHandle;
			if (delaySwitchHandle != null)
			{
				delaySwitchHandle.Remove();
			}
			this.DelaySwitchHandle = null;
			float max = bDelay ? NpcTimetableController.Instance.GetMaxDelaySwitchTime() : 0f;
			float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(0f, max);
			if (randomFloatNumber < 20f)
			{
				this.StopTimetableInternal();
				return;
			}
			this.DelaySwitchHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.DelaySwitchHandle = null;
				this.StopTimetableInternal();
			}, randomFloatNumber, null, null, true, 1f);
		}

		// Token: 0x0603D4E4 RID: 251108 RVA: 0x011B7208 File Offset: 0x011B5408
		private unsafe void StopTimetableInternal()
		{
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnNpcStopTimetable);
			TimetableConfigData curTimetableData = this.CurTimetableData;
			int splineId = (curTimetableData != null) ? curTimetableData.SplineId : 0;
			this.CurTimetableData = null;
			this.CurrentSelectedBTPath = "";
			BasePerformComponent performComp = this.PerformComp;
			if (performComp != null)
			{
				performComp.PerformStopMove(EPerformMode.Ecology, new IStopMoveParams
				{
					SplineId = splineId,
					Context = "StopTimetable"
				}, null, null);
			}
			CharacterAiComponent aiComp = this.AiComp;
			if (aiComp != null)
			{
				aiComp.EnableAi("NpcTimetableComp.SwitchTimetable");
			}
			CharacterAiComponent aiComp2 = this.AiComp;
			if (aiComp2 != null && !aiComp2.TrySetLevelAIBehaviorTree())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.YY;
				string message = "[NpcTimetable] 回退Levelai失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId";
				CharacterActorComponent actorComp = this.ActorComp;
				ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityID", base.Entity.Id);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0603D4E5 RID: 251109 RVA: 0x011B7338 File Offset: 0x011B5538
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			NpcTimetableComponent npcTimetableComponent = (NpcTimetableComponent)componentTemplate;
			if (npcTimetableComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (npcTimetableComponent.AiComp == null)
			{
				this.AiComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AiComp), "AiComp"))
			{
				return false;
			}
			if (npcTimetableComponent.PatrolComp == null)
			{
				this.PatrolComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PatrolComp), "PatrolComp"))
			{
				return false;
			}
			if (npcTimetableComponent.PerformComp == null)
			{
				this.PerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerformComp), "PerformComp"))
			{
				return false;
			}
			this.IsEventAdded = npcTimetableComponent.IsEventAdded;
			this.CreatureId = npcTimetableComponent.CreatureId;
			this.IsBehaviorTreeRunning = npcTimetableComponent.IsBehaviorTreeRunning;
			if (npcTimetableComponent.CurTimetableData == null)
			{
				this.CurTimetableData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurTimetableData), "CurTimetableData"))
			{
				return false;
			}
			this.CurrentSelectedBTPath = npcTimetableComponent.CurrentSelectedBTPath;
			if (npcTimetableComponent.DelaySwitchHandle == null)
			{
				this.DelaySwitchHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DelaySwitchHandle), "DelaySwitchHandle"))
			{
				return false;
			}
			if (npcTimetableComponent.LastSavedData == null)
			{
				this.LastSavedData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSavedData), "LastSavedData"))
			{
				return false;
			}
			if (npcTimetableComponent.LastSavedPatrolData == null)
			{
				this.LastSavedPatrolData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSavedPatrolData), "LastSavedPatrolData"))
			{
				return false;
			}
			this.LastSavedPatrolIsAiSpline = npcTimetableComponent.LastSavedPatrolIsAiSpline;
			return true;
		}

		// Token: 0x17007409 RID: 29705
		// (get) Token: 0x0603D4E6 RID: 251110 RVA: 0x011B74EC File Offset: 0x011B56EC
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700740A RID: 29706
		// (get) Token: 0x0603D4E7 RID: 251111 RVA: 0x011B74EF File Offset: 0x011B56EF
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700740B RID: 29707
		// (get) Token: 0x0603D4E8 RID: 251112 RVA: 0x011B74F2 File Offset: 0x011B56F2
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020842 RID: 133186
		protected CharacterActorComponent ActorComp;

		// Token: 0x04020843 RID: 133187
		protected CharacterAiComponent AiComp;

		// Token: 0x04020844 RID: 133188
		protected CharacterPatrolComponent PatrolComp;

		// Token: 0x04020845 RID: 133189
		protected BasePerformComponent PerformComp;

		// Token: 0x04020846 RID: 133190
		protected bool IsEventAdded;

		// Token: 0x04020847 RID: 133191
		protected long CreatureId;

		// Token: 0x04020848 RID: 133192
		protected bool IsBehaviorTreeRunning;

		// Token: 0x04020849 RID: 133193
		protected TimetableConfigData CurTimetableData;

		// Token: 0x0402084A RID: 133194
		[Nullable(1)]
		protected string CurrentSelectedBTPath = "";

		// Token: 0x0402084B RID: 133195
		protected TimerHandle DelaySwitchHandle;

		// Token: 0x0402084C RID: 133196
		protected TimetableSavedData LastSavedData;

		// Token: 0x0402084D RID: 133197
		protected PatrolSavedData LastSavedPatrolData;

		// Token: 0x0402084E RID: 133198
		protected bool LastSavedPatrolIsAiSpline;
	}
}
