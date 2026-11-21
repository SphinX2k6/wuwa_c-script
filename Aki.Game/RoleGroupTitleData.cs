using System;
using System.Runtime.CompilerServices;

// Token: 0x0200061F RID: 1567
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class RoleGroupTitleData : MultiTemplateGridDataBase<RoleGroupTitleData_Data, RoleGroupTitleItem>
{
	// Token: 0x06004951 RID: 18769 RVA: 0x0018E18A File Offset: 0x0018C38A
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x06004952 RID: 18770 RVA: 0x0018E18D File Offset: 0x0018C38D
	public override RoleGroupTitleItem CreateProxy()
	{
		return new RoleGroupTitleItem();
	}
}
