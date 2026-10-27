using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007050 RID: 28752
	public class ISetPlayerOperationRestrictionT
	{
		// Token: 0x1700D593 RID: 54675
		// (get) Token: 0x06032E21 RID: 208417 RVA: 0x006DCF46 File Offset: 0x006DB146
		// (set) Token: 0x06032E22 RID: 208418 RVA: 0x006DCF4E File Offset: 0x006DB14E
		public EPlayerOperationType Type { get; set; }

		// Token: 0x06032E23 RID: 208419 RVA: 0x006DCF57 File Offset: 0x006DB157
		public ISetPlayerOperationRestrictionT()
		{
			this.Type = EPlayerOperationType.EnableAll;
		}
	}
}
