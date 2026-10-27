using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

// Token: 0x020011C6 RID: 4550
public class MoonCelebrationAwardSubView : ActivitySubViewBase
{
	// Token: 0x06007928 RID: 31016 RVA: 0x001984E0 File Offset: 0x001966E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardAllBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnRewardItemClickBtnA));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnRewardItemClickBtnB));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007929 RID: 31017 RVA: 0x0019871A File Offset: 0x0019691A
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x0600792A RID: 31018 RVA: 0x0019872D File Offset: 0x0019692D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600792B RID: 31019 RVA: 0x0019874B File Offset: 0x0019694B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600792C RID: 31020 RVA: 0x00198769 File Offset: 0x00196969
	protected override void OnStart()
	{
		base.GetText(10).SetText(this.ActivityBaseData.GetTitle(), true);
		this.RefreshTimeTitle();
		this.RefreshRewardItem();
		this.RefreshRewardState();
	}

	// Token: 0x0600792D RID: 31021 RVA: 0x00198798 File Offset: 0x00196998
	private void RefreshRewardItem()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		TimePointRewardActivity value = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(rewardDataList[0].Id).Value;
		bool flag = false;
		for (int i = 0; i < value.RewardItemLength; i++)
		{
			int key = value.RewardItem(i).Value.Key;
			int value2 = value.RewardItem(i).Value.Value;
			ItemInfo? config = ItemConfig.Instance.GetConfig(key);
			if (config != null)
			{
				if (!flag)
				{
					base.SetTextureByPath(config.Value.Icon, base.GetTexture(8), null, null);
					base.GetText(5).SetText("X" + value2.ToString(), true);
					flag = true;
					this.ItemDataIdA = key;
				}
				else
				{
					base.SetTextureByPath(config.Value.Icon, base.GetTexture(9), null, null);
					base.GetText(7).SetText("X" + value2.ToString(), true);
					this.ItemDataIdB = key;
				}
			}
		}
	}

	// Token: 0x0600792E RID: 31022 RVA: 0x001988E8 File Offset: 0x00196AE8
	private void RefreshRewardState()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		bool flag = rewardDataList[0].RewardState == ETimePointRewardState.Lock;
		base.GetText(2).SetUIActive(flag);
		if (flag)
		{
			double num = (double)rewardDataList[0].RewardTime - TimeUtil.Instance.GetServerTimeStamp();
			this.SetTimeText(num);
			if (num <= 1.0)
			{
				rewardDataList[0].HasUnlock = true;
			}
			base.GetButton(0).SetSelfInteractive(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Moon_Reward_Lock", Array.Empty<object>());
			base.GetItem(11).SetUIActive(true);
			return;
		}
		bool flag2 = rewardDataList[0].RewardState == ETimePointRewardState.UnlockAndUnClaimed;
		base.GetButton(0).SetSelfInteractive(flag2);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), flag2 ? "Moon_Reward_Unlock" : "Moon_Reward_Finish", Array.Empty<object>());
		base.GetItem(11).SetUIActive(false);
		if (!flag2)
		{
			base.GetButton(4).SetSelfInteractive(false);
			base.GetButton(6).SetSelfInteractive(false);
		}
	}

	// Token: 0x0600792F RID: 31023 RVA: 0x00198A00 File Offset: 0x00196C00
	private void OnClickRewardAllBtn()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		if (rewardDataList[0].RewardState != ETimePointRewardState.UnlockAndUnClaimed)
		{
			return;
		}
		ActivityTimePointRewardController.Instance.GetRewardById(this.ActivityTimePointRewardData.Id, rewardDataList[0].Id);
	}

	// Token: 0x06007930 RID: 31024 RVA: 0x00198A4A File Offset: 0x00196C4A
	private void OnRewardItemClickBtnA()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemDataIdA, true, null);
	}

	// Token: 0x06007931 RID: 31025 RVA: 0x00198A5E File Offset: 0x00196C5E
	private void OnRewardItemClickBtnB()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemDataIdB, true, null);
	}

	// Token: 0x06007932 RID: 31026 RVA: 0x00198A74 File Offset: 0x00196C74
	private void SetTimeText(double leftTime)
	{
		double num = leftTime * TimeUtil.Instance.Millisecond;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (num >= 86400.0)
		{
			double num2 = num / TimeUtil.Instance.Hour;
			double num3 = Math.Floor(num2 / TimeUtil.Instance.OneDayHourCount);
			double value = Math.Ceiling(num2 - num3 * TimeUtil.Instance.OneDayHourCount);
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(2);
			string textStringId = "CelebrationAwardLeftTimeDay";
			object[] array = new object[2];
			int num4 = 0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num3);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num5 = 1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
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
			double value2 = Math.Ceiling(num6 - num7 * TimeUtil.Instance.Minute);
			LguiUtil instance2 = LguiUtil.Instance;
			UUIText text2 = base.GetText(2);
			string textStringId2 = "CelebrationAwardLeftTimeHour";
			object[] array2 = new object[2];
			int num8 = 0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num7);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array2[num8] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num9 = 1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
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
			double value3 = Math.Ceiling(num10 - num11 * TimeUtil.Instance.Minute);
			LguiUtil instance3 = LguiUtil.Instance;
			UUIText text3 = base.GetText(2);
			string textStringId3 = "CelebrationAwardLeftTimeSecond";
			object[] array3 = new object[2];
			int num12 = 0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num11);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array3[num12] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num13 = 1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value3);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			array3[num13] = defaultInterpolatedStringHandler.ToStringAndClear();
			instance3.SetLocalTextNew(text3, textStringId3, new <>z__ReadOnlyArray<object>(array3));
			return;
		}
		LguiUtil instance4 = LguiUtil.Instance;
		UUIText text4 = base.GetText(2);
		string textStringId4 = "CelebrationAwardLeftTimeLessSecond";
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Max(Math.Floor(num), 1.0));
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		instance4.SetLocalTextNew(text4, textStringId4, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
	}

	// Token: 0x06007933 RID: 31027 RVA: 0x00198D4A File Offset: 0x00196F4A
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardItem();
		this.RefreshRewardState();
	}

	// Token: 0x06007934 RID: 31028 RVA: 0x00198D68 File Offset: 0x00196F68
	private void RefreshTimeTitle()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityTimePointRewardData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(3).SetUIActive(item);
		if (item)
		{
			base.GetText(3).SetText(item2, true);
		}
	}

	// Token: 0x06007935 RID: 31029 RVA: 0x00198DB1 File Offset: 0x00196FB1
	protected override void OnTimer(float gap)
	{
		this.RefreshRewardState();
		this.RefreshTimeTitle();
	}

	// Token: 0x040037B0 RID: 14256
	[Nullable(2)]
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x040037B1 RID: 14257
	private int ItemDataIdA;

	// Token: 0x040037B2 RID: 14258
	private int ItemDataIdB;

	// Token: 0x020077B4 RID: 30644
	private class EComponentDefine
	{
		// Token: 0x04027778 RID: 161656
		public const int GetBtn = 0;

		// Token: 0x04027779 RID: 161657
		public const int GetText = 1;

		// Token: 0x0402777A RID: 161658
		public const int TimeText = 2;

		// Token: 0x0402777B RID: 161659
		public const int TitleTimeText = 3;

		// Token: 0x0402777C RID: 161660
		public const int RewardBtnA = 4;

		// Token: 0x0402777D RID: 161661
		public const int ItemACountText = 5;

		// Token: 0x0402777E RID: 161662
		public const int RewardBtnB = 6;

		// Token: 0x0402777F RID: 161663
		public const int ItemBCountText = 7;

		// Token: 0x04027780 RID: 161664
		public const int ItemATexture = 8;

		// Token: 0x04027781 RID: 161665
		public const int ItemBTexture = 9;

		// Token: 0x04027782 RID: 161666
		public const int TitleText = 10;

		// Token: 0x04027783 RID: 161667
		public const int TipsItem = 11;
	}
}
