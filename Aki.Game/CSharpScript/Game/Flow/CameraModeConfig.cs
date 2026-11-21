using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063D6 RID: 25558
	public class CameraModeConfig
	{
		// Token: 0x04020E46 RID: 134726
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
