using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F3 RID: 29427
	public class ITalkItemPhoneMessageEmojiT
	{
		// Token: 0x1700DD68 RID: 56680
		// (get) Token: 0x06034EA5 RID: 216741 RVA: 0x0072ABA8 File Offset: 0x00728DA8
		// (set) Token: 0x06034EA6 RID: 216742 RVA: 0x0072ABB0 File Offset: 0x00728DB0
		public EPhoneMessageType Type { get; set; }

		// Token: 0x1700DD69 RID: 56681
		// (get) Token: 0x06034EA7 RID: 216743 RVA: 0x0072ABB9 File Offset: 0x00728DB9
		// (set) Token: 0x06034EA8 RID: 216744 RVA: 0x0072ABC1 File Offset: 0x00728DC1
		public int EmojiId { get; set; }

		// Token: 0x06034EA9 RID: 216745 RVA: 0x0072ABCA File Offset: 0x00728DCA
		public ITalkItemPhoneMessageEmojiT()
		{
			this.Type = EPhoneMessageType.Voice;
			this.EmojiId = 0;
		}
	}
}
