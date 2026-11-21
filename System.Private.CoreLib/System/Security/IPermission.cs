using System;
using System.Runtime.CompilerServices;

namespace System.Security
{
	// Token: 0x02000258 RID: 600
	[NullableContext(2)]
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public interface IPermission : ISecurityEncodable
	{
		// Token: 0x06002D50 RID: 11600
		[NullableContext(1)]
		IPermission Copy();

		// Token: 0x06002D51 RID: 11601
		void Demand();

		// Token: 0x06002D52 RID: 11602
		IPermission Intersect(IPermission target);

		// Token: 0x06002D53 RID: 11603
		bool IsSubsetOf(IPermission target);

		// Token: 0x06002D54 RID: 11604
		IPermission Union(IPermission target);
	}
}
