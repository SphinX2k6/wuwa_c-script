using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D7E RID: 23934
	[NullableContext(2)]
	[Nullable(0)]
	public class MissionViewItem : BattleChildView
	{
		// Token: 0x17008E51 RID: 36433
		// (get) Token: 0x0603CBFB RID: 248827 RVA: 0x00E95798 File Offset: 0x00E93998
		public long? ShowDataId
		{
			get
			{
				IMissionItemViewShowData showData = this.ShowData;
				if (showData == null)
				{
					return null;
				}
				return new long?(showData.Id);
			}
		}

		// Token: 0x17008E52 RID: 36434
		// (get) Token: 0x0603CBFC RID: 248828 RVA: 0x00E957C3 File Offset: 0x00E939C3
		public IMissionItemViewShowData ShowData
		{
			get
			{
				return BattleUiModel.Instance.GetMissionViewData(this.ViewType);
			}
		}

		// Token: 0x0603CBFD RID: 248829 RVA: 0x00E957D8 File Offset: 0x00E939D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnShortcutKeyClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603CBFE RID: 248830 RVA: 0x00E959CC File Offset: 0x00E93BCC
		protected override UniTask OnBeforeStartAsync()
		{
			MissionViewItem.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionViewItem.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CBFF RID: 248831 RVA: 0x00E95A0F File Offset: 0x00E93C0F
		private void InitController()
		{
			this.ShortcutKeyController.Init(this, this.ViewType, base.GetItem(11), base.GetSprite(10), base.GetText(2));
		}

		// Token: 0x0603CC00 RID: 248832 RVA: 0x00E95A3C File Offset: 0x00E93C3C
		private void InitRegistryComponentsState()
		{
			base.GetText(2).SetAlpha(1f);
			base.GetItem(1).SetUIActive(false);
			this.ProcessItem = base.GetItem(5);
			this.ProcessItem.SetUIActive(true);
			this.CompleteItem = base.GetItem(4);
			this.CompleteItem.SetUIActive(false);
			base.GetUiNiagara(7).SetNiagaraUIActive(true, false);
		}

		// Token: 0x0603CC01 RID: 248833 RVA: 0x00E95AA8 File Offset: 0x00E93CA8
		private UniTask InitMissionPanelStep()
		{
			MissionViewItem.<InitMissionPanelStep>d__28 <InitMissionPanelStep>d__;
			<InitMissionPanelStep>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMissionPanelStep>d__.<>4__this = this;
			<InitMissionPanelStep>d__.<>1__state = -1;
			<InitMissionPanelStep>d__.<>t__builder.Start<MissionViewItem.<InitMissionPanelStep>d__28>(ref <InitMissionPanelStep>d__);
			return <InitMissionPanelStep>d__.<>t__builder.Task;
		}

		// Token: 0x0603CC02 RID: 248834 RVA: 0x00E95AEC File Offset: 0x00E93CEC
		private UniTask InitFishingEntrustNavigation()
		{
			MissionViewItem.<InitFishingEntrustNavigation>d__29 <InitFishingEntrustNavigation>d__;
			<InitFishingEntrustNavigation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingEntrustNavigation>d__.<>4__this = this;
			<InitFishingEntrustNavigation>d__.<>1__state = -1;
			<InitFishingEntrustNavigation>d__.<>t__builder.Start<MissionViewItem.<InitFishingEntrustNavigation>d__29>(ref <InitFishingEntrustNavigation>d__);
			return <InitFishingEntrustNavigation>d__.<>t__builder.Task;
		}

		// Token: 0x0603CC03 RID: 248835 RVA: 0x00E95B30 File Offset: 0x00E93D30
		protected override void OnStart()
		{
			base.GetText(6).OnSelfLanguageChange.Bind(new Action(this.SetCompleteQuestName));
			base.GetText(8).OnSelfLanguageChange.Bind(new Action(this.UpdateTotalTitleText_ForBind));
			this.TotalTitleSequencePlayer = new LevelSequencePlayer(this.ProcessItem);
			this.TotalTitleSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnTotalTitleSequenceClose), false);
			this.QuestFinishSequencePlayer = new LevelSequencePlayer(this.CompleteItem);
			this.QuestFinishSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnFinishSequenceClose), false);
		}

		// Token: 0x0603CC04 RID: 248836 RVA: 0x00E95BCC File Offset: 0x00E93DCC
		protected override void OnBeforeDestroy()
		{
			this.ShortcutKeyController.Dispose();
			MissionPanelStep missionPanelStep = this.MissionPanelStep;
			if (missionPanelStep != null)
			{
				missionPanelStep.Destroy(null);
			}
			this.FishingEntrustNavigationItem.Destroy(null);
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			LevelSequencePlayer totalTitleSequencePlayer = this.TotalTitleSequencePlayer;
			if (totalTitleSequencePlayer != null)
			{
				totalTitleSequencePlayer.Clear();
			}
			this.TotalTitleSequencePlayer = null;
		}

		// Token: 0x0603CC05 RID: 248837 RVA: 0x00E95C30 File Offset: 0x00E93E30
		public void OnPanelShow()
		{
			this.IsPanelShow = true;
			this.AddEvents();
			this.QuestFinishSequencePlayer.ResumeSequence();
			this.TotalTitleSequencePlayer.ResumeSequence();
			this.MissionPanelStepVisibleProcessQueue.Push(MissionViewItem.EProcessType.Show);
			this.ShortcutKeyController.OnPanelShow();
			this.UpdateTotalTitleText();
		}

		// Token: 0x0603CC06 RID: 248838 RVA: 0x00E95C7E File Offset: 0x00E93E7E
		public void OnPanelHide()
		{
			this.IsPanelShow = false;
			this.RemoveEvents();
			this.QuestFinishSequencePlayer.PauseSequence();
			this.TotalTitleSequencePlayer.PauseSequence();
			this.MissionPanelStepVisibleProcessQueue.Push(MissionViewItem.EProcessType.Hide);
			this.ShortcutKeyController.OnPanelHide();
		}

		// Token: 0x0603CC07 RID: 248839 RVA: 0x00E95CBC File Offset: 0x00E93EBC
		private void ProcessMissionPanelStepVisibleProcess()
		{
			if (this.MissionPanelStepVisibleProcessQueue.Empty)
			{
				return;
			}
			MissionViewItem.EProcessType eprocessType = this.MissionPanelStepVisibleProcessQueue.Pop();
			if (eprocessType != MissionViewItem.EProcessType.Show)
			{
				if (eprocessType != MissionViewItem.EProcessType.Hide)
				{
					return;
				}
				this.LastStepShowState = this.MissionPanelStep.IsShowOrShowing;
				this.MissionPanelStep.Hide(null);
			}
			else if (this.LastStepShowState)
			{
				MissionPanelStep missionPanelStep = this.MissionPanelStep;
				if (missionPanelStep == null)
				{
					return;
				}
				missionPanelStep.Show(null);
				return;
			}
		}

		// Token: 0x0603CC08 RID: 248840 RVA: 0x00E95D24 File Offset: 0x00E93F24
		private void AddEvents()
		{
			EventSystem.Instance.Add<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.OnLogicTreeChildQuestNodeStatusChange));
			EventSystem.Instance.Add<GeneralContext, ChildQuestNodeProgress>(EEventName.OnLogicTreeNodeProgressChange, new Action<GeneralContext, ChildQuestNodeProgress>(this.OnNodeProgressChanged));
			EventSystem.Instance.Add<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnLogicTreeNodeStatusChange));
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeAddTag, new Action<EBehaviorTreeTag>(this.OnGeneralLogicTreeCommunicateTagChange));
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeRemoveTag, new Action<EBehaviorTreeTag>(this.OnGeneralLogicTreeCommunicateTagChange));
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnForceRefresh));
			EventSystem.Instance.Add(EEventName.MissionPanelStepTitleAnimStart, new Action<long>(this.OnMissionPanelStepTitleAnimStart));
			EventSystem.Instance.Add(EEventName.MissionPanelStepTitleAnimEnd, new Action<long>(this.OnMissionPanelStepTitleAnimEnd));
			EventSystem.Instance.Add(EEventName.OnQuestStageNameChange, new Action<int>(this.OnQuestStageNameChange));
			if (!Info.Instance.IsInTouch())
			{
				EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.ShortcutKeyController.UpdateShortcutButton));
			}
		}

		// Token: 0x0603CC09 RID: 248841 RVA: 0x00E95E5C File Offset: 0x00E9405C
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.OnLogicTreeChildQuestNodeStatusChange));
			EventSystem.Instance.Remove(EEventName.OnLogicTreeNodeProgressChange, new Action<GeneralContext, ChildQuestNodeProgress>(this.OnNodeProgressChanged));
			EventSystem.Instance.Remove(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnLogicTreeNodeStatusChange));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeAddTag, new Action<EBehaviorTreeTag>(this.OnGeneralLogicTreeCommunicateTagChange));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeRemoveTag, new Action<EBehaviorTreeTag>(this.OnGeneralLogicTreeCommunicateTagChange));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnForceRefresh));
			EventSystem.Instance.Remove(EEventName.MissionPanelStepTitleAnimStart, new Action<long>(this.OnMissionPanelStepTitleAnimStart));
			EventSystem.Instance.Remove(EEventName.MissionPanelStepTitleAnimEnd, new Action<long>(this.OnMissionPanelStepTitleAnimEnd));
			EventSystem.Instance.Remove(EEventName.OnQuestStageNameChange, new Action<int>(this.OnQuestStageNameChange));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.ShortcutKeyController.UpdateShortcutButton));
		}

		// Token: 0x0603CC0A RID: 248842 RVA: 0x00E95F86 File Offset: 0x00E94186
		private void OnShortcutKeyClick()
		{
			this.ShortcutKeyController.OnShortcutKeyClick();
		}

		// Token: 0x0603CC0B RID: 248843 RVA: 0x00E95F93 File Offset: 0x00E94193
		[NullableContext(1)]
		private void OnLogicTreeChildQuestNodeStatusChange(GeneralContext context, ChildQuestNodeStatus _2, ChildQuestNodeStatus _3, ENodeStatusUpdateReason _4)
		{
			this.OnChildQuestNodeStatusChanged(context);
		}

		// Token: 0x0603CC0C RID: 248844 RVA: 0x00E95F9C File Offset: 0x00E9419C
		[NullableContext(1)]
		private void OnLogicTreeNodeStatusChange(GeneralContext context, NodeStatus _2, NodeStatus _3, ENodeStatusUpdateReason _4)
		{
			this.OnChildQuestNodeStatusChanged(context);
		}

		// Token: 0x0603CC0D RID: 248845 RVA: 0x00E95FA8 File Offset: 0x00E941A8
		[NullableContext(1)]
		private void OnChildQuestNodeStatusChanged(GeneralContext context)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext != null)
			{
				long treeIncId = generalLogicTreeContext.TreeIncId;
				long? showDataId = this.ShowDataId;
				if (treeIncId == showDataId.GetValueOrDefault() & showDataId != null)
				{
					this.ShortcutKeyController.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
					return;
				}
			}
		}

		// Token: 0x0603CC0E RID: 248846 RVA: 0x00E95FF0 File Offset: 0x00E941F0
		[NullableContext(1)]
		private void OnNodeProgressChanged(GeneralContext context, ChildQuestNodeProgress progress)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext != null)
			{
				long treeIncId = generalLogicTreeContext.TreeIncId;
				long? showDataId = this.ShowDataId;
				if (treeIncId == showDataId.GetValueOrDefault() & showDataId != null)
				{
					if (this.CurProcessId != 0)
					{
						return;
					}
					this.OnTickImp(0);
					return;
				}
			}
		}

		// Token: 0x0603CC0F RID: 248847 RVA: 0x00E96038 File Offset: 0x00E94238
		private void OnGeneralLogicTreeCommunicateTagChange(EBehaviorTreeTag tag)
		{
			if (tag != EBehaviorTreeTag.CanCommunicateAgain)
			{
				return;
			}
			this.ShortcutKeyController.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
		}

		// Token: 0x0603CC10 RID: 248848 RVA: 0x00E9604C File Offset: 0x00E9424C
		private void OnMissionPanelStepTitleAnimStart(long id)
		{
			long? showDataId = this.ShowDataId;
			if (!(showDataId.GetValueOrDefault() == id & showDataId != null))
			{
				return;
			}
			if (base.GetText(8).IsUIActiveSelf())
			{
				return;
			}
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0603CC11 RID: 248849 RVA: 0x00E96098 File Offset: 0x00E94298
		private void OnMissionPanelStepTitleAnimEnd(long id)
		{
			long? showDataId = this.ShowDataId;
			if (!(showDataId.GetValueOrDefault() == id & showDataId != null))
			{
				return;
			}
			if (base.GetText(8).IsUIActiveSelf())
			{
				return;
			}
			this.SetIcon();
		}

		// Token: 0x0603CC12 RID: 248850 RVA: 0x00E960D8 File Offset: 0x00E942D8
		[NullableContext(1)]
		private void OnTotalTitleSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				CustomPromise<bool> totalSequenceStartPromise = this.TotalSequenceStartPromise;
				if (totalSequenceStartPromise != null && totalSequenceStartPromise.IsPending)
				{
					this.TotalSequenceStartPromise.SetResult(true);
					return;
				}
			}
			else if (sequenceName == "Close")
			{
				CustomPromise<bool> totalSequenceClosePromise = this.TotalSequenceClosePromise;
				if (totalSequenceClosePromise != null && totalSequenceClosePromise.IsPending)
				{
					this.TotalSequenceClosePromise.SetResult(true);
				}
			}
		}

		// Token: 0x0603CC13 RID: 248851 RVA: 0x00E96140 File Offset: 0x00E94340
		[NullableContext(1)]
		private void OnFinishSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				CustomPromise<bool> questFinishStartPromise = this.QuestFinishStartPromise;
				if (questFinishStartPromise != null && questFinishStartPromise.IsPending)
				{
					this.QuestFinishStartPromise.SetResult(true);
					return;
				}
			}
			else if (sequenceName == "Close")
			{
				CustomPromise<bool> questFinishClosePromise = this.QuestFinishClosePromise;
				if (questFinishClosePromise != null && questFinishClosePromise.IsPending)
				{
					this.QuestFinishClosePromise.SetResult(true);
				}
			}
		}

		// Token: 0x0603CC14 RID: 248852 RVA: 0x00E961A8 File Offset: 0x00E943A8
		[NullableContext(1)]
		private void UpdateSelfData(IMissionItemViewShowData showData)
		{
			this.SetShowData(showData);
			this.SetIcon();
			this.ShortcutKeyController.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
		}

		// Token: 0x0603CC15 RID: 248853 RVA: 0x00E961C4 File Offset: 0x00E943C4
		private void SetShowData(IMissionItemViewShowData showData = null)
		{
			BattleUiModel.Instance.SetMissionViewData(this.ViewType, showData);
		}

		// Token: 0x0603CC16 RID: 248854 RVA: 0x00E961D8 File Offset: 0x00E943D8
		private void SetIcon()
		{
			if (this.ShowData == null)
			{
				return;
			}
			int trackIconConfigId = this.ShowData.TrackIconConfigId;
			if (trackIconConfigId == 0)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(0);
			if (MissionViewStepTextUtil.CheckShowConfigEmpty(this.ShowData))
			{
				sprite.SetUIActive(false);
				return;
			}
			sprite.SetUIActive(true);
			this.SetSpriteByPath(QuestNewConfig.Instance.GetQuestTypeMark(trackIconConfigId), sprite, false, null, null);
		}

		// Token: 0x0603CC17 RID: 248855 RVA: 0x00E96240 File Offset: 0x00E94440
		[NullableContext(0)]
		public UniTask<bool> StartShow(int processId, [Nullable(1)] IMissionItemViewShowData showData, bool bSkipAnim)
		{
			MissionViewItem.<StartShow>d__50 <StartShow>d__;
			<StartShow>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartShow>d__.<>4__this = this;
			<StartShow>d__.processId = processId;
			<StartShow>d__.showData = showData;
			<StartShow>d__.bSkipAnim = bSkipAnim;
			<StartShow>d__.<>1__state = -1;
			<StartShow>d__.<>t__builder.Start<MissionViewItem.<StartShow>d__50>(ref <StartShow>d__);
			return <StartShow>d__.<>t__builder.Task;
		}

		// Token: 0x0603CC18 RID: 248856 RVA: 0x00E9629C File Offset: 0x00E9449C
		[NullableContext(0)]
		public UniTask<bool> OnLogicTreeUpdateShow(int processId, [Nullable(1)] IMissionItemViewShowData showData, bool bSkipAnim)
		{
			MissionViewItem.<OnLogicTreeUpdateShow>d__51 <OnLogicTreeUpdateShow>d__;
			<OnLogicTreeUpdateShow>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnLogicTreeUpdateShow>d__.<>4__this = this;
			<OnLogicTreeUpdateShow>d__.processId = processId;
			<OnLogicTreeUpdateShow>d__.showData = showData;
			<OnLogicTreeUpdateShow>d__.bSkipAnim = bSkipAnim;
			<OnLogicTreeUpdateShow>d__.<>1__state = -1;
			<OnLogicTreeUpdateShow>d__.<>t__builder.Start<MissionViewItem.<OnLogicTreeUpdateShow>d__51>(ref <OnLogicTreeUpdateShow>d__);
			return <OnLogicTreeUpdateShow>d__.<>t__builder.Task;
		}

		// Token: 0x0603CC19 RID: 248857 RVA: 0x00E962F8 File Offset: 0x00E944F8
		[NullableContext(0)]
		public UniTask<bool> EndShow(int processId, bool bSkipAnim, ETreeTextExpressReason? reason = null)
		{
			MissionViewItem.<EndShow>d__52 <EndShow>d__;
			<EndShow>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EndShow>d__.<>4__this = this;
			<EndShow>d__.processId = processId;
			<EndShow>d__.bSkipAnim = bSkipAnim;
			<EndShow>d__.reason = reason;
			<EndShow>d__.<>1__state = -1;
			<EndShow>d__.<>t__builder.Start<MissionViewItem.<EndShow>d__52>(ref <EndShow>d__);
			return <EndShow>d__.<>t__builder.Task;
		}

		// Token: 0x0603CC1A RID: 248858 RVA: 0x00E96354 File Offset: 0x00E94554
		public UniTask ChildStepConditionIndexChange(int stepId, int? curConditionTextIndex)
		{
			MissionViewItem.<ChildStepConditionIndexChange>d__53 <ChildStepConditionIndexChange>d__;
			<ChildStepConditionIndexChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChildStepConditionIndexChange>d__.<>4__this = this;
			<ChildStepConditionIndexChange>d__.stepId = stepId;
			<ChildStepConditionIndexChange>d__.curConditionTextIndex = curConditionTextIndex;
			<ChildStepConditionIndexChange>d__.<>1__state = -1;
			<ChildStepConditionIndexChange>d__.<>t__builder.Start<MissionViewItem.<ChildStepConditionIndexChange>d__53>(ref <ChildStepConditionIndexChange>d__);
			return <ChildStepConditionIndexChange>d__.<>t__builder.Task;
		}

		// Token: 0x0603CC1B RID: 248859 RVA: 0x00E963A7 File Offset: 0x00E945A7
		private void OnQuestStageNameChange(int questId)
		{
			this.UpdateTotalTitleText();
		}

		// Token: 0x0603CC1C RID: 248860 RVA: 0x00E963B0 File Offset: 0x00E945B0
		private void UpdateTotalTitleText_ForBind()
		{
			this.UpdateTotalTitleText();
		}

		// Token: 0x0603CC1D RID: 248861 RVA: 0x00E963BC File Offset: 0x00E945BC
		private bool UpdateTotalTitleText()
		{
			UUIText text = base.GetText(8);
			UUIItem item = base.GetItem(9);
			string totalTitleText = this.GetTotalTitleText();
			text.SetText(totalTitleText, true);
			if (string.IsNullOrEmpty(totalTitleText))
			{
				text.SetUIActive(false);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				return false;
			}
			text.SetUIActive(true);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			return true;
		}

		// Token: 0x0603CC1E RID: 248862 RVA: 0x00E96416 File Offset: 0x00E94616
		[NullableContext(1)]
		private string GetTotalTitleText()
		{
			if (this.ShowData == null || string.IsNullOrEmpty(this.ShowData.TitleTextKey))
			{
				return string.Empty;
			}
			return PublicUtil.Instance.GetConfigTextByKey(this.ShowData.TitleTextKey);
		}

		// Token: 0x0603CC1F RID: 248863 RVA: 0x00E96450 File Offset: 0x00E94650
		public void OnRefresh(float delta, int curProcessId)
		{
			this.ProcessMissionPanelStepVisibleProcess();
			if (!this.IsPanelShow)
			{
				return;
			}
			this.MissionPanelStep.OnTick(delta);
			if (this.CurTickTime > 1000f)
			{
				this.CurTickTime -= 1000f;
				this.OnTickImp(curProcessId);
			}
			this.CurTickTime += delta;
		}

		// Token: 0x0603CC20 RID: 248864 RVA: 0x00E964AC File Offset: 0x00E946AC
		private void OnTickImp(int curProcessId)
		{
			if (curProcessId != 0 && curProcessId == this.CurProcessId)
			{
				return;
			}
			if (!this.CheckVisible())
			{
				UUIItem processItem = this.ProcessItem;
				if (processItem == null)
				{
					return;
				}
				processItem.SetUIActive(false);
				return;
			}
			else
			{
				this.MissionPanelStep.Update();
				this.ShortcutKeyController.UpdateTrackTargetShortcutKey();
				this.ShortcutKeyController.RefreshFastReturnShortcutKey();
				UUIItem processItem2 = this.ProcessItem;
				if (processItem2 == null)
				{
					return;
				}
				processItem2.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0603CC21 RID: 248865 RVA: 0x00E96514 File Offset: 0x00E94714
		private void SetCompleteQuestName()
		{
			BehaviorTreeViewShowData behaviorTreeViewShowData = this.ShowData as BehaviorTreeViewShowData;
			if (behaviorTreeViewShowData == null || behaviorTreeViewShowData.BtType != BtType.Quest)
			{
				return;
			}
			global::Quest quest = QuestNewModel.Instance.GetQuest(behaviorTreeViewShowData.TreeConfigId);
			base.GetText(6).SetText(((quest != null) ? quest.Name : null) ?? string.Empty, true);
		}

		// Token: 0x0603CC22 RID: 248866 RVA: 0x00E96570 File Offset: 0x00E94770
		private void SetNiagaraColor(float _)
		{
			if (this.ShowData == null)
			{
				return;
			}
			TaskMark? questMarkConfig = QuestNewConfig.Instance.GetQuestMarkConfig(this.ShowData.TrackIconConfigId);
			if (questMarkConfig == null)
			{
				return;
			}
			UUINiagara uiNiagara = base.GetUiNiagara(7);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetColor(FColor.FromHex(questMarkConfig.Value.TrackTextStartEffectColor));
			uiNiagara.ActivateSystem(true);
		}

		// Token: 0x0603CC23 RID: 248867 RVA: 0x00E965D4 File Offset: 0x00E947D4
		private void OnForceRefresh(long treeIncId)
		{
			IMissionItemViewShowData showData = this.ShowData;
			long? num = (showData != null) ? new long?(showData.Id) : null;
			if (!(treeIncId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			if (this.CurProcessId != 0)
			{
				return;
			}
			this.OnTickImp(0);
		}

		// Token: 0x0603CC24 RID: 248868 RVA: 0x00E96628 File Offset: 0x00E94828
		public bool CheckVisible()
		{
			if (!BattleUiModel.Instance.IsMissionPanelVisible)
			{
				return false;
			}
			if (this.ShowData != null)
			{
				Dictionary<EMissionItemView, bool> isShowingMissionViewItems = BattleUiModel.Instance.IsShowingMissionViewItems;
				if (isShowingMissionViewItems != null && isShowingMissionViewItems.GetValueOrDefault(this.ViewType))
				{
					BehaviorTreeViewShowData behaviorTreeViewShowData = this.ShowData as BehaviorTreeViewShowData;
					if (behaviorTreeViewShowData != null)
					{
						if (behaviorTreeViewShowData.BtType == BtType.Quest && GameModeController.Instance.IsInInstance())
						{
							return false;
						}
						LogicTreeContainer logicTreeContainer = GeneralLogicTreeUtil.Instance.GetLogicTreeContainer(behaviorTreeViewShowData.BtType, behaviorTreeViewShowData.TreeConfigId);
						if (logicTreeContainer == null || !logicTreeContainer.CanShowTrackExpression())
						{
							return false;
						}
					}
					return !MissionViewStepTextUtil.CheckShowConfigEmpty(this.ShowData);
				}
			}
			return false;
		}

		// Token: 0x0401FA5B RID: 129627
		[Nullable(1)]
		private readonly MissionViewItem.ShortcutKeyControllerImpl ShortcutKeyController = new MissionViewItem.ShortcutKeyControllerImpl();

		// Token: 0x0401FA5C RID: 129628
		private UUIItem ProcessItem;

		// Token: 0x0401FA5D RID: 129629
		private UUIItem CompleteItem;

		// Token: 0x0401FA5E RID: 129630
		protected LevelSequencePlayer TotalTitleSequencePlayer;

		// Token: 0x0401FA5F RID: 129631
		protected LevelSequencePlayer QuestFinishSequencePlayer;

		// Token: 0x0401FA60 RID: 129632
		private MissionPanelStep MissionPanelStep;

		// Token: 0x0401FA61 RID: 129633
		[Nullable(1)]
		private readonly FishingEntrustNavigationItem FishingEntrustNavigationItem = new FishingEntrustNavigationItem();

		// Token: 0x0401FA62 RID: 129634
		private int CurProcessId;

		// Token: 0x0401FA63 RID: 129635
		private float CurTickTime;

		// Token: 0x0401FA64 RID: 129636
		public EMissionItemView ViewType;

		// Token: 0x0401FA65 RID: 129637
		private bool IsPanelShow;

		// Token: 0x0401FA66 RID: 129638
		private bool LastStepShowState;

		// Token: 0x0401FA67 RID: 129639
		private CustomPromise<bool> TotalSequenceStartPromise;

		// Token: 0x0401FA68 RID: 129640
		private CustomPromise<bool> TotalSequenceClosePromise;

		// Token: 0x0401FA69 RID: 129641
		private CustomPromise<bool> QuestFinishStartPromise;

		// Token: 0x0401FA6A RID: 129642
		private CustomPromise<bool> QuestFinishClosePromise;

		// Token: 0x0401FA6B RID: 129643
		[Nullable(1)]
		private readonly Queue<MissionViewItem.EProcessType> MissionPanelStepVisibleProcessQueue = new Queue<MissionViewItem.EProcessType>(4);

		// Token: 0x0200C031 RID: 49201
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039FEE RID: 237550
			Icon,
			// Token: 0x04039FEF RID: 237551
			ParentStep,
			// Token: 0x04039FF0 RID: 237552
			ShortcutKeyText,
			// Token: 0x04039FF1 RID: 237553
			ShortcutKeyButton,
			// Token: 0x04039FF2 RID: 237554
			CompleteItem,
			// Token: 0x04039FF3 RID: 237555
			ProcessItem,
			// Token: 0x04039FF4 RID: 237556
			CompleteQuestName,
			// Token: 0x04039FF5 RID: 237557
			StartNiagara,
			// Token: 0x04039FF6 RID: 237558
			TotalTitleText,
			// Token: 0x04039FF7 RID: 237559
			TotalTitleTextNode,
			// Token: 0x04039FF8 RID: 237560
			ShortcutKeyMobileSprite,
			// Token: 0x04039FF9 RID: 237561
			ShortcutKeyRoot
		}

		// Token: 0x0200C032 RID: 49202
		[NullableContext(0)]
		private enum EProcessType
		{
			// Token: 0x04039FFB RID: 237563
			Show,
			// Token: 0x04039FFC RID: 237564
			Hide
		}

		// Token: 0x0200C033 RID: 49203
		[Nullable(0)]
		private class ShortcutKeyControllerImpl
		{
			// Token: 0x1700A267 RID: 41575
			// (get) Token: 0x060502CD RID: 328397 RVA: 0x0158522A File Offset: 0x0158342A
			public IMissionItemViewShowData ShowData
			{
				get
				{
					return BattleUiModel.Instance.GetMissionViewData(this.ViewType);
				}
			}

			// Token: 0x060502CE RID: 328398 RVA: 0x0158523C File Offset: 0x0158343C
			[NullableContext(1)]
			public void Init(MissionViewItem owner, EMissionItemView viewType, UUIItem shortcutKeyRoot, UUISprite shortcutKeySprite, UUIText shortcutTextComp)
			{
				this.Owner = owner;
				this.ViewType = viewType;
				this.ShortcutKeyRoot = shortcutKeyRoot;
				this.ShortcutKeySprite = shortcutKeySprite;
				this.ShortcutTextComp = shortcutTextComp;
			}

			// Token: 0x060502CF RID: 328399 RVA: 0x01585263 File Offset: 0x01583463
			public void OnPanelShow()
			{
				this.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
			}

			// Token: 0x060502D0 RID: 328400 RVA: 0x0158526D File Offset: 0x0158346D
			public void OnPanelHide()
			{
				this.SetUpShortcutKeyByType(EActiveNodeShortcutShow.None);
			}

			// Token: 0x060502D1 RID: 328401 RVA: 0x01585276 File Offset: 0x01583476
			public void OnProcessStart()
			{
				this.SetUpShortcutKeyByType(EActiveNodeShortcutShow.None);
			}

			// Token: 0x060502D2 RID: 328402 RVA: 0x0158527F File Offset: 0x0158347F
			public void OnProcessEnd()
			{
				this.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
			}

			// Token: 0x060502D3 RID: 328403 RVA: 0x01585289 File Offset: 0x01583489
			public void Dispose()
			{
				InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
				InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}

			// Token: 0x060502D4 RID: 328404 RVA: 0x015852C1 File Offset: 0x015834C1
			[NullableContext(1)]
			private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
			{
				if (actionType != InputDistributeDefine.EActionType.Release)
				{
					return;
				}
				this.OnShortcutKeyClick();
			}

			// Token: 0x060502D5 RID: 328405 RVA: 0x015852CE File Offset: 0x015834CE
			public void UpdateShortcutButton(EInputControllerType last = EInputControllerType.None, EInputControllerType now = EInputControllerType.None)
			{
				this.UpdateCurShortcutType();
				this.SetUpShortcutKeyByType(this.CurShortcutType);
			}

			// Token: 0x060502D6 RID: 328406 RVA: 0x015852E4 File Offset: 0x015834E4
			private void UpdateCurShortcutType()
			{
				this.CurShortcutType = EActiveNodeShortcutShow.None;
				IMissionItemViewShowData showData = this.ShowData;
				if (showData != null && showData.DataSource == EMissionItemViewDataSource.BehaviorTree)
				{
					BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
					if (behaviorTree != null)
					{
						this.CurShortcutType = behaviorTree.GetCurrentNodeShortcutShow();
					}
				}
			}

			// Token: 0x060502D7 RID: 328407 RVA: 0x0158533C File Offset: 0x0158353C
			private void SetUpShortcutKeyByType(EActiveNodeShortcutShow type)
			{
				BaseBehaviorTree baseBehaviorTree = null;
				IMissionItemViewShowData showData = this.ShowData;
				if (showData != null && showData.DataSource == EMissionItemViewDataSource.BehaviorTree)
				{
					baseBehaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
				}
				switch (type)
				{
				case EActiveNodeShortcutShow.None:
					InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					this.ShortcutKeyRoot.SetUIActive(false);
					return;
				case EActiveNodeShortcutShow.GiveUp:
				{
					string text = baseBehaviorTree.GetGiveUpText();
					if (string.IsNullOrEmpty(text))
					{
						text = TextConfig.Instance.GetTextById("GeneralLogicTreeGiveUp");
					}
					if (Info.Instance.IsInKeyBoard())
					{
						InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("玩法放弃");
						if (actionBinding == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							return;
						}
						InputKey pcKey = actionBinding.GetPcKey();
						if (pcKey == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance = Log.Instance;
							ELogModule module = ELogModule.GeneralLogicTree;
							ELogAuthor author = ELogAuthor.YSQ;
							string message = "pcKey为空";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionMapping", "玩法放弃");
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							return;
						}
						string newText = "<texture=" + pcKey.GetKeyIconPath() + "/>" + text;
						this.ShortcutTextComp.SetText(newText, true);
					}
					else if (Info.Instance.IsInGamepad())
					{
						string newText2 = this.GetGamepadShortcutString("玩法放弃", text) ?? text;
						this.ShortcutTextComp.SetText(newText2, true);
					}
					else
					{
						string resourcePath = UiResourceConfig.Instance.GetResourcePath("FightMissionStop");
						string newText3 = "<texture=" + resourcePath + "/>" + text;
						this.ShortcutTextComp.SetText(newText3, true);
					}
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					this.ShortcutKeyRoot.SetUIActive(true);
					InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					return;
				}
				case EActiveNodeShortcutShow.Communicate:
				{
					InputActionBinding actionBinding2 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding2 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.GeneralLogicTree;
						ELogAuthor author2 = ELogAuthor.YSQ;
						string message2 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					string textById = TextConfig.Instance.GetTextById("QuestCommunicateCallback");
					string newText4 = textById;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey2 = actionBinding2.GetPcKey();
						if (pcKey2 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.GeneralLogicTree;
							ELogAuthor author3 = ELogAuthor.YSQ;
							string message3 = "pcKey为空";
							ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
							return;
						}
						string keyIconPath = pcKey2.GetKeyIconPath();
						newText4 = "<texture=" + keyIconPath + "/>" + textById;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText4 = (this.GetGamepadShortcutString("任务追踪", textById) ?? textById);
					}
					this.ShortcutTextComp.SetText(newText4, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.ChallengeAgain:
				{
					string text2 = baseBehaviorTree.GetGiveUpText();
					if (string.IsNullOrEmpty(text2))
					{
						text2 = TextConfig.Instance.GetTextById("ChallengeAgain");
					}
					if (Info.Instance.IsInKeyBoard())
					{
						InputActionBinding actionBinding3 = InputSettingsManager.Instance.GetActionBinding("重新挑战");
						if (actionBinding3 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							return;
						}
						InputKey pcKey3 = actionBinding3.GetPcKey();
						if (pcKey3 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance4 = Log.Instance;
							ELogModule module4 = ELogModule.GeneralLogicTree;
							ELogAuthor author4 = ELogAuthor.YSQ;
							string message4 = "pcKey为空";
							ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("actionMapping", "重新挑战");
							instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
							return;
						}
						string newText5 = "<texture=" + pcKey3.GetKeyIconPath() + "/>" + text2;
						this.ShortcutTextComp.SetText(newText5, true);
					}
					else if (Info.Instance.IsInGamepad())
					{
						string newText6 = this.GetGamepadShortcutString("重新挑战", text2) ?? text2;
						this.ShortcutTextComp.SetText(newText6, true);
					}
					else
					{
						string newText7 = TextConfig.Instance.GetTextById("ChallengeAgain_mobile") ?? text2;
						this.ShortcutTextComp.SetText(newText7, true);
					}
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.TrackTarget:
					if (this.RefreshTrackTarget())
					{
						InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
						InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
						return;
					}
					this.ShortcutKeyRoot.SetUIActive(false);
					return;
				case EActiveNodeShortcutShow.PhoneMessage:
				{
					InputActionBinding actionBinding4 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding4 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance5 = Log.Instance;
						ELogModule module5 = ELogModule.GeneralLogicTree;
						ELogAuthor author5 = ELogAuthor.YSQ;
						string message5 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					string text3 = TextConfig.Instance.GetTextById("QuestTrack_ReadMessage") ?? string.Empty;
					string newText8 = text3;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey4 = actionBinding4.GetPcKey();
						if (pcKey4 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance6 = Log.Instance;
							ELogModule module6 = ELogModule.GeneralLogicTree;
							ELogAuthor author6 = ELogAuthor.YSQ;
							string message6 = "pcKey为空";
							ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
							return;
						}
						string keyIconPath2 = pcKey4.GetKeyIconPath();
						newText8 = "<texture=" + keyIconPath2 + "/>" + text3;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText8 = (this.GetGamepadShortcutString("任务追踪", text3) ?? text3);
					}
					this.ShortcutTextComp.SetText(newText8, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.FastReturn:
				{
					InputActionBinding actionBinding5 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding5 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance7 = Log.Instance;
						ELogModule module7 = ELogModule.GeneralLogicTree;
						ELogAuthor author7 = ELogAuthor.HYF;
						string message7 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple7 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance7.Error(module7, author7, message7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple7));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					FastReturnResolved fastReturnResolved = FastReturnUtil.Resolve(baseBehaviorTree);
					string id = (((fastReturnResolved != null) ? fastReturnResolved.TrackReturnDungeon : null) != null) ? "QuestTrack_DungeonQuickReturn" : "QuestTrack_QuestQuickReturn";
					string text4 = TextConfig.Instance.GetTextById(id) ?? "快速返回";
					string text5 = (!string.IsNullOrEmpty((fastReturnResolved != null) ? fastReturnResolved.TidTip : null)) ? (PublicUtil.Instance.GetConfigTextByKey(fastReturnResolved.TidTip) ?? text4) : text4;
					string newText9 = text5;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey5 = actionBinding5.GetPcKey();
						if (pcKey5 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance8 = Log.Instance;
							ELogModule module8 = ELogModule.GeneralLogicTree;
							ELogAuthor author8 = ELogAuthor.HYF;
							string message8 = "pcKey为空";
							ValueTuple<string, object> valueTuple8 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance8.Error(module8, author8, message8, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple8));
							return;
						}
						string keyIconPath3 = pcKey5.GetKeyIconPath();
						newText9 = "<texture=" + keyIconPath3 + "/>" + text5;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText9 = (this.GetGamepadShortcutString("任务追踪", text5) ?? text5);
					}
					this.ShortcutTextComp.SetText(newText9, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.QuestMultiLineView:
				{
					InputActionBinding actionBinding6 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding6 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance9 = Log.Instance;
						ELogModule module9 = ELogModule.GeneralLogicTree;
						ELogAuthor author9 = ELogAuthor.YSQ;
						string message9 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple9 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance9.Error(module9, author9, message9, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple9));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					string text6 = TextConfig.Instance.GetTextById("QuestBranch_Track") ?? "查看分线";
					string newText10 = text6;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey6 = actionBinding6.GetPcKey();
						if (pcKey6 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance10 = Log.Instance;
							ELogModule module10 = ELogModule.GeneralLogicTree;
							ELogAuthor author10 = ELogAuthor.YSQ;
							string message10 = "pcKey为空";
							ValueTuple<string, object> valueTuple10 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance10.Error(module10, author10, message10, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple10));
							return;
						}
						string keyIconPath4 = pcKey6.GetKeyIconPath();
						newText10 = "<texture=" + keyIconPath4 + "/>" + text6;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText10 = (this.GetGamepadShortcutString("任务追踪", text6) ?? text6);
					}
					this.ShortcutTextComp.SetText(newText10, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.SheriffAnomalyProgress:
				{
					InputActionBinding actionBinding7 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding7 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance11 = Log.Instance;
						ELogModule module11 = ELogModule.GeneralLogicTree;
						ELogAuthor author11 = ELogAuthor.SYB;
						string message11 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple11 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance11.Error(module11, author11, message11, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple11));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					string text7 = TextConfig.Instance.GetMultiTextByKey("Sheriff_HudDesc_2") ?? "查看案情进展";
					string newText11 = text7;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey7 = actionBinding7.GetPcKey();
						if (pcKey7 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance12 = Log.Instance;
							ELogModule module12 = ELogModule.GeneralLogicTree;
							ELogAuthor author12 = ELogAuthor.SYB;
							string message12 = "pcKey为空";
							ValueTuple<string, object> valueTuple12 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance12.Error(module12, author12, message12, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple12));
							return;
						}
						string keyIconPath5 = pcKey7.GetKeyIconPath();
						newText11 = "<texture=" + keyIconPath5 + "/>" + text7;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText11 = (this.GetGamepadShortcutString("任务追踪", text7) ?? text7);
					}
					this.ShortcutTextComp.SetText(newText11, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.SheriffReasoningBoard:
				{
					InputActionBinding actionBinding8 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding8 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance13 = Log.Instance;
						ELogModule module13 = ELogModule.GeneralLogicTree;
						ELogAuthor author13 = ELogAuthor.WHJ;
						string message13 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple13 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance13.Error(module13, author13, message13, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple13));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					string text8 = TextConfig.Instance.GetMultiTextByKey("Sheriff_HudDesc_3") ?? string.Empty;
					string newText12 = text8;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey8 = actionBinding8.GetPcKey();
						if (pcKey8 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance14 = Log.Instance;
							ELogModule module14 = ELogModule.GeneralLogicTree;
							ELogAuthor author14 = ELogAuthor.WHJ;
							string message14 = "pcKey为空";
							ValueTuple<string, object> valueTuple14 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance14.Error(module14, author14, message14, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple14));
							return;
						}
						string keyIconPath6 = pcKey8.GetKeyIconPath();
						newText12 = "<texture=" + keyIconPath6 + "/>" + text8;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText12 = (this.GetGamepadShortcutString("任务追踪", text8) ?? text8);
					}
					this.ShortcutTextComp.SetText(newText12, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.SheriffMainBoard:
				{
					InputActionBinding actionBinding9 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding9 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance15 = Log.Instance;
						ELogModule module15 = ELogModule.GeneralLogicTree;
						ELogAuthor author15 = ELogAuthor.CB;
						string message15 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple15 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance15.Error(module15, author15, message15, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple15));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					string text9 = TextConfig.Instance.GetMultiTextByKey("Inference_Desc_34") ?? "进入明慎台";
					string newText13 = text9;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey9 = actionBinding9.GetPcKey();
						if (pcKey9 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance16 = Log.Instance;
							ELogModule module16 = ELogModule.GeneralLogicTree;
							ELogAuthor author16 = ELogAuthor.CB;
							string message16 = "pcKey为空";
							ValueTuple<string, object> valueTuple16 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance16.Error(module16, author16, message16, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple16));
							return;
						}
						string keyIconPath7 = pcKey9.GetKeyIconPath();
						newText13 = "<texture=" + keyIconPath7 + "/>" + text9;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText13 = (this.GetGamepadShortcutString("任务追踪", text9) ?? text9);
					}
					this.ShortcutTextComp.SetText(newText13, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				case EActiveNodeShortcutShow.SheriffClueDetail:
				{
					InputActionBinding actionBinding10 = InputSettingsManager.Instance.GetActionBinding("任务追踪");
					if (actionBinding10 == null)
					{
						this.ShortcutKeyRoot.SetUIActive(false);
						Log instance17 = Log.Instance;
						ELogModule module17 = ELogModule.GeneralLogicTree;
						ELogAuthor author17 = ELogAuthor.WHJ;
						string message17 = "找不到actionBinding配置";
						ValueTuple<string, object> valueTuple17 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance17.Error(module17, author17, message17, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple17));
						return;
					}
					InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
					string text10 = TextConfig.Instance.GetMultiTextByKey("Inference_Desc_35") ?? string.Empty;
					string newText14 = text10;
					if (Info.Instance.IsInKeyBoard())
					{
						InputKey pcKey10 = actionBinding10.GetPcKey();
						if (pcKey10 == null)
						{
							this.ShortcutKeyRoot.SetUIActive(false);
							Log instance18 = Log.Instance;
							ELogModule module18 = ELogModule.GeneralLogicTree;
							ELogAuthor author18 = ELogAuthor.CB;
							string message18 = "pcKey为空";
							ValueTuple<string, object> valueTuple18 = new ValueTuple<string, object>("actionMapping", "任务追踪");
							instance18.Error(module18, author18, message18, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple18));
							return;
						}
						string keyIconPath8 = pcKey10.GetKeyIconPath();
						newText14 = "<texture=" + keyIconPath8 + "/>" + text10;
					}
					else if (Info.Instance.IsInGamepad())
					{
						newText14 = (this.GetGamepadShortcutString("任务追踪", text10) ?? text10);
					}
					this.ShortcutTextComp.SetText(newText14, true);
					this.ShortcutTextComp.SetAlpha(1f);
					this.ShortcutTextComp.SetUIActive(true);
					this.ShortcutKeyRoot.SetUIActive(true);
					this.ShortcutKeySprite.SetUIActive(false);
					return;
				}
				default:
					return;
				}
			}

			// Token: 0x060502D8 RID: 328408 RVA: 0x01586354 File Offset: 0x01584554
			public void UpdateTrackTargetShortcutKey()
			{
				this.RefreshTrackTarget();
			}

			// Token: 0x060502D9 RID: 328409 RVA: 0x01586360 File Offset: 0x01584560
			public void RefreshFastReturnShortcutKey()
			{
				if (this.ShowData == null || this.ShowData.DataSource != EMissionItemViewDataSource.BehaviorTree)
				{
					return;
				}
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
				if (behaviorTree == null)
				{
					return;
				}
				bool flag = FastReturnUtil.Resolve(behaviorTree) != null;
				bool flag2 = this.CurShortcutType == EActiveNodeShortcutShow.FastReturn;
				if (flag == flag2)
				{
					return;
				}
				this.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
			}

			// Token: 0x060502DA RID: 328410 RVA: 0x015863C4 File Offset: 0x015845C4
			private bool RefreshTrackTarget()
			{
				if (this.CurShortcutType != EActiveNodeShortcutShow.TrackTarget)
				{
					return false;
				}
				InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("任务追踪");
				if (actionBinding == null)
				{
					this.ShortcutKeyRoot.SetUIActive(false);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.GeneralLogicTree;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "找不到actionBinding配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionMapping", "任务追踪");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				if (this.ShowData == null || this.ShowData.DataSource != EMissionItemViewDataSource.BehaviorTree)
				{
					return false;
				}
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
				if (behaviorTree == null)
				{
					return false;
				}
				int closestMapMarkId = behaviorTree.GetClosestMapMarkId();
				global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
				if (playerLocation == null)
				{
					return false;
				}
				this.QueryResult = MapModel.Instance.QueryNearestTeleporter(closestMapMarkId, EMarkType.Quest, playerLocation);
				bool flag = this.QueryResult.Info == null;
				string newText = string.Empty;
				switch (Info.Instance.InputControllerMainType)
				{
				case EInputControllerMainType.Keyboard:
				{
					InputKey pcKey = actionBinding.GetPcKey();
					if (pcKey == null)
					{
						this.ShortcutTextComp.SetUIActive(false);
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.GeneralLogicTree;
						ELogAuthor author2 = ELogAuthor.YSQ;
						string message2 = "pcKey为空";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("actionMapping", "任务追踪");
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return false;
					}
					string keyIconPath = pcKey.GetKeyIconPath();
					string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(flag ? "FastTravel_CurrentLocationIsCloser" : "FastTravel_ClickToFastTravel");
					newText = "<texture=" + keyIconPath + "/>" + multiTextByKey;
					break;
				}
				case EInputControllerMainType.Gamepad:
				{
					string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(flag ? "FastTravel_CurrentLocationIsCloser" : "FastTravel_ClickToFastTravel");
					newText = (this.GetGamepadShortcutString("任务追踪", multiTextByKey2) ?? multiTextByKey2);
					break;
				}
				case EInputControllerMainType.Touch:
					newText = TextConfig.Instance.GetMultiTextByKey(flag ? "FastTravel_CurrentLocationIsCloser" : "FastTravel_ClickToFastTravel_Mobile");
					break;
				}
				this.ShortcutTextComp.SetText(newText, true);
				this.ShortcutTextComp.SetAlpha(1f);
				this.ShortcutTextComp.SetUIActive(true);
				this.ShortcutKeyRoot.SetUIActive(true);
				this.ShortcutKeySprite.SetUIActive(Info.Instance.InputControllerMainType == EInputControllerMainType.Touch);
				return true;
			}

			// Token: 0x060502DB RID: 328411 RVA: 0x015865F0 File Offset: 0x015847F0
			[NullableContext(1)]
			[return: Nullable(2)]
			private string GetGamepadShortcutString(string actionName, string sourceString)
			{
				InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(actionName);
				if (combinationActionBindingByActionName == null)
				{
					return null;
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				combinationActionBindingByActionName.GetCurrentPlatformKeyNameMap(dictionary);
				string value = actionName;
				string value2 = actionName;
				using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						string text;
						string text2;
						keyValuePair.Deconstruct(out text, out text2);
						string key = text;
						string key2 = text2;
						InputKey key3 = InputSettings.Instance.GetKey(key);
						InputKey key4 = InputSettings.Instance.GetKey(key2);
						if (key3 != null)
						{
							value = key3.GetKeyIconPath();
						}
						if (key4 != null)
						{
							value2 = key4.GetKeyIconPath();
						}
					}
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
				defaultInterpolatedStringHandler.AppendLiteral("<texture=");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("/>+<texture=");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				defaultInterpolatedStringHandler.AppendLiteral("/>");
				defaultInterpolatedStringHandler.AppendFormatted(sourceString);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}

			// Token: 0x060502DC RID: 328412 RVA: 0x015866F4 File Offset: 0x015848F4
			public void OnShortcutKeyClick()
			{
				if (this.Owner == null || !this.Owner.CheckVisible())
				{
					return;
				}
				if (this.ShowData == null || this.ShowData.DataSource != EMissionItemViewDataSource.BehaviorTree)
				{
					return;
				}
				if (this.IsRequesting)
				{
					return;
				}
				this.IsRequesting = true;
				BaseBehaviorTree tree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
				if (tree == null)
				{
					return;
				}
				switch (this.CurShortcutType)
				{
				case EActiveNodeShortcutShow.GiveUp:
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PlayEnd);
					confirmBoxDataNew.SetCloseFunction(delegate
					{
						if (tree.ContainTag(EBehaviorTreeTag.RollbackWaiting))
						{
							EventSystem.Instance.EmitWithTarget(tree.GetBlackBoard(), EEventName.GeneralLogicTreeRollbackWaitingUpdate);
						}
					});
					confirmBoxDataNew.FunctionMap[1] = delegate()
					{
						this.IsRequesting = false;
					};
					Action<bool> <>9__3;
					confirmBoxDataNew.FunctionMap[2] = delegate()
					{
						if (this.ShowData == null || tree.ContainTag(EBehaviorTreeTag.RollbackWaiting))
						{
							this.IsRequesting = false;
							return;
						}
						GeneralLogicTreeController instance = GeneralLogicTreeController.Instance;
						long id = this.ShowData.Id;
						Action<bool> callback;
						if ((callback = <>9__3) == null)
						{
							callback = (<>9__3 = delegate(bool _)
							{
								this.IsRequesting = false;
							});
						}
						instance.RequestGiveUp(id, callback);
					};
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return;
				}
				case EActiveNodeShortcutShow.Communicate:
				{
					int? currentCommunicateId = tree.GetBlackBoard().GetCurrentCommunicateId();
					if (currentCommunicateId != null)
					{
						EventSystem.Instance.Emit<int>(EEventName.CommunicateAgain, currentCommunicateId.Value);
						this.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
						this.IsRequesting = false;
						return;
					}
					break;
				}
				case EActiveNodeShortcutShow.ChallengeAgain:
					EventSystem.Instance.Emit<string>(EEventName.ChallengeAgain, "重新挑战");
					this.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
					this.IsRequesting = false;
					return;
				case EActiveNodeShortcutShow.TrackTarget:
					if (this.QueryResult != null && this.QueryResult.Info != null)
					{
						WorldMapController.Instance.FocusNearestTargetOnWorldMap(this.QueryResult);
						this.IsRequesting = false;
						return;
					}
					break;
				case EActiveNodeShortcutShow.PhoneMessage:
				{
					BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
					ITrackCustomBoard trackCustomBoard = (behaviorTree != null) ? behaviorTree.GetCurrentNodeCustomTrackBoard() : null;
					if (trackCustomBoard != null)
					{
						QuestUtil.Instance.HandleTrackCustomBoard(trackCustomBoard, true);
					}
					this.IsRequesting = false;
					return;
				}
				case EActiveNodeShortcutShow.FastReturn:
				{
					BaseBehaviorTree behaviorTree2 = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
					FastReturnResolved fastReturnResolved = FastReturnUtil.Resolve(behaviorTree2);
					if (behaviorTree2 != null && fastReturnResolved != null)
					{
						FastReturnUtil.Trigger(behaviorTree2, fastReturnResolved, false, delegate
						{
							this.IsRequesting = false;
						});
						return;
					}
					this.IsRequesting = false;
					return;
				}
				case EActiveNodeShortcutShow.QuestMultiLineView:
				{
					BaseBehaviorTree behaviorTree3 = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
					ITrackCustomBoard trackCustomBoard2 = (behaviorTree3 != null) ? behaviorTree3.GetCurrentNodeCustomTrackBoard() : null;
					if (trackCustomBoard2 != null)
					{
						QuestUtil.Instance.HandleTrackCustomBoard(trackCustomBoard2, true);
					}
					this.IsRequesting = false;
					return;
				}
				case EActiveNodeShortcutShow.SheriffAnomalyProgress:
				{
					BaseBehaviorTree behaviorTree4 = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
					ITrackCustomBoard trackCustomBoard3 = (behaviorTree4 != null) ? behaviorTree4.GetCurrentNodeCustomTrackBoard() : null;
					if (trackCustomBoard3 != null)
					{
						QuestUtil.Instance.HandleTrackCustomBoard(trackCustomBoard3, true);
					}
					this.IsRequesting = false;
					return;
				}
				case EActiveNodeShortcutShow.SheriffReasoningBoard:
				{
					BaseBehaviorTree behaviorTree5 = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
					ITrackCustomBoard trackCustomBoard4 = (behaviorTree5 != null) ? behaviorTree5.GetCurrentNodeCustomTrackBoard() : null;
					if (trackCustomBoard4 != null)
					{
						QuestUtil.Instance.HandleTrackCustomBoard(trackCustomBoard4, true);
					}
					this.IsRequesting = false;
					return;
				}
				case EActiveNodeShortcutShow.SheriffMainBoard:
					SheriffController.Instance.OpenSheriffMap(new SheriffMapPanelParam
					{
						OnPanelOpened = delegate
						{
							this.IsRequesting = false;
						}
					});
					return;
				case EActiveNodeShortcutShow.SheriffClueDetail:
				{
					BaseBehaviorTree behaviorTree6 = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
					ITrackCustomBoard trackCustomBoard5 = (behaviorTree6 != null) ? behaviorTree6.GetCurrentNodeCustomTrackBoard() : null;
					if (trackCustomBoard5 != null)
					{
						QuestUtil.Instance.HandleTrackCustomBoard(trackCustomBoard5, true);
					}
					this.IsRequesting = false;
					break;
				}
				default:
					return;
				}
			}

			// Token: 0x04039FFD RID: 237565
			private MissionViewItem Owner;

			// Token: 0x04039FFE RID: 237566
			private EMissionItemView ViewType;

			// Token: 0x04039FFF RID: 237567
			public UUIItem ShortcutKeyRoot;

			// Token: 0x0403A000 RID: 237568
			public UUISprite ShortcutKeySprite;

			// Token: 0x0403A001 RID: 237569
			public UUIText ShortcutTextComp;

			// Token: 0x0403A002 RID: 237570
			private EActiveNodeShortcutShow CurShortcutType;

			// Token: 0x0403A003 RID: 237571
			private QueryNearestTeleporterResult QueryResult;

			// Token: 0x0403A004 RID: 237572
			private bool IsRequesting;
		}
	}
}
