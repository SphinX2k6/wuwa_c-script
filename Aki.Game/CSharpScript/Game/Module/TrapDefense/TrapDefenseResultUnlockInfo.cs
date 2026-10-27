using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A5E RID: 19038
	public class TrapDefenseResultUnlockInfo : ITrapDefenseResultUnlockInfo
	{
		// Token: 0x17007A82 RID: 31362
		// (get) Token: 0x06031603 RID: 202243 RVA: 0x00B72509 File Offset: 0x00B70709
		// (set) Token: 0x06031604 RID: 202244 RVA: 0x00B72511 File Offset: 0x00B70711
		public ETrapDefenseResultUnlockType Type { get; set; }

		// Token: 0x17007A83 RID: 31363
		// (get) Token: 0x06031605 RID: 202245 RVA: 0x00B7251A File Offset: 0x00B7071A
		// (set) Token: 0x06031606 RID: 202246 RVA: 0x00B72522 File Offset: 0x00B70722
		public int Id { get; set; }

		// Token: 0x17007A84 RID: 31364
		// (get) Token: 0x06031607 RID: 202247 RVA: 0x00B7252B File Offset: 0x00B7072B
		// (set) Token: 0x06031608 RID: 202248 RVA: 0x00B72533 File Offset: 0x00B70733
		public bool? NeedUnlockBar { get; set; }

		// Token: 0x17007A85 RID: 31365
		// (get) Token: 0x06031609 RID: 202249 RVA: 0x00B7253C File Offset: 0x00B7073C
		// (set) Token: 0x0603160A RID: 202250 RVA: 0x00B72544 File Offset: 0x00B70744
		public bool? IsFinish { get; set; }

		// Token: 0x17007A86 RID: 31366
		// (get) Token: 0x0603160B RID: 202251 RVA: 0x00B7254D File Offset: 0x00B7074D
		// (set) Token: 0x0603160C RID: 202252 RVA: 0x00B72555 File Offset: 0x00B70755
		public bool? IsNewUnlock { get; set; }

		// Token: 0x17007A87 RID: 31367
		// (get) Token: 0x0603160D RID: 202253 RVA: 0x00B7255E File Offset: 0x00B7075E
		// (set) Token: 0x0603160E RID: 202254 RVA: 0x00B72566 File Offset: 0x00B70766
		public bool? ForShare { get; set; }
	}
}
