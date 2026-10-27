using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A5 RID: 18853
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaBattleCardCancelComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x06031163 RID: 201059 RVA: 0x00B63E8F File Offset: 0x00B6208F
		public PhantomArenaBattleCardCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031164 RID: 201060 RVA: 0x00B63E98 File Offset: 0x00B62098
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Proxy != null)
			{
				int index = base.Proxy.GamepadLogic.SelectedCard.Data.Index;
				int handIndex = base.Proxy.GamepadLogic.HandIndex;
				base.Proxy.GamepadLogic.CancelSelectedCard();
				UiNavigationViewManager.Instance.RefreshCurrentHotKey();
				if (index != -1)
				{
					TsUiNavigationBehaviorListener ownBattleSlotListenerByIndex = this.GetOwnBattleSlotListenerByIndex(index);
					UiNavigationNewController.Instance.SwitchNavigationFocus(ownBattleSlotListenerByIndex);
					return;
				}
				if (handIndex != -1)
				{
					TsUiNavigationBehaviorListener ownHandCardListenerByIndex = this.GetOwnHandCardListenerByIndex(handIndex);
					UiNavigationNewController.Instance.SwitchNavigationFocus(ownHandCardListenerByIndex);
				}
			}
		}

		// Token: 0x06031165 RID: 201061 RVA: 0x00B63F22 File Offset: 0x00B62122
		protected override void OnRefreshSelfHotKeyStateImplement()
		{
			if (base.Proxy == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!base.Proxy.GamepadLogic.IsInCardSelectState)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06031166 RID: 201062 RVA: 0x00B63F5C File Offset: 0x00B6215C
		private TsUiNavigationBehaviorListener GetOwnBattleSlotListenerByIndex(int index)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			NavigationGroup navigationGroup = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetNavigationGroup() : null;
			if (navigationGroup == null)
			{
				return null;
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				if (tsUiNavigationBehaviorListener.GetNavigationComponent().GetType() == ENavigationSelectableDefine.PhantomArenaOwnBattleToggle)
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
			}
			if (list.Count <= index)
			{
				return null;
			}
			return list[index];
		}

		// Token: 0x06031167 RID: 201063 RVA: 0x00B63FF4 File Offset: 0x00B621F4
		private TsUiNavigationBehaviorListener GetOwnHandCardListenerByIndex(int index)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			NavigationGroup navigationGroup = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetNavigationGroup() : null;
			if (navigationGroup == null)
			{
				return null;
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				if (tsUiNavigationBehaviorListener.GetNavigationComponent().GetType() == ENavigationSelectableDefine.PhantomArenaOwnHandToggle)
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
			}
			if (list.Count <= index)
			{
				return null;
			}
			return list[index];
		}
	}
}
