using System;
using System.Runtime.CompilerServices;

// Token: 0x02000684 RID: 1668
[NullableContext(1)]
public interface IChessboardPointParams
{
	// Token: 0x17000A6E RID: 2670
	// (get) Token: 0x06004D0C RID: 19724
	// (set) Token: 0x06004D0D RID: 19725
	int Id { get; set; }

	// Token: 0x17000A6F RID: 2671
	// (get) Token: 0x06004D0E RID: 19726
	// (set) Token: 0x06004D0F RID: 19727
	Vector Location { get; set; }

	// Token: 0x17000A70 RID: 2672
	// (get) Token: 0x06004D10 RID: 19728
	// (set) Token: 0x06004D11 RID: 19729
	Rotator Rotation { get; set; }

	// Token: 0x17000A71 RID: 2673
	// (get) Token: 0x06004D12 RID: 19730
	// (set) Token: 0x06004D13 RID: 19731
	[Nullable(2)]
	Rotator BackwardRotation { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000A72 RID: 2674
	// (get) Token: 0x06004D14 RID: 19732
	// (set) Token: 0x06004D15 RID: 19733
	int SortIndex { get; set; }
}
