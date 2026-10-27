using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02004A05 RID: 18949
	public class NavigationNextLatest : HotKeyComponent
	{
		// Token: 0x060312E2 RID: 201442 RVA: 0x00B6824A File Offset: 0x00B6644A
		public NavigationNextLatest(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312E3 RID: 201443 RVA: 0x00B68253 File Offset: 0x00B66453
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.HandleCommonConsumeNavigationToLast(config.BindButtonTag);
		}

		// Token: 0x060312E4 RID: 201444 RVA: 0x00B68268 File Offset: 0x00B66468
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
