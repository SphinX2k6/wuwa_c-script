using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E5D RID: 15965
	public class IBvbPlayerScoreT
	{
		// Token: 0x17006BC5 RID: 27589
		// (get) Token: 0x0601580B RID: 88075 RVA: 0x00319E8A File Offset: 0x0031808A
		// (set) Token: 0x0601580C RID: 88076 RVA: 0x00319E92 File Offset: 0x00318092
		public ESystemVarName Type { get; set; }

		// Token: 0x0601580D RID: 88077 RVA: 0x00319E9B File Offset: 0x0031809B
		public IBvbPlayerScoreT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
