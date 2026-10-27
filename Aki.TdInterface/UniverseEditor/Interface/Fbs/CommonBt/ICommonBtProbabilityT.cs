using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EC4 RID: 24260
	public class ICommonBtProbabilityT
	{
		// Token: 0x1700B54C RID: 46412
		// (get) Token: 0x060299F1 RID: 170481 RVA: 0x005B5DE4 File Offset: 0x005B3FE4
		// (set) Token: 0x060299F2 RID: 170482 RVA: 0x005B5DEC File Offset: 0x005B3FEC
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700B54D RID: 46413
		// (get) Token: 0x060299F3 RID: 170483 RVA: 0x005B5DF5 File Offset: 0x005B3FF5
		// (set) Token: 0x060299F4 RID: 170484 RVA: 0x005B5DFD File Offset: 0x005B3FFD
		public int Id { get; set; }

		// Token: 0x1700B54E RID: 46414
		// (get) Token: 0x060299F5 RID: 170485 RVA: 0x005B5E06 File Offset: 0x005B4006
		// (set) Token: 0x060299F6 RID: 170486 RVA: 0x005B5E0E File Offset: 0x005B400E
		public string Desc { get; set; }

		// Token: 0x1700B54F RID: 46415
		// (get) Token: 0x060299F7 RID: 170487 RVA: 0x005B5E17 File Offset: 0x005B4017
		// (set) Token: 0x060299F8 RID: 170488 RVA: 0x005B5E1F File Offset: 0x005B401F
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700B550 RID: 46416
		// (get) Token: 0x060299F9 RID: 170489 RVA: 0x005B5E28 File Offset: 0x005B4028
		// (set) Token: 0x060299FA RID: 170490 RVA: 0x005B5E30 File Offset: 0x005B4030
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700B551 RID: 46417
		// (get) Token: 0x060299FB RID: 170491 RVA: 0x005B5E39 File Offset: 0x005B4039
		// (set) Token: 0x060299FC RID: 170492 RVA: 0x005B5E41 File Offset: 0x005B4041
		public List<TCommonBtNodeUnion> Children { get; set; }

		// Token: 0x1700B552 RID: 46418
		// (get) Token: 0x060299FD RID: 170493 RVA: 0x005B5E4A File Offset: 0x005B404A
		// (set) Token: 0x060299FE RID: 170494 RVA: 0x005B5E52 File Offset: 0x005B4052
		public List<float> RandomWeights { get; set; }

		// Token: 0x1700B553 RID: 46419
		// (get) Token: 0x060299FF RID: 170495 RVA: 0x005B5E5B File Offset: 0x005B405B
		// (set) Token: 0x06029A00 RID: 170496 RVA: 0x005B5E63 File Offset: 0x005B4063
		public byte NullMask { get; set; }

		// Token: 0x06029A01 RID: 170497 RVA: 0x005B5E6C File Offset: 0x005B406C
		public ICommonBtProbabilityT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.RandomWeights = null;
			this.NullMask = 0;
		}
	}
}
