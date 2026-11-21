using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000A27 RID: 2599
[NullableContext(1)]
[Nullable(0)]
public class ActivityVersionPreheatSubView : ActivitySubViewBase
{
	// Token: 0x060070C9 RID: 28873 RVA: 0x00228D1C File Offset: 0x00226F1C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
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
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060070CA RID: 28874 RVA: 0x00228E4C File Offset: 0x0022704C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityVersionPreheatSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityVersionPreheatSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060070CB RID: 28875 RVA: 0x00228E8F File Offset: 0x0022708F
	protected override void OnBeforeDestroy()
	{
		this.QuestItemList.Clear();
	}

	// Token: 0x060070CC RID: 28876 RVA: 0x00228E9C File Offset: 0x0022709C
	protected override void OnStart()
	{
	}

	// Token: 0x060070CD RID: 28877 RVA: 0x00228E9E File Offset: 0x0022709E
	protected override void OnRefreshView()
	{
		this.RefreshQuests();
		this.RefreshActivityInfo();
		this.RefreshBonus();
	}

	// Token: 0x060070CE RID: 28878 RVA: 0x00228EB4 File Offset: 0x002270B4
	protected override void OnTimer(float gap)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.ActivityInfoItem.RefreshSubTitleExternal(item, item2);
	}

	// Token: 0x060070CF RID: 28879 RVA: 0x00228EE4 File Offset: 0x002270E4
	private unsafe void RefreshQuests()
	{
		List<VersionPreheatQuestData> list = VersionPreheatModel.Instance.BuildQuestDataList();
		if (this.QuestItemList.Count != list.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.VersionPreheat;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "任务数据个数与任务ui个数不匹配，隐藏全部任务面板";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("item count", this.QuestItemList.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("data count", list.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			foreach (VersionPreheatQuestItem versionPreheatQuestItem in this.QuestItemList)
			{
				versionPreheatQuestItem.SetUiActive(false);
			}
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			VersionPreheatQuestData data = list[i];
			this.QuestItemList[i].RefreshExternalAsync(data);
		}
	}

	// Token: 0x060070D0 RID: 28880 RVA: 0x00228FF4 File Offset: 0x002271F4
	private void RefreshActivityInfo()
	{
		VersionPreheatActivityInfoData data = VersionPreheatModel.Instance.BuildActivityInfoData();
		this.ActivityInfoItem.RefreshExternal(data);
	}

	// Token: 0x060070D1 RID: 28881 RVA: 0x00229018 File Offset: 0x00227218
	private void RefreshBonus()
	{
		VersionPreheatModel instance = VersionPreheatModel.Instance;
		bool isBonusAvailable = instance.IsBonusAvailable;
		this.BonusItem.SetUiActive(isBonusAvailable);
		if (isBonusAvailable)
		{
			VersionPreheatBonusData data = instance.BuildBonusQuestData();
			this.BonusItem.RefreshExternalAsync(data);
		}
	}

	// Token: 0x04004587 RID: 17799
	private List<VersionPreheatQuestItem> QuestItemList = new List<VersionPreheatQuestItem>();

	// Token: 0x04004588 RID: 17800
	private VersionPreheatBonusItem BonusItem;

	// Token: 0x04004589 RID: 17801
	private VersionPreheatActivityItem ActivityInfoItem;

	// Token: 0x0400458A RID: 17802
	private readonly int[] PreheatItemIndexList = new int[]
	{
		0,
		1,
		2,
		3,
		4,
		5
	};

	// Token: 0x02006D24 RID: 27940
	[NullableContext(0)]
	internal class EComponent
	{
		// Token: 0x04023D46 RID: 146758
		public const int PreheatItem1 = 0;

		// Token: 0x04023D47 RID: 146759
		public const int PreheatItem2 = 1;

		// Token: 0x04023D48 RID: 146760
		public const int PreheatItem3 = 2;

		// Token: 0x04023D49 RID: 146761
		public const int PreheatItem4 = 3;

		// Token: 0x04023D4A RID: 146762
		public const int PreheatItem5 = 4;

		// Token: 0x04023D4B RID: 146763
		public const int PreheatItem6 = 5;

		// Token: 0x04023D4C RID: 146764
		public const int BonusItem = 6;

		// Token: 0x04023D4D RID: 146765
		public const int ActivityInfoItem = 7;
	}
}
