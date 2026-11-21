using System;

// Token: 0x020003B2 RID: 946
public class SpeedModifier : ISpeedModifier
{
	// Token: 0x1700078E RID: 1934
	// (get) Token: 0x060033DA RID: 13274 RVA: 0x001352CE File Offset: 0x001334CE
	// (set) Token: 0x060033DB RID: 13275 RVA: 0x001352D6 File Offset: 0x001334D6
	public EModifierType Type { get; set; }

	// Token: 0x1700078F RID: 1935
	// (get) Token: 0x060033DC RID: 13276 RVA: 0x001352DF File Offset: 0x001334DF
	// (set) Token: 0x060033DD RID: 13277 RVA: 0x001352E7 File Offset: 0x001334E7
	public float Value { get; set; }

	// Token: 0x17000790 RID: 1936
	// (get) Token: 0x060033DE RID: 13278 RVA: 0x001352F0 File Offset: 0x001334F0
	// (set) Token: 0x060033DF RID: 13279 RVA: 0x001352F8 File Offset: 0x001334F8
	public int Priority { get; set; }
}
