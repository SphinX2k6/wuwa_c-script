using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000218 RID: 536
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DecoderFallback
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x0008177C File Offset: 0x0007F97C
		public static DecoderFallback ReplacementFallback
		{
			get
			{
				return DecoderReplacementFallback.s_default;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x00081783 File Offset: 0x0007F983
		public static DecoderFallback ExceptionFallback
		{
			get
			{
				return DecoderExceptionFallback.s_default;
			}
		}

		// Token: 0x06002973 RID: 10611
		public abstract DecoderFallbackBuffer CreateFallbackBuffer();

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002974 RID: 10612
		public abstract int MaxCharCount { get; }
	}
}
