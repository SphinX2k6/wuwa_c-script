using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001191 RID: 4497
public class ActivitySubViewBeginnerBook : ActivitySubViewBase
{
	// Token: 0x06007708 RID: 30472 RVA: 0x0018D0C4 File Offset: 0x0018B2C4
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

	// Token: 0x06007709 RID: 30473 RVA: 0x0018D1B1 File Offset: 0x0018B3B1
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityBeginnerBookData);
	}

	// Token: 0x0600770A RID: 30474 RVA: 0x0018D1C4 File Offset: 0x0018B3C4
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

	// Token: 0x0600770B RID: 30475 RVA: 0x0018D290 File Offset: 0x0018B490
	protected override UniTask OnBeforeShowSelfAsync()
	{
		ActivitySubViewBeginnerBook.<OnBeforeShowSelfAsync>d__8 <OnBeforeShowSelfAsync>d__;
		<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowSelfAsync>d__.<>4__this = this;
		<OnBeforeShowSelfAsync>d__.<>1__state = -1;
		<OnBeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewBeginnerBook.<OnBeforeShowSelfAsync>d__8>(ref <OnBeforeShowSelfAsync>d__);
		return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600770C RID: 30476 RVA: 0x0018D2D3 File Offset: 0x0018B4D3
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

	// Token: 0x0600770D RID: 30477 RVA: 0x0018D2FD File Offset: 0x0018B4FD
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		this.RemainTime.SetUIActive(isActive);
	}

	// Token: 0x0600770E RID: 30478 RVA: 0x0018D31C File Offset: 0x0018B51C
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

	// Token: 0x0600770F RID: 30479 RVA: 0x0018D353 File Offset: 0x0018B553
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x04003692 RID: 13970
	[Nullable(2)]
	private UUIText RemainTime;

	// Token: 0x04003693 RID: 13971
	private bool IsRemainTimeActive = true;

	// Token: 0x04003694 RID: 13972
	[Nullable(2)]
	private ActivityBeginnerBookData ActivityData;

	// Token: 0x04003695 RID: 13973
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityBeginnerTargetItem, int> TargetLayout;

	// Token: 0x04003696 RID: 13974
	[Nullable(1)]
	private readonly Func<ActivityBeginnerTargetItem> InitItem = () => new ActivityBeginnerTargetItem();

	// Token: 0x02007776 RID: 30582
	private class EChildType
	{
		// Token: 0x04027676 RID: 161398
		public const int TitleText = 0;

		// Token: 0x04027677 RID: 161399
		public const int RemainTimeText = 1;

		// Token: 0x04027678 RID: 161400
		public const int TargetLayout = 2;

		// Token: 0x04027679 RID: 161401
		public const int LayouetItem = 3;

		// Token: 0x0402767A RID: 161402
		public const int FemaleItem = 4;

		// Token: 0x0402767B RID: 161403
		public const int MaleItem = 5;
	}
}
