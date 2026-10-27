using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004276 RID: 17014
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BPI_Character.BPI_Character_C")]
	public interface IBPI_Character_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602C209 RID: 180745 RVA: 0x00A17040 File Offset: 0x00A15240
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceSetCharState(FGameplayTag newCharState)
		{
			IBPI_Character_C.__InterfaceSetCharState_FunctionParams* ptr = stackalloc IBPI_Character_C.__InterfaceSetCharState_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Character_C.__InterfaceSetCharState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetCharState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->newCharState = newCharState;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetCharState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C20A RID: 180746 RVA: 0x00A17088 File Offset: 0x00A15288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceSetGait(FGameplayTag newGait)
		{
			IBPI_Character_C.__InterfaceSetGait_FunctionParams* ptr = stackalloc IBPI_Character_C.__InterfaceSetGait_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Character_C.__InterfaceSetGait_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetGait_NativeFunctionPtr, (void*)ptr, 1);
			ptr->newGait = newGait;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetGait_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C20B RID: 180747 RVA: 0x00A170D0 File Offset: 0x00A152D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceSetRotationMode(FGameplayTag newRotationMode)
		{
			IBPI_Character_C.__InterfaceSetRotationMode_FunctionParams* ptr = stackalloc IBPI_Character_C.__InterfaceSetRotationMode_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Character_C.__InterfaceSetRotationMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetRotationMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->newRotationMode = newRotationMode;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetRotationMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C20C RID: 180748 RVA: 0x00A17118 File Offset: 0x00A15318
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceSetMovementState(FGameplayTag newMovementState)
		{
			IBPI_Character_C.__InterfaceSetMovementState_FunctionParams* ptr = stackalloc IBPI_Character_C.__InterfaceSetMovementState_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Character_C.__InterfaceSetMovementState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetMovementState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->newMovementState = newMovementState;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Character_C_ReflectionImplementationFields.__InterfaceSetMovementState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x04017165 RID: 94565
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BPI_Character.BPI_Character_C";

		// Token: 0x0200A64C RID: 42572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceSetCharState_FunctionParams
		{
			// Token: 0x0403254B RID: 206155
			[FieldOffset(0)]
			public FGameplayTag newCharState;
		}

		// Token: 0x0200A64D RID: 42573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceSetGait_FunctionParams
		{
			// Token: 0x0403254C RID: 206156
			[FieldOffset(0)]
			public FGameplayTag newGait;
		}

		// Token: 0x0200A64E RID: 42574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceSetRotationMode_FunctionParams
		{
			// Token: 0x0403254D RID: 206157
			[FieldOffset(0)]
			public FGameplayTag newRotationMode;
		}

		// Token: 0x0200A64F RID: 42575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceSetMovementState_FunctionParams
		{
			// Token: 0x0403254E RID: 206158
			[FieldOffset(0)]
			public FGameplayTag newMovementState;
		}
	}
}
