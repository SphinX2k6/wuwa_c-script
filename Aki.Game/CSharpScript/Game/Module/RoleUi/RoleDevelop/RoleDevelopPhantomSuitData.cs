using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D1A RID: 19738
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopPhantomSuitData : IRoleDevelopPhantomSuitData
	{
		// Token: 0x17007E08 RID: 32264
		// (get) Token: 0x06033015 RID: 208917 RVA: 0x00BE1BCD File Offset: 0x00BDFDCD
		// (set) Token: 0x06033016 RID: 208918 RVA: 0x00BE1BD5 File Offset: 0x00BDFDD5
		public int DevelopRoleId { get; set; }

		// Token: 0x17007E09 RID: 32265
		// (get) Token: 0x06033017 RID: 208919 RVA: 0x00BE1BDE File Offset: 0x00BDFDDE
		// (set) Token: 0x06033018 RID: 208920 RVA: 0x00BE1BE6 File Offset: 0x00BDFDE6
		public int FetterGroupId { get; set; }

		// Token: 0x17007E0A RID: 32266
		// (get) Token: 0x06033019 RID: 208921 RVA: 0x00BE1BEF File Offset: 0x00BDFDEF
		// (set) Token: 0x0603301A RID: 208922 RVA: 0x00BE1BF7 File Offset: 0x00BDFDF7
		public VisionFetterRecommendInfo VisionFetterRecommendInfo { get; set; }

		// Token: 0x17007E0B RID: 32267
		// (get) Token: 0x0603301B RID: 208923 RVA: 0x00BE1C00 File Offset: 0x00BDFE00
		// (set) Token: 0x0603301C RID: 208924 RVA: 0x00BE1C08 File Offset: 0x00BDFE08
		public int? FirstVisionMonsterId { get; set; }

		// Token: 0x17007E0C RID: 32268
		// (get) Token: 0x0603301D RID: 208925 RVA: 0x00BE1C11 File Offset: 0x00BDFE11
		// (set) Token: 0x0603301E RID: 208926 RVA: 0x00BE1C19 File Offset: 0x00BDFE19
		public bool? IsNeedFetterButton { get; set; }
	}
}
