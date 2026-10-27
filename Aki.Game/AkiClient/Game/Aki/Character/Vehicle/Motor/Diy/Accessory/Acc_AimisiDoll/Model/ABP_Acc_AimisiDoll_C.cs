using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.Accessory.Acc_AimisiDoll.Model
{
	// Token: 0x0200404A RID: 16458
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_AimisiDoll/Model/ABP_Acc_AimisiDoll.ABP_Acc_AimisiDoll_C")]
	[UnrealStructLayout(2464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2456)]
	public class ABP_Acc_AimisiDoll_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4A2 RID: 173218 RVA: 0x009DBA48 File Offset: 0x009D9C48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Acc_AimisiDoll_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_AimisiDoll/Model/ABP_Acc_AimisiDoll.ABP_Acc_AimisiDoll_C");
			}
			return ABP_Acc_AimisiDoll_C._ClassPtr;
		}

		// Token: 0x0602A4A3 RID: 173219 RVA: 0x009DBA6C File Offset: 0x009D9C6C
		public ABP_Acc_AimisiDoll_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_AimisiDoll_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4A4 RID: 173220 RVA: 0x009DBA94 File Offset: 0x009D9C94
		[NullableContext(1)]
		public ABP_Acc_AimisiDoll_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_AimisiDoll_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4A5 RID: 173221 RVA: 0x009DBAC8 File Offset: 0x009D9CC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Acc_AimisiDoll_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Acc_AimisiDoll_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Acc_AimisiDoll_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Acc_AimisiDoll_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Acc_AimisiDoll_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A4A6 RID: 173222 RVA: 0x009DBB4F File Offset: 0x009D9D4F
		protected ABP_Acc_AimisiDoll_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CF3 RID: 89331
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_AimisiDoll/Model/ABP_Acc_AimisiDoll.ABP_Acc_AimisiDoll_C";

		// Token: 0x04015CF4 RID: 89332
		private static IntPtr _ClassPtr;

		// Token: 0x04015CF5 RID: 89333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CF6 RID: 89334
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A362 RID: 41826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032132 RID: 205106
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
