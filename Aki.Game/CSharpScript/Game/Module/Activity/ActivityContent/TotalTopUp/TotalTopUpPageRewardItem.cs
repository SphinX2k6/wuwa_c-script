using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FBD RID: 24509
	public class TotalTopUpPageRewardItem : UiPanelBase
	{
		// Token: 0x0603E20D RID: 254477 RVA: 0x00F01250 File Offset: 0x00EFF450
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

		// Token: 0x0603E20E RID: 254478 RVA: 0x00F0133B File Offset: 0x00EFF53B
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603E20F RID: 254479 RVA: 0x00F01350 File Offset: 0x00EFF550
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

		// Token: 0x0603E210 RID: 254480 RVA: 0x00F0140C File Offset: 0x00EFF60C
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

		// Token: 0x0402074C RID: 132940
		[Nullable(2)]
		private TotalTopUpPageRewardViewModel ViewModel;

		// Token: 0x0200C295 RID: 49813
		private class ENode
		{
			// Token: 0x0403AC80 RID: 240768
			public const int BtnReward = 0;

			// Token: 0x0403AC81 RID: 240769
			public const int ItemNormalPanel = 1;

			// Token: 0x0403AC82 RID: 240770
			public const int ItemClaimedPanel = 2;

			// Token: 0x0403AC83 RID: 240771
			public const int TextureIcon = 3;

			// Token: 0x0403AC84 RID: 240772
			public const int TextScore = 4;

			// Token: 0x0403AC85 RID: 240773
			public const int TextRewardCount = 5;

			// Token: 0x0403AC86 RID: 240774
			public const int ItemCheckIcon = 6;

			// Token: 0x0403AC87 RID: 240775
			public const int ItemRedDot = 7;
		}
	}
}
