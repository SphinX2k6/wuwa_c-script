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

// Token: 0x020013D6 RID: 5078
public class ActivitySubViewNoviceJourney : ActivitySubViewBase
{
	// Token: 0x06008F55 RID: 36693 RVA: 0x001EF7F8 File Offset: 0x001ED9F8
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

	// Token: 0x06008F56 RID: 36694 RVA: 0x001EF8C4 File Offset: 0x001EDAC4
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNoviceJourneyData);
	}

	// Token: 0x06008F57 RID: 36695 RVA: 0x001EF8D8 File Offset: 0x001EDAD8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewNoviceJourney.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewNoviceJourney.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008F58 RID: 36696 RVA: 0x001EF91B File Offset: 0x001EDB1B
	[NullableContext(1)]
	private NoviceJourneyItem InitItem()
	{
		NoviceJourneyItem noviceJourneyItem = new NoviceJourneyItem();
		noviceJourneyItem.SetActivityData(this.ActivityData);
		return noviceJourneyItem;
	}

	// Token: 0x06008F59 RID: 36697 RVA: 0x001EF92E File Offset: 0x001EDB2E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.NoticeJourneyReceive, new Action<int>(this.OnNoticeJourneyReceive));
	}

	// Token: 0x06008F5A RID: 36698 RVA: 0x001EF94C File Offset: 0x001EDB4C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.NoticeJourneyReceive, new Action<int>(this.OnNoticeJourneyReceive));
	}

	// Token: 0x06008F5B RID: 36699 RVA: 0x001EF96A File Offset: 0x001EDB6A
	private void OnNoticeJourneyReceive(int level)
	{
		this.Layout.GetLayoutItemByKey(level).RefreshCurrentState();
	}

	// Token: 0x06008F5C RID: 36700 RVA: 0x001EF984 File Offset: 0x001EDB84
	protected override void OnStart()
	{
		this.RemainTime = base.GetText(1);
		this.IsRemainTimeActive = (this.ActivityData.EndShowTime != 0L);
		this.RemainTime.SetUIActive(this.ActivityData.EndShowTime != 0L);
		int? playerLevel = PlayerInfoModel.Instance.GetPlayerLevel();
		base.GetText(0).SetText(playerLevel.ToString(), true);
		base.GetText(4).SetText(this.ActivityData.GetTitle(), true);
	}

	// Token: 0x06008F5D RID: 36701 RVA: 0x001EFA0A File Offset: 0x001EDC0A
	protected override void OnBeforeShow()
	{
		this.SetRemainTimeText();
	}

	// Token: 0x06008F5E RID: 36702 RVA: 0x001EFA14 File Offset: 0x001EDC14
	protected override void OnBeforeDestroy()
	{
		foreach (NoviceJourneyItem child in this.Layout.GetLayoutItemList())
		{
			base.AddChild(child);
		}
	}

	// Token: 0x06008F5F RID: 36703 RVA: 0x001EFA6C File Offset: 0x001EDC6C
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		this.RemainTime.SetUIActive(isActive);
	}

	// Token: 0x06008F60 RID: 36704 RVA: 0x001EFA8C File Offset: 0x001EDC8C
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

	// Token: 0x06008F61 RID: 36705 RVA: 0x001EFAC3 File Offset: 0x001EDCC3
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x04003F6A RID: 16234
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NoviceJourneyItem, NewbieCourse> Layout;

	// Token: 0x04003F6B RID: 16235
	[Nullable(2)]
	private UUIText RemainTime;

	// Token: 0x04003F6C RID: 16236
	private bool IsRemainTimeActive = true;

	// Token: 0x04003F6D RID: 16237
	[Nullable(2)]
	private ActivityNoviceJourneyData ActivityData;

	// Token: 0x02007A52 RID: 31314
	private class EComponents
	{
		// Token: 0x04028422 RID: 164898
		public const int LevelText = 0;

		// Token: 0x04028423 RID: 164899
		public const int RemainTimeText = 1;

		// Token: 0x04028424 RID: 164900
		public const int Layout = 2;

		// Token: 0x04028425 RID: 164901
		public const int GridItem = 3;

		// Token: 0x04028426 RID: 164902
		public const int TitleText = 4;
	}
}
