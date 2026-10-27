using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x0200411A RID: 16666
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_SwordRiding.ABP_BaseRole_Gameplay_SwordRiding_C")]
	[UnrealStructLayout(3968, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3953)]
	public class ABP_BaseRole_Gameplay_SwordRiding_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AEA7 RID: 175783 RVA: 0x009EFA29 File Offset: 0x009EDC29
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_SwordRiding_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_SwordRiding.ABP_BaseRole_Gameplay_SwordRiding_C");
			}
			return ABP_BaseRole_Gameplay_SwordRiding_C._ClassPtr;
		}

		// Token: 0x0602AEA8 RID: 175784 RVA: 0x009EFA50 File Offset: 0x009EDC50
		public ABP_BaseRole_Gameplay_SwordRiding_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_SwordRiding_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AEA9 RID: 175785 RVA: 0x009EFA78 File Offset: 0x009EDC78
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_SwordRiding_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_SwordRiding_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069AD RID: 27053
		// (get) Token: 0x0602AEAA RID: 175786 RVA: 0x009EFAAB File Offset: 0x009EDCAB
		// (set) Token: 0x0602AEAB RID: 175787 RVA: 0x009EFABF File Offset: 0x009EDCBF
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SwordRiding_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SwordRiding_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170069AE RID: 27054
		// (get) Token: 0x0602AEAC RID: 175788 RVA: 0x009EFAD4 File Offset: 0x009EDCD4
		// (set) Token: 0x0602AEAD RID: 175789 RVA: 0x009EFAE8 File Offset: 0x009EDCE8
		public unsafe UKuroAnimInstanceRole Kuro_Anim_Instance_Role
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceRole>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SwordRiding_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_SwordRiding_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170069AF RID: 27055
		// (get) Token: 0x0602AEAE RID: 175790 RVA: 0x009EFAFD File Offset: 0x009EDCFD
		// (set) Token: 0x0602AEAF RID: 175791 RVA: 0x009EFB0D File Offset: 0x009EDD0D
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_SwordRiding_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_SwordRiding_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AEB0 RID: 175792 RVA: 0x009EFB20 File Offset: 0x009EDD20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_SwordRiding_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_SwordRiding_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_SwordRiding_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_SwordRiding_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_SwordRiding_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AEB1 RID: 175793 RVA: 0x009EFBA7 File Offset: 0x009EDDA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_SwordRiding_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AEB2 RID: 175794 RVA: 0x009EFBBB File Offset: 0x009EDDBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_SwordRiding_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AEB3 RID: 175795 RVA: 0x009EFBD0 File Offset: 0x009EDDD0
		protected ABP_BaseRole_Gameplay_SwordRiding_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163EE RID: 91118
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_SwordRiding.ABP_BaseRole_Gameplay_SwordRiding_C";

		// Token: 0x040163EF RID: 91119
		private static IntPtr _ClassPtr;

		// Token: 0x040163F0 RID: 91120
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163F1 RID: 91121
		internal static int __PropertyOffset_11;

		// Token: 0x040163F2 RID: 91122
		internal static int __PropertyOffset_12;

		// Token: 0x040163F3 RID: 91123
		internal static int __PropertyOffset_13;

		// Token: 0x040163F4 RID: 91124
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040163F5 RID: 91125
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A42F RID: 42031
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403226A RID: 205418
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
