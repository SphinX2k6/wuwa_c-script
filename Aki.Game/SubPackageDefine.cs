using System;

// Token: 0x02002013 RID: 8211
public class SubPackageDefine
{
	// Token: 0x06014550 RID: 83280 RVA: 0x005ECED3 File Offset: 0x005EB0D3
	public static int GetDynamicRecallId(int recallId)
	{
		return 100000000 + recallId;
	}

	// Token: 0x06014551 RID: 83281 RVA: 0x005ECEDC File Offset: 0x005EB0DC
	public static bool IsDynamicRecallId(int id)
	{
		return id >= 100000000;
	}

	// Token: 0x06014552 RID: 83282 RVA: 0x005ECEE9 File Offset: 0x005EB0E9
	public static int RecallIdFromDynamic(int id)
	{
		return id - 100000000;
	}

	// Token: 0x0400AC7A RID: 44154
	public const int KEY_SUBPACKAGE_ID = 1;

	// Token: 0x0400AC7B RID: 44155
	public const int DYNAMIC_RECALL_SUBPACKAGE_BASE = 100000000;
}
