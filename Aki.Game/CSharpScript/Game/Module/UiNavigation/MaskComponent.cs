using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200390E RID: 14606
	public class MaskComponent : HotKeyComponent
	{
		// Token: 0x06025C5D RID: 154717 RVA: 0x00A9E726 File Offset: 0x00A9C926
		public MaskComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C5E RID: 154718 RVA: 0x00A9E730 File Offset: 0x00A9C930
		protected override void OnPress(HotKeyMap config)
		{
			UUIItem uuiitem = this.RootItem.GetRootCanvas().GetOwner().RootComponent as UUIItem;
			if (uuiitem != null)
			{
				UiNavigationNewController.Instance.SimulateClickItem(uuiitem, null);
			}
		}

		// Token: 0x06025C5F RID: 154719 RVA: 0x00A9E770 File Offset: 0x00A9C970
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
