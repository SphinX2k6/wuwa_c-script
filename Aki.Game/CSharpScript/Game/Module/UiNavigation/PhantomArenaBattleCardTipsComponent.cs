using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003922 RID: 14626
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleCardTipsComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x06025CA9 RID: 154793 RVA: 0x00A9F338 File Offset: 0x00A9D538
		public PhantomArenaBattleCardTipsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CAA RID: 154794 RVA: 0x00A9F344 File Offset: 0x00A9D544
		protected override void OnPress(HotKeyMap _)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			NavigationSelectableBase navigationSelectableBase = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetNavigationComponent() : null;
			if (navigationSelectableBase == null)
			{
				return;
			}
			if (navigationSelectableBase.GetType() == ENavigationSelectableDefine.PhantomArenaOwnHandToggle)
			{
				this.SwitchHandCardTips(navigationSelectableBase);
				return;
			}
			if (navigationSelectableBase.GetType() == ENavigationSelectableDefine.PhantomArenaOwnBattleToggle)
			{
				this.SwitchOwnBattleCardTips(navigationSelectableBase);
				return;
			}
			if (navigationSelectableBase.GetType() == ENavigationSelectableDefine.PhantomArenaOpponentBattleToggle)
			{
				this.SwitchOpponentBattleCardTips(navigationSelectableBase);
			}
		}

		// Token: 0x06025CAB RID: 154795 RVA: 0x00A9F3A1 File Offset: 0x00A9D5A1
		protected override void OnRefreshSelfHotKeyStateImplement()
		{
			if (base.Proxy == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (base.Proxy.GamepadLogic.IsInCardSelectState)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025CAC RID: 154796 RVA: 0x00A9F3DA File Offset: 0x00A9D5DA
		protected override void OnRefreshSelfHotKeyStateIsMainInVisible()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025CAD RID: 154797 RVA: 0x00A9F3E5 File Offset: 0x00A9D5E5
		protected void SwitchHandCardTips(NavigationSelectableBase navigationComponent)
		{
			NavigationPhantomArenaOwnHandToggle navigationPhantomArenaOwnHandToggle = navigationComponent as NavigationPhantomArenaOwnHandToggle;
			if (navigationPhantomArenaOwnHandToggle == null)
			{
				return;
			}
			navigationPhantomArenaOwnHandToggle.SwitchHandCardTips();
		}

		// Token: 0x06025CAE RID: 154798 RVA: 0x00A9F3F7 File Offset: 0x00A9D5F7
		protected void SwitchOwnBattleCardTips(NavigationSelectableBase navigationComponent)
		{
			NavigationPhantomArenaOwnBattleToggle navigationPhantomArenaOwnBattleToggle = navigationComponent as NavigationPhantomArenaOwnBattleToggle;
			if (navigationPhantomArenaOwnBattleToggle == null)
			{
				return;
			}
			navigationPhantomArenaOwnBattleToggle.SwitchBattleCardTips();
		}

		// Token: 0x06025CAF RID: 154799 RVA: 0x00A9F409 File Offset: 0x00A9D609
		protected void SwitchOpponentBattleCardTips(NavigationSelectableBase navigationComponent)
		{
			NavigationPhantomArenaOpponentBattleToggle navigationPhantomArenaOpponentBattleToggle = navigationComponent as NavigationPhantomArenaOpponentBattleToggle;
			if (navigationPhantomArenaOpponentBattleToggle == null)
			{
				return;
			}
			navigationPhantomArenaOpponentBattleToggle.SwitchBattleCardTips();
		}
	}
}
