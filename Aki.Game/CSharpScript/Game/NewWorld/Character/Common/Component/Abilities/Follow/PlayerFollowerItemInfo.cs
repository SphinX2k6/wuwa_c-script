using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006370 RID: 25456
	public class PlayerFollowerItemInfo : IPlayerFollowerItemInfo
	{
		// Token: 0x1700750F RID: 29967
		// (get) Token: 0x0603DACF RID: 252623 RVA: 0x011DEB34 File Offset: 0x011DCD34
		// (set) Token: 0x0603DAD0 RID: 252624 RVA: 0x011DEB3C File Offset: 0x011DCD3C
		public int Type { get; set; }

		// Token: 0x17007510 RID: 29968
		// (get) Token: 0x0603DAD1 RID: 252625 RVA: 0x011DEB45 File Offset: 0x011DCD45
		// (set) Token: 0x0603DAD2 RID: 252626 RVA: 0x011DEB4D File Offset: 0x011DCD4D
		public long EntityId { get; set; }
	}
}
