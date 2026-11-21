using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200636C RID: 25452
	[NullableContext(1)]
	public interface IPlayerFollowerHandlerFactory<[Nullable(0)] out T> where T : IPlayerFollowerHandler
	{
		// Token: 0x0603DAC0 RID: 252608
		T Create(int playerId);
	}
}
