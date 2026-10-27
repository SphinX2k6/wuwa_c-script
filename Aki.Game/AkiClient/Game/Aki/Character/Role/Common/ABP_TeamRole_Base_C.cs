using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x020040A0 RID: 16544
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_TeamRole_Base.ABP_TeamRole_Base_C")]
	[UnrealStructLayout(3856, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3852)]
	public class ABP_TeamRole_Base_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AB55 RID: 174933 RVA: 0x009E980C File Offset: 0x009E7A0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_TeamRole_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_TeamRole_Base.ABP_TeamRole_Base_C");
			}
			return ABP_TeamRole_Base_C._ClassPtr;
		}

		// Token: 0x0602AB56 RID: 174934 RVA: 0x009E9830 File Offset: 0x009E7A30
		public ABP_TeamRole_Base_C() : this(BuiltinUtils.AllocNativeUObject(ABP_TeamRole_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AB57 RID: 174935 RVA: 0x009E9858 File Offset: 0x009E7A58
		[NullableContext(1)]
		public ABP_TeamRole_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_TeamRole_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006911 RID: 26897
		// (get) Token: 0x0602AB58 RID: 174936 RVA: 0x009E988B File Offset: 0x009E7A8B
		// (set) Token: 0x0602AB59 RID: 174937 RVA: 0x009E989B File Offset: 0x009E7A9B
		public unsafe int Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TeamRole_Base_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TeamRole_Base_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x0602AB5A RID: 174938 RVA: 0x009E98AC File Offset: 0x009E7AAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_TeamRole_Base_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_TeamRole_Base_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_TeamRole_Base_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TeamRole_Base_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TeamRole_Base_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AB5B RID: 174939 RVA: 0x009E9934 File Offset: 0x009E7B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPosition(int Postion)
		{
			ABP_TeamRole_Base_C.__SetPosition_FunctionParams* ptr = stackalloc ABP_TeamRole_Base_C.__SetPosition_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_TeamRole_Base_C.__SetPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TeamRole_Base_C.__SetPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Postion = Postion;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TeamRole_Base_C.__SetPosition_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB5C RID: 174940 RVA: 0x009E997A File Offset: 0x009E7B7A
		protected ABP_TeamRole_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040161A6 RID: 90534
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_TeamRole_Base.ABP_TeamRole_Base_C";

		// Token: 0x040161A7 RID: 90535
		private static IntPtr _ClassPtr;

		// Token: 0x040161A8 RID: 90536
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040161A9 RID: 90537
		internal static int __PropertyOffset_16;

		// Token: 0x040161AA RID: 90538
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040161AB RID: 90539
		private static IntPtr __SetPosition_NativeFunctionPtr;

		// Token: 0x0200A418 RID: 42008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032251 RID: 205393
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A419 RID: 42009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPosition_FunctionParams
		{
			// Token: 0x04032252 RID: 205394
			[FieldOffset(0)]
			public int Postion;
		}
	}
}
