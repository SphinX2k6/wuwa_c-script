using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011C5 RID: 4549
[NullableContext(1)]
[Nullable(0)]
public class AwardPanel : UiPanelBase
{
	// Token: 0x0600791B RID: 31003 RVA: 0x00197B9C File Offset: 0x00195D9C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickItem1));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickItem2));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickItem3));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickReceive));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600791C RID: 31004 RVA: 0x00197E60 File Offset: 0x00196060
	protected override UniTask OnBeforeStartAsync()
	{
		AwardPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AwardPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600791D RID: 31005 RVA: 0x00197EA3 File Offset: 0x001960A3
	public void SetActivityId(int activeId)
	{
		this.ActivityId = new int?(activeId);
	}

	// Token: 0x0600791E RID: 31006 RVA: 0x00197EB4 File Offset: 0x001960B4
	public void Refresh(TimePointRewardData data)
	{
		this.Data = data;
		TimePointRewardActivity? timePointRewardById = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(this.Data.Id);
		if (timePointRewardById == null)
		{
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			IntPair value = timePointRewardById.Value.Rewards(i).Value;
			this.AwardItems[i].Refresh(this.Data, value);
		}
	}

	// Token: 0x0600791F RID: 31007 RVA: 0x00197F28 File Offset: 0x00196128
	public void RefreshState(TimePointRewardData data, string tipsTextId)
	{
		bool flag = data.RewardState == ETimePointRewardState.Lock;
		bool uiactive = data.RewardState == ETimePointRewardState.UnlockAndUnClaimed;
		bool uiactive2 = data.RewardState == ETimePointRewardState.UnlockAndClaimed;
		base.GetItem(10).SetUIActive(flag);
		base.GetItem(11).SetUIActive(uiactive);
		base.GetItem(12).SetUIActive(uiactive2);
		base.GetItem(13).SetUIActive(uiactive2);
		base.GetItem(14).SetUIActive(uiactive2);
		base.GetItem(8).SetUIActive(uiactive);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), tipsTextId, Array.Empty<object>());
		base.GetItem(6).SetUIActive(flag);
		base.GetItem(4).SetUIActive(flag);
		if (flag)
		{
			double num = (double)data.RewardTime - TimeUtil.Instance.GetServerTimeStamp();
			this.SetTimeText(num);
			if (num <= 1.0)
			{
				data.HasUnlock = true;
			}
		}
		if (ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(data.Id) == null)
		{
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			this.AwardItems[i].RefreshState(data);
		}
		base.GetItem(0).SetUIActive(data.RewardState == ETimePointRewardState.UnlockAndUnClaimed);
		this.RefreshItemBtn(data);
	}

	// Token: 0x06007920 RID: 31008 RVA: 0x00198064 File Offset: 0x00196264
	private void RefreshItemBtn(TimePointRewardData data)
	{
		for (int i = 0; i < 3; i++)
		{
			this.AwardItems[i].RefreshState(data);
		}
	}

	// Token: 0x06007921 RID: 31009 RVA: 0x00198090 File Offset: 0x00196290
	private void SetTimeText(double leftTime)
	{
		double num = leftTime * TimeUtil.Instance.Millisecond;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (num >= 86400.0)
		{
			double num2 = num / TimeUtil.Instance.Hour;
			double num3 = Math.Floor(num2 / TimeUtil.Instance.OneDayHourCount);
			double value = Math.Floor(num2 - num3 * TimeUtil.Instance.OneDayHourCount);
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(5);
			string textStringId = "AnniversaryWelfare_LeftTime_Day";
			object[] array = new object[2];
			int num4 = 0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ffe04f");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num3);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num5 = 1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ffe04f");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array[num5] = defaultInterpolatedStringHandler.ToStringAndClear();
			instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlyArray<object>(array));
			return;
		}
		if (num >= 3600.0)
		{
			double num6 = num / TimeUtil.Instance.Minute;
			double num7 = Math.Floor(num6 / TimeUtil.Instance.Minute);
			double value2 = Math.Floor(num6 - num7 * TimeUtil.Instance.Minute);
			LguiUtil instance2 = LguiUtil.Instance;
			UUIText text2 = base.GetText(5);
			string textStringId2 = "AnniversaryWelfare_LeftTime_Hour";
			object[] array2 = new object[2];
			int num8 = 0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ffe04f");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num7);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array2[num8] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num9 = 1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ffe04f");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array2[num9] = defaultInterpolatedStringHandler.ToStringAndClear();
			instance2.SetLocalTextNew(text2, textStringId2, new <>z__ReadOnlyArray<object>(array2));
			return;
		}
		if (num >= 60.0)
		{
			double num10 = num;
			double num11 = Math.Floor(num / TimeUtil.Instance.Minute);
			double value3 = Math.Floor(num10 - num11 * TimeUtil.Instance.Minute);
			LguiUtil instance3 = LguiUtil.Instance;
			UUIText text3 = base.GetText(5);
			string textStringId3 = "AnniversaryWelfare_LeftTime_Second";
			object[] array3 = new object[2];
			int num12 = 0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ffe04f");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num11);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array3[num12] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num13 = 1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ffe04f");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value3);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array3[num13] = defaultInterpolatedStringHandler.ToStringAndClear();
			instance3.SetLocalTextNew(text3, textStringId3, new <>z__ReadOnlyArray<object>(array3));
			return;
		}
		LguiUtil instance4 = LguiUtil.Instance;
		UUIText text4 = base.GetText(5);
		string textStringId4 = "AnniversaryWelfare_LeftTime_LessSecond";
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=");
		defaultInterpolatedStringHandler.AppendFormatted("#ffe04f");
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Max(Math.Floor(num), 1.0));
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		instance4.SetLocalTextNew(text4, textStringId4, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
	}

	// Token: 0x06007922 RID: 31010 RVA: 0x0019840E File Offset: 0x0019660E
	private void OnClickReceive()
	{
		if (this.Data.RewardState != ETimePointRewardState.UnlockAndUnClaimed)
		{
			return;
		}
		ActivityTimePointRewardController.Instance.GetRewardById(this.ActivityId.Value, this.Data.Id);
	}

	// Token: 0x06007923 RID: 31011 RVA: 0x0019843F File Offset: 0x0019663F
	private void OnClickItem1()
	{
		this.OnClickItem(0);
	}

	// Token: 0x06007924 RID: 31012 RVA: 0x00198448 File Offset: 0x00196648
	private void OnClickItem2()
	{
		this.OnClickItem(1);
	}

	// Token: 0x06007925 RID: 31013 RVA: 0x00198451 File Offset: 0x00196651
	private void OnClickItem3()
	{
		this.OnClickItem(2);
	}

	// Token: 0x06007926 RID: 31014 RVA: 0x0019845C File Offset: 0x0019665C
	private void OnClickItem(int awardIndex)
	{
		if (this.Data == null)
		{
			return;
		}
		TimePointRewardActivity? timePointRewardById = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(this.Data.Id);
		if (timePointRewardById == null)
		{
			return;
		}
		IntPair? intPair = timePointRewardById.Value.Rewards(awardIndex);
		if (intPair == null)
		{
			return;
		}
		int item = intPair.Value.Item1;
		ItemController.Instance.OpenItemTipsByItemId(item, true, null);
	}

	// Token: 0x040037AC RID: 14252
	[Nullable(2)]
	private TimePointRewardData Data;

	// Token: 0x040037AD RID: 14253
	private int? ActivityId;

	// Token: 0x040037AE RID: 14254
	private readonly List<AwardItem> AwardItems = new List<AwardItem>();

	// Token: 0x040037AF RID: 14255
	private const int REWARD_COUNT = 3;

	// Token: 0x020077B2 RID: 30642
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027765 RID: 161637
		public const int CommonRedDotItem = 0;

		// Token: 0x04027766 RID: 161638
		public const int RewardBtn1 = 1;

		// Token: 0x04027767 RID: 161639
		public const int RewardBtn2 = 2;

		// Token: 0x04027768 RID: 161640
		public const int RewardBtn3 = 3;

		// Token: 0x04027769 RID: 161641
		public const int TimeItem = 4;

		// Token: 0x0402776A RID: 161642
		public const int TimeCountText = 5;

		// Token: 0x0402776B RID: 161643
		public const int TimeTipsItem = 6;

		// Token: 0x0402776C RID: 161644
		public const int TimeTipsText = 7;

		// Token: 0x0402776D RID: 161645
		public const int RewardReceiveItem = 8;

		// Token: 0x0402776E RID: 161646
		public const int RewardSelfBtn = 9;

		// Token: 0x0402776F RID: 161647
		public const int UnClaimableItem = 10;

		// Token: 0x04027770 RID: 161648
		public const int ClaimableItem = 11;

		// Token: 0x04027771 RID: 161649
		public const int ClaimedItem = 12;

		// Token: 0x04027772 RID: 161650
		public const int ClaimedMaskItem = 13;

		// Token: 0x04027773 RID: 161651
		public const int ClaimedTextItem = 14;
	}
}
