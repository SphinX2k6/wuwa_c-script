using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004966 RID: 18790
	public class GamepadInteractComponentBase : HotKeyComponent
	{
		// Token: 0x06031045 RID: 200773 RVA: 0x00B614DB File Offset: 0x00B5F6DB
		public GamepadInteractComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031046 RID: 200774 RVA: 0x00B614E4 File Offset: 0x00B5F6E4
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (!viewHandle.HasGamepadControlMouse())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationPanelConfig mainPanel = viewHandle.MainPanel;
			bool? flag;
			if (mainPanel == null)
			{
				flag = null;
			}
			else
			{
				UUIItem gamepadMouseItem = mainPanel.GamepadMouseItem;
				flag = ((gamepadMouseItem != null) ? new bool?(gamepadMouseItem.IsUIActiveInHierarchy()) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, valueOrDefault, false);
		}
	}
}
