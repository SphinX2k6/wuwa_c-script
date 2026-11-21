using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000216 RID: 534
	public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x06002964 RID: 10596 RVA: 0x00081665 File Offset: 0x0007F865
		[NullableContext(1)]
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			DecoderExceptionFallbackBuffer.Throw(bytesUnknown, index);
			return true;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00007B65 File Offset: 0x00005D65
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool MovePrevious()
		{
			return false;
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x00007B65 File Offset: 0x00005D65
		public override int Remaining
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00081670 File Offset: 0x0007F870
		[DoesNotReturn]
		private static void Throw(byte[] bytesUnknown, int index)
		{
			if (bytesUnknown == null)
			{
				bytesUnknown = Array.Empty<byte>();
			}
			StringBuilder stringBuilder = new StringBuilder(bytesUnknown.Length * 4);
			int num = 0;
			while (num < bytesUnknown.Length && num < 20)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("[");
				appendInterpolatedStringHandler.AppendFormatted<byte>(bytesUnknown[num], "X2");
				appendInterpolatedStringHandler.AppendLiteral("]");
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
				num++;
			}
			if (bytesUnknown.Length > 20)
			{
				stringBuilder.Append(" ...");
			}
			throw new DecoderFallbackException(SR.Format(SR.Argument_InvalidCodePageBytesIndex, stringBuilder, index), bytesUnknown, index);
		}
	}
}
