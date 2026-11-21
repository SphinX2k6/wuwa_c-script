using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200380D RID: 14349
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrDeliveryParam : IVillageInfrDeliveryParam
	{
		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x060254C1 RID: 152769 RVA: 0x00A83E7D File Offset: 0x00A8207D
		// (set) Token: 0x060254C2 RID: 152770 RVA: 0x00A83E85 File Offset: 0x00A82085
		public EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x060254C3 RID: 152771 RVA: 0x00A83E8E File Offset: 0x00A8208E
		// (set) Token: 0x060254C4 RID: 152772 RVA: 0x00A83E96 File Offset: 0x00A82096
		public int SelectId { get; set; }

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x060254C5 RID: 152773 RVA: 0x00A83E9F File Offset: 0x00A8209F
		// (set) Token: 0x060254C6 RID: 152774 RVA: 0x00A83EA7 File Offset: 0x00A820A7
		public string UiCameraName { get; set; }
	}
}
