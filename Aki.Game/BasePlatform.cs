using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02003269 RID: 12905
[NullableContext(1)]
[Nullable(0)]
public class BasePlatform
{
	// Token: 0x0601BE56 RID: 114262 RVA: 0x007BBE5D File Offset: 0x007BA05D
	public BasePlatform(EntityHandle entityHandle)
	{
		this.EntityHandle = entityHandle;
	}

	// Token: 0x0601BE57 RID: 114263 RVA: 0x007BBE6C File Offset: 0x007BA06C
	public virtual FTransformDouble? GetTransform()
	{
		return null;
	}

	// Token: 0x0601BE58 RID: 114264 RVA: 0x007BBE84 File Offset: 0x007BA084
	public virtual void TransformFromRelativeSpace(FVectorDouble inPosition, FRotator inRotation, ref FVectorDouble outPosition, ref FRotator outRotation)
	{
		FTransformDouble? transform = this.GetTransform();
		FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
		outPosition = UKismetMathLibrary.D_TransformLocation(ftransformDouble, inPosition);
		ftransformDouble = (transform ?? new FTransformDouble());
		outRotation = UKismetMathLibrary.D_TransformRotation(ftransformDouble, inRotation);
	}

	// Token: 0x0601BE59 RID: 114265 RVA: 0x007BBEEC File Offset: 0x007BA0EC
	public virtual void TransformToRelativeSpace(FVectorDouble inPosition, FRotator inRotation, ref FVectorDouble outPosition, ref FRotator outRotation)
	{
		FTransformDouble? transform = this.GetTransform();
		FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
		outPosition = UKismetMathLibrary.D_InverseTransformLocation(ftransformDouble, inPosition);
		ftransformDouble = (transform ?? new FTransformDouble());
		outRotation = UKismetMathLibrary.D_InverseTransformRotation(ftransformDouble, inRotation);
	}

	// Token: 0x0601BE5A RID: 114266 RVA: 0x007BBF51 File Offset: 0x007BA151
	public virtual bool CheckLeave(Entity entity, global::Vector location)
	{
		return false;
	}

	// Token: 0x0601BE5B RID: 114267 RVA: 0x007BBF54 File Offset: 0x007BA154
	public virtual void OnCharacterEnter(Entity entity, UCharacterMovementComponent characterMovement)
	{
	}

	// Token: 0x0601BE5C RID: 114268 RVA: 0x007BBF58 File Offset: 0x007BA158
	protected void RequestEnterOrLeave(bool isEnter)
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CH, "[BasePlatform.RequestEnterOrLeave] EntityHandle无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		VehiclePlatformGetOnRequest vehiclePlatformGetOnRequest = VehiclePlatformGetOnRequest.Create();
		long creatureDataId = this.EntityHandle.CreatureDataId;
		vehiclePlatformGetOnRequest.EntityId = creatureDataId;
		vehiclePlatformGetOnRequest.IsGetOn = isEnter;
		Net.Instance.Call(ERequestMessageId.VehiclePlatformGetOnRequest, vehiclePlatformGetOnRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x0400DC26 RID: 56358
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400DC27 RID: 56359
	public int CreatureDataId;

	// Token: 0x0400DC28 RID: 56360
	public bool IsDeltaBaseSpeedNeedZ;
}
