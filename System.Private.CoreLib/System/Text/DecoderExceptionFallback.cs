using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000215 RID: 533
	public sealed class DecoderExceptionFallback : DecoderFallback
	{
		// Token: 0x0600295E RID: 10590 RVA: 0x00081638 File Offset: 0x0007F838
		[NullableContext(1)]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return new DecoderExceptionFallbackBuffer();
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x00007B65 File Offset: 0x00005D65
		public override int MaxCharCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0008163F File Offset: 0x0007F83F
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			return value is DecoderExceptionFallback;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0008164A File Offset: 0x0007F84A
		public override int GetHashCode()
		{
			return 879;
		}

		// Token: 0x04000737 RID: 1847
		internal static readonly DecoderExceptionFallback s_default = new DecoderExceptionFallback();
	}
}
