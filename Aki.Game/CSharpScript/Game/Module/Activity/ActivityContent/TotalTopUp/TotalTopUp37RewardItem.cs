using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FB3 RID: 24499
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37RewardItem : UiPanelBase
	{
		// Token: 0x0603E1AD RID: 254381 RVA: 0x00EFF41C File Offset: 0x00EFD61C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem))
			};
		}

		// Token: 0x0603E1AE RID: 254382 RVA: 0x00EFF534 File Offset: 0x00EFD734
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603E1AF RID: 254383 RVA: 0x00EFF548 File Offset: 0x00EFD748
		public void Refresh(TotalTopUpPageRewardViewModel viewModel)
		{
			this.ViewModel = viewModel;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(viewModel.Score);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(newText, true);
			}
			UUIText text2 = base.GetText(6);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
			bool flag = viewModel.ShowRewardCount != 0;
			UUIText text3 = base.GetText(9);
			if (text3 != null)
			{
				text3.SetUIActive(flag);
			}
			if (flag)
			{
				UUIText text4 = base.GetText(9);
				if (text4 != null)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("x");
					defaultInterpolatedStringHandler.AppendFormatted<int>(viewModel.ShowRewardCount);
					text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			bool uiactive = viewModel.State == ETotalTopUpRewardState.CanClaim;
			bool flag2 = viewModel.State == ETotalTopUpRewardState.Claimed;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(uiactive);
			}
			FColor color = FColor.FromHex(flag2 ? "C3C3C3" : "FFFFFF");
			UUIItem item4 = base.GetItem(1);
			if (item4 != null)
			{
				item4.SetColor(color);
			}
			this.SetSelected(false);
		}

		// Token: 0x17008FFB RID: 36859
		// (get) Token: 0x0603E1B0 RID: 254384 RVA: 0x00EFF67E File Offset: 0x00EFD87E
		public int RewardConfigId
		{
			get
			{
				TotalTopUpPageRewardViewModel viewModel = this.ViewModel;
				if (viewModel == null)
				{
					return 0;
				}
				return viewModel.RewardConfigId;
			}
		}

		// Token: 0x0603E1B1 RID: 254385 RVA: 0x00EFF691 File Offset: 0x00EFD891
		public void SetPreviewMark(bool isPreviewing)
		{
			this.SetSelected(isPreviewing);
		}

		// Token: 0x0603E1B2 RID: 254386 RVA: 0x00EFF69A File Offset: 0x00EFD89A
		private void SetSelected(bool isSelected)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(isSelected);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!isSelected);
		}

		// Token: 0x0603E1B3 RID: 254387 RVA: 0x00EFF6C4 File Offset: 0x00EFD8C4
		private void OnClickItem()
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

		// Token: 0x0402071F RID: 132895
		private const string CLAIMED_BG_COLOR = "C3C3C3";

		// Token: 0x04020720 RID: 132896
		private const string NORMAL_BG_COLOR = "FFFFFF";

		// Token: 0x04020721 RID: 132897
		[Nullable(2)]
		private TotalTopUpPageRewardViewModel ViewModel;

		// Token: 0x0200C287 RID: 49799
		[NullableContext(0)]
		private class ENode
		{
			// Token: 0x0403AC31 RID: 240689
			public const int BtnItem = 0;

			// Token: 0x0403AC32 RID: 240690
			public const int PnlBg = 1;

			// Token: 0x0403AC33 RID: 240691
			public const int PnlCost = 2;

			// Token: 0x0403AC34 RID: 240692
			public const int TextScore = 3;

			// Token: 0x0403AC35 RID: 240693
			public const int PnlDone = 4;

			// Token: 0x0403AC36 RID: 240694
			public const int PnlSelected = 5;

			// Token: 0x0403AC37 RID: 240695
			public const int TextSelectedScore = 6;

			// Token: 0x0403AC38 RID: 240696
			public const int ItemRedDot = 7;

			// Token: 0x0403AC39 RID: 240697
			public const int EffectItem = 8;

			// Token: 0x0403AC3A RID: 240698
			public const int TxtNum = 9;
		}
	}
}
