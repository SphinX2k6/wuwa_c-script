using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001393 RID: 5011
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLimitTaskView : UiViewBase
{
	// Token: 0x0600C6A7 RID: 50855 RVA: 0x003B3382 File Offset: 0x003B1582
	public HonamiStoryLimitTaskView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600C6A8 RID: 50856 RVA: 0x003B338C File Offset: 0x003B158C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
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
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C6A9 RID: 50857 RVA: 0x003B3438 File Offset: 0x003B1638
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryLimitTaskView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryLimitTaskView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C6AA RID: 50858 RVA: 0x003B347B File Offset: 0x003B167B
	private HonamiStoryLimitTaskItem CreateTaskItem()
	{
		return new HonamiStoryLimitTaskItem
		{
			OnClickToGet = new Action<int>(this.OnClickGetTaskReward)
		};
	}

	// Token: 0x0600C6AB RID: 50859 RVA: 0x003B3494 File Offset: 0x003B1694
	private void RefreshTaskScroll()
	{
		new UiAsyncTask("RefreshProgress", delegate()
		{
			HonamiStoryLimitTaskView.<<RefreshTaskScroll>b__9_0>d <<RefreshTaskScroll>b__9_0>d;
			<<RefreshTaskScroll>b__9_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshTaskScroll>b__9_0>d.<>4__this = this;
			<<RefreshTaskScroll>b__9_0>d.<>1__state = -1;
			<<RefreshTaskScroll>b__9_0>d.<>t__builder.Start<HonamiStoryLimitTaskView.<<RefreshTaskScroll>b__9_0>d>(ref <<RefreshTaskScroll>b__9_0>d);
			return <<RefreshTaskScroll>b__9_0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x0600C6AC RID: 50860 RVA: 0x003B34B4 File Offset: 0x003B16B4
	private UniTask RefreshTaskScrollAsync()
	{
		HonamiStoryLimitTaskView.<RefreshTaskScrollAsync>d__10 <RefreshTaskScrollAsync>d__;
		<RefreshTaskScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTaskScrollAsync>d__.<>4__this = this;
		<RefreshTaskScrollAsync>d__.<>1__state = -1;
		<RefreshTaskScrollAsync>d__.<>t__builder.Start<HonamiStoryLimitTaskView.<RefreshTaskScrollAsync>d__10>(ref <RefreshTaskScrollAsync>d__);
		return <RefreshTaskScrollAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C6AD RID: 50861 RVA: 0x003B34F7 File Offset: 0x003B16F7
	private void RefreshProgressItem()
	{
		new UiAsyncTask("RefreshProgress", delegate()
		{
			HonamiStoryLimitTaskView.<<RefreshProgressItem>b__11_0>d <<RefreshProgressItem>b__11_0>d;
			<<RefreshProgressItem>b__11_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshProgressItem>b__11_0>d.<>4__this = this;
			<<RefreshProgressItem>b__11_0>d.<>1__state = -1;
			<<RefreshProgressItem>b__11_0>d.<>t__builder.Start<HonamiStoryLimitTaskView.<<RefreshProgressItem>b__11_0>d>(ref <<RefreshProgressItem>b__11_0>d);
			return <<RefreshProgressItem>b__11_0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x0600C6AE RID: 50862 RVA: 0x003B3518 File Offset: 0x003B1718
	private UniTask RefreshProgressItemAsync()
	{
		HonamiStoryLimitTaskView.<RefreshProgressItemAsync>d__12 <RefreshProgressItemAsync>d__;
		<RefreshProgressItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshProgressItemAsync>d__.<>4__this = this;
		<RefreshProgressItemAsync>d__.<>1__state = -1;
		<RefreshProgressItemAsync>d__.<>t__builder.Start<HonamiStoryLimitTaskView.<RefreshProgressItemAsync>d__12>(ref <RefreshProgressItemAsync>d__);
		return <RefreshProgressItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C6AF RID: 50863 RVA: 0x003B355C File Offset: 0x003B175C
	private void OnClickGetTaskReward(int taskId)
	{
		List<int> finishedLimitTaskIds = this.ActivityData.GetFinishedLimitTaskIds();
		HonamiStoryController.Instance.SendHonamiStoryLimitTaskRewardRequest(finishedLimitTaskIds, delegate
		{
			this.RefreshTaskScroll();
			this.RefreshProgressItem();
		});
	}

	// Token: 0x0600C6B0 RID: 50864 RVA: 0x003B358C File Offset: 0x003B178C
	private void OnClickGetProgressReward()
	{
		List<int> finishedScoreRewardIds = this.ActivityData.GetFinishedScoreRewardIds();
		HonamiStoryController.Instance.SendHonamiStoryScoreRewardRequest(finishedScoreRewardIds, new Action(this.RefreshProgressItem));
	}

	// Token: 0x0600C6B1 RID: 50865 RVA: 0x003B35BC File Offset: 0x003B17BC
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(431);
	}

	// Token: 0x0600C6B2 RID: 50866 RVA: 0x003B35CD File Offset: 0x003B17CD
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400713D RID: 28989
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x0400713E RID: 28990
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400713F RID: 28991
	private HonamiStoryLimitTaskProItem ProgressItem;

	// Token: 0x04007140 RID: 28992
	private GenericScrollViewNew<HonamiStoryLimitTaskItem, HonamiStoryLimitTaskData> RewardScroll;

	// Token: 0x02007637 RID: 30263
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402662F RID: 157231
		CaptionItem,
		// Token: 0x04026630 RID: 157232
		RewardItemScroll,
		// Token: 0x04026631 RID: 157233
		PnlQuestItem,
		// Token: 0x04026632 RID: 157234
		PnlBottomReward
	}
}
