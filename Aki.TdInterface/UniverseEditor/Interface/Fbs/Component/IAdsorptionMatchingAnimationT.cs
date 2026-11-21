using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005377 RID: 21367
	public class IAdsorptionMatchingAnimationT
	{
		// Token: 0x170096E4 RID: 38628
		// (get) Token: 0x06021493 RID: 136339 RVA: 0x00497C95 File Offset: 0x00495E95
		// (set) Token: 0x06021494 RID: 136340 RVA: 0x00497C9D File Offset: 0x00495E9D
		public IVectorInfoT MatchPos { get; set; }

		// Token: 0x170096E5 RID: 38629
		// (get) Token: 0x06021495 RID: 136341 RVA: 0x00497CA6 File Offset: 0x00495EA6
		// (set) Token: 0x06021496 RID: 136342 RVA: 0x00497CAE File Offset: 0x00495EAE
		public IVectorInfoT MatchRot { get; set; }

		// Token: 0x170096E6 RID: 38630
		// (get) Token: 0x06021497 RID: 136343 RVA: 0x00497CB7 File Offset: 0x00495EB7
		// (set) Token: 0x06021498 RID: 136344 RVA: 0x00497CBF File Offset: 0x00495EBF
		public string MatchReferenceKey { get; set; }

		// Token: 0x170096E7 RID: 38631
		// (get) Token: 0x06021499 RID: 136345 RVA: 0x00497CC8 File Offset: 0x00495EC8
		// (set) Token: 0x0602149A RID: 136346 RVA: 0x00497CD0 File Offset: 0x00495ED0
		public string MoveCurve { get; set; }

		// Token: 0x0602149B RID: 136347 RVA: 0x00497CD9 File Offset: 0x00495ED9
		public IAdsorptionMatchingAnimationT()
		{
			this.MatchPos = null;
			this.MatchRot = null;
			this.MatchReferenceKey = null;
			this.MoveCurve = null;
		}
	}
}
