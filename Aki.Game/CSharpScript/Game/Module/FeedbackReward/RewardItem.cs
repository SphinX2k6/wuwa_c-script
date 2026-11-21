using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FeedbackReward
{
	// Token: 0x02004A64 RID: 19044
	internal class RewardItem : GridProxyAbstract<int>
	{
		// Token: 0x0602FA87 RID: 195207 RVA: 0x00D4BEEC File Offset: 0x00D4A0EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FA88 RID: 195208 RVA: 0x00D4BF98 File Offset: 0x00D4A198
		protected override UniTask OnBeforeStartAsync()
		{
			RewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA89 RID: 195209 RVA: 0x00D4BFDC File Offset: 0x00D4A1DC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			GivebackScoreReward? givebackScoreRewardById = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(data);
			if (givebackScoreRewardById == null)
			{
				return;
			}
			this.RewardId = data;
			base.GetText(3).SetText(givebackScoreRewardById.Value.Target.ToString(), true);
			EFeedbackRewardState feedbackRewardState = FeedbackRewardModel.Instance.GetFeedbackRewardState(data);
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(givebackScoreRewardById.Value.DropId);
			if (dropPackage != null)
			{
				using (Dictionary<int, int>.Enumerator enumerator = dropPackage.Value.DropPreview().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						PropSmallItemGrid parameters = new PropSmallItemGrid
						{
							Data = keyValuePair.Key,
							ItemConfigId = new int?(keyValuePair.Key),
							BottomText = ((keyValuePair.Value > 0) ? keyValuePair.Value.ToString() : null),
							IsStarReceivableVisible = new bool?(feedbackRewardState == EFeedbackRewardState.Finish),
							IsReceivedVisible = new bool?(feedbackRewardState == EFeedbackRewardState.Claimed)
						};
						SmallItemGrid showItem = this.ShowItem;
						if (showItem != null)
						{
							showItem.Apply<PropSmallItemGrid>(parameters);
						}
					}
				}
			}
			base.GetItem(0).SetUIActive(gridIndex > 0);
			base.GetItem(1).SetUIActive(feedbackRewardState >= EFeedbackRewardState.Finish);
		}

		// Token: 0x0602FA8A RID: 195210 RVA: 0x00D4C154 File Offset: 0x00D4A354
		[NullableContext(1)]
		private void OnExtendToggleClicked(MediumItemGridExtendCallback _)
		{
			if (FeedbackRewardModel.Instance.GetFeedbackRewardState(this.RewardId) == EFeedbackRewardState.Finish)
			{
				FeedbackRewardController.Instance.GivebackRewardRequest().Forget();
				return;
			}
			GivebackScoreReward? givebackScoreRewardById = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(this.RewardId);
			if (givebackScoreRewardById == null)
			{
				return;
			}
			if (givebackScoreRewardById.Value.ShowType == 3)
			{
				ItemController.Instance.OpenTitleTipsByItemId(givebackScoreRewardById.Value.SkipParam);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(givebackScoreRewardById.Value.SkipParam, true, null, false);
		}

		// Token: 0x0602FA8B RID: 195211 RVA: 0x00D4C1E7 File Offset: 0x00D4A3E7
		public void SetPreviewVisible(bool value)
		{
			SmallItemGrid showItem = this.ShowItem;
			if (showItem == null)
			{
				return;
			}
			showItem.SetPreviewVisible(value);
		}

		// Token: 0x040194EA RID: 103658
		public int RewardId;

		// Token: 0x040194EB RID: 103659
		[Nullable(2)]
		private SmallItemGrid ShowItem;

		// Token: 0x0200A6C7 RID: 42695
		private enum ERewardItem
		{
			// Token: 0x040338D4 RID: 211156
			BarItem,
			// Token: 0x040338D5 RID: 211157
			FinishItem,
			// Token: 0x040338D6 RID: 211158
			GirdItem,
			// Token: 0x040338D7 RID: 211159
			PointText
		}
	}
}
