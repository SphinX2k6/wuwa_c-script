using System;
using System.Runtime.CompilerServices;

// Token: 0x020011D0 RID: 4560
[NullableContext(1)]
public interface IChessboardPointParams
{
	// Token: 0x17000A4E RID: 2638
	// (get) Token: 0x06007975 RID: 31093
	// (set) Token: 0x06007976 RID: 31094
	int Id { get; set; }

	// Token: 0x17000A4F RID: 2639
	// (get) Token: 0x06007977 RID: 31095
	// (set) Token: 0x06007978 RID: 31096
	Vector Location { get; set; }

	// Token: 0x17000A50 RID: 2640
	// (get) Token: 0x06007979 RID: 31097
	// (set) Token: 0x0600797A RID: 31098
	Rotator Rotation { get; set; }

	// Token: 0x17000A51 RID: 2641
	// (get) Token: 0x0600797B RID: 31099
	// (set) Token: 0x0600797C RID: 31100
	[Nullable(2)]
	Rotator BackwardRotation { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000A52 RID: 2642
	// (get) Token: 0x0600797D RID: 31101
	// (set) Token: 0x0600797E RID: 31102
	int SortIndex { get; set; }
}
