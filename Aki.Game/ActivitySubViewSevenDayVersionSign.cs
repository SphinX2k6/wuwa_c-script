using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001501 RID: 5377
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewSevenDayVersionSign : ActivitySubViewBase
{
	// Token: 0x06009958 RID: 39256 RVA: 0x002131B4 File Offset: 0x002113B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009959 RID: 39257 RVA: 0x00213305 File Offset: 0x00211505
	protected override void OnSetData()
	{
		this.ActivitySignData = (this.ActivityBaseData as ActivitySevenDaySignData);
	}

	// Token: 0x0600995A RID: 39258 RVA: 0x00213318 File Offset: 0x00211518
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewSevenDayVersionSign.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewSevenDayVersionSign.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600995B RID: 39259 RVA: 0x0021335B File Offset: 0x0021155B
	protected override void OnStart()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivitySignData);
		this.TitleComponent.SetTitleByText(this.ActivitySignData.GetTitle());
	}

	// Token: 0x0600995C RID: 39260 RVA: 0x00213384 File Offset: 0x00211584
	protected override void OnRefreshView()
	{
		this.RefreshReward();
	}

	// Token: 0x0600995D RID: 39261 RVA: 0x0021338C File Offset: 0x0021158C
	private void RefreshReward()
	{
		for (int i = 0; i < 7; i++)
		{
			OneItemConfig[] rewardByDay = this.ActivitySignData.GetRewardByDay(i);
			SignState? rewardStateByDay = this.ActivitySignData.GetRewardStateByDay(i);
			if (rewardStateByDay != null && rewardByDay != null && rewardByDay.Length != 0)
			{
				SignRewardItemBase signRewardItemBase = this.ItemList[i];
				if (signRewardItemBase != null)
				{
					signRewardItemBase.RefreshByData(rewardByDay[0], rewardStateByDay.Value, i);
				}
			}
		}
	}

	// Token: 0x0600995E RID: 39262 RVA: 0x002133F0 File Offset: 0x002115F0
	protected override void OnTimer(float gap)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.RefreshTimerText(item, item2);
	}

	// Token: 0x0600995F RID: 39263 RVA: 0x0021341A File Offset: 0x0021161A
	public void RefreshTimerText(bool isShow, string timeText)
	{
		this.TitleComponent.SetTimeTextVisible(isShow);
		if (isShow)
		{
			this.TitleComponent.SetTimeTextByText(timeText);
		}
	}

	// Token: 0x06009960 RID: 39264 RVA: 0x00213438 File Offset: 0x00211638
	private bool IsRewardCanGet(int day)
	{
		return this.ActivitySignData.GetRewardStateByDay(day).GetValueOrDefault() == SignState.Unlock;
	}

	// Token: 0x06009961 RID: 39265 RVA: 0x0021345C File Offset: 0x0021165C
	private void OnClickToGetReward(int index)
	{
		if (this.IsRewardCanGet(index))
		{
			ActivitySevenDaySignController.Instance.GetRewardByDay(this.ActivitySignData.Id, index);
		}
	}

	// Token: 0x0400436A RID: 17258
	private const int SIGN_DAY_COUNT = 7;

	// Token: 0x0400436B RID: 17259
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400436C RID: 17260
	protected SignRewardItemBase[] ItemList;

	// Token: 0x0400436D RID: 17261
	[Nullable(2)]
	protected ActivitySevenDaySignData ActivitySignData;

	// Token: 0x02007B3A RID: 31546
	[NullableContext(0)]
	private class EVersionSignComponents
	{
		// Token: 0x04028866 RID: 165990
		public const int TitleItem = 0;

		// Token: 0x04028867 RID: 165991
		public const int Item1 = 1;

		// Token: 0x04028868 RID: 165992
		public const int Item2 = 2;

		// Token: 0x04028869 RID: 165993
		public const int Item3 = 3;

		// Token: 0x0402886A RID: 165994
		public const int Item4 = 4;

		// Token: 0x0402886B RID: 165995
		public const int Item5 = 5;

		// Token: 0x0402886C RID: 165996
		public const int Item6 = 6;

		// Token: 0x0402886D RID: 165997
		public const int Item7 = 7;

		// Token: 0x0402886E RID: 165998
		public const int Content = 8;
	}
}
