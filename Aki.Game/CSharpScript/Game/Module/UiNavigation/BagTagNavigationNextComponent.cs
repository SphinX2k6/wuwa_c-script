using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C2 RID: 14530
	public class BagTagNavigationNextComponent : NavigationGroupNextComponent
	{
		// Token: 0x06025AFB RID: 154363 RVA: 0x00A9B4DB File Offset: 0x00A996DB
		public BagTagNavigationNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025AFC RID: 154364 RVA: 0x00A9B4E4 File Offset: 0x00A996E4
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
