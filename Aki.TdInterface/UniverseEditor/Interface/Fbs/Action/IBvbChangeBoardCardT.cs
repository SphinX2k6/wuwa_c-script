using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AB RID: 26795
	public class IBvbChangeBoardCardT
	{
		// Token: 0x1700C4E9 RID: 50409
		// (get) Token: 0x0602DD03 RID: 187651 RVA: 0x00642E5B File Offset: 0x0064105B
		// (set) Token: 0x0602DD04 RID: 187652 RVA: 0x00642E63 File Offset: 0x00641063
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C4EA RID: 50410
		// (get) Token: 0x0602DD05 RID: 187653 RVA: 0x00642E6C File Offset: 0x0064106C
		// (set) Token: 0x0602DD06 RID: 187654 RVA: 0x00642E74 File Offset: 0x00641074
		public int BoardPosIndex { get; set; }

		// Token: 0x1700C4EB RID: 50411
		// (get) Token: 0x0602DD07 RID: 187655 RVA: 0x00642E7D File Offset: 0x0064107D
		// (set) Token: 0x0602DD08 RID: 187656 RVA: 0x00642E85 File Offset: 0x00641085
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700C4EC RID: 50412
		// (get) Token: 0x0602DD09 RID: 187657 RVA: 0x00642E8E File Offset: 0x0064108E
		// (set) Token: 0x0602DD0A RID: 187658 RVA: 0x00642E96 File Offset: 0x00641096
		public byte NullMask { get; set; }

		// Token: 0x0602DD0B RID: 187659 RVA: 0x00642E9F File Offset: 0x0064109F
		public IBvbChangeBoardCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.BoardPosIndex = 0;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
