using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02005A9A RID: 23194
	public class ConfigManager : ConfigManagerBase
	{
		// Token: 0x0401E14A RID: 123210
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ConfigManager Instance = new ConfigManager();
	}
}
