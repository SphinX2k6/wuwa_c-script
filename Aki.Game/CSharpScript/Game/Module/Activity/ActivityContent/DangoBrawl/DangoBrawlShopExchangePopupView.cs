using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200683F RID: 26687
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopExchangePopupView : GameplayExchangePopView
	{
		// Token: 0x060429C1 RID: 272833 RVA: 0x01031E14 File Offset: 0x01030014
		public DangoBrawlShopExchangePopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060429C2 RID: 272834 RVA: 0x01031E1D File Offset: 0x0103001D
		protected override NumberSelectComponent CreateNumberSelectComponent(UUIItem item)
		{
			return new DangoBrawlShopNumSelectComponent(item);
		}

		// Token: 0x060429C3 RID: 272835 RVA: 0x01031E25 File Offset: 0x01030025
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.SetTitleByTextIdAndArg("DangoBrawlBattleUIText_037", Array.Empty<object>());
			}
			base.OnBeforeShow();
			this.RefreshLimitTextExtra();
		}

		// Token: 0x060429C4 RID: 272836 RVA: 0x01031E50 File Offset: 0x01030050
		private void RefreshLimitTextExtra()
		{
			if (this.ViewProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(16);
			if (text != null)
			{
				text.SetUIActive(this.ViewProxy.LeftTimeItemVisible && this.ViewProxy.LeftTimeTextVisible);
			}
			UUIText text2 = base.GetText(10);
			bool limitTextItemVisible = this.ViewProxy.LimitTextItemVisible;
			text2.SetUIActive(limitTextItemVisible);
			if (!limitTextItemVisible)
			{
				return;
			}
			GameplayShopUtil.SetText(text2, this.ViewProxy.LimitTextData);
			text2.SetColor(FColor.FromHex("FED12E"));
		}

		// Token: 0x04022B2B RID: 142123
		private const int LimitTextIndex = 10;

		// Token: 0x04022B2C RID: 142124
		private const int LeftTimeItemIndex = 15;

		// Token: 0x04022B2D RID: 142125
		private const int LeftTimeTextIndex = 16;

		// Token: 0x04022B2E RID: 142126
		private const string LimitTextColor = "FED12E";
	}
}
