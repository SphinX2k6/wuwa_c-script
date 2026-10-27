using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007142 RID: 28994
	public class PlayerFollowerItemInfo : IPlayerFollowerItemInfo
	{
		// Token: 0x17009D3D RID: 40253
		// (get) Token: 0x06046C7E RID: 289918 RVA: 0x011D611F File Offset: 0x011D431F
		// (set) Token: 0x06046C7F RID: 289919 RVA: 0x011D6127 File Offset: 0x011D4327
		public int Type { get; set; }

		// Token: 0x17009D3E RID: 40254
		// (get) Token: 0x06046C80 RID: 289920 RVA: 0x011D6130 File Offset: 0x011D4330
		// (set) Token: 0x06046C81 RID: 289921 RVA: 0x011D6138 File Offset: 0x011D4338
		public long EntityId { get; set; }
	}
}
