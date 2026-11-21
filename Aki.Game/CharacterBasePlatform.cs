using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020027D9 RID: 10201
[NullableContext(1)]
[Nullable(0)]
public class CharacterBasePlatform : BasePlatform
{
	// Token: 0x06019A38 RID: 105016 RVA: 0x007E38C4 File Offset: 0x007E1AC4
	public CharacterBasePlatform(EntityHandle entityHandle) : base(entityHandle)
	{
		this.IsDeltaBaseSpeedNeedZ = false;
		BP_BasePlatform_C basePlatform = entityHandle.Entity.GetComponent<CharacterActorComponent>().Actor.BasePlatform;
		if (basePlatform != null && basePlatform.IsValid())
		{
			this.LeaveSphereCenter = new FVectorDouble?(UKismetMathLibrary.Conv_VectorToVectorDouble(basePlatform.LeaveSphereCenter));
			this.LeaveSphereRadiusSq = (double)(basePlatform.LeaveSphereRadius * basePlatform.LeaveSphereRadius);
		}
	}

	// Token: 0x06019A39 RID: 105017 RVA: 0x007E3938 File Offset: 0x007E1B38
	public override FTransformDouble? GetTransform()
	{
		if (!this.EntityHandle.Valid)
		{
			return null;
		}
		CharacterActorComponent component = this.EntityHandle.Entity.GetComponent<CharacterActorComponent>();
		BP_BasePlatform_C basePlatform = component.Actor.BasePlatform;
		if (basePlatform == null || !basePlatform.IsValid())
		{
			return null;
		}
		return new FTransformDouble?(component.Actor.Mesh.D_GetSocketTransform(basePlatform.RootComponent.AttachSocketName, ERelativeTransformSpace.RTS_World));
	}

	// Token: 0x06019A3A RID: 105018 RVA: 0x007E39B8 File Offset: 0x007E1BB8
	public override bool CheckLeave(Entity entity, Vector location)
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return true;
		}
		FTransformDouble ftransformDouble = this.GetTransform() ?? new FTransformDouble();
		FVectorDouble fvectorDouble = UKismetMathLibrary.D_TransformLocation(ftransformDouble, this.LeaveSphereCenter ?? new FVectorDouble());
		this.CacheLocation.DeepCopy(fvectorDouble);
		return Vector.DistSquared(location, this.CacheLocation) > this.LeaveSphereRadiusSq;
	}

	// Token: 0x0400E0C8 RID: 57544
	public FVectorDouble? LeaveSphereCenter;

	// Token: 0x0400E0C9 RID: 57545
	public double LeaveSphereRadiusSq;

	// Token: 0x0400E0CA RID: 57546
	protected readonly Vector CacheLocation = Vector.Create();
}
