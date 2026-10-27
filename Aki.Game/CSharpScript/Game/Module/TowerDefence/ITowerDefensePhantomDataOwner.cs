using System;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B3D RID: 19261
	public interface ITowerDefensePhantomDataOwner
	{
		// Token: 0x17007BB7 RID: 31671
		// (get) Token: 0x06031E30 RID: 204336
		// (set) Token: 0x06031E31 RID: 204337
		long PlayerId { get; set; }

		// Token: 0x17007BB8 RID: 31672
		// (get) Token: 0x06031E32 RID: 204338
		// (set) Token: 0x06031E33 RID: 204339
		bool IsSelf { get; set; }

		// Token: 0x17007BB9 RID: 31673
		// (get) Token: 0x06031E34 RID: 204340
		// (set) Token: 0x06031E35 RID: 204341
		int RoleCfgId { get; set; }

		// Token: 0x17007BBA RID: 31674
		// (get) Token: 0x06031E36 RID: 204342
		// (set) Token: 0x06031E37 RID: 204343
		int RoleSkinId { get; set; }

		// Token: 0x17007BBB RID: 31675
		// (get) Token: 0x06031E38 RID: 204344
		// (set) Token: 0x06031E39 RID: 204345
		int PhantomId { get; set; }
	}
}
