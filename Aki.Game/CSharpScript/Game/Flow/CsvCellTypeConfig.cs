using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063DE RID: 25566
	public class CsvCellTypeConfig
	{
		// Token: 0x04020E49 RID: 134729
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, string> Config = new Dictionary<string, string>
		{
			{
				"Int",
				"整形"
			},
			{
				"String",
				"字符串"
			},
			{
				"Float",
				"浮点型"
			},
			{
				"Boolean",
				"布尔型"
			}
		};
	}
}
