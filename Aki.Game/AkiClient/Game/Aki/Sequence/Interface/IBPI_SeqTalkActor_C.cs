using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x02003A3C RID: 14908
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqTalkActor.BPI_SeqTalkActor_C")]
	public interface IBPI_SeqTalkActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F646 RID: 128582 RVA: 0x008B7414 File Offset: 0x008B5614
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			IBPI_SeqTalkActor_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc IBPI_SeqTalkActor_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_SeqTalkActor_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqTalkActor_C_ReflectionImplementationFields.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref IBPI_SeqTalkActor_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqTalkActor_C_ReflectionImplementationFields.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0601F647 RID: 128583 RVA: 0x008B7478 File Offset: 0x008B5678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			IBPI_SeqTalkActor_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc IBPI_SeqTalkActor_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_SeqTalkActor_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqTalkActor_C_ReflectionImplementationFields.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqTalkActor_C_ReflectionImplementationFields.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0400F131 RID: 61745
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqTalkActor.BPI_SeqTalkActor_C";

		// Token: 0x02009AD6 RID: 39638
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0403107E RID: 200830
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02009AD7 RID: 39639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x0403107F RID: 200831
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x04031080 RID: 200832
			[FieldOffset(4)]
			public int TalkID_SP;
		}
	}
}
