using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000022 RID: 34
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageSystem
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000B3DA File Offset: 0x000095DA
		public static ILanguageSystemProxy Instance
		{
			get
			{
				return LanguageSystem._instance;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000B3E1 File Offset: 0x000095E1
		[NullableContext(2)]
		public static void SetInstance(ILanguageSystemProxy instance)
		{
			LanguageSystem._instance = instance;
		}

		// Token: 0x04000235 RID: 565
		[Nullable(2)]
		private static ILanguageSystemProxy _instance;
	}
}
