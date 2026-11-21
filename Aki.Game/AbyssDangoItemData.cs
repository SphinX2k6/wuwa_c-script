using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EE1 RID: 3809
public class AbyssDangoItemData
{
	// Token: 0x04005B8E RID: 23438
	public int DangoId;

	// Token: 0x04005B8F RID: 23439
	public int PlayerId;

	// Token: 0x04005B90 RID: 23440
	public int RoleId;

	// Token: 0x04005B91 RID: 23441
	public bool SelectState;

	// Token: 0x04005B92 RID: 23442
	[Nullable(1)]
	public Action<AbyssDangoItemData> OnSelectCallBack = delegate(AbyssDangoItemData _)
	{
	};
}
