using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02005AA1 RID: 23201
	public class ModelManager : ModelManagerBase
	{
		// Token: 0x0401E181 RID: 123265
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ModelManager Instance = new ModelManager();

		// Token: 0x0401E182 RID: 123266
		public bool IsInit = true;
	}
}
