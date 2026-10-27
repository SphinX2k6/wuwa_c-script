using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FE7 RID: 28647
	public static class InputBindingDefine
	{
		// Token: 0x040245B3 RID: 148915
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly EInputBindingType[] inputBindingTypesArray = new EInputBindingType[]
		{
			EInputBindingType.Original,
			EInputBindingType.Motor
		};
	}
}
