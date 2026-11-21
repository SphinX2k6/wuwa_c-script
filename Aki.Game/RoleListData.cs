using System;
using System.Runtime.CompilerServices;

// Token: 0x02000621 RID: 1569
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class RoleListData : MultiTemplateGridDataBase<BabelTowerRoleListItemData, BabelTowerRoleListItem>
{
	// Token: 0x0600495A RID: 18778 RVA: 0x0018E647 File Offset: 0x0018C847
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x0600495B RID: 18779 RVA: 0x0018E64A File Offset: 0x0018C84A
	public override BabelTowerRoleListItem CreateProxy()
	{
		return new BabelTowerRoleListItem();
	}
}
