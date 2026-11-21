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
	// Token: 0x020047DE RID: 18398
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScoreSubTitle : UiPanelBase
	{
		// Token: 0x0602E3A9 RID: 189353 RVA: 0x00CE4E74 File Offset: 0x00CE3074
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

		// Token: 0x0602E3AA RID: 189354 RVA: 0x00CE4F40 File Offset: 0x00CE3140
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreScoreSubTitle.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreScoreSubTitle.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3AB RID: 189355 RVA: 0x00CE4F84 File Offset: 0x00CE3184
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

		// Token: 0x040189EB RID: 100843
		private readonly List<RewardExploreScoreSubTitleItem> FirstItemList = new List<RewardExploreScoreSubTitleItem>();

		// Token: 0x040189EC RID: 100844
		private readonly List<RewardExploreScoreSubTitleItem> LowItemList = new List<RewardExploreScoreSubTitleItem>();

		// Token: 0x040189ED RID: 100845
		private RewardExploreScoreSubTitle.NewRecordItem NewRecordItemInstance;

		// Token: 0x0200A41C RID: 42012
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032D9E RID: 208286
			public const int FirstTargetItem1 = 0;

			// Token: 0x04032D9F RID: 208287
			public const int FirstTargetItem2 = 1;

			// Token: 0x04032DA0 RID: 208288
			public const int LowTargetItem1 = 2;

			// Token: 0x04032DA1 RID: 208289
			public const int LowTargetItem2 = 3;

			// Token: 0x04032DA2 RID: 208290
			public const int NewRecordItem = 4;
		}

		// Token: 0x0200A41D RID: 42013
		[NullableContext(0)]
		public class NewRecordItem : UiPanelBase
		{
			// Token: 0x06045CC6 RID: 285894 RVA: 0x014FCAC4 File Offset: 0x014FACC4
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

			// Token: 0x06045CC7 RID: 285895 RVA: 0x014FCB59 File Offset: 0x014FAD59
			[NullableContext(1)]
			public void Refresh(IRewardExploreScoreBelongHalfArea data)
			{
				this.RefreshRecord(data);
				this.SetNewRecordItemVisible(data.IfNewRecord);
			}

			// Token: 0x06045CC8 RID: 285896 RVA: 0x014FCB70 File Offset: 0x014FAD70
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

			// Token: 0x06045CC9 RID: 285897 RVA: 0x014FCB9D File Offset: 0x014FAD9D
			private void SetNewRecordItemVisible(bool bVisible)
			{
				UUIItem item = base.GetItem(2);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(bVisible);
			}

			// Token: 0x0200BD4C RID: 48460
			private class ENewRecordComponent
			{
				// Token: 0x0403A1E8 RID: 238056
				public const int TitleText = 0;

				// Token: 0x0403A1E9 RID: 238057
				public const int RecordText = 1;

				// Token: 0x0403A1EA RID: 238058
				public const int NewRecordItem = 2;
			}
		}
	}
}
