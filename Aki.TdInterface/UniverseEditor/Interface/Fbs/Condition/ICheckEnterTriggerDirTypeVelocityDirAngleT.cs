using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F2 RID: 18930
	public class ICheckEnterTriggerDirTypeVelocityDirAngleT
	{
		// Token: 0x170088E9 RID: 35049
		// (get) Token: 0x0601D944 RID: 121156 RVA: 0x00429BDF File Offset: 0x00427DDF
		// (set) Token: 0x0601D945 RID: 121157 RVA: 0x00429BE7 File Offset: 0x00427DE7
		public ECheckEnterTriggerDirType Type { get; set; }

		// Token: 0x170088EA RID: 35050
		// (get) Token: 0x0601D946 RID: 121158 RVA: 0x00429BF0 File Offset: 0x00427DF0
		// (set) Token: 0x0601D947 RID: 121159 RVA: 0x00429BF8 File Offset: 0x00427DF8
		public IEllipseConeRangeT AngleRange { get; set; }

		// Token: 0x0601D948 RID: 121160 RVA: 0x00429C01 File Offset: 0x00427E01
		public ICheckEnterTriggerDirTypeVelocityDirAngleT()
		{
			this.Type = ECheckEnterTriggerDirType.ForwardAngle;
			this.AngleRange = null;
		}
	}
}
