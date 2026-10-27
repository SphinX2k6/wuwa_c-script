using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x0200426C RID: 17004
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_MascotInterface.ABPC_Seq_MascotInterface_C")]
	public interface IABPC_Seq_MascotInterface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602C19B RID: 180635 RVA: 0x00A159B4 File Offset: 0x00A13BB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetAddSpineHeadValue(ref FRotator AddSpineHead)
		{
			IABPC_Seq_MascotInterface_C.__GetAddSpineHeadValue_FunctionParams* ptr = stackalloc IABPC_Seq_MascotInterface_C.__GetAddSpineHeadValue_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IABPC_Seq_MascotInterface_C.__GetAddSpineHeadValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IABPC_Seq_MascotInterface_C_ReflectionImplementationFields.__GetAddSpineHeadValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AddSpineHead = AddSpineHead;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IABPC_Seq_MascotInterface_C_ReflectionImplementationFields.__GetAddSpineHeadValue_NativeFunctionPtr, (void*)ptr);
			AddSpineHead = ptr->AddSpineHead;
		}

		// Token: 0x0602C19C RID: 180636 RVA: 0x00A15A0C File Offset: 0x00A13C0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetAddSpineValue(ref FRotator AddSpine)
		{
			IABPC_Seq_MascotInterface_C.__GetAddSpineValue_FunctionParams* ptr = stackalloc IABPC_Seq_MascotInterface_C.__GetAddSpineValue_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IABPC_Seq_MascotInterface_C.__GetAddSpineValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IABPC_Seq_MascotInterface_C_ReflectionImplementationFields.__GetAddSpineValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AddSpine = AddSpine;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IABPC_Seq_MascotInterface_C_ReflectionImplementationFields.__GetAddSpineValue_NativeFunctionPtr, (void*)ptr);
			AddSpine = ptr->AddSpine;
		}

		// Token: 0x0401710D RID: 94477
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_MascotInterface.ABPC_Seq_MascotInterface_C";

		// Token: 0x0200A62A RID: 42538
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetAddSpineHeadValue_FunctionParams
		{
			// Token: 0x04032514 RID: 206100
			[FieldOffset(0)]
			public FRotator AddSpineHead;
		}

		// Token: 0x0200A62B RID: 42539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetAddSpineValue_FunctionParams
		{
			// Token: 0x04032515 RID: 206101
			[FieldOffset(0)]
			public FRotator AddSpine;
		}
	}
}
