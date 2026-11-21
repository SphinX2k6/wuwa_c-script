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

// Token: 0x02001BA5 RID: 7077
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeDetailView : UiViewBase, IPopViewWithCustomUiBlurItem
{
	// Token: 0x06011A0E RID: 72206 RVA: 0x00532E47 File Offset: 0x00531047
	public QuestTreeNodeDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011A0F RID: 72207 RVA: 0x00532E50 File Offset: 0x00531050
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

	// Token: 0x06011A10 RID: 72208 RVA: 0x0053324C File Offset: 0x0053144C
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeNodeDetailView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeNodeDetailView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011A11 RID: 72209 RVA: 0x00533290 File Offset: 0x00531490
	protected override void OnStart()
	{
		base.GetRootItem().SetStretchTop(0f);
		base.GetRootItem().SetStretchBottom(0f);
		base.GetRootItem().SetStretchLeft(0f);
		base.GetRootItem().SetStretchRight(0f);
	}

	// Token: 0x06011A12 RID: 72210 RVA: 0x005332DD File Offset: 0x005314DD
	protected override void OnBeforeShow()
	{
		QuestTreeModel.Instance.ViewModelChapter.SelectData(this.Data);
	}

	// Token: 0x06011A13 RID: 72211 RVA: 0x005332F4 File Offset: 0x005314F4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x06011A14 RID: 72212 RVA: 0x00533312 File Offset: 0x00531512
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x06011A15 RID: 72213 RVA: 0x00533330 File Offset: 0x00531530
	protected override void OnBeforeDestroy()
	{
		QuestTreeModel.Instance.ViewModelChapter.SelectData(null);
	}

	// Token: 0x06011A16 RID: 72214 RVA: 0x00533342 File Offset: 0x00531542
	public void ChangeData(QuestTreeNodeData data)
	{
		this.Data = data;
		this.RefreshInfos();
	}

	// Token: 0x06011A17 RID: 72215 RVA: 0x00533352 File Offset: 0x00531552
	public UUIItem GetOverrideRootItem()
	{
		return base.GetRootItem();
	}

	// Token: 0x06011A18 RID: 72216 RVA: 0x0053335C File Offset: 0x0053155C
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

	// Token: 0x06011A19 RID: 72217 RVA: 0x005333B8 File Offset: 0x005315B8
	private UniTask RefreshInfos()
	{
		QuestTreeNodeDetailView.<RefreshInfos>d__23 <RefreshInfos>d__;
		<RefreshInfos>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshInfos>d__.<>4__this = this;
		<RefreshInfos>d__.<>1__state = -1;
		<RefreshInfos>d__.<>t__builder.Start<QuestTreeNodeDetailView.<RefreshInfos>d__23>(ref <RefreshInfos>d__);
		return <RefreshInfos>d__.<>t__builder.Task;
	}

	// Token: 0x06011A1A RID: 72218 RVA: 0x005333FC File Offset: 0x005315FC
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

	// Token: 0x06011A1B RID: 72219 RVA: 0x00533430 File Offset: 0x00531630
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

	// Token: 0x06011A1C RID: 72220 RVA: 0x0053347C File Offset: 0x0053167C
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

	// Token: 0x06011A1D RID: 72221 RVA: 0x00533510 File Offset: 0x00531710
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

	// Token: 0x06011A1E RID: 72222 RVA: 0x005335D0 File Offset: 0x005317D0
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

	// Token: 0x06011A1F RID: 72223 RVA: 0x0053363E File Offset: 0x0053183E
	private void OnBtnCancelClick(int _)
	{
		QuestTreeController.Instance.ReportJump(this.Data, EQuestTreeLogReportJumpMotion.UnTrack);
		QuestTreeController.Instance.CancelTrackNode(this.Data);
	}

	// Token: 0x06011A20 RID: 72224 RVA: 0x00533664 File Offset: 0x00531864
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

	// Token: 0x06011A21 RID: 72225 RVA: 0x005336FC File Offset: 0x005318FC
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

	// Token: 0x06011A22 RID: 72226 RVA: 0x00533758 File Offset: 0x00531958
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

	// Token: 0x06011A23 RID: 72227 RVA: 0x005337E9 File Offset: 0x005319E9
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		if (data == this.Data)
		{
			this.OnDataUpdateImp();
		}
	}

	// Token: 0x06011A24 RID: 72228 RVA: 0x005337FC File Offset: 0x005319FC
	private UniTask OnDataUpdateImp()
	{
		QuestTreeNodeDetailView.<OnDataUpdateImp>d__34 <OnDataUpdateImp>d__;
		<OnDataUpdateImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnDataUpdateImp>d__.<>4__this = this;
		<OnDataUpdateImp>d__.<>1__state = -1;
		<OnDataUpdateImp>d__.<>t__builder.Start<QuestTreeNodeDetailView.<OnDataUpdateImp>d__34>(ref <OnDataUpdateImp>d__);
		return <OnDataUpdateImp>d__.<>t__builder.Task;
	}

	// Token: 0x04009A29 RID: 39465
	private QuestTreeNodeData Data;

	// Token: 0x04009A2A RID: 39466
	private ButtonItem BtnRecall;

	// Token: 0x04009A2B RID: 39467
	private ButtonItem RestartRecallButton;

	// Token: 0x04009A2C RID: 39468
	private QuestTreeDetailImageItem ImageItem;

	// Token: 0x04009A2D RID: 39469
	private GenericLayout<QuestTreeNodeTargetItem, IQuestTreeNodeTarget> LayoutTargets;

	// Token: 0x04009A2E RID: 39470
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ScrollRewards;

	// Token: 0x04009A2F RID: 39471
	private ButtonItem BtnCancel;

	// Token: 0x04009A30 RID: 39472
	private ButtonItem BtnGoto;

	// Token: 0x04009A31 RID: 39473
	private ButtonItem BtnGotoHalf;

	// Token: 0x04009A32 RID: 39474
	private QuestTreeNodeDetailTipsItem TipsItem;

	// Token: 0x04009A33 RID: 39475
	private bool IsRefreshedFromSuspended;

	// Token: 0x02007E9B RID: 32411
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028FA9 RID: 167849
		public const int SpriteTypeIcon = 0;

		// Token: 0x04028FAA RID: 167850
		public const int TextName = 1;

		// Token: 0x04028FAB RID: 167851
		public const int TextRegion = 2;

		// Token: 0x04028FAC RID: 167852
		public const int ItemMultiPics = 3;

		// Token: 0x04028FAD RID: 167853
		public const int ItemPic = 4;

		// Token: 0x04028FAE RID: 167854
		public const int ItemInUse = 5;

		// Token: 0x04028FAF RID: 167855
		public const int ItemTargetParent = 6;

		// Token: 0x04028FB0 RID: 167856
		public const int ItemTargetTitleParent = 7;

		// Token: 0x04028FB1 RID: 167857
		public const int TextTargetTitle = 8;

		// Token: 0x04028FB2 RID: 167858
		public const int LayoutTargets = 9;

		// Token: 0x04028FB3 RID: 167859
		public const int ItemTarget = 10;

		// Token: 0x04028FB4 RID: 167860
		public const int TextDesc = 11;

		// Token: 0x04028FB5 RID: 167861
		public const int ItemRewardParent = 12;

		// Token: 0x04028FB6 RID: 167862
		public const int ItemRewardContent = 13;

		// Token: 0x04028FB7 RID: 167863
		public const int ItemReward = 14;

		// Token: 0x04028FB8 RID: 167864
		public const int ItemBtnParent = 15;

		// Token: 0x04028FB9 RID: 167865
		public const int ItemBtnCancelTrack = 16;

		// Token: 0x04028FBA RID: 167866
		public const int ItemBtnGotoHalf = 17;

		// Token: 0x04028FBB RID: 167867
		public const int ItemBtnGoto = 18;

		// Token: 0x04028FBC RID: 167868
		public const int ItemFinished = 19;

		// Token: 0x04028FBD RID: 167869
		public const int ItemLock = 20;

		// Token: 0x04028FBE RID: 167870
		public const int ItemInUseBottom = 21;

		// Token: 0x04028FBF RID: 167871
		public const int ScrollRewards = 22;

		// Token: 0x04028FC0 RID: 167872
		public const int TextLock = 23;

		// Token: 0x04028FC1 RID: 167873
		public const int ScrollText = 24;

		// Token: 0x04028FC2 RID: 167874
		public const int BottomItem = 25;

		// Token: 0x04028FC3 RID: 167875
		public const int RestartRecallButton = 26;

		// Token: 0x04028FC4 RID: 167876
		public const int RecallButton = 27;

		// Token: 0x04028FC5 RID: 167877
		public const int RecallButtonParentItem = 28;
	}
}
