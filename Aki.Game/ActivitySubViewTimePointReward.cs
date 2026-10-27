using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200151B RID: 5403
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewTimePointReward : ActivitySubViewBase
{
	// Token: 0x06009A0C RID: 39436 RVA: 0x00215474 File Offset: 0x00213674
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009A0D RID: 39437 RVA: 0x00215540 File Offset: 0x00213740
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x06009A0E RID: 39438 RVA: 0x00215554 File Offset: 0x00213754
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTimePointReward.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTimePointReward.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A0F RID: 39439 RVA: 0x00215598 File Offset: 0x00213798
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityTimePointRewardData.LocalConfig;
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		bool flag = !StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(localConfig.Value.DescTheme, Array.Empty<string>());
		}
		UUIText text = base.GetText(1);
		bool flag2 = !StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().Desc : null);
		text.SetUIActive(flag2);
		if (flag2)
		{
			text.ShowTextNew(localConfig.Value.Desc);
		}
	}

	// Token: 0x06009A10 RID: 39440 RVA: 0x00215679 File Offset: 0x00213879
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06009A11 RID: 39441 RVA: 0x00215697 File Offset: 0x00213897
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06009A12 RID: 39442 RVA: 0x002156B5 File Offset: 0x002138B5
	[NullableContext(1)]
	private TimePointRewardItem InitItem()
	{
		return new TimePointRewardItem
		{
			OnClickToGet = new Action<int>(this.OnGetReward)
		};
	}

	// Token: 0x06009A13 RID: 39443 RVA: 0x002156D0 File Offset: 0x002138D0
	protected override UniTask OnBeforeShowSelfAsync()
	{
		ActivitySubViewTimePointReward.<OnBeforeShowSelfAsync>d__12 <OnBeforeShowSelfAsync>d__;
		<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowSelfAsync>d__.<>4__this = this;
		<OnBeforeShowSelfAsync>d__.<>1__state = -1;
		<OnBeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewTimePointReward.<OnBeforeShowSelfAsync>d__12>(ref <OnBeforeShowSelfAsync>d__);
		return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A14 RID: 39444 RVA: 0x00215714 File Offset: 0x00213914
	private UniTask RefreshRewardLayout()
	{
		ActivitySubViewTimePointReward.<RefreshRewardLayout>d__13 <RefreshRewardLayout>d__;
		<RefreshRewardLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRewardLayout>d__.<>4__this = this;
		<RefreshRewardLayout>d__.<>1__state = -1;
		<RefreshRewardLayout>d__.<>t__builder.Start<ActivitySubViewTimePointReward.<RefreshRewardLayout>d__13>(ref <RefreshRewardLayout>d__);
		return <RefreshRewardLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06009A15 RID: 39445 RVA: 0x00215757 File Offset: 0x00213957
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardLayout();
	}

	// Token: 0x06009A16 RID: 39446 RVA: 0x0021576F File Offset: 0x0021396F
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06009A17 RID: 39447 RVA: 0x00215778 File Offset: 0x00213978
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x06009A18 RID: 39448 RVA: 0x002157B5 File Offset: 0x002139B5
	private void OnGetReward(int id)
	{
		ActivityTimePointRewardController.Instance.GetRewardById(this.ActivityTimePointRewardData.Id, id);
	}

	// Token: 0x040043CF RID: 17359
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x040043D0 RID: 17360
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040043D1 RID: 17361
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TimePointRewardItem, TimePointRewardData> GridLayout;

	// Token: 0x040043D2 RID: 17362
	private UiPanelBase BgItem;

	// Token: 0x02007B49 RID: 31561
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040288A9 RID: 166057
		public const int TitleItem = 0;

		// Token: 0x040288AA RID: 166058
		public const int TextDesc = 1;

		// Token: 0x040288AB RID: 166059
		public const int Layout = 2;

		// Token: 0x040288AC RID: 166060
		public const int LayoutItem = 3;

		// Token: 0x040288AD RID: 166061
		public const int BgItem = 4;
	}
}
