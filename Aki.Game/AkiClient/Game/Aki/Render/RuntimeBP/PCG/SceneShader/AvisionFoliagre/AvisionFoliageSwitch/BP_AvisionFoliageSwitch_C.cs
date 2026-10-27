using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.AvisionFoliagre.AvisionFoliageSwitch
{
	// Token: 0x02003C0A RID: 15370
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/AvisionFoliagre/AvisionFoliageSwitch/BP_AvisionFoliageSwitch.BP_AvisionFoliageSwitch_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1554)]
	public class BP_AvisionFoliageSwitch_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023133 RID: 143667 RVA: 0x00919DD0 File Offset: 0x00917FD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AvisionFoliageSwitch_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/AvisionFoliagre/AvisionFoliageSwitch/BP_AvisionFoliageSwitch.BP_AvisionFoliageSwitch_C");
			}
			return BP_AvisionFoliageSwitch_C._ClassPtr;
		}

		// Token: 0x06023134 RID: 143668 RVA: 0x00919DF4 File Offset: 0x00917FF4
		public BP_AvisionFoliageSwitch_C() : this(BuiltinUtils.AllocNativeUObject(BP_AvisionFoliageSwitch_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023135 RID: 143669 RVA: 0x00919E1C File Offset: 0x0091801C
		[NullableContext(1)]
		public BP_AvisionFoliageSwitch_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AvisionFoliageSwitch_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x06023136 RID: 143670 RVA: 0x00919E4F File Offset: 0x0091804F
		// (set) Token: 0x06023137 RID: 143671 RVA: 0x00919E63 File Offset: 0x00918063
		public unsafe UStaticMeshComponent CommonFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x06023138 RID: 143672 RVA: 0x00919E78 File Offset: 0x00918078
		// (set) Token: 0x06023139 RID: 143673 RVA: 0x00919E8C File Offset: 0x0091808C
		public unsafe UStaticMeshComponent AvisionFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0602313A RID: 143674 RVA: 0x00919EA1 File Offset: 0x009180A1
		// (set) Token: 0x0602313B RID: 143675 RVA: 0x00919EB5 File Offset: 0x009180B5
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x0602313C RID: 143676 RVA: 0x00919ECA File Offset: 0x009180CA
		// (set) Token: 0x0602313D RID: 143677 RVA: 0x00919EDE File Offset: 0x009180DE
		public unsafe UStaticMesh SM_AvisionFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x0602313E RID: 143678 RVA: 0x00919EF3 File Offset: 0x009180F3
		// (set) Token: 0x0602313F RID: 143679 RVA: 0x00919F07 File Offset: 0x00918107
		public unsafe UStaticMesh SM_CommonFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x06023140 RID: 143680 RVA: 0x00919F1C File Offset: 0x0091811C
		// (set) Token: 0x06023141 RID: 143681 RVA: 0x00919F2C File Offset: 0x0091812C
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x06023142 RID: 143682 RVA: 0x00919F3D File Offset: 0x0091813D
		// (set) Token: 0x06023143 RID: 143683 RVA: 0x00919F4D File Offset: 0x0091814D
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x06023144 RID: 143684 RVA: 0x00919F5E File Offset: 0x0091815E
		// (set) Token: 0x06023145 RID: 143685 RVA: 0x00919F72 File Offset: 0x00918172
		public unsafe FLinearColor LeafDissolve_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x06023146 RID: 143686 RVA: 0x00919F87 File Offset: 0x00918187
		// (set) Token: 0x06023147 RID: 143687 RVA: 0x00919F9B File Offset: 0x0091819B
		public unsafe UMaterialInstanceDynamic AvisionFoliage_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x06023148 RID: 143688 RVA: 0x00919FB0 File Offset: 0x009181B0
		// (set) Token: 0x06023149 RID: 143689 RVA: 0x00919FC4 File Offset: 0x009181C4
		public unsafe UMaterialInstanceDynamic CommonFoliage_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x0602314A RID: 143690 RVA: 0x00919FD9 File Offset: 0x009181D9
		// (set) Token: 0x0602314B RID: 143691 RVA: 0x00919FED File Offset: 0x009181ED
		public unsafe UMaterialInstanceDynamic CommonFoliage_LOD1_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AvisionFoliageSwitch_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x0602314C RID: 143692 RVA: 0x0091A002 File Offset: 0x00918202
		// (set) Token: 0x0602314D RID: 143693 RVA: 0x0091A012 File Offset: 0x00918212
		public unsafe bool HasToggled_Close
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x0602314E RID: 143694 RVA: 0x0091A023 File Offset: 0x00918223
		// (set) Token: 0x0602314F RID: 143695 RVA: 0x0091A033 File Offset: 0x00918233
		public unsafe bool HasToggled_Open
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AvisionFoliageSwitch_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023150 RID: 143696 RVA: 0x0091A044 File Offset: 0x00918244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Collision()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AvisionFoliageSwitch_C.__Set_Collision_NativeFunctionPtr, null);
		}

		// Token: 0x06023151 RID: 143697 RVA: 0x0091A058 File Offset: 0x00918258
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AvisionFoliageSwitch_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023152 RID: 143698 RVA: 0x0091A06C File Offset: 0x0091826C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AvisionFoliageSwitch_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023153 RID: 143699 RVA: 0x0091A081 File Offset: 0x00918281
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AvisionFoliageSwitch_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023154 RID: 143700 RVA: 0x0091A095 File Offset: 0x00918295
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AvisionFoliageSwitch_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023155 RID: 143701 RVA: 0x0091A0AC File Offset: 0x009182AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AvisionFoliageSwitch_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AvisionFoliageSwitch_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AvisionFoliageSwitch_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AvisionFoliageSwitch_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AvisionFoliageSwitch_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023156 RID: 143702 RVA: 0x0091A0F4 File Offset: 0x009182F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AvisionFoliageSwitch_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AvisionFoliageSwitch_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AvisionFoliageSwitch_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AvisionFoliageSwitch_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AvisionFoliageSwitch_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023157 RID: 143703 RVA: 0x0091A13B File Offset: 0x0091833B
		protected BP_AvisionFoliageSwitch_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011468 RID: 70760
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/AvisionFoliagre/AvisionFoliageSwitch/BP_AvisionFoliageSwitch.BP_AvisionFoliageSwitch_C";

		// Token: 0x04011469 RID: 70761
		private static IntPtr _ClassPtr;

		// Token: 0x0401146A RID: 70762
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401146B RID: 70763
		internal static int __PropertyOffset_1;

		// Token: 0x0401146C RID: 70764
		internal static int __PropertyOffset_2;

		// Token: 0x0401146D RID: 70765
		internal static int __PropertyOffset_3;

		// Token: 0x0401146E RID: 70766
		internal static int __PropertyOffset_4;

		// Token: 0x0401146F RID: 70767
		internal static int __PropertyOffset_5;

		// Token: 0x04011470 RID: 70768
		internal static int __PropertyOffset_6;

		// Token: 0x04011471 RID: 70769
		internal static int __PropertyOffset_7;

		// Token: 0x04011472 RID: 70770
		internal static int __PropertyOffset_8;

		// Token: 0x04011473 RID: 70771
		internal static int __PropertyOffset_9;

		// Token: 0x04011474 RID: 70772
		internal static int __PropertyOffset_10;

		// Token: 0x04011475 RID: 70773
		internal static int __PropertyOffset_11;

		// Token: 0x04011476 RID: 70774
		internal static int __PropertyOffset_12;

		// Token: 0x04011477 RID: 70775
		internal static int __PropertyOffset_13;

		// Token: 0x04011478 RID: 70776
		private static IntPtr __Set_Collision_NativeFunctionPtr;

		// Token: 0x04011479 RID: 70777
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401147A RID: 70778
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401147B RID: 70779
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E0E RID: 40462
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403163D RID: 202301
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
