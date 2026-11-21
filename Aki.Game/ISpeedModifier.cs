using System;

// Token: 0x020003B0 RID: 944
public interface ISpeedModifier
{
	// Token: 0x17000789 RID: 1929
	// (get) Token: 0x060033D0 RID: 13264
	// (set) Token: 0x060033D1 RID: 13265
	EModifierType Type { get; set; }

	// Token: 0x1700078A RID: 1930
	// (get) Token: 0x060033D2 RID: 13266
	// (set) Token: 0x060033D3 RID: 13267
	float Value { get; set; }

	// Token: 0x1700078B RID: 1931
	// (get) Token: 0x060033D4 RID: 13268
	// (set) Token: 0x060033D5 RID: 13269
	int Priority { get; set; }
}
