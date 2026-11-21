using System;
using System.Runtime.CompilerServices;

namespace System.Security.Principal
{
	// Token: 0x0200026D RID: 621
	[NullableContext(2)]
	public interface IPrincipal
	{
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002DEA RID: 11754
		IIdentity Identity { get; }

		// Token: 0x06002DEB RID: 11755
		[NullableContext(1)]
		bool IsInRole(string role);
	}
}
