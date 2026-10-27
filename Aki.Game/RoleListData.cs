using System;
using System.Runtime.CompilerServices;

// Token: 0x0200116D RID: 4461
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class RoleListData : MultiTemplateGridDataBase<BabelTowerRoleListItemData, BabelTowerRoleListItem>
{
	// Token: 0x060075C3 RID: 30147 RVA: 0x00185A9F File Offset: 0x00183C9F
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x060075C4 RID: 30148 RVA: 0x00185AA2 File Offset: 0x00183CA2
	public override BabelTowerRoleListItem CreateProxy()
	{
		return new BabelTowerRoleListItem();
	}
}
