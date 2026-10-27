using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000026 RID: 38
	public class Stat
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000B415 File Offset: 0x00009615
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

		// Token: 0x04000237 RID: 567
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
