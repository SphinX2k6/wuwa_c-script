using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004573 RID: 17779
	public class IRollBlockGridJumpFloorT
	{
		// Token: 0x17007E3F RID: 32319
		// (get) Token: 0x0601AD37 RID: 109879 RVA: 0x003D40C1 File Offset: 0x003D22C1
		// (set) Token: 0x0601AD38 RID: 109880 RVA: 0x003D40C9 File Offset: 0x003D22C9
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E40 RID: 32320
		// (get) Token: 0x0601AD39 RID: 109881 RVA: 0x003D40D2 File Offset: 0x003D22D2
		// (set) Token: 0x0601AD3A RID: 109882 RVA: 0x003D40DA File Offset: 0x003D22DA
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E41 RID: 32321
		// (get) Token: 0x0601AD3B RID: 109883 RVA: 0x003D40E3 File Offset: 0x003D22E3
		// (set) Token: 0x0601AD3C RID: 109884 RVA: 0x003D40EB File Offset: 0x003D22EB
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E42 RID: 32322
		// (get) Token: 0x0601AD3D RID: 109885 RVA: 0x003D40F4 File Offset: 0x003D22F4
		// (set) Token: 0x0601AD3E RID: 109886 RVA: 0x003D40FC File Offset: 0x003D22FC
		public ERollBlockLayType JumpDirection { get; set; }

		// Token: 0x17007E43 RID: 32323
		// (get) Token: 0x0601AD3F RID: 109887 RVA: 0x003D4105 File Offset: 0x003D2305
		// (set) Token: 0x0601AD40 RID: 109888 RVA: 0x003D410D File Offset: 0x003D230D
		public byte NullMask { get; set; }

		// Token: 0x0601AD41 RID: 109889 RVA: 0x003D4116 File Offset: 0x003D2316
		public IRollBlockGridJumpFloorT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.JumpDirection = ERollBlockLayType.Left;
			this.NullMask = 0;
		}
	}
}
