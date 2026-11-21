using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B7 RID: 26807
	public class IBvbEvolutionT
	{
		// Token: 0x1700C508 RID: 50440
		// (get) Token: 0x0602DD81 RID: 187777 RVA: 0x00643BE9 File Offset: 0x00641DE9
		// (set) Token: 0x0602DD82 RID: 187778 RVA: 0x00643BF1 File Offset: 0x00641DF1
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C509 RID: 50441
		// (get) Token: 0x0602DD83 RID: 187779 RVA: 0x00643BFA File Offset: 0x00641DFA
		// (set) Token: 0x0602DD84 RID: 187780 RVA: 0x00643C02 File Offset: 0x00641E02
		public int HandCardIndex { get; set; }

		// Token: 0x1700C50A RID: 50442
		// (get) Token: 0x0602DD85 RID: 187781 RVA: 0x00643C0B File Offset: 0x00641E0B
		// (set) Token: 0x0602DD86 RID: 187782 RVA: 0x00643C13 File Offset: 0x00641E13
		public int BoardPosIndex { get; set; }

		// Token: 0x1700C50B RID: 50443
		// (get) Token: 0x0602DD87 RID: 187783 RVA: 0x00643C1C File Offset: 0x00641E1C
		// (set) Token: 0x0602DD88 RID: 187784 RVA: 0x00643C24 File Offset: 0x00641E24
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700C50C RID: 50444
		// (get) Token: 0x0602DD89 RID: 187785 RVA: 0x00643C2D File Offset: 0x00641E2D
		// (set) Token: 0x0602DD8A RID: 187786 RVA: 0x00643C35 File Offset: 0x00641E35
		public byte NullMask { get; set; }

		// Token: 0x0602DD8B RID: 187787 RVA: 0x00643C3E File Offset: 0x00641E3E
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
