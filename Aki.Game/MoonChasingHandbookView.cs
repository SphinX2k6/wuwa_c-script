using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200133B RID: 4923
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingHandbookView : UiViewBase
{
	// Token: 0x06008915 RID: 35093 RVA: 0x001D4D6C File Offset: 0x001D2F6C
	public MoonChasingHandbookView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008916 RID: 35094 RVA: 0x001D4D78 File Offset: 0x001D2F78
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

	// Token: 0x06008917 RID: 35095 RVA: 0x001D4E00 File Offset: 0x001D3000
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingHandbookView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingHandbookView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008918 RID: 35096 RVA: 0x001D4E43 File Offset: 0x001D3043
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
		this.RefreshCount();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06008919 RID: 35097 RVA: 0x001D4E5B File Offset: 0x001D305B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Add(EEventName.TrackMoonHandbookUpdate, new Action(this.OnTrackMoonHandbookUpdate));
	}

	// Token: 0x0600891A RID: 35098 RVA: 0x001D4E95 File Offset: 0x001D3095
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Remove(EEventName.TrackMoonHandbookUpdate, new Action(this.OnTrackMoonHandbookUpdate));
	}

	// Token: 0x0600891B RID: 35099 RVA: 0x001D4ECF File Offset: 0x001D30CF
	private HandbookDisplayGrid OnCreateDisplayGrid()
	{
		return new HandbookDisplayGrid();
	}

	// Token: 0x0600891C RID: 35100 RVA: 0x001D4ED8 File Offset: 0x001D30D8
	private void RefreshCount()
	{
		int handbookUnlockCount = MoonChasingModel.Instance.GetHandbookUnlockCount();
		base.GetText(3).SetText(handbookUnlockCount.ToString(), true);
	}

	// Token: 0x0600891D RID: 35101 RVA: 0x001D4F04 File Offset: 0x001D3104
	private void RefreshLayout()
	{
		List<IHandbookGridData> handbookGridList = MoonChasingModel.Instance.GetHandbookGridList();
		this.DisplayGridLayout.RefreshByData(handbookGridList, false, null, true);
	}

	// Token: 0x0600891E RID: 35102 RVA: 0x001D4F2B File Offset: 0x001D312B
	private void OnRefreshRewardPopUp(RewardPopupData data)
	{
		this.RewardPopup.Refresh(data);
	}

	// Token: 0x0600891F RID: 35103 RVA: 0x001D4F39 File Offset: 0x001D3139
	private void OnTrackMoonHandbookUpdate()
	{
		this.RewardPopup.SetActive(false);
	}

	// Token: 0x04003D1E RID: 15646
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003D1F RID: 15647
	private LoopScrollView<HandbookDisplayGrid, IHandbookGridData> DisplayGridLayout;

	// Token: 0x04003D20 RID: 15648
	private CommonRewardPopup RewardPopup;

	// Token: 0x020079A5 RID: 31141
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x040280E6 RID: 164070
		public const int Caption = 0;

		// Token: 0x040280E7 RID: 164071
		public const int DisplayLayout = 1;

		// Token: 0x040280E8 RID: 164072
		public const int DisplayItem = 2;

		// Token: 0x040280E9 RID: 164073
		public const int TxtUnlock = 3;

		// Token: 0x040280EA RID: 164074
		public const int PanelReward = 4;
	}
}
