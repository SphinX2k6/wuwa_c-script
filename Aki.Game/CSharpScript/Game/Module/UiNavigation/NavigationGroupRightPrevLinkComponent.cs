using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A2 RID: 18850
	public class NavigationGroupRightPrevLinkComponent : NavigationGroupRightPrevComponent
	{
		// Token: 0x0603115B RID: 201051 RVA: 0x00B63D6D File Offset: 0x00B61F6D
		public NavigationGroupRightPrevLinkComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603115C RID: 201052 RVA: 0x00B63D78 File Offset: 0x00B61F78
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
			NavigationGroup navigationGroup = focusListener.GetNavigationGroup();
			if (string.IsNullOrEmpty(navigationGroup.PrevGroupName))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup activeNavigationGroupByNameCheckAll = viewHandle.GetActiveNavigationGroupByNameCheckAll(navigationGroup.PrevGroupName);
			if (activeNavigationGroupByNameCheckAll == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			bool isActive = UiNavigationLogic.HasActiveListenerInGroup(activeNavigationGroupByNameCheckAll);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}
	}
}
