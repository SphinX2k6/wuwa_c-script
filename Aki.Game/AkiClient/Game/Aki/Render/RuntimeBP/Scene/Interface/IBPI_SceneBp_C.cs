using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface
{
	// Token: 0x02003B3C RID: 15164
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_SceneBp.BPI_SceneBp_C")]
	public interface IBPI_SceneBp_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060218C7 RID: 137415 RVA: 0x008EF378 File Offset: 0x008ED578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ShouldStopOnHide(ref bool ret)
		{
			IBPI_SceneBp_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc IBPI_SceneBp_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_SceneBp_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SceneBp_C_ReflectionImplementationFields.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x060218C8 RID: 137416 RVA: 0x008EF3C7 File Offset: 0x008ED5C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x060218C9 RID: 137417 RVA: 0x008EF3DB File Offset: 0x008ED5DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x060218CA RID: 137418 RVA: 0x008EF3F0 File Offset: 0x008ED5F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetAoiRange(ref int ret)
		{
			IBPI_SceneBp_C.__GetAoiRange_FunctionParams* ptr = stackalloc IBPI_SceneBp_C.__GetAoiRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_SceneBp_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SceneBp_C_ReflectionImplementationFields.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x060218CB RID: 137419 RVA: 0x008EF43F File Offset: 0x008ED63F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x060218CC RID: 137420 RVA: 0x008EF453 File Offset: 0x008ED653
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x060218CD RID: 137421 RVA: 0x008EF467 File Offset: 0x008ED667
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0401059B RID: 66971
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_SceneBp.BPI_SceneBp_C";

		// Token: 0x02009CA4 RID: 40100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0403136D RID: 201581
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02009CA5 RID: 40101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0403136E RID: 201582
			[FieldOffset(0)]
			public int ret;
		}
	}
}
