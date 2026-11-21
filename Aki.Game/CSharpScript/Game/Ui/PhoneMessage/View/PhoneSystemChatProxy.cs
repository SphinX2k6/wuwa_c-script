using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui.PhoneMessage.View
{
	// Token: 0x02003620 RID: 13856
	[NullableContext(1)]
	[Nullable(0)]
	public class PhoneSystemChatProxy
	{
		// Token: 0x06023FB1 RID: 147377 RVA: 0x00A3234F File Offset: 0x00A3054F
		public void RegisterView(PhoneMsgPanelViewBig view)
		{
			this.View = view;
		}

		// Token: 0x06023FB2 RID: 147378 RVA: 0x00A32358 File Offset: 0x00A30558
		public void SetChatSelectPanelBlackMarkEnable(bool isEnable)
		{
			this.View.SetChatSelectPanelBlackMarkEnable(isEnable);
		}

		// Token: 0x06023FB3 RID: 147379 RVA: 0x00A32366 File Offset: 0x00A30566
		public void OnGamepadFocusPartner(UUISelectableComponent component)
		{
			this.View.OnGamepadFocusPartner(component);
		}

		// Token: 0x0401412B RID: 82219
		private PhoneMsgPanelViewBig View;
	}
}
