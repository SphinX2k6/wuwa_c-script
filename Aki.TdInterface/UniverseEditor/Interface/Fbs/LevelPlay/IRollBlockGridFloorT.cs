using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200456D RID: 17773
	public class IRollBlockGridFloorT
	{
		// Token: 0x17007E2A RID: 32298
		// (get) Token: 0x0601ACD1 RID: 109777 RVA: 0x003D2EFB File Offset: 0x003D10FB
		// (set) Token: 0x0601ACD2 RID: 109778 RVA: 0x003D2F03 File Offset: 0x003D1103
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E2B RID: 32299
		// (get) Token: 0x0601ACD3 RID: 109779 RVA: 0x003D2F0C File Offset: 0x003D110C
		// (set) Token: 0x0601ACD4 RID: 109780 RVA: 0x003D2F14 File Offset: 0x003D1114
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E2C RID: 32300
		// (get) Token: 0x0601ACD5 RID: 109781 RVA: 0x003D2F1D File Offset: 0x003D111D
		// (set) Token: 0x0601ACD6 RID: 109782 RVA: 0x003D2F25 File Offset: 0x003D1125
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E2D RID: 32301
		// (get) Token: 0x0601ACD7 RID: 109783 RVA: 0x003D2F2E File Offset: 0x003D112E
		// (set) Token: 0x0601ACD8 RID: 109784 RVA: 0x003D2F36 File Offset: 0x003D1136
		public byte NullMask { get; set; }

		// Token: 0x0601ACD9 RID: 109785 RVA: 0x003D2F3F File Offset: 0x003D113F
		public IRollBlockGridFloorT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
