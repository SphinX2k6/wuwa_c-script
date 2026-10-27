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

// Token: 0x02001ED1 RID: 7889
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLimitTaskView : UiViewBase
{
	// Token: 0x0600F288 RID: 62088 RVA: 0x003A7881 File Offset: 0x003A5A81
	public HonamiStoryLimitTaskView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600F289 RID: 62089 RVA: 0x003A788C File Offset: 0x003A5A8C
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

	// Token: 0x0600F28A RID: 62090 RVA: 0x003A7938 File Offset: 0x003A5B38
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryLimitTaskView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryLimitTaskView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F28B RID: 62091 RVA: 0x003A797B File Offset: 0x003A5B7B
	private HonamiStoryLimitTaskItem CreateTaskItem()
	{
		return new HonamiStoryLimitTaskItem
		{
			OnClickToGet = new Action<int>(this.OnClickGetTaskReward)
		};
	}

	// Token: 0x0600F28C RID: 62092 RVA: 0x003A7994 File Offset: 0x003A5B94
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

	// Token: 0x0600F28D RID: 62093 RVA: 0x003A79B4 File Offset: 0x003A5BB4
	private UniTask RefreshTaskScrollAsync()
	{
		HonamiStoryLimitTaskView.<RefreshTaskScrollAsync>d__10 <RefreshTaskScrollAsync>d__;
		<RefreshTaskScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTaskScrollAsync>d__.<>4__this = this;
		<RefreshTaskScrollAsync>d__.<>1__state = -1;
		<RefreshTaskScrollAsync>d__.<>t__builder.Start<HonamiStoryLimitTaskView.<RefreshTaskScrollAsync>d__10>(ref <RefreshTaskScrollAsync>d__);
		return <RefreshTaskScrollAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F28E RID: 62094 RVA: 0x003A79F7 File Offset: 0x003A5BF7
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

	// Token: 0x0600F28F RID: 62095 RVA: 0x003A7A18 File Offset: 0x003A5C18
	private UniTask RefreshProgressItemAsync()
	{
		HonamiStoryLimitTaskView.<RefreshProgressItemAsync>d__12 <RefreshProgressItemAsync>d__;
		<RefreshProgressItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshProgressItemAsync>d__.<>4__this = this;
		<RefreshProgressItemAsync>d__.<>1__state = -1;
		<RefreshProgressItemAsync>d__.<>t__builder.Start<HonamiStoryLimitTaskView.<RefreshProgressItemAsync>d__12>(ref <RefreshProgressItemAsync>d__);
		return <RefreshProgressItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F290 RID: 62096 RVA: 0x003A7A5C File Offset: 0x003A5C5C
	private void OnClickGetTaskReward(int taskId)
	{
		List<int> finishedLimitTaskIds = this.ActivityData.GetFinishedLimitTaskIds();
		HonamiStoryController.Instance.SendHonamiStoryLimitTaskRewardRequest(finishedLimitTaskIds, delegate
		{
			this.RefreshTaskScroll();
			this.RefreshProgressItem();
		});
	}

	// Token: 0x0600F291 RID: 62097 RVA: 0x003A7A8C File Offset: 0x003A5C8C
	private void OnClickGetProgressReward()
	{
		List<int> finishedScoreRewardIds = this.ActivityData.GetFinishedScoreRewardIds();
		HonamiStoryController.Instance.SendHonamiStoryScoreRewardRequest(finishedScoreRewardIds, new Action(this.RefreshProgressItem));
	}

	// Token: 0x0600F292 RID: 62098 RVA: 0x003A7ABC File Offset: 0x003A5CBC
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(431);
	}

	// Token: 0x0600F293 RID: 62099 RVA: 0x003A7ACD File Offset: 0x003A5CCD
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400705C RID: 28764
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x0400705D RID: 28765
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400705E RID: 28766
	private HonamiStoryLimitTaskProItem ProgressItem;

	// Token: 0x0400705F RID: 28767
	private GenericScrollViewNew<HonamiStoryLimitTaskItem, HonamiStoryLimitTaskData> RewardScroll;

	// Token: 0x020084B2 RID: 33970
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B30B RID: 176907
		CaptionItem,
		// Token: 0x0402B30C RID: 176908
		RewardItemScroll,
		// Token: 0x0402B30D RID: 176909
		PnlQuestItem,
		// Token: 0x0402B30E RID: 176910
		PnlBottomReward
	}
}
