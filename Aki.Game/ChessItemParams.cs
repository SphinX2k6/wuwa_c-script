using System;

// Token: 0x020011D3 RID: 4563
public class ChessItemParams : IChessItemParams
{
	// Token: 0x17000A5C RID: 2652
	// (get) Token: 0x06007992 RID: 31122 RVA: 0x00199D7B File Offset: 0x00197F7B
	// (set) Token: 0x06007993 RID: 31123 RVA: 0x00199D83 File Offset: 0x00197F83
	public int Id { get; set; }

	// Token: 0x17000A5D RID: 2653
	// (get) Token: 0x06007994 RID: 31124 RVA: 0x00199D8C File Offset: 0x00197F8C
	// (set) Token: 0x06007995 RID: 31125 RVA: 0x00199D94 File Offset: 0x00197F94
	public long CreatureDataId { get; set; }

	// Token: 0x17000A5E RID: 2654
	// (get) Token: 0x06007996 RID: 31126 RVA: 0x00199D9D File Offset: 0x00197F9D
	// (set) Token: 0x06007997 RID: 31127 RVA: 0x00199DA5 File Offset: 0x00197FA5
	public bool RotationIsForward { get; set; }

	// Token: 0x17000A5F RID: 2655
	// (get) Token: 0x06007998 RID: 31128 RVA: 0x00199DAE File Offset: 0x00197FAE
	// (set) Token: 0x06007999 RID: 31129 RVA: 0x00199DB6 File Offset: 0x00197FB6
	public int InitPointId { get; set; }
}
