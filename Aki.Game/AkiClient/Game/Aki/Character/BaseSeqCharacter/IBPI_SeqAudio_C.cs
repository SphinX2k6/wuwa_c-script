using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x020032DA RID: 13018
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/BPI_SeqAudio.BPI_SeqAudio_C")]
	public interface IBPI_SeqAudio_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602104A RID: 135242 RVA: 0x009567E4 File Offset: 0x009549E4
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe void GetSeqAudio(ref SeqAudio_Seq_V2_C SeqAudio)
		{
			IBPI_SeqAudio_C.__GetSeqAudio_FunctionParams* ptr = stackalloc IBPI_SeqAudio_C.__GetSeqAudio_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_SeqAudio_C.__GetSeqAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqAudio_C_ReflectionImplementationFields.__GetSeqAudio_NativeFunctionPtr, (void*)ptr, 1);
			ref IBPI_SeqAudio_C.__GetSeqAudio_FunctionParams ptr2 = ref *ptr;
			SeqAudio_Seq_V2_C seqAudio_Seq_V2_C = SeqAudio;
			ptr2.SeqAudio = ((seqAudio_Seq_V2_C != null) ? seqAudio_Seq_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqAudio_C_ReflectionImplementationFields.__GetSeqAudio_NativeFunctionPtr, (void*)ptr);
			SeqAudio = BuiltinUtils.GetOrCreateUObjectByNativePointer<SeqAudio_Seq_V2_C>(ptr->SeqAudio);
		}

		// Token: 0x04011E91 RID: 73361
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/BPI_SeqAudio.BPI_SeqAudio_C";

		// Token: 0x02009061 RID: 36961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x0402CE61 RID: 183905
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}
	}
}
