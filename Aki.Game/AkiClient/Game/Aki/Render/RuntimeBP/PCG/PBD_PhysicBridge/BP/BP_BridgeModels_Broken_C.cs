using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C40 RID: 15424
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_Broken.BP_BridgeModels_Broken_C")]
	[UnrealStructLayout(1856, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1856)]
	public class BP_BridgeModels_Broken_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023929 RID: 145705 RVA: 0x00927332 File Offset: 0x00925532
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BridgeModels_Broken_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_Broken.BP_BridgeModels_Broken_C");
			}
			return BP_BridgeModels_Broken_C._ClassPtr;
		}

		// Token: 0x0602392A RID: 145706 RVA: 0x00927358 File Offset: 0x00925558
		public BP_BridgeModels_Broken_C() : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_Broken_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602392B RID: 145707 RVA: 0x00927380 File Offset: 0x00925580
		[NullableContext(1)]
		public BP_BridgeModels_Broken_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_Broken_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x0602392C RID: 145708 RVA: 0x009273B3 File Offset: 0x009255B3
		// (set) Token: 0x0602392D RID: 145709 RVA: 0x009273C7 File Offset: 0x009255C7
		public unsafe UStaticMeshComponent Cube8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x0602392E RID: 145710 RVA: 0x009273DC File Offset: 0x009255DC
		// (set) Token: 0x0602392F RID: 145711 RVA: 0x009273F0 File Offset: 0x009255F0
		public unsafe UStaticMeshComponent Cube7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x06023930 RID: 145712 RVA: 0x00927405 File Offset: 0x00925605
		// (set) Token: 0x06023931 RID: 145713 RVA: 0x00927419 File Offset: 0x00925619
		public unsafe UChildActorComponent _15_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x06023932 RID: 145714 RVA: 0x0092742E File Offset: 0x0092562E
		// (set) Token: 0x06023933 RID: 145715 RVA: 0x00927442 File Offset: 0x00925642
		public unsafe UStaticMeshComponent Cube3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x06023934 RID: 145716 RVA: 0x00927457 File Offset: 0x00925657
		// (set) Token: 0x06023935 RID: 145717 RVA: 0x0092746B File Offset: 0x0092566B
		public unsafe UStaticMeshComponent Cube2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x06023936 RID: 145718 RVA: 0x00927480 File Offset: 0x00925680
		// (set) Token: 0x06023937 RID: 145719 RVA: 0x00927494 File Offset: 0x00925694
		public unsafe UChildActorComponent _15_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x06023938 RID: 145720 RVA: 0x009274A9 File Offset: 0x009256A9
		// (set) Token: 0x06023939 RID: 145721 RVA: 0x009274BD File Offset: 0x009256BD
		public unsafe UChildActorComponent _15_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x0602393A RID: 145722 RVA: 0x009274D2 File Offset: 0x009256D2
		// (set) Token: 0x0602393B RID: 145723 RVA: 0x009274E6 File Offset: 0x009256E6
		public unsafe UChildActorComponent _15_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x0602393C RID: 145724 RVA: 0x009274FB File Offset: 0x009256FB
		// (set) Token: 0x0602393D RID: 145725 RVA: 0x0092750F File Offset: 0x0092570F
		public unsafe UChildActorComponent _24_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x0602393E RID: 145726 RVA: 0x00927524 File Offset: 0x00925724
		// (set) Token: 0x0602393F RID: 145727 RVA: 0x00927538 File Offset: 0x00925738
		public unsafe UChildActorComponent _24_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x06023940 RID: 145728 RVA: 0x0092754D File Offset: 0x0092574D
		// (set) Token: 0x06023941 RID: 145729 RVA: 0x00927561 File Offset: 0x00925761
		public unsafe UChildActorComponent _24_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x06023942 RID: 145730 RVA: 0x00927576 File Offset: 0x00925776
		// (set) Token: 0x06023943 RID: 145731 RVA: 0x0092758A File Offset: 0x0092578A
		public unsafe UChildActorComponent _24_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x06023944 RID: 145732 RVA: 0x0092759F File Offset: 0x0092579F
		// (set) Token: 0x06023945 RID: 145733 RVA: 0x009275B3 File Offset: 0x009257B3
		public unsafe UStaticMeshComponent Cube6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x06023946 RID: 145734 RVA: 0x009275C8 File Offset: 0x009257C8
		// (set) Token: 0x06023947 RID: 145735 RVA: 0x009275DC File Offset: 0x009257DC
		public unsafe UStaticMeshComponent Cube5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x06023948 RID: 145736 RVA: 0x009275F1 File Offset: 0x009257F1
		// (set) Token: 0x06023949 RID: 145737 RVA: 0x00927605 File Offset: 0x00925805
		public unsafe UChildActorComponent _50_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x0602394A RID: 145738 RVA: 0x0092761A File Offset: 0x0092581A
		// (set) Token: 0x0602394B RID: 145739 RVA: 0x0092762E File Offset: 0x0092582E
		public unsafe UChildActorComponent _50_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x0602394C RID: 145740 RVA: 0x00927643 File Offset: 0x00925843
		// (set) Token: 0x0602394D RID: 145741 RVA: 0x00927657 File Offset: 0x00925857
		public unsafe UStaticMeshComponent Cube10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x0602394E RID: 145742 RVA: 0x0092766C File Offset: 0x0092586C
		// (set) Token: 0x0602394F RID: 145743 RVA: 0x00927680 File Offset: 0x00925880
		public unsafe UStaticMeshComponent Cube9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x06023950 RID: 145744 RVA: 0x00927695 File Offset: 0x00925895
		// (set) Token: 0x06023951 RID: 145745 RVA: 0x009276A9 File Offset: 0x009258A9
		public unsafe UChildActorComponent _50_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x06023952 RID: 145746 RVA: 0x009276BE File Offset: 0x009258BE
		// (set) Token: 0x06023953 RID: 145747 RVA: 0x009276D2 File Offset: 0x009258D2
		public unsafe UChildActorComponent _50_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x06023954 RID: 145748 RVA: 0x009276E7 File Offset: 0x009258E7
		// (set) Token: 0x06023955 RID: 145749 RVA: 0x009276FB File Offset: 0x009258FB
		public unsafe UChildActorComponent _10_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x06023956 RID: 145750 RVA: 0x00927710 File Offset: 0x00925910
		// (set) Token: 0x06023957 RID: 145751 RVA: 0x00927724 File Offset: 0x00925924
		public unsafe UChildActorComponent _10_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x06023958 RID: 145752 RVA: 0x00927739 File Offset: 0x00925939
		// (set) Token: 0x06023959 RID: 145753 RVA: 0x0092774D File Offset: 0x0092594D
		public unsafe UStaticMeshComponent Cube1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x0602395A RID: 145754 RVA: 0x00927762 File Offset: 0x00925962
		// (set) Token: 0x0602395B RID: 145755 RVA: 0x00927776 File Offset: 0x00925976
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x0602395C RID: 145756 RVA: 0x0092778B File Offset: 0x0092598B
		// (set) Token: 0x0602395D RID: 145757 RVA: 0x0092779F File Offset: 0x0092599F
		public unsafe UChildActorComponent _10_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x0602395E RID: 145758 RVA: 0x009277B4 File Offset: 0x009259B4
		// (set) Token: 0x0602395F RID: 145759 RVA: 0x009277C8 File Offset: 0x009259C8
		public unsafe UChildActorComponent _10_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x06023960 RID: 145760 RVA: 0x009277DD File Offset: 0x009259DD
		// (set) Token: 0x06023961 RID: 145761 RVA: 0x009277F1 File Offset: 0x009259F1
		public unsafe UChildActorComponent _60_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x06023962 RID: 145762 RVA: 0x00927806 File Offset: 0x00925A06
		// (set) Token: 0x06023963 RID: 145763 RVA: 0x0092781A File Offset: 0x00925A1A
		public unsafe UChildActorComponent _60_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x06023964 RID: 145764 RVA: 0x0092782F File Offset: 0x00925A2F
		// (set) Token: 0x06023965 RID: 145765 RVA: 0x00927843 File Offset: 0x00925A43
		public unsafe UChildActorComponent _60_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x06023966 RID: 145766 RVA: 0x00927858 File Offset: 0x00925A58
		// (set) Token: 0x06023967 RID: 145767 RVA: 0x0092786C File Offset: 0x00925A6C
		public unsafe UChildActorComponent _60_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x06023968 RID: 145768 RVA: 0x00927881 File Offset: 0x00925A81
		// (set) Token: 0x06023969 RID: 145769 RVA: 0x00927895 File Offset: 0x00925A95
		public unsafe UChildActorComponent _00_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x0602396A RID: 145770 RVA: 0x009278AA File Offset: 0x00925AAA
		// (set) Token: 0x0602396B RID: 145771 RVA: 0x009278BE File Offset: 0x00925ABE
		public unsafe UChildActorComponent _00_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x0602396C RID: 145772 RVA: 0x009278D3 File Offset: 0x00925AD3
		// (set) Token: 0x0602396D RID: 145773 RVA: 0x009278E7 File Offset: 0x00925AE7
		public unsafe UChildActorComponent _00_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x0602396E RID: 145774 RVA: 0x009278FC File Offset: 0x00925AFC
		// (set) Token: 0x0602396F RID: 145775 RVA: 0x00927910 File Offset: 0x00925B10
		public unsafe UChildActorComponent _00_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x06023970 RID: 145776 RVA: 0x00927925 File Offset: 0x00925B25
		// (set) Token: 0x06023971 RID: 145777 RVA: 0x00927939 File Offset: 0x00925B39
		public unsafe UStaticMeshComponent StaticMesh00
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x06023972 RID: 145778 RVA: 0x0092794E File Offset: 0x00925B4E
		// (set) Token: 0x06023973 RID: 145779 RVA: 0x00927962 File Offset: 0x00925B62
		public unsafe UStaticMeshComponent SM_Gel_Bri_04IL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x06023974 RID: 145780 RVA: 0x00927977 File Offset: 0x00925B77
		// (set) Token: 0x06023975 RID: 145781 RVA: 0x0092798B File Offset: 0x00925B8B
		public unsafe UStaticMeshComponent StaticMesh57
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x06023976 RID: 145782 RVA: 0x009279A0 File Offset: 0x00925BA0
		// (set) Token: 0x06023977 RID: 145783 RVA: 0x009279B4 File Offset: 0x00925BB4
		public unsafe UStaticMeshComponent StaticMesh56
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x06023978 RID: 145784 RVA: 0x009279C9 File Offset: 0x00925BC9
		// (set) Token: 0x06023979 RID: 145785 RVA: 0x009279DD File Offset: 0x00925BDD
		public unsafe UStaticMeshComponent StaticMesh55
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x0602397A RID: 145786 RVA: 0x009279F2 File Offset: 0x00925BF2
		// (set) Token: 0x0602397B RID: 145787 RVA: 0x00927A06 File Offset: 0x00925C06
		public unsafe UStaticMeshComponent StaticMesh54
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x0602397C RID: 145788 RVA: 0x00927A1B File Offset: 0x00925C1B
		// (set) Token: 0x0602397D RID: 145789 RVA: 0x00927A2F File Offset: 0x00925C2F
		public unsafe UStaticMeshComponent StaticMesh53
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x0602397E RID: 145790 RVA: 0x00927A44 File Offset: 0x00925C44
		// (set) Token: 0x0602397F RID: 145791 RVA: 0x00927A58 File Offset: 0x00925C58
		public unsafe UStaticMeshComponent StaticMesh52
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x06023980 RID: 145792 RVA: 0x00927A6D File Offset: 0x00925C6D
		// (set) Token: 0x06023981 RID: 145793 RVA: 0x00927A81 File Offset: 0x00925C81
		public unsafe UStaticMeshComponent StaticMesh51
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x06023982 RID: 145794 RVA: 0x00927A96 File Offset: 0x00925C96
		// (set) Token: 0x06023983 RID: 145795 RVA: 0x00927AAA File Offset: 0x00925CAA
		public unsafe UStaticMeshComponent StaticMesh50
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x06023984 RID: 145796 RVA: 0x00927ABF File Offset: 0x00925CBF
		// (set) Token: 0x06023985 RID: 145797 RVA: 0x00927AD3 File Offset: 0x00925CD3
		public unsafe UStaticMeshComponent StaticMesh49
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x06023986 RID: 145798 RVA: 0x00927AE8 File Offset: 0x00925CE8
		// (set) Token: 0x06023987 RID: 145799 RVA: 0x00927AFC File Offset: 0x00925CFC
		public unsafe UStaticMeshComponent StaticMesh48
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x06023988 RID: 145800 RVA: 0x00927B11 File Offset: 0x00925D11
		// (set) Token: 0x06023989 RID: 145801 RVA: 0x00927B25 File Offset: 0x00925D25
		public unsafe UStaticMeshComponent StaticMesh47
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x0602398A RID: 145802 RVA: 0x00927B3A File Offset: 0x00925D3A
		// (set) Token: 0x0602398B RID: 145803 RVA: 0x00927B4E File Offset: 0x00925D4E
		public unsafe UStaticMeshComponent StaticMesh46
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x0602398C RID: 145804 RVA: 0x00927B63 File Offset: 0x00925D63
		// (set) Token: 0x0602398D RID: 145805 RVA: 0x00927B77 File Offset: 0x00925D77
		public unsafe UStaticMeshComponent StaticMesh45
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x0602398E RID: 145806 RVA: 0x00927B8C File Offset: 0x00925D8C
		// (set) Token: 0x0602398F RID: 145807 RVA: 0x00927BA0 File Offset: 0x00925DA0
		public unsafe UStaticMeshComponent StaticMesh44
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x06023990 RID: 145808 RVA: 0x00927BB5 File Offset: 0x00925DB5
		// (set) Token: 0x06023991 RID: 145809 RVA: 0x00927BC9 File Offset: 0x00925DC9
		public unsafe UStaticMeshComponent StaticMesh43
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_51);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_51, value);
			}
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x06023992 RID: 145810 RVA: 0x00927BDE File Offset: 0x00925DDE
		// (set) Token: 0x06023993 RID: 145811 RVA: 0x00927BF2 File Offset: 0x00925DF2
		public unsafe UStaticMeshComponent StaticMesh42
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_52);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x06023994 RID: 145812 RVA: 0x00927C07 File Offset: 0x00925E07
		// (set) Token: 0x06023995 RID: 145813 RVA: 0x00927C1B File Offset: 0x00925E1B
		public unsafe UStaticMeshComponent StaticMesh41
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_53);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_53, value);
			}
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x06023996 RID: 145814 RVA: 0x00927C30 File Offset: 0x00925E30
		// (set) Token: 0x06023997 RID: 145815 RVA: 0x00927C44 File Offset: 0x00925E44
		public unsafe UStaticMeshComponent StaticMesh40
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x06023998 RID: 145816 RVA: 0x00927C59 File Offset: 0x00925E59
		// (set) Token: 0x06023999 RID: 145817 RVA: 0x00927C6D File Offset: 0x00925E6D
		public unsafe UStaticMeshComponent StaticMesh39
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_55);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x0602399A RID: 145818 RVA: 0x00927C82 File Offset: 0x00925E82
		// (set) Token: 0x0602399B RID: 145819 RVA: 0x00927C96 File Offset: 0x00925E96
		public unsafe UStaticMeshComponent StaticMesh38
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x0602399C RID: 145820 RVA: 0x00927CAB File Offset: 0x00925EAB
		// (set) Token: 0x0602399D RID: 145821 RVA: 0x00927CBF File Offset: 0x00925EBF
		public unsafe UStaticMeshComponent StaticMesh37
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x0602399E RID: 145822 RVA: 0x00927CD4 File Offset: 0x00925ED4
		// (set) Token: 0x0602399F RID: 145823 RVA: 0x00927CE8 File Offset: 0x00925EE8
		public unsafe UStaticMeshComponent StaticMesh36
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x060239A0 RID: 145824 RVA: 0x00927CFD File Offset: 0x00925EFD
		// (set) Token: 0x060239A1 RID: 145825 RVA: 0x00927D11 File Offset: 0x00925F11
		public unsafe UStaticMeshComponent StaticMesh35
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_59);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_59, value);
			}
		}

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x060239A2 RID: 145826 RVA: 0x00927D26 File Offset: 0x00925F26
		// (set) Token: 0x060239A3 RID: 145827 RVA: 0x00927D3A File Offset: 0x00925F3A
		public unsafe UStaticMeshComponent StaticMesh34
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x060239A4 RID: 145828 RVA: 0x00927D4F File Offset: 0x00925F4F
		// (set) Token: 0x060239A5 RID: 145829 RVA: 0x00927D63 File Offset: 0x00925F63
		public unsafe UStaticMeshComponent StaticMesh33
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_61);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_61, value);
			}
		}

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x060239A6 RID: 145830 RVA: 0x00927D78 File Offset: 0x00925F78
		// (set) Token: 0x060239A7 RID: 145831 RVA: 0x00927D8C File Offset: 0x00925F8C
		public unsafe UStaticMeshComponent StaticMesh32
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_62);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_62, value);
			}
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x060239A8 RID: 145832 RVA: 0x00927DA1 File Offset: 0x00925FA1
		// (set) Token: 0x060239A9 RID: 145833 RVA: 0x00927DB5 File Offset: 0x00925FB5
		public unsafe UStaticMeshComponent StaticMesh31
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x060239AA RID: 145834 RVA: 0x00927DCA File Offset: 0x00925FCA
		// (set) Token: 0x060239AB RID: 145835 RVA: 0x00927DDE File Offset: 0x00925FDE
		public unsafe UStaticMeshComponent StaticMesh30
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x060239AC RID: 145836 RVA: 0x00927DF3 File Offset: 0x00925FF3
		// (set) Token: 0x060239AD RID: 145837 RVA: 0x00927E07 File Offset: 0x00926007
		public unsafe UStaticMeshComponent StaticMesh29
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x060239AE RID: 145838 RVA: 0x00927E1C File Offset: 0x0092601C
		// (set) Token: 0x060239AF RID: 145839 RVA: 0x00927E30 File Offset: 0x00926030
		public unsafe UStaticMeshComponent StaticMesh28
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_66);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x060239B0 RID: 145840 RVA: 0x00927E45 File Offset: 0x00926045
		// (set) Token: 0x060239B1 RID: 145841 RVA: 0x00927E59 File Offset: 0x00926059
		public unsafe UStaticMeshComponent StaticMesh27
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_67);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_67, value);
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x060239B2 RID: 145842 RVA: 0x00927E6E File Offset: 0x0092606E
		// (set) Token: 0x060239B3 RID: 145843 RVA: 0x00927E82 File Offset: 0x00926082
		public unsafe UStaticMeshComponent StaticMesh26
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_68);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_68, value);
			}
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x060239B4 RID: 145844 RVA: 0x00927E97 File Offset: 0x00926097
		// (set) Token: 0x060239B5 RID: 145845 RVA: 0x00927EAB File Offset: 0x009260AB
		public unsafe UStaticMeshComponent StaticMesh25
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_69);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_69, value);
			}
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x060239B6 RID: 145846 RVA: 0x00927EC0 File Offset: 0x009260C0
		// (set) Token: 0x060239B7 RID: 145847 RVA: 0x00927ED4 File Offset: 0x009260D4
		public unsafe UStaticMeshComponent StaticMesh24
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_70);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_70, value);
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x060239B8 RID: 145848 RVA: 0x00927EE9 File Offset: 0x009260E9
		// (set) Token: 0x060239B9 RID: 145849 RVA: 0x00927EFD File Offset: 0x009260FD
		public unsafe UStaticMeshComponent StaticMesh23
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_71);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_71, value);
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x060239BA RID: 145850 RVA: 0x00927F12 File Offset: 0x00926112
		// (set) Token: 0x060239BB RID: 145851 RVA: 0x00927F26 File Offset: 0x00926126
		public unsafe UStaticMeshComponent StaticMesh22
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_72);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_72, value);
			}
		}

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x060239BC RID: 145852 RVA: 0x00927F3B File Offset: 0x0092613B
		// (set) Token: 0x060239BD RID: 145853 RVA: 0x00927F4F File Offset: 0x0092614F
		public unsafe UStaticMeshComponent StaticMesh21
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_73);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_73, value);
			}
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x060239BE RID: 145854 RVA: 0x00927F64 File Offset: 0x00926164
		// (set) Token: 0x060239BF RID: 145855 RVA: 0x00927F78 File Offset: 0x00926178
		public unsafe UStaticMeshComponent StaticMesh20
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_74);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_74, value);
			}
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x060239C0 RID: 145856 RVA: 0x00927F8D File Offset: 0x0092618D
		// (set) Token: 0x060239C1 RID: 145857 RVA: 0x00927FA1 File Offset: 0x009261A1
		public unsafe UStaticMeshComponent StaticMesh19
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_75);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_75, value);
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x060239C2 RID: 145858 RVA: 0x00927FB6 File Offset: 0x009261B6
		// (set) Token: 0x060239C3 RID: 145859 RVA: 0x00927FCA File Offset: 0x009261CA
		public unsafe UStaticMeshComponent StaticMesh18
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_76);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_76, value);
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x060239C4 RID: 145860 RVA: 0x00927FDF File Offset: 0x009261DF
		// (set) Token: 0x060239C5 RID: 145861 RVA: 0x00927FF3 File Offset: 0x009261F3
		public unsafe UStaticMeshComponent StaticMesh17
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_77);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_77, value);
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x060239C6 RID: 145862 RVA: 0x00928008 File Offset: 0x00926208
		// (set) Token: 0x060239C7 RID: 145863 RVA: 0x0092801C File Offset: 0x0092621C
		public unsafe UStaticMeshComponent StaticMesh16
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_78);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_78, value);
			}
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x060239C8 RID: 145864 RVA: 0x00928031 File Offset: 0x00926231
		// (set) Token: 0x060239C9 RID: 145865 RVA: 0x00928045 File Offset: 0x00926245
		public unsafe UStaticMeshComponent StaticMesh15
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_79);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_79, value);
			}
		}

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x060239CA RID: 145866 RVA: 0x0092805A File Offset: 0x0092625A
		// (set) Token: 0x060239CB RID: 145867 RVA: 0x0092806E File Offset: 0x0092626E
		public unsafe UStaticMeshComponent StaticMesh14
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_80);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_80, value);
			}
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x060239CC RID: 145868 RVA: 0x00928083 File Offset: 0x00926283
		// (set) Token: 0x060239CD RID: 145869 RVA: 0x00928097 File Offset: 0x00926297
		public unsafe UStaticMeshComponent StaticMesh13
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_81);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_81, value);
			}
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x060239CE RID: 145870 RVA: 0x009280AC File Offset: 0x009262AC
		// (set) Token: 0x060239CF RID: 145871 RVA: 0x009280C0 File Offset: 0x009262C0
		public unsafe UStaticMeshComponent StaticMesh12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_82);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_82, value);
			}
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x060239D0 RID: 145872 RVA: 0x009280D5 File Offset: 0x009262D5
		// (set) Token: 0x060239D1 RID: 145873 RVA: 0x009280E9 File Offset: 0x009262E9
		public unsafe UStaticMeshComponent StaticMesh11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_83);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_83, value);
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x060239D2 RID: 145874 RVA: 0x009280FE File Offset: 0x009262FE
		// (set) Token: 0x060239D3 RID: 145875 RVA: 0x00928112 File Offset: 0x00926312
		public unsafe UStaticMeshComponent StaticMesh10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_84);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_84, value);
			}
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x060239D4 RID: 145876 RVA: 0x00928127 File Offset: 0x00926327
		// (set) Token: 0x060239D5 RID: 145877 RVA: 0x0092813B File Offset: 0x0092633B
		public unsafe UStaticMeshComponent StaticMesh09
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_85);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_85, value);
			}
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x060239D6 RID: 145878 RVA: 0x00928150 File Offset: 0x00926350
		// (set) Token: 0x060239D7 RID: 145879 RVA: 0x00928164 File Offset: 0x00926364
		public unsafe UStaticMeshComponent StaticMesh08
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_86);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_86, value);
			}
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x060239D8 RID: 145880 RVA: 0x00928179 File Offset: 0x00926379
		// (set) Token: 0x060239D9 RID: 145881 RVA: 0x0092818D File Offset: 0x0092638D
		public unsafe UStaticMeshComponent StaticMesh07
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_87);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_87, value);
			}
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x060239DA RID: 145882 RVA: 0x009281A2 File Offset: 0x009263A2
		// (set) Token: 0x060239DB RID: 145883 RVA: 0x009281B6 File Offset: 0x009263B6
		public unsafe UStaticMeshComponent StaticMesh06
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_88);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_88, value);
			}
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x060239DC RID: 145884 RVA: 0x009281CB File Offset: 0x009263CB
		// (set) Token: 0x060239DD RID: 145885 RVA: 0x009281DF File Offset: 0x009263DF
		public unsafe UStaticMeshComponent StaticMesh05
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_89);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_89, value);
			}
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x060239DE RID: 145886 RVA: 0x009281F4 File Offset: 0x009263F4
		// (set) Token: 0x060239DF RID: 145887 RVA: 0x00928208 File Offset: 0x00926408
		public unsafe UStaticMeshComponent StaticMesh04
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_90);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_90, value);
			}
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x060239E0 RID: 145888 RVA: 0x0092821D File Offset: 0x0092641D
		// (set) Token: 0x060239E1 RID: 145889 RVA: 0x00928231 File Offset: 0x00926431
		public unsafe UStaticMeshComponent StaticMesh03
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_91);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_91, value);
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x060239E2 RID: 145890 RVA: 0x00928246 File Offset: 0x00926446
		// (set) Token: 0x060239E3 RID: 145891 RVA: 0x0092825A File Offset: 0x0092645A
		public unsafe UStaticMeshComponent StaticMesh02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_92);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_92, value);
			}
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x060239E4 RID: 145892 RVA: 0x0092826F File Offset: 0x0092646F
		// (set) Token: 0x060239E5 RID: 145893 RVA: 0x00928283 File Offset: 0x00926483
		public unsafe UStaticMeshComponent StaticMesh01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_93);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_93, value);
			}
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x060239E6 RID: 145894 RVA: 0x00928298 File Offset: 0x00926498
		// (set) Token: 0x060239E7 RID: 145895 RVA: 0x009282AC File Offset: 0x009264AC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_94);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_Broken_C.__PropertyOffset_94, value);
			}
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x060239E8 RID: 145896 RVA: 0x009282C4 File Offset: 0x009264C4
		// (set) Token: 0x060239E9 RID: 145897 RVA: 0x009282FD File Offset: 0x009264FD
		[Nullable(1)]
		public custom custom
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				custom result;
				if ((result = this._custom) == null)
				{
					result = (this._custom = new custom(base.NativePtr + (IntPtr)BP_BridgeModels_Broken_C.__PropertyOffset_95, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_BridgeModels_Broken_C.__PropertyOffset_95, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x060239EA RID: 145898 RVA: 0x0092831E File Offset: 0x0092651E
		// (set) Token: 0x060239EB RID: 145899 RVA: 0x00928332 File Offset: 0x00926532
		public unsafe FVector NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_Broken_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_Broken_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x060239EC RID: 145900 RVA: 0x00928348 File Offset: 0x00926548
		// (set) Token: 0x060239ED RID: 145901 RVA: 0x00928381 File Offset: 0x00926581
		[Nullable(1)]
		public TArray<UStaticMeshComponent> BlockList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._BlockList) == null)
				{
					result = (this._BlockList = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_BridgeModels_Broken_C.__PropertyOffset_97, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BlockList.CopyAssign(value);
			}
		}

		// Token: 0x060239EE RID: 145902 RVA: 0x0092838F File Offset: 0x0092658F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RecoverBlock()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_Broken_C.__RecoverBlock_NativeFunctionPtr, null);
		}

		// Token: 0x060239EF RID: 145903 RVA: 0x009283A4 File Offset: 0x009265A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSideBlockColli(bool IsBreak)
		{
			BP_BridgeModels_Broken_C.__SetSideBlockColli_FunctionParams* ptr = stackalloc BP_BridgeModels_Broken_C.__SetSideBlockColli_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BridgeModels_Broken_C.__SetSideBlockColli_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_Broken_C.__SetSideBlockColli_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsBreak = IsBreak;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_Broken_C.__SetSideBlockColli_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060239F0 RID: 145904 RVA: 0x009283EC File Offset: 0x009265EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetBridgeLink(int idx, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UChildActorComponent> tempArray1)
		{
			BP_BridgeModels_Broken_C.__GetBridgeLink_FunctionParams* ptr = stackalloc BP_BridgeModels_Broken_C.__GetBridgeLink_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(BP_BridgeModels_Broken_C.__GetBridgeLink_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_Broken_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
			ptr->idx = idx;
			TArray<UChildActorComponent> tarray = tempArray1;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->tempArray1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_Broken_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr);
			TArray<UChildActorComponent> tarray2 = tempArray1;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->tempArray1);
			}
			UnrealReflectionUtils.DestroyStruct(BP_BridgeModels_Broken_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060239F1 RID: 145905 RVA: 0x0092846E File Offset: 0x0092666E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_Broken_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060239F2 RID: 145906 RVA: 0x00928482 File Offset: 0x00926682
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_Broken_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060239F3 RID: 145907 RVA: 0x00928497 File Offset: 0x00926697
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_Broken_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060239F4 RID: 145908 RVA: 0x009284AB File Offset: 0x009266AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_Broken_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060239F5 RID: 145909 RVA: 0x009284C0 File Offset: 0x009266C0
		protected BP_BridgeModels_Broken_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401190C RID: 71948
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_Broken.BP_BridgeModels_Broken_C";

		// Token: 0x0401190D RID: 71949
		private static IntPtr _ClassPtr;

		// Token: 0x0401190E RID: 71950
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401190F RID: 71951
		public static IntPtr __custom__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011910 RID: 71952
		internal static int __PropertyOffset_1;

		// Token: 0x04011911 RID: 71953
		internal static int __PropertyOffset_2;

		// Token: 0x04011912 RID: 71954
		internal static int __PropertyOffset_3;

		// Token: 0x04011913 RID: 71955
		internal static int __PropertyOffset_4;

		// Token: 0x04011914 RID: 71956
		internal static int __PropertyOffset_5;

		// Token: 0x04011915 RID: 71957
		internal static int __PropertyOffset_6;

		// Token: 0x04011916 RID: 71958
		internal static int __PropertyOffset_7;

		// Token: 0x04011917 RID: 71959
		internal static int __PropertyOffset_8;

		// Token: 0x04011918 RID: 71960
		internal static int __PropertyOffset_9;

		// Token: 0x04011919 RID: 71961
		internal static int __PropertyOffset_10;

		// Token: 0x0401191A RID: 71962
		internal static int __PropertyOffset_11;

		// Token: 0x0401191B RID: 71963
		internal static int __PropertyOffset_12;

		// Token: 0x0401191C RID: 71964
		internal static int __PropertyOffset_13;

		// Token: 0x0401191D RID: 71965
		internal static int __PropertyOffset_14;

		// Token: 0x0401191E RID: 71966
		internal static int __PropertyOffset_15;

		// Token: 0x0401191F RID: 71967
		internal static int __PropertyOffset_16;

		// Token: 0x04011920 RID: 71968
		internal static int __PropertyOffset_17;

		// Token: 0x04011921 RID: 71969
		internal static int __PropertyOffset_18;

		// Token: 0x04011922 RID: 71970
		internal static int __PropertyOffset_19;

		// Token: 0x04011923 RID: 71971
		internal static int __PropertyOffset_20;

		// Token: 0x04011924 RID: 71972
		internal static int __PropertyOffset_21;

		// Token: 0x04011925 RID: 71973
		internal static int __PropertyOffset_22;

		// Token: 0x04011926 RID: 71974
		internal static int __PropertyOffset_23;

		// Token: 0x04011927 RID: 71975
		internal static int __PropertyOffset_24;

		// Token: 0x04011928 RID: 71976
		internal static int __PropertyOffset_25;

		// Token: 0x04011929 RID: 71977
		internal static int __PropertyOffset_26;

		// Token: 0x0401192A RID: 71978
		internal static int __PropertyOffset_27;

		// Token: 0x0401192B RID: 71979
		internal static int __PropertyOffset_28;

		// Token: 0x0401192C RID: 71980
		internal static int __PropertyOffset_29;

		// Token: 0x0401192D RID: 71981
		internal static int __PropertyOffset_30;

		// Token: 0x0401192E RID: 71982
		internal static int __PropertyOffset_31;

		// Token: 0x0401192F RID: 71983
		internal static int __PropertyOffset_32;

		// Token: 0x04011930 RID: 71984
		internal static int __PropertyOffset_33;

		// Token: 0x04011931 RID: 71985
		internal static int __PropertyOffset_34;

		// Token: 0x04011932 RID: 71986
		internal static int __PropertyOffset_35;

		// Token: 0x04011933 RID: 71987
		internal static int __PropertyOffset_36;

		// Token: 0x04011934 RID: 71988
		internal static int __PropertyOffset_37;

		// Token: 0x04011935 RID: 71989
		internal static int __PropertyOffset_38;

		// Token: 0x04011936 RID: 71990
		internal static int __PropertyOffset_39;

		// Token: 0x04011937 RID: 71991
		internal static int __PropertyOffset_40;

		// Token: 0x04011938 RID: 71992
		internal static int __PropertyOffset_41;

		// Token: 0x04011939 RID: 71993
		internal static int __PropertyOffset_42;

		// Token: 0x0401193A RID: 71994
		internal static int __PropertyOffset_43;

		// Token: 0x0401193B RID: 71995
		internal static int __PropertyOffset_44;

		// Token: 0x0401193C RID: 71996
		internal static int __PropertyOffset_45;

		// Token: 0x0401193D RID: 71997
		internal static int __PropertyOffset_46;

		// Token: 0x0401193E RID: 71998
		internal static int __PropertyOffset_47;

		// Token: 0x0401193F RID: 71999
		internal static int __PropertyOffset_48;

		// Token: 0x04011940 RID: 72000
		internal static int __PropertyOffset_49;

		// Token: 0x04011941 RID: 72001
		internal static int __PropertyOffset_50;

		// Token: 0x04011942 RID: 72002
		internal static int __PropertyOffset_51;

		// Token: 0x04011943 RID: 72003
		internal static int __PropertyOffset_52;

		// Token: 0x04011944 RID: 72004
		internal static int __PropertyOffset_53;

		// Token: 0x04011945 RID: 72005
		internal static int __PropertyOffset_54;

		// Token: 0x04011946 RID: 72006
		internal static int __PropertyOffset_55;

		// Token: 0x04011947 RID: 72007
		internal static int __PropertyOffset_56;

		// Token: 0x04011948 RID: 72008
		internal static int __PropertyOffset_57;

		// Token: 0x04011949 RID: 72009
		internal static int __PropertyOffset_58;

		// Token: 0x0401194A RID: 72010
		internal static int __PropertyOffset_59;

		// Token: 0x0401194B RID: 72011
		internal static int __PropertyOffset_60;

		// Token: 0x0401194C RID: 72012
		internal static int __PropertyOffset_61;

		// Token: 0x0401194D RID: 72013
		internal static int __PropertyOffset_62;

		// Token: 0x0401194E RID: 72014
		internal static int __PropertyOffset_63;

		// Token: 0x0401194F RID: 72015
		internal static int __PropertyOffset_64;

		// Token: 0x04011950 RID: 72016
		internal static int __PropertyOffset_65;

		// Token: 0x04011951 RID: 72017
		internal static int __PropertyOffset_66;

		// Token: 0x04011952 RID: 72018
		internal static int __PropertyOffset_67;

		// Token: 0x04011953 RID: 72019
		internal static int __PropertyOffset_68;

		// Token: 0x04011954 RID: 72020
		internal static int __PropertyOffset_69;

		// Token: 0x04011955 RID: 72021
		internal static int __PropertyOffset_70;

		// Token: 0x04011956 RID: 72022
		internal static int __PropertyOffset_71;

		// Token: 0x04011957 RID: 72023
		internal static int __PropertyOffset_72;

		// Token: 0x04011958 RID: 72024
		internal static int __PropertyOffset_73;

		// Token: 0x04011959 RID: 72025
		internal static int __PropertyOffset_74;

		// Token: 0x0401195A RID: 72026
		internal static int __PropertyOffset_75;

		// Token: 0x0401195B RID: 72027
		internal static int __PropertyOffset_76;

		// Token: 0x0401195C RID: 72028
		internal static int __PropertyOffset_77;

		// Token: 0x0401195D RID: 72029
		internal static int __PropertyOffset_78;

		// Token: 0x0401195E RID: 72030
		internal static int __PropertyOffset_79;

		// Token: 0x0401195F RID: 72031
		internal static int __PropertyOffset_80;

		// Token: 0x04011960 RID: 72032
		internal static int __PropertyOffset_81;

		// Token: 0x04011961 RID: 72033
		internal static int __PropertyOffset_82;

		// Token: 0x04011962 RID: 72034
		internal static int __PropertyOffset_83;

		// Token: 0x04011963 RID: 72035
		internal static int __PropertyOffset_84;

		// Token: 0x04011964 RID: 72036
		internal static int __PropertyOffset_85;

		// Token: 0x04011965 RID: 72037
		internal static int __PropertyOffset_86;

		// Token: 0x04011966 RID: 72038
		internal static int __PropertyOffset_87;

		// Token: 0x04011967 RID: 72039
		internal static int __PropertyOffset_88;

		// Token: 0x04011968 RID: 72040
		internal static int __PropertyOffset_89;

		// Token: 0x04011969 RID: 72041
		internal static int __PropertyOffset_90;

		// Token: 0x0401196A RID: 72042
		internal static int __PropertyOffset_91;

		// Token: 0x0401196B RID: 72043
		internal static int __PropertyOffset_92;

		// Token: 0x0401196C RID: 72044
		internal static int __PropertyOffset_93;

		// Token: 0x0401196D RID: 72045
		internal static int __PropertyOffset_94;

		// Token: 0x0401196E RID: 72046
		internal static int __PropertyOffset_95;

		// Token: 0x0401196F RID: 72047
		private custom _custom;

		// Token: 0x04011970 RID: 72048
		internal static int __PropertyOffset_96;

		// Token: 0x04011971 RID: 72049
		internal static int __PropertyOffset_97;

		// Token: 0x04011972 RID: 72050
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _BlockList;

		// Token: 0x04011973 RID: 72051
		private static IntPtr __RecoverBlock_NativeFunctionPtr;

		// Token: 0x04011974 RID: 72052
		private static IntPtr __SetSideBlockColli_NativeFunctionPtr;

		// Token: 0x04011975 RID: 72053
		private static IntPtr __GetBridgeLink_NativeFunctionPtr;

		// Token: 0x04011976 RID: 72054
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011977 RID: 72055
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009E7C RID: 40572
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetSideBlockColli_FunctionParams
		{
			// Token: 0x0403171A RID: 202522
			[FieldOffset(0)]
			public bool IsBreak;
		}

		// Token: 0x02009E7D RID: 40573
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __GetBridgeLink_FunctionParams
		{
			// Token: 0x0403171B RID: 202523
			[FieldOffset(0)]
			public int idx;

			// Token: 0x0403171C RID: 202524
			[FieldOffset(8)]
			public byte tempArray1;
		}
	}
}
