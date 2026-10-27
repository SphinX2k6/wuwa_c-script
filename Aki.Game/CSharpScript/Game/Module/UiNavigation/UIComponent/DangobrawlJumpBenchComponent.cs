using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049F9 RID: 18937
	public class DangobrawlJumpBenchComponent : HotKeyComponent
	{
		// Token: 0x060312A8 RID: 201384 RVA: 0x00B67612 File Offset: 0x00B65812
		public DangobrawlJumpBenchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312A9 RID: 201385 RVA: 0x00B6761C File Offset: 0x00B6581C
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

		// Token: 0x060312AA RID: 201386 RVA: 0x00B67663 File Offset: 0x00B65863
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
