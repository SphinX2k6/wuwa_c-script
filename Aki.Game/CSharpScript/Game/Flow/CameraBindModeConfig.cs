using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063DD RID: 25565
	public class CameraBindModeConfig
	{
		// Token: 0x04020E48 RID: 134728
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, string> Config = new Dictionary<string, string>
		{
			{
				"One",
				"1角色"
			},
			{
				"Two",
				"2角色"
			},
			{
				"Three",
				"3角色"
			},
			{
				"None",
				"无"
			}
		};
	}
}
