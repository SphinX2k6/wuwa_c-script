using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB2 RID: 20146
	public class ICheckEnterTriggerDirTypeVelocityDirAngleT
	{
		// Token: 0x17008FB9 RID: 36793
		// (get) Token: 0x0601F3B7 RID: 127927 RVA: 0x0045A84B File Offset: 0x00458A4B
		// (set) Token: 0x0601F3B8 RID: 127928 RVA: 0x0045A853 File Offset: 0x00458A53
		public ECheckEnterTriggerDirType Type { get; set; }

		// Token: 0x17008FBA RID: 36794
		// (get) Token: 0x0601F3B9 RID: 127929 RVA: 0x0045A85C File Offset: 0x00458A5C
		// (set) Token: 0x0601F3BA RID: 127930 RVA: 0x0045A864 File Offset: 0x00458A64
		public IEllipseConeRangeT AngleRange { get; set; }

		// Token: 0x0601F3BB RID: 127931 RVA: 0x0045A86D File Offset: 0x00458A6D
		public ICheckEnterTriggerDirTypeVelocityDirAngleT()
		{
			this.Type = ECheckEnterTriggerDirType.ForwardAngle;
			this.AngleRange = null;
		}
	}
}
