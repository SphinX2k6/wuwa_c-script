using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027FC RID: 10236
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevPhantomData : RoleDevPhantomViewItemDataBase
{
	// Token: 0x06015028 RID: 86056 RVA: 0x0055247D File Offset: 0x0055067D
	protected override void InitByRoleType(int roleId)
	{
		this.RefreshSuitDataList();
	}

	// Token: 0x06015029 RID: 86057 RVA: 0x00552485 File Offset: 0x00550685
	protected override List<RoleDevPhantomSuitItemData> GetSuitDataList()
	{
		return this.SuitDataListInternal;
	}

	// Token: 0x0601502A RID: 86058 RVA: 0x0055248D File Offset: 0x0055068D
	public override void RefreshSuitDataList()
	{
		this.SuitDataListInternal.Clear();
	}

	// Token: 0x04009DFC RID: 40444
	private List<RoleDevPhantomSuitItemData> SuitDataListInternal = new List<RoleDevPhantomSuitItemData>();
}
