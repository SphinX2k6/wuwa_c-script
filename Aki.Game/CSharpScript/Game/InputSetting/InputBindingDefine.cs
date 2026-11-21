using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006168 RID: 24936
	public static class InputBindingDefine
	{
		// Token: 0x0401F868 RID: 129128
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly EInputBindingType[] inputBindingTypesArray = new EInputBindingType[]
		{
			EInputBindingType.Original,
			EInputBindingType.Motor
		};
	}
}
