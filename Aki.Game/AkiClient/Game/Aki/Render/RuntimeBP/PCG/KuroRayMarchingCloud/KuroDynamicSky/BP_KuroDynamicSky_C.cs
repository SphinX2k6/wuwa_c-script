using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.KuroDynamicSky
{
	// Token: 0x02003C80 RID: 15488
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/KuroDynamicSky/BP_KuroDynamicSky.BP_KuroDynamicSky_C")]
	[UnrealStructLayout(2192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2192)]
	public class BP_KuroDynamicSky_C : AKuroBPCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602410A RID: 147722 RVA: 0x009342EA File Offset: 0x009324EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroDynamicSky_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/KuroDynamicSky/BP_KuroDynamicSky.BP_KuroDynamicSky_C");
			}
			return BP_KuroDynamicSky_C._ClassPtr;
		}

		// Token: 0x0602410B RID: 147723 RVA: 0x00934310 File Offset: 0x00932510
		public BP_KuroDynamicSky_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroDynamicSky_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602410C RID: 147724 RVA: 0x00934338 File Offset: 0x00932538
		[NullableContext(1)]
		public BP_KuroDynamicSky_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroDynamicSky_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x0602410D RID: 147725 RVA: 0x0093436B File Offset: 0x0093256B
		// (set) Token: 0x0602410E RID: 147726 RVA: 0x0093437F File Offset: 0x0093257F
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x0602410F RID: 147727 RVA: 0x00934394 File Offset: 0x00932594
		// (set) Token: 0x06024110 RID: 147728 RVA: 0x009343A8 File Offset: 0x009325A8
		public unsafe UNiagaraComponent NS_DynamicSkyThunder
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x06024111 RID: 147729 RVA: 0x009343BD File Offset: 0x009325BD
		// (set) Token: 0x06024112 RID: 147730 RVA: 0x009343D1 File Offset: 0x009325D1
		public unsafe UStaticMeshComponent SkyCloud_Mobile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x06024113 RID: 147731 RVA: 0x009343E6 File Offset: 0x009325E6
		// (set) Token: 0x06024114 RID: 147732 RVA: 0x009343FA File Offset: 0x009325FA
		public unsafe UVolumetricCloudComponent VolumetricCloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumetricCloudComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x06024115 RID: 147733 RVA: 0x0093440F File Offset: 0x0093260F
		// (set) Token: 0x06024116 RID: 147734 RVA: 0x00934423 File Offset: 0x00932623
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x06024117 RID: 147735 RVA: 0x00934438 File Offset: 0x00932638
		// (set) Token: 0x06024118 RID: 147736 RVA: 0x00934448 File Offset: 0x00932648
		public unsafe float Shadow_Sample_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x06024119 RID: 147737 RVA: 0x00934459 File Offset: 0x00932659
		// (set) Token: 0x0602411A RID: 147738 RVA: 0x00934469 File Offset: 0x00932669
		public unsafe float Distance_to_Sample_Max_Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x0602411B RID: 147739 RVA: 0x0093447A File Offset: 0x0093267A
		// (set) Token: 0x0602411C RID: 147740 RVA: 0x0093448A File Offset: 0x0093268A
		public unsafe float Shadow_Tracing_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x0602411D RID: 147741 RVA: 0x0093449B File Offset: 0x0093269B
		// (set) Token: 0x0602411E RID: 147742 RVA: 0x009344AB File Offset: 0x009326AB
		public unsafe float Tracing_Max_Start_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x0602411F RID: 147743 RVA: 0x009344BC File Offset: 0x009326BC
		// (set) Token: 0x06024120 RID: 147744 RVA: 0x009344CC File Offset: 0x009326CC
		public unsafe float Tracing_Max_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x06024121 RID: 147745 RVA: 0x009344DD File Offset: 0x009326DD
		// (set) Token: 0x06024122 RID: 147746 RVA: 0x009344ED File Offset: 0x009326ED
		public unsafe float View_Sample_Count_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x06024123 RID: 147747 RVA: 0x009344FE File Offset: 0x009326FE
		// (set) Token: 0x06024124 RID: 147748 RVA: 0x0093450E File Offset: 0x0093270E
		public unsafe float Layer_Height_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x06024125 RID: 147749 RVA: 0x0093451F File Offset: 0x0093271F
		// (set) Token: 0x06024126 RID: 147750 RVA: 0x0093452F File Offset: 0x0093272F
		public unsafe float Bottom_Altitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x06024127 RID: 147751 RVA: 0x00934540 File Offset: 0x00932740
		// (set) Token: 0x06024128 RID: 147752 RVA: 0x00934550 File Offset: 0x00932750
		public unsafe float SubNoise_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x06024129 RID: 147753 RVA: 0x00934561 File Offset: 0x00932761
		// (set) Token: 0x0602412A RID: 147754 RVA: 0x00934571 File Offset: 0x00932771
		public unsafe float High_Frequency_Noise_Layer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x0602412B RID: 147755 RVA: 0x00934582 File Offset: 0x00932782
		// (set) Token: 0x0602412C RID: 147756 RVA: 0x00934592 File Offset: 0x00932792
		public unsafe float Extinction_Scale_Top
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004510 RID: 17680
		// (get) Token: 0x0602412D RID: 147757 RVA: 0x009345A3 File Offset: 0x009327A3
		// (set) Token: 0x0602412E RID: 147758 RVA: 0x009345B3 File Offset: 0x009327B3
		public unsafe float Extinction_Scale_Bottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004511 RID: 17681
		// (get) Token: 0x0602412F RID: 147759 RVA: 0x009345C4 File Offset: 0x009327C4
		// (set) Token: 0x06024130 RID: 147760 RVA: 0x009345D4 File Offset: 0x009327D4
		public unsafe float SubNoise_Erosion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004512 RID: 17682
		// (get) Token: 0x06024131 RID: 147761 RVA: 0x009345E5 File Offset: 0x009327E5
		// (set) Token: 0x06024132 RID: 147762 RVA: 0x009345F5 File Offset: 0x009327F5
		public unsafe float Multiscattering_Occlusion_Factor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004513 RID: 17683
		// (get) Token: 0x06024133 RID: 147763 RVA: 0x00934606 File Offset: 0x00932806
		// (set) Token: 0x06024134 RID: 147764 RVA: 0x00934616 File Offset: 0x00932816
		public unsafe float MultiScattering_Eccentricity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004514 RID: 17684
		// (get) Token: 0x06024135 RID: 147765 RVA: 0x00934627 File Offset: 0x00932827
		// (set) Token: 0x06024136 RID: 147766 RVA: 0x00934637 File Offset: 0x00932837
		public unsafe float Volumetric_Clouds_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x06024137 RID: 147767 RVA: 0x00934648 File Offset: 0x00932848
		// (set) Token: 0x06024138 RID: 147768 RVA: 0x00934658 File Offset: 0x00932858
		public unsafe float Cloud_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x06024139 RID: 147769 RVA: 0x00934669 File Offset: 0x00932869
		// (set) Token: 0x0602413A RID: 147770 RVA: 0x00934679 File Offset: 0x00932879
		public unsafe float Phase_G
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x0602413B RID: 147771 RVA: 0x0093468A File Offset: 0x0093288A
		// (set) Token: 0x0602413C RID: 147772 RVA: 0x0093469A File Offset: 0x0093289A
		public unsafe float Phase_G_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x0602413D RID: 147773 RVA: 0x009346AB File Offset: 0x009328AB
		// (set) Token: 0x0602413E RID: 147774 RVA: 0x009346BB File Offset: 0x009328BB
		public unsafe float Multiscattering_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x0602413F RID: 147775 RVA: 0x009346CC File Offset: 0x009328CC
		// (set) Token: 0x06024140 RID: 147776 RVA: 0x009346DC File Offset: 0x009328DC
		public unsafe float Overall_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x06024141 RID: 147777 RVA: 0x009346ED File Offset: 0x009328ED
		// (set) Token: 0x06024142 RID: 147778 RVA: 0x00934701 File Offset: 0x00932901
		public unsafe FLinearColor Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x06024143 RID: 147779 RVA: 0x00934716 File Offset: 0x00932916
		// (set) Token: 0x06024144 RID: 147780 RVA: 0x00934726 File Offset: 0x00932926
		public unsafe float Base_Clouds_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x06024145 RID: 147781 RVA: 0x00934737 File Offset: 0x00932937
		// (set) Token: 0x06024146 RID: 147782 RVA: 0x0093474B File Offset: 0x0093294B
		public unsafe UMaterialInterface Mateiral
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x06024147 RID: 147783 RVA: 0x00934760 File Offset: 0x00932960
		// (set) Token: 0x06024148 RID: 147784 RVA: 0x00934770 File Offset: 0x00932970
		public unsafe bool bPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x06024149 RID: 147785 RVA: 0x00934781 File Offset: 0x00932981
		// (set) Token: 0x0602414A RID: 147786 RVA: 0x00934791 File Offset: 0x00932991
		public unsafe float Custom_Lighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x0602414B RID: 147787 RVA: 0x009347A2 File Offset: 0x009329A2
		// (set) Token: 0x0602414C RID: 147788 RVA: 0x009347B6 File Offset: 0x009329B6
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x0602414D RID: 147789 RVA: 0x009347CB File Offset: 0x009329CB
		// (set) Token: 0x0602414E RID: 147790 RVA: 0x009347DB File Offset: 0x009329DB
		public unsafe float VolumeCloudMainLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x0602414F RID: 147791 RVA: 0x009347EC File Offset: 0x009329EC
		// (set) Token: 0x06024150 RID: 147792 RVA: 0x00934800 File Offset: 0x00932A00
		public unsafe FLinearColor ShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x06024151 RID: 147793 RVA: 0x00934815 File Offset: 0x00932A15
		// (set) Token: 0x06024152 RID: 147794 RVA: 0x00934825 File Offset: 0x00932A25
		public unsafe float VolumeCloudSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x06024153 RID: 147795 RVA: 0x00934836 File Offset: 0x00932A36
		// (set) Token: 0x06024154 RID: 147796 RVA: 0x0093484A File Offset: 0x00932A4A
		public unsafe UMaterialInterface Mateiral_Mobile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x06024155 RID: 147797 RVA: 0x00934860 File Offset: 0x00932A60
		// (set) Token: 0x06024156 RID: 147798 RVA: 0x00934899 File Offset: 0x00932A99
		[Nullable(1)]
		public FKuroSkyVolumetricCloudSetting Setting
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroSkyVolumetricCloudSetting result;
				if ((result = this._Setting) == null)
				{
					result = (this._Setting = new FKuroSkyVolumetricCloudSetting(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_37, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroSkyVolumetricCloudSetting.StaticStruct(), base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_37, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x06024157 RID: 147799 RVA: 0x009348BA File Offset: 0x00932ABA
		// (set) Token: 0x06024158 RID: 147800 RVA: 0x009348CE File Offset: 0x00932ACE
		public unsafe FLinearColor OffsetFromSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x06024159 RID: 147801 RVA: 0x009348E3 File Offset: 0x00932AE3
		// (set) Token: 0x0602415A RID: 147802 RVA: 0x009348F7 File Offset: 0x00932AF7
		public unsafe FVector2D ThunderRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x0602415B RID: 147803 RVA: 0x0093490C File Offset: 0x00932B0C
		// (set) Token: 0x0602415C RID: 147804 RVA: 0x00934920 File Offset: 0x00932B20
		public unsafe FVectorDouble ThunderCenterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x0602415D RID: 147805 RVA: 0x00934935 File Offset: 0x00932B35
		// (set) Token: 0x0602415E RID: 147806 RVA: 0x00934949 File Offset: 0x00932B49
		public unsafe UCurveFloat ThunderCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x0602415F RID: 147807 RVA: 0x0093495E File Offset: 0x00932B5E
		// (set) Token: 0x06024160 RID: 147808 RVA: 0x00934972 File Offset: 0x00932B72
		public unsafe FVectorDouble ThunderSpawnPoistion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x06024161 RID: 147809 RVA: 0x00934987 File Offset: 0x00932B87
		// (set) Token: 0x06024162 RID: 147810 RVA: 0x00934997 File Offset: 0x00932B97
		public unsafe bool bStartThunder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x06024163 RID: 147811 RVA: 0x009349A8 File Offset: 0x00932BA8
		// (set) Token: 0x06024164 RID: 147812 RVA: 0x009349B8 File Offset: 0x00932BB8
		public unsafe float ThunderDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x06024165 RID: 147813 RVA: 0x009349C9 File Offset: 0x00932BC9
		// (set) Token: 0x06024166 RID: 147814 RVA: 0x009349DD File Offset: 0x00932BDD
		public unsafe FLinearColor ThunderColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x06024167 RID: 147815 RVA: 0x009349F2 File Offset: 0x00932BF2
		// (set) Token: 0x06024168 RID: 147816 RVA: 0x00934A02 File Offset: 0x00932C02
		public unsafe float ThunderTimeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x06024169 RID: 147817 RVA: 0x00934A13 File Offset: 0x00932C13
		// (set) Token: 0x0602416A RID: 147818 RVA: 0x00934A23 File Offset: 0x00932C23
		public unsafe float ThunderIntervalMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x0602416B RID: 147819 RVA: 0x00934A34 File Offset: 0x00932C34
		// (set) Token: 0x0602416C RID: 147820 RVA: 0x00934A44 File Offset: 0x00932C44
		public unsafe float ThunderIntervalCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x0602416D RID: 147821 RVA: 0x00934A55 File Offset: 0x00932C55
		// (set) Token: 0x0602416E RID: 147822 RVA: 0x00934A65 File Offset: 0x00932C65
		public unsafe float ThunderIntervalMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x0602416F RID: 147823 RVA: 0x00934A76 File Offset: 0x00932C76
		// (set) Token: 0x06024170 RID: 147824 RVA: 0x00934A86 File Offset: 0x00932C86
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x06024171 RID: 147825 RVA: 0x00934A97 File Offset: 0x00932C97
		// (set) Token: 0x06024172 RID: 147826 RVA: 0x00934AA7 File Offset: 0x00932CA7
		public unsafe bool bUseCameraAsThunderCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x06024173 RID: 147827 RVA: 0x00934AB8 File Offset: 0x00932CB8
		// (set) Token: 0x06024174 RID: 147828 RVA: 0x00934ACC File Offset: 0x00932CCC
		public unsafe UAkAudioEvent ThunderAudio
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_52);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x06024175 RID: 147829 RVA: 0x00934AE1 File Offset: 0x00932CE1
		// (set) Token: 0x06024176 RID: 147830 RVA: 0x00934AF1 File Offset: 0x00932CF1
		public unsafe bool bEnableThunder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x06024177 RID: 147831 RVA: 0x00934B02 File Offset: 0x00932D02
		// (set) Token: 0x06024178 RID: 147832 RVA: 0x00934B12 File Offset: 0x00932D12
		public unsafe bool bPlayAudio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x06024179 RID: 147833 RVA: 0x00934B23 File Offset: 0x00932D23
		// (set) Token: 0x0602417A RID: 147834 RVA: 0x00934B33 File Offset: 0x00932D33
		public unsafe bool bReseted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x0602417B RID: 147835 RVA: 0x00934B44 File Offset: 0x00932D44
		// (set) Token: 0x0602417C RID: 147836 RVA: 0x00934B54 File Offset: 0x00932D54
		public unsafe float CamerForwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x0602417D RID: 147837 RVA: 0x00934B65 File Offset: 0x00932D65
		// (set) Token: 0x0602417E RID: 147838 RVA: 0x00934B79 File Offset: 0x00932D79
		public unsafe FTransform Out_Camera_Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x0602417F RID: 147839 RVA: 0x00934B8E File Offset: 0x00932D8E
		// (set) Token: 0x06024180 RID: 147840 RVA: 0x00934B9E File Offset: 0x00932D9E
		public unsafe bool bEnablePostprocess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_58) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_58) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x06024181 RID: 147841 RVA: 0x00934BAF File Offset: 0x00932DAF
		// (set) Token: 0x06024182 RID: 147842 RVA: 0x00934BBF File Offset: 0x00932DBF
		public unsafe float TimeLerpStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroDynamicSky_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x06024183 RID: 147843 RVA: 0x00934BD0 File Offset: 0x00932DD0
		// (set) Token: 0x06024184 RID: 147844 RVA: 0x00934BE4 File Offset: 0x00932DE4
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroDynamicSky_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x06024185 RID: 147845 RVA: 0x00934BF9 File Offset: 0x00932DF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetThunder()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__ResetThunder_NativeFunctionPtr, null);
		}

		// Token: 0x06024186 RID: 147846 RVA: 0x00934C0D File Offset: 0x00932E0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TryToSpawnThunder()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__TryToSpawnThunder_NativeFunctionPtr, null);
		}

		// Token: 0x06024187 RID: 147847 RVA: 0x00934C21 File Offset: 0x00932E21
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateThunder()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__UpdateThunder_NativeFunctionPtr, null);
		}

		// Token: 0x06024188 RID: 147848 RVA: 0x00934C35 File Offset: 0x00932E35
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SpawnThunder()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__SpawnThunder_NativeFunctionPtr, null);
		}

		// Token: 0x06024189 RID: 147849 RVA: 0x00934C49 File Offset: 0x00932E49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_Params_from_Setting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__Init_Params_from_Setting_NativeFunctionPtr, null);
		}

		// Token: 0x0602418A RID: 147850 RVA: 0x00934C5D File Offset: 0x00932E5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__UpdateCloudParams_NativeFunctionPtr, null);
		}

		// Token: 0x0602418B RID: 147851 RVA: 0x00934C71 File Offset: 0x00932E71
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602418C RID: 147852 RVA: 0x00934C85 File Offset: 0x00932E85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroDynamicSky_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602418D RID: 147853 RVA: 0x00934C9A File Offset: 0x00932E9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602418E RID: 147854 RVA: 0x00934CAE File Offset: 0x00932EAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroDynamicSky_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602418F RID: 147855 RVA: 0x00934CC3 File Offset: 0x00932EC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x06024190 RID: 147856 RVA: 0x00934CD7 File Offset: 0x00932ED7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroDynamicSky_C.__BeforeCookForMobile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024191 RID: 147857 RVA: 0x00934CEC File Offset: 0x00932EEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x06024192 RID: 147858 RVA: 0x00934D00 File Offset: 0x00932F00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroDynamicSky_C.__BeforeCookForPC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024193 RID: 147859 RVA: 0x00934D15 File Offset: 0x00932F15
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroDynamicSky_C.__BeforeSave_NativeFunctionPtr, null);
		}

		// Token: 0x06024194 RID: 147860 RVA: 0x00934D29 File Offset: 0x00932F29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BeforeSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroDynamicSky_C.__BeforeSave_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024195 RID: 147861 RVA: 0x00934D3E File Offset: 0x00932F3E
		protected BP_KuroDynamicSky_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DA4 RID: 73124
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/KuroDynamicSky/BP_KuroDynamicSky.BP_KuroDynamicSky_C";

		// Token: 0x04011DA5 RID: 73125
		private static IntPtr _ClassPtr;

		// Token: 0x04011DA6 RID: 73126
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DA7 RID: 73127
		internal static int __PropertyOffset_1;

		// Token: 0x04011DA8 RID: 73128
		internal static int __PropertyOffset_2;

		// Token: 0x04011DA9 RID: 73129
		internal static int __PropertyOffset_3;

		// Token: 0x04011DAA RID: 73130
		internal static int __PropertyOffset_4;

		// Token: 0x04011DAB RID: 73131
		internal static int __PropertyOffset_5;

		// Token: 0x04011DAC RID: 73132
		internal static int __PropertyOffset_6;

		// Token: 0x04011DAD RID: 73133
		internal static int __PropertyOffset_7;

		// Token: 0x04011DAE RID: 73134
		internal static int __PropertyOffset_8;

		// Token: 0x04011DAF RID: 73135
		internal static int __PropertyOffset_9;

		// Token: 0x04011DB0 RID: 73136
		internal static int __PropertyOffset_10;

		// Token: 0x04011DB1 RID: 73137
		internal static int __PropertyOffset_11;

		// Token: 0x04011DB2 RID: 73138
		internal static int __PropertyOffset_12;

		// Token: 0x04011DB3 RID: 73139
		internal static int __PropertyOffset_13;

		// Token: 0x04011DB4 RID: 73140
		internal static int __PropertyOffset_14;

		// Token: 0x04011DB5 RID: 73141
		internal static int __PropertyOffset_15;

		// Token: 0x04011DB6 RID: 73142
		internal static int __PropertyOffset_16;

		// Token: 0x04011DB7 RID: 73143
		internal static int __PropertyOffset_17;

		// Token: 0x04011DB8 RID: 73144
		internal static int __PropertyOffset_18;

		// Token: 0x04011DB9 RID: 73145
		internal static int __PropertyOffset_19;

		// Token: 0x04011DBA RID: 73146
		internal static int __PropertyOffset_20;

		// Token: 0x04011DBB RID: 73147
		internal static int __PropertyOffset_21;

		// Token: 0x04011DBC RID: 73148
		internal static int __PropertyOffset_22;

		// Token: 0x04011DBD RID: 73149
		internal static int __PropertyOffset_23;

		// Token: 0x04011DBE RID: 73150
		internal static int __PropertyOffset_24;

		// Token: 0x04011DBF RID: 73151
		internal static int __PropertyOffset_25;

		// Token: 0x04011DC0 RID: 73152
		internal static int __PropertyOffset_26;

		// Token: 0x04011DC1 RID: 73153
		internal static int __PropertyOffset_27;

		// Token: 0x04011DC2 RID: 73154
		internal static int __PropertyOffset_28;

		// Token: 0x04011DC3 RID: 73155
		internal static int __PropertyOffset_29;

		// Token: 0x04011DC4 RID: 73156
		internal static int __PropertyOffset_30;

		// Token: 0x04011DC5 RID: 73157
		internal static int __PropertyOffset_31;

		// Token: 0x04011DC6 RID: 73158
		internal static int __PropertyOffset_32;

		// Token: 0x04011DC7 RID: 73159
		internal static int __PropertyOffset_33;

		// Token: 0x04011DC8 RID: 73160
		internal static int __PropertyOffset_34;

		// Token: 0x04011DC9 RID: 73161
		internal static int __PropertyOffset_35;

		// Token: 0x04011DCA RID: 73162
		internal static int __PropertyOffset_36;

		// Token: 0x04011DCB RID: 73163
		internal static int __PropertyOffset_37;

		// Token: 0x04011DCC RID: 73164
		private FKuroSkyVolumetricCloudSetting _Setting;

		// Token: 0x04011DCD RID: 73165
		internal static int __PropertyOffset_38;

		// Token: 0x04011DCE RID: 73166
		internal static int __PropertyOffset_39;

		// Token: 0x04011DCF RID: 73167
		internal static int __PropertyOffset_40;

		// Token: 0x04011DD0 RID: 73168
		internal static int __PropertyOffset_41;

		// Token: 0x04011DD1 RID: 73169
		internal static int __PropertyOffset_42;

		// Token: 0x04011DD2 RID: 73170
		internal static int __PropertyOffset_43;

		// Token: 0x04011DD3 RID: 73171
		internal static int __PropertyOffset_44;

		// Token: 0x04011DD4 RID: 73172
		internal static int __PropertyOffset_45;

		// Token: 0x04011DD5 RID: 73173
		internal static int __PropertyOffset_46;

		// Token: 0x04011DD6 RID: 73174
		internal static int __PropertyOffset_47;

		// Token: 0x04011DD7 RID: 73175
		internal static int __PropertyOffset_48;

		// Token: 0x04011DD8 RID: 73176
		internal static int __PropertyOffset_49;

		// Token: 0x04011DD9 RID: 73177
		internal static int __PropertyOffset_50;

		// Token: 0x04011DDA RID: 73178
		internal static int __PropertyOffset_51;

		// Token: 0x04011DDB RID: 73179
		internal static int __PropertyOffset_52;

		// Token: 0x04011DDC RID: 73180
		internal static int __PropertyOffset_53;

		// Token: 0x04011DDD RID: 73181
		internal static int __PropertyOffset_54;

		// Token: 0x04011DDE RID: 73182
		internal static int __PropertyOffset_55;

		// Token: 0x04011DDF RID: 73183
		internal static int __PropertyOffset_56;

		// Token: 0x04011DE0 RID: 73184
		internal static int __PropertyOffset_57;

		// Token: 0x04011DE1 RID: 73185
		internal static int __PropertyOffset_58;

		// Token: 0x04011DE2 RID: 73186
		internal static int __PropertyOffset_59;

		// Token: 0x04011DE3 RID: 73187
		internal static int __PropertyOffset_60;

		// Token: 0x04011DE4 RID: 73188
		private static IntPtr __ResetThunder_NativeFunctionPtr;

		// Token: 0x04011DE5 RID: 73189
		private static IntPtr __TryToSpawnThunder_NativeFunctionPtr;

		// Token: 0x04011DE6 RID: 73190
		private static IntPtr __UpdateThunder_NativeFunctionPtr;

		// Token: 0x04011DE7 RID: 73191
		private static IntPtr __SpawnThunder_NativeFunctionPtr;

		// Token: 0x04011DE8 RID: 73192
		private static IntPtr __Init_Params_from_Setting_NativeFunctionPtr;

		// Token: 0x04011DE9 RID: 73193
		private static IntPtr __UpdateCloudParams_NativeFunctionPtr;

		// Token: 0x04011DEA RID: 73194
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011DEB RID: 73195
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011DEC RID: 73196
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x04011DED RID: 73197
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x04011DEE RID: 73198
		private static IntPtr __BeforeSave_NativeFunctionPtr;
	}
}
