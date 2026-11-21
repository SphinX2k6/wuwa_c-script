using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x02000217 RID: 535
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class DecoderFallbackException : ArgumentException
	{
		// Token: 0x0600296A RID: 10602 RVA: 0x00081714 File Offset: 0x0007F914
		public DecoderFallbackException() : base(SR.Arg_ArgumentException)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x0008172C File Offset: 0x0007F92C
		public DecoderFallbackException(string message) : base(message)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00081740 File Offset: 0x0007F940
		public DecoderFallbackException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00081755 File Offset: 0x0007F955
		public DecoderFallbackException(string message, byte[] bytesUnknown, int index) : base(message)
		{
			this._bytesUnknown = bytesUnknown;
			this._index = index;
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0001E5B9 File Offset: 0x0001C7B9
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x0008176C File Offset: 0x0007F96C
		public byte[] BytesUnknown
		{
			get
			{
				return this._bytesUnknown;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x00081774 File Offset: 0x0007F974
		public int Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x04000738 RID: 1848
		private readonly byte[] _bytesUnknown;

		// Token: 0x04000739 RID: 1849
		private readonly int _index;
	}
}
