using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003972 RID: 14706
	public class DangobrawlJumpBackpackComponent : HotKeyComponent
	{
		// Token: 0x06025DDB RID: 155099 RVA: 0x00AA2573 File Offset: 0x00AA0773
		public DangobrawlJumpBackpackComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DDC RID: 155100 RVA: 0x00AA257C File Offset: 0x00AA077C
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

		// Token: 0x06025DDD RID: 155101 RVA: 0x00AA25C3 File Offset: 0x00AA07C3
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
