using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004927 RID: 18727
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationChatPhraseToggle : NavigationButton
	{
		// Token: 0x06030EB4 RID: 200372 RVA: 0x00B5B7CF File Offset: 0x00B599CF
		public NavigationChatPhraseToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079CF RID: 31183
		// (get) Token: 0x06030EB5 RID: 200373 RVA: 0x00B5B7DC File Offset: 0x00B599DC
		protected PhoneSystemChatProxy Proxy
		{
			get
			{
				if (this.ProxyInternal == null)
				{
					PhoneMsgPanelViewBig phoneMsgPanelViewBig = UiManager.Instance.GetViewByName(EUiViewName.PhoneMsgPanelViewBig) as PhoneMsgPanelViewBig;
					if (phoneMsgPanelViewBig != null)
					{
						this.ProxyInternal = phoneMsgPanelViewBig.GetProxy();
					}
				}
				return this.ProxyInternal;
			}
		}

		// Token: 0x06030EB6 RID: 200374 RVA: 0x00B5B81B File Offset: 0x00B59A1B
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.SetChatSelectPanelBlackMarkEnable(true);
			}
		}

		// Token: 0x0401A3E1 RID: 107489
		protected PhoneSystemChatProxy ProxyInternal;
	}
}
