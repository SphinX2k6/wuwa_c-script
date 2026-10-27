using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200713E RID: 28990
	[NullableContext(1)]
	public interface IPlayerFollowerHandlerFactory<[Nullable(0)] out T> where T : IPlayerFollowerHandler
	{
		// Token: 0x06046C6F RID: 289903
		T Create(int playerId);
	}
}
