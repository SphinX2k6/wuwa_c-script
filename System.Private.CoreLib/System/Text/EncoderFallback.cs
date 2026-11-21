using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000221 RID: 545
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class EncoderFallback
	{
		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x0008286F File Offset: 0x00080A6F
		public static EncoderFallback ReplacementFallback
		{
			get
			{
				return EncoderReplacementFallback.s_default;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x00082876 File Offset: 0x00080A76
		public static EncoderFallback ExceptionFallback
		{
			get
			{
				return EncoderExceptionFallback.s_default;
			}
		}

		// Token: 0x060029D2 RID: 10706
		public abstract EncoderFallbackBuffer CreateFallbackBuffer();

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060029D3 RID: 10707
		public abstract int MaxCharCount { get; }
	}
}
