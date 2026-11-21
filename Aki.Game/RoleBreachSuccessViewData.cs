using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D23 RID: 7459
[NullableContext(1)]
[Nullable(0)]
public class RoleBreachSuccessViewData
{
	// Token: 0x060127AD RID: 75693 RVA: 0x0057591F File Offset: 0x00573B1F
	public RoleBreachSuccessViewData(int roleDataId, Action onMaskClick)
	{
		this.RoleDataId = roleDataId;
		this.OnMaskClick = onMaskClick;
	}

	// Token: 0x0400A0C9 RID: 41161
	public int RoleDataId;

	// Token: 0x0400A0CA RID: 41162
	public Action OnMaskClick;
}
