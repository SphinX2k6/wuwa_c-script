using System;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049FB RID: 18939
	public class DangobrawlJumpShopComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x060312B4 RID: 201396 RVA: 0x00B677FC File Offset: 0x00B659FC
		public DangobrawlJumpShopComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312B5 RID: 201397 RVA: 0x00B67808 File Offset: 0x00B65A08
		protected override bool ShouldShow()
		{
			DangoBrawlItemViewRegistry registry = DangobrawlHotKeyComponentBase.Registry;
			UUIItem uuiitem;
			if (registry == null)
			{
				uuiitem = null;
			}
			else
			{
				DangoBrawlBackpackView backpackView = registry.GetBackpackView();
				uuiitem = ((backpackView != null) ? backpackView.GetShopHitItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			return uuiitem2 != null && uuiitem2.IsValid();
		}

		// Token: 0x060312B6 RID: 201398 RVA: 0x00B67840 File Offset: 0x00B65A40
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlItemViewRegistry registry = DangobrawlHotKeyComponentBase.Registry;
			UUIItem uuiitem;
			if (registry == null)
			{
				uuiitem = null;
			}
			else
			{
				DangoBrawlBackpackView backpackView = registry.GetBackpackView();
				uuiitem = ((backpackView != null) ? backpackView.GetShopHitItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null || !uuiitem2.IsValid())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationMousePositionForView(uuiitem2);
		}
	}
}
