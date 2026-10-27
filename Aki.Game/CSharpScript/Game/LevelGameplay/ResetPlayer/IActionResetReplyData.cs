using System;

namespace CSharpScript.Game.LevelGamePlay.ResetPlayer
{
	// Token: 0x02006AB2 RID: 27314
	public class IActionResetReplyData
	{
		// Token: 0x1700994B RID: 39243
		// (get) Token: 0x06043DAB RID: 277931 RVA: 0x010A13F9 File Offset: 0x0109F5F9
		// (set) Token: 0x06043DAC RID: 277932 RVA: 0x010A1401 File Offset: 0x0109F601
		public int PlayerId { get; set; }

		// Token: 0x1700994C RID: 39244
		// (get) Token: 0x06043DAD RID: 277933 RVA: 0x010A140A File Offset: 0x0109F60A
		// (set) Token: 0x06043DAE RID: 277934 RVA: 0x010A1412 File Offset: 0x0109F612
		public int IncId { get; set; }

		// Token: 0x1700994D RID: 39245
		// (get) Token: 0x06043DAF RID: 277935 RVA: 0x010A141B File Offset: 0x0109F61B
		// (set) Token: 0x06043DB0 RID: 277936 RVA: 0x010A1423 File Offset: 0x0109F623
		public int Index { get; set; }
	}
}
