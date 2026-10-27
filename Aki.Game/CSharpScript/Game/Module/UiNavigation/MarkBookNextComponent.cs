using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004990 RID: 18832
	public class MarkBookNextComponent : HotKeyComponent
	{
		// Token: 0x0603111B RID: 200987 RVA: 0x00B63626 File Offset: 0x00B61826
		public MarkBookNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603111C RID: 200988 RVA: 0x00B6362F File Offset: 0x00B6182F
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.BookMarkNavigation(ELGUINavigationDirection.Down, base.GetBindButtonTag());
		}

		// Token: 0x0603111D RID: 200989 RVA: 0x00B63644 File Offset: 0x00B61844
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
