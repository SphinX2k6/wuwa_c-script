using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A0 RID: 14496
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationChatTalkToggle : NavigationToggle
	{
		// Token: 0x060259E8 RID: 154088 RVA: 0x00A96712 File Offset: 0x00A94912
		public NavigationChatTalkToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x060259E9 RID: 154089 RVA: 0x00A96720 File Offset: 0x00A94920
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

		// Token: 0x060259EA RID: 154090 RVA: 0x00A9675F File Offset: 0x00A9495F
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.SetChatSelectPanelBlackMarkEnable(false);
			}
		}

		// Token: 0x04014C56 RID: 85078
		protected PhoneSystemChatProxy ProxyInternal;
	}
}
