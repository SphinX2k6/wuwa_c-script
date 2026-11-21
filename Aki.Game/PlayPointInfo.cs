using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F61 RID: 3937
[NullableContext(2)]
[Nullable(0)]
public class PlayPointInfo : IPlayPointInfo
{
	// Token: 0x170010B0 RID: 4272
	// (get) Token: 0x06009DF3 RID: 40435 RVA: 0x002EC7E1 File Offset: 0x002EA9E1
	// (set) Token: 0x06009DF4 RID: 40436 RVA: 0x002EC7E9 File Offset: 0x002EA9E9
	public int PlayId { get; set; }

	// Token: 0x170010B1 RID: 4273
	// (get) Token: 0x06009DF5 RID: 40437 RVA: 0x002EC7F2 File Offset: 0x002EA9F2
	// (set) Token: 0x06009DF6 RID: 40438 RVA: 0x002EC7FA File Offset: 0x002EA9FA
	public int EntityId { get; set; }

	// Token: 0x170010B2 RID: 4274
	// (get) Token: 0x06009DF7 RID: 40439 RVA: 0x002EC803 File Offset: 0x002EAA03
	// (set) Token: 0x06009DF8 RID: 40440 RVA: 0x002EC80B File Offset: 0x002EAA0B
	public EPlayPointState PlayState { get; set; }

	// Token: 0x170010B3 RID: 4275
	// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x002EC814 File Offset: 0x002EAA14
	// (set) Token: 0x06009DFA RID: 40442 RVA: 0x002EC81C File Offset: 0x002EAA1C
	public bool? IsClear { get; set; }

	// Token: 0x170010B4 RID: 4276
	// (get) Token: 0x06009DFB RID: 40443 RVA: 0x002EC825 File Offset: 0x002EAA25
	// (set) Token: 0x06009DFC RID: 40444 RVA: 0x002EC82D File Offset: 0x002EAA2D
	public string ClearInfo { get; set; }

	// Token: 0x170010B5 RID: 4277
	// (get) Token: 0x06009DFD RID: 40445 RVA: 0x002EC836 File Offset: 0x002EAA36
	// (set) Token: 0x06009DFE RID: 40446 RVA: 0x002EC83E File Offset: 0x002EAA3E
	public bool? LevelPlayMarkUnlock { get; set; }

	// Token: 0x170010B6 RID: 4278
	// (get) Token: 0x06009DFF RID: 40447 RVA: 0x002EC847 File Offset: 0x002EAA47
	// (set) Token: 0x06009E00 RID: 40448 RVA: 0x002EC84F File Offset: 0x002EAA4F
	public bool IsUnlock { get; set; }
}
