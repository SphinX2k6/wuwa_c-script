using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC6 RID: 16070
	public class IScoreDisplayMaterialParamsT
	{
		// Token: 0x17006CD4 RID: 27860
		// (get) Token: 0x06015C12 RID: 89106 RVA: 0x0032172F File Offset: 0x0031F92F
		// (set) Token: 0x06015C13 RID: 89107 RVA: 0x00321737 File Offset: 0x0031F937
		public EParamsPreset Type { get; set; }

		// Token: 0x17006CD5 RID: 27861
		// (get) Token: 0x06015C14 RID: 89108 RVA: 0x00321740 File Offset: 0x0031F940
		// (set) Token: 0x06015C15 RID: 89109 RVA: 0x00321748 File Offset: 0x0031F948
		public IScoreDisplayParamsVarT ScoreDisplayParams { get; set; }

		// Token: 0x06015C16 RID: 89110 RVA: 0x00321751 File Offset: 0x0031F951
		public IScoreDisplayMaterialParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.ScoreDisplayParams = null;
		}
	}
}
