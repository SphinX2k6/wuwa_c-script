using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004274 RID: 17012
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BPI_Animation.BPI_Animation_C")]
	public interface IBPI_Animation_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602C202 RID: 180738 RVA: 0x00A16EA8 File Offset: 0x00A150A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceControlPoint(FVector Offset)
		{
			IBPI_Animation_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C203 RID: 180739 RVA: 0x00A16EF0 File Offset: 0x00A150F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceManipulateInteractDirection(float 角度)
		{
			IBPI_Animation_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C204 RID: 180740 RVA: 0x00A16F38 File Offset: 0x00A15138
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceFixHookDirect(FVector Offset)
		{
			IBPI_Animation_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C205 RID: 180741 RVA: 0x00A16F80 File Offset: 0x00A15180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceSimulateJump(float Speed)
		{
			IBPI_Animation_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C206 RID: 180742 RVA: 0x00A16FC6 File Offset: 0x00A151C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602C207 RID: 180743 RVA: 0x00A16FDC File Offset: 0x00A151DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InterfaceJumpPressed(ref float Speed)
		{
			IBPI_Animation_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x04017163 RID: 94563
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BPI_Animation.BPI_Animation_C";

		// Token: 0x0200A647 RID: 42567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x04032546 RID: 206150
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A648 RID: 42568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x04032547 RID: 206151
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A649 RID: 42569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x04032548 RID: 206152
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A64A RID: 42570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x04032549 RID: 206153
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A64B RID: 42571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0403254A RID: 206154
			[FieldOffset(0)]
			public float Speed;
		}
	}
}
