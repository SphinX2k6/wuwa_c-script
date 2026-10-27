using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030E6 RID: 12518
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkeletalMeshComponentPool : SceneComponentPool<USkeletalMeshComponent>
{
	// Token: 0x0601ACEA RID: 109802 RVA: 0x0073BBCF File Offset: 0x00739DCF
	protected override void ActiveComponent(USkeletalMeshComponent component)
	{
		component.SetHiddenInGame(false, false);
		component.SetComponentTickEnabled(true);
	}

	// Token: 0x0601ACEB RID: 109803 RVA: 0x0073BBE0 File Offset: 0x00739DE0
	protected override void CleanComponent(USkeletalMeshComponent component)
	{
		component.SetSkeletalMesh(null, true);
		component.SetAnimClass(default(UClassStackOnlyPtr));
		component.SetHiddenInGame(true, false);
		component.SetComponentTickEnabled(false);
	}

	// Token: 0x0601ACEC RID: 109804 RVA: 0x0073BC14 File Offset: 0x00739E14
	[NullableContext(2)]
	protected override USkeletalMeshComponent CreateComponent()
	{
		if (!base.CheckPoolRange())
		{
			return null;
		}
		USkeletalMeshComponent uskeletalMeshComponent = this.ActorInternal.AddComponentByClass(USkeletalMeshComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as USkeletalMeshComponent;
		MeshComponentUtils.RelativeAttachComponentOnSafe(uskeletalMeshComponent, this.AttachComponentInternal, "");
		return uskeletalMeshComponent;
	}
}
