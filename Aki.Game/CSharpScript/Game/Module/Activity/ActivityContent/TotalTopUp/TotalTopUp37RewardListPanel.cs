using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F9B RID: 20379
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37RewardListPanel : UiPanelBase
	{
		// Token: 0x0603314F RID: 209231 RVA: 0x00E513B8 File Offset: 0x00E4F5B8
		protected override void OnRegisterComponent()
		{
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 9; i++)
			{
				list.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033150 RID: 209232 RVA: 0x00E513F8 File Offset: 0x00E4F5F8
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUp37RewardListPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUp37RewardListPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033151 RID: 209233 RVA: 0x00E5143C File Offset: 0x00E4F63C
		public void Refresh(TotalTopUpPageViewModel viewModel)
		{
			List<TotalTopUpPageRewardViewModel> rewardViewModels = viewModel.RewardViewModels;
			for (int i = 0; i < this.RewardItems.Count; i++)
			{
				TotalTopUp37RewardItem totalTopUp37RewardItem = this.RewardItems[i];
				TotalTopUpPageRewardViewModel totalTopUpPageRewardViewModel = (i + 1 < rewardViewModels.Count) ? rewardViewModels[i + 1] : null;
				if (totalTopUpPageRewardViewModel != null)
				{
					totalTopUp37RewardItem.SetUiActive(true);
					totalTopUp37RewardItem.Refresh(totalTopUpPageRewardViewModel);
				}
				else
				{
					totalTopUp37RewardItem.SetUiActive(false);
				}
			}
		}

		// Token: 0x06033152 RID: 209234 RVA: 0x00E514A8 File Offset: 0x00E4F6A8
		public void MarkPreview(int rewardId)
		{
			foreach (TotalTopUp37RewardItem totalTopUp37RewardItem in this.RewardItems)
			{
				totalTopUp37RewardItem.SetPreviewMark(totalTopUp37RewardItem.RewardConfigId == rewardId);
			}
		}

		// Token: 0x0401B1F4 RID: 111092
		private const int ITEM_COUNT = 9;

		// Token: 0x0401B1F5 RID: 111093
		private readonly List<TotalTopUp37RewardItem> RewardItems = new List<TotalTopUp37RewardItem>();
	}
}
