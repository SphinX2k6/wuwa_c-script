using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000A6 RID: 166
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TypeLoadException : SystemException
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x0001BDDC File Offset: 0x00019FDC
		internal TypeLoadException(string className, string assemblyName) : this(null)
		{
			this._className = className;
			this._assemblyName = assemblyName;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0001BDF4 File Offset: 0x00019FF4
		private void SetMessageField()
		{
			if (this._message != null)
			{
				return;
			}
			if (this._className == null)
			{
				this._message = SR.Arg_TypeLoadException;
				return;
			}
			this._message = SR.Format(SR.ClassLoad_General, this._className, this._assemblyName ?? SR.IO_UnknownFileName);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0001BE43 File Offset: 0x0001A043
		public TypeLoadException() : base(SR.Arg_TypeLoadException)
		{
			base.HResult = -2146233054;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0001BE5B File Offset: 0x0001A05B
		[NullableContext(2)]
		public TypeLoadException(string message) : base(message)
		{
			base.HResult = -2146233054;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0001BE6F File Offset: 0x0001A06F
		[NullableContext(2)]
		public TypeLoadException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233054;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0001BE84 File Offset: 0x0001A084
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0001BE92 File Offset: 0x0001A092
		public string TypeName
		{
			get
			{
				return this._className ?? string.Empty;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TypeLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._className = info.GetString("TypeLoadClassName");
			this._assemblyName = info.GetString("TypeLoadAssemblyName");
			this._messageArg = info.GetString("TypeLoadMessageArg");
			this._resourceId = info.GetInt32("TypeLoadResourceID");
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0001BF00 File Offset: 0x0001A100
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("TypeLoadClassName", this._className, typeof(string));
			info.AddValue("TypeLoadAssemblyName", this._assemblyName, typeof(string));
			info.AddValue("TypeLoadMessageArg", this._messageArg, typeof(string));
			info.AddValue("TypeLoadResourceID", this._resourceId);
		}

		// Token: 0x040002AF RID: 687
		private string _className;

		// Token: 0x040002B0 RID: 688
		private string _assemblyName;

		// Token: 0x040002B1 RID: 689
		private readonly string _messageArg;

		// Token: 0x040002B2 RID: 690
		private readonly int _resourceId;
	}
}
