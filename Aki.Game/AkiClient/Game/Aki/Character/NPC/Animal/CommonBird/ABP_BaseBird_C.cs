using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonBird
{
	// Token: 0x02004247 RID: 16967
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonBird/ABP_BaseBird.ABP_BaseBird_C")]
	[UnrealStructLayout(4480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4472)]
	public class ABP_BaseBird_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF3B RID: 180027 RVA: 0x00A0FF69 File Offset: 0x00A0E169
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseBird_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonBird/ABP_BaseBird.ABP_BaseBird_C");
			}
			return ABP_BaseBird_C._ClassPtr;
		}

		// Token: 0x0602BF3C RID: 180028 RVA: 0x00A0FF90 File Offset: 0x00A0E190
		public ABP_BaseBird_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseBird_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF3D RID: 180029 RVA: 0x00A0FFB8 File Offset: 0x00A0E1B8
		[NullableContext(1)]
		public ABP_BaseBird_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseBird_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BF3E RID: 180030 RVA: 0x00A0FFEC File Offset: 0x00A0E1EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_BaseBird_C.__基础层_FunctionParams* ptr = stackalloc ABP_BaseBird_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseBird_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseBird_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseBird_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BF3F RID: 180031 RVA: 0x00A10074 File Offset: 0x00A0E274
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseBird_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseBird_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseBird_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseBird_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseBird_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BF40 RID: 180032 RVA: 0x00A100FB File Offset: 0x00A0E2FB
		protected ABP_BaseBird_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F2D RID: 93997
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonBird/ABP_BaseBird.ABP_BaseBird_C";

		// Token: 0x04016F2E RID: 93998
		private static IntPtr _ClassPtr;

		// Token: 0x04016F2F RID: 93999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F30 RID: 94000
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016F31 RID: 94001
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A5A4 RID: 42404
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x04032437 RID: 205879
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A5A5 RID: 42405
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032438 RID: 205880
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
