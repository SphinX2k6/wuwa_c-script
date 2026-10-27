using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.Accessory.Acc_HYtuanzi_mone
{
	// Token: 0x02004048 RID: 16456
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_mone/ABP_Acc_HYtuanzi_mone.ABP_Acc_HYtuanzi_mone_C")]
	[UnrealStructLayout(2464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2456)]
	public class ABP_Acc_HYtuanzi_mone_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A498 RID: 173208 RVA: 0x009DB828 File Offset: 0x009D9A28
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Acc_HYtuanzi_mone_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_mone/ABP_Acc_HYtuanzi_mone.ABP_Acc_HYtuanzi_mone_C");
			}
			return ABP_Acc_HYtuanzi_mone_C._ClassPtr;
		}

		// Token: 0x0602A499 RID: 173209 RVA: 0x009DB84C File Offset: 0x009D9A4C
		public ABP_Acc_HYtuanzi_mone_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_mone_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A49A RID: 173210 RVA: 0x009DB874 File Offset: 0x009D9A74
		[NullableContext(1)]
		public ABP_Acc_HYtuanzi_mone_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_mone_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A49B RID: 173211 RVA: 0x009DB8A8 File Offset: 0x009D9AA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Acc_HYtuanzi_mone_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Acc_HYtuanzi_mone_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Acc_HYtuanzi_mone_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Acc_HYtuanzi_mone_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Acc_HYtuanzi_mone_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A49C RID: 173212 RVA: 0x009DB92F File Offset: 0x009D9B2F
		protected ABP_Acc_HYtuanzi_mone_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CEB RID: 89323
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_mone/ABP_Acc_HYtuanzi_mone.ABP_Acc_HYtuanzi_mone_C";

		// Token: 0x04015CEC RID: 89324
		private static IntPtr _ClassPtr;

		// Token: 0x04015CED RID: 89325
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CEE RID: 89326
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A360 RID: 41824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032130 RID: 205104
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
