using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049AC RID: 18860
	public class PhantomArenaCardInfoComponent : HotKeyComponent
	{
		// Token: 0x06031186 RID: 201094 RVA: 0x00B64633 File Offset: 0x00B62833
		public PhantomArenaCardInfoComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031187 RID: 201095 RVA: 0x00B6463C File Offset: 0x00B6283C
		protected override void OnPress(HotKeyMap _)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			if (currentNavigationFocusListener != null)
			{
				EventSystem.Instance.Emit<UUIItem>(EEventName.GamepadTriggerCardInfo, currentNavigationFocusListener.RootUIComp.Get());
			}
		}

		// Token: 0x06031188 RID: 201096 RVA: 0x00B64678 File Offset: 0x00B62878
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
