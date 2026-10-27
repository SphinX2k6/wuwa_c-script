using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004146 RID: 16710
	public class IStartBtNodeT
	{
		// Token: 0x17007657 RID: 30295
		// (get) Token: 0x06018840 RID: 100416 RVA: 0x00388BC8 File Offset: 0x00386DC8
		// (set) Token: 0x06018841 RID: 100417 RVA: 0x00388BD0 File Offset: 0x00386DD0
		public EBtNode Type { get; set; }

		// Token: 0x17007658 RID: 30296
		// (get) Token: 0x06018842 RID: 100418 RVA: 0x00388BD9 File Offset: 0x00386DD9
		// (set) Token: 0x06018843 RID: 100419 RVA: 0x00388BE1 File Offset: 0x00386DE1
		public int Id { get; set; }

		// Token: 0x17007659 RID: 30297
		// (get) Token: 0x06018844 RID: 100420 RVA: 0x00388BEA File Offset: 0x00386DEA
		// (set) Token: 0x06018845 RID: 100421 RVA: 0x00388BF2 File Offset: 0x00386DF2
		public string Desc { get; set; }

		// Token: 0x1700765A RID: 30298
		// (get) Token: 0x06018846 RID: 100422 RVA: 0x00388BFB File Offset: 0x00386DFB
		// (set) Token: 0x06018847 RID: 100423 RVA: 0x00388C03 File Offset: 0x00386E03
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x1700765B RID: 30299
		// (get) Token: 0x06018848 RID: 100424 RVA: 0x00388C0C File Offset: 0x00386E0C
		// (set) Token: 0x06018849 RID: 100425 RVA: 0x00388C14 File Offset: 0x00386E14
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700765C RID: 30300
		// (get) Token: 0x0601884A RID: 100426 RVA: 0x00388C1D File Offset: 0x00386E1D
		// (set) Token: 0x0601884B RID: 100427 RVA: 0x00388C25 File Offset: 0x00386E25
		public bool Disabled { get; set; }

		// Token: 0x1700765D RID: 30301
		// (get) Token: 0x0601884C RID: 100428 RVA: 0x00388C2E File Offset: 0x00386E2E
		// (set) Token: 0x0601884D RID: 100429 RVA: 0x00388C36 File Offset: 0x00386E36
		public TBtNodeUnion Child { get; set; }

		// Token: 0x1700765E RID: 30302
		// (get) Token: 0x0601884E RID: 100430 RVA: 0x00388C3F File Offset: 0x00386E3F
		// (set) Token: 0x0601884F RID: 100431 RVA: 0x00388C47 File Offset: 0x00386E47
		public byte NullMask { get; set; }

		// Token: 0x06018850 RID: 100432 RVA: 0x00388C50 File Offset: 0x00386E50
		public IStartBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Child = null;
			this.NullMask = 0;
		}
	}
}
