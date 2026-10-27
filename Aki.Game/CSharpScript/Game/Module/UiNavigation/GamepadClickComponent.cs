using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200496C RID: 18796
	public class GamepadClickComponent : GamepadInteractComponentBase
	{
		// Token: 0x06031055 RID: 200789 RVA: 0x00B6175A File Offset: 0x00B5F95A
		public GamepadClickComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031056 RID: 200790 RVA: 0x00B61764 File Offset: 0x00B5F964
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

		// Token: 0x06031057 RID: 200791 RVA: 0x00B617B8 File Offset: 0x00B5F9B8
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
