using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BA5 RID: 19365
	public class ICompareFishingPrestigeLevelConditionT
	{
		// Token: 0x17008C91 RID: 35985
		// (get) Token: 0x0601E898 RID: 125080 RVA: 0x00445D32 File Offset: 0x00443F32
		// (set) Token: 0x0601E899 RID: 125081 RVA: 0x00445D3A File Offset: 0x00443F3A
		public ECondition Type { get; set; }

		// Token: 0x17008C92 RID: 35986
		// (get) Token: 0x0601E89A RID: 125082 RVA: 0x00445D43 File Offset: 0x00443F43
		// (set) Token: 0x0601E89B RID: 125083 RVA: 0x00445D4B File Offset: 0x00443F4B
		public ECompare Compare { get; set; }

		// Token: 0x17008C93 RID: 35987
		// (get) Token: 0x0601E89C RID: 125084 RVA: 0x00445D54 File Offset: 0x00443F54
		// (set) Token: 0x0601E89D RID: 125085 RVA: 0x00445D5C File Offset: 0x00443F5C
		public int PrestigeLevel { get; set; }

		// Token: 0x0601E89E RID: 125086 RVA: 0x00445D65 File Offset: 0x00443F65
		public ICompareFishingPrestigeLevelConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.PrestigeLevel = 0;
		}
	}
}
