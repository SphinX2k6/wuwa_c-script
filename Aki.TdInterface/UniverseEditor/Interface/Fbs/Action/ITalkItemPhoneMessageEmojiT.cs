using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AC8 RID: 31432
	public class ITalkItemPhoneMessageEmojiT
	{
		// Token: 0x1700E961 RID: 59745
		// (get) Token: 0x060381AB RID: 229803 RVA: 0x0078C00C File Offset: 0x0078A20C
		// (set) Token: 0x060381AC RID: 229804 RVA: 0x0078C014 File Offset: 0x0078A214
		public EPhoneMessageType Type { get; set; }

		// Token: 0x1700E962 RID: 59746
		// (get) Token: 0x060381AD RID: 229805 RVA: 0x0078C01D File Offset: 0x0078A21D
		// (set) Token: 0x060381AE RID: 229806 RVA: 0x0078C025 File Offset: 0x0078A225
		public int EmojiId { get; set; }

		// Token: 0x060381AF RID: 229807 RVA: 0x0078C02E File Offset: 0x0078A22E
		public ITalkItemPhoneMessageEmojiT()
		{
			this.Type = EPhoneMessageType.Voice;
			this.EmojiId = 0;
		}
	}
}
