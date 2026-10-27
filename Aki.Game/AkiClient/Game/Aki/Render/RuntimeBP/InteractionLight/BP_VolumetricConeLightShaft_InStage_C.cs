using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.InteractionLight
{
	// Token: 0x02003D25 RID: 15653
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/InteractionLight/BP_VolumetricConeLightShaft_InStage.BP_VolumetricConeLightShaft_InStage_C")]
	[UnrealStructLayout(2880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class BP_VolumetricConeLightShaft_InStage_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060259BF RID: 154047 RVA: 0x0095E701 File Offset: 0x0095C901
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_InStage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/InteractionLight/BP_VolumetricConeLightShaft_InStage.BP_VolumetricConeLightShaft_InStage_C");
			}
			return BP_VolumetricConeLightShaft_InStage_C._ClassPtr;
		}

		// Token: 0x060259C0 RID: 154048 RVA: 0x0095E728 File Offset: 0x0095C928
		public BP_VolumetricConeLightShaft_InStage_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InStage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060259C1 RID: 154049 RVA: 0x0095E750 File Offset: 0x0095C950
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_InStage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InStage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x060259C2 RID: 154050 RVA: 0x0095E783 File Offset: 0x0095C983
		// (set) Token: 0x060259C3 RID: 154051 RVA: 0x0095E797 File Offset: 0x0095C997
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x060259C4 RID: 154052 RVA: 0x0095E7AC File Offset: 0x0095C9AC
		// (set) Token: 0x060259C5 RID: 154053 RVA: 0x0095E7C0 File Offset: 0x0095C9C0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x060259C6 RID: 154054 RVA: 0x0095E7D5 File Offset: 0x0095C9D5
		// (set) Token: 0x060259C7 RID: 154055 RVA: 0x0095E7E9 File Offset: 0x0095C9E9
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x060259C8 RID: 154056 RVA: 0x0095E7FE File Offset: 0x0095C9FE
		// (set) Token: 0x060259C9 RID: 154057 RVA: 0x0095E812 File Offset: 0x0095CA12
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x060259CA RID: 154058 RVA: 0x0095E827 File Offset: 0x0095CA27
		// (set) Token: 0x060259CB RID: 154059 RVA: 0x0095E83B File Offset: 0x0095CA3B
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x060259CC RID: 154060 RVA: 0x0095E850 File Offset: 0x0095CA50
		// (set) Token: 0x060259CD RID: 154061 RVA: 0x0095E864 File Offset: 0x0095CA64
		public unsafe FVector VolumetriConeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004D98 RID: 19864
		// (get) Token: 0x060259CE RID: 154062 RVA: 0x0095E879 File Offset: 0x0095CA79
		// (set) Token: 0x060259CF RID: 154063 RVA: 0x0095E889 File Offset: 0x0095CA89
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D99 RID: 19865
		// (get) Token: 0x060259D0 RID: 154064 RVA: 0x0095E89A File Offset: 0x0095CA9A
		// (set) Token: 0x060259D1 RID: 154065 RVA: 0x0095E8AA File Offset: 0x0095CAAA
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D9A RID: 19866
		// (get) Token: 0x060259D2 RID: 154066 RVA: 0x0095E8BB File Offset: 0x0095CABB
		// (set) Token: 0x060259D3 RID: 154067 RVA: 0x0095E8CB File Offset: 0x0095CACB
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D9B RID: 19867
		// (get) Token: 0x060259D4 RID: 154068 RVA: 0x0095E8DC File Offset: 0x0095CADC
		// (set) Token: 0x060259D5 RID: 154069 RVA: 0x0095E8EC File Offset: 0x0095CAEC
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004D9C RID: 19868
		// (get) Token: 0x060259D6 RID: 154070 RVA: 0x0095E8FD File Offset: 0x0095CAFD
		// (set) Token: 0x060259D7 RID: 154071 RVA: 0x0095E90D File Offset: 0x0095CB0D
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004D9D RID: 19869
		// (get) Token: 0x060259D8 RID: 154072 RVA: 0x0095E91E File Offset: 0x0095CB1E
		// (set) Token: 0x060259D9 RID: 154073 RVA: 0x0095E92E File Offset: 0x0095CB2E
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x060259DA RID: 154074 RVA: 0x0095E93F File Offset: 0x0095CB3F
		// (set) Token: 0x060259DB RID: 154075 RVA: 0x0095E94F File Offset: 0x0095CB4F
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004D9F RID: 19871
		// (get) Token: 0x060259DC RID: 154076 RVA: 0x0095E960 File Offset: 0x0095CB60
		// (set) Token: 0x060259DD RID: 154077 RVA: 0x0095E974 File Offset: 0x0095CB74
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004DA0 RID: 19872
		// (get) Token: 0x060259DE RID: 154078 RVA: 0x0095E989 File Offset: 0x0095CB89
		// (set) Token: 0x060259DF RID: 154079 RVA: 0x0095E99D File Offset: 0x0095CB9D
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004DA1 RID: 19873
		// (get) Token: 0x060259E0 RID: 154080 RVA: 0x0095E9B2 File Offset: 0x0095CBB2
		// (set) Token: 0x060259E1 RID: 154081 RVA: 0x0095E9C2 File Offset: 0x0095CBC2
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004DA2 RID: 19874
		// (get) Token: 0x060259E2 RID: 154082 RVA: 0x0095E9D3 File Offset: 0x0095CBD3
		// (set) Token: 0x060259E3 RID: 154083 RVA: 0x0095E9E3 File Offset: 0x0095CBE3
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004DA3 RID: 19875
		// (get) Token: 0x060259E4 RID: 154084 RVA: 0x0095E9F4 File Offset: 0x0095CBF4
		// (set) Token: 0x060259E5 RID: 154085 RVA: 0x0095EA04 File Offset: 0x0095CC04
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004DA4 RID: 19876
		// (get) Token: 0x060259E6 RID: 154086 RVA: 0x0095EA15 File Offset: 0x0095CC15
		// (set) Token: 0x060259E7 RID: 154087 RVA: 0x0095EA25 File Offset: 0x0095CC25
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004DA5 RID: 19877
		// (get) Token: 0x060259E8 RID: 154088 RVA: 0x0095EA36 File Offset: 0x0095CC36
		// (set) Token: 0x060259E9 RID: 154089 RVA: 0x0095EA46 File Offset: 0x0095CC46
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004DA6 RID: 19878
		// (get) Token: 0x060259EA RID: 154090 RVA: 0x0095EA57 File Offset: 0x0095CC57
		// (set) Token: 0x060259EB RID: 154091 RVA: 0x0095EA67 File Offset: 0x0095CC67
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004DA7 RID: 19879
		// (get) Token: 0x060259EC RID: 154092 RVA: 0x0095EA78 File Offset: 0x0095CC78
		// (set) Token: 0x060259ED RID: 154093 RVA: 0x0095EA8C File Offset: 0x0095CC8C
		public unsafe FVector LightShaftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004DA8 RID: 19880
		// (get) Token: 0x060259EE RID: 154094 RVA: 0x0095EAA1 File Offset: 0x0095CCA1
		// (set) Token: 0x060259EF RID: 154095 RVA: 0x0095EAB5 File Offset: 0x0095CCB5
		public unsafe UStaticMesh LightShaftStaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17004DA9 RID: 19881
		// (get) Token: 0x060259F0 RID: 154096 RVA: 0x0095EACA File Offset: 0x0095CCCA
		// (set) Token: 0x060259F1 RID: 154097 RVA: 0x0095EADE File Offset: 0x0095CCDE
		public unsafe UMaterialInstance LightShaftCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17004DAA RID: 19882
		// (get) Token: 0x060259F2 RID: 154098 RVA: 0x0095EAF3 File Offset: 0x0095CCF3
		// (set) Token: 0x060259F3 RID: 154099 RVA: 0x0095EB07 File Offset: 0x0095CD07
		public unsafe UTexture2D Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17004DAB RID: 19883
		// (get) Token: 0x060259F4 RID: 154100 RVA: 0x0095EB1C File Offset: 0x0095CD1C
		// (set) Token: 0x060259F5 RID: 154101 RVA: 0x0095EB30 File Offset: 0x0095CD30
		public unsafe FLinearColor FallOff_ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004DAC RID: 19884
		// (get) Token: 0x060259F6 RID: 154102 RVA: 0x0095EB45 File Offset: 0x0095CD45
		// (set) Token: 0x060259F7 RID: 154103 RVA: 0x0095EB55 File Offset: 0x0095CD55
		public unsafe float FallOff_DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004DAD RID: 19885
		// (get) Token: 0x060259F8 RID: 154104 RVA: 0x0095EB66 File Offset: 0x0095CD66
		// (set) Token: 0x060259F9 RID: 154105 RVA: 0x0095EB76 File Offset: 0x0095CD76
		public unsafe float ScreenFadeFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004DAE RID: 19886
		// (get) Token: 0x060259FA RID: 154106 RVA: 0x0095EB87 File Offset: 0x0095CD87
		// (set) Token: 0x060259FB RID: 154107 RVA: 0x0095EB97 File Offset: 0x0095CD97
		public unsafe float Opacity_CenterPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004DAF RID: 19887
		// (get) Token: 0x060259FC RID: 154108 RVA: 0x0095EBA8 File Offset: 0x0095CDA8
		// (set) Token: 0x060259FD RID: 154109 RVA: 0x0095EBB8 File Offset: 0x0095CDB8
		public unsafe float ScreenFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004DB0 RID: 19888
		// (get) Token: 0x060259FE RID: 154110 RVA: 0x0095EBC9 File Offset: 0x0095CDC9
		// (set) Token: 0x060259FF RID: 154111 RVA: 0x0095EBD9 File Offset: 0x0095CDD9
		public unsafe float ShaftTopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004DB1 RID: 19889
		// (get) Token: 0x06025A00 RID: 154112 RVA: 0x0095EBEA File Offset: 0x0095CDEA
		// (set) Token: 0x06025A01 RID: 154113 RVA: 0x0095EBFE File Offset: 0x0095CDFE
		public unsafe FLinearColor UVScaleAndAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004DB2 RID: 19890
		// (get) Token: 0x06025A02 RID: 154114 RVA: 0x0095EC13 File Offset: 0x0095CE13
		// (set) Token: 0x06025A03 RID: 154115 RVA: 0x0095EC27 File Offset: 0x0095CE27
		public unsafe UStaticMesh LightMaskStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17004DB3 RID: 19891
		// (get) Token: 0x06025A04 RID: 154116 RVA: 0x0095EC3C File Offset: 0x0095CE3C
		// (set) Token: 0x06025A05 RID: 154117 RVA: 0x0095EC4C File Offset: 0x0095CE4C
		public unsafe float LightMaskZaxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004DB4 RID: 19892
		// (get) Token: 0x06025A06 RID: 154118 RVA: 0x0095EC5D File Offset: 0x0095CE5D
		// (set) Token: 0x06025A07 RID: 154119 RVA: 0x0095EC71 File Offset: 0x0095CE71
		public unsafe UMaterialInstance LightMaskMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17004DB5 RID: 19893
		// (get) Token: 0x06025A08 RID: 154120 RVA: 0x0095EC86 File Offset: 0x0095CE86
		// (set) Token: 0x06025A09 RID: 154121 RVA: 0x0095EC9A File Offset: 0x0095CE9A
		public unsafe FVector LightMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17004DB6 RID: 19894
		// (get) Token: 0x06025A0A RID: 154122 RVA: 0x0095ECAF File Offset: 0x0095CEAF
		// (set) Token: 0x06025A0B RID: 154123 RVA: 0x0095ECC3 File Offset: 0x0095CEC3
		public unsafe FLinearColor LightMaskColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17004DB7 RID: 19895
		// (get) Token: 0x06025A0C RID: 154124 RVA: 0x0095ECD8 File Offset: 0x0095CED8
		// (set) Token: 0x06025A0D RID: 154125 RVA: 0x0095ECEC File Offset: 0x0095CEEC
		public unsafe UTexture2D LightMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x17004DB8 RID: 19896
		// (get) Token: 0x06025A0E RID: 154126 RVA: 0x0095ED01 File Offset: 0x0095CF01
		// (set) Token: 0x06025A0F RID: 154127 RVA: 0x0095ED11 File Offset: 0x0095CF11
		public unsafe float ColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17004DB9 RID: 19897
		// (get) Token: 0x06025A10 RID: 154128 RVA: 0x0095ED22 File Offset: 0x0095CF22
		// (set) Token: 0x06025A11 RID: 154129 RVA: 0x0095ED32 File Offset: 0x0095CF32
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17004DBA RID: 19898
		// (get) Token: 0x06025A12 RID: 154130 RVA: 0x0095ED43 File Offset: 0x0095CF43
		// (set) Token: 0x06025A13 RID: 154131 RVA: 0x0095ED53 File Offset: 0x0095CF53
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17004DBB RID: 19899
		// (get) Token: 0x06025A14 RID: 154132 RVA: 0x0095ED64 File Offset: 0x0095CF64
		// (set) Token: 0x06025A15 RID: 154133 RVA: 0x0095ED74 File Offset: 0x0095CF74
		public unsafe float FlankInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004DBC RID: 19900
		// (get) Token: 0x06025A16 RID: 154134 RVA: 0x0095ED85 File Offset: 0x0095CF85
		// (set) Token: 0x06025A17 RID: 154135 RVA: 0x0095ED95 File Offset: 0x0095CF95
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17004DBD RID: 19901
		// (get) Token: 0x06025A18 RID: 154136 RVA: 0x0095EDA6 File Offset: 0x0095CFA6
		// (set) Token: 0x06025A19 RID: 154137 RVA: 0x0095EDB6 File Offset: 0x0095CFB6
		public unsafe float RightSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17004DBE RID: 19902
		// (get) Token: 0x06025A1A RID: 154138 RVA: 0x0095EDC7 File Offset: 0x0095CFC7
		// (set) Token: 0x06025A1B RID: 154139 RVA: 0x0095EDDB File Offset: 0x0095CFDB
		public unsafe FVector CenterLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17004DBF RID: 19903
		// (get) Token: 0x06025A1C RID: 154140 RVA: 0x0095EDF0 File Offset: 0x0095CFF0
		// (set) Token: 0x06025A1D RID: 154141 RVA: 0x0095EE04 File Offset: 0x0095D004
		public unsafe UTexture MainNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x17004DC0 RID: 19904
		// (get) Token: 0x06025A1E RID: 154142 RVA: 0x0095EE19 File Offset: 0x0095D019
		// (set) Token: 0x06025A1F RID: 154143 RVA: 0x0095EE2D File Offset: 0x0095D02D
		public unsafe UTexture SecondNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17004DC1 RID: 19905
		// (get) Token: 0x06025A20 RID: 154144 RVA: 0x0095EE42 File Offset: 0x0095D042
		// (set) Token: 0x06025A21 RID: 154145 RVA: 0x0095EE56 File Offset: 0x0095D056
		public unsafe FLinearColor MainNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17004DC2 RID: 19906
		// (get) Token: 0x06025A22 RID: 154146 RVA: 0x0095EE6B File Offset: 0x0095D06B
		// (set) Token: 0x06025A23 RID: 154147 RVA: 0x0095EE7F File Offset: 0x0095D07F
		public unsafe FLinearColor SecondNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x06025A24 RID: 154148 RVA: 0x0095EE94 File Offset: 0x0095D094
		// (set) Token: 0x06025A25 RID: 154149 RVA: 0x0095EEA4 File Offset: 0x0095D0A4
		public unsafe float MainUVAddStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x06025A26 RID: 154150 RVA: 0x0095EEB5 File Offset: 0x0095D0B5
		// (set) Token: 0x06025A27 RID: 154151 RVA: 0x0095EEC9 File Offset: 0x0095D0C9
		public unsafe FLinearColor MainNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x06025A28 RID: 154152 RVA: 0x0095EEDE File Offset: 0x0095D0DE
		// (set) Token: 0x06025A29 RID: 154153 RVA: 0x0095EEF2 File Offset: 0x0095D0F2
		public unsafe FLinearColor SecondNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x06025A2A RID: 154154 RVA: 0x0095EF08 File Offset: 0x0095D108
		// (set) Token: 0x06025A2B RID: 154155 RVA: 0x0095EF41 File Offset: 0x0095D141
		[Nullable(1)]
		public TMap<FName, float> MaterialInstanceB_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MaterialInstanceB_Scalars) == null)
				{
					result = (this._MaterialInstanceB_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_53, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x06025A2C RID: 154156 RVA: 0x0095EF50 File Offset: 0x0095D150
		// (set) Token: 0x06025A2D RID: 154157 RVA: 0x0095EF89 File Offset: 0x0095D189
		[Nullable(1)]
		public TMap<FName, FLinearColor> MaterialInstanceB_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._MaterialInstanceB_Vectors) == null)
				{
					result = (this._MaterialInstanceB_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_54, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x06025A2E RID: 154158 RVA: 0x0095EF98 File Offset: 0x0095D198
		// (set) Token: 0x06025A2F RID: 154159 RVA: 0x0095EFD1 File Offset: 0x0095D1D1
		[Nullable(1)]
		public TMap<FName, UTexture> MaterialInstanceB_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._MaterialInstanceB_Textures) == null)
				{
					result = (this._MaterialInstanceB_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_55, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x06025A30 RID: 154160 RVA: 0x0095EFE0 File Offset: 0x0095D1E0
		// (set) Token: 0x06025A31 RID: 154161 RVA: 0x0095F019 File Offset: 0x0095D219
		[Nullable(1)]
		public TMap<FName, float> MaterialInstance_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MaterialInstance_Scalars) == null)
				{
					result = (this._MaterialInstance_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_56, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x06025A32 RID: 154162 RVA: 0x0095F028 File Offset: 0x0095D228
		// (set) Token: 0x06025A33 RID: 154163 RVA: 0x0095F061 File Offset: 0x0095D261
		[Nullable(1)]
		public TMap<FName, FLinearColor> MaterialInstance_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._MaterialInstance_Vectors) == null)
				{
					result = (this._MaterialInstance_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_57, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x06025A34 RID: 154164 RVA: 0x0095F070 File Offset: 0x0095D270
		// (set) Token: 0x06025A35 RID: 154165 RVA: 0x0095F0A9 File Offset: 0x0095D2A9
		[Nullable(1)]
		public TMap<FName, UTexture> MaterialInstance_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._MaterialInstance_Textures) == null)
				{
					result = (this._MaterialInstance_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_58, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x06025A36 RID: 154166 RVA: 0x0095F0B8 File Offset: 0x0095D2B8
		// (set) Token: 0x06025A37 RID: 154167 RVA: 0x0095F0F1 File Offset: 0x0095D2F1
		[Nullable(1)]
		public TMap<FName, float> LightShaftCone_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._LightShaftCone_Scalars) == null)
				{
					result = (this._LightShaftCone_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_59, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17004DCD RID: 19917
		// (get) Token: 0x06025A38 RID: 154168 RVA: 0x0095F100 File Offset: 0x0095D300
		// (set) Token: 0x06025A39 RID: 154169 RVA: 0x0095F139 File Offset: 0x0095D339
		[Nullable(1)]
		public TMap<FName, FLinearColor> LightShaftCone_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LightShaftCone_Vectors) == null)
				{
					result = (this._LightShaftCone_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_60, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17004DCE RID: 19918
		// (get) Token: 0x06025A3A RID: 154170 RVA: 0x0095F148 File Offset: 0x0095D348
		// (set) Token: 0x06025A3B RID: 154171 RVA: 0x0095F181 File Offset: 0x0095D381
		[Nullable(1)]
		public TMap<FName, UTexture> LightShaftCone_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._LightShaftCone_Textures) == null)
				{
					result = (this._LightShaftCone_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_61, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x06025A3C RID: 154172 RVA: 0x0095F190 File Offset: 0x0095D390
		// (set) Token: 0x06025A3D RID: 154173 RVA: 0x0095F1C9 File Offset: 0x0095D3C9
		[Nullable(1)]
		public TMap<FName, float> LightMaskMaterial_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._LightMaskMaterial_Scalars) == null)
				{
					result = (this._LightMaskMaterial_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_62, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x06025A3E RID: 154174 RVA: 0x0095F1D8 File Offset: 0x0095D3D8
		// (set) Token: 0x06025A3F RID: 154175 RVA: 0x0095F211 File Offset: 0x0095D411
		[Nullable(1)]
		public TMap<FName, FLinearColor> LightMaskMaterial_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LightMaskMaterial_Vectors) == null)
				{
					result = (this._LightMaskMaterial_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_63, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x06025A40 RID: 154176 RVA: 0x0095F220 File Offset: 0x0095D420
		// (set) Token: 0x06025A41 RID: 154177 RVA: 0x0095F259 File Offset: 0x0095D459
		[Nullable(1)]
		public TMap<FName, UTexture> LightMaskMaterial_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._LightMaskMaterial_Textures) == null)
				{
					result = (this._LightMaskMaterial_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_64, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17004DD2 RID: 19922
		// (get) Token: 0x06025A42 RID: 154178 RVA: 0x0095F267 File Offset: 0x0095D467
		// (set) Token: 0x06025A43 RID: 154179 RVA: 0x0095F27B File Offset: 0x0095D47B
		public unsafe UMaterialInstanceDynamic MaterialInstanceBDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x17004DD3 RID: 19923
		// (get) Token: 0x06025A44 RID: 154180 RVA: 0x0095F290 File Offset: 0x0095D490
		// (set) Token: 0x06025A45 RID: 154181 RVA: 0x0095F2A4 File Offset: 0x0095D4A4
		public unsafe UMaterialInstanceDynamic MaterialInstanceDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_66);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x17004DD4 RID: 19924
		// (get) Token: 0x06025A46 RID: 154182 RVA: 0x0095F2B9 File Offset: 0x0095D4B9
		// (set) Token: 0x06025A47 RID: 154183 RVA: 0x0095F2CD File Offset: 0x0095D4CD
		public unsafe UMaterialInstanceDynamic LightShaftConeDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_67);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_67, value);
			}
		}

		// Token: 0x17004DD5 RID: 19925
		// (get) Token: 0x06025A48 RID: 154184 RVA: 0x0095F2E2 File Offset: 0x0095D4E2
		// (set) Token: 0x06025A49 RID: 154185 RVA: 0x0095F2F6 File Offset: 0x0095D4F6
		public unsafe UMaterialInstanceDynamic LightMaskMaterialDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_68);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_68, value);
			}
		}

		// Token: 0x17004DD6 RID: 19926
		// (get) Token: 0x06025A4A RID: 154186 RVA: 0x0095F30B File Offset: 0x0095D50B
		// (set) Token: 0x06025A4B RID: 154187 RVA: 0x0095F31B File Offset: 0x0095D51B
		public unsafe bool IsTickUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_69) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_69) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DD7 RID: 19927
		// (get) Token: 0x06025A4C RID: 154188 RVA: 0x0095F32C File Offset: 0x0095D52C
		// (set) Token: 0x06025A4D RID: 154189 RVA: 0x0095F33C File Offset: 0x0095D53C
		public unsafe bool OptimizeForMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DD8 RID: 19928
		// (get) Token: 0x06025A4E RID: 154190 RVA: 0x0095F34D File Offset: 0x0095D54D
		// (set) Token: 0x06025A4F RID: 154191 RVA: 0x0095F361 File Offset: 0x0095D561
		public unsafe UStaticMeshComponent VolumetricCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_71);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_71, value);
			}
		}

		// Token: 0x06025A50 RID: 154192 RVA: 0x0095F376 File Offset: 0x0095D576
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06025A51 RID: 154193 RVA: 0x0095F38A File Offset: 0x0095D58A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025A52 RID: 154194 RVA: 0x0095F39E File Offset: 0x0095D59E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025A53 RID: 154195 RVA: 0x0095F3B3 File Offset: 0x0095D5B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025A54 RID: 154196 RVA: 0x0095F3C7 File Offset: 0x0095D5C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025A55 RID: 154197 RVA: 0x0095F3DC File Offset: 0x0095D5DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025A56 RID: 154198 RVA: 0x0095F424 File Offset: 0x0095D624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025A57 RID: 154199 RVA: 0x0095F46C File Offset: 0x0095D66C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025A58 RID: 154200 RVA: 0x0095F4B4 File Offset: 0x0095D6B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025A59 RID: 154201 RVA: 0x0095F4FB File Offset: 0x0095D6FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnGameUserSettingsChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__OnGameUserSettingsChange_NativeFunctionPtr, null);
		}

		// Token: 0x06025A5A RID: 154202 RVA: 0x0095F510 File Offset: 0x0095D710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025A5B RID: 154203 RVA: 0x0095F55C File Offset: 0x0095D75C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025A5C RID: 154204 RVA: 0x0095F5A8 File Offset: 0x0095D7A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVolumeColor(FLinearColor LightColor)
		{
			BP_VolumetricConeLightShaft_InStage_C.__SetVolumeColor_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__SetVolumeColor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__SetVolumeColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__SetVolumeColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LightColor = LightColor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__SetVolumeColor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025A5D RID: 154205 RVA: 0x0095F5EE File Offset: 0x0095D7EE
		protected BP_VolumetricConeLightShaft_InStage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C79 RID: 76921
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/InteractionLight/BP_VolumetricConeLightShaft_InStage.BP_VolumetricConeLightShaft_InStage_C";

		// Token: 0x04012C7A RID: 76922
		private static IntPtr _ClassPtr;

		// Token: 0x04012C7B RID: 76923
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C7C RID: 76924
		internal static int __PropertyOffset_1;

		// Token: 0x04012C7D RID: 76925
		internal static int __PropertyOffset_2;

		// Token: 0x04012C7E RID: 76926
		internal static int __PropertyOffset_3;

		// Token: 0x04012C7F RID: 76927
		internal static int __PropertyOffset_4;

		// Token: 0x04012C80 RID: 76928
		internal static int __PropertyOffset_5;

		// Token: 0x04012C81 RID: 76929
		internal static int __PropertyOffset_6;

		// Token: 0x04012C82 RID: 76930
		internal static int __PropertyOffset_7;

		// Token: 0x04012C83 RID: 76931
		internal static int __PropertyOffset_8;

		// Token: 0x04012C84 RID: 76932
		internal static int __PropertyOffset_9;

		// Token: 0x04012C85 RID: 76933
		internal static int __PropertyOffset_10;

		// Token: 0x04012C86 RID: 76934
		internal static int __PropertyOffset_11;

		// Token: 0x04012C87 RID: 76935
		internal static int __PropertyOffset_12;

		// Token: 0x04012C88 RID: 76936
		internal static int __PropertyOffset_13;

		// Token: 0x04012C89 RID: 76937
		internal static int __PropertyOffset_14;

		// Token: 0x04012C8A RID: 76938
		internal static int __PropertyOffset_15;

		// Token: 0x04012C8B RID: 76939
		internal static int __PropertyOffset_16;

		// Token: 0x04012C8C RID: 76940
		internal static int __PropertyOffset_17;

		// Token: 0x04012C8D RID: 76941
		internal static int __PropertyOffset_18;

		// Token: 0x04012C8E RID: 76942
		internal static int __PropertyOffset_19;

		// Token: 0x04012C8F RID: 76943
		internal static int __PropertyOffset_20;

		// Token: 0x04012C90 RID: 76944
		internal static int __PropertyOffset_21;

		// Token: 0x04012C91 RID: 76945
		internal static int __PropertyOffset_22;

		// Token: 0x04012C92 RID: 76946
		internal static int __PropertyOffset_23;

		// Token: 0x04012C93 RID: 76947
		internal static int __PropertyOffset_24;

		// Token: 0x04012C94 RID: 76948
		internal static int __PropertyOffset_25;

		// Token: 0x04012C95 RID: 76949
		internal static int __PropertyOffset_26;

		// Token: 0x04012C96 RID: 76950
		internal static int __PropertyOffset_27;

		// Token: 0x04012C97 RID: 76951
		internal static int __PropertyOffset_28;

		// Token: 0x04012C98 RID: 76952
		internal static int __PropertyOffset_29;

		// Token: 0x04012C99 RID: 76953
		internal static int __PropertyOffset_30;

		// Token: 0x04012C9A RID: 76954
		internal static int __PropertyOffset_31;

		// Token: 0x04012C9B RID: 76955
		internal static int __PropertyOffset_32;

		// Token: 0x04012C9C RID: 76956
		internal static int __PropertyOffset_33;

		// Token: 0x04012C9D RID: 76957
		internal static int __PropertyOffset_34;

		// Token: 0x04012C9E RID: 76958
		internal static int __PropertyOffset_35;

		// Token: 0x04012C9F RID: 76959
		internal static int __PropertyOffset_36;

		// Token: 0x04012CA0 RID: 76960
		internal static int __PropertyOffset_37;

		// Token: 0x04012CA1 RID: 76961
		internal static int __PropertyOffset_38;

		// Token: 0x04012CA2 RID: 76962
		internal static int __PropertyOffset_39;

		// Token: 0x04012CA3 RID: 76963
		internal static int __PropertyOffset_40;

		// Token: 0x04012CA4 RID: 76964
		internal static int __PropertyOffset_41;

		// Token: 0x04012CA5 RID: 76965
		internal static int __PropertyOffset_42;

		// Token: 0x04012CA6 RID: 76966
		internal static int __PropertyOffset_43;

		// Token: 0x04012CA7 RID: 76967
		internal static int __PropertyOffset_44;

		// Token: 0x04012CA8 RID: 76968
		internal static int __PropertyOffset_45;

		// Token: 0x04012CA9 RID: 76969
		internal static int __PropertyOffset_46;

		// Token: 0x04012CAA RID: 76970
		internal static int __PropertyOffset_47;

		// Token: 0x04012CAB RID: 76971
		internal static int __PropertyOffset_48;

		// Token: 0x04012CAC RID: 76972
		internal static int __PropertyOffset_49;

		// Token: 0x04012CAD RID: 76973
		internal static int __PropertyOffset_50;

		// Token: 0x04012CAE RID: 76974
		internal static int __PropertyOffset_51;

		// Token: 0x04012CAF RID: 76975
		internal static int __PropertyOffset_52;

		// Token: 0x04012CB0 RID: 76976
		internal static int __PropertyOffset_53;

		// Token: 0x04012CB1 RID: 76977
		private TMap<FName, float> _MaterialInstanceB_Scalars;

		// Token: 0x04012CB2 RID: 76978
		internal static int __PropertyOffset_54;

		// Token: 0x04012CB3 RID: 76979
		private TMap<FName, FLinearColor> _MaterialInstanceB_Vectors;

		// Token: 0x04012CB4 RID: 76980
		internal static int __PropertyOffset_55;

		// Token: 0x04012CB5 RID: 76981
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _MaterialInstanceB_Textures;

		// Token: 0x04012CB6 RID: 76982
		internal static int __PropertyOffset_56;

		// Token: 0x04012CB7 RID: 76983
		private TMap<FName, float> _MaterialInstance_Scalars;

		// Token: 0x04012CB8 RID: 76984
		internal static int __PropertyOffset_57;

		// Token: 0x04012CB9 RID: 76985
		private TMap<FName, FLinearColor> _MaterialInstance_Vectors;

		// Token: 0x04012CBA RID: 76986
		internal static int __PropertyOffset_58;

		// Token: 0x04012CBB RID: 76987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _MaterialInstance_Textures;

		// Token: 0x04012CBC RID: 76988
		internal static int __PropertyOffset_59;

		// Token: 0x04012CBD RID: 76989
		private TMap<FName, float> _LightShaftCone_Scalars;

		// Token: 0x04012CBE RID: 76990
		internal static int __PropertyOffset_60;

		// Token: 0x04012CBF RID: 76991
		private TMap<FName, FLinearColor> _LightShaftCone_Vectors;

		// Token: 0x04012CC0 RID: 76992
		internal static int __PropertyOffset_61;

		// Token: 0x04012CC1 RID: 76993
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _LightShaftCone_Textures;

		// Token: 0x04012CC2 RID: 76994
		internal static int __PropertyOffset_62;

		// Token: 0x04012CC3 RID: 76995
		private TMap<FName, float> _LightMaskMaterial_Scalars;

		// Token: 0x04012CC4 RID: 76996
		internal static int __PropertyOffset_63;

		// Token: 0x04012CC5 RID: 76997
		private TMap<FName, FLinearColor> _LightMaskMaterial_Vectors;

		// Token: 0x04012CC6 RID: 76998
		internal static int __PropertyOffset_64;

		// Token: 0x04012CC7 RID: 76999
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _LightMaskMaterial_Textures;

		// Token: 0x04012CC8 RID: 77000
		internal static int __PropertyOffset_65;

		// Token: 0x04012CC9 RID: 77001
		internal static int __PropertyOffset_66;

		// Token: 0x04012CCA RID: 77002
		internal static int __PropertyOffset_67;

		// Token: 0x04012CCB RID: 77003
		internal static int __PropertyOffset_68;

		// Token: 0x04012CCC RID: 77004
		internal static int __PropertyOffset_69;

		// Token: 0x04012CCD RID: 77005
		internal static int __PropertyOffset_70;

		// Token: 0x04012CCE RID: 77006
		internal static int __PropertyOffset_71;

		// Token: 0x04012CCF RID: 77007
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04012CD0 RID: 77008
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012CD1 RID: 77009
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012CD2 RID: 77010
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012CD3 RID: 77011
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012CD4 RID: 77012
		private static IntPtr __OnGameUserSettingsChange_NativeFunctionPtr;

		// Token: 0x04012CD5 RID: 77013
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04012CD6 RID: 77014
		private static IntPtr __SetVolumeColor_NativeFunctionPtr;

		// Token: 0x0200A01A RID: 40986
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031AC3 RID: 203459
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A01B RID: 40987
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031AC4 RID: 203460
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A01C RID: 40988
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031AC5 RID: 203461
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200A01D RID: 40989
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetVolumeColor_FunctionParams
		{
			// Token: 0x04031AC6 RID: 203462
			[FieldOffset(0)]
			public FLinearColor LightColor;
		}
	}
}
