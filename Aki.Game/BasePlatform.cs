using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020027D8 RID: 10200
[NullableContext(1)]
[Nullable(0)]
public class BasePlatform
{
	// Token: 0x06019A31 RID: 105009 RVA: 0x007E3735 File Offset: 0x007E1935
	public BasePlatform(EntityHandle entityHandle)
	{
		this.EntityHandle = entityHandle;
	}

	// Token: 0x06019A32 RID: 105010 RVA: 0x007E3744 File Offset: 0x007E1944
	public virtual FTransformDouble? GetTransform()
	{
		return null;
	}

	// Token: 0x06019A33 RID: 105011 RVA: 0x007E375C File Offset: 0x007E195C
	public virtual void TransformFromRelativeSpace(FVectorDouble inPosition, FRotator inRotation, ref FVectorDouble outPosition, ref FRotator outRotation)
	{
		FTransformDouble? transform = this.GetTransform();
		FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
		outPosition = UKismetMathLibrary.D_TransformLocation(ftransformDouble, inPosition);
		ftransformDouble = (transform ?? new FTransformDouble());
		outRotation = UKismetMathLibrary.D_TransformRotation(ftransformDouble, inRotation);
	}

	// Token: 0x06019A34 RID: 105012 RVA: 0x007E37C4 File Offset: 0x007E19C4
	public virtual void TransformToRelativeSpace(FVectorDouble inPosition, FRotator inRotation, ref FVectorDouble outPosition, ref FRotator outRotation)
	{
		FTransformDouble? transform = this.GetTransform();
		FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
		outPosition = UKismetMathLibrary.D_InverseTransformLocation(ftransformDouble, inPosition);
		ftransformDouble = (transform ?? new FTransformDouble());
		outRotation = UKismetMathLibrary.D_InverseTransformRotation(ftransformDouble, inRotation);
	}

	// Token: 0x06019A35 RID: 105013 RVA: 0x007E3829 File Offset: 0x007E1A29
	public virtual bool CheckLeave(Entity entity, global::Vector location)
	{
		return false;
	}

	// Token: 0x06019A36 RID: 105014 RVA: 0x007E382C File Offset: 0x007E1A2C
	public virtual void OnCharacterEnter(Entity entity, UCharacterMovementComponent characterMovement)
	{
	}

	// Token: 0x06019A37 RID: 105015 RVA: 0x007E3830 File Offset: 0x007E1A30
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

	// Token: 0x0400E0C5 RID: 57541
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400E0C6 RID: 57542
	public int CreatureDataId;

	// Token: 0x0400E0C7 RID: 57543
	public bool IsDeltaBaseSpeedNeedZ;
}
