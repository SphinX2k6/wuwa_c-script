using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005584 RID: 21892
	public class PlayerMarkCreateInfo : MarkCreateInfo
	{
		// Token: 0x06037CC6 RID: 228550 RVA: 0x00D3953F File Offset: 0x00D3773F
		public PlayerMarkCreateInfo(int playerId, int playerIndex, FVector position, int mapId, EMapGravityDirection gravity = EMapGravityDirection.Down) : base(EMarkCreateType.PlayerMark)
		{
			this.PlayerId = playerId;
			this.PlayerIndex = playerIndex;
			this.Position = position;
			this.MapId = mapId;
			this.Gravity = gravity;
		}

		// Token: 0x0401D544 RID: 120132
		public int PlayerId;

		// Token: 0x0401D545 RID: 120133
		public int PlayerIndex;

		// Token: 0x0401D546 RID: 120134
		public FVector Position;

		// Token: 0x0401D547 RID: 120135
		public int MapId;

		// Token: 0x0401D548 RID: 120136
		public EMapGravityDirection Gravity;
	}
}
