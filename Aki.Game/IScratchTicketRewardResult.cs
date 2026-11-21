using System;

// Token: 0x0200099E RID: 2462
public interface IScratchTicketRewardResult
{
	// Token: 0x17000D3F RID: 3391
	// (get) Token: 0x06006C21 RID: 27681
	// (set) Token: 0x06006C22 RID: 27682
	int Index { get; set; }

	// Token: 0x17000D40 RID: 3392
	// (get) Token: 0x06006C23 RID: 27683
	// (set) Token: 0x06006C24 RID: 27684
	EScratchDirectionType DirectionType { get; set; }

	// Token: 0x17000D41 RID: 3393
	// (get) Token: 0x06006C25 RID: 27685
	// (set) Token: 0x06006C26 RID: 27686
	ECellSequenceType SequenceType { get; set; }
}
