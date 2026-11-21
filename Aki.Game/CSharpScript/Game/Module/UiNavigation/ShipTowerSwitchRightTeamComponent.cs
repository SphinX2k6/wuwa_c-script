using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200394B RID: 14667
	public class ShipTowerSwitchRightTeamComponent : HotKeyComponent
	{
		// Token: 0x06025D34 RID: 154932 RVA: 0x00AA0281 File Offset: 0x00A9E481
		public ShipTowerSwitchRightTeamComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D35 RID: 154933 RVA: 0x00AA028C File Offset: 0x00A9E48C
		protected override void OnRelease(HotKeyMap config)
		{
			TsUiNavigationBehaviorListener triggerListener = this.GetTriggerListener();
			if (triggerListener != null)
			{
				UiNavigationNewController.Instance.InteractClickByListener(triggerListener);
			}
		}

		// Token: 0x06025D36 RID: 154934 RVA: 0x00AA02B0 File Offset: 0x00A9E4B0
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener GetTriggerListener()
		{
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			string bindButtonTag = base.GetBindButtonTag();
			if (bindButtonTag == null)
			{
				return null;
			}
			List<TsUiNavigationBehaviorListener> list = (currentViewHandle != null) ? currentViewHandle.GetActiveListenerListByTag(bindButtonTag) : null;
			if (list == null)
			{
				return null;
			}
			TsUiNavigationBehaviorListener result = null;
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in list)
			{
				UUIExtendToggle uuiextendToggle = tsUiNavigationBehaviorListener.GetSelectableComponent() as UUIExtendToggle;
				if (uuiextendToggle != null && uuiextendToggle.GetToggleState() != EToggleState.ETT_Checked)
				{
					result = tsUiNavigationBehaviorListener;
					break;
				}
			}
			return result;
		}

		// Token: 0x06025D37 RID: 154935 RVA: 0x00AA0348 File Offset: 0x00A9E548
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (StringUtils.IsEmpty(base.GetBindButtonTag()))
			{
				return;
			}
			bool isShowLeftTeamPanel = ShipTowerModel.Instance.IsShowLeftTeamPanel;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isShowLeftTeamPanel, false);
		}
	}
}
