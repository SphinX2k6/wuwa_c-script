using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000645 RID: 1605
public class ActivitySubViewBeginnerBook : ActivitySubViewBase
{
	// Token: 0x06004A9F RID: 19103 RVA: 0x00195CB0 File Offset: 0x00193EB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004AA0 RID: 19104 RVA: 0x00195D9D File Offset: 0x00193F9D
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityBeginnerBookData);
	}

	// Token: 0x06004AA1 RID: 19105 RVA: 0x00195DB0 File Offset: 0x00193FB0
	protected override void OnStart()
	{
		base.GetText(0).SetText(this.ActivityData.GetTitle(), true);
		this.TargetLayout = new GenericLayout<ActivityBeginnerTargetItem, int>(base.GetVerticalLayout(2), this.InitItem, base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		this.RemainTime = base.GetText(1);
		this.IsRemainTimeActive = (this.ActivityData.EndShowTime != 0L);
		this.RemainTime.SetUIActive(this.ActivityData.EndShowTime != 0L);
		this.SetRemainTimeText();
	}

	// Token: 0x06004AA2 RID: 19106 RVA: 0x00195E7C File Offset: 0x0019407C
	protected override UniTask OnBeforeShowSelfAsync()
	{
		ActivitySubViewBeginnerBook.<OnBeforeShowSelfAsync>d__8 <OnBeforeShowSelfAsync>d__;
		<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowSelfAsync>d__.<>4__this = this;
		<OnBeforeShowSelfAsync>d__.<>1__state = -1;
		<OnBeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewBeginnerBook.<OnBeforeShowSelfAsync>d__8>(ref <OnBeforeShowSelfAsync>d__);
		return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004AA3 RID: 19107 RVA: 0x00195EBF File Offset: 0x001940BF
	protected override void OnRefreshView()
	{
		GenericLayout<ActivityBeginnerTargetItem, int> targetLayout = this.TargetLayout;
		if (targetLayout == null)
		{
			return;
		}
		targetLayout.RefreshByData(this.ActivityData.AllBeginnerTargetList, delegate
		{
			GenericLayout<ActivityBeginnerTargetItem, int> targetLayout2 = this.TargetLayout;
			List<ActivityBeginnerTargetItem> list = (targetLayout2 != null) ? targetLayout2.GetLayoutItemList() : null;
			ActivityBeginnerBookData activityBeginnerBookData = this.ActivityBaseData as ActivityBeginnerBookData;
			foreach (ActivityBeginnerTargetItem activityBeginnerTargetItem in list)
			{
				activityBeginnerTargetItem.SetEnableJump(activityBeginnerBookData.GetEnableJump(activityBeginnerTargetItem.DataId));
				activityBeginnerTargetItem.SetFinish(activityBeginnerBookData.GetFinishState(activityBeginnerTargetItem.DataId));
			}
		}, false);
	}

	// Token: 0x06004AA4 RID: 19108 RVA: 0x00195EE9 File Offset: 0x001940E9
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		this.RemainTime.SetUIActive(isActive);
	}

	// Token: 0x06004AA5 RID: 19109 RVA: 0x00195F08 File Offset: 0x00194108
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

	// Token: 0x06004AA6 RID: 19110 RVA: 0x00195F3F File Offset: 0x0019413F
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x0400372B RID: 14123
	[Nullable(2)]
	private UUIText RemainTime;

	// Token: 0x0400372C RID: 14124
	private bool IsRemainTimeActive = true;

	// Token: 0x0400372D RID: 14125
	[Nullable(2)]
	private ActivityBeginnerBookData ActivityData;

	// Token: 0x0400372E RID: 14126
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityBeginnerTargetItem, int> TargetLayout;

	// Token: 0x0400372F RID: 14127
	[Nullable(1)]
	private readonly Func<ActivityBeginnerTargetItem> InitItem = () => new ActivityBeginnerTargetItem();

	// Token: 0x02006903 RID: 26883
	private class EChildType
	{
		// Token: 0x040229AF RID: 141743
		public const int TitleText = 0;

		// Token: 0x040229B0 RID: 141744
		public const int RemainTimeText = 1;

		// Token: 0x040229B1 RID: 141745
		public const int TargetLayout = 2;

		// Token: 0x040229B2 RID: 141746
		public const int LayouetItem = 3;

		// Token: 0x040229B3 RID: 141747
		public const int FemaleItem = 4;

		// Token: 0x040229B4 RID: 141748
		public const int MaleItem = 5;
	}
}
