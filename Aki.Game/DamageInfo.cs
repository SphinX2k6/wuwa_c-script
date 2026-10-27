using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001A07 RID: 6663
[NullableContext(1)]
[Nullable(0)]
public class DamageInfo
{
	// Token: 0x040059F0 RID: 23024
	public float Damage;

	// Token: 0x040059F1 RID: 23025
	public int ElementId;

	// Token: 0x040059F2 RID: 23026
	public FVectorDouble? DamagePosition;

	// Token: 0x040059F3 RID: 23027
	public Vector BaseLocation = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x040059F4 RID: 23028
	public bool IsOwnPlayer;

	// Token: 0x040059F5 RID: 23029
	public bool IsCritical;

	// Token: 0x040059F6 RID: 23030
	public bool IsCure;

	// Token: 0x040059F7 RID: 23031
	public int DamageTextId;

	// Token: 0x040059F8 RID: 23032
	public string DamageText = "";

	// Token: 0x040059F9 RID: 23033
	public int DamageTextAreaId;

	// Token: 0x040059FA RID: 23034
	public int EntityId;

	// Token: 0x040059FB RID: 23035
	public bool EnableOptimization;

	// Token: 0x040059FC RID: 23036
	public bool Valid;
}
