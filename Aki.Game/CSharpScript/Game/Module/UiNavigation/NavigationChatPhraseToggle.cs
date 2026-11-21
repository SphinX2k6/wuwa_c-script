using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200389E RID: 14494
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationChatPhraseToggle : NavigationButton
	{
		// Token: 0x060259E1 RID: 154081 RVA: 0x00A9663F File Offset: 0x00A9483F
		public NavigationChatPhraseToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x060259E2 RID: 154082 RVA: 0x00A9664C File Offset: 0x00A9484C
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

		// Token: 0x060259E3 RID: 154083 RVA: 0x00A9668B File Offset: 0x00A9488B
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.SetChatSelectPanelBlackMarkEnable(true);
			}
		}

		// Token: 0x04014C54 RID: 85076
		protected PhoneSystemChatProxy ProxyInternal;
	}
}
