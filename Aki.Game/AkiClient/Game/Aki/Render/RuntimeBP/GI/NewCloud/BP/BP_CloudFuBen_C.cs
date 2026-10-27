using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D57 RID: 15703
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBen.BP_CloudFuBen_C")]
	[UnrealStructLayout(2080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2076)]
	public class BP_CloudFuBen_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026447 RID: 156743 RVA: 0x00970680 File Offset: 0x0096E880
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudFuBen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBen.BP_CloudFuBen_C");
			}
			return BP_CloudFuBen_C._ClassPtr;
		}

		// Token: 0x06026448 RID: 156744 RVA: 0x009706A4 File Offset: 0x0096E8A4
		public BP_CloudFuBen_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudFuBen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026449 RID: 156745 RVA: 0x009706CC File Offset: 0x0096E8CC
		[NullableContext(1)]
		public BP_CloudFuBen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudFuBen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005151 RID: 20817
		// (get) Token: 0x0602644A RID: 156746 RVA: 0x009706FF File Offset: 0x0096E8FF
		// (set) Token: 0x0602644B RID: 156747 RVA: 0x00970713 File Offset: 0x0096E913
		public unsafe UStaticMeshComponent Cloud_Anomalies
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005152 RID: 20818
		// (get) Token: 0x0602644C RID: 156748 RVA: 0x00970728 File Offset: 0x0096E928
		// (set) Token: 0x0602644D RID: 156749 RVA: 0x0097073C File Offset: 0x0096E93C
		public unsafe UStaticMeshComponent Sun_Moon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005153 RID: 20819
		// (get) Token: 0x0602644E RID: 156750 RVA: 0x00970751 File Offset: 0x0096E951
		// (set) Token: 0x0602644F RID: 156751 RVA: 0x00970765 File Offset: 0x0096E965
		public unsafe UStaticMeshComponent Cloud_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005154 RID: 20820
		// (get) Token: 0x06026450 RID: 156752 RVA: 0x0097077A File Offset: 0x0096E97A
		// (set) Token: 0x06026451 RID: 156753 RVA: 0x0097078E File Offset: 0x0096E98E
		public unsafe UStaticMeshComponent Cloud_Special
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005155 RID: 20821
		// (get) Token: 0x06026452 RID: 156754 RVA: 0x009707A3 File Offset: 0x0096E9A3
		// (set) Token: 0x06026453 RID: 156755 RVA: 0x009707B7 File Offset: 0x0096E9B7
		public unsafe UStaticMeshComponent Cloud_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005156 RID: 20822
		// (get) Token: 0x06026454 RID: 156756 RVA: 0x009707CC File Offset: 0x0096E9CC
		// (set) Token: 0x06026455 RID: 156757 RVA: 0x009707E0 File Offset: 0x0096E9E0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005157 RID: 20823
		// (get) Token: 0x06026456 RID: 156758 RVA: 0x009707F5 File Offset: 0x0096E9F5
		// (set) Token: 0x06026457 RID: 156759 RVA: 0x00970809 File Offset: 0x0096EA09
		public unsafe UMaterialInstanceDynamic DMI_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005158 RID: 20824
		// (get) Token: 0x06026458 RID: 156760 RVA: 0x0097081E File Offset: 0x0096EA1E
		// (set) Token: 0x06026459 RID: 156761 RVA: 0x00970832 File Offset: 0x0096EA32
		public unsafe UMaterialInstanceDynamic DMI_Anomalies
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005159 RID: 20825
		// (get) Token: 0x0602645A RID: 156762 RVA: 0x00970847 File Offset: 0x0096EA47
		// (set) Token: 0x0602645B RID: 156763 RVA: 0x0097085B File Offset: 0x0096EA5B
		public unsafe UMaterialInstanceDynamic DMI_SunMoon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700515A RID: 20826
		// (get) Token: 0x0602645C RID: 156764 RVA: 0x00970870 File Offset: 0x0096EA70
		// (set) Token: 0x0602645D RID: 156765 RVA: 0x00970884 File Offset: 0x0096EA84
		public unsafe UMaterialInstanceDynamic DMI_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700515B RID: 20827
		// (get) Token: 0x0602645E RID: 156766 RVA: 0x00970899 File Offset: 0x0096EA99
		// (set) Token: 0x0602645F RID: 156767 RVA: 0x009708A9 File Offset: 0x0096EAA9
		public unsafe bool UpdatePerFourFrame01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700515C RID: 20828
		// (get) Token: 0x06026460 RID: 156768 RVA: 0x009708BA File Offset: 0x0096EABA
		// (set) Token: 0x06026461 RID: 156769 RVA: 0x009708CA File Offset: 0x0096EACA
		public unsafe bool UpdatePerFourFrame02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700515D RID: 20829
		// (get) Token: 0x06026462 RID: 156770 RVA: 0x009708DB File Offset: 0x0096EADB
		// (set) Token: 0x06026463 RID: 156771 RVA: 0x009708EF File Offset: 0x0096EAEF
		public unsafe UTexture2D Top_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700515E RID: 20830
		// (get) Token: 0x06026464 RID: 156772 RVA: 0x00970904 File Offset: 0x0096EB04
		// (set) Token: 0x06026465 RID: 156773 RVA: 0x00970918 File Offset: 0x0096EB18
		public unsafe UTexture2D POI_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700515F RID: 20831
		// (get) Token: 0x06026466 RID: 156774 RVA: 0x0097092D File Offset: 0x0096EB2D
		// (set) Token: 0x06026467 RID: 156775 RVA: 0x00970941 File Offset: 0x0096EB41
		public unsafe FRotator POI_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005160 RID: 20832
		// (get) Token: 0x06026468 RID: 156776 RVA: 0x00970956 File Offset: 0x0096EB56
		// (set) Token: 0x06026469 RID: 156777 RVA: 0x0097096A File Offset: 0x0096EB6A
		public unsafe UMaterialInstance TOP_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17005161 RID: 20833
		// (get) Token: 0x0602646A RID: 156778 RVA: 0x0097097F File Offset: 0x0096EB7F
		// (set) Token: 0x0602646B RID: 156779 RVA: 0x0097098F File Offset: 0x0096EB8F
		public unsafe bool UV1UV2_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005162 RID: 20834
		// (get) Token: 0x0602646C RID: 156780 RVA: 0x009709A0 File Offset: 0x0096EBA0
		// (set) Token: 0x0602646D RID: 156781 RVA: 0x009709B0 File Offset: 0x0096EBB0
		public unsafe float UVTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005163 RID: 20835
		// (get) Token: 0x0602646E RID: 156782 RVA: 0x009709C1 File Offset: 0x0096EBC1
		// (set) Token: 0x0602646F RID: 156783 RVA: 0x009709D1 File Offset: 0x0096EBD1
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005164 RID: 20836
		// (get) Token: 0x06026470 RID: 156784 RVA: 0x009709E2 File Offset: 0x0096EBE2
		// (set) Token: 0x06026471 RID: 156785 RVA: 0x009709F2 File Offset: 0x0096EBF2
		public unsafe float Top_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005165 RID: 20837
		// (get) Token: 0x06026472 RID: 156786 RVA: 0x00970A03 File Offset: 0x0096EC03
		// (set) Token: 0x06026473 RID: 156787 RVA: 0x00970A17 File Offset: 0x0096EC17
		public unsafe UTexture2D Special_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005166 RID: 20838
		// (get) Token: 0x06026474 RID: 156788 RVA: 0x00970A2C File Offset: 0x0096EC2C
		// (set) Token: 0x06026475 RID: 156789 RVA: 0x00970A40 File Offset: 0x0096EC40
		public unsafe UMaterialInstance Special_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17005167 RID: 20839
		// (get) Token: 0x06026476 RID: 156790 RVA: 0x00970A55 File Offset: 0x0096EC55
		// (set) Token: 0x06026477 RID: 156791 RVA: 0x00970A69 File Offset: 0x0096EC69
		public unsafe FRotator Special_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005168 RID: 20840
		// (get) Token: 0x06026478 RID: 156792 RVA: 0x00970A7E File Offset: 0x0096EC7E
		// (set) Token: 0x06026479 RID: 156793 RVA: 0x00970A8E File Offset: 0x0096EC8E
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005169 RID: 20841
		// (get) Token: 0x0602647A RID: 156794 RVA: 0x00970A9F File Offset: 0x0096EC9F
		// (set) Token: 0x0602647B RID: 156795 RVA: 0x00970AAF File Offset: 0x0096ECAF
		public unsafe int TransSortNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700516A RID: 20842
		// (get) Token: 0x0602647C RID: 156796 RVA: 0x00970AC0 File Offset: 0x0096ECC0
		// (set) Token: 0x0602647D RID: 156797 RVA: 0x00970AD4 File Offset: 0x0096ECD4
		public unsafe UStaticMesh CloudSpecialMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x1700516B RID: 20843
		// (get) Token: 0x0602647E RID: 156798 RVA: 0x00970AE9 File Offset: 0x0096ECE9
		// (set) Token: 0x0602647F RID: 156799 RVA: 0x00970AFD File Offset: 0x0096ECFD
		public unsafe UTexture2D Noise_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x1700516C RID: 20844
		// (get) Token: 0x06026480 RID: 156800 RVA: 0x00970B12 File Offset: 0x0096ED12
		// (set) Token: 0x06026481 RID: 156801 RVA: 0x00970B22 File Offset: 0x0096ED22
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700516D RID: 20845
		// (get) Token: 0x06026482 RID: 156802 RVA: 0x00970B33 File Offset: 0x0096ED33
		// (set) Token: 0x06026483 RID: 156803 RVA: 0x00970B43 File Offset: 0x0096ED43
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700516E RID: 20846
		// (get) Token: 0x06026484 RID: 156804 RVA: 0x00970B54 File Offset: 0x0096ED54
		// (set) Token: 0x06026485 RID: 156805 RVA: 0x00970B64 File Offset: 0x0096ED64
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700516F RID: 20847
		// (get) Token: 0x06026486 RID: 156806 RVA: 0x00970B75 File Offset: 0x0096ED75
		// (set) Token: 0x06026487 RID: 156807 RVA: 0x00970B89 File Offset: 0x0096ED89
		public unsafe UTexture2D Anomalies_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17005170 RID: 20848
		// (get) Token: 0x06026488 RID: 156808 RVA: 0x00970B9E File Offset: 0x0096ED9E
		// (set) Token: 0x06026489 RID: 156809 RVA: 0x00970BB2 File Offset: 0x0096EDB2
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17005171 RID: 20849
		// (get) Token: 0x0602648A RID: 156810 RVA: 0x00970BC7 File Offset: 0x0096EDC7
		// (set) Token: 0x0602648B RID: 156811 RVA: 0x00970BDB File Offset: 0x0096EDDB
		public unsafe FRotator Anomalies_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17005172 RID: 20850
		// (get) Token: 0x0602648C RID: 156812 RVA: 0x00970BF0 File Offset: 0x0096EDF0
		// (set) Token: 0x0602648D RID: 156813 RVA: 0x00970C00 File Offset: 0x0096EE00
		public unsafe float Anomalies_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17005173 RID: 20851
		// (get) Token: 0x0602648E RID: 156814 RVA: 0x00970C11 File Offset: 0x0096EE11
		// (set) Token: 0x0602648F RID: 156815 RVA: 0x00970C25 File Offset: 0x0096EE25
		public unsafe FVector Anomalies_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17005174 RID: 20852
		// (get) Token: 0x06026490 RID: 156816 RVA: 0x00970C3C File Offset: 0x0096EE3C
		// (set) Token: 0x06026491 RID: 156817 RVA: 0x00970C75 File Offset: 0x0096EE75
		[Nullable(1)]
		public FKuroCurveFloat Sky
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Sky) == null)
				{
					result = (this._Sky = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_36, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_36, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005175 RID: 20853
		// (get) Token: 0x06026492 RID: 156818 RVA: 0x00970C98 File Offset: 0x0096EE98
		// (set) Token: 0x06026493 RID: 156819 RVA: 0x00970CD1 File Offset: 0x0096EED1
		[Nullable(1)]
		public FKuroCurveFloat StarTrails
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StarTrails) == null)
				{
					result = (this._StarTrails = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_37, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_37, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005176 RID: 20854
		// (get) Token: 0x06026494 RID: 156820 RVA: 0x00970CF2 File Offset: 0x0096EEF2
		// (set) Token: 0x06026495 RID: 156821 RVA: 0x00970D02 File Offset: 0x0096EF02
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17005177 RID: 20855
		// (get) Token: 0x06026496 RID: 156822 RVA: 0x00970D13 File Offset: 0x0096EF13
		// (set) Token: 0x06026497 RID: 156823 RVA: 0x00970D23 File Offset: 0x0096EF23
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17005178 RID: 20856
		// (get) Token: 0x06026498 RID: 156824 RVA: 0x00970D34 File Offset: 0x0096EF34
		// (set) Token: 0x06026499 RID: 156825 RVA: 0x00970D44 File Offset: 0x0096EF44
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17005179 RID: 20857
		// (get) Token: 0x0602649A RID: 156826 RVA: 0x00970D55 File Offset: 0x0096EF55
		// (set) Token: 0x0602649B RID: 156827 RVA: 0x00970D65 File Offset: 0x0096EF65
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700517A RID: 20858
		// (get) Token: 0x0602649C RID: 156828 RVA: 0x00970D76 File Offset: 0x0096EF76
		// (set) Token: 0x0602649D RID: 156829 RVA: 0x00970D86 File Offset: 0x0096EF86
		public unsafe float Anomalies_NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x1700517B RID: 20859
		// (get) Token: 0x0602649E RID: 156830 RVA: 0x00970D97 File Offset: 0x0096EF97
		// (set) Token: 0x0602649F RID: 156831 RVA: 0x00970DA7 File Offset: 0x0096EFA7
		public unsafe float Anomalies_NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x1700517C RID: 20860
		// (get) Token: 0x060264A0 RID: 156832 RVA: 0x00970DB8 File Offset: 0x0096EFB8
		// (set) Token: 0x060264A1 RID: 156833 RVA: 0x00970DC8 File Offset: 0x0096EFC8
		public unsafe float Anomalies_NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x1700517D RID: 20861
		// (get) Token: 0x060264A2 RID: 156834 RVA: 0x00970DD9 File Offset: 0x0096EFD9
		// (set) Token: 0x060264A3 RID: 156835 RVA: 0x00970DED File Offset: 0x0096EFED
		public unsafe UTexture2D Anomalies_NoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x1700517E RID: 20862
		// (get) Token: 0x060264A4 RID: 156836 RVA: 0x00970E02 File Offset: 0x0096F002
		// (set) Token: 0x060264A5 RID: 156837 RVA: 0x00970E16 File Offset: 0x0096F016
		[Nullable(1)]
		public unsafe string LevelLog
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CloudFuBen_C.__PropertyOffset_46)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CloudFuBen_C.__PropertyOffset_46)), value);
			}
		}

		// Token: 0x1700517F RID: 20863
		// (get) Token: 0x060264A6 RID: 156838 RVA: 0x00970E2B File Offset: 0x0096F02B
		// (set) Token: 0x060264A7 RID: 156839 RVA: 0x00970E3B File Offset: 0x0096F03B
		public unsafe float Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x060264A8 RID: 156840 RVA: 0x00970E4C File Offset: 0x0096F04C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_CloudFuBen_C.__Timer_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CloudFuBen_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x060264A9 RID: 156841 RVA: 0x00970E9C File Offset: 0x0096F09C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeSky(bool IsTick)
		{
			BP_CloudFuBen_C.__ChangeSky_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__ChangeSky_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_CloudFuBen_C.__ChangeSky_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__ChangeSky_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsTick = IsTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__ChangeSky_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060264AA RID: 156842 RVA: 0x00970EE4 File Offset: 0x0096F0E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Special_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation, float Intensity, FVector Scale, UTexture2D NoiseTex, float NoiseSpeed, float NoiseStrength, float NoiseTilling, FLinearColor Color)
		{
			BP_CloudFuBen_C.__Special_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Special_Parameters_Initial_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_CloudFuBen_C.__Special_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Special_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			ptr->Intensity = Intensity;
			ptr->Scale = Scale;
			ptr->NoiseTex = ((NoiseTex != null) ? NoiseTex.NativePtr : IntPtr.Zero);
			ptr->NoiseSpeed = NoiseSpeed;
			ptr->NoiseStrength = NoiseStrength;
			ptr->NoiseTilling = NoiseTilling;
			ptr->Color = Color;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Special_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060264AB RID: 156843 RVA: 0x00970FB8 File Offset: 0x0096F1B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SunMoon_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation, float Intensity)
		{
			BP_CloudFuBen_C.__SunMoon_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__SunMoon_Parameters_Initial_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BP_CloudFuBen_C.__SunMoon_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__SunMoon_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			ptr->Intensity = Intensity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__SunMoon_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060264AC RID: 156844 RVA: 0x0097104C File Offset: 0x0096F24C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Single_POI_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation)
		{
			BP_CloudFuBen_C.__Single_POI_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Single_POI_Parameters_Initial_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_CloudFuBen_C.__Single_POI_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Single_POI_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Single_POI_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060264AD RID: 156845 RVA: 0x009710D8 File Offset: 0x0096F2D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePerFourFrame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__UpdatePerFourFrame_NativeFunctionPtr, null);
		}

		// Token: 0x060264AE RID: 156846 RVA: 0x009710EC File Offset: 0x0096F2EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CreateDMI(UStaticMeshComponent Mesh, UMaterialInstance Material, ref UMaterialInstanceDynamic DMI)
		{
			BP_CloudFuBen_C.__CreateDMI_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__CreateDMI_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CloudFuBen_C.__CreateDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__CreateDMI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ref BP_CloudFuBen_C.__CreateDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMI;
			ptr2.DMI = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__CreateDMI_NativeFunctionPtr, (void*)ptr);
			DMI = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMI);
		}

		// Token: 0x060264AF RID: 156847 RVA: 0x0097117C File Offset: 0x0096F37C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Single_Cloud_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, bool UV1UV2_, float CloudSpeed, float Top_Rotation, float UVTiling, float NoiseStrength, float NoiseSpeed, float NoiseTilling, UTexture2D NoiseTex)
		{
			BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->UV1UV2_ = UV1UV2_;
			ptr->CloudSpeed = CloudSpeed;
			ptr->Top_Rotation = Top_Rotation;
			ptr->UVTiling = UVTiling;
			ptr->NoiseStrength = NoiseStrength;
			ptr->NoiseSpeed = NoiseSpeed;
			ptr->NoiseTilling = NoiseTilling;
			ptr->NoiseTex = ((NoiseTex != null) ? NoiseTex.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060264B0 RID: 156848 RVA: 0x0097124D File Offset: 0x0096F44D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060264B1 RID: 156849 RVA: 0x00971261 File Offset: 0x0096F461
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060264B2 RID: 156850 RVA: 0x00971276 File Offset: 0x0096F476
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060264B3 RID: 156851 RVA: 0x0097128A File Offset: 0x0096F48A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060264B4 RID: 156852 RVA: 0x009712A0 File Offset: 0x0096F4A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060264B5 RID: 156853 RVA: 0x009712E8 File Offset: 0x0096F4E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060264B6 RID: 156854 RVA: 0x00971330 File Offset: 0x0096F530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060264B7 RID: 156855 RVA: 0x00971378 File Offset: 0x0096F578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060264B8 RID: 156856 RVA: 0x009713BF File Offset: 0x0096F5BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x060264B9 RID: 156857 RVA: 0x009713D3 File Offset: 0x0096F5D3
		protected BP_CloudFuBen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040132B2 RID: 78514
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBen.BP_CloudFuBen_C";

		// Token: 0x040132B3 RID: 78515
		private static IntPtr _ClassPtr;

		// Token: 0x040132B4 RID: 78516
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040132B5 RID: 78517
		internal static int __PropertyOffset_1;

		// Token: 0x040132B6 RID: 78518
		internal static int __PropertyOffset_2;

		// Token: 0x040132B7 RID: 78519
		internal static int __PropertyOffset_3;

		// Token: 0x040132B8 RID: 78520
		internal static int __PropertyOffset_4;

		// Token: 0x040132B9 RID: 78521
		internal static int __PropertyOffset_5;

		// Token: 0x040132BA RID: 78522
		internal static int __PropertyOffset_6;

		// Token: 0x040132BB RID: 78523
		internal static int __PropertyOffset_7;

		// Token: 0x040132BC RID: 78524
		internal static int __PropertyOffset_8;

		// Token: 0x040132BD RID: 78525
		internal static int __PropertyOffset_9;

		// Token: 0x040132BE RID: 78526
		internal static int __PropertyOffset_10;

		// Token: 0x040132BF RID: 78527
		internal static int __PropertyOffset_11;

		// Token: 0x040132C0 RID: 78528
		internal static int __PropertyOffset_12;

		// Token: 0x040132C1 RID: 78529
		internal static int __PropertyOffset_13;

		// Token: 0x040132C2 RID: 78530
		internal static int __PropertyOffset_14;

		// Token: 0x040132C3 RID: 78531
		internal static int __PropertyOffset_15;

		// Token: 0x040132C4 RID: 78532
		internal static int __PropertyOffset_16;

		// Token: 0x040132C5 RID: 78533
		internal static int __PropertyOffset_17;

		// Token: 0x040132C6 RID: 78534
		internal static int __PropertyOffset_18;

		// Token: 0x040132C7 RID: 78535
		internal static int __PropertyOffset_19;

		// Token: 0x040132C8 RID: 78536
		internal static int __PropertyOffset_20;

		// Token: 0x040132C9 RID: 78537
		internal static int __PropertyOffset_21;

		// Token: 0x040132CA RID: 78538
		internal static int __PropertyOffset_22;

		// Token: 0x040132CB RID: 78539
		internal static int __PropertyOffset_23;

		// Token: 0x040132CC RID: 78540
		internal static int __PropertyOffset_24;

		// Token: 0x040132CD RID: 78541
		internal static int __PropertyOffset_25;

		// Token: 0x040132CE RID: 78542
		internal static int __PropertyOffset_26;

		// Token: 0x040132CF RID: 78543
		internal static int __PropertyOffset_27;

		// Token: 0x040132D0 RID: 78544
		internal static int __PropertyOffset_28;

		// Token: 0x040132D1 RID: 78545
		internal static int __PropertyOffset_29;

		// Token: 0x040132D2 RID: 78546
		internal static int __PropertyOffset_30;

		// Token: 0x040132D3 RID: 78547
		internal static int __PropertyOffset_31;

		// Token: 0x040132D4 RID: 78548
		internal static int __PropertyOffset_32;

		// Token: 0x040132D5 RID: 78549
		internal static int __PropertyOffset_33;

		// Token: 0x040132D6 RID: 78550
		internal static int __PropertyOffset_34;

		// Token: 0x040132D7 RID: 78551
		internal static int __PropertyOffset_35;

		// Token: 0x040132D8 RID: 78552
		internal static int __PropertyOffset_36;

		// Token: 0x040132D9 RID: 78553
		private FKuroCurveFloat _Sky;

		// Token: 0x040132DA RID: 78554
		internal static int __PropertyOffset_37;

		// Token: 0x040132DB RID: 78555
		private FKuroCurveFloat _StarTrails;

		// Token: 0x040132DC RID: 78556
		internal static int __PropertyOffset_38;

		// Token: 0x040132DD RID: 78557
		internal static int __PropertyOffset_39;

		// Token: 0x040132DE RID: 78558
		internal static int __PropertyOffset_40;

		// Token: 0x040132DF RID: 78559
		internal static int __PropertyOffset_41;

		// Token: 0x040132E0 RID: 78560
		internal static int __PropertyOffset_42;

		// Token: 0x040132E1 RID: 78561
		internal static int __PropertyOffset_43;

		// Token: 0x040132E2 RID: 78562
		internal static int __PropertyOffset_44;

		// Token: 0x040132E3 RID: 78563
		internal static int __PropertyOffset_45;

		// Token: 0x040132E4 RID: 78564
		internal static int __PropertyOffset_46;

		// Token: 0x040132E5 RID: 78565
		internal static int __PropertyOffset_47;

		// Token: 0x040132E6 RID: 78566
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x040132E7 RID: 78567
		private static IntPtr __ChangeSky_NativeFunctionPtr;

		// Token: 0x040132E8 RID: 78568
		private static IntPtr __Special_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x040132E9 RID: 78569
		private static IntPtr __SunMoon_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x040132EA RID: 78570
		private static IntPtr __Single_POI_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x040132EB RID: 78571
		private static IntPtr __UpdatePerFourFrame_NativeFunctionPtr;

		// Token: 0x040132EC RID: 78572
		private static IntPtr __CreateDMI_NativeFunctionPtr;

		// Token: 0x040132ED RID: 78573
		private static IntPtr __Single_Cloud_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x040132EE RID: 78574
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040132EF RID: 78575
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040132F0 RID: 78576
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040132F1 RID: 78577
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040132F2 RID: 78578
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0200A0E0 RID: 41184
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031BEF RID: 203759
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x0200A0E1 RID: 41185
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __ChangeSky_FunctionParams
		{
			// Token: 0x04031BF0 RID: 203760
			[FieldOffset(0)]
			public bool IsTick;
		}

		// Token: 0x0200A0E2 RID: 41186
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __Special_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031BF1 RID: 203761
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031BF2 RID: 203762
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031BF3 RID: 203763
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031BF4 RID: 203764
			[FieldOffset(24)]
			public FRotator POIRotation;

			// Token: 0x04031BF5 RID: 203765
			[FieldOffset(36)]
			public float Intensity;

			// Token: 0x04031BF6 RID: 203766
			[FieldOffset(40)]
			public FVector Scale;

			// Token: 0x04031BF7 RID: 203767
			[FieldOffset(56)]
			public IntPtr NoiseTex;

			// Token: 0x04031BF8 RID: 203768
			[FieldOffset(64)]
			public float NoiseSpeed;

			// Token: 0x04031BF9 RID: 203769
			[FieldOffset(68)]
			public float NoiseStrength;

			// Token: 0x04031BFA RID: 203770
			[FieldOffset(72)]
			public float NoiseTilling;

			// Token: 0x04031BFB RID: 203771
			[FieldOffset(76)]
			public FLinearColor Color;
		}

		// Token: 0x0200A0E3 RID: 41187
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __SunMoon_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031BFC RID: 203772
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031BFD RID: 203773
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031BFE RID: 203774
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031BFF RID: 203775
			[FieldOffset(24)]
			public FRotator POIRotation;

			// Token: 0x04031C00 RID: 203776
			[FieldOffset(36)]
			public float Intensity;
		}

		// Token: 0x0200A0E4 RID: 41188
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __Single_POI_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C01 RID: 203777
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C02 RID: 203778
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C03 RID: 203779
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031C04 RID: 203780
			[FieldOffset(24)]
			public FRotator POIRotation;
		}

		// Token: 0x0200A0E5 RID: 41189
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateDMI_FunctionParams
		{
			// Token: 0x04031C05 RID: 203781
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031C06 RID: 203782
			[FieldOffset(8)]
			public IntPtr Material;

			// Token: 0x04031C07 RID: 203783
			[FieldOffset(16)]
			public IntPtr DMI;
		}

		// Token: 0x0200A0E6 RID: 41190
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __Single_Cloud_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C08 RID: 203784
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C09 RID: 203785
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C0A RID: 203786
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031C0B RID: 203787
			[FieldOffset(24)]
			public bool UV1UV2_;

			// Token: 0x04031C0C RID: 203788
			[FieldOffset(28)]
			public float CloudSpeed;

			// Token: 0x04031C0D RID: 203789
			[FieldOffset(32)]
			public float Top_Rotation;

			// Token: 0x04031C0E RID: 203790
			[FieldOffset(36)]
			public float UVTiling;

			// Token: 0x04031C0F RID: 203791
			[FieldOffset(40)]
			public float NoiseStrength;

			// Token: 0x04031C10 RID: 203792
			[FieldOffset(44)]
			public float NoiseSpeed;

			// Token: 0x04031C11 RID: 203793
			[FieldOffset(48)]
			public float NoiseTilling;

			// Token: 0x04031C12 RID: 203794
			[FieldOffset(56)]
			public IntPtr NoiseTex;
		}

		// Token: 0x0200A0E7 RID: 41191
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C13 RID: 203795
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0E8 RID: 41192
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C14 RID: 203796
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
