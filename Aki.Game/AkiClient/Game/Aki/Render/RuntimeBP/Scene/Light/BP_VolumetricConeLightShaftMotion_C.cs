using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B20 RID: 15136
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaftMotion.BP_VolumetricConeLightShaftMotion_C")]
	[UnrealStructLayout(2616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2612)]
	public class BP_VolumetricConeLightShaftMotion_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060212F9 RID: 135929 RVA: 0x008E6CF0 File Offset: 0x008E4EF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaftMotion_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaftMotion.BP_VolumetricConeLightShaftMotion_C");
			}
			return BP_VolumetricConeLightShaftMotion_C._ClassPtr;
		}

		// Token: 0x060212FA RID: 135930 RVA: 0x008E6D14 File Offset: 0x008E4F14
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricConeLightShaftMotion_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x060212FB RID: 135931 RVA: 0x008E6D1C File Offset: 0x008E4F1C
		public BP_VolumetricConeLightShaftMotion_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaftMotion_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060212FC RID: 135932 RVA: 0x008E6D44 File Offset: 0x008E4F44
		[NullableContext(1)]
		public BP_VolumetricConeLightShaftMotion_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaftMotion_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x060212FD RID: 135933 RVA: 0x008E6D77 File Offset: 0x008E4F77
		// (set) Token: 0x060212FE RID: 135934 RVA: 0x008E6D8B File Offset: 0x008E4F8B
		public unsafe USpotLightComponent SpotLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x060212FF RID: 135935 RVA: 0x008E6DA0 File Offset: 0x008E4FA0
		// (set) Token: 0x06021300 RID: 135936 RVA: 0x008E6DB4 File Offset: 0x008E4FB4
		public unsafe UStaticMeshComponent SM_Ird_Lig_03AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x06021301 RID: 135937 RVA: 0x008E6DC9 File Offset: 0x008E4FC9
		// (set) Token: 0x06021302 RID: 135938 RVA: 0x008E6DDD File Offset: 0x008E4FDD
		public unsafe UStaticMeshComponent SM_Lightshaft02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x06021303 RID: 135939 RVA: 0x008E6DF2 File Offset: 0x008E4FF2
		// (set) Token: 0x06021304 RID: 135940 RVA: 0x008E6E06 File Offset: 0x008E5006
		public unsafe UStaticMeshComponent SM_LightFlare
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x06021305 RID: 135941 RVA: 0x008E6E1B File Offset: 0x008E501B
		// (set) Token: 0x06021306 RID: 135942 RVA: 0x008E6E2F File Offset: 0x008E502F
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x06021307 RID: 135943 RVA: 0x008E6E44 File Offset: 0x008E5044
		// (set) Token: 0x06021308 RID: 135944 RVA: 0x008E6E58 File Offset: 0x008E5058
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x06021309 RID: 135945 RVA: 0x008E6E6D File Offset: 0x008E506D
		// (set) Token: 0x0602130A RID: 135946 RVA: 0x008E6E7D File Offset: 0x008E507D
		public unsafe bool EnableSpotLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0602130B RID: 135947 RVA: 0x008E6E8E File Offset: 0x008E508E
		// (set) Token: 0x0602130C RID: 135948 RVA: 0x008E6EA2 File Offset: 0x008E50A2
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0602130D RID: 135949 RVA: 0x008E6EB7 File Offset: 0x008E50B7
		// (set) Token: 0x0602130E RID: 135950 RVA: 0x008E6ECB File Offset: 0x008E50CB
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0602130F RID: 135951 RVA: 0x008E6EE0 File Offset: 0x008E50E0
		// (set) Token: 0x06021310 RID: 135952 RVA: 0x008E6EF4 File Offset: 0x008E50F4
		public unsafe UMaterialInstance MaterialInstanceBT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x06021311 RID: 135953 RVA: 0x008E6F09 File Offset: 0x008E5109
		// (set) Token: 0x06021312 RID: 135954 RVA: 0x008E6F1D File Offset: 0x008E511D
		public unsafe UMaterialInstance MaterialInstanceT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x06021313 RID: 135955 RVA: 0x008E6F32 File Offset: 0x008E5132
		// (set) Token: 0x06021314 RID: 135956 RVA: 0x008E6F46 File Offset: 0x008E5146
		public unsafe FVector MainScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x06021315 RID: 135957 RVA: 0x008E6F5B File Offset: 0x008E515B
		// (set) Token: 0x06021316 RID: 135958 RVA: 0x008E6F6F File Offset: 0x008E516F
		public unsafe FVector VolumetriConeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x06021317 RID: 135959 RVA: 0x008E6F84 File Offset: 0x008E5184
		// (set) Token: 0x06021318 RID: 135960 RVA: 0x008E6F94 File Offset: 0x008E5194
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x06021319 RID: 135961 RVA: 0x008E6FA5 File Offset: 0x008E51A5
		// (set) Token: 0x0602131A RID: 135962 RVA: 0x008E6FB5 File Offset: 0x008E51B5
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0602131B RID: 135963 RVA: 0x008E6FC6 File Offset: 0x008E51C6
		// (set) Token: 0x0602131C RID: 135964 RVA: 0x008E6FD6 File Offset: 0x008E51D6
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0602131D RID: 135965 RVA: 0x008E6FE7 File Offset: 0x008E51E7
		// (set) Token: 0x0602131E RID: 135966 RVA: 0x008E6FF7 File Offset: 0x008E51F7
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0602131F RID: 135967 RVA: 0x008E7008 File Offset: 0x008E5208
		// (set) Token: 0x06021320 RID: 135968 RVA: 0x008E7018 File Offset: 0x008E5218
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x06021321 RID: 135969 RVA: 0x008E7029 File Offset: 0x008E5229
		// (set) Token: 0x06021322 RID: 135970 RVA: 0x008E7039 File Offset: 0x008E5239
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x06021323 RID: 135971 RVA: 0x008E704A File Offset: 0x008E524A
		// (set) Token: 0x06021324 RID: 135972 RVA: 0x008E705A File Offset: 0x008E525A
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x06021325 RID: 135973 RVA: 0x008E706B File Offset: 0x008E526B
		// (set) Token: 0x06021326 RID: 135974 RVA: 0x008E707F File Offset: 0x008E527F
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x06021327 RID: 135975 RVA: 0x008E7094 File Offset: 0x008E5294
		// (set) Token: 0x06021328 RID: 135976 RVA: 0x008E70A8 File Offset: 0x008E52A8
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x06021329 RID: 135977 RVA: 0x008E70BD File Offset: 0x008E52BD
		// (set) Token: 0x0602132A RID: 135978 RVA: 0x008E70CD File Offset: 0x008E52CD
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0602132B RID: 135979 RVA: 0x008E70DE File Offset: 0x008E52DE
		// (set) Token: 0x0602132C RID: 135980 RVA: 0x008E70EE File Offset: 0x008E52EE
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0602132D RID: 135981 RVA: 0x008E70FF File Offset: 0x008E52FF
		// (set) Token: 0x0602132E RID: 135982 RVA: 0x008E710F File Offset: 0x008E530F
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0602132F RID: 135983 RVA: 0x008E7120 File Offset: 0x008E5320
		// (set) Token: 0x06021330 RID: 135984 RVA: 0x008E7130 File Offset: 0x008E5330
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x06021331 RID: 135985 RVA: 0x008E7141 File Offset: 0x008E5341
		// (set) Token: 0x06021332 RID: 135986 RVA: 0x008E7151 File Offset: 0x008E5351
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x06021333 RID: 135987 RVA: 0x008E7162 File Offset: 0x008E5362
		// (set) Token: 0x06021334 RID: 135988 RVA: 0x008E7172 File Offset: 0x008E5372
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x06021335 RID: 135989 RVA: 0x008E7183 File Offset: 0x008E5383
		// (set) Token: 0x06021336 RID: 135990 RVA: 0x008E7197 File Offset: 0x008E5397
		public unsafe FVector LightShaftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x06021337 RID: 135991 RVA: 0x008E71AC File Offset: 0x008E53AC
		// (set) Token: 0x06021338 RID: 135992 RVA: 0x008E71C0 File Offset: 0x008E53C0
		public unsafe UMaterialInstance LightShaftCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x06021339 RID: 135993 RVA: 0x008E71D5 File Offset: 0x008E53D5
		// (set) Token: 0x0602133A RID: 135994 RVA: 0x008E71E9 File Offset: 0x008E53E9
		public unsafe UTexture2D Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0602133B RID: 135995 RVA: 0x008E71FE File Offset: 0x008E53FE
		// (set) Token: 0x0602133C RID: 135996 RVA: 0x008E7212 File Offset: 0x008E5412
		public unsafe FLinearColor FallOff_ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0602133D RID: 135997 RVA: 0x008E7227 File Offset: 0x008E5427
		// (set) Token: 0x0602133E RID: 135998 RVA: 0x008E7237 File Offset: 0x008E5437
		public unsafe float FallOff_DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0602133F RID: 135999 RVA: 0x008E7248 File Offset: 0x008E5448
		// (set) Token: 0x06021340 RID: 136000 RVA: 0x008E7258 File Offset: 0x008E5458
		public unsafe float ScreenFadeFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x06021341 RID: 136001 RVA: 0x008E7269 File Offset: 0x008E5469
		// (set) Token: 0x06021342 RID: 136002 RVA: 0x008E7279 File Offset: 0x008E5479
		public unsafe float Opacity_CenterPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x06021343 RID: 136003 RVA: 0x008E728A File Offset: 0x008E548A
		// (set) Token: 0x06021344 RID: 136004 RVA: 0x008E729A File Offset: 0x008E549A
		public unsafe float ScreenFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x06021345 RID: 136005 RVA: 0x008E72AB File Offset: 0x008E54AB
		// (set) Token: 0x06021346 RID: 136006 RVA: 0x008E72BB File Offset: 0x008E54BB
		public unsafe float ShaftTopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x06021347 RID: 136007 RVA: 0x008E72CC File Offset: 0x008E54CC
		// (set) Token: 0x06021348 RID: 136008 RVA: 0x008E72E0 File Offset: 0x008E54E0
		public unsafe FLinearColor UVScaleAndAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x06021349 RID: 136009 RVA: 0x008E72F5 File Offset: 0x008E54F5
		// (set) Token: 0x0602134A RID: 136010 RVA: 0x008E7305 File Offset: 0x008E5505
		public unsafe float LightMaskZaxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0602134B RID: 136011 RVA: 0x008E7316 File Offset: 0x008E5516
		// (set) Token: 0x0602134C RID: 136012 RVA: 0x008E732A File Offset: 0x008E552A
		public unsafe UMaterialInstance LightMaskMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0602134D RID: 136013 RVA: 0x008E733F File Offset: 0x008E553F
		// (set) Token: 0x0602134E RID: 136014 RVA: 0x008E7353 File Offset: 0x008E5553
		public unsafe FVector LightMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0602134F RID: 136015 RVA: 0x008E7368 File Offset: 0x008E5568
		// (set) Token: 0x06021350 RID: 136016 RVA: 0x008E737C File Offset: 0x008E557C
		public unsafe FLinearColor LightMaskColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x06021351 RID: 136017 RVA: 0x008E7391 File Offset: 0x008E5591
		// (set) Token: 0x06021352 RID: 136018 RVA: 0x008E73A5 File Offset: 0x008E55A5
		public unsafe UTexture2D LightMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x06021353 RID: 136019 RVA: 0x008E73BA File Offset: 0x008E55BA
		// (set) Token: 0x06021354 RID: 136020 RVA: 0x008E73CA File Offset: 0x008E55CA
		public unsafe float ColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x06021355 RID: 136021 RVA: 0x008E73DB File Offset: 0x008E55DB
		// (set) Token: 0x06021356 RID: 136022 RVA: 0x008E73EB File Offset: 0x008E55EB
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x06021357 RID: 136023 RVA: 0x008E73FC File Offset: 0x008E55FC
		// (set) Token: 0x06021358 RID: 136024 RVA: 0x008E740C File Offset: 0x008E560C
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x06021359 RID: 136025 RVA: 0x008E741D File Offset: 0x008E561D
		// (set) Token: 0x0602135A RID: 136026 RVA: 0x008E742D File Offset: 0x008E562D
		public unsafe float FlankInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0602135B RID: 136027 RVA: 0x008E743E File Offset: 0x008E563E
		// (set) Token: 0x0602135C RID: 136028 RVA: 0x008E744E File Offset: 0x008E564E
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0602135D RID: 136029 RVA: 0x008E745F File Offset: 0x008E565F
		// (set) Token: 0x0602135E RID: 136030 RVA: 0x008E746F File Offset: 0x008E566F
		public unsafe float RightSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0602135F RID: 136031 RVA: 0x008E7480 File Offset: 0x008E5680
		// (set) Token: 0x06021360 RID: 136032 RVA: 0x008E7490 File Offset: 0x008E5690
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x06021361 RID: 136033 RVA: 0x008E74A1 File Offset: 0x008E56A1
		// (set) Token: 0x06021362 RID: 136034 RVA: 0x008E74B1 File Offset: 0x008E56B1
		public unsafe float AnimationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x06021363 RID: 136035 RVA: 0x008E74C2 File Offset: 0x008E56C2
		// (set) Token: 0x06021364 RID: 136036 RVA: 0x008E74D2 File Offset: 0x008E56D2
		public unsafe float AnimationAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x06021365 RID: 136037 RVA: 0x008E74E3 File Offset: 0x008E56E3
		// (set) Token: 0x06021366 RID: 136038 RVA: 0x008E74F3 File Offset: 0x008E56F3
		public unsafe bool Tickable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x06021367 RID: 136039 RVA: 0x008E7504 File Offset: 0x008E5704
		// (set) Token: 0x06021368 RID: 136040 RVA: 0x008E7514 File Offset: 0x008E5714
		public unsafe float AnimationBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x06021369 RID: 136041 RVA: 0x008E7525 File Offset: 0x008E5725
		// (set) Token: 0x0602136A RID: 136042 RVA: 0x008E7535 File Offset: 0x008E5735
		public unsafe bool IsPC_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0602136B RID: 136043 RVA: 0x008E7546 File Offset: 0x008E5746
		// (set) Token: 0x0602136C RID: 136044 RVA: 0x008E7556 File Offset: 0x008E5756
		public unsafe bool UseNoiseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0602136D RID: 136045 RVA: 0x008E7567 File Offset: 0x008E5767
		// (set) Token: 0x0602136E RID: 136046 RVA: 0x008E757B File Offset: 0x008E577B
		public unsafe UTexture MainNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0602136F RID: 136047 RVA: 0x008E7590 File Offset: 0x008E5790
		// (set) Token: 0x06021370 RID: 136048 RVA: 0x008E75A4 File Offset: 0x008E57A4
		public unsafe UTexture SecondNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x06021371 RID: 136049 RVA: 0x008E75B9 File Offset: 0x008E57B9
		// (set) Token: 0x06021372 RID: 136050 RVA: 0x008E75CD File Offset: 0x008E57CD
		public unsafe FLinearColor MainNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x06021373 RID: 136051 RVA: 0x008E75E2 File Offset: 0x008E57E2
		// (set) Token: 0x06021374 RID: 136052 RVA: 0x008E75F6 File Offset: 0x008E57F6
		public unsafe FLinearColor SecondNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x06021375 RID: 136053 RVA: 0x008E760B File Offset: 0x008E580B
		// (set) Token: 0x06021376 RID: 136054 RVA: 0x008E761B File Offset: 0x008E581B
		public unsafe float MainUVAddStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x06021377 RID: 136055 RVA: 0x008E762C File Offset: 0x008E582C
		// (set) Token: 0x06021378 RID: 136056 RVA: 0x008E7640 File Offset: 0x008E5840
		public unsafe FLinearColor MainNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x06021379 RID: 136057 RVA: 0x008E7655 File Offset: 0x008E5855
		// (set) Token: 0x0602137A RID: 136058 RVA: 0x008E7669 File Offset: 0x008E5869
		public unsafe FLinearColor SecondNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0602137B RID: 136059 RVA: 0x008E767E File Offset: 0x008E587E
		// (set) Token: 0x0602137C RID: 136060 RVA: 0x008E7692 File Offset: 0x008E5892
		public unsafe UMaterialInstance LightShaftMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0602137D RID: 136061 RVA: 0x008E76A7 File Offset: 0x008E58A7
		// (set) Token: 0x0602137E RID: 136062 RVA: 0x008E76BB File Offset: 0x008E58BB
		public unsafe UMaterialInstance LightShaftMaterial_InStage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0602137F RID: 136063 RVA: 0x008E76D0 File Offset: 0x008E58D0
		// (set) Token: 0x06021380 RID: 136064 RVA: 0x008E7709 File Offset: 0x008E5909
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
					result = (this._LightShaftCone_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_66, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x06021381 RID: 136065 RVA: 0x008E7718 File Offset: 0x008E5918
		// (set) Token: 0x06021382 RID: 136066 RVA: 0x008E7751 File Offset: 0x008E5951
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
					result = (this._LightShaftCone_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_67, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x06021383 RID: 136067 RVA: 0x008E7760 File Offset: 0x008E5960
		// (set) Token: 0x06021384 RID: 136068 RVA: 0x008E7799 File Offset: 0x008E5999
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
					result = (this._LightShaftCone_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_68, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x06021385 RID: 136069 RVA: 0x008E77A7 File Offset: 0x008E59A7
		// (set) Token: 0x06021386 RID: 136070 RVA: 0x008E77BB File Offset: 0x008E59BB
		public unsafe UMaterialInstanceDynamic LightShaftMaterial_DY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_69);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_69, value);
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x06021387 RID: 136071 RVA: 0x008E77D0 File Offset: 0x008E59D0
		// (set) Token: 0x06021388 RID: 136072 RVA: 0x008E77E0 File Offset: 0x008E59E0
		public unsafe bool 启用曲线
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x06021389 RID: 136073 RVA: 0x008E77F4 File Offset: 0x008E59F4
		// (set) Token: 0x0602138A RID: 136074 RVA: 0x008E782D File Offset: 0x008E5A2D
		[Nullable(1)]
		public FKuroCurveVector 摆动曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._摆动曲线) == null)
				{
					result = (this._摆动曲线 = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_71, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_71, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0602138B RID: 136075 RVA: 0x008E784E File Offset: 0x008E5A4E
		// (set) Token: 0x0602138C RID: 136076 RVA: 0x008E785E File Offset: 0x008E5A5E
		public unsafe float 曲线周期
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaftMotion_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x0602138D RID: 136077 RVA: 0x008E7870 File Offset: 0x008E5A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602138E RID: 136078 RVA: 0x008E78B8 File Offset: 0x008E5AB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602138F RID: 136079 RVA: 0x008E78FE File Offset: 0x008E5AFE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_in_Stage_Material()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__Update_in_Stage_Material_NativeFunctionPtr, null);
		}

		// Token: 0x06021390 RID: 136080 RVA: 0x008E7912 File Offset: 0x008E5B12
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 重置旋转()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__重置旋转_NativeFunctionPtr, null);
		}

		// Token: 0x06021391 RID: 136081 RVA: 0x008E7926 File Offset: 0x008E5B26
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021392 RID: 136082 RVA: 0x008E793A File Offset: 0x008E5B3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021393 RID: 136083 RVA: 0x008E794F File Offset: 0x008E5B4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021394 RID: 136084 RVA: 0x008E7963 File Offset: 0x008E5B63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021395 RID: 136085 RVA: 0x008E7978 File Offset: 0x008E5B78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021396 RID: 136086 RVA: 0x008E79C0 File Offset: 0x008E5BC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021397 RID: 136087 RVA: 0x008E7A08 File Offset: 0x008E5C08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftMotion_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftMotion_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftMotion_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftMotion_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021398 RID: 136088 RVA: 0x008E7A50 File Offset: 0x008E5C50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaftMotion_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaftMotion_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaftMotion_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaftMotion_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaftMotion_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021399 RID: 136089 RVA: 0x008E7A97 File Offset: 0x008E5C97
		protected BP_VolumetricConeLightShaftMotion_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010270 RID: 66160
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010271 RID: 66161
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaftMotion.BP_VolumetricConeLightShaftMotion_C";

		// Token: 0x04010272 RID: 66162
		private static IntPtr _ClassPtr;

		// Token: 0x04010273 RID: 66163
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010274 RID: 66164
		internal static int __PropertyOffset_1;

		// Token: 0x04010275 RID: 66165
		internal static int __PropertyOffset_2;

		// Token: 0x04010276 RID: 66166
		internal static int __PropertyOffset_3;

		// Token: 0x04010277 RID: 66167
		internal static int __PropertyOffset_4;

		// Token: 0x04010278 RID: 66168
		internal static int __PropertyOffset_5;

		// Token: 0x04010279 RID: 66169
		internal static int __PropertyOffset_6;

		// Token: 0x0401027A RID: 66170
		internal static int __PropertyOffset_7;

		// Token: 0x0401027B RID: 66171
		internal static int __PropertyOffset_8;

		// Token: 0x0401027C RID: 66172
		internal static int __PropertyOffset_9;

		// Token: 0x0401027D RID: 66173
		internal static int __PropertyOffset_10;

		// Token: 0x0401027E RID: 66174
		internal static int __PropertyOffset_11;

		// Token: 0x0401027F RID: 66175
		internal static int __PropertyOffset_12;

		// Token: 0x04010280 RID: 66176
		internal static int __PropertyOffset_13;

		// Token: 0x04010281 RID: 66177
		internal static int __PropertyOffset_14;

		// Token: 0x04010282 RID: 66178
		internal static int __PropertyOffset_15;

		// Token: 0x04010283 RID: 66179
		internal static int __PropertyOffset_16;

		// Token: 0x04010284 RID: 66180
		internal static int __PropertyOffset_17;

		// Token: 0x04010285 RID: 66181
		internal static int __PropertyOffset_18;

		// Token: 0x04010286 RID: 66182
		internal static int __PropertyOffset_19;

		// Token: 0x04010287 RID: 66183
		internal static int __PropertyOffset_20;

		// Token: 0x04010288 RID: 66184
		internal static int __PropertyOffset_21;

		// Token: 0x04010289 RID: 66185
		internal static int __PropertyOffset_22;

		// Token: 0x0401028A RID: 66186
		internal static int __PropertyOffset_23;

		// Token: 0x0401028B RID: 66187
		internal static int __PropertyOffset_24;

		// Token: 0x0401028C RID: 66188
		internal static int __PropertyOffset_25;

		// Token: 0x0401028D RID: 66189
		internal static int __PropertyOffset_26;

		// Token: 0x0401028E RID: 66190
		internal static int __PropertyOffset_27;

		// Token: 0x0401028F RID: 66191
		internal static int __PropertyOffset_28;

		// Token: 0x04010290 RID: 66192
		internal static int __PropertyOffset_29;

		// Token: 0x04010291 RID: 66193
		internal static int __PropertyOffset_30;

		// Token: 0x04010292 RID: 66194
		internal static int __PropertyOffset_31;

		// Token: 0x04010293 RID: 66195
		internal static int __PropertyOffset_32;

		// Token: 0x04010294 RID: 66196
		internal static int __PropertyOffset_33;

		// Token: 0x04010295 RID: 66197
		internal static int __PropertyOffset_34;

		// Token: 0x04010296 RID: 66198
		internal static int __PropertyOffset_35;

		// Token: 0x04010297 RID: 66199
		internal static int __PropertyOffset_36;

		// Token: 0x04010298 RID: 66200
		internal static int __PropertyOffset_37;

		// Token: 0x04010299 RID: 66201
		internal static int __PropertyOffset_38;

		// Token: 0x0401029A RID: 66202
		internal static int __PropertyOffset_39;

		// Token: 0x0401029B RID: 66203
		internal static int __PropertyOffset_40;

		// Token: 0x0401029C RID: 66204
		internal static int __PropertyOffset_41;

		// Token: 0x0401029D RID: 66205
		internal static int __PropertyOffset_42;

		// Token: 0x0401029E RID: 66206
		internal static int __PropertyOffset_43;

		// Token: 0x0401029F RID: 66207
		internal static int __PropertyOffset_44;

		// Token: 0x040102A0 RID: 66208
		internal static int __PropertyOffset_45;

		// Token: 0x040102A1 RID: 66209
		internal static int __PropertyOffset_46;

		// Token: 0x040102A2 RID: 66210
		internal static int __PropertyOffset_47;

		// Token: 0x040102A3 RID: 66211
		internal static int __PropertyOffset_48;

		// Token: 0x040102A4 RID: 66212
		internal static int __PropertyOffset_49;

		// Token: 0x040102A5 RID: 66213
		internal static int __PropertyOffset_50;

		// Token: 0x040102A6 RID: 66214
		internal static int __PropertyOffset_51;

		// Token: 0x040102A7 RID: 66215
		internal static int __PropertyOffset_52;

		// Token: 0x040102A8 RID: 66216
		internal static int __PropertyOffset_53;

		// Token: 0x040102A9 RID: 66217
		internal static int __PropertyOffset_54;

		// Token: 0x040102AA RID: 66218
		internal static int __PropertyOffset_55;

		// Token: 0x040102AB RID: 66219
		internal static int __PropertyOffset_56;

		// Token: 0x040102AC RID: 66220
		internal static int __PropertyOffset_57;

		// Token: 0x040102AD RID: 66221
		internal static int __PropertyOffset_58;

		// Token: 0x040102AE RID: 66222
		internal static int __PropertyOffset_59;

		// Token: 0x040102AF RID: 66223
		internal static int __PropertyOffset_60;

		// Token: 0x040102B0 RID: 66224
		internal static int __PropertyOffset_61;

		// Token: 0x040102B1 RID: 66225
		internal static int __PropertyOffset_62;

		// Token: 0x040102B2 RID: 66226
		internal static int __PropertyOffset_63;

		// Token: 0x040102B3 RID: 66227
		internal static int __PropertyOffset_64;

		// Token: 0x040102B4 RID: 66228
		internal static int __PropertyOffset_65;

		// Token: 0x040102B5 RID: 66229
		internal static int __PropertyOffset_66;

		// Token: 0x040102B6 RID: 66230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _LightShaftCone_Textures;

		// Token: 0x040102B7 RID: 66231
		internal static int __PropertyOffset_67;

		// Token: 0x040102B8 RID: 66232
		private TMap<FName, float> _LightShaftCone_Scalars;

		// Token: 0x040102B9 RID: 66233
		internal static int __PropertyOffset_68;

		// Token: 0x040102BA RID: 66234
		private TMap<FName, FLinearColor> _LightShaftCone_Vectors;

		// Token: 0x040102BB RID: 66235
		internal static int __PropertyOffset_69;

		// Token: 0x040102BC RID: 66236
		internal static int __PropertyOffset_70;

		// Token: 0x040102BD RID: 66237
		internal static int __PropertyOffset_71;

		// Token: 0x040102BE RID: 66238
		private FKuroCurveVector _摆动曲线;

		// Token: 0x040102BF RID: 66239
		internal static int __PropertyOffset_72;

		// Token: 0x040102C0 RID: 66240
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040102C1 RID: 66241
		private static IntPtr __Update_in_Stage_Material_NativeFunctionPtr;

		// Token: 0x040102C2 RID: 66242
		private static IntPtr __重置旋转_NativeFunctionPtr;

		// Token: 0x040102C3 RID: 66243
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040102C4 RID: 66244
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040102C5 RID: 66245
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040102C6 RID: 66246
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C78 RID: 40056
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031336 RID: 201526
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C79 RID: 40057
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031337 RID: 201527
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C7A RID: 40058
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031338 RID: 201528
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
