using System;
using System.Runtime.CompilerServices;

// Token: 0x02001846 RID: 6214
[NullableContext(1)]
[Nullable(0)]
public class EditFormationRoleFilter : RoleFilter
{
	// Token: 0x0600B612 RID: 46610 RVA: 0x00292B0F File Offset: 0x00290D0F
	public override TDefaultFilter[] DefaultFilterList()
	{
		return new TDefaultFilter[]
		{
			new TDefaultFilter(this.IsEditFormation)
		};
	}

	// Token: 0x0600B613 RID: 46611 RVA: 0x00292B28 File Offset: 0x00290D28
	private bool IsEditFormation(object data)
	{
		int dataId = ((RoleDataBase)data).GetDataId();
		return RoleSelectModel.Instance.GetRoleIndex(dataId) > 0;
	}
}
