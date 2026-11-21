using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x020007D7 RID: 2007
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class FileLoadException : IOException
	{
		// Token: 0x060080A2 RID: 32930 RVA: 0x0012FE71 File Offset: 0x0012E071
		internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			return "";
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x0012FE78 File Offset: 0x0012E078
		public FileLoadException() : base(SR.IO_FileLoad)
		{
			base.HResult = -2146232799;
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x0012FE90 File Offset: 0x0012E090
		public FileLoadException(string message) : base(message)
		{
			base.HResult = -2146232799;
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x0012FEA4 File Offset: 0x0012E0A4
		public FileLoadException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232799;
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x0012FEB9 File Offset: 0x0012E0B9
		public FileLoadException(string message, string fileName) : base(message)
		{
			base.HResult = -2146232799;
			this.FileName = fileName;
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x0012FED4 File Offset: 0x0012E0D4
		public FileLoadException(string message, string fileName, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232799;
			this.FileName = fileName;
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x0012FEF0 File Offset: 0x0012E0F0
		[Nullable(1)]
		public override string Message
		{
			[NullableContext(1)]
			get
			{
				string result;
				if ((result = this._message) == null)
				{
					result = (this._message = FileLoadException.FormatFileLoadExceptionMessage(this.FileName, base.HResult));
				}
				return result;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060080A9 RID: 32937 RVA: 0x0012FF21 File Offset: 0x0012E121
		public string FileName { get; }

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x060080AA RID: 32938 RVA: 0x0012FF29 File Offset: 0x0012E129
		public string FusionLog { get; }

		// Token: 0x060080AB RID: 32939 RVA: 0x0012FF34 File Offset: 0x0012E134
		[NullableContext(1)]
		public override string ToString()
		{
			string text = base.GetType().ToString() + ": " + this.Message;
			if (!string.IsNullOrEmpty(this.FileName))
			{
				text = text + "\r\n" + SR.Format(SR.IO_FileName_Name, this.FileName);
			}
			if (base.InnerException != null)
			{
				text = text + "\r\n ---> " + base.InnerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + "\r\n" + this.StackTrace;
			}
			if (this.FusionLog != null)
			{
				if (text == null)
				{
					text = " ";
				}
				text = text + "\r\n\r\n" + this.FusionLog;
			}
			return text;
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x0012FFE3 File Offset: 0x0012E1E3
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected FileLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileName = info.GetString("FileLoad_FileName");
			this.FusionLog = info.GetString("FileLoad_FusionLog");
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x0013000F File Offset: 0x0012E20F
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("FileLoad_FileName", this.FileName, typeof(string));
			info.AddValue("FileLoad_FusionLog", this.FusionLog, typeof(string));
		}
	}
}
