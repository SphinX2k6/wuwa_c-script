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

// Token: 0x020013DD RID: 5085
public class ActivitySubViewPhantomCollect : ActivitySubViewBase
{
	// Token: 0x06008F99 RID: 36761 RVA: 0x001F064C File Offset: 0x001EE84C
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

	// Token: 0x06008F9A RID: 36762 RVA: 0x001F075A File Offset: 0x001EE95A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomCollectUpdate, new Action<PhantomCollectRewardType>(this.OnPhantomCollectUpdate));
	}

	// Token: 0x06008F9B RID: 36763 RVA: 0x001F0778 File Offset: 0x001EE978
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomCollectUpdate, new Action<PhantomCollectRewardType>(this.OnPhantomCollectUpdate));
	}

	// Token: 0x06008F9C RID: 36764 RVA: 0x001F0796 File Offset: 0x001EE996
	private void OnPhantomCollectUpdate(PhantomCollectRewardType reawrdType)
	{
		this.RefreshTaskLayout();
	}

	// Token: 0x06008F9D RID: 36765 RVA: 0x001F079E File Offset: 0x001EE99E
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityPhantomCollectData)this.ActivityBaseData;
	}

	// Token: 0x06008F9E RID: 36766 RVA: 0x001F07B4 File Offset: 0x001EE9B4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewPhantomCollect.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewPhantomCollect.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008F9F RID: 36767 RVA: 0x001F07F7 File Offset: 0x001EE9F7
	protected override void OnStart()
	{
		this.ActivityData = ActivityPhantomCollectController.Instance.GetCurrentActivityDataById();
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
	}

	// Token: 0x06008FA0 RID: 36768 RVA: 0x001F0830 File Offset: 0x001EEA30
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshTaskLayout();
		this.RefreshMonster();
	}

	// Token: 0x06008FA1 RID: 36769 RVA: 0x001F0844 File Offset: 0x001EEA44
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

	// Token: 0x06008FA2 RID: 36770 RVA: 0x001F0884 File Offset: 0x001EEA84
	public void RefreshTaskLayout()
	{
		ActivityPhantomCollectData currentActivityDataById = ActivityPhantomCollectController.Instance.GetCurrentActivityDataById();
		this.TaskGenericLayout.RefreshByDataAsync(((currentActivityDataById != null) ? currentActivityDataById.PhantomCollectRewardList : null) ?? new PhantomCollectReward[0], false, null);
	}

	// Token: 0x06008FA3 RID: 36771 RVA: 0x001F08C8 File Offset: 0x001EEAC8
	public void RefreshMonster()
	{
		int[] collectPhantomList = this.ActivityData.GetCollectPhantomList();
		for (int i = 0; i < 5; i++)
		{
			this.MonsterItemList[i].Refresh(collectPhantomList[i]);
		}
	}

	// Token: 0x04003F77 RID: 16247
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<ActivitySubViewPhantomCollectTaskItem, PhantomCollectReward> TaskGenericLayout;

	// Token: 0x04003F78 RID: 16248
	[Nullable(2)]
	public ActivityPhantomCollectData ActivityData;

	// Token: 0x04003F79 RID: 16249
	[Nullable(2)]
	public ActivityTitleTypeA TitleComponent;

	// Token: 0x04003F7A RID: 16250
	[Nullable(1)]
	public List<ActivitySubViewPhantomCollectMonsterItem> MonsterItemList = new List<ActivitySubViewPhantomCollectMonsterItem>();

	// Token: 0x04003F7B RID: 16251
	[Nullable(1)]
	private readonly Func<ActivitySubViewPhantomCollectTaskItem> CreateGrid = () => new ActivitySubViewPhantomCollectTaskItem();

	// Token: 0x02007A5C RID: 31324
	private class EActivitySubViewPhantomCollect
	{
		// Token: 0x0402844C RID: 164940
		public const int TitleItem = 0;

		// Token: 0x0402844D RID: 164941
		public const int PhantomCollectItem1 = 1;

		// Token: 0x0402844E RID: 164942
		public const int PhantomCollectItem2 = 2;

		// Token: 0x0402844F RID: 164943
		public const int PhantomCollectItem3 = 3;

		// Token: 0x04028450 RID: 164944
		public const int PhantomCollectItem4 = 4;

		// Token: 0x04028451 RID: 164945
		public const int PhantomCollectItem5 = 5;

		// Token: 0x04028452 RID: 164946
		public const int VerticalLayout = 6;
	}
}
