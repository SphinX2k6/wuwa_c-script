using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003926 RID: 14630
	public class PhantomArenaCardInfoComponent : HotKeyComponent
	{
		// Token: 0x06025CBC RID: 154812 RVA: 0x00A9F583 File Offset: 0x00A9D783
		public PhantomArenaCardInfoComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CBD RID: 154813 RVA: 0x00A9F58C File Offset: 0x00A9D78C
		protected override void OnPress(HotKeyMap _)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			if (currentNavigationFocusListener != null)
			{
				EventSystem.Instance.Emit<UUIItem>(EEventName.GamepadTriggerCardInfo, currentNavigationFocusListener.RootUIComp.Get());
			}
		}

		// Token: 0x06025CBE RID: 154814 RVA: 0x00A9F5C8 File Offset: 0x00A9D7C8
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!base.IsLinkListener(focusListener.GetOwner()))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
