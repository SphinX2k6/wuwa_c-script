using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006240 RID: 25152
	public class IBvbDeployT
	{
		// Token: 0x1700BB72 RID: 47986
		// (get) Token: 0x0602B5E4 RID: 177636 RVA: 0x005F8791 File Offset: 0x005F6991
		// (set) Token: 0x0602B5E5 RID: 177637 RVA: 0x005F8799 File Offset: 0x005F6999
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BB73 RID: 47987
		// (get) Token: 0x0602B5E6 RID: 177638 RVA: 0x005F87A2 File Offset: 0x005F69A2
		// (set) Token: 0x0602B5E7 RID: 177639 RVA: 0x005F87AA File Offset: 0x005F69AA
		public int HandCardIndex { get; set; }

		// Token: 0x1700BB74 RID: 47988
		// (get) Token: 0x0602B5E8 RID: 177640 RVA: 0x005F87B3 File Offset: 0x005F69B3
		// (set) Token: 0x0602B5E9 RID: 177641 RVA: 0x005F87BB File Offset: 0x005F69BB
		public int BoardPosIndex { get; set; }

		// Token: 0x1700BB75 RID: 47989
		// (get) Token: 0x0602B5EA RID: 177642 RVA: 0x005F87C4 File Offset: 0x005F69C4
		// (set) Token: 0x0602B5EB RID: 177643 RVA: 0x005F87CC File Offset: 0x005F69CC
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700BB76 RID: 47990
		// (get) Token: 0x0602B5EC RID: 177644 RVA: 0x005F87D5 File Offset: 0x005F69D5
		// (set) Token: 0x0602B5ED RID: 177645 RVA: 0x005F87DD File Offset: 0x005F69DD
		public byte NullMask { get; set; }

		// Token: 0x0602B5EE RID: 177646 RVA: 0x005F87E6 File Offset: 0x005F69E6
		public IBvbDeployT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.HandCardIndex = 0;
			this.BoardPosIndex = 0;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
