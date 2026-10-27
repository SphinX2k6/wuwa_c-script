using System;

// Token: 0x020017BB RID: 6075
public interface IHandler
{
	// Token: 0x17000EAD RID: 3757
	// (get) Token: 0x0600B157 RID: 45399
	EHandlerType Type { get; }

	// Token: 0x17000EAE RID: 3758
	// (get) Token: 0x0600B158 RID: 45400
	// (set) Token: 0x0600B159 RID: 45401
	bool? IsSync { get; set; }

	// Token: 0x17000EAF RID: 3759
	// (get) Token: 0x0600B15A RID: 45402
	// (set) Token: 0x0600B15B RID: 45403
	bool? IsCache { get; set; }
}
