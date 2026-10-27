using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common.Gameplay
{
	// Token: 0x020041A1 RID: 16801
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/Gameplay/ABP_BaseNPC_Gameplay_Default.ABP_BaseNPC_Gameplay_Default_C")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class ABP_BaseNPC_Gameplay_Default_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BB0D RID: 178957 RVA: 0x00A0799B File Offset: 0x00A05B9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseNPC_Gameplay_Default_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/Gameplay/ABP_BaseNPC_Gameplay_Default.ABP_BaseNPC_Gameplay_Default_C");
			}
			return ABP_BaseNPC_Gameplay_Default_C._ClassPtr;
		}

		// Token: 0x0602BB0E RID: 178958 RVA: 0x00A079C0 File Offset: 0x00A05BC0
		public ABP_BaseNPC_Gameplay_Default_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_Gameplay_Default_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BB0F RID: 178959 RVA: 0x00A079E8 File Offset: 0x00A05BE8
		[NullableContext(1)]
		public ABP_BaseNPC_Gameplay_Default_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_Gameplay_Default_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BB10 RID: 178960 RVA: 0x00A07A1C File Offset: 0x00A05C1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseNPC_Gameplay_Default_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseNPC_Gameplay_Default_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseNPC_Gameplay_Default_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_Gameplay_Default_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_Gameplay_Default_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BB11 RID: 178961 RVA: 0x00A07AA3 File Offset: 0x00A05CA3
		protected ABP_BaseNPC_Gameplay_Default_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016C24 RID: 93220
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/Gameplay/ABP_BaseNPC_Gameplay_Default.ABP_BaseNPC_Gameplay_Default_C";

		// Token: 0x04016C25 RID: 93221
		private static IntPtr _ClassPtr;

		// Token: 0x04016C26 RID: 93222
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016C27 RID: 93223
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A580 RID: 42368
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032408 RID: 205832
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
