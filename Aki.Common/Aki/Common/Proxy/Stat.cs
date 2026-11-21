using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000027 RID: 39
	public class Stat
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0000EBE1 File Offset: 0x0000CDE1
		[NullableContext(1)]
		public static IStat CreateNoFlameGraph(string name, string desc = "", string group = "")
		{
			Func<string, string, string, IStat> createNoFlameGraphFunc = Stat.CreateNoFlameGraphFunc;
			if (createNoFlameGraphFunc == null)
			{
				return null;
			}
			return createNoFlameGraphFunc(name, desc, group);
		}

		// Token: 0x0400023C RID: 572
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1
		})]
		public static Func<string, string, string, IStat> CreateNoFlameGraphFunc;
	}
}
