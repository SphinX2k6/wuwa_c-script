using System;

namespace System.Security
{
	// Token: 0x0200025A RID: 602
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public interface IStackWalk
	{
		// Token: 0x06002D57 RID: 11607
		void Assert();

		// Token: 0x06002D58 RID: 11608
		void Demand();

		// Token: 0x06002D59 RID: 11609
		void Deny();

		// Token: 0x06002D5A RID: 11610
		void PermitOnly();
	}
}
