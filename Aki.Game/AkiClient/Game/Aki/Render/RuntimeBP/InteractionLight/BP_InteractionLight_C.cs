using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.InteractionLight
{
	// Token: 0x02003D24 RID: 15652
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/InteractionLight/BP_InteractionLight.BP_InteractionLight_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class BP_InteractionLight_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025993 RID: 154003 RVA: 0x0095E2C5 File Offset: 0x0095C4C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractionLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/InteractionLight/BP_InteractionLight.BP_InteractionLight_C");
			}
			return BP_InteractionLight_C._ClassPtr;
		}

		// Token: 0x06025994 RID: 154004 RVA: 0x0095E2EC File Offset: 0x0095C4EC
		public BP_InteractionLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractionLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025995 RID: 154005 RVA: 0x0095E314 File Offset: 0x0095C514
		[NullableContext(1)]
		public BP_InteractionLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractionLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x06025996 RID: 154006 RVA: 0x0095E347 File Offset: 0x0095C547
		// (set) Token: 0x06025997 RID: 154007 RVA: 0x0095E35B File Offset: 0x0095C55B
		public unsafe USpotLightComponent SpotLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x06025998 RID: 154008 RVA: 0x0095E370 File Offset: 0x0095C570
		// (set) Token: 0x06025999 RID: 154009 RVA: 0x0095E384 File Offset: 0x0095C584
		public unsafe UChildActorComponent BP_VolumetricConeLightShaft_InStage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x0602599A RID: 154010 RVA: 0x0095E399 File Offset: 0x0095C599
		// (set) Token: 0x0602599B RID: 154011 RVA: 0x0095E3AD File Offset: 0x0095C5AD
		public unsafe UStaticMeshComponent DownSM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x0602599C RID: 154012 RVA: 0x0095E3C2 File Offset: 0x0095C5C2
		// (set) Token: 0x0602599D RID: 154013 RVA: 0x0095E3D6 File Offset: 0x0095C5D6
		public unsafe UKuroInteractionComponent ProximityTrigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroInteractionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x0602599E RID: 154014 RVA: 0x0095E3EB File Offset: 0x0095C5EB
		// (set) Token: 0x0602599F RID: 154015 RVA: 0x0095E3FF File Offset: 0x0095C5FF
		public unsafe UStaticMeshComponent UpSM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x060259A0 RID: 154016 RVA: 0x0095E414 File Offset: 0x0095C614
		// (set) Token: 0x060259A1 RID: 154017 RVA: 0x0095E428 File Offset: 0x0095C628
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionLight_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x060259A2 RID: 154018 RVA: 0x0095E43D File Offset: 0x0095C63D
		// (set) Token: 0x060259A3 RID: 154019 RVA: 0x0095E451 File Offset: 0x0095C651
		public unsafe FVector SkillPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x060259A4 RID: 154020 RVA: 0x0095E466 File Offset: 0x0095C666
		// (set) Token: 0x060259A5 RID: 154021 RVA: 0x0095E476 File Offset: 0x0095C676
		public unsafe float InteractionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x060259A6 RID: 154022 RVA: 0x0095E487 File Offset: 0x0095C687
		// (set) Token: 0x060259A7 RID: 154023 RVA: 0x0095E497 File Offset: 0x0095C697
		public unsafe bool IsChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x060259A8 RID: 154024 RVA: 0x0095E4A8 File Offset: 0x0095C6A8
		// (set) Token: 0x060259A9 RID: 154025 RVA: 0x0095E4B8 File Offset: 0x0095C6B8
		public unsafe int TargetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x060259AA RID: 154026 RVA: 0x0095E4C9 File Offset: 0x0095C6C9
		// (set) Token: 0x060259AB RID: 154027 RVA: 0x0095E4D9 File Offset: 0x0095C6D9
		public unsafe int DefaultID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x060259AC RID: 154028 RVA: 0x0095E4EA File Offset: 0x0095C6EA
		// (set) Token: 0x060259AD RID: 154029 RVA: 0x0095E4FA File Offset: 0x0095C6FA
		public unsafe float ResetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x060259AE RID: 154030 RVA: 0x0095E50B File Offset: 0x0095C70B
		// (set) Token: 0x060259AF RID: 154031 RVA: 0x0095E51F File Offset: 0x0095C71F
		public unsafe FVectorDouble ActorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x060259B0 RID: 154032 RVA: 0x0095E534 File Offset: 0x0095C734
		// (set) Token: 0x060259B1 RID: 154033 RVA: 0x0095E544 File Offset: 0x0095C744
		public unsafe float DebounceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x060259B2 RID: 154034 RVA: 0x0095E555 File Offset: 0x0095C755
		// (set) Token: 0x060259B3 RID: 154035 RVA: 0x0095E569 File Offset: 0x0095C769
		public unsafe FLinearColor Fall_Off_Color_Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x060259B4 RID: 154036 RVA: 0x0095E57E File Offset: 0x0095C77E
		// (set) Token: 0x060259B5 RID: 154037 RVA: 0x0095E58E File Offset: 0x0095C78E
		public unsafe int TestId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionLight_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x060259B6 RID: 154038 RVA: 0x0095E59F File Offset: 0x0095C79F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CanChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionLight_C.__CanChange_NativeFunctionPtr, null);
		}

		// Token: 0x060259B7 RID: 154039 RVA: 0x0095E5B3 File Offset: 0x0095C7B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060259B8 RID: 154040 RVA: 0x0095E5C7 File Offset: 0x0095C7C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractionLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060259B9 RID: 154041 RVA: 0x0095E5DC File Offset: 0x0095C7DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeapon(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_InteractionLight_C.__OnWeapon_FunctionParams* ptr = stackalloc BP_InteractionLight_C.__OnWeapon_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_InteractionLight_C.__OnWeapon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionLight_C.__OnWeapon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionLight_C.__OnWeapon_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060259BA RID: 154042 RVA: 0x0095E640 File Offset: 0x0095C840
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InteractionLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractionLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractionLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060259BB RID: 154043 RVA: 0x0095E688 File Offset: 0x0095C888
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InteractionLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractionLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractionLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractionLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060259BC RID: 154044 RVA: 0x0095E6CF File Offset: 0x0095C8CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060259BD RID: 154045 RVA: 0x0095E6E3 File Offset: 0x0095C8E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractionLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060259BE RID: 154046 RVA: 0x0095E6F8 File Offset: 0x0095C8F8
		protected BP_InteractionLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C61 RID: 76897
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/InteractionLight/BP_InteractionLight.BP_InteractionLight_C";

		// Token: 0x04012C62 RID: 76898
		private static IntPtr _ClassPtr;

		// Token: 0x04012C63 RID: 76899
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C64 RID: 76900
		internal static int __PropertyOffset_1;

		// Token: 0x04012C65 RID: 76901
		internal static int __PropertyOffset_2;

		// Token: 0x04012C66 RID: 76902
		internal static int __PropertyOffset_3;

		// Token: 0x04012C67 RID: 76903
		internal static int __PropertyOffset_4;

		// Token: 0x04012C68 RID: 76904
		internal static int __PropertyOffset_5;

		// Token: 0x04012C69 RID: 76905
		internal static int __PropertyOffset_6;

		// Token: 0x04012C6A RID: 76906
		internal static int __PropertyOffset_7;

		// Token: 0x04012C6B RID: 76907
		internal static int __PropertyOffset_8;

		// Token: 0x04012C6C RID: 76908
		internal static int __PropertyOffset_9;

		// Token: 0x04012C6D RID: 76909
		internal static int __PropertyOffset_10;

		// Token: 0x04012C6E RID: 76910
		internal static int __PropertyOffset_11;

		// Token: 0x04012C6F RID: 76911
		internal static int __PropertyOffset_12;

		// Token: 0x04012C70 RID: 76912
		internal static int __PropertyOffset_13;

		// Token: 0x04012C71 RID: 76913
		internal static int __PropertyOffset_14;

		// Token: 0x04012C72 RID: 76914
		internal static int __PropertyOffset_15;

		// Token: 0x04012C73 RID: 76915
		internal static int __PropertyOffset_16;

		// Token: 0x04012C74 RID: 76916
		private static IntPtr __CanChange_NativeFunctionPtr;

		// Token: 0x04012C75 RID: 76917
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012C76 RID: 76918
		private static IntPtr __OnWeapon_NativeFunctionPtr;

		// Token: 0x04012C77 RID: 76919
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012C78 RID: 76920
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A018 RID: 40984
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeapon_FunctionParams
		{
			// Token: 0x04031ABF RID: 203455
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031AC0 RID: 203456
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031AC1 RID: 203457
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x0200A019 RID: 40985
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031AC2 RID: 203458
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
