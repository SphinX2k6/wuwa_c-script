using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints
{
	// Token: 0x02003A92 RID: 14994
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Sky.Ultra_Dynamic_Sky_C")]
	[UnrealStructLayout(2472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2469)]
	public class Ultra_Dynamic_Sky_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE91 RID: 130705 RVA: 0x008C5C26 File Offset: 0x008C3E26
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Ultra_Dynamic_Sky_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Sky.Ultra_Dynamic_Sky_C");
			}
			return Ultra_Dynamic_Sky_C._ClassPtr;
		}

		// Token: 0x0601FE92 RID: 130706 RVA: 0x008C5C4C File Offset: 0x008C3E4C
		public Ultra_Dynamic_Sky_C() : this(BuiltinUtils.AllocNativeUObject(Ultra_Dynamic_Sky_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE93 RID: 130707 RVA: 0x008C5C74 File Offset: 0x008C3E74
		[NullableContext(1)]
		public Ultra_Dynamic_Sky_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Ultra_Dynamic_Sky_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0601FE94 RID: 130708 RVA: 0x008C5CA7 File Offset: 0x008C3EA7
		// (set) Token: 0x0601FE95 RID: 130709 RVA: 0x008C5CBB File Offset: 0x008C3EBB
		public unsafe UNiagaraComponent Inside_Cloud_Fog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x0601FE96 RID: 130710 RVA: 0x008C5CD0 File Offset: 0x008C3ED0
		// (set) Token: 0x0601FE97 RID: 130711 RVA: 0x008C5CE4 File Offset: 0x008C3EE4
		public unsafe UVolumetricCloudComponent VolumetricAurora
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumetricCloudComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0601FE98 RID: 130712 RVA: 0x008C5CF9 File Offset: 0x008C3EF9
		// (set) Token: 0x0601FE99 RID: 130713 RVA: 0x008C5D0D File Offset: 0x008C3F0D
		public unsafe UStaticMeshComponent StaticCloudsSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0601FE9A RID: 130714 RVA: 0x008C5D22 File Offset: 0x008C3F22
		// (set) Token: 0x0601FE9B RID: 130715 RVA: 0x008C5D36 File Offset: 0x008C3F36
		public unsafe UBillboardComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0601FE9C RID: 130716 RVA: 0x008C5D4B File Offset: 0x008C3F4B
		// (set) Token: 0x0601FE9D RID: 130717 RVA: 0x008C5D5F File Offset: 0x008C3F5F
		public unsafe UVolumetricCloudComponent VolumetricCloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumetricCloudComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0601FE9E RID: 130718 RVA: 0x008C5D74 File Offset: 0x008C3F74
		// (set) Token: 0x0601FE9F RID: 130719 RVA: 0x008C5D88 File Offset: 0x008C3F88
		public unsafe USkyLightComponent CubeMap_Sky_Light
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0601FEA0 RID: 130720 RVA: 0x008C5D9D File Offset: 0x008C3F9D
		// (set) Token: 0x0601FEA1 RID: 130721 RVA: 0x008C5DB1 File Offset: 0x008C3FB1
		public unsafe USkyLightComponent Capture_Based_Sky_Light
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0601FEA2 RID: 130722 RVA: 0x008C5DC6 File Offset: 0x008C3FC6
		// (set) Token: 0x0601FEA3 RID: 130723 RVA: 0x008C5DDA File Offset: 0x008C3FDA
		public unsafe UPostProcessComponent Exposure
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0601FEA4 RID: 130724 RVA: 0x008C5DEF File Offset: 0x008C3FEF
		// (set) Token: 0x0601FEA5 RID: 130725 RVA: 0x008C5E03 File Offset: 0x008C4003
		public unsafe UExponentialHeightFogComponent HeightFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UExponentialHeightFogComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0601FEA6 RID: 130726 RVA: 0x008C5E18 File Offset: 0x008C4018
		// (set) Token: 0x0601FEA7 RID: 130727 RVA: 0x008C5E2C File Offset: 0x008C402C
		public unsafe UDirectionalLightComponent Moon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0601FEA8 RID: 130728 RVA: 0x008C5E41 File Offset: 0x008C4041
		// (set) Token: 0x0601FEA9 RID: 130729 RVA: 0x008C5E55 File Offset: 0x008C4055
		public unsafe UDirectionalLightComponent Sun
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x0601FEAA RID: 130730 RVA: 0x008C5E6A File Offset: 0x008C406A
		// (set) Token: 0x0601FEAB RID: 130731 RVA: 0x008C5E7E File Offset: 0x008C407E
		public unsafe UArrowComponent Moon_Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x0601FEAC RID: 130732 RVA: 0x008C5E93 File Offset: 0x008C4093
		// (set) Token: 0x0601FEAD RID: 130733 RVA: 0x008C5EA7 File Offset: 0x008C40A7
		public unsafe UArrowComponent Sun_Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x0601FEAE RID: 130734 RVA: 0x008C5EBC File Offset: 0x008C40BC
		// (set) Token: 0x0601FEAF RID: 130735 RVA: 0x008C5ED0 File Offset: 0x008C40D0
		public unsafe UStaticMeshComponent Ultra_Dynamic_Sky_Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0601FEB0 RID: 130736 RVA: 0x008C5EE5 File Offset: 0x008C40E5
		// (set) Token: 0x0601FEB1 RID: 130737 RVA: 0x008C5EF9 File Offset: 0x008C40F9
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_FeatureToggle> Sun_Light
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x0601FEB2 RID: 130738 RVA: 0x008C5F0E File Offset: 0x008C410E
		// (set) Token: 0x0601FEB3 RID: 130739 RVA: 0x008C5F22 File Offset: 0x008C4122
		public unsafe ADirectionalLight Custom_Sun_Light_Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADirectionalLight>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0601FEB4 RID: 130740 RVA: 0x008C5F37 File Offset: 0x008C4137
		// (set) Token: 0x0601FEB5 RID: 130741 RVA: 0x008C5F4B File Offset: 0x008C414B
		[Nullable(0)]
		public unsafe TEnumAsByte<EComponentMobility> Sun_Mobility
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_17);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x0601FEB6 RID: 130742 RVA: 0x008C5F60 File Offset: 0x008C4160
		// (set) Token: 0x0601FEB7 RID: 130743 RVA: 0x008C5F74 File Offset: 0x008C4174
		public unsafe UMaterialInstanceDynamic Sky_MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x0601FEB8 RID: 130744 RVA: 0x008C5F89 File Offset: 0x008C4189
		// (set) Token: 0x0601FEB9 RID: 130745 RVA: 0x008C5F99 File Offset: 0x008C4199
		public unsafe bool Refresh_Settings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0601FEBA RID: 130746 RVA: 0x008C5FAA File Offset: 0x008C41AA
		// (set) Token: 0x0601FEBB RID: 130747 RVA: 0x008C5FBA File Offset: 0x008C41BA
		public unsafe float Cloud_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0601FEBC RID: 130748 RVA: 0x008C5FCB File Offset: 0x008C41CB
		// (set) Token: 0x0601FEBD RID: 130749 RVA: 0x008C5FDB File Offset: 0x008C41DB
		public unsafe float Cloud_Wisps_Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0601FEBE RID: 130750 RVA: 0x008C5FEC File Offset: 0x008C41EC
		// (set) Token: 0x0601FEBF RID: 130751 RVA: 0x008C5FFC File Offset: 0x008C41FC
		public unsafe float Time_of_Day
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0601FEC0 RID: 130752 RVA: 0x008C600D File Offset: 0x008C420D
		// (set) Token: 0x0601FEC1 RID: 130753 RVA: 0x008C6021 File Offset: 0x008C4221
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_SkyMode> Sky_Mode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_23);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0601FEC2 RID: 130754 RVA: 0x008C6036 File Offset: 0x008C4236
		// (set) Token: 0x0601FEC3 RID: 130755 RVA: 0x008C6046 File Offset: 0x008C4246
		public unsafe float Cloud_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x0601FEC4 RID: 130756 RVA: 0x008C6057 File Offset: 0x008C4257
		// (set) Token: 0x0601FEC5 RID: 130757 RVA: 0x008C6067 File Offset: 0x008C4267
		public unsafe float Overall_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x0601FEC6 RID: 130758 RVA: 0x008C6078 File Offset: 0x008C4278
		// (set) Token: 0x0601FEC7 RID: 130759 RVA: 0x008C6088 File Offset: 0x008C4288
		public unsafe float Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0601FEC8 RID: 130760 RVA: 0x008C6099 File Offset: 0x008C4299
		// (set) Token: 0x0601FEC9 RID: 130761 RVA: 0x008C60A9 File Offset: 0x008C42A9
		public unsafe float Cloud_Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0601FECA RID: 130762 RVA: 0x008C60BA File Offset: 0x008C42BA
		// (set) Token: 0x0601FECB RID: 130763 RVA: 0x008C60CA File Offset: 0x008C42CA
		public unsafe float Cloud_Phase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0601FECC RID: 130764 RVA: 0x008C60DB File Offset: 0x008C42DB
		// (set) Token: 0x0601FECD RID: 130765 RVA: 0x008C60EB File Offset: 0x008C42EB
		public unsafe bool Moon_Casts_Shadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0601FECE RID: 130766 RVA: 0x008C60FC File Offset: 0x008C42FC
		// (set) Token: 0x0601FECF RID: 130767 RVA: 0x008C610C File Offset: 0x008C430C
		public unsafe float Moon_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0601FED0 RID: 130768 RVA: 0x008C611D File Offset: 0x008C431D
		// (set) Token: 0x0601FED1 RID: 130769 RVA: 0x008C612D File Offset: 0x008C432D
		public unsafe float Moon_Inclination
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0601FED2 RID: 130770 RVA: 0x008C613E File Offset: 0x008C433E
		// (set) Token: 0x0601FED3 RID: 130771 RVA: 0x008C614E File Offset: 0x008C434E
		public unsafe float Moon_Phase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0601FED4 RID: 130772 RVA: 0x008C615F File Offset: 0x008C435F
		// (set) Token: 0x0601FED5 RID: 130773 RVA: 0x008C616F File Offset: 0x008C436F
		public unsafe bool Automatically_Set_Advanced_Legacy_Settings_using_Time_of_Day
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0601FED6 RID: 130774 RVA: 0x008C6180 File Offset: 0x008C4380
		// (set) Token: 0x0601FED7 RID: 130775 RVA: 0x008C6190 File Offset: 0x008C4390
		public unsafe float Stars_Visibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0601FED8 RID: 130776 RVA: 0x008C61A1 File Offset: 0x008C43A1
		// (set) Token: 0x0601FED9 RID: 130777 RVA: 0x008C61B1 File Offset: 0x008C43B1
		public unsafe bool Change_Moon_Phase_Once_a_Day
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0601FEDA RID: 130778 RVA: 0x008C61C2 File Offset: 0x008C43C2
		// (set) Token: 0x0601FEDB RID: 130779 RVA: 0x008C61D2 File Offset: 0x008C43D2
		public unsafe float Moon_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0601FEDC RID: 130780 RVA: 0x008C61E3 File Offset: 0x008C43E3
		// (set) Token: 0x0601FEDD RID: 130781 RVA: 0x008C61F3 File Offset: 0x008C43F3
		public unsafe float Moon_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0601FEDE RID: 130782 RVA: 0x008C6204 File Offset: 0x008C4404
		// (set) Token: 0x0601FEDF RID: 130783 RVA: 0x008C6214 File Offset: 0x008C4414
		public unsafe float Sun_Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0601FEE0 RID: 130784 RVA: 0x008C6225 File Offset: 0x008C4425
		// (set) Token: 0x0601FEE1 RID: 130785 RVA: 0x008C6239 File Offset: 0x008C4439
		public unsafe FLinearColor Horizon_Base_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0601FEE2 RID: 130786 RVA: 0x008C624E File Offset: 0x008C444E
		// (set) Token: 0x0601FEE3 RID: 130787 RVA: 0x008C6262 File Offset: 0x008C4462
		public unsafe FLinearColor Zenith_Base_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0601FEE4 RID: 130788 RVA: 0x008C6277 File Offset: 0x008C4477
		// (set) Token: 0x0601FEE5 RID: 130789 RVA: 0x008C628B File Offset: 0x008C448B
		public unsafe FLinearColor Cloud_Light_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0601FEE6 RID: 130790 RVA: 0x008C62A0 File Offset: 0x008C44A0
		// (set) Token: 0x0601FEE7 RID: 130791 RVA: 0x008C62B4 File Offset: 0x008C44B4
		public unsafe FLinearColor Cloud_Dark_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0601FEE8 RID: 130792 RVA: 0x008C62C9 File Offset: 0x008C44C9
		// (set) Token: 0x0601FEE9 RID: 130793 RVA: 0x008C62DD File Offset: 0x008C44DD
		public unsafe FLinearColor Sun_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0601FEEA RID: 130794 RVA: 0x008C62F2 File Offset: 0x008C44F2
		// (set) Token: 0x0601FEEB RID: 130795 RVA: 0x008C6302 File Offset: 0x008C4502
		public unsafe float Cloud_Shine_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0601FEEC RID: 130796 RVA: 0x008C6313 File Offset: 0x008C4513
		// (set) Token: 0x0601FEED RID: 130797 RVA: 0x008C6327 File Offset: 0x008C4527
		public unsafe FLinearColor Sun_Light_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0601FEEE RID: 130798 RVA: 0x008C633C File Offset: 0x008C453C
		// (set) Token: 0x0601FEEF RID: 130799 RVA: 0x008C634C File Offset: 0x008C454C
		public unsafe bool Animate_Time_of_Day
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0601FEF0 RID: 130800 RVA: 0x008C635D File Offset: 0x008C455D
		// (set) Token: 0x0601FEF1 RID: 130801 RVA: 0x008C636D File Offset: 0x008C456D
		public unsafe float Day_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0601FEF2 RID: 130802 RVA: 0x008C637E File Offset: 0x008C457E
		// (set) Token: 0x0601FEF3 RID: 130803 RVA: 0x008C638E File Offset: 0x008C458E
		public unsafe float Night_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0601FEF4 RID: 130804 RVA: 0x008C639F File Offset: 0x008C459F
		// (set) Token: 0x0601FEF5 RID: 130805 RVA: 0x008C63AF File Offset: 0x008C45AF
		public unsafe float Cloud_Density_target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0601FEF6 RID: 130806 RVA: 0x008C63C0 File Offset: 0x008C45C0
		// (set) Token: 0x0601FEF7 RID: 130807 RVA: 0x008C63D0 File Offset: 0x008C45D0
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0601FEF8 RID: 130808 RVA: 0x008C63E1 File Offset: 0x008C45E1
		// (set) Token: 0x0601FEF9 RID: 130809 RVA: 0x008C63F1 File Offset: 0x008C45F1
		public unsafe bool Sun_Casts_Shadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0601FEFA RID: 130810 RVA: 0x008C6402 File Offset: 0x008C4602
		// (set) Token: 0x0601FEFB RID: 130811 RVA: 0x008C6412 File Offset: 0x008C4612
		public unsafe float Sun_Disk_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0601FEFC RID: 130812 RVA: 0x008C6423 File Offset: 0x008C4623
		// (set) Token: 0x0601FEFD RID: 130813 RVA: 0x008C6433 File Offset: 0x008C4633
		public unsafe float Sun_Shader_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0601FEFE RID: 130814 RVA: 0x008C6444 File Offset: 0x008C4644
		// (set) Token: 0x0601FEFF RID: 130815 RVA: 0x008C6458 File Offset: 0x008C4658
		public unsafe FLinearColor Moon_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0601FF00 RID: 130816 RVA: 0x008C646D File Offset: 0x008C466D
		// (set) Token: 0x0601FF01 RID: 130817 RVA: 0x008C647D File Offset: 0x008C467D
		public unsafe float Soften_Cloud_Layer_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0601FF02 RID: 130818 RVA: 0x008C648E File Offset: 0x008C468E
		// (set) Token: 0x0601FF03 RID: 130819 RVA: 0x008C649E File Offset: 0x008C469E
		public unsafe float Soften_Cloud_Layer_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0601FF04 RID: 130820 RVA: 0x008C64AF File Offset: 0x008C46AF
		// (set) Token: 0x0601FF05 RID: 130821 RVA: 0x008C64BF File Offset: 0x008C46BF
		public unsafe float Sharpen_Outer_Edge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0601FF06 RID: 130822 RVA: 0x008C64D0 File Offset: 0x008C46D0
		// (set) Token: 0x0601FF07 RID: 130823 RVA: 0x008C64E0 File Offset: 0x008C46E0
		public unsafe float Sun_Highlight_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0601FF08 RID: 130824 RVA: 0x008C64F1 File Offset: 0x008C46F1
		// (set) Token: 0x0601FF09 RID: 130825 RVA: 0x008C6501 File Offset: 0x008C4701
		public unsafe float Stars_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0601FF0A RID: 130826 RVA: 0x008C6512 File Offset: 0x008C4712
		// (set) Token: 0x0601FF0B RID: 130827 RVA: 0x008C6526 File Offset: 0x008C4726
		public unsafe FLinearColor Stars_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0601FF0C RID: 130828 RVA: 0x008C653B File Offset: 0x008C473B
		// (set) Token: 0x0601FF0D RID: 130829 RVA: 0x008C654B File Offset: 0x008C474B
		public unsafe float Moon_Orbit_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0601FF0E RID: 130830 RVA: 0x008C655C File Offset: 0x008C475C
		// (set) Token: 0x0601FF0F RID: 130831 RVA: 0x008C656C File Offset: 0x008C476C
		public unsafe bool Automatically_Set_Sun_Light_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_62) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_62) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0601FF10 RID: 130832 RVA: 0x008C657D File Offset: 0x008C477D
		// (set) Token: 0x0601FF11 RID: 130833 RVA: 0x008C6591 File Offset: 0x008C4791
		public unsafe FRotator Sun_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0601FF12 RID: 130834 RVA: 0x008C65A6 File Offset: 0x008C47A6
		// (set) Token: 0x0601FF13 RID: 130835 RVA: 0x008C65B6 File Offset: 0x008C47B6
		public unsafe float Sun_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0601FF14 RID: 130836 RVA: 0x008C65C7 File Offset: 0x008C47C7
		// (set) Token: 0x0601FF15 RID: 130837 RVA: 0x008C65DB File Offset: 0x008C47DB
		public unsafe UMaterialInstanceDynamic Sun_Cloud_Shadows_MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0601FF16 RID: 130838 RVA: 0x008C65F0 File Offset: 0x008C47F0
		// (set) Token: 0x0601FF17 RID: 130839 RVA: 0x008C6600 File Offset: 0x008C4800
		public unsafe bool Use_Cloud_Shadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_66) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_66) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0601FF18 RID: 130840 RVA: 0x008C6611 File Offset: 0x008C4811
		// (set) Token: 0x0601FF19 RID: 130841 RVA: 0x008C6621 File Offset: 0x008C4821
		public unsafe float Cloud_Shadows_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0601FF1A RID: 130842 RVA: 0x008C6632 File Offset: 0x008C4832
		// (set) Token: 0x0601FF1B RID: 130843 RVA: 0x008C6642 File Offset: 0x008C4842
		public unsafe float Cloud_Shadows_Intensity_When_Sunny
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0601FF1C RID: 130844 RVA: 0x008C6653 File Offset: 0x008C4853
		// (set) Token: 0x0601FF1D RID: 130845 RVA: 0x008C6667 File Offset: 0x008C4867
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_FeatureToggle> Moon_Light
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_69);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0601FF1E RID: 130846 RVA: 0x008C667C File Offset: 0x008C487C
		// (set) Token: 0x0601FF1F RID: 130847 RVA: 0x008C6690 File Offset: 0x008C4890
		public unsafe ADirectionalLight Custom_Moon_Light_Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADirectionalLight>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_70);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_70, value);
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0601FF20 RID: 130848 RVA: 0x008C66A5 File Offset: 0x008C48A5
		// (set) Token: 0x0601FF21 RID: 130849 RVA: 0x008C66B5 File Offset: 0x008C48B5
		public unsafe bool Manually_Select_Sun_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_71) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_71) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0601FF22 RID: 130850 RVA: 0x008C66C6 File Offset: 0x008C48C6
		// (set) Token: 0x0601FF23 RID: 130851 RVA: 0x008C66D6 File Offset: 0x008C48D6
		public unsafe bool Automatically_Set_Moon_Light_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_72) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_72) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0601FF24 RID: 130852 RVA: 0x008C66E7 File Offset: 0x008C48E7
		// (set) Token: 0x0601FF25 RID: 130853 RVA: 0x008C66F7 File Offset: 0x008C48F7
		public unsafe float Moonlight_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0601FF26 RID: 130854 RVA: 0x008C6708 File Offset: 0x008C4908
		// (set) Token: 0x0601FF27 RID: 130855 RVA: 0x008C6718 File Offset: 0x008C4918
		public unsafe float Stars_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0601FF28 RID: 130856 RVA: 0x008C6729 File Offset: 0x008C4929
		// (set) Token: 0x0601FF29 RID: 130857 RVA: 0x008C6739 File Offset: 0x008C4939
		public unsafe float Sun_Inclination
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0601FF2A RID: 130858 RVA: 0x008C674A File Offset: 0x008C494A
		// (set) Token: 0x0601FF2B RID: 130859 RVA: 0x008C675E File Offset: 0x008C495E
		public unsafe UMaterialInstanceDynamic Moon_Cloud_Shadows_MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_76);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_76, value);
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0601FF2C RID: 130860 RVA: 0x008C6773 File Offset: 0x008C4973
		// (set) Token: 0x0601FF2D RID: 130861 RVA: 0x008C6783 File Offset: 0x008C4983
		public unsafe float Sun_Yaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0601FF2E RID: 130862 RVA: 0x008C6794 File Offset: 0x008C4994
		// (set) Token: 0x0601FF2F RID: 130863 RVA: 0x008C67A4 File Offset: 0x008C49A4
		public unsafe float Moon_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0601FF30 RID: 130864 RVA: 0x008C67B5 File Offset: 0x008C49B5
		// (set) Token: 0x0601FF31 RID: 130865 RVA: 0x008C67C9 File Offset: 0x008C49C9
		public unsafe UTexture2D Custom_Moon_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_79);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_79, value);
			}
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0601FF32 RID: 130866 RVA: 0x008C67DE File Offset: 0x008C49DE
		// (set) Token: 0x0601FF33 RID: 130867 RVA: 0x008C67EE File Offset: 0x008C49EE
		public unsafe bool Use_Custom_Moon_Texture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_80) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_80) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0601FF34 RID: 130868 RVA: 0x008C67FF File Offset: 0x008C49FF
		// (set) Token: 0x0601FF35 RID: 130869 RVA: 0x008C6813 File Offset: 0x008C4A13
		[Nullable(0)]
		public unsafe TEnumAsByte<EComponentMobility> Moon_Mobility
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_81);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_81) = value;
			}
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0601FF36 RID: 130870 RVA: 0x008C6828 File Offset: 0x008C4A28
		// (set) Token: 0x0601FF37 RID: 130871 RVA: 0x008C683C File Offset: 0x008C4A3C
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_FeatureToggle> Sky_Light
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_82);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_82) = value;
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0601FF38 RID: 130872 RVA: 0x008C6851 File Offset: 0x008C4A51
		// (set) Token: 0x0601FF39 RID: 130873 RVA: 0x008C6865 File Offset: 0x008C4A65
		public unsafe ASkyLight Custom_Sky_Light_Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkyLight>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_83);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_83, value);
			}
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0601FF3A RID: 130874 RVA: 0x008C687A File Offset: 0x008C4A7A
		// (set) Token: 0x0601FF3B RID: 130875 RVA: 0x008C688E File Offset: 0x008C4A8E
		[Nullable(0)]
		public unsafe TEnumAsByte<EComponentMobility> Sky_Light_Mobility
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_84);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0601FF3C RID: 130876 RVA: 0x008C68A3 File Offset: 0x008C4AA3
		// (set) Token: 0x0601FF3D RID: 130877 RVA: 0x008C68B7 File Offset: 0x008C4AB7
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_FeatureToggle> Height_Fog
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_85);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0601FF3E RID: 130878 RVA: 0x008C68CC File Offset: 0x008C4ACC
		// (set) Token: 0x0601FF3F RID: 130879 RVA: 0x008C68E0 File Offset: 0x008C4AE0
		public unsafe AExponentialHeightFog Custom_Height_Fog_Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AExponentialHeightFog>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_86);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_86, value);
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0601FF40 RID: 130880 RVA: 0x008C68F5 File Offset: 0x008C4AF5
		// (set) Token: 0x0601FF41 RID: 130881 RVA: 0x008C6909 File Offset: 0x008C4B09
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_SkyLightMode> Sky_Light_Mode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_87);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_87) = value;
			}
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0601FF42 RID: 130882 RVA: 0x008C691E File Offset: 0x008C4B1E
		// (set) Token: 0x0601FF43 RID: 130883 RVA: 0x008C6932 File Offset: 0x008C4B32
		public unsafe UCurveFloat Night_Filter_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_88);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_88, value);
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0601FF44 RID: 130884 RVA: 0x008C6947 File Offset: 0x008C4B47
		// (set) Token: 0x0601FF45 RID: 130885 RVA: 0x008C6957 File Offset: 0x008C4B57
		public unsafe float Moon_Glow_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_89);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_89) = value;
			}
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0601FF46 RID: 130886 RVA: 0x008C6968 File Offset: 0x008C4B68
		// (set) Token: 0x0601FF47 RID: 130887 RVA: 0x008C6978 File Offset: 0x008C4B78
		public unsafe float Sun_Light_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_90);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_90) = value;
			}
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0601FF48 RID: 130888 RVA: 0x008C6989 File Offset: 0x008C4B89
		// (set) Token: 0x0601FF49 RID: 130889 RVA: 0x008C6999 File Offset: 0x008C4B99
		public unsafe bool Use_Auroras
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_91) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_91) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0601FF4A RID: 130890 RVA: 0x008C69AA File Offset: 0x008C4BAA
		// (set) Token: 0x0601FF4B RID: 130891 RVA: 0x008C69BA File Offset: 0x008C4BBA
		public unsafe float Aurora_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0601FF4C RID: 130892 RVA: 0x008C69CB File Offset: 0x008C4BCB
		// (set) Token: 0x0601FF4D RID: 130893 RVA: 0x008C69DB File Offset: 0x008C4BDB
		public unsafe float Aurora_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0601FF4E RID: 130894 RVA: 0x008C69EC File Offset: 0x008C4BEC
		// (set) Token: 0x0601FF4F RID: 130895 RVA: 0x008C69FC File Offset: 0x008C4BFC
		public unsafe float Cloud_Shadows_Intensity_When_Overcast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0601FF50 RID: 130896 RVA: 0x008C6A0D File Offset: 0x008C4C0D
		// (set) Token: 0x0601FF51 RID: 130897 RVA: 0x008C6A1D File Offset: 0x008C4C1D
		public unsafe float Cloud_Shadows_Softness_When_Sunny
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0601FF52 RID: 130898 RVA: 0x008C6A2E File Offset: 0x008C4C2E
		// (set) Token: 0x0601FF53 RID: 130899 RVA: 0x008C6A3E File Offset: 0x008C4C3E
		public unsafe float Cloud_Shadows_Softness_When_Overcast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0601FF54 RID: 130900 RVA: 0x008C6A4F File Offset: 0x008C4C4F
		// (set) Token: 0x0601FF55 RID: 130901 RVA: 0x008C6A5F File Offset: 0x008C4C5F
		public unsafe float Cloud_Tiling_Layer_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_97);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_97) = value;
			}
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0601FF56 RID: 130902 RVA: 0x008C6A70 File Offset: 0x008C4C70
		// (set) Token: 0x0601FF57 RID: 130903 RVA: 0x008C6A80 File Offset: 0x008C4C80
		public unsafe float Cloud_Tiling_Layer_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_98);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_98) = value;
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0601FF58 RID: 130904 RVA: 0x008C6A91 File Offset: 0x008C4C91
		// (set) Token: 0x0601FF59 RID: 130905 RVA: 0x008C6AA1 File Offset: 0x008C4CA1
		public unsafe bool One_Cloud_Layer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_99) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_99) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0601FF5A RID: 130906 RVA: 0x008C6AB2 File Offset: 0x008C4CB2
		// (set) Token: 0x0601FF5B RID: 130907 RVA: 0x008C6AC2 File Offset: 0x008C4CC2
		public unsafe float Cloud_Height_Layer_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0601FF5C RID: 130908 RVA: 0x008C6AD3 File Offset: 0x008C4CD3
		// (set) Token: 0x0601FF5D RID: 130909 RVA: 0x008C6AE3 File Offset: 0x008C4CE3
		public unsafe float Cloud_Height_Layer_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0601FF5E RID: 130910 RVA: 0x008C6AF4 File Offset: 0x008C4CF4
		// (set) Token: 0x0601FF5F RID: 130911 RVA: 0x008C6B04 File Offset: 0x008C4D04
		public unsafe float Overcast_Swirling_Texture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0601FF60 RID: 130912 RVA: 0x008C6B15 File Offset: 0x008C4D15
		// (set) Token: 0x0601FF61 RID: 130913 RVA: 0x008C6B25 File Offset: 0x008C4D25
		public unsafe float Dawn_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_103);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0601FF62 RID: 130914 RVA: 0x008C6B36 File Offset: 0x008C4D36
		// (set) Token: 0x0601FF63 RID: 130915 RVA: 0x008C6B46 File Offset: 0x008C4D46
		public unsafe float Dusk_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0601FF64 RID: 130916 RVA: 0x008C6B57 File Offset: 0x008C4D57
		// (set) Token: 0x0601FF65 RID: 130917 RVA: 0x008C6B67 File Offset: 0x008C4D67
		public unsafe float Night_brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_105);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_105) = value;
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0601FF66 RID: 130918 RVA: 0x008C6B78 File Offset: 0x008C4D78
		// (set) Token: 0x0601FF67 RID: 130919 RVA: 0x008C6B88 File Offset: 0x008C4D88
		public unsafe float Moon_Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_106);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_106) = value;
			}
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0601FF68 RID: 130920 RVA: 0x008C6B99 File Offset: 0x008C4D99
		// (set) Token: 0x0601FF69 RID: 130921 RVA: 0x008C6BA9 File Offset: 0x008C4DA9
		public unsafe float Sun_Volumetric_Scattering_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_107);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_107) = value;
			}
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0601FF6A RID: 130922 RVA: 0x008C6BBA File Offset: 0x008C4DBA
		// (set) Token: 0x0601FF6B RID: 130923 RVA: 0x008C6BCA File Offset: 0x008C4DCA
		public unsafe float Moon_Volumetric_Scattering_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_108);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_108) = value;
			}
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0601FF6C RID: 130924 RVA: 0x008C6BDB File Offset: 0x008C4DDB
		// (set) Token: 0x0601FF6D RID: 130925 RVA: 0x008C6BEB File Offset: 0x008C4DEB
		public unsafe float Aurora_Phase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_109);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_109) = value;
			}
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0601FF6E RID: 130926 RVA: 0x008C6BFC File Offset: 0x008C4DFC
		// (set) Token: 0x0601FF6F RID: 130927 RVA: 0x008C6C10 File Offset: 0x008C4E10
		[Nullable(1)]
		public unsafe string Readme
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_110)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_110)), value);
			}
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0601FF70 RID: 130928 RVA: 0x008C6C25 File Offset: 0x008C4E25
		// (set) Token: 0x0601FF71 RID: 130929 RVA: 0x008C6C39 File Offset: 0x008C4E39
		public unsafe ULightComponent Sun_LightComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_111);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_111, value);
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0601FF72 RID: 130930 RVA: 0x008C6C4E File Offset: 0x008C4E4E
		// (set) Token: 0x0601FF73 RID: 130931 RVA: 0x008C6C62 File Offset: 0x008C4E62
		public unsafe ULightComponent Moon_LightComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_112);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_112, value);
			}
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0601FF74 RID: 130932 RVA: 0x008C6C77 File Offset: 0x008C4E77
		// (set) Token: 0x0601FF75 RID: 130933 RVA: 0x008C6C8B File Offset: 0x008C4E8B
		public unsafe USkyLightComponent SkyLightComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_113);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_113, value);
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0601FF76 RID: 130934 RVA: 0x008C6CA0 File Offset: 0x008C4EA0
		// (set) Token: 0x0601FF77 RID: 130935 RVA: 0x008C6CB4 File Offset: 0x008C4EB4
		public unsafe UExponentialHeightFogComponent Height_Fog_Component
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UExponentialHeightFogComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_114);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_114, value);
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0601FF78 RID: 130936 RVA: 0x008C6CC9 File Offset: 0x008C4EC9
		// (set) Token: 0x0601FF79 RID: 130937 RVA: 0x008C6CD9 File Offset: 0x008C4ED9
		public unsafe bool Use_Exposure_Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_115) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_115) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0601FF7A RID: 130938 RVA: 0x008C6CEA File Offset: 0x008C4EEA
		// (set) Token: 0x0601FF7B RID: 130939 RVA: 0x008C6CFA File Offset: 0x008C4EFA
		public unsafe float Exposure_Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_116);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_116) = value;
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0601FF7C RID: 130940 RVA: 0x008C6D0B File Offset: 0x008C4F0B
		// (set) Token: 0x0601FF7D RID: 130941 RVA: 0x008C6D1B File Offset: 0x008C4F1B
		public unsafe float Exposure_Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_117);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_117) = value;
			}
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0601FF7E RID: 130942 RVA: 0x008C6D2C File Offset: 0x008C4F2C
		// (set) Token: 0x0601FF7F RID: 130943 RVA: 0x008C6D3C File Offset: 0x008C4F3C
		public unsafe float TimeRandomOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_118);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_118) = value;
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0601FF80 RID: 130944 RVA: 0x008C6D4D File Offset: 0x008C4F4D
		// (set) Token: 0x0601FF81 RID: 130945 RVA: 0x008C6D5D File Offset: 0x008C4F5D
		public unsafe float Extend_Dawn_and_Dusk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_119);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_119) = value;
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0601FF82 RID: 130946 RVA: 0x008C6D6E File Offset: 0x008C4F6E
		// (set) Token: 0x0601FF83 RID: 130947 RVA: 0x008C6D7E File Offset: 0x008C4F7E
		public unsafe bool Move_Static_Stationary_Lights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_120) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_120) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0601FF84 RID: 130948 RVA: 0x008C6D8F File Offset: 0x008C4F8F
		// (set) Token: 0x0601FF85 RID: 130949 RVA: 0x008C6D9F File Offset: 0x008C4F9F
		public unsafe float Fog_Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_121);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_121) = value;
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0601FF86 RID: 130950 RVA: 0x008C6DB0 File Offset: 0x008C4FB0
		// (set) Token: 0x0601FF87 RID: 130951 RVA: 0x008C6DC4 File Offset: 0x008C4FC4
		public unsafe UCurveLinearColor Fog_Inscattering_Color_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_122);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_122, value);
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0601FF88 RID: 130952 RVA: 0x008C6DD9 File Offset: 0x008C4FD9
		// (set) Token: 0x0601FF89 RID: 130953 RVA: 0x008C6DED File Offset: 0x008C4FED
		public unsafe UCurveLinearColor Fog_Directional_Inscattering_Color_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_123);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_123, value);
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0601FF8A RID: 130954 RVA: 0x008C6E02 File Offset: 0x008C5002
		// (set) Token: 0x0601FF8B RID: 130955 RVA: 0x008C6E12 File Offset: 0x008C5012
		public unsafe float Stars_Tiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_124);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_124) = value;
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0601FF8C RID: 130956 RVA: 0x008C6E23 File Offset: 0x008C5023
		// (set) Token: 0x0601FF8D RID: 130957 RVA: 0x008C6E37 File Offset: 0x008C5037
		public unsafe UTexture2D Stars_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_125);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_125, value);
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0601FF8E RID: 130958 RVA: 0x008C6E4C File Offset: 0x008C504C
		// (set) Token: 0x0601FF8F RID: 130959 RVA: 0x008C6E5C File Offset: 0x008C505C
		public unsafe float Night_Sky_Glow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_126);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_126) = value;
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0601FF90 RID: 130960 RVA: 0x008C6E6D File Offset: 0x008C506D
		// (set) Token: 0x0601FF91 RID: 130961 RVA: 0x008C6E81 File Offset: 0x008C5081
		public unsafe FLinearColor Night_Sky_Glow_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_127);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_127) = value;
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0601FF92 RID: 130962 RVA: 0x008C6E96 File Offset: 0x008C5096
		// (set) Token: 0x0601FF93 RID: 130963 RVA: 0x008C6EA6 File Offset: 0x008C50A6
		public unsafe float Stars_Phase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_128);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_128) = value;
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0601FF94 RID: 130964 RVA: 0x008C6EB7 File Offset: 0x008C50B7
		// (set) Token: 0x0601FF95 RID: 130965 RVA: 0x008C6ECB File Offset: 0x008C50CB
		public unsafe UCurveFloat Stars_Intensity_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_129);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_129, value);
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0601FF96 RID: 130966 RVA: 0x008C6EE0 File Offset: 0x008C50E0
		// (set) Token: 0x0601FF97 RID: 130967 RVA: 0x008C6EF0 File Offset: 0x008C50F0
		public unsafe float Sky_Light_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_130);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_130) = value;
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0601FF98 RID: 130968 RVA: 0x008C6F01 File Offset: 0x008C5101
		// (set) Token: 0x0601FF99 RID: 130969 RVA: 0x008C6F15 File Offset: 0x008C5115
		public unsafe UTextureCube Flat_Sunny_Cubemap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_131);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_131, value);
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0601FF9A RID: 130970 RVA: 0x008C6F2A File Offset: 0x008C512A
		// (set) Token: 0x0601FF9B RID: 130971 RVA: 0x008C6F3E File Offset: 0x008C513E
		public unsafe UTextureCube Flat_Overcast_Cubemap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_132);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_132, value);
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0601FF9C RID: 130972 RVA: 0x008C6F53 File Offset: 0x008C5153
		// (set) Token: 0x0601FF9D RID: 130973 RVA: 0x008C6F67 File Offset: 0x008C5167
		public unsafe UCurveLinearColor Sky_Light_Dynamic_Tinting_Color_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_133);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_133, value);
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0601FF9E RID: 130974 RVA: 0x008C6F7C File Offset: 0x008C517C
		// (set) Token: 0x0601FF9F RID: 130975 RVA: 0x008C6F90 File Offset: 0x008C5190
		public unsafe UTextureCube Custom_Cubemap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_134);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_134, value);
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0601FFA0 RID: 130976 RVA: 0x008C6FA5 File Offset: 0x008C51A5
		// (set) Token: 0x0601FFA1 RID: 130977 RVA: 0x008C6FB9 File Offset: 0x008C51B9
		public unsafe FLinearColor Sky_Light_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_135);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_135) = value;
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0601FFA2 RID: 130978 RVA: 0x008C6FCE File Offset: 0x008C51CE
		// (set) Token: 0x0601FFA3 RID: 130979 RVA: 0x008C6FE2 File Offset: 0x008C51E2
		public unsafe FLinearColor Sky_Light_Lower_Hemisphere_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_136);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_136) = value;
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0601FFA4 RID: 130980 RVA: 0x008C6FF7 File Offset: 0x008C51F7
		// (set) Token: 0x0601FFA5 RID: 130981 RVA: 0x008C7007 File Offset: 0x008C5207
		public unsafe bool Recapture_Sky_light_Periodically
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_137) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_137) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0601FFA6 RID: 130982 RVA: 0x008C7018 File Offset: 0x008C5218
		// (set) Token: 0x0601FFA7 RID: 130983 RVA: 0x008C7028 File Offset: 0x008C5228
		public unsafe float Sky_Light_Recapture_Period__Seconds_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_138);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_138) = value;
			}
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0601FFA8 RID: 130984 RVA: 0x008C7039 File Offset: 0x008C5239
		// (set) Token: 0x0601FFA9 RID: 130985 RVA: 0x008C7049 File Offset: 0x008C5249
		public unsafe float Sunrise_Event_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_139);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_139) = value;
			}
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0601FFAA RID: 130986 RVA: 0x008C705A File Offset: 0x008C525A
		// (set) Token: 0x0601FFAB RID: 130987 RVA: 0x008C706A File Offset: 0x008C526A
		public unsafe float Sunset_Event_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_140);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_140) = value;
			}
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0601FFAC RID: 130988 RVA: 0x008C707C File Offset: 0x008C527C
		// (set) Token: 0x0601FFAD RID: 130989 RVA: 0x008C70B5 File Offset: 0x008C52B5
		[Nullable(1)]
		public Sunset Sunset
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				Sunset result;
				if ((result = this._Sunset) == null)
				{
					result = (this._Sunset = new Sunset(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_141, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_141, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0601FFAE RID: 130990 RVA: 0x008C70D8 File Offset: 0x008C52D8
		// (set) Token: 0x0601FFAF RID: 130991 RVA: 0x008C7111 File Offset: 0x008C5311
		[Nullable(1)]
		public Sunrise Sunrise
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				Sunrise result;
				if ((result = this._Sunrise) == null)
				{
					result = (this._Sunrise = new Sunrise(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_142, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_142, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0601FFB0 RID: 130992 RVA: 0x008C7132 File Offset: 0x008C5332
		// (set) Token: 0x0601FFB1 RID: 130993 RVA: 0x008C7142 File Offset: 0x008C5342
		public unsafe bool Use_Fog_Density_Curve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_143) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_143) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0601FFB2 RID: 130994 RVA: 0x008C7153 File Offset: 0x008C5353
		// (set) Token: 0x0601FFB3 RID: 130995 RVA: 0x008C7167 File Offset: 0x008C5367
		public unsafe UCurveFloat Fog_Density_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_144);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_144, value);
			}
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0601FFB4 RID: 130996 RVA: 0x008C717C File Offset: 0x008C537C
		// (set) Token: 0x0601FFB5 RID: 130997 RVA: 0x008C718C File Offset: 0x008C538C
		public unsafe float Internal_Time_of_Day
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_145);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_145) = value;
			}
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0601FFB6 RID: 130998 RVA: 0x008C719D File Offset: 0x008C539D
		// (set) Token: 0x0601FFB7 RID: 130999 RVA: 0x008C71AD File Offset: 0x008C53AD
		public unsafe float Horizon_Density_Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_146);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_146) = value;
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0601FFB8 RID: 131000 RVA: 0x008C71BE File Offset: 0x008C53BE
		// (set) Token: 0x0601FFB9 RID: 131001 RVA: 0x008C71CE File Offset: 0x008C53CE
		public unsafe float Zenith_Density_Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_147);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_147) = value;
			}
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0601FFBA RID: 131002 RVA: 0x008C71DF File Offset: 0x008C53DF
		// (set) Token: 0x0601FFBB RID: 131003 RVA: 0x008C71EF File Offset: 0x008C53EF
		public unsafe float Latitude_Gradient_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_148);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_148) = value;
			}
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0601FFBC RID: 131004 RVA: 0x008C7200 File Offset: 0x008C5400
		// (set) Token: 0x0601FFBD RID: 131005 RVA: 0x008C7210 File Offset: 0x008C5410
		public unsafe float Latitude_Gradient_Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_149);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_149) = value;
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0601FFBE RID: 131006 RVA: 0x008C7221 File Offset: 0x008C5421
		// (set) Token: 0x0601FFBF RID: 131007 RVA: 0x008C7231 File Offset: 0x008C5431
		public unsafe float Around_Sun_Density_Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_150);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_150) = value;
			}
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0601FFC0 RID: 131008 RVA: 0x008C7242 File Offset: 0x008C5442
		// (set) Token: 0x0601FFC1 RID: 131009 RVA: 0x008C7252 File Offset: 0x008C5452
		public unsafe float Around_Sun_Density_Exponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_151);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_151) = value;
			}
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0601FFC2 RID: 131010 RVA: 0x008C7263 File Offset: 0x008C5463
		// (set) Token: 0x0601FFC3 RID: 131011 RVA: 0x008C7273 File Offset: 0x008C5473
		public unsafe float Around_Moon_Density_Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_152);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_152) = value;
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0601FFC4 RID: 131012 RVA: 0x008C7284 File Offset: 0x008C5484
		// (set) Token: 0x0601FFC5 RID: 131013 RVA: 0x008C7294 File Offset: 0x008C5494
		public unsafe float Around_Moon_Density_Exponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_153);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_153) = value;
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0601FFC6 RID: 131014 RVA: 0x008C72A5 File Offset: 0x008C54A5
		// (set) Token: 0x0601FFC7 RID: 131015 RVA: 0x008C72B9 File Offset: 0x008C54B9
		public unsafe UTexture2D Cloud_Wisps_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_154);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_154, value);
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0601FFC8 RID: 131016 RVA: 0x008C72CE File Offset: 0x008C54CE
		// (set) Token: 0x0601FFC9 RID: 131017 RVA: 0x008C72E2 File Offset: 0x008C54E2
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_NoiseType> Cloud_Noise_Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_155);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_155) = value;
			}
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x0601FFCA RID: 131018 RVA: 0x008C72F7 File Offset: 0x008C54F7
		// (set) Token: 0x0601FFCB RID: 131019 RVA: 0x008C730B File Offset: 0x008C550B
		public unsafe UTexture Custom_Noise_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_156);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_156, value);
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0601FFCC RID: 131020 RVA: 0x008C7320 File Offset: 0x008C5520
		// (set) Token: 0x0601FFCD RID: 131021 RVA: 0x008C7330 File Offset: 0x008C5530
		public unsafe float Sun_Lighting_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_157);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_157) = value;
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0601FFCE RID: 131022 RVA: 0x008C7341 File Offset: 0x008C5541
		// (set) Token: 0x0601FFCF RID: 131023 RVA: 0x008C7351 File Offset: 0x008C5551
		public unsafe float Shine_Variation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_158);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_158) = value;
			}
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0601FFD0 RID: 131024 RVA: 0x008C7362 File Offset: 0x008C5562
		// (set) Token: 0x0601FFD1 RID: 131025 RVA: 0x008C7376 File Offset: 0x008C5576
		public unsafe UCurveFloat Sun_Highlight_Radius_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_159);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_159, value);
			}
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0601FFD2 RID: 131026 RVA: 0x008C738B File Offset: 0x008C558B
		// (set) Token: 0x0601FFD3 RID: 131027 RVA: 0x008C739F File Offset: 0x008C559F
		public unsafe UCurveFloat Sun_Highlight_Intensity_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_160);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_160, value);
			}
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0601FFD4 RID: 131028 RVA: 0x008C73B4 File Offset: 0x008C55B4
		// (set) Token: 0x0601FFD5 RID: 131029 RVA: 0x008C73C8 File Offset: 0x008C55C8
		public unsafe UCurveFloat Shine_Intensity_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_161);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_161, value);
			}
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0601FFD6 RID: 131030 RVA: 0x008C73DD File Offset: 0x008C55DD
		// (set) Token: 0x0601FFD7 RID: 131031 RVA: 0x008C73ED File Offset: 0x008C55ED
		public unsafe float Cloud_Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_162);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_162) = value;
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0601FFD8 RID: 131032 RVA: 0x008C73FE File Offset: 0x008C55FE
		// (set) Token: 0x0601FFD9 RID: 131033 RVA: 0x008C740E File Offset: 0x008C560E
		public unsafe float Sun_Vertical_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_163);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_163) = value;
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0601FFDA RID: 131034 RVA: 0x008C741F File Offset: 0x008C561F
		// (set) Token: 0x0601FFDB RID: 131035 RVA: 0x008C742F File Offset: 0x008C562F
		public unsafe float Moon_Vertical_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_164);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_164) = value;
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0601FFDC RID: 131036 RVA: 0x008C7440 File Offset: 0x008C5640
		// (set) Token: 0x0601FFDD RID: 131037 RVA: 0x008C7450 File Offset: 0x008C5650
		public unsafe float Directional_Lights_Absent_Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_165);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_165) = value;
			}
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0601FFDE RID: 131038 RVA: 0x008C7461 File Offset: 0x008C5661
		// (set) Token: 0x0601FFDF RID: 131039 RVA: 0x008C7475 File Offset: 0x008C5675
		public unsafe UMaterialInstanceDynamic Volumetric_Clouds_MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_166);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_166, value);
			}
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0601FFE0 RID: 131040 RVA: 0x008C748A File Offset: 0x008C568A
		// (set) Token: 0x0601FFE1 RID: 131041 RVA: 0x008C749A File Offset: 0x008C569A
		public unsafe float Layer_Height_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_167);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_167) = value;
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0601FFE2 RID: 131042 RVA: 0x008C74AB File Offset: 0x008C56AB
		// (set) Token: 0x0601FFE3 RID: 131043 RVA: 0x008C74BB File Offset: 0x008C56BB
		public unsafe float Bottom_Altitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_168);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_168) = value;
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0601FFE4 RID: 131044 RVA: 0x008C74CC File Offset: 0x008C56CC
		// (set) Token: 0x0601FFE5 RID: 131045 RVA: 0x008C74DC File Offset: 0x008C56DC
		public unsafe float Base_Clouds_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_169);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_169) = value;
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0601FFE6 RID: 131046 RVA: 0x008C74ED File Offset: 0x008C56ED
		// (set) Token: 0x0601FFE7 RID: 131047 RVA: 0x008C74FD File Offset: 0x008C56FD
		public unsafe float SubNoise_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_170);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_170) = value;
			}
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0601FFE8 RID: 131048 RVA: 0x008C750E File Offset: 0x008C570E
		// (set) Token: 0x0601FFE9 RID: 131049 RVA: 0x008C751E File Offset: 0x008C571E
		public unsafe float High_Frequency_Noise_Layer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_171);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_171) = value;
			}
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0601FFEA RID: 131050 RVA: 0x008C752F File Offset: 0x008C572F
		// (set) Token: 0x0601FFEB RID: 131051 RVA: 0x008C753F File Offset: 0x008C573F
		public unsafe float Extinction_Scale_Top
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_172);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_172) = value;
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0601FFEC RID: 131052 RVA: 0x008C7550 File Offset: 0x008C5750
		// (set) Token: 0x0601FFED RID: 131053 RVA: 0x008C7560 File Offset: 0x008C5760
		public unsafe float Extinction_Scale_Bottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_173);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_173) = value;
			}
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0601FFEE RID: 131054 RVA: 0x008C7571 File Offset: 0x008C5771
		// (set) Token: 0x0601FFEF RID: 131055 RVA: 0x008C7581 File Offset: 0x008C5781
		public unsafe float View_Sample_Count_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_174);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_174) = value;
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0601FFF0 RID: 131056 RVA: 0x008C7592 File Offset: 0x008C5792
		// (set) Token: 0x0601FFF1 RID: 131057 RVA: 0x008C75A2 File Offset: 0x008C57A2
		public unsafe float Shadow_Sample_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_175);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_175) = value;
			}
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0601FFF2 RID: 131058 RVA: 0x008C75B3 File Offset: 0x008C57B3
		// (set) Token: 0x0601FFF3 RID: 131059 RVA: 0x008C75C7 File Offset: 0x008C57C7
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_NoiseType> Volumetric_Cloud_Noise_Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_176);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_176) = value;
			}
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0601FFF4 RID: 131060 RVA: 0x008C75DC File Offset: 0x008C57DC
		// (set) Token: 0x0601FFF5 RID: 131061 RVA: 0x008C75F0 File Offset: 0x008C57F0
		public unsafe UTexture Volumetric_Custom_Noise_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_177);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_177, value);
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0601FFF6 RID: 131062 RVA: 0x008C7605 File Offset: 0x008C5805
		// (set) Token: 0x0601FFF7 RID: 131063 RVA: 0x008C7615 File Offset: 0x008C5815
		public unsafe float Multiscattering_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_178);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_178) = value;
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0601FFF8 RID: 131064 RVA: 0x008C7626 File Offset: 0x008C5826
		// (set) Token: 0x0601FFF9 RID: 131065 RVA: 0x008C7636 File Offset: 0x008C5836
		public unsafe float Multiscattering_Occlusion_Factor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_179);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_179) = value;
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0601FFFA RID: 131066 RVA: 0x008C7647 File Offset: 0x008C5847
		// (set) Token: 0x0601FFFB RID: 131067 RVA: 0x008C7657 File Offset: 0x008C5857
		public unsafe float Shadow_Tracing_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_180);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_180) = value;
			}
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0601FFFC RID: 131068 RVA: 0x008C7668 File Offset: 0x008C5868
		// (set) Token: 0x0601FFFD RID: 131069 RVA: 0x008C7678 File Offset: 0x008C5878
		public unsafe float SubNoise_Erosion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_181);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_181) = value;
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0601FFFE RID: 131070 RVA: 0x008C7689 File Offset: 0x008C5889
		// (set) Token: 0x0601FFFF RID: 131071 RVA: 0x008C7699 File Offset: 0x008C5899
		public unsafe float FullCloudiness_Fog_Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_182);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_182) = value;
			}
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x06020000 RID: 131072 RVA: 0x008C76AA File Offset: 0x008C58AA
		// (set) Token: 0x06020001 RID: 131073 RVA: 0x008C76BA File Offset: 0x008C58BA
		public unsafe bool Runtime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_183) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_183) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x06020002 RID: 131074 RVA: 0x008C76CB File Offset: 0x008C58CB
		// (set) Token: 0x06020003 RID: 131075 RVA: 0x008C76DB File Offset: 0x008C58DB
		public unsafe float Clouds_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_184);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_184) = value;
			}
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x06020004 RID: 131076 RVA: 0x008C76EC File Offset: 0x008C58EC
		// (set) Token: 0x06020005 RID: 131077 RVA: 0x008C76FC File Offset: 0x008C58FC
		public unsafe float Fog_Density_Distribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_185);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_185) = value;
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x06020006 RID: 131078 RVA: 0x008C770D File Offset: 0x008C590D
		// (set) Token: 0x06020007 RID: 131079 RVA: 0x008C771D File Offset: 0x008C591D
		public unsafe bool Use_Volumetric_Fog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_186) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_186) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x06020008 RID: 131080 RVA: 0x008C772E File Offset: 0x008C592E
		// (set) Token: 0x06020009 RID: 131081 RVA: 0x008C773E File Offset: 0x008C593E
		public unsafe bool Randomize_Cloud_Formation_on_Run
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_187) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_187) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0602000A RID: 131082 RVA: 0x008C774F File Offset: 0x008C594F
		// (set) Token: 0x0602000B RID: 131083 RVA: 0x008C775F File Offset: 0x008C595F
		public unsafe float Phase_G
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_188);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_188) = value;
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0602000C RID: 131084 RVA: 0x008C7770 File Offset: 0x008C5970
		// (set) Token: 0x0602000D RID: 131085 RVA: 0x008C7780 File Offset: 0x008C5980
		public unsafe float Phase_G_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_189);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_189) = value;
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0602000E RID: 131086 RVA: 0x008C7791 File Offset: 0x008C5991
		// (set) Token: 0x0602000F RID: 131087 RVA: 0x008C77A1 File Offset: 0x008C59A1
		public unsafe float MultiScattering_Eccentricity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_190);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_190) = value;
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x06020010 RID: 131088 RVA: 0x008C77B2 File Offset: 0x008C59B2
		// (set) Token: 0x06020011 RID: 131089 RVA: 0x008C77C2 File Offset: 0x008C59C2
		public unsafe float Distance_to_Sample_Max_Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_191);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_191) = value;
			}
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x06020012 RID: 131090 RVA: 0x008C77D3 File Offset: 0x008C59D3
		// (set) Token: 0x06020013 RID: 131091 RVA: 0x008C77E3 File Offset: 0x008C59E3
		public unsafe float Time_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_192);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_192) = value;
			}
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x06020014 RID: 131092 RVA: 0x008C77F4 File Offset: 0x008C59F4
		// (set) Token: 0x06020015 RID: 131093 RVA: 0x008C7804 File Offset: 0x008C5A04
		public unsafe bool Force_Light_Functions_On
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_193) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_193) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x06020016 RID: 131094 RVA: 0x008C7815 File Offset: 0x008C5A15
		// (set) Token: 0x06020017 RID: 131095 RVA: 0x008C7829 File Offset: 0x008C5A29
		public unsafe Ultra_Dynamic_Weather_C Weather_BP
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<Ultra_Dynamic_Weather_C>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_194);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_194, value);
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x06020018 RID: 131096 RVA: 0x008C783E File Offset: 0x008C5A3E
		// (set) Token: 0x06020019 RID: 131097 RVA: 0x008C784E File Offset: 0x008C5A4E
		public unsafe float Volumetric_Clouds_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_195);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_195) = value;
			}
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0602001A RID: 131098 RVA: 0x008C785F File Offset: 0x008C5A5F
		// (set) Token: 0x0602001B RID: 131099 RVA: 0x008C786F File Offset: 0x008C5A6F
		public unsafe float Tracing_Max_Start_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_196);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_196) = value;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0602001C RID: 131100 RVA: 0x008C7880 File Offset: 0x008C5A80
		// (set) Token: 0x0602001D RID: 131101 RVA: 0x008C7894 File Offset: 0x008C5A94
		public unsafe UMaterialInstanceDynamic Static_Clouds_MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_197);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_197, value);
			}
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0602001E RID: 131102 RVA: 0x008C78A9 File Offset: 0x008C5AA9
		// (set) Token: 0x0602001F RID: 131103 RVA: 0x008C78BD File Offset: 0x008C5ABD
		public unsafe FLinearColor Aurora_Color_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_198);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_198) = value;
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x06020020 RID: 131104 RVA: 0x008C78D2 File Offset: 0x008C5AD2
		// (set) Token: 0x06020021 RID: 131105 RVA: 0x008C78E6 File Offset: 0x008C5AE6
		public unsafe FLinearColor Aurora_Color_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_199);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_199) = value;
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x06020022 RID: 131106 RVA: 0x008C78FB File Offset: 0x008C5AFB
		// (set) Token: 0x06020023 RID: 131107 RVA: 0x008C790F File Offset: 0x008C5B0F
		public unsafe FLinearColor Aurora_Color_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_200);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_200) = value;
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x06020024 RID: 131108 RVA: 0x008C7924 File Offset: 0x008C5B24
		// (set) Token: 0x06020025 RID: 131109 RVA: 0x008C7938 File Offset: 0x008C5B38
		public unsafe UMaterialInstanceDynamic Volumetric_Aurora_MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_201);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_201, value);
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x06020026 RID: 131110 RVA: 0x008C794D File Offset: 0x008C5B4D
		// (set) Token: 0x06020027 RID: 131111 RVA: 0x008C795D File Offset: 0x008C5B5D
		public unsafe float Overcast_Night_Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_202);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_202) = value;
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x06020028 RID: 131112 RVA: 0x008C796E File Offset: 0x008C5B6E
		// (set) Token: 0x06020029 RID: 131113 RVA: 0x008C797E File Offset: 0x008C5B7E
		public unsafe bool Use_Sky_Mode_Scalability_Map
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_203) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_203) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0602002A RID: 131114 RVA: 0x008C7990 File Offset: 0x008C5B90
		// (set) Token: 0x0602002B RID: 131115 RVA: 0x008C79C9 File Offset: 0x008C5BC9
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<int, TEnumAsByte<UDS_SkyMode>> Sky_Mode_ScalabilityMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<int, TEnumAsByte<UDS_SkyMode>> result;
				if ((result = this._Sky_Mode_ScalabilityMap) == null)
				{
					result = (this._Sky_Mode_ScalabilityMap = new TMap<int, TEnumAsByte<UDS_SkyMode>>(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_204, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Sky_Mode_ScalabilityMap.CopyAssign(value);
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0602002C RID: 131116 RVA: 0x008C79D7 File Offset: 0x008C5BD7
		// (set) Token: 0x0602002D RID: 131117 RVA: 0x008C79E7 File Offset: 0x008C5BE7
		public unsafe float Scale_Skylight_Intensity_at_Night
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_205);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_205) = value;
			}
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0602002E RID: 131118 RVA: 0x008C79F8 File Offset: 0x008C5BF8
		// (set) Token: 0x0602002F RID: 131119 RVA: 0x008C7A08 File Offset: 0x008C5C08
		public unsafe float Scale_Skylight_Intensity_when_Cloudy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_206);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_206) = value;
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x06020030 RID: 131120 RVA: 0x008C7A19 File Offset: 0x008C5C19
		// (set) Token: 0x06020031 RID: 131121 RVA: 0x008C7A2D File Offset: 0x008C5C2D
		public unsafe UCurveLinearColor Horizon_Base_Color__Legacy_Color_Curve_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_207);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_207, value);
			}
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x06020032 RID: 131122 RVA: 0x008C7A42 File Offset: 0x008C5C42
		// (set) Token: 0x06020033 RID: 131123 RVA: 0x008C7A56 File Offset: 0x008C5C56
		public unsafe UCurveLinearColor Cloud_Dark_Color__Legacy_Color_Curve_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_208);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_208, value);
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x06020034 RID: 131124 RVA: 0x008C7A6B File Offset: 0x008C5C6B
		// (set) Token: 0x06020035 RID: 131125 RVA: 0x008C7A7F File Offset: 0x008C5C7F
		public unsafe UCurveLinearColor Cloud_Light_Color__Legacy_Color_Curve_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_209);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_209, value);
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x06020036 RID: 131126 RVA: 0x008C7A94 File Offset: 0x008C5C94
		// (set) Token: 0x06020037 RID: 131127 RVA: 0x008C7AA8 File Offset: 0x008C5CA8
		public unsafe UCurveLinearColor Sun_Color__Legacy_Color_Curve_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_210);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_210, value);
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x06020038 RID: 131128 RVA: 0x008C7ABD File Offset: 0x008C5CBD
		// (set) Token: 0x06020039 RID: 131129 RVA: 0x008C7AD1 File Offset: 0x008C5CD1
		public unsafe UCurveLinearColor Sun_Cloudy_Color_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_211);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_211, value);
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0602003A RID: 131130 RVA: 0x008C7AE6 File Offset: 0x008C5CE6
		// (set) Token: 0x0602003B RID: 131131 RVA: 0x008C7AFA File Offset: 0x008C5CFA
		public unsafe UCurveLinearColor Zenith_Base_Color__Legacy_Color_Curve_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_212);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_212, value);
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0602003C RID: 131132 RVA: 0x008C7B0F File Offset: 0x008C5D0F
		// (set) Token: 0x0602003D RID: 131133 RVA: 0x008C7B23 File Offset: 0x008C5D23
		public unsafe UCurveFloat Directional_Intensity_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_213);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_213, value);
			}
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0602003E RID: 131134 RVA: 0x008C7B38 File Offset: 0x008C5D38
		// (set) Token: 0x0602003F RID: 131135 RVA: 0x008C7B4C File Offset: 0x008C5D4C
		public unsafe UCurveFloat Aurora_Intensity_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_214);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_214, value);
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x06020040 RID: 131136 RVA: 0x008C7B61 File Offset: 0x008C5D61
		// (set) Token: 0x06020041 RID: 131137 RVA: 0x008C7B75 File Offset: 0x008C5D75
		public unsafe UMaterialInstanceDynamic Inside_Clouds_Fog_MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_215);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Sky_C.__PropertyOffset_215, value);
			}
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x06020042 RID: 131138 RVA: 0x008C7B8A File Offset: 0x008C5D8A
		// (set) Token: 0x06020043 RID: 131139 RVA: 0x008C7B9A File Offset: 0x008C5D9A
		public unsafe float Tracing_Max_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_216);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_216) = value;
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x06020044 RID: 131140 RVA: 0x008C7BAB File Offset: 0x008C5DAB
		// (set) Token: 0x06020045 RID: 131141 RVA: 0x008C7BBB File Offset: 0x008C5DBB
		public unsafe bool Enable_Fog_Inside_Clouds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_217) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_217) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x06020046 RID: 131142 RVA: 0x008C7BCC File Offset: 0x008C5DCC
		// (set) Token: 0x06020047 RID: 131143 RVA: 0x008C7BDC File Offset: 0x008C5DDC
		public unsafe float Volumetric_Aurora_Sample_Count_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_218);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_218) = value;
			}
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x06020048 RID: 131144 RVA: 0x008C7BED File Offset: 0x008C5DED
		// (set) Token: 0x06020049 RID: 131145 RVA: 0x008C7BFD File Offset: 0x008C5DFD
		public unsafe bool For_Mobile_Renderer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_219) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Sky_C.__PropertyOffset_219) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602004A RID: 131146 RVA: 0x008C7C0E File Offset: 0x008C5E0E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Sky_Mode_with_Scalability_Map()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Set_Sky_Mode_with_Scalability_Map_NativeFunctionPtr, null);
		}

		// Token: 0x0602004B RID: 131147 RVA: 0x008C7C22 File Offset: 0x008C5E22
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Get_Reference_to_Weather_BP()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Get_Reference_to_Weather_BP_NativeFunctionPtr, null);
		}

		// Token: 0x0602004C RID: 131148 RVA: 0x008C7C36 File Offset: 0x008C5E36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Variables_Controlled_by_Weather()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Update_Variables_Controlled_by_Weather_NativeFunctionPtr, null);
		}

		// Token: 0x0602004D RID: 131149 RVA: 0x008C7C4A File Offset: 0x008C5E4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Static_Variables()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Update_Static_Variables_NativeFunctionPtr, null);
		}

		// Token: 0x0602004E RID: 131150 RVA: 0x008C7C60 File Offset: 0x008C5E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ConstructionScript_Function(bool Run_By_Counterpart)
		{
			Ultra_Dynamic_Sky_C.__ConstructionScript_Function_FunctionParams* ptr = stackalloc Ultra_Dynamic_Sky_C.__ConstructionScript_Function_FunctionParams[(UIntPtr)3023] + 15L / (long)sizeof(Ultra_Dynamic_Sky_C.__ConstructionScript_Function_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Sky_C.__ConstructionScript_Function_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Run_By_Counterpart = Run_By_Counterpart;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__ConstructionScript_Function_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602004F RID: 131151 RVA: 0x008C7CA9 File Offset: 0x008C5EA9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Cloud_Timing()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Set_Cloud_Timing_NativeFunctionPtr, null);
		}

		// Token: 0x06020050 RID: 131152 RVA: 0x008C7CC0 File Offset: 0x008C5EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Time_of_Day_using_Time_Code(FTimecode Time_Code)
		{
			Ultra_Dynamic_Sky_C.__Set_Time_of_Day_using_Time_Code_FunctionParams* ptr = stackalloc Ultra_Dynamic_Sky_C.__Set_Time_of_Day_using_Time_Code_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(Ultra_Dynamic_Sky_C.__Set_Time_of_Day_using_Time_Code_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Sky_C.__Set_Time_of_Day_using_Time_Code_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time_Code = Time_Code;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Set_Time_of_Day_using_Time_Code_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020051 RID: 131153 RVA: 0x008C7D08 File Offset: 0x008C5F08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Time_of_Day_in_Real_Time_Format(ref FTimecode Time)
		{
			Ultra_Dynamic_Sky_C.__Get_Time_of_Day_in_Real_Time_Format_FunctionParams* ptr = stackalloc Ultra_Dynamic_Sky_C.__Get_Time_of_Day_in_Real_Time_Format_FunctionParams[(UIntPtr)99] + 15L / (long)sizeof(Ultra_Dynamic_Sky_C.__Get_Time_of_Day_in_Real_Time_Format_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Sky_C.__Get_Time_of_Day_in_Real_Time_Format_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Get_Time_of_Day_in_Real_Time_Format_NativeFunctionPtr, (void*)ptr);
			Time = ptr->Time;
		}

		// Token: 0x06020052 RID: 131154 RVA: 0x008C7D5F File Offset: 0x008C5F5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Active_Variables()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Update_Active_Variables_NativeFunctionPtr, null);
		}

		// Token: 0x06020053 RID: 131155 RVA: 0x008C7D74 File Offset: 0x008C5F74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Sun_and_Moon_Rotation(bool Move_Static_Lights)
		{
			Ultra_Dynamic_Sky_C.__Set_Sun_and_Moon_Rotation_FunctionParams* ptr = stackalloc Ultra_Dynamic_Sky_C.__Set_Sun_and_Moon_Rotation_FunctionParams[(UIntPtr)991] + 15L / (long)sizeof(Ultra_Dynamic_Sky_C.__Set_Sun_and_Moon_Rotation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Sky_C.__Set_Sun_and_Moon_Rotation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Move_Static_Lights = Move_Static_Lights;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Set_Sun_and_Moon_Rotation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020054 RID: 131156 RVA: 0x008C7DBD File Offset: 0x008C5FBD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020055 RID: 131157 RVA: 0x008C7DD1 File Offset: 0x008C5FD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020056 RID: 131158 RVA: 0x008C7DE8 File Offset: 0x008C5FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			Ultra_Dynamic_Sky_C.__ReceiveTick_FunctionParams* ptr = stackalloc Ultra_Dynamic_Sky_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Ultra_Dynamic_Sky_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Sky_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020057 RID: 131159 RVA: 0x008C7E30 File Offset: 0x008C6030
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			Ultra_Dynamic_Sky_C.__ReceiveTick_FunctionParams* ptr = stackalloc Ultra_Dynamic_Sky_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Ultra_Dynamic_Sky_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Sky_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020058 RID: 131160 RVA: 0x008C7E77 File Offset: 0x008C6077
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020059 RID: 131161 RVA: 0x008C7E8B File Offset: 0x008C608B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602005A RID: 131162 RVA: 0x008C7EA0 File Offset: 0x008C60A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Midnight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Sky_C.__Midnight_NativeFunctionPtr, null);
		}

		// Token: 0x0602005B RID: 131163 RVA: 0x008C7EB4 File Offset: 0x008C60B4
		protected Ultra_Dynamic_Sky_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F634 RID: 63028
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Sky.Ultra_Dynamic_Sky_C";

		// Token: 0x0400F635 RID: 63029
		private static IntPtr _ClassPtr;

		// Token: 0x0400F636 RID: 63030
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F637 RID: 63031
		public static IntPtr __Sunrise__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F638 RID: 63032
		public static IntPtr __Sunset__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F639 RID: 63033
		internal static int __PropertyOffset_1;

		// Token: 0x0400F63A RID: 63034
		internal static int __PropertyOffset_2;

		// Token: 0x0400F63B RID: 63035
		internal static int __PropertyOffset_3;

		// Token: 0x0400F63C RID: 63036
		internal static int __PropertyOffset_4;

		// Token: 0x0400F63D RID: 63037
		internal static int __PropertyOffset_5;

		// Token: 0x0400F63E RID: 63038
		internal static int __PropertyOffset_6;

		// Token: 0x0400F63F RID: 63039
		internal static int __PropertyOffset_7;

		// Token: 0x0400F640 RID: 63040
		internal static int __PropertyOffset_8;

		// Token: 0x0400F641 RID: 63041
		internal static int __PropertyOffset_9;

		// Token: 0x0400F642 RID: 63042
		internal static int __PropertyOffset_10;

		// Token: 0x0400F643 RID: 63043
		internal static int __PropertyOffset_11;

		// Token: 0x0400F644 RID: 63044
		internal static int __PropertyOffset_12;

		// Token: 0x0400F645 RID: 63045
		internal static int __PropertyOffset_13;

		// Token: 0x0400F646 RID: 63046
		internal static int __PropertyOffset_14;

		// Token: 0x0400F647 RID: 63047
		internal static int __PropertyOffset_15;

		// Token: 0x0400F648 RID: 63048
		internal static int __PropertyOffset_16;

		// Token: 0x0400F649 RID: 63049
		internal static int __PropertyOffset_17;

		// Token: 0x0400F64A RID: 63050
		internal static int __PropertyOffset_18;

		// Token: 0x0400F64B RID: 63051
		internal static int __PropertyOffset_19;

		// Token: 0x0400F64C RID: 63052
		internal static int __PropertyOffset_20;

		// Token: 0x0400F64D RID: 63053
		internal static int __PropertyOffset_21;

		// Token: 0x0400F64E RID: 63054
		internal static int __PropertyOffset_22;

		// Token: 0x0400F64F RID: 63055
		internal static int __PropertyOffset_23;

		// Token: 0x0400F650 RID: 63056
		internal static int __PropertyOffset_24;

		// Token: 0x0400F651 RID: 63057
		internal static int __PropertyOffset_25;

		// Token: 0x0400F652 RID: 63058
		internal static int __PropertyOffset_26;

		// Token: 0x0400F653 RID: 63059
		internal static int __PropertyOffset_27;

		// Token: 0x0400F654 RID: 63060
		internal static int __PropertyOffset_28;

		// Token: 0x0400F655 RID: 63061
		internal static int __PropertyOffset_29;

		// Token: 0x0400F656 RID: 63062
		internal static int __PropertyOffset_30;

		// Token: 0x0400F657 RID: 63063
		internal static int __PropertyOffset_31;

		// Token: 0x0400F658 RID: 63064
		internal static int __PropertyOffset_32;

		// Token: 0x0400F659 RID: 63065
		internal static int __PropertyOffset_33;

		// Token: 0x0400F65A RID: 63066
		internal static int __PropertyOffset_34;

		// Token: 0x0400F65B RID: 63067
		internal static int __PropertyOffset_35;

		// Token: 0x0400F65C RID: 63068
		internal static int __PropertyOffset_36;

		// Token: 0x0400F65D RID: 63069
		internal static int __PropertyOffset_37;

		// Token: 0x0400F65E RID: 63070
		internal static int __PropertyOffset_38;

		// Token: 0x0400F65F RID: 63071
		internal static int __PropertyOffset_39;

		// Token: 0x0400F660 RID: 63072
		internal static int __PropertyOffset_40;

		// Token: 0x0400F661 RID: 63073
		internal static int __PropertyOffset_41;

		// Token: 0x0400F662 RID: 63074
		internal static int __PropertyOffset_42;

		// Token: 0x0400F663 RID: 63075
		internal static int __PropertyOffset_43;

		// Token: 0x0400F664 RID: 63076
		internal static int __PropertyOffset_44;

		// Token: 0x0400F665 RID: 63077
		internal static int __PropertyOffset_45;

		// Token: 0x0400F666 RID: 63078
		internal static int __PropertyOffset_46;

		// Token: 0x0400F667 RID: 63079
		internal static int __PropertyOffset_47;

		// Token: 0x0400F668 RID: 63080
		internal static int __PropertyOffset_48;

		// Token: 0x0400F669 RID: 63081
		internal static int __PropertyOffset_49;

		// Token: 0x0400F66A RID: 63082
		internal static int __PropertyOffset_50;

		// Token: 0x0400F66B RID: 63083
		internal static int __PropertyOffset_51;

		// Token: 0x0400F66C RID: 63084
		internal static int __PropertyOffset_52;

		// Token: 0x0400F66D RID: 63085
		internal static int __PropertyOffset_53;

		// Token: 0x0400F66E RID: 63086
		internal static int __PropertyOffset_54;

		// Token: 0x0400F66F RID: 63087
		internal static int __PropertyOffset_55;

		// Token: 0x0400F670 RID: 63088
		internal static int __PropertyOffset_56;

		// Token: 0x0400F671 RID: 63089
		internal static int __PropertyOffset_57;

		// Token: 0x0400F672 RID: 63090
		internal static int __PropertyOffset_58;

		// Token: 0x0400F673 RID: 63091
		internal static int __PropertyOffset_59;

		// Token: 0x0400F674 RID: 63092
		internal static int __PropertyOffset_60;

		// Token: 0x0400F675 RID: 63093
		internal static int __PropertyOffset_61;

		// Token: 0x0400F676 RID: 63094
		internal static int __PropertyOffset_62;

		// Token: 0x0400F677 RID: 63095
		internal static int __PropertyOffset_63;

		// Token: 0x0400F678 RID: 63096
		internal static int __PropertyOffset_64;

		// Token: 0x0400F679 RID: 63097
		internal static int __PropertyOffset_65;

		// Token: 0x0400F67A RID: 63098
		internal static int __PropertyOffset_66;

		// Token: 0x0400F67B RID: 63099
		internal static int __PropertyOffset_67;

		// Token: 0x0400F67C RID: 63100
		internal static int __PropertyOffset_68;

		// Token: 0x0400F67D RID: 63101
		internal static int __PropertyOffset_69;

		// Token: 0x0400F67E RID: 63102
		internal static int __PropertyOffset_70;

		// Token: 0x0400F67F RID: 63103
		internal static int __PropertyOffset_71;

		// Token: 0x0400F680 RID: 63104
		internal static int __PropertyOffset_72;

		// Token: 0x0400F681 RID: 63105
		internal static int __PropertyOffset_73;

		// Token: 0x0400F682 RID: 63106
		internal static int __PropertyOffset_74;

		// Token: 0x0400F683 RID: 63107
		internal static int __PropertyOffset_75;

		// Token: 0x0400F684 RID: 63108
		internal static int __PropertyOffset_76;

		// Token: 0x0400F685 RID: 63109
		internal static int __PropertyOffset_77;

		// Token: 0x0400F686 RID: 63110
		internal static int __PropertyOffset_78;

		// Token: 0x0400F687 RID: 63111
		internal static int __PropertyOffset_79;

		// Token: 0x0400F688 RID: 63112
		internal static int __PropertyOffset_80;

		// Token: 0x0400F689 RID: 63113
		internal static int __PropertyOffset_81;

		// Token: 0x0400F68A RID: 63114
		internal static int __PropertyOffset_82;

		// Token: 0x0400F68B RID: 63115
		internal static int __PropertyOffset_83;

		// Token: 0x0400F68C RID: 63116
		internal static int __PropertyOffset_84;

		// Token: 0x0400F68D RID: 63117
		internal static int __PropertyOffset_85;

		// Token: 0x0400F68E RID: 63118
		internal static int __PropertyOffset_86;

		// Token: 0x0400F68F RID: 63119
		internal static int __PropertyOffset_87;

		// Token: 0x0400F690 RID: 63120
		internal static int __PropertyOffset_88;

		// Token: 0x0400F691 RID: 63121
		internal static int __PropertyOffset_89;

		// Token: 0x0400F692 RID: 63122
		internal static int __PropertyOffset_90;

		// Token: 0x0400F693 RID: 63123
		internal static int __PropertyOffset_91;

		// Token: 0x0400F694 RID: 63124
		internal static int __PropertyOffset_92;

		// Token: 0x0400F695 RID: 63125
		internal static int __PropertyOffset_93;

		// Token: 0x0400F696 RID: 63126
		internal static int __PropertyOffset_94;

		// Token: 0x0400F697 RID: 63127
		internal static int __PropertyOffset_95;

		// Token: 0x0400F698 RID: 63128
		internal static int __PropertyOffset_96;

		// Token: 0x0400F699 RID: 63129
		internal static int __PropertyOffset_97;

		// Token: 0x0400F69A RID: 63130
		internal static int __PropertyOffset_98;

		// Token: 0x0400F69B RID: 63131
		internal static int __PropertyOffset_99;

		// Token: 0x0400F69C RID: 63132
		internal static int __PropertyOffset_100;

		// Token: 0x0400F69D RID: 63133
		internal static int __PropertyOffset_101;

		// Token: 0x0400F69E RID: 63134
		internal static int __PropertyOffset_102;

		// Token: 0x0400F69F RID: 63135
		internal static int __PropertyOffset_103;

		// Token: 0x0400F6A0 RID: 63136
		internal static int __PropertyOffset_104;

		// Token: 0x0400F6A1 RID: 63137
		internal static int __PropertyOffset_105;

		// Token: 0x0400F6A2 RID: 63138
		internal static int __PropertyOffset_106;

		// Token: 0x0400F6A3 RID: 63139
		internal static int __PropertyOffset_107;

		// Token: 0x0400F6A4 RID: 63140
		internal static int __PropertyOffset_108;

		// Token: 0x0400F6A5 RID: 63141
		internal static int __PropertyOffset_109;

		// Token: 0x0400F6A6 RID: 63142
		internal static int __PropertyOffset_110;

		// Token: 0x0400F6A7 RID: 63143
		internal static int __PropertyOffset_111;

		// Token: 0x0400F6A8 RID: 63144
		internal static int __PropertyOffset_112;

		// Token: 0x0400F6A9 RID: 63145
		internal static int __PropertyOffset_113;

		// Token: 0x0400F6AA RID: 63146
		internal static int __PropertyOffset_114;

		// Token: 0x0400F6AB RID: 63147
		internal static int __PropertyOffset_115;

		// Token: 0x0400F6AC RID: 63148
		internal static int __PropertyOffset_116;

		// Token: 0x0400F6AD RID: 63149
		internal static int __PropertyOffset_117;

		// Token: 0x0400F6AE RID: 63150
		internal static int __PropertyOffset_118;

		// Token: 0x0400F6AF RID: 63151
		internal static int __PropertyOffset_119;

		// Token: 0x0400F6B0 RID: 63152
		internal static int __PropertyOffset_120;

		// Token: 0x0400F6B1 RID: 63153
		internal static int __PropertyOffset_121;

		// Token: 0x0400F6B2 RID: 63154
		internal static int __PropertyOffset_122;

		// Token: 0x0400F6B3 RID: 63155
		internal static int __PropertyOffset_123;

		// Token: 0x0400F6B4 RID: 63156
		internal static int __PropertyOffset_124;

		// Token: 0x0400F6B5 RID: 63157
		internal static int __PropertyOffset_125;

		// Token: 0x0400F6B6 RID: 63158
		internal static int __PropertyOffset_126;

		// Token: 0x0400F6B7 RID: 63159
		internal static int __PropertyOffset_127;

		// Token: 0x0400F6B8 RID: 63160
		internal static int __PropertyOffset_128;

		// Token: 0x0400F6B9 RID: 63161
		internal static int __PropertyOffset_129;

		// Token: 0x0400F6BA RID: 63162
		internal static int __PropertyOffset_130;

		// Token: 0x0400F6BB RID: 63163
		internal static int __PropertyOffset_131;

		// Token: 0x0400F6BC RID: 63164
		internal static int __PropertyOffset_132;

		// Token: 0x0400F6BD RID: 63165
		internal static int __PropertyOffset_133;

		// Token: 0x0400F6BE RID: 63166
		internal static int __PropertyOffset_134;

		// Token: 0x0400F6BF RID: 63167
		internal static int __PropertyOffset_135;

		// Token: 0x0400F6C0 RID: 63168
		internal static int __PropertyOffset_136;

		// Token: 0x0400F6C1 RID: 63169
		internal static int __PropertyOffset_137;

		// Token: 0x0400F6C2 RID: 63170
		internal static int __PropertyOffset_138;

		// Token: 0x0400F6C3 RID: 63171
		internal static int __PropertyOffset_139;

		// Token: 0x0400F6C4 RID: 63172
		internal static int __PropertyOffset_140;

		// Token: 0x0400F6C5 RID: 63173
		internal static int __PropertyOffset_141;

		// Token: 0x0400F6C6 RID: 63174
		private Sunset _Sunset;

		// Token: 0x0400F6C7 RID: 63175
		internal static int __PropertyOffset_142;

		// Token: 0x0400F6C8 RID: 63176
		private Sunrise _Sunrise;

		// Token: 0x0400F6C9 RID: 63177
		internal static int __PropertyOffset_143;

		// Token: 0x0400F6CA RID: 63178
		internal static int __PropertyOffset_144;

		// Token: 0x0400F6CB RID: 63179
		internal static int __PropertyOffset_145;

		// Token: 0x0400F6CC RID: 63180
		internal static int __PropertyOffset_146;

		// Token: 0x0400F6CD RID: 63181
		internal static int __PropertyOffset_147;

		// Token: 0x0400F6CE RID: 63182
		internal static int __PropertyOffset_148;

		// Token: 0x0400F6CF RID: 63183
		internal static int __PropertyOffset_149;

		// Token: 0x0400F6D0 RID: 63184
		internal static int __PropertyOffset_150;

		// Token: 0x0400F6D1 RID: 63185
		internal static int __PropertyOffset_151;

		// Token: 0x0400F6D2 RID: 63186
		internal static int __PropertyOffset_152;

		// Token: 0x0400F6D3 RID: 63187
		internal static int __PropertyOffset_153;

		// Token: 0x0400F6D4 RID: 63188
		internal static int __PropertyOffset_154;

		// Token: 0x0400F6D5 RID: 63189
		internal static int __PropertyOffset_155;

		// Token: 0x0400F6D6 RID: 63190
		internal static int __PropertyOffset_156;

		// Token: 0x0400F6D7 RID: 63191
		internal static int __PropertyOffset_157;

		// Token: 0x0400F6D8 RID: 63192
		internal static int __PropertyOffset_158;

		// Token: 0x0400F6D9 RID: 63193
		internal static int __PropertyOffset_159;

		// Token: 0x0400F6DA RID: 63194
		internal static int __PropertyOffset_160;

		// Token: 0x0400F6DB RID: 63195
		internal static int __PropertyOffset_161;

		// Token: 0x0400F6DC RID: 63196
		internal static int __PropertyOffset_162;

		// Token: 0x0400F6DD RID: 63197
		internal static int __PropertyOffset_163;

		// Token: 0x0400F6DE RID: 63198
		internal static int __PropertyOffset_164;

		// Token: 0x0400F6DF RID: 63199
		internal static int __PropertyOffset_165;

		// Token: 0x0400F6E0 RID: 63200
		internal static int __PropertyOffset_166;

		// Token: 0x0400F6E1 RID: 63201
		internal static int __PropertyOffset_167;

		// Token: 0x0400F6E2 RID: 63202
		internal static int __PropertyOffset_168;

		// Token: 0x0400F6E3 RID: 63203
		internal static int __PropertyOffset_169;

		// Token: 0x0400F6E4 RID: 63204
		internal static int __PropertyOffset_170;

		// Token: 0x0400F6E5 RID: 63205
		internal static int __PropertyOffset_171;

		// Token: 0x0400F6E6 RID: 63206
		internal static int __PropertyOffset_172;

		// Token: 0x0400F6E7 RID: 63207
		internal static int __PropertyOffset_173;

		// Token: 0x0400F6E8 RID: 63208
		internal static int __PropertyOffset_174;

		// Token: 0x0400F6E9 RID: 63209
		internal static int __PropertyOffset_175;

		// Token: 0x0400F6EA RID: 63210
		internal static int __PropertyOffset_176;

		// Token: 0x0400F6EB RID: 63211
		internal static int __PropertyOffset_177;

		// Token: 0x0400F6EC RID: 63212
		internal static int __PropertyOffset_178;

		// Token: 0x0400F6ED RID: 63213
		internal static int __PropertyOffset_179;

		// Token: 0x0400F6EE RID: 63214
		internal static int __PropertyOffset_180;

		// Token: 0x0400F6EF RID: 63215
		internal static int __PropertyOffset_181;

		// Token: 0x0400F6F0 RID: 63216
		internal static int __PropertyOffset_182;

		// Token: 0x0400F6F1 RID: 63217
		internal static int __PropertyOffset_183;

		// Token: 0x0400F6F2 RID: 63218
		internal static int __PropertyOffset_184;

		// Token: 0x0400F6F3 RID: 63219
		internal static int __PropertyOffset_185;

		// Token: 0x0400F6F4 RID: 63220
		internal static int __PropertyOffset_186;

		// Token: 0x0400F6F5 RID: 63221
		internal static int __PropertyOffset_187;

		// Token: 0x0400F6F6 RID: 63222
		internal static int __PropertyOffset_188;

		// Token: 0x0400F6F7 RID: 63223
		internal static int __PropertyOffset_189;

		// Token: 0x0400F6F8 RID: 63224
		internal static int __PropertyOffset_190;

		// Token: 0x0400F6F9 RID: 63225
		internal static int __PropertyOffset_191;

		// Token: 0x0400F6FA RID: 63226
		internal static int __PropertyOffset_192;

		// Token: 0x0400F6FB RID: 63227
		internal static int __PropertyOffset_193;

		// Token: 0x0400F6FC RID: 63228
		internal static int __PropertyOffset_194;

		// Token: 0x0400F6FD RID: 63229
		internal static int __PropertyOffset_195;

		// Token: 0x0400F6FE RID: 63230
		internal static int __PropertyOffset_196;

		// Token: 0x0400F6FF RID: 63231
		internal static int __PropertyOffset_197;

		// Token: 0x0400F700 RID: 63232
		internal static int __PropertyOffset_198;

		// Token: 0x0400F701 RID: 63233
		internal static int __PropertyOffset_199;

		// Token: 0x0400F702 RID: 63234
		internal static int __PropertyOffset_200;

		// Token: 0x0400F703 RID: 63235
		internal static int __PropertyOffset_201;

		// Token: 0x0400F704 RID: 63236
		internal static int __PropertyOffset_202;

		// Token: 0x0400F705 RID: 63237
		internal static int __PropertyOffset_203;

		// Token: 0x0400F706 RID: 63238
		internal static int __PropertyOffset_204;

		// Token: 0x0400F707 RID: 63239
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<int, TEnumAsByte<UDS_SkyMode>> _Sky_Mode_ScalabilityMap;

		// Token: 0x0400F708 RID: 63240
		internal static int __PropertyOffset_205;

		// Token: 0x0400F709 RID: 63241
		internal static int __PropertyOffset_206;

		// Token: 0x0400F70A RID: 63242
		internal static int __PropertyOffset_207;

		// Token: 0x0400F70B RID: 63243
		internal static int __PropertyOffset_208;

		// Token: 0x0400F70C RID: 63244
		internal static int __PropertyOffset_209;

		// Token: 0x0400F70D RID: 63245
		internal static int __PropertyOffset_210;

		// Token: 0x0400F70E RID: 63246
		internal static int __PropertyOffset_211;

		// Token: 0x0400F70F RID: 63247
		internal static int __PropertyOffset_212;

		// Token: 0x0400F710 RID: 63248
		internal static int __PropertyOffset_213;

		// Token: 0x0400F711 RID: 63249
		internal static int __PropertyOffset_214;

		// Token: 0x0400F712 RID: 63250
		internal static int __PropertyOffset_215;

		// Token: 0x0400F713 RID: 63251
		internal static int __PropertyOffset_216;

		// Token: 0x0400F714 RID: 63252
		internal static int __PropertyOffset_217;

		// Token: 0x0400F715 RID: 63253
		internal static int __PropertyOffset_218;

		// Token: 0x0400F716 RID: 63254
		internal static int __PropertyOffset_219;

		// Token: 0x0400F717 RID: 63255
		private static IntPtr __Set_Sky_Mode_with_Scalability_Map_NativeFunctionPtr;

		// Token: 0x0400F718 RID: 63256
		private static IntPtr __Get_Reference_to_Weather_BP_NativeFunctionPtr;

		// Token: 0x0400F719 RID: 63257
		private static IntPtr __Update_Variables_Controlled_by_Weather_NativeFunctionPtr;

		// Token: 0x0400F71A RID: 63258
		private static IntPtr __Update_Static_Variables_NativeFunctionPtr;

		// Token: 0x0400F71B RID: 63259
		private static IntPtr __ConstructionScript_Function_NativeFunctionPtr;

		// Token: 0x0400F71C RID: 63260
		private static IntPtr __Set_Cloud_Timing_NativeFunctionPtr;

		// Token: 0x0400F71D RID: 63261
		private static IntPtr __Set_Time_of_Day_using_Time_Code_NativeFunctionPtr;

		// Token: 0x0400F71E RID: 63262
		private static IntPtr __Get_Time_of_Day_in_Real_Time_Format_NativeFunctionPtr;

		// Token: 0x0400F71F RID: 63263
		private static IntPtr __Update_Active_Variables_NativeFunctionPtr;

		// Token: 0x0400F720 RID: 63264
		private static IntPtr __Set_Sun_and_Moon_Rotation_NativeFunctionPtr;

		// Token: 0x0400F721 RID: 63265
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F722 RID: 63266
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F723 RID: 63267
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F724 RID: 63268
		private static IntPtr __Midnight_NativeFunctionPtr;

		// Token: 0x02009B65 RID: 39781
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3008)]
		protected ref struct __ConstructionScript_Function_FunctionParams
		{
			// Token: 0x0403119C RID: 201116
			[FieldOffset(0)]
			public bool Run_By_Counterpart;
		}

		// Token: 0x02009B66 RID: 39782
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Set_Time_of_Day_using_Time_Code_FunctionParams
		{
			// Token: 0x0403119D RID: 201117
			[FieldOffset(0)]
			public FTimecode Time_Code;
		}

		// Token: 0x02009B67 RID: 39783
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __Get_Time_of_Day_in_Real_Time_Format_FunctionParams
		{
			// Token: 0x0403119E RID: 201118
			[FieldOffset(0)]
			public FTimecode Time;
		}

		// Token: 0x02009B68 RID: 39784
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 976)]
		protected ref struct __Set_Sun_and_Moon_Rotation_FunctionParams
		{
			// Token: 0x0403119F RID: 201119
			[FieldOffset(0)]
			public bool Move_Static_Lights;
		}

		// Token: 0x02009B69 RID: 39785
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311A0 RID: 201120
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
