using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006255 RID: 25173
	public class IBvbRecycleBoardCardT
	{
		// Token: 0x1700BB9B RID: 48027
		// (get) Token: 0x0602B6B6 RID: 177846 RVA: 0x005FA04F File Offset: 0x005F824F
		// (set) Token: 0x0602B6B7 RID: 177847 RVA: 0x005FA057 File Offset: 0x005F8257
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BB9C RID: 48028
		// (get) Token: 0x0602B6B8 RID: 177848 RVA: 0x005FA060 File Offset: 0x005F8260
		// (set) Token: 0x0602B6B9 RID: 177849 RVA: 0x005FA068 File Offset: 0x005F8268
		public int BoardPosIndex { get; set; }

		// Token: 0x1700BB9D RID: 48029
		// (get) Token: 0x0602B6BA RID: 177850 RVA: 0x005FA071 File Offset: 0x005F8271
		// (set) Token: 0x0602B6BB RID: 177851 RVA: 0x005FA079 File Offset: 0x005F8279
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700BB9E RID: 48030
		// (get) Token: 0x0602B6BC RID: 177852 RVA: 0x005FA082 File Offset: 0x005F8282
		// (set) Token: 0x0602B6BD RID: 177853 RVA: 0x005FA08A File Offset: 0x005F828A
		public byte NullMask { get; set; }

		// Token: 0x0602B6BE RID: 177854 RVA: 0x005FA093 File Offset: 0x005F8293
		public IBvbRecycleBoardCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.BoardPosIndex = 0;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
