using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200263E RID: 9790
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkeletalMeshComponentPool : SceneComponentPool<USkeletalMeshComponent>
{
	// Token: 0x06018706 RID: 100102 RVA: 0x0076160B File Offset: 0x0075F80B
	protected override void ActiveComponent(USkeletalMeshComponent component)
	{
		component.SetHiddenInGame(false, false);
		component.SetComponentTickEnabled(true);
	}

	// Token: 0x06018707 RID: 100103 RVA: 0x0076161C File Offset: 0x0075F81C
	protected override void CleanComponent(USkeletalMeshComponent component)
	{
		component.SetSkeletalMesh(null, true);
		component.SetAnimClass(default(UClassStackOnlyPtr));
		component.SetHiddenInGame(true, false);
		component.SetComponentTickEnabled(false);
	}

	// Token: 0x06018708 RID: 100104 RVA: 0x00761650 File Offset: 0x0075F850
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
