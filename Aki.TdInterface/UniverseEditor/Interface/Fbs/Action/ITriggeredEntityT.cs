using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C6F RID: 31855
	public class ITriggeredEntityT
	{
		// Token: 0x1700EE83 RID: 61059
		// (get) Token: 0x060396FD RID: 235261 RVA: 0x007C10FA File Offset: 0x007BF2FA
		// (set) Token: 0x060396FE RID: 235262 RVA: 0x007C1102 File Offset: 0x007BF302
		public ETargetEntityType Type { get; set; }

		// Token: 0x060396FF RID: 235263 RVA: 0x007C110B File Offset: 0x007BF30B
		public ITriggeredEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
