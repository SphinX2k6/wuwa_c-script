using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD9 RID: 23257
	public class ITransportBoxElementalRangeT
	{
		// Token: 0x1700AF47 RID: 44871
		// (get) Token: 0x06027AA8 RID: 162472 RVA: 0x00574C66 File Offset: 0x00572E66
		// (set) Token: 0x06027AA9 RID: 162473 RVA: 0x00574C6E File Offset: 0x00572E6E
		public EElementalRangeType Type { get; set; }

		// Token: 0x06027AAA RID: 162474 RVA: 0x00574C77 File Offset: 0x00572E77
		public ITransportBoxElementalRangeT()
		{
			this.Type = EElementalRangeType.BaseShape;
		}
	}
}
