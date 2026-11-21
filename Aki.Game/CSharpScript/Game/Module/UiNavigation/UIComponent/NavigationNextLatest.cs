using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003981 RID: 14721
	public class NavigationNextLatest : HotKeyComponent
	{
		// Token: 0x06025E30 RID: 155184 RVA: 0x00AA39B2 File Offset: 0x00AA1BB2
		public NavigationNextLatest(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025E31 RID: 155185 RVA: 0x00AA39BB File Offset: 0x00AA1BBB
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.HandleCommonConsumeNavigationToLast(config.BindButtonTag);
		}

		// Token: 0x06025E32 RID: 155186 RVA: 0x00AA39D0 File Offset: 0x00AA1BD0
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
			string text;
			if (!string.IsNullOrEmpty(bindButtonTag))
			{
				text = navigationGroup.GroupNameMap.GetValueOrDefault(bindButtonTag);
			}
			else
			{
				text = navigationGroup.NextGroupName;
			}
			if (string.IsNullOrEmpty(text))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup activeNavigationGroupByNameCheckAll = viewHandle.GetActiveNavigationGroupByNameCheckAll(text);
			if (activeNavigationGroupByNameCheckAll == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			bool isActive = activeNavigationGroupByNameCheckAll.ActiveListenerList.Count > 0;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}
	}
}
