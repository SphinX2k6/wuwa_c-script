using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060DF RID: 24799
	public class RoverlikeLootGainEntry : RoverlikeGainEntry
	{
		// Token: 0x0603EB28 RID: 256808 RVA: 0x00F24CD8 File Offset: 0x00F22ED8
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

		// Token: 0x04020C69 RID: 134249
		public int LootRoomPassedCounter;

		// Token: 0x04020C6A RID: 134250
		public int LootLv;

		// Token: 0x04020C6B RID: 134251
		public bool Unlock;

		// Token: 0x04020C6C RID: 134252
		public int Progress;

		// Token: 0x04020C6D RID: 134253
		public int Target;

		// Token: 0x04020C6E RID: 134254
		public bool IsEquipped;
	}
}
