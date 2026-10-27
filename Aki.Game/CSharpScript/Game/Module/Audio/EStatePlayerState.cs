using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E8A RID: 24202
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EStatePlayerState
	{
		// Token: 0x04020206 RID: 131590
		public const string StateGroupName = "battle_music_state";

		// Token: 0x04020207 RID: 131591
		public const string NotContactEnemy = "none";

		// Token: 0x04020208 RID: 131592
		public const string InBattleNotDamageEnemy = "battle_in";

		// Token: 0x04020209 RID: 131593
		public const string InBattleDamagedEnemy = "battle_strong";
	}
}
