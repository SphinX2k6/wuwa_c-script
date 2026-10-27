using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004896 RID: 18582
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrDeliveryParam : IVillageInfrDeliveryParam
	{
		// Token: 0x17007941 RID: 31041
		// (get) Token: 0x06030995 RID: 199061 RVA: 0x00B49075 File Offset: 0x00B47275
		// (set) Token: 0x06030996 RID: 199062 RVA: 0x00B4907D File Offset: 0x00B4727D
		public EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17007942 RID: 31042
		// (get) Token: 0x06030997 RID: 199063 RVA: 0x00B49086 File Offset: 0x00B47286
		// (set) Token: 0x06030998 RID: 199064 RVA: 0x00B4908E File Offset: 0x00B4728E
		public int SelectId { get; set; }

		// Token: 0x17007943 RID: 31043
		// (get) Token: 0x06030999 RID: 199065 RVA: 0x00B49097 File Offset: 0x00B47297
		// (set) Token: 0x0603099A RID: 199066 RVA: 0x00B4909F File Offset: 0x00B4729F
		public string UiCameraName { get; set; }
	}
}
