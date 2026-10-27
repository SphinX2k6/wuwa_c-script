using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020018A9 RID: 6313
[NullableContext(2)]
[Nullable(0)]
public class SortStorageData : ISortStorageData
{
	// Token: 0x17000F54 RID: 3924
	// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x0029EBBC File Offset: 0x0029CDBC
	// (set) Token: 0x0600B8C5 RID: 47301 RVA: 0x0029EBC4 File Offset: 0x0029CDC4
	public int ConfigId { get; set; }

	// Token: 0x17000F55 RID: 3925
	// (get) Token: 0x0600B8C6 RID: 47302 RVA: 0x0029EBCD File Offset: 0x0029CDCD
	// (set) Token: 0x0600B8C7 RID: 47303 RVA: 0x0029EBD5 File Offset: 0x0029CDD5
	public int? SelectBaseSort { get; set; }

	// Token: 0x17000F56 RID: 3926
	// (get) Token: 0x0600B8C8 RID: 47304 RVA: 0x0029EBDE File Offset: 0x0029CDDE
	// (set) Token: 0x0600B8C9 RID: 47305 RVA: 0x0029EBE6 File Offset: 0x0029CDE6
	public List<int> SelectAttributeSort { get; set; }

	// Token: 0x17000F57 RID: 3927
	// (get) Token: 0x0600B8CA RID: 47306 RVA: 0x0029EBEF File Offset: 0x0029CDEF
	// (set) Token: 0x0600B8CB RID: 47307 RVA: 0x0029EBF7 File Offset: 0x0029CDF7
	public bool IsAscending { get; set; }
}
