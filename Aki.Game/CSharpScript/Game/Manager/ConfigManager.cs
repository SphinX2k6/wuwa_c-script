using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.Manager
{
	// Token: 0x0200693F RID: 26943
	public class ConfigManager : ConfigManagerBase
	{
		// Token: 0x04022F60 RID: 143200
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ConfigManager Instance = new ConfigManager();
	}
}
