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
	// Token: 0x02004D60 RID: 19808
	[NullableContext(2)]
	[Nullable(0)]
	public class MissionViewItem : BattleChildView
	{
		// Token: 0x17006223 RID: 25123
		// (get) Token: 0x06031B57 RID: 203607 RVA: 0x00DE5FE0 File Offset: 0x00DE41E0
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

		// Token: 0x17006224 RID: 25124
		// (get) Token: 0x06031B58 RID: 203608 RVA: 0x00DE600B File Offset: 0x00DE420B
		public IMissionItemViewShowData ShowData
		{
			get
			{
				return BattleUiModel.Instance.GetMissionViewData(this.ViewType);
			}
		}

		// Token: 0x06031B59 RID: 203609 RVA: 0x00DE6020 File Offset: 0x00DE4220
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

		// Token: 0x06031B5A RID: 203610 RVA: 0x00DE6214 File Offset: 0x00DE4414
		protected override UniTask OnBeforeStartAsync()
		{
			MissionViewItem.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionViewItem.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031B5B RID: 203611 RVA: 0x00DE6257 File Offset: 0x00DE4457
		private void InitController()
		{
			this.ShortcutKeyController.Init(this, this.ViewType, base.GetItem(11), base.GetSprite(10), base.GetText(2));
		}

		// Token: 0x06031B5C RID: 203612 RVA: 0x00DE6284 File Offset: 0x00DE4484
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

		// Token: 0x06031B5D RID: 203613 RVA: 0x00DE62F0 File Offset: 0x00DE44F0
		private UniTask InitMissionPanelStep()
		{
			MissionViewItem.<InitMissionPanelStep>d__28 <InitMissionPanelStep>d__;
			<InitMissionPanelStep>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMissionPanelStep>d__.<>4__this = this;
			<InitMissionPanelStep>d__.<>1__state = -1;
			<InitMissionPanelStep>d__.<>t__builder.Start<MissionViewItem.<InitMissionPanelStep>d__28>(ref <InitMissionPanelStep>d__);
			return <InitMissionPanelStep>d__.<>t__builder.Task;
		}

		// Token: 0x06031B5E RID: 203614 RVA: 0x00DE6334 File Offset: 0x00DE4534
		private UniTask InitFishingEntrustNavigation()
		{
			MissionViewItem.<InitFishingEntrustNavigation>d__29 <InitFishingEntrustNavigation>d__;
			<InitFishingEntrustNavigation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingEntrustNavigation>d__.<>4__this = this;
			<InitFishingEntrustNavigation>d__.<>1__state = -1;
			<InitFishingEntrustNavigation>d__.<>t__builder.Start<MissionViewItem.<InitFishingEntrustNavigation>d__29>(ref <InitFishingEntrustNavigation>d__);
			return <InitFishingEntrustNavigation>d__.<>t__builder.Task;
		}

		// Token: 0x06031B5F RID: 203615 RVA: 0x00DE6378 File Offset: 0x00DE4578
		protected override void OnStart()
		{
			base.GetText(6).OnSelfLanguageChange.Bind(new Action(this.SetCompleteQuestName));
			base.GetText(8).OnSelfLanguageChange.Bind(new Action(this.UpdateTotalTitleText_ForBind));
			this.TotalTitleSequencePlayer = new LevelSequencePlayer(this.ProcessItem);
			this.TotalTitleSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnTotalTitleSequenceClose), false);
			this.QuestFinishSequencePlayer = new LevelSequencePlayer(this.CompleteItem);
			this.QuestFinishSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnFinishSequenceClose), false);
		}

		// Token: 0x06031B60 RID: 203616 RVA: 0x00DE6414 File Offset: 0x00DE4614
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

		// Token: 0x06031B61 RID: 203617 RVA: 0x00DE6478 File Offset: 0x00DE4678
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

		// Token: 0x06031B62 RID: 203618 RVA: 0x00DE64C6 File Offset: 0x00DE46C6
		public void OnPanelHide()
		{
			this.IsPanelShow = false;
			this.RemoveEvents();
			this.QuestFinishSequencePlayer.PauseSequence();
			this.TotalTitleSequencePlayer.PauseSequence();
			this.MissionPanelStepVisibleProcessQueue.Push(MissionViewItem.EProcessType.Hide);
			this.ShortcutKeyController.OnPanelHide();
		}

		// Token: 0x06031B63 RID: 203619 RVA: 0x00DE6504 File Offset: 0x00DE4704
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

		// Token: 0x06031B64 RID: 203620 RVA: 0x00DE656C File Offset: 0x00DE476C
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

		// Token: 0x06031B65 RID: 203621 RVA: 0x00DE66A4 File Offset: 0x00DE48A4
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

		// Token: 0x06031B66 RID: 203622 RVA: 0x00DE67CE File Offset: 0x00DE49CE
		private void OnShortcutKeyClick()
		{
			this.ShortcutKeyController.OnShortcutKeyClick();
		}

		// Token: 0x06031B67 RID: 203623 RVA: 0x00DE67DB File Offset: 0x00DE49DB
		[NullableContext(1)]
		private void OnLogicTreeChildQuestNodeStatusChange(GeneralContext context, ChildQuestNodeStatus _2, ChildQuestNodeStatus _3, ENodeStatusUpdateReason _4)
		{
			this.OnChildQuestNodeStatusChanged(context);
		}

		// Token: 0x06031B68 RID: 203624 RVA: 0x00DE67E4 File Offset: 0x00DE49E4
		[NullableContext(1)]
		private void OnLogicTreeNodeStatusChange(GeneralContext context, NodeStatus _2, NodeStatus _3, ENodeStatusUpdateReason _4)
		{
			this.OnChildQuestNodeStatusChanged(context);
		}

		// Token: 0x06031B69 RID: 203625 RVA: 0x00DE67F0 File Offset: 0x00DE49F0
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

		// Token: 0x06031B6A RID: 203626 RVA: 0x00DE6838 File Offset: 0x00DE4A38
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

		// Token: 0x06031B6B RID: 203627 RVA: 0x00DE6880 File Offset: 0x00DE4A80
		private void OnGeneralLogicTreeCommunicateTagChange(EBehaviorTreeTag tag)
		{
			if (tag != EBehaviorTreeTag.CanCommunicateAgain)
			{
				return;
			}
			this.ShortcutKeyController.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
		}

		// Token: 0x06031B6C RID: 203628 RVA: 0x00DE6894 File Offset: 0x00DE4A94
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

		// Token: 0x06031B6D RID: 203629 RVA: 0x00DE68E0 File Offset: 0x00DE4AE0
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

		// Token: 0x06031B6E RID: 203630 RVA: 0x00DE6920 File Offset: 0x00DE4B20
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

		// Token: 0x06031B6F RID: 203631 RVA: 0x00DE6988 File Offset: 0x00DE4B88
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

		// Token: 0x06031B70 RID: 203632 RVA: 0x00DE69F0 File Offset: 0x00DE4BF0
		[NullableContext(1)]
		private void UpdateSelfData(IMissionItemViewShowData showData)
		{
			this.SetShowData(showData);
			this.SetIcon();
			this.ShortcutKeyController.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
		}

		// Token: 0x06031B71 RID: 203633 RVA: 0x00DE6A0C File Offset: 0x00DE4C0C
		private void SetShowData(IMissionItemViewShowData showData = null)
		{
			BattleUiModel.Instance.SetMissionViewData(this.ViewType, showData);
		}

		// Token: 0x06031B72 RID: 203634 RVA: 0x00DE6A20 File Offset: 0x00DE4C20
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

		// Token: 0x06031B73 RID: 203635 RVA: 0x00DE6A88 File Offset: 0x00DE4C88
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

		// Token: 0x06031B74 RID: 203636 RVA: 0x00DE6AE4 File Offset: 0x00DE4CE4
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

		// Token: 0x06031B75 RID: 203637 RVA: 0x00DE6B40 File Offset: 0x00DE4D40
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

		// Token: 0x06031B76 RID: 203638 RVA: 0x00DE6B9C File Offset: 0x00DE4D9C
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

		// Token: 0x06031B77 RID: 203639 RVA: 0x00DE6BEF File Offset: 0x00DE4DEF
		private void OnQuestStageNameChange(int questId)
		{
			this.UpdateTotalTitleText();
		}

		// Token: 0x06031B78 RID: 203640 RVA: 0x00DE6BF8 File Offset: 0x00DE4DF8
		private void UpdateTotalTitleText_ForBind()
		{
			this.UpdateTotalTitleText();
		}

		// Token: 0x06031B79 RID: 203641 RVA: 0x00DE6C04 File Offset: 0x00DE4E04
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

		// Token: 0x06031B7A RID: 203642 RVA: 0x00DE6C5E File Offset: 0x00DE4E5E
		[NullableContext(1)]
		private string GetTotalTitleText()
		{
			if (this.ShowData == null || string.IsNullOrEmpty(this.ShowData.TitleTextKey))
			{
				return string.Empty;
			}
			return PublicUtil.Instance.GetConfigTextByKey(this.ShowData.TitleTextKey);
		}

		// Token: 0x06031B7B RID: 203643 RVA: 0x00DE6C98 File Offset: 0x00DE4E98
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

		// Token: 0x06031B7C RID: 203644 RVA: 0x00DE6CF4 File Offset: 0x00DE4EF4
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

		// Token: 0x06031B7D RID: 203645 RVA: 0x00DE6D5C File Offset: 0x00DE4F5C
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

		// Token: 0x06031B7E RID: 203646 RVA: 0x00DE6DB8 File Offset: 0x00DE4FB8
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

		// Token: 0x06031B7F RID: 203647 RVA: 0x00DE6E1C File Offset: 0x00DE501C
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

		// Token: 0x06031B80 RID: 203648 RVA: 0x00DE6E70 File Offset: 0x00DE5070
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

		// Token: 0x0401A513 RID: 107795
		[Nullable(1)]
		private readonly MissionViewItem.ShortcutKeyControllerImpl ShortcutKeyController = new MissionViewItem.ShortcutKeyControllerImpl();

		// Token: 0x0401A514 RID: 107796
		private UUIItem ProcessItem;

		// Token: 0x0401A515 RID: 107797
		private UUIItem CompleteItem;

		// Token: 0x0401A516 RID: 107798
		protected LevelSequencePlayer TotalTitleSequencePlayer;

		// Token: 0x0401A517 RID: 107799
		protected LevelSequencePlayer QuestFinishSequencePlayer;

		// Token: 0x0401A518 RID: 107800
		private MissionPanelStep MissionPanelStep;

		// Token: 0x0401A519 RID: 107801
		[Nullable(1)]
		private readonly FishingEntrustNavigationItem FishingEntrustNavigationItem = new FishingEntrustNavigationItem();

		// Token: 0x0401A51A RID: 107802
		private int CurProcessId;

		// Token: 0x0401A51B RID: 107803
		private float CurTickTime;

		// Token: 0x0401A51C RID: 107804
		public EMissionItemView ViewType;

		// Token: 0x0401A51D RID: 107805
		private bool IsPanelShow;

		// Token: 0x0401A51E RID: 107806
		private bool LastStepShowState;

		// Token: 0x0401A51F RID: 107807
		private CustomPromise<bool> TotalSequenceStartPromise;

		// Token: 0x0401A520 RID: 107808
		private CustomPromise<bool> TotalSequenceClosePromise;

		// Token: 0x0401A521 RID: 107809
		private CustomPromise<bool> QuestFinishStartPromise;

		// Token: 0x0401A522 RID: 107810
		private CustomPromise<bool> QuestFinishClosePromise;

		// Token: 0x0401A523 RID: 107811
		[Nullable(1)]
		private readonly Queue<MissionViewItem.EProcessType> MissionPanelStepVisibleProcessQueue = new Queue<MissionViewItem.EProcessType>(4);

		// Token: 0x0200AA37 RID: 43575
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x040349B1 RID: 215473
			Icon,
			// Token: 0x040349B2 RID: 215474
			ParentStep,
			// Token: 0x040349B3 RID: 215475
			ShortcutKeyText,
			// Token: 0x040349B4 RID: 215476
			ShortcutKeyButton,
			// Token: 0x040349B5 RID: 215477
			CompleteItem,
			// Token: 0x040349B6 RID: 215478
			ProcessItem,
			// Token: 0x040349B7 RID: 215479
			CompleteQuestName,
			// Token: 0x040349B8 RID: 215480
			StartNiagara,
			// Token: 0x040349B9 RID: 215481
			TotalTitleText,
			// Token: 0x040349BA RID: 215482
			TotalTitleTextNode,
			// Token: 0x040349BB RID: 215483
			ShortcutKeyMobileSprite,
			// Token: 0x040349BC RID: 215484
			ShortcutKeyRoot
		}

		// Token: 0x0200AA38 RID: 43576
		[NullableContext(0)]
		private enum EProcessType
		{
			// Token: 0x040349BE RID: 215486
			Show,
			// Token: 0x040349BF RID: 215487
			Hide
		}

		// Token: 0x0200AA39 RID: 43577
		[Nullable(0)]
		private class ShortcutKeyControllerImpl
		{
			// Token: 0x17007A04 RID: 31236
			// (get) Token: 0x06046810 RID: 288784 RVA: 0x0153E5AA File Offset: 0x0153C7AA
			public IMissionItemViewShowData ShowData
			{
				get
				{
					return BattleUiModel.Instance.GetMissionViewData(this.ViewType);
				}
			}

			// Token: 0x06046811 RID: 288785 RVA: 0x0153E5BC File Offset: 0x0153C7BC
			[NullableContext(1)]
			public void Init(MissionViewItem owner, EMissionItemView viewType, UUIItem shortcutKeyRoot, UUISprite shortcutKeySprite, UUIText shortcutTextComp)
			{
				this.Owner = owner;
				this.ViewType = viewType;
				this.ShortcutKeyRoot = shortcutKeyRoot;
				this.ShortcutKeySprite = shortcutKeySprite;
				this.ShortcutTextComp = shortcutTextComp;
			}

			// Token: 0x06046812 RID: 288786 RVA: 0x0153E5E3 File Offset: 0x0153C7E3
			public void OnPanelShow()
			{
				this.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
			}

			// Token: 0x06046813 RID: 288787 RVA: 0x0153E5ED File Offset: 0x0153C7ED
			public void OnPanelHide()
			{
				this.SetUpShortcutKeyByType(EActiveNodeShortcutShow.None);
			}

			// Token: 0x06046814 RID: 288788 RVA: 0x0153E5F6 File Offset: 0x0153C7F6
			public void OnProcessStart()
			{
				this.SetUpShortcutKeyByType(EActiveNodeShortcutShow.None);
			}

			// Token: 0x06046815 RID: 288789 RVA: 0x0153E5FF File Offset: 0x0153C7FF
			public void OnProcessEnd()
			{
				this.UpdateShortcutButton(EInputControllerType.None, EInputControllerType.None);
			}

			// Token: 0x06046816 RID: 288790 RVA: 0x0153E609 File Offset: 0x0153C809
			public void Dispose()
			{
				InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
				InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}

			// Token: 0x06046817 RID: 288791 RVA: 0x0153E641 File Offset: 0x0153C841
			[NullableContext(1)]
			private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
			{
				if (actionType != InputDistributeDefine.EActionType.Release)
				{
					return;
				}
				this.OnShortcutKeyClick();
			}

			// Token: 0x06046818 RID: 288792 RVA: 0x0153E64E File Offset: 0x0153C84E
			public void UpdateShortcutButton(EInputControllerType last = EInputControllerType.None, EInputControllerType now = EInputControllerType.None)
			{
				this.UpdateCurShortcutType();
				this.SetUpShortcutKeyByType(this.CurShortcutType);
			}

			// Token: 0x06046819 RID: 288793 RVA: 0x0153E664 File Offset: 0x0153C864
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

			// Token: 0x0604681A RID: 288794 RVA: 0x0153E6BC File Offset: 0x0153C8BC
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

			// Token: 0x0604681B RID: 288795 RVA: 0x0153F6D4 File Offset: 0x0153D8D4
			public void UpdateTrackTargetShortcutKey()
			{
				this.RefreshTrackTarget();
			}

			// Token: 0x0604681C RID: 288796 RVA: 0x0153F6E0 File Offset: 0x0153D8E0
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

			// Token: 0x0604681D RID: 288797 RVA: 0x0153F744 File Offset: 0x0153D944
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

			// Token: 0x0604681E RID: 288798 RVA: 0x0153F970 File Offset: 0x0153DB70
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

			// Token: 0x0604681F RID: 288799 RVA: 0x0153FA74 File Offset: 0x0153DC74
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
					confirmBoxDataNew.FunctionMap[0] = delegate()
					{
						this.IsRequesting = false;
					};
					confirmBoxDataNew.FunctionMap[1] = delegate()
					{
						this.IsRequesting = false;
					};
					Action<bool> <>9__4;
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
						if ((callback = <>9__4) == null)
						{
							callback = (<>9__4 = delegate(bool _)
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

			// Token: 0x040349C0 RID: 215488
			private MissionViewItem Owner;

			// Token: 0x040349C1 RID: 215489
			private EMissionItemView ViewType;

			// Token: 0x040349C2 RID: 215490
			public UUIItem ShortcutKeyRoot;

			// Token: 0x040349C3 RID: 215491
			public UUISprite ShortcutKeySprite;

			// Token: 0x040349C4 RID: 215492
			public UUIText ShortcutTextComp;

			// Token: 0x040349C5 RID: 215493
			private EActiveNodeShortcutShow CurShortcutType;

			// Token: 0x040349C6 RID: 215494
			private QueryNearestTeleporterResult QueryResult;

			// Token: 0x040349C7 RID: 215495
			private bool IsRequesting;
		}
	}
}
