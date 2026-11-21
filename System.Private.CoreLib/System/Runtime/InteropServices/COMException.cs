using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005B6 RID: 1462
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class COMException : ExternalException
	{
		// Token: 0x06006FDC RID: 28636 RVA: 0x0010D5CF File Offset: 0x0010B7CF
		public COMException() : base(SR.Arg_COMException)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x0010D5E7 File Offset: 0x0010B7E7
		public COMException(string message) : base(message ?? SR.Arg_COMException)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x0010D604 File Offset: 0x0010B804
		public COMException(string message, Exception inner) : base(message ?? SR.Arg_COMException, inner)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x0010D622 File Offset: 0x0010B822
		public COMException(string message, int errorCode) : base(message ?? SR.Arg_COMException)
		{
			base.HResult = errorCode;
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x0010D63B File Offset: 0x0010B83B
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected COMException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x0010D648 File Offset: 0x0010B848
		[NullableContext(1)]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
			appendInterpolatedStringHandler.AppendFormatted<Type>(base.GetType());
			appendInterpolatedStringHandler.AppendLiteral(" (0x");
			appendInterpolatedStringHandler.AppendFormatted<int>(base.HResult, "X8");
			appendInterpolatedStringHandler.AppendLiteral(")");
			stringBuilder3.Append(ref appendInterpolatedStringHandler);
			string message = this.Message;
			if (!string.IsNullOrEmpty(message))
			{
				stringBuilder.Append(": ").Append(message);
			}
			Exception innerException = base.InnerException;
			if (innerException != null)
			{
				stringBuilder.Append("\r\n ---> ").Append(innerException.ToString());
			}
			string stackTrace = this.StackTrace;
			if (stackTrace != null)
			{
				stringBuilder.AppendLine().Append(stackTrace);
			}
			return stringBuilder.ToString();
		}
	}
}
