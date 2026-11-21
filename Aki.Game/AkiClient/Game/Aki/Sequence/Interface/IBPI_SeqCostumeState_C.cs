using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x0200307A RID: 12410
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqCostumeState.BPI_SeqCostumeState_C")]
	public interface IBPI_SeqCostumeState_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D961 RID: 121185 RVA: 0x008FC224 File Offset: 0x008FA424
		[SkipLocalsInit]
		void ClearSeqCostumeState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqCostumeState_C_ReflectionImplementationFields.__ClearSeqCostumeState_NativeFunctionPtr, null);
		}

		// Token: 0x0601D962 RID: 121186 RVA: 0x008FC238 File Offset: 0x008FA438
		[SkipLocalsInit]
		unsafe void ApplySeqCostumeState(int State)
		{
			IBPI_SeqCostumeState_C.__ApplySeqCostumeState_FunctionParams* ptr = stackalloc IBPI_SeqCostumeState_C.__ApplySeqCostumeState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_SeqCostumeState_C.__ApplySeqCostumeState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqCostumeState_C_ReflectionImplementationFields.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqCostumeState_C_ReflectionImplementationFields.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0400F975 RID: 63861
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqCostumeState.BPI_SeqCostumeState_C";

		// Token: 0x02008D63 RID: 36195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplySeqCostumeState_FunctionParams
		{
			// Token: 0x0402C8EF RID: 182511
			[FieldOffset(0)]
			public int State;
		}
	}
}
