using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200494B RID: 18763
	public class BagTagNavigationNextComponent : NavigationGroupNextComponent
	{
		// Token: 0x06030FCF RID: 200655 RVA: 0x00B60697 File Offset: 0x00B5E897
		public BagTagNavigationNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FD0 RID: 200656 RVA: 0x00B606A0 File Offset: 0x00B5E8A0
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup navigationGroup = focusListener.GetNavigationGroup();
			string bindButtonTag = base.GetBindButtonTag();
			string value = null;
			if (!string.IsNullOrEmpty(bindButtonTag))
			{
				navigationGroup.GroupNameMap.TryGetValue(bindButtonTag, out value);
			}
			else
			{
				value = navigationGroup.NextGroupName;
			}
			if (string.IsNullOrEmpty(value))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup navigationGroupByName = viewHandle.GetNavigationGroupByName(navigationGroup.NextGroupName);
			if (navigationGroupByName == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener defaultListener = navigationGroupByName.DefaultListener;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, defaultListener != null && defaultListener.IsScrollOrLayoutActive(), false);
		}
	}
}
