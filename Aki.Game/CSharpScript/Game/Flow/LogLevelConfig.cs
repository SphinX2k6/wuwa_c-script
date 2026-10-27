using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007248 RID: 29256
	public class LogLevelConfig
	{
		// Token: 0x04025B86 RID: 154502
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
