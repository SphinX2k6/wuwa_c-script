using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020034F3 RID: 13555
[NullableContext(2)]
[Nullable(0)]
public class AttachActorItem
{
	// Token: 0x0400E93A RID: 59706
	public int Id;

	// Token: 0x0400E93B RID: 59707
	public int EntityId;

	// Token: 0x0400E93C RID: 59708
	public string Reason;

	// Token: 0x0400E93D RID: 59709
	public AActor Actor;

	// Token: 0x0400E93E RID: 59710
	public string Name;

	// Token: 0x0400E93F RID: 59711
	public string ParentActorName;

	// Token: 0x0400E940 RID: 59712
	public EDetachType? DetachType;
}
