using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200505D RID: 20573
	public class RoverlikeLootGainEntry : RoverlikeGainEntry
	{
		// Token: 0x060337EA RID: 210922 RVA: 0x00E6BB30 File Offset: 0x00E69D30
		[NullableContext(1)]
		public RoverlikeLootGainEntry(RoverRogueGainEntry proto) : base(proto)
		{
			RoverRogueLootInfo lootInfo = proto.LootInfo;
			if (lootInfo == null)
			{
				return;
			}
			this.LootRoomPassedCounter = lootInfo.LootRoomPassedCounter;
			this.LootLv = lootInfo.LootLv;
			this.Unlock = lootInfo.Unlock;
			this.Progress = lootInfo.Progress;
			this.Target = lootInfo.Target;
		}

		// Token: 0x0401B596 RID: 112022
		public int LootRoomPassedCounter;

		// Token: 0x0401B597 RID: 112023
		public int LootLv;

		// Token: 0x0401B598 RID: 112024
		public bool Unlock;

		// Token: 0x0401B599 RID: 112025
		public int Progress;

		// Token: 0x0401B59A RID: 112026
		public int Target;

		// Token: 0x0401B59B RID: 112027
		public bool IsEquipped;
	}
}
