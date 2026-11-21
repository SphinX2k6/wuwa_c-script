using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x02000220 RID: 544
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		// Token: 0x060029C5 RID: 10693 RVA: 0x00081714 File Offset: 0x0007F914
		public EncoderFallbackException() : base(SR.Arg_ArgumentException)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0008172C File Offset: 0x0007F92C
		public EncoderFallbackException(string message) : base(message)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00081740 File Offset: 0x0007F940
		public EncoderFallbackException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000827A1 File Offset: 0x000809A1
		internal EncoderFallbackException(string message, char charUnknown, int index) : base(message)
		{
			this._charUnknown = charUnknown;
			this._index = index;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000827B8 File Offset: 0x000809B8
		internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index) : base(message)
		{
			if (!char.IsHighSurrogate(charUnknownHigh))
			{
				throw new ArgumentOutOfRangeException("charUnknownHigh", SR.Format(SR.ArgumentOutOfRange_Range, 55296, 56319));
			}
			if (!char.IsLowSurrogate(charUnknownLow))
			{
				throw new ArgumentOutOfRangeException("CharUnknownLow", SR.Format(SR.ArgumentOutOfRange_Range, 56320, 57343));
			}
			this._charUnknownHigh = charUnknownHigh;
			this._charUnknownLow = charUnknownLow;
			this._index = index;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0001E5B9 File Offset: 0x0001C7B9
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x00082844 File Offset: 0x00080A44
		public char CharUnknown
		{
			get
			{
				return this._charUnknown;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x0008284C File Offset: 0x00080A4C
		public char CharUnknownHigh
		{
			get
			{
				return this._charUnknownHigh;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x00082854 File Offset: 0x00080A54
		public char CharUnknownLow
		{
			get
			{
				return this._charUnknownLow;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x0008285C File Offset: 0x00080A5C
		public int Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00082864 File Offset: 0x00080A64
		public bool IsUnknownSurrogate()
		{
			return this._charUnknownHigh > '\0';
		}

		// Token: 0x0400074D RID: 1869
		private readonly char _charUnknown;

		// Token: 0x0400074E RID: 1870
		private readonly char _charUnknownHigh;

		// Token: 0x0400074F RID: 1871
		private readonly char _charUnknownLow;

		// Token: 0x04000750 RID: 1872
		private readonly int _index;
	}
}
