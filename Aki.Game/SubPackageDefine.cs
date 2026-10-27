using System;

// Token: 0x02002A97 RID: 10903
public class SubPackageDefine
{
	// Token: 0x06016B26 RID: 92966 RVA: 0x005C08C3 File Offset: 0x005BEAC3
	public static int GetDynamicRecallId(int recallId)
	{
		return 100000000 + recallId;
	}

	// Token: 0x06016B27 RID: 92967 RVA: 0x005C08CC File Offset: 0x005BEACC
	public static bool IsDynamicRecallId(int id)
	{
		return id >= 100000000;
	}

	// Token: 0x06016B28 RID: 92968 RVA: 0x005C08D9 File Offset: 0x005BEAD9
	public static int RecallIdFromDynamic(int id)
	{
		return id - 100000000;
	}

	// Token: 0x0400A874 RID: 43124
	public const int KEY_SUBPACKAGE_ID = 1;

	// Token: 0x0400A875 RID: 43125
	public const int DYNAMIC_RECALL_SUBPACKAGE_BASE = 100000000;
}
