using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200455A RID: 17754
	public class PlayerMarkCreateInfo : MarkCreateInfo
	{
		// Token: 0x0602CBC4 RID: 183236 RVA: 0x00C8721F File Offset: 0x00C8541F
		public PlayerMarkCreateInfo(int playerId, int playerIndex, FVector position, int mapId) : base(EMarkCreateType.PlayerMark)
		{
			this.PlayerId = playerId;
			this.PlayerIndex = playerIndex;
			this.Position = position;
			this.MapId = mapId;
		}

		// Token: 0x04017FD0 RID: 98256
		public int PlayerId;

		// Token: 0x04017FD1 RID: 98257
		public int PlayerIndex;

		// Token: 0x04017FD2 RID: 98258
		public FVector Position;

		// Token: 0x04017FD3 RID: 98259
		public int MapId;
	}
}
