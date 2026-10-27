using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007135 RID: 28981
	[NullableContext(2)]
	public interface IFollowable
	{
		// Token: 0x06046C4F RID: 289871
		EntityHandle GetFollower();

		// Token: 0x06046C50 RID: 289872
		bool IsFollowerEnable();
	}
}
