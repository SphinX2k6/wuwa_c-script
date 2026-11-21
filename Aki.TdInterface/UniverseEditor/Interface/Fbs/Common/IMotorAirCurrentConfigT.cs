using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006447 RID: 25671
	public class IMotorAirCurrentConfigT
	{
		// Token: 0x1700BD88 RID: 48520
		// (get) Token: 0x0602B9F0 RID: 178672 RVA: 0x005F0230 File Offset: 0x005EE430
		// (set) Token: 0x0602B9F1 RID: 178673 RVA: 0x005F0238 File Offset: 0x005EE438
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700BD89 RID: 48521
		// (get) Token: 0x0602B9F2 RID: 178674 RVA: 0x005F0241 File Offset: 0x005EE441
		// (set) Token: 0x0602B9F3 RID: 178675 RVA: 0x005F0249 File Offset: 0x005EE449
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700BD8A RID: 48522
		// (get) Token: 0x0602B9F4 RID: 178676 RVA: 0x005F0252 File Offset: 0x005EE452
		// (set) Token: 0x0602B9F5 RID: 178677 RVA: 0x005F025A File Offset: 0x005EE45A
		public float WindFieldDepth { get; set; }

		// Token: 0x1700BD8B RID: 48523
		// (get) Token: 0x0602B9F6 RID: 178678 RVA: 0x005F0263 File Offset: 0x005EE463
		// (set) Token: 0x0602B9F7 RID: 178679 RVA: 0x005F026B File Offset: 0x005EE46B
		public float MaxAdditionalSpeed { get; set; }

		// Token: 0x1700BD8C RID: 48524
		// (get) Token: 0x0602B9F8 RID: 178680 RVA: 0x005F0274 File Offset: 0x005EE474
		// (set) Token: 0x0602B9F9 RID: 178681 RVA: 0x005F027C File Offset: 0x005EE47C
		public string SpeedCurve { get; set; }

		// Token: 0x1700BD8D RID: 48525
		// (get) Token: 0x0602B9FA RID: 178682 RVA: 0x005F0285 File Offset: 0x005EE485
		// (set) Token: 0x0602B9FB RID: 178683 RVA: 0x005F028D File Offset: 0x005EE48D
		public float SpeedTolerance { get; set; }

		// Token: 0x0602B9FC RID: 178684 RVA: 0x005F0296 File Offset: 0x005EE496
		public IMotorAirCurrentConfigT()
		{
			this.Direction = null;
			this.Offset = null;
			this.WindFieldDepth = 0f;
			this.MaxAdditionalSpeed = 0f;
			this.SpeedCurve = null;
			this.SpeedTolerance = 0f;
		}
	}
}
