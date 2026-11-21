using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sharphereal.Core
{
	// Token: 0x02000005 RID: 5
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class StaticVariableRegistry
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		public static int Count
		{
			get
			{
				return StaticVariableRegistry.Initializers.Count;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002072 File Offset: 0x00000272
		public static void RegisterAndExecute(Action initAction, Action resetAction)
		{
			initAction();
			StaticVariableRegistry.Initializers.Add(initAction);
			StaticVariableRegistry.Resetters.Add(resetAction);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002090 File Offset: 0x00000290
		public static void CreateRequiredStaticDefaultValue()
		{
			foreach (Action action in StaticVariableRegistry.Initializers)
			{
				action();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020E0 File Offset: 0x000002E0
		public static void ResetRequiredStaticDefaultValue()
		{
			foreach (Action action in StaticVariableRegistry.Resetters)
			{
				action();
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly List<Action> Initializers = new List<Action>();

		// Token: 0x04000002 RID: 2
		private static readonly List<Action> Resetters = new List<Action>();
	}
}
