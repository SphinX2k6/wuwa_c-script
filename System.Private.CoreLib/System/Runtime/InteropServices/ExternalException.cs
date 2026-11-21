using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005CE RID: 1486
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ExternalException : SystemException
	{
		// Token: 0x0600701E RID: 28702 RVA: 0x0010DA8F File Offset: 0x0010BC8F
		public ExternalException() : base(SR.Arg_ExternalException)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x0010DAA7 File Offset: 0x0010BCA7
		public ExternalException(string message) : base(message ?? SR.Arg_ExternalException)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x0010DAC4 File Offset: 0x0010BCC4
		public ExternalException(string message, Exception inner) : base(message ?? SR.Arg_ExternalException, inner)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x0010DAE2 File Offset: 0x0010BCE2
		public ExternalException(string message, int errorCode) : base(message ?? SR.Arg_ExternalException)
		{
			base.HResult = errorCode;
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ExternalException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06007023 RID: 28707 RVA: 0x0010DAFB File Offset: 0x0010BCFB
		public virtual int ErrorCode
		{
			get
			{
				return base.HResult;
			}
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x0010DB04 File Offset: 0x0010BD04
		[NullableContext(1)]
		public override string ToString()
		{
			string message = this.Message;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(base.GetType());
			defaultInterpolatedStringHandler.AppendLiteral(" (0x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(base.HResult, "X8");
			defaultInterpolatedStringHandler.AppendLiteral(")");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!string.IsNullOrEmpty(message))
			{
				text = text + ": " + message;
			}
			Exception innerException = base.InnerException;
			if (innerException != null)
			{
				text = text + "\r\n ---> " + innerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + "\r\n" + this.StackTrace;
			}
			return text;
		}
	}
}
