using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A5E RID: 14942
	public class IBvbGetCardEvolvedUseT
	{
		// Token: 0x1700666E RID: 26222
		// (get) Token: 0x0601440A RID: 82954 RVA: 0x002F5793 File Offset: 0x002F3993
		// (set) Token: 0x0601440B RID: 82955 RVA: 0x002F579B File Offset: 0x002F399B
		public ESystemVarName Type { get; set; }

		// Token: 0x1700666F RID: 26223
		// (get) Token: 0x0601440C RID: 82956 RVA: 0x002F57A4 File Offset: 0x002F39A4
		// (set) Token: 0x0601440D RID: 82957 RVA: 0x002F57AC File Offset: 0x002F39AC
		public TVarRefUnion Card { get; set; }

		// Token: 0x0601440E RID: 82958 RVA: 0x002F57B5 File Offset: 0x002F39B5
		public IBvbGetCardEvolvedUseT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Card = null;
		}
	}
}
