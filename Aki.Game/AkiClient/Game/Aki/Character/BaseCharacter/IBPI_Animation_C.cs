using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032DE RID: 13022
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BPI_Animation.BPI_Animation_C")]
	public interface IBPI_Animation_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060210AA RID: 135338 RVA: 0x00957A20 File Offset: 0x00955C20
		[SkipLocalsInit]
		unsafe void InterfaceControlPoint(FVector Offset)
		{
			IBPI_Animation_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210AB RID: 135339 RVA: 0x00957A68 File Offset: 0x00955C68
		[SkipLocalsInit]
		unsafe void InterfaceManipulateInteractDirection(float 角度)
		{
			IBPI_Animation_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210AC RID: 135340 RVA: 0x00957AB0 File Offset: 0x00955CB0
		[SkipLocalsInit]
		unsafe void InterfaceFixHookDirect(FVector Offset)
		{
			IBPI_Animation_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210AD RID: 135341 RVA: 0x00957AF8 File Offset: 0x00955CF8
		[SkipLocalsInit]
		unsafe void InterfaceSimulateJump(float Speed)
		{
			IBPI_Animation_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210AE RID: 135342 RVA: 0x00957B3E File Offset: 0x00955D3E
		[SkipLocalsInit]
		void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x060210AF RID: 135343 RVA: 0x00957B54 File Offset: 0x00955D54
		[SkipLocalsInit]
		unsafe void InterfaceJumpPressed(ref float Speed)
		{
			IBPI_Animation_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc IBPI_Animation_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_Animation_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Animation_C_ReflectionImplementationFields.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Animation_C_ReflectionImplementationFields.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x04011ED3 RID: 73427
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BPI_Animation.BPI_Animation_C";

		// Token: 0x0200907A RID: 36986
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CE8D RID: 183949
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200907B RID: 36987
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CE8E RID: 183950
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200907C RID: 36988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CE8F RID: 183951
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200907D RID: 36989
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CE90 RID: 183952
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200907E RID: 36990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CE91 RID: 183953
			[FieldOffset(0)]
			public float Speed;
		}
	}
}
