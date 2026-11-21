using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6D RID: 23661
	public class IPasserbyNpcExitOrderBaseT
	{
		// Token: 0x1700ADE2 RID: 44514
		// (get) Token: 0x06027411 RID: 160785 RVA: 0x0056080A File Offset: 0x0055EA0A
		// (set) Token: 0x06027412 RID: 160786 RVA: 0x00560812 File Offset: 0x0055EA12
		public EPasserbyNpcExitOrderType Type { get; set; }

		// Token: 0x06027413 RID: 160787 RVA: 0x0056081B File Offset: 0x0055EA1B
		public IPasserbyNpcExitOrderBaseT()
		{
			this.Type = EPasserbyNpcExitOrderType.NearSplineStartFirst;
		}
	}
}
