using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063C7 RID: 25543
	public class LogLevelConfig
	{
		// Token: 0x04020E44 RID: 134724
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, string> Config = new Dictionary<string, string>
		{
			{
				"Info",
				"提示"
			},
			{
				"Warn",
				"警告"
			},
			{
				"Error",
				"错误"
			}
		};
	}
}
