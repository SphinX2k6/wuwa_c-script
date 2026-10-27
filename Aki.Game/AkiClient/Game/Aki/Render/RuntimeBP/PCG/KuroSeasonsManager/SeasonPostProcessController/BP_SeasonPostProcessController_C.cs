using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroSeasonsManager.SeasonPostProcessController
{
	// Token: 0x02003C77 RID: 15479
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroSeasonsManager/SeasonPostProcessController/BP_SeasonPostProcessController.BP_SeasonPostProcessController_C")]
	[UnrealStructLayout(2088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2088)]
	public class BP_SeasonPostProcessController_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023F42 RID: 147266 RVA: 0x009316B5 File Offset: 0x0092F8B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeasonPostProcessController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroSeasonsManager/SeasonPostProcessController/BP_SeasonPostProcessController.BP_SeasonPostProcessController_C");
			}
			return BP_SeasonPostProcessController_C._ClassPtr;
		}

		// Token: 0x06023F43 RID: 147267 RVA: 0x009316DC File Offset: 0x0092F8DC
		public BP_SeasonPostProcessController_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeasonPostProcessController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023F44 RID: 147268 RVA: 0x00931704 File Offset: 0x0092F904
		[NullableContext(1)]
		public BP_SeasonPostProcessController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeasonPostProcessController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x06023F45 RID: 147269 RVA: 0x00931737 File Offset: 0x0092F937
		// (set) Token: 0x06023F46 RID: 147270 RVA: 0x0093174B File Offset: 0x0092F94B
		public unsafe UKuroPostProcessComponent PPC_Autumn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x06023F47 RID: 147271 RVA: 0x00931760 File Offset: 0x0092F960
		// (set) Token: 0x06023F48 RID: 147272 RVA: 0x00931774 File Offset: 0x0092F974
		public unsafe UKuroPostProcessComponent PPC_Summer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x06023F49 RID: 147273 RVA: 0x00931789 File Offset: 0x0092F989
		// (set) Token: 0x06023F4A RID: 147274 RVA: 0x0093179D File Offset: 0x0092F99D
		public unsafe UKuroPostProcessComponent PPC_Spring
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x06023F4B RID: 147275 RVA: 0x009317B2 File Offset: 0x0092F9B2
		// (set) Token: 0x06023F4C RID: 147276 RVA: 0x009317C6 File Offset: 0x0092F9C6
		public unsafe UKuroPostProcessComponent PPC_Snow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x06023F4D RID: 147277 RVA: 0x009317DB File Offset: 0x0092F9DB
		// (set) Token: 0x06023F4E RID: 147278 RVA: 0x009317EF File Offset: 0x0092F9EF
		public unsafe UKuroPostProcessComponent PPC_Rain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x06023F4F RID: 147279 RVA: 0x00931804 File Offset: 0x0092FA04
		// (set) Token: 0x06023F50 RID: 147280 RVA: 0x00931818 File Offset: 0x0092FA18
		public unsafe UKuroPostProcessComponent PPC_Winter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x06023F51 RID: 147281 RVA: 0x0093182D File Offset: 0x0092FA2D
		// (set) Token: 0x06023F52 RID: 147282 RVA: 0x00931841 File Offset: 0x0092FA41
		public unsafe UBoxComponent PostProcessBoundCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x06023F53 RID: 147283 RVA: 0x00931856 File Offset: 0x0092FA56
		// (set) Token: 0x06023F54 RID: 147284 RVA: 0x0093186A File Offset: 0x0092FA6A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x06023F55 RID: 147285 RVA: 0x0093187F File Offset: 0x0092FA7F
		// (set) Token: 0x06023F56 RID: 147286 RVA: 0x0093188F File Offset: 0x0092FA8F
		public unsafe float NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x06023F57 RID: 147287 RVA: 0x009318A0 File Offset: 0x0092FAA0
		// (set) Token: 0x06023F58 RID: 147288 RVA: 0x009318B0 File Offset: 0x0092FAB0
		public unsafe bool Open_EditorViewable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x06023F59 RID: 147289 RVA: 0x009318C1 File Offset: 0x0092FAC1
		// (set) Token: 0x06023F5A RID: 147290 RVA: 0x009318D1 File Offset: 0x0092FAD1
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x06023F5B RID: 147291 RVA: 0x009318E2 File Offset: 0x0092FAE2
		// (set) Token: 0x06023F5C RID: 147292 RVA: 0x009318F6 File Offset: 0x0092FAF6
		public unsafe UMaterialParameterCollection SeasonMPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x06023F5D RID: 147293 RVA: 0x0093190B File Offset: 0x0092FB0B
		// (set) Token: 0x06023F5E RID: 147294 RVA: 0x00931920 File Offset: 0x0092FB20
		[Nullable(1)]
		public TSoftObjectPtr<AKuroPostProcessVolume> PPV_Spring
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroPostProcessVolume>(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_13, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_13, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x06023F5F RID: 147295 RVA: 0x00931945 File Offset: 0x0092FB45
		// (set) Token: 0x06023F60 RID: 147296 RVA: 0x0093195A File Offset: 0x0092FB5A
		[Nullable(1)]
		public TSoftObjectPtr<AKuroPostProcessVolume> PPV_Summer
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroPostProcessVolume>(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_14, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x06023F61 RID: 147297 RVA: 0x0093197F File Offset: 0x0092FB7F
		// (set) Token: 0x06023F62 RID: 147298 RVA: 0x00931994 File Offset: 0x0092FB94
		[Nullable(1)]
		public TSoftObjectPtr<AKuroPostProcessVolume> PPV_Autumn
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroPostProcessVolume>(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_15, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_15, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x06023F63 RID: 147299 RVA: 0x009319B9 File Offset: 0x0092FBB9
		// (set) Token: 0x06023F64 RID: 147300 RVA: 0x009319CE File Offset: 0x0092FBCE
		[Nullable(1)]
		public TSoftObjectPtr<AKuroPostProcessVolume> PPV_Winter
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroPostProcessVolume>(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_16, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_16, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x06023F65 RID: 147301 RVA: 0x009319F3 File Offset: 0x0092FBF3
		// (set) Token: 0x06023F66 RID: 147302 RVA: 0x00931A08 File Offset: 0x0092FC08
		[Nullable(1)]
		public TSoftObjectPtr<AKuroPostProcessVolume> PPV_Rain
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroPostProcessVolume>(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_17, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_17, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x06023F67 RID: 147303 RVA: 0x00931A2D File Offset: 0x0092FC2D
		// (set) Token: 0x06023F68 RID: 147304 RVA: 0x00931A42 File Offset: 0x0092FC42
		[Nullable(1)]
		public TSoftObjectPtr<AKuroPostProcessVolume> PPV_Sonw
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroPostProcessVolume>(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_18, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x06023F69 RID: 147305 RVA: 0x00931A67 File Offset: 0x0092FC67
		// (set) Token: 0x06023F6A RID: 147306 RVA: 0x00931A7B File Offset: 0x0092FC7B
		public unsafe UKuroWeatherDataAsset DA_Spring
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x06023F6B RID: 147307 RVA: 0x00931A90 File Offset: 0x0092FC90
		// (set) Token: 0x06023F6C RID: 147308 RVA: 0x00931AA4 File Offset: 0x0092FCA4
		public unsafe UKuroWeatherDataAsset DA_Summer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x06023F6D RID: 147309 RVA: 0x00931AB9 File Offset: 0x0092FCB9
		// (set) Token: 0x06023F6E RID: 147310 RVA: 0x00931ACD File Offset: 0x0092FCCD
		public unsafe UKuroWeatherDataAsset DA_Autumn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x06023F6F RID: 147311 RVA: 0x00931AE2 File Offset: 0x0092FCE2
		// (set) Token: 0x06023F70 RID: 147312 RVA: 0x00931AF6 File Offset: 0x0092FCF6
		public unsafe UKuroWeatherDataAsset DA_Winter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x06023F71 RID: 147313 RVA: 0x00931B0B File Offset: 0x0092FD0B
		// (set) Token: 0x06023F72 RID: 147314 RVA: 0x00931B1F File Offset: 0x0092FD1F
		public unsafe UKuroWeatherDataAsset DA_Rain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x06023F73 RID: 147315 RVA: 0x00931B34 File Offset: 0x0092FD34
		// (set) Token: 0x06023F74 RID: 147316 RVA: 0x00931B48 File Offset: 0x0092FD48
		public unsafe UKuroWeatherDataAsset DA_Snow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x06023F75 RID: 147317 RVA: 0x00931B5D File Offset: 0x0092FD5D
		// (set) Token: 0x06023F76 RID: 147318 RVA: 0x00931B71 File Offset: 0x0092FD71
		public unsafe FName Parameter_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004472 RID: 17522
		// (get) Token: 0x06023F77 RID: 147319 RVA: 0x00931B86 File Offset: 0x0092FD86
		// (set) Token: 0x06023F78 RID: 147320 RVA: 0x00931B96 File Offset: 0x0092FD96
		public unsafe float SeasonTransitionTimeLine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004473 RID: 17523
		// (get) Token: 0x06023F79 RID: 147321 RVA: 0x00931BA7 File Offset: 0x0092FDA7
		// (set) Token: 0x06023F7A RID: 147322 RVA: 0x00931BBB File Offset: 0x0092FDBB
		public unsafe FLinearColor SeasonWeights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004474 RID: 17524
		// (get) Token: 0x06023F7B RID: 147323 RVA: 0x00931BD0 File Offset: 0x0092FDD0
		// (set) Token: 0x06023F7C RID: 147324 RVA: 0x00931BE4 File Offset: 0x0092FDE4
		public unsafe FVector ActivationBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004475 RID: 17525
		// (get) Token: 0x06023F7D RID: 147325 RVA: 0x00931BF9 File Offset: 0x0092FDF9
		// (set) Token: 0x06023F7E RID: 147326 RVA: 0x00931C09 File Offset: 0x0092FE09
		public unsafe float SeasonPPC_Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x06023F7F RID: 147327 RVA: 0x00931C1A File Offset: 0x0092FE1A
		// (set) Token: 0x06023F80 RID: 147328 RVA: 0x00931C2A File Offset: 0x0092FE2A
		public unsafe float WeatherPPC_Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x06023F81 RID: 147329 RVA: 0x00931C3B File Offset: 0x0092FE3B
		// (set) Token: 0x06023F82 RID: 147330 RVA: 0x00931C4B File Offset: 0x0092FE4B
		public unsafe float ExitFadeOutDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004478 RID: 17528
		// (get) Token: 0x06023F83 RID: 147331 RVA: 0x00931C5C File Offset: 0x0092FE5C
		// (set) Token: 0x06023F84 RID: 147332 RVA: 0x00931C6C File Offset: 0x0092FE6C
		public unsafe bool bIsFadingOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004479 RID: 17529
		// (get) Token: 0x06023F85 RID: 147333 RVA: 0x00931C7D File Offset: 0x0092FE7D
		// (set) Token: 0x06023F86 RID: 147334 RVA: 0x00931C8D File Offset: 0x0092FE8D
		public unsafe float FadeOutTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x06023F87 RID: 147335 RVA: 0x00931C9E File Offset: 0x0092FE9E
		// (set) Token: 0x06023F88 RID: 147336 RVA: 0x00931CAE File Offset: 0x0092FEAE
		public unsafe float RainChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x06023F89 RID: 147337 RVA: 0x00931CBF File Offset: 0x0092FEBF
		// (set) Token: 0x06023F8A RID: 147338 RVA: 0x00931CCF File Offset: 0x0092FECF
		public unsafe float RainMinDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x06023F8B RID: 147339 RVA: 0x00931CE0 File Offset: 0x0092FEE0
		// (set) Token: 0x06023F8C RID: 147340 RVA: 0x00931CF0 File Offset: 0x0092FEF0
		public unsafe float RainMaxDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x06023F8D RID: 147341 RVA: 0x00931D01 File Offset: 0x0092FF01
		// (set) Token: 0x06023F8E RID: 147342 RVA: 0x00931D11 File Offset: 0x0092FF11
		public unsafe float RainDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x06023F8F RID: 147343 RVA: 0x00931D22 File Offset: 0x0092FF22
		// (set) Token: 0x06023F90 RID: 147344 RVA: 0x00931D36 File Offset: 0x0092FF36
		[Nullable(0)]
		public unsafe TEnumAsByte<E_ESeasonWeather> RainState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_38);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x06023F91 RID: 147345 RVA: 0x00931D4B File Offset: 0x0092FF4B
		// (set) Token: 0x06023F92 RID: 147346 RVA: 0x00931D5B File Offset: 0x0092FF5B
		public unsafe float RainTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17004480 RID: 17536
		// (get) Token: 0x06023F93 RID: 147347 RVA: 0x00931D6C File Offset: 0x0092FF6C
		// (set) Token: 0x06023F94 RID: 147348 RVA: 0x00931D7C File Offset: 0x0092FF7C
		public unsafe float RainTargetDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17004481 RID: 17537
		// (get) Token: 0x06023F95 RID: 147349 RVA: 0x00931D8D File Offset: 0x0092FF8D
		// (set) Token: 0x06023F96 RID: 147350 RVA: 0x00931D9D File Offset: 0x0092FF9D
		public unsafe float SnowChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x06023F97 RID: 147351 RVA: 0x00931DAE File Offset: 0x0092FFAE
		// (set) Token: 0x06023F98 RID: 147352 RVA: 0x00931DBE File Offset: 0x0092FFBE
		public unsafe float SnowMinDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x06023F99 RID: 147353 RVA: 0x00931DCF File Offset: 0x0092FFCF
		// (set) Token: 0x06023F9A RID: 147354 RVA: 0x00931DDF File Offset: 0x0092FFDF
		public unsafe float SnowMaxDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x06023F9B RID: 147355 RVA: 0x00931DF0 File Offset: 0x0092FFF0
		// (set) Token: 0x06023F9C RID: 147356 RVA: 0x00931E00 File Offset: 0x00930000
		public unsafe float SnowDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x06023F9D RID: 147357 RVA: 0x00931E11 File Offset: 0x00930011
		// (set) Token: 0x06023F9E RID: 147358 RVA: 0x00931E25 File Offset: 0x00930025
		[Nullable(0)]
		public unsafe TEnumAsByte<E_ESeasonWeather> SnowState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_45);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x06023F9F RID: 147359 RVA: 0x00931E3A File Offset: 0x0093003A
		// (set) Token: 0x06023FA0 RID: 147360 RVA: 0x00931E4A File Offset: 0x0093004A
		public unsafe float SnowTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x06023FA1 RID: 147361 RVA: 0x00931E5B File Offset: 0x0093005B
		// (set) Token: 0x06023FA2 RID: 147362 RVA: 0x00931E6B File Offset: 0x0093006B
		public unsafe float SnowTargetDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x06023FA3 RID: 147363 RVA: 0x00931E7C File Offset: 0x0093007C
		// (set) Token: 0x06023FA4 RID: 147364 RVA: 0x00931E8C File Offset: 0x0093008C
		public unsafe float RainCooldownMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x06023FA5 RID: 147365 RVA: 0x00931E9D File Offset: 0x0093009D
		// (set) Token: 0x06023FA6 RID: 147366 RVA: 0x00931EAD File Offset: 0x009300AD
		public unsafe float RainCooldownMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x06023FA7 RID: 147367 RVA: 0x00931EBE File Offset: 0x009300BE
		// (set) Token: 0x06023FA8 RID: 147368 RVA: 0x00931ECE File Offset: 0x009300CE
		public unsafe float RainTargetCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x06023FA9 RID: 147369 RVA: 0x00931EDF File Offset: 0x009300DF
		// (set) Token: 0x06023FAA RID: 147370 RVA: 0x00931EEF File Offset: 0x009300EF
		public unsafe bool bEditorPreviewRain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x06023FAB RID: 147371 RVA: 0x00931F00 File Offset: 0x00930100
		// (set) Token: 0x06023FAC RID: 147372 RVA: 0x00931F10 File Offset: 0x00930110
		public unsafe float SnowCooldownMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x06023FAD RID: 147373 RVA: 0x00931F21 File Offset: 0x00930121
		// (set) Token: 0x06023FAE RID: 147374 RVA: 0x00931F31 File Offset: 0x00930131
		public unsafe float SnowCooldownMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x06023FAF RID: 147375 RVA: 0x00931F42 File Offset: 0x00930142
		// (set) Token: 0x06023FB0 RID: 147376 RVA: 0x00931F52 File Offset: 0x00930152
		public unsafe float SnowTargetCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x06023FB1 RID: 147377 RVA: 0x00931F63 File Offset: 0x00930163
		// (set) Token: 0x06023FB2 RID: 147378 RVA: 0x00931F73 File Offset: 0x00930173
		public unsafe bool bEditorPreviewSnow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeasonPostProcessController_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x06023FB3 RID: 147379 RVA: 0x00931F84 File Offset: 0x00930184
		// (set) Token: 0x06023FB4 RID: 147380 RVA: 0x00931F98 File Offset: 0x00930198
		public unsafe AKuroPostProcessVolume PPV_Spring_Final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x06023FB5 RID: 147381 RVA: 0x00931FAD File Offset: 0x009301AD
		// (set) Token: 0x06023FB6 RID: 147382 RVA: 0x00931FC1 File Offset: 0x009301C1
		public unsafe AKuroPostProcessVolume PPV_Summer_Final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17004492 RID: 17554
		// (get) Token: 0x06023FB7 RID: 147383 RVA: 0x00931FD6 File Offset: 0x009301D6
		// (set) Token: 0x06023FB8 RID: 147384 RVA: 0x00931FEA File Offset: 0x009301EA
		public unsafe AKuroPostProcessVolume PPV_Autumn_Final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x17004493 RID: 17555
		// (get) Token: 0x06023FB9 RID: 147385 RVA: 0x00931FFF File Offset: 0x009301FF
		// (set) Token: 0x06023FBA RID: 147386 RVA: 0x00932013 File Offset: 0x00930213
		public unsafe AKuroPostProcessVolume PPV_Winter_Final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_59);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_59, value);
			}
		}

		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x06023FBB RID: 147387 RVA: 0x00932028 File Offset: 0x00930228
		// (set) Token: 0x06023FBC RID: 147388 RVA: 0x0093203C File Offset: 0x0093023C
		public unsafe AKuroPostProcessVolume PPV_Rain_Final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x06023FBD RID: 147389 RVA: 0x00932051 File Offset: 0x00930251
		// (set) Token: 0x06023FBE RID: 147390 RVA: 0x00932065 File Offset: 0x00930265
		public unsafe AKuroPostProcessVolume PPV_Snow_Final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_61);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeasonPostProcessController_C.__PropertyOffset_61, value);
			}
		}

		// Token: 0x06023FBF RID: 147391 RVA: 0x0093207A File Offset: 0x0093027A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Get_WP_SeasonPostProcess()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__Get_WP_SeasonPostProcess_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC0 RID: 147392 RVA: 0x0093208E File Offset: 0x0093028E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWeatherSnow()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__UpdateWeatherSnow_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC1 RID: 147393 RVA: 0x009320A2 File Offset: 0x009302A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWeatherRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__UpdateWeatherRain_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC2 RID: 147394 RVA: 0x009320B6 File Offset: 0x009302B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFadeOut()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__UpdateFadeOut_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC3 RID: 147395 RVA: 0x009320CA File Offset: 0x009302CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetAllPPV()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__ResetAllPPV_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC4 RID: 147396 RVA: 0x009320DE File Offset: 0x009302DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSeasonPPV()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__UpdateSeasonPPV_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC5 RID: 147397 RVA: 0x009320F2 File Offset: 0x009302F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalcSeasonWeights()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__CalcSeasonWeights_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC6 RID: 147398 RVA: 0x00932106 File Offset: 0x00930306
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023FC7 RID: 147399 RVA: 0x0093211A File Offset: 0x0093031A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023FC8 RID: 147400 RVA: 0x00932130 File Offset: 0x00930330
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SeasonPostProcessController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeasonPostProcessController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeasonPostProcessController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeasonPostProcessController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023FC9 RID: 147401 RVA: 0x00932178 File Offset: 0x00930378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SeasonPostProcessController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeasonPostProcessController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeasonPostProcessController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeasonPostProcessController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023FCA RID: 147402 RVA: 0x009321C0 File Offset: 0x009303C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SeasonPostProcessController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeasonPostProcessController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeasonPostProcessController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeasonPostProcessController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023FCB RID: 147403 RVA: 0x00932208 File Offset: 0x00930408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SeasonPostProcessController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeasonPostProcessController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeasonPostProcessController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeasonPostProcessController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023FCC RID: 147404 RVA: 0x0093224F File Offset: 0x0093044F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023FCD RID: 147405 RVA: 0x00932263 File Offset: 0x00930463
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023FCE RID: 147406 RVA: 0x00932278 File Offset: 0x00930478
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023FCF RID: 147407 RVA: 0x00932304 File Offset: 0x00930504
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeasonPostProcessController_C.__BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023FD0 RID: 147408 RVA: 0x009323BE File Offset: 0x009305BE
		protected BP_SeasonPostProcessController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C9F RID: 72863
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroSeasonsManager/SeasonPostProcessController/BP_SeasonPostProcessController.BP_SeasonPostProcessController_C";

		// Token: 0x04011CA0 RID: 72864
		private static IntPtr _ClassPtr;

		// Token: 0x04011CA1 RID: 72865
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011CA2 RID: 72866
		internal static int __PropertyOffset_1;

		// Token: 0x04011CA3 RID: 72867
		internal static int __PropertyOffset_2;

		// Token: 0x04011CA4 RID: 72868
		internal static int __PropertyOffset_3;

		// Token: 0x04011CA5 RID: 72869
		internal static int __PropertyOffset_4;

		// Token: 0x04011CA6 RID: 72870
		internal static int __PropertyOffset_5;

		// Token: 0x04011CA7 RID: 72871
		internal static int __PropertyOffset_6;

		// Token: 0x04011CA8 RID: 72872
		internal static int __PropertyOffset_7;

		// Token: 0x04011CA9 RID: 72873
		internal static int __PropertyOffset_8;

		// Token: 0x04011CAA RID: 72874
		internal static int __PropertyOffset_9;

		// Token: 0x04011CAB RID: 72875
		internal static int __PropertyOffset_10;

		// Token: 0x04011CAC RID: 72876
		internal static int __PropertyOffset_11;

		// Token: 0x04011CAD RID: 72877
		internal static int __PropertyOffset_12;

		// Token: 0x04011CAE RID: 72878
		internal static int __PropertyOffset_13;

		// Token: 0x04011CAF RID: 72879
		internal static int __PropertyOffset_14;

		// Token: 0x04011CB0 RID: 72880
		internal static int __PropertyOffset_15;

		// Token: 0x04011CB1 RID: 72881
		internal static int __PropertyOffset_16;

		// Token: 0x04011CB2 RID: 72882
		internal static int __PropertyOffset_17;

		// Token: 0x04011CB3 RID: 72883
		internal static int __PropertyOffset_18;

		// Token: 0x04011CB4 RID: 72884
		internal static int __PropertyOffset_19;

		// Token: 0x04011CB5 RID: 72885
		internal static int __PropertyOffset_20;

		// Token: 0x04011CB6 RID: 72886
		internal static int __PropertyOffset_21;

		// Token: 0x04011CB7 RID: 72887
		internal static int __PropertyOffset_22;

		// Token: 0x04011CB8 RID: 72888
		internal static int __PropertyOffset_23;

		// Token: 0x04011CB9 RID: 72889
		internal static int __PropertyOffset_24;

		// Token: 0x04011CBA RID: 72890
		internal static int __PropertyOffset_25;

		// Token: 0x04011CBB RID: 72891
		internal static int __PropertyOffset_26;

		// Token: 0x04011CBC RID: 72892
		internal static int __PropertyOffset_27;

		// Token: 0x04011CBD RID: 72893
		internal static int __PropertyOffset_28;

		// Token: 0x04011CBE RID: 72894
		internal static int __PropertyOffset_29;

		// Token: 0x04011CBF RID: 72895
		internal static int __PropertyOffset_30;

		// Token: 0x04011CC0 RID: 72896
		internal static int __PropertyOffset_31;

		// Token: 0x04011CC1 RID: 72897
		internal static int __PropertyOffset_32;

		// Token: 0x04011CC2 RID: 72898
		internal static int __PropertyOffset_33;

		// Token: 0x04011CC3 RID: 72899
		internal static int __PropertyOffset_34;

		// Token: 0x04011CC4 RID: 72900
		internal static int __PropertyOffset_35;

		// Token: 0x04011CC5 RID: 72901
		internal static int __PropertyOffset_36;

		// Token: 0x04011CC6 RID: 72902
		internal static int __PropertyOffset_37;

		// Token: 0x04011CC7 RID: 72903
		internal static int __PropertyOffset_38;

		// Token: 0x04011CC8 RID: 72904
		internal static int __PropertyOffset_39;

		// Token: 0x04011CC9 RID: 72905
		internal static int __PropertyOffset_40;

		// Token: 0x04011CCA RID: 72906
		internal static int __PropertyOffset_41;

		// Token: 0x04011CCB RID: 72907
		internal static int __PropertyOffset_42;

		// Token: 0x04011CCC RID: 72908
		internal static int __PropertyOffset_43;

		// Token: 0x04011CCD RID: 72909
		internal static int __PropertyOffset_44;

		// Token: 0x04011CCE RID: 72910
		internal static int __PropertyOffset_45;

		// Token: 0x04011CCF RID: 72911
		internal static int __PropertyOffset_46;

		// Token: 0x04011CD0 RID: 72912
		internal static int __PropertyOffset_47;

		// Token: 0x04011CD1 RID: 72913
		internal static int __PropertyOffset_48;

		// Token: 0x04011CD2 RID: 72914
		internal static int __PropertyOffset_49;

		// Token: 0x04011CD3 RID: 72915
		internal static int __PropertyOffset_50;

		// Token: 0x04011CD4 RID: 72916
		internal static int __PropertyOffset_51;

		// Token: 0x04011CD5 RID: 72917
		internal static int __PropertyOffset_52;

		// Token: 0x04011CD6 RID: 72918
		internal static int __PropertyOffset_53;

		// Token: 0x04011CD7 RID: 72919
		internal static int __PropertyOffset_54;

		// Token: 0x04011CD8 RID: 72920
		internal static int __PropertyOffset_55;

		// Token: 0x04011CD9 RID: 72921
		internal static int __PropertyOffset_56;

		// Token: 0x04011CDA RID: 72922
		internal static int __PropertyOffset_57;

		// Token: 0x04011CDB RID: 72923
		internal static int __PropertyOffset_58;

		// Token: 0x04011CDC RID: 72924
		internal static int __PropertyOffset_59;

		// Token: 0x04011CDD RID: 72925
		internal static int __PropertyOffset_60;

		// Token: 0x04011CDE RID: 72926
		internal static int __PropertyOffset_61;

		// Token: 0x04011CDF RID: 72927
		private static IntPtr __Get_WP_SeasonPostProcess_NativeFunctionPtr;

		// Token: 0x04011CE0 RID: 72928
		private static IntPtr __UpdateWeatherSnow_NativeFunctionPtr;

		// Token: 0x04011CE1 RID: 72929
		private static IntPtr __UpdateWeatherRain_NativeFunctionPtr;

		// Token: 0x04011CE2 RID: 72930
		private static IntPtr __UpdateFadeOut_NativeFunctionPtr;

		// Token: 0x04011CE3 RID: 72931
		private static IntPtr __ResetAllPPV_NativeFunctionPtr;

		// Token: 0x04011CE4 RID: 72932
		private static IntPtr __UpdateSeasonPPV_NativeFunctionPtr;

		// Token: 0x04011CE5 RID: 72933
		private static IntPtr __CalcSeasonWeights_NativeFunctionPtr;

		// Token: 0x04011CE6 RID: 72934
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011CE7 RID: 72935
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011CE8 RID: 72936
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011CE9 RID: 72937
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011CEA RID: 72938
		private static IntPtr __BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011CEB RID: 72939
		private static IntPtr __BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009EBB RID: 40635
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403179C RID: 202652
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EBC RID: 40636
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403179D RID: 202653
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EBD RID: 40637
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403179E RID: 202654
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403179F RID: 202655
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317A0 RID: 202656
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317A1 RID: 202657
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009EBE RID: 40638
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_SeasonPostProcessController_PostProcessBoundCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317A2 RID: 202658
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317A3 RID: 202659
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317A4 RID: 202660
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317A5 RID: 202661
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040317A6 RID: 202662
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040317A7 RID: 202663
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
