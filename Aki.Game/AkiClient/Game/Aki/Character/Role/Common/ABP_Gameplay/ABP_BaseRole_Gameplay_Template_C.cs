using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x0200411B RID: 16667
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Template.ABP_BaseRole_Gameplay_Template_C")]
	[UnrealStructLayout(3824, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3824)]
	public class ABP_BaseRole_Gameplay_Template_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AEB4 RID: 175796 RVA: 0x009EFBD9 File Offset: 0x009EDDD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Template_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Template.ABP_BaseRole_Gameplay_Template_C");
			}
			return ABP_BaseRole_Gameplay_Template_C._ClassPtr;
		}

		// Token: 0x0602AEB5 RID: 175797 RVA: 0x009EFC00 File Offset: 0x009EDE00
		public ABP_BaseRole_Gameplay_Template_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Template_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AEB6 RID: 175798 RVA: 0x009EFC28 File Offset: 0x009EDE28
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Template_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Template_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AEB7 RID: 175799 RVA: 0x009EFC5C File Offset: 0x009EDE5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_Template_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Template_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Template_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Template_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Template_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AEB8 RID: 175800 RVA: 0x009EFCE3 File Offset: 0x009EDEE3
		protected ABP_BaseRole_Gameplay_Template_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163F6 RID: 91126
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Template.ABP_BaseRole_Gameplay_Template_C";

		// Token: 0x040163F7 RID: 91127
		private static IntPtr _ClassPtr;

		// Token: 0x040163F8 RID: 91128
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163F9 RID: 91129
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A430 RID: 42032
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403226B RID: 205419
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
