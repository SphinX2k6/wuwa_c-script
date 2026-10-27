using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004993 RID: 18835
	public class MarkBookPrevReleaseComponent : HotKeyComponent
	{
		// Token: 0x06031124 RID: 200996 RVA: 0x00B6376A File Offset: 0x00B6196A
		public MarkBookPrevReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031125 RID: 200997 RVA: 0x00B63773 File Offset: 0x00B61973
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.BookMarkNavigation(ELGUINavigationDirection.Up, base.GetBindButtonTag());
		}

		// Token: 0x06031126 RID: 200998 RVA: 0x00B63788 File Offset: 0x00B61988
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
