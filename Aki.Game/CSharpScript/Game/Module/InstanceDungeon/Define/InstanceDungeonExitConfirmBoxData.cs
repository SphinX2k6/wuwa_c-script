using System;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048AA RID: 18602
	public class InstanceDungeonExitConfirmBoxData : IInstanceDungeonExitConfirmBoxData
	{
		// Token: 0x17005E8A RID: 24202
		// (get) Token: 0x0602EBAF RID: 191407 RVA: 0x00D09251 File Offset: 0x00D07451
		// (set) Token: 0x0602EBB0 RID: 191408 RVA: 0x00D09259 File Offset: 0x00D07459
		public EInstanceDungeonExitConfirmBoxParseRule ParseRuleType { get; set; }

		// Token: 0x17005E8B RID: 24203
		// (get) Token: 0x0602EBB1 RID: 191409 RVA: 0x00D09262 File Offset: 0x00D07462
		// (set) Token: 0x0602EBB2 RID: 191410 RVA: 0x00D0926A File Offset: 0x00D0746A
		public int? UnfinishedBoxId { get; set; }

		// Token: 0x17005E8C RID: 24204
		// (get) Token: 0x0602EBB3 RID: 191411 RVA: 0x00D09273 File Offset: 0x00D07473
		// (set) Token: 0x0602EBB4 RID: 191412 RVA: 0x00D0927B File Offset: 0x00D0747B
		public int? FinishBoxId { get; set; }

		// Token: 0x17005E8D RID: 24205
		// (get) Token: 0x0602EBB5 RID: 191413 RVA: 0x00D09284 File Offset: 0x00D07484
		// (set) Token: 0x0602EBB6 RID: 191414 RVA: 0x00D0928C File Offset: 0x00D0748C
		public int? UnfinishedTelBoxId { get; set; }

		// Token: 0x17005E8E RID: 24206
		// (get) Token: 0x0602EBB7 RID: 191415 RVA: 0x00D09295 File Offset: 0x00D07495
		// (set) Token: 0x0602EBB8 RID: 191416 RVA: 0x00D0929D File Offset: 0x00D0749D
		public int? FinishTelBoxId { get; set; }
	}
}
