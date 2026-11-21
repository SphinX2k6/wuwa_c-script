using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ECC RID: 16076
	public class IScoreDisplayParamsVarT
	{
		// Token: 0x17006CDC RID: 27868
		// (get) Token: 0x06015C41 RID: 89153 RVA: 0x00321D23 File Offset: 0x0031FF23
		// (set) Token: 0x06015C42 RID: 89154 RVA: 0x00321D2B File Offset: 0x0031FF2B
		public EScoreDisplayDataSource Type { get; set; }

		// Token: 0x17006CDD RID: 27869
		// (get) Token: 0x06015C43 RID: 89155 RVA: 0x00321D34 File Offset: 0x0031FF34
		// (set) Token: 0x06015C44 RID: 89156 RVA: 0x00321D3C File Offset: 0x0031FF3C
		public TVarRefUnion Var { get; set; }

		// Token: 0x06015C45 RID: 89157 RVA: 0x00321D45 File Offset: 0x0031FF45
		public IScoreDisplayParamsVarT()
		{
			this.Type = EScoreDisplayDataSource.Var;
			this.Var = null;
		}
	}
}
