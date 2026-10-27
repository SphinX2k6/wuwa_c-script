using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200695D RID: 26973
	public class LevelGameplayActionsDefine
	{
		// Token: 0x06043306 RID: 275206 RVA: 0x01062023 File Offset: 0x01060223
		// Note: this type is marked as 'beforefieldinit'.
		static LevelGameplayActionsDefine()
		{
			Dictionary<EOptionType, string> dictionary = new Dictionary<EOptionType, string>();
			dictionary[EOptionType.Normal] = "基础交互";
			dictionary[EOptionType.Dynamic] = "动态交互";
			dictionary[EOptionType.Random] = "随机交互";
			LevelGameplayActionsDefine.optionTypeLogString = dictionary;
		}

		// Token: 0x04022FD1 RID: 143313
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EOptionType, string> optionTypeLogString;
	}
}
