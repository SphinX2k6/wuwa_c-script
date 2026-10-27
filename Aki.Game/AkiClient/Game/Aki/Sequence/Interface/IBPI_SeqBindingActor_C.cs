using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x02003A38 RID: 14904
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqBindingActor.BPI_SeqBindingActor_C")]
	public interface IBPI_SeqBindingActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F63F RID: 128575 RVA: 0x008B71A4 File Offset: 0x008B53A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetSeqBindingTag(ref FName Tag)
		{
			IBPI_SeqBindingActor_C.__GetSeqBindingTag_FunctionParams* ptr = stackalloc IBPI_SeqBindingActor_C.__GetSeqBindingTag_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_SeqBindingActor_C.__GetSeqBindingTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqBindingActor_C_ReflectionImplementationFields.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqBindingActor_C_ReflectionImplementationFields.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr);
			Tag = ptr->Tag;
		}

		// Token: 0x0400F12D RID: 61741
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqBindingActor.BPI_SeqBindingActor_C";

		// Token: 0x02009AD0 RID: 39632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetSeqBindingTag_FunctionParams
		{
			// Token: 0x04031076 RID: 200822
			[FieldOffset(0)]
			public FName Tag;
		}
	}
}
