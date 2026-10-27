using System;
using System.Runtime.CompilerServices;

// Token: 0x020016F7 RID: 5879
[NullableContext(1)]
[Nullable(0)]
public class TeleportInfo
{
	// Token: 0x0600A880 RID: 43136 RVA: 0x0025E664 File Offset: 0x0025C864
	public TeleportInfo(Vector location, [Nullable(2)] Rotator rotator)
	{
	}

	// Token: 0x17000DF6 RID: 3574
	// (get) Token: 0x0600A881 RID: 43137 RVA: 0x0025E67A File Offset: 0x0025C87A
	// (set) Token: 0x0600A882 RID: 43138 RVA: 0x0025E682 File Offset: 0x0025C882
	public Vector Location { get; set; } = location;

	// Token: 0x17000DF7 RID: 3575
	// (get) Token: 0x0600A883 RID: 43139 RVA: 0x0025E68B File Offset: 0x0025C88B
	// (set) Token: 0x0600A884 RID: 43140 RVA: 0x0025E693 File Offset: 0x0025C893
	[Nullable(2)]
	public Rotator Rotator { [NullableContext(2)] get; [NullableContext(2)] set; } = rotator;
}
