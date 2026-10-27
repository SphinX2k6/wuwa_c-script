using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200713B RID: 28987
	[NullableContext(1)]
	public interface IPlayerFollowerFollowShooterHandler : IPlayerFollowerHandler
	{
		// Token: 0x06046C5B RID: 289883
		bool SetFollowShooterEnable(bool enable, BPEEnableFollowShooter enableType, string reason);

		// Token: 0x06046C5C RID: 289884
		[NullableContext(2)]
		EntityHandle GetFollowShooter();

		// Token: 0x06046C5D RID: 289885
		bool IsFollowShooterEnable();

		// Token: 0x06046C5E RID: 289886
		void AddFollowShooterCustomEntityId(string customKey, int entityId);

		// Token: 0x06046C5F RID: 289887
		int? GetFollowShooterCustomEntityId(string customKey);

		// Token: 0x06046C60 RID: 289888
		bool RemoveFollowShooterCustomEntityId(string customKey);
	}
}
