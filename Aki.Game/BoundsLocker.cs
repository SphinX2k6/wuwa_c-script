using System;

// Token: 0x020023F9 RID: 9209
public class BoundsLocker : IBoundsLocker
{
	// Token: 0x170023CD RID: 9165
	// (get) Token: 0x060170E9 RID: 94441 RVA: 0x006BB6EB File Offset: 0x006B98EB
	// (set) Token: 0x060170EA RID: 94442 RVA: 0x006BB6F3 File Offset: 0x006B98F3
	public bool LockUpperBounds { get; set; }

	// Token: 0x170023CE RID: 9166
	// (get) Token: 0x060170EB RID: 94443 RVA: 0x006BB6FC File Offset: 0x006B98FC
	// (set) Token: 0x060170EC RID: 94444 RVA: 0x006BB704 File Offset: 0x006B9904
	public bool LockLowerBounds { get; set; }

	// Token: 0x170023CF RID: 9167
	// (get) Token: 0x060170ED RID: 94445 RVA: 0x006BB70D File Offset: 0x006B990D
	// (set) Token: 0x060170EE RID: 94446 RVA: 0x006BB715 File Offset: 0x006B9915
	public float UpperPercent { get; set; }

	// Token: 0x170023D0 RID: 9168
	// (get) Token: 0x060170EF RID: 94447 RVA: 0x006BB71E File Offset: 0x006B991E
	// (set) Token: 0x060170F0 RID: 94448 RVA: 0x006BB726 File Offset: 0x006B9926
	public float UpperOffset { get; set; }

	// Token: 0x170023D1 RID: 9169
	// (get) Token: 0x060170F1 RID: 94449 RVA: 0x006BB72F File Offset: 0x006B992F
	// (set) Token: 0x060170F2 RID: 94450 RVA: 0x006BB737 File Offset: 0x006B9937
	public float LowerPercent { get; set; }

	// Token: 0x170023D2 RID: 9170
	// (get) Token: 0x060170F3 RID: 94451 RVA: 0x006BB740 File Offset: 0x006B9940
	// (set) Token: 0x060170F4 RID: 94452 RVA: 0x006BB748 File Offset: 0x006B9948
	public float LowerOffset { get; set; }
}
