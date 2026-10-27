using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.Accessory.Acc_HYtuanzi_xinyuehu
{
	// Token: 0x02004046 RID: 16454
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_xinyuehu/ABP_Acc_HYtuanzi_xinyuehu.ABP_Acc_HYtuanzi_xinyuehu_C")]
	[UnrealStructLayout(2464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2456)]
	public class ABP_Acc_HYtuanzi_xinyuehu_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A48D RID: 173197 RVA: 0x009DB559 File Offset: 0x009D9759
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Acc_HYtuanzi_xinyuehu_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_xinyuehu/ABP_Acc_HYtuanzi_xinyuehu.ABP_Acc_HYtuanzi_xinyuehu_C");
			}
			return ABP_Acc_HYtuanzi_xinyuehu_C._ClassPtr;
		}

		// Token: 0x0602A48E RID: 173198 RVA: 0x009DB580 File Offset: 0x009D9780
		public ABP_Acc_HYtuanzi_xinyuehu_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_xinyuehu_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A48F RID: 173199 RVA: 0x009DB5A8 File Offset: 0x009D97A8
		[NullableContext(1)]
		public ABP_Acc_HYtuanzi_xinyuehu_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_xinyuehu_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A490 RID: 173200 RVA: 0x009DB5DC File Offset: 0x009D97DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Acc_HYtuanzi_xinyuehu_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Acc_HYtuanzi_xinyuehu_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Acc_HYtuanzi_xinyuehu_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Acc_HYtuanzi_xinyuehu_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Acc_HYtuanzi_xinyuehu_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A491 RID: 173201 RVA: 0x009DB663 File Offset: 0x009D9863
		protected ABP_Acc_HYtuanzi_xinyuehu_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CE2 RID: 89314
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_xinyuehu/ABP_Acc_HYtuanzi_xinyuehu.ABP_Acc_HYtuanzi_xinyuehu_C";

		// Token: 0x04015CE3 RID: 89315
		private static IntPtr _ClassPtr;

		// Token: 0x04015CE4 RID: 89316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CE5 RID: 89317
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A35D RID: 41821
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403212C RID: 205100
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
