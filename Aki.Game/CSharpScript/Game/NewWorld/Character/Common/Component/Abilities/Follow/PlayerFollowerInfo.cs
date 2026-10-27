using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007138 RID: 28984
	public class PlayerFollowerInfo
	{
		// Token: 0x06046C53 RID: 289875 RVA: 0x011D602B File Offset: 0x011D422B
		public PlayerFollowerInfo(long creatureDataId, int? priority = 0)
		{
		}

		// Token: 0x06046C54 RID: 289876 RVA: 0x011D6047 File Offset: 0x011D4247
		[NullableContext(1)]
		public static int Compare(PlayerFollowerInfo a, PlayerFollowerInfo b)
		{
			return a.Priority - b.Priority;
		}

		// Token: 0x04025276 RID: 152182
		public long CreatureDataId = creatureDataId;

		// Token: 0x04025277 RID: 152183
		public int Priority = priority.GetValueOrDefault();
	}
}
