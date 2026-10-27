using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004991 RID: 18833
	public class MarkBookPrevComponent : HotKeyComponent
	{
		// Token: 0x0603111E RID: 200990 RVA: 0x00B63692 File Offset: 0x00B61892
		public MarkBookPrevComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603111F RID: 200991 RVA: 0x00B6369B File Offset: 0x00B6189B
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.BookMarkNavigation(ELGUINavigationDirection.Up, base.GetBindButtonTag());
		}

		// Token: 0x06031120 RID: 200992 RVA: 0x00B636B0 File Offset: 0x00B618B0
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
