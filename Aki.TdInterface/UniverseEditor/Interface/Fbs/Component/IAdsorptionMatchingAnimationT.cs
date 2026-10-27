using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E66 RID: 20070
	public class IAdsorptionMatchingAnimationT
	{
		// Token: 0x17008FAB RID: 36779
		// (get) Token: 0x0601F848 RID: 129096 RVA: 0x00463C7D File Offset: 0x00461E7D
		// (set) Token: 0x0601F849 RID: 129097 RVA: 0x00463C85 File Offset: 0x00461E85
		public IVectorInfoT MatchPos { get; set; }

		// Token: 0x17008FAC RID: 36780
		// (get) Token: 0x0601F84A RID: 129098 RVA: 0x00463C8E File Offset: 0x00461E8E
		// (set) Token: 0x0601F84B RID: 129099 RVA: 0x00463C96 File Offset: 0x00461E96
		public IVectorInfoT MatchRot { get; set; }

		// Token: 0x17008FAD RID: 36781
		// (get) Token: 0x0601F84C RID: 129100 RVA: 0x00463C9F File Offset: 0x00461E9F
		// (set) Token: 0x0601F84D RID: 129101 RVA: 0x00463CA7 File Offset: 0x00461EA7
		public string MatchReferenceKey { get; set; }

		// Token: 0x17008FAE RID: 36782
		// (get) Token: 0x0601F84E RID: 129102 RVA: 0x00463CB0 File Offset: 0x00461EB0
		// (set) Token: 0x0601F84F RID: 129103 RVA: 0x00463CB8 File Offset: 0x00461EB8
		public string MoveCurve { get; set; }

		// Token: 0x0601F850 RID: 129104 RVA: 0x00463CC1 File Offset: 0x00461EC1
		public IAdsorptionMatchingAnimationT()
		{
			this.MatchPos = null;
			this.MatchRot = null;
			this.MatchReferenceKey = null;
			this.MoveCurve = null;
		}
	}
}
