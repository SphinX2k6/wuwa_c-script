using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EE0 RID: 7904
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPermanentTaskView : UiViewBase
{
	// Token: 0x0600F337 RID: 62263 RVA: 0x003AA2B2 File Offset: 0x003A84B2
	public HonamiStoryPermanentTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F338 RID: 62264 RVA: 0x003AA2BC File Offset: 0x003A84BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F339 RID: 62265 RVA: 0x003AA3AC File Offset: 0x003A85AC
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryPermanentTaskView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryPermanentTaskView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F33A RID: 62266 RVA: 0x003AA3EF File Offset: 0x003A85EF
	private HonamiStoryPermanentTaskItem CreateTaskItem()
	{
		return new HonamiStoryPermanentTaskItem
		{
			OnClickToGet = new Action<int>(this.OnClickGetTaskReward)
		};
	}

	// Token: 0x0600F33B RID: 62267 RVA: 0x003AA408 File Offset: 0x003A8608
	private void RefreshTaskScroll()
	{
		new UiAsyncTask("RefreshProgress", delegate()
		{
			HonamiStoryPermanentTaskView.<<RefreshTaskScroll>b__9_0>d <<RefreshTaskScroll>b__9_0>d;
			<<RefreshTaskScroll>b__9_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshTaskScroll>b__9_0>d.<>4__this = this;
			<<RefreshTaskScroll>b__9_0>d.<>1__state = -1;
			<<RefreshTaskScroll>b__9_0>d.<>t__builder.Start<HonamiStoryPermanentTaskView.<<RefreshTaskScroll>b__9_0>d>(ref <<RefreshTaskScroll>b__9_0>d);
			return <<RefreshTaskScroll>b__9_0>d.<>t__builder.Task;
		}, null).Run();
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityData.Id);
	}

	// Token: 0x0600F33C RID: 62268 RVA: 0x003AA444 File Offset: 0x003A8644
	private UniTask RefreshTaskScrollAsync()
	{
		HonamiStoryPermanentTaskView.<RefreshTaskScrollAsync>d__10 <RefreshTaskScrollAsync>d__;
		<RefreshTaskScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTaskScrollAsync>d__.<>4__this = this;
		<RefreshTaskScrollAsync>d__.<>1__state = -1;
		<RefreshTaskScrollAsync>d__.<>t__builder.Start<HonamiStoryPermanentTaskView.<RefreshTaskScrollAsync>d__10>(ref <RefreshTaskScrollAsync>d__);
		return <RefreshTaskScrollAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F33D RID: 62269 RVA: 0x003AA488 File Offset: 0x003A8688
	private void OnClickGetTaskReward(int taskId)
	{
		List<int> permanentTaskIdsByState = this.ActivityData.GetPermanentTaskIdsByState(EActivityTaskState.FinishedAndUnclaimed);
		HonamiStoryController.Instance.SendHonamiStoryPermanentTaskRewardRequest(permanentTaskIdsByState, new Action(this.RefreshTaskScroll));
	}

	// Token: 0x0600F33E RID: 62270 RVA: 0x003AA4B9 File Offset: 0x003A86B9
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(431);
	}

	// Token: 0x0600F33F RID: 62271 RVA: 0x003AA4CA File Offset: 0x003A86CA
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x040070A7 RID: 28839
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x040070A8 RID: 28840
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070A9 RID: 28841
	private GenericScrollViewNew<HonamiStoryPermanentTaskItem, HonamiStoryPermanentTaskData> RewardScroll;

	// Token: 0x040070AA RID: 28842
	private HonamiStoryProfitPanel ProfitPanel;

	// Token: 0x020084C9 RID: 33993
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B36A RID: 177002
		CaptionItem,
		// Token: 0x0402B36B RID: 177003
		RewardItemScroll,
		// Token: 0x0402B36C RID: 177004
		PnlQuestItem,
		// Token: 0x0402B36D RID: 177005
		PnlEnterProfit,
		// Token: 0x0402B36E RID: 177006
		TxtBozaiTitle,
		// Token: 0x0402B36F RID: 177007
		TxtBozaiDesc
	}
}
