using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063D4 RID: 25556
	public class FlowBoolOptionConfig
	{
		// Token: 0x04020E45 RID: 134725
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, string> Config = new Dictionary<string, string>
		{
			{
				"DisableInput",
				"是否禁止输入"
			},
			{
				"DisableViewControl",
				"是否禁止视角控制"
			},
			{
				"HideUi",
				"是否隐藏其它UI"
			},
			{
				"CanSkip",
				"是否可以跳过"
			},
			{
				"CanInteractive",
				"是否可以交互"
			}
		};
	}
}
