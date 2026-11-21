using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A66 RID: 27238
	public class IClientSetPlayerOperationRestrictionT
	{
		// Token: 0x1700C81D RID: 51229
		// (get) Token: 0x0602EBC7 RID: 191431 RVA: 0x0065EB6E File Offset: 0x0065CD6E
		// (set) Token: 0x0602EBC8 RID: 191432 RVA: 0x0065EB76 File Offset: 0x0065CD76
		public EPlayerOperationType Type { get; set; }

		// Token: 0x0602EBC9 RID: 191433 RVA: 0x0065EB7F File Offset: 0x0065CD7F
		public IClientSetPlayerOperationRestrictionT()
		{
			this.Type = EPlayerOperationType.EnableAll;
		}
	}
}
