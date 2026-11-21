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

// Token: 0x020009D3 RID: 2515
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewTimePointReward : ActivitySubViewBase
{
	// Token: 0x06006DEA RID: 28138 RVA: 0x0021F210 File Offset: 0x0021D410
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

	// Token: 0x06006DEB RID: 28139 RVA: 0x0021F2DC File Offset: 0x0021D4DC
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x06006DEC RID: 28140 RVA: 0x0021F2F0 File Offset: 0x0021D4F0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTimePointReward.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTimePointReward.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006DED RID: 28141 RVA: 0x0021F334 File Offset: 0x0021D534
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

	// Token: 0x06006DEE RID: 28142 RVA: 0x0021F415 File Offset: 0x0021D615
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06006DEF RID: 28143 RVA: 0x0021F433 File Offset: 0x0021D633
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06006DF0 RID: 28144 RVA: 0x0021F451 File Offset: 0x0021D651
	[NullableContext(1)]
	private TimePointRewardItem InitItem()
	{
		return new TimePointRewardItem
		{
			OnClickToGet = new Action<int>(this.OnGetReward)
		};
	}

	// Token: 0x06006DF1 RID: 28145 RVA: 0x0021F46C File Offset: 0x0021D66C
	protected override UniTask OnBeforeShowSelfAsync()
	{
		ActivitySubViewTimePointReward.<OnBeforeShowSelfAsync>d__12 <OnBeforeShowSelfAsync>d__;
		<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowSelfAsync>d__.<>4__this = this;
		<OnBeforeShowSelfAsync>d__.<>1__state = -1;
		<OnBeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewTimePointReward.<OnBeforeShowSelfAsync>d__12>(ref <OnBeforeShowSelfAsync>d__);
		return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006DF2 RID: 28146 RVA: 0x0021F4B0 File Offset: 0x0021D6B0
	private UniTask RefreshRewardLayout()
	{
		ActivitySubViewTimePointReward.<RefreshRewardLayout>d__13 <RefreshRewardLayout>d__;
		<RefreshRewardLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRewardLayout>d__.<>4__this = this;
		<RefreshRewardLayout>d__.<>1__state = -1;
		<RefreshRewardLayout>d__.<>t__builder.Start<ActivitySubViewTimePointReward.<RefreshRewardLayout>d__13>(ref <RefreshRewardLayout>d__);
		return <RefreshRewardLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06006DF3 RID: 28147 RVA: 0x0021F4F3 File Offset: 0x0021D6F3
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardLayout();
	}

	// Token: 0x06006DF4 RID: 28148 RVA: 0x0021F50B File Offset: 0x0021D70B
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06006DF5 RID: 28149 RVA: 0x0021F514 File Offset: 0x0021D714
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

	// Token: 0x06006DF6 RID: 28150 RVA: 0x0021F551 File Offset: 0x0021D751
	private void OnGetReward(int id)
	{
		ActivityTimePointRewardController.Instance.GetRewardById(this.ActivityTimePointRewardData.Id, id);
	}

	// Token: 0x04004475 RID: 17525
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x04004476 RID: 17526
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004477 RID: 17527
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TimePointRewardItem, TimePointRewardData> GridLayout;

	// Token: 0x04004478 RID: 17528
	private UiPanelBase BgItem;

	// Token: 0x02006CD4 RID: 27860
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023BE4 RID: 146404
		public const int TitleItem = 0;

		// Token: 0x04023BE5 RID: 146405
		public const int TextDesc = 1;

		// Token: 0x04023BE6 RID: 146406
		public const int Layout = 2;

		// Token: 0x04023BE7 RID: 146407
		public const int LayoutItem = 3;

		// Token: 0x04023BE8 RID: 146408
		public const int BgItem = 4;
	}
}
