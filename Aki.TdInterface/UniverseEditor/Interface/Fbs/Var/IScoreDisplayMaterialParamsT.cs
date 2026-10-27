using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC4 RID: 15044
	public class IScoreDisplayMaterialParamsT
	{
		// Token: 0x17006739 RID: 26425
		// (get) Token: 0x06014768 RID: 83816 RVA: 0x002FB49F File Offset: 0x002F969F
		// (set) Token: 0x06014769 RID: 83817 RVA: 0x002FB4A7 File Offset: 0x002F96A7
		public EParamsPreset Type { get; set; }

		// Token: 0x1700673A RID: 26426
		// (get) Token: 0x0601476A RID: 83818 RVA: 0x002FB4B0 File Offset: 0x002F96B0
		// (set) Token: 0x0601476B RID: 83819 RVA: 0x002FB4B8 File Offset: 0x002F96B8
		public IScoreDisplayParamsVarT ScoreDisplayParams { get; set; }

		// Token: 0x0601476C RID: 83820 RVA: 0x002FB4C1 File Offset: 0x002F96C1
		public IScoreDisplayMaterialParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.ScoreDisplayParams = null;
		}
	}
}
