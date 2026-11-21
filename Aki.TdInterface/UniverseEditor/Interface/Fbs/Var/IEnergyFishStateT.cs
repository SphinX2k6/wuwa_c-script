using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E7B RID: 15995
	public class IEnergyFishStateT
	{
		// Token: 0x17006C15 RID: 27669
		// (get) Token: 0x0601593A RID: 88378 RVA: 0x0031C30A File Offset: 0x0031A50A
		// (set) Token: 0x0601593B RID: 88379 RVA: 0x0031C312 File Offset: 0x0031A512
		public EEnergyFishState Type { get; set; }

		// Token: 0x0601593C RID: 88380 RVA: 0x0031C31B File Offset: 0x0031A51B
		public IEnergyFishStateT()
		{
			this.Type = EEnergyFishState.Spline;
		}
	}
}
