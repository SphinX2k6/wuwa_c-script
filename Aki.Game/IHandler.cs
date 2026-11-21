using System;

// Token: 0x02000C74 RID: 3188
public interface IHandler
{
	// Token: 0x17000ED0 RID: 3792
	// (get) Token: 0x0600853F RID: 34111
	EHandlerType Type { get; }

	// Token: 0x17000ED1 RID: 3793
	// (get) Token: 0x06008540 RID: 34112
	// (set) Token: 0x06008541 RID: 34113
	bool? IsSync { get; set; }

	// Token: 0x17000ED2 RID: 3794
	// (get) Token: 0x06008542 RID: 34114
	// (set) Token: 0x06008543 RID: 34115
	bool? IsCache { get; set; }
}
