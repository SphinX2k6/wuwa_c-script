using System;
using System.Runtime.CompilerServices;

// Token: 0x0200024A RID: 586
[NullableContext(1)]
[Nullable(0)]
public class CloudGameUserInfoLegacy : ICloudGameUserInfoLegacy, ILoginInfo
{
	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000DABB0 File Offset: 0x000D8DB0
	// (set) Token: 0x060023B7 RID: 9143 RVA: 0x000DABB8 File Offset: 0x000D8DB8
	public string TraceId { get; set; }

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000DABC1 File Offset: 0x000D8DC1
	// (set) Token: 0x060023B9 RID: 9145 RVA: 0x000DABC9 File Offset: 0x000D8DC9
	public int LoginCode { get; set; }

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x060023BA RID: 9146 RVA: 0x000DABD2 File Offset: 0x000D8DD2
	// (set) Token: 0x060023BB RID: 9147 RVA: 0x000DABDA File Offset: 0x000D8DDA
	public string Uid { get; set; }

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x060023BC RID: 9148 RVA: 0x000DABE3 File Offset: 0x000D8DE3
	// (set) Token: 0x060023BD RID: 9149 RVA: 0x000DABEB File Offset: 0x000D8DEB
	public string UserName { get; set; }

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x060023BE RID: 9150 RVA: 0x000DABF4 File Offset: 0x000D8DF4
	// (set) Token: 0x060023BF RID: 9151 RVA: 0x000DABFC File Offset: 0x000D8DFC
	public string Token { get; set; }
}
