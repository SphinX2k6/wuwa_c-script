using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006369 RID: 25449
	[NullableContext(1)]
	public interface IPlayerFollowerFollowShooterHandler : IPlayerFollowerHandler
	{
		// Token: 0x0603DAAC RID: 252588
		bool SetFollowShooterEnable(bool enable, BPEEnableFollowShooter enableType, string reason);

		// Token: 0x0603DAAD RID: 252589
		[NullableContext(2)]
		EntityHandle GetFollowShooter();

		// Token: 0x0603DAAE RID: 252590
		bool IsFollowShooterEnable();

		// Token: 0x0603DAAF RID: 252591
		void AddFollowShooterCustomEntityId(string customKey, int entityId);

		// Token: 0x0603DAB0 RID: 252592
		int? GetFollowShooterCustomEntityId(string customKey);

		// Token: 0x0603DAB1 RID: 252593
		bool RemoveFollowShooterCustomEntityId(string customKey);
	}
}
