using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BAF RID: 2991
[NullableContext(1)]
[Nullable(0)]
public class TeleportInfo
{
	// Token: 0x06007C60 RID: 31840 RVA: 0x00268A80 File Offset: 0x00266C80
	public TeleportInfo(Vector location, [Nullable(2)] Rotator rotator)
	{
	}

	// Token: 0x17000E17 RID: 3607
	// (get) Token: 0x06007C61 RID: 31841 RVA: 0x00268A96 File Offset: 0x00266C96
	// (set) Token: 0x06007C62 RID: 31842 RVA: 0x00268A9E File Offset: 0x00266C9E
	public Vector Location { get; set; } = location;

	// Token: 0x17000E18 RID: 3608
	// (get) Token: 0x06007C63 RID: 31843 RVA: 0x00268AA7 File Offset: 0x00266CA7
	// (set) Token: 0x06007C64 RID: 31844 RVA: 0x00268AAF File Offset: 0x00266CAF
	[Nullable(2)]
	public Rotator Rotator { [NullableContext(2)] get; [NullableContext(2)] set; } = rotator;
}
