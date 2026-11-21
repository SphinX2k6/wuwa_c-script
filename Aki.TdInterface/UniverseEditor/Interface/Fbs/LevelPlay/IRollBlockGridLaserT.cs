using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049DE RID: 18910
	public class IRollBlockGridLaserT
	{
		// Token: 0x1700848E RID: 33934
		// (get) Token: 0x0601C546 RID: 116038 RVA: 0x00400D6D File Offset: 0x003FEF6D
		// (set) Token: 0x0601C547 RID: 116039 RVA: 0x00400D75 File Offset: 0x003FEF75
		public ERollBlockGridType Type { get; set; }

		// Token: 0x1700848F RID: 33935
		// (get) Token: 0x0601C548 RID: 116040 RVA: 0x00400D7E File Offset: 0x003FEF7E
		// (set) Token: 0x0601C549 RID: 116041 RVA: 0x00400D86 File Offset: 0x003FEF86
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17008490 RID: 33936
		// (get) Token: 0x0601C54A RID: 116042 RVA: 0x00400D8F File Offset: 0x003FEF8F
		// (set) Token: 0x0601C54B RID: 116043 RVA: 0x00400D97 File Offset: 0x003FEF97
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17008491 RID: 33937
		// (get) Token: 0x0601C54C RID: 116044 RVA: 0x00400DA0 File Offset: 0x003FEFA0
		// (set) Token: 0x0601C54D RID: 116045 RVA: 0x00400DA8 File Offset: 0x003FEFA8
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x17008492 RID: 33938
		// (get) Token: 0x0601C54E RID: 116046 RVA: 0x00400DB1 File Offset: 0x003FEFB1
		// (set) Token: 0x0601C54F RID: 116047 RVA: 0x00400DB9 File Offset: 0x003FEFB9
		public int Length { get; set; }

		// Token: 0x17008493 RID: 33939
		// (get) Token: 0x0601C550 RID: 116048 RVA: 0x00400DC2 File Offset: 0x003FEFC2
		// (set) Token: 0x0601C551 RID: 116049 RVA: 0x00400DCA File Offset: 0x003FEFCA
		public int Height { get; set; }

		// Token: 0x17008494 RID: 33940
		// (get) Token: 0x0601C552 RID: 116050 RVA: 0x00400DD3 File Offset: 0x003FEFD3
		// (set) Token: 0x0601C553 RID: 116051 RVA: 0x00400DDB File Offset: 0x003FEFDB
		public byte NullMask { get; set; }

		// Token: 0x0601C554 RID: 116052 RVA: 0x00400DE4 File Offset: 0x003FEFE4
		public IRollBlockGridLaserT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.Direction = ERollBlockLayType.Left;
			this.Length = 0;
			this.Height = 0;
			this.NullMask = 0;
		}
	}
}
