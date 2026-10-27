using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02006946 RID: 26950
	public class ModelManager : ModelManagerBase
	{
		// Token: 0x04022F97 RID: 143255
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ModelManager Instance = new ModelManager();

		// Token: 0x04022F98 RID: 143256
		public bool IsInit = true;
	}
}
