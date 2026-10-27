using System;
using System.Runtime.CompilerServices;

// Token: 0x02002857 RID: 10327
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorLockItemData
{
	// Token: 0x0601547D RID: 87165 RVA: 0x0055FFA5 File Offset: 0x0055E1A5
	public RoleFavorLockItemData(bool isLock, string desc)
	{
		this.IsLock = isLock;
		this.Desc = desc;
	}

	// Token: 0x04009EFB RID: 40699
	public bool IsLock;

	// Token: 0x04009EFC RID: 40700
	public string Desc = "";
}
