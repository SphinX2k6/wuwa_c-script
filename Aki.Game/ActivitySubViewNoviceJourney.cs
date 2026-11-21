using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200088A RID: 2186
public class ActivitySubViewNoviceJourney : ActivitySubViewBase
{
	// Token: 0x060062EA RID: 25322 RVA: 0x001F8330 File Offset: 0x001F6530
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060062EB RID: 25323 RVA: 0x001F83FC File Offset: 0x001F65FC
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNoviceJourneyData);
	}

	// Token: 0x060062EC RID: 25324 RVA: 0x001F8410 File Offset: 0x001F6610
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewNoviceJourney.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewNoviceJourney.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060062ED RID: 25325 RVA: 0x001F8453 File Offset: 0x001F6653
	[NullableContext(1)]
	private NoviceJourneyItem InitItem()
	{
		NoviceJourneyItem noviceJourneyItem = new NoviceJourneyItem();
		noviceJourneyItem.SetActivityData(this.ActivityData);
		return noviceJourneyItem;
	}

	// Token: 0x060062EE RID: 25326 RVA: 0x001F8466 File Offset: 0x001F6666
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.NoticeJourneyReceive, new Action<int>(this.OnNoticeJourneyReceive));
	}

	// Token: 0x060062EF RID: 25327 RVA: 0x001F8484 File Offset: 0x001F6684
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.NoticeJourneyReceive, new Action<int>(this.OnNoticeJourneyReceive));
	}

	// Token: 0x060062F0 RID: 25328 RVA: 0x001F84A2 File Offset: 0x001F66A2
	private void OnNoticeJourneyReceive(int level)
	{
		this.Layout.GetLayoutItemByKey(level).RefreshCurrentState();
	}

	// Token: 0x060062F1 RID: 25329 RVA: 0x001F84BC File Offset: 0x001F66BC
	protected override void OnStart()
	{
		this.RemainTime = base.GetText(1);
		this.IsRemainTimeActive = (this.ActivityData.EndShowTime != 0L);
		this.RemainTime.SetUIActive(this.ActivityData.EndShowTime != 0L);
		int? playerLevel = PlayerInfoModel.Instance.GetPlayerLevel();
		base.GetText(0).SetText(playerLevel.ToString(), true);
		base.GetText(4).SetText(this.ActivityData.GetTitle(), true);
	}

	// Token: 0x060062F2 RID: 25330 RVA: 0x001F8542 File Offset: 0x001F6742
	protected override void OnBeforeShow()
	{
		this.SetRemainTimeText();
	}

	// Token: 0x060062F3 RID: 25331 RVA: 0x001F854C File Offset: 0x001F674C
	protected override void OnBeforeDestroy()
	{
		foreach (NoviceJourneyItem child in this.Layout.GetLayoutItemList())
		{
			base.AddChild(child);
		}
	}

	// Token: 0x060062F4 RID: 25332 RVA: 0x001F85A4 File Offset: 0x001F67A4
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		this.RemainTime.SetUIActive(isActive);
	}

	// Token: 0x060062F5 RID: 25333 RVA: 0x001F85C4 File Offset: 0x001F67C4
	private void SetRemainTimeText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.SetRemainTimeActive(item);
		if (item)
		{
			this.RemainTime.SetText(item2, true);
		}
	}

	// Token: 0x060062F6 RID: 25334 RVA: 0x001F85FB File Offset: 0x001F67FB
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x04004002 RID: 16386
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NoviceJourneyItem, NewbieCourse> Layout;

	// Token: 0x04004003 RID: 16387
	[Nullable(2)]
	private UUIText RemainTime;

	// Token: 0x04004004 RID: 16388
	private bool IsRemainTimeActive = true;

	// Token: 0x04004005 RID: 16389
	[Nullable(2)]
	private ActivityNoviceJourneyData ActivityData;

	// Token: 0x02006BD8 RID: 27608
	private class EComponents
	{
		// Token: 0x0402373F RID: 145215
		public const int LevelText = 0;

		// Token: 0x04023740 RID: 145216
		public const int RemainTimeText = 1;

		// Token: 0x04023741 RID: 145217
		public const int Layout = 2;

		// Token: 0x04023742 RID: 145218
		public const int GridItem = 3;

		// Token: 0x04023743 RID: 145219
		public const int TitleText = 4;
	}
}
