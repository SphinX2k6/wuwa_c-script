using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000140 RID: 320
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateJumpLandDetect.TsAnimNotifyStateJumpLandDetect_C")]
public class TsAnimNotifyStateJumpLandDetect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700032D RID: 813
	// (get) Token: 0x0600138A RID: 5002 RVA: 0x0006D8EC File Offset: 0x0006BAEC
	// (set) Token: 0x0600138B RID: 5003 RVA: 0x0006D8FC File Offset: 0x0006BAFC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxHeightOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_MaxHeightOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_MaxHeightOffset) = value;
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x0600138C RID: 5004 RVA: 0x0006D90D File Offset: 0x0006BB0D
	// (set) Token: 0x0600138D RID: 5005 RVA: 0x0006D91D File Offset: 0x0006BB1D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OnlyDown
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_OnlyDown) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_OnlyDown) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x0600138E RID: 5006 RVA: 0x0006D92E File Offset: 0x0006BB2E
	// (set) Token: 0x0600138F RID: 5007 RVA: 0x0006D942 File Offset: 0x0006BB42
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName IgnoreActorTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_IgnoreActorTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_IgnoreActorTag) = value;
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x06001390 RID: 5008 RVA: 0x0006D957 File Offset: 0x0006BB57
	// (set) Token: 0x06001391 RID: 5009 RVA: 0x0006D967 File Offset: 0x0006BB67
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_DebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x06001392 RID: 5010 RVA: 0x0006D978 File Offset: 0x0006BB78
	// (set) Token: 0x06001393 RID: 5011 RVA: 0x0006D988 File Offset: 0x0006BB88
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndPointHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_EndPointHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_EndPointHeight) = value;
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x06001394 RID: 5012 RVA: 0x0006D999 File Offset: 0x0006BB99
	// (set) Token: 0x06001395 RID: 5013 RVA: 0x0006D9A9 File Offset: 0x0006BBA9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableGoThrough
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_EnableGoThrough) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateJumpLandDetect.__PropertyOffset_EnableGoThrough) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x0006D9BC File Offset: 0x0006BBBC
	private void Init()
	{
		if (this.TsInited && this.ParamsMap != null)
		{
			return;
		}
		this.TsInited = true;
		this.TmpVector = Vector.Create();
		this.TmpVector2 = Vector.Create();
		this.TmpRotator = Rotator.Create();
		this.OwnerTransform = Transform.Create();
		this.ParamsMap = new Dictionary<int, JumpLandDetectParams>();
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x0006DA18 File Offset: 0x0006BC18
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x0006DAC0 File Offset: 0x0006BCC0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		this.Init();
		int entityIdNoBlueprint = tsBaseCharacter.GetEntityIdNoBlueprint();
		JumpLandDetectParams jumpLandDetectParams;
		if (!this.ParamsMap.TryGetValue(entityIdNoBlueprint, out jumpLandDetectParams))
		{
			jumpLandDetectParams = new JumpLandDetectParams();
			this.ParamsMap[entityIdNoBlueprint] = jumpLandDetectParams;
		}
		jumpLandDetectParams.Entity = tsBaseCharacter.GetEntityNoBlueprint();
		Entity entity = jumpLandDetectParams.Entity;
		CharacterMoveComponent characterMoveComponent = (entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null;
		if (this.EnableGoThrough && characterMoveComponent != null && characterMoveComponent.IsKuroPlanarPhysWalkingEnable)
		{
			characterMoveComponent.CharacterMovement.GoThroughLower = true;
			characterMoveComponent.CharacterMovement.GoThroughPriority = 0;
			jumpLandDetectParams.SetGoThrough = true;
		}
		else
		{
			jumpLandDetectParams.SetGoThrough = false;
		}
		Vector vector = Vector.Create();
		Vector vector2 = Vector.Create();
		Vector vector3 = Vector.Create();
		Vector vector4 = Vector.Create();
		UAnimInstance animInstance = meshComp.GetAnimInstance();
		Transform ownerTransform = this.OwnerTransform;
		FTransformDouble ftransformDouble = tsBaseCharacter.D_GetTransform();
		ownerTransform.FromUeTransform(ftransformDouble);
		this.GetCurveLocation(animInstance, 0f, this.TmpVector);
		this.GetCurveRotator(animInstance, 0f, this.TmpRotator);
		this.GetCurveLocation(animInstance, totalDuration, this.TmpVector2);
		MathUtils.Instance.InverseTransformPositionNoScale(this.TmpVector, this.TmpRotator, this.TmpVector2, this.TmpVector2);
		this.TmpVector2.Z -= (double)this.EndPointHeight;
		this.OwnerTransform.TransformPosition(this.TmpVector2, this.TmpVector2);
		Vector vector5 = Vector.Create();
		this.OwnerTransform.GetRotation().RotateVector(Vector.UpVectorProxy, vector5);
		vector5.Multiply((double)this.MaxHeightOffset, vector2);
		float scaledCapsuleRadius = tsBaseCharacter.CapsuleComponent.GetScaledCapsuleRadius();
		vector5.MultiplyEqual((double)(tsBaseCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight() - scaledCapsuleRadius));
		this.TmpVector2.Subtraction(vector5, vector);
		if (this.OnlyDown)
		{
			vector3.DeepCopy(vector);
		}
		else
		{
			vector.Addition(vector2, vector3);
		}
		vector.Subtraction(vector2, vector4);
		TArray<FHitResult> tarray = new TArray<FHitResult>();
		TArray<AActor> tarray2 = new TArray<AActor>();
		UKismetSystemLibrary.D_SphereTraceMulti(tsBaseCharacter, vector3.ToUeVector(false), vector4.ToUeVector(false), scaledCapsuleRadius, KuroTraceTypeQuery.IkGround, false, tarray2, this.DebugDraw ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None, ref tarray, true, new FLinearColor?(this.TraceColorRed), new FLinearColor?(this.TraceColorGreen), 5f);
		int num = tarray.Num();
		jumpLandDetectParams.TotalTime = 0f;
		jumpLandDetectParams.NowTime = 0f;
		int i = 0;
		while (i < num)
		{
			FHitResult fhitResult = tarray.Get(i);
			if (fhitResult.bBlockingHit)
			{
				AActor inActor = fhitResult.Actor;
				FName ignoreActorTag = this.IgnoreActorTag;
				if (!UKuroCollisionLibrary.ActorHasTag(inActor, ignoreActorTag, fhitResult.Item) && tsBaseCharacter.CharacterMovement.IsWalkable(fhitResult))
				{
					Vector.Create(fhitResult.Location).Subtraction(vector, jumpLandDetectParams.HeightOffset);
					jumpLandDetectParams.TotalTime = totalDuration;
					return true;
				}
				return false;
			}
			else
			{
				i++;
			}
		}
		return true;
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x0006DDB4 File Offset: 0x0006BFB4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x0006DE54 File Offset: 0x0006C054
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		int entityIdNoBlueprint = tsBaseCharacter.GetEntityIdNoBlueprint();
		JumpLandDetectParams jumpLandDetectParams;
		if (!this.ParamsMap.TryGetValue(entityIdNoBlueprint, out jumpLandDetectParams))
		{
			return false;
		}
		this.ParamsMap.Remove(entityIdNoBlueprint);
		if (jumpLandDetectParams.SetGoThrough)
		{
			tsBaseCharacter.CharacterMovement.GoThroughLower = false;
			Entity entity = jumpLandDetectParams.Entity;
			if (entity != null)
			{
				BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
				if (component != null)
				{
					component.ResetHitPriorityAndGoThrough();
				}
			}
		}
		Entity entity2 = jumpLandDetectParams.Entity;
		CharacterUnifiedStateComponent characterUnifiedStateComponent = (entity2 != null) ? entity2.GetComponent<CharacterUnifiedStateComponent>() : null;
		if (characterUnifiedStateComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "JumpLandDetect No Unified";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", tsBaseCharacter);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (jumpLandDetectParams.NowTime <= jumpLandDetectParams.TotalTime && characterUnifiedStateComponent.PositionState == ECharPositionState.Air && jumpLandDetectParams.TotalTime > 0f)
		{
			float offsetRate = (jumpLandDetectParams.TotalTime - jumpLandDetectParams.NowTime) / jumpLandDetectParams.TotalTime;
			this.Move(animation, jumpLandDetectParams, offsetRate);
		}
		if ((double)base.CurrentTimeLength >= (double)jumpLandDetectParams.TotalTime - 0.0001 && this.EndPointHeight <= 0f)
		{
			this.TrySetMovementMode(tsBaseCharacter);
		}
		return true;
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x0006DF7C File Offset: 0x0006C17C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x0006E024 File Offset: 0x0006C224
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		int entityIdNoBlueprint = tsBaseCharacter.GetEntityIdNoBlueprint();
		JumpLandDetectParams jumpLandDetectParams;
		if (!this.ParamsMap.TryGetValue(entityIdNoBlueprint, out jumpLandDetectParams))
		{
			return false;
		}
		if (jumpLandDetectParams.Entity.GetComponent<CharacterUnifiedStateComponent>().PositionState == ECharPositionState.Ground)
		{
			jumpLandDetectParams.TotalTime -= frameDeltaTime;
		}
		else if (jumpLandDetectParams.NowTime <= jumpLandDetectParams.TotalTime && jumpLandDetectParams.TotalTime > 0f)
		{
			float offsetRate = Math.Min(jumpLandDetectParams.TotalTime - jumpLandDetectParams.NowTime, frameDeltaTime) / jumpLandDetectParams.TotalTime;
			this.Move(animation, jumpLandDetectParams, offsetRate);
			jumpLandDetectParams.NowTime += frameDeltaTime;
		}
		return true;
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x0006E0CC File Offset: 0x0006C2CC
	private unsafe void Move(UAnimSequenceBase animation, JumpLandDetectParams @params, float offsetRate)
	{
		BaseSkillComponent component = @params.Entity.GetComponent<BaseSkillComponent>();
		if (component != null && component.IsSkillMontageInvalid(animation.GetName()))
		{
			return;
		}
		BaseActorComponent component2 = @params.Entity.GetComponent<CharacterActorComponent>();
		@params.HeightOffset.Multiply((double)offsetRate, this.TmpVector);
		if (this.TmpVector.ContainsNaN())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Move NaN";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HeightOffset", @params.HeightOffset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("offsetRate", offsetRate);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		component2.AddActorWorldOffset(this.TmpVector.ToUeVector(false), "TsAnimNotifyStateJumpLandDetect", true);
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0006E198 File Offset: 0x0006C398
	private void GetCurveLocation(UAnimInstance mainAnim, float deltaSeconds, Vector @out)
	{
		@out.X = (double)mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_Y, deltaSeconds, false, false);
		@out.Y = (double)(-(double)mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_X, deltaSeconds, false, false));
		@out.Z = (double)mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_Z, deltaSeconds, false, false);
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x0006E1F4 File Offset: 0x0006C3F4
	private void GetCurveRotator(UAnimInstance mainAnim, float deltaSeconds, Rotator @out)
	{
		@out.Pitch = 0f;
		@out.Yaw = mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_LOOK, deltaSeconds, false, false);
		@out.Roll = 0f;
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x0006E228 File Offset: 0x0006C428
	private void TrySetMovementMode(TsBaseCharacter owner)
	{
		CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		CharacterDriveVehicleComponent characterDriveVehicleComponent = (entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null;
		if (characterDriveVehicleComponent != null && characterDriveVehicleComponent.IsOnVehicle)
		{
			return;
		}
		owner.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Walking,
			CustomMode = 0,
			Context = "[TsAnimNotifyStateJumpLandDetect.K2_NotifyEnd]"
		});
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0006E288 File Offset: 0x0006C488
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x0006E303 File Offset: 0x0006C503
	protected override string GetNotifyName_Implementation()
	{
		return "跳跃检测着陆";
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x0006E30A File Offset: 0x0006C50A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateJumpLandDetect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateJumpLandDetect.TsAnimNotifyStateJumpLandDetect_C");
		}
		return TsAnimNotifyStateJumpLandDetect._ClassPtr;
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x0006E330 File Offset: 0x0006C530
	public TsAnimNotifyStateJumpLandDetect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateJumpLandDetect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x0006E358 File Offset: 0x0006C558
	public TsAnimNotifyStateJumpLandDetect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateJumpLandDetect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x0006E38C File Offset: 0x0006C58C
	protected TsAnimNotifyStateJumpLandDetect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x0006E418 File Offset: 0x0006C618
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x0006E454 File Offset: 0x0006C654
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x0006E488 File Offset: 0x0006C688
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x0006E4C1 File Offset: 0x0006C6C1
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E3B RID: 3643
	private bool TsInited;

	// Token: 0x04000E3C RID: 3644
	private Vector TmpVector = Vector.Create();

	// Token: 0x04000E3D RID: 3645
	private Vector TmpVector2 = Vector.Create();

	// Token: 0x04000E3E RID: 3646
	private Rotator TmpRotator = Rotator.Create();

	// Token: 0x04000E3F RID: 3647
	private Transform OwnerTransform = Transform.Create();

	// Token: 0x04000E40 RID: 3648
	private Dictionary<int, JumpLandDetectParams> ParamsMap = new Dictionary<int, JumpLandDetectParams>();

	// Token: 0x04000E41 RID: 3649
	private readonly FLinearColor TraceColorRed = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000E42 RID: 3650
	private readonly FLinearColor TraceColorGreen = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000E43 RID: 3651
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateJumpLandDetect.TsAnimNotifyStateJumpLandDetect_C";

	// Token: 0x04000E44 RID: 3652
	private static IntPtr _ClassPtr;

	// Token: 0x04000E45 RID: 3653
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E46 RID: 3654
	private static int __PropertyOffset_MaxHeightOffset;

	// Token: 0x04000E47 RID: 3655
	private static int __PropertyOffset_OnlyDown;

	// Token: 0x04000E48 RID: 3656
	private static int __PropertyOffset_IgnoreActorTag;

	// Token: 0x04000E49 RID: 3657
	private static int __PropertyOffset_DebugDraw;

	// Token: 0x04000E4A RID: 3658
	private static int __PropertyOffset_EndPointHeight;

	// Token: 0x04000E4B RID: 3659
	private static int __PropertyOffset_EnableGoThrough;
}
