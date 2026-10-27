using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007338 RID: 29496
	public class ITalkOptionPhoneMessageEmojiT
	{
		// Token: 0x1700E007 RID: 57351
		// (get) Token: 0x0603587A RID: 219258 RVA: 0x0074ABAA File Offset: 0x00748DAA
		// (set) Token: 0x0603587B RID: 219259 RVA: 0x0074ABB2 File Offset: 0x00748DB2
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x1700E008 RID: 57352
		// (get) Token: 0x0603587C RID: 219260 RVA: 0x0074ABBB File Offset: 0x00748DBB
		// (set) Token: 0x0603587D RID: 219261 RVA: 0x0074ABC3 File Offset: 0x00748DC3
		public int EmojiId { get; set; }

		// Token: 0x1700E009 RID: 57353
		// (get) Token: 0x0603587E RID: 219262 RVA: 0x0074ABCC File Offset: 0x00748DCC
		// (set) Token: 0x0603587F RID: 219263 RVA: 0x0074ABD4 File Offset: 0x00748DD4
		public byte NullMask { get; set; }

		// Token: 0x06035880 RID: 219264 RVA: 0x0074ABDD File Offset: 0x00748DDD
		public ITalkOptionPhoneMessageEmojiT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
			this.EmojiId = 0;
			this.NullMask = 0;
		}
	}
}
