using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007257 RID: 29271
	public class CameraModeConfig
	{
		// Token: 0x04025B88 RID: 154504
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, string> Config = new Dictionary<string, string>
		{
			{
				"Drama",
				"剧情相机"
			},
			{
				"Follow",
				"跟随"
			},
			{
				"FollowDrama",
				"跟随相机剧情模式"
			}
		};
	}
}
