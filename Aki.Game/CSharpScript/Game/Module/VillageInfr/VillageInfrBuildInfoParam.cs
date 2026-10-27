using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004894 RID: 18580
	[NullableContext(2)]
	[Nullable(0)]
	public class VillageInfrBuildInfoParam : IVillageInfrBuildInfoParam
	{
		// Token: 0x1700793A RID: 31034
		// (get) Token: 0x06030986 RID: 199046 RVA: 0x00B49029 File Offset: 0x00B47229
		// (set) Token: 0x06030987 RID: 199047 RVA: 0x00B49031 File Offset: 0x00B47231
		public EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x1700793B RID: 31035
		// (get) Token: 0x06030988 RID: 199048 RVA: 0x00B4903A File Offset: 0x00B4723A
		// (set) Token: 0x06030989 RID: 199049 RVA: 0x00B49042 File Offset: 0x00B47242
		public int SelectId { get; set; }

		// Token: 0x1700793C RID: 31036
		// (get) Token: 0x0603098A RID: 199050 RVA: 0x00B4904B File Offset: 0x00B4724B
		// (set) Token: 0x0603098B RID: 199051 RVA: 0x00B49053 File Offset: 0x00B47253
		public bool IsDelivery { get; set; }

		// Token: 0x1700793D RID: 31037
		// (get) Token: 0x0603098C RID: 199052 RVA: 0x00B4905C File Offset: 0x00B4725C
		// (set) Token: 0x0603098D RID: 199053 RVA: 0x00B49064 File Offset: 0x00B47264
		public Action CloseCb { get; set; }
	}
}
