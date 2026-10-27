using System;
using System.Runtime.CompilerServices;

// Token: 0x0200116B RID: 4459
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class RoleGroupTitleData : MultiTemplateGridDataBase<RoleGroupTitleData_Data, RoleGroupTitleItem>
{
	// Token: 0x060075BA RID: 30138 RVA: 0x001855D2 File Offset: 0x001837D2
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x060075BB RID: 30139 RVA: 0x001855D5 File Offset: 0x001837D5
	public override RoleGroupTitleItem CreateProxy()
	{
		return new RoleGroupTitleItem();
	}
}
