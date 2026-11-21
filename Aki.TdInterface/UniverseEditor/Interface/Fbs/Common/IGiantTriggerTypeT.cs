using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200642C RID: 25644
	public class IGiantTriggerTypeT
	{
		// Token: 0x1700BD62 RID: 48482
		// (get) Token: 0x0602B930 RID: 178480 RVA: 0x005EEE62 File Offset: 0x005ED062
		// (set) Token: 0x0602B931 RID: 178481 RVA: 0x005EEE6A File Offset: 0x005ED06A
		public EGiantTriggerType Type { get; set; }

		// Token: 0x0602B932 RID: 178482 RVA: 0x005EEE73 File Offset: 0x005ED073
		public IGiantTriggerTypeT()
		{
			this.Type = EGiantTriggerType.RoleState;
		}
	}
}
