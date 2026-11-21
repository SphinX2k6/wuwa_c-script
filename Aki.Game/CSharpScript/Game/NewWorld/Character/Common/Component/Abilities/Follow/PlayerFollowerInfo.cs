using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006366 RID: 25446
	public class PlayerFollowerInfo
	{
		// Token: 0x0603DAA4 RID: 252580 RVA: 0x011DEA40 File Offset: 0x011DCC40
		public PlayerFollowerInfo(long creatureDataId, int? priority = 0)
		{
		}

		// Token: 0x0603DAA5 RID: 252581 RVA: 0x011DEA5C File Offset: 0x011DCC5C
		[NullableContext(1)]
		public static int Compare(PlayerFollowerInfo a, PlayerFollowerInfo b)
		{
			return a.Priority - b.Priority;
		}

		// Token: 0x04020B56 RID: 133974
		public long CreatureDataId = creatureDataId;

		// Token: 0x04020B57 RID: 133975
		public int Priority = priority.GetValueOrDefault();
	}
}
