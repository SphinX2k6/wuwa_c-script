using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000023 RID: 35
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageSystem
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000EBA6 File Offset: 0x0000CDA6
		public static ILanguageSystemProxy Instance
		{
			get
			{
				return LanguageSystem._instance;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000EBAD File Offset: 0x0000CDAD
		[NullableContext(2)]
		public static void SetInstance(ILanguageSystemProxy instance)
		{
			LanguageSystem._instance = instance;
		}

		// Token: 0x0400023A RID: 570
		[Nullable(2)]
		private static ILanguageSystemProxy _instance;
	}
}
