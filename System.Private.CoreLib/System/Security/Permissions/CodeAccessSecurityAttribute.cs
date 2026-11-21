using System;

namespace System.Security.Permissions
{
	// Token: 0x02000270 RID: 624
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	public abstract class CodeAccessSecurityAttribute : SecurityAttribute
	{
		// Token: 0x06002DEC RID: 11756 RVA: 0x00093E40 File Offset: 0x00092040
		protected CodeAccessSecurityAttribute(SecurityAction action) : base((SecurityAction)0)
		{
		}
	}
}
