using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E13 RID: 15891
	public class IEventTypeConfigT
	{
		// Token: 0x17006DD7 RID: 28119
		// (get) Token: 0x060163E0 RID: 91104 RVA: 0x00335E5E File Offset: 0x0033405E
		// (set) Token: 0x060163E1 RID: 91105 RVA: 0x00335E66 File Offset: 0x00334066
		public ECommonEventType Type { get; set; }

		// Token: 0x060163E2 RID: 91106 RVA: 0x00335E6F File Offset: 0x0033406F
		public IEventTypeConfigT()
		{
			this.Type = ECommonEventType.VarValueChange;
		}
	}
}
