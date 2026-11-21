using System;

// Token: 0x020020DC RID: 8412
public interface ISurvivorsLvNodeData
{
	// Token: 0x17001F05 RID: 7941
	// (get) Token: 0x06014A7B RID: 84603
	int Lv { get; }

	// Token: 0x17001F06 RID: 7942
	// (get) Token: 0x06014A7C RID: 84604
	bool IsImportant { get; }

	// Token: 0x17001F07 RID: 7943
	// (get) Token: 0x06014A7D RID: 84605
	ESurvivorsLvState State { get; }
}
