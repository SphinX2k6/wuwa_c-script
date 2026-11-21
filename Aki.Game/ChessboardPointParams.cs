using System;
using System.Runtime.CompilerServices;

// Token: 0x02000685 RID: 1669
[NullableContext(1)]
[Nullable(0)]
public class ChessboardPointParams : IChessboardPointParams
{
	// Token: 0x17000A73 RID: 2675
	// (get) Token: 0x06004D16 RID: 19734 RVA: 0x001A29CE File Offset: 0x001A0BCE
	// (set) Token: 0x06004D17 RID: 19735 RVA: 0x001A29D6 File Offset: 0x001A0BD6
	public int Id { get; set; }

	// Token: 0x17000A74 RID: 2676
	// (get) Token: 0x06004D18 RID: 19736 RVA: 0x001A29DF File Offset: 0x001A0BDF
	// (set) Token: 0x06004D19 RID: 19737 RVA: 0x001A29E7 File Offset: 0x001A0BE7
	public Vector Location { get; set; }

	// Token: 0x17000A75 RID: 2677
	// (get) Token: 0x06004D1A RID: 19738 RVA: 0x001A29F0 File Offset: 0x001A0BF0
	// (set) Token: 0x06004D1B RID: 19739 RVA: 0x001A29F8 File Offset: 0x001A0BF8
	public Rotator Rotation { get; set; }

	// Token: 0x17000A76 RID: 2678
	// (get) Token: 0x06004D1C RID: 19740 RVA: 0x001A2A01 File Offset: 0x001A0C01
	// (set) Token: 0x06004D1D RID: 19741 RVA: 0x001A2A09 File Offset: 0x001A0C09
	[Nullable(2)]
	public Rotator BackwardRotation { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000A77 RID: 2679
	// (get) Token: 0x06004D1E RID: 19742 RVA: 0x001A2A12 File Offset: 0x001A0C12
	// (set) Token: 0x06004D1F RID: 19743 RVA: 0x001A2A1A File Offset: 0x001A0C1A
	public int SortIndex { get; set; }
}
