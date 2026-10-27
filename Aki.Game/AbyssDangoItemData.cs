using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A22 RID: 6690
public class AbyssDangoItemData
{
	// Token: 0x04005ABF RID: 23231
	public int DangoId;

	// Token: 0x04005AC0 RID: 23232
	public int PlayerId;

	// Token: 0x04005AC1 RID: 23233
	public int RoleId;

	// Token: 0x04005AC2 RID: 23234
	public bool SelectState;

	// Token: 0x04005AC3 RID: 23235
	[Nullable(1)]
	public Action<AbyssDangoItemData> OnSelectCallBack = delegate(AbyssDangoItemData _)
	{
	};
}
