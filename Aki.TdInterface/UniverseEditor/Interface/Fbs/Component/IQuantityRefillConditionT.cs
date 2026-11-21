using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DCE RID: 24014
	public class IQuantityRefillConditionT
	{
		// Token: 0x1700B0DA RID: 45274
		// (get) Token: 0x06028096 RID: 163990 RVA: 0x00579A14 File Offset: 0x00577C14
		// (set) Token: 0x06028097 RID: 163991 RVA: 0x00579A1C File Offset: 0x00577C1C
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x1700B0DB RID: 45275
		// (get) Token: 0x06028098 RID: 163992 RVA: 0x00579A25 File Offset: 0x00577C25
		// (set) Token: 0x06028099 RID: 163993 RVA: 0x00579A2D File Offset: 0x00577C2D
		public int Quantity { get; set; }

		// Token: 0x1700B0DC RID: 45276
		// (get) Token: 0x0602809A RID: 163994 RVA: 0x00579A36 File Offset: 0x00577C36
		// (set) Token: 0x0602809B RID: 163995 RVA: 0x00579A3E File Offset: 0x00577C3E
		public float DelayRefill { get; set; }

		// Token: 0x1700B0DD RID: 45277
		// (get) Token: 0x0602809C RID: 163996 RVA: 0x00579A47 File Offset: 0x00577C47
		// (set) Token: 0x0602809D RID: 163997 RVA: 0x00579A4F File Offset: 0x00577C4F
		public byte NullMask { get; set; }

		// Token: 0x0602809E RID: 163998 RVA: 0x00579A58 File Offset: 0x00577C58
		public IQuantityRefillConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
			this.Quantity = 0;
			this.DelayRefill = 0f;
			this.NullMask = 0;
		}
	}
}
