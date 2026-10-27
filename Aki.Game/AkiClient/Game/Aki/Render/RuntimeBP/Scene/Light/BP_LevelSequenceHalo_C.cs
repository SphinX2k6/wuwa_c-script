using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Billboard;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B0F RID: 15119
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LevelSequenceHalo.BP_LevelSequenceHalo_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class BP_LevelSequenceHalo_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F6C RID: 135020 RVA: 0x008E15EF File Offset: 0x008DF7EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LevelSequenceHalo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LevelSequenceHalo.BP_LevelSequenceHalo_C");
			}
			return BP_LevelSequenceHalo_C._ClassPtr;
		}

		// Token: 0x06020F6D RID: 135021 RVA: 0x008E1614 File Offset: 0x008DF814
		public BP_LevelSequenceHalo_C() : this(BuiltinUtils.AllocNativeUObject(BP_LevelSequenceHalo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F6E RID: 135022 RVA: 0x008E163C File Offset: 0x008DF83C
		[NullableContext(1)]
		public BP_LevelSequenceHalo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LevelSequenceHalo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x06020F6F RID: 135023 RVA: 0x008E166F File Offset: 0x008DF86F
		// (set) Token: 0x06020F70 RID: 135024 RVA: 0x008E1683 File Offset: 0x008DF883
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x06020F71 RID: 135025 RVA: 0x008E1698 File Offset: 0x008DF898
		// (set) Token: 0x06020F72 RID: 135026 RVA: 0x008E16AC File Offset: 0x008DF8AC
		public unsafe UKuroHaloComponent KuroHalo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroHaloComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x06020F73 RID: 135027 RVA: 0x008E16C1 File Offset: 0x008DF8C1
		// (set) Token: 0x06020F74 RID: 135028 RVA: 0x008E16D5 File Offset: 0x008DF8D5
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x06020F75 RID: 135029 RVA: 0x008E16EA File Offset: 0x008DF8EA
		// (set) Token: 0x06020F76 RID: 135030 RVA: 0x008E16FA File Offset: 0x008DF8FA
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x06020F77 RID: 135031 RVA: 0x008E170B File Offset: 0x008DF90B
		// (set) Token: 0x06020F78 RID: 135032 RVA: 0x008E171B File Offset: 0x008DF91B
		public unsafe bool bAcceptGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x06020F79 RID: 135033 RVA: 0x008E172C File Offset: 0x008DF92C
		// (set) Token: 0x06020F7A RID: 135034 RVA: 0x008E173C File Offset: 0x008DF93C
		public unsafe float SizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x06020F7B RID: 135035 RVA: 0x008E174D File Offset: 0x008DF94D
		// (set) Token: 0x06020F7C RID: 135036 RVA: 0x008E175D File Offset: 0x008DF95D
		public unsafe float IntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x06020F7D RID: 135037 RVA: 0x008E176E File Offset: 0x008DF96E
		// (set) Token: 0x06020F7E RID: 135038 RVA: 0x008E177E File Offset: 0x008DF97E
		public unsafe float LightExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x06020F7F RID: 135039 RVA: 0x008E178F File Offset: 0x008DF98F
		// (set) Token: 0x06020F80 RID: 135040 RVA: 0x008E179F File Offset: 0x008DF99F
		public unsafe float FadeStartRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x06020F81 RID: 135041 RVA: 0x008E17B0 File Offset: 0x008DF9B0
		// (set) Token: 0x06020F82 RID: 135042 RVA: 0x008E17C0 File Offset: 0x008DF9C0
		public unsafe float FadeEndRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x06020F83 RID: 135043 RVA: 0x008E17D1 File Offset: 0x008DF9D1
		// (set) Token: 0x06020F84 RID: 135044 RVA: 0x008E17E5 File Offset: 0x008DF9E5
		public unsafe UKuroHaloComponent HaloComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroHaloComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x06020F85 RID: 135045 RVA: 0x008E17FA File Offset: 0x008DF9FA
		// (set) Token: 0x06020F86 RID: 135046 RVA: 0x008E180A File Offset: 0x008DFA0A
		public unsafe float DepthFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x06020F87 RID: 135047 RVA: 0x008E181B File Offset: 0x008DFA1B
		// (set) Token: 0x06020F88 RID: 135048 RVA: 0x008E182B File Offset: 0x008DFA2B
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x06020F89 RID: 135049 RVA: 0x008E183C File Offset: 0x008DFA3C
		// (set) Token: 0x06020F8A RID: 135050 RVA: 0x008E1850 File Offset: 0x008DFA50
		[Nullable(0)]
		public unsafe TEnumAsByte<E_BillboardMode> FaceCameraMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_14);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x06020F8B RID: 135051 RVA: 0x008E1865 File Offset: 0x008DFA65
		// (set) Token: 0x06020F8C RID: 135052 RVA: 0x008E1879 File Offset: 0x008DFA79
		public unsafe UStaticMesh HaloMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x06020F8D RID: 135053 RVA: 0x008E188E File Offset: 0x008DFA8E
		// (set) Token: 0x06020F8E RID: 135054 RVA: 0x008E189E File Offset: 0x008DFA9E
		public unsafe float MinDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x06020F8F RID: 135055 RVA: 0x008E18AF File Offset: 0x008DFAAF
		// (set) Token: 0x06020F90 RID: 135056 RVA: 0x008E18BF File Offset: 0x008DFABF
		public unsafe float MaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x06020F91 RID: 135057 RVA: 0x008E18D0 File Offset: 0x008DFAD0
		// (set) Token: 0x06020F92 RID: 135058 RVA: 0x008E18E0 File Offset: 0x008DFAE0
		public unsafe float MinDrawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x06020F93 RID: 135059 RVA: 0x008E18F1 File Offset: 0x008DFAF1
		// (set) Token: 0x06020F94 RID: 135060 RVA: 0x008E1901 File Offset: 0x008DFB01
		public unsafe float MaxDrawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x06020F95 RID: 135061 RVA: 0x008E1912 File Offset: 0x008DFB12
		// (set) Token: 0x06020F96 RID: 135062 RVA: 0x008E1922 File Offset: 0x008DFB22
		public unsafe float UseShapeTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x06020F97 RID: 135063 RVA: 0x008E1933 File Offset: 0x008DFB33
		// (set) Token: 0x06020F98 RID: 135064 RVA: 0x008E1947 File Offset: 0x008DFB47
		public unsafe UTexture2D VolumeTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x06020F99 RID: 135065 RVA: 0x008E195C File Offset: 0x008DFB5C
		// (set) Token: 0x06020F9A RID: 135066 RVA: 0x008E196C File Offset: 0x008DFB6C
		public unsafe float VolumeTexOnlyR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x06020F9B RID: 135067 RVA: 0x008E197D File Offset: 0x008DFB7D
		// (set) Token: 0x06020F9C RID: 135068 RVA: 0x008E198D File Offset: 0x008DFB8D
		public unsafe float VolumeTexDesaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x06020F9D RID: 135069 RVA: 0x008E199E File Offset: 0x008DFB9E
		// (set) Token: 0x06020F9E RID: 135070 RVA: 0x008E19B2 File Offset: 0x008DFBB2
		public unsafe FLinearColor VolumeTexUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x06020F9F RID: 135071 RVA: 0x008E19C7 File Offset: 0x008DFBC7
		// (set) Token: 0x06020FA0 RID: 135072 RVA: 0x008E19DB File Offset: 0x008DFBDB
		public unsafe FLinearColor VolumeTexUVSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x06020FA1 RID: 135073 RVA: 0x008E19F0 File Offset: 0x008DFBF0
		// (set) Token: 0x06020FA2 RID: 135074 RVA: 0x008E1A04 File Offset: 0x008DFC04
		public unsafe PD_HaloPointLightConfig_C HaloPointConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_HaloPointLightConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x06020FA3 RID: 135075 RVA: 0x008E1A19 File Offset: 0x008DFC19
		// (set) Token: 0x06020FA4 RID: 135076 RVA: 0x008E1A29 File Offset: 0x008DFC29
		public unsafe KuroFeatureLevel CurrentFeatureLevel
		{
			get
			{
				return (KuroFeatureLevel)(*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_27));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_27) = (byte)value;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x06020FA5 RID: 135077 RVA: 0x008E1A3A File Offset: 0x008DFC3A
		// (set) Token: 0x06020FA6 RID: 135078 RVA: 0x008E1A4A File Offset: 0x008DFC4A
		public unsafe float LightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x06020FA7 RID: 135079 RVA: 0x008E1A5B File Offset: 0x008DFC5B
		// (set) Token: 0x06020FA8 RID: 135080 RVA: 0x008E1A6F File Offset: 0x008DFC6F
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x06020FA9 RID: 135081 RVA: 0x008E1A84 File Offset: 0x008DFC84
		// (set) Token: 0x06020FAA RID: 135082 RVA: 0x008E1A94 File Offset: 0x008DFC94
		public unsafe float LightAttenRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x06020FAB RID: 135083 RVA: 0x008E1AA5 File Offset: 0x008DFCA5
		// (set) Token: 0x06020FAC RID: 135084 RVA: 0x008E1AB5 File Offset: 0x008DFCB5
		public unsafe float LightFalloffExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x06020FAD RID: 135085 RVA: 0x008E1AC6 File Offset: 0x008DFCC6
		// (set) Token: 0x06020FAE RID: 135086 RVA: 0x008E1AD6 File Offset: 0x008DFCD6
		public unsafe int TranslucentSortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x06020FAF RID: 135087 RVA: 0x008E1AE7 File Offset: 0x008DFCE7
		// (set) Token: 0x06020FB0 RID: 135088 RVA: 0x008E1AF7 File Offset: 0x008DFCF7
		public unsafe bool UseTranslucentMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x06020FB1 RID: 135089 RVA: 0x008E1B08 File Offset: 0x008DFD08
		// (set) Token: 0x06020FB2 RID: 135090 RVA: 0x008E1B1C File Offset: 0x008DFD1C
		public unsafe UMaterialInterface MI_PointLightHalo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x06020FB3 RID: 135091 RVA: 0x008E1B31 File Offset: 0x008DFD31
		// (set) Token: 0x06020FB4 RID: 135092 RVA: 0x008E1B45 File Offset: 0x008DFD45
		public unsafe UMaterialInterface MI_PointLightHalo_Translucent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x06020FB5 RID: 135093 RVA: 0x008E1B5A File Offset: 0x008DFD5A
		// (set) Token: 0x06020FB6 RID: 135094 RVA: 0x008E1B6E File Offset: 0x008DFD6E
		public unsafe UMaterialInterface MI_PointLightHalo_Translucent_DOF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x06020FB7 RID: 135095 RVA: 0x008E1B83 File Offset: 0x008DFD83
		// (set) Token: 0x06020FB8 RID: 135096 RVA: 0x008E1B97 File Offset: 0x008DFD97
		public unsafe UMaterialInterface MI_PointLightHalo_Plus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x06020FB9 RID: 135097 RVA: 0x008E1BAC File Offset: 0x008DFDAC
		// (set) Token: 0x06020FBA RID: 135098 RVA: 0x008E1BC0 File Offset: 0x008DFDC0
		public unsafe UMaterialInterface MI_PointLightHalo_Translucent_Plus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x06020FBB RID: 135099 RVA: 0x008E1BD5 File Offset: 0x008DFDD5
		// (set) Token: 0x06020FBC RID: 135100 RVA: 0x008E1BE9 File Offset: 0x008DFDE9
		public unsafe UMaterialInterface MI_PointLightHalo_Translucent_DOF_Plus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x06020FBD RID: 135101 RVA: 0x008E1C00 File Offset: 0x008DFE00
		// (set) Token: 0x06020FBE RID: 135102 RVA: 0x008E1C39 File Offset: 0x008DFE39
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_40, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x06020FBF RID: 135103 RVA: 0x008E1C48 File Offset: 0x008DFE48
		// (set) Token: 0x06020FC0 RID: 135104 RVA: 0x008E1C81 File Offset: 0x008DFE81
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_41, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x06020FC1 RID: 135105 RVA: 0x008E1C90 File Offset: 0x008DFE90
		// (set) Token: 0x06020FC2 RID: 135106 RVA: 0x008E1CC9 File Offset: 0x008DFEC9
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_42, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x06020FC3 RID: 135107 RVA: 0x008E1CD7 File Offset: 0x008DFED7
		// (set) Token: 0x06020FC4 RID: 135108 RVA: 0x008E1CE7 File Offset: 0x008DFEE7
		public unsafe float AcceptGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x06020FC5 RID: 135109 RVA: 0x008E1CF8 File Offset: 0x008DFEF8
		// (set) Token: 0x06020FC6 RID: 135110 RVA: 0x008E1D08 File Offset: 0x008DFF08
		public unsafe bool Use_DOF_Material
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x06020FC7 RID: 135111 RVA: 0x008E1D19 File Offset: 0x008DFF19
		// (set) Token: 0x06020FC8 RID: 135112 RVA: 0x008E1D29 File Offset: 0x008DFF29
		public unsafe bool 移动端低画质以上生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x06020FC9 RID: 135113 RVA: 0x008E1D3A File Offset: 0x008DFF3A
		// (set) Token: 0x06020FCA RID: 135114 RVA: 0x008E1D4E File Offset: 0x008DFF4E
		public unsafe UTexture NoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x06020FCB RID: 135115 RVA: 0x008E1D63 File Offset: 0x008DFF63
		// (set) Token: 0x06020FCC RID: 135116 RVA: 0x008E1D77 File Offset: 0x008DFF77
		public unsafe FLinearColor NoiseTexUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x06020FCD RID: 135117 RVA: 0x008E1D8C File Offset: 0x008DFF8C
		// (set) Token: 0x06020FCE RID: 135118 RVA: 0x008E1D9C File Offset: 0x008DFF9C
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x06020FCF RID: 135119 RVA: 0x008E1DAD File Offset: 0x008DFFAD
		// (set) Token: 0x06020FD0 RID: 135120 RVA: 0x008E1DBD File Offset: 0x008DFFBD
		public unsafe bool 替换材质开关
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LevelSequenceHalo_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x06020FD1 RID: 135121 RVA: 0x008E1DCE File Offset: 0x008DFFCE
		// (set) Token: 0x06020FD2 RID: 135122 RVA: 0x008E1DE2 File Offset: 0x008DFFE2
		public unsafe UMaterialInterface 替换材质
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LevelSequenceHalo_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x06020FD3 RID: 135123 RVA: 0x008E1DF8 File Offset: 0x008DFFF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLightQualityMaterial(UPrimitiveComponent HaloComponent, bool UseTranslucentMaterial, bool Use_DOF_Material, UMaterialInterface M_PointLightHalo_Translucent_DOF, UMaterialInterface M_PointLightHalo_Translucent, UMaterialInterface M_PointLightHalo)
		{
			BP_LevelSequenceHalo_C.__SetLightQualityMaterial_FunctionParams* ptr = stackalloc BP_LevelSequenceHalo_C.__SetLightQualityMaterial_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_LevelSequenceHalo_C.__SetLightQualityMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LevelSequenceHalo_C.__SetLightQualityMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HaloComponent = ((HaloComponent != null) ? HaloComponent.NativePtr : IntPtr.Zero);
			ptr->UseTranslucentMaterial = UseTranslucentMaterial;
			ptr->Use_DOF_Material = Use_DOF_Material;
			ptr->M_PointLightHalo_Translucent_DOF = ((M_PointLightHalo_Translucent_DOF != null) ? M_PointLightHalo_Translucent_DOF.NativePtr : IntPtr.Zero);
			ptr->M_PointLightHalo_Translucent = ((M_PointLightHalo_Translucent != null) ? M_PointLightHalo_Translucent.NativePtr : IntPtr.Zero);
			ptr->M_PointLightHalo = ((M_PointLightHalo != null) ? M_PointLightHalo.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__SetLightQualityMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD4 RID: 135124 RVA: 0x008E1EA3 File Offset: 0x008E00A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__UpdateEditor_NativeFunctionPtr, null);
		}

		// Token: 0x06020FD5 RID: 135125 RVA: 0x008E1EB7 File Offset: 0x008E00B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06020FD6 RID: 135126 RVA: 0x008E1ECC File Offset: 0x008E00CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetHaloDrawParameters(ref float MinDrawDistance, ref float MaxDrawDistance, ref float MinDrawRange, ref float MaxDrawRange)
		{
			BP_LevelSequenceHalo_C.__GetHaloDrawParameters_FunctionParams* ptr = stackalloc BP_LevelSequenceHalo_C.__GetHaloDrawParameters_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_LevelSequenceHalo_C.__GetHaloDrawParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LevelSequenceHalo_C.__GetHaloDrawParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MinDrawDistance = MinDrawDistance;
			ptr->MaxDrawDistance = MaxDrawDistance;
			ptr->MinDrawRange = MinDrawRange;
			ptr->MaxDrawRange = MaxDrawRange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__GetHaloDrawParameters_NativeFunctionPtr, (void*)ptr);
			MinDrawDistance = ptr->MinDrawDistance;
			MaxDrawDistance = ptr->MaxDrawDistance;
			MinDrawRange = ptr->MinDrawRange;
			MaxDrawRange = ptr->MaxDrawRange;
		}

		// Token: 0x06020FD7 RID: 135127 RVA: 0x008E1F50 File Offset: 0x008E0150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateHaloParameter(bool UpdateComponent)
		{
			BP_LevelSequenceHalo_C.__UpdateHaloParameter_FunctionParams* ptr = stackalloc BP_LevelSequenceHalo_C.__UpdateHaloParameter_FunctionParams[(UIntPtr)303] + 15L / (long)sizeof(BP_LevelSequenceHalo_C.__UpdateHaloParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LevelSequenceHalo_C.__UpdateHaloParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UpdateComponent = UpdateComponent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__UpdateHaloParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD8 RID: 135128 RVA: 0x008E1F99 File Offset: 0x008E0199
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020FD9 RID: 135129 RVA: 0x008E1FAD File Offset: 0x008E01AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020FDA RID: 135130 RVA: 0x008E1FC2 File Offset: 0x008E01C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020FDB RID: 135131 RVA: 0x008E1FD6 File Offset: 0x008E01D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020FDC RID: 135132 RVA: 0x008E1FEC File Offset: 0x008E01EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LevelSequenceHalo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LevelSequenceHalo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LevelSequenceHalo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LevelSequenceHalo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FDD RID: 135133 RVA: 0x008E2034 File Offset: 0x008E0234
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LevelSequenceHalo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LevelSequenceHalo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LevelSequenceHalo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LevelSequenceHalo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LevelSequenceHalo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020FDE RID: 135134 RVA: 0x008E207B File Offset: 0x008E027B
		protected BP_LevelSequenceHalo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401006D RID: 65645
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LevelSequenceHalo.BP_LevelSequenceHalo_C";

		// Token: 0x0401006E RID: 65646
		private static IntPtr _ClassPtr;

		// Token: 0x0401006F RID: 65647
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010070 RID: 65648
		internal static int __PropertyOffset_1;

		// Token: 0x04010071 RID: 65649
		internal static int __PropertyOffset_2;

		// Token: 0x04010072 RID: 65650
		internal static int __PropertyOffset_3;

		// Token: 0x04010073 RID: 65651
		internal static int __PropertyOffset_4;

		// Token: 0x04010074 RID: 65652
		internal static int __PropertyOffset_5;

		// Token: 0x04010075 RID: 65653
		internal static int __PropertyOffset_6;

		// Token: 0x04010076 RID: 65654
		internal static int __PropertyOffset_7;

		// Token: 0x04010077 RID: 65655
		internal static int __PropertyOffset_8;

		// Token: 0x04010078 RID: 65656
		internal static int __PropertyOffset_9;

		// Token: 0x04010079 RID: 65657
		internal static int __PropertyOffset_10;

		// Token: 0x0401007A RID: 65658
		internal static int __PropertyOffset_11;

		// Token: 0x0401007B RID: 65659
		internal static int __PropertyOffset_12;

		// Token: 0x0401007C RID: 65660
		internal static int __PropertyOffset_13;

		// Token: 0x0401007D RID: 65661
		internal static int __PropertyOffset_14;

		// Token: 0x0401007E RID: 65662
		internal static int __PropertyOffset_15;

		// Token: 0x0401007F RID: 65663
		internal static int __PropertyOffset_16;

		// Token: 0x04010080 RID: 65664
		internal static int __PropertyOffset_17;

		// Token: 0x04010081 RID: 65665
		internal static int __PropertyOffset_18;

		// Token: 0x04010082 RID: 65666
		internal static int __PropertyOffset_19;

		// Token: 0x04010083 RID: 65667
		internal static int __PropertyOffset_20;

		// Token: 0x04010084 RID: 65668
		internal static int __PropertyOffset_21;

		// Token: 0x04010085 RID: 65669
		internal static int __PropertyOffset_22;

		// Token: 0x04010086 RID: 65670
		internal static int __PropertyOffset_23;

		// Token: 0x04010087 RID: 65671
		internal static int __PropertyOffset_24;

		// Token: 0x04010088 RID: 65672
		internal static int __PropertyOffset_25;

		// Token: 0x04010089 RID: 65673
		internal static int __PropertyOffset_26;

		// Token: 0x0401008A RID: 65674
		internal static int __PropertyOffset_27;

		// Token: 0x0401008B RID: 65675
		internal static int __PropertyOffset_28;

		// Token: 0x0401008C RID: 65676
		internal static int __PropertyOffset_29;

		// Token: 0x0401008D RID: 65677
		internal static int __PropertyOffset_30;

		// Token: 0x0401008E RID: 65678
		internal static int __PropertyOffset_31;

		// Token: 0x0401008F RID: 65679
		internal static int __PropertyOffset_32;

		// Token: 0x04010090 RID: 65680
		internal static int __PropertyOffset_33;

		// Token: 0x04010091 RID: 65681
		internal static int __PropertyOffset_34;

		// Token: 0x04010092 RID: 65682
		internal static int __PropertyOffset_35;

		// Token: 0x04010093 RID: 65683
		internal static int __PropertyOffset_36;

		// Token: 0x04010094 RID: 65684
		internal static int __PropertyOffset_37;

		// Token: 0x04010095 RID: 65685
		internal static int __PropertyOffset_38;

		// Token: 0x04010096 RID: 65686
		internal static int __PropertyOffset_39;

		// Token: 0x04010097 RID: 65687
		internal static int __PropertyOffset_40;

		// Token: 0x04010098 RID: 65688
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04010099 RID: 65689
		internal static int __PropertyOffset_41;

		// Token: 0x0401009A RID: 65690
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0401009B RID: 65691
		internal static int __PropertyOffset_42;

		// Token: 0x0401009C RID: 65692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0401009D RID: 65693
		internal static int __PropertyOffset_43;

		// Token: 0x0401009E RID: 65694
		internal static int __PropertyOffset_44;

		// Token: 0x0401009F RID: 65695
		internal static int __PropertyOffset_45;

		// Token: 0x040100A0 RID: 65696
		internal static int __PropertyOffset_46;

		// Token: 0x040100A1 RID: 65697
		internal static int __PropertyOffset_47;

		// Token: 0x040100A2 RID: 65698
		internal static int __PropertyOffset_48;

		// Token: 0x040100A3 RID: 65699
		internal static int __PropertyOffset_49;

		// Token: 0x040100A4 RID: 65700
		internal static int __PropertyOffset_50;

		// Token: 0x040100A5 RID: 65701
		private static IntPtr __SetLightQualityMaterial_NativeFunctionPtr;

		// Token: 0x040100A6 RID: 65702
		private static IntPtr __UpdateEditor_NativeFunctionPtr;

		// Token: 0x040100A7 RID: 65703
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x040100A8 RID: 65704
		private static IntPtr __GetHaloDrawParameters_NativeFunctionPtr;

		// Token: 0x040100A9 RID: 65705
		private static IntPtr __UpdateHaloParameter_NativeFunctionPtr;

		// Token: 0x040100AA RID: 65706
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040100AB RID: 65707
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040100AC RID: 65708
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C53 RID: 40019
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetLightQualityMaterial_FunctionParams
		{
			// Token: 0x04031307 RID: 201479
			[FieldOffset(0)]
			public IntPtr HaloComponent;

			// Token: 0x04031308 RID: 201480
			[FieldOffset(8)]
			public bool UseTranslucentMaterial;

			// Token: 0x04031309 RID: 201481
			[FieldOffset(9)]
			public bool Use_DOF_Material;

			// Token: 0x0403130A RID: 201482
			[FieldOffset(16)]
			public IntPtr M_PointLightHalo_Translucent_DOF;

			// Token: 0x0403130B RID: 201483
			[FieldOffset(24)]
			public IntPtr M_PointLightHalo_Translucent;

			// Token: 0x0403130C RID: 201484
			[FieldOffset(32)]
			public IntPtr M_PointLightHalo;
		}

		// Token: 0x02009C54 RID: 40020
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetHaloDrawParameters_FunctionParams
		{
			// Token: 0x0403130D RID: 201485
			[FieldOffset(0)]
			public float MinDrawDistance;

			// Token: 0x0403130E RID: 201486
			[FieldOffset(4)]
			public float MaxDrawDistance;

			// Token: 0x0403130F RID: 201487
			[FieldOffset(8)]
			public float MinDrawRange;

			// Token: 0x04031310 RID: 201488
			[FieldOffset(12)]
			public float MaxDrawRange;
		}

		// Token: 0x02009C55 RID: 40021
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 288)]
		protected ref struct __UpdateHaloParameter_FunctionParams
		{
			// Token: 0x04031311 RID: 201489
			[FieldOffset(0)]
			public bool UpdateComponent;
		}

		// Token: 0x02009C56 RID: 40022
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031312 RID: 201490
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
