using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x02004119 RID: 16665
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_SlopeSlide.ABP_BaseRole_Gameplay_SlopeSlide_C")]
	[UnrealStructLayout(9056, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9049)]
	public class ABP_BaseRole_Gameplay_SlopeSlide_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE9A RID: 175770 RVA: 0x009EF879 File Offset: 0x009EDA79
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_SlopeSlide_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_SlopeSlide.ABP_BaseRole_Gameplay_SlopeSlide_C");
			}
			return ABP_BaseRole_Gameplay_SlopeSlide_C._ClassPtr;
		}

		// Token: 0x0602AE9B RID: 175771 RVA: 0x009EF8A0 File Offset: 0x009EDAA0
		public ABP_BaseRole_Gameplay_SlopeSlide_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_SlopeSlide_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE9C RID: 175772 RVA: 0x009EF8C8 File Offset: 0x009EDAC8
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_SlopeSlide_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_SlopeSlide_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069AA RID: 27050
		// (get) Token: 0x0602AE9D RID: 175773 RVA: 0x009EF8FB File Offset: 0x009EDAFB
		// (set) Token: 0x0602AE9E RID: 175774 RVA: 0x009EF90F File Offset: 0x009EDB0F
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SlopeSlide_C.__PropertyOffset_52);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SlopeSlide_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x170069AB RID: 27051
		// (get) Token: 0x0602AE9F RID: 175775 RVA: 0x009EF924 File Offset: 0x009EDB24
		// (set) Token: 0x0602AEA0 RID: 175776 RVA: 0x009EF938 File Offset: 0x009EDB38
		public unsafe UKuroAnimInstanceRole Kuro_Anim_Instance_Role
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceRole>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SlopeSlide_C.__PropertyOffset_53);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SlopeSlide_C.__PropertyOffset_53, value);
			}
		}

		// Token: 0x170069AC RID: 27052
		// (get) Token: 0x0602AEA1 RID: 175777 RVA: 0x009EF94D File Offset: 0x009EDB4D
		// (set) Token: 0x0602AEA2 RID: 175778 RVA: 0x009EF95D File Offset: 0x009EDB5D
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_SlopeSlide_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_SlopeSlide_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AEA3 RID: 175779 RVA: 0x009EF970 File Offset: 0x009EDB70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_SlopeSlide_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_SlopeSlide_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_SlopeSlide_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_SlopeSlide_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_SlopeSlide_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AEA4 RID: 175780 RVA: 0x009EF9F7 File Offset: 0x009EDBF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_SlopeSlide_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AEA5 RID: 175781 RVA: 0x009EFA0B File Offset: 0x009EDC0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_SlopeSlide_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AEA6 RID: 175782 RVA: 0x009EFA20 File Offset: 0x009EDC20
		protected ABP_BaseRole_Gameplay_SlopeSlide_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163E6 RID: 91110
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_SlopeSlide.ABP_BaseRole_Gameplay_SlopeSlide_C";

		// Token: 0x040163E7 RID: 91111
		private static IntPtr _ClassPtr;

		// Token: 0x040163E8 RID: 91112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163E9 RID: 91113
		internal static int __PropertyOffset_52;

		// Token: 0x040163EA RID: 91114
		internal static int __PropertyOffset_53;

		// Token: 0x040163EB RID: 91115
		internal static int __PropertyOffset_54;

		// Token: 0x040163EC RID: 91116
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040163ED RID: 91117
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A42E RID: 42030
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032269 RID: 205417
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
