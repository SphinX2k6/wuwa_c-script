using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000EC6 RID: 3782
[NullableContext(1)]
[Nullable(0)]
public class DamageInfo
{
	// Token: 0x04005ABF RID: 23231
	public float Damage;

	// Token: 0x04005AC0 RID: 23232
	public int ElementId;

	// Token: 0x04005AC1 RID: 23233
	public FVectorDouble? DamagePosition;

	// Token: 0x04005AC2 RID: 23234
	public Vector BaseLocation = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04005AC3 RID: 23235
	public bool IsOwnPlayer;

	// Token: 0x04005AC4 RID: 23236
	public bool IsCritical;

	// Token: 0x04005AC5 RID: 23237
	public bool IsCure;

	// Token: 0x04005AC6 RID: 23238
	public int DamageTextId;

	// Token: 0x04005AC7 RID: 23239
	public string DamageText = "";

	// Token: 0x04005AC8 RID: 23240
	public int DamageTextAreaId;

	// Token: 0x04005AC9 RID: 23241
	public int EntityId;

	// Token: 0x04005ACA RID: 23242
	public bool EnableOptimization;

	// Token: 0x04005ACB RID: 23243
	public bool Valid;
}
