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

// Token: 0x020011C2 RID: 4546
[NullableContext(2)]
[Nullable(0)]
public class CelebrationAwardSubView : ActivitySubViewBase
{
	// Token: 0x06007903 RID: 30979 RVA: 0x00196F08 File Offset: 0x00195108
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

	// Token: 0x06007904 RID: 30980 RVA: 0x0019713F File Offset: 0x0019533F
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x06007905 RID: 30981 RVA: 0x00197154 File Offset: 0x00195354
	protected override UniTask OnBeforeStartAsync()
	{
		CelebrationAwardSubView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CelebrationAwardSubView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007906 RID: 30982 RVA: 0x00197197 File Offset: 0x00195397
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06007907 RID: 30983 RVA: 0x001971B5 File Offset: 0x001953B5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06007908 RID: 30984 RVA: 0x001971D4 File Offset: 0x001953D4
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

	// Token: 0x06007909 RID: 30985 RVA: 0x001972A2 File Offset: 0x001954A2
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

	// Token: 0x0600790A RID: 30986 RVA: 0x001972CC File Offset: 0x001954CC
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

	// Token: 0x0600790B RID: 30987 RVA: 0x00197478 File Offset: 0x00195678
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

	// Token: 0x0600790C RID: 30988 RVA: 0x0019758C File Offset: 0x0019578C
	private void OnClickRewardAllBtn()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		if (rewardDataList[0].RewardState != ETimePointRewardState.UnlockAndUnClaimed)
		{
			return;
		}
		ActivityTimePointRewardController.Instance.GetRewardById(this.ActivityTimePointRewardData.Id, rewardDataList[0].Id);
	}

	// Token: 0x0600790D RID: 30989 RVA: 0x001975D6 File Offset: 0x001957D6
	[NullableContext(1)]
	private void OnRewardItemClick(MediumItemGridExtendCallback callbackParameter)
	{
		ItemController.Instance.OpenItemTipsByItemId(((TItem)callbackParameter.Data).ItemData.ItemId, true, null);
	}

	// Token: 0x0600790E RID: 30990 RVA: 0x001975FC File Offset: 0x001957FC
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

	// Token: 0x0600790F RID: 30991 RVA: 0x001978D2 File Offset: 0x00195AD2
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardItem();
		this.RefreshRewardState();
	}

	// Token: 0x06007910 RID: 30992 RVA: 0x001978F0 File Offset: 0x00195AF0
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

	// Token: 0x06007911 RID: 30993 RVA: 0x00197936 File Offset: 0x00195B36
	protected override void OnTimer(float gap)
	{
		this.RefreshRewardState();
		this.RefreshTimeTitle();
	}

	// Token: 0x040037A6 RID: 14246
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x040037A7 RID: 14247
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040037A8 RID: 14248
	private SmallItemGrid RewardGirdA;

	// Token: 0x040037A9 RID: 14249
	private SmallItemGrid RewardGirdB;

	// Token: 0x040037AA RID: 14250
	private bool IsFirstPlayIdle;

	// Token: 0x040037AB RID: 14251
	private bool HaveShowStart;

	// Token: 0x020077AE RID: 30638
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402774B RID: 161611
		public const int TitleItem = 0;

		// Token: 0x0402774C RID: 161612
		public const int RewardBtnA = 1;

		// Token: 0x0402774D RID: 161613
		public const int RewardBtnB = 2;

		// Token: 0x0402774E RID: 161614
		public const int DesText = 3;

		// Token: 0x0402774F RID: 161615
		public const int TimeText = 4;

		// Token: 0x04027750 RID: 161616
		public const int AllTimeText = 5;

		// Token: 0x04027751 RID: 161617
		public const int GetItem = 6;

		// Token: 0x04027752 RID: 161618
		public const int GetBtn = 7;

		// Token: 0x04027753 RID: 161619
		public const int GetText = 8;

		// Token: 0x04027754 RID: 161620
		public const int RewardItemA = 9;

		// Token: 0x04027755 RID: 161621
		public const int RewardItemB = 10;

		// Token: 0x04027756 RID: 161622
		public const int BgSpine = 11;

		// Token: 0x04027757 RID: 161623
		public const int GetItemSpine = 12;
	}
}
