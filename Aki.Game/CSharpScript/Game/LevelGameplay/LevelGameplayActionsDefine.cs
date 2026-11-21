using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AB8 RID: 23224
	public class LevelGameplayActionsDefine
	{
		// Token: 0x0603933D RID: 234301 RVA: 0x01006283 File Offset: 0x01004483
		// Note: this type is marked as 'beforefieldinit'.
		static LevelGameplayActionsDefine()
		{
			Dictionary<EOptionType, string> dictionary = new Dictionary<EOptionType, string>();
			dictionary[EOptionType.Normal] = "基础交互";
			dictionary[EOptionType.Dynamic] = "动态交互";
			dictionary[EOptionType.Random] = "随机交互";
			LevelGameplayActionsDefine.optionTypeLogString = dictionary;
		}

		// Token: 0x0401E1BB RID: 123323
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EOptionType, string> optionTypeLogString;
	}
}
