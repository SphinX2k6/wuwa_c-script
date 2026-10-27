using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D1 RID: 18897
	public class ShipTowerSwitchRightTeamComponent : HotKeyComponent
	{
		// Token: 0x060311FE RID: 201214 RVA: 0x00B65331 File Offset: 0x00B63531
		public ShipTowerSwitchRightTeamComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311FF RID: 201215 RVA: 0x00B6533C File Offset: 0x00B6353C
		protected override void OnRelease(HotKeyMap config)
		{
			TsUiNavigationBehaviorListener triggerListener = this.GetTriggerListener();
			if (triggerListener != null)
			{
				UiNavigationNewController.Instance.InteractClickByListener(triggerListener);
			}
		}

		// Token: 0x06031200 RID: 201216 RVA: 0x00B65360 File Offset: 0x00B63560
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

		// Token: 0x06031201 RID: 201217 RVA: 0x00B653F8 File Offset: 0x00B635F8
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
