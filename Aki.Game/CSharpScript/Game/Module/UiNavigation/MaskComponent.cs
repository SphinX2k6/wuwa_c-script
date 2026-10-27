using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004994 RID: 18836
	public class MaskComponent : HotKeyComponent
	{
		// Token: 0x06031127 RID: 200999 RVA: 0x00B637D6 File Offset: 0x00B619D6
		public MaskComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031128 RID: 201000 RVA: 0x00B637E0 File Offset: 0x00B619E0
		protected override void OnPress(HotKeyMap config)
		{
			UUIItem uuiitem = this.RootItem.GetRootCanvas().GetOwner().RootComponent as UUIItem;
			if (uuiitem != null)
			{
				UiNavigationNewController.Instance.SimulateClickItem(uuiitem, null);
			}
		}

		// Token: 0x06031129 RID: 201001 RVA: 0x00B63820 File Offset: 0x00B61A20
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
