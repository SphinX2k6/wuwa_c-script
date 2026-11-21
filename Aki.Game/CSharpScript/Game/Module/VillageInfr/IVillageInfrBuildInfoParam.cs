using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200380A RID: 14346
	[NullableContext(2)]
	public interface IVillageInfrBuildInfoParam
	{
		// Token: 0x17004C9E RID: 19614
		// (get) Token: 0x060254AA RID: 152746
		// (set) Token: 0x060254AB RID: 152747
		EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x060254AC RID: 152748
		// (set) Token: 0x060254AD RID: 152749
		int SelectId { get; set; }

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x060254AE RID: 152750
		// (set) Token: 0x060254AF RID: 152751
		bool IsDelivery { get; set; }

		// Token: 0x17004CA1 RID: 19617
		// (get) Token: 0x060254B0 RID: 152752
		// (set) Token: 0x060254B1 RID: 152753
		Action CloseCb { get; set; }
	}
}
