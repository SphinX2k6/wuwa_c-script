using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D77 RID: 7543
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevPhantomData : RoleDevPhantomViewItemDataBase
{
	// Token: 0x06012A28 RID: 76328 RVA: 0x0057D1F1 File Offset: 0x0057B3F1
	protected override void InitByRoleType(int roleId)
	{
		this.RefreshSuitDataList();
	}

	// Token: 0x06012A29 RID: 76329 RVA: 0x0057D1F9 File Offset: 0x0057B3F9
	protected override List<RoleDevPhantomSuitItemData> GetSuitDataList()
	{
		return this.SuitDataListInternal;
	}

	// Token: 0x06012A2A RID: 76330 RVA: 0x0057D201 File Offset: 0x0057B401
	public override void RefreshSuitDataList()
	{
		this.SuitDataListInternal.Clear();
	}

	// Token: 0x0400A1E5 RID: 41445
	private List<RoleDevPhantomSuitItemData> SuitDataListInternal = new List<RoleDevPhantomSuitItemData>();
}
