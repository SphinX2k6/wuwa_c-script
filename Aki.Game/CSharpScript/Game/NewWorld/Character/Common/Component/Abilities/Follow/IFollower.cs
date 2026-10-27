using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007134 RID: 28980
	[NullableContext(1)]
	public interface IFollower
	{
		// Token: 0x06046C4B RID: 289867
		void Possessed();

		// Token: 0x06046C4C RID: 289868
		void UnPossessed();

		// Token: 0x06046C4D RID: 289869
		bool SetEnable(bool enable, BPEEnableFollowShooter enableType, string reason);

		// Token: 0x06046C4E RID: 289870
		bool GetEnable();
	}
}
