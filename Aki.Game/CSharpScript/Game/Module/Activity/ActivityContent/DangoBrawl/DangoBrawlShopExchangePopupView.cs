using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200578F RID: 22415
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopExchangePopupView : GameplayExchangePopView
	{
		// Token: 0x06037515 RID: 226581 RVA: 0x00F73320 File Offset: 0x00F71520
		public DangoBrawlShopExchangePopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06037516 RID: 226582 RVA: 0x00F73329 File Offset: 0x00F71529
		protected override NumberSelectComponent CreateNumberSelectComponent(UUIItem item)
		{
			return new DangoBrawlShopNumSelectComponent(item);
		}

		// Token: 0x06037517 RID: 226583 RVA: 0x00F73331 File Offset: 0x00F71531
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

		// Token: 0x06037518 RID: 226584 RVA: 0x00F7335C File Offset: 0x00F7155C
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

		// Token: 0x0401D388 RID: 119688
		private const int LimitTextIndex = 10;

		// Token: 0x0401D389 RID: 119689
		private const int LeftTimeItemIndex = 15;

		// Token: 0x0401D38A RID: 119690
		private const int LeftTimeTextIndex = 16;

		// Token: 0x0401D38B RID: 119691
		private const string LimitTextColor = "FED12E";
	}
}
