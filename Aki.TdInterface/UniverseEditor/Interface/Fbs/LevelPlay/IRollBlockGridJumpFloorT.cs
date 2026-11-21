using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049DB RID: 18907
	public class IRollBlockGridJumpFloorT
	{
		// Token: 0x17008480 RID: 33920
		// (get) Token: 0x0601C50C RID: 115980 RVA: 0x0040035D File Offset: 0x003FE55D
		// (set) Token: 0x0601C50D RID: 115981 RVA: 0x00400365 File Offset: 0x003FE565
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17008481 RID: 33921
		// (get) Token: 0x0601C50E RID: 115982 RVA: 0x0040036E File Offset: 0x003FE56E
		// (set) Token: 0x0601C50F RID: 115983 RVA: 0x00400376 File Offset: 0x003FE576
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17008482 RID: 33922
		// (get) Token: 0x0601C510 RID: 115984 RVA: 0x0040037F File Offset: 0x003FE57F
		// (set) Token: 0x0601C511 RID: 115985 RVA: 0x00400387 File Offset: 0x003FE587
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17008483 RID: 33923
		// (get) Token: 0x0601C512 RID: 115986 RVA: 0x00400390 File Offset: 0x003FE590
		// (set) Token: 0x0601C513 RID: 115987 RVA: 0x00400398 File Offset: 0x003FE598
		public ERollBlockLayType JumpDirection { get; set; }

		// Token: 0x17008484 RID: 33924
		// (get) Token: 0x0601C514 RID: 115988 RVA: 0x004003A1 File Offset: 0x003FE5A1
		// (set) Token: 0x0601C515 RID: 115989 RVA: 0x004003A9 File Offset: 0x003FE5A9
		public byte NullMask { get; set; }

		// Token: 0x0601C516 RID: 115990 RVA: 0x004003B2 File Offset: 0x003FE5B2
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
