using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D2 RID: 18898
	public class IRollBlockGridFallFloorT
	{
		// Token: 0x17008461 RID: 33889
		// (get) Token: 0x0601C474 RID: 115828 RVA: 0x003FE8EF File Offset: 0x003FCAEF
		// (set) Token: 0x0601C475 RID: 115829 RVA: 0x003FE8F7 File Offset: 0x003FCAF7
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17008462 RID: 33890
		// (get) Token: 0x0601C476 RID: 115830 RVA: 0x003FE900 File Offset: 0x003FCB00
		// (set) Token: 0x0601C477 RID: 115831 RVA: 0x003FE908 File Offset: 0x003FCB08
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17008463 RID: 33891
		// (get) Token: 0x0601C478 RID: 115832 RVA: 0x003FE911 File Offset: 0x003FCB11
		// (set) Token: 0x0601C479 RID: 115833 RVA: 0x003FE919 File Offset: 0x003FCB19
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17008464 RID: 33892
		// (get) Token: 0x0601C47A RID: 115834 RVA: 0x003FE922 File Offset: 0x003FCB22
		// (set) Token: 0x0601C47B RID: 115835 RVA: 0x003FE92A File Offset: 0x003FCB2A
		public byte NullMask { get; set; }

		// Token: 0x0601C47C RID: 115836 RVA: 0x003FE933 File Offset: 0x003FCB33
		public IRollBlockGridFallFloorT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.NullMask = 0;
		}
	}
}
