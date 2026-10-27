using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud;
using AkiClient.Game.Aki.Render.RuntimeBP.UI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D2C RID: 15660
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C")]
	[UnrealStructLayout(17344, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 17343)]
	public class BP_GlobalGI_C : AKuroGlobalGI, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025B12 RID: 154386 RVA: 0x009608D1 File Offset: 0x0095EAD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GlobalGI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C");
			}
			return BP_GlobalGI_C._ClassPtr;
		}

		// Token: 0x06025B13 RID: 154387 RVA: 0x009608F8 File Offset: 0x0095EAF8
		public BP_GlobalGI_C() : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025B14 RID: 154388 RVA: 0x00960920 File Offset: 0x0095EB20
		[NullableContext(1)]
		public BP_GlobalGI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E15 RID: 19989
		// (get) Token: 0x06025B15 RID: 154389 RVA: 0x00960953 File Offset: 0x0095EB53
		// (set) Token: 0x06025B16 RID: 154390 RVA: 0x00960967 File Offset: 0x0095EB67
		public unsafe UChildActorComponent KuroDynamicSky
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004E16 RID: 19990
		// (get) Token: 0x06025B17 RID: 154391 RVA: 0x0096097C File Offset: 0x0095EB7C
		// (set) Token: 0x06025B18 RID: 154392 RVA: 0x00960990 File Offset: 0x0095EB90
		public unsafe UKuroPostProcessComponent ToonBaseFFTPost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004E17 RID: 19991
		// (get) Token: 0x06025B19 RID: 154393 RVA: 0x009609A5 File Offset: 0x0095EBA5
		// (set) Token: 0x06025B1A RID: 154394 RVA: 0x009609B9 File Offset: 0x0095EBB9
		public unsafe USkyAtmosphereComponent SkyAtmosphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyAtmosphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004E18 RID: 19992
		// (get) Token: 0x06025B1B RID: 154395 RVA: 0x009609CE File Offset: 0x0095EBCE
		// (set) Token: 0x06025B1C RID: 154396 RVA: 0x009609E2 File Offset: 0x0095EBE2
		public unsafe UPostProcessComponent GodRayPostVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004E19 RID: 19993
		// (get) Token: 0x06025B1D RID: 154397 RVA: 0x009609F7 File Offset: 0x0095EBF7
		// (set) Token: 0x06025B1E RID: 154398 RVA: 0x00960A0B File Offset: 0x0095EC0B
		public unsafe USceneRayTracingGICaptureComponentCube SceneRayTracingGICaptureComponentCube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneRayTracingGICaptureComponentCube>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004E1A RID: 19994
		// (get) Token: 0x06025B1F RID: 154399 RVA: 0x00960A20 File Offset: 0x0095EC20
		// (set) Token: 0x06025B20 RID: 154400 RVA: 0x00960A34 File Offset: 0x0095EC34
		public unsafe UChildActorComponent KuroVolumeCloudGlobal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004E1B RID: 19995
		// (get) Token: 0x06025B21 RID: 154401 RVA: 0x00960A49 File Offset: 0x0095EC49
		// (set) Token: 0x06025B22 RID: 154402 RVA: 0x00960A5D File Offset: 0x0095EC5D
		public unsafe UChildActorComponent RainOverrider
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x06025B23 RID: 154403 RVA: 0x00960A72 File Offset: 0x0095EC72
		// (set) Token: 0x06025B24 RID: 154404 RVA: 0x00960A86 File Offset: 0x0095EC86
		public unsafe UKuroGlobalHeightMapComponent KuroGlobalHeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGlobalHeightMapComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x06025B25 RID: 154405 RVA: 0x00960A9B File Offset: 0x0095EC9B
		// (set) Token: 0x06025B26 RID: 154406 RVA: 0x00960AAF File Offset: 0x0095ECAF
		public unsafe UStaticMeshComponent CloudOcean
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x06025B27 RID: 154407 RVA: 0x00960AC4 File Offset: 0x0095ECC4
		// (set) Token: 0x06025B28 RID: 154408 RVA: 0x00960AD8 File Offset: 0x0095ECD8
		public unsafe UKuroGlobalColorMapComponent KuroGlobalColorMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGlobalColorMapComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x06025B29 RID: 154409 RVA: 0x00960AED File Offset: 0x0095ECED
		// (set) Token: 0x06025B2A RID: 154410 RVA: 0x00960B01 File Offset: 0x0095ED01
		public unsafe UStaticMeshComponent SM_MilkyWay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x06025B2B RID: 154411 RVA: 0x00960B16 File Offset: 0x0095ED16
		// (set) Token: 0x06025B2C RID: 154412 RVA: 0x00960B2A File Offset: 0x0095ED2A
		public unsafe BP_UiSceneRenderingComponent_C BP_UiSceneRenderingComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_UiSceneRenderingComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x06025B2D RID: 154413 RVA: 0x00960B3F File Offset: 0x0095ED3F
		// (set) Token: 0x06025B2E RID: 154414 RVA: 0x00960B53 File Offset: 0x0095ED53
		public unsafe UKuroPostProcessComponent GlobalUiScenePostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x06025B2F RID: 154415 RVA: 0x00960B68 File Offset: 0x0095ED68
		// (set) Token: 0x06025B30 RID: 154416 RVA: 0x00960B7C File Offset: 0x0095ED7C
		public unsafe UChildActorComponent ImposterManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x06025B31 RID: 154417 RVA: 0x00960B91 File Offset: 0x0095ED91
		// (set) Token: 0x06025B32 RID: 154418 RVA: 0x00960BA5 File Offset: 0x0095EDA5
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x06025B33 RID: 154419 RVA: 0x00960BBA File Offset: 0x0095EDBA
		// (set) Token: 0x06025B34 RID: 154420 RVA: 0x00960BCE File Offset: 0x0095EDCE
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x06025B35 RID: 154421 RVA: 0x00960BE3 File Offset: 0x0095EDE3
		// (set) Token: 0x06025B36 RID: 154422 RVA: 0x00960BF7 File Offset: 0x0095EDF7
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x06025B37 RID: 154423 RVA: 0x00960C0C File Offset: 0x0095EE0C
		// (set) Token: 0x06025B38 RID: 154424 RVA: 0x00960C20 File Offset: 0x0095EE20
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x06025B39 RID: 154425 RVA: 0x00960C35 File Offset: 0x0095EE35
		// (set) Token: 0x06025B3A RID: 154426 RVA: 0x00960C49 File Offset: 0x0095EE49
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x06025B3B RID: 154427 RVA: 0x00960C5E File Offset: 0x0095EE5E
		// (set) Token: 0x06025B3C RID: 154428 RVA: 0x00960C72 File Offset: 0x0095EE72
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x06025B3D RID: 154429 RVA: 0x00960C87 File Offset: 0x0095EE87
		// (set) Token: 0x06025B3E RID: 154430 RVA: 0x00960C9B File Offset: 0x0095EE9B
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x06025B3F RID: 154431 RVA: 0x00960CB0 File Offset: 0x0095EEB0
		// (set) Token: 0x06025B40 RID: 154432 RVA: 0x00960CC4 File Offset: 0x0095EEC4
		public unsafe UKuroPostProcessComponent LUTPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x06025B41 RID: 154433 RVA: 0x00960CD9 File Offset: 0x0095EED9
		// (set) Token: 0x06025B42 RID: 154434 RVA: 0x00960CED File Offset: 0x0095EEED
		public unsafe UStaticMeshComponent SM_Stars
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x06025B43 RID: 154435 RVA: 0x00960D02 File Offset: 0x0095EF02
		// (set) Token: 0x06025B44 RID: 154436 RVA: 0x00960D16 File Offset: 0x0095EF16
		public unsafe UStaticMeshComponent Skybox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x06025B45 RID: 154437 RVA: 0x00960D2B File Offset: 0x0095EF2B
		// (set) Token: 0x06025B46 RID: 154438 RVA: 0x00960D3F File Offset: 0x0095EF3F
		public unsafe UPostProcessComponent GlobalPostProcessVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x06025B47 RID: 154439 RVA: 0x00960D54 File Offset: 0x0095EF54
		// (set) Token: 0x06025B48 RID: 154440 RVA: 0x00960D68 File Offset: 0x0095EF68
		public unsafe UDirectionalLightComponent SceneLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x06025B49 RID: 154441 RVA: 0x00960D7D File Offset: 0x0095EF7D
		// (set) Token: 0x06025B4A RID: 154442 RVA: 0x00960D91 File Offset: 0x0095EF91
		public unsafe UDirectionalLightComponent AtmoMoonLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x06025B4B RID: 154443 RVA: 0x00960DA6 File Offset: 0x0095EFA6
		// (set) Token: 0x06025B4C RID: 154444 RVA: 0x00960DBA File Offset: 0x0095EFBA
		public unsafe UDirectionalLightComponent AtmoSunLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17004E31 RID: 20017
		// (get) Token: 0x06025B4D RID: 154445 RVA: 0x00960DCF File Offset: 0x0095EFCF
		// (set) Token: 0x06025B4E RID: 154446 RVA: 0x00960DE3 File Offset: 0x0095EFE3
		public unsafe USkyLightComponent SkyLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17004E32 RID: 20018
		// (get) Token: 0x06025B4F RID: 154447 RVA: 0x00960DF8 File Offset: 0x0095EFF8
		// (set) Token: 0x06025B50 RID: 154448 RVA: 0x00960E0C File Offset: 0x0095F00C
		public unsafe UExponentialHeightFogComponent HeightFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UExponentialHeightFogComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17004E33 RID: 20019
		// (get) Token: 0x06025B51 RID: 154449 RVA: 0x00960E21 File Offset: 0x0095F021
		// (set) Token: 0x06025B52 RID: 154450 RVA: 0x00960E35 File Offset: 0x0095F035
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17004E34 RID: 20020
		// (get) Token: 0x06025B53 RID: 154451 RVA: 0x00960E4A File Offset: 0x0095F04A
		// (set) Token: 0x06025B54 RID: 154452 RVA: 0x00960E5A File Offset: 0x0095F05A
		public unsafe float CharacterLightHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x06025B55 RID: 154453 RVA: 0x00960E6B File Offset: 0x0095F06B
		// (set) Token: 0x06025B56 RID: 154454 RVA: 0x00960E7B File Offset: 0x0095F07B
		public unsafe float CurrTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x06025B57 RID: 154455 RVA: 0x00960E8C File Offset: 0x0095F08C
		// (set) Token: 0x06025B58 RID: 154456 RVA: 0x00960E9C File Offset: 0x0095F09C
		public unsafe bool EnableTODCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x06025B59 RID: 154457 RVA: 0x00960EAD File Offset: 0x0095F0AD
		// (set) Token: 0x06025B5A RID: 154458 RVA: 0x00960EBD File Offset: 0x0095F0BD
		public unsafe bool PauseTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x06025B5B RID: 154459 RVA: 0x00960ECE File Offset: 0x0095F0CE
		// (set) Token: 0x06025B5C RID: 154460 RVA: 0x00960EDE File Offset: 0x0095F0DE
		public unsafe bool 编辑器下更新
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x06025B5D RID: 154461 RVA: 0x00960EEF File Offset: 0x0095F0EF
		// (set) Token: 0x06025B5E RID: 154462 RVA: 0x00960EFF File Offset: 0x0095F0FF
		public unsafe float TODCycleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17004E3A RID: 20026
		// (get) Token: 0x06025B5F RID: 154463 RVA: 0x00960F10 File Offset: 0x0095F110
		// (set) Token: 0x06025B60 RID: 154464 RVA: 0x00960F24 File Offset: 0x0095F124
		public unsafe FRotator SenenDirLightRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17004E3B RID: 20027
		// (get) Token: 0x06025B61 RID: 154465 RVA: 0x00960F39 File Offset: 0x0095F139
		// (set) Token: 0x06025B62 RID: 154466 RVA: 0x00960F49 File Offset: 0x0095F149
		public unsafe float MainLightAngleLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17004E3C RID: 20028
		// (get) Token: 0x06025B63 RID: 154467 RVA: 0x00960F5A File Offset: 0x0095F15A
		// (set) Token: 0x06025B64 RID: 154468 RVA: 0x00960F6A File Offset: 0x0095F16A
		public unsafe bool IsGIEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x06025B65 RID: 154469 RVA: 0x00960F7B File Offset: 0x0095F17B
		// (set) Token: 0x06025B66 RID: 154470 RVA: 0x00960F8B File Offset: 0x0095F18B
		public unsafe bool 使用随机的昼夜循环天气组
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x06025B67 RID: 154471 RVA: 0x00960F9C File Offset: 0x0095F19C
		// (set) Token: 0x06025B68 RID: 154472 RVA: 0x00960FAC File Offset: 0x0095F1AC
		public unsafe int 当前的天气组索引值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x06025B69 RID: 154473 RVA: 0x00960FBD File Offset: 0x0095F1BD
		// (set) Token: 0x06025B6A RID: 154474 RVA: 0x00960FD1 File Offset: 0x0095F1D1
		public unsafe FLinearColor 太阳颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x06025B6B RID: 154475 RVA: 0x00960FE8 File Offset: 0x0095F1E8
		// (set) Token: 0x06025B6C RID: 154476 RVA: 0x00961021 File Offset: 0x0095F221
		[Nullable(1)]
		public TArray<FVector2D> SunLightExistTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._SunLightExistTime) == null)
				{
					result = (this._SunLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_44, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SunLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x06025B6D RID: 154477 RVA: 0x00961030 File Offset: 0x0095F230
		// (set) Token: 0x06025B6E RID: 154478 RVA: 0x00961069 File Offset: 0x0095F269
		[Nullable(1)]
		public TArray<FVector2D> MoonLightExistTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._MoonLightExistTime) == null)
				{
					result = (this._MoonLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_45, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MoonLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x06025B6F RID: 154479 RVA: 0x00961077 File Offset: 0x0095F277
		// (set) Token: 0x06025B70 RID: 154480 RVA: 0x00961087 File Offset: 0x0095F287
		public unsafe bool 运行时自动开始循环
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x06025B71 RID: 154481 RVA: 0x00961098 File Offset: 0x0095F298
		// (set) Token: 0x06025B72 RID: 154482 RVA: 0x009610A8 File Offset: 0x0095F2A8
		public unsafe bool UISceneRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x06025B73 RID: 154483 RVA: 0x009610B9 File Offset: 0x0095F2B9
		// (set) Token: 0x06025B74 RID: 154484 RVA: 0x009610C9 File Offset: 0x0095F2C9
		public unsafe bool IsRootGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x06025B75 RID: 154485 RVA: 0x009610DA File Offset: 0x0095F2DA
		// (set) Token: 0x06025B76 RID: 154486 RVA: 0x009610EA File Offset: 0x0095F2EA
		public unsafe bool DEBUG_使用角色预览方向光
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x06025B77 RID: 154487 RVA: 0x009610FB File Offset: 0x0095F2FB
		// (set) Token: 0x06025B78 RID: 154488 RVA: 0x0096110B File Offset: 0x0095F30B
		public unsafe float DEBUG_角色预览方向光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x06025B79 RID: 154489 RVA: 0x0096111C File Offset: 0x0095F31C
		// (set) Token: 0x06025B7A RID: 154490 RVA: 0x0096112C File Offset: 0x0095F32C
		public unsafe int TotalDaysElapsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x06025B7B RID: 154491 RVA: 0x0096113D File Offset: 0x0095F33D
		// (set) Token: 0x06025B7C RID: 154492 RVA: 0x0096114D File Offset: 0x0095F34D
		public unsafe float MoonFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x06025B7D RID: 154493 RVA: 0x0096115E File Offset: 0x0095F35E
		// (set) Token: 0x06025B7E RID: 154494 RVA: 0x00961172 File Offset: 0x0095F372
		public unsafe FVector2D MoonVisibleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x06025B7F RID: 154495 RVA: 0x00961187 File Offset: 0x0095F387
		// (set) Token: 0x06025B80 RID: 154496 RVA: 0x00961197 File Offset: 0x0095F397
		public unsafe bool 编辑器下关闭LensFlare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x06025B81 RID: 154497 RVA: 0x009611A8 File Offset: 0x0095F3A8
		// (set) Token: 0x06025B82 RID: 154498 RVA: 0x009611B8 File Offset: 0x0095F3B8
		public unsafe bool 关闭雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x06025B83 RID: 154499 RVA: 0x009611C9 File Offset: 0x0095F3C9
		// (set) Token: 0x06025B84 RID: 154500 RVA: 0x009611D9 File Offset: 0x0095F3D9
		public unsafe bool RuntimeTimeEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E4D RID: 20045
		// (get) Token: 0x06025B85 RID: 154501 RVA: 0x009611EA File Offset: 0x0095F3EA
		// (set) Token: 0x06025B86 RID: 154502 RVA: 0x009611FA File Offset: 0x0095F3FA
		public unsafe float MainLightTickSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17004E4E RID: 20046
		// (get) Token: 0x06025B87 RID: 154503 RVA: 0x0096120B File Offset: 0x0095F40B
		// (set) Token: 0x06025B88 RID: 154504 RVA: 0x0096121B File Offset: 0x0095F41B
		public unsafe float MainLightTickCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17004E4F RID: 20047
		// (get) Token: 0x06025B89 RID: 154505 RVA: 0x0096122C File Offset: 0x0095F42C
		// (set) Token: 0x06025B8A RID: 154506 RVA: 0x0096123C File Offset: 0x0095F43C
		public unsafe bool ForceUpdateMainLightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E50 RID: 20048
		// (get) Token: 0x06025B8B RID: 154507 RVA: 0x0096124D File Offset: 0x0095F44D
		// (set) Token: 0x06025B8C RID: 154508 RVA: 0x0096125D File Offset: 0x0095F45D
		public unsafe float WindDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17004E51 RID: 20049
		// (get) Token: 0x06025B8D RID: 154509 RVA: 0x0096126E File Offset: 0x0095F46E
		// (set) Token: 0x06025B8E RID: 154510 RVA: 0x0096127E File Offset: 0x0095F47E
		public unsafe bool 使用临时雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_61) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_61) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E52 RID: 20050
		// (get) Token: 0x06025B8F RID: 154511 RVA: 0x0096128F File Offset: 0x0095F48F
		// (set) Token: 0x06025B90 RID: 154512 RVA: 0x009612A3 File Offset: 0x0095F4A3
		public unsafe UMaterialInstance TempFogMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_62);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_62, value);
			}
		}

		// Token: 0x17004E53 RID: 20051
		// (get) Token: 0x06025B91 RID: 154513 RVA: 0x009612B8 File Offset: 0x0095F4B8
		// (set) Token: 0x06025B92 RID: 154514 RVA: 0x009612CC File Offset: 0x0095F4CC
		public unsafe UMaterialInstanceDynamic TempFogDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x17004E54 RID: 20052
		// (get) Token: 0x06025B93 RID: 154515 RVA: 0x009612E1 File Offset: 0x0095F4E1
		// (set) Token: 0x06025B94 RID: 154516 RVA: 0x009612F5 File Offset: 0x0095F4F5
		public unsafe UMaterialInstance SkyboxMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x17004E55 RID: 20053
		// (get) Token: 0x06025B95 RID: 154517 RVA: 0x0096130A File Offset: 0x0095F50A
		// (set) Token: 0x06025B96 RID: 154518 RVA: 0x0096131E File Offset: 0x0095F51E
		public unsafe FLinearColor SunDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x06025B97 RID: 154519 RVA: 0x00961333 File Offset: 0x0095F533
		// (set) Token: 0x06025B98 RID: 154520 RVA: 0x00961347 File Offset: 0x0095F547
		public unsafe FLinearColor SunScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x06025B99 RID: 154521 RVA: 0x0096135C File Offset: 0x0095F55C
		// (set) Token: 0x06025B9A RID: 154522 RVA: 0x0096136C File Offset: 0x0095F56C
		public unsafe float SunSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x06025B9B RID: 154523 RVA: 0x0096137D File Offset: 0x0095F57D
		// (set) Token: 0x06025B9C RID: 154524 RVA: 0x00961391 File Offset: 0x0095F591
		public unsafe FLinearColor MoonDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x06025B9D RID: 154525 RVA: 0x009613A6 File Offset: 0x0095F5A6
		// (set) Token: 0x06025B9E RID: 154526 RVA: 0x009613BA File Offset: 0x0095F5BA
		public unsafe FLinearColor MoonScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x06025B9F RID: 154527 RVA: 0x009613CF File Offset: 0x0095F5CF
		// (set) Token: 0x06025BA0 RID: 154528 RVA: 0x009613DF File Offset: 0x0095F5DF
		public unsafe float MoonSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x06025BA1 RID: 154529 RVA: 0x009613F0 File Offset: 0x0095F5F0
		// (set) Token: 0x06025BA2 RID: 154530 RVA: 0x00961404 File Offset: 0x0095F604
		public unsafe FLinearColor HorizonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x06025BA3 RID: 154531 RVA: 0x00961419 File Offset: 0x0095F619
		// (set) Token: 0x06025BA4 RID: 154532 RVA: 0x00961429 File Offset: 0x0095F629
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x06025BA5 RID: 154533 RVA: 0x0096143A File Offset: 0x0095F63A
		// (set) Token: 0x06025BA6 RID: 154534 RVA: 0x0096144E File Offset: 0x0095F64E
		public unsafe FLinearColor ZenithColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x06025BA7 RID: 154535 RVA: 0x00961463 File Offset: 0x0095F663
		// (set) Token: 0x06025BA8 RID: 154536 RVA: 0x00961473 File Offset: 0x0095F673
		public unsafe float ExtremWeatherWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x17004E5F RID: 20063
		// (get) Token: 0x06025BA9 RID: 154537 RVA: 0x00961484 File Offset: 0x0095F684
		// (set) Token: 0x06025BAA RID: 154538 RVA: 0x00961498 File Offset: 0x0095F698
		public unsafe FLinearColor ST_TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17004E60 RID: 20064
		// (get) Token: 0x06025BAB RID: 154539 RVA: 0x009614AD File Offset: 0x0095F6AD
		// (set) Token: 0x06025BAC RID: 154540 RVA: 0x009614C1 File Offset: 0x0095F6C1
		public unsafe FLinearColor ST_DomeColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x06025BAD RID: 154541 RVA: 0x009614D6 File Offset: 0x0095F6D6
		// (set) Token: 0x06025BAE RID: 154542 RVA: 0x009614E6 File Offset: 0x0095F6E6
		public unsafe float ST_TopWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x06025BAF RID: 154543 RVA: 0x009614F7 File Offset: 0x0095F6F7
		// (set) Token: 0x06025BB0 RID: 154544 RVA: 0x0096150B File Offset: 0x0095F70B
		public unsafe UCurveFloat CharMainLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_78);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_78, value);
			}
		}

		// Token: 0x17004E63 RID: 20067
		// (get) Token: 0x06025BB1 RID: 154545 RVA: 0x00961520 File Offset: 0x0095F720
		// (set) Token: 0x06025BB2 RID: 154546 RVA: 0x00961534 File Offset: 0x0095F734
		public unsafe UCurveFloat CharSkyLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_79);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_79, value);
			}
		}

		// Token: 0x17004E64 RID: 20068
		// (get) Token: 0x06025BB3 RID: 154547 RVA: 0x00961549 File Offset: 0x0095F749
		// (set) Token: 0x06025BB4 RID: 154548 RVA: 0x00961559 File Offset: 0x0095F759
		public unsafe bool UseCharCustomLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_80) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_80) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x06025BB5 RID: 154549 RVA: 0x0096156A File Offset: 0x0095F76A
		// (set) Token: 0x06025BB6 RID: 154550 RVA: 0x0096157E File Offset: 0x0095F77E
		public unsafe FLinearColor CharAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_81);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_81) = value;
			}
		}

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x06025BB7 RID: 154551 RVA: 0x00961593 File Offset: 0x0095F793
		// (set) Token: 0x06025BB8 RID: 154552 RVA: 0x009615A7 File Offset: 0x0095F7A7
		public unsafe FLinearColor CharSkinAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_82);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_82) = value;
			}
		}

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x06025BB9 RID: 154553 RVA: 0x009615BC File Offset: 0x0095F7BC
		// (set) Token: 0x06025BBA RID: 154554 RVA: 0x009615D0 File Offset: 0x0095F7D0
		public unsafe UCurveFloat CharShadowCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_83);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_83, value);
			}
		}

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x06025BBB RID: 154555 RVA: 0x009615E5 File Offset: 0x0095F7E5
		// (set) Token: 0x06025BBC RID: 154556 RVA: 0x009615F9 File Offset: 0x0095F7F9
		public unsafe UMaterialInstance LightFunctionMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_84);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_84, value);
			}
		}

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x06025BBD RID: 154557 RVA: 0x0096160E File Offset: 0x0095F80E
		// (set) Token: 0x06025BBE RID: 154558 RVA: 0x0096161E File Offset: 0x0095F81E
		public unsafe float LightFunctionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_85);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x06025BBF RID: 154559 RVA: 0x0096162F File Offset: 0x0095F82F
		// (set) Token: 0x06025BC0 RID: 154560 RVA: 0x00961643 File Offset: 0x0095F843
		public unsafe UMaterialInstanceDynamic LightFunctionDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_86);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_86, value);
			}
		}

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x06025BC1 RID: 154561 RVA: 0x00961658 File Offset: 0x0095F858
		// (set) Token: 0x06025BC2 RID: 154562 RVA: 0x00961668 File Offset: 0x0095F868
		public unsafe bool DEBUG开启无音区特殊地表
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_87) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_87) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x06025BC3 RID: 154563 RVA: 0x00961679 File Offset: 0x0095F879
		// (set) Token: 0x06025BC4 RID: 154564 RVA: 0x0096168D File Offset: 0x0095F88D
		public unsafe UMaterialInstance LensFlareMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_88);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_88, value);
			}
		}

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x06025BC5 RID: 154565 RVA: 0x009616A2 File Offset: 0x0095F8A2
		// (set) Token: 0x06025BC6 RID: 154566 RVA: 0x009616B6 File Offset: 0x0095F8B6
		public unsafe UMaterialInstanceDynamic LensFlareDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_89);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_89, value);
			}
		}

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x06025BC7 RID: 154567 RVA: 0x009616CB File Offset: 0x0095F8CB
		// (set) Token: 0x06025BC8 RID: 154568 RVA: 0x009616DF File Offset: 0x0095F8DF
		public unsafe UMaterialInstance MobileLensFlareMI_Ghost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_90);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_90, value);
			}
		}

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x06025BC9 RID: 154569 RVA: 0x009616F4 File Offset: 0x0095F8F4
		// (set) Token: 0x06025BCA RID: 154570 RVA: 0x00961708 File Offset: 0x0095F908
		public unsafe FLinearColor Nadir_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_91);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_91) = value;
			}
		}

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x06025BCB RID: 154571 RVA: 0x0096171D File Offset: 0x0095F91D
		// (set) Token: 0x06025BCC RID: 154572 RVA: 0x0096172D File Offset: 0x0095F92D
		public unsafe float Nadir_Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x06025BCD RID: 154573 RVA: 0x0096173E File Offset: 0x0095F93E
		// (set) Token: 0x06025BCE RID: 154574 RVA: 0x0096174E File Offset: 0x0095F94E
		public unsafe float Sun_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x06025BCF RID: 154575 RVA: 0x0096175F File Offset: 0x0095F95F
		// (set) Token: 0x06025BD0 RID: 154576 RVA: 0x0096176F File Offset: 0x0095F96F
		public unsafe float Moon_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x06025BD1 RID: 154577 RVA: 0x00961780 File Offset: 0x0095F980
		// (set) Token: 0x06025BD2 RID: 154578 RVA: 0x00961794 File Offset: 0x0095F994
		public unsafe UMaterialInstance StarsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_95);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_95, value);
			}
		}

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x06025BD3 RID: 154579 RVA: 0x009617A9 File Offset: 0x0095F9A9
		// (set) Token: 0x06025BD4 RID: 154580 RVA: 0x009617B9 File Offset: 0x0095F9B9
		public unsafe float MainDirectionLightUpdateThreshold_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x17004E75 RID: 20085
		// (get) Token: 0x06025BD5 RID: 154581 RVA: 0x009617CA File Offset: 0x0095F9CA
		// (set) Token: 0x06025BD6 RID: 154582 RVA: 0x009617DA File Offset: 0x0095F9DA
		public unsafe float MainDirectionLightUpdateThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_97);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_97) = value;
			}
		}

		// Token: 0x17004E76 RID: 20086
		// (get) Token: 0x06025BD7 RID: 154583 RVA: 0x009617EB File Offset: 0x0095F9EB
		// (set) Token: 0x06025BD8 RID: 154584 RVA: 0x009617FF File Offset: 0x0095F9FF
		public unsafe FVector GlobalWindDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_98);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_98) = value;
			}
		}

		// Token: 0x17004E77 RID: 20087
		// (get) Token: 0x06025BD9 RID: 154585 RVA: 0x00961814 File Offset: 0x0095FA14
		// (set) Token: 0x06025BDA RID: 154586 RVA: 0x00961828 File Offset: 0x0095FA28
		public unsafe FVector GlobalWindRightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_99);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_99) = value;
			}
		}

		// Token: 0x17004E78 RID: 20088
		// (get) Token: 0x06025BDB RID: 154587 RVA: 0x0096183D File Offset: 0x0095FA3D
		// (set) Token: 0x06025BDC RID: 154588 RVA: 0x0096184D File Offset: 0x0095FA4D
		public unsafe float DEBUG无音区特殊地表强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x17004E79 RID: 20089
		// (get) Token: 0x06025BDD RID: 154589 RVA: 0x0096185E File Offset: 0x0095FA5E
		// (set) Token: 0x06025BDE RID: 154590 RVA: 0x00961872 File Offset: 0x0095FA72
		public unsafe BP_ControlTodTime_C TodTimeController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ControlTodTime_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_101);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_101, value);
			}
		}

		// Token: 0x17004E7A RID: 20090
		// (get) Token: 0x06025BDF RID: 154591 RVA: 0x00961887 File Offset: 0x0095FA87
		// (set) Token: 0x06025BE0 RID: 154592 RVA: 0x00961897 File Offset: 0x0095FA97
		public unsafe float RealTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x06025BE1 RID: 154593 RVA: 0x009618A8 File Offset: 0x0095FAA8
		// (set) Token: 0x06025BE2 RID: 154594 RVA: 0x009618BC File Offset: 0x0095FABC
		public unsafe BP_Clouds_C DynamicCloudsActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Clouds_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_103);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_103, value);
			}
		}

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x06025BE3 RID: 154595 RVA: 0x009618D1 File Offset: 0x0095FAD1
		// (set) Token: 0x06025BE4 RID: 154596 RVA: 0x009618E5 File Offset: 0x0095FAE5
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroDynamicCloudType> LocalDynamicCloudsType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_104);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x06025BE5 RID: 154597 RVA: 0x009618FA File Offset: 0x0095FAFA
		// (set) Token: 0x06025BE6 RID: 154598 RVA: 0x0096190A File Offset: 0x0095FB0A
		public unsafe float RainDensityChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_105);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_105) = value;
			}
		}

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x06025BE7 RID: 154599 RVA: 0x0096191B File Offset: 0x0095FB1B
		// (set) Token: 0x06025BE8 RID: 154600 RVA: 0x0096192B File Offset: 0x0095FB2B
		public unsafe float RainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_106);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_106) = value;
			}
		}

		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x06025BE9 RID: 154601 RVA: 0x0096193C File Offset: 0x0095FB3C
		// (set) Token: 0x06025BEA RID: 154602 RVA: 0x0096194C File Offset: 0x0095FB4C
		public unsafe float SnowDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_107);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_107) = value;
			}
		}

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x06025BEB RID: 154603 RVA: 0x0096195D File Offset: 0x0095FB5D
		// (set) Token: 0x06025BEC RID: 154604 RVA: 0x0096196D File Offset: 0x0095FB6D
		public unsafe float RainGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_108);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_108) = value;
			}
		}

		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x06025BED RID: 154605 RVA: 0x0096197E File Offset: 0x0095FB7E
		// (set) Token: 0x06025BEE RID: 154606 RVA: 0x0096198E File Offset: 0x0095FB8E
		public unsafe float RainGravityChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_109);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_109) = value;
			}
		}

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x06025BEF RID: 154607 RVA: 0x0096199F File Offset: 0x0095FB9F
		// (set) Token: 0x06025BF0 RID: 154608 RVA: 0x009619AF File Offset: 0x0095FBAF
		public unsafe float RainWindPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_110);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_110) = value;
			}
		}

		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x06025BF1 RID: 154609 RVA: 0x009619C0 File Offset: 0x0095FBC0
		// (set) Token: 0x06025BF2 RID: 154610 RVA: 0x009619D0 File Offset: 0x0095FBD0
		public unsafe float RainWindPowerChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_111);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_111) = value;
			}
		}

		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x06025BF3 RID: 154611 RVA: 0x009619E1 File Offset: 0x0095FBE1
		// (set) Token: 0x06025BF4 RID: 154612 RVA: 0x009619F1 File Offset: 0x0095FBF1
		public unsafe bool CanSpawnEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_112) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_112) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x06025BF5 RID: 154613 RVA: 0x00961A02 File Offset: 0x0095FC02
		// (set) Token: 0x06025BF6 RID: 154614 RVA: 0x00961A12 File Offset: 0x0095FC12
		public unsafe float FinalSnowDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_113);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_113) = value;
			}
		}

		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x06025BF7 RID: 154615 RVA: 0x00961A23 File Offset: 0x0095FC23
		// (set) Token: 0x06025BF8 RID: 154616 RVA: 0x00961A33 File Offset: 0x0095FC33
		public unsafe float FinalRainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_114);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_114) = value;
			}
		}

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x06025BF9 RID: 154617 RVA: 0x00961A44 File Offset: 0x0095FC44
		// (set) Token: 0x06025BFA RID: 154618 RVA: 0x00961A54 File Offset: 0x0095FC54
		public unsafe float FinalRainGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_115);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_115) = value;
			}
		}

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x06025BFB RID: 154619 RVA: 0x00961A65 File Offset: 0x0095FC65
		// (set) Token: 0x06025BFC RID: 154620 RVA: 0x00961A75 File Offset: 0x0095FC75
		public unsafe float DefaultSkyLightShadowSupplement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_116);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_116) = value;
			}
		}

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x06025BFD RID: 154621 RVA: 0x00961A86 File Offset: 0x0095FC86
		// (set) Token: 0x06025BFE RID: 154622 RVA: 0x00961A96 File Offset: 0x0095FC96
		public unsafe float DefaultSkyLightReflectionAddIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_117);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_117) = value;
			}
		}

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x06025BFF RID: 154623 RVA: 0x00961AA7 File Offset: 0x0095FCA7
		// (set) Token: 0x06025C00 RID: 154624 RVA: 0x00961ABB File Offset: 0x0095FCBB
		public unsafe UMaterialInstance MobileLensFlareMI_Halo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_118);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_118, value);
			}
		}

		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x06025C01 RID: 154625 RVA: 0x00961AD0 File Offset: 0x0095FCD0
		// (set) Token: 0x06025C02 RID: 154626 RVA: 0x00961AE4 File Offset: 0x0095FCE4
		public unsafe UMaterialInstanceDynamic MobileLensFlareDMI_Ghost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_119);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_119, value);
			}
		}

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x06025C03 RID: 154627 RVA: 0x00961AF9 File Offset: 0x0095FCF9
		// (set) Token: 0x06025C04 RID: 154628 RVA: 0x00961B0D File Offset: 0x0095FD0D
		public unsafe UMaterialInstanceDynamic MobileLensFlareDMI_Halo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_120);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_120, value);
			}
		}

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x06025C05 RID: 154629 RVA: 0x00961B22 File Offset: 0x0095FD22
		// (set) Token: 0x06025C06 RID: 154630 RVA: 0x00961B36 File Offset: 0x0095FD36
		public unsafe UTexture2D HeightMapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_121);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_121, value);
			}
		}

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x06025C07 RID: 154631 RVA: 0x00961B4B File Offset: 0x0095FD4B
		// (set) Token: 0x06025C08 RID: 154632 RVA: 0x00961B5B File Offset: 0x0095FD5B
		public unsafe bool HeightMapUpdated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_122) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_122) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x06025C09 RID: 154633 RVA: 0x00961B6C File Offset: 0x0095FD6C
		// (set) Token: 0x06025C0A RID: 154634 RVA: 0x00961B80 File Offset: 0x0095FD80
		public unsafe FVector SunLightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_123);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_123) = value;
			}
		}

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x06025C0B RID: 154635 RVA: 0x00961B95 File Offset: 0x0095FD95
		// (set) Token: 0x06025C0C RID: 154636 RVA: 0x00961BA5 File Offset: 0x0095FDA5
		public unsafe bool IsComponentsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_124) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_124) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x06025C0D RID: 154637 RVA: 0x00961BB6 File Offset: 0x0095FDB6
		// (set) Token: 0x06025C0E RID: 154638 RVA: 0x00961BCA File Offset: 0x0095FDCA
		public unsafe UTexture Last_LightFunction_Map
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_125);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_125, value);
			}
		}

		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x06025C0F RID: 154639 RVA: 0x00961BDF File Offset: 0x0095FDDF
		// (set) Token: 0x06025C10 RID: 154640 RVA: 0x00961BF3 File Offset: 0x0095FDF3
		public unsafe UTexture InitLightFunctionMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_126);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_126, value);
			}
		}

		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x06025C11 RID: 154641 RVA: 0x00961C08 File Offset: 0x0095FE08
		// (set) Token: 0x06025C12 RID: 154642 RVA: 0x00961C18 File Offset: 0x0095FE18
		public unsafe float TODLightLoadingWait
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_127);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_127) = value;
			}
		}

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x06025C13 RID: 154643 RVA: 0x00961C29 File Offset: 0x0095FE29
		// (set) Token: 0x06025C14 RID: 154644 RVA: 0x00961C39 File Offset: 0x0095FE39
		public unsafe float DayLightLoadingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_128);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_128) = value;
			}
		}

		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x06025C15 RID: 154645 RVA: 0x00961C4A File Offset: 0x0095FE4A
		// (set) Token: 0x06025C16 RID: 154646 RVA: 0x00961C5A File Offset: 0x0095FE5A
		public unsafe float NightLightLoadingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_129);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_129) = value;
			}
		}

		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x06025C17 RID: 154647 RVA: 0x00961C6B File Offset: 0x0095FE6B
		// (set) Token: 0x06025C18 RID: 154648 RVA: 0x00961C7B File Offset: 0x0095FE7B
		public unsafe int ComputeLightGridSkipFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_130);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_130) = value;
			}
		}

		// Token: 0x17004E97 RID: 20119
		// (get) Token: 0x06025C19 RID: 154649 RVA: 0x00961C8C File Offset: 0x0095FE8C
		// (set) Token: 0x06025C1A RID: 154650 RVA: 0x00961CA0 File Offset: 0x0095FEA0
		public unsafe UMaterialInstance MilkyWayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_131);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_131, value);
			}
		}

		// Token: 0x17004E98 RID: 20120
		// (get) Token: 0x06025C1B RID: 154651 RVA: 0x00961CB5 File Offset: 0x0095FEB5
		// (set) Token: 0x06025C1C RID: 154652 RVA: 0x00961CC5 File Offset: 0x0095FEC5
		public unsafe bool 使用主角位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_132) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_132) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E99 RID: 20121
		// (get) Token: 0x06025C1D RID: 154653 RVA: 0x00961CD6 File Offset: 0x0095FED6
		// (set) Token: 0x06025C1E RID: 154654 RVA: 0x00961CE6 File Offset: 0x0095FEE6
		public unsafe float DEBUG_角色预览方向光垂直方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_133);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_133) = value;
			}
		}

		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x06025C1F RID: 154655 RVA: 0x00961CF8 File Offset: 0x0095FEF8
		// (set) Token: 0x06025C20 RID: 154656 RVA: 0x00961D31 File Offset: 0x0095FF31
		[Nullable(1)]
		public CallCloudChange CallCloudChange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				CallCloudChange result;
				if ((result = this._CallCloudChange) == null)
				{
					result = (this._CallCloudChange = new CallCloudChange(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_134, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_134, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x06025C21 RID: 154657 RVA: 0x00961D54 File Offset: 0x0095FF54
		// (set) Token: 0x06025C22 RID: 154658 RVA: 0x00961D8D File Offset: 0x0095FF8D
		[Nullable(1)]
		public FKuroCurveFloat FogTImeControl
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogTImeControl) == null)
				{
					result = (this._FogTImeControl = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_135, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_135, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x06025C23 RID: 154659 RVA: 0x00961DAE File Offset: 0x0095FFAE
		// (set) Token: 0x06025C24 RID: 154660 RVA: 0x00961DBE File Offset: 0x0095FFBE
		public unsafe bool Is_Editor_Update
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_136) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_136) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x06025C25 RID: 154661 RVA: 0x00961DCF File Offset: 0x0095FFCF
		// (set) Token: 0x06025C26 RID: 154662 RVA: 0x00961DDF File Offset: 0x0095FFDF
		public unsafe bool EnableImposterUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_137) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_137) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E9E RID: 20126
		// (get) Token: 0x06025C27 RID: 154663 RVA: 0x00961DF0 File Offset: 0x0095FFF0
		// (set) Token: 0x06025C28 RID: 154664 RVA: 0x00961E00 File Offset: 0x00960000
		public unsafe float Clouds_Change_CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_138);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_138) = value;
			}
		}

		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x06025C29 RID: 154665 RVA: 0x00961E11 File Offset: 0x00960011
		// (set) Token: 0x06025C2A RID: 154666 RVA: 0x00961E21 File Offset: 0x00960021
		public unsafe float Clouds_Change_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_139);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_139) = value;
			}
		}

		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x06025C2B RID: 154667 RVA: 0x00961E32 File Offset: 0x00960032
		// (set) Token: 0x06025C2C RID: 154668 RVA: 0x00961E42 File Offset: 0x00960042
		public unsafe float Clouds_Change_Time_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_140);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_140) = value;
			}
		}

		// Token: 0x17004EA1 RID: 20129
		// (get) Token: 0x06025C2D RID: 154669 RVA: 0x00961E53 File Offset: 0x00960053
		// (set) Token: 0x06025C2E RID: 154670 RVA: 0x00961E63 File Offset: 0x00960063
		public unsafe bool 启用时间参数写入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_141) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_141) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA2 RID: 20130
		// (get) Token: 0x06025C2F RID: 154671 RVA: 0x00961E74 File Offset: 0x00960074
		// (set) Token: 0x06025C30 RID: 154672 RVA: 0x00961E84 File Offset: 0x00960084
		public unsafe bool UINeedLerpData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_142) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_142) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA3 RID: 20131
		// (get) Token: 0x06025C31 RID: 154673 RVA: 0x00961E95 File Offset: 0x00960095
		// (set) Token: 0x06025C32 RID: 154674 RVA: 0x00961EA5 File Offset: 0x009600A5
		public unsafe bool bEnableLumen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_143) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_143) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA4 RID: 20132
		// (get) Token: 0x06025C33 RID: 154675 RVA: 0x00961EB6 File Offset: 0x009600B6
		// (set) Token: 0x06025C34 RID: 154676 RVA: 0x00961ECA File Offset: 0x009600CA
		public unsafe UMaterialInstance LightFunctionMaterial_seq
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_144);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_144, value);
			}
		}

		// Token: 0x17004EA5 RID: 20133
		// (get) Token: 0x06025C35 RID: 154677 RVA: 0x00961EDF File Offset: 0x009600DF
		// (set) Token: 0x06025C36 RID: 154678 RVA: 0x00961EEF File Offset: 0x009600EF
		public unsafe bool Override_Cloud_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_145) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_145) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA6 RID: 20134
		// (get) Token: 0x06025C37 RID: 154679 RVA: 0x00961F00 File Offset: 0x00960100
		// (set) Token: 0x06025C38 RID: 154680 RVA: 0x00961F10 File Offset: 0x00960110
		public unsafe float Sequence_Cloud_Time_Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_146);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_146) = value;
			}
		}

		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x06025C39 RID: 154681 RVA: 0x00961F21 File Offset: 0x00960121
		// (set) Token: 0x06025C3A RID: 154682 RVA: 0x00961F31 File Offset: 0x00960131
		public unsafe float Sequence_Cloud_Time_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_147);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_147) = value;
			}
		}

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x06025C3B RID: 154683 RVA: 0x00961F42 File Offset: 0x00960142
		// (set) Token: 0x06025C3C RID: 154684 RVA: 0x00961F56 File Offset: 0x00960156
		public unsafe UMaterialInstance VolumetricLightFunctionMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_148);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_148, value);
			}
		}

		// Token: 0x17004EA9 RID: 20137
		// (get) Token: 0x06025C3D RID: 154685 RVA: 0x00961F6B File Offset: 0x0096016B
		// (set) Token: 0x06025C3E RID: 154686 RVA: 0x00961F7B File Offset: 0x0096017B
		public unsafe bool PerformanceLightExist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_149) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_149) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EAA RID: 20138
		// (get) Token: 0x06025C3F RID: 154687 RVA: 0x00961F8C File Offset: 0x0096018C
		// (set) Token: 0x06025C40 RID: 154688 RVA: 0x00961F9C File Offset: 0x0096019C
		public unsafe bool bEnableAutoExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_150) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_150) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x06025C41 RID: 154689 RVA: 0x00961FAD File Offset: 0x009601AD
		// (set) Token: 0x06025C42 RID: 154690 RVA: 0x00961FBD File Offset: 0x009601BD
		public unsafe bool PerformanceLightExist_MP4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_151) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_151) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x06025C43 RID: 154691 RVA: 0x00961FCE File Offset: 0x009601CE
		// (set) Token: 0x06025C44 RID: 154692 RVA: 0x00961FDE File Offset: 0x009601DE
		public unsafe bool BPScreenFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_152) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_152) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x06025C45 RID: 154693 RVA: 0x00961FEF File Offset: 0x009601EF
		// (set) Token: 0x06025C46 RID: 154694 RVA: 0x00962003 File Offset: 0x00960203
		public unsafe UMaterialInstance Star_Material_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_153);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_153, value);
			}
		}

		// Token: 0x17004EAE RID: 20142
		// (get) Token: 0x06025C47 RID: 154695 RVA: 0x00962018 File Offset: 0x00960218
		// (set) Token: 0x06025C48 RID: 154696 RVA: 0x0096202C File Offset: 0x0096022C
		public unsafe UKuroScreenFilterSystemData ScreenFilterAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenFilterSystemData>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_154);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_154, value);
			}
		}

		// Token: 0x17004EAF RID: 20143
		// (get) Token: 0x06025C49 RID: 154697 RVA: 0x00962044 File Offset: 0x00960244
		// (set) Token: 0x06025C4A RID: 154698 RVA: 0x0096207D File Offset: 0x0096027D
		[Nullable(1)]
		public TArray<SD_KuroTraceCloudData> Data
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SD_KuroTraceCloudData> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<SD_KuroTraceCloudData>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_155, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x17004EB0 RID: 20144
		// (get) Token: 0x06025C4B RID: 154699 RVA: 0x0096208B File Offset: 0x0096028B
		// (set) Token: 0x06025C4C RID: 154700 RVA: 0x0096209B File Offset: 0x0096029B
		public unsafe bool bCurrentPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_156) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_156) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EB1 RID: 20145
		// (get) Token: 0x06025C4D RID: 154701 RVA: 0x009620AC File Offset: 0x009602AC
		// (set) Token: 0x06025C4E RID: 154702 RVA: 0x009620BC File Offset: 0x009602BC
		public unsafe bool bSetDailyRandom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_157) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_157) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x06025C4F RID: 154703 RVA: 0x009620CD File Offset: 0x009602CD
		// (set) Token: 0x06025C50 RID: 154704 RVA: 0x009620E1 File Offset: 0x009602E1
		public unsafe UMaterialInstance FrozenMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_158);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_158, value);
			}
		}

		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x06025C51 RID: 154705 RVA: 0x009620F6 File Offset: 0x009602F6
		// (set) Token: 0x06025C52 RID: 154706 RVA: 0x0096210A File Offset: 0x0096030A
		public unsafe UMaterialInstanceDynamic FrozenDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_159);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_159, value);
			}
		}

		// Token: 0x17004EB4 RID: 20148
		// (get) Token: 0x06025C53 RID: 154707 RVA: 0x0096211F File Offset: 0x0096031F
		// (set) Token: 0x06025C54 RID: 154708 RVA: 0x0096212F File Offset: 0x0096032F
		public unsafe float TimeTotal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_160);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_160) = value;
			}
		}

		// Token: 0x17004EB5 RID: 20149
		// (get) Token: 0x06025C55 RID: 154709 RVA: 0x00962140 File Offset: 0x00960340
		// (set) Token: 0x06025C56 RID: 154710 RVA: 0x00962150 File Offset: 0x00960350
		public unsafe bool ChangeFrozen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_161) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_161) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EB6 RID: 20150
		// (get) Token: 0x06025C57 RID: 154711 RVA: 0x00962161 File Offset: 0x00960361
		// (set) Token: 0x06025C58 RID: 154712 RVA: 0x00962171 File Offset: 0x00960371
		public unsafe bool Ini
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_162) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_162) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EB7 RID: 20151
		// (get) Token: 0x06025C59 RID: 154713 RVA: 0x00962182 File Offset: 0x00960382
		// (set) Token: 0x06025C5A RID: 154714 RVA: 0x00962192 File Offset: 0x00960392
		public unsafe bool NeedDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_163) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_163) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EB8 RID: 20152
		// (get) Token: 0x06025C5B RID: 154715 RVA: 0x009621A3 File Offset: 0x009603A3
		// (set) Token: 0x06025C5C RID: 154716 RVA: 0x009621B7 File Offset: 0x009603B7
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroRainType> CurrentRainType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_164);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_164) = value;
			}
		}

		// Token: 0x17004EB9 RID: 20153
		// (get) Token: 0x06025C5D RID: 154717 RVA: 0x009621CC File Offset: 0x009603CC
		// (set) Token: 0x06025C5E RID: 154718 RVA: 0x009621E0 File Offset: 0x009603E0
		public unsafe BP_SeqControlClouds_C SeqCloudsController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SeqControlClouds_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_165);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_165, value);
			}
		}

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x06025C5F RID: 154719 RVA: 0x009621F5 File Offset: 0x009603F5
		// (set) Token: 0x06025C60 RID: 154720 RVA: 0x00962205 File Offset: 0x00960405
		public unsafe float Change_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_166);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_166) = value;
			}
		}

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x06025C61 RID: 154721 RVA: 0x00962216 File Offset: 0x00960416
		// (set) Token: 0x06025C62 RID: 154722 RVA: 0x00962226 File Offset: 0x00960426
		public unsafe bool CloudControlDoOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_167) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_167) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x06025C63 RID: 154723 RVA: 0x00962238 File Offset: 0x00960438
		// (set) Token: 0x06025C64 RID: 154724 RVA: 0x00962271 File Offset: 0x00960471
		[Nullable(1)]
		public TArray<string> CommandToolStartArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CommandToolStartArray) == null)
				{
					result = (this._CommandToolStartArray = new TArray<string>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_168, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CommandToolStartArray.CopyAssign(value);
			}
		}

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x06025C65 RID: 154725 RVA: 0x00962280 File Offset: 0x00960480
		// (set) Token: 0x06025C66 RID: 154726 RVA: 0x009622B9 File Offset: 0x009604B9
		[Nullable(1)]
		public TArray<string> CommandToolEndArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CommandToolEndArray) == null)
				{
					result = (this._CommandToolEndArray = new TArray<string>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_169, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CommandToolEndArray.CopyAssign(value);
			}
		}

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x06025C67 RID: 154727 RVA: 0x009622C8 File Offset: 0x009604C8
		// (set) Token: 0x06025C68 RID: 154728 RVA: 0x00962301 File Offset: 0x00960501
		[Nullable(1)]
		public TArray<float> CommandToolOriginalValueArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CommandToolOriginalValueArray) == null)
				{
					result = (this._CommandToolOriginalValueArray = new TArray<float>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_170, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CommandToolOriginalValueArray.CopyAssign(value);
			}
		}

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x06025C69 RID: 154729 RVA: 0x0096230F File Offset: 0x0096050F
		// (set) Token: 0x06025C6A RID: 154730 RVA: 0x0096231F File Offset: 0x0096051F
		public unsafe bool NeedResetActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_171) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_171) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EC0 RID: 20160
		// (get) Token: 0x06025C6B RID: 154731 RVA: 0x00962330 File Offset: 0x00960530
		// (set) Token: 0x06025C6C RID: 154732 RVA: 0x00962340 File Offset: 0x00960540
		public unsafe bool NeedRunEndCommand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_172) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_172) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x06025C6D RID: 154733 RVA: 0x00962351 File Offset: 0x00960551
		// (set) Token: 0x06025C6E RID: 154734 RVA: 0x00962361 File Offset: 0x00960561
		public unsafe float CloudsCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_173);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_173) = value;
			}
		}

		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x06025C6F RID: 154735 RVA: 0x00962372 File Offset: 0x00960572
		// (set) Token: 0x06025C70 RID: 154736 RVA: 0x00962382 File Offset: 0x00960582
		public unsafe int UpdateSkylightBlendNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_174);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_174) = value;
			}
		}

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x06025C71 RID: 154737 RVA: 0x00962393 File Offset: 0x00960593
		// (set) Token: 0x06025C72 RID: 154738 RVA: 0x009623A3 File Offset: 0x009605A3
		public unsafe bool EnableSetSkyBlendingSkipCVar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_175) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_175) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x06025C73 RID: 154739 RVA: 0x009623B4 File Offset: 0x009605B4
		// (set) Token: 0x06025C74 RID: 154740 RVA: 0x009623C4 File Offset: 0x009605C4
		public unsafe bool DoOnceSetSkyBlendingSkipCVar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_176) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_176) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EC5 RID: 20165
		// (get) Token: 0x06025C75 RID: 154741 RVA: 0x009623D5 File Offset: 0x009605D5
		// (set) Token: 0x06025C76 RID: 154742 RVA: 0x009623E5 File Offset: 0x009605E5
		public unsafe bool bEnableUpdateTimeTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_177) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_177) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025C77 RID: 154743 RVA: 0x009623F6 File Offset: 0x009605F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UodateSkylightBlendTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UodateSkylightBlendTick_NativeFunctionPtr, null);
		}

		// Token: 0x06025C78 RID: 154744 RVA: 0x0096240A File Offset: 0x0096060A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateVolumeCloudGodRay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateVolumeCloudGodRay_NativeFunctionPtr, null);
		}

		// Token: 0x06025C79 RID: 154745 RVA: 0x0096241E File Offset: 0x0096061E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnGlobalGITick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnGlobalGITick_NativeFunctionPtr, null);
		}

		// Token: 0x06025C7A RID: 154746 RVA: 0x00962432 File Offset: 0x00960632
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMeshBlend()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateMeshBlend_NativeFunctionPtr, null);
		}

		// Token: 0x06025C7B RID: 154747 RVA: 0x00962446 File Offset: 0x00960646
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ToggleShowDynamicSkyPlatform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__ToggleShowDynamicSkyPlatform_NativeFunctionPtr, null);
		}

		// Token: 0x06025C7C RID: 154748 RVA: 0x0096245A File Offset: 0x0096065A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpadteVolumertricCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpadteVolumertricCloud_NativeFunctionPtr, null);
		}

		// Token: 0x06025C7D RID: 154749 RVA: 0x0096246E File Offset: 0x0096066E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCharacterRootPos()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateCharacterRootPos_NativeFunctionPtr, null);
		}

		// Token: 0x06025C7E RID: 154750 RVA: 0x00962482 File Offset: 0x00960682
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_GIControlParamToGlobalShaderParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Set_GIControlParamToGlobalShaderParam_NativeFunctionPtr, null);
		}

		// Token: 0x06025C7F RID: 154751 RVA: 0x00962496 File Offset: 0x00960696
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateOriginSkyAtmosphere()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateOriginSkyAtmosphere_NativeFunctionPtr, null);
		}

		// Token: 0x06025C80 RID: 154752 RVA: 0x009624AA File Offset: 0x009606AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateVolumeCloudLightWeight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateVolumeCloudLightWeight_NativeFunctionPtr, null);
		}

		// Token: 0x06025C81 RID: 154753 RVA: 0x009624BE File Offset: 0x009606BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void IsPerformanceLightExist()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__IsPerformanceLightExist_NativeFunctionPtr, null);
		}

		// Token: 0x06025C82 RID: 154754 RVA: 0x009624D2 File Offset: 0x009606D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateOcean()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateOcean_NativeFunctionPtr, null);
		}

		// Token: 0x06025C83 RID: 154755 RVA: 0x009624E6 File Offset: 0x009606E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFrozen()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateFrozen_NativeFunctionPtr, null);
		}

		// Token: 0x06025C84 RID: 154756 RVA: 0x009624FA File Offset: 0x009606FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateEditor_NativeFunctionPtr, null);
		}

		// Token: 0x06025C85 RID: 154757 RVA: 0x0096250E File Offset: 0x0096070E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateBigWorld()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateBigWorld_NativeFunctionPtr, null);
		}

		// Token: 0x06025C86 RID: 154758 RVA: 0x00962524 File Offset: 0x00960724
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateMilkWay(ref UMaterialInstanceDynamic MilkyWay_DMI, ref FKuroMilkyWaySetting CloudCardSetting)
		{
			BP_GlobalGI_C.__UpdateMilkWay_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__UpdateMilkWay_FunctionParams[(UIntPtr)343] + 15L / (long)sizeof(BP_GlobalGI_C.__UpdateMilkWay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__UpdateMilkWay_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_C.__UpdateMilkWay_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = MilkyWay_DMI;
			ptr2.MilkyWay_DMI = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMilkyWaySetting.StaticStruct(), &ptr->CloudCardSetting, CloudCardSetting.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateMilkWay_NativeFunctionPtr, (void*)ptr);
			MilkyWay_DMI = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->MilkyWay_DMI);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMilkyWaySetting.StaticStruct(), CloudCardSetting.NativePtr, &ptr->CloudCardSetting, 1, false);
			}
		}

		// Token: 0x06025C87 RID: 154759 RVA: 0x009625D4 File Offset: 0x009607D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMilkyWayDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetMilkyWayDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetMilkyWayDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x06025C88 RID: 154760 RVA: 0x00962638 File Offset: 0x00960838
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void updateLightFunctions()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__updateLightFunctions_NativeFunctionPtr, null);
		}

		// Token: 0x06025C89 RID: 154761 RVA: 0x0096264C File Offset: 0x0096084C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetParallaxCorrectCachedCrossFadeShadowDirection(ref FRotator NewParam)
		{
			BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025C8A RID: 154762 RVA: 0x009626A4 File Offset: 0x009608A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetTODCharacterLighting(FLinearColor mainLight, float mainLightIntensity, FLinearColor skyLight, float skyLightIntensity, ref FLinearColor FrontSideLight, ref FLinearColor BackSideLight)
		{
			BP_GlobalGI_C.__GetTODCharacterLighting_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetTODCharacterLighting_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_GlobalGI_C.__GetTODCharacterLighting_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mainLight = mainLight;
			ptr->mainLightIntensity = mainLightIntensity;
			ptr->skyLight = skyLight;
			ptr->skyLightIntensity = skyLightIntensity;
			ptr->FrontSideLight = FrontSideLight;
			ptr->BackSideLight = BackSideLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr);
			FrontSideLight = ptr->FrontSideLight;
			BackSideLight = ptr->BackSideLight;
		}

		// Token: 0x06025C8B RID: 154763 RVA: 0x00962738 File Offset: 0x00960938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetParallaxCorrectCachedShadowDirection(ref FRotator NewParam)
		{
			BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025C8C RID: 154764 RVA: 0x00962790 File Offset: 0x00960990
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLevelSequenceCloudControl(BP_SeqControlClouds_C SeqCloudsController)
		{
			BP_GlobalGI_C.__SetLevelSequenceCloudControl_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__SetLevelSequenceCloudControl_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GlobalGI_C.__SetLevelSequenceCloudControl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__SetLevelSequenceCloudControl_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SeqCloudsController = ((SeqCloudsController != null) ? SeqCloudsController.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__SetLevelSequenceCloudControl_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025C8D RID: 154765 RVA: 0x009627E8 File Offset: 0x009609E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FLinearColor Clamp_Luminance(FLinearColor InColor, float Min, float Max)
		{
			BP_GlobalGI_C.__Clamp_Luminance_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Clamp_Luminance_FunctionParams[(UIntPtr)123] + 15L / (long)sizeof(BP_GlobalGI_C.__Clamp_Luminance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InColor = InColor;
			ptr->Min = Min;
			ptr->Max = Max;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025C8E RID: 154766 RVA: 0x00962844 File Offset: 0x00960A44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_GlobalGI_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__EulerToForward_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GlobalGI_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025C8F RID: 154767 RVA: 0x00962897 File Offset: 0x00960A97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Dynamic_Clouds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Dynamic_Clouds_NativeFunctionPtr, null);
		}

		// Token: 0x06025C90 RID: 154768 RVA: 0x009628AC File Offset: 0x00960AAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLevelSequenceTimeControl(BP_ControlTodTime_C TodTimeControl)
		{
			BP_GlobalGI_C.__SetLevelSequenceTimeControl_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__SetLevelSequenceTimeControl_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GlobalGI_C.__SetLevelSequenceTimeControl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__SetLevelSequenceTimeControl_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TodTimeControl = ((TodTimeControl != null) ? TodTimeControl.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__SetLevelSequenceTimeControl_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025C91 RID: 154769 RVA: 0x00962904 File Offset: 0x00960B04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetStarsDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_C.__GetStarsDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetStarsDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetStarsDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetStarsDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_C.__GetStarsDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetStarsDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x06025C92 RID: 154770 RVA: 0x00962968 File Offset: 0x00960B68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateClusteredStuff()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateClusteredStuff_NativeFunctionPtr, null);
		}

		// Token: 0x06025C93 RID: 154771 RVA: 0x0096297C File Offset: 0x00960B7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSkyboxDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x06025C94 RID: 154772 RVA: 0x009629E0 File Offset: 0x00960BE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSkybox()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateSkybox_NativeFunctionPtr, null);
		}

		// Token: 0x06025C95 RID: 154773 RVA: 0x009629F4 File Offset: 0x00960BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Misc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Misc_NativeFunctionPtr, null);
		}

		// Token: 0x06025C96 RID: 154774 RVA: 0x00962A08 File Offset: 0x00960C08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFlowmapSkybox()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateFlowmapSkybox_NativeFunctionPtr, null);
		}

		// Token: 0x06025C97 RID: 154775 RVA: 0x00962A1C File Offset: 0x00960C1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 申时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__申时_NativeFunctionPtr, null);
		}

		// Token: 0x06025C98 RID: 154776 RVA: 0x00962A30 File Offset: 0x00960C30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 下午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__下午_NativeFunctionPtr, null);
		}

		// Token: 0x06025C99 RID: 154777 RVA: 0x00962A44 File Offset: 0x00960C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 上午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__上午_NativeFunctionPtr, null);
		}

		// Token: 0x06025C9A RID: 154778 RVA: 0x00962A58 File Offset: 0x00960C58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 辰时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__辰时_NativeFunctionPtr, null);
		}

		// Token: 0x06025C9B RID: 154779 RVA: 0x00962A6C File Offset: 0x00960C6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Day_Night_Data_Layer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Day_Night_Data_Layer_NativeFunctionPtr, null);
		}

		// Token: 0x06025C9C RID: 154780 RVA: 0x00962A80 File Offset: 0x00960C80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCloudCard(ref FKuroCloudCardSetting CloudCardSetting)
		{
			BP_GlobalGI_C.__UpdateCloudCard_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__UpdateCloudCard_FunctionParams[(UIntPtr)179] + 15L / (long)sizeof(BP_GlobalGI_C.__UpdateCloudCard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__UpdateCloudCard_NativeFunctionPtr, (void*)ptr, 1);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCloudCardSetting.StaticStruct(), &ptr->CloudCardSetting, CloudCardSetting.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateCloudCard_NativeFunctionPtr, (void*)ptr);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCloudCardSetting.StaticStruct(), CloudCardSetting.NativePtr, &ptr->CloudCardSetting, 1, false);
			}
		}

		// Token: 0x06025C9D RID: 154781 RVA: 0x00962B0A File Offset: 0x00960D0A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06025C9E RID: 154782 RVA: 0x00962B1E File Offset: 0x00960D1E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 夜晚到清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__夜晚到清晨_NativeFunctionPtr, null);
		}

		// Token: 0x06025C9F RID: 154783 RVA: 0x00962B32 File Offset: 0x00960D32
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 黄昏到夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__黄昏到夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA0 RID: 154784 RVA: 0x00962B46 File Offset: 0x00960D46
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 黄昏()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__黄昏_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA1 RID: 154785 RVA: 0x00962B5A File Offset: 0x00960D5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 中午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__中午_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA2 RID: 154786 RVA: 0x00962B6E File Offset: 0x00960D6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__清晨_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA3 RID: 154787 RVA: 0x00962B82 File Offset: 0x00960D82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSkyDome()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateSkyDome_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA4 RID: 154788 RVA: 0x00962B96 File Offset: 0x00960D96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitGI_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA5 RID: 154789 RVA: 0x00962BAC File Offset: 0x00960DAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_All_Components_States(bool IsEnable)
		{
			BP_GlobalGI_C.__Set_All_Components_States_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Set_All_Components_States_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_GlobalGI_C.__Set_All_Components_States_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEnable = IsEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025CA6 RID: 154790 RVA: 0x00962BF2 File Offset: 0x00960DF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLightShaft()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateLightShaft_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA7 RID: 154791 RVA: 0x00962C08 File Offset: 0x00960E08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetLightDirectionFromVH(float Vertical, float Horizontal, ref FRotator Result)
		{
			BP_GlobalGI_C.__GetLightDirectionFromVH_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetLightDirectionFromVH_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetLightDirectionFromVH_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06025CA8 RID: 154792 RVA: 0x00962C6D File Offset: 0x00960E6D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePostProcessVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdatePostProcessVolume_NativeFunctionPtr, null);
		}

		// Token: 0x06025CA9 RID: 154793 RVA: 0x00962C81 File Offset: 0x00960E81
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLightParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateLightParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06025CAA RID: 154794 RVA: 0x00962C95 File Offset: 0x00960E95
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Light_Direction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Light_Direction_NativeFunctionPtr, null);
		}

		// Token: 0x06025CAB RID: 154795 RVA: 0x00962CA9 File Offset: 0x00960EA9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Main_Light()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Main_Light_NativeFunctionPtr, null);
		}

		// Token: 0x06025CAC RID: 154796 RVA: 0x00962CBD File Offset: 0x00960EBD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_UI_Env()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_UI_Env_NativeFunctionPtr, null);
		}

		// Token: 0x06025CAD RID: 154797 RVA: 0x00962CD1 File Offset: 0x00960ED1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateTime_NativeFunctionPtr, null);
		}

		// Token: 0x06025CAE RID: 154798 RVA: 0x00962CE8 File Offset: 0x00960EE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateTimeOnce(float OverrideTime)
		{
			BP_GlobalGI_C.__UpdateTimeOnce_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__UpdateTimeOnce_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GlobalGI_C.__UpdateTimeOnce_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__UpdateTimeOnce_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverrideTime = OverrideTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateTimeOnce_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025CAF RID: 154799 RVA: 0x00962D30 File Offset: 0x00960F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetViewLocation(ref FVector WorldPosition, ref bool Suc)
		{
			BP_GlobalGI_C.__GetViewLocation_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetViewLocation_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GlobalGI_C.__GetViewLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldPosition = WorldPosition;
			ptr->Suc = Suc;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr);
			WorldPosition = ptr->WorldPosition;
			Suc = ptr->Suc;
		}

		// Token: 0x06025CB0 RID: 154800 RVA: 0x00962D97 File Offset: 0x00960F97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitFeature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitFeature_NativeFunctionPtr, null);
		}

		// Token: 0x06025CB1 RID: 154801 RVA: 0x00962DAC File Offset: 0x00960FAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateLightDirectionWithLimit(float V, float H, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_C.__CalculateLightDirectionWithLimit_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__CalculateLightDirectionWithLimit_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_GlobalGI_C.__CalculateLightDirectionWithLimit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__CalculateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V = V;
			ptr->H = H;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__CalculateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025CB2 RID: 154802 RVA: 0x00962E20 File Offset: 0x00961020
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateLightDirection(float Vertical, float Horizontal, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_C.__CalculateLightDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__CalculateLightDirection_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_GlobalGI_C.__CalculateLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025CB3 RID: 154803 RVA: 0x00962E8E File Offset: 0x0096108E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateAtmosphere()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateAtmosphere_NativeFunctionPtr, null);
		}

		// Token: 0x06025CB4 RID: 154804 RVA: 0x00962EA2 File Offset: 0x009610A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSkyLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateSkyLight_NativeFunctionPtr, null);
		}

		// Token: 0x06025CB5 RID: 154805 RVA: 0x00962EB8 File Offset: 0x009610B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Scene_Light_Direction(ref FVector LightDir)
		{
			BP_GlobalGI_C.__Get_Scene_Light_Direction_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Get_Scene_Light_Direction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_C.__Get_Scene_Light_Direction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LightDir = LightDir;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr);
			LightDir = ptr->LightDir;
		}

		// Token: 0x06025CB6 RID: 154806 RVA: 0x00962F0F File Offset: 0x0096110F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitGICompoemnt()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitGICompoemnt_NativeFunctionPtr, null);
		}

		// Token: 0x06025CB7 RID: 154807 RVA: 0x00962F23 File Offset: 0x00961123
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMaterials()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitMaterials_NativeFunctionPtr, null);
		}

		// Token: 0x06025CB8 RID: 154808 RVA: 0x00962F37 File Offset: 0x00961137
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWind()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateWind_NativeFunctionPtr, null);
		}

		// Token: 0x06025CB9 RID: 154809 RVA: 0x00962F4C File Offset: 0x0096114C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get2SkyboxLerpWeight(float startSetting, float EndSetting, float CurrentTime, ref float Weight)
		{
			BP_GlobalGI_C.__Get2SkyboxLerpWeight_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Get2SkyboxLerpWeight_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_GlobalGI_C.__Get2SkyboxLerpWeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Get2SkyboxLerpWeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->startSetting = startSetting;
			ptr->EndSetting = EndSetting;
			ptr->CurrentTime = CurrentTime;
			ptr->Weight = Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Get2SkyboxLerpWeight_NativeFunctionPtr, (void*)ptr);
			Weight = ptr->Weight;
		}

		// Token: 0x06025CBA RID: 154810 RVA: 0x00962FB2 File Offset: 0x009611B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Env()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Env_NativeFunctionPtr, null);
		}

		// Token: 0x06025CBB RID: 154811 RVA: 0x00962FC6 File Offset: 0x009611C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFog()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateFog_NativeFunctionPtr, null);
		}

		// Token: 0x06025CBC RID: 154812 RVA: 0x00962FDC File Offset: 0x009611DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateGIData(bool Skip_Lerp_Data)
		{
			BP_GlobalGI_C.__UpdateGIData_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__UpdateGIData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__UpdateGIData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__UpdateGIData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Skip_Lerp_Data = Skip_Lerp_Data;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateGIData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025CBD RID: 154813 RVA: 0x00963022 File Offset: 0x00961222
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCharacterGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateCharacterGI_NativeFunctionPtr, null);
		}

		// Token: 0x06025CBE RID: 154814 RVA: 0x00963036 File Offset: 0x00961236
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025CBF RID: 154815 RVA: 0x0096304A File Offset: 0x0096124A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025CC0 RID: 154816 RVA: 0x00963060 File Offset: 0x00961260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroTickEditor(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025CC1 RID: 154817 RVA: 0x009630A8 File Offset: 0x009612A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroTickEditor_Implementation(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025CC2 RID: 154818 RVA: 0x009630F0 File Offset: 0x009612F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroTick(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025CC3 RID: 154819 RVA: 0x00963138 File Offset: 0x00961338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroTick_Implementation(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025CC4 RID: 154820 RVA: 0x0096317F File Offset: 0x0096137F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnKuroInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroInit_NativeFunctionPtr, null);
		}

		// Token: 0x06025CC5 RID: 154821 RVA: 0x00963193 File Offset: 0x00961393
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnKuroInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025CC6 RID: 154822 RVA: 0x009631A8 File Offset: 0x009613A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025CC7 RID: 154823 RVA: 0x009631BC File Offset: 0x009613BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025CC8 RID: 154824 RVA: 0x009631D1 File Offset: 0x009613D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnKuroRuntimeDestroy()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroRuntimeDestroy_NativeFunctionPtr, null);
		}

		// Token: 0x06025CC9 RID: 154825 RVA: 0x009631E5 File Offset: 0x009613E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnKuroRuntimeDestroy_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroRuntimeDestroy_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025CCA RID: 154826 RVA: 0x009631FC File Offset: 0x009613FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroSetRuntimeTime(float CurrentTime)
		{
			BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025CCB RID: 154827 RVA: 0x00963244 File Offset: 0x00961444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroSetRuntimeTime_Implementation(float CurrentTime)
		{
			BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025CCC RID: 154828 RVA: 0x0096328C File Offset: 0x0096148C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroStartUiScene(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025CCD RID: 154829 RVA: 0x00963300 File Offset: 0x00961500
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroStartUiScene_Implementation(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025CCE RID: 154830 RVA: 0x00963374 File Offset: 0x00961574
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnKuroEndUiScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroEndUiScene_NativeFunctionPtr, null);
		}

		// Token: 0x06025CCF RID: 154831 RVA: 0x00963388 File Offset: 0x00961588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnKuroEndUiScene_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroEndUiScene_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025CD0 RID: 154832 RVA: 0x0096339D File Offset: 0x0096159D
		protected BP_GlobalGI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D44 RID: 77124
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C";

		// Token: 0x04012D45 RID: 77125
		private static IntPtr _ClassPtr;

		// Token: 0x04012D46 RID: 77126
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012D47 RID: 77127
		public static IntPtr __CallCloudChange__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012D48 RID: 77128
		internal static int __PropertyOffset_1;

		// Token: 0x04012D49 RID: 77129
		internal static int __PropertyOffset_2;

		// Token: 0x04012D4A RID: 77130
		internal static int __PropertyOffset_3;

		// Token: 0x04012D4B RID: 77131
		internal static int __PropertyOffset_4;

		// Token: 0x04012D4C RID: 77132
		internal static int __PropertyOffset_5;

		// Token: 0x04012D4D RID: 77133
		internal static int __PropertyOffset_6;

		// Token: 0x04012D4E RID: 77134
		internal static int __PropertyOffset_7;

		// Token: 0x04012D4F RID: 77135
		internal static int __PropertyOffset_8;

		// Token: 0x04012D50 RID: 77136
		internal static int __PropertyOffset_9;

		// Token: 0x04012D51 RID: 77137
		internal static int __PropertyOffset_10;

		// Token: 0x04012D52 RID: 77138
		internal static int __PropertyOffset_11;

		// Token: 0x04012D53 RID: 77139
		internal static int __PropertyOffset_12;

		// Token: 0x04012D54 RID: 77140
		internal static int __PropertyOffset_13;

		// Token: 0x04012D55 RID: 77141
		internal static int __PropertyOffset_14;

		// Token: 0x04012D56 RID: 77142
		internal static int __PropertyOffset_15;

		// Token: 0x04012D57 RID: 77143
		internal static int __PropertyOffset_16;

		// Token: 0x04012D58 RID: 77144
		internal static int __PropertyOffset_17;

		// Token: 0x04012D59 RID: 77145
		internal static int __PropertyOffset_18;

		// Token: 0x04012D5A RID: 77146
		internal static int __PropertyOffset_19;

		// Token: 0x04012D5B RID: 77147
		internal static int __PropertyOffset_20;

		// Token: 0x04012D5C RID: 77148
		internal static int __PropertyOffset_21;

		// Token: 0x04012D5D RID: 77149
		internal static int __PropertyOffset_22;

		// Token: 0x04012D5E RID: 77150
		internal static int __PropertyOffset_23;

		// Token: 0x04012D5F RID: 77151
		internal static int __PropertyOffset_24;

		// Token: 0x04012D60 RID: 77152
		internal static int __PropertyOffset_25;

		// Token: 0x04012D61 RID: 77153
		internal static int __PropertyOffset_26;

		// Token: 0x04012D62 RID: 77154
		internal static int __PropertyOffset_27;

		// Token: 0x04012D63 RID: 77155
		internal static int __PropertyOffset_28;

		// Token: 0x04012D64 RID: 77156
		internal static int __PropertyOffset_29;

		// Token: 0x04012D65 RID: 77157
		internal static int __PropertyOffset_30;

		// Token: 0x04012D66 RID: 77158
		internal static int __PropertyOffset_31;

		// Token: 0x04012D67 RID: 77159
		internal static int __PropertyOffset_32;

		// Token: 0x04012D68 RID: 77160
		internal static int __PropertyOffset_33;

		// Token: 0x04012D69 RID: 77161
		internal static int __PropertyOffset_34;

		// Token: 0x04012D6A RID: 77162
		internal static int __PropertyOffset_35;

		// Token: 0x04012D6B RID: 77163
		internal static int __PropertyOffset_36;

		// Token: 0x04012D6C RID: 77164
		internal static int __PropertyOffset_37;

		// Token: 0x04012D6D RID: 77165
		internal static int __PropertyOffset_38;

		// Token: 0x04012D6E RID: 77166
		internal static int __PropertyOffset_39;

		// Token: 0x04012D6F RID: 77167
		internal static int __PropertyOffset_40;

		// Token: 0x04012D70 RID: 77168
		internal static int __PropertyOffset_41;

		// Token: 0x04012D71 RID: 77169
		internal static int __PropertyOffset_42;

		// Token: 0x04012D72 RID: 77170
		internal static int __PropertyOffset_43;

		// Token: 0x04012D73 RID: 77171
		internal static int __PropertyOffset_44;

		// Token: 0x04012D74 RID: 77172
		private TArray<FVector2D> _SunLightExistTime;

		// Token: 0x04012D75 RID: 77173
		internal static int __PropertyOffset_45;

		// Token: 0x04012D76 RID: 77174
		private TArray<FVector2D> _MoonLightExistTime;

		// Token: 0x04012D77 RID: 77175
		internal static int __PropertyOffset_46;

		// Token: 0x04012D78 RID: 77176
		internal static int __PropertyOffset_47;

		// Token: 0x04012D79 RID: 77177
		internal static int __PropertyOffset_48;

		// Token: 0x04012D7A RID: 77178
		internal static int __PropertyOffset_49;

		// Token: 0x04012D7B RID: 77179
		internal static int __PropertyOffset_50;

		// Token: 0x04012D7C RID: 77180
		internal static int __PropertyOffset_51;

		// Token: 0x04012D7D RID: 77181
		internal static int __PropertyOffset_52;

		// Token: 0x04012D7E RID: 77182
		internal static int __PropertyOffset_53;

		// Token: 0x04012D7F RID: 77183
		internal static int __PropertyOffset_54;

		// Token: 0x04012D80 RID: 77184
		internal static int __PropertyOffset_55;

		// Token: 0x04012D81 RID: 77185
		internal static int __PropertyOffset_56;

		// Token: 0x04012D82 RID: 77186
		internal static int __PropertyOffset_57;

		// Token: 0x04012D83 RID: 77187
		internal static int __PropertyOffset_58;

		// Token: 0x04012D84 RID: 77188
		internal static int __PropertyOffset_59;

		// Token: 0x04012D85 RID: 77189
		internal static int __PropertyOffset_60;

		// Token: 0x04012D86 RID: 77190
		internal static int __PropertyOffset_61;

		// Token: 0x04012D87 RID: 77191
		internal static int __PropertyOffset_62;

		// Token: 0x04012D88 RID: 77192
		internal static int __PropertyOffset_63;

		// Token: 0x04012D89 RID: 77193
		internal static int __PropertyOffset_64;

		// Token: 0x04012D8A RID: 77194
		internal static int __PropertyOffset_65;

		// Token: 0x04012D8B RID: 77195
		internal static int __PropertyOffset_66;

		// Token: 0x04012D8C RID: 77196
		internal static int __PropertyOffset_67;

		// Token: 0x04012D8D RID: 77197
		internal static int __PropertyOffset_68;

		// Token: 0x04012D8E RID: 77198
		internal static int __PropertyOffset_69;

		// Token: 0x04012D8F RID: 77199
		internal static int __PropertyOffset_70;

		// Token: 0x04012D90 RID: 77200
		internal static int __PropertyOffset_71;

		// Token: 0x04012D91 RID: 77201
		internal static int __PropertyOffset_72;

		// Token: 0x04012D92 RID: 77202
		internal static int __PropertyOffset_73;

		// Token: 0x04012D93 RID: 77203
		internal static int __PropertyOffset_74;

		// Token: 0x04012D94 RID: 77204
		internal static int __PropertyOffset_75;

		// Token: 0x04012D95 RID: 77205
		internal static int __PropertyOffset_76;

		// Token: 0x04012D96 RID: 77206
		internal static int __PropertyOffset_77;

		// Token: 0x04012D97 RID: 77207
		internal static int __PropertyOffset_78;

		// Token: 0x04012D98 RID: 77208
		internal static int __PropertyOffset_79;

		// Token: 0x04012D99 RID: 77209
		internal static int __PropertyOffset_80;

		// Token: 0x04012D9A RID: 77210
		internal static int __PropertyOffset_81;

		// Token: 0x04012D9B RID: 77211
		internal static int __PropertyOffset_82;

		// Token: 0x04012D9C RID: 77212
		internal static int __PropertyOffset_83;

		// Token: 0x04012D9D RID: 77213
		internal static int __PropertyOffset_84;

		// Token: 0x04012D9E RID: 77214
		internal static int __PropertyOffset_85;

		// Token: 0x04012D9F RID: 77215
		internal static int __PropertyOffset_86;

		// Token: 0x04012DA0 RID: 77216
		internal static int __PropertyOffset_87;

		// Token: 0x04012DA1 RID: 77217
		internal static int __PropertyOffset_88;

		// Token: 0x04012DA2 RID: 77218
		internal static int __PropertyOffset_89;

		// Token: 0x04012DA3 RID: 77219
		internal static int __PropertyOffset_90;

		// Token: 0x04012DA4 RID: 77220
		internal static int __PropertyOffset_91;

		// Token: 0x04012DA5 RID: 77221
		internal static int __PropertyOffset_92;

		// Token: 0x04012DA6 RID: 77222
		internal static int __PropertyOffset_93;

		// Token: 0x04012DA7 RID: 77223
		internal static int __PropertyOffset_94;

		// Token: 0x04012DA8 RID: 77224
		internal static int __PropertyOffset_95;

		// Token: 0x04012DA9 RID: 77225
		internal static int __PropertyOffset_96;

		// Token: 0x04012DAA RID: 77226
		internal static int __PropertyOffset_97;

		// Token: 0x04012DAB RID: 77227
		internal static int __PropertyOffset_98;

		// Token: 0x04012DAC RID: 77228
		internal static int __PropertyOffset_99;

		// Token: 0x04012DAD RID: 77229
		internal static int __PropertyOffset_100;

		// Token: 0x04012DAE RID: 77230
		internal static int __PropertyOffset_101;

		// Token: 0x04012DAF RID: 77231
		internal static int __PropertyOffset_102;

		// Token: 0x04012DB0 RID: 77232
		internal static int __PropertyOffset_103;

		// Token: 0x04012DB1 RID: 77233
		internal static int __PropertyOffset_104;

		// Token: 0x04012DB2 RID: 77234
		internal static int __PropertyOffset_105;

		// Token: 0x04012DB3 RID: 77235
		internal static int __PropertyOffset_106;

		// Token: 0x04012DB4 RID: 77236
		internal static int __PropertyOffset_107;

		// Token: 0x04012DB5 RID: 77237
		internal static int __PropertyOffset_108;

		// Token: 0x04012DB6 RID: 77238
		internal static int __PropertyOffset_109;

		// Token: 0x04012DB7 RID: 77239
		internal static int __PropertyOffset_110;

		// Token: 0x04012DB8 RID: 77240
		internal static int __PropertyOffset_111;

		// Token: 0x04012DB9 RID: 77241
		internal static int __PropertyOffset_112;

		// Token: 0x04012DBA RID: 77242
		internal static int __PropertyOffset_113;

		// Token: 0x04012DBB RID: 77243
		internal static int __PropertyOffset_114;

		// Token: 0x04012DBC RID: 77244
		internal static int __PropertyOffset_115;

		// Token: 0x04012DBD RID: 77245
		internal static int __PropertyOffset_116;

		// Token: 0x04012DBE RID: 77246
		internal static int __PropertyOffset_117;

		// Token: 0x04012DBF RID: 77247
		internal static int __PropertyOffset_118;

		// Token: 0x04012DC0 RID: 77248
		internal static int __PropertyOffset_119;

		// Token: 0x04012DC1 RID: 77249
		internal static int __PropertyOffset_120;

		// Token: 0x04012DC2 RID: 77250
		internal static int __PropertyOffset_121;

		// Token: 0x04012DC3 RID: 77251
		internal static int __PropertyOffset_122;

		// Token: 0x04012DC4 RID: 77252
		internal static int __PropertyOffset_123;

		// Token: 0x04012DC5 RID: 77253
		internal static int __PropertyOffset_124;

		// Token: 0x04012DC6 RID: 77254
		internal static int __PropertyOffset_125;

		// Token: 0x04012DC7 RID: 77255
		internal static int __PropertyOffset_126;

		// Token: 0x04012DC8 RID: 77256
		internal static int __PropertyOffset_127;

		// Token: 0x04012DC9 RID: 77257
		internal static int __PropertyOffset_128;

		// Token: 0x04012DCA RID: 77258
		internal static int __PropertyOffset_129;

		// Token: 0x04012DCB RID: 77259
		internal static int __PropertyOffset_130;

		// Token: 0x04012DCC RID: 77260
		internal static int __PropertyOffset_131;

		// Token: 0x04012DCD RID: 77261
		internal static int __PropertyOffset_132;

		// Token: 0x04012DCE RID: 77262
		internal static int __PropertyOffset_133;

		// Token: 0x04012DCF RID: 77263
		internal static int __PropertyOffset_134;

		// Token: 0x04012DD0 RID: 77264
		private CallCloudChange _CallCloudChange;

		// Token: 0x04012DD1 RID: 77265
		internal static int __PropertyOffset_135;

		// Token: 0x04012DD2 RID: 77266
		private FKuroCurveFloat _FogTImeControl;

		// Token: 0x04012DD3 RID: 77267
		internal static int __PropertyOffset_136;

		// Token: 0x04012DD4 RID: 77268
		internal static int __PropertyOffset_137;

		// Token: 0x04012DD5 RID: 77269
		internal static int __PropertyOffset_138;

		// Token: 0x04012DD6 RID: 77270
		internal static int __PropertyOffset_139;

		// Token: 0x04012DD7 RID: 77271
		internal static int __PropertyOffset_140;

		// Token: 0x04012DD8 RID: 77272
		internal static int __PropertyOffset_141;

		// Token: 0x04012DD9 RID: 77273
		internal static int __PropertyOffset_142;

		// Token: 0x04012DDA RID: 77274
		internal static int __PropertyOffset_143;

		// Token: 0x04012DDB RID: 77275
		internal static int __PropertyOffset_144;

		// Token: 0x04012DDC RID: 77276
		internal static int __PropertyOffset_145;

		// Token: 0x04012DDD RID: 77277
		internal static int __PropertyOffset_146;

		// Token: 0x04012DDE RID: 77278
		internal static int __PropertyOffset_147;

		// Token: 0x04012DDF RID: 77279
		internal static int __PropertyOffset_148;

		// Token: 0x04012DE0 RID: 77280
		internal static int __PropertyOffset_149;

		// Token: 0x04012DE1 RID: 77281
		internal static int __PropertyOffset_150;

		// Token: 0x04012DE2 RID: 77282
		internal static int __PropertyOffset_151;

		// Token: 0x04012DE3 RID: 77283
		internal static int __PropertyOffset_152;

		// Token: 0x04012DE4 RID: 77284
		internal static int __PropertyOffset_153;

		// Token: 0x04012DE5 RID: 77285
		internal static int __PropertyOffset_154;

		// Token: 0x04012DE6 RID: 77286
		internal static int __PropertyOffset_155;

		// Token: 0x04012DE7 RID: 77287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SD_KuroTraceCloudData> _Data;

		// Token: 0x04012DE8 RID: 77288
		internal static int __PropertyOffset_156;

		// Token: 0x04012DE9 RID: 77289
		internal static int __PropertyOffset_157;

		// Token: 0x04012DEA RID: 77290
		internal static int __PropertyOffset_158;

		// Token: 0x04012DEB RID: 77291
		internal static int __PropertyOffset_159;

		// Token: 0x04012DEC RID: 77292
		internal static int __PropertyOffset_160;

		// Token: 0x04012DED RID: 77293
		internal static int __PropertyOffset_161;

		// Token: 0x04012DEE RID: 77294
		internal static int __PropertyOffset_162;

		// Token: 0x04012DEF RID: 77295
		internal static int __PropertyOffset_163;

		// Token: 0x04012DF0 RID: 77296
		internal static int __PropertyOffset_164;

		// Token: 0x04012DF1 RID: 77297
		internal static int __PropertyOffset_165;

		// Token: 0x04012DF2 RID: 77298
		internal static int __PropertyOffset_166;

		// Token: 0x04012DF3 RID: 77299
		internal static int __PropertyOffset_167;

		// Token: 0x04012DF4 RID: 77300
		internal static int __PropertyOffset_168;

		// Token: 0x04012DF5 RID: 77301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CommandToolStartArray;

		// Token: 0x04012DF6 RID: 77302
		internal static int __PropertyOffset_169;

		// Token: 0x04012DF7 RID: 77303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CommandToolEndArray;

		// Token: 0x04012DF8 RID: 77304
		internal static int __PropertyOffset_170;

		// Token: 0x04012DF9 RID: 77305
		private TArray<float> _CommandToolOriginalValueArray;

		// Token: 0x04012DFA RID: 77306
		internal static int __PropertyOffset_171;

		// Token: 0x04012DFB RID: 77307
		internal static int __PropertyOffset_172;

		// Token: 0x04012DFC RID: 77308
		internal static int __PropertyOffset_173;

		// Token: 0x04012DFD RID: 77309
		internal static int __PropertyOffset_174;

		// Token: 0x04012DFE RID: 77310
		internal static int __PropertyOffset_175;

		// Token: 0x04012DFF RID: 77311
		internal static int __PropertyOffset_176;

		// Token: 0x04012E00 RID: 77312
		internal static int __PropertyOffset_177;

		// Token: 0x04012E01 RID: 77313
		private static IntPtr __UodateSkylightBlendTick_NativeFunctionPtr;

		// Token: 0x04012E02 RID: 77314
		private static IntPtr __UpdateVolumeCloudGodRay_NativeFunctionPtr;

		// Token: 0x04012E03 RID: 77315
		private static IntPtr __OnGlobalGITick_NativeFunctionPtr;

		// Token: 0x04012E04 RID: 77316
		private static IntPtr __UpdateMeshBlend_NativeFunctionPtr;

		// Token: 0x04012E05 RID: 77317
		private static IntPtr __ToggleShowDynamicSkyPlatform_NativeFunctionPtr;

		// Token: 0x04012E06 RID: 77318
		private static IntPtr __UpadteVolumertricCloud_NativeFunctionPtr;

		// Token: 0x04012E07 RID: 77319
		private static IntPtr __UpdateCharacterRootPos_NativeFunctionPtr;

		// Token: 0x04012E08 RID: 77320
		private static IntPtr __Set_GIControlParamToGlobalShaderParam_NativeFunctionPtr;

		// Token: 0x04012E09 RID: 77321
		private static IntPtr __UpdateOriginSkyAtmosphere_NativeFunctionPtr;

		// Token: 0x04012E0A RID: 77322
		private static IntPtr __UpdateVolumeCloudLightWeight_NativeFunctionPtr;

		// Token: 0x04012E0B RID: 77323
		private static IntPtr __IsPerformanceLightExist_NativeFunctionPtr;

		// Token: 0x04012E0C RID: 77324
		private static IntPtr __UpdateOcean_NativeFunctionPtr;

		// Token: 0x04012E0D RID: 77325
		private static IntPtr __UpdateFrozen_NativeFunctionPtr;

		// Token: 0x04012E0E RID: 77326
		private static IntPtr __UpdateEditor_NativeFunctionPtr;

		// Token: 0x04012E0F RID: 77327
		private static IntPtr __UpdateBigWorld_NativeFunctionPtr;

		// Token: 0x04012E10 RID: 77328
		private static IntPtr __UpdateMilkWay_NativeFunctionPtr;

		// Token: 0x04012E11 RID: 77329
		private static IntPtr __GetMilkyWayDMI_NativeFunctionPtr;

		// Token: 0x04012E12 RID: 77330
		private static IntPtr __updateLightFunctions_NativeFunctionPtr;

		// Token: 0x04012E13 RID: 77331
		private static IntPtr __GetParallaxCorrectCachedCrossFadeShadowDirection_NativeFunctionPtr;

		// Token: 0x04012E14 RID: 77332
		private static IntPtr __GetTODCharacterLighting_NativeFunctionPtr;

		// Token: 0x04012E15 RID: 77333
		private static IntPtr __GetParallaxCorrectCachedShadowDirection_NativeFunctionPtr;

		// Token: 0x04012E16 RID: 77334
		private static IntPtr __SetLevelSequenceCloudControl_NativeFunctionPtr;

		// Token: 0x04012E17 RID: 77335
		private static IntPtr __Clamp_Luminance_NativeFunctionPtr;

		// Token: 0x04012E18 RID: 77336
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x04012E19 RID: 77337
		private static IntPtr __Update_Dynamic_Clouds_NativeFunctionPtr;

		// Token: 0x04012E1A RID: 77338
		private static IntPtr __SetLevelSequenceTimeControl_NativeFunctionPtr;

		// Token: 0x04012E1B RID: 77339
		private static IntPtr __GetStarsDMI_NativeFunctionPtr;

		// Token: 0x04012E1C RID: 77340
		private static IntPtr __UpdateClusteredStuff_NativeFunctionPtr;

		// Token: 0x04012E1D RID: 77341
		private static IntPtr __GetSkyboxDMI_NativeFunctionPtr;

		// Token: 0x04012E1E RID: 77342
		private static IntPtr __UpdateSkybox_NativeFunctionPtr;

		// Token: 0x04012E1F RID: 77343
		private static IntPtr __Update_Misc_NativeFunctionPtr;

		// Token: 0x04012E20 RID: 77344
		private static IntPtr __UpdateFlowmapSkybox_NativeFunctionPtr;

		// Token: 0x04012E21 RID: 77345
		private static IntPtr __申时_NativeFunctionPtr;

		// Token: 0x04012E22 RID: 77346
		private static IntPtr __下午_NativeFunctionPtr;

		// Token: 0x04012E23 RID: 77347
		private static IntPtr __上午_NativeFunctionPtr;

		// Token: 0x04012E24 RID: 77348
		private static IntPtr __辰时_NativeFunctionPtr;

		// Token: 0x04012E25 RID: 77349
		private static IntPtr __Update_Day_Night_Data_Layer_NativeFunctionPtr;

		// Token: 0x04012E26 RID: 77350
		private static IntPtr __UpdateCloudCard_NativeFunctionPtr;

		// Token: 0x04012E27 RID: 77351
		private static IntPtr __夜晚_NativeFunctionPtr;

		// Token: 0x04012E28 RID: 77352
		private static IntPtr __夜晚到清晨_NativeFunctionPtr;

		// Token: 0x04012E29 RID: 77353
		private static IntPtr __黄昏到夜晚_NativeFunctionPtr;

		// Token: 0x04012E2A RID: 77354
		private static IntPtr __黄昏_NativeFunctionPtr;

		// Token: 0x04012E2B RID: 77355
		private static IntPtr __中午_NativeFunctionPtr;

		// Token: 0x04012E2C RID: 77356
		private static IntPtr __清晨_NativeFunctionPtr;

		// Token: 0x04012E2D RID: 77357
		private static IntPtr __UpdateSkyDome_NativeFunctionPtr;

		// Token: 0x04012E2E RID: 77358
		private static IntPtr __InitGI_NativeFunctionPtr;

		// Token: 0x04012E2F RID: 77359
		private static IntPtr __Set_All_Components_States_NativeFunctionPtr;

		// Token: 0x04012E30 RID: 77360
		private static IntPtr __UpdateLightShaft_NativeFunctionPtr;

		// Token: 0x04012E31 RID: 77361
		private static IntPtr __GetLightDirectionFromVH_NativeFunctionPtr;

		// Token: 0x04012E32 RID: 77362
		private static IntPtr __UpdatePostProcessVolume_NativeFunctionPtr;

		// Token: 0x04012E33 RID: 77363
		private static IntPtr __UpdateLightParameters_NativeFunctionPtr;

		// Token: 0x04012E34 RID: 77364
		private static IntPtr __Update_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012E35 RID: 77365
		private static IntPtr __Update_Main_Light_NativeFunctionPtr;

		// Token: 0x04012E36 RID: 77366
		private static IntPtr __Update_UI_Env_NativeFunctionPtr;

		// Token: 0x04012E37 RID: 77367
		private static IntPtr __UpdateTime_NativeFunctionPtr;

		// Token: 0x04012E38 RID: 77368
		private static IntPtr __UpdateTimeOnce_NativeFunctionPtr;

		// Token: 0x04012E39 RID: 77369
		private static IntPtr __GetViewLocation_NativeFunctionPtr;

		// Token: 0x04012E3A RID: 77370
		private static IntPtr __InitFeature_NativeFunctionPtr;

		// Token: 0x04012E3B RID: 77371
		private static IntPtr __CalculateLightDirectionWithLimit_NativeFunctionPtr;

		// Token: 0x04012E3C RID: 77372
		private static IntPtr __CalculateLightDirection_NativeFunctionPtr;

		// Token: 0x04012E3D RID: 77373
		private static IntPtr __UpdateAtmosphere_NativeFunctionPtr;

		// Token: 0x04012E3E RID: 77374
		private static IntPtr __UpdateSkyLight_NativeFunctionPtr;

		// Token: 0x04012E3F RID: 77375
		private static IntPtr __Get_Scene_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012E40 RID: 77376
		private static IntPtr __InitGICompoemnt_NativeFunctionPtr;

		// Token: 0x04012E41 RID: 77377
		private static IntPtr __InitMaterials_NativeFunctionPtr;

		// Token: 0x04012E42 RID: 77378
		private static IntPtr __UpdateWind_NativeFunctionPtr;

		// Token: 0x04012E43 RID: 77379
		private static IntPtr __Get2SkyboxLerpWeight_NativeFunctionPtr;

		// Token: 0x04012E44 RID: 77380
		private static IntPtr __Update_Env_NativeFunctionPtr;

		// Token: 0x04012E45 RID: 77381
		private static IntPtr __UpdateFog_NativeFunctionPtr;

		// Token: 0x04012E46 RID: 77382
		private static IntPtr __UpdateGIData_NativeFunctionPtr;

		// Token: 0x04012E47 RID: 77383
		private static IntPtr __UpdateCharacterGI_NativeFunctionPtr;

		// Token: 0x04012E48 RID: 77384
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012E49 RID: 77385
		private static IntPtr __OnKuroTickEditor_NativeFunctionPtr;

		// Token: 0x04012E4A RID: 77386
		private static IntPtr __OnKuroTick_NativeFunctionPtr;

		// Token: 0x04012E4B RID: 77387
		private static IntPtr __OnKuroInit_NativeFunctionPtr;

		// Token: 0x04012E4C RID: 77388
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012E4D RID: 77389
		private static IntPtr __OnKuroRuntimeDestroy_NativeFunctionPtr;

		// Token: 0x04012E4E RID: 77390
		private static IntPtr __OnKuroSetRuntimeTime_NativeFunctionPtr;

		// Token: 0x04012E4F RID: 77391
		private static IntPtr __OnKuroStartUiScene_NativeFunctionPtr;

		// Token: 0x04012E50 RID: 77392
		private static IntPtr __OnKuroEndUiScene_NativeFunctionPtr;

		// Token: 0x0200A025 RID: 40997
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 328)]
		protected ref struct __UpdateMilkWay_FunctionParams
		{
			// Token: 0x04031ACE RID: 203470
			[FieldOffset(0)]
			public IntPtr MilkyWay_DMI;

			// Token: 0x04031ACF RID: 203471
			[FieldOffset(8)]
			public byte CloudCardSetting;
		}

		// Token: 0x0200A026 RID: 40998
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetMilkyWayDMI_FunctionParams
		{
			// Token: 0x04031AD0 RID: 203472
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x0200A027 RID: 40999
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams
		{
			// Token: 0x04031AD1 RID: 203473
			[FieldOffset(0)]
			public FRotator NewParam;
		}

		// Token: 0x0200A028 RID: 41000
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __GetTODCharacterLighting_FunctionParams
		{
			// Token: 0x04031AD2 RID: 203474
			[FieldOffset(0)]
			public FLinearColor mainLight;

			// Token: 0x04031AD3 RID: 203475
			[FieldOffset(16)]
			public float mainLightIntensity;

			// Token: 0x04031AD4 RID: 203476
			[FieldOffset(20)]
			public FLinearColor skyLight;

			// Token: 0x04031AD5 RID: 203477
			[FieldOffset(36)]
			public float skyLightIntensity;

			// Token: 0x04031AD6 RID: 203478
			[FieldOffset(40)]
			public FLinearColor FrontSideLight;

			// Token: 0x04031AD7 RID: 203479
			[FieldOffset(56)]
			public FLinearColor BackSideLight;
		}

		// Token: 0x0200A029 RID: 41001
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetParallaxCorrectCachedShadowDirection_FunctionParams
		{
			// Token: 0x04031AD8 RID: 203480
			[FieldOffset(0)]
			public FRotator NewParam;
		}

		// Token: 0x0200A02A RID: 41002
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetLevelSequenceCloudControl_FunctionParams
		{
			// Token: 0x04031AD9 RID: 203481
			[FieldOffset(0)]
			public IntPtr SeqCloudsController;
		}

		// Token: 0x0200A02B RID: 41003
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 108)]
		protected ref struct __Clamp_Luminance_FunctionParams
		{
			// Token: 0x04031ADA RID: 203482
			[FieldOffset(0)]
			public FLinearColor InColor;

			// Token: 0x04031ADB RID: 203483
			[FieldOffset(16)]
			public float Min;

			// Token: 0x04031ADC RID: 203484
			[FieldOffset(20)]
			public float Max;

			// Token: 0x04031ADD RID: 203485
			[FieldOffset(24)]
			public FLinearColor __Result;
		}

		// Token: 0x0200A02C RID: 41004
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x04031ADE RID: 203486
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x04031ADF RID: 203487
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x04031AE0 RID: 203488
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x0200A02D RID: 41005
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetLevelSequenceTimeControl_FunctionParams
		{
			// Token: 0x04031AE1 RID: 203489
			[FieldOffset(0)]
			public IntPtr TodTimeControl;
		}

		// Token: 0x0200A02E RID: 41006
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetStarsDMI_FunctionParams
		{
			// Token: 0x04031AE2 RID: 203490
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x0200A02F RID: 41007
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSkyboxDMI_FunctionParams
		{
			// Token: 0x04031AE3 RID: 203491
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x0200A030 RID: 41008
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 164)]
		protected ref struct __UpdateCloudCard_FunctionParams
		{
			// Token: 0x04031AE4 RID: 203492
			[FieldOffset(0)]
			public byte CloudCardSetting;
		}

		// Token: 0x0200A031 RID: 41009
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __Set_All_Components_States_FunctionParams
		{
			// Token: 0x04031AE5 RID: 203493
			[FieldOffset(0)]
			public bool IsEnable;
		}

		// Token: 0x0200A032 RID: 41010
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetLightDirectionFromVH_FunctionParams
		{
			// Token: 0x04031AE6 RID: 203494
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x04031AE7 RID: 203495
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x04031AE8 RID: 203496
			[FieldOffset(8)]
			public FRotator Result;
		}

		// Token: 0x0200A033 RID: 41011
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateTimeOnce_FunctionParams
		{
			// Token: 0x04031AE9 RID: 203497
			[FieldOffset(0)]
			public float OverrideTime;
		}

		// Token: 0x0200A034 RID: 41012
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetViewLocation_FunctionParams
		{
			// Token: 0x04031AEA RID: 203498
			[FieldOffset(0)]
			public FVector WorldPosition;

			// Token: 0x04031AEB RID: 203499
			[FieldOffset(12)]
			public bool Suc;
		}

		// Token: 0x0200A035 RID: 41013
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __CalculateLightDirectionWithLimit_FunctionParams
		{
			// Token: 0x04031AEC RID: 203500
			[FieldOffset(0)]
			public float V;

			// Token: 0x04031AED RID: 203501
			[FieldOffset(4)]
			public float H;

			// Token: 0x04031AEE RID: 203502
			[FieldOffset(8)]
			public float Time;

			// Token: 0x04031AEF RID: 203503
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x0200A036 RID: 41014
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __CalculateLightDirection_FunctionParams
		{
			// Token: 0x04031AF0 RID: 203504
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x04031AF1 RID: 203505
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x04031AF2 RID: 203506
			[FieldOffset(8)]
			public float Time;

			// Token: 0x04031AF3 RID: 203507
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x0200A037 RID: 41015
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Get_Scene_Light_Direction_FunctionParams
		{
			// Token: 0x04031AF4 RID: 203508
			[FieldOffset(0)]
			public FVector LightDir;
		}

		// Token: 0x0200A038 RID: 41016
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __Get2SkyboxLerpWeight_FunctionParams
		{
			// Token: 0x04031AF5 RID: 203509
			[FieldOffset(0)]
			public float startSetting;

			// Token: 0x04031AF6 RID: 203510
			[FieldOffset(4)]
			public float EndSetting;

			// Token: 0x04031AF7 RID: 203511
			[FieldOffset(8)]
			public float CurrentTime;

			// Token: 0x04031AF8 RID: 203512
			[FieldOffset(12)]
			public float Weight;
		}

		// Token: 0x0200A039 RID: 41017
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateGIData_FunctionParams
		{
			// Token: 0x04031AF9 RID: 203513
			[FieldOffset(0)]
			public bool Skip_Lerp_Data;
		}

		// Token: 0x0200A03A RID: 41018
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTickEditor_FunctionParams
		{
			// Token: 0x04031AFA RID: 203514
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A03B RID: 41019
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTick_FunctionParams
		{
			// Token: 0x04031AFB RID: 203515
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A03C RID: 41020
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroSetRuntimeTime_FunctionParams
		{
			// Token: 0x04031AFC RID: 203516
			[FieldOffset(0)]
			public float CurrentTime;
		}

		// Token: 0x0200A03D RID: 41021
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __OnKuroStartUiScene_FunctionParams
		{
			// Token: 0x04031AFD RID: 203517
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x04031AFE RID: 203518
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}
	}
}
