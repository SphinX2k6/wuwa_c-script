using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C97 RID: 7319
public class RoleTowerRoleSnapshotData
{
	// Token: 0x04009E67 RID: 40551
	public int RoleId;

	// Token: 0x04009E68 RID: 40552
	public int WeaponIncId;

	// Token: 0x04009E69 RID: 40553
	[Nullable(1)]
	public List<int> PhantomIncIds = new List<int>();
}
