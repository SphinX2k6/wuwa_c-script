using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FB4 RID: 24500
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37RewardListPanel : UiPanelBase
	{
		// Token: 0x0603E1B5 RID: 254389 RVA: 0x00EFF6FC File Offset: 0x00EFD8FC
		protected override void OnRegisterComponent()
		{
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 9; i++)
			{
				list.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E1B6 RID: 254390 RVA: 0x00EFF73C File Offset: 0x00EFD93C
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUp37RewardListPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUp37RewardListPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1B7 RID: 254391 RVA: 0x00EFF780 File Offset: 0x00EFD980
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

		// Token: 0x0603E1B8 RID: 254392 RVA: 0x00EFF7EC File Offset: 0x00EFD9EC
		public void MarkPreview(int rewardId)
		{
			foreach (TotalTopUp37RewardItem totalTopUp37RewardItem in this.RewardItems)
			{
				totalTopUp37RewardItem.SetPreviewMark(totalTopUp37RewardItem.RewardConfigId == rewardId);
			}
		}

		// Token: 0x04020722 RID: 132898
		private const int ITEM_COUNT = 9;

		// Token: 0x04020723 RID: 132899
		private readonly List<TotalTopUp37RewardItem> RewardItems = new List<TotalTopUp37RewardItem>();
	}
}
