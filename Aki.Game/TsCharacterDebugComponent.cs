using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002392 RID: 9106
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/TsCharacterDebugComponent.TsCharacterDebugComponent_C")]
public class TsCharacterDebugComponent : UActorComponent, IUnrealUObject, IUnrealObject
{
	// Token: 0x170022FE RID: 8958
	// (get) Token: 0x060167BA RID: 92090 RVA: 0x006938E8 File Offset: 0x00691AE8
	// (set) Token: 0x060167BB RID: 92091 RVA: 0x006938F8 File Offset: 0x00691AF8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxFixSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_MaxFixSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_MaxFixSpeed) = value;
		}
	}

	// Token: 0x170022FF RID: 8959
	// (get) Token: 0x060167BC RID: 92092 RVA: 0x00693909 File Offset: 0x00691B09
	// (set) Token: 0x060167BD RID: 92093 RVA: 0x00693919 File Offset: 0x00691B19
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool StaticInit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_StaticInit) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_StaticInit) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002300 RID: 8960
	// (get) Token: 0x060167BE RID: 92094 RVA: 0x0069392A File Offset: 0x00691B2A
	// (set) Token: 0x060167BF RID: 92095 RVA: 0x0069393A File Offset: 0x00691B3A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int StaticAttrId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_StaticAttrId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_StaticAttrId) = value;
		}
	}

	// Token: 0x17002301 RID: 8961
	// (get) Token: 0x060167C0 RID: 92096 RVA: 0x0069394B File Offset: 0x00691B4B
	// (set) Token: 0x060167C1 RID: 92097 RVA: 0x0069395F File Offset: 0x00691B5F
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StaticAiId
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsCharacterDebugComponent.__PropertyOffset_StaticAiId)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsCharacterDebugComponent.__PropertyOffset_StaticAiId)), value);
		}
	}

	// Token: 0x17002302 RID: 8962
	// (get) Token: 0x060167C2 RID: 92098 RVA: 0x00693974 File Offset: 0x00691B74
	// (set) Token: 0x060167C3 RID: 92099 RVA: 0x00693984 File Offset: 0x00691B84
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long DebugCreatureId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_DebugCreatureId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_DebugCreatureId) = value;
		}
	}

	// Token: 0x17002303 RID: 8963
	// (get) Token: 0x060167C4 RID: 92100 RVA: 0x00693995 File Offset: 0x00691B95
	// (set) Token: 0x060167C5 RID: 92101 RVA: 0x006939A5 File Offset: 0x00691BA5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DebugEntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_DebugEntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_DebugEntityId) = value;
		}
	}

	// Token: 0x17002304 RID: 8964
	// (get) Token: 0x060167C6 RID: 92102 RVA: 0x006939B6 File Offset: 0x00691BB6
	// (set) Token: 0x060167C7 RID: 92103 RVA: 0x006939C6 File Offset: 0x00691BC6
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe float TestRiseSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_TestRiseSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_TestRiseSpeed) = value;
		}
	}

	// Token: 0x17002305 RID: 8965
	// (get) Token: 0x060167C8 RID: 92104 RVA: 0x006939D7 File Offset: 0x00691BD7
	// (set) Token: 0x060167C9 RID: 92105 RVA: 0x006939E7 File Offset: 0x00691BE7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DebugInteractCount
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_DebugInteractCount);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_DebugInteractCount) = value;
		}
	}

	// Token: 0x17002306 RID: 8966
	// (get) Token: 0x060167CA RID: 92106 RVA: 0x006939F8 File Offset: 0x00691BF8
	// (set) Token: 0x060167CB RID: 92107 RVA: 0x00693A0C File Offset: 0x00691C0C
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBehaviorTree BehaviorTree
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + TsCharacterDebugComponent.__PropertyOffset_BehaviorTree);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsCharacterDebugComponent.__PropertyOffset_BehaviorTree, value);
		}
	}

	// Token: 0x17002307 RID: 8967
	// (get) Token: 0x060167CC RID: 92108 RVA: 0x00693A21 File Offset: 0x00691C21
	// (set) Token: 0x060167CD RID: 92109 RVA: 0x00693A35 File Offset: 0x00691C35
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor PatrolSpline
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsCharacterDebugComponent.__PropertyOffset_PatrolSpline);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsCharacterDebugComponent.__PropertyOffset_PatrolSpline, value);
		}
	}

	// Token: 0x17002308 RID: 8968
	// (get) Token: 0x060167CE RID: 92110 RVA: 0x00693A4A File Offset: 0x00691C4A
	// (set) Token: 0x060167CF RID: 92111 RVA: 0x00693A5E File Offset: 0x00691C5E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EDrawDebugTrace> EnterClimbTrace
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_EnterClimbTrace);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_EnterClimbTrace) = value;
		}
	}

	// Token: 0x060167D0 RID: 92112 RVA: 0x00693A73 File Offset: 0x00691C73
	public void Destroy()
	{
		this.BaseChar = null;
	}

	// Token: 0x060167D1 RID: 92113 RVA: 0x00693A7C File Offset: 0x00691C7C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMovementDebug(bool newDebug)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMovementDebug"), TsCharacterDebugComponent.StaticClass(), out intPtr, out num))
		{
			this.SetMovementDebug_Implementation(newDebug);
			return;
		}
		TsCharacterDebugComponent.__SetMovementDebug_FunctionParams* ptr = stackalloc TsCharacterDebugComponent.__SetMovementDebug_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsCharacterDebugComponent.__SetMovementDebug_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->newDebug = newDebug;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060167D2 RID: 92114 RVA: 0x00693B08 File Offset: 0x00691D08
	protected void SetMovementDebug_Implementation(bool newDebug)
	{
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<ActorDebugMovementComponent>().SetDebug(newDebug);
	}

	// Token: 0x060167D3 RID: 92115 RVA: 0x00693B28 File Offset: 0x00691D28
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeEnterClimbTrace()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeEnterClimbTrace"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeEnterClimbTrace_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167D4 RID: 92116 RVA: 0x00693B84 File Offset: 0x00691D84
	protected void ChangeEnterClimbTrace_Implementation()
	{
		EDrawDebugTrace edrawDebugTrace = this.EnterClimbTrace;
		if (edrawDebugTrace != EDrawDebugTrace.None)
		{
			if (edrawDebugTrace != EDrawDebugTrace.ForOneFrame)
			{
				this.EnterClimbTrace = EDrawDebugTrace.None;
			}
			else
			{
				this.EnterClimbTrace = EDrawDebugTrace.ForDuration;
			}
		}
		else
		{
			this.EnterClimbTrace = EDrawDebugTrace.ForOneFrame;
		}
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<CharacterClimbComponent>().UpdateClimbDebug();
	}

	// Token: 0x17002309 RID: 8969
	// (get) Token: 0x060167D5 RID: 92117 RVA: 0x00693BE8 File Offset: 0x00691DE8
	// (set) Token: 0x060167D6 RID: 92118 RVA: 0x00693BFC File Offset: 0x00691DFC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EDrawDebugTrace> VaultClimbTrace
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_VaultClimbTrace);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_VaultClimbTrace) = value;
		}
	}

	// Token: 0x060167D7 RID: 92119 RVA: 0x00693C14 File Offset: 0x00691E14
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeVaultClimbTrace()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeVaultClimbTrace"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeVaultClimbTrace_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167D8 RID: 92120 RVA: 0x00693C70 File Offset: 0x00691E70
	protected void ChangeVaultClimbTrace_Implementation()
	{
		EDrawDebugTrace edrawDebugTrace = this.VaultClimbTrace;
		if (edrawDebugTrace != EDrawDebugTrace.None)
		{
			if (edrawDebugTrace != EDrawDebugTrace.ForOneFrame)
			{
				this.VaultClimbTrace = EDrawDebugTrace.None;
			}
			else
			{
				this.VaultClimbTrace = EDrawDebugTrace.ForDuration;
			}
		}
		else
		{
			this.VaultClimbTrace = EDrawDebugTrace.ForOneFrame;
		}
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<CharacterClimbComponent>().UpdateClimbDebug();
	}

	// Token: 0x1700230A RID: 8970
	// (get) Token: 0x060167D9 RID: 92121 RVA: 0x00693CD4 File Offset: 0x00691ED4
	// (set) Token: 0x060167DA RID: 92122 RVA: 0x00693CE8 File Offset: 0x00691EE8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EDrawDebugTrace> UpArriveClimbTrace
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_UpArriveClimbTrace);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_UpArriveClimbTrace) = value;
		}
	}

	// Token: 0x060167DB RID: 92123 RVA: 0x00693D00 File Offset: 0x00691F00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeUpArriveClimbTrace()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeUpArriveClimbTrace"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeUpArriveClimbTrace_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167DC RID: 92124 RVA: 0x00693D5C File Offset: 0x00691F5C
	protected void ChangeUpArriveClimbTrace_Implementation()
	{
		EDrawDebugTrace edrawDebugTrace = this.UpArriveClimbTrace;
		if (edrawDebugTrace != EDrawDebugTrace.None)
		{
			if (edrawDebugTrace != EDrawDebugTrace.ForOneFrame)
			{
				this.UpArriveClimbTrace = EDrawDebugTrace.None;
			}
			else
			{
				this.UpArriveClimbTrace = EDrawDebugTrace.ForDuration;
			}
		}
		else
		{
			this.UpArriveClimbTrace = EDrawDebugTrace.ForOneFrame;
		}
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<CharacterClimbComponent>().UpdateClimbDebug();
	}

	// Token: 0x1700230B RID: 8971
	// (get) Token: 0x060167DD RID: 92125 RVA: 0x00693DC0 File Offset: 0x00691FC0
	// (set) Token: 0x060167DE RID: 92126 RVA: 0x00693DD4 File Offset: 0x00691FD4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EDrawDebugTrace> ClimbingTrace
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_ClimbingTrace);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCharacterDebugComponent.__PropertyOffset_ClimbingTrace) = value;
		}
	}

	// Token: 0x060167DF RID: 92127 RVA: 0x00693DEC File Offset: 0x00691FEC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeClimbingTrace()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeClimbingTrace"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeClimbingTrace_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167E0 RID: 92128 RVA: 0x00693E48 File Offset: 0x00692048
	protected void ChangeClimbingTrace_Implementation()
	{
		if (this.ClimbingTrace == EDrawDebugTrace.None)
		{
			this.ClimbingTrace = EDrawDebugTrace.ForOneFrame;
		}
		else
		{
			this.ClimbingTrace = EDrawDebugTrace.None;
		}
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<CharacterClimbComponent>().UpdateClimbDebug();
	}

	// Token: 0x060167E1 RID: 92129 RVA: 0x00693E98 File Offset: 0x00692098
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeNoTop()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeNoTop"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeNoTop_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167E2 RID: 92130 RVA: 0x00693EF1 File Offset: 0x006920F1
	protected void ChangeNoTop_Implementation()
	{
		this.NoTop = !this.NoTop;
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<CharacterClimbComponent>().UpdateClimbDebug();
	}

	// Token: 0x060167E3 RID: 92131 RVA: 0x00693F1C File Offset: 0x0069211C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167E4 RID: 92132 RVA: 0x00693F78 File Offset: 0x00692178
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		AActor owner = base.GetOwner();
		this.BaseChar = (owner as TsBaseCharacter);
		if (this.BaseChar == null)
		{
			return;
		}
		this.OriginWalkableAngle = this.BaseChar.CharacterMovement.K2_GetWalkableFloorAngle();
		this.DebugRiseModeOn = false;
		base.SetComponentTickEnabled(this.DebugRiseModeOn);
	}

	// Token: 0x060167E5 RID: 92133 RVA: 0x00693FCC File Offset: 0x006921CC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsCharacterDebugComponent.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		UActorComponent.__ReceiveTick_FunctionParams* ptr = stackalloc UActorComponent.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UActorComponent.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060167E6 RID: 92134 RVA: 0x00694058 File Offset: 0x00692258
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		this.DebugRising(deltaSeconds);
	}

	// Token: 0x060167E7 RID: 92135 RVA: 0x00694064 File Offset: 0x00692264
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ActivateDebugSpeed(bool activate)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ActivateDebugSpeed"), TsCharacterDebugComponent.StaticClass(), out intPtr, out num))
		{
			this.ActivateDebugSpeed_Implementation(activate);
			return;
		}
		TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams* ptr = stackalloc TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->activate = activate;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060167E8 RID: 92136 RVA: 0x006940F0 File Offset: 0x006922F0
	protected void ActivateDebugSpeed_Implementation(bool activate)
	{
		if (activate)
		{
			this.BaseChar.CharacterMovement.SetWalkableFloorAngle(90f);
			if (this.MaxFixSpeed == 0f)
			{
				this.MaxFixSpeed = 5000f;
				return;
			}
		}
		else
		{
			this.BaseChar.CharacterMovement.SetWalkableFloorAngle(this.OriginWalkableAngle);
			if (this.MaxFixSpeed != 0f)
			{
				this.MaxFixSpeed = 0f;
			}
		}
	}

	// Token: 0x060167E9 RID: 92137 RVA: 0x0069415C File Offset: 0x0069235C
	protected void DebugRising(float deltaSeconds)
	{
		if (this.DebugRiseModeOn)
		{
			TsCharacterDebugComponent.tmpVector.Reset();
			GravityUtils.Instance.AddZnInGravityForActor(this.BaseChar.CharacterActorComponent, TsCharacterDebugComponent.tmpVector, (double)(this.TestRiseSpeed * deltaSeconds));
			this.BaseChar.CharacterActorComponent.AddActorWorldOffset(TsCharacterDebugComponent.tmpVector.ToUeVector(false), "DebugRising", false);
			this.BaseChar.CharacterActorComponent.MoveComp.SetForceSpeed(Vector.ZeroVectorProxy);
		}
	}

	// Token: 0x060167EA RID: 92138 RVA: 0x006941DC File Offset: 0x006923DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DebugDrawActivateArea()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DebugDrawActivateArea"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DebugDrawActivateArea_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167EB RID: 92139 RVA: 0x00694238 File Offset: 0x00692438
	protected void DebugDrawActivateArea_Implementation()
	{
		FVectorDouble actorLocation = this.BaseChar.CharacterActorComponent.ActorLocation;
		FVector fvector = actorLocation;
		FVectorDouble end = new FVectorDouble(ref fvector);
		end.Z += 100.0;
		UKismetSystemLibrary.D_DrawDebugCylinder(this, actorLocation, end, 5000f, 12, null, 0f, 0f);
	}

	// Token: 0x060167EC RID: 92140 RVA: 0x0069429C File Offset: 0x0069249C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDebugRiseEnable(bool enable)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDebugRiseEnable"), TsCharacterDebugComponent.StaticClass(), out intPtr, out num))
		{
			this.SetDebugRiseEnable_Implementation(enable);
			return;
		}
		TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams* ptr = stackalloc TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->enable = enable;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060167ED RID: 92141 RVA: 0x00694328 File Offset: 0x00692528
	protected void SetDebugRiseEnable_Implementation(bool enable)
	{
		if (this.DebugRiseModeOn == enable)
		{
			return;
		}
		this.DebugRiseModeOn = enable;
		base.SetComponentTickEnabled(enable);
	}

	// Token: 0x060167EE RID: 92142 RVA: 0x00694342 File Offset: 0x00692542
	public void SaveDebugPatrolPoint(FVector point)
	{
		this.SaveDebugPatrolPoint(Vector.Create(point));
	}

	// Token: 0x060167EF RID: 92143 RVA: 0x00694355 File Offset: 0x00692555
	[NullableContext(1)]
	public void SaveDebugPatrolPoint(Vector point)
	{
		if (this.DebugPatrolPoints == null)
		{
			this.DebugPatrolPoints = new List<Vector>();
		}
		this.DebugPatrolPoints.Add(point);
	}

	// Token: 0x060167F0 RID: 92144 RVA: 0x00694376 File Offset: 0x00692576
	public void ClearDebugPatrolPoints()
	{
		List<Vector> debugPatrolPoints = this.DebugPatrolPoints;
		if (debugPatrolPoints == null)
		{
			return;
		}
		debugPatrolPoints.Clear();
	}

	// Token: 0x060167F1 RID: 92145 RVA: 0x00694388 File Offset: 0x00692588
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DrawDebugPatrolPoints()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DrawDebugPatrolPoints"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DrawDebugPatrolPoints_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167F2 RID: 92146 RVA: 0x006943E4 File Offset: 0x006925E4
	protected void DrawDebugPatrolPoints_Implementation()
	{
		if (this.DebugPatrolPoints == null || this.DebugPatrolPoints.Count == 0)
		{
			return;
		}
		Vector vector = this.DebugPatrolPoints[0];
		UKismetSystemLibrary.D_DrawDebugSphere(this, vector.ToUeVector(false), 18f, 12, new FLinearColor?(ColorUtils.LinearCyan), 60f, 0f);
		int num = this.DebugPatrolPoints.Count - 1;
		for (int i = 1; i < num; i++)
		{
			Vector vector2 = this.DebugPatrolPoints[i];
			UKismetSystemLibrary.D_DrawDebugSphere(this, vector2.ToUeVector(false), 6f, 4, new FLinearColor?(ColorUtils.LinearGreen), 60f, 0f);
		}
		if (num > 0)
		{
			Vector vector3 = this.DebugPatrolPoints[num];
			UKismetSystemLibrary.D_DrawDebugSphere(this, vector3.ToUeVector(false), 18f, 12, new FLinearColor?(ColorUtils.LinearYellow), 60f, 0f);
		}
	}

	// Token: 0x060167F3 RID: 92147 RVA: 0x006944C8 File Offset: 0x006926C8
	[NullableContext(1)]
	public void SaveErrorNavigationPath(Vector start, Vector end, FVector[] results)
	{
		if (this.DebugNavigationErrorPaths == null)
		{
			this.DebugNavigationErrorPaths = new List<TsCharacterDebugComponent.NavigationErrorData>();
		}
		TsCharacterDebugComponent.NavigationErrorData navigationErrorData = new TsCharacterDebugComponent.NavigationErrorData();
		navigationErrorData.Start = Vector.Create(start);
		navigationErrorData.End = Vector.Create(end);
		navigationErrorData.Results = new List<FVectorDouble>();
		foreach (FVector fvector in results)
		{
			FVectorDouble item = new FVectorDouble();
			item.Set((double)fvector.X, (double)fvector.Y, (double)fvector.Z);
			navigationErrorData.Results.Add(item);
		}
		this.DebugNavigationErrorPaths.Add(navigationErrorData);
	}

	// Token: 0x060167F4 RID: 92148 RVA: 0x00694564 File Offset: 0x00692764
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DrawErrorNavigationPaths()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterDebugComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DrawErrorNavigationPaths"), TsCharacterDebugComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DrawErrorNavigationPaths_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060167F5 RID: 92149 RVA: 0x006945C0 File Offset: 0x006927C0
	protected void DrawErrorNavigationPaths_Implementation()
	{
		if (this.DebugNavigationErrorPaths == null)
		{
			return;
		}
		for (int i = 0; i < this.DebugNavigationErrorPaths.Count; i++)
		{
			TsCharacterDebugComponent.NavigationErrorData navigationErrorData = this.DebugNavigationErrorPaths[i];
			UKismetSystemLibrary.D_DrawDebugSphere(this, navigationErrorData.Start.ToUeVector(false), 18f, 12, new FLinearColor?(ColorUtils.LinearCyan), 60f, 0f);
			if (navigationErrorData.Results != null)
			{
				for (int j = 0; j < navigationErrorData.Results.Count; j++)
				{
					FVectorDouble center = navigationErrorData.Results[j];
					UKismetSystemLibrary.D_DrawDebugSphere(this, center, 6f, 4, new FLinearColor?(ColorUtils.LinearRed), 60f, 0f);
				}
			}
			UKismetSystemLibrary.D_DrawDebugSphere(this, navigationErrorData.End.ToUeVector(false), 18f, 12, new FLinearColor?(ColorUtils.LinearYellow), 60f, 0f);
		}
	}

	// Token: 0x060167F6 RID: 92150 RVA: 0x006946A5 File Offset: 0x006928A5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsCharacterDebugComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/TsCharacterDebugComponent.TsCharacterDebugComponent_C");
		}
		return TsCharacterDebugComponent._ClassPtr;
	}

	// Token: 0x060167F7 RID: 92151 RVA: 0x006946CC File Offset: 0x006928CC
	public TsCharacterDebugComponent() : this(BuiltinUtils.AllocNativeUObject(TsCharacterDebugComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060167F8 RID: 92152 RVA: 0x006946F4 File Offset: 0x006928F4
	[NullableContext(1)]
	public TsCharacterDebugComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterDebugComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060167F9 RID: 92153 RVA: 0x00694727 File Offset: 0x00692927
	protected TsCharacterDebugComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060167FA RID: 92154 RVA: 0x00694730 File Offset: 0x00692930
	protected unsafe virtual void __CPPCALL_SetMovementDebug_Implementation(TsCharacterDebugComponent.__SetMovementDebug_FunctionParams* __Params)
	{
		this.SetMovementDebug_Implementation(__Params->newDebug);
	}

	// Token: 0x060167FB RID: 92155 RVA: 0x0069473E File Offset: 0x0069293E
	protected virtual void __CPPCALL_ChangeEnterClimbTrace_Implementation()
	{
		this.ChangeEnterClimbTrace_Implementation();
	}

	// Token: 0x060167FC RID: 92156 RVA: 0x00694746 File Offset: 0x00692946
	protected virtual void __CPPCALL_ChangeVaultClimbTrace_Implementation()
	{
		this.ChangeVaultClimbTrace_Implementation();
	}

	// Token: 0x060167FD RID: 92157 RVA: 0x0069474E File Offset: 0x0069294E
	protected virtual void __CPPCALL_ChangeUpArriveClimbTrace_Implementation()
	{
		this.ChangeUpArriveClimbTrace_Implementation();
	}

	// Token: 0x060167FE RID: 92158 RVA: 0x00694756 File Offset: 0x00692956
	protected virtual void __CPPCALL_ChangeClimbingTrace_Implementation()
	{
		this.ChangeClimbingTrace_Implementation();
	}

	// Token: 0x060167FF RID: 92159 RVA: 0x0069475E File Offset: 0x0069295E
	protected virtual void __CPPCALL_ChangeNoTop_Implementation()
	{
		this.ChangeNoTop_Implementation();
	}

	// Token: 0x06016800 RID: 92160 RVA: 0x00694766 File Offset: 0x00692966
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06016801 RID: 92161 RVA: 0x0069476E File Offset: 0x0069296E
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(UActorComponent.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06016802 RID: 92162 RVA: 0x0069477C File Offset: 0x0069297C
	protected unsafe virtual void __CPPCALL_ActivateDebugSpeed_Implementation(TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams* __Params)
	{
		this.ActivateDebugSpeed_Implementation(__Params->activate);
	}

	// Token: 0x06016803 RID: 92163 RVA: 0x0069478A File Offset: 0x0069298A
	protected virtual void __CPPCALL_DebugDrawActivateArea_Implementation()
	{
		this.DebugDrawActivateArea_Implementation();
	}

	// Token: 0x06016804 RID: 92164 RVA: 0x00694792 File Offset: 0x00692992
	protected unsafe virtual void __CPPCALL_SetDebugRiseEnable_Implementation(TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams* __Params)
	{
		this.SetDebugRiseEnable_Implementation(__Params->enable);
	}

	// Token: 0x06016805 RID: 92165 RVA: 0x006947A0 File Offset: 0x006929A0
	protected virtual void __CPPCALL_DrawDebugPatrolPoints_Implementation()
	{
		this.DrawDebugPatrolPoints_Implementation();
	}

	// Token: 0x06016806 RID: 92166 RVA: 0x006947A8 File Offset: 0x006929A8
	protected virtual void __CPPCALL_DrawErrorNavigationPaths_Implementation()
	{
		this.DrawErrorNavigationPaths_Implementation();
	}

	// Token: 0x0400BE98 RID: 48792
	private const int JUMPED_TURN_SPEED_THREADHOLD = 100;

	// Token: 0x0400BE99 RID: 48793
	private const int ACTIVE_DISTANCE = 5000;

	// Token: 0x0400BE9A RID: 48794
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static Vector tmpVector = Vector.Create();

	// Token: 0x0400BE9B RID: 48795
	[Nullable(2)]
	public TsBaseCharacter BaseChar;

	// Token: 0x0400BE9C RID: 48796
	protected float OriginWalkableAngle;

	// Token: 0x0400BE9D RID: 48797
	private bool DebugRiseModeOn;

	// Token: 0x0400BE9E RID: 48798
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> DebugPatrolPoints;

	// Token: 0x0400BE9F RID: 48799
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<TsCharacterDebugComponent.NavigationErrorData> DebugNavigationErrorPaths;

	// Token: 0x0400BEA0 RID: 48800
	public bool NoTop;

	// Token: 0x0400BEA1 RID: 48801
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/TsCharacterDebugComponent.TsCharacterDebugComponent_C";

	// Token: 0x0400BEA2 RID: 48802
	private static IntPtr _ClassPtr;

	// Token: 0x0400BEA3 RID: 48803
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BEA4 RID: 48804
	private static int __PropertyOffset_MaxFixSpeed;

	// Token: 0x0400BEA5 RID: 48805
	private static int __PropertyOffset_StaticInit;

	// Token: 0x0400BEA6 RID: 48806
	private static int __PropertyOffset_StaticAttrId;

	// Token: 0x0400BEA7 RID: 48807
	private static int __PropertyOffset_StaticAiId;

	// Token: 0x0400BEA8 RID: 48808
	private static int __PropertyOffset_DebugCreatureId;

	// Token: 0x0400BEA9 RID: 48809
	private static int __PropertyOffset_DebugEntityId;

	// Token: 0x0400BEAA RID: 48810
	private static int __PropertyOffset_TestRiseSpeed;

	// Token: 0x0400BEAB RID: 48811
	private static int __PropertyOffset_DebugInteractCount;

	// Token: 0x0400BEAC RID: 48812
	private static int __PropertyOffset_BehaviorTree;

	// Token: 0x0400BEAD RID: 48813
	private static int __PropertyOffset_PatrolSpline;

	// Token: 0x0400BEAE RID: 48814
	private static int __PropertyOffset_EnterClimbTrace;

	// Token: 0x0400BEAF RID: 48815
	private static int __PropertyOffset_VaultClimbTrace;

	// Token: 0x0400BEB0 RID: 48816
	private static int __PropertyOffset_UpArriveClimbTrace;

	// Token: 0x0400BEB1 RID: 48817
	private static int __PropertyOffset_ClimbingTrace;

	// Token: 0x0200857B RID: 34171
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigationErrorData
	{
		// Token: 0x0402AFDC RID: 176092
		public Vector Start;

		// Token: 0x0402AFDD RID: 176093
		public Vector End;

		// Token: 0x0402AFDE RID: 176094
		public List<FVectorDouble> Results;
	}

	// Token: 0x0200857C RID: 34172
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetMovementDebug_FunctionParams
	{
		// Token: 0x0402AFDF RID: 176095
		[FieldOffset(0)]
		public bool newDebug;
	}

	// Token: 0x0200857D RID: 34173
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __ActivateDebugSpeed_FunctionParams
	{
		// Token: 0x0402AFE0 RID: 176096
		[FieldOffset(0)]
		public bool activate;
	}

	// Token: 0x0200857E RID: 34174
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetDebugRiseEnable_FunctionParams
	{
		// Token: 0x0402AFE1 RID: 176097
		[FieldOffset(0)]
		public bool enable;
	}
}
