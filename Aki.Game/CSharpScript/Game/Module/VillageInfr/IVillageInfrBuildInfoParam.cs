using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004893 RID: 18579
	[NullableContext(2)]
	public interface IVillageInfrBuildInfoParam
	{
		// Token: 0x17007936 RID: 31030
		// (get) Token: 0x0603097E RID: 199038
		// (set) Token: 0x0603097F RID: 199039
		EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17007937 RID: 31031
		// (get) Token: 0x06030980 RID: 199040
		// (set) Token: 0x06030981 RID: 199041
		int SelectId { get; set; }

		// Token: 0x17007938 RID: 31032
		// (get) Token: 0x06030982 RID: 199042
		// (set) Token: 0x06030983 RID: 199043
		bool IsDelivery { get; set; }

		// Token: 0x17007939 RID: 31033
		// (get) Token: 0x06030984 RID: 199044
		// (set) Token: 0x06030985 RID: 199045
		Action CloseCb { get; set; }
	}
}
