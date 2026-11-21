using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EAF RID: 20143
	public class ICheckEnterTriggerDirTypeForwardAngleT
	{
		// Token: 0x17008FB4 RID: 36788
		// (get) Token: 0x0601F3A1 RID: 127905 RVA: 0x0045A5BF File Offset: 0x004587BF
		// (set) Token: 0x0601F3A2 RID: 127906 RVA: 0x0045A5C7 File Offset: 0x004587C7
		public ECheckEnterTriggerDirType Type { get; set; }

		// Token: 0x17008FB5 RID: 36789
		// (get) Token: 0x0601F3A3 RID: 127907 RVA: 0x0045A5D0 File Offset: 0x004587D0
		// (set) Token: 0x0601F3A4 RID: 127908 RVA: 0x0045A5D8 File Offset: 0x004587D8
		public IEllipseConeRangeT AngleRange { get; set; }

		// Token: 0x0601F3A5 RID: 127909 RVA: 0x0045A5E1 File Offset: 0x004587E1
		public ICheckEnterTriggerDirTypeForwardAngleT()
		{
			this.Type = ECheckEnterTriggerDirType.ForwardAngle;
			this.AngleRange = null;
		}
	}
}
