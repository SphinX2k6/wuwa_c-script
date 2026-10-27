using System;

// Token: 0x020014E6 RID: 5350
public interface IScratchTicketRewardResult
{
	// Token: 0x17000D1E RID: 3358
	// (get) Token: 0x06009847 RID: 38983
	// (set) Token: 0x06009848 RID: 38984
	int Index { get; set; }

	// Token: 0x17000D1F RID: 3359
	// (get) Token: 0x06009849 RID: 38985
	// (set) Token: 0x0600984A RID: 38986
	EScratchDirectionType DirectionType { get; set; }

	// Token: 0x17000D20 RID: 3360
	// (get) Token: 0x0600984B RID: 38987
	// (set) Token: 0x0600984C RID: 38988
	ECellSequenceType SequenceType { get; set; }
}
