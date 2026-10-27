using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C5F RID: 19551
	public class IOnlinePlayerConditionTargetT
	{
		// Token: 0x17008E07 RID: 36359
		// (get) Token: 0x0601F003 RID: 126979 RVA: 0x00455CD6 File Offset: 0x00453ED6
		// (set) Token: 0x0601F004 RID: 126980 RVA: 0x00455CDE File Offset: 0x00453EDE
		public EOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x0601F005 RID: 126981 RVA: 0x00455CE7 File Offset: 0x00453EE7
		public IOnlinePlayerConditionTargetT()
		{
			this.Type = EOnlinePlayerConditionTarget.Host;
		}
	}
}
