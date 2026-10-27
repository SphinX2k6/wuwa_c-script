using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026BA RID: 9914
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeDetailView : UiViewBase, IPopViewWithCustomUiBlurItem
{
	// Token: 0x0601452C RID: 83244 RVA: 0x0052410F File Offset: 0x0052230F
	public QuestTreeNodeDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601452D RID: 83245 RVA: 0x00524118 File Offset: 0x00522318
	protected unsafe override void OnRegisterComponent()
	{
		int num = 29;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601452E RID: 83246 RVA: 0x00524514 File Offset: 0x00522714
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeNodeDetailView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeNodeDetailView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601452F RID: 83247 RVA: 0x00524558 File Offset: 0x00522758
	protected override void OnStart()
	{
		base.GetRootItem().SetStretchTop(0f);
		base.GetRootItem().SetStretchBottom(0f);
		base.GetRootItem().SetStretchLeft(0f);
		base.GetRootItem().SetStretchRight(0f);
	}

	// Token: 0x06014530 RID: 83248 RVA: 0x005245A5 File Offset: 0x005227A5
	protected override void OnBeforeShow()
	{
		QuestTreeModel.Instance.ViewModelChapter.SelectData(this.Data);
	}

	// Token: 0x06014531 RID: 83249 RVA: 0x005245BC File Offset: 0x005227BC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x06014532 RID: 83250 RVA: 0x005245DA File Offset: 0x005227DA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x06014533 RID: 83251 RVA: 0x005245F8 File Offset: 0x005227F8
	protected override void OnBeforeDestroy()
	{
		QuestTreeModel.Instance.ViewModelChapter.SelectData(null);
	}

	// Token: 0x06014534 RID: 83252 RVA: 0x0052460A File Offset: 0x0052280A
	public void ChangeData(QuestTreeNodeData data)
	{
		this.Data = data;
		this.RefreshInfos();
	}

	// Token: 0x06014535 RID: 83253 RVA: 0x0052461A File Offset: 0x0052281A
	public UUIItem GetOverrideRootItem()
	{
		return base.GetRootItem();
	}

	// Token: 0x06014536 RID: 83254 RVA: 0x00524624 File Offset: 0x00522824
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1 || configParams[0] != "RecallButton")
		{
			return null;
		}
		UUIItem item = base.GetItem(27);
		if (item == null)
		{
			return null;
		}
		if (Info.Instance.IsInGamepad())
		{
			UiNavigationNewController.Instance.SetNavigationFocusForView(item, false, false, false);
		}
		return new UUIItem[]
		{
			item,
			item
		};
	}

	// Token: 0x06014537 RID: 83255 RVA: 0x00524680 File Offset: 0x00522880
	private UniTask RefreshInfos()
	{
		QuestTreeNodeDetailView.<RefreshInfos>d__23 <RefreshInfos>d__;
		<RefreshInfos>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshInfos>d__.<>4__this = this;
		<RefreshInfos>d__.<>1__state = -1;
		<RefreshInfos>d__.<>t__builder.Start<QuestTreeNodeDetailView.<RefreshInfos>d__23>(ref <RefreshInfos>d__);
		return <RefreshInfos>d__.<>t__builder.Task;
	}

	// Token: 0x06014538 RID: 83256 RVA: 0x005246C4 File Offset: 0x005228C4
	[NullableContext(2)]
	private TsUiBlur GetUiBlurComponent()
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return null;
		}
		return rootItem.GetOwner().GetComponentByClass(TsUiBlur.StaticClass()) as TsUiBlur;
	}

	// Token: 0x06014539 RID: 83257 RVA: 0x005246F8 File Offset: 0x005228F8
	private void SetUiBlurOverrideItem()
	{
		TsUiBlur uiBlurComponent = this.GetUiBlurComponent();
		if (uiBlurComponent == null)
		{
			return;
		}
		QuestTreeChapterView view = QuestTreeModel.Instance.ViewModelChapter.View;
		UUIItem uuiitem = (view != null) ? view.GetOverrideBlurItem() : null;
		if (uuiitem == null || !uuiitem.IsValid())
		{
			return;
		}
		uiBlurComponent.OverrideItem = uuiitem.GetOwner();
	}

	// Token: 0x0601453A RID: 83258 RVA: 0x00524744 File Offset: 0x00522944
	private bool ShouldShowGotoBtn()
	{
		if (this.Data.IsTracking)
		{
			return false;
		}
		if (this.Data.DisplayState == EQuestTreeNodeState.Available)
		{
			return true;
		}
		Quest quest = QuestNewModel.Instance.GetQuest(this.Data.QuestId);
		if (quest == null)
		{
			return false;
		}
		if (quest.IsSuspend() && quest.GetSuspendType() == EBehaviorTreeSuspendType.Online)
		{
			return false;
		}
		EQuestSpecialState questSpecialState = QuestNewModel.Instance.GetQuestSpecialState(quest);
		bool flag = questSpecialState - EQuestSpecialState.LockByLackResource <= 1 || questSpecialState == EQuestSpecialState.NotInFocusModeButLock;
		if (flag)
		{
			this.IsRefreshedFromSuspended = true;
			return true;
		}
		return this.Data.State == EQuestTreeNodeState.InProgress;
	}

	// Token: 0x0601453B RID: 83259 RVA: 0x005247D8 File Offset: 0x005229D8
	private void RefreshGotoBtnText()
	{
		if (this.Data.DisplayState == EQuestTreeNodeState.Available)
		{
			this.BtnGoto.SetLocalTextNew("QuestTree_Status_Acceptable_Go", Array.Empty<object>());
			return;
		}
		Quest quest = QuestNewModel.Instance.GetQuest(this.Data.QuestId);
		if (quest == null)
		{
			return;
		}
		EQuestSpecialState questSpecialState = QuestNewModel.Instance.GetQuestSpecialState(quest);
		if (questSpecialState == EQuestSpecialState.LockByLackResource)
		{
			this.BtnGoto.SetLocalTextNew("GoToDownload", Array.Empty<object>());
			return;
		}
		if (questSpecialState == EQuestSpecialState.ResourceReadyButLock)
		{
			this.BtnGoto.SetLocalTextNew("GoOnTask", Array.Empty<object>());
			return;
		}
		if (questSpecialState != EQuestSpecialState.NotInFocusModeButLock)
		{
			this.BtnGoto.SetLocalTextNew("QuestTree_Status_Ongoing_Go", Array.Empty<object>());
			return;
		}
		this.BtnGoto.SetLocalTextNew("Task_Focus_Tips02", Array.Empty<object>());
	}

	// Token: 0x0601453C RID: 83260 RVA: 0x00524898 File Offset: 0x00522A98
	private void RefreshLockText()
	{
		Quest quest = QuestNewModel.Instance.GetQuest(this.Data.QuestId);
		if (quest == null)
		{
			return;
		}
		if (QuestNewModel.Instance.GetQuestSpecialState(quest) == EQuestSpecialState.LockByFocusMode)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(23), "QuestTree_FocusModeTips", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(23), "QuestTree_Status_Locked", Array.Empty<object>());
	}

	// Token: 0x0601453D RID: 83261 RVA: 0x00524906 File Offset: 0x00522B06
	private void OnBtnCancelClick(int _)
	{
		QuestTreeController.Instance.ReportJump(this.Data, EQuestTreeLogReportJumpMotion.UnTrack);
		QuestTreeController.Instance.CancelTrackNode(this.Data);
	}

	// Token: 0x0601453E RID: 83262 RVA: 0x0052492C File Offset: 0x00522B2C
	private void OnBtnGotoClick(int _)
	{
		Quest quest = QuestNewModel.Instance.GetQuest(this.Data.QuestId);
		EQuestSpecialState equestSpecialState = (quest != null) ? QuestNewModel.Instance.GetQuestSpecialState(quest) : EQuestSpecialState.None;
		if (this.Data.DisplayState == EQuestTreeNodeState.Available && equestSpecialState != EQuestSpecialState.LockByLackResource)
		{
			Func<bool> onAcceptGoto = this.Data.GetOnAcceptGoto();
			if (onAcceptGoto != null && onAcceptGoto())
			{
				base.CloseMe(null);
			}
			QuestTreeController.Instance.ReportJump(this.Data, EQuestTreeLogReportJumpMotion.Acceptable);
			return;
		}
		QuestTreeController.Instance.ReportJump(this.Data, EQuestTreeLogReportJumpMotion.Goto);
		QuestTreeController.Instance.TrackOrGotoNode(this.Data);
	}

	// Token: 0x0601453F RID: 83263 RVA: 0x005249C4 File Offset: 0x00522BC4
	private void OnBtnRecall(int _)
	{
		int recallId = this.Data.RecallId;
		if (recallId == 0)
		{
			return;
		}
		if (!SubPackageDownLoadModel.Instance.CheckAndDownLoadRecallResource(recallId))
		{
			RecallQuestController.Instance.LogReportRecallClick(recallId, 0);
			return;
		}
		RecallQuestController.Instance.LogReportRecallClick(recallId, 1);
		bool bContinue = RecallQuestModel.Instance.IsRecallHasData(recallId);
		RecallQuestController.Instance.RequestStartRecall(recallId, bContinue);
	}

	// Token: 0x06014540 RID: 83264 RVA: 0x00524A20 File Offset: 0x00522C20
	private void OnRestartRecallBtnClick(int _)
	{
		int recallId = this.Data.RecallId;
		if (recallId == 0)
		{
			return;
		}
		if (!SubPackageDownLoadModel.Instance.CheckAndDownLoadRecallResource(recallId))
		{
			RecallQuestController.Instance.LogReportRecallClick(recallId, 0);
			return;
		}
		RecallQuestController.Instance.LogReportRecallClick(recallId, 1);
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RestartRecall);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			RecallQuestController.Instance.RequestStartRecall(recallId, false);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06014541 RID: 83265 RVA: 0x00524AB1 File Offset: 0x00522CB1
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		if (data == this.Data)
		{
			this.OnDataUpdateImp();
		}
	}

	// Token: 0x06014542 RID: 83266 RVA: 0x00524AC4 File Offset: 0x00522CC4
	private UniTask OnDataUpdateImp()
	{
		QuestTreeNodeDetailView.<OnDataUpdateImp>d__34 <OnDataUpdateImp>d__;
		<OnDataUpdateImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnDataUpdateImp>d__.<>4__this = this;
		<OnDataUpdateImp>d__.<>1__state = -1;
		<OnDataUpdateImp>d__.<>t__builder.Start<QuestTreeNodeDetailView.<OnDataUpdateImp>d__34>(ref <OnDataUpdateImp>d__);
		return <OnDataUpdateImp>d__.<>t__builder.Task;
	}

	// Token: 0x040098D1 RID: 39121
	private QuestTreeNodeData Data;

	// Token: 0x040098D2 RID: 39122
	private ButtonItem BtnRecall;

	// Token: 0x040098D3 RID: 39123
	private ButtonItem RestartRecallButton;

	// Token: 0x040098D4 RID: 39124
	private QuestTreeDetailImageItem ImageItem;

	// Token: 0x040098D5 RID: 39125
	private GenericLayout<QuestTreeNodeTargetItem, IQuestTreeNodeTarget> LayoutTargets;

	// Token: 0x040098D6 RID: 39126
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ScrollRewards;

	// Token: 0x040098D7 RID: 39127
	private ButtonItem BtnCancel;

	// Token: 0x040098D8 RID: 39128
	private ButtonItem BtnGoto;

	// Token: 0x040098D9 RID: 39129
	private ButtonItem BtnGotoHalf;

	// Token: 0x040098DA RID: 39130
	private QuestTreeNodeDetailTipsItem TipsItem;

	// Token: 0x040098DB RID: 39131
	private bool IsRefreshedFromSuspended;

	// Token: 0x02008D12 RID: 36114
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DC92 RID: 187538
		public const int SpriteTypeIcon = 0;

		// Token: 0x0402DC93 RID: 187539
		public const int TextName = 1;

		// Token: 0x0402DC94 RID: 187540
		public const int TextRegion = 2;

		// Token: 0x0402DC95 RID: 187541
		public const int ItemMultiPics = 3;

		// Token: 0x0402DC96 RID: 187542
		public const int ItemPic = 4;

		// Token: 0x0402DC97 RID: 187543
		public const int ItemInUse = 5;

		// Token: 0x0402DC98 RID: 187544
		public const int ItemTargetParent = 6;

		// Token: 0x0402DC99 RID: 187545
		public const int ItemTargetTitleParent = 7;

		// Token: 0x0402DC9A RID: 187546
		public const int TextTargetTitle = 8;

		// Token: 0x0402DC9B RID: 187547
		public const int LayoutTargets = 9;

		// Token: 0x0402DC9C RID: 187548
		public const int ItemTarget = 10;

		// Token: 0x0402DC9D RID: 187549
		public const int TextDesc = 11;

		// Token: 0x0402DC9E RID: 187550
		public const int ItemRewardParent = 12;

		// Token: 0x0402DC9F RID: 187551
		public const int ItemRewardContent = 13;

		// Token: 0x0402DCA0 RID: 187552
		public const int ItemReward = 14;

		// Token: 0x0402DCA1 RID: 187553
		public const int ItemBtnParent = 15;

		// Token: 0x0402DCA2 RID: 187554
		public const int ItemBtnCancelTrack = 16;

		// Token: 0x0402DCA3 RID: 187555
		public const int ItemBtnGotoHalf = 17;

		// Token: 0x0402DCA4 RID: 187556
		public const int ItemBtnGoto = 18;

		// Token: 0x0402DCA5 RID: 187557
		public const int ItemFinished = 19;

		// Token: 0x0402DCA6 RID: 187558
		public const int ItemLock = 20;

		// Token: 0x0402DCA7 RID: 187559
		public const int ItemInUseBottom = 21;

		// Token: 0x0402DCA8 RID: 187560
		public const int ScrollRewards = 22;

		// Token: 0x0402DCA9 RID: 187561
		public const int TextLock = 23;

		// Token: 0x0402DCAA RID: 187562
		public const int ScrollText = 24;

		// Token: 0x0402DCAB RID: 187563
		public const int BottomItem = 25;

		// Token: 0x0402DCAC RID: 187564
		public const int RestartRecallButton = 26;

		// Token: 0x0402DCAD RID: 187565
		public const int RecallButton = 27;

		// Token: 0x0402DCAE RID: 187566
		public const int RecallButtonParentItem = 28;
	}
}
