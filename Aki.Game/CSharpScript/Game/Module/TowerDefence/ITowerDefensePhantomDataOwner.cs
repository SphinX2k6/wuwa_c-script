using System;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE5 RID: 15077
	public interface ITowerDefensePhantomDataOwner
	{
		// Token: 0x17004F64 RID: 20324
		// (get) Token: 0x06026BC0 RID: 158656
		// (set) Token: 0x06026BC1 RID: 158657
		long PlayerId { get; set; }

		// Token: 0x17004F65 RID: 20325
		// (get) Token: 0x06026BC2 RID: 158658
		// (set) Token: 0x06026BC3 RID: 158659
		bool IsSelf { get; set; }

		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x06026BC4 RID: 158660
		// (set) Token: 0x06026BC5 RID: 158661
		int RoleCfgId { get; set; }

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x06026BC6 RID: 158662
		// (set) Token: 0x06026BC7 RID: 158663
		int RoleSkinId { get; set; }

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x06026BC8 RID: 158664
		// (set) Token: 0x06026BC9 RID: 158665
		int PhantomId { get; set; }
	}
}
