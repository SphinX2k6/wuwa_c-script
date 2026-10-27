using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x02004114 RID: 16660
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_AssistedWalk.ABP_BaseRole_Gameplay_AssistedWalk_C")]
	[UnrealStructLayout(8064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8049)]
	public class ABP_BaseRole_Gameplay_AssistedWalk_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE22 RID: 175650 RVA: 0x009EE858 File Offset: 0x009ECA58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_AssistedWalk_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_AssistedWalk.ABP_BaseRole_Gameplay_AssistedWalk_C");
			}
			return ABP_BaseRole_Gameplay_AssistedWalk_C._ClassPtr;
		}

		// Token: 0x0602AE23 RID: 175651 RVA: 0x009EE87C File Offset: 0x009ECA7C
		public ABP_BaseRole_Gameplay_AssistedWalk_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_AssistedWalk_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE24 RID: 175652 RVA: 0x009EE8A4 File Offset: 0x009ECAA4
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_AssistedWalk_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_AssistedWalk_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006988 RID: 27016
		// (get) Token: 0x0602AE25 RID: 175653 RVA: 0x009EE8D7 File Offset: 0x009ECAD7
		// (set) Token: 0x0602AE26 RID: 175654 RVA: 0x009EE8EB File Offset: 0x009ECAEB
		public unsafe TsBaseCharacter As_Ts_Base_Character
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_AssistedWalk_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_AssistedWalk_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17006989 RID: 27017
		// (get) Token: 0x0602AE27 RID: 175655 RVA: 0x009EE900 File Offset: 0x009ECB00
		// (set) Token: 0x0602AE28 RID: 175656 RVA: 0x009EE914 File Offset: 0x009ECB14
		public unsafe UKuroAnimInstanceChar As_Kuro_Anim_Instance_Char
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceChar>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_AssistedWalk_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_AssistedWalk_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x1700698A RID: 27018
		// (get) Token: 0x0602AE29 RID: 175657 RVA: 0x009EE929 File Offset: 0x009ECB29
		// (set) Token: 0x0602AE2A RID: 175658 RVA: 0x009EE939 File Offset: 0x009ECB39
		public unsafe bool IsStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_AssistedWalk_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_AssistedWalk_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AE2B RID: 175659 RVA: 0x009EE94C File Offset: 0x009ECB4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_AssistedWalk_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_AssistedWalk_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_AssistedWalk_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_AssistedWalk_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_AssistedWalk_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AE2C RID: 175660 RVA: 0x009EE9D3 File Offset: 0x009ECBD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_AssistedWalk_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AE2D RID: 175661 RVA: 0x009EE9E7 File Offset: 0x009ECBE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_AssistedWalk_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AE2E RID: 175662 RVA: 0x009EE9FC File Offset: 0x009ECBFC
		protected ABP_BaseRole_Gameplay_AssistedWalk_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401639C RID: 91036
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_AssistedWalk.ABP_BaseRole_Gameplay_AssistedWalk_C";

		// Token: 0x0401639D RID: 91037
		private static IntPtr _ClassPtr;

		// Token: 0x0401639E RID: 91038
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401639F RID: 91039
		internal static int __PropertyOffset_45;

		// Token: 0x040163A0 RID: 91040
		internal static int __PropertyOffset_46;

		// Token: 0x040163A1 RID: 91041
		internal static int __PropertyOffset_47;

		// Token: 0x040163A2 RID: 91042
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040163A3 RID: 91043
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A41D RID: 42013
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032256 RID: 205398
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
