using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005807 RID: 22535
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScoreSubTitle : UiPanelBase
	{
		// Token: 0x06039495 RID: 234645 RVA: 0x00D9600C File Offset: 0x00D9420C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039496 RID: 234646 RVA: 0x00D960D8 File Offset: 0x00D942D8
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreScoreSubTitle.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreScoreSubTitle.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039497 RID: 234647 RVA: 0x00D9611C File Offset: 0x00D9431C
		public void RefreshData(IRewardExploreScoreBelongHalfArea exploreScore)
		{
			int num = 0;
			int num2 = 0;
			foreach (IRewardExploreScoreBelongHalfAreaItem rewardExploreScoreBelongHalfAreaItem in exploreScore.ItemList)
			{
				if (rewardExploreScoreBelongHalfAreaItem.Belong == ETeamBelong.FirstPart)
				{
					if (num < this.FirstItemList.Count)
					{
						RewardExploreScoreSubTitleItem rewardExploreScoreSubTitleItem = this.FirstItemList[num++];
						rewardExploreScoreSubTitleItem.SetUiActive(true);
						rewardExploreScoreSubTitleItem.RefreshText(rewardExploreScoreBelongHalfAreaItem);
					}
				}
				else if (rewardExploreScoreBelongHalfAreaItem.Belong == ETeamBelong.LowPart && num2 < this.LowItemList.Count)
				{
					RewardExploreScoreSubTitleItem rewardExploreScoreSubTitleItem2 = this.LowItemList[num2++];
					rewardExploreScoreSubTitleItem2.SetUiActive(true);
					rewardExploreScoreSubTitleItem2.RefreshText(rewardExploreScoreBelongHalfAreaItem);
				}
			}
			RewardExploreScoreSubTitle.NewRecordItem newRecordItemInstance = this.NewRecordItemInstance;
			if (newRecordItemInstance == null)
			{
				return;
			}
			newRecordItemInstance.Refresh(exploreScore);
		}

		// Token: 0x0401DF54 RID: 122708
		private readonly List<RewardExploreScoreSubTitleItem> FirstItemList = new List<RewardExploreScoreSubTitleItem>();

		// Token: 0x0401DF55 RID: 122709
		private readonly List<RewardExploreScoreSubTitleItem> LowItemList = new List<RewardExploreScoreSubTitleItem>();

		// Token: 0x0401DF56 RID: 122710
		private RewardExploreScoreSubTitle.NewRecordItem NewRecordItemInstance;

		// Token: 0x0200BA06 RID: 47622
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040383B1 RID: 230321
			public const int FirstTargetItem1 = 0;

			// Token: 0x040383B2 RID: 230322
			public const int FirstTargetItem2 = 1;

			// Token: 0x040383B3 RID: 230323
			public const int LowTargetItem1 = 2;

			// Token: 0x040383B4 RID: 230324
			public const int LowTargetItem2 = 3;

			// Token: 0x040383B5 RID: 230325
			public const int NewRecordItem = 4;
		}

		// Token: 0x0200BA07 RID: 47623
		[NullableContext(0)]
		public class NewRecordItem : UiPanelBase
		{
			// Token: 0x0604F73A RID: 325434 RVA: 0x0154377C File Offset: 0x0154197C
			protected unsafe override void OnRegisterComponent()
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
			}

			// Token: 0x0604F73B RID: 325435 RVA: 0x01543811 File Offset: 0x01541A11
			[NullableContext(1)]
			public void Refresh(IRewardExploreScoreBelongHalfArea data)
			{
				this.RefreshRecord(data);
				this.SetNewRecordItemVisible(data.IfNewRecord);
			}

			// Token: 0x0604F73C RID: 325436 RVA: 0x01543828 File Offset: 0x01541A28
			[NullableContext(1)]
			private void RefreshRecord(IRewardExploreScoreBelongHalfArea data)
			{
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				text.SetText(data.FullScore.ToString(), true);
			}

			// Token: 0x0604F73D RID: 325437 RVA: 0x01543855 File Offset: 0x01541A55
			private void SetNewRecordItemVisible(bool bVisible)
			{
				UUIItem item = base.GetItem(2);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(bVisible);
			}

			// Token: 0x0200D16E RID: 53614
			private class ENewRecordComponent
			{
				// Token: 0x0403EDA0 RID: 257440
				public const int TitleText = 0;

				// Token: 0x0403EDA1 RID: 257441
				public const int RecordText = 1;

				// Token: 0x0403EDA2 RID: 257442
				public const int NewRecordItem = 2;
			}
		}
	}
}
