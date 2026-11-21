using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038DE RID: 14558
	public class GamepadInteractComponentBase : HotKeyComponent
	{
		// Token: 0x06025B75 RID: 154485 RVA: 0x00A9C3BB File Offset: 0x00A9A5BB
		public GamepadInteractComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B76 RID: 154486 RVA: 0x00A9C3C4 File Offset: 0x00A9A5C4
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
