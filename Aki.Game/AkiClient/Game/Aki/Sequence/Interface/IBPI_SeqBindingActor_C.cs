using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x02003078 RID: 12408
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqBindingActor.BPI_SeqBindingActor_C")]
	public interface IBPI_SeqBindingActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D95D RID: 121181 RVA: 0x008FC09C File Offset: 0x008FA29C
		[SkipLocalsInit]
		unsafe void GetSeqBindingTag(ref FName Tag)
		{
			IBPI_SeqBindingActor_C.__GetSeqBindingTag_FunctionParams* ptr = stackalloc IBPI_SeqBindingActor_C.__GetSeqBindingTag_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_SeqBindingActor_C.__GetSeqBindingTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqBindingActor_C_ReflectionImplementationFields.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqBindingActor_C_ReflectionImplementationFields.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr);
			Tag = ptr->Tag;
		}

		// Token: 0x0400F973 RID: 63859
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqBindingActor.BPI_SeqBindingActor_C";

		// Token: 0x02008D5F RID: 36191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetSeqBindingTag_FunctionParams
		{
			// Token: 0x0402C8E9 RID: 182505
			[FieldOffset(0)]
			public FName Tag;
		}
	}
}
