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

// Token: 0x020013A2 RID: 5026
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPermanentTaskView : UiViewBase
{
	// Token: 0x0600C756 RID: 51030 RVA: 0x003B5DAE File Offset: 0x003B3FAE
	public HonamiStoryPermanentTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C757 RID: 51031 RVA: 0x003B5DB8 File Offset: 0x003B3FB8
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

	// Token: 0x0600C758 RID: 51032 RVA: 0x003B5EA8 File Offset: 0x003B40A8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryPermanentTaskView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryPermanentTaskView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C759 RID: 51033 RVA: 0x003B5EEB File Offset: 0x003B40EB
	private HonamiStoryPermanentTaskItem CreateTaskItem()
	{
		return new HonamiStoryPermanentTaskItem
		{
			OnClickToGet = new Action<int>(this.OnClickGetTaskReward)
		};
	}

	// Token: 0x0600C75A RID: 51034 RVA: 0x003B5F04 File Offset: 0x003B4104
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

	// Token: 0x0600C75B RID: 51035 RVA: 0x003B5F40 File Offset: 0x003B4140
	private UniTask RefreshTaskScrollAsync()
	{
		HonamiStoryPermanentTaskView.<RefreshTaskScrollAsync>d__10 <RefreshTaskScrollAsync>d__;
		<RefreshTaskScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTaskScrollAsync>d__.<>4__this = this;
		<RefreshTaskScrollAsync>d__.<>1__state = -1;
		<RefreshTaskScrollAsync>d__.<>t__builder.Start<HonamiStoryPermanentTaskView.<RefreshTaskScrollAsync>d__10>(ref <RefreshTaskScrollAsync>d__);
		return <RefreshTaskScrollAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C75C RID: 51036 RVA: 0x003B5F84 File Offset: 0x003B4184
	private void OnClickGetTaskReward(int taskId)
	{
		List<int> permanentTaskIdsByState = this.ActivityData.GetPermanentTaskIdsByState(EActivityTaskState.FinishedAndUnclaimed);
		HonamiStoryController.Instance.SendHonamiStoryPermanentTaskRewardRequest(permanentTaskIdsByState, new Action(this.RefreshTaskScroll));
	}

	// Token: 0x0600C75D RID: 51037 RVA: 0x003B5FB5 File Offset: 0x003B41B5
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(431);
	}

	// Token: 0x0600C75E RID: 51038 RVA: 0x003B5FC6 File Offset: 0x003B41C6
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04007188 RID: 29064
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007189 RID: 29065
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400718A RID: 29066
	private GenericScrollViewNew<HonamiStoryPermanentTaskItem, HonamiStoryPermanentTaskData> RewardScroll;

	// Token: 0x0400718B RID: 29067
	private HonamiStoryProfitPanel ProfitPanel;

	// Token: 0x0200764E RID: 30286
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402668E RID: 157326
		CaptionItem,
		// Token: 0x0402668F RID: 157327
		RewardItemScroll,
		// Token: 0x04026690 RID: 157328
		PnlQuestItem,
		// Token: 0x04026691 RID: 157329
		PnlEnterProfit,
		// Token: 0x04026692 RID: 157330
		TxtBozaiTitle,
		// Token: 0x04026693 RID: 157331
		TxtBozaiDesc
	}
}
