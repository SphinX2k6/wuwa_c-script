using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004928 RID: 18728
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationChatTalkPartnerToggle : NavigationToggle
	{
		// Token: 0x06030EB7 RID: 200375 RVA: 0x00B5B834 File Offset: 0x00B59A34
		public NavigationChatTalkPartnerToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079D0 RID: 31184
		// (get) Token: 0x06030EB8 RID: 200376 RVA: 0x00B5B840 File Offset: 0x00B59A40
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

		// Token: 0x06030EB9 RID: 200377 RVA: 0x00B5B87F File Offset: 0x00B59A7F
		protected override bool OnCanFocusInScrollOrLayout()
		{
			bool isInteractive = this.IsInteractive;
			return false;
		}

		// Token: 0x06030EBA RID: 200378 RVA: 0x00B5B889 File Offset: 0x00B59A89
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.SetChatSelectPanelBlackMarkEnable(false);
			}
		}

		// Token: 0x0401A3E2 RID: 107490
		protected PhoneSystemChatProxy ProxyInternal;
	}
}
