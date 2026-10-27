using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057FB RID: 22523
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreBarList : UiPanelBase
	{
		// Token: 0x06039434 RID: 234548 RVA: 0x00D9428C File Offset: 0x00D9248C
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
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x06039435 RID: 234549 RVA: 0x00D94300 File Offset: 0x00D92500
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

		// Token: 0x06039436 RID: 234550 RVA: 0x00D9432D File Offset: 0x00D9252D
		protected override void OnBeforeDestroy()
		{
			this.BarVerticalItem = null;
			this.RewardExploreBarItem = null;
			this.ClearAllRewardExploreBar();
		}

		// Token: 0x06039437 RID: 234551 RVA: 0x00D94344 File Offset: 0x00D92544
		public void Refresh(string tipsTextId, IReadOnlyList<IRewardExploreBar> exploreBarDataList)
		{
			bool flag = !StringUtils.IsEmpty(tipsTextId);
			if (flag)
			{
				this.SetTitleText(tipsTextId);
			}
			this.SetTitleTextVisible(flag);
			this.SetBarList(exploreBarDataList);
		}

		// Token: 0x06039438 RID: 234552 RVA: 0x00D94374 File Offset: 0x00D92574
		private void SetBarList(IReadOnlyList<IRewardExploreBar> exploreBarDataList)
		{
			this.ClearAllRewardExploreBar();
			UUIItem item = base.GetItem(0);
			if (exploreBarDataList == null || exploreBarDataList.Count == 0)
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				return;
			}
			foreach (IRewardExploreBar rewardExploreBarData in exploreBarDataList)
			{
				this.NewRewardExploreBar(rewardExploreBarData);
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
		}

		// Token: 0x06039439 RID: 234553 RVA: 0x00D943EC File Offset: 0x00D925EC
		private void SetTitleText(string titleTextId)
		{
		}

		// Token: 0x0603943A RID: 234554 RVA: 0x00D943EE File Offset: 0x00D925EE
		private void SetTitleTextVisible(bool bVisible)
		{
		}

		// Token: 0x0603943B RID: 234555 RVA: 0x00D943F0 File Offset: 0x00D925F0
		private void NewRewardExploreBar(IRewardExploreBar rewardExploreBarData)
		{
			TrainingItem trainingItem = new TrainingItem(LguiUtil.Instance.CopyItem(this.RewardExploreBarItem, this.BarVerticalItem));
			trainingItem.SetData(rewardExploreBarData.TrainingData);
			trainingItem.SetActive(true);
			this.RewardExploreBarListItem.Add(trainingItem);
		}

		// Token: 0x0603943C RID: 234556 RVA: 0x00D94438 File Offset: 0x00D92638
		private void ClearAllRewardExploreBar()
		{
			foreach (TrainingItem trainingItem in this.RewardExploreBarListItem)
			{
				trainingItem.Destroy(null);
			}
			this.RewardExploreBarListItem.Clear();
		}

		// Token: 0x0401DF31 RID: 122673
		[Nullable(2)]
		private UUIItem BarVerticalItem;

		// Token: 0x0401DF32 RID: 122674
		[Nullable(2)]
		private UUIItem RewardExploreBarItem;

		// Token: 0x0401DF33 RID: 122675
		private readonly List<TrainingItem> RewardExploreBarListItem = new List<TrainingItem>();

		// Token: 0x0200B9F0 RID: 47600
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038367 RID: 230247
			public const int BarVerticalItem = 0;

			// Token: 0x04038368 RID: 230248
			public const int RewardExploreBarItem = 1;
		}
	}
}
