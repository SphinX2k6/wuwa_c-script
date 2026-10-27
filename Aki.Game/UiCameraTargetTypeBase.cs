using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

// Token: 0x02002C39 RID: 11321
[NullableContext(1)]
[Nullable(0)]
public abstract class UiCameraTargetTypeBase
{
	// Token: 0x060179ED RID: 96749
	[return: Nullable(2)]
	public abstract AActor GetTargetActor(SUiCameraAnimationSettings config);

	// Token: 0x060179EE RID: 96750
	[NullableContext(2)]
	public abstract string GetTargetBodyKey();

	// Token: 0x060179EF RID: 96751
	[return: Nullable(2)]
	public abstract USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config);
}
