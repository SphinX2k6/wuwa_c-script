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
	// Token: 0x0200709C RID: 28828
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcTimetableComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009C26 RID: 39974
		// (get) Token: 0x060463E5 RID: 287717 RVA: 0x01193605 File Offset: 0x01191805
		[Nullable(1)]
		public static Type[] Dependencies
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

		// Token: 0x060463E6 RID: 287718 RVA: 0x01193628 File Offset: 0x01191828
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			this.CreatureId = component.GetCreatureDataId();
			return true;
		}

		// Token: 0x060463E7 RID: 287719 RVA: 0x01193650 File Offset: 0x01191850
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
			this.AiComp = base.Entity.CheckGetComponent<CharacterAiComponent>();
			this.PatrolComp = base.Entity.GetComponent<CharacterPatrolComponent>();
			this.PerformComp = base.Entity.GetComponent<BasePerformComponent>();
			this.AddEvents();
			return true;
		}

		// Token: 0x060463E8 RID: 287720 RVA: 0x011936A8 File Offset: 0x011918A8
		protected override void OnActivate()
		{
			TimetableConfigData timeScheduleByCreatureId = NpcTimetableController.Instance.GetTimeScheduleByCreatureId(this.CreatureId);
			if (timeScheduleByCreatureId == null)
			{
				return;
			}
			this.SwitchTimetable(timeScheduleByCreatureId, "Activate", false);
		}

		// Token: 0x060463E9 RID: 287721 RVA: 0x011936D7 File Offset: 0x011918D7
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

		// Token: 0x060463EA RID: 287722 RVA: 0x01193700 File Offset: 0x01191900
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

		// Token: 0x060463EB RID: 287723 RVA: 0x0119380C File Offset: 0x01191A0C
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

		// Token: 0x060463EC RID: 287724 RVA: 0x01193918 File Offset: 0x01191B18
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

		// Token: 0x060463ED RID: 287725 RVA: 0x01193A0F File Offset: 0x01191C0F
		protected void OnBeforeAiDisable()
		{
			this.TrySaveTimetableSavedData();
			this.IsBehaviorTreeRunning = false;
		}

		// Token: 0x060463EE RID: 287726 RVA: 0x01193A1F File Offset: 0x01191C1F
		protected void OnAiEnable()
		{
			this.LastSavedData = null;
			this.IsBehaviorTreeRunning = true;
		}

		// Token: 0x060463EF RID: 287727 RVA: 0x01193A2F File Offset: 0x01191C2F
		protected void OnPatrolStartOrResume(int splineId)
		{
			if (this.IsBehaviorTreeRunning)
			{
				return;
			}
			this.LastSavedPatrolData = null;
			this.LastSavedPatrolIsAiSpline = false;
		}

		// Token: 0x060463F0 RID: 287728 RVA: 0x01193A48 File Offset: 0x01191C48
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

		// Token: 0x060463F1 RID: 287729 RVA: 0x01193A98 File Offset: 0x01191C98
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

		// Token: 0x060463F2 RID: 287730 RVA: 0x01193BB4 File Offset: 0x01191DB4
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

		// Token: 0x060463F3 RID: 287731 RVA: 0x01193C68 File Offset: 0x01191E68
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

		// Token: 0x060463F4 RID: 287732 RVA: 0x01193CCC File Offset: 0x01191ECC
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

		// Token: 0x060463F5 RID: 287733 RVA: 0x01193D24 File Offset: 0x01191F24
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

		// Token: 0x060463F6 RID: 287734 RVA: 0x01193E34 File Offset: 0x01192034
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

		// Token: 0x060463F7 RID: 287735 RVA: 0x01193ED0 File Offset: 0x011920D0
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

		// Token: 0x060463F8 RID: 287736 RVA: 0x01194070 File Offset: 0x01192270
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

		// Token: 0x060463F9 RID: 287737 RVA: 0x011940FC File Offset: 0x011922FC
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

		// Token: 0x060463FA RID: 287738 RVA: 0x0119422C File Offset: 0x0119242C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			NpcTimetableComponent npcTimetableComponent = (NpcTimetableComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (npcTimetableComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AiComp"))
			{
				if (npcTimetableComponent.AiComp == null)
				{
					this.AiComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAiComponent>(this.AiComp), "AiComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PatrolComp"))
			{
				if (npcTimetableComponent.PatrolComp == null)
				{
					this.PatrolComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterPatrolComponent>(this.PatrolComp), "PatrolComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PerformComp"))
			{
				if (npcTimetableComponent.PerformComp == null)
				{
					this.PerformComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BasePerformComponent>(this.PerformComp), "PerformComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsEventAdded"))
			{
				this.IsEventAdded = npcTimetableComponent.IsEventAdded;
			}
			if (base.CanResetComponentProperty("CreatureId"))
			{
				this.CreatureId = npcTimetableComponent.CreatureId;
			}
			if (base.CanResetComponentProperty("IsBehaviorTreeRunning"))
			{
				this.IsBehaviorTreeRunning = npcTimetableComponent.IsBehaviorTreeRunning;
			}
			if (base.CanResetComponentProperty("CurTimetableData"))
			{
				if (npcTimetableComponent.CurTimetableData == null)
				{
					this.CurTimetableData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimetableConfigData>(this.CurTimetableData), "CurTimetableData"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentSelectedBTPath"))
			{
				this.CurrentSelectedBTPath = npcTimetableComponent.CurrentSelectedBTPath;
			}
			if (base.CanResetComponentProperty("DelaySwitchHandle"))
			{
				if (npcTimetableComponent.DelaySwitchHandle == null)
				{
					this.DelaySwitchHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.DelaySwitchHandle), "DelaySwitchHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastSavedData"))
			{
				if (npcTimetableComponent.LastSavedData == null)
				{
					this.LastSavedData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimetableSavedData>(this.LastSavedData), "LastSavedData"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastSavedPatrolData"))
			{
				if (npcTimetableComponent.LastSavedPatrolData == null)
				{
					this.LastSavedPatrolData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PatrolSavedData>(this.LastSavedPatrolData), "LastSavedPatrolData"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastSavedPatrolIsAiSpline"))
			{
				this.LastSavedPatrolIsAiSpline = npcTimetableComponent.LastSavedPatrolIsAiSpline;
			}
			return true;
		}

		// Token: 0x04024CF0 RID: 150768
		protected CharacterActorComponent ActorComp;

		// Token: 0x04024CF1 RID: 150769
		protected CharacterAiComponent AiComp;

		// Token: 0x04024CF2 RID: 150770
		protected CharacterPatrolComponent PatrolComp;

		// Token: 0x04024CF3 RID: 150771
		protected BasePerformComponent PerformComp;

		// Token: 0x04024CF4 RID: 150772
		protected bool IsEventAdded;

		// Token: 0x04024CF5 RID: 150773
		protected long CreatureId;

		// Token: 0x04024CF6 RID: 150774
		protected bool IsBehaviorTreeRunning;

		// Token: 0x04024CF7 RID: 150775
		protected TimetableConfigData CurTimetableData;

		// Token: 0x04024CF8 RID: 150776
		[Nullable(1)]
		protected string CurrentSelectedBTPath = "";

		// Token: 0x04024CF9 RID: 150777
		protected TimerHandle DelaySwitchHandle;

		// Token: 0x04024CFA RID: 150778
		protected TimetableSavedData LastSavedData;

		// Token: 0x04024CFB RID: 150779
		protected PatrolSavedData LastSavedPatrolData;

		// Token: 0x04024CFC RID: 150780
		protected bool LastSavedPatrolIsAiSpline;
	}
}
