using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006180 RID: 24960
	public class IAirPassageMoveLimitT
	{
		// Token: 0x1700BA22 RID: 47650
		// (get) Token: 0x0602AFF8 RID: 176120 RVA: 0x005EEAC4 File Offset: 0x005ECCC4
		// (set) Token: 0x0602AFF9 RID: 176121 RVA: 0x005EEACC File Offset: 0x005ECCCC
		public float DirectionAngleLimit { get; set; }

		// Token: 0x1700BA23 RID: 47651
		// (get) Token: 0x0602AFFA RID: 176122 RVA: 0x005EEAD5 File Offset: 0x005ECCD5
		// (set) Token: 0x0602AFFB RID: 176123 RVA: 0x005EEADD File Offset: 0x005ECCDD
		public float EdgeLimitCurveFactor { get; set; }

		// Token: 0x0602AFFC RID: 176124 RVA: 0x005EEAE6 File Offset: 0x005ECCE6
		public IAirPassageMoveLimitT()
		{
			this.DirectionAngleLimit = 0f;
			this.EdgeLimitCurveFactor = 0f;
		}
	}
}
