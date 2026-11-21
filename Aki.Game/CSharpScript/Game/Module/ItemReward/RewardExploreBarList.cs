using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047D2 RID: 18386
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreBarList : UiPanelBase
	{
		// Token: 0x0602E348 RID: 189256 RVA: 0x00CE30D4 File Offset: 0x00CE12D4
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

		// Token: 0x0602E349 RID: 189257 RVA: 0x00CE3148 File Offset: 0x00CE1348
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

		// Token: 0x0602E34A RID: 189258 RVA: 0x00CE3175 File Offset: 0x00CE1375
		protected override void OnBeforeDestroy()
		{
			this.BarVerticalItem = null;
			this.RewardExploreBarItem = null;
			this.ClearAllRewardExploreBar();
		}

		// Token: 0x0602E34B RID: 189259 RVA: 0x00CE318C File Offset: 0x00CE138C
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

		// Token: 0x0602E34C RID: 189260 RVA: 0x00CE31BC File Offset: 0x00CE13BC
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

		// Token: 0x0602E34D RID: 189261 RVA: 0x00CE3234 File Offset: 0x00CE1434
		private void SetTitleText(string titleTextId)
		{
		}

		// Token: 0x0602E34E RID: 189262 RVA: 0x00CE3236 File Offset: 0x00CE1436
		private void SetTitleTextVisible(bool bVisible)
		{
		}

		// Token: 0x0602E34F RID: 189263 RVA: 0x00CE3238 File Offset: 0x00CE1438
		private void NewRewardExploreBar(IRewardExploreBar rewardExploreBarData)
		{
			TrainingItem trainingItem = new TrainingItem(LguiUtil.Instance.CopyItem(this.RewardExploreBarItem, this.BarVerticalItem));
			trainingItem.SetData(rewardExploreBarData.TrainingData);
			trainingItem.SetActive(true);
			this.RewardExploreBarListItem.Add(trainingItem);
		}

		// Token: 0x0602E350 RID: 189264 RVA: 0x00CE3280 File Offset: 0x00CE1480
		private void ClearAllRewardExploreBar()
		{
			foreach (TrainingItem trainingItem in this.RewardExploreBarListItem)
			{
				trainingItem.Destroy(null);
			}
			this.RewardExploreBarListItem.Clear();
		}

		// Token: 0x040189C8 RID: 100808
		[Nullable(2)]
		private UUIItem BarVerticalItem;

		// Token: 0x040189C9 RID: 100809
		[Nullable(2)]
		private UUIItem RewardExploreBarItem;

		// Token: 0x040189CA RID: 100810
		private readonly List<TrainingItem> RewardExploreBarListItem = new List<TrainingItem>();

		// Token: 0x0200A406 RID: 41990
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032D54 RID: 208212
			public const int BarVerticalItem = 0;

			// Token: 0x04032D55 RID: 208213
			public const int RewardExploreBarItem = 1;
		}
	}
}
