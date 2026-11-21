using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002661 RID: 9825
[NullableContext(1)]
[Nullable(0)]
public class SpherePullTarget : ISpherePullTarget
{
	// Token: 0x170026E5 RID: 9957
	// (get) Token: 0x060189A4 RID: 100772 RVA: 0x00775A45 File Offset: 0x00773C45
	// (set) Token: 0x060189A5 RID: 100773 RVA: 0x00775A4D File Offset: 0x00773C4D
	public IVector Center { get; set; }

	// Token: 0x170026E6 RID: 9958
	// (get) Token: 0x060189A6 RID: 100774 RVA: 0x00775A56 File Offset: 0x00773C56
	// (set) Token: 0x060189A7 RID: 100775 RVA: 0x00775A5E File Offset: 0x00773C5E
	public float Radius { get; set; }

	// Token: 0x170026E7 RID: 9959
	// (get) Token: 0x060189A8 RID: 100776 RVA: 0x00775A67 File Offset: 0x00773C67
	// (set) Token: 0x060189A9 RID: 100777 RVA: 0x00775A6F File Offset: 0x00773C6F
	public float GroundHeight { get; set; }

	// Token: 0x170026E8 RID: 9960
	// (get) Token: 0x060189AA RID: 100778 RVA: 0x00775A78 File Offset: 0x00773C78
	// (set) Token: 0x060189AB RID: 100779 RVA: 0x00775A80 File Offset: 0x00773C80
	public IVector GravityDirection { get; set; }

	// Token: 0x170026E9 RID: 9961
	// (get) Token: 0x060189AC RID: 100780 RVA: 0x00775A89 File Offset: 0x00773C89
	// (set) Token: 0x060189AD RID: 100781 RVA: 0x00775A91 File Offset: 0x00773C91
	public CurveBase Curve { get; set; }
}
