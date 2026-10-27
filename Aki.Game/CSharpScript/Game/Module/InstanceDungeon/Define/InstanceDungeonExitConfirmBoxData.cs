using System;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D2 RID: 22738
	public class InstanceDungeonExitConfirmBoxData : IInstanceDungeonExitConfirmBoxData
	{
		// Token: 0x17008ABE RID: 35518
		// (get) Token: 0x06039C8C RID: 236684 RVA: 0x00DBA339 File Offset: 0x00DB8539
		// (set) Token: 0x06039C8D RID: 236685 RVA: 0x00DBA341 File Offset: 0x00DB8541
		public EInstanceDungeonExitConfirmBoxParseRule ParseRuleType { get; set; }

		// Token: 0x17008ABF RID: 35519
		// (get) Token: 0x06039C8E RID: 236686 RVA: 0x00DBA34A File Offset: 0x00DB854A
		// (set) Token: 0x06039C8F RID: 236687 RVA: 0x00DBA352 File Offset: 0x00DB8552
		public int? UnfinishedBoxId { get; set; }

		// Token: 0x17008AC0 RID: 35520
		// (get) Token: 0x06039C90 RID: 236688 RVA: 0x00DBA35B File Offset: 0x00DB855B
		// (set) Token: 0x06039C91 RID: 236689 RVA: 0x00DBA363 File Offset: 0x00DB8563
		public int? FinishBoxId { get; set; }

		// Token: 0x17008AC1 RID: 35521
		// (get) Token: 0x06039C92 RID: 236690 RVA: 0x00DBA36C File Offset: 0x00DB856C
		// (set) Token: 0x06039C93 RID: 236691 RVA: 0x00DBA374 File Offset: 0x00DB8574
		public int? UnfinishedTelBoxId { get; set; }

		// Token: 0x17008AC2 RID: 35522
		// (get) Token: 0x06039C94 RID: 236692 RVA: 0x00DBA37D File Offset: 0x00DB857D
		// (set) Token: 0x06039C95 RID: 236693 RVA: 0x00DBA385 File Offset: 0x00DB8585
		public int? FinishTelBoxId { get; set; }
	}
}
