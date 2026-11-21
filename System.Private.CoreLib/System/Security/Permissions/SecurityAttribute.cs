using System;
using System.Runtime.CompilerServices;

namespace System.Security.Permissions
{
	// Token: 0x02000273 RID: 627
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	public abstract class SecurityAttribute : Attribute
	{
		// Token: 0x06002DED RID: 11757 RVA: 0x00022817 File Offset: 0x00020A17
		protected SecurityAttribute(SecurityAction action)
		{
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x00093E49 File Offset: 0x00092049
		// (set) Token: 0x06002DEF RID: 11759 RVA: 0x00093E51 File Offset: 0x00092051
		public SecurityAction Action { get; set; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x00093E5A File Offset: 0x0009205A
		// (set) Token: 0x06002DF1 RID: 11761 RVA: 0x00093E62 File Offset: 0x00092062
		public bool Unrestricted { get; set; }

		// Token: 0x06002DF2 RID: 11762
		[NullableContext(2)]
		public abstract IPermission CreatePermission();
	}
}
