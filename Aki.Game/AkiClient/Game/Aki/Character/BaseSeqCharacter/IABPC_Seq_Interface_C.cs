using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x0200426B RID: 17003
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Interface.ABPC_Seq_Interface_C")]
	public interface IABPC_Seq_Interface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602C19A RID: 180634 RVA: 0x00A15950 File Offset: 0x00A13B50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetABPC_Body_V2(ref ABPC_Seq_Body_V2_C ABPC_Body_V2)
		{
			IABPC_Seq_Interface_C.__GetABPC_Body_V2_FunctionParams* ptr = stackalloc IABPC_Seq_Interface_C.__GetABPC_Body_V2_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IABPC_Seq_Interface_C.__GetABPC_Body_V2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IABPC_Seq_Interface_C_ReflectionImplementationFields.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr, 1);
			ref IABPC_Seq_Interface_C.__GetABPC_Body_V2_FunctionParams ptr2 = ref *ptr;
			ABPC_Seq_Body_V2_C abpc_Seq_Body_V2_C = ABPC_Body_V2;
			ptr2.ABPC_Body_V2 = ((abpc_Seq_Body_V2_C != null) ? abpc_Seq_Body_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IABPC_Seq_Interface_C_ReflectionImplementationFields.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr);
			ABPC_Body_V2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ABPC_Seq_Body_V2_C>(ptr->ABPC_Body_V2);
		}

		// Token: 0x0401710C RID: 94476
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/ABPC_Seq_Interface.ABPC_Seq_Interface_C";

		// Token: 0x0200A629 RID: 42537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetABPC_Body_V2_FunctionParams
		{
			// Token: 0x04032513 RID: 206099
			[FieldOffset(0)]
			public IntPtr ABPC_Body_V2;
		}
	}
}
