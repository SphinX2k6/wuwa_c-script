using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000891 RID: 2193
public class ActivitySubViewPhantomCollect : ActivitySubViewBase
{
	// Token: 0x0600632E RID: 25390 RVA: 0x001F9188 File Offset: 0x001F7388
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
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
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600632F RID: 25391 RVA: 0x001F9296 File Offset: 0x001F7496
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomCollectUpdate, new Action<PhantomCollectRewardType>(this.OnPhantomCollectUpdate));
	}

	// Token: 0x06006330 RID: 25392 RVA: 0x001F92B4 File Offset: 0x001F74B4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomCollectUpdate, new Action<PhantomCollectRewardType>(this.OnPhantomCollectUpdate));
	}

	// Token: 0x06006331 RID: 25393 RVA: 0x001F92D2 File Offset: 0x001F74D2
	private void OnPhantomCollectUpdate(PhantomCollectRewardType reawrdType)
	{
		this.RefreshTaskLayout();
	}

	// Token: 0x06006332 RID: 25394 RVA: 0x001F92DA File Offset: 0x001F74DA
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityPhantomCollectData)this.ActivityBaseData;
	}

	// Token: 0x06006333 RID: 25395 RVA: 0x001F92F0 File Offset: 0x001F74F0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewPhantomCollect.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewPhantomCollect.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006334 RID: 25396 RVA: 0x001F9333 File Offset: 0x001F7533
	protected override void OnStart()
	{
		this.ActivityData = ActivityPhantomCollectController.Instance.GetCurrentActivityDataById();
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
	}

	// Token: 0x06006335 RID: 25397 RVA: 0x001F936C File Offset: 0x001F756C
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshTaskLayout();
		this.RefreshMonster();
	}

	// Token: 0x06006336 RID: 25398 RVA: 0x001F9380 File Offset: 0x001F7580
	public void RefreshTimerText()
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

	// Token: 0x06006337 RID: 25399 RVA: 0x001F93C0 File Offset: 0x001F75C0
	public void RefreshTaskLayout()
	{
		ActivityPhantomCollectData currentActivityDataById = ActivityPhantomCollectController.Instance.GetCurrentActivityDataById();
		this.TaskGenericLayout.RefreshByDataAsync(((currentActivityDataById != null) ? currentActivityDataById.PhantomCollectRewardList : null) ?? new PhantomCollectReward[0], false, null);
	}

	// Token: 0x06006338 RID: 25400 RVA: 0x001F9404 File Offset: 0x001F7604
	public void RefreshMonster()
	{
		int[] collectPhantomList = this.ActivityData.GetCollectPhantomList();
		for (int i = 0; i < 5; i++)
		{
			this.MonsterItemList[i].Refresh(collectPhantomList[i]);
		}
	}

	// Token: 0x0400400F RID: 16399
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<ActivitySubViewPhantomCollectTaskItem, PhantomCollectReward> TaskGenericLayout;

	// Token: 0x04004010 RID: 16400
	[Nullable(2)]
	public ActivityPhantomCollectData ActivityData;

	// Token: 0x04004011 RID: 16401
	[Nullable(2)]
	public ActivityTitleTypeA TitleComponent;

	// Token: 0x04004012 RID: 16402
	[Nullable(1)]
	public List<ActivitySubViewPhantomCollectMonsterItem> MonsterItemList = new List<ActivitySubViewPhantomCollectMonsterItem>();

	// Token: 0x04004013 RID: 16403
	[Nullable(1)]
	private readonly Func<ActivitySubViewPhantomCollectTaskItem> CreateGrid = () => new ActivitySubViewPhantomCollectTaskItem();

	// Token: 0x02006BE0 RID: 27616
	private class EActivitySubViewPhantomCollect
	{
		// Token: 0x04023766 RID: 145254
		public const int TitleItem = 0;

		// Token: 0x04023767 RID: 145255
		public const int PhantomCollectItem1 = 1;

		// Token: 0x04023768 RID: 145256
		public const int PhantomCollectItem2 = 2;

		// Token: 0x04023769 RID: 145257
		public const int PhantomCollectItem3 = 3;

		// Token: 0x0402376A RID: 145258
		public const int PhantomCollectItem4 = 4;

		// Token: 0x0402376B RID: 145259
		public const int PhantomCollectItem5 = 5;

		// Token: 0x0402376C RID: 145260
		public const int VerticalLayout = 6;
	}
}
