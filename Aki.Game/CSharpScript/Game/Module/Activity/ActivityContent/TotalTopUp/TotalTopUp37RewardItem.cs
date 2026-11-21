using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F9A RID: 20378
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37RewardItem : UiPanelBase
	{
		// Token: 0x06033147 RID: 209223 RVA: 0x00E510D8 File Offset: 0x00E4F2D8
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

		// Token: 0x06033148 RID: 209224 RVA: 0x00E511F0 File Offset: 0x00E4F3F0
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06033149 RID: 209225 RVA: 0x00E51204 File Offset: 0x00E4F404
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

		// Token: 0x170063CD RID: 25549
		// (get) Token: 0x0603314A RID: 209226 RVA: 0x00E5133A File Offset: 0x00E4F53A
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

		// Token: 0x0603314B RID: 209227 RVA: 0x00E5134D File Offset: 0x00E4F54D
		public void SetPreviewMark(bool isPreviewing)
		{
			this.SetSelected(isPreviewing);
		}

		// Token: 0x0603314C RID: 209228 RVA: 0x00E51356 File Offset: 0x00E4F556
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

		// Token: 0x0603314D RID: 209229 RVA: 0x00E51380 File Offset: 0x00E4F580
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

		// Token: 0x0401B1F1 RID: 111089
		private const string CLAIMED_BG_COLOR = "C3C3C3";

		// Token: 0x0401B1F2 RID: 111090
		private const string NORMAL_BG_COLOR = "FFFFFF";

		// Token: 0x0401B1F3 RID: 111091
		[Nullable(2)]
		private TotalTopUpPageRewardViewModel ViewModel;

		// Token: 0x0200AC92 RID: 44178
		[NullableContext(0)]
		private class ENode
		{
			// Token: 0x0403560D RID: 218637
			public const int BtnItem = 0;

			// Token: 0x0403560E RID: 218638
			public const int PnlBg = 1;

			// Token: 0x0403560F RID: 218639
			public const int PnlCost = 2;

			// Token: 0x04035610 RID: 218640
			public const int TextScore = 3;

			// Token: 0x04035611 RID: 218641
			public const int PnlDone = 4;

			// Token: 0x04035612 RID: 218642
			public const int PnlSelected = 5;

			// Token: 0x04035613 RID: 218643
			public const int TextSelectedScore = 6;

			// Token: 0x04035614 RID: 218644
			public const int ItemRedDot = 7;

			// Token: 0x04035615 RID: 218645
			public const int EffectItem = 8;

			// Token: 0x04035616 RID: 218646
			public const int TxtNum = 9;
		}
	}
}
