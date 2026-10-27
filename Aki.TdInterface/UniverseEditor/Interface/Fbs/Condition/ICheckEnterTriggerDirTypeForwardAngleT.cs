using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049EF RID: 18927
	public class ICheckEnterTriggerDirTypeForwardAngleT
	{
		// Token: 0x170088E4 RID: 35044
		// (get) Token: 0x0601D92E RID: 121134 RVA: 0x00429953 File Offset: 0x00427B53
		// (set) Token: 0x0601D92F RID: 121135 RVA: 0x0042995B File Offset: 0x00427B5B
		public ECheckEnterTriggerDirType Type { get; set; }

		// Token: 0x170088E5 RID: 35045
		// (get) Token: 0x0601D930 RID: 121136 RVA: 0x00429964 File Offset: 0x00427B64
		// (set) Token: 0x0601D931 RID: 121137 RVA: 0x0042996C File Offset: 0x00427B6C
		public IEllipseConeRangeT AngleRange { get; set; }

		// Token: 0x0601D932 RID: 121138 RVA: 0x00429975 File Offset: 0x00427B75
		public ICheckEnterTriggerDirTypeForwardAngleT()
		{
			this.Type = ECheckEnterTriggerDirType.ForwardAngle;
			this.AngleRange = null;
		}
	}
}
