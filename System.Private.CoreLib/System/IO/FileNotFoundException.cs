using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x020007F5 RID: 2037
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class FileNotFoundException : IOException
	{
		// Token: 0x0600826C RID: 33388 RVA: 0x0013687B File Offset: 0x00134A7B
		public FileNotFoundException() : base(SR.IO_FileNotFound)
		{
			base.HResult = -2147024894;
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x00136893 File Offset: 0x00134A93
		public FileNotFoundException(string message) : base(message)
		{
			base.HResult = -2147024894;
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x001368A7 File Offset: 0x00134AA7
		public FileNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024894;
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x001368BC File Offset: 0x00134ABC
		public FileNotFoundException(string message, string fileName) : base(message)
		{
			base.HResult = -2147024894;
			this.FileName = fileName;
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x001368D7 File Offset: 0x00134AD7
		public FileNotFoundException(string message, string fileName, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024894;
			this.FileName = fileName;
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06008271 RID: 33393 RVA: 0x001368F3 File Offset: 0x00134AF3
		[Nullable(1)]
		public override string Message
		{
			[NullableContext(1)]
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x00136904 File Offset: 0x00134B04
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this.FileName == null && base.HResult == -2146233088)
				{
					this._message = SR.IO_FileNotFound;
					return;
				}
				if (this.FileName != null)
				{
					this._message = FileLoadException.FormatFileLoadExceptionMessage(this.FileName, base.HResult);
				}
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06008273 RID: 33395 RVA: 0x00136959 File Offset: 0x00134B59
		public string FileName { get; }

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06008274 RID: 33396 RVA: 0x00136961 File Offset: 0x00134B61
		public string FusionLog { get; }

		// Token: 0x06008275 RID: 33397 RVA: 0x0013696C File Offset: 0x00134B6C
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

		// Token: 0x06008276 RID: 33398 RVA: 0x00136A1B File Offset: 0x00134C1B
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected FileNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileName = info.GetString("FileNotFound_FileName");
			this.FusionLog = info.GetString("FileNotFound_FusionLog");
		}

		// Token: 0x06008277 RID: 33399 RVA: 0x00136A47 File Offset: 0x00134C47
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("FileNotFound_FileName", this.FileName, typeof(string));
			info.AddValue("FileNotFound_FusionLog", this.FusionLog, typeof(string));
		}
	}
}
