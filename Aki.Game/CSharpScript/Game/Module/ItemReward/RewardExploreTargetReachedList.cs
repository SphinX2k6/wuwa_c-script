using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200580A RID: 22538
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreTargetReachedList : UiPanelBase
	{
		// Token: 0x060394A1 RID: 234657 RVA: 0x00D963A4 File Offset: 0x00D945A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060394A2 RID: 234658 RVA: 0x00D9640D File Offset: 0x00D9460D
		protected override void OnStart()
		{
			this.BarVerticalItem = base.GetItem(0);
			this.RewardExploreBarItem = base.GetItem(1);
			UUIItem rewardExploreBarItem = this.RewardExploreBarItem;
			if (rewardExploreBarItem == null)
			{
				return;
			}
			rewardExploreBarItem.SetUIActive(false);
		}

		// Token: 0x060394A3 RID: 234659 RVA: 0x00D9643A File Offset: 0x00D9463A
		protected override void OnBeforeDestroy()
		{
			this.BarVerticalItem = null;
			this.RewardExploreBarItem = null;
			this.ClearAllRewardExploreBar();
		}

		// Token: 0x060394A4 RID: 234660 RVA: 0x00D96450 File Offset: 0x00D94650
		public void SetBarList(IRewardExploreTargetReached[] exploreBarDataList)
		{
			this.ClearAllRewardExploreBar();
			UUIItem item = base.GetItem(0);
			if (exploreBarDataList == null || exploreBarDataList.Length == 0)
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				return;
			}
			foreach (IRewardExploreTargetReached rewardTargetReachedData in exploreBarDataList)
			{
				this.NewRewardExploreBar(rewardTargetReachedData);
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
		}

		// Token: 0x060394A5 RID: 234661 RVA: 0x00D964A4 File Offset: 0x00D946A4
		private void NewRewardExploreBar(IRewardExploreTargetReached rewardTargetReachedData)
		{
			LguiUtil instance = LguiUtil.Instance;
			UUIItem rewardExploreBarItem = this.RewardExploreBarItem;
			RewardExploreTargetReached rewardExploreTargetReached = new RewardExploreTargetReached(instance.DuplicateActor((rewardExploreBarItem != null) ? rewardExploreBarItem.GetOwner() : null, this.BarVerticalItem));
			rewardExploreTargetReached.Refresh(rewardTargetReachedData);
			rewardExploreTargetReached.SetActive(true);
			this.RewardExploreBarList.Add(rewardExploreTargetReached);
		}

		// Token: 0x060394A6 RID: 234662 RVA: 0x00D964F4 File Offset: 0x00D946F4
		private void ClearAllRewardExploreBar()
		{
			foreach (RewardExploreTargetReached rewardExploreTargetReached in this.RewardExploreBarList)
			{
				rewardExploreTargetReached.Destroy(null);
			}
			this.RewardExploreBarList.Clear();
		}

		// Token: 0x0401DF57 RID: 122711
		private UUIItem RewardExploreBarItem;

		// Token: 0x0401DF58 RID: 122712
		private UUIItem BarVerticalItem;

		// Token: 0x0401DF59 RID: 122713
		private readonly List<RewardExploreTargetReached> RewardExploreBarList = new List<RewardExploreTargetReached>();

		// Token: 0x0200BA0B RID: 47627
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040383C2 RID: 230338
			public const int BarVerticalItem = 0;

			// Token: 0x040383C3 RID: 230339
			public const int RewardTargetReachedItem = 1;
		}
	}
}
