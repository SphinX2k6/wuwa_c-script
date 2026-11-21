using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000DD RID: 221
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class BadImageFormatException : SystemException
	{
		// Token: 0x06000A54 RID: 2644 RVA: 0x0001F094 File Offset: 0x0001D294
		public BadImageFormatException() : base(SR.Arg_BadImageFormatException)
		{
			base.HResult = -2147024885;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0001F0AC File Offset: 0x0001D2AC
		public BadImageFormatException(string message) : base(message)
		{
			base.HResult = -2147024885;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
		public BadImageFormatException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147024885;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001F0D5 File Offset: 0x0001D2D5
		public BadImageFormatException(string message, string fileName) : base(message)
		{
			base.HResult = -2147024885;
			this._fileName = fileName;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0001F0F0 File Offset: 0x0001D2F0
		public BadImageFormatException(string message, string fileName, Exception inner) : base(message, inner)
		{
			base.HResult = -2147024885;
			this._fileName = fileName;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001F10C File Offset: 0x0001D30C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected BadImageFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._fileName = info.GetString("BadImageFormat_FileName");
			this._fusionLog = info.GetString("BadImageFormat_FusionLog");
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001F138 File Offset: 0x0001D338
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("BadImageFormat_FileName", this._fileName, typeof(string));
			info.AddValue("BadImageFormat_FusionLog", this._fusionLog, typeof(string));
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0001F178 File Offset: 0x0001D378
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

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001F188 File Offset: 0x0001D388
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this._fileName == null && base.HResult == -2146233088)
				{
					this._message = SR.Arg_BadImageFormatException;
					return;
				}
				this._message = FileLoadException.FormatFileLoadExceptionMessage(this._fileName, base.HResult);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0001F1D5 File Offset: 0x0001D3D5
		public string FileName
		{
			get
			{
				return this._fileName;
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
		[NullableContext(1)]
		public override string ToString()
		{
			string text = base.GetType().ToString() + ": " + this.Message;
			if (!string.IsNullOrEmpty(this._fileName))
			{
				text = text + "\r\n" + SR.Format(SR.IO_FileName_Name, this._fileName);
			}
			if (base.InnerException != null)
			{
				text = text + " ---> " + base.InnerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + "\r\n" + this.StackTrace;
			}
			if (this._fusionLog != null)
			{
				if (text == null)
				{
					text = " ";
				}
				text = text + "\r\n\r\n" + this._fusionLog;
			}
			return text;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0001F28F File Offset: 0x0001D48F
		public string FusionLog
		{
			get
			{
				return this._fusionLog;
			}
		}

		// Token: 0x040002FD RID: 765
		private readonly string _fileName;

		// Token: 0x040002FE RID: 766
		private readonly string _fusionLog;
	}
}
