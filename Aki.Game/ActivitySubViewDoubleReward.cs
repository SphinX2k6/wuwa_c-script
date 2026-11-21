using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000715 RID: 1813
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewDoubleReward : ActivitySubViewBase
{
	// Token: 0x17000B06 RID: 2822
	// (get) Token: 0x06005377 RID: 21367 RVA: 0x001B9A90 File Offset: 0x001B7C90
	// (set) Token: 0x06005378 RID: 21368 RVA: 0x001B9A98 File Offset: 0x001B7C98
	protected ActivityDoubleRewardData ActivityData { get; set; }

	// Token: 0x17000B07 RID: 2823
	// (get) Token: 0x06005379 RID: 21369 RVA: 0x001B9AA1 File Offset: 0x001B7CA1
	// (set) Token: 0x0600537A RID: 21370 RVA: 0x001B9AA9 File Offset: 0x001B7CA9
	private ActivityTitleTypeA TitleComponent { get; set; }

	// Token: 0x17000B08 RID: 2824
	// (get) Token: 0x0600537B RID: 21371 RVA: 0x001B9AB2 File Offset: 0x001B7CB2
	// (set) Token: 0x0600537C RID: 21372 RVA: 0x001B9ABA File Offset: 0x001B7CBA
	private ActivityDescriptionTypeA DescriptionComponent { get; set; }

	// Token: 0x0600537D RID: 21373 RVA: 0x001B9AC4 File Offset: 0x001B7CC4
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

	// Token: 0x0600537E RID: 21374 RVA: 0x001B9C53 File Offset: 0x001B7E53
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityDoubleRewardData);
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x001B9C68 File Offset: 0x001B7E68
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewDoubleReward.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDoubleReward.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005380 RID: 21376 RVA: 0x001B9CAC File Offset: 0x001B7EAC
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

	// Token: 0x06005381 RID: 21377 RVA: 0x001B9D63 File Offset: 0x001B7F63
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06005382 RID: 21378 RVA: 0x001B9D6C File Offset: 0x001B7F6C
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

	// Token: 0x06005383 RID: 21379 RVA: 0x001B9E70 File Offset: 0x001B8070
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

	// Token: 0x06005384 RID: 21380 RVA: 0x001B9EAD File Offset: 0x001B80AD
	private void OnClickJump()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			this.ActivityData.JumpToDungeon();
		});
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x001B9ECB File Offset: 0x001B80CB
	private void OnClickLock()
	{
		ActivityController.Instance.OpenActivityConditionView(this.ActivityData.Id);
	}

	// Token: 0x020069FD RID: 27133
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022E2D RID: 142893
		public const int TitleItem = 0;

		// Token: 0x04022E2E RID: 142894
		public const int DescriptionItem = 1;

		// Token: 0x04022E2F RID: 142895
		public const int TxtNum = 2;

		// Token: 0x04022E30 RID: 142896
		public const int BtnJump = 3;

		// Token: 0x04022E31 RID: 142897
		public const int ItemDoubleTip = 4;

		// Token: 0x04022E32 RID: 142898
		public const int ItemLockTip = 5;

		// Token: 0x04022E33 RID: 142899
		public const int TxtLockTip = 6;

		// Token: 0x04022E34 RID: 142900
		public const int ButtonLock = 7;
	}
}
