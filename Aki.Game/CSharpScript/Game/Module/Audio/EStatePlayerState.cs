using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E6F RID: 20079
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EStatePlayerState
	{
		// Token: 0x0401ACCD RID: 109773
		public const string StateGroupName = "battle_music_state";

		// Token: 0x0401ACCE RID: 109774
		public const string NotContactEnemy = "none";

		// Token: 0x0401ACCF RID: 109775
		public const string InBattleNotDamageEnemy = "battle_in";

		// Token: 0x0401ACD0 RID: 109776
		public const string InBattleDamagedEnemy = "battle_strong";
	}
}
