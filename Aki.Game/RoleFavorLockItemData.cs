using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DD2 RID: 7634
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorLockItemData
{
	// Token: 0x06012E7B RID: 77435 RVA: 0x0058AD01 File Offset: 0x00588F01
	public RoleFavorLockItemData(bool isLock, string desc)
	{
		this.IsLock = isLock;
		this.Desc = desc;
	}

	// Token: 0x0400A2E4 RID: 41700
	public bool IsLock;

	// Token: 0x0400A2E5 RID: 41701
	public string Desc = "";
}
