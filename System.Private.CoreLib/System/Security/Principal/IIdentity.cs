using System;
using System.Runtime.CompilerServices;

namespace System.Security.Principal
{
	// Token: 0x0200026C RID: 620
	[NullableContext(2)]
	public interface IIdentity
	{
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002DE7 RID: 11751
		string Name { get; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002DE8 RID: 11752
		string AuthenticationType { get; }

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002DE9 RID: 11753
		bool IsAuthenticated { get; }
	}
}
