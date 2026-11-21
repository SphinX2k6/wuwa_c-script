using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047D5 RID: 18389
	public class IPerformerAiProbabilityT
	{
		// Token: 0x1700801A RID: 32794
		// (get) Token: 0x0601B1B4 RID: 111028 RVA: 0x003D7098 File Offset: 0x003D5298
		// (set) Token: 0x0601B1B5 RID: 111029 RVA: 0x003D70A0 File Offset: 0x003D52A0
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x1700801B RID: 32795
		// (get) Token: 0x0601B1B6 RID: 111030 RVA: 0x003D70A9 File Offset: 0x003D52A9
		// (set) Token: 0x0601B1B7 RID: 111031 RVA: 0x003D70B1 File Offset: 0x003D52B1
		public int Id { get; set; }

		// Token: 0x1700801C RID: 32796
		// (get) Token: 0x0601B1B8 RID: 111032 RVA: 0x003D70BA File Offset: 0x003D52BA
		// (set) Token: 0x0601B1B9 RID: 111033 RVA: 0x003D70C2 File Offset: 0x003D52C2
		public string Desc { get; set; }

		// Token: 0x1700801D RID: 32797
		// (get) Token: 0x0601B1BA RID: 111034 RVA: 0x003D70CB File Offset: 0x003D52CB
		// (set) Token: 0x0601B1BB RID: 111035 RVA: 0x003D70D3 File Offset: 0x003D52D3
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700801E RID: 32798
		// (get) Token: 0x0601B1BC RID: 111036 RVA: 0x003D70DC File Offset: 0x003D52DC
		// (set) Token: 0x0601B1BD RID: 111037 RVA: 0x003D70E4 File Offset: 0x003D52E4
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700801F RID: 32799
		// (get) Token: 0x0601B1BE RID: 111038 RVA: 0x003D70ED File Offset: 0x003D52ED
		// (set) Token: 0x0601B1BF RID: 111039 RVA: 0x003D70F5 File Offset: 0x003D52F5
		public List<TPerformerAiNodeUnion> Children { get; set; }

		// Token: 0x17008020 RID: 32800
		// (get) Token: 0x0601B1C0 RID: 111040 RVA: 0x003D70FE File Offset: 0x003D52FE
		// (set) Token: 0x0601B1C1 RID: 111041 RVA: 0x003D7106 File Offset: 0x003D5306
		public List<float> RandomWeights { get; set; }

		// Token: 0x17008021 RID: 32801
		// (get) Token: 0x0601B1C2 RID: 111042 RVA: 0x003D710F File Offset: 0x003D530F
		// (set) Token: 0x0601B1C3 RID: 111043 RVA: 0x003D7117 File Offset: 0x003D5317
		public byte NullMask { get; set; }

		// Token: 0x0601B1C4 RID: 111044 RVA: 0x003D7120 File Offset: 0x003D5320
		public IPerformerAiProbabilityT()
		{
			this.Type = EPerformerAiNodeType.Start;
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
