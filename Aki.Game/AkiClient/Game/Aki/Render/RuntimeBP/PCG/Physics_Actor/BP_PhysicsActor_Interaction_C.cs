using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x02003C37 RID: 15415
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Interaction.BP_PhysicsActor_Interaction_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_PhysicsActor_Interaction_C : AKuroPhysicActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023759 RID: 145241 RVA: 0x0092477F File Offset: 0x0092297F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_Interaction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Interaction.BP_PhysicsActor_Interaction_C");
			}
			return BP_PhysicsActor_Interaction_C._ClassPtr;
		}

		// Token: 0x0602375A RID: 145242 RVA: 0x009247A4 File Offset: 0x009229A4
		public BP_PhysicsActor_Interaction_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Interaction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602375B RID: 145243 RVA: 0x009247CC File Offset: 0x009229CC
		[NullableContext(1)]
		public BP_PhysicsActor_Interaction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Interaction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x0602375C RID: 145244 RVA: 0x009247FF File Offset: 0x009229FF
		// (set) Token: 0x0602375D RID: 145245 RVA: 0x00924813 File Offset: 0x00922A13
		public unsafe UStaticMeshComponent StaticMesh_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Interaction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Interaction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x0602375E RID: 145246 RVA: 0x00924828 File Offset: 0x00922A28
		// (set) Token: 0x0602375F RID: 145247 RVA: 0x0092483C File Offset: 0x00922A3C
		public unsafe BP_SceneBattleInteract_C Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Interaction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Interaction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x06023760 RID: 145248 RVA: 0x00924851 File Offset: 0x00922A51
		// (set) Token: 0x06023761 RID: 145249 RVA: 0x00924865 File Offset: 0x00922A65
		public unsafe FVectorDouble PrePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicsActor_Interaction_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicsActor_Interaction_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x06023762 RID: 145250 RVA: 0x0092487A File Offset: 0x00922A7A
		// (set) Token: 0x06023763 RID: 145251 RVA: 0x0092488A File Offset: 0x00922A8A
		public unsafe float Impulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicsActor_Interaction_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicsActor_Interaction_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x06023764 RID: 145252 RVA: 0x0092489B File Offset: 0x00922A9B
		// (set) Token: 0x06023765 RID: 145253 RVA: 0x009248AF File Offset: 0x00922AAF
		public unsafe FVector WeaponImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicsActor_Interaction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicsActor_Interaction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06023766 RID: 145254 RVA: 0x009248C4 File Offset: 0x00922AC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_Interaction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023767 RID: 145255 RVA: 0x009248D8 File Offset: 0x00922AD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_Interaction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023768 RID: 145256 RVA: 0x009248ED File Offset: 0x00922AED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_Interaction_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06023769 RID: 145257 RVA: 0x00924901 File Offset: 0x00922B01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_Interaction_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602376A RID: 145258 RVA: 0x00924916 File Offset: 0x00922B16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_Interaction_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0602376B RID: 145259 RVA: 0x0092492A File Offset: 0x00922B2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_Interaction_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602376C RID: 145260 RVA: 0x00924940 File Offset: 0x00922B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_PhysicsActor_Interaction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_PhysicsActor_Interaction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_PhysicsActor_Interaction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicsActor_Interaction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_Interaction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602376D RID: 145261 RVA: 0x009249A3 File Offset: 0x00922BA3
		protected BP_PhysicsActor_Interaction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011811 RID: 71697
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Interaction.BP_PhysicsActor_Interaction_C";

		// Token: 0x04011812 RID: 71698
		private static IntPtr _ClassPtr;

		// Token: 0x04011813 RID: 71699
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011814 RID: 71700
		internal static int __PropertyOffset_1;

		// Token: 0x04011815 RID: 71701
		internal static int __PropertyOffset_2;

		// Token: 0x04011816 RID: 71702
		internal static int __PropertyOffset_3;

		// Token: 0x04011817 RID: 71703
		internal static int __PropertyOffset_4;

		// Token: 0x04011818 RID: 71704
		internal static int __PropertyOffset_5;

		// Token: 0x04011819 RID: 71705
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401181A RID: 71706
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x0401181B RID: 71707
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0401181C RID: 71708
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009E70 RID: 40560
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040316FA RID: 202490
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040316FB RID: 202491
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040316FC RID: 202492
			[FieldOffset(32)]
			public int Id;
		}
	}
}
