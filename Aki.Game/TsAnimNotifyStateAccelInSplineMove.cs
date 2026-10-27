using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000102 RID: 258
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAccelInSplineMove.TsAnimNotifyStateAccelInSplineMove_C")]
public class TsAnimNotifyStateAccelInSplineMove : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000F0E RID: 3854 RVA: 0x000575D0 File Offset: 0x000557D0
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

	// Token: 0x06000F0F RID: 3855 RVA: 0x00057678 File Offset: 0x00055878
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
		if (entityNoBlueprint == null || !entityNoBlueprint.Valid)
		{
			return false;
		}
		CharacterSplineMoveComponent component = entityNoBlueprint.GetComponent<CharacterSplineMoveComponent>();
		if (component == null || !component.Active)
		{
			return false;
		}
		if (component.CurrentSplineMoveType != ESplineMovePattern.PathLine)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (!characterActorComponent)
		{
			return false;
		}
		TsAnimNotifyStateAccelInSplineMove.Initialize();
		this.InitializeSelf();
		CharacterAnimationComponent component2 = characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
		if (component2 != null && component2.HasKuroRootMotion)
		{
			CharacterMoveComponent component3 = characterActorComponent.Entity.GetComponent<CharacterMoveComponent>();
			if (!component3)
			{
				return false;
			}
			Vector vector2;
			Vector vector = this.AddSpeedMap.TryGetValue(owner, out vector2) ? vector2 : null;
			if (vector == null)
			{
				vector = Vector.Create(0.0, 0.0, 0.0);
				this.AddSpeedMap.Add(owner, vector);
			}
			TsAnimNotifyStateAccelInSplineMove.CurrentSpeed.DeepCopy(vector);
			if (!this.CalculateNewSpeed(vector, characterActorComponent, frameDeltaTime, owner as TsBaseCharacter))
			{
				return false;
			}
			TsAnimNotifyStateAccelInSplineMove.CurrentSpeed.Addition(vector, TsAnimNotifyStateAccelInSplineMove.TmpVector);
			TsAnimNotifyStateAccelInSplineMove.TmpVector.MultiplyEqual((double)(frameDeltaTime / 2f));
			component3.MoveCharacter(TsAnimNotifyStateAccelInSplineMove.TmpVector, frameDeltaTime, "ANSAccelInSplineMove");
			characterActorComponent.ActorVelocityProxy.Addition(vector, TsAnimNotifyStateAccelInSplineMove.TmpVector);
			(owner as TsBaseCharacter).CharacterMovement.Velocity = TsAnimNotifyStateAccelInSplineMove.TmpVector.ToUeVectorOld();
			UeMovementTickManageComponent component4 = characterActorComponent.Entity.GetComponent<UeMovementTickManageComponent>();
			if (component4 != null)
			{
				component4.CacheVelocityInfo("SetActorVelocity");
			}
			return true;
		}
		else
		{
			this.AddSpeedMap.Remove(owner);
			Vector currentSpeed = TsAnimNotifyStateAccelInSplineMove.CurrentSpeed;
			FVector velocity = (owner as TsBaseCharacter).CharacterMovement.Velocity;
			currentSpeed.FromUeVector(velocity);
			if (!this.CalculateNewSpeed(TsAnimNotifyStateAccelInSplineMove.CurrentSpeed, characterActorComponent, frameDeltaTime, owner as TsBaseCharacter))
			{
				return false;
			}
			(owner as TsBaseCharacter).CharacterMovement.Velocity = TsAnimNotifyStateAccelInSplineMove.CurrentSpeed.ToUeVectorOld();
			UeMovementTickManageComponent component5 = characterActorComponent.Entity.GetComponent<UeMovementTickManageComponent>();
			if (component5 != null)
			{
				component5.CacheVelocityInfo("SetActorVelocity");
			}
			return true;
		}
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00057894 File Offset: 0x00055A94
	[NullableContext(1)]
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

	// Token: 0x06000F11 RID: 3857 RVA: 0x00057934 File Offset: 0x00055B34
	[NullableContext(1)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner != null)
		{
			Dictionary<AActor, Vector> addSpeedMap = this.AddSpeedMap;
			if (addSpeedMap != null)
			{
				addSpeedMap.Remove(owner);
			}
		}
		return true;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00057960 File Offset: 0x00055B60
	[NullableContext(1)]
	private unsafe bool CalculateNewSpeed(Vector inOutSpeed, CharacterActorComponent actorComp, float frameDeltaTime, TsBaseCharacter owner)
	{
		if (actorComp.InputDirectProxy.IsNearlyZero(9.999999747378752E-05))
		{
			double num = inOutSpeed.SizeSquared2D();
			if (num > 1E-08)
			{
				double num2 = Math.Sqrt(num);
				double num3 = Math.Max(0.0, num2 - (double)(CharacterSplineMoveComponent.SplineMoveConfig.AnsAccel * frameDeltaTime)) / num2;
				inOutSpeed.X *= num3;
				inOutSpeed.Y *= num3;
			}
			return true;
		}
		actorComp.InputDirectProxy.Multiply((double)(CharacterSplineMoveComponent.SplineMoveConfig.AnsAccel * frameDeltaTime), TsAnimNotifyStateAccelInSplineMove.TmpVector);
		inOutSpeed.AdditionEqual(TsAnimNotifyStateAccelInSplineMove.TmpVector);
		double num4 = MathUtils.Instance.Square((double)CharacterSplineMoveComponent.SplineMoveConfig.MaxFlySpeed);
		double num5 = inOutSpeed.SizeSquared2D();
		if (num5 > num4)
		{
			double num6 = Math.Sqrt(num4 / num5);
			inOutSpeed.X *= num6;
			inOutSpeed.Y *= num6;
		}
		if (inOutSpeed.ContainsNaN())
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "TsAnimNotifyStateAccelInSplineMove Nan Speed";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("target", inOutSpeed);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OwnerVelocity", owner.CharacterMovement.Velocity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("newSizeSquared", num5);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("maxSpeedSquared", num4);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		return true;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00057AFE File Offset: 0x00055CFE
	private static void Initialize()
	{
		if (TsAnimNotifyStateAccelInSplineMove.CurrentSpeed != null)
		{
			return;
		}
		TsAnimNotifyStateAccelInSplineMove.CurrentSpeed = Vector.Create();
		TsAnimNotifyStateAccelInSplineMove.TmpVector = Vector.Create();
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00057B1C File Offset: 0x00055D1C
	private void InitializeSelf()
	{
		if (this.AddSpeedMap != null)
		{
			return;
		}
		this.AddSpeedMap = new Dictionary<AActor, Vector>();
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00057B32 File Offset: 0x00055D32
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAccelInSplineMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAccelInSplineMove.TsAnimNotifyStateAccelInSplineMove_C");
		}
		return TsAnimNotifyStateAccelInSplineMove._ClassPtr;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00057B58 File Offset: 0x00055D58
	public TsAnimNotifyStateAccelInSplineMove() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAccelInSplineMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00057B80 File Offset: 0x00055D80
	[NullableContext(1)]
	public TsAnimNotifyStateAccelInSplineMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAccelInSplineMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00057BB3 File Offset: 0x00055DB3
	protected TsAnimNotifyStateAccelInSplineMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00057BBC File Offset: 0x00055DBC
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00057BF8 File Offset: 0x00055DF8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000BF5 RID: 3061
	[Nullable(2)]
	[StaticVariableRuleIgnore]
	private static Vector CurrentSpeed;

	// Token: 0x04000BF6 RID: 3062
	[Nullable(2)]
	[StaticVariableRuleIgnore]
	private static Vector TmpVector;

	// Token: 0x04000BF7 RID: 3063
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<AActor, Vector> AddSpeedMap;

	// Token: 0x04000BF8 RID: 3064
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAccelInSplineMove.TsAnimNotifyStateAccelInSplineMove_C";

	// Token: 0x04000BF9 RID: 3065
	private static IntPtr _ClassPtr;

	// Token: 0x04000BFA RID: 3066
	private static IntPtr _ClassDefaultObjectPtr;
}
