using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A8 RID: 18856
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleCardTipsComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x06031173 RID: 201075 RVA: 0x00B643E8 File Offset: 0x00B625E8
		public PhantomArenaBattleCardTipsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031174 RID: 201076 RVA: 0x00B643F4 File Offset: 0x00B625F4
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

		// Token: 0x06031175 RID: 201077 RVA: 0x00B64451 File Offset: 0x00B62651
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

		// Token: 0x06031176 RID: 201078 RVA: 0x00B6448A File Offset: 0x00B6268A
		protected override void OnRefreshSelfHotKeyStateIsMainInVisible()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06031177 RID: 201079 RVA: 0x00B64495 File Offset: 0x00B62695
		protected void SwitchHandCardTips(NavigationSelectableBase navigationComponent)
		{
			NavigationPhantomArenaOwnHandToggle navigationPhantomArenaOwnHandToggle = navigationComponent as NavigationPhantomArenaOwnHandToggle;
			if (navigationPhantomArenaOwnHandToggle == null)
			{
				return;
			}
			navigationPhantomArenaOwnHandToggle.SwitchHandCardTips();
		}

		// Token: 0x06031178 RID: 201080 RVA: 0x00B644A7 File Offset: 0x00B626A7
		protected void SwitchOwnBattleCardTips(NavigationSelectableBase navigationComponent)
		{
			NavigationPhantomArenaOwnBattleToggle navigationPhantomArenaOwnBattleToggle = navigationComponent as NavigationPhantomArenaOwnBattleToggle;
			if (navigationPhantomArenaOwnBattleToggle == null)
			{
				return;
			}
			navigationPhantomArenaOwnBattleToggle.SwitchBattleCardTips();
		}

		// Token: 0x06031179 RID: 201081 RVA: 0x00B644B9 File Offset: 0x00B626B9
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
