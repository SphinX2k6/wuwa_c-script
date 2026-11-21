using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006362 RID: 25442
	[NullableContext(1)]
	public interface IFollower
	{
		// Token: 0x0603DA9C RID: 252572
		void Possessed();

		// Token: 0x0603DA9D RID: 252573
		void UnPossessed();

		// Token: 0x0603DA9E RID: 252574
		bool SetEnable(bool enable, BPEEnableFollowShooter enableType, string reason);

		// Token: 0x0603DA9F RID: 252575
		bool GetEnable();
	}
}
