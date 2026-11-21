using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E4 RID: 14564
	public class GamepadClickComponent : GamepadInteractComponentBase
	{
		// Token: 0x06025B85 RID: 154501 RVA: 0x00A9C63A File Offset: 0x00A9A83A
		public GamepadClickComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B86 RID: 154502 RVA: 0x00A9C644 File Offset: 0x00A9A844
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = currentViewHandle.GetGuideUiListener();
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = currentViewHandle.GetHitComponentListener();
			}
			if (tsUiNavigationBehaviorListener != null)
			{
				TArray<string> tagArray = tsUiNavigationBehaviorListener.TagArray;
				if (tagArray != null && tagArray.Contains(config.BindButtonTag))
				{
					UiNavigationNewController.Instance.InteractClickByListener(tsUiNavigationBehaviorListener);
				}
			}
		}

		// Token: 0x06025B87 RID: 154503 RVA: 0x00A9C698 File Offset: 0x00A9A898
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			if (!viewHandle.HasGamepadControlMouse())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (viewHandle.IsNavigationMousePositionDragging())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = viewHandle.GetGuideUiListener();
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = viewHandle.GetHitComponentListener();
			}
			if (tsUiNavigationBehaviorListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TArray<string> tagArray = tsUiNavigationBehaviorListener.TagArray;
			bool isActive = tagArray != null && tagArray.Contains(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}
	}
}
