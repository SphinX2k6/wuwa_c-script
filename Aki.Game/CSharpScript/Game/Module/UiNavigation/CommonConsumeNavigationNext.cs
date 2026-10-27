using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004954 RID: 18772
	public class CommonConsumeNavigationNext : HotKeyComponent
	{
		// Token: 0x06030FF4 RID: 200692 RVA: 0x00B60C81 File Offset: 0x00B5EE81
		public CommonConsumeNavigationNext(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FF5 RID: 200693 RVA: 0x00B60C8A File Offset: 0x00B5EE8A
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.HandleCommonConsumeNavigation(config.BindButtonTag);
		}

		// Token: 0x06030FF6 RID: 200694 RVA: 0x00B60CA0 File Offset: 0x00B5EEA0
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
			string text = null;
			if (!string.IsNullOrEmpty(bindButtonTag))
			{
				navigationGroup.GroupNameMap.TryGetValue(bindButtonTag, out text);
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
