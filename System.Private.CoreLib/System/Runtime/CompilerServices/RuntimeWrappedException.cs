using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006C7 RID: 1735
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class RuntimeWrappedException : Exception
	{
		// Token: 0x06007481 RID: 29825 RVA: 0x00115928 File Offset: 0x00113B28
		public RuntimeWrappedException(object thrownObject) : base(SR.RuntimeWrappedException)
		{
			base.HResult = -2146233026;
			this._wrappedException = thrownObject;
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x00115947 File Offset: 0x00113B47
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private RuntimeWrappedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._wrappedException = info.GetValue("WrappedException", typeof(object));
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x0011596C File Offset: 0x00113B6C
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("WrappedException", this._wrappedException, typeof(object));
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x00115991 File Offset: 0x00113B91
		public object WrappedException
		{
			get
			{
				return this._wrappedException;
			}
		}

		// Token: 0x040014EF RID: 5359
		private readonly object _wrappedException;
	}
}
