using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B21 RID: 15137
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaftSeq.BP_VolumetricConeLightShaftSeq_C")]
	[UnrealStructLayout(1808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class BP_VolumetricConeLightShaftSeq_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602139A RID: 136090 RVA: 0x008E7AA0 File Offset: 0x008E5CA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaftSeq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaftSeq.BP_VolumetricConeLightShaftSeq_C");
			}
			return BP_VolumetricConeLightShaftSeq_C._ClassPtr;
		}

		// Token: 0x0602139B RID: 136091 RVA: 0x008E7AC4 File Offset: 0x008E5CC4
		public BP_VolumetricConeLightShaftSeq_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaftSeq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602139C RID: 136092 RVA: 0x008E7AEC File Offset: 0x008E5CEC
		[NullableContext(1)]
		public BP_VolumetricConeLightShaftSeq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaftSeq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0602139D RID: 136093 RVA: 0x008E7B1F File Offset: 0x008E5D1F
		// (set) Token: 0x0602139E RID: 136094 RVA: 0x008E7B33 File Offset: 0x008E5D33
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0602139F RID: 136095 RVA: 0x008E7B48 File Offset: 0x008E5D48
		// (set) Token: 0x060213A0 RID: 136096 RVA: 0x008E7B5C File Offset: 0x008E5D5C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x060213A1 RID: 136097 RVA: 0x008E7B71 File Offset: 0x008E5D71
		// (set) Token: 0x060213A2 RID: 136098 RVA: 0x008E7B85 File Offset: 0x008E5D85
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x060213A3 RID: 136099 RVA: 0x008E7B9A File Offset: 0x008E5D9A
		// (set) Token: 0x060213A4 RID: 136100 RVA: 0x008E7BAE File Offset: 0x008E5DAE
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x060213A5 RID: 136101 RVA: 0x008E7BC3 File Offset: 0x008E5DC3
		// (set) Token: 0x060213A6 RID: 136102 RVA: 0x008E7BD7 File Offset: 0x008E5DD7
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x060213A7 RID: 136103 RVA: 0x008E7BEC File Offset: 0x008E5DEC
		// (set) Token: 0x060213A8 RID: 136104 RVA: 0x008E7C00 File Offset: 0x008E5E00
		public unsafe FVector VolumetriConeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x060213A9 RID: 136105 RVA: 0x008E7C15 File Offset: 0x008E5E15
		// (set) Token: 0x060213AA RID: 136106 RVA: 0x008E7C25 File Offset: 0x008E5E25
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x060213AB RID: 136107 RVA: 0x008E7C36 File Offset: 0x008E5E36
		// (set) Token: 0x060213AC RID: 136108 RVA: 0x008E7C46 File Offset: 0x008E5E46
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x060213AD RID: 136109 RVA: 0x008E7C57 File Offset: 0x008E5E57
		// (set) Token: 0x060213AE RID: 136110 RVA: 0x008E7C67 File Offset: 0x008E5E67
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x060213AF RID: 136111 RVA: 0x008E7C78 File Offset: 0x008E5E78
		// (set) Token: 0x060213B0 RID: 136112 RVA: 0x008E7C88 File Offset: 0x008E5E88
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x060213B1 RID: 136113 RVA: 0x008E7C99 File Offset: 0x008E5E99
		// (set) Token: 0x060213B2 RID: 136114 RVA: 0x008E7CA9 File Offset: 0x008E5EA9
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x060213B3 RID: 136115 RVA: 0x008E7CBA File Offset: 0x008E5EBA
		// (set) Token: 0x060213B4 RID: 136116 RVA: 0x008E7CCA File Offset: 0x008E5ECA
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x060213B5 RID: 136117 RVA: 0x008E7CDB File Offset: 0x008E5EDB
		// (set) Token: 0x060213B6 RID: 136118 RVA: 0x008E7CEB File Offset: 0x008E5EEB
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x060213B7 RID: 136119 RVA: 0x008E7CFC File Offset: 0x008E5EFC
		// (set) Token: 0x060213B8 RID: 136120 RVA: 0x008E7D10 File Offset: 0x008E5F10
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x060213B9 RID: 136121 RVA: 0x008E7D25 File Offset: 0x008E5F25
		// (set) Token: 0x060213BA RID: 136122 RVA: 0x008E7D39 File Offset: 0x008E5F39
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x060213BB RID: 136123 RVA: 0x008E7D4E File Offset: 0x008E5F4E
		// (set) Token: 0x060213BC RID: 136124 RVA: 0x008E7D5E File Offset: 0x008E5F5E
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x060213BD RID: 136125 RVA: 0x008E7D6F File Offset: 0x008E5F6F
		// (set) Token: 0x060213BE RID: 136126 RVA: 0x008E7D7F File Offset: 0x008E5F7F
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x060213BF RID: 136127 RVA: 0x008E7D90 File Offset: 0x008E5F90
		// (set) Token: 0x060213C0 RID: 136128 RVA: 0x008E7DA0 File Offset: 0x008E5FA0
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x060213C1 RID: 136129 RVA: 0x008E7DB1 File Offset: 0x008E5FB1
		// (set) Token: 0x060213C2 RID: 136130 RVA: 0x008E7DC1 File Offset: 0x008E5FC1
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x060213C3 RID: 136131 RVA: 0x008E7DD2 File Offset: 0x008E5FD2
		// (set) Token: 0x060213C4 RID: 136132 RVA: 0x008E7DE2 File Offset: 0x008E5FE2
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x060213C5 RID: 136133 RVA: 0x008E7DF3 File Offset: 0x008E5FF3
		// (set) Token: 0x060213C6 RID: 136134 RVA: 0x008E7E03 File Offset: 0x008E6003
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x060213C7 RID: 136135 RVA: 0x008E7E14 File Offset: 0x008E6014
		// (set) Token: 0x060213C8 RID: 136136 RVA: 0x008E7E28 File Offset: 0x008E6028
		public unsafe FVector LightShaftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x060213C9 RID: 136137 RVA: 0x008E7E3D File Offset: 0x008E603D
		// (set) Token: 0x060213CA RID: 136138 RVA: 0x008E7E51 File Offset: 0x008E6051
		public unsafe UStaticMesh LightShaftStaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x060213CB RID: 136139 RVA: 0x008E7E66 File Offset: 0x008E6066
		// (set) Token: 0x060213CC RID: 136140 RVA: 0x008E7E7A File Offset: 0x008E607A
		public unsafe UMaterialInstance LightShaftCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x060213CD RID: 136141 RVA: 0x008E7E8F File Offset: 0x008E608F
		// (set) Token: 0x060213CE RID: 136142 RVA: 0x008E7EA3 File Offset: 0x008E60A3
		public unsafe UTexture2D Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x060213CF RID: 136143 RVA: 0x008E7EB8 File Offset: 0x008E60B8
		// (set) Token: 0x060213D0 RID: 136144 RVA: 0x008E7ECC File Offset: 0x008E60CC
		public unsafe FLinearColor FallOff_ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x060213D1 RID: 136145 RVA: 0x008E7EE1 File Offset: 0x008E60E1
		// (set) Token: 0x060213D2 RID: 136146 RVA: 0x008E7EF1 File Offset: 0x008E60F1
		public unsafe float FallOff_DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x060213D3 RID: 136147 RVA: 0x008E7F02 File Offset: 0x008E6102
		// (set) Token: 0x060213D4 RID: 136148 RVA: 0x008E7F12 File Offset: 0x008E6112
		public unsafe float ScreenFadeFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x060213D5 RID: 136149 RVA: 0x008E7F23 File Offset: 0x008E6123
		// (set) Token: 0x060213D6 RID: 136150 RVA: 0x008E7F33 File Offset: 0x008E6133
		public unsafe float Opacity_CenterPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x060213D7 RID: 136151 RVA: 0x008E7F44 File Offset: 0x008E6144
		// (set) Token: 0x060213D8 RID: 136152 RVA: 0x008E7F54 File Offset: 0x008E6154
		public unsafe float ScreenFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x060213D9 RID: 136153 RVA: 0x008E7F65 File Offset: 0x008E6165
		// (set) Token: 0x060213DA RID: 136154 RVA: 0x008E7F75 File Offset: 0x008E6175
		public unsafe float ShaftTopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x060213DB RID: 136155 RVA: 0x008E7F86 File Offset: 0x008E6186
		// (set) Token: 0x060213DC RID: 136156 RVA: 0x008E7F9A File Offset: 0x008E619A
		public unsafe FLinearColor UVScaleAndAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x060213DD RID: 136157 RVA: 0x008E7FAF File Offset: 0x008E61AF
		// (set) Token: 0x060213DE RID: 136158 RVA: 0x008E7FC3 File Offset: 0x008E61C3
		public unsafe UStaticMesh LightMaskStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x060213DF RID: 136159 RVA: 0x008E7FD8 File Offset: 0x008E61D8
		// (set) Token: 0x060213E0 RID: 136160 RVA: 0x008E7FE8 File Offset: 0x008E61E8
		public unsafe float LightMaskZaxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x060213E1 RID: 136161 RVA: 0x008E7FF9 File Offset: 0x008E61F9
		// (set) Token: 0x060213E2 RID: 136162 RVA: 0x008E800D File Offset: 0x008E620D
		public unsafe UMaterialInstance LightMaskMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x060213E3 RID: 136163 RVA: 0x008E8022 File Offset: 0x008E6222
		// (set) Token: 0x060213E4 RID: 136164 RVA: 0x008E8036 File Offset: 0x008E6236
		public unsafe FVector LightMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x060213E5 RID: 136165 RVA: 0x008E804B File Offset: 0x008E624B
		// (set) Token: 0x060213E6 RID: 136166 RVA: 0x008E805F File Offset: 0x008E625F
		public unsafe FLinearColor LightMaskColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x060213E7 RID: 136167 RVA: 0x008E8074 File Offset: 0x008E6274
		// (set) Token: 0x060213E8 RID: 136168 RVA: 0x008E8088 File Offset: 0x008E6288
		public unsafe UTexture2D LightMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x060213E9 RID: 136169 RVA: 0x008E809D File Offset: 0x008E629D
		// (set) Token: 0x060213EA RID: 136170 RVA: 0x008E80AD File Offset: 0x008E62AD
		public unsafe float ColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x060213EB RID: 136171 RVA: 0x008E80BE File Offset: 0x008E62BE
		// (set) Token: 0x060213EC RID: 136172 RVA: 0x008E80CE File Offset: 0x008E62CE
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x060213ED RID: 136173 RVA: 0x008E80DF File Offset: 0x008E62DF
		// (set) Token: 0x060213EE RID: 136174 RVA: 0x008E80EF File Offset: 0x008E62EF
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x060213EF RID: 136175 RVA: 0x008E8100 File Offset: 0x008E6300
		// (set) Token: 0x060213F0 RID: 136176 RVA: 0x008E8110 File Offset: 0x008E6310
		public unsafe float FlankInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x060213F1 RID: 136177 RVA: 0x008E8121 File Offset: 0x008E6321
		// (set) Token: 0x060213F2 RID: 136178 RVA: 0x008E8131 File Offset: 0x008E6331
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x060213F3 RID: 136179 RVA: 0x008E8142 File Offset: 0x008E6342
		// (set) Token: 0x060213F4 RID: 136180 RVA: 0x008E8152 File Offset: 0x008E6352
		public unsafe float RightSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x060213F5 RID: 136181 RVA: 0x008E8163 File Offset: 0x008E6363
		// (set) Token: 0x060213F6 RID: 136182 RVA: 0x008E8177 File Offset: 0x008E6377
		public unsafe UMaterialInstanceDynamic DynamicMaterialVolumetricCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x060213F7 RID: 136183 RVA: 0x008E818C File Offset: 0x008E638C
		// (set) Token: 0x060213F8 RID: 136184 RVA: 0x008E81A0 File Offset: 0x008E63A0
		public unsafe UMaterialInstanceDynamic LightShaftConeDynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x060213F9 RID: 136185 RVA: 0x008E81B5 File Offset: 0x008E63B5
		// (set) Token: 0x060213FA RID: 136186 RVA: 0x008E81C9 File Offset: 0x008E63C9
		public unsafe UMaterialInstanceDynamic LightMaskDynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x060213FB RID: 136187 RVA: 0x008E81DE File Offset: 0x008E63DE
		// (set) Token: 0x060213FC RID: 136188 RVA: 0x008E81F2 File Offset: 0x008E63F2
		public unsafe UStaticMeshComponent LightShaftComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x060213FD RID: 136189 RVA: 0x008E8207 File Offset: 0x008E6407
		// (set) Token: 0x060213FE RID: 136190 RVA: 0x008E8217 File Offset: 0x008E6417
		public unsafe float HeighFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x060213FF RID: 136191 RVA: 0x008E8228 File Offset: 0x008E6428
		// (set) Token: 0x06021400 RID: 136192 RVA: 0x008E8238 File Offset: 0x008E6438
		public unsafe float HeighFadeHard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftSeq_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x06021401 RID: 136193 RVA: 0x008E8249 File Offset: 0x008E6449
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021402 RID: 136194 RVA: 0x008E825D File Offset: 0x008E645D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021403 RID: 136195 RVA: 0x008E8272 File Offset: 0x008E6472
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021404 RID: 136196 RVA: 0x008E8286 File Offset: 0x008E6486
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021405 RID: 136197 RVA: 0x008E829C File Offset: 0x008E649C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021406 RID: 136198 RVA: 0x008E82E4 File Offset: 0x008E64E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021407 RID: 136199 RVA: 0x008E832C File Offset: 0x008E652C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftSeq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftSeq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftSeq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftSeq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021408 RID: 136200 RVA: 0x008E8374 File Offset: 0x008E6574
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftSeq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftSeq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftSeq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftSeq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftSeq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021409 RID: 136201 RVA: 0x008E83BB File Offset: 0x008E65BB
		protected BP_VolumetricConeLightShaftSeq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102C7 RID: 66247
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaftSeq.BP_VolumetricConeLightShaftSeq_C";

		// Token: 0x040102C8 RID: 66248
		private static IntPtr _ClassPtr;

		// Token: 0x040102C9 RID: 66249
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102CA RID: 66250
		internal static int __PropertyOffset_1;

		// Token: 0x040102CB RID: 66251
		internal static int __PropertyOffset_2;

		// Token: 0x040102CC RID: 66252
		internal static int __PropertyOffset_3;

		// Token: 0x040102CD RID: 66253
		internal static int __PropertyOffset_4;

		// Token: 0x040102CE RID: 66254
		internal static int __PropertyOffset_5;

		// Token: 0x040102CF RID: 66255
		internal static int __PropertyOffset_6;

		// Token: 0x040102D0 RID: 66256
		internal static int __PropertyOffset_7;

		// Token: 0x040102D1 RID: 66257
		internal static int __PropertyOffset_8;

		// Token: 0x040102D2 RID: 66258
		internal static int __PropertyOffset_9;

		// Token: 0x040102D3 RID: 66259
		internal static int __PropertyOffset_10;

		// Token: 0x040102D4 RID: 66260
		internal static int __PropertyOffset_11;

		// Token: 0x040102D5 RID: 66261
		internal static int __PropertyOffset_12;

		// Token: 0x040102D6 RID: 66262
		internal static int __PropertyOffset_13;

		// Token: 0x040102D7 RID: 66263
		internal static int __PropertyOffset_14;

		// Token: 0x040102D8 RID: 66264
		internal static int __PropertyOffset_15;

		// Token: 0x040102D9 RID: 66265
		internal static int __PropertyOffset_16;

		// Token: 0x040102DA RID: 66266
		internal static int __PropertyOffset_17;

		// Token: 0x040102DB RID: 66267
		internal static int __PropertyOffset_18;

		// Token: 0x040102DC RID: 66268
		internal static int __PropertyOffset_19;

		// Token: 0x040102DD RID: 66269
		internal static int __PropertyOffset_20;

		// Token: 0x040102DE RID: 66270
		internal static int __PropertyOffset_21;

		// Token: 0x040102DF RID: 66271
		internal static int __PropertyOffset_22;

		// Token: 0x040102E0 RID: 66272
		internal static int __PropertyOffset_23;

		// Token: 0x040102E1 RID: 66273
		internal static int __PropertyOffset_24;

		// Token: 0x040102E2 RID: 66274
		internal static int __PropertyOffset_25;

		// Token: 0x040102E3 RID: 66275
		internal static int __PropertyOffset_26;

		// Token: 0x040102E4 RID: 66276
		internal static int __PropertyOffset_27;

		// Token: 0x040102E5 RID: 66277
		internal static int __PropertyOffset_28;

		// Token: 0x040102E6 RID: 66278
		internal static int __PropertyOffset_29;

		// Token: 0x040102E7 RID: 66279
		internal static int __PropertyOffset_30;

		// Token: 0x040102E8 RID: 66280
		internal static int __PropertyOffset_31;

		// Token: 0x040102E9 RID: 66281
		internal static int __PropertyOffset_32;

		// Token: 0x040102EA RID: 66282
		internal static int __PropertyOffset_33;

		// Token: 0x040102EB RID: 66283
		internal static int __PropertyOffset_34;

		// Token: 0x040102EC RID: 66284
		internal static int __PropertyOffset_35;

		// Token: 0x040102ED RID: 66285
		internal static int __PropertyOffset_36;

		// Token: 0x040102EE RID: 66286
		internal static int __PropertyOffset_37;

		// Token: 0x040102EF RID: 66287
		internal static int __PropertyOffset_38;

		// Token: 0x040102F0 RID: 66288
		internal static int __PropertyOffset_39;

		// Token: 0x040102F1 RID: 66289
		internal static int __PropertyOffset_40;

		// Token: 0x040102F2 RID: 66290
		internal static int __PropertyOffset_41;

		// Token: 0x040102F3 RID: 66291
		internal static int __PropertyOffset_42;

		// Token: 0x040102F4 RID: 66292
		internal static int __PropertyOffset_43;

		// Token: 0x040102F5 RID: 66293
		internal static int __PropertyOffset_44;

		// Token: 0x040102F6 RID: 66294
		internal static int __PropertyOffset_45;

		// Token: 0x040102F7 RID: 66295
		internal static int __PropertyOffset_46;

		// Token: 0x040102F8 RID: 66296
		internal static int __PropertyOffset_47;

		// Token: 0x040102F9 RID: 66297
		internal static int __PropertyOffset_48;

		// Token: 0x040102FA RID: 66298
		internal static int __PropertyOffset_49;

		// Token: 0x040102FB RID: 66299
		internal static int __PropertyOffset_50;

		// Token: 0x040102FC RID: 66300
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040102FD RID: 66301
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040102FE RID: 66302
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040102FF RID: 66303
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C7B RID: 40059
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031339 RID: 201529
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C7C RID: 40060
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403133A RID: 201530
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
