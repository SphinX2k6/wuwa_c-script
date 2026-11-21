using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	public class DeserializeConfig
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000EB8F File Offset: 0x0000CD8F
		public static IDeserializeConfigProxy Instance
		{
			get
			{
				return DeserializeConfig._instance;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000EB96 File Offset: 0x0000CD96
		[NullableContext(2)]
		public static void SetInstance(IDeserializeConfigProxy instance)
		{
			DeserializeConfig._instance = instance;
		}

		// Token: 0x04000239 RID: 569
		[Nullable(2)]
		private static IDeserializeConfigProxy _instance;
	}
}
