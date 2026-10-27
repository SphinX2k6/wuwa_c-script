using System;

// Token: 0x020020D4 RID: 8404
public class ExploreToolAuthorizationLogData
{
	// Token: 0x060108BE RID: 67774 RVA: 0x0040AB80 File Offset: 0x00408D80
	public ExploreToolAuthorizationLogData(int auth_id, int item_id)
	{
		this.i_auth_id = auth_id;
		this.i_item_id = item_id;
	}

	// Token: 0x04007BB7 RID: 31671
	public int i_auth_id;

	// Token: 0x04007BB8 RID: 31672
	public int i_item_id;
}
