using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000676 RID: 1654
[NullableContext(2)]
[Nullable(0)]
public class CelebrationAwardSubView : ActivitySubViewBase
{
	// Token: 0x06004C9A RID: 19610 RVA: 0x0019FBB8 File Offset: 0x0019DDB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(USpineSkeletonAnimationComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickRewardAllBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004C9B RID: 19611 RVA: 0x0019FDEF File Offset: 0x0019DFEF
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x06004C9C RID: 19612 RVA: 0x0019FE04 File Offset: 0x0019E004
	protected override UniTask OnBeforeStartAsync()
	{
		CelebrationAwardSubView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CelebrationAwardSubView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004C9D RID: 19613 RVA: 0x0019FE47 File Offset: 0x0019E047
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004C9E RID: 19614 RVA: 0x0019FE65 File Offset: 0x0019E065
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004C9F RID: 19615 RVA: 0x0019FE84 File Offset: 0x0019E084
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityTimePointRewardData.LocalConfig;
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		this.RefreshTimeTitle();
		bool flag = !StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(localConfig.Value.DescTheme, Array.Empty<string>());
		}
		base.GetSpine(11).SetAnimation(0, "start", false).AnimationComplete.Add(delegate(UTrackEntry _)
		{
			base.GetSpine(11).SetAnimation(0, "idle", true);
		});
		this.RefreshRewardItem();
		this.RefreshRewardState();
	}

	// Token: 0x06004CA0 RID: 19616 RVA: 0x0019FF52 File Offset: 0x0019E152
	protected override void OnBeforeShow()
	{
		if (this.HaveShowStart)
		{
			this.PlaySubViewSequence("ShowView", false);
			return;
		}
		this.PlaySubViewSequence("Start1", false);
		this.HaveShowStart = true;
	}

	// Token: 0x06004CA1 RID: 19617 RVA: 0x0019FF7C File Offset: 0x0019E17C
	private void RefreshRewardItem()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		TimePointRewardActivity value = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(rewardDataList[0].Id).Value;
		List<PropSmallItemGrid> list = new List<PropSmallItemGrid>();
		for (int i = 0; i < value.RewardItemLength; i++)
		{
			int key = value.RewardItem(i).Value.Key;
			int value2 = value.RewardItem(i).Value.Value;
			TItem titem = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(key, 0),
				Count = value2
			};
			PropSmallItemGrid item = new PropSmallItemGrid
			{
				Data = titem,
				ItemConfigId = new int?(titem.ItemData.ItemId),
				BottomText = titem.Count.ToString(),
				IsLockVisible = new bool?(rewardDataList[0].RewardState == ETimePointRewardState.Lock),
				IsReceivedVisible = new bool?(rewardDataList[0].RewardState == ETimePointRewardState.UnlockAndClaimed)
			};
			list.Add(item);
		}
		this.RewardGirdA.Apply<PropSmallItemGrid>(list[0]);
		this.RewardGirdA.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.RewardGirdB.Apply<PropSmallItemGrid>(list[1]);
		this.RewardGirdB.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
	}

	// Token: 0x06004CA2 RID: 19618 RVA: 0x001A0128 File Offset: 0x0019E328
	private void RefreshRewardState()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		bool flag = rewardDataList[0].RewardState == ETimePointRewardState.Lock;
		base.GetText(4).SetUIActive(flag);
		base.GetText(5).SetUIActive(flag);
		base.GetText(3).SetUIActive(flag);
		base.GetItem(6).SetUIActive(!flag);
		if (flag)
		{
			double num = (double)rewardDataList[0].RewardTime - TimeUtil.Instance.GetServerTimeStamp();
			this.SetTimeText(num);
			if (num <= 1.0)
			{
				rewardDataList[0].HasUnlock = true;
				return;
			}
		}
		else
		{
			bool flag2 = rewardDataList[0].RewardState == ETimePointRewardState.UnlockAndUnClaimed;
			base.GetText(8).SetUIActive(!flag2);
			base.GetButton(7).RootUIComp.Get().SetUIActive(flag2);
			if (!this.IsFirstPlayIdle)
			{
				base.GetSpine(12).SetAnimation(0, "start", false).AnimationComplete.Add(delegate(UTrackEntry _)
				{
					base.GetSpine(12).SetAnimation(0, "idle", true);
				});
				this.IsFirstPlayIdle = true;
			}
		}
	}

	// Token: 0x06004CA3 RID: 19619 RVA: 0x001A023C File Offset: 0x0019E43C
	private void OnClickRewardAllBtn()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		if (rewardDataList[0].RewardState != ETimePointRewardState.UnlockAndUnClaimed)
		{
			return;
		}
		ActivityTimePointRewardController.Instance.GetRewardById(this.ActivityTimePointRewardData.Id, rewardDataList[0].Id);
	}

	// Token: 0x06004CA4 RID: 19620 RVA: 0x001A0286 File Offset: 0x0019E486
	[NullableContext(1)]
	private void OnRewardItemClick(MediumItemGridExtendCallback callbackParameter)
	{
		ItemController.Instance.OpenItemTipsByItemId(((TItem)callbackParameter.Data).ItemData.ItemId, true, null, false);
	}

	// Token: 0x06004CA5 RID: 19621 RVA: 0x001A02AC File Offset: 0x0019E4AC
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
			UUIText text = base.GetText(4);
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
			UUIText text2 = base.GetText(4);
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
			UUIText text3 = base.GetText(4);
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
		UUIText text4 = base.GetText(4);
		string textStringId4 = "CelebrationAwardLeftTimeLessSecond";
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#f39233>");
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Max(Math.Floor(num), 1.0));
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		instance4.SetLocalTextNew(text4, textStringId4, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
	}

	// Token: 0x06004CA6 RID: 19622 RVA: 0x001A0582 File Offset: 0x0019E782
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardItem();
		this.RefreshRewardState();
	}

	// Token: 0x06004CA7 RID: 19623 RVA: 0x001A05A0 File Offset: 0x0019E7A0
	private void RefreshTimeTitle()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityTimePointRewardData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x06004CA8 RID: 19624 RVA: 0x001A05E6 File Offset: 0x0019E7E6
	protected override void OnTimer(float gap)
	{
		this.RefreshRewardState();
		this.RefreshTimeTitle();
	}

	// Token: 0x0400383F RID: 14399
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x04003840 RID: 14400
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003841 RID: 14401
	private SmallItemGrid RewardGirdA;

	// Token: 0x04003842 RID: 14402
	private SmallItemGrid RewardGirdB;

	// Token: 0x04003843 RID: 14403
	private bool IsFirstPlayIdle;

	// Token: 0x04003844 RID: 14404
	private bool HaveShowStart;

	// Token: 0x02006939 RID: 26937
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022A7D RID: 141949
		public const int TitleItem = 0;

		// Token: 0x04022A7E RID: 141950
		public const int RewardBtnA = 1;

		// Token: 0x04022A7F RID: 141951
		public const int RewardBtnB = 2;

		// Token: 0x04022A80 RID: 141952
		public const int DesText = 3;

		// Token: 0x04022A81 RID: 141953
		public const int TimeText = 4;

		// Token: 0x04022A82 RID: 141954
		public const int AllTimeText = 5;

		// Token: 0x04022A83 RID: 141955
		public const int GetItem = 6;

		// Token: 0x04022A84 RID: 141956
		public const int GetBtn = 7;

		// Token: 0x04022A85 RID: 141957
		public const int GetText = 8;

		// Token: 0x04022A86 RID: 141958
		public const int RewardItemA = 9;

		// Token: 0x04022A87 RID: 141959
		public const int RewardItemB = 10;

		// Token: 0x04022A88 RID: 141960
		public const int BgSpine = 11;

		// Token: 0x04022A89 RID: 141961
		public const int GetItemSpine = 12;
	}
}
