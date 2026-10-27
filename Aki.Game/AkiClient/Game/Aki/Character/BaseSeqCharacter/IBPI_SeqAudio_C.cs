using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x0200426D RID: 17005
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/BPI_SeqAudio.BPI_SeqAudio_C")]
	public interface IBPI_SeqAudio_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602C19D RID: 180637 RVA: 0x00A15A64 File Offset: 0x00A13C64
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0401710E RID: 94478
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/BPI_SeqAudio.BPI_SeqAudio_C";

		// Token: 0x0200A62C RID: 42540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x04032516 RID: 206102
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}
	}
}
