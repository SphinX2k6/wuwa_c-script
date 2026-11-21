using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect
{
	// Token: 0x020030FF RID: 12543
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/BPI_EffectInterface.BPI_EffectInterface_C")]
	public interface IBPI_EffectInterface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601EAD4 RID: 125652 RVA: 0x0091A19B File Offset: 0x0091839B
		[SkipLocalsInit]
		void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EffectInterface_C_ReflectionImplementationFields.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x0601EAD5 RID: 125653 RVA: 0x0091A1B0 File Offset: 0x009183B0
		[SkipLocalsInit]
		unsafe void SetHandle(int Handle)
		{
			IBPI_EffectInterface_C.__SetHandle_FunctionParams* ptr = stackalloc IBPI_EffectInterface_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_EffectInterface_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_EffectInterface_C_ReflectionImplementationFields.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EffectInterface_C_ReflectionImplementationFields.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAD6 RID: 125654 RVA: 0x0091A1F8 File Offset: 0x009183F8
		[SkipLocalsInit]
		unsafe void GetHandle(ref int Handle)
		{
			IBPI_EffectInterface_C.__GetHandle_FunctionParams* ptr = stackalloc IBPI_EffectInterface_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_EffectInterface_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_EffectInterface_C_ReflectionImplementationFields.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EffectInterface_C_ReflectionImplementationFields.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x04010473 RID: 66675
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/BPI_EffectInterface.BPI_EffectInterface_C";

		// Token: 0x02008EB5 RID: 36533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x0402CB52 RID: 183122
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008EB6 RID: 36534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x0402CB53 RID: 183123
			[FieldOffset(0)]
			public int Handle;
		}
	}
}
