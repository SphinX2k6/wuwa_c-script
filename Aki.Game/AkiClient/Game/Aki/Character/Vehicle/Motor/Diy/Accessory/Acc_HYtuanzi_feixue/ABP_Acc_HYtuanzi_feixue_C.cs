using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.Accessory.Acc_HYtuanzi_feixue
{
	// Token: 0x02004049 RID: 16457
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_feixue/ABP_Acc_HYtuanzi_feixue.ABP_Acc_HYtuanzi_feixue_C")]
	[UnrealStructLayout(2464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2456)]
	public class ABP_Acc_HYtuanzi_feixue_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A49D RID: 173213 RVA: 0x009DB938 File Offset: 0x009D9B38
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Acc_HYtuanzi_feixue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_feixue/ABP_Acc_HYtuanzi_feixue.ABP_Acc_HYtuanzi_feixue_C");
			}
			return ABP_Acc_HYtuanzi_feixue_C._ClassPtr;
		}

		// Token: 0x0602A49E RID: 173214 RVA: 0x009DB95C File Offset: 0x009D9B5C
		public ABP_Acc_HYtuanzi_feixue_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_feixue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A49F RID: 173215 RVA: 0x009DB984 File Offset: 0x009D9B84
		[NullableContext(1)]
		public ABP_Acc_HYtuanzi_feixue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_feixue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4A0 RID: 173216 RVA: 0x009DB9B8 File Offset: 0x009D9BB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Acc_HYtuanzi_feixue_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Acc_HYtuanzi_feixue_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Acc_HYtuanzi_feixue_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Acc_HYtuanzi_feixue_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Acc_HYtuanzi_feixue_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A4A1 RID: 173217 RVA: 0x009DBA3F File Offset: 0x009D9C3F
		protected ABP_Acc_HYtuanzi_feixue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CEF RID: 89327
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_feixue/ABP_Acc_HYtuanzi_feixue.ABP_Acc_HYtuanzi_feixue_C";

		// Token: 0x04015CF0 RID: 89328
		private static IntPtr _ClassPtr;

		// Token: 0x04015CF1 RID: 89329
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CF2 RID: 89330
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A361 RID: 41825
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032131 RID: 205105
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
