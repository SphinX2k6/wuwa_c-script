using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Security
{
	// Token: 0x02000263 RID: 611
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SecurityException : SystemException
	{
		// Token: 0x06002DBE RID: 11710 RVA: 0x00093AE1 File Offset: 0x00091CE1
		public SecurityException() : base(SR.Arg_SecurityException)
		{
			base.HResult = -2146233078;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00093AF9 File Offset: 0x00091CF9
		public SecurityException(string message) : base(message ?? SR.Arg_SecurityException)
		{
			base.HResult = -2146233078;
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00093B16 File Offset: 0x00091D16
		public SecurityException(string message, Exception inner) : base(message ?? SR.Arg_SecurityException, inner)
		{
			base.HResult = -2146233078;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00093B34 File Offset: 0x00091D34
		public SecurityException(string message, Type type) : base(message ?? SR.Arg_SecurityException)
		{
			base.HResult = -2146233078;
			this.PermissionType = type;
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00093B58 File Offset: 0x00091D58
		public SecurityException(string message, Type type, string state) : base(message ?? SR.Arg_SecurityException)
		{
			base.HResult = -2146233078;
			this.PermissionType = type;
			this.PermissionState = state;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00093B84 File Offset: 0x00091D84
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SecurityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.Demanded = (string)info.GetValueNoThrow("Demanded", typeof(string));
			this.GrantedSet = (string)info.GetValueNoThrow("GrantedSet", typeof(string));
			this.RefusedSet = (string)info.GetValueNoThrow("RefusedSet", typeof(string));
			this.DenySetInstance = (string)info.GetValueNoThrow("Denied", typeof(string));
			this.PermitOnlySetInstance = (string)info.GetValueNoThrow("PermitOnly", typeof(string));
			this.Url = (string)info.GetValueNoThrow("Url", typeof(string));
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00093C59 File Offset: 0x00091E59
		[NullableContext(1)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00093C64 File Offset: 0x00091E64
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("Demanded", this.Demanded, typeof(string));
			info.AddValue("GrantedSet", this.GrantedSet, typeof(string));
			info.AddValue("RefusedSet", this.RefusedSet, typeof(string));
			info.AddValue("Denied", this.DenySetInstance, typeof(string));
			info.AddValue("PermitOnly", this.PermitOnlySetInstance, typeof(string));
			info.AddValue("Url", this.Url, typeof(string));
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x00093D1B File Offset: 0x00091F1B
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x00093D23 File Offset: 0x00091F23
		public object Demanded { get; set; }

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x00093D2C File Offset: 0x00091F2C
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x00093D34 File Offset: 0x00091F34
		public object DenySetInstance { get; set; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x00093D3D File Offset: 0x00091F3D
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x00093D45 File Offset: 0x00091F45
		public AssemblyName FailedAssemblyInfo { get; set; }

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x00093D4E File Offset: 0x00091F4E
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x00093D56 File Offset: 0x00091F56
		public string GrantedSet { get; set; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x00093D5F File Offset: 0x00091F5F
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x00093D67 File Offset: 0x00091F67
		public MethodInfo Method { get; set; }

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x00093D70 File Offset: 0x00091F70
		// (set) Token: 0x06002DD1 RID: 11729 RVA: 0x00093D78 File Offset: 0x00091F78
		public string PermissionState { get; set; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x00093D81 File Offset: 0x00091F81
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x00093D89 File Offset: 0x00091F89
		public Type PermissionType { get; set; }

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x00093D92 File Offset: 0x00091F92
		// (set) Token: 0x06002DD5 RID: 11733 RVA: 0x00093D9A File Offset: 0x00091F9A
		public object PermitOnlySetInstance { get; set; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x00093DA3 File Offset: 0x00091FA3
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x00093DAB File Offset: 0x00091FAB
		public string RefusedSet { get; set; }

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x00093DB4 File Offset: 0x00091FB4
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x00093DBC File Offset: 0x00091FBC
		public string Url { get; set; }
	}
}
