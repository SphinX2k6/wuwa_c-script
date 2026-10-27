using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.CarPaint.BluePrints
{
	// Token: 0x02003CCA RID: 15562
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarOpenDoor.BP_CarOpenDoor_C")]
	[UnrealStructLayout(1936, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1928)]
	public class BP_CarOpenDoor_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024D18 RID: 150808 RVA: 0x00949246 File Offset: 0x00947446
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CarOpenDoor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarOpenDoor.BP_CarOpenDoor_C");
			}
			return BP_CarOpenDoor_C._ClassPtr;
		}

		// Token: 0x06024D19 RID: 150809 RVA: 0x0094926C File Offset: 0x0094746C
		public BP_CarOpenDoor_C() : this(BuiltinUtils.AllocNativeUObject(BP_CarOpenDoor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024D1A RID: 150810 RVA: 0x00949294 File Offset: 0x00947494
		[NullableContext(1)]
		public BP_CarOpenDoor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CarOpenDoor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x06024D1B RID: 150811 RVA: 0x009492C7 File Offset: 0x009474C7
		// (set) Token: 0x06024D1C RID: 150812 RVA: 0x009492DB File Offset: 0x009474DB
		public unsafe UBoxComponent BoxTrigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x06024D1D RID: 150813 RVA: 0x009492F0 File Offset: 0x009474F0
		// (set) Token: 0x06024D1E RID: 150814 RVA: 0x00949304 File Offset: 0x00947504
		public unsafe UStaticMeshComponent SM_Cyb_Car_01GM1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x06024D1F RID: 150815 RVA: 0x00949319 File Offset: 0x00947519
		// (set) Token: 0x06024D20 RID: 150816 RVA: 0x0094932D File Offset: 0x0094752D
		public unsafe UStaticMeshComponent SM_Cyb_Car_01GM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x06024D21 RID: 150817 RVA: 0x00949342 File Offset: 0x00947542
		// (set) Token: 0x06024D22 RID: 150818 RVA: 0x00949356 File Offset: 0x00947556
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x06024D23 RID: 150819 RVA: 0x0094936B File Offset: 0x0094756B
		// (set) Token: 0x06024D24 RID: 150820 RVA: 0x0094937B File Offset: 0x0094757B
		public unsafe float Timeline_7_NewTrack_0_F4056B3E4301EE392C91AFB153752861
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004947 RID: 18759
		// (get) Token: 0x06024D25 RID: 150821 RVA: 0x0094938C File Offset: 0x0094758C
		// (set) Token: 0x06024D26 RID: 150822 RVA: 0x009493A0 File Offset: 0x009475A0
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_7__Direction_F4056B3E4301EE392C91AFB153752861
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004948 RID: 18760
		// (get) Token: 0x06024D27 RID: 150823 RVA: 0x009493B5 File Offset: 0x009475B5
		// (set) Token: 0x06024D28 RID: 150824 RVA: 0x009493C9 File Offset: 0x009475C9
		public unsafe UTimelineComponent Timeline_7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004949 RID: 18761
		// (get) Token: 0x06024D29 RID: 150825 RVA: 0x009493DE File Offset: 0x009475DE
		// (set) Token: 0x06024D2A RID: 150826 RVA: 0x009493EE File Offset: 0x009475EE
		public unsafe float Timeline_6_NewTrack_0_A57150204F6656C36D403FAB7B19B78D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700494A RID: 18762
		// (get) Token: 0x06024D2B RID: 150827 RVA: 0x009493FF File Offset: 0x009475FF
		// (set) Token: 0x06024D2C RID: 150828 RVA: 0x00949413 File Offset: 0x00947613
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_6__Direction_A57150204F6656C36D403FAB7B19B78D
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_9);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700494B RID: 18763
		// (get) Token: 0x06024D2D RID: 150829 RVA: 0x00949428 File Offset: 0x00947628
		// (set) Token: 0x06024D2E RID: 150830 RVA: 0x0094943C File Offset: 0x0094763C
		public unsafe UTimelineComponent Timeline_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700494C RID: 18764
		// (get) Token: 0x06024D2F RID: 150831 RVA: 0x00949451 File Offset: 0x00947651
		// (set) Token: 0x06024D30 RID: 150832 RVA: 0x00949461 File Offset: 0x00947661
		public unsafe float Timeline_3_NewTrack_0_BB403BFA400E5ED28E1FA39630A859EC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700494D RID: 18765
		// (get) Token: 0x06024D31 RID: 150833 RVA: 0x00949472 File Offset: 0x00947672
		// (set) Token: 0x06024D32 RID: 150834 RVA: 0x00949486 File Offset: 0x00947686
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_3__Direction_BB403BFA400E5ED28E1FA39630A859EC
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_12);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700494E RID: 18766
		// (get) Token: 0x06024D33 RID: 150835 RVA: 0x0094949B File Offset: 0x0094769B
		// (set) Token: 0x06024D34 RID: 150836 RVA: 0x009494AF File Offset: 0x009476AF
		public unsafe UTimelineComponent Timeline_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700494F RID: 18767
		// (get) Token: 0x06024D35 RID: 150837 RVA: 0x009494C4 File Offset: 0x009476C4
		// (set) Token: 0x06024D36 RID: 150838 RVA: 0x009494D4 File Offset: 0x009476D4
		public unsafe float Timeline_2_NewTrack_0_D264918943903987D00F289189FE3468
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x06024D37 RID: 150839 RVA: 0x009494E5 File Offset: 0x009476E5
		// (set) Token: 0x06024D38 RID: 150840 RVA: 0x009494F9 File Offset: 0x009476F9
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_2__Direction_D264918943903987D00F289189FE3468
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x06024D39 RID: 150841 RVA: 0x0094950E File Offset: 0x0094770E
		// (set) Token: 0x06024D3A RID: 150842 RVA: 0x00949522 File Offset: 0x00947722
		public unsafe UTimelineComponent Timeline_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x06024D3B RID: 150843 RVA: 0x00949537 File Offset: 0x00947737
		// (set) Token: 0x06024D3C RID: 150844 RVA: 0x00949547 File Offset: 0x00947747
		public unsafe float Timeline_5_NewTrack_0_9976DCE14A7B78504561969515E1A371
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x06024D3D RID: 150845 RVA: 0x00949558 File Offset: 0x00947758
		// (set) Token: 0x06024D3E RID: 150846 RVA: 0x0094956C File Offset: 0x0094776C
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_5__Direction_9976DCE14A7B78504561969515E1A371
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_18);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x06024D3F RID: 150847 RVA: 0x00949581 File Offset: 0x00947781
		// (set) Token: 0x06024D40 RID: 150848 RVA: 0x00949595 File Offset: 0x00947795
		public unsafe UTimelineComponent Timeline_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004955 RID: 18773
		// (get) Token: 0x06024D41 RID: 150849 RVA: 0x009495AA File Offset: 0x009477AA
		// (set) Token: 0x06024D42 RID: 150850 RVA: 0x009495BA File Offset: 0x009477BA
		public unsafe float Timeline_1_NewTrack_0_284631E04DD31FBE074F85B56DA633C5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004956 RID: 18774
		// (get) Token: 0x06024D43 RID: 150851 RVA: 0x009495CB File Offset: 0x009477CB
		// (set) Token: 0x06024D44 RID: 150852 RVA: 0x009495DF File Offset: 0x009477DF
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_1__Direction_284631E04DD31FBE074F85B56DA633C5
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_21);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004957 RID: 18775
		// (get) Token: 0x06024D45 RID: 150853 RVA: 0x009495F4 File Offset: 0x009477F4
		// (set) Token: 0x06024D46 RID: 150854 RVA: 0x00949608 File Offset: 0x00947808
		public unsafe UTimelineComponent Timeline_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17004958 RID: 18776
		// (get) Token: 0x06024D47 RID: 150855 RVA: 0x0094961D File Offset: 0x0094781D
		// (set) Token: 0x06024D48 RID: 150856 RVA: 0x0094962D File Offset: 0x0094782D
		public unsafe float Timeline_4_NewTrack_0_8AB12E704B35847EE58200AEC43A5F02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x06024D49 RID: 150857 RVA: 0x0094963E File Offset: 0x0094783E
		// (set) Token: 0x06024D4A RID: 150858 RVA: 0x00949652 File Offset: 0x00947852
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_4__Direction_8AB12E704B35847EE58200AEC43A5F02
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_24);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x06024D4B RID: 150859 RVA: 0x00949667 File Offset: 0x00947867
		// (set) Token: 0x06024D4C RID: 150860 RVA: 0x0094967B File Offset: 0x0094787B
		public unsafe UTimelineComponent Timeline_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x06024D4D RID: 150861 RVA: 0x00949690 File Offset: 0x00947890
		// (set) Token: 0x06024D4E RID: 150862 RVA: 0x009496A0 File Offset: 0x009478A0
		public unsafe float Timeline_0_NewTrack_0_A3641E244AB652293D0D3A8D2BE1FD52
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x06024D4F RID: 150863 RVA: 0x009496B1 File Offset: 0x009478B1
		// (set) Token: 0x06024D50 RID: 150864 RVA: 0x009496C5 File Offset: 0x009478C5
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_A3641E244AB652293D0D3A8D2BE1FD52
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_27);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x06024D51 RID: 150865 RVA: 0x009496DA File Offset: 0x009478DA
		// (set) Token: 0x06024D52 RID: 150866 RVA: 0x009496EE File Offset: 0x009478EE
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x06024D53 RID: 150867 RVA: 0x00949703 File Offset: 0x00947903
		// (set) Token: 0x06024D54 RID: 150868 RVA: 0x00949717 File Offset: 0x00947917
		public unsafe FTransform LeftTrans1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x06024D55 RID: 150869 RVA: 0x0094972C File Offset: 0x0094792C
		// (set) Token: 0x06024D56 RID: 150870 RVA: 0x00949740 File Offset: 0x00947940
		public unsafe FTransform LeftTrans2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x06024D57 RID: 150871 RVA: 0x00949755 File Offset: 0x00947955
		// (set) Token: 0x06024D58 RID: 150872 RVA: 0x00949769 File Offset: 0x00947969
		public unsafe FTransform LeftTrans3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x06024D59 RID: 150873 RVA: 0x0094977E File Offset: 0x0094797E
		// (set) Token: 0x06024D5A RID: 150874 RVA: 0x00949792 File Offset: 0x00947992
		public unsafe FTransform RightTrans1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x06024D5B RID: 150875 RVA: 0x009497A7 File Offset: 0x009479A7
		// (set) Token: 0x06024D5C RID: 150876 RVA: 0x009497BB File Offset: 0x009479BB
		public unsafe FTransform RightTrans2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x06024D5D RID: 150877 RVA: 0x009497D0 File Offset: 0x009479D0
		// (set) Token: 0x06024D5E RID: 150878 RVA: 0x009497E4 File Offset: 0x009479E4
		public unsafe FTransform RightTrans3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x06024D5F RID: 150879 RVA: 0x009497F9 File Offset: 0x009479F9
		// (set) Token: 0x06024D60 RID: 150880 RVA: 0x00949809 File Offset: 0x00947A09
		public unsafe bool bIsTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x06024D61 RID: 150881 RVA: 0x0094981A File Offset: 0x00947A1A
		// (set) Token: 0x06024D62 RID: 150882 RVA: 0x0094982A File Offset: 0x00947A2A
		public unsafe bool bIsOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarOpenDoor_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x06024D63 RID: 150883 RVA: 0x0094983B File Offset: 0x00947A3B
		// (set) Token: 0x06024D64 RID: 150884 RVA: 0x0094984F File Offset: 0x00947A4F
		public unsafe UAkAudioEvent CloseDoorSound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x06024D65 RID: 150885 RVA: 0x00949864 File Offset: 0x00947A64
		// (set) Token: 0x06024D66 RID: 150886 RVA: 0x00949878 File Offset: 0x00947A78
		public unsafe UAkAudioEvent OpenDoorSound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarOpenDoor_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x06024D67 RID: 150887 RVA: 0x0094988D File Offset: 0x00947A8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D68 RID: 150888 RVA: 0x009498A1 File Offset: 0x00947AA1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D69 RID: 150889 RVA: 0x009498B5 File Offset: 0x00947AB5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_4__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_4__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D6A RID: 150890 RVA: 0x009498C9 File Offset: 0x00947AC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_4__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_4__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D6B RID: 150891 RVA: 0x009498DD File Offset: 0x00947ADD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_1__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_1__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D6C RID: 150892 RVA: 0x009498F1 File Offset: 0x00947AF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_1__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_1__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D6D RID: 150893 RVA: 0x00949905 File Offset: 0x00947B05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_5__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_5__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D6E RID: 150894 RVA: 0x00949919 File Offset: 0x00947B19
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_5__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_5__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D6F RID: 150895 RVA: 0x0094992D File Offset: 0x00947B2D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_2__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_2__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D70 RID: 150896 RVA: 0x00949941 File Offset: 0x00947B41
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_2__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_2__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D71 RID: 150897 RVA: 0x00949955 File Offset: 0x00947B55
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_3__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_3__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D72 RID: 150898 RVA: 0x00949969 File Offset: 0x00947B69
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_3__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_3__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D73 RID: 150899 RVA: 0x0094997D File Offset: 0x00947B7D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_6__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_6__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D74 RID: 150900 RVA: 0x00949991 File Offset: 0x00947B91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_6__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_6__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D75 RID: 150901 RVA: 0x009499A5 File Offset: 0x00947BA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_7__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_7__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D76 RID: 150902 RVA: 0x009499B9 File Offset: 0x00947BB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_7__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Timeline_7__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06024D77 RID: 150903 RVA: 0x009499D0 File Offset: 0x00947BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_53A13A9545B3414C4D4E72B710224B40(int PlayingID)
		{
			BP_CarOpenDoor_C.__Completed_53A13A9545B3414C4D4E72B710224B40_FunctionParams* ptr = stackalloc BP_CarOpenDoor_C.__Completed_53A13A9545B3414C4D4E72B710224B40_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarOpenDoor_C.__Completed_53A13A9545B3414C4D4E72B710224B40_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarOpenDoor_C.__Completed_53A13A9545B3414C4D4E72B710224B40_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Completed_53A13A9545B3414C4D4E72B710224B40_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024D78 RID: 150904 RVA: 0x00949A18 File Offset: 0x00947C18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_5553A0C94D655F5940A628A1D52F7D2F(int PlayingID)
		{
			BP_CarOpenDoor_C.__Completed_5553A0C94D655F5940A628A1D52F7D2F_FunctionParams* ptr = stackalloc BP_CarOpenDoor_C.__Completed_5553A0C94D655F5940A628A1D52F7D2F_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarOpenDoor_C.__Completed_5553A0C94D655F5940A628A1D52F7D2F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarOpenDoor_C.__Completed_5553A0C94D655F5940A628A1D52F7D2F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__Completed_5553A0C94D655F5940A628A1D52F7D2F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024D79 RID: 150905 RVA: 0x00949A60 File Offset: 0x00947C60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CarOpenDoor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CarOpenDoor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarOpenDoor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarOpenDoor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024D7A RID: 150906 RVA: 0x00949AA8 File Offset: 0x00947CA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CarOpenDoor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CarOpenDoor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarOpenDoor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarOpenDoor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarOpenDoor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024D7B RID: 150907 RVA: 0x00949AF0 File Offset: 0x00947CF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_CarOpenDoor_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CarOpenDoor_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_CarOpenDoor_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarOpenDoor_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024D7C RID: 150908 RVA: 0x00949BAC File Offset: 0x00947DAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_CarOpenDoor_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CarOpenDoor_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CarOpenDoor_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarOpenDoor_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024D7D RID: 150909 RVA: 0x00949C35 File Offset: 0x00947E35
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ChangeDoor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarOpenDoor_C.__ChangeDoor_NativeFunctionPtr, null);
		}

		// Token: 0x06024D7E RID: 150910 RVA: 0x00949C49 File Offset: 0x00947E49
		protected BP_CarOpenDoor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124C4 RID: 74948
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarOpenDoor.BP_CarOpenDoor_C";

		// Token: 0x040124C5 RID: 74949
		private static IntPtr _ClassPtr;

		// Token: 0x040124C6 RID: 74950
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124C7 RID: 74951
		internal static int __PropertyOffset_1;

		// Token: 0x040124C8 RID: 74952
		internal static int __PropertyOffset_2;

		// Token: 0x040124C9 RID: 74953
		internal static int __PropertyOffset_3;

		// Token: 0x040124CA RID: 74954
		internal static int __PropertyOffset_4;

		// Token: 0x040124CB RID: 74955
		internal static int __PropertyOffset_5;

		// Token: 0x040124CC RID: 74956
		internal static int __PropertyOffset_6;

		// Token: 0x040124CD RID: 74957
		internal static int __PropertyOffset_7;

		// Token: 0x040124CE RID: 74958
		internal static int __PropertyOffset_8;

		// Token: 0x040124CF RID: 74959
		internal static int __PropertyOffset_9;

		// Token: 0x040124D0 RID: 74960
		internal static int __PropertyOffset_10;

		// Token: 0x040124D1 RID: 74961
		internal static int __PropertyOffset_11;

		// Token: 0x040124D2 RID: 74962
		internal static int __PropertyOffset_12;

		// Token: 0x040124D3 RID: 74963
		internal static int __PropertyOffset_13;

		// Token: 0x040124D4 RID: 74964
		internal static int __PropertyOffset_14;

		// Token: 0x040124D5 RID: 74965
		internal static int __PropertyOffset_15;

		// Token: 0x040124D6 RID: 74966
		internal static int __PropertyOffset_16;

		// Token: 0x040124D7 RID: 74967
		internal static int __PropertyOffset_17;

		// Token: 0x040124D8 RID: 74968
		internal static int __PropertyOffset_18;

		// Token: 0x040124D9 RID: 74969
		internal static int __PropertyOffset_19;

		// Token: 0x040124DA RID: 74970
		internal static int __PropertyOffset_20;

		// Token: 0x040124DB RID: 74971
		internal static int __PropertyOffset_21;

		// Token: 0x040124DC RID: 74972
		internal static int __PropertyOffset_22;

		// Token: 0x040124DD RID: 74973
		internal static int __PropertyOffset_23;

		// Token: 0x040124DE RID: 74974
		internal static int __PropertyOffset_24;

		// Token: 0x040124DF RID: 74975
		internal static int __PropertyOffset_25;

		// Token: 0x040124E0 RID: 74976
		internal static int __PropertyOffset_26;

		// Token: 0x040124E1 RID: 74977
		internal static int __PropertyOffset_27;

		// Token: 0x040124E2 RID: 74978
		internal static int __PropertyOffset_28;

		// Token: 0x040124E3 RID: 74979
		internal static int __PropertyOffset_29;

		// Token: 0x040124E4 RID: 74980
		internal static int __PropertyOffset_30;

		// Token: 0x040124E5 RID: 74981
		internal static int __PropertyOffset_31;

		// Token: 0x040124E6 RID: 74982
		internal static int __PropertyOffset_32;

		// Token: 0x040124E7 RID: 74983
		internal static int __PropertyOffset_33;

		// Token: 0x040124E8 RID: 74984
		internal static int __PropertyOffset_34;

		// Token: 0x040124E9 RID: 74985
		internal static int __PropertyOffset_35;

		// Token: 0x040124EA RID: 74986
		internal static int __PropertyOffset_36;

		// Token: 0x040124EB RID: 74987
		internal static int __PropertyOffset_37;

		// Token: 0x040124EC RID: 74988
		internal static int __PropertyOffset_38;

		// Token: 0x040124ED RID: 74989
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124EE RID: 74990
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124EF RID: 74991
		private static IntPtr __Timeline_4__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124F0 RID: 74992
		private static IntPtr __Timeline_4__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124F1 RID: 74993
		private static IntPtr __Timeline_1__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124F2 RID: 74994
		private static IntPtr __Timeline_1__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124F3 RID: 74995
		private static IntPtr __Timeline_5__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124F4 RID: 74996
		private static IntPtr __Timeline_5__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124F5 RID: 74997
		private static IntPtr __Timeline_2__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124F6 RID: 74998
		private static IntPtr __Timeline_2__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124F7 RID: 74999
		private static IntPtr __Timeline_3__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124F8 RID: 75000
		private static IntPtr __Timeline_3__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124F9 RID: 75001
		private static IntPtr __Timeline_6__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124FA RID: 75002
		private static IntPtr __Timeline_6__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124FB RID: 75003
		private static IntPtr __Timeline_7__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040124FC RID: 75004
		private static IntPtr __Timeline_7__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040124FD RID: 75005
		private static IntPtr __Completed_53A13A9545B3414C4D4E72B710224B40_NativeFunctionPtr;

		// Token: 0x040124FE RID: 75006
		private static IntPtr __Completed_5553A0C94D655F5940A628A1D52F7D2F_NativeFunctionPtr;

		// Token: 0x040124FF RID: 75007
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012500 RID: 75008
		private static IntPtr __BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012501 RID: 75009
		private static IntPtr __BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012502 RID: 75010
		private static IntPtr __ChangeDoor_NativeFunctionPtr;

		// Token: 0x02009F71 RID: 40817
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_53A13A9545B3414C4D4E72B710224B40_FunctionParams
		{
			// Token: 0x04031970 RID: 203120
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009F72 RID: 40818
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_5553A0C94D655F5940A628A1D52F7D2F_FunctionParams
		{
			// Token: 0x04031971 RID: 203121
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009F73 RID: 40819
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031972 RID: 203122
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F74 RID: 40820
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031973 RID: 203123
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031974 RID: 203124
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031975 RID: 203125
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031976 RID: 203126
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031977 RID: 203127
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031978 RID: 203128
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F75 RID: 40821
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031979 RID: 203129
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403197A RID: 203130
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403197B RID: 203131
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403197C RID: 203132
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
