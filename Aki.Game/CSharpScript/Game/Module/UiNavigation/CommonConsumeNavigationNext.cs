using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038CC RID: 14540
	public class CommonConsumeNavigationNext : HotKeyComponent
	{
		// Token: 0x06025B24 RID: 154404 RVA: 0x00A9BB61 File Offset: 0x00A99D61
		public CommonConsumeNavigationNext(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B25 RID: 154405 RVA: 0x00A9BB6A File Offset: 0x00A99D6A
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.HandleCommonConsumeNavigation(config.BindButtonTag);
		}

		// Token: 0x06025B26 RID: 154406 RVA: 0x00A9BB80 File Offset: 0x00A99D80
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
