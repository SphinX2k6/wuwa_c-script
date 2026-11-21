using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000164 RID: 356
	[NullableContext(1)]
	[Nullable(0)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	public abstract class MarshalByRefObject
	{
		// Token: 0x0600174D RID: 5965 RVA: 0x000466CC File Offset: 0x000448CC
		[Obsolete("This Remoting API is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0010", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public object GetLifetimeService()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_Remoting);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000466CC File Offset: 0x000448CC
		[Obsolete("This Remoting API is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0010", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public virtual object InitializeLifetimeService()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_Remoting);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x000466D8 File Offset: 0x000448D8
		protected MarshalByRefObject MemberwiseClone(bool cloneIdentity)
		{
			return (MarshalByRefObject)base.MemberwiseClone();
		}
	}
}
