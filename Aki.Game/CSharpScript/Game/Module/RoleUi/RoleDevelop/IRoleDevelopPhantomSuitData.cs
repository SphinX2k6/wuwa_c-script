using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D19 RID: 19737
	[NullableContext(1)]
	public interface IRoleDevelopPhantomSuitData
	{
		// Token: 0x17007E03 RID: 32259
		// (get) Token: 0x0603300B RID: 208907
		// (set) Token: 0x0603300C RID: 208908
		int DevelopRoleId { get; set; }

		// Token: 0x17007E04 RID: 32260
		// (get) Token: 0x0603300D RID: 208909
		// (set) Token: 0x0603300E RID: 208910
		int FetterGroupId { get; set; }

		// Token: 0x17007E05 RID: 32261
		// (get) Token: 0x0603300F RID: 208911
		// (set) Token: 0x06033010 RID: 208912
		VisionFetterRecommendInfo VisionFetterRecommendInfo { get; set; }

		// Token: 0x17007E06 RID: 32262
		// (get) Token: 0x06033011 RID: 208913
		// (set) Token: 0x06033012 RID: 208914
		int? FirstVisionMonsterId { get; set; }

		// Token: 0x17007E07 RID: 32263
		// (get) Token: 0x06033013 RID: 208915
		// (set) Token: 0x06033014 RID: 208916
		bool? IsNeedFetterButton { get; set; }
	}
}
