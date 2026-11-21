using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009B9 RID: 2489
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewSevenDayVersionSign : ActivitySubViewBase
{
	// Token: 0x06006D32 RID: 27954 RVA: 0x0021CECC File Offset: 0x0021B0CC
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

	// Token: 0x06006D33 RID: 27955 RVA: 0x0021D01D File Offset: 0x0021B21D
	protected override void OnSetData()
	{
		this.ActivitySignData = (this.ActivityBaseData as ActivitySevenDaySignData);
	}

	// Token: 0x06006D34 RID: 27956 RVA: 0x0021D030 File Offset: 0x0021B230
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewSevenDayVersionSign.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewSevenDayVersionSign.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006D35 RID: 27957 RVA: 0x0021D073 File Offset: 0x0021B273
	protected override void OnStart()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivitySignData);
		this.TitleComponent.SetTitleByText(this.ActivitySignData.GetTitle());
	}

	// Token: 0x06006D36 RID: 27958 RVA: 0x0021D09C File Offset: 0x0021B29C
	protected override void OnRefreshView()
	{
		this.RefreshReward();
	}

	// Token: 0x06006D37 RID: 27959 RVA: 0x0021D0A4 File Offset: 0x0021B2A4
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

	// Token: 0x06006D38 RID: 27960 RVA: 0x0021D108 File Offset: 0x0021B308
	protected override void OnTimer(float gap)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.RefreshTimerText(item, item2);
	}

	// Token: 0x06006D39 RID: 27961 RVA: 0x0021D132 File Offset: 0x0021B332
	public void RefreshTimerText(bool isShow, string timeText)
	{
		this.TitleComponent.SetTimeTextVisible(isShow);
		if (isShow)
		{
			this.TitleComponent.SetTimeTextByText(timeText);
		}
	}

	// Token: 0x06006D3A RID: 27962 RVA: 0x0021D150 File Offset: 0x0021B350
	private bool IsRewardCanGet(int day)
	{
		return this.ActivitySignData.GetRewardStateByDay(day).GetValueOrDefault() == SignState.Unlock;
	}

	// Token: 0x06006D3B RID: 27963 RVA: 0x0021D174 File Offset: 0x0021B374
	private void OnClickToGetReward(int index)
	{
		if (this.IsRewardCanGet(index))
		{
			ActivitySevenDaySignController.Instance.GetRewardByDay(this.ActivitySignData.Id, index);
		}
	}

	// Token: 0x0400440F RID: 17423
	private const int SIGN_DAY_COUNT = 7;

	// Token: 0x04004410 RID: 17424
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004411 RID: 17425
	protected SignRewardItemBase[] ItemList;

	// Token: 0x04004412 RID: 17426
	[Nullable(2)]
	protected ActivitySevenDaySignData ActivitySignData;

	// Token: 0x02006CC5 RID: 27845
	[NullableContext(0)]
	private class EVersionSignComponents
	{
		// Token: 0x04023BA2 RID: 146338
		public const int TitleItem = 0;

		// Token: 0x04023BA3 RID: 146339
		public const int Item1 = 1;

		// Token: 0x04023BA4 RID: 146340
		public const int Item2 = 2;

		// Token: 0x04023BA5 RID: 146341
		public const int Item3 = 3;

		// Token: 0x04023BA6 RID: 146342
		public const int Item4 = 4;

		// Token: 0x04023BA7 RID: 146343
		public const int Item5 = 5;

		// Token: 0x04023BA8 RID: 146344
		public const int Item6 = 6;

		// Token: 0x04023BA9 RID: 146345
		public const int Item7 = 7;

		// Token: 0x04023BAA RID: 146346
		public const int Content = 8;
	}
}
