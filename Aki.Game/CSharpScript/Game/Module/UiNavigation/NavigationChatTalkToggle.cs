using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004929 RID: 18729
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationChatTalkToggle : NavigationToggle
	{
		// Token: 0x06030EBB RID: 200379 RVA: 0x00B5B8A2 File Offset: 0x00B59AA2
		public NavigationChatTalkToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079D1 RID: 31185
		// (get) Token: 0x06030EBC RID: 200380 RVA: 0x00B5B8B0 File Offset: 0x00B59AB0
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

		// Token: 0x06030EBD RID: 200381 RVA: 0x00B5B8EF File Offset: 0x00B59AEF
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.SetChatSelectPanelBlackMarkEnable(false);
			}
		}

		// Token: 0x0401A3E3 RID: 107491
		protected PhoneSystemChatProxy ProxyInternal;
	}
}
