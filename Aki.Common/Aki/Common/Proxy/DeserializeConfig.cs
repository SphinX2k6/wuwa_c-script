using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000020 RID: 32
	[NullableContext(1)]
	[Nullable(0)]
	public class DeserializeConfig
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000B3C3 File Offset: 0x000095C3
		public static IDeserializeConfigProxy Instance
		{
			get
			{
				return DeserializeConfig._instance;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000B3CA File Offset: 0x000095CA
		[NullableContext(2)]
		public static void SetInstance(IDeserializeConfigProxy instance)
		{
			DeserializeConfig._instance = instance;
		}

		// Token: 0x04000234 RID: 564
		[Nullable(2)]
		private static IDeserializeConfigProxy _instance;
	}
}
