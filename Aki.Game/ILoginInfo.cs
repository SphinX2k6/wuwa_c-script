using System;
using System.Runtime.CompilerServices;

// Token: 0x0200155C RID: 5468
[NullableContext(1)]
public interface ILoginInfo
{
	// Token: 0x1700146B RID: 5227
	// (get) Token: 0x0600DAAF RID: 55983
	// (set) Token: 0x0600DAB0 RID: 55984
	int LoginCode { get; set; }

	// Token: 0x1700146C RID: 5228
	// (get) Token: 0x0600DAB1 RID: 55985
	// (set) Token: 0x0600DAB2 RID: 55986
	string Uid { get; set; }

	// Token: 0x1700146D RID: 5229
	// (get) Token: 0x0600DAB3 RID: 55987
	// (set) Token: 0x0600DAB4 RID: 55988
	string UserName { get; set; }

	// Token: 0x1700146E RID: 5230
	// (get) Token: 0x0600DAB5 RID: 55989
	// (set) Token: 0x0600DAB6 RID: 55990
	string Token { get; set; }
}
