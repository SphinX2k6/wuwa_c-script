using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DEC RID: 24044
	public class IGiantTriggerStableValueT
	{
		// Token: 0x1700B3F8 RID: 46072
		// (get) Token: 0x06029292 RID: 168594 RVA: 0x005A5F63 File Offset: 0x005A4163
		// (set) Token: 0x06029293 RID: 168595 RVA: 0x005A5F6B File Offset: 0x005A416B
		public EGiantTriggerType Type { get; set; }

		// Token: 0x1700B3F9 RID: 46073
		// (get) Token: 0x06029294 RID: 168596 RVA: 0x005A5F74 File Offset: 0x005A4174
		// (set) Token: 0x06029295 RID: 168597 RVA: 0x005A5F7C File Offset: 0x005A417C
		public TGiantStableValueUnion StableValueOption { get; set; }

		// Token: 0x06029296 RID: 168598 RVA: 0x005A5F85 File Offset: 0x005A4185
		public IGiantTriggerStableValueT()
		{
			this.Type = EGiantTriggerType.RoleState;
			this.StableValueOption = null;
		}
	}
}
