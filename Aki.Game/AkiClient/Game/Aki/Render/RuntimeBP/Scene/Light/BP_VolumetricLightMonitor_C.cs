using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B27 RID: 15143
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLightMonitor.BP_VolumetricLightMonitor_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class BP_VolumetricLightMonitor_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021570 RID: 136560 RVA: 0x008EA564 File Offset: 0x008E8764
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricLightMonitor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLightMonitor.BP_VolumetricLightMonitor_C");
			}
			return BP_VolumetricLightMonitor_C._ClassPtr;
		}

		// Token: 0x06021571 RID: 136561 RVA: 0x008EA588 File Offset: 0x008E8788
		public BP_VolumetricLightMonitor_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricLightMonitor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021572 RID: 136562 RVA: 0x008EA5B0 File Offset: 0x008E87B0
		[NullableContext(1)]
		public BP_VolumetricLightMonitor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricLightMonitor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x06021573 RID: 136563 RVA: 0x008EA5E3 File Offset: 0x008E87E3
		// (set) Token: 0x06021574 RID: 136564 RVA: 0x008EA5F7 File Offset: 0x008E87F7
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x06021575 RID: 136565 RVA: 0x008EA60C File Offset: 0x008E880C
		// (set) Token: 0x06021576 RID: 136566 RVA: 0x008EA620 File Offset: 0x008E8820
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x06021577 RID: 136567 RVA: 0x008EA635 File Offset: 0x008E8835
		// (set) Token: 0x06021578 RID: 136568 RVA: 0x008EA649 File Offset: 0x008E8849
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x06021579 RID: 136569 RVA: 0x008EA65E File Offset: 0x008E885E
		// (set) Token: 0x0602157A RID: 136570 RVA: 0x008EA672 File Offset: 0x008E8872
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0602157B RID: 136571 RVA: 0x008EA687 File Offset: 0x008E8887
		// (set) Token: 0x0602157C RID: 136572 RVA: 0x008EA69B File Offset: 0x008E889B
		public unsafe UMaterialInstance MaterialInstanceBT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0602157D RID: 136573 RVA: 0x008EA6B0 File Offset: 0x008E88B0
		// (set) Token: 0x0602157E RID: 136574 RVA: 0x008EA6C0 File Offset: 0x008E88C0
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0602157F RID: 136575 RVA: 0x008EA6D1 File Offset: 0x008E88D1
		// (set) Token: 0x06021580 RID: 136576 RVA: 0x008EA6E1 File Offset: 0x008E88E1
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x06021581 RID: 136577 RVA: 0x008EA6F2 File Offset: 0x008E88F2
		// (set) Token: 0x06021582 RID: 136578 RVA: 0x008EA702 File Offset: 0x008E8902
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x06021583 RID: 136579 RVA: 0x008EA713 File Offset: 0x008E8913
		// (set) Token: 0x06021584 RID: 136580 RVA: 0x008EA723 File Offset: 0x008E8923
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x06021585 RID: 136581 RVA: 0x008EA734 File Offset: 0x008E8934
		// (set) Token: 0x06021586 RID: 136582 RVA: 0x008EA744 File Offset: 0x008E8944
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x06021587 RID: 136583 RVA: 0x008EA755 File Offset: 0x008E8955
		// (set) Token: 0x06021588 RID: 136584 RVA: 0x008EA765 File Offset: 0x008E8965
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x06021589 RID: 136585 RVA: 0x008EA776 File Offset: 0x008E8976
		// (set) Token: 0x0602158A RID: 136586 RVA: 0x008EA786 File Offset: 0x008E8986
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0602158B RID: 136587 RVA: 0x008EA797 File Offset: 0x008E8997
		// (set) Token: 0x0602158C RID: 136588 RVA: 0x008EA7AB File Offset: 0x008E89AB
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0602158D RID: 136589 RVA: 0x008EA7C0 File Offset: 0x008E89C0
		// (set) Token: 0x0602158E RID: 136590 RVA: 0x008EA7D4 File Offset: 0x008E89D4
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0602158F RID: 136591 RVA: 0x008EA7E9 File Offset: 0x008E89E9
		// (set) Token: 0x06021590 RID: 136592 RVA: 0x008EA7F9 File Offset: 0x008E89F9
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x06021591 RID: 136593 RVA: 0x008EA80A File Offset: 0x008E8A0A
		// (set) Token: 0x06021592 RID: 136594 RVA: 0x008EA81A File Offset: 0x008E8A1A
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x06021593 RID: 136595 RVA: 0x008EA82B File Offset: 0x008E8A2B
		// (set) Token: 0x06021594 RID: 136596 RVA: 0x008EA83B File Offset: 0x008E8A3B
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x06021595 RID: 136597 RVA: 0x008EA84C File Offset: 0x008E8A4C
		// (set) Token: 0x06021596 RID: 136598 RVA: 0x008EA85C File Offset: 0x008E8A5C
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x06021597 RID: 136599 RVA: 0x008EA86D File Offset: 0x008E8A6D
		// (set) Token: 0x06021598 RID: 136600 RVA: 0x008EA87D File Offset: 0x008E8A7D
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x06021599 RID: 136601 RVA: 0x008EA88E File Offset: 0x008E8A8E
		// (set) Token: 0x0602159A RID: 136602 RVA: 0x008EA89E File Offset: 0x008E8A9E
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0602159B RID: 136603 RVA: 0x008EA8AF File Offset: 0x008E8AAF
		// (set) Token: 0x0602159C RID: 136604 RVA: 0x008EA8BF File Offset: 0x008E8ABF
		public unsafe float LightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0602159D RID: 136605 RVA: 0x008EA8D0 File Offset: 0x008E8AD0
		// (set) Token: 0x0602159E RID: 136606 RVA: 0x008EA8E0 File Offset: 0x008E8AE0
		public unsafe float NearFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0602159F RID: 136607 RVA: 0x008EA8F1 File Offset: 0x008E8AF1
		// (set) Token: 0x060215A0 RID: 136608 RVA: 0x008EA901 File Offset: 0x008E8B01
		public unsafe float FullIntLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x060215A1 RID: 136609 RVA: 0x008EA912 File Offset: 0x008E8B12
		// (set) Token: 0x060215A2 RID: 136610 RVA: 0x008EA922 File Offset: 0x008E8B22
		public unsafe float FarFadeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x060215A3 RID: 136611 RVA: 0x008EA933 File Offset: 0x008E8B33
		// (set) Token: 0x060215A4 RID: 136612 RVA: 0x008EA947 File Offset: 0x008E8B47
		public unsafe UMaterialInstanceDynamic DynamicVolumetricShaftMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x060215A5 RID: 136613 RVA: 0x008EA95C File Offset: 0x008E8B5C
		// (set) Token: 0x060215A6 RID: 136614 RVA: 0x008EA970 File Offset: 0x008E8B70
		public unsafe UMaterialInstance DecalLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x060215A7 RID: 136615 RVA: 0x008EA985 File Offset: 0x008E8B85
		// (set) Token: 0x060215A8 RID: 136616 RVA: 0x008EA995 File Offset: 0x008E8B95
		public unsafe float LightDecalZoFFSET
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x060215A9 RID: 136617 RVA: 0x008EA9A6 File Offset: 0x008E8BA6
		// (set) Token: 0x060215AA RID: 136618 RVA: 0x008EA9B6 File Offset: 0x008E8BB6
		public unsafe float DecalHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x060215AB RID: 136619 RVA: 0x008EA9C7 File Offset: 0x008E8BC7
		// (set) Token: 0x060215AC RID: 136620 RVA: 0x008EA9D7 File Offset: 0x008E8BD7
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x060215AD RID: 136621 RVA: 0x008EA9E8 File Offset: 0x008E8BE8
		// (set) Token: 0x060215AE RID: 136622 RVA: 0x008EA9F8 File Offset: 0x008E8BF8
		public unsafe float InSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x060215AF RID: 136623 RVA: 0x008EAA09 File Offset: 0x008E8C09
		// (set) Token: 0x060215B0 RID: 136624 RVA: 0x008EAA1D File Offset: 0x008E8C1D
		public unsafe FLinearColor InSideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x060215B1 RID: 136625 RVA: 0x008EAA32 File Offset: 0x008E8C32
		// (set) Token: 0x060215B2 RID: 136626 RVA: 0x008EAA42 File Offset: 0x008E8C42
		public unsafe float OutSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x060215B3 RID: 136627 RVA: 0x008EAA53 File Offset: 0x008E8C53
		// (set) Token: 0x060215B4 RID: 136628 RVA: 0x008EAA67 File Offset: 0x008E8C67
		public unsafe FLinearColor OutSideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLightMonitor_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x060215B5 RID: 136629 RVA: 0x008EAA7C File Offset: 0x008E8C7C
		// (set) Token: 0x060215B6 RID: 136630 RVA: 0x008EAA90 File Offset: 0x008E8C90
		public unsafe UMaterialInstanceDynamic DynamicDecalMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x060215B7 RID: 136631 RVA: 0x008EAAA5 File Offset: 0x008E8CA5
		// (set) Token: 0x060215B8 RID: 136632 RVA: 0x008EAAB9 File Offset: 0x008E8CB9
		public unsafe UDecalComponent decalcomponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLightMonitor_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x060215B9 RID: 136633 RVA: 0x008EAACE File Offset: 0x008E8CCE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricLightMonitor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060215BA RID: 136634 RVA: 0x008EAAE2 File Offset: 0x008E8CE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricLightMonitor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060215BB RID: 136635 RVA: 0x008EAAF8 File Offset: 0x008E8CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricLightMonitor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricLightMonitor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricLightMonitor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricLightMonitor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricLightMonitor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060215BC RID: 136636 RVA: 0x008EAB40 File Offset: 0x008E8D40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricLightMonitor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricLightMonitor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricLightMonitor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricLightMonitor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricLightMonitor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060215BD RID: 136637 RVA: 0x008EAB88 File Offset: 0x008E8D88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricLightMonitor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricLightMonitor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricLightMonitor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricLightMonitor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricLightMonitor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060215BE RID: 136638 RVA: 0x008EABD0 File Offset: 0x008E8DD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricLightMonitor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricLightMonitor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricLightMonitor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricLightMonitor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricLightMonitor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060215BF RID: 136639 RVA: 0x008EAC17 File Offset: 0x008E8E17
		protected BP_VolumetricLightMonitor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103CB RID: 66507
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLightMonitor.BP_VolumetricLightMonitor_C";

		// Token: 0x040103CC RID: 66508
		private static IntPtr _ClassPtr;

		// Token: 0x040103CD RID: 66509
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103CE RID: 66510
		internal static int __PropertyOffset_1;

		// Token: 0x040103CF RID: 66511
		internal static int __PropertyOffset_2;

		// Token: 0x040103D0 RID: 66512
		internal static int __PropertyOffset_3;

		// Token: 0x040103D1 RID: 66513
		internal static int __PropertyOffset_4;

		// Token: 0x040103D2 RID: 66514
		internal static int __PropertyOffset_5;

		// Token: 0x040103D3 RID: 66515
		internal static int __PropertyOffset_6;

		// Token: 0x040103D4 RID: 66516
		internal static int __PropertyOffset_7;

		// Token: 0x040103D5 RID: 66517
		internal static int __PropertyOffset_8;

		// Token: 0x040103D6 RID: 66518
		internal static int __PropertyOffset_9;

		// Token: 0x040103D7 RID: 66519
		internal static int __PropertyOffset_10;

		// Token: 0x040103D8 RID: 66520
		internal static int __PropertyOffset_11;

		// Token: 0x040103D9 RID: 66521
		internal static int __PropertyOffset_12;

		// Token: 0x040103DA RID: 66522
		internal static int __PropertyOffset_13;

		// Token: 0x040103DB RID: 66523
		internal static int __PropertyOffset_14;

		// Token: 0x040103DC RID: 66524
		internal static int __PropertyOffset_15;

		// Token: 0x040103DD RID: 66525
		internal static int __PropertyOffset_16;

		// Token: 0x040103DE RID: 66526
		internal static int __PropertyOffset_17;

		// Token: 0x040103DF RID: 66527
		internal static int __PropertyOffset_18;

		// Token: 0x040103E0 RID: 66528
		internal static int __PropertyOffset_19;

		// Token: 0x040103E1 RID: 66529
		internal static int __PropertyOffset_20;

		// Token: 0x040103E2 RID: 66530
		internal static int __PropertyOffset_21;

		// Token: 0x040103E3 RID: 66531
		internal static int __PropertyOffset_22;

		// Token: 0x040103E4 RID: 66532
		internal static int __PropertyOffset_23;

		// Token: 0x040103E5 RID: 66533
		internal static int __PropertyOffset_24;

		// Token: 0x040103E6 RID: 66534
		internal static int __PropertyOffset_25;

		// Token: 0x040103E7 RID: 66535
		internal static int __PropertyOffset_26;

		// Token: 0x040103E8 RID: 66536
		internal static int __PropertyOffset_27;

		// Token: 0x040103E9 RID: 66537
		internal static int __PropertyOffset_28;

		// Token: 0x040103EA RID: 66538
		internal static int __PropertyOffset_29;

		// Token: 0x040103EB RID: 66539
		internal static int __PropertyOffset_30;

		// Token: 0x040103EC RID: 66540
		internal static int __PropertyOffset_31;

		// Token: 0x040103ED RID: 66541
		internal static int __PropertyOffset_32;

		// Token: 0x040103EE RID: 66542
		internal static int __PropertyOffset_33;

		// Token: 0x040103EF RID: 66543
		internal static int __PropertyOffset_34;

		// Token: 0x040103F0 RID: 66544
		internal static int __PropertyOffset_35;

		// Token: 0x040103F1 RID: 66545
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040103F2 RID: 66546
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040103F3 RID: 66547
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C89 RID: 40073
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031347 RID: 201543
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C8A RID: 40074
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031348 RID: 201544
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
