using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x0200021E RID: 542
	public sealed class EncoderExceptionFallback : EncoderFallback
	{
		// Token: 0x060029BA RID: 10682 RVA: 0x000826C0 File Offset: 0x000808C0
		[NullableContext(1)]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new EncoderExceptionFallbackBuffer();
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x00007B65 File Offset: 0x00005D65
		public override int MaxCharCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000826C7 File Offset: 0x000808C7
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			return value is EncoderExceptionFallback;
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000826D2 File Offset: 0x000808D2
		public override int GetHashCode()
		{
			return 654;
		}

		// Token: 0x0400074C RID: 1868
		internal static readonly EncoderExceptionFallback s_default = new EncoderExceptionFallback();
	}
}
