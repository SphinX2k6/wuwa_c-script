using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000144 RID: 324
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateJumpLandDetect.TsAnimNotifyStateJumpLandDetect_C")]
public class TsAnimNotifyStateJumpLandDetect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06001427 RID: 5159 RVA: 0x000729F0 File Offset: 0x00070BF0
	// (set) Token: 0x06001428 RID: 5160 RVA: 0x00072A00 File Offset: 0x00070C00
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

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06001429 RID: 5161 RVA: 0x00072A11 File Offset: 0x00070C11
	// (set) Token: 0x0600142A RID: 5162 RVA: 0x00072A21 File Offset: 0x00070C21
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

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x0600142B RID: 5163 RVA: 0x00072A32 File Offset: 0x00070C32
	// (set) Token: 0x0600142C RID: 5164 RVA: 0x00072A46 File Offset: 0x00070C46
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

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x0600142D RID: 5165 RVA: 0x00072A5B File Offset: 0x00070C5B
	// (set) Token: 0x0600142E RID: 5166 RVA: 0x00072A6B File Offset: 0x00070C6B
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

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x0600142F RID: 5167 RVA: 0x00072A7C File Offset: 0x00070C7C
	// (set) Token: 0x06001430 RID: 5168 RVA: 0x00072A8C File Offset: 0x00070C8C
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

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x06001431 RID: 5169 RVA: 0x00072A9D File Offset: 0x00070C9D
	// (set) Token: 0x06001432 RID: 5170 RVA: 0x00072AAD File Offset: 0x00070CAD
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

	// Token: 0x06001433 RID: 5171 RVA: 0x00072AC0 File Offset: 0x00070CC0
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

	// Token: 0x06001434 RID: 5172 RVA: 0x00072B1C File Offset: 0x00070D1C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateJumpLandDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateJumpLandDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001435 RID: 5173 RVA: 0x00072BDC File Offset: 0x00070DDC
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

	// Token: 0x06001436 RID: 5174 RVA: 0x00072ED0 File Offset: 0x000710D0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateJumpLandDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateJumpLandDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001437 RID: 5175 RVA: 0x00072F88 File Offset: 0x00071188
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

	// Token: 0x06001438 RID: 5176 RVA: 0x000730B0 File Offset: 0x000712B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateJumpLandDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateJumpLandDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001439 RID: 5177 RVA: 0x00073170 File Offset: 0x00071370
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

	// Token: 0x0600143A RID: 5178 RVA: 0x00073218 File Offset: 0x00071418
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

	// Token: 0x0600143B RID: 5179 RVA: 0x000732E4 File Offset: 0x000714E4
	private void GetCurveLocation(UAnimInstance mainAnim, float deltaSeconds, Vector @out)
	{
		@out.X = (double)mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_Y, deltaSeconds, false, false);
		@out.Y = (double)(-(double)mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_X, deltaSeconds, false, false));
		@out.Z = (double)mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_Z, deltaSeconds, false, false);
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00073340 File Offset: 0x00071540
	private void GetCurveRotator(UAnimInstance mainAnim, float deltaSeconds, Rotator @out)
	{
		@out.Pitch = 0f;
		@out.Yaw = mainAnim.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_LOOK, deltaSeconds, false, false);
		@out.Roll = 0f;
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x00073374 File Offset: 0x00071574
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

	// Token: 0x0600143E RID: 5182 RVA: 0x000733D4 File Offset: 0x000715D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateJumpLandDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateJumpLandDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600143F RID: 5183 RVA: 0x00073464 File Offset: 0x00071664
	protected override string GetNotifyName_Implementation()
	{
		return "跳跃检测着陆";
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x0007346B File Offset: 0x0007166B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateJumpLandDetect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateJumpLandDetect.TsAnimNotifyStateJumpLandDetect_C");
		}
		return TsAnimNotifyStateJumpLandDetect._ClassPtr;
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00073490 File Offset: 0x00071690
	public TsAnimNotifyStateJumpLandDetect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateJumpLandDetect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x000734B8 File Offset: 0x000716B8
	public TsAnimNotifyStateJumpLandDetect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateJumpLandDetect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x000734EC File Offset: 0x000716EC
	protected TsAnimNotifyStateJumpLandDetect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00073578 File Offset: 0x00071778
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x000735B4 File Offset: 0x000717B4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x000735E8 File Offset: 0x000717E8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00073621 File Offset: 0x00071821
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E7E RID: 3710
	private bool TsInited;

	// Token: 0x04000E7F RID: 3711
	private Vector TmpVector = Vector.Create();

	// Token: 0x04000E80 RID: 3712
	private Vector TmpVector2 = Vector.Create();

	// Token: 0x04000E81 RID: 3713
	private Rotator TmpRotator = Rotator.Create();

	// Token: 0x04000E82 RID: 3714
	private Transform OwnerTransform = Transform.Create();

	// Token: 0x04000E83 RID: 3715
	private Dictionary<int, JumpLandDetectParams> ParamsMap = new Dictionary<int, JumpLandDetectParams>();

	// Token: 0x04000E84 RID: 3716
	private readonly FLinearColor TraceColorRed = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000E85 RID: 3717
	private readonly FLinearColor TraceColorGreen = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000E86 RID: 3718
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateJumpLandDetect.TsAnimNotifyStateJumpLandDetect_C";

	// Token: 0x04000E87 RID: 3719
	private static IntPtr _ClassPtr;

	// Token: 0x04000E88 RID: 3720
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E89 RID: 3721
	private static int __PropertyOffset_MaxHeightOffset;

	// Token: 0x04000E8A RID: 3722
	private static int __PropertyOffset_OnlyDown;

	// Token: 0x04000E8B RID: 3723
	private static int __PropertyOffset_IgnoreActorTag;

	// Token: 0x04000E8C RID: 3724
	private static int __PropertyOffset_DebugDraw;

	// Token: 0x04000E8D RID: 3725
	private static int __PropertyOffset_EndPointHeight;

	// Token: 0x04000E8E RID: 3726
	private static int __PropertyOffset_EnableGoThrough;
}
