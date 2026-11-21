using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200781C RID: 30748
	public class ISetPlayerOperationRestrictionT
	{
		// Token: 0x1700E174 RID: 57716
		// (get) Token: 0x060360BE RID: 221374 RVA: 0x0073D46E File Offset: 0x0073B66E
		// (set) Token: 0x060360BF RID: 221375 RVA: 0x0073D476 File Offset: 0x0073B676
		public EPlayerOperationType Type { get; set; }

		// Token: 0x060360C0 RID: 221376 RVA: 0x0073D47F File Offset: 0x0073B67F
		public ISetPlayerOperationRestrictionT()
		{
			this.Type = EPlayerOperationType.EnableAll;
		}
	}
}
