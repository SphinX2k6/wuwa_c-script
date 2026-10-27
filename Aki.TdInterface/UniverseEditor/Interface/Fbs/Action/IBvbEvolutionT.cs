using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006246 RID: 25158
	public class IBvbEvolutionT
	{
		// Token: 0x1700BB80 RID: 48000
		// (get) Token: 0x0602B620 RID: 177696 RVA: 0x005F8DE1 File Offset: 0x005F6FE1
		// (set) Token: 0x0602B621 RID: 177697 RVA: 0x005F8DE9 File Offset: 0x005F6FE9
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BB81 RID: 48001
		// (get) Token: 0x0602B622 RID: 177698 RVA: 0x005F8DF2 File Offset: 0x005F6FF2
		// (set) Token: 0x0602B623 RID: 177699 RVA: 0x005F8DFA File Offset: 0x005F6FFA
		public int HandCardIndex { get; set; }

		// Token: 0x1700BB82 RID: 48002
		// (get) Token: 0x0602B624 RID: 177700 RVA: 0x005F8E03 File Offset: 0x005F7003
		// (set) Token: 0x0602B625 RID: 177701 RVA: 0x005F8E0B File Offset: 0x005F700B
		public int BoardPosIndex { get; set; }

		// Token: 0x1700BB83 RID: 48003
		// (get) Token: 0x0602B626 RID: 177702 RVA: 0x005F8E14 File Offset: 0x005F7014
		// (set) Token: 0x0602B627 RID: 177703 RVA: 0x005F8E1C File Offset: 0x005F701C
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700BB84 RID: 48004
		// (get) Token: 0x0602B628 RID: 177704 RVA: 0x005F8E25 File Offset: 0x005F7025
		// (set) Token: 0x0602B629 RID: 177705 RVA: 0x005F8E2D File Offset: 0x005F702D
		public byte NullMask { get; set; }

		// Token: 0x0602B62A RID: 177706 RVA: 0x005F8E36 File Offset: 0x005F7036
		public IBvbEvolutionT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.HandCardIndex = 0;
			this.BoardPosIndex = 0;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
