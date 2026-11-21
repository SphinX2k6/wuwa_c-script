using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CDD RID: 15581
	public interface IRoleDevelopSkillData
	{
		// Token: 0x170051E5 RID: 20965
		// (get) Token: 0x06027E5F RID: 163423
		// (set) Token: 0x06027E60 RID: 163424
		int RoleId { get; set; }

		// Token: 0x170051E6 RID: 20966
		// (get) Token: 0x06027E61 RID: 163425
		// (set) Token: 0x06027E62 RID: 163426
		int SkillNodeId { get; set; }

		// Token: 0x170051E7 RID: 20967
		// (get) Token: 0x06027E63 RID: 163427
		// (set) Token: 0x06027E64 RID: 163428
		int CurrentLevel { get; set; }

		// Token: 0x170051E8 RID: 20968
		// (get) Token: 0x06027E65 RID: 163429
		// (set) Token: 0x06027E66 RID: 163430
		int TargetLevel { get; set; }

		// Token: 0x170051E9 RID: 20969
		// (get) Token: 0x06027E67 RID: 163431
		// (set) Token: 0x06027E68 RID: 163432
		int Index { get; set; }
	}
}
