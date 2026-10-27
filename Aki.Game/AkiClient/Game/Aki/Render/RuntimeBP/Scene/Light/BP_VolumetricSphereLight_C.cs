using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B2C RID: 15148
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLight.BP_VolumetricSphereLight_C")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1429)]
	public class BP_VolumetricSphereLight_C : AKuroLightActorBase, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060216B2 RID: 136882 RVA: 0x008EC018 File Offset: 0x008EA218
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricSphereLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLight.BP_VolumetricSphereLight_C");
			}
			return BP_VolumetricSphereLight_C._ClassPtr;
		}

		// Token: 0x060216B3 RID: 136883 RVA: 0x008EC03C File Offset: 0x008EA23C
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricSphereLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x060216B4 RID: 136884 RVA: 0x008EC044 File Offset: 0x008EA244
		public BP_VolumetricSphereLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060216B5 RID: 136885 RVA: 0x008EC06C File Offset: 0x008EA26C
		[NullableContext(1)]
		public BP_VolumetricSphereLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x060216B6 RID: 136886 RVA: 0x008EC09F File Offset: 0x008EA29F
		// (set) Token: 0x060216B7 RID: 136887 RVA: 0x008EC0B3 File Offset: 0x008EA2B3
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x060216B8 RID: 136888 RVA: 0x008EC0C8 File Offset: 0x008EA2C8
		// (set) Token: 0x060216B9 RID: 136889 RVA: 0x008EC0DC File Offset: 0x008EA2DC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x060216BA RID: 136890 RVA: 0x008EC0F1 File Offset: 0x008EA2F1
		// (set) Token: 0x060216BB RID: 136891 RVA: 0x008EC105 File Offset: 0x008EA305
		public unsafe UStaticMesh SphereLightStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x060216BC RID: 136892 RVA: 0x008EC11A File Offset: 0x008EA31A
		// (set) Token: 0x060216BD RID: 136893 RVA: 0x008EC12E File Offset: 0x008EA32E
		public unsafe UMaterialInstanceDynamic MaterialInstanceDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x060216BE RID: 136894 RVA: 0x008EC143 File Offset: 0x008EA343
		// (set) Token: 0x060216BF RID: 136895 RVA: 0x008EC157 File Offset: 0x008EA357
		public unsafe UMaterialInstance SphereLightMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x060216C0 RID: 136896 RVA: 0x008EC16C File Offset: 0x008EA36C
		// (set) Token: 0x060216C1 RID: 136897 RVA: 0x008EC17C File Offset: 0x008EA37C
		public unsafe bool IsReverseCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x060216C2 RID: 136898 RVA: 0x008EC18D File Offset: 0x008EA38D
		// (set) Token: 0x060216C3 RID: 136899 RVA: 0x008EC19D File Offset: 0x008EA39D
		public unsafe bool BlackDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x060216C4 RID: 136900 RVA: 0x008EC1AE File Offset: 0x008EA3AE
		// (set) Token: 0x060216C5 RID: 136901 RVA: 0x008EC1BE File Offset: 0x008EA3BE
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x060216C6 RID: 136902 RVA: 0x008EC1CF File Offset: 0x008EA3CF
		// (set) Token: 0x060216C7 RID: 136903 RVA: 0x008EC1DF File Offset: 0x008EA3DF
		public unsafe bool OutDistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x060216C8 RID: 136904 RVA: 0x008EC1F0 File Offset: 0x008EA3F0
		// (set) Token: 0x060216C9 RID: 136905 RVA: 0x008EC200 File Offset: 0x008EA400
		public unsafe bool ApplyFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x060216CA RID: 136906 RVA: 0x008EC211 File Offset: 0x008EA411
		// (set) Token: 0x060216CB RID: 136907 RVA: 0x008EC221 File Offset: 0x008EA421
		public unsafe float FogInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x060216CC RID: 136908 RVA: 0x008EC232 File Offset: 0x008EA432
		// (set) Token: 0x060216CD RID: 136909 RVA: 0x008EC242 File Offset: 0x008EA442
		public unsafe float FogPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x060216CE RID: 136910 RVA: 0x008EC253 File Offset: 0x008EA453
		// (set) Token: 0x060216CF RID: 136911 RVA: 0x008EC263 File Offset: 0x008EA463
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x060216D0 RID: 136912 RVA: 0x008EC274 File Offset: 0x008EA474
		// (set) Token: 0x060216D1 RID: 136913 RVA: 0x008EC284 File Offset: 0x008EA484
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x060216D2 RID: 136914 RVA: 0x008EC295 File Offset: 0x008EA495
		// (set) Token: 0x060216D3 RID: 136915 RVA: 0x008EC2A9 File Offset: 0x008EA4A9
		public unsafe FLinearColor InsideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x060216D4 RID: 136916 RVA: 0x008EC2BE File Offset: 0x008EA4BE
		// (set) Token: 0x060216D5 RID: 136917 RVA: 0x008EC2D2 File Offset: 0x008EA4D2
		public unsafe FLinearColor OutSideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x060216D6 RID: 136918 RVA: 0x008EC2E7 File Offset: 0x008EA4E7
		// (set) Token: 0x060216D7 RID: 136919 RVA: 0x008EC2F7 File Offset: 0x008EA4F7
		public unsafe float SphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x060216D8 RID: 136920 RVA: 0x008EC308 File Offset: 0x008EA508
		// (set) Token: 0x060216D9 RID: 136921 RVA: 0x008EC318 File Offset: 0x008EA518
		public unsafe float LightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x060216DA RID: 136922 RVA: 0x008EC329 File Offset: 0x008EA529
		// (set) Token: 0x060216DB RID: 136923 RVA: 0x008EC339 File Offset: 0x008EA539
		public unsafe float NearFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x060216DC RID: 136924 RVA: 0x008EC34A File Offset: 0x008EA54A
		// (set) Token: 0x060216DD RID: 136925 RVA: 0x008EC35A File Offset: 0x008EA55A
		public unsafe float FullIntLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x060216DE RID: 136926 RVA: 0x008EC36B File Offset: 0x008EA56B
		// (set) Token: 0x060216DF RID: 136927 RVA: 0x008EC37B File Offset: 0x008EA57B
		public unsafe float FarFadeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x060216E0 RID: 136928 RVA: 0x008EC38C File Offset: 0x008EA58C
		// (set) Token: 0x060216E1 RID: 136929 RVA: 0x008EC3A0 File Offset: 0x008EA5A0
		public unsafe UMaterialInstance SphereLightMatWithOutDF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x060216E2 RID: 136930 RVA: 0x008EC3B5 File Offset: 0x008EA5B5
		// (set) Token: 0x060216E3 RID: 136931 RVA: 0x008EC3C9 File Offset: 0x008EA5C9
		public unsafe UMaterialInstance SphereLightMatWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x060216E4 RID: 136932 RVA: 0x008EC3DE File Offset: 0x008EA5DE
		// (set) Token: 0x060216E5 RID: 136933 RVA: 0x008EC3F2 File Offset: 0x008EA5F2
		public unsafe UMaterialInstance SphereLightMatWithOutDFWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x060216E6 RID: 136934 RVA: 0x008EC407 File Offset: 0x008EA607
		// (set) Token: 0x060216E7 RID: 136935 RVA: 0x008EC41B File Offset: 0x008EA61B
		public unsafe UMaterialInstance SphereLightBlackDown
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x060216E8 RID: 136936 RVA: 0x008EC430 File Offset: 0x008EA630
		// (set) Token: 0x060216E9 RID: 136937 RVA: 0x008EC444 File Offset: 0x008EA644
		public unsafe UMaterialInstance SphereLightBlackDownWithOutDF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x060216EA RID: 136938 RVA: 0x008EC459 File Offset: 0x008EA659
		// (set) Token: 0x060216EB RID: 136939 RVA: 0x008EC469 File Offset: 0x008EA669
		public unsafe bool Editor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x060216EC RID: 136940 RVA: 0x008EC47A File Offset: 0x008EA67A
		// (set) Token: 0x060216ED RID: 136941 RVA: 0x008EC48E File Offset: 0x008EA68E
		public unsafe FVectorDouble CameraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x060216EE RID: 136942 RVA: 0x008EC4A3 File Offset: 0x008EA6A3
		// (set) Token: 0x060216EF RID: 136943 RVA: 0x008EC4B7 File Offset: 0x008EA6B7
		public unsafe UStaticMeshComponent MeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x060216F0 RID: 136944 RVA: 0x008EC4CC File Offset: 0x008EA6CC
		// (set) Token: 0x060216F1 RID: 136945 RVA: 0x008EC4DC File Offset: 0x008EA6DC
		public unsafe float DistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x060216F2 RID: 136946 RVA: 0x008EC4ED File Offset: 0x008EA6ED
		// (set) Token: 0x060216F3 RID: 136947 RVA: 0x008EC4FD File Offset: 0x008EA6FD
		public unsafe bool bUseCPUDitanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x060216F4 RID: 136948 RVA: 0x008EC50E File Offset: 0x008EA70E
		// (set) Token: 0x060216F5 RID: 136949 RVA: 0x008EC51E File Offset: 0x008EA71E
		public unsafe int TranslucentSortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x060216F6 RID: 136950 RVA: 0x008EC52F File Offset: 0x008EA72F
		// (set) Token: 0x060216F7 RID: 136951 RVA: 0x008EC53F File Offset: 0x008EA73F
		public unsafe bool UseNoiseFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x060216F8 RID: 136952 RVA: 0x008EC550 File Offset: 0x008EA750
		// (set) Token: 0x060216F9 RID: 136953 RVA: 0x008EC564 File Offset: 0x008EA764
		public unsafe UTexture MainNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x060216FA RID: 136954 RVA: 0x008EC579 File Offset: 0x008EA779
		// (set) Token: 0x060216FB RID: 136955 RVA: 0x008EC58D File Offset: 0x008EA78D
		public unsafe UTexture SecondNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x060216FC RID: 136956 RVA: 0x008EC5A2 File Offset: 0x008EA7A2
		// (set) Token: 0x060216FD RID: 136957 RVA: 0x008EC5B6 File Offset: 0x008EA7B6
		public unsafe FLinearColor MainNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x060216FE RID: 136958 RVA: 0x008EC5CB File Offset: 0x008EA7CB
		// (set) Token: 0x060216FF RID: 136959 RVA: 0x008EC5DF File Offset: 0x008EA7DF
		public unsafe FLinearColor SecondNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x06021700 RID: 136960 RVA: 0x008EC5F4 File Offset: 0x008EA7F4
		// (set) Token: 0x06021701 RID: 136961 RVA: 0x008EC604 File Offset: 0x008EA804
		public unsafe float MainUVAddStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x06021702 RID: 136962 RVA: 0x008EC615 File Offset: 0x008EA815
		// (set) Token: 0x06021703 RID: 136963 RVA: 0x008EC629 File Offset: 0x008EA829
		public unsafe FLinearColor MainNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x06021704 RID: 136964 RVA: 0x008EC63E File Offset: 0x008EA83E
		// (set) Token: 0x06021705 RID: 136965 RVA: 0x008EC652 File Offset: 0x008EA852
		public unsafe FLinearColor SecondNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x06021706 RID: 136966 RVA: 0x008EC667 File Offset: 0x008EA867
		// (set) Token: 0x06021707 RID: 136967 RVA: 0x008EC67B File Offset: 0x008EA87B
		public unsafe UMaterialInstance SphereLightMat_NF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x06021708 RID: 136968 RVA: 0x008EC690 File Offset: 0x008EA890
		// (set) Token: 0x06021709 RID: 136969 RVA: 0x008EC6A4 File Offset: 0x008EA8A4
		public unsafe UMaterialInstance SphereLightMatWithOutDF_NF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0602170A RID: 136970 RVA: 0x008EC6B9 File Offset: 0x008EA8B9
		// (set) Token: 0x0602170B RID: 136971 RVA: 0x008EC6CD File Offset: 0x008EA8CD
		public unsafe UMaterialInstance SphereLightMatWithOutFog_NF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0602170C RID: 136972 RVA: 0x008EC6E2 File Offset: 0x008EA8E2
		// (set) Token: 0x0602170D RID: 136973 RVA: 0x008EC6F6 File Offset: 0x008EA8F6
		public unsafe UMaterialInstance SphereLightMatWithOutDFWithOutFog_NF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0602170E RID: 136974 RVA: 0x008EC70B File Offset: 0x008EA90B
		// (set) Token: 0x0602170F RID: 136975 RVA: 0x008EC71F File Offset: 0x008EA91F
		public unsafe UMaterialInstance SphereLightBlackDown_NF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x06021710 RID: 136976 RVA: 0x008EC734 File Offset: 0x008EA934
		// (set) Token: 0x06021711 RID: 136977 RVA: 0x008EC748 File Offset: 0x008EA948
		public unsafe UMaterialInstance SphereLightBlackDownWithOutDF_NF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x06021712 RID: 136978 RVA: 0x008EC75D File Offset: 0x008EA95D
		// (set) Token: 0x06021713 RID: 136979 RVA: 0x008EC76D File Offset: 0x008EA96D
		public unsafe int FrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x06021714 RID: 136980 RVA: 0x008EC77E File Offset: 0x008EA97E
		// (set) Token: 0x06021715 RID: 136981 RVA: 0x008EC792 File Offset: 0x008EA992
		[Nullable(0)]
		public unsafe TEnumAsByte<ELightQualityType> Quality
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_48);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x06021716 RID: 136982 RVA: 0x008EC7A7 File Offset: 0x008EA9A7
		// (set) Token: 0x06021717 RID: 136983 RVA: 0x008EC7B7 File Offset: 0x008EA9B7
		public unsafe int CurrentQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x06021718 RID: 136984 RVA: 0x008EC7C8 File Offset: 0x008EA9C8
		// (set) Token: 0x06021719 RID: 136985 RVA: 0x008EC7D8 File Offset: 0x008EA9D8
		public unsafe bool bMobileVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602171A RID: 136986 RVA: 0x008EC7EC File Offset: 0x008EA9EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricSphereLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602171B RID: 136987 RVA: 0x008EC834 File Offset: 0x008EAA34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricSphereLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602171C RID: 136988 RVA: 0x008EC87A File Offset: 0x008EAA7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetQuality()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__SetQuality_NativeFunctionPtr, null);
		}

		// Token: 0x0602171D RID: 136989 RVA: 0x008EC88E File Offset: 0x008EAA8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateVolumetricSphereLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__UpdateVolumetricSphereLight_NativeFunctionPtr, null);
		}

		// Token: 0x0602171E RID: 136990 RVA: 0x008EC8A2 File Offset: 0x008EAAA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602171F RID: 136991 RVA: 0x008EC8B6 File Offset: 0x008EAAB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021720 RID: 136992 RVA: 0x008EC8CB File Offset: 0x008EAACB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021721 RID: 136993 RVA: 0x008EC8DF File Offset: 0x008EAADF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021722 RID: 136994 RVA: 0x008EC8F4 File Offset: 0x008EAAF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Update(float DeltaSeconds)
		{
			BP_VolumetricSphereLight_C.__Update_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_C.__Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_C.__Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_C.__Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__Update_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021723 RID: 136995 RVA: 0x008EC93C File Offset: 0x008EAB3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Update_Implementation(float DeltaSeconds)
		{
			BP_VolumetricSphereLight_C.__Update_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_C.__Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_C.__Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_C.__Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__Update_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021724 RID: 136996 RVA: 0x008EC984 File Offset: 0x008EAB84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void SetLightIntensityScale(float ScaleFactor)
		{
			BP_VolumetricSphereLight_C.__SetLightIntensityScale_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_C.__SetLightIntensityScale_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_C.__SetLightIntensityScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScaleFactor = ScaleFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021725 RID: 136997 RVA: 0x008EC9CC File Offset: 0x008EABCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void SetLightIntensityScale_Implementation(float ScaleFactor)
		{
			BP_VolumetricSphereLight_C.__SetLightIntensityScale_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_C.__SetLightIntensityScale_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_C.__SetLightIntensityScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScaleFactor = ScaleFactor;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021726 RID: 136998 RVA: 0x008ECA13 File Offset: 0x008EAC13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06021727 RID: 136999 RVA: 0x008ECA27 File Offset: 0x008EAC27
		protected BP_VolumetricSphereLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010474 RID: 66676
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010475 RID: 66677
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLight.BP_VolumetricSphereLight_C";

		// Token: 0x04010476 RID: 66678
		private static IntPtr _ClassPtr;

		// Token: 0x04010477 RID: 66679
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010478 RID: 66680
		internal static int __PropertyOffset_1;

		// Token: 0x04010479 RID: 66681
		internal static int __PropertyOffset_2;

		// Token: 0x0401047A RID: 66682
		internal static int __PropertyOffset_3;

		// Token: 0x0401047B RID: 66683
		internal static int __PropertyOffset_4;

		// Token: 0x0401047C RID: 66684
		internal static int __PropertyOffset_5;

		// Token: 0x0401047D RID: 66685
		internal static int __PropertyOffset_6;

		// Token: 0x0401047E RID: 66686
		internal static int __PropertyOffset_7;

		// Token: 0x0401047F RID: 66687
		internal static int __PropertyOffset_8;

		// Token: 0x04010480 RID: 66688
		internal static int __PropertyOffset_9;

		// Token: 0x04010481 RID: 66689
		internal static int __PropertyOffset_10;

		// Token: 0x04010482 RID: 66690
		internal static int __PropertyOffset_11;

		// Token: 0x04010483 RID: 66691
		internal static int __PropertyOffset_12;

		// Token: 0x04010484 RID: 66692
		internal static int __PropertyOffset_13;

		// Token: 0x04010485 RID: 66693
		internal static int __PropertyOffset_14;

		// Token: 0x04010486 RID: 66694
		internal static int __PropertyOffset_15;

		// Token: 0x04010487 RID: 66695
		internal static int __PropertyOffset_16;

		// Token: 0x04010488 RID: 66696
		internal static int __PropertyOffset_17;

		// Token: 0x04010489 RID: 66697
		internal static int __PropertyOffset_18;

		// Token: 0x0401048A RID: 66698
		internal static int __PropertyOffset_19;

		// Token: 0x0401048B RID: 66699
		internal static int __PropertyOffset_20;

		// Token: 0x0401048C RID: 66700
		internal static int __PropertyOffset_21;

		// Token: 0x0401048D RID: 66701
		internal static int __PropertyOffset_22;

		// Token: 0x0401048E RID: 66702
		internal static int __PropertyOffset_23;

		// Token: 0x0401048F RID: 66703
		internal static int __PropertyOffset_24;

		// Token: 0x04010490 RID: 66704
		internal static int __PropertyOffset_25;

		// Token: 0x04010491 RID: 66705
		internal static int __PropertyOffset_26;

		// Token: 0x04010492 RID: 66706
		internal static int __PropertyOffset_27;

		// Token: 0x04010493 RID: 66707
		internal static int __PropertyOffset_28;

		// Token: 0x04010494 RID: 66708
		internal static int __PropertyOffset_29;

		// Token: 0x04010495 RID: 66709
		internal static int __PropertyOffset_30;

		// Token: 0x04010496 RID: 66710
		internal static int __PropertyOffset_31;

		// Token: 0x04010497 RID: 66711
		internal static int __PropertyOffset_32;

		// Token: 0x04010498 RID: 66712
		internal static int __PropertyOffset_33;

		// Token: 0x04010499 RID: 66713
		internal static int __PropertyOffset_34;

		// Token: 0x0401049A RID: 66714
		internal static int __PropertyOffset_35;

		// Token: 0x0401049B RID: 66715
		internal static int __PropertyOffset_36;

		// Token: 0x0401049C RID: 66716
		internal static int __PropertyOffset_37;

		// Token: 0x0401049D RID: 66717
		internal static int __PropertyOffset_38;

		// Token: 0x0401049E RID: 66718
		internal static int __PropertyOffset_39;

		// Token: 0x0401049F RID: 66719
		internal static int __PropertyOffset_40;

		// Token: 0x040104A0 RID: 66720
		internal static int __PropertyOffset_41;

		// Token: 0x040104A1 RID: 66721
		internal static int __PropertyOffset_42;

		// Token: 0x040104A2 RID: 66722
		internal static int __PropertyOffset_43;

		// Token: 0x040104A3 RID: 66723
		internal static int __PropertyOffset_44;

		// Token: 0x040104A4 RID: 66724
		internal static int __PropertyOffset_45;

		// Token: 0x040104A5 RID: 66725
		internal static int __PropertyOffset_46;

		// Token: 0x040104A6 RID: 66726
		internal static int __PropertyOffset_47;

		// Token: 0x040104A7 RID: 66727
		internal static int __PropertyOffset_48;

		// Token: 0x040104A8 RID: 66728
		internal static int __PropertyOffset_49;

		// Token: 0x040104A9 RID: 66729
		internal static int __PropertyOffset_50;

		// Token: 0x040104AA RID: 66730
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040104AB RID: 66731
		private static IntPtr __SetQuality_NativeFunctionPtr;

		// Token: 0x040104AC RID: 66732
		private static IntPtr __UpdateVolumetricSphereLight_NativeFunctionPtr;

		// Token: 0x040104AD RID: 66733
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040104AE RID: 66734
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040104AF RID: 66735
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x040104B0 RID: 66736
		private static IntPtr __SetLightIntensityScale_NativeFunctionPtr;

		// Token: 0x040104B1 RID: 66737
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x02009C8F RID: 40079
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x0403134D RID: 201549
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C90 RID: 40080
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __Update_FunctionParams
		{
			// Token: 0x0403134E RID: 201550
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C91 RID: 40081
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __SetLightIntensityScale_FunctionParams
		{
			// Token: 0x0403134F RID: 201551
			[FieldOffset(0)]
			public float ScaleFactor;
		}
	}
}
