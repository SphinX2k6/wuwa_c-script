using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.UI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D2E RID: 15662
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI_XuanJue.BP_GlobalGI_XuanJue_C")]
	[UnrealStructLayout(16816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 16808)]
	public class BP_GlobalGI_XuanJue_C : AKuroGlobalGI, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025DFD RID: 155133 RVA: 0x00965226 File Offset: 0x00963426
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GlobalGI_XuanJue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI_XuanJue.BP_GlobalGI_XuanJue_C");
			}
			return BP_GlobalGI_XuanJue_C._ClassPtr;
		}

		// Token: 0x06025DFE RID: 155134 RVA: 0x0096524C File Offset: 0x0096344C
		public BP_GlobalGI_XuanJue_C() : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_XuanJue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025DFF RID: 155135 RVA: 0x00965274 File Offset: 0x00963474
		[NullableContext(1)]
		public BP_GlobalGI_XuanJue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_XuanJue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F3C RID: 20284
		// (get) Token: 0x06025E00 RID: 155136 RVA: 0x009652A7 File Offset: 0x009634A7
		// (set) Token: 0x06025E01 RID: 155137 RVA: 0x009652BB File Offset: 0x009634BB
		public unsafe USceneRayTracingGICaptureComponentCube SceneRayTracingGICaptureComponentCube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneRayTracingGICaptureComponentCube>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x06025E02 RID: 155138 RVA: 0x009652D0 File Offset: 0x009634D0
		// (set) Token: 0x06025E03 RID: 155139 RVA: 0x009652E4 File Offset: 0x009634E4
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x06025E04 RID: 155140 RVA: 0x009652F9 File Offset: 0x009634F9
		// (set) Token: 0x06025E05 RID: 155141 RVA: 0x0096530D File Offset: 0x0096350D
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x06025E06 RID: 155142 RVA: 0x00965322 File Offset: 0x00963522
		// (set) Token: 0x06025E07 RID: 155143 RVA: 0x00965336 File Offset: 0x00963536
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x06025E08 RID: 155144 RVA: 0x0096534B File Offset: 0x0096354B
		// (set) Token: 0x06025E09 RID: 155145 RVA: 0x0096535F File Offset: 0x0096355F
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x06025E0A RID: 155146 RVA: 0x00965374 File Offset: 0x00963574
		// (set) Token: 0x06025E0B RID: 155147 RVA: 0x00965388 File Offset: 0x00963588
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x06025E0C RID: 155148 RVA: 0x0096539D File Offset: 0x0096359D
		// (set) Token: 0x06025E0D RID: 155149 RVA: 0x009653B1 File Offset: 0x009635B1
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x06025E0E RID: 155150 RVA: 0x009653C6 File Offset: 0x009635C6
		// (set) Token: 0x06025E0F RID: 155151 RVA: 0x009653DA File Offset: 0x009635DA
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x06025E10 RID: 155152 RVA: 0x009653EF File Offset: 0x009635EF
		// (set) Token: 0x06025E11 RID: 155153 RVA: 0x00965403 File Offset: 0x00963603
		public unsafe UKuroPostProcessComponent LUTPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x06025E12 RID: 155154 RVA: 0x00965418 File Offset: 0x00963618
		// (set) Token: 0x06025E13 RID: 155155 RVA: 0x0096542C File Offset: 0x0096362C
		public unsafe UStaticMeshComponent SM_Aurora
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x06025E14 RID: 155156 RVA: 0x00965441 File Offset: 0x00963641
		// (set) Token: 0x06025E15 RID: 155157 RVA: 0x00965455 File Offset: 0x00963655
		public unsafe UStaticMeshComponent SM_Stars
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x06025E16 RID: 155158 RVA: 0x0096546A File Offset: 0x0096366A
		// (set) Token: 0x06025E17 RID: 155159 RVA: 0x0096547E File Offset: 0x0096367E
		public unsafe UStaticMeshComponent Skybox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x06025E18 RID: 155160 RVA: 0x00965493 File Offset: 0x00963693
		// (set) Token: 0x06025E19 RID: 155161 RVA: 0x009654A7 File Offset: 0x009636A7
		public unsafe UKuroPostProcessComponent GlobalUiKuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x06025E1A RID: 155162 RVA: 0x009654BC File Offset: 0x009636BC
		// (set) Token: 0x06025E1B RID: 155163 RVA: 0x009654D0 File Offset: 0x009636D0
		public unsafe UPostProcessComponent GlobalPostProcessVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x06025E1C RID: 155164 RVA: 0x009654E5 File Offset: 0x009636E5
		// (set) Token: 0x06025E1D RID: 155165 RVA: 0x009654F9 File Offset: 0x009636F9
		public unsafe UDirectionalLightComponent SceneLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x06025E1E RID: 155166 RVA: 0x0096550E File Offset: 0x0096370E
		// (set) Token: 0x06025E1F RID: 155167 RVA: 0x00965522 File Offset: 0x00963722
		public unsafe UDirectionalLightComponent AtmoMoonLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x06025E20 RID: 155168 RVA: 0x00965537 File Offset: 0x00963737
		// (set) Token: 0x06025E21 RID: 155169 RVA: 0x0096554B File Offset: 0x0096374B
		public unsafe UDirectionalLightComponent AtmoSunLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x06025E22 RID: 155170 RVA: 0x00965560 File Offset: 0x00963760
		// (set) Token: 0x06025E23 RID: 155171 RVA: 0x00965574 File Offset: 0x00963774
		public unsafe USkyLightComponent SkyLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x06025E24 RID: 155172 RVA: 0x00965589 File Offset: 0x00963789
		// (set) Token: 0x06025E25 RID: 155173 RVA: 0x0096559D File Offset: 0x0096379D
		public unsafe UExponentialHeightFogComponent HeightFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UExponentialHeightFogComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x06025E26 RID: 155174 RVA: 0x009655B2 File Offset: 0x009637B2
		// (set) Token: 0x06025E27 RID: 155175 RVA: 0x009655C6 File Offset: 0x009637C6
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x06025E28 RID: 155176 RVA: 0x009655DB File Offset: 0x009637DB
		// (set) Token: 0x06025E29 RID: 155177 RVA: 0x009655EB File Offset: 0x009637EB
		public unsafe float CharacterLightHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x06025E2A RID: 155178 RVA: 0x009655FC File Offset: 0x009637FC
		// (set) Token: 0x06025E2B RID: 155179 RVA: 0x0096560C File Offset: 0x0096380C
		public unsafe float CurrTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x06025E2C RID: 155180 RVA: 0x0096561D File Offset: 0x0096381D
		// (set) Token: 0x06025E2D RID: 155181 RVA: 0x0096562D File Offset: 0x0096382D
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x06025E2E RID: 155182 RVA: 0x0096563E File Offset: 0x0096383E
		// (set) Token: 0x06025E2F RID: 155183 RVA: 0x0096564E File Offset: 0x0096384E
		public unsafe bool EnableTODCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x06025E30 RID: 155184 RVA: 0x0096565F File Offset: 0x0096385F
		// (set) Token: 0x06025E31 RID: 155185 RVA: 0x0096566F File Offset: 0x0096386F
		public unsafe bool PauseTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x06025E32 RID: 155186 RVA: 0x00965680 File Offset: 0x00963880
		// (set) Token: 0x06025E33 RID: 155187 RVA: 0x00965690 File Offset: 0x00963890
		public unsafe bool 编辑器下更新
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x06025E34 RID: 155188 RVA: 0x009656A1 File Offset: 0x009638A1
		// (set) Token: 0x06025E35 RID: 155189 RVA: 0x009656B1 File Offset: 0x009638B1
		public unsafe float TODCycleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x06025E36 RID: 155190 RVA: 0x009656C2 File Offset: 0x009638C2
		// (set) Token: 0x06025E37 RID: 155191 RVA: 0x009656D6 File Offset: 0x009638D6
		public unsafe FRotator AtmosphereSunRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x06025E38 RID: 155192 RVA: 0x009656EB File Offset: 0x009638EB
		// (set) Token: 0x06025E39 RID: 155193 RVA: 0x009656FF File Offset: 0x009638FF
		public unsafe FRotator SenenDirLightRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x06025E3A RID: 155194 RVA: 0x00965714 File Offset: 0x00963914
		// (set) Token: 0x06025E3B RID: 155195 RVA: 0x00965724 File Offset: 0x00963924
		public unsafe float BP_SunHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x06025E3C RID: 155196 RVA: 0x00965735 File Offset: 0x00963935
		// (set) Token: 0x06025E3D RID: 155197 RVA: 0x00965745 File Offset: 0x00963945
		public unsafe float BP_SunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x06025E3E RID: 155198 RVA: 0x00965756 File Offset: 0x00963956
		// (set) Token: 0x06025E3F RID: 155199 RVA: 0x00965766 File Offset: 0x00963966
		public unsafe float MainLightHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x06025E40 RID: 155200 RVA: 0x00965777 File Offset: 0x00963977
		// (set) Token: 0x06025E41 RID: 155201 RVA: 0x00965787 File Offset: 0x00963987
		public unsafe float MainLightVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x06025E42 RID: 155202 RVA: 0x00965798 File Offset: 0x00963998
		// (set) Token: 0x06025E43 RID: 155203 RVA: 0x009657A8 File Offset: 0x009639A8
		public unsafe float MainLightAngleLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x06025E44 RID: 155204 RVA: 0x009657B9 File Offset: 0x009639B9
		// (set) Token: 0x06025E45 RID: 155205 RVA: 0x009657C9 File Offset: 0x009639C9
		public unsafe bool IsGIEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x06025E46 RID: 155206 RVA: 0x009657DA File Offset: 0x009639DA
		// (set) Token: 0x06025E47 RID: 155207 RVA: 0x009657EA File Offset: 0x009639EA
		public unsafe bool 使用随机的昼夜循环天气组
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F60 RID: 20320
		// (get) Token: 0x06025E48 RID: 155208 RVA: 0x009657FB File Offset: 0x009639FB
		// (set) Token: 0x06025E49 RID: 155209 RVA: 0x0096580B File Offset: 0x00963A0B
		public unsafe int 当前的天气组索引值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17004F61 RID: 20321
		// (get) Token: 0x06025E4A RID: 155210 RVA: 0x0096581C File Offset: 0x00963A1C
		// (set) Token: 0x06025E4B RID: 155211 RVA: 0x00965830 File Offset: 0x00963A30
		public unsafe FLinearColor 太阳颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17004F62 RID: 20322
		// (get) Token: 0x06025E4C RID: 155212 RVA: 0x00965848 File Offset: 0x00963A48
		// (set) Token: 0x06025E4D RID: 155213 RVA: 0x00965881 File Offset: 0x00963A81
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
					result = (this._SunLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_39, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SunLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x17004F63 RID: 20323
		// (get) Token: 0x06025E4E RID: 155214 RVA: 0x00965890 File Offset: 0x00963A90
		// (set) Token: 0x06025E4F RID: 155215 RVA: 0x009658C9 File Offset: 0x00963AC9
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
					result = (this._MoonLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_40, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MoonLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x17004F64 RID: 20324
		// (get) Token: 0x06025E50 RID: 155216 RVA: 0x009658D7 File Offset: 0x00963AD7
		// (set) Token: 0x06025E51 RID: 155217 RVA: 0x009658E7 File Offset: 0x00963AE7
		public unsafe bool 运行时自动开始循环
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F65 RID: 20325
		// (get) Token: 0x06025E52 RID: 155218 RVA: 0x009658F8 File Offset: 0x00963AF8
		// (set) Token: 0x06025E53 RID: 155219 RVA: 0x00965908 File Offset: 0x00963B08
		public unsafe bool UISceneRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x06025E54 RID: 155220 RVA: 0x00965919 File Offset: 0x00963B19
		// (set) Token: 0x06025E55 RID: 155221 RVA: 0x0096592D File Offset: 0x00963B2D
		public unsafe PDA_GIUIData_C UIData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_GIUIData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x06025E56 RID: 155222 RVA: 0x00965942 File Offset: 0x00963B42
		// (set) Token: 0x06025E57 RID: 155223 RVA: 0x00965952 File Offset: 0x00963B52
		public unsafe bool DEBUG_UI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x06025E58 RID: 155224 RVA: 0x00965963 File Offset: 0x00963B63
		// (set) Token: 0x06025E59 RID: 155225 RVA: 0x00965973 File Offset: 0x00963B73
		public unsafe bool IsRootGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x06025E5A RID: 155226 RVA: 0x00965984 File Offset: 0x00963B84
		// (set) Token: 0x06025E5B RID: 155227 RVA: 0x00965994 File Offset: 0x00963B94
		public unsafe bool IsEditorUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x06025E5C RID: 155228 RVA: 0x009659A5 File Offset: 0x00963BA5
		// (set) Token: 0x06025E5D RID: 155229 RVA: 0x009659B5 File Offset: 0x00963BB5
		public unsafe bool 更新角色光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x06025E5E RID: 155230 RVA: 0x009659C6 File Offset: 0x00963BC6
		// (set) Token: 0x06025E5F RID: 155231 RVA: 0x009659D6 File Offset: 0x00963BD6
		public unsafe bool 根据光源方向自动更新角色光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x06025E60 RID: 155232 RVA: 0x009659E7 File Offset: 0x00963BE7
		// (set) Token: 0x06025E61 RID: 155233 RVA: 0x009659F7 File Offset: 0x00963BF7
		public unsafe bool DEBUG_使用角色预览方向光
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x06025E62 RID: 155234 RVA: 0x00965A08 File Offset: 0x00963C08
		// (set) Token: 0x06025E63 RID: 155235 RVA: 0x00965A18 File Offset: 0x00963C18
		public unsafe float DEBUG_角色预览方向光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17004F6E RID: 20334
		// (get) Token: 0x06025E64 RID: 155236 RVA: 0x00965A29 File Offset: 0x00963C29
		// (set) Token: 0x06025E65 RID: 155237 RVA: 0x00965A39 File Offset: 0x00963C39
		public unsafe int TotalDaysElapsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17004F6F RID: 20335
		// (get) Token: 0x06025E66 RID: 155238 RVA: 0x00965A4A File Offset: 0x00963C4A
		// (set) Token: 0x06025E67 RID: 155239 RVA: 0x00965A5A File Offset: 0x00963C5A
		public unsafe float MoonFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17004F70 RID: 20336
		// (get) Token: 0x06025E68 RID: 155240 RVA: 0x00965A6B File Offset: 0x00963C6B
		// (set) Token: 0x06025E69 RID: 155241 RVA: 0x00965A7F File Offset: 0x00963C7F
		public unsafe FVector2D MoonVisibleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x06025E6A RID: 155242 RVA: 0x00965A94 File Offset: 0x00963C94
		// (set) Token: 0x06025E6B RID: 155243 RVA: 0x00965AA8 File Offset: 0x00963CA8
		public unsafe PDA_GIUIData_C DefaultUIData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_GIUIData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x06025E6C RID: 155244 RVA: 0x00965ABD File Offset: 0x00963CBD
		// (set) Token: 0x06025E6D RID: 155245 RVA: 0x00965ACD File Offset: 0x00963CCD
		public unsafe bool 关闭雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x06025E6E RID: 155246 RVA: 0x00965ADE File Offset: 0x00963CDE
		// (set) Token: 0x06025E6F RID: 155247 RVA: 0x00965AEE File Offset: 0x00963CEE
		public unsafe bool RuntimeTimeEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x06025E70 RID: 155248 RVA: 0x00965AFF File Offset: 0x00963CFF
		// (set) Token: 0x06025E71 RID: 155249 RVA: 0x00965B0F File Offset: 0x00963D0F
		public unsafe float MainLightTickSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17004F75 RID: 20341
		// (get) Token: 0x06025E72 RID: 155250 RVA: 0x00965B20 File Offset: 0x00963D20
		// (set) Token: 0x06025E73 RID: 155251 RVA: 0x00965B30 File Offset: 0x00963D30
		public unsafe float MainLightTickCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17004F76 RID: 20342
		// (get) Token: 0x06025E74 RID: 155252 RVA: 0x00965B41 File Offset: 0x00963D41
		// (set) Token: 0x06025E75 RID: 155253 RVA: 0x00965B51 File Offset: 0x00963D51
		public unsafe bool ForceUpdateMainLightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F77 RID: 20343
		// (get) Token: 0x06025E76 RID: 155254 RVA: 0x00965B62 File Offset: 0x00963D62
		// (set) Token: 0x06025E77 RID: 155255 RVA: 0x00965B72 File Offset: 0x00963D72
		public unsafe float WindDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17004F78 RID: 20344
		// (get) Token: 0x06025E78 RID: 155256 RVA: 0x00965B83 File Offset: 0x00963D83
		// (set) Token: 0x06025E79 RID: 155257 RVA: 0x00965B93 File Offset: 0x00963D93
		public unsafe bool 使用临时雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_61) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_61) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F79 RID: 20345
		// (get) Token: 0x06025E7A RID: 155258 RVA: 0x00965BA4 File Offset: 0x00963DA4
		// (set) Token: 0x06025E7B RID: 155259 RVA: 0x00965BB4 File Offset: 0x00963DB4
		public unsafe bool 开启集群特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_62) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_62) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F7A RID: 20346
		// (get) Token: 0x06025E7C RID: 155260 RVA: 0x00965BC5 File Offset: 0x00963DC5
		// (set) Token: 0x06025E7D RID: 155261 RVA: 0x00965BD9 File Offset: 0x00963DD9
		public unsafe UMaterialInstance TempFogMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x06025E7E RID: 155262 RVA: 0x00965BEE File Offset: 0x00963DEE
		// (set) Token: 0x06025E7F RID: 155263 RVA: 0x00965C02 File Offset: 0x00963E02
		public unsafe UMaterialInstanceDynamic TempFogDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x17004F7C RID: 20348
		// (get) Token: 0x06025E80 RID: 155264 RVA: 0x00965C17 File Offset: 0x00963E17
		// (set) Token: 0x06025E81 RID: 155265 RVA: 0x00965C2B File Offset: 0x00963E2B
		public unsafe UMaterialInstanceDynamic SkyboxDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x17004F7D RID: 20349
		// (get) Token: 0x06025E82 RID: 155266 RVA: 0x00965C40 File Offset: 0x00963E40
		// (set) Token: 0x06025E83 RID: 155267 RVA: 0x00965C54 File Offset: 0x00963E54
		public unsafe UMaterialInstance SkyboxMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_66);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x17004F7E RID: 20350
		// (get) Token: 0x06025E84 RID: 155268 RVA: 0x00965C69 File Offset: 0x00963E69
		// (set) Token: 0x06025E85 RID: 155269 RVA: 0x00965C7D File Offset: 0x00963E7D
		public unsafe FLinearColor SunDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x17004F7F RID: 20351
		// (get) Token: 0x06025E86 RID: 155270 RVA: 0x00965C92 File Offset: 0x00963E92
		// (set) Token: 0x06025E87 RID: 155271 RVA: 0x00965CA6 File Offset: 0x00963EA6
		public unsafe FLinearColor SunScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17004F80 RID: 20352
		// (get) Token: 0x06025E88 RID: 155272 RVA: 0x00965CBB File Offset: 0x00963EBB
		// (set) Token: 0x06025E89 RID: 155273 RVA: 0x00965CCB File Offset: 0x00963ECB
		public unsafe float SunSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17004F81 RID: 20353
		// (get) Token: 0x06025E8A RID: 155274 RVA: 0x00965CDC File Offset: 0x00963EDC
		// (set) Token: 0x06025E8B RID: 155275 RVA: 0x00965CF0 File Offset: 0x00963EF0
		public unsafe FLinearColor MoonDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x06025E8C RID: 155276 RVA: 0x00965D05 File Offset: 0x00963F05
		// (set) Token: 0x06025E8D RID: 155277 RVA: 0x00965D19 File Offset: 0x00963F19
		public unsafe FLinearColor MoonScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x06025E8E RID: 155278 RVA: 0x00965D2E File Offset: 0x00963F2E
		// (set) Token: 0x06025E8F RID: 155279 RVA: 0x00965D3E File Offset: 0x00963F3E
		public unsafe float MoonSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x17004F84 RID: 20356
		// (get) Token: 0x06025E90 RID: 155280 RVA: 0x00965D4F File Offset: 0x00963F4F
		// (set) Token: 0x06025E91 RID: 155281 RVA: 0x00965D63 File Offset: 0x00963F63
		public unsafe FLinearColor HorizonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x17004F85 RID: 20357
		// (get) Token: 0x06025E92 RID: 155282 RVA: 0x00965D78 File Offset: 0x00963F78
		// (set) Token: 0x06025E93 RID: 155283 RVA: 0x00965D88 File Offset: 0x00963F88
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x17004F86 RID: 20358
		// (get) Token: 0x06025E94 RID: 155284 RVA: 0x00965D99 File Offset: 0x00963F99
		// (set) Token: 0x06025E95 RID: 155285 RVA: 0x00965DAD File Offset: 0x00963FAD
		public unsafe FLinearColor ZenithColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17004F87 RID: 20359
		// (get) Token: 0x06025E96 RID: 155286 RVA: 0x00965DC2 File Offset: 0x00963FC2
		// (set) Token: 0x06025E97 RID: 155287 RVA: 0x00965DD2 File Offset: 0x00963FD2
		public unsafe float ExtremWeatherWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17004F88 RID: 20360
		// (get) Token: 0x06025E98 RID: 155288 RVA: 0x00965DE3 File Offset: 0x00963FE3
		// (set) Token: 0x06025E99 RID: 155289 RVA: 0x00965DF7 File Offset: 0x00963FF7
		public unsafe FLinearColor ST_TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17004F89 RID: 20361
		// (get) Token: 0x06025E9A RID: 155290 RVA: 0x00965E0C File Offset: 0x0096400C
		// (set) Token: 0x06025E9B RID: 155291 RVA: 0x00965E20 File Offset: 0x00964020
		public unsafe FLinearColor ST_DomeColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x17004F8A RID: 20362
		// (get) Token: 0x06025E9C RID: 155292 RVA: 0x00965E35 File Offset: 0x00964035
		// (set) Token: 0x06025E9D RID: 155293 RVA: 0x00965E45 File Offset: 0x00964045
		public unsafe float ST_TopWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_79);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_79) = value;
			}
		}

		// Token: 0x17004F8B RID: 20363
		// (get) Token: 0x06025E9E RID: 155294 RVA: 0x00965E56 File Offset: 0x00964056
		// (set) Token: 0x06025E9F RID: 155295 RVA: 0x00965E6A File Offset: 0x0096406A
		public unsafe UCurveFloat CharMainLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_80);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_80, value);
			}
		}

		// Token: 0x17004F8C RID: 20364
		// (get) Token: 0x06025EA0 RID: 155296 RVA: 0x00965E7F File Offset: 0x0096407F
		// (set) Token: 0x06025EA1 RID: 155297 RVA: 0x00965E93 File Offset: 0x00964093
		public unsafe UCurveFloat CharSkyLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_81);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_81, value);
			}
		}

		// Token: 0x17004F8D RID: 20365
		// (get) Token: 0x06025EA2 RID: 155298 RVA: 0x00965EA8 File Offset: 0x009640A8
		// (set) Token: 0x06025EA3 RID: 155299 RVA: 0x00965EB8 File Offset: 0x009640B8
		public unsafe bool UseCharCustomLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_82) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_82) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F8E RID: 20366
		// (get) Token: 0x06025EA4 RID: 155300 RVA: 0x00965EC9 File Offset: 0x009640C9
		// (set) Token: 0x06025EA5 RID: 155301 RVA: 0x00965EDD File Offset: 0x009640DD
		public unsafe FLinearColor CharAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_83);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_83) = value;
			}
		}

		// Token: 0x17004F8F RID: 20367
		// (get) Token: 0x06025EA6 RID: 155302 RVA: 0x00965EF2 File Offset: 0x009640F2
		// (set) Token: 0x06025EA7 RID: 155303 RVA: 0x00965F06 File Offset: 0x00964106
		public unsafe FLinearColor CharSkinAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x17004F90 RID: 20368
		// (get) Token: 0x06025EA8 RID: 155304 RVA: 0x00965F1B File Offset: 0x0096411B
		// (set) Token: 0x06025EA9 RID: 155305 RVA: 0x00965F2F File Offset: 0x0096412F
		public unsafe UCurveFloat CharShadowCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_85);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_85, value);
			}
		}

		// Token: 0x17004F91 RID: 20369
		// (get) Token: 0x06025EAA RID: 155306 RVA: 0x00965F44 File Offset: 0x00964144
		// (set) Token: 0x06025EAB RID: 155307 RVA: 0x00965F58 File Offset: 0x00964158
		public unsafe UMaterialInstance LightFunctionMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_86);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_86, value);
			}
		}

		// Token: 0x17004F92 RID: 20370
		// (get) Token: 0x06025EAC RID: 155308 RVA: 0x00965F6D File Offset: 0x0096416D
		// (set) Token: 0x06025EAD RID: 155309 RVA: 0x00965F7D File Offset: 0x0096417D
		public unsafe float LightFunctionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_87);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_87) = value;
			}
		}

		// Token: 0x17004F93 RID: 20371
		// (get) Token: 0x06025EAE RID: 155310 RVA: 0x00965F8E File Offset: 0x0096418E
		// (set) Token: 0x06025EAF RID: 155311 RVA: 0x00965FA2 File Offset: 0x009641A2
		public unsafe UMaterialInstanceDynamic LightFunctionDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_88);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_88, value);
			}
		}

		// Token: 0x17004F94 RID: 20372
		// (get) Token: 0x06025EB0 RID: 155312 RVA: 0x00965FB7 File Offset: 0x009641B7
		// (set) Token: 0x06025EB1 RID: 155313 RVA: 0x00965FC7 File Offset: 0x009641C7
		public unsafe bool DEBUG开启无音区特殊地表
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_89) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_89) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F95 RID: 20373
		// (get) Token: 0x06025EB2 RID: 155314 RVA: 0x00965FD8 File Offset: 0x009641D8
		// (set) Token: 0x06025EB3 RID: 155315 RVA: 0x00965FEC File Offset: 0x009641EC
		public unsafe UMaterialInstance LensFlareMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_90);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_90, value);
			}
		}

		// Token: 0x17004F96 RID: 20374
		// (get) Token: 0x06025EB4 RID: 155316 RVA: 0x00966001 File Offset: 0x00964201
		// (set) Token: 0x06025EB5 RID: 155317 RVA: 0x00966015 File Offset: 0x00964215
		public unsafe UMaterialInstanceDynamic LensFlareDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_91);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_91, value);
			}
		}

		// Token: 0x17004F97 RID: 20375
		// (get) Token: 0x06025EB6 RID: 155318 RVA: 0x0096602A File Offset: 0x0096422A
		// (set) Token: 0x06025EB7 RID: 155319 RVA: 0x0096603E File Offset: 0x0096423E
		public unsafe FLinearColor Nadir_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x17004F98 RID: 20376
		// (get) Token: 0x06025EB8 RID: 155320 RVA: 0x00966053 File Offset: 0x00964253
		// (set) Token: 0x06025EB9 RID: 155321 RVA: 0x00966063 File Offset: 0x00964263
		public unsafe float Nadir_Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x17004F99 RID: 20377
		// (get) Token: 0x06025EBA RID: 155322 RVA: 0x00966074 File Offset: 0x00964274
		// (set) Token: 0x06025EBB RID: 155323 RVA: 0x00966084 File Offset: 0x00964284
		public unsafe float Sun_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17004F9A RID: 20378
		// (get) Token: 0x06025EBC RID: 155324 RVA: 0x00966095 File Offset: 0x00964295
		// (set) Token: 0x06025EBD RID: 155325 RVA: 0x009660A5 File Offset: 0x009642A5
		public unsafe float Moon_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x17004F9B RID: 20379
		// (get) Token: 0x06025EBE RID: 155326 RVA: 0x009660B6 File Offset: 0x009642B6
		// (set) Token: 0x06025EBF RID: 155327 RVA: 0x009660CA File Offset: 0x009642CA
		public unsafe UMaterialInstanceDynamic Stars_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_96);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_96, value);
			}
		}

		// Token: 0x17004F9C RID: 20380
		// (get) Token: 0x06025EC0 RID: 155328 RVA: 0x009660DF File Offset: 0x009642DF
		// (set) Token: 0x06025EC1 RID: 155329 RVA: 0x009660F3 File Offset: 0x009642F3
		public unsafe UMaterialInstance StarsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_97);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_97, value);
			}
		}

		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x06025EC2 RID: 155330 RVA: 0x00966108 File Offset: 0x00964308
		// (set) Token: 0x06025EC3 RID: 155331 RVA: 0x0096611C File Offset: 0x0096431C
		public unsafe UMaterialInstanceDynamic AuroraDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_98);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_98, value);
			}
		}

		// Token: 0x17004F9E RID: 20382
		// (get) Token: 0x06025EC4 RID: 155332 RVA: 0x00966131 File Offset: 0x00964331
		// (set) Token: 0x06025EC5 RID: 155333 RVA: 0x00966145 File Offset: 0x00964345
		public unsafe UMaterialInstance AuroraMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_99);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_XuanJue_C.__PropertyOffset_99, value);
			}
		}

		// Token: 0x17004F9F RID: 20383
		// (get) Token: 0x06025EC6 RID: 155334 RVA: 0x0096615A File Offset: 0x0096435A
		// (set) Token: 0x06025EC7 RID: 155335 RVA: 0x0096616A File Offset: 0x0096436A
		public unsafe float MainDirectionLightUpdateThreshold_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x17004FA0 RID: 20384
		// (get) Token: 0x06025EC8 RID: 155336 RVA: 0x0096617B File Offset: 0x0096437B
		// (set) Token: 0x06025EC9 RID: 155337 RVA: 0x0096618B File Offset: 0x0096438B
		public unsafe float MainDirectionLightUpdateThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x17004FA1 RID: 20385
		// (get) Token: 0x06025ECA RID: 155338 RVA: 0x0096619C File Offset: 0x0096439C
		// (set) Token: 0x06025ECB RID: 155339 RVA: 0x009661B0 File Offset: 0x009643B0
		public unsafe FVector GlobalWindDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x17004FA2 RID: 20386
		// (get) Token: 0x06025ECC RID: 155340 RVA: 0x009661C5 File Offset: 0x009643C5
		// (set) Token: 0x06025ECD RID: 155341 RVA: 0x009661D9 File Offset: 0x009643D9
		public unsafe FVector GlobalWindRightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_103);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x17004FA3 RID: 20387
		// (get) Token: 0x06025ECE RID: 155342 RVA: 0x009661EE File Offset: 0x009643EE
		// (set) Token: 0x06025ECF RID: 155343 RVA: 0x009661FE File Offset: 0x009643FE
		public unsafe float DEBUG无音区特殊地表强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x06025ED0 RID: 155344 RVA: 0x0096620F File Offset: 0x0096440F
		// (set) Token: 0x06025ED1 RID: 155345 RVA: 0x00966223 File Offset: 0x00964423
		public unsafe FLinearColor Character_Rim_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_105);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_105) = value;
			}
		}

		// Token: 0x17004FA5 RID: 20389
		// (get) Token: 0x06025ED2 RID: 155346 RVA: 0x00966238 File Offset: 0x00964438
		// (set) Token: 0x06025ED3 RID: 155347 RVA: 0x00966248 File Offset: 0x00964448
		public unsafe float RealTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_106);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_XuanJue_C.__PropertyOffset_106) = value;
			}
		}

		// Token: 0x06025ED4 RID: 155348 RVA: 0x00966259 File Offset: 0x00964459
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCharacterGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateCharacterGI_NativeFunctionPtr, null);
		}

		// Token: 0x06025ED5 RID: 155349 RVA: 0x00966270 File Offset: 0x00964470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetTODCharacterLighting(FLinearColor mainLight, float mainLightIntensity, FLinearColor skyLight, float skyLightIntensity, ref FLinearColor FrontSideLight, ref FLinearColor BackSideLight)
		{
			BP_GlobalGI_XuanJue_C.__GetTODCharacterLighting_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__GetTODCharacterLighting_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__GetTODCharacterLighting_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mainLight = mainLight;
			ptr->mainLightIntensity = mainLightIntensity;
			ptr->skyLight = skyLight;
			ptr->skyLightIntensity = skyLightIntensity;
			ptr->FrontSideLight = FrontSideLight;
			ptr->BackSideLight = BackSideLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr);
			FrontSideLight = ptr->FrontSideLight;
			BackSideLight = ptr->BackSideLight;
		}

		// Token: 0x06025ED6 RID: 155350 RVA: 0x00966304 File Offset: 0x00964504
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FLinearColor Clamp_Luminance(FLinearColor InColor, float Min, float Max)
		{
			BP_GlobalGI_XuanJue_C.__Clamp_Luminance_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Clamp_Luminance_FunctionParams[(UIntPtr)123] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Clamp_Luminance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InColor = InColor;
			ptr->Min = Min;
			ptr->Max = Max;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025ED7 RID: 155351 RVA: 0x00966360 File Offset: 0x00964560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_GlobalGI_XuanJue_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__EulerToForward_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025ED8 RID: 155352 RVA: 0x009663B3 File Offset: 0x009645B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReloadRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__ReloadRain_NativeFunctionPtr, null);
		}

		// Token: 0x06025ED9 RID: 155353 RVA: 0x009663C8 File Offset: 0x009645C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAuroraDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_XuanJue_C.__GetAuroraDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__GetAuroraDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__GetAuroraDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__GetAuroraDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_XuanJue_C.__GetAuroraDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetAuroraDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x06025EDA RID: 155354 RVA: 0x0096642C File Offset: 0x0096462C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetStarsDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_XuanJue_C.__GetStarsDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__GetStarsDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__GetStarsDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__GetStarsDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_XuanJue_C.__GetStarsDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetStarsDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x06025EDB RID: 155355 RVA: 0x00966490 File Offset: 0x00964690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSkyboxDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_XuanJue_C.__GetSkyboxDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__GetSkyboxDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__GetSkyboxDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_XuanJue_C.__GetSkyboxDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x06025EDC RID: 155356 RVA: 0x009664F4 File Offset: 0x009646F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSkybox()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateSkybox_NativeFunctionPtr, null);
		}

		// Token: 0x06025EDD RID: 155357 RVA: 0x00966508 File Offset: 0x00964708
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMisc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateMisc_NativeFunctionPtr, null);
		}

		// Token: 0x06025EDE RID: 155358 RVA: 0x0096651C File Offset: 0x0096471C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFlowmapSkybox()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateFlowmapSkybox_NativeFunctionPtr, null);
		}

		// Token: 0x06025EDF RID: 155359 RVA: 0x00966530 File Offset: 0x00964730
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetTrulyTime(ref float CurTime)
		{
			BP_GlobalGI_XuanJue_C.__GetTrulyTime_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__GetTrulyTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__GetTrulyTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__GetTrulyTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurTime = CurTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetTrulyTime_NativeFunctionPtr, (void*)ptr);
			CurTime = ptr->CurTime;
		}

		// Token: 0x06025EE0 RID: 155360 RVA: 0x0096657F File Offset: 0x0096477F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 申时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__申时_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE1 RID: 155361 RVA: 0x00966593 File Offset: 0x00964793
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 下午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__下午_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE2 RID: 155362 RVA: 0x009665A7 File Offset: 0x009647A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 上午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__上午_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE3 RID: 155363 RVA: 0x009665BB File Offset: 0x009647BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 辰时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__辰时_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE4 RID: 155364 RVA: 0x009665CF File Offset: 0x009647CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDayNightDataLayer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateDayNightDataLayer_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE5 RID: 155365 RVA: 0x009665E4 File Offset: 0x009647E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCloudCard(ref FKuroCloudCardSetting CloudCardSetting)
		{
			BP_GlobalGI_XuanJue_C.__UpdateCloudCard_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__UpdateCloudCard_FunctionParams[(UIntPtr)179] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__UpdateCloudCard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__UpdateCloudCard_NativeFunctionPtr, (void*)ptr, 1);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCloudCardSetting.StaticStruct(), &ptr->CloudCardSetting, CloudCardSetting.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateCloudCard_NativeFunctionPtr, (void*)ptr);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCloudCardSetting.StaticStruct(), CloudCardSetting.NativePtr, &ptr->CloudCardSetting, 1, false);
			}
		}

		// Token: 0x06025EE6 RID: 155366 RVA: 0x0096666E File Offset: 0x0096486E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE7 RID: 155367 RVA: 0x00966682 File Offset: 0x00964882
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 夜晚到清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__夜晚到清晨_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE8 RID: 155368 RVA: 0x00966696 File Offset: 0x00964896
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 黄昏到夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__黄昏到夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06025EE9 RID: 155369 RVA: 0x009666AA File Offset: 0x009648AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 黄昏()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__黄昏_NativeFunctionPtr, null);
		}

		// Token: 0x06025EEA RID: 155370 RVA: 0x009666BE File Offset: 0x009648BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 中午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__中午_NativeFunctionPtr, null);
		}

		// Token: 0x06025EEB RID: 155371 RVA: 0x009666D2 File Offset: 0x009648D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__清晨_NativeFunctionPtr, null);
		}

		// Token: 0x06025EEC RID: 155372 RVA: 0x009666E6 File Offset: 0x009648E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLightMPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateLightMPC_NativeFunctionPtr, null);
		}

		// Token: 0x06025EED RID: 155373 RVA: 0x009666FA File Offset: 0x009648FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetSkyDomeActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetSkyDomeActor_NativeFunctionPtr, null);
		}

		// Token: 0x06025EEE RID: 155374 RVA: 0x00966710 File Offset: 0x00964910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Total_TOD_Time_Elapsed(ref float Time)
		{
			BP_GlobalGI_XuanJue_C.__Get_Total_TOD_Time_Elapsed_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Get_Total_TOD_Time_Elapsed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Get_Total_TOD_Time_Elapsed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Get_Total_TOD_Time_Elapsed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Get_Total_TOD_Time_Elapsed_NativeFunctionPtr, (void*)ptr);
			Time = ptr->Time;
		}

		// Token: 0x06025EEF RID: 155375 RVA: 0x0096675F File Offset: 0x0096495F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSkyDome()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateSkyDome_NativeFunctionPtr, null);
		}

		// Token: 0x06025EF0 RID: 155376 RVA: 0x00966773 File Offset: 0x00964973
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__InitGI_NativeFunctionPtr, null);
		}

		// Token: 0x06025EF1 RID: 155377 RVA: 0x00966788 File Offset: 0x00964988
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_All_Components_States(bool IsEnable)
		{
			BP_GlobalGI_XuanJue_C.__Set_All_Components_States_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Set_All_Components_States_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Set_All_Components_States_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEnable = IsEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025EF2 RID: 155378 RVA: 0x009667D0 File Offset: 0x009649D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetUIComponentsVisibility(bool IsVisible)
		{
			BP_GlobalGI_XuanJue_C.__SetUIComponentsVisibility_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__SetUIComponentsVisibility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__SetUIComponentsVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__SetUIComponentsVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsVisible = IsVisible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__SetUIComponentsVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025EF3 RID: 155379 RVA: 0x00966816 File Offset: 0x00964A16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void End3DUIScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__End3DUIScene_NativeFunctionPtr, null);
		}

		// Token: 0x06025EF4 RID: 155380 RVA: 0x0096682C File Offset: 0x00964A2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Start3DUIScene(PDA_GIUIData_C UIGIData)
		{
			BP_GlobalGI_XuanJue_C.__Start3DUIScene_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Start3DUIScene_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Start3DUIScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Start3DUIScene_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UIGIData = ((UIGIData != null) ? UIGIData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Start3DUIScene_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025EF5 RID: 155381 RVA: 0x00966881 File Offset: 0x00964A81
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLightShaft()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateLightShaft_NativeFunctionPtr, null);
		}

		// Token: 0x06025EF6 RID: 155382 RVA: 0x00966898 File Offset: 0x00964A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetLightDirectionFromVH(float Vertical, float Horizontal, ref FRotator Result)
		{
			BP_GlobalGI_XuanJue_C.__GetLightDirectionFromVH_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__GetLightDirectionFromVH_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__GetLightDirectionFromVH_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06025EF7 RID: 155383 RVA: 0x009668FD File Offset: 0x00964AFD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePostProcessVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdatePostProcessVolume_NativeFunctionPtr, null);
		}

		// Token: 0x06025EF8 RID: 155384 RVA: 0x00966911 File Offset: 0x00964B11
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLightParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateLightParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06025EF9 RID: 155385 RVA: 0x00966925 File Offset: 0x00964B25
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Main_Light_Direction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Update_Main_Light_Direction_NativeFunctionPtr, null);
		}

		// Token: 0x06025EFA RID: 155386 RVA: 0x00966939 File Offset: 0x00964B39
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMainLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateMainLight_NativeFunctionPtr, null);
		}

		// Token: 0x06025EFB RID: 155387 RVA: 0x0096694D File Offset: 0x00964B4D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateTime_NativeFunctionPtr, null);
		}

		// Token: 0x06025EFC RID: 155388 RVA: 0x00966964 File Offset: 0x00964B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetViewLocation(ref FVector WorldPosition, ref bool Suc)
		{
			BP_GlobalGI_XuanJue_C.__GetViewLocation_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__GetViewLocation_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__GetViewLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldPosition = WorldPosition;
			ptr->Suc = Suc;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr);
			WorldPosition = ptr->WorldPosition;
			Suc = ptr->Suc;
		}

		// Token: 0x06025EFD RID: 155389 RVA: 0x009669CB File Offset: 0x00964BCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitFeature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__InitFeature_NativeFunctionPtr, null);
		}

		// Token: 0x06025EFE RID: 155390 RVA: 0x009669E0 File Offset: 0x00964BE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalulateLightDirectionWithLimit(float V, float H, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_XuanJue_C.__CalulateLightDirectionWithLimit_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__CalulateLightDirectionWithLimit_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__CalulateLightDirectionWithLimit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__CalulateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V = V;
			ptr->H = H;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__CalulateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025EFF RID: 155391 RVA: 0x00966A54 File Offset: 0x00964C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateLightDirection(float Vertical, float Horizontal, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_XuanJue_C.__CalculateLightDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__CalculateLightDirection_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__CalculateLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025F00 RID: 155392 RVA: 0x00966AC2 File Offset: 0x00964CC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateAtmosphere()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateAtmosphere_NativeFunctionPtr, null);
		}

		// Token: 0x06025F01 RID: 155393 RVA: 0x00966AD6 File Offset: 0x00964CD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSkyLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateSkyLight_NativeFunctionPtr, null);
		}

		// Token: 0x06025F02 RID: 155394 RVA: 0x00966AEC File Offset: 0x00964CEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Scene_Light_Rotator(ref FRotator SunLight, ref FRotator NightLight)
		{
			BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Rotator_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Rotator_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Rotator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Rotator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SunLight = SunLight;
			ptr->NightLight = NightLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Rotator_NativeFunctionPtr, (void*)ptr);
			SunLight = ptr->SunLight;
			NightLight = ptr->NightLight;
		}

		// Token: 0x06025F03 RID: 155395 RVA: 0x00966B5C File Offset: 0x00964D5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Scene_Light_Direction(ref FVector LightDir)
		{
			BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Direction_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Direction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Direction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LightDir = LightDir;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr);
			LightDir = ptr->LightDir;
		}

		// Token: 0x06025F04 RID: 155396 RVA: 0x00966BB3 File Offset: 0x00964DB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitGICompoemnt()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__InitGICompoemnt_NativeFunctionPtr, null);
		}

		// Token: 0x06025F05 RID: 155397 RVA: 0x00966BC8 File Offset: 0x00964DC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Light_Rotator(ref FRotator SunLight, ref FRotator NightLight)
		{
			BP_GlobalGI_XuanJue_C.__Get_Light_Rotator_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Get_Light_Rotator_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Get_Light_Rotator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Get_Light_Rotator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SunLight = SunLight;
			ptr->NightLight = NightLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Get_Light_Rotator_NativeFunctionPtr, (void*)ptr);
			SunLight = ptr->SunLight;
			NightLight = ptr->NightLight;
		}

		// Token: 0x06025F06 RID: 155398 RVA: 0x00966C38 File Offset: 0x00964E38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Light_Direction(ref FVector SunLight, ref FVector NightLight)
		{
			BP_GlobalGI_XuanJue_C.__Get_Light_Direction_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Get_Light_Direction_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Get_Light_Direction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Get_Light_Direction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SunLight = SunLight;
			ptr->NightLight = NightLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Get_Light_Direction_NativeFunctionPtr, (void*)ptr);
			SunLight = ptr->SunLight;
			NightLight = ptr->NightLight;
		}

		// Token: 0x06025F07 RID: 155399 RVA: 0x00966CA7 File Offset: 0x00964EA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMaterials()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__InitMaterials_NativeFunctionPtr, null);
		}

		// Token: 0x06025F08 RID: 155400 RVA: 0x00966CBC File Offset: 0x00964EBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Is_Day(ref bool Result)
		{
			BP_GlobalGI_XuanJue_C.__Is_Day_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Is_Day_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Is_Day_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Is_Day_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Is_Day_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06025F09 RID: 155401 RVA: 0x00966D0B File Offset: 0x00964F0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWind()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateWind_NativeFunctionPtr, null);
		}

		// Token: 0x06025F0A RID: 155402 RVA: 0x00966D1F File Offset: 0x00964F1F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLensFlares()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateLensFlares_NativeFunctionPtr, null);
		}

		// Token: 0x06025F0B RID: 155403 RVA: 0x00966D34 File Offset: 0x00964F34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get2SkyboxLerpWeight(float startSetting, float EndSetting, float CurrentTime, ref float Weight)
		{
			BP_GlobalGI_XuanJue_C.__Get2SkyboxLerpWeight_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__Get2SkyboxLerpWeight_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__Get2SkyboxLerpWeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__Get2SkyboxLerpWeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->startSetting = startSetting;
			ptr->EndSetting = EndSetting;
			ptr->CurrentTime = CurrentTime;
			ptr->Weight = Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Get2SkyboxLerpWeight_NativeFunctionPtr, (void*)ptr);
			Weight = ptr->Weight;
		}

		// Token: 0x06025F0C RID: 155404 RVA: 0x00966D9A File Offset: 0x00964F9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Env()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__Update_Env_NativeFunctionPtr, null);
		}

		// Token: 0x06025F0D RID: 155405 RVA: 0x00966DAE File Offset: 0x00964FAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFog()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateFog_NativeFunctionPtr, null);
		}

		// Token: 0x06025F0E RID: 155406 RVA: 0x00966DC2 File Offset: 0x00964FC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateGIData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UpdateGIData_NativeFunctionPtr, null);
		}

		// Token: 0x06025F0F RID: 155407 RVA: 0x00966DD6 File Offset: 0x00964FD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025F10 RID: 155408 RVA: 0x00966DEA File Offset: 0x00964FEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025F11 RID: 155409 RVA: 0x00966E00 File Offset: 0x00965000
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroStartUI(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroStartUI_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroStartUI_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroStartUI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroStartUI_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroStartUI_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_XuanJue_C.__OnKuroStartUI_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025F12 RID: 155410 RVA: 0x00966E74 File Offset: 0x00965074
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroStartUI_Implementation(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroStartUI_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroStartUI_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroStartUI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroStartUI_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroStartUI_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_XuanJue_C.__OnKuroStartUI_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025F13 RID: 155411 RVA: 0x00966EE8 File Offset: 0x009650E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnKuroEndUI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroEndUI_NativeFunctionPtr, null);
		}

		// Token: 0x06025F14 RID: 155412 RVA: 0x00966EFC File Offset: 0x009650FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnKuroEndUI_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroEndUI_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025F15 RID: 155413 RVA: 0x00966F11 File Offset: 0x00965111
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnKuroInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroInit_NativeFunctionPtr, null);
		}

		// Token: 0x06025F16 RID: 155414 RVA: 0x00966F25 File Offset: 0x00965125
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnKuroInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025F17 RID: 155415 RVA: 0x00966F3C File Offset: 0x0096513C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroTick(float DeltaTime)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F18 RID: 155416 RVA: 0x00966F84 File Offset: 0x00965184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroTick_Implementation(float DeltaTime)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025F19 RID: 155417 RVA: 0x00966FCC File Offset: 0x009651CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroTickEditor(float DeltaTime)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F1A RID: 155418 RVA: 0x00967014 File Offset: 0x00965214
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroTickEditor_Implementation(float DeltaTime)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025F1B RID: 155419 RVA: 0x0096705B File Offset: 0x0096525B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025F1C RID: 155420 RVA: 0x0096706F File Offset: 0x0096526F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025F1D RID: 155421 RVA: 0x00967084 File Offset: 0x00965284
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnKuroRuntimeDestroy()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroRuntimeDestroy_NativeFunctionPtr, null);
		}

		// Token: 0x06025F1E RID: 155422 RVA: 0x00967098 File Offset: 0x00965298
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnKuroRuntimeDestroy_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroRuntimeDestroy_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025F1F RID: 155423 RVA: 0x009670B0 File Offset: 0x009652B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroSetRuntimeTime(float CurrentTime)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F20 RID: 155424 RVA: 0x009670F8 File Offset: 0x009652F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroSetRuntimeTime_Implementation(float CurrentTime)
		{
			BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_XuanJue_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025F21 RID: 155425 RVA: 0x0096713F File Offset: 0x0096533F
		protected BP_GlobalGI_XuanJue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F02 RID: 77570
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI_XuanJue.BP_GlobalGI_XuanJue_C";

		// Token: 0x04012F03 RID: 77571
		private static IntPtr _ClassPtr;

		// Token: 0x04012F04 RID: 77572
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F05 RID: 77573
		internal static int __PropertyOffset_1;

		// Token: 0x04012F06 RID: 77574
		internal static int __PropertyOffset_2;

		// Token: 0x04012F07 RID: 77575
		internal static int __PropertyOffset_3;

		// Token: 0x04012F08 RID: 77576
		internal static int __PropertyOffset_4;

		// Token: 0x04012F09 RID: 77577
		internal static int __PropertyOffset_5;

		// Token: 0x04012F0A RID: 77578
		internal static int __PropertyOffset_6;

		// Token: 0x04012F0B RID: 77579
		internal static int __PropertyOffset_7;

		// Token: 0x04012F0C RID: 77580
		internal static int __PropertyOffset_8;

		// Token: 0x04012F0D RID: 77581
		internal static int __PropertyOffset_9;

		// Token: 0x04012F0E RID: 77582
		internal static int __PropertyOffset_10;

		// Token: 0x04012F0F RID: 77583
		internal static int __PropertyOffset_11;

		// Token: 0x04012F10 RID: 77584
		internal static int __PropertyOffset_12;

		// Token: 0x04012F11 RID: 77585
		internal static int __PropertyOffset_13;

		// Token: 0x04012F12 RID: 77586
		internal static int __PropertyOffset_14;

		// Token: 0x04012F13 RID: 77587
		internal static int __PropertyOffset_15;

		// Token: 0x04012F14 RID: 77588
		internal static int __PropertyOffset_16;

		// Token: 0x04012F15 RID: 77589
		internal static int __PropertyOffset_17;

		// Token: 0x04012F16 RID: 77590
		internal static int __PropertyOffset_18;

		// Token: 0x04012F17 RID: 77591
		internal static int __PropertyOffset_19;

		// Token: 0x04012F18 RID: 77592
		internal static int __PropertyOffset_20;

		// Token: 0x04012F19 RID: 77593
		internal static int __PropertyOffset_21;

		// Token: 0x04012F1A RID: 77594
		internal static int __PropertyOffset_22;

		// Token: 0x04012F1B RID: 77595
		internal static int __PropertyOffset_23;

		// Token: 0x04012F1C RID: 77596
		internal static int __PropertyOffset_24;

		// Token: 0x04012F1D RID: 77597
		internal static int __PropertyOffset_25;

		// Token: 0x04012F1E RID: 77598
		internal static int __PropertyOffset_26;

		// Token: 0x04012F1F RID: 77599
		internal static int __PropertyOffset_27;

		// Token: 0x04012F20 RID: 77600
		internal static int __PropertyOffset_28;

		// Token: 0x04012F21 RID: 77601
		internal static int __PropertyOffset_29;

		// Token: 0x04012F22 RID: 77602
		internal static int __PropertyOffset_30;

		// Token: 0x04012F23 RID: 77603
		internal static int __PropertyOffset_31;

		// Token: 0x04012F24 RID: 77604
		internal static int __PropertyOffset_32;

		// Token: 0x04012F25 RID: 77605
		internal static int __PropertyOffset_33;

		// Token: 0x04012F26 RID: 77606
		internal static int __PropertyOffset_34;

		// Token: 0x04012F27 RID: 77607
		internal static int __PropertyOffset_35;

		// Token: 0x04012F28 RID: 77608
		internal static int __PropertyOffset_36;

		// Token: 0x04012F29 RID: 77609
		internal static int __PropertyOffset_37;

		// Token: 0x04012F2A RID: 77610
		internal static int __PropertyOffset_38;

		// Token: 0x04012F2B RID: 77611
		internal static int __PropertyOffset_39;

		// Token: 0x04012F2C RID: 77612
		private TArray<FVector2D> _SunLightExistTime;

		// Token: 0x04012F2D RID: 77613
		internal static int __PropertyOffset_40;

		// Token: 0x04012F2E RID: 77614
		private TArray<FVector2D> _MoonLightExistTime;

		// Token: 0x04012F2F RID: 77615
		internal static int __PropertyOffset_41;

		// Token: 0x04012F30 RID: 77616
		internal static int __PropertyOffset_42;

		// Token: 0x04012F31 RID: 77617
		internal static int __PropertyOffset_43;

		// Token: 0x04012F32 RID: 77618
		internal static int __PropertyOffset_44;

		// Token: 0x04012F33 RID: 77619
		internal static int __PropertyOffset_45;

		// Token: 0x04012F34 RID: 77620
		internal static int __PropertyOffset_46;

		// Token: 0x04012F35 RID: 77621
		internal static int __PropertyOffset_47;

		// Token: 0x04012F36 RID: 77622
		internal static int __PropertyOffset_48;

		// Token: 0x04012F37 RID: 77623
		internal static int __PropertyOffset_49;

		// Token: 0x04012F38 RID: 77624
		internal static int __PropertyOffset_50;

		// Token: 0x04012F39 RID: 77625
		internal static int __PropertyOffset_51;

		// Token: 0x04012F3A RID: 77626
		internal static int __PropertyOffset_52;

		// Token: 0x04012F3B RID: 77627
		internal static int __PropertyOffset_53;

		// Token: 0x04012F3C RID: 77628
		internal static int __PropertyOffset_54;

		// Token: 0x04012F3D RID: 77629
		internal static int __PropertyOffset_55;

		// Token: 0x04012F3E RID: 77630
		internal static int __PropertyOffset_56;

		// Token: 0x04012F3F RID: 77631
		internal static int __PropertyOffset_57;

		// Token: 0x04012F40 RID: 77632
		internal static int __PropertyOffset_58;

		// Token: 0x04012F41 RID: 77633
		internal static int __PropertyOffset_59;

		// Token: 0x04012F42 RID: 77634
		internal static int __PropertyOffset_60;

		// Token: 0x04012F43 RID: 77635
		internal static int __PropertyOffset_61;

		// Token: 0x04012F44 RID: 77636
		internal static int __PropertyOffset_62;

		// Token: 0x04012F45 RID: 77637
		internal static int __PropertyOffset_63;

		// Token: 0x04012F46 RID: 77638
		internal static int __PropertyOffset_64;

		// Token: 0x04012F47 RID: 77639
		internal static int __PropertyOffset_65;

		// Token: 0x04012F48 RID: 77640
		internal static int __PropertyOffset_66;

		// Token: 0x04012F49 RID: 77641
		internal static int __PropertyOffset_67;

		// Token: 0x04012F4A RID: 77642
		internal static int __PropertyOffset_68;

		// Token: 0x04012F4B RID: 77643
		internal static int __PropertyOffset_69;

		// Token: 0x04012F4C RID: 77644
		internal static int __PropertyOffset_70;

		// Token: 0x04012F4D RID: 77645
		internal static int __PropertyOffset_71;

		// Token: 0x04012F4E RID: 77646
		internal static int __PropertyOffset_72;

		// Token: 0x04012F4F RID: 77647
		internal static int __PropertyOffset_73;

		// Token: 0x04012F50 RID: 77648
		internal static int __PropertyOffset_74;

		// Token: 0x04012F51 RID: 77649
		internal static int __PropertyOffset_75;

		// Token: 0x04012F52 RID: 77650
		internal static int __PropertyOffset_76;

		// Token: 0x04012F53 RID: 77651
		internal static int __PropertyOffset_77;

		// Token: 0x04012F54 RID: 77652
		internal static int __PropertyOffset_78;

		// Token: 0x04012F55 RID: 77653
		internal static int __PropertyOffset_79;

		// Token: 0x04012F56 RID: 77654
		internal static int __PropertyOffset_80;

		// Token: 0x04012F57 RID: 77655
		internal static int __PropertyOffset_81;

		// Token: 0x04012F58 RID: 77656
		internal static int __PropertyOffset_82;

		// Token: 0x04012F59 RID: 77657
		internal static int __PropertyOffset_83;

		// Token: 0x04012F5A RID: 77658
		internal static int __PropertyOffset_84;

		// Token: 0x04012F5B RID: 77659
		internal static int __PropertyOffset_85;

		// Token: 0x04012F5C RID: 77660
		internal static int __PropertyOffset_86;

		// Token: 0x04012F5D RID: 77661
		internal static int __PropertyOffset_87;

		// Token: 0x04012F5E RID: 77662
		internal static int __PropertyOffset_88;

		// Token: 0x04012F5F RID: 77663
		internal static int __PropertyOffset_89;

		// Token: 0x04012F60 RID: 77664
		internal static int __PropertyOffset_90;

		// Token: 0x04012F61 RID: 77665
		internal static int __PropertyOffset_91;

		// Token: 0x04012F62 RID: 77666
		internal static int __PropertyOffset_92;

		// Token: 0x04012F63 RID: 77667
		internal static int __PropertyOffset_93;

		// Token: 0x04012F64 RID: 77668
		internal static int __PropertyOffset_94;

		// Token: 0x04012F65 RID: 77669
		internal static int __PropertyOffset_95;

		// Token: 0x04012F66 RID: 77670
		internal static int __PropertyOffset_96;

		// Token: 0x04012F67 RID: 77671
		internal static int __PropertyOffset_97;

		// Token: 0x04012F68 RID: 77672
		internal static int __PropertyOffset_98;

		// Token: 0x04012F69 RID: 77673
		internal static int __PropertyOffset_99;

		// Token: 0x04012F6A RID: 77674
		internal static int __PropertyOffset_100;

		// Token: 0x04012F6B RID: 77675
		internal static int __PropertyOffset_101;

		// Token: 0x04012F6C RID: 77676
		internal static int __PropertyOffset_102;

		// Token: 0x04012F6D RID: 77677
		internal static int __PropertyOffset_103;

		// Token: 0x04012F6E RID: 77678
		internal static int __PropertyOffset_104;

		// Token: 0x04012F6F RID: 77679
		internal static int __PropertyOffset_105;

		// Token: 0x04012F70 RID: 77680
		internal static int __PropertyOffset_106;

		// Token: 0x04012F71 RID: 77681
		private static IntPtr __UpdateCharacterGI_NativeFunctionPtr;

		// Token: 0x04012F72 RID: 77682
		private static IntPtr __GetTODCharacterLighting_NativeFunctionPtr;

		// Token: 0x04012F73 RID: 77683
		private static IntPtr __Clamp_Luminance_NativeFunctionPtr;

		// Token: 0x04012F74 RID: 77684
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x04012F75 RID: 77685
		private static IntPtr __ReloadRain_NativeFunctionPtr;

		// Token: 0x04012F76 RID: 77686
		private static IntPtr __GetAuroraDMI_NativeFunctionPtr;

		// Token: 0x04012F77 RID: 77687
		private static IntPtr __GetStarsDMI_NativeFunctionPtr;

		// Token: 0x04012F78 RID: 77688
		private static IntPtr __GetSkyboxDMI_NativeFunctionPtr;

		// Token: 0x04012F79 RID: 77689
		private static IntPtr __UpdateSkybox_NativeFunctionPtr;

		// Token: 0x04012F7A RID: 77690
		private static IntPtr __UpdateMisc_NativeFunctionPtr;

		// Token: 0x04012F7B RID: 77691
		private static IntPtr __UpdateFlowmapSkybox_NativeFunctionPtr;

		// Token: 0x04012F7C RID: 77692
		private static IntPtr __GetTrulyTime_NativeFunctionPtr;

		// Token: 0x04012F7D RID: 77693
		private static IntPtr __申时_NativeFunctionPtr;

		// Token: 0x04012F7E RID: 77694
		private static IntPtr __下午_NativeFunctionPtr;

		// Token: 0x04012F7F RID: 77695
		private static IntPtr __上午_NativeFunctionPtr;

		// Token: 0x04012F80 RID: 77696
		private static IntPtr __辰时_NativeFunctionPtr;

		// Token: 0x04012F81 RID: 77697
		private static IntPtr __UpdateDayNightDataLayer_NativeFunctionPtr;

		// Token: 0x04012F82 RID: 77698
		private static IntPtr __UpdateCloudCard_NativeFunctionPtr;

		// Token: 0x04012F83 RID: 77699
		private static IntPtr __夜晚_NativeFunctionPtr;

		// Token: 0x04012F84 RID: 77700
		private static IntPtr __夜晚到清晨_NativeFunctionPtr;

		// Token: 0x04012F85 RID: 77701
		private static IntPtr __黄昏到夜晚_NativeFunctionPtr;

		// Token: 0x04012F86 RID: 77702
		private static IntPtr __黄昏_NativeFunctionPtr;

		// Token: 0x04012F87 RID: 77703
		private static IntPtr __中午_NativeFunctionPtr;

		// Token: 0x04012F88 RID: 77704
		private static IntPtr __清晨_NativeFunctionPtr;

		// Token: 0x04012F89 RID: 77705
		private static IntPtr __UpdateLightMPC_NativeFunctionPtr;

		// Token: 0x04012F8A RID: 77706
		private static IntPtr __GetSkyDomeActor_NativeFunctionPtr;

		// Token: 0x04012F8B RID: 77707
		private static IntPtr __Get_Total_TOD_Time_Elapsed_NativeFunctionPtr;

		// Token: 0x04012F8C RID: 77708
		private static IntPtr __UpdateSkyDome_NativeFunctionPtr;

		// Token: 0x04012F8D RID: 77709
		private static IntPtr __InitGI_NativeFunctionPtr;

		// Token: 0x04012F8E RID: 77710
		private static IntPtr __Set_All_Components_States_NativeFunctionPtr;

		// Token: 0x04012F8F RID: 77711
		private static IntPtr __SetUIComponentsVisibility_NativeFunctionPtr;

		// Token: 0x04012F90 RID: 77712
		private static IntPtr __End3DUIScene_NativeFunctionPtr;

		// Token: 0x04012F91 RID: 77713
		private static IntPtr __Start3DUIScene_NativeFunctionPtr;

		// Token: 0x04012F92 RID: 77714
		private static IntPtr __UpdateLightShaft_NativeFunctionPtr;

		// Token: 0x04012F93 RID: 77715
		private static IntPtr __GetLightDirectionFromVH_NativeFunctionPtr;

		// Token: 0x04012F94 RID: 77716
		private static IntPtr __UpdatePostProcessVolume_NativeFunctionPtr;

		// Token: 0x04012F95 RID: 77717
		private static IntPtr __UpdateLightParameters_NativeFunctionPtr;

		// Token: 0x04012F96 RID: 77718
		private static IntPtr __Update_Main_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012F97 RID: 77719
		private static IntPtr __UpdateMainLight_NativeFunctionPtr;

		// Token: 0x04012F98 RID: 77720
		private static IntPtr __UpdateTime_NativeFunctionPtr;

		// Token: 0x04012F99 RID: 77721
		private static IntPtr __GetViewLocation_NativeFunctionPtr;

		// Token: 0x04012F9A RID: 77722
		private static IntPtr __InitFeature_NativeFunctionPtr;

		// Token: 0x04012F9B RID: 77723
		private static IntPtr __CalulateLightDirectionWithLimit_NativeFunctionPtr;

		// Token: 0x04012F9C RID: 77724
		private static IntPtr __CalculateLightDirection_NativeFunctionPtr;

		// Token: 0x04012F9D RID: 77725
		private static IntPtr __UpdateAtmosphere_NativeFunctionPtr;

		// Token: 0x04012F9E RID: 77726
		private static IntPtr __UpdateSkyLight_NativeFunctionPtr;

		// Token: 0x04012F9F RID: 77727
		private static IntPtr __Get_Scene_Light_Rotator_NativeFunctionPtr;

		// Token: 0x04012FA0 RID: 77728
		private static IntPtr __Get_Scene_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012FA1 RID: 77729
		private static IntPtr __InitGICompoemnt_NativeFunctionPtr;

		// Token: 0x04012FA2 RID: 77730
		private static IntPtr __Get_Light_Rotator_NativeFunctionPtr;

		// Token: 0x04012FA3 RID: 77731
		private static IntPtr __Get_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012FA4 RID: 77732
		private static IntPtr __InitMaterials_NativeFunctionPtr;

		// Token: 0x04012FA5 RID: 77733
		private static IntPtr __Is_Day_NativeFunctionPtr;

		// Token: 0x04012FA6 RID: 77734
		private static IntPtr __UpdateWind_NativeFunctionPtr;

		// Token: 0x04012FA7 RID: 77735
		private static IntPtr __UpdateLensFlares_NativeFunctionPtr;

		// Token: 0x04012FA8 RID: 77736
		private static IntPtr __Get2SkyboxLerpWeight_NativeFunctionPtr;

		// Token: 0x04012FA9 RID: 77737
		private static IntPtr __Update_Env_NativeFunctionPtr;

		// Token: 0x04012FAA RID: 77738
		private static IntPtr __UpdateFog_NativeFunctionPtr;

		// Token: 0x04012FAB RID: 77739
		private static IntPtr __UpdateGIData_NativeFunctionPtr;

		// Token: 0x04012FAC RID: 77740
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012FAD RID: 77741
		private static IntPtr __OnKuroStartUI_NativeFunctionPtr;

		// Token: 0x04012FAE RID: 77742
		private static IntPtr __OnKuroEndUI_NativeFunctionPtr;

		// Token: 0x04012FAF RID: 77743
		private static IntPtr __OnKuroInit_NativeFunctionPtr;

		// Token: 0x04012FB0 RID: 77744
		private static IntPtr __OnKuroTick_NativeFunctionPtr;

		// Token: 0x04012FB1 RID: 77745
		private static IntPtr __OnKuroTickEditor_NativeFunctionPtr;

		// Token: 0x04012FB2 RID: 77746
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012FB3 RID: 77747
		private static IntPtr __OnKuroRuntimeDestroy_NativeFunctionPtr;

		// Token: 0x04012FB4 RID: 77748
		private static IntPtr __OnKuroSetRuntimeTime_NativeFunctionPtr;

		// Token: 0x0200A055 RID: 41045
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __GetTODCharacterLighting_FunctionParams
		{
			// Token: 0x04031B2D RID: 203565
			[FieldOffset(0)]
			public FLinearColor mainLight;

			// Token: 0x04031B2E RID: 203566
			[FieldOffset(16)]
			public float mainLightIntensity;

			// Token: 0x04031B2F RID: 203567
			[FieldOffset(20)]
			public FLinearColor skyLight;

			// Token: 0x04031B30 RID: 203568
			[FieldOffset(36)]
			public float skyLightIntensity;

			// Token: 0x04031B31 RID: 203569
			[FieldOffset(40)]
			public FLinearColor FrontSideLight;

			// Token: 0x04031B32 RID: 203570
			[FieldOffset(56)]
			public FLinearColor BackSideLight;
		}

		// Token: 0x0200A056 RID: 41046
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 108)]
		protected ref struct __Clamp_Luminance_FunctionParams
		{
			// Token: 0x04031B33 RID: 203571
			[FieldOffset(0)]
			public FLinearColor InColor;

			// Token: 0x04031B34 RID: 203572
			[FieldOffset(16)]
			public float Min;

			// Token: 0x04031B35 RID: 203573
			[FieldOffset(20)]
			public float Max;

			// Token: 0x04031B36 RID: 203574
			[FieldOffset(24)]
			public FLinearColor __Result;
		}

		// Token: 0x0200A057 RID: 41047
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x04031B37 RID: 203575
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x04031B38 RID: 203576
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x04031B39 RID: 203577
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x0200A058 RID: 41048
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAuroraDMI_FunctionParams
		{
			// Token: 0x04031B3A RID: 203578
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x0200A059 RID: 41049
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetStarsDMI_FunctionParams
		{
			// Token: 0x04031B3B RID: 203579
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x0200A05A RID: 41050
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSkyboxDMI_FunctionParams
		{
			// Token: 0x04031B3C RID: 203580
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x0200A05B RID: 41051
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTrulyTime_FunctionParams
		{
			// Token: 0x04031B3D RID: 203581
			[FieldOffset(0)]
			public float CurTime;
		}

		// Token: 0x0200A05C RID: 41052
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 164)]
		protected ref struct __UpdateCloudCard_FunctionParams
		{
			// Token: 0x04031B3E RID: 203582
			[FieldOffset(0)]
			public byte CloudCardSetting;
		}

		// Token: 0x0200A05D RID: 41053
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Get_Total_TOD_Time_Elapsed_FunctionParams
		{
			// Token: 0x04031B3F RID: 203583
			[FieldOffset(0)]
			public float Time;
		}

		// Token: 0x0200A05E RID: 41054
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __Set_All_Components_States_FunctionParams
		{
			// Token: 0x04031B40 RID: 203584
			[FieldOffset(0)]
			public bool IsEnable;
		}

		// Token: 0x0200A05F RID: 41055
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetUIComponentsVisibility_FunctionParams
		{
			// Token: 0x04031B41 RID: 203585
			[FieldOffset(0)]
			public bool IsVisible;
		}

		// Token: 0x0200A060 RID: 41056
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Start3DUIScene_FunctionParams
		{
			// Token: 0x04031B42 RID: 203586
			[FieldOffset(0)]
			public IntPtr UIGIData;
		}

		// Token: 0x0200A061 RID: 41057
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetLightDirectionFromVH_FunctionParams
		{
			// Token: 0x04031B43 RID: 203587
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x04031B44 RID: 203588
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x04031B45 RID: 203589
			[FieldOffset(8)]
			public FRotator Result;
		}

		// Token: 0x0200A062 RID: 41058
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetViewLocation_FunctionParams
		{
			// Token: 0x04031B46 RID: 203590
			[FieldOffset(0)]
			public FVector WorldPosition;

			// Token: 0x04031B47 RID: 203591
			[FieldOffset(12)]
			public bool Suc;
		}

		// Token: 0x0200A063 RID: 41059
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __CalulateLightDirectionWithLimit_FunctionParams
		{
			// Token: 0x04031B48 RID: 203592
			[FieldOffset(0)]
			public float V;

			// Token: 0x04031B49 RID: 203593
			[FieldOffset(4)]
			public float H;

			// Token: 0x04031B4A RID: 203594
			[FieldOffset(8)]
			public float Time;

			// Token: 0x04031B4B RID: 203595
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x0200A064 RID: 41060
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __CalculateLightDirection_FunctionParams
		{
			// Token: 0x04031B4C RID: 203596
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x04031B4D RID: 203597
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x04031B4E RID: 203598
			[FieldOffset(8)]
			public float Time;

			// Token: 0x04031B4F RID: 203599
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x0200A065 RID: 41061
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Get_Scene_Light_Rotator_FunctionParams
		{
			// Token: 0x04031B50 RID: 203600
			[FieldOffset(0)]
			public FRotator SunLight;

			// Token: 0x04031B51 RID: 203601
			[FieldOffset(12)]
			public FRotator NightLight;
		}

		// Token: 0x0200A066 RID: 41062
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Get_Scene_Light_Direction_FunctionParams
		{
			// Token: 0x04031B52 RID: 203602
			[FieldOffset(0)]
			public FVector LightDir;
		}

		// Token: 0x0200A067 RID: 41063
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __Get_Light_Rotator_FunctionParams
		{
			// Token: 0x04031B53 RID: 203603
			[FieldOffset(0)]
			public FRotator SunLight;

			// Token: 0x04031B54 RID: 203604
			[FieldOffset(12)]
			public FRotator NightLight;
		}

		// Token: 0x0200A068 RID: 41064
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __Get_Light_Direction_FunctionParams
		{
			// Token: 0x04031B55 RID: 203605
			[FieldOffset(0)]
			public FVector SunLight;

			// Token: 0x04031B56 RID: 203606
			[FieldOffset(12)]
			public FVector NightLight;
		}

		// Token: 0x0200A069 RID: 41065
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Is_Day_FunctionParams
		{
			// Token: 0x04031B57 RID: 203607
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A06A RID: 41066
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __Get2SkyboxLerpWeight_FunctionParams
		{
			// Token: 0x04031B58 RID: 203608
			[FieldOffset(0)]
			public float startSetting;

			// Token: 0x04031B59 RID: 203609
			[FieldOffset(4)]
			public float EndSetting;

			// Token: 0x04031B5A RID: 203610
			[FieldOffset(8)]
			public float CurrentTime;

			// Token: 0x04031B5B RID: 203611
			[FieldOffset(12)]
			public float Weight;
		}

		// Token: 0x0200A06B RID: 41067
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __OnKuroStartUI_FunctionParams
		{
			// Token: 0x04031B5C RID: 203612
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x04031B5D RID: 203613
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}

		// Token: 0x0200A06C RID: 41068
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTick_FunctionParams
		{
			// Token: 0x04031B5E RID: 203614
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A06D RID: 41069
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTickEditor_FunctionParams
		{
			// Token: 0x04031B5F RID: 203615
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A06E RID: 41070
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroSetRuntimeTime_FunctionParams
		{
			// Token: 0x04031B60 RID: 203616
			[FieldOffset(0)]
			public float CurrentTime;
		}
	}
}
