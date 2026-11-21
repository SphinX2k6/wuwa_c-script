using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200390D RID: 14605
	public class MarkBookPrevReleaseComponent : HotKeyComponent
	{
		// Token: 0x06025C5A RID: 154714 RVA: 0x00A9E6BA File Offset: 0x00A9C8BA
		public MarkBookPrevReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C5B RID: 154715 RVA: 0x00A9E6C3 File Offset: 0x00A9C8C3
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.BookMarkNavigation(ELGUINavigationDirection.Up, base.GetBindButtonTag());
		}

		// Token: 0x06025C5C RID: 154716 RVA: 0x00A9E6D8 File Offset: 0x00A9C8D8
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			NavigationGroup groupConfig = (activeListenerByTag != null) ? activeListenerByTag.GetNavigationGroup() : null;
			List<TsUiNavigationBehaviorListener> markBookActiveListenerList = UiNavigationNewController.Instance.GetMarkBookActiveListenerList(groupConfig);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, markBookActiveListenerList.Count > 1, false);
		}
	}
}
