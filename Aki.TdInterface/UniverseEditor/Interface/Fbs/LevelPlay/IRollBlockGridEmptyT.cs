using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004567 RID: 17767
	public class IRollBlockGridEmptyT
	{
		// Token: 0x17007E16 RID: 32278
		// (get) Token: 0x0601AC6D RID: 109677 RVA: 0x003D1DAB File Offset: 0x003CFFAB
		// (set) Token: 0x0601AC6E RID: 109678 RVA: 0x003D1DB3 File Offset: 0x003CFFB3
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E17 RID: 32279
		// (get) Token: 0x0601AC6F RID: 109679 RVA: 0x003D1DBC File Offset: 0x003CFFBC
		// (set) Token: 0x0601AC70 RID: 109680 RVA: 0x003D1DC4 File Offset: 0x003CFFC4
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E18 RID: 32280
		// (get) Token: 0x0601AC71 RID: 109681 RVA: 0x003D1DCD File Offset: 0x003CFFCD
		// (set) Token: 0x0601AC72 RID: 109682 RVA: 0x003D1DD5 File Offset: 0x003CFFD5
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E19 RID: 32281
		// (get) Token: 0x0601AC73 RID: 109683 RVA: 0x003D1DDE File Offset: 0x003CFFDE
		// (set) Token: 0x0601AC74 RID: 109684 RVA: 0x003D1DE6 File Offset: 0x003CFFE6
		public byte NullMask { get; set; }

		// Token: 0x0601AC75 RID: 109685 RVA: 0x003D1DEF File Offset: 0x003CFFEF
		public IRollBlockGridEmptyT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
