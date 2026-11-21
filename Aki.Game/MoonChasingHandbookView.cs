using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007EF RID: 2031
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingHandbookView : UiViewBase
{
	// Token: 0x06005CB0 RID: 23728 RVA: 0x001DDBD8 File Offset: 0x001DBDD8
	public MoonChasingHandbookView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005CB1 RID: 23729 RVA: 0x001DDBE4 File Offset: 0x001DBDE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06005CB2 RID: 23730 RVA: 0x001DDC6C File Offset: 0x001DBE6C
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingHandbookView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingHandbookView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005CB3 RID: 23731 RVA: 0x001DDCAF File Offset: 0x001DBEAF
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
		this.RefreshCount();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06005CB4 RID: 23732 RVA: 0x001DDCC7 File Offset: 0x001DBEC7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Add(EEventName.TrackMoonHandbookUpdate, new Action(this.OnTrackMoonHandbookUpdate));
	}

	// Token: 0x06005CB5 RID: 23733 RVA: 0x001DDD01 File Offset: 0x001DBF01
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Remove(EEventName.TrackMoonHandbookUpdate, new Action(this.OnTrackMoonHandbookUpdate));
	}

	// Token: 0x06005CB6 RID: 23734 RVA: 0x001DDD3B File Offset: 0x001DBF3B
	private HandbookDisplayGrid OnCreateDisplayGrid()
	{
		return new HandbookDisplayGrid();
	}

	// Token: 0x06005CB7 RID: 23735 RVA: 0x001DDD44 File Offset: 0x001DBF44
	private void RefreshCount()
	{
		int handbookUnlockCount = MoonChasingModel.Instance.GetHandbookUnlockCount();
		base.GetText(3).SetText(handbookUnlockCount.ToString(), true);
	}

	// Token: 0x06005CB8 RID: 23736 RVA: 0x001DDD70 File Offset: 0x001DBF70
	private void RefreshLayout()
	{
		List<IHandbookGridData> handbookGridList = MoonChasingModel.Instance.GetHandbookGridList();
		this.DisplayGridLayout.RefreshByData(handbookGridList, false, null, true);
	}

	// Token: 0x06005CB9 RID: 23737 RVA: 0x001DDD97 File Offset: 0x001DBF97
	private void OnRefreshRewardPopUp(RewardPopupData data)
	{
		this.RewardPopup.Refresh(data);
	}

	// Token: 0x06005CBA RID: 23738 RVA: 0x001DDDA5 File Offset: 0x001DBFA5
	private void OnTrackMoonHandbookUpdate()
	{
		this.RewardPopup.SetActive(false);
	}

	// Token: 0x04003DB6 RID: 15798
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003DB7 RID: 15799
	private LoopScrollView<HandbookDisplayGrid, IHandbookGridData> DisplayGridLayout;

	// Token: 0x04003DB8 RID: 15800
	private CommonRewardPopup RewardPopup;

	// Token: 0x02006B2F RID: 27439
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04023413 RID: 144403
		public const int Caption = 0;

		// Token: 0x04023414 RID: 144404
		public const int DisplayLayout = 1;

		// Token: 0x04023415 RID: 144405
		public const int DisplayItem = 2;

		// Token: 0x04023416 RID: 144406
		public const int TxtUnlock = 3;

		// Token: 0x04023417 RID: 144407
		public const int PanelReward = 4;
	}
}
