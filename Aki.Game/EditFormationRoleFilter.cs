using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CFF RID: 3327
[NullableContext(1)]
[Nullable(0)]
public class EditFormationRoleFilter : RoleFilter
{
	// Token: 0x060089FD RID: 35325 RVA: 0x0029D247 File Offset: 0x0029B447
	public override TDefaultFilter[] DefaultFilterList()
	{
		return new TDefaultFilter[]
		{
			new TDefaultFilter(this.IsEditFormation)
		};
	}

	// Token: 0x060089FE RID: 35326 RVA: 0x0029D260 File Offset: 0x0029B460
	private bool IsEditFormation(object data)
	{
		int dataId = ((RoleDataBase)data).GetDataId();
		return RoleSelectModel.Instance.GetRoleIndex(dataId) > 0;
	}
}
