using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B10 RID: 31504
	public class ITalkOptionPhoneMessageEmojiT
	{
		// Token: 0x1700EC03 RID: 60419
		// (get) Token: 0x06038BAD RID: 232365 RVA: 0x007AC732 File Offset: 0x007AA932
		// (set) Token: 0x06038BAE RID: 232366 RVA: 0x007AC73A File Offset: 0x007AA93A
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x1700EC04 RID: 60420
		// (get) Token: 0x06038BAF RID: 232367 RVA: 0x007AC743 File Offset: 0x007AA943
		// (set) Token: 0x06038BB0 RID: 232368 RVA: 0x007AC74B File Offset: 0x007AA94B
		public int EmojiId { get; set; }

		// Token: 0x1700EC05 RID: 60421
		// (get) Token: 0x06038BB1 RID: 232369 RVA: 0x007AC754 File Offset: 0x007AA954
		// (set) Token: 0x06038BB2 RID: 232370 RVA: 0x007AC75C File Offset: 0x007AA95C
		public byte NullMask { get; set; }

		// Token: 0x06038BB3 RID: 232371 RVA: 0x007AC765 File Offset: 0x007AA965
		public ITalkOptionPhoneMessageEmojiT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
			this.EmojiId = 0;
			this.NullMask = 0;
		}
	}
}
