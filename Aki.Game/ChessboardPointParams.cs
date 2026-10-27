using System;
using System.Runtime.CompilerServices;

// Token: 0x020011D1 RID: 4561
[NullableContext(1)]
[Nullable(0)]
public class ChessboardPointParams : IChessboardPointParams
{
	// Token: 0x17000A53 RID: 2643
	// (get) Token: 0x0600797F RID: 31103 RVA: 0x00199D1E File Offset: 0x00197F1E
	// (set) Token: 0x06007980 RID: 31104 RVA: 0x00199D26 File Offset: 0x00197F26
	public int Id { get; set; }

	// Token: 0x17000A54 RID: 2644
	// (get) Token: 0x06007981 RID: 31105 RVA: 0x00199D2F File Offset: 0x00197F2F
	// (set) Token: 0x06007982 RID: 31106 RVA: 0x00199D37 File Offset: 0x00197F37
	public Vector Location { get; set; }

	// Token: 0x17000A55 RID: 2645
	// (get) Token: 0x06007983 RID: 31107 RVA: 0x00199D40 File Offset: 0x00197F40
	// (set) Token: 0x06007984 RID: 31108 RVA: 0x00199D48 File Offset: 0x00197F48
	public Rotator Rotation { get; set; }

	// Token: 0x17000A56 RID: 2646
	// (get) Token: 0x06007985 RID: 31109 RVA: 0x00199D51 File Offset: 0x00197F51
	// (set) Token: 0x06007986 RID: 31110 RVA: 0x00199D59 File Offset: 0x00197F59
	[Nullable(2)]
	public Rotator BackwardRotation { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000A57 RID: 2647
	// (get) Token: 0x06007987 RID: 31111 RVA: 0x00199D62 File Offset: 0x00197F62
	// (set) Token: 0x06007988 RID: 31112 RVA: 0x00199D6A File Offset: 0x00197F6A
	public int SortIndex { get; set; }
}
