using System;
using System.Runtime.CompilerServices;

// Token: 0x020027A8 RID: 10152
[NullableContext(1)]
[Nullable(0)]
public class RoleBreachSuccessViewData
{
	// Token: 0x06014DB3 RID: 85427 RVA: 0x0054AD97 File Offset: 0x00548F97
	public RoleBreachSuccessViewData(int roleDataId, Action onMaskClick)
	{
		this.RoleDataId = roleDataId;
		this.OnMaskClick = onMaskClick;
	}

	// Token: 0x04009CE6 RID: 40166
	public int RoleDataId;

	// Token: 0x04009CE7 RID: 40167
	public Action OnMaskClick;
}
