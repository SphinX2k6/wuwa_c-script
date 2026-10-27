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

// Token: 0x02002E36 RID: 11830
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/TsCharacterDebugComponent.TsCharacterDebugComponent_C")]
public class TsCharacterDebugComponent : UActorComponent, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700228B RID: 8843
	// (get) Token: 0x06018EED RID: 102125 RVA: 0x0066D9F0 File Offset: 0x0066BBF0
	// (set) Token: 0x06018EEE RID: 102126 RVA: 0x0066DA00 File Offset: 0x0066BC00
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

	// Token: 0x1700228C RID: 8844
	// (get) Token: 0x06018EEF RID: 102127 RVA: 0x0066DA11 File Offset: 0x0066BC11
	// (set) Token: 0x06018EF0 RID: 102128 RVA: 0x0066DA21 File Offset: 0x0066BC21
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

	// Token: 0x1700228D RID: 8845
	// (get) Token: 0x06018EF1 RID: 102129 RVA: 0x0066DA32 File Offset: 0x0066BC32
	// (set) Token: 0x06018EF2 RID: 102130 RVA: 0x0066DA42 File Offset: 0x0066BC42
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

	// Token: 0x1700228E RID: 8846
	// (get) Token: 0x06018EF3 RID: 102131 RVA: 0x0066DA53 File Offset: 0x0066BC53
	// (set) Token: 0x06018EF4 RID: 102132 RVA: 0x0066DA67 File Offset: 0x0066BC67
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

	// Token: 0x1700228F RID: 8847
	// (get) Token: 0x06018EF5 RID: 102133 RVA: 0x0066DA7C File Offset: 0x0066BC7C
	// (set) Token: 0x06018EF6 RID: 102134 RVA: 0x0066DA8C File Offset: 0x0066BC8C
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

	// Token: 0x17002290 RID: 8848
	// (get) Token: 0x06018EF7 RID: 102135 RVA: 0x0066DA9D File Offset: 0x0066BC9D
	// (set) Token: 0x06018EF8 RID: 102136 RVA: 0x0066DAAD File Offset: 0x0066BCAD
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

	// Token: 0x17002291 RID: 8849
	// (get) Token: 0x06018EF9 RID: 102137 RVA: 0x0066DABE File Offset: 0x0066BCBE
	// (set) Token: 0x06018EFA RID: 102138 RVA: 0x0066DACE File Offset: 0x0066BCCE
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

	// Token: 0x17002292 RID: 8850
	// (get) Token: 0x06018EFB RID: 102139 RVA: 0x0066DADF File Offset: 0x0066BCDF
	// (set) Token: 0x06018EFC RID: 102140 RVA: 0x0066DAEF File Offset: 0x0066BCEF
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

	// Token: 0x17002293 RID: 8851
	// (get) Token: 0x06018EFD RID: 102141 RVA: 0x0066DB00 File Offset: 0x0066BD00
	// (set) Token: 0x06018EFE RID: 102142 RVA: 0x0066DB14 File Offset: 0x0066BD14
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

	// Token: 0x17002294 RID: 8852
	// (get) Token: 0x06018EFF RID: 102143 RVA: 0x0066DB29 File Offset: 0x0066BD29
	// (set) Token: 0x06018F00 RID: 102144 RVA: 0x0066DB3D File Offset: 0x0066BD3D
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

	// Token: 0x17002295 RID: 8853
	// (get) Token: 0x06018F01 RID: 102145 RVA: 0x0066DB52 File Offset: 0x0066BD52
	// (set) Token: 0x06018F02 RID: 102146 RVA: 0x0066DB66 File Offset: 0x0066BD66
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

	// Token: 0x06018F03 RID: 102147 RVA: 0x0066DB7B File Offset: 0x0066BD7B
	public void Destroy()
	{
		this.BaseChar = null;
	}

	// Token: 0x06018F04 RID: 102148 RVA: 0x0066DB84 File Offset: 0x0066BD84
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMovementDebug(bool newDebug)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMovementDebug"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsCharacterDebugComponent.__SetMovementDebug_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsCharacterDebugComponent.__SetMovementDebug_FunctionParams*)ptr + 15L / (long)sizeof(TsCharacterDebugComponent.__SetMovementDebug_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->newDebug = newDebug;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06018F05 RID: 102149 RVA: 0x0066DBFA File Offset: 0x0066BDFA
	protected void SetMovementDebug_Implementation(bool newDebug)
	{
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<ActorDebugMovementComponent>().SetDebug(newDebug);
	}

	// Token: 0x06018F06 RID: 102150 RVA: 0x0066DC18 File Offset: 0x0066BE18
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeEnterClimbTrace()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeEnterClimbTrace"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F07 RID: 102151 RVA: 0x0066DC88 File Offset: 0x0066BE88
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

	// Token: 0x17002296 RID: 8854
	// (get) Token: 0x06018F08 RID: 102152 RVA: 0x0066DCEC File Offset: 0x0066BEEC
	// (set) Token: 0x06018F09 RID: 102153 RVA: 0x0066DD00 File Offset: 0x0066BF00
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

	// Token: 0x06018F0A RID: 102154 RVA: 0x0066DD18 File Offset: 0x0066BF18
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeVaultClimbTrace()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeVaultClimbTrace"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F0B RID: 102155 RVA: 0x0066DD88 File Offset: 0x0066BF88
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

	// Token: 0x17002297 RID: 8855
	// (get) Token: 0x06018F0C RID: 102156 RVA: 0x0066DDEC File Offset: 0x0066BFEC
	// (set) Token: 0x06018F0D RID: 102157 RVA: 0x0066DE00 File Offset: 0x0066C000
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

	// Token: 0x06018F0E RID: 102158 RVA: 0x0066DE18 File Offset: 0x0066C018
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeUpArriveClimbTrace()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeUpArriveClimbTrace"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F0F RID: 102159 RVA: 0x0066DE88 File Offset: 0x0066C088
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

	// Token: 0x17002298 RID: 8856
	// (get) Token: 0x06018F10 RID: 102160 RVA: 0x0066DEEC File Offset: 0x0066C0EC
	// (set) Token: 0x06018F11 RID: 102161 RVA: 0x0066DF00 File Offset: 0x0066C100
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

	// Token: 0x06018F12 RID: 102162 RVA: 0x0066DF18 File Offset: 0x0066C118
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeClimbingTrace()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeClimbingTrace"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F13 RID: 102163 RVA: 0x0066DF88 File Offset: 0x0066C188
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

	// Token: 0x06018F14 RID: 102164 RVA: 0x0066DFD8 File Offset: 0x0066C1D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeNoTop()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeNoTop"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F15 RID: 102165 RVA: 0x0066E048 File Offset: 0x0066C248
	protected void ChangeNoTop_Implementation()
	{
		this.NoTop = !this.NoTop;
		this.BaseChar.CharacterActorComponent.Entity.GetComponent<CharacterClimbComponent>().UpdateClimbDebug();
	}

	// Token: 0x06018F16 RID: 102166 RVA: 0x0066E074 File Offset: 0x0066C274
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F17 RID: 102167 RVA: 0x0066E0E4 File Offset: 0x0066C2E4
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

	// Token: 0x06018F18 RID: 102168 RVA: 0x0066E138 File Offset: 0x0066C338
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UActorComponent.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UActorComponent.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(UActorComponent.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06018F19 RID: 102169 RVA: 0x0066E1AE File Offset: 0x0066C3AE
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		this.DebugRising(deltaSeconds);
	}

	// Token: 0x06018F1A RID: 102170 RVA: 0x0066E1B8 File Offset: 0x0066C3B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ActivateDebugSpeed(bool activate)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ActivateDebugSpeed"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams*)ptr + 15L / (long)sizeof(TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->activate = activate;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06018F1B RID: 102171 RVA: 0x0066E230 File Offset: 0x0066C430
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

	// Token: 0x06018F1C RID: 102172 RVA: 0x0066E29C File Offset: 0x0066C49C
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

	// Token: 0x06018F1D RID: 102173 RVA: 0x0066E31C File Offset: 0x0066C51C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DebugDrawActivateArea()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DebugDrawActivateArea"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F1E RID: 102174 RVA: 0x0066E38C File Offset: 0x0066C58C
	protected void DebugDrawActivateArea_Implementation()
	{
		FVectorDouble actorLocation = this.BaseChar.CharacterActorComponent.ActorLocation;
		FVector fvector = actorLocation;
		FVectorDouble end = new FVectorDouble(ref fvector);
		end.Z += 100.0;
		UKismetSystemLibrary.D_DrawDebugCylinder(this, actorLocation, end, 5000f, 12, null, 0f, 0f);
	}

	// Token: 0x06018F1F RID: 102175 RVA: 0x0066E3F0 File Offset: 0x0066C5F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDebugRiseEnable(bool enable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDebugRiseEnable"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams*)ptr + 15L / (long)sizeof(TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->enable = enable;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06018F20 RID: 102176 RVA: 0x0066E466 File Offset: 0x0066C666
	protected void SetDebugRiseEnable_Implementation(bool enable)
	{
		if (this.DebugRiseModeOn == enable)
		{
			return;
		}
		this.DebugRiseModeOn = enable;
		base.SetComponentTickEnabled(enable);
	}

	// Token: 0x06018F21 RID: 102177 RVA: 0x0066E480 File Offset: 0x0066C680
	public void SaveDebugPatrolPoint(FVector point)
	{
		this.SaveDebugPatrolPoint(Vector.Create(point));
	}

	// Token: 0x06018F22 RID: 102178 RVA: 0x0066E493 File Offset: 0x0066C693
	[NullableContext(1)]
	public void SaveDebugPatrolPoint(Vector point)
	{
		if (this.DebugPatrolPoints == null)
		{
			this.DebugPatrolPoints = new List<Vector>();
		}
		this.DebugPatrolPoints.Add(point);
	}

	// Token: 0x06018F23 RID: 102179 RVA: 0x0066E4B4 File Offset: 0x0066C6B4
	public void ClearDebugPatrolPoints()
	{
		List<Vector> debugPatrolPoints = this.DebugPatrolPoints;
		if (debugPatrolPoints == null)
		{
			return;
		}
		debugPatrolPoints.Clear();
	}

	// Token: 0x06018F24 RID: 102180 RVA: 0x0066E4C8 File Offset: 0x0066C6C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DrawDebugPatrolPoints()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DrawDebugPatrolPoints"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F25 RID: 102181 RVA: 0x0066E538 File Offset: 0x0066C738
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

	// Token: 0x06018F26 RID: 102182 RVA: 0x0066E61C File Offset: 0x0066C81C
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

	// Token: 0x06018F27 RID: 102183 RVA: 0x0066E6B8 File Offset: 0x0066C8B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DrawErrorNavigationPaths()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DrawErrorNavigationPaths"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018F28 RID: 102184 RVA: 0x0066E728 File Offset: 0x0066C928
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

	// Token: 0x06018F29 RID: 102185 RVA: 0x0066E80D File Offset: 0x0066CA0D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsCharacterDebugComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/TsCharacterDebugComponent.TsCharacterDebugComponent_C");
		}
		return TsCharacterDebugComponent._ClassPtr;
	}

	// Token: 0x06018F2A RID: 102186 RVA: 0x0066E834 File Offset: 0x0066CA34
	public TsCharacterDebugComponent() : this(BuiltinUtils.AllocNativeUObject(TsCharacterDebugComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018F2B RID: 102187 RVA: 0x0066E85C File Offset: 0x0066CA5C
	[NullableContext(1)]
	public TsCharacterDebugComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterDebugComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018F2C RID: 102188 RVA: 0x0066E88F File Offset: 0x0066CA8F
	protected TsCharacterDebugComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06018F2D RID: 102189 RVA: 0x0066E898 File Offset: 0x0066CA98
	protected unsafe virtual void __CPPCALL_SetMovementDebug_Implementation(TsCharacterDebugComponent.__SetMovementDebug_FunctionParams* __Params)
	{
		this.SetMovementDebug_Implementation(__Params->newDebug);
	}

	// Token: 0x06018F2E RID: 102190 RVA: 0x0066E8A6 File Offset: 0x0066CAA6
	protected virtual void __CPPCALL_ChangeEnterClimbTrace_Implementation()
	{
		this.ChangeEnterClimbTrace_Implementation();
	}

	// Token: 0x06018F2F RID: 102191 RVA: 0x0066E8AE File Offset: 0x0066CAAE
	protected virtual void __CPPCALL_ChangeVaultClimbTrace_Implementation()
	{
		this.ChangeVaultClimbTrace_Implementation();
	}

	// Token: 0x06018F30 RID: 102192 RVA: 0x0066E8B6 File Offset: 0x0066CAB6
	protected virtual void __CPPCALL_ChangeUpArriveClimbTrace_Implementation()
	{
		this.ChangeUpArriveClimbTrace_Implementation();
	}

	// Token: 0x06018F31 RID: 102193 RVA: 0x0066E8BE File Offset: 0x0066CABE
	protected virtual void __CPPCALL_ChangeClimbingTrace_Implementation()
	{
		this.ChangeClimbingTrace_Implementation();
	}

	// Token: 0x06018F32 RID: 102194 RVA: 0x0066E8C6 File Offset: 0x0066CAC6
	protected virtual void __CPPCALL_ChangeNoTop_Implementation()
	{
		this.ChangeNoTop_Implementation();
	}

	// Token: 0x06018F33 RID: 102195 RVA: 0x0066E8CE File Offset: 0x0066CACE
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06018F34 RID: 102196 RVA: 0x0066E8D6 File Offset: 0x0066CAD6
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(UActorComponent.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06018F35 RID: 102197 RVA: 0x0066E8E4 File Offset: 0x0066CAE4
	protected unsafe virtual void __CPPCALL_ActivateDebugSpeed_Implementation(TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams* __Params)
	{
		this.ActivateDebugSpeed_Implementation(__Params->activate);
	}

	// Token: 0x06018F36 RID: 102198 RVA: 0x0066E8F2 File Offset: 0x0066CAF2
	protected virtual void __CPPCALL_DebugDrawActivateArea_Implementation()
	{
		this.DebugDrawActivateArea_Implementation();
	}

	// Token: 0x06018F37 RID: 102199 RVA: 0x0066E8FA File Offset: 0x0066CAFA
	protected unsafe virtual void __CPPCALL_SetDebugRiseEnable_Implementation(TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams* __Params)
	{
		this.SetDebugRiseEnable_Implementation(__Params->enable);
	}

	// Token: 0x06018F38 RID: 102200 RVA: 0x0066E908 File Offset: 0x0066CB08
	protected virtual void __CPPCALL_DrawDebugPatrolPoints_Implementation()
	{
		this.DrawDebugPatrolPoints_Implementation();
	}

	// Token: 0x06018F39 RID: 102201 RVA: 0x0066E910 File Offset: 0x0066CB10
	protected virtual void __CPPCALL_DrawErrorNavigationPaths_Implementation()
	{
		this.DrawErrorNavigationPaths_Implementation();
	}

	// Token: 0x0400BB0A RID: 47882
	private const int JUMPED_TURN_SPEED_THREADHOLD = 100;

	// Token: 0x0400BB0B RID: 47883
	private const int ACTIVE_DISTANCE = 5000;

	// Token: 0x0400BB0C RID: 47884
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static Vector tmpVector = Vector.Create();

	// Token: 0x0400BB0D RID: 47885
	[Nullable(2)]
	public TsBaseCharacter BaseChar;

	// Token: 0x0400BB0E RID: 47886
	protected float OriginWalkableAngle;

	// Token: 0x0400BB0F RID: 47887
	private bool DebugRiseModeOn;

	// Token: 0x0400BB10 RID: 47888
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> DebugPatrolPoints;

	// Token: 0x0400BB11 RID: 47889
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<TsCharacterDebugComponent.NavigationErrorData> DebugNavigationErrorPaths;

	// Token: 0x0400BB12 RID: 47890
	public bool NoTop;

	// Token: 0x0400BB13 RID: 47891
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Component/TsCharacterDebugComponent.TsCharacterDebugComponent_C";

	// Token: 0x0400BB14 RID: 47892
	private static IntPtr _ClassPtr;

	// Token: 0x0400BB15 RID: 47893
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BB16 RID: 47894
	private static int __PropertyOffset_MaxFixSpeed;

	// Token: 0x0400BB17 RID: 47895
	private static int __PropertyOffset_StaticInit;

	// Token: 0x0400BB18 RID: 47896
	private static int __PropertyOffset_StaticAttrId;

	// Token: 0x0400BB19 RID: 47897
	private static int __PropertyOffset_StaticAiId;

	// Token: 0x0400BB1A RID: 47898
	private static int __PropertyOffset_DebugCreatureId;

	// Token: 0x0400BB1B RID: 47899
	private static int __PropertyOffset_DebugEntityId;

	// Token: 0x0400BB1C RID: 47900
	private static int __PropertyOffset_TestRiseSpeed;

	// Token: 0x0400BB1D RID: 47901
	private static int __PropertyOffset_DebugInteractCount;

	// Token: 0x0400BB1E RID: 47902
	private static int __PropertyOffset_BehaviorTree;

	// Token: 0x0400BB1F RID: 47903
	private static int __PropertyOffset_PatrolSpline;

	// Token: 0x0400BB20 RID: 47904
	private static int __PropertyOffset_EnterClimbTrace;

	// Token: 0x0400BB21 RID: 47905
	private static int __PropertyOffset_VaultClimbTrace;

	// Token: 0x0400BB22 RID: 47906
	private static int __PropertyOffset_UpArriveClimbTrace;

	// Token: 0x0400BB23 RID: 47907
	private static int __PropertyOffset_ClimbingTrace;

	// Token: 0x02009355 RID: 37717
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigationErrorData
	{
		// Token: 0x0402F956 RID: 194902
		public Vector Start;

		// Token: 0x0402F957 RID: 194903
		public Vector End;

		// Token: 0x0402F958 RID: 194904
		public List<FVectorDouble> Results;
	}

	// Token: 0x02009356 RID: 37718
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetMovementDebug_FunctionParams
	{
		// Token: 0x0402F959 RID: 194905
		[FieldOffset(0)]
		public bool newDebug;
	}

	// Token: 0x02009357 RID: 37719
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __ActivateDebugSpeed_FunctionParams
	{
		// Token: 0x0402F95A RID: 194906
		[FieldOffset(0)]
		public bool activate;
	}

	// Token: 0x02009358 RID: 37720
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetDebugRiseEnable_FunctionParams
	{
		// Token: 0x0402F95B RID: 194907
		[FieldOffset(0)]
		public bool enable;
	}
}
