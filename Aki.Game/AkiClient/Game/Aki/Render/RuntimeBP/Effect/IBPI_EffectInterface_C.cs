using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect
{
	// Token: 0x02003DB4 RID: 15796
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/BPI_EffectInterface.BPI_EffectInterface_C")]
	public interface IBPI_EffectInterface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060273EA RID: 160746 RVA: 0x0098C144 File Offset: 0x0098A344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EffectInterface_C_ReflectionImplementationFields.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x060273EB RID: 160747 RVA: 0x0098C158 File Offset: 0x0098A358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetHandle(int Handle)
		{
			IBPI_EffectInterface_C.__SetHandle_FunctionParams* ptr = stackalloc IBPI_EffectInterface_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_EffectInterface_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_EffectInterface_C_ReflectionImplementationFields.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EffectInterface_C_ReflectionImplementationFields.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060273EC RID: 160748 RVA: 0x0098C1A0 File Offset: 0x0098A3A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetHandle(ref int Handle)
		{
			IBPI_EffectInterface_C.__GetHandle_FunctionParams* ptr = stackalloc IBPI_EffectInterface_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_EffectInterface_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_EffectInterface_C_ReflectionImplementationFields.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EffectInterface_C_ReflectionImplementationFields.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x04013CC5 RID: 81093
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/BPI_EffectInterface.BPI_EffectInterface_C";

		// Token: 0x0200A208 RID: 41480
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x04031E70 RID: 204400
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x0200A209 RID: 41481
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x04031E71 RID: 204401
			[FieldOffset(0)]
			public int Handle;
		}
	}
}
