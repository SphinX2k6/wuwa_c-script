using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004895 RID: 18581
	[NullableContext(1)]
	public interface IVillageInfrDeliveryParam
	{
		// Token: 0x1700793E RID: 31038
		// (get) Token: 0x0603098F RID: 199055
		// (set) Token: 0x06030990 RID: 199056
		EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x1700793F RID: 31039
		// (get) Token: 0x06030991 RID: 199057
		// (set) Token: 0x06030992 RID: 199058
		int SelectId { get; set; }

		// Token: 0x17007940 RID: 31040
		// (get) Token: 0x06030993 RID: 199059
		// (set) Token: 0x06030994 RID: 199060
		string UiCameraName { get; set; }
	}
}
