using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x0200307C RID: 12412
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqTalkActor.BPI_SeqTalkActor_C")]
	public interface IBPI_SeqTalkActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D964 RID: 121188 RVA: 0x008FC30C File Offset: 0x008FA50C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D965 RID: 121189 RVA: 0x008FC370 File Offset: 0x008FA570
		[SkipLocalsInit]
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

		// Token: 0x0400F977 RID: 63863
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqTalkActor.BPI_SeqTalkActor_C";

		// Token: 0x02008D65 RID: 36197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0402C8F1 RID: 182513
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02008D66 RID: 36198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x0402C8F2 RID: 182514
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x0402C8F3 RID: 182515
			[FieldOffset(4)]
			public int TalkID_SP;
		}
	}
}
