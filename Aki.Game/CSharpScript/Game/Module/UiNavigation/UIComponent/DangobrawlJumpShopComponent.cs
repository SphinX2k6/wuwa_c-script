using System;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003975 RID: 14709
	public class DangobrawlJumpShopComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x06025DEA RID: 155114 RVA: 0x00AA27B8 File Offset: 0x00AA09B8
		public DangobrawlJumpShopComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DEB RID: 155115 RVA: 0x00AA27C4 File Offset: 0x00AA09C4
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

		// Token: 0x06025DEC RID: 155116 RVA: 0x00AA27FC File Offset: 0x00AA09FC
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
