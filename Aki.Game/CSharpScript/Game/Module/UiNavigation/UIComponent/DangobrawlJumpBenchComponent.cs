using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003973 RID: 14707
	public class DangobrawlJumpBenchComponent : HotKeyComponent
	{
		// Token: 0x06025DDE RID: 155102 RVA: 0x00AA25CE File Offset: 0x00AA07CE
		public DangobrawlJumpBenchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DDF RID: 155103 RVA: 0x00AA25D8 File Offset: 0x00AA07D8
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
				uuiitem = ((backpackView != null) ? backpackView.GetBenchHitItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null || !uuiitem2.IsValid())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationMousePositionForView(uuiitem2);
		}

		// Token: 0x06025DE0 RID: 155104 RVA: 0x00AA261F File Offset: 0x00AA081F
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
