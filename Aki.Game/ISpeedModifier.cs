using System;

// Token: 0x02000EFB RID: 3835
public interface ISpeedModifier
{
	// Token: 0x17000767 RID: 1895
	// (get) Token: 0x06006038 RID: 24632
	// (set) Token: 0x06006039 RID: 24633
	EModifierType Type { get; set; }

	// Token: 0x17000768 RID: 1896
	// (get) Token: 0x0600603A RID: 24634
	// (set) Token: 0x0600603B RID: 24635
	float Value { get; set; }

	// Token: 0x17000769 RID: 1897
	// (get) Token: 0x0600603C RID: 24636
	// (set) Token: 0x0600603D RID: 24637
	int Priority { get; set; }
}
