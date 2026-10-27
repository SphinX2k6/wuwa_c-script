using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x0200326A RID: 12906
[NullableContext(1)]
[Nullable(0)]
public class CharacterBasePlatform : BasePlatform
{
	// Token: 0x0601BE5D RID: 114269 RVA: 0x007BBFEC File Offset: 0x007BA1EC
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

	// Token: 0x0601BE5E RID: 114270 RVA: 0x007BC060 File Offset: 0x007BA260
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

	// Token: 0x0601BE5F RID: 114271 RVA: 0x007BC0E0 File Offset: 0x007BA2E0
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

	// Token: 0x0400DC29 RID: 56361
	public FVectorDouble? LeaveSphereCenter;

	// Token: 0x0400DC2A RID: 56362
	public double LeaveSphereRadiusSq;

	// Token: 0x0400DC2B RID: 56363
	protected readonly Vector CacheLocation = Vector.Create();
}
