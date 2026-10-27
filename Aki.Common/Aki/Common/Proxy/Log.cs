using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000024 RID: 36
	[NullableContext(1)]
	[Nullable(0)]
	public class Log
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000B3FE File Offset: 0x000095FE
		public static ILog Instance
		{
			get
			{
				return Log._instance;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000B405 File Offset: 0x00009605
		[NullableContext(2)]
		public static void SetInstance(ILog instance)
		{
			Log._instance = instance;
		}

		// Token: 0x04000236 RID: 566
		[Nullable(2)]
		private static ILog _instance;
	}
}
