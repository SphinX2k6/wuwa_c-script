using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Resources
{
	// Token: 0x0200027D RID: 637
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class MissingSatelliteAssemblyException : SystemException
	{
		// Token: 0x06002E3E RID: 11838 RVA: 0x00094A47 File Offset: 0x00092C47
		public MissingSatelliteAssemblyException() : base(SR.MissingSatelliteAssembly_Default)
		{
			base.HResult = -2146233034;
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x00094A5F File Offset: 0x00092C5F
		public MissingSatelliteAssemblyException(string message) : base(message ?? SR.MissingSatelliteAssembly_Default)
		{
			base.HResult = -2146233034;
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x00094A7C File Offset: 0x00092C7C
		public MissingSatelliteAssemblyException(string message, string cultureName) : base(message ?? SR.MissingSatelliteAssembly_Default)
		{
			base.HResult = -2146233034;
			this._cultureName = cultureName;
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00094AA0 File Offset: 0x00092CA0
		public MissingSatelliteAssemblyException(string message, Exception inner) : base(message ?? SR.MissingSatelliteAssembly_Default, inner)
		{
			base.HResult = -2146233034;
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00094ABE File Offset: 0x00092CBE
		public string CultureName
		{
			get
			{
				return this._cultureName;
			}
		}

		// Token: 0x0400086F RID: 2159
		private readonly string _cultureName;
	}
}
