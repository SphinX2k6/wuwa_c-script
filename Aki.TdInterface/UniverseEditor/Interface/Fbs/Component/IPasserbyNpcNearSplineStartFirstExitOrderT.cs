using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9D RID: 23709
	public class IPasserbyNpcNearSplineStartFirstExitOrderT
	{
		// Token: 0x1700AE25 RID: 44581
		// (get) Token: 0x06027545 RID: 161093 RVA: 0x00562626 File Offset: 0x00560826
		// (set) Token: 0x06027546 RID: 161094 RVA: 0x0056262E File Offset: 0x0056082E
		public EPasserbyNpcExitOrderType Type { get; set; }

		// Token: 0x06027547 RID: 161095 RVA: 0x00562637 File Offset: 0x00560837
		public IPasserbyNpcNearSplineStartFirstExitOrderT()
		{
			this.Type = EPasserbyNpcExitOrderType.NearSplineStartFirst;
		}
	}
}
