using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006363 RID: 25443
	[NullableContext(2)]
	public interface IFollowable
	{
		// Token: 0x0603DAA0 RID: 252576
		EntityHandle GetFollower();

		// Token: 0x0603DAA1 RID: 252577
		bool IsFollowerEnable();
	}
}
