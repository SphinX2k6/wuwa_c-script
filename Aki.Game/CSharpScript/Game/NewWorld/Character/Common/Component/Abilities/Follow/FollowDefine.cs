using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006365 RID: 25445
	public class FollowDefine
	{
		// Token: 0x04020B53 RID: 133971
		public const int PRIORITY_VEHICLE = 103;

		// Token: 0x04020B54 RID: 133972
		public const int WAIT_FOLLOWER_TIME = 90000;

		// Token: 0x04020B55 RID: 133973
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
