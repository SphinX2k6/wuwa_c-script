using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049EC RID: 18924
	public class ICheckEnterTriggerDirTypeT
	{
		// Token: 0x170088E0 RID: 35040
		// (get) Token: 0x0601D91A RID: 121114 RVA: 0x0042970E File Offset: 0x0042790E
		// (set) Token: 0x0601D91B RID: 121115 RVA: 0x00429716 File Offset: 0x00427916
		public ECheckEnterTriggerDirType Type { get; set; }

		// Token: 0x0601D91C RID: 121116 RVA: 0x0042971F File Offset: 0x0042791F
		public ICheckEnterTriggerDirTypeT()
		{
			this.Type = ECheckEnterTriggerDirType.ForwardAngle;
		}
	}
}
