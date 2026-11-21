using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200391F RID: 14623
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaBattleCardCancelComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x06025C99 RID: 154777 RVA: 0x00A9EDDF File Offset: 0x00A9CFDF
		public PhantomArenaBattleCardCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C9A RID: 154778 RVA: 0x00A9EDE8 File Offset: 0x00A9CFE8
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

		// Token: 0x06025C9B RID: 154779 RVA: 0x00A9EE72 File Offset: 0x00A9D072
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

		// Token: 0x06025C9C RID: 154780 RVA: 0x00A9EEAC File Offset: 0x00A9D0AC
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

		// Token: 0x06025C9D RID: 154781 RVA: 0x00A9EF44 File Offset: 0x00A9D144
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
