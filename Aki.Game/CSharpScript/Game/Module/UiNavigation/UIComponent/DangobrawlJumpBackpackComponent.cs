using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049F8 RID: 18936
	public class DangobrawlJumpBackpackComponent : HotKeyComponent
	{
		// Token: 0x060312A5 RID: 201381 RVA: 0x00B675B7 File Offset: 0x00B657B7
		public DangobrawlJumpBackpackComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312A6 RID: 201382 RVA: 0x00B675C0 File Offset: 0x00B657C0
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlItemViewRegistry viewRegistry = DangoBrawlModel.Instance.GetViewRegistry();
			UUIItem uuiitem;
			if (viewRegistry == null)
			{
				uuiitem = null;
			}
			else
			{
				DangoBrawlBackpackView backpackView = viewRegistry.GetBackpackView();
				uuiitem = ((backpackView != null) ? backpackView.GetBagHitItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null || !uuiitem2.IsValid())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationMousePositionForView(uuiitem2);
		}

		// Token: 0x060312A7 RID: 201383 RVA: 0x00B67607 File Offset: 0x00B65807
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
