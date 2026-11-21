using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.ComponentModel
{
	// Token: 0x0200032C RID: 812
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Win32Exception : ExternalException
	{
		// Token: 0x06003A26 RID: 14886 RVA: 0x000C1475 File Offset: 0x000BF675
		public Win32Exception() : this(Marshal.GetLastPInvokeError())
		{
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x000C1482 File Offset: 0x000BF682
		public Win32Exception(int error) : this(error, Marshal.GetPInvokeErrorMessage(error))
		{
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x000C1491 File Offset: 0x000BF691
		[NullableContext(2)]
		public Win32Exception(int error, string message) : base(message)
		{
			this.NativeErrorCode = error;
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x000C14A1 File Offset: 0x000BF6A1
		[NullableContext(2)]
		public Win32Exception(string message) : this(Marshal.GetLastPInvokeError(), message)
		{
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x000C14AF File Offset: 0x000BF6AF
		[NullableContext(2)]
		public Win32Exception(string message, Exception innerException) : base(message, innerException)
		{
			this.NativeErrorCode = Marshal.GetLastPInvokeError();
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x000C14C4 File Offset: 0x000BF6C4
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Win32Exception(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.NativeErrorCode = info.GetInt32("NativeErrorCode");
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x000C14DF File Offset: 0x000BF6DF
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("NativeErrorCode", this.NativeErrorCode);
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x000C14FA File Offset: 0x000BF6FA
		public int NativeErrorCode { get; }

		// Token: 0x06003A2E RID: 14894 RVA: 0x000C1504 File Offset: 0x000BF704
		public override string ToString()
		{
			if (this.NativeErrorCode == 0 || this.NativeErrorCode == base.HResult)
			{
				return base.ToString();
			}
			string message = this.Message;
			StringBuilder stringBuilder = new StringBuilder(base.GetType().ToString());
			string text;
			if (this.NativeErrorCode >= 0)
			{
				text = this.NativeErrorCode.ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NativeErrorCode, "X8");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string value = text;
			if (base.HResult == -2147467259)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(3, 1, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral(" (");
				appendInterpolatedStringHandler.AppendFormatted(value);
				appendInterpolatedStringHandler.AppendLiteral(")");
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
			}
			else
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral(" (");
				appendInterpolatedStringHandler.AppendFormatted<int>(base.HResult, "X8");
				appendInterpolatedStringHandler.AppendLiteral(", ");
				appendInterpolatedStringHandler.AppendFormatted(value);
				appendInterpolatedStringHandler.AppendLiteral(")");
				stringBuilder4.Append(ref appendInterpolatedStringHandler);
			}
			if (!string.IsNullOrEmpty(message))
			{
				stringBuilder.Append(": ");
				stringBuilder.Append(message);
			}
			Exception innerException = base.InnerException;
			if (innerException != null)
			{
				stringBuilder.Append(" ---> ");
				stringBuilder.Append(innerException.ToString());
			}
			string stackTrace = this.StackTrace;
			if (stackTrace != null)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append(stackTrace);
			}
			return stringBuilder.ToString();
		}
	}
}
