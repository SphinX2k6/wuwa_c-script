using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200389F RID: 14495
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationChatTalkPartnerToggle : NavigationToggle
	{
		// Token: 0x060259E4 RID: 154084 RVA: 0x00A966A4 File Offset: 0x00A948A4
		public NavigationChatTalkPartnerToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x060259E5 RID: 154085 RVA: 0x00A966B0 File Offset: 0x00A948B0
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

		// Token: 0x060259E6 RID: 154086 RVA: 0x00A966EF File Offset: 0x00A948EF
		protected override bool OnCanFocusInScrollOrLayout()
		{
			bool isInteractive = this.IsInteractive;
			return false;
		}

		// Token: 0x060259E7 RID: 154087 RVA: 0x00A966F9 File Offset: 0x00A948F9
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.SetChatSelectPanelBlackMarkEnable(false);
			}
		}

		// Token: 0x04014C55 RID: 85077
		protected PhoneSystemChatProxy ProxyInternal;
	}
}
