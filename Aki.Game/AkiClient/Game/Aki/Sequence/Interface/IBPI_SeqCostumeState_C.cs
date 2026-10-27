using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x02003A3A RID: 14906
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqCostumeState.BPI_SeqCostumeState_C")]
	public interface IBPI_SeqCostumeState_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F643 RID: 128579 RVA: 0x008B732C File Offset: 0x008B552C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void ClearSeqCostumeState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqCostumeState_C_ReflectionImplementationFields.__ClearSeqCostumeState_NativeFunctionPtr, null);
		}

		// Token: 0x0601F644 RID: 128580 RVA: 0x008B7340 File Offset: 0x008B5540
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ApplySeqCostumeState(int State)
		{
			IBPI_SeqCostumeState_C.__ApplySeqCostumeState_FunctionParams* ptr = stackalloc IBPI_SeqCostumeState_C.__ApplySeqCostumeState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_SeqCostumeState_C.__ApplySeqCostumeState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqCostumeState_C_ReflectionImplementationFields.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqCostumeState_C_ReflectionImplementationFields.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0400F12F RID: 61743
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqCostumeState.BPI_SeqCostumeState_C";

		// Token: 0x02009AD4 RID: 39636
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplySeqCostumeState_FunctionParams
		{
			// Token: 0x0403107C RID: 200828
			[FieldOffset(0)]
			public int State;
		}
	}
}
