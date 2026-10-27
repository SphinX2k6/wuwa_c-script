using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200623A RID: 25146
	public class IBvbChangeBoardCardT
	{
		// Token: 0x1700BB61 RID: 47969
		// (get) Token: 0x0602B5A2 RID: 177570 RVA: 0x005F8053 File Offset: 0x005F6253
		// (set) Token: 0x0602B5A3 RID: 177571 RVA: 0x005F805B File Offset: 0x005F625B
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BB62 RID: 47970
		// (get) Token: 0x0602B5A4 RID: 177572 RVA: 0x005F8064 File Offset: 0x005F6264
		// (set) Token: 0x0602B5A5 RID: 177573 RVA: 0x005F806C File Offset: 0x005F626C
		public int BoardPosIndex { get; set; }

		// Token: 0x1700BB63 RID: 47971
		// (get) Token: 0x0602B5A6 RID: 177574 RVA: 0x005F8075 File Offset: 0x005F6275
		// (set) Token: 0x0602B5A7 RID: 177575 RVA: 0x005F807D File Offset: 0x005F627D
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700BB64 RID: 47972
		// (get) Token: 0x0602B5A8 RID: 177576 RVA: 0x005F8086 File Offset: 0x005F6286
		// (set) Token: 0x0602B5A9 RID: 177577 RVA: 0x005F808E File Offset: 0x005F628E
		public byte NullMask { get; set; }

		// Token: 0x0602B5AA RID: 177578 RVA: 0x005F8097 File Offset: 0x005F6297
		public IBvbChangeBoardCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.BoardPosIndex = 0;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
