using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000025 RID: 37
	[NullableContext(1)]
	[Nullable(0)]
	public class Log
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000EBCA File Offset: 0x0000CDCA
		public static ILog Instance
		{
			get
			{
				return Log._instance;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000EBD1 File Offset: 0x0000CDD1
		[NullableContext(2)]
		public static void SetInstance(ILog instance)
		{
			Log._instance = instance;
		}

		// Token: 0x0400023B RID: 571
		[Nullable(2)]
		private static ILog _instance;
	}
}
