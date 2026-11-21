using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200507D RID: 20605
	public class ICompareDungeonIdT
	{
		// Token: 0x1700937E RID: 37758
		// (get) Token: 0x060203A0 RID: 132000 RVA: 0x004777C6 File Offset: 0x004759C6
		// (set) Token: 0x060203A1 RID: 132001 RVA: 0x004777CE File Offset: 0x004759CE
		public ECondition Type { get; set; }

		// Token: 0x1700937F RID: 37759
		// (get) Token: 0x060203A2 RID: 132002 RVA: 0x004777D7 File Offset: 0x004759D7
		// (set) Token: 0x060203A3 RID: 132003 RVA: 0x004777DF File Offset: 0x004759DF
		public int DungeonId { get; set; }

		// Token: 0x17009380 RID: 37760
		// (get) Token: 0x060203A4 RID: 132004 RVA: 0x004777E8 File Offset: 0x004759E8
		// (set) Token: 0x060203A5 RID: 132005 RVA: 0x004777F0 File Offset: 0x004759F0
		public ECompare Compare { get; set; }

		// Token: 0x060203A6 RID: 132006 RVA: 0x004777F9 File Offset: 0x004759F9
		public ICompareDungeonIdT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
