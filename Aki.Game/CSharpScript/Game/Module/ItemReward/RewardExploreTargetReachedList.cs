using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047E1 RID: 18401
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreTargetReachedList : UiPanelBase
	{
		// Token: 0x0602E3B5 RID: 189365 RVA: 0x00CE520C File Offset: 0x00CE340C
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

		// Token: 0x0602E3B6 RID: 189366 RVA: 0x00CE5275 File Offset: 0x00CE3475
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

		// Token: 0x0602E3B7 RID: 189367 RVA: 0x00CE52A2 File Offset: 0x00CE34A2
		protected override void OnBeforeDestroy()
		{
			this.BarVerticalItem = null;
			this.RewardExploreBarItem = null;
			this.ClearAllRewardExploreBar();
		}

		// Token: 0x0602E3B8 RID: 189368 RVA: 0x00CE52B8 File Offset: 0x00CE34B8
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

		// Token: 0x0602E3B9 RID: 189369 RVA: 0x00CE530C File Offset: 0x00CE350C
		private void NewRewardExploreBar(IRewardExploreTargetReached rewardTargetReachedData)
		{
			LguiUtil instance = LguiUtil.Instance;
			UUIItem rewardExploreBarItem = this.RewardExploreBarItem;
			RewardExploreTargetReached rewardExploreTargetReached = new RewardExploreTargetReached(instance.DuplicateActor((rewardExploreBarItem != null) ? rewardExploreBarItem.GetOwner() : null, this.BarVerticalItem));
			rewardExploreTargetReached.Refresh(rewardTargetReachedData);
			rewardExploreTargetReached.SetActive(true);
			this.RewardExploreBarList.Add(rewardExploreTargetReached);
		}

		// Token: 0x0602E3BA RID: 189370 RVA: 0x00CE535C File Offset: 0x00CE355C
		private void ClearAllRewardExploreBar()
		{
			foreach (RewardExploreTargetReached rewardExploreTargetReached in this.RewardExploreBarList)
			{
				rewardExploreTargetReached.Destroy(null);
			}
			this.RewardExploreBarList.Clear();
		}

		// Token: 0x040189EE RID: 100846
		private UUIItem RewardExploreBarItem;

		// Token: 0x040189EF RID: 100847
		private UUIItem BarVerticalItem;

		// Token: 0x040189F0 RID: 100848
		private readonly List<RewardExploreTargetReached> RewardExploreBarList = new List<RewardExploreTargetReached>();

		// Token: 0x0200A421 RID: 42017
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032DAF RID: 208303
			public const int BarVerticalItem = 0;

			// Token: 0x04032DB0 RID: 208304
			public const int RewardTargetReachedItem = 1;
		}
	}
}
