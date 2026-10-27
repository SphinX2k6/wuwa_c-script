using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001261 RID: 4705
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewDoubleReward : ActivitySubViewBase
{
	// Token: 0x17000AE6 RID: 2790
	// (get) Token: 0x06007FE0 RID: 32736 RVA: 0x001B0DBF File Offset: 0x001AEFBF
	// (set) Token: 0x06007FE1 RID: 32737 RVA: 0x001B0DC7 File Offset: 0x001AEFC7
	protected ActivityDoubleRewardData ActivityData { get; set; }

	// Token: 0x17000AE7 RID: 2791
	// (get) Token: 0x06007FE2 RID: 32738 RVA: 0x001B0DD0 File Offset: 0x001AEFD0
	// (set) Token: 0x06007FE3 RID: 32739 RVA: 0x001B0DD8 File Offset: 0x001AEFD8
	private ActivityTitleTypeA TitleComponent { get; set; }

	// Token: 0x17000AE8 RID: 2792
	// (get) Token: 0x06007FE4 RID: 32740 RVA: 0x001B0DE1 File Offset: 0x001AEFE1
	// (set) Token: 0x06007FE5 RID: 32741 RVA: 0x001B0DE9 File Offset: 0x001AEFE9
	private ActivityDescriptionTypeA DescriptionComponent { get; set; }

	// Token: 0x06007FE6 RID: 32742 RVA: 0x001B0DF4 File Offset: 0x001AEFF4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickJump));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickLock));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007FE7 RID: 32743 RVA: 0x001B0F83 File Offset: 0x001AF183
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityDoubleRewardData);
	}

	// Token: 0x06007FE8 RID: 32744 RVA: 0x001B0F98 File Offset: 0x001AF198
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewDoubleReward.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDoubleReward.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007FE9 RID: 32745 RVA: 0x001B0FDC File Offset: 0x001AF1DC
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		bool flag = !StringUtils.IsEmpty(localConfig.Value.DescTheme);
		this.TitleComponent.SetActivityBaseData(this.ActivityData);
		this.TitleComponent.SetTitleByText(this.ActivityData.GetTitle());
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(localConfig.Value.DescTheme, Array.Empty<string>());
		}
		string desc = localConfig.Value.Desc;
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		this.OnRefreshView();
	}

	// Token: 0x06007FEA RID: 32746 RVA: 0x001B1093 File Offset: 0x001AF293
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06007FEB RID: 32747 RVA: 0x001B109C File Offset: 0x001AF29C
	protected override void OnRefreshView()
	{
		ValueTuple<string, int, int> numTxtAndParam = this.ActivityData.GetNumTxtAndParam();
		bool flag = this.ActivityData.IsUnLock();
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag && FunctionModel.Instance.IsOpen(10023004));
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), numTxtAndParam.Item1, new <>z__ReadOnlyArray<object>(new object[]
		{
			numTxtAndParam.Item2,
			numTxtAndParam.Item3
		}));
		base.GetItem(4).SetUIActive(flag);
		base.GetItem(5).SetUIActive(!flag);
		base.GetButton(7).RootUIComp.Get().SetUIActive(!flag);
		if (!flag)
		{
			string currentLockConditionText = this.GetCurrentLockConditionText();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), currentLockConditionText, Array.Empty<object>());
		}
		this.RefreshTimerText();
		this.ActivityData.ReadDailyRedDot();
	}

	// Token: 0x06007FEC RID: 32748 RVA: 0x001B11A0 File Offset: 0x001AF3A0
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

	// Token: 0x06007FED RID: 32749 RVA: 0x001B11DD File Offset: 0x001AF3DD
	private void OnClickJump()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			this.ActivityData.JumpToDungeon();
		});
	}

	// Token: 0x06007FEE RID: 32750 RVA: 0x001B11FB File Offset: 0x001AF3FB
	private void OnClickLock()
	{
		ActivityController.Instance.OpenActivityConditionView(this.ActivityData.Id);
	}

	// Token: 0x02007872 RID: 30834
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027AFC RID: 162556
		public const int TitleItem = 0;

		// Token: 0x04027AFD RID: 162557
		public const int DescriptionItem = 1;

		// Token: 0x04027AFE RID: 162558
		public const int TxtNum = 2;

		// Token: 0x04027AFF RID: 162559
		public const int BtnJump = 3;

		// Token: 0x04027B00 RID: 162560
		public const int ItemDoubleTip = 4;

		// Token: 0x04027B01 RID: 162561
		public const int ItemLockTip = 5;

		// Token: 0x04027B02 RID: 162562
		public const int TxtLockTip = 6;

		// Token: 0x04027B03 RID: 162563
		public const int ButtonLock = 7;
	}
}
