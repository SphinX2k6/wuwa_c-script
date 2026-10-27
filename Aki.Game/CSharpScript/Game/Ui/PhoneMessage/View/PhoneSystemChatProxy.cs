using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui.PhoneMessage.View
{
	// Token: 0x020046F0 RID: 18160
	[NullableContext(1)]
	[Nullable(0)]
	public class PhoneSystemChatProxy
	{
		// Token: 0x0602F7EC RID: 194540 RVA: 0x00B0268B File Offset: 0x00B0088B
		public void RegisterView(PhoneMsgPanelViewBig view)
		{
			this.View = view;
		}

		// Token: 0x0602F7ED RID: 194541 RVA: 0x00B02694 File Offset: 0x00B00894
		public void SetChatSelectPanelBlackMarkEnable(bool isEnable)
		{
			this.View.SetChatSelectPanelBlackMarkEnable(isEnable);
		}

		// Token: 0x04019A7C RID: 105084
		private PhoneMsgPanelViewBig View;
	}
}
