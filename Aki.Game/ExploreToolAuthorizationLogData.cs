using System;

// Token: 0x020015AB RID: 5547
public class ExploreToolAuthorizationLogData
{
	// Token: 0x0600DD2E RID: 56622 RVA: 0x00417290 File Offset: 0x00415490
	public ExploreToolAuthorizationLogData(int auth_id, int item_id)
	{
		this.i_auth_id = auth_id;
		this.i_item_id = item_id;
	}

	// Token: 0x04007CB6 RID: 31926
	public int i_auth_id;

	// Token: 0x04007CB7 RID: 31927
	public int i_item_id;
}
