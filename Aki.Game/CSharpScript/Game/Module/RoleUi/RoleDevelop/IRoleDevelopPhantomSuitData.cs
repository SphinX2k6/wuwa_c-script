using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CD0 RID: 15568
	[NullableContext(1)]
	public interface IRoleDevelopPhantomSuitData
	{
		// Token: 0x170051AD RID: 20909
		// (get) Token: 0x06027DE9 RID: 163305
		// (set) Token: 0x06027DEA RID: 163306
		int DevelopRoleId { get; set; }

		// Token: 0x170051AE RID: 20910
		// (get) Token: 0x06027DEB RID: 163307
		// (set) Token: 0x06027DEC RID: 163308
		int FetterGroupId { get; set; }

		// Token: 0x170051AF RID: 20911
		// (get) Token: 0x06027DED RID: 163309
		// (set) Token: 0x06027DEE RID: 163310
		VisionFetterRecommendInfo VisionFetterRecommendInfo { get; set; }

		// Token: 0x170051B0 RID: 20912
		// (get) Token: 0x06027DEF RID: 163311
		// (set) Token: 0x06027DF0 RID: 163312
		int? FirstVisionMonsterId { get; set; }

		// Token: 0x170051B1 RID: 20913
		// (get) Token: 0x06027DF1 RID: 163313
		// (set) Token: 0x06027DF2 RID: 163314
		bool? IsNeedFetterButton { get; set; }
	}
}
