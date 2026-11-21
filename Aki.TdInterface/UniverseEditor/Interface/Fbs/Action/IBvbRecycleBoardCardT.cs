using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C6 RID: 26822
	public class IBvbRecycleBoardCardT
	{
		// Token: 0x1700C523 RID: 50467
		// (get) Token: 0x0602DE17 RID: 187927 RVA: 0x00644E57 File Offset: 0x00643057
		// (set) Token: 0x0602DE18 RID: 187928 RVA: 0x00644E5F File Offset: 0x0064305F
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C524 RID: 50468
		// (get) Token: 0x0602DE19 RID: 187929 RVA: 0x00644E68 File Offset: 0x00643068
		// (set) Token: 0x0602DE1A RID: 187930 RVA: 0x00644E70 File Offset: 0x00643070
		public int BoardPosIndex { get; set; }

		// Token: 0x1700C525 RID: 50469
		// (get) Token: 0x0602DE1B RID: 187931 RVA: 0x00644E79 File Offset: 0x00643079
		// (set) Token: 0x0602DE1C RID: 187932 RVA: 0x00644E81 File Offset: 0x00643081
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700C526 RID: 50470
		// (get) Token: 0x0602DE1D RID: 187933 RVA: 0x00644E8A File Offset: 0x0064308A
		// (set) Token: 0x0602DE1E RID: 187934 RVA: 0x00644E92 File Offset: 0x00643092
		public byte NullMask { get; set; }

		// Token: 0x0602DE1F RID: 187935 RVA: 0x00644E9B File Offset: 0x0064309B
		public IBvbRecycleBoardCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.BoardPosIndex = 0;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
