using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004992 RID: 18834
	public class MarkBookNextReleaseComponent : HotKeyComponent
	{
		// Token: 0x06031121 RID: 200993 RVA: 0x00B636FE File Offset: 0x00B618FE
		public MarkBookNextReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031122 RID: 200994 RVA: 0x00B63707 File Offset: 0x00B61907
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.BookMarkNavigation(ELGUINavigationDirection.Down, base.GetBindButtonTag());
		}

		// Token: 0x06031123 RID: 200995 RVA: 0x00B6371C File Offset: 0x00B6191C
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
