using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007137 RID: 28983
	public class FollowDefine
	{
		// Token: 0x04025273 RID: 152179
		public const int PRIORITY_VEHICLE = 103;

		// Token: 0x04025274 RID: 152180
		public const int WAIT_FOLLOWER_TIME = 90000;

		// Token: 0x04025275 RID: 152181
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, int> PlayerFollowerPriority = new Dictionary<int, int>
		{
			{
				1,
				100
			},
			{
				2,
				98
			},
			{
				3,
				99
			},
			{
				666,
				97
			},
			{
				4,
				99999
			}
		};
	}
}
