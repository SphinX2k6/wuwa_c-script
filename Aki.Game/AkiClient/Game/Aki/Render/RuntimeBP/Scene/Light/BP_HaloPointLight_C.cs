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
	// Token: 0x02003B05 RID: 15109
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_HaloPointLight.BP_HaloPointLight_C")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1269)]
	public class BP_HaloPointLight_C : APointLight, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020D67 RID: 134503 RVA: 0x008DE761 File Offset: 0x008DC961
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HaloPointLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_HaloPointLight.BP_HaloPointLight_C");
			}
			return BP_HaloPointLight_C._ClassPtr;
		}

		// Token: 0x06020D68 RID: 134504 RVA: 0x008DE785 File Offset: 0x008DC985
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_HaloPointLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020D69 RID: 134505 RVA: 0x008DE78C File Offset: 0x008DC98C
		public BP_HaloPointLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_HaloPointLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D6A RID: 134506 RVA: 0x008DE7B4 File Offset: 0x008DC9B4
		[NullableContext(1)]
		public BP_HaloPointLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HaloPointLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x06020D6B RID: 134507 RVA: 0x008DE7E7 File Offset: 0x008DC9E7
		// (set) Token: 0x06020D6C RID: 134508 RVA: 0x008DE7FB File Offset: 0x008DC9FB
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x06020D6D RID: 134509 RVA: 0x008DE810 File Offset: 0x008DCA10
		// (set) Token: 0x06020D6E RID: 134510 RVA: 0x008DE820 File Offset: 0x008DCA20
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x06020D6F RID: 134511 RVA: 0x008DE831 File Offset: 0x008DCA31
		// (set) Token: 0x06020D70 RID: 134512 RVA: 0x008DE841 File Offset: 0x008DCA41
		public unsafe bool bAcceptGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x06020D71 RID: 134513 RVA: 0x008DE852 File Offset: 0x008DCA52
		// (set) Token: 0x06020D72 RID: 134514 RVA: 0x008DE862 File Offset: 0x008DCA62
		public unsafe bool Enable_Black
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x06020D73 RID: 134515 RVA: 0x008DE873 File Offset: 0x008DCA73
		// (set) Token: 0x06020D74 RID: 134516 RVA: 0x008DE883 File Offset: 0x008DCA83
		public unsafe bool FaceToCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x06020D75 RID: 134517 RVA: 0x008DE894 File Offset: 0x008DCA94
		// (set) Token: 0x06020D76 RID: 134518 RVA: 0x008DE8A4 File Offset: 0x008DCAA4
		public unsafe float SizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x06020D77 RID: 134519 RVA: 0x008DE8B5 File Offset: 0x008DCAB5
		// (set) Token: 0x06020D78 RID: 134520 RVA: 0x008DE8C5 File Offset: 0x008DCAC5
		public unsafe float IntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x06020D79 RID: 134521 RVA: 0x008DE8D6 File Offset: 0x008DCAD6
		// (set) Token: 0x06020D7A RID: 134522 RVA: 0x008DE8E6 File Offset: 0x008DCAE6
		public unsafe float LightExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x06020D7B RID: 134523 RVA: 0x008DE8F7 File Offset: 0x008DCAF7
		// (set) Token: 0x06020D7C RID: 134524 RVA: 0x008DE907 File Offset: 0x008DCB07
		public unsafe float FadeStartRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x06020D7D RID: 134525 RVA: 0x008DE918 File Offset: 0x008DCB18
		// (set) Token: 0x06020D7E RID: 134526 RVA: 0x008DE928 File Offset: 0x008DCB28
		public unsafe float FadeEndRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x06020D7F RID: 134527 RVA: 0x008DE939 File Offset: 0x008DCB39
		// (set) Token: 0x06020D80 RID: 134528 RVA: 0x008DE94D File Offset: 0x008DCB4D
		public unsafe UKuroHaloComponent HaloComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroHaloComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x06020D81 RID: 134529 RVA: 0x008DE962 File Offset: 0x008DCB62
		// (set) Token: 0x06020D82 RID: 134530 RVA: 0x008DE972 File Offset: 0x008DCB72
		public unsafe float DepthFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x06020D83 RID: 134531 RVA: 0x008DE983 File Offset: 0x008DCB83
		// (set) Token: 0x06020D84 RID: 134532 RVA: 0x008DE993 File Offset: 0x008DCB93
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x06020D85 RID: 134533 RVA: 0x008DE9A4 File Offset: 0x008DCBA4
		// (set) Token: 0x06020D86 RID: 134534 RVA: 0x008DE9B8 File Offset: 0x008DCBB8
		[Nullable(0)]
		public unsafe TEnumAsByte<E_BillboardMode> FaceCameraMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_14);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x06020D87 RID: 134535 RVA: 0x008DE9CD File Offset: 0x008DCBCD
		// (set) Token: 0x06020D88 RID: 134536 RVA: 0x008DE9E1 File Offset: 0x008DCBE1
		public unsafe UStaticMesh HaloMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x06020D89 RID: 134537 RVA: 0x008DE9F6 File Offset: 0x008DCBF6
		// (set) Token: 0x06020D8A RID: 134538 RVA: 0x008DEA06 File Offset: 0x008DCC06
		public unsafe float MinDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x06020D8B RID: 134539 RVA: 0x008DEA17 File Offset: 0x008DCC17
		// (set) Token: 0x06020D8C RID: 134540 RVA: 0x008DEA27 File Offset: 0x008DCC27
		public unsafe float MaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x06020D8D RID: 134541 RVA: 0x008DEA38 File Offset: 0x008DCC38
		// (set) Token: 0x06020D8E RID: 134542 RVA: 0x008DEA48 File Offset: 0x008DCC48
		public unsafe float MinDrawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x06020D8F RID: 134543 RVA: 0x008DEA59 File Offset: 0x008DCC59
		// (set) Token: 0x06020D90 RID: 134544 RVA: 0x008DEA69 File Offset: 0x008DCC69
		public unsafe float MaxDrawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x06020D91 RID: 134545 RVA: 0x008DEA7A File Offset: 0x008DCC7A
		// (set) Token: 0x06020D92 RID: 134546 RVA: 0x008DEA8A File Offset: 0x008DCC8A
		public unsafe float UseShapeTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x06020D93 RID: 134547 RVA: 0x008DEA9B File Offset: 0x008DCC9B
		// (set) Token: 0x06020D94 RID: 134548 RVA: 0x008DEAAF File Offset: 0x008DCCAF
		public unsafe UTexture2D VolumeTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x06020D95 RID: 134549 RVA: 0x008DEAC4 File Offset: 0x008DCCC4
		// (set) Token: 0x06020D96 RID: 134550 RVA: 0x008DEAD4 File Offset: 0x008DCCD4
		public unsafe float PointLinghtIntenty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x06020D97 RID: 134551 RVA: 0x008DEAE5 File Offset: 0x008DCCE5
		// (set) Token: 0x06020D98 RID: 134552 RVA: 0x008DEAF9 File Offset: 0x008DCCF9
		public unsafe PD_HaloPointLightConfig_C HaloPointConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_HaloPointLightConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x06020D99 RID: 134553 RVA: 0x008DEB0E File Offset: 0x008DCD0E
		// (set) Token: 0x06020D9A RID: 134554 RVA: 0x008DEB1E File Offset: 0x008DCD1E
		public unsafe KuroFeatureLevel CurrentFeatureLevel
		{
			get
			{
				return (KuroFeatureLevel)(*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_24));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_24) = (byte)value;
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x06020D9B RID: 134555 RVA: 0x008DEB2F File Offset: 0x008DCD2F
		// (set) Token: 0x06020D9C RID: 134556 RVA: 0x008DEB43 File Offset: 0x008DCD43
		public unsafe UMaterialInterface HaloMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x06020D9D RID: 134557 RVA: 0x008DEB58 File Offset: 0x008DCD58
		// (set) Token: 0x06020D9E RID: 134558 RVA: 0x008DEB6C File Offset: 0x008DCD6C
		public unsafe UMaterialInterface HaloMaterial_NoBillboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x06020D9F RID: 134559 RVA: 0x008DEB81 File Offset: 0x008DCD81
		// (set) Token: 0x06020DA0 RID: 134560 RVA: 0x008DEB95 File Offset: 0x008DCD95
		public unsafe FVector NoFaceCameraSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x06020DA1 RID: 134561 RVA: 0x008DEBAA File Offset: 0x008DCDAA
		// (set) Token: 0x06020DA2 RID: 134562 RVA: 0x008DEBBE File Offset: 0x008DCDBE
		public unsafe UMaterialInterface HaloMaterial_NoBillboard_Black
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x06020DA3 RID: 134563 RVA: 0x008DEBD3 File Offset: 0x008DCDD3
		// (set) Token: 0x06020DA4 RID: 134564 RVA: 0x008DEBE7 File Offset: 0x008DCDE7
		public unsafe UMaterialInterface HaloMaterial_Black
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HaloPointLight_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x06020DA5 RID: 134565 RVA: 0x008DEBFC File Offset: 0x008DCDFC
		// (set) Token: 0x06020DA6 RID: 134566 RVA: 0x008DEC0C File Offset: 0x008DCE0C
		public unsafe int TranslucentSortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x06020DA7 RID: 134567 RVA: 0x008DEC1D File Offset: 0x008DCE1D
		// (set) Token: 0x06020DA8 RID: 134568 RVA: 0x008DEC2D File Offset: 0x008DCE2D
		public unsafe int FrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x06020DA9 RID: 134569 RVA: 0x008DEC3E File Offset: 0x008DCE3E
		// (set) Token: 0x06020DAA RID: 134570 RVA: 0x008DEC52 File Offset: 0x008DCE52
		[Nullable(0)]
		public unsafe TEnumAsByte<ELightQualityType> Quality
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_32);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x06020DAB RID: 134571 RVA: 0x008DEC67 File Offset: 0x008DCE67
		// (set) Token: 0x06020DAC RID: 134572 RVA: 0x008DEC77 File Offset: 0x008DCE77
		public unsafe int CurrentQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x06020DAD RID: 134573 RVA: 0x008DEC88 File Offset: 0x008DCE88
		// (set) Token: 0x06020DAE RID: 134574 RVA: 0x008DEC98 File Offset: 0x008DCE98
		public unsafe float BoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x06020DAF RID: 134575 RVA: 0x008DECA9 File Offset: 0x008DCEA9
		// (set) Token: 0x06020DB0 RID: 134576 RVA: 0x008DECB9 File Offset: 0x008DCEB9
		public unsafe bool bNeedToShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HaloPointLight_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020DB1 RID: 134577 RVA: 0x008DECCC File Offset: 0x008DCECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_HaloPointLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_HaloPointLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HaloPointLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HaloPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020DB2 RID: 134578 RVA: 0x008DED14 File Offset: 0x008DCF14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_HaloPointLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_HaloPointLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HaloPointLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HaloPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HaloPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020DB3 RID: 134579 RVA: 0x008DED5A File Offset: 0x008DCF5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetQuality()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__SetQuality_NativeFunctionPtr, null);
		}

		// Token: 0x06020DB4 RID: 134580 RVA: 0x008DED70 File Offset: 0x008DCF70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetHaloDrawParameters(ref float MinDrawDistance, ref float MaxDrawDistance, ref float MinDrawRange, ref float MaxDrawRange)
		{
			BP_HaloPointLight_C.__GetHaloDrawParameters_FunctionParams* ptr = stackalloc BP_HaloPointLight_C.__GetHaloDrawParameters_FunctionParams[(UIntPtr)171] + 15L / (long)sizeof(BP_HaloPointLight_C.__GetHaloDrawParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HaloPointLight_C.__GetHaloDrawParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MinDrawDistance = MinDrawDistance;
			ptr->MaxDrawDistance = MaxDrawDistance;
			ptr->MinDrawRange = MinDrawRange;
			ptr->MaxDrawRange = MaxDrawRange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__GetHaloDrawParameters_NativeFunctionPtr, (void*)ptr);
			MinDrawDistance = ptr->MinDrawDistance;
			MaxDrawDistance = ptr->MaxDrawDistance;
			MinDrawRange = ptr->MinDrawRange;
			MaxDrawRange = ptr->MaxDrawRange;
		}

		// Token: 0x06020DB5 RID: 134581 RVA: 0x008DEDF4 File Offset: 0x008DCFF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateHaloParameter(bool UpdateComponent)
		{
			BP_HaloPointLight_C.__UpdateHaloParameter_FunctionParams* ptr = stackalloc BP_HaloPointLight_C.__UpdateHaloParameter_FunctionParams[(UIntPtr)195] + 15L / (long)sizeof(BP_HaloPointLight_C.__UpdateHaloParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HaloPointLight_C.__UpdateHaloParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UpdateComponent = UpdateComponent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__UpdateHaloParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DB6 RID: 134582 RVA: 0x008DEE3D File Offset: 0x008DD03D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020DB7 RID: 134583 RVA: 0x008DEE51 File Offset: 0x008DD051
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HaloPointLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020DB8 RID: 134584 RVA: 0x008DEE66 File Offset: 0x008DD066
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020DB9 RID: 134585 RVA: 0x008DEE7A File Offset: 0x008DD07A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HaloPointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020DBA RID: 134586 RVA: 0x008DEE8F File Offset: 0x008DD08F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void HaloPointParaUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__HaloPointParaUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x06020DBB RID: 134587 RVA: 0x008DEEA3 File Offset: 0x008DD0A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void HaloPointParaUpdate_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HaloPointLight_C.__HaloPointParaUpdate_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020DBC RID: 134588 RVA: 0x008DEEB8 File Offset: 0x008DD0B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_HaloPointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HaloPointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HaloPointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HaloPointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DBD RID: 134589 RVA: 0x008DEF00 File Offset: 0x008DD100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_HaloPointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HaloPointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HaloPointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HaloPointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HaloPointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020DBE RID: 134590 RVA: 0x008DEF47 File Offset: 0x008DD147
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HaloPointLight_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06020DBF RID: 134591 RVA: 0x008DEF5B File Offset: 0x008DD15B
		protected BP_HaloPointLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF49 RID: 65353
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0400FF4A RID: 65354
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_HaloPointLight.BP_HaloPointLight_C";

		// Token: 0x0400FF4B RID: 65355
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF4C RID: 65356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF4D RID: 65357
		internal static int __PropertyOffset_1;

		// Token: 0x0400FF4E RID: 65358
		internal static int __PropertyOffset_2;

		// Token: 0x0400FF4F RID: 65359
		internal static int __PropertyOffset_3;

		// Token: 0x0400FF50 RID: 65360
		internal static int __PropertyOffset_4;

		// Token: 0x0400FF51 RID: 65361
		internal static int __PropertyOffset_5;

		// Token: 0x0400FF52 RID: 65362
		internal static int __PropertyOffset_6;

		// Token: 0x0400FF53 RID: 65363
		internal static int __PropertyOffset_7;

		// Token: 0x0400FF54 RID: 65364
		internal static int __PropertyOffset_8;

		// Token: 0x0400FF55 RID: 65365
		internal static int __PropertyOffset_9;

		// Token: 0x0400FF56 RID: 65366
		internal static int __PropertyOffset_10;

		// Token: 0x0400FF57 RID: 65367
		internal static int __PropertyOffset_11;

		// Token: 0x0400FF58 RID: 65368
		internal static int __PropertyOffset_12;

		// Token: 0x0400FF59 RID: 65369
		internal static int __PropertyOffset_13;

		// Token: 0x0400FF5A RID: 65370
		internal static int __PropertyOffset_14;

		// Token: 0x0400FF5B RID: 65371
		internal static int __PropertyOffset_15;

		// Token: 0x0400FF5C RID: 65372
		internal static int __PropertyOffset_16;

		// Token: 0x0400FF5D RID: 65373
		internal static int __PropertyOffset_17;

		// Token: 0x0400FF5E RID: 65374
		internal static int __PropertyOffset_18;

		// Token: 0x0400FF5F RID: 65375
		internal static int __PropertyOffset_19;

		// Token: 0x0400FF60 RID: 65376
		internal static int __PropertyOffset_20;

		// Token: 0x0400FF61 RID: 65377
		internal static int __PropertyOffset_21;

		// Token: 0x0400FF62 RID: 65378
		internal static int __PropertyOffset_22;

		// Token: 0x0400FF63 RID: 65379
		internal static int __PropertyOffset_23;

		// Token: 0x0400FF64 RID: 65380
		internal static int __PropertyOffset_24;

		// Token: 0x0400FF65 RID: 65381
		internal static int __PropertyOffset_25;

		// Token: 0x0400FF66 RID: 65382
		internal static int __PropertyOffset_26;

		// Token: 0x0400FF67 RID: 65383
		internal static int __PropertyOffset_27;

		// Token: 0x0400FF68 RID: 65384
		internal static int __PropertyOffset_28;

		// Token: 0x0400FF69 RID: 65385
		internal static int __PropertyOffset_29;

		// Token: 0x0400FF6A RID: 65386
		internal static int __PropertyOffset_30;

		// Token: 0x0400FF6B RID: 65387
		internal static int __PropertyOffset_31;

		// Token: 0x0400FF6C RID: 65388
		internal static int __PropertyOffset_32;

		// Token: 0x0400FF6D RID: 65389
		internal static int __PropertyOffset_33;

		// Token: 0x0400FF6E RID: 65390
		internal static int __PropertyOffset_34;

		// Token: 0x0400FF6F RID: 65391
		internal static int __PropertyOffset_35;

		// Token: 0x0400FF70 RID: 65392
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x0400FF71 RID: 65393
		private static IntPtr __SetQuality_NativeFunctionPtr;

		// Token: 0x0400FF72 RID: 65394
		private static IntPtr __GetHaloDrawParameters_NativeFunctionPtr;

		// Token: 0x0400FF73 RID: 65395
		private static IntPtr __UpdateHaloParameter_NativeFunctionPtr;

		// Token: 0x0400FF74 RID: 65396
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FF75 RID: 65397
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FF76 RID: 65398
		private static IntPtr __HaloPointParaUpdate_NativeFunctionPtr;

		// Token: 0x0400FF77 RID: 65399
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FF78 RID: 65400
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x02009C43 RID: 40003
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040312F4 RID: 201460
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C44 RID: 40004
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 156)]
		protected ref struct __GetHaloDrawParameters_FunctionParams
		{
			// Token: 0x040312F5 RID: 201461
			[FieldOffset(0)]
			public float MinDrawDistance;

			// Token: 0x040312F6 RID: 201462
			[FieldOffset(4)]
			public float MaxDrawDistance;

			// Token: 0x040312F7 RID: 201463
			[FieldOffset(8)]
			public float MinDrawRange;

			// Token: 0x040312F8 RID: 201464
			[FieldOffset(12)]
			public float MaxDrawRange;
		}

		// Token: 0x02009C45 RID: 40005
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 180)]
		protected ref struct __UpdateHaloParameter_FunctionParams
		{
			// Token: 0x040312F9 RID: 201465
			[FieldOffset(0)]
			public bool UpdateComponent;
		}

		// Token: 0x02009C46 RID: 40006
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312FA RID: 201466
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
