using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200156F RID: 5487
[NullableContext(1)]
[Nullable(0)]
public class ActivityVersionPreheatSubView : ActivitySubViewBase
{
	// Token: 0x06009CEB RID: 40171 RVA: 0x0021EF6C File Offset: 0x0021D16C
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

	// Token: 0x06009CEC RID: 40172 RVA: 0x0021F09C File Offset: 0x0021D29C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityVersionPreheatSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityVersionPreheatSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009CED RID: 40173 RVA: 0x0021F0DF File Offset: 0x0021D2DF
	protected override void OnBeforeDestroy()
	{
		this.QuestItemList.Clear();
	}

	// Token: 0x06009CEE RID: 40174 RVA: 0x0021F0EC File Offset: 0x0021D2EC
	protected override void OnStart()
	{
	}

	// Token: 0x06009CEF RID: 40175 RVA: 0x0021F0EE File Offset: 0x0021D2EE
	protected override void OnRefreshView()
	{
		this.RefreshQuests();
		this.RefreshActivityInfo();
		this.RefreshBonus();
	}

	// Token: 0x06009CF0 RID: 40176 RVA: 0x0021F104 File Offset: 0x0021D304
	protected override void OnTimer(float gap)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.ActivityInfoItem.RefreshSubTitleExternal(item, item2);
	}

	// Token: 0x06009CF1 RID: 40177 RVA: 0x0021F134 File Offset: 0x0021D334
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

	// Token: 0x06009CF2 RID: 40178 RVA: 0x0021F244 File Offset: 0x0021D444
	private void RefreshActivityInfo()
	{
		VersionPreheatActivityInfoData data = VersionPreheatModel.Instance.BuildActivityInfoData();
		this.ActivityInfoItem.RefreshExternal(data);
	}

	// Token: 0x06009CF3 RID: 40179 RVA: 0x0021F268 File Offset: 0x0021D468
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

	// Token: 0x040044E1 RID: 17633
	private List<VersionPreheatQuestItem> QuestItemList = new List<VersionPreheatQuestItem>();

	// Token: 0x040044E2 RID: 17634
	private VersionPreheatBonusItem BonusItem;

	// Token: 0x040044E3 RID: 17635
	private VersionPreheatActivityItem ActivityInfoItem;

	// Token: 0x040044E4 RID: 17636
	private readonly int[] PreheatItemIndexList = new int[]
	{
		0,
		1,
		2,
		3,
		4,
		5
	};

	// Token: 0x02007B99 RID: 31641
	[NullableContext(0)]
	internal class EComponent
	{
		// Token: 0x04028A0B RID: 166411
		public const int PreheatItem1 = 0;

		// Token: 0x04028A0C RID: 166412
		public const int PreheatItem2 = 1;

		// Token: 0x04028A0D RID: 166413
		public const int PreheatItem3 = 2;

		// Token: 0x04028A0E RID: 166414
		public const int PreheatItem4 = 3;

		// Token: 0x04028A0F RID: 166415
		public const int PreheatItem5 = 4;

		// Token: 0x04028A10 RID: 166416
		public const int PreheatItem6 = 5;

		// Token: 0x04028A11 RID: 166417
		public const int BonusItem = 6;

		// Token: 0x04028A12 RID: 166418
		public const int ActivityInfoItem = 7;
	}
}
