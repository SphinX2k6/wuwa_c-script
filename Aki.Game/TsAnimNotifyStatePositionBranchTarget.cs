using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000153 RID: 339
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionBranchTarget.TsAnimNotifyStatePositionBranchTarget_C")]
public class TsAnimNotifyStatePositionBranchTarget : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600153B RID: 5435 RVA: 0x00077C53 File Offset: 0x00075E53
	static TsAnimNotifyStatePositionBranchTarget()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStatePositionBranchTarget.CreateStaticDefaultValue), new Action(TsAnimNotifyStatePositionBranchTarget.ResetStaticDefaultValue));
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00077C72 File Offset: 0x00075E72
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStatePositionBranchTarget._paramPool = new List<PositionBranchTargetParams>();
		TsAnimNotifyStatePositionBranchTarget._paramMap = new Dictionary<int, PositionBranchTargetParams>();
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00077C88 File Offset: 0x00075E88
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStatePositionBranchTarget._paramPool = null;
		TsAnimNotifyStatePositionBranchTarget._paramMap = null;
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x0600153E RID: 5438 RVA: 0x00077C96 File Offset: 0x00075E96
	// (set) Token: 0x0600153F RID: 5439 RVA: 0x00077CAA File Offset: 0x00075EAA
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat MoveCurve
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MoveCurve);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MoveCurve, value);
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06001540 RID: 5440 RVA: 0x00077CBF File Offset: 0x00075EBF
	// (set) Token: 0x06001541 RID: 5441 RVA: 0x00077CCF File Offset: 0x00075ECF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06001542 RID: 5442 RVA: 0x00077CE0 File Offset: 0x00075EE0
	// (set) Token: 0x06001543 RID: 5443 RVA: 0x00077CF0 File Offset: 0x00075EF0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x06001544 RID: 5444 RVA: 0x00077D01 File Offset: 0x00075F01
	// (set) Token: 0x06001545 RID: 5445 RVA: 0x00077D11 File Offset: 0x00075F11
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否永远面向目标
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_是否永远面向目标) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_是否永远面向目标) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06001546 RID: 5446 RVA: 0x00077D22 File Offset: 0x00075F22
	// (set) Token: 0x06001547 RID: 5447 RVA: 0x00077D32 File Offset: 0x00075F32
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 忽略Z轴方向
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略Z轴方向) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略Z轴方向) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06001548 RID: 5448 RVA: 0x00077D43 File Offset: 0x00075F43
	// (set) Token: 0x06001549 RID: 5449 RVA: 0x00077D53 File Offset: 0x00075F53
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 忽略水平方向
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略水平方向) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略水平方向) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x0600154A RID: 5450 RVA: 0x00077D64 File Offset: 0x00075F64
	// (set) Token: 0x0600154B RID: 5451 RVA: 0x00077D74 File Offset: 0x00075F74
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 永远修正Z轴
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_永远修正Z轴) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_永远修正Z轴) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x0600154C RID: 5452 RVA: 0x00077D85 File Offset: 0x00075F85
	// (set) Token: 0x0600154D RID: 5453 RVA: 0x00077D95 File Offset: 0x00075F95
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 忽略双方半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略双方半径) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略双方半径) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x0600154E RID: 5454 RVA: 0x00077DA6 File Offset: 0x00075FA6
	// (set) Token: 0x0600154F RID: 5455 RVA: 0x00077DB6 File Offset: 0x00075FB6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsShareTarget
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_IsShareTarget) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_IsShareTarget) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x06001550 RID: 5456 RVA: 0x00077DC7 File Offset: 0x00075FC7
	// (set) Token: 0x06001551 RID: 5457 RVA: 0x00077DDB File Offset: 0x00075FDB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector TargetOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetOffset) = value;
		}
	}

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06001552 RID: 5458 RVA: 0x00077DF0 File Offset: 0x00075FF0
	// (set) Token: 0x06001553 RID: 5459 RVA: 0x00077E04 File Offset: 0x00076004
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FRotator TargetRotation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetRotation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetRotation) = value;
		}
	}

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06001554 RID: 5460 RVA: 0x00077E19 File Offset: 0x00076019
	// (set) Token: 0x06001555 RID: 5461 RVA: 0x00077E29 File Offset: 0x00076029
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OffsetByOrientation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByOrientation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByOrientation) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06001556 RID: 5462 RVA: 0x00077E3A File Offset: 0x0007603A
	// (set) Token: 0x06001557 RID: 5463 RVA: 0x00077E4A File Offset: 0x0007604A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OffsetByAbsolute
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByAbsolute) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByAbsolute) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x06001558 RID: 5464 RVA: 0x00077E5B File Offset: 0x0007605B
	// (set) Token: 0x06001559 RID: 5465 RVA: 0x00077E6B File Offset: 0x0007606B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinHeightFromTargetFloor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MinHeightFromTargetFloor);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MinHeightFromTargetFloor) = value;
		}
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x0600155A RID: 5466 RVA: 0x00077E7C File Offset: 0x0007607C
	// (set) Token: 0x0600155B RID: 5467 RVA: 0x00077E8C File Offset: 0x0007608C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 允许反向移动
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许反向移动) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许反向移动) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x0600155C RID: 5468 RVA: 0x00077E9D File Offset: 0x0007609D
	// (set) Token: 0x0600155D RID: 5469 RVA: 0x00077EAD File Offset: 0x000760AD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 允许正向移动
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许正向移动) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许正向移动) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000382 RID: 898
	// (get) Token: 0x0600155E RID: 5470 RVA: 0x00077EBE File Offset: 0x000760BE
	// (set) Token: 0x0600155F RID: 5471 RVA: 0x00077ECE File Offset: 0x000760CE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnsBranchTargetBlackboardType 黑板类型
	{
		get
		{
			return (EAnsBranchTargetBlackboardType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板类型) = (byte)value;
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06001560 RID: 5472 RVA: 0x00077EDF File Offset: 0x000760DF
	// (set) Token: 0x06001561 RID: 5473 RVA: 0x00077EF3 File Offset: 0x000760F3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 黑板值
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板值)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板值)), value);
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06001562 RID: 5474 RVA: 0x00077F08 File Offset: 0x00076108
	// (set) Token: 0x06001563 RID: 5475 RVA: 0x00077F1C File Offset: 0x0007611C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 黑板目标Socket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板目标Socket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板目标Socket)), value);
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06001564 RID: 5476 RVA: 0x00077F31 File Offset: 0x00076131
	// (set) Token: 0x06001565 RID: 5477 RVA: 0x00077F41 File Offset: 0x00076141
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最小吸附距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最小吸附距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最小吸附距离) = value;
		}
	}

	// Token: 0x17000386 RID: 902
	// (get) Token: 0x06001566 RID: 5478 RVA: 0x00077F52 File Offset: 0x00076152
	// (set) Token: 0x06001567 RID: 5479 RVA: 0x00077F62 File Offset: 0x00076162
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最大吸附距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最大吸附距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最大吸附距离) = value;
		}
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x00077F74 File Offset: 0x00076174
	private void Initialize()
	{
		if (this.IsInitialize && !GlobalData.IsPlayInEditor)
		{
			return;
		}
		this.IsInitialize = true;
		this.TsMoveCurve = this.MoveCurve;
		this.TsDistance = this.Distance;
		this.TsMaxDistance = this.最大吸附距离;
		this.TsMinDistance = this.最小吸附距离;
		this.TsMaxSpeed = this.MaxSpeed;
		this.TsLookAtTarget = this.是否永远面向目标;
		this.TsIgnoreZ = this.忽略Z轴方向;
		this.TsIgnoreHorizontal = this.忽略水平方向;
		this.TsAlwaysMoveZ = this.永远修正Z轴;
		this.TsIgnoreRadius = this.忽略双方半径;
		this.TsIsShareTarget = this.IsShareTarget;
		this.TsAllowReverseMovement = this.允许反向移动;
		this.TsAllowForwardMovement = this.允许正向移动;
		this.TsBlackboardKey = this.黑板值;
		this.TsBlackboardType = this.黑板类型;
		this.TsBlackboardSocket = this.黑板目标Socket;
		this.TsTargetOffset = Vector.Create(this.TargetOffset);
		this.TmpRotator = Rotator.Create();
		Rotator tmpRotator = this.TmpRotator;
		FRotator targetRotation = this.TargetRotation;
		tmpRotator.DeepCopy(targetRotation);
		this.TmpQuat.Reset();
		this.TmpRotator.Quaternion(this.TmpQuat);
		this.TmpQuat.RotateVector(this.TsTargetOffset, this.TsTargetOffset);
		this.TsMinHeightFromTargetFloor = this.MinHeightFromTargetFloor;
		this.TargetPos.Reset();
		this.TmpVector.Reset();
		this.TmpVector2.Reset();
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x000780F0 File Offset: 0x000762F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionBranchTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStatePositionBranchTarget.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x000781B0 File Offset: 0x000763B0
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Initialize();
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter) && !(owner is TsBaseVehicle))
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		object obj;
		if (tsBaseCharacter == null)
		{
			obj = null;
		}
		else
		{
			Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
			obj = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseActorComponent>() : null);
		}
		object obj2;
		if ((obj2 = obj) == null)
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle == null)
			{
				obj2 = null;
			}
			else
			{
				Entity entityNoBlueprint2 = tsBaseVehicle.GetEntityNoBlueprint();
				obj2 = ((entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<BaseActorComponent>() : null);
			}
		}
		BaseActorComponent baseActorComponent = obj2;
		if (baseActorComponent == null)
		{
			return false;
		}
		BaseSkillComponent component = baseActorComponent.Entity.GetComponent<BaseSkillComponent>();
		BaseSkillComponent baseSkillComponent;
		if (this.TsIsShareTarget)
		{
			CreatureDataComponent component2 = baseActorComponent.Entity.GetComponent<CreatureDataComponent>();
			EntityHandle entity = CreatureModel.Instance.GetEntity(component2.GetSummonerId());
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			baseSkillComponent = ((worldEntity != null) ? worldEntity.GetComponent<BaseSkillComponent>() : null);
			if (baseSkillComponent == null)
			{
				baseSkillComponent = component;
			}
		}
		else
		{
			baseSkillComponent = component;
		}
		if (baseSkillComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "No SkillComponent";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", baseActorComponent.Owner);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (TsAnimNotifyStatePositionBranchTarget._paramPool == null || TsAnimNotifyStatePositionBranchTarget._paramMap == null)
		{
			return false;
		}
		PositionBranchTargetParams positionBranchTargetParams;
		if (!TsAnimNotifyStatePositionBranchTarget._paramMap.TryGetValue(baseActorComponent.Entity.Id, out positionBranchTargetParams) || positionBranchTargetParams == null)
		{
			if (TsAnimNotifyStatePositionBranchTarget._paramPool.Count > 0)
			{
				positionBranchTargetParams = TsAnimNotifyStatePositionBranchTarget._paramPool[TsAnimNotifyStatePositionBranchTarget._paramPool.Count - 1];
				TsAnimNotifyStatePositionBranchTarget._paramPool.RemoveAt(TsAnimNotifyStatePositionBranchTarget._paramPool.Count - 1);
			}
			else
			{
				positionBranchTargetParams = new PositionBranchTargetParams();
			}
		}
		positionBranchTargetParams.BaseActorComp = baseActorComponent;
		positionBranchTargetParams.BaseUnifiedComp = baseActorComponent.Entity.GetComponent<BaseUnifiedStateComponent>();
		positionBranchTargetParams.BaseSkillComp = baseSkillComponent;
		positionBranchTargetParams.NowTime = 0f;
		positionBranchTargetParams.TotalTime = totalDuration;
		if (!positionBranchTargetParams.RefreshTarget(this.TsBlackboardKey, this.TsBlackboardType, this.TsBlackboardSocket))
		{
			return true;
		}
		TsBaseCharacter tsBaseCharacter2 = owner as TsBaseCharacter;
		int key = (tsBaseCharacter2 != null) ? tsBaseCharacter2.GetEntityIdNoBlueprint() : (owner as TsBaseVehicle).GetEntityIdNoBlueprint();
		TsAnimNotifyStatePositionBranchTarget._paramMap[key] = positionBranchTargetParams;
		return true;
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x000783A0 File Offset: 0x000765A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionBranchTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStatePositionBranchTarget.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x00078460 File Offset: 0x00076660
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if ((double)frameDeltaTime < 0.0001)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
		if (tsBaseCharacter == null && tsBaseVehicle == null)
		{
			return false;
		}
		int key = (tsBaseCharacter != null) ? tsBaseCharacter.GetEntityIdNoBlueprint() : tsBaseVehicle.GetEntityIdNoBlueprint();
		if (TsAnimNotifyStatePositionBranchTarget._paramMap == null)
		{
			return false;
		}
		PositionBranchTargetParams positionBranchTargetParams;
		if (!TsAnimNotifyStatePositionBranchTarget._paramMap.TryGetValue(key, out positionBranchTargetParams) || positionBranchTargetParams == null)
		{
			return false;
		}
		if (positionBranchTargetParams.RefreshTarget(this.TsBlackboardKey, this.TsBlackboardType, this.TsBlackboardSocket))
		{
			this.MoveToTarget(frameDeltaTime, positionBranchTargetParams);
			positionBranchTargetParams.LastLocation.DeepCopy(positionBranchTargetParams.BaseActorComp.ActorLocationProxy);
		}
		positionBranchTargetParams.NowTime += frameDeltaTime;
		return true;
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x00078510 File Offset: 0x00076710
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionBranchTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStatePositionBranchTarget.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x000785C8 File Offset: 0x000767C8
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (TsAnimNotifyStatePositionBranchTarget._paramPool == null || TsAnimNotifyStatePositionBranchTarget._paramMap == null)
		{
			return false;
		}
		PositionBranchTargetParams positionBranchTargetParams;
		if (!TsAnimNotifyStatePositionBranchTarget._paramMap.TryGetValue(characterActorComponent.Entity.Id, out positionBranchTargetParams) || positionBranchTargetParams == null)
		{
			return false;
		}
		TsAnimNotifyStatePositionBranchTarget._paramMap.Remove(characterActorComponent.Entity.Id);
		positionBranchTargetParams.Clear();
		TsAnimNotifyStatePositionBranchTarget._paramPool.Add(positionBranchTargetParams);
		return true;
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x00078644 File Offset: 0x00076844
	private void GetTargetPos(PositionBranchTargetParams @params, Vector outVector)
	{
		if (@params.TargetPos != null)
		{
			outVector.DeepCopy(@params.TargetPos);
			if (this.OffsetByAbsolute)
			{
				this.TmpVector.DeepCopy(this.TsTargetOffset);
			}
			else
			{
				if (this.OffsetByOrientation)
				{
					outVector.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
				}
				else
				{
					@params.BaseActorComp.ActorLocationProxy.Subtraction(outVector, this.TmpVector);
				}
				this.TmpVector.ToOrientationQuat(this.TmpQuat);
				this.TmpQuat.RotateVector(this.TsTargetOffset, this.TmpVector);
			}
			outVector.AdditionEqual(this.TmpVector);
			return;
		}
		if (!string.IsNullOrEmpty(@params.SocketName))
		{
			CharacterActorComponent targetCharActorComp = @params.TargetCharActorComp;
			if (((targetCharActorComp != null) ? targetCharActorComp.Actor : null) != null)
			{
				FName inSocketName = FNameUtil.GetDynamicFName(@params.SocketName) ?? FName.NAME_None;
				FVectorDouble fvectorDouble = @params.TargetCharActorComp.Actor.Mesh.D_GetSocketLocation(inSocketName);
				outVector.FromUeVector(fvectorDouble);
			}
			else
			{
				outVector.DeepCopy(@params.TargetBaseActorComp.ActorLocationProxy);
			}
		}
		else
		{
			outVector.DeepCopy(@params.TargetBaseActorComp.ActorLocationProxy);
		}
		if (this.OffsetByAbsolute)
		{
			this.TmpVector.DeepCopy(this.TsTargetOffset);
		}
		else if (this.OffsetByOrientation)
		{
			outVector.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
			this.TmpVector.ToOrientationQuat(this.TmpQuat);
			this.TmpQuat.RotateVector(this.TsTargetOffset, this.TmpVector);
		}
		else
		{
			@params.TargetBaseActorComp.ActorQuatProxy.RotateVector(this.TsTargetOffset, this.TmpVector);
		}
		outVector.AdditionEqual(this.TmpVector);
		if (@params.TargetCharActorComp != null)
		{
			double num = GravityUtils.Instance.GetZnInGravityForActor(@params.TargetBaseActorComp, @params.TargetCharActorComp.FloorLocation) + (double)this.TsMinHeightFromTargetFloor;
			double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(@params.TargetBaseActorComp, outVector);
			if (num > znInGravityForActor)
			{
				GravityUtils.Instance.AddZnInGravityForActor(@params.TargetBaseActorComp, outVector, num - znInGravityForActor);
			}
		}
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x00078864 File Offset: 0x00076A64
	private double GetTowardVector(PositionBranchTargetParams @params, Vector outVector)
	{
		this.GetTargetPos(@params, this.TargetPos);
		this.TargetPos.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
		this.TargetPos.Subtraction(@params.LastLocation, this.TmpVector2);
		double num = this.TmpVector.DotProduct(this.TmpVector2);
		outVector.DeepCopy(this.TmpVector);
		if (this.TsIgnoreZ)
		{
			GravityUtils.Instance.ConvertToPlanarVectorForActor(@params.BaseActorComp, outVector);
			if (num >= 0.0)
			{
				return outVector.Size();
			}
			return -1.0;
		}
		else if (this.TsIgnoreHorizontal)
		{
			GravityUtils.Instance.ConvertToVerticalVectorForActor(@params.BaseActorComp, outVector);
			if (num >= 0.0)
			{
				return outVector.Size();
			}
			return -1.0;
		}
		else
		{
			if (num >= 0.0)
			{
				return Math.Sqrt(GravityUtils.Instance.GetPlanarSizeSquared2dForActor(@params.BaseActorComp, outVector));
			}
			return -1.0;
		}
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x0007896C File Offset: 0x00076B6C
	private double GetRate(float delta, PositionBranchTargetParams @params)
	{
		float num = @params.NowTime + delta;
		double result;
		if (@params.TotalTime <= num)
		{
			result = 1.0;
		}
		else if (this.TsMoveCurve != null)
		{
			float floatValue = this.TsMoveCurve.GetFloatValue(@params.NowTime / @params.TotalTime);
			float floatValue2 = this.TsMoveCurve.GetFloatValue(num / @params.TotalTime);
			if (floatValue >= 1f)
			{
				return 0.0;
			}
			result = (double)((floatValue2 - floatValue) / (1f - floatValue));
		}
		else
		{
			double cubicValue = MathUtils.Instance.GetCubicValue((double)(@params.NowTime / @params.TotalTime));
			double cubicValue2 = MathUtils.Instance.GetCubicValue((double)(num / @params.TotalTime));
			if (cubicValue >= 1.0)
			{
				return 0.0;
			}
			result = (cubicValue2 - cubicValue) / (1.0 - cubicValue);
		}
		return result;
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x00078A54 File Offset: 0x00076C54
	private unsafe void MoveToTarget(float delta, PositionBranchTargetParams @params)
	{
		double towardVector = this.GetTowardVector(@params, this.TmpVector);
		if (this.TsMinDistance > 0f && towardVector < (double)this.TsMinDistance)
		{
			return;
		}
		if (this.TsMaxDistance > 0f && towardVector > (double)this.TsMaxDistance)
		{
			return;
		}
		double num = (double)this.TsDistance;
		if (!this.TsIgnoreRadius)
		{
			num += (double)@params.BaseActorComp.ScaledRadius;
			if (@params.TargetCharActorComp != null && string.IsNullOrEmpty(@params.SocketName))
			{
				num += (double)@params.TargetCharActorComp.ScaledRadius;
			}
		}
		if (towardVector > 0.0001 && ((num < towardVector && this.TsAllowForwardMovement) || (num > towardVector && this.TsAllowReverseMovement)))
		{
			if (this.TsMaxSpeed <= 0f)
			{
				return;
			}
			double rate = this.GetRate(delta, @params);
			if (rate <= 0.0)
			{
				return;
			}
			double num2 = this.TmpVector.Size();
			double num3 = MathUtils.Instance.Clamp((num2 - num) * rate, (double)(-(double)this.TsMaxSpeed * delta), (double)(this.TsMaxSpeed * delta));
			this.TmpVector.MultiplyEqual(num3 / num2);
		}
		else
		{
			@params.LastLocation.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
			if (this.TsAlwaysMoveZ && !this.TsIgnoreZ)
			{
				double rate2 = this.GetRate(delta, @params);
				this.TargetPos.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector2);
				double newZ = MathUtils.Instance.Clamp(GravityUtils.Instance.GetZnInGravityForActor(@params.BaseActorComp, this.TmpVector2) * rate2, (double)(-(double)this.TsMaxSpeed * delta), (double)(this.TsMaxSpeed * delta));
				GravityUtils.Instance.SetZnInGravityForActor(@params.BaseActorComp, this.TmpVector, newZ);
			}
			else
			{
				GravityUtils.Instance.ConvertToPlanarVectorForActor(@params.BaseActorComp, this.TmpVector);
			}
			if (this.TmpVector.SizeSquared() > 4000000.0)
			{
				this.TmpVector.Reset();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "LastLocation太远，很危险，无视掉";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "Actor";
				BaseActorComponent baseActorComp = @params.BaseActorComp;
				ptr = new ValueTuple<string, object>(item, (baseActorComp != null) ? baseActorComp.Owner : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Last", @params.LastLocation);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "ActorLast";
				BaseActorComponent baseActorComp2 = @params.BaseActorComp;
				ptr2 = new ValueTuple<string, object>(item2, (baseActorComp2 != null) ? baseActorComp2.LastActorLocation : null);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
				string item3 = "Now";
				BaseActorComponent baseActorComp3 = @params.BaseActorComp;
				ptr3 = new ValueTuple<string, object>(item3, (baseActorComp3 != null) ? baseActorComp3.ActorLocationProxy : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}
		BaseActorComponent baseActorComp4 = @params.BaseActorComp;
		BaseMoveComponent baseMoveComponent = (baseActorComp4 != null) ? baseActorComp4.MoveComp : null;
		if (baseMoveComponent != null)
		{
			baseMoveComponent.MoveCharacter(this.TmpVector, delta, "TsAnimNotifyStatePositionBranchTarget");
			if (this.TsLookAtTarget)
			{
				this.TargetPos.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
				Vector gravityUp = baseMoveComponent.GravityUp;
				MathUtils.Instance.LookRotationUpFirst(this.TmpVector, gravityUp, this.TmpQuat);
				this.TmpQuat.Rotator(this.TmpRotator);
				@params.BaseActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "TsAnimNotifyStatePositionBranchTarget", false);
				return;
			}
		}
		else
		{
			this.TmpVector.AdditionEqual(@params.BaseActorComp.ActorLocationProxy);
			if (this.TsLookAtTarget)
			{
				BaseActorComponent baseActorComp5 = @params.BaseActorComp;
				Vector vector;
				if (baseActorComp5 == null)
				{
					vector = null;
				}
				else
				{
					VehicleMoveComponent vehicleMoveComp = baseActorComp5.VehicleMoveComp;
					vector = ((vehicleMoveComp != null) ? vehicleMoveComp.GravityUp : null);
				}
				Vector up = vector ?? Vector.UpVectorProxy;
				MathUtils.Instance.LookRotationUpFirst(this.TmpVector, up, this.TmpQuat);
				this.TmpQuat.Rotator(this.TmpRotator);
				BaseActorComponent baseActorComp6 = @params.BaseActorComp;
				if (baseActorComp6 == null)
				{
					return;
				}
				baseActorComp6.SetActorLocationAndRotation(this.TmpVector.ToUeVector(false), this.TmpRotator.ToUeRotator(), "TsAnimNotifyStatePositionBranchTarget", true, null);
				return;
			}
			else
			{
				BaseActorComponent baseActorComp7 = @params.BaseActorComp;
				if (baseActorComp7 == null)
				{
					return;
				}
				baseActorComp7.SetActorLocation(this.TmpVector.ToUeVector(false), "TsAnimNotifyStatePositionBranchTarget", true);
			}
		}
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x00078E90 File Offset: 0x00077090
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionBranchTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStatePositionBranchTarget.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00078F20 File Offset: 0x00077120
	protected override string GetNotifyName_Implementation()
	{
		return "位移吸附到目标位置";
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x00078F27 File Offset: 0x00077127
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStatePositionBranchTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionBranchTarget.TsAnimNotifyStatePositionBranchTarget_C");
		}
		return TsAnimNotifyStatePositionBranchTarget._ClassPtr;
	}

	// Token: 0x06001576 RID: 5494 RVA: 0x00078F4C File Offset: 0x0007714C
	public TsAnimNotifyStatePositionBranchTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionBranchTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x00078F74 File Offset: 0x00077174
	public TsAnimNotifyStatePositionBranchTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionBranchTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00078FA8 File Offset: 0x000771A8
	protected TsAnimNotifyStatePositionBranchTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00079040 File Offset: 0x00077240
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x0007907C File Offset: 0x0007727C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x000790B8 File Offset: 0x000772B8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x000790EB File Offset: 0x000772EB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EF2 RID: 3826
	private const double INVALID_LAST_LOCATION_THRESHOLD_SQUARED = 4000000.0;

	// Token: 0x04000EF3 RID: 3827
	private bool IsInitialize;

	// Token: 0x04000EF4 RID: 3828
	[Nullable(2)]
	private UCurveFloat TsMoveCurve;

	// Token: 0x04000EF5 RID: 3829
	private float TsDistance;

	// Token: 0x04000EF6 RID: 3830
	private float TsMaxDistance;

	// Token: 0x04000EF7 RID: 3831
	private float TsMinDistance;

	// Token: 0x04000EF8 RID: 3832
	private float TsMaxSpeed;

	// Token: 0x04000EF9 RID: 3833
	private bool TsLookAtTarget;

	// Token: 0x04000EFA RID: 3834
	private bool TsIgnoreZ;

	// Token: 0x04000EFB RID: 3835
	private bool TsIgnoreHorizontal;

	// Token: 0x04000EFC RID: 3836
	private bool TsAlwaysMoveZ;

	// Token: 0x04000EFD RID: 3837
	private bool TsIgnoreRadius;

	// Token: 0x04000EFE RID: 3838
	private bool TsIsShareTarget;

	// Token: 0x04000EFF RID: 3839
	private Vector TsTargetOffset = Vector.Create();

	// Token: 0x04000F00 RID: 3840
	private float TsMinHeightFromTargetFloor;

	// Token: 0x04000F01 RID: 3841
	private readonly Vector TargetPos = Vector.Create();

	// Token: 0x04000F02 RID: 3842
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04000F03 RID: 3843
	private readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000F04 RID: 3844
	private Rotator TmpRotator = Rotator.Create();

	// Token: 0x04000F05 RID: 3845
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F06 RID: 3846
	private bool TsAllowReverseMovement;

	// Token: 0x04000F07 RID: 3847
	private bool TsAllowForwardMovement = true;

	// Token: 0x04000F08 RID: 3848
	private string TsBlackboardKey = "";

	// Token: 0x04000F09 RID: 3849
	private string TsBlackboardSocket = "";

	// Token: 0x04000F0A RID: 3850
	private EAnsBranchTargetBlackboardType TsBlackboardType;

	// Token: 0x04000F0B RID: 3851
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<PositionBranchTargetParams> _paramPool;

	// Token: 0x04000F0C RID: 3852
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, PositionBranchTargetParams> _paramMap;

	// Token: 0x04000F0D RID: 3853
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionBranchTarget.TsAnimNotifyStatePositionBranchTarget_C";

	// Token: 0x04000F0E RID: 3854
	private static IntPtr _ClassPtr;

	// Token: 0x04000F0F RID: 3855
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F10 RID: 3856
	private static int __PropertyOffset_MoveCurve;

	// Token: 0x04000F11 RID: 3857
	private static int __PropertyOffset_Distance;

	// Token: 0x04000F12 RID: 3858
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000F13 RID: 3859
	private static int __PropertyOffset_是否永远面向目标;

	// Token: 0x04000F14 RID: 3860
	private static int __PropertyOffset_忽略Z轴方向;

	// Token: 0x04000F15 RID: 3861
	private static int __PropertyOffset_忽略水平方向;

	// Token: 0x04000F16 RID: 3862
	private static int __PropertyOffset_永远修正Z轴;

	// Token: 0x04000F17 RID: 3863
	private static int __PropertyOffset_忽略双方半径;

	// Token: 0x04000F18 RID: 3864
	private static int __PropertyOffset_IsShareTarget;

	// Token: 0x04000F19 RID: 3865
	private static int __PropertyOffset_TargetOffset;

	// Token: 0x04000F1A RID: 3866
	private static int __PropertyOffset_TargetRotation;

	// Token: 0x04000F1B RID: 3867
	private static int __PropertyOffset_OffsetByOrientation;

	// Token: 0x04000F1C RID: 3868
	private static int __PropertyOffset_OffsetByAbsolute;

	// Token: 0x04000F1D RID: 3869
	private static int __PropertyOffset_MinHeightFromTargetFloor;

	// Token: 0x04000F1E RID: 3870
	private static int __PropertyOffset_允许反向移动;

	// Token: 0x04000F1F RID: 3871
	private static int __PropertyOffset_允许正向移动;

	// Token: 0x04000F20 RID: 3872
	private static int __PropertyOffset_黑板类型;

	// Token: 0x04000F21 RID: 3873
	private static int __PropertyOffset_黑板值;

	// Token: 0x04000F22 RID: 3874
	private static int __PropertyOffset_黑板目标Socket;

	// Token: 0x04000F23 RID: 3875
	private static int __PropertyOffset_最小吸附距离;

	// Token: 0x04000F24 RID: 3876
	private static int __PropertyOffset_最大吸附距离;
}
