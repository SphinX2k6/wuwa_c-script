using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FA4 RID: 20388
	public class TotalTopUpPageRewardItem : UiPanelBase
	{
		// Token: 0x060331A7 RID: 209319 RVA: 0x00E52F0C File Offset: 0x00E5110C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickReward))
			};
		}

		// Token: 0x060331A8 RID: 209320 RVA: 0x00E52FF7 File Offset: 0x00E511F7
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060331A9 RID: 209321 RVA: 0x00E5300C File Offset: 0x00E5120C
		[NullableContext(1)]
		public void Refresh(TotalTopUpPageRewardViewModel viewModel)
		{
			this.ViewModel = viewModel;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText("x" + viewModel.RewardCount.ToString(), true);
			}
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.SetText(viewModel.Score.ToString(), true);
			}
			bool flag = viewModel.State == ETotalTopUpRewardState.CanClaim;
			bool uiactive = viewModel.State == ETotalTopUpRewardState.Claimed;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(6);
			bool uiactive2 = viewModel.ShowCheckItem && !flag;
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(uiactive2);
		}

		// Token: 0x060331AA RID: 209322 RVA: 0x00E530C8 File Offset: 0x00E512C8
		private void OnClickReward()
		{
			if (this.ViewModel == null)
			{
				return;
			}
			if (this.ViewModel.State == ETotalTopUpRewardState.CanClaim)
			{
				this.ViewModel.Claim();
				return;
			}
			this.ViewModel.PreviewReward();
		}

		// Token: 0x0401B21E RID: 111134
		[Nullable(2)]
		private TotalTopUpPageRewardViewModel ViewModel;

		// Token: 0x0200ACA0 RID: 44192
		private class ENode
		{
			// Token: 0x0403565C RID: 218716
			public const int BtnReward = 0;

			// Token: 0x0403565D RID: 218717
			public const int ItemNormalPanel = 1;

			// Token: 0x0403565E RID: 218718
			public const int ItemClaimedPanel = 2;

			// Token: 0x0403565F RID: 218719
			public const int TextureIcon = 3;

			// Token: 0x04035660 RID: 218720
			public const int TextScore = 4;

			// Token: 0x04035661 RID: 218721
			public const int TextRewardCount = 5;

			// Token: 0x04035662 RID: 218722
			public const int ItemCheckIcon = 6;

			// Token: 0x04035663 RID: 218723
			public const int ItemRedDot = 7;
		}
	}
}
