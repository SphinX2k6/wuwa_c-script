using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.GuideSpriteDecal
{
	// Token: 0x02003C06 RID: 15366
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/BP_GuideSpriteDecal_PointLight.BP_GuideSpriteDecal_PointLight_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1673)]
	public class BP_GuideSpriteDecal_PointLight_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023026 RID: 143398 RVA: 0x009182CC File Offset: 0x009164CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GuideSpriteDecal_PointLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/BP_GuideSpriteDecal_PointLight.BP_GuideSpriteDecal_PointLight_C");
			}
			return BP_GuideSpriteDecal_PointLight_C._ClassPtr;
		}

		// Token: 0x06023027 RID: 143399 RVA: 0x009182F0 File Offset: 0x009164F0
		public BP_GuideSpriteDecal_PointLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_GuideSpriteDecal_PointLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023028 RID: 143400 RVA: 0x00918318 File Offset: 0x00916518
		[NullableContext(1)]
		public BP_GuideSpriteDecal_PointLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GuideSpriteDecal_PointLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x06023029 RID: 143401 RVA: 0x0091834B File Offset: 0x0091654B
		// (set) Token: 0x0602302A RID: 143402 RVA: 0x0091835F File Offset: 0x0091655F
		public unsafe UDecalComponent Decal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0602302B RID: 143403 RVA: 0x00918374 File Offset: 0x00916574
		// (set) Token: 0x0602302C RID: 143404 RVA: 0x00918388 File Offset: 0x00916588
		public unsafe UTextRenderComponent GuideSpline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x0602302D RID: 143405 RVA: 0x0091839D File Offset: 0x0091659D
		// (set) Token: 0x0602302E RID: 143406 RVA: 0x009183B1 File Offset: 0x009165B1
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x0602302F RID: 143407 RVA: 0x009183C6 File Offset: 0x009165C6
		// (set) Token: 0x06023030 RID: 143408 RVA: 0x009183DA File Offset: 0x009165DA
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x06023031 RID: 143409 RVA: 0x009183EF File Offset: 0x009165EF
		// (set) Token: 0x06023032 RID: 143410 RVA: 0x00918403 File Offset: 0x00916603
		public unsafe UBoxComponent TriggerBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x06023033 RID: 143411 RVA: 0x00918418 File Offset: 0x00916618
		// (set) Token: 0x06023034 RID: 143412 RVA: 0x0091842C File Offset: 0x0091662C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x06023035 RID: 143413 RVA: 0x00918441 File Offset: 0x00916641
		// (set) Token: 0x06023036 RID: 143414 RVA: 0x00918455 File Offset: 0x00916655
		public unsafe FVector Collision_Box_Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x06023037 RID: 143415 RVA: 0x0091846A File Offset: 0x0091666A
		// (set) Token: 0x06023038 RID: 143416 RVA: 0x0091847A File Offset: 0x0091667A
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x06023039 RID: 143417 RVA: 0x0091848B File Offset: 0x0091668B
		// (set) Token: 0x0602303A RID: 143418 RVA: 0x0091849B File Offset: 0x0091669B
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x0602303B RID: 143419 RVA: 0x009184AC File Offset: 0x009166AC
		// (set) Token: 0x0602303C RID: 143420 RVA: 0x009184BC File Offset: 0x009166BC
		public unsafe bool bShouldMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0602303D RID: 143421 RVA: 0x009184CD File Offset: 0x009166CD
		// (set) Token: 0x0602303E RID: 143422 RVA: 0x009184E2 File Offset: 0x009166E2
		[Nullable(1)]
		public TSoftObjectPtr<ADecalActor> Decal
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<ADecalActor>(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_11, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0602303F RID: 143423 RVA: 0x00918507 File Offset: 0x00916707
		// (set) Token: 0x06023040 RID: 143424 RVA: 0x00918517 File Offset: 0x00916717
		public unsafe float Decal_ProgressSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x06023041 RID: 143425 RVA: 0x00918528 File Offset: 0x00916728
		// (set) Token: 0x06023042 RID: 143426 RVA: 0x00918538 File Offset: 0x00916738
		public unsafe float Decal_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x06023043 RID: 143427 RVA: 0x00918549 File Offset: 0x00916749
		// (set) Token: 0x06023044 RID: 143428 RVA: 0x0091855D File Offset: 0x0091675D
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x06023045 RID: 143429 RVA: 0x00918572 File Offset: 0x00916772
		// (set) Token: 0x06023046 RID: 143430 RVA: 0x00918582 File Offset: 0x00916782
		public unsafe float Debug_Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x06023047 RID: 143431 RVA: 0x00918593 File Offset: 0x00916793
		// (set) Token: 0x06023048 RID: 143432 RVA: 0x009185A3 File Offset: 0x009167A3
		public unsafe bool Play_Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x06023049 RID: 143433 RVA: 0x009185B4 File Offset: 0x009167B4
		// (set) Token: 0x0602304A RID: 143434 RVA: 0x009185C4 File Offset: 0x009167C4
		public unsafe float MovementSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x0602304B RID: 143435 RVA: 0x009185D5 File Offset: 0x009167D5
		// (set) Token: 0x0602304C RID: 143436 RVA: 0x009185E5 File Offset: 0x009167E5
		public unsafe float CurrentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x0602304D RID: 143437 RVA: 0x009185F6 File Offset: 0x009167F6
		// (set) Token: 0x0602304E RID: 143438 RVA: 0x0091860A File Offset: 0x0091680A
		public unsafe FLinearColor Light_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x0602304F RID: 143439 RVA: 0x0091861F File Offset: 0x0091681F
		// (set) Token: 0x06023050 RID: 143440 RVA: 0x0091862F File Offset: 0x0091682F
		public unsafe float Attenuation_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x06023051 RID: 143441 RVA: 0x00918640 File Offset: 0x00916840
		// (set) Token: 0x06023052 RID: 143442 RVA: 0x00918650 File Offset: 0x00916850
		public unsafe float LightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x06023053 RID: 143443 RVA: 0x00918661 File Offset: 0x00916861
		// (set) Token: 0x06023054 RID: 143444 RVA: 0x00918671 File Offset: 0x00916871
		public unsafe float PointLight_SpeedOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x06023055 RID: 143445 RVA: 0x00918682 File Offset: 0x00916882
		// (set) Token: 0x06023056 RID: 143446 RVA: 0x00918692 File Offset: 0x00916892
		public unsafe bool Debug_One
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x06023057 RID: 143447 RVA: 0x009186A3 File Offset: 0x009168A3
		// (set) Token: 0x06023058 RID: 143448 RVA: 0x009186B3 File Offset: 0x009168B3
		public unsafe float Progress_Point
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x06023059 RID: 143449 RVA: 0x009186C4 File Offset: 0x009168C4
		// (set) Token: 0x0602305A RID: 143450 RVA: 0x009186D4 File Offset: 0x009168D4
		public unsafe float LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x0602305B RID: 143451 RVA: 0x009186E5 File Offset: 0x009168E5
		// (set) Token: 0x0602305C RID: 143452 RVA: 0x009186F5 File Offset: 0x009168F5
		public unsafe float Decal_EmissiveStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x0602305D RID: 143453 RVA: 0x00918706 File Offset: 0x00916906
		// (set) Token: 0x0602305E RID: 143454 RVA: 0x0091871A File Offset: 0x0091691A
		public unsafe UAkAudioEvent Play_Audio_Event
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x0602305F RID: 143455 RVA: 0x0091872F File Offset: 0x0091692F
		// (set) Token: 0x06023060 RID: 143456 RVA: 0x00918743 File Offset: 0x00916943
		public unsafe UAkAudioEvent Stop_Audio_Event
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x06023061 RID: 143457 RVA: 0x00918758 File Offset: 0x00916958
		// (set) Token: 0x06023062 RID: 143458 RVA: 0x00918768 File Offset: 0x00916968
		public unsafe bool Play_Audio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023063 RID: 143459 RVA: 0x00918779 File Offset: 0x00916979
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x06023064 RID: 143460 RVA: 0x0091878D File Offset: 0x0091698D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023065 RID: 143461 RVA: 0x009187A1 File Offset: 0x009169A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023066 RID: 143462 RVA: 0x009187B6 File Offset: 0x009169B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023067 RID: 143463 RVA: 0x009187CA File Offset: 0x009169CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023068 RID: 143464 RVA: 0x009187E0 File Offset: 0x009169E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023069 RID: 143465 RVA: 0x00918828 File Offset: 0x00916A28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602306A RID: 143466 RVA: 0x00918870 File Offset: 0x00916A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602306B RID: 143467 RVA: 0x009188B8 File Offset: 0x00916AB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602306C RID: 143468 RVA: 0x009188FF File Offset: 0x00916AFF
		protected BP_GuideSpriteDecal_PointLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113D5 RID: 70613
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/BP_GuideSpriteDecal_PointLight.BP_GuideSpriteDecal_PointLight_C";

		// Token: 0x040113D6 RID: 70614
		private static IntPtr _ClassPtr;

		// Token: 0x040113D7 RID: 70615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113D8 RID: 70616
		internal static int __PropertyOffset_1;

		// Token: 0x040113D9 RID: 70617
		internal static int __PropertyOffset_2;

		// Token: 0x040113DA RID: 70618
		internal static int __PropertyOffset_3;

		// Token: 0x040113DB RID: 70619
		internal static int __PropertyOffset_4;

		// Token: 0x040113DC RID: 70620
		internal static int __PropertyOffset_5;

		// Token: 0x040113DD RID: 70621
		internal static int __PropertyOffset_6;

		// Token: 0x040113DE RID: 70622
		internal static int __PropertyOffset_7;

		// Token: 0x040113DF RID: 70623
		internal static int __PropertyOffset_8;

		// Token: 0x040113E0 RID: 70624
		internal static int __PropertyOffset_9;

		// Token: 0x040113E1 RID: 70625
		internal static int __PropertyOffset_10;

		// Token: 0x040113E2 RID: 70626
		internal static int __PropertyOffset_11;

		// Token: 0x040113E3 RID: 70627
		internal static int __PropertyOffset_12;

		// Token: 0x040113E4 RID: 70628
		internal static int __PropertyOffset_13;

		// Token: 0x040113E5 RID: 70629
		internal static int __PropertyOffset_14;

		// Token: 0x040113E6 RID: 70630
		internal static int __PropertyOffset_15;

		// Token: 0x040113E7 RID: 70631
		internal static int __PropertyOffset_16;

		// Token: 0x040113E8 RID: 70632
		internal static int __PropertyOffset_17;

		// Token: 0x040113E9 RID: 70633
		internal static int __PropertyOffset_18;

		// Token: 0x040113EA RID: 70634
		internal static int __PropertyOffset_19;

		// Token: 0x040113EB RID: 70635
		internal static int __PropertyOffset_20;

		// Token: 0x040113EC RID: 70636
		internal static int __PropertyOffset_21;

		// Token: 0x040113ED RID: 70637
		internal static int __PropertyOffset_22;

		// Token: 0x040113EE RID: 70638
		internal static int __PropertyOffset_23;

		// Token: 0x040113EF RID: 70639
		internal static int __PropertyOffset_24;

		// Token: 0x040113F0 RID: 70640
		internal static int __PropertyOffset_25;

		// Token: 0x040113F1 RID: 70641
		internal static int __PropertyOffset_26;

		// Token: 0x040113F2 RID: 70642
		internal static int __PropertyOffset_27;

		// Token: 0x040113F3 RID: 70643
		internal static int __PropertyOffset_28;

		// Token: 0x040113F4 RID: 70644
		internal static int __PropertyOffset_29;

		// Token: 0x040113F5 RID: 70645
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x040113F6 RID: 70646
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040113F7 RID: 70647
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040113F8 RID: 70648
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040113F9 RID: 70649
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009DFF RID: 40447
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403161E RID: 202270
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E00 RID: 40448
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403161F RID: 202271
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
