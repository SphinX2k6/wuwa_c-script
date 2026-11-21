using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006429 RID: 25641
	public class IGiantTriggerStableValueT
	{
		// Token: 0x1700BD5E RID: 48478
		// (get) Token: 0x0602B91C RID: 178460 RVA: 0x005EEC93 File Offset: 0x005ECE93
		// (set) Token: 0x0602B91D RID: 178461 RVA: 0x005EEC9B File Offset: 0x005ECE9B
		public EGiantTriggerType Type { get; set; }

		// Token: 0x1700BD5F RID: 48479
		// (get) Token: 0x0602B91E RID: 178462 RVA: 0x005EECA4 File Offset: 0x005ECEA4
		// (set) Token: 0x0602B91F RID: 178463 RVA: 0x005EECAC File Offset: 0x005ECEAC
		public TGiantStableValueUnion StableValueOption { get; set; }

		// Token: 0x0602B920 RID: 178464 RVA: 0x005EECB5 File Offset: 0x005ECEB5
		public IGiantTriggerStableValueT()
		{
			this.Type = EGiantTriggerType.RoleState;
			this.StableValueOption = null;
		}
	}
}
