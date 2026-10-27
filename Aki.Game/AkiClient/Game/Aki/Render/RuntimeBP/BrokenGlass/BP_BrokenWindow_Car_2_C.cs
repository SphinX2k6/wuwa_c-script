using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.BrokenGlass
{
	// Token: 0x02003E36 RID: 15926
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow_Car_2.BP_BrokenWindow_Car_2_C")]
	[UnrealStructLayout(1832, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1832)]
	public class BP_BrokenWindow_Car_2_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027FBF RID: 163775 RVA: 0x009A1304 File Offset: 0x0099F504
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BrokenWindow_Car_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow_Car_2.BP_BrokenWindow_Car_2_C");
			}
			return BP_BrokenWindow_Car_2_C._ClassPtr;
		}

		// Token: 0x06027FC0 RID: 163776 RVA: 0x009A1328 File Offset: 0x0099F528
		public BP_BrokenWindow_Car_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_BrokenWindow_Car_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027FC1 RID: 163777 RVA: 0x009A1350 File Offset: 0x0099F550
		[NullableContext(1)]
		public BP_BrokenWindow_Car_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BrokenWindow_Car_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B1D RID: 23325
		// (get) Token: 0x06027FC2 RID: 163778 RVA: 0x009A1383 File Offset: 0x0099F583
		// (set) Token: 0x06027FC3 RID: 163779 RVA: 0x009A1397 File Offset: 0x0099F597
		public unsafe UStaticMeshComponent WindowFront2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005B1E RID: 23326
		// (get) Token: 0x06027FC4 RID: 163780 RVA: 0x009A13AC File Offset: 0x0099F5AC
		// (set) Token: 0x06027FC5 RID: 163781 RVA: 0x009A13C0 File Offset: 0x0099F5C0
		public unsafe UStaticMeshComponent WindowFront1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005B1F RID: 23327
		// (get) Token: 0x06027FC6 RID: 163782 RVA: 0x009A13D5 File Offset: 0x0099F5D5
		// (set) Token: 0x06027FC7 RID: 163783 RVA: 0x009A13E9 File Offset: 0x0099F5E9
		public unsafe UStaticMeshComponent WindowBack1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005B20 RID: 23328
		// (get) Token: 0x06027FC8 RID: 163784 RVA: 0x009A13FE File Offset: 0x0099F5FE
		// (set) Token: 0x06027FC9 RID: 163785 RVA: 0x009A1412 File Offset: 0x0099F612
		public unsafe UStaticMeshComponent WindowBack2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005B21 RID: 23329
		// (get) Token: 0x06027FCA RID: 163786 RVA: 0x009A1427 File Offset: 0x0099F627
		// (set) Token: 0x06027FCB RID: 163787 RVA: 0x009A143B File Offset: 0x0099F63B
		public unsafe UStaticMeshComponent WindowRight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005B22 RID: 23330
		// (get) Token: 0x06027FCC RID: 163788 RVA: 0x009A1450 File Offset: 0x0099F650
		// (set) Token: 0x06027FCD RID: 163789 RVA: 0x009A1464 File Offset: 0x0099F664
		public unsafe UStaticMeshComponent WindowLeft
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005B23 RID: 23331
		// (get) Token: 0x06027FCE RID: 163790 RVA: 0x009A1479 File Offset: 0x0099F679
		// (set) Token: 0x06027FCF RID: 163791 RVA: 0x009A148D File Offset: 0x0099F68D
		public unsafe UBoxComponent BackWindowColli2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005B24 RID: 23332
		// (get) Token: 0x06027FD0 RID: 163792 RVA: 0x009A14A2 File Offset: 0x0099F6A2
		// (set) Token: 0x06027FD1 RID: 163793 RVA: 0x009A14B6 File Offset: 0x0099F6B6
		public unsafe UBoxComponent BackWindowColli1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005B25 RID: 23333
		// (get) Token: 0x06027FD2 RID: 163794 RVA: 0x009A14CB File Offset: 0x0099F6CB
		// (set) Token: 0x06027FD3 RID: 163795 RVA: 0x009A14DF File Offset: 0x0099F6DF
		public unsafe UBoxComponent FrontWindowColli2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005B26 RID: 23334
		// (get) Token: 0x06027FD4 RID: 163796 RVA: 0x009A14F4 File Offset: 0x0099F6F4
		// (set) Token: 0x06027FD5 RID: 163797 RVA: 0x009A1508 File Offset: 0x0099F708
		public unsafe UBoxComponent FrontWindowColli1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005B27 RID: 23335
		// (get) Token: 0x06027FD6 RID: 163798 RVA: 0x009A151D File Offset: 0x0099F71D
		// (set) Token: 0x06027FD7 RID: 163799 RVA: 0x009A1531 File Offset: 0x0099F731
		public unsafe UBoxComponent RightWindowColli
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005B28 RID: 23336
		// (get) Token: 0x06027FD8 RID: 163800 RVA: 0x009A1546 File Offset: 0x0099F746
		// (set) Token: 0x06027FD9 RID: 163801 RVA: 0x009A155A File Offset: 0x0099F75A
		public unsafe UBoxComponent LeftWindowColli
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005B29 RID: 23337
		// (get) Token: 0x06027FDA RID: 163802 RVA: 0x009A156F File Offset: 0x0099F76F
		// (set) Token: 0x06027FDB RID: 163803 RVA: 0x009A1583 File Offset: 0x0099F783
		public unsafe UStaticMeshComponent SM_Com3_Car_05AL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005B2A RID: 23338
		// (get) Token: 0x06027FDC RID: 163804 RVA: 0x009A1598 File Offset: 0x0099F798
		// (set) Token: 0x06027FDD RID: 163805 RVA: 0x009A15AC File Offset: 0x0099F7AC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_Car_2_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005B2B RID: 23339
		// (get) Token: 0x06027FDE RID: 163806 RVA: 0x009A15C1 File Offset: 0x0099F7C1
		// (set) Token: 0x06027FDF RID: 163807 RVA: 0x009A15D5 File Offset: 0x0099F7D5
		public unsafe FVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005B2C RID: 23340
		// (get) Token: 0x06027FE0 RID: 163808 RVA: 0x009A15EC File Offset: 0x0099F7EC
		// (set) Token: 0x06027FE1 RID: 163809 RVA: 0x009A1625 File Offset: 0x0099F825
		[Nullable(1)]
		public TArray<FVector> UVList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._UVList) == null)
				{
					result = (this._UVList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UVList.CopyAssign(value);
			}
		}

		// Token: 0x17005B2D RID: 23341
		// (get) Token: 0x06027FE2 RID: 163810 RVA: 0x009A1633 File Offset: 0x0099F833
		// (set) Token: 0x06027FE3 RID: 163811 RVA: 0x009A1643 File Offset: 0x0099F843
		public unsafe int UVIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005B2E RID: 23342
		// (get) Token: 0x06027FE4 RID: 163812 RVA: 0x009A1654 File Offset: 0x0099F854
		// (set) Token: 0x06027FE5 RID: 163813 RVA: 0x009A1664 File Offset: 0x0099F864
		public unsafe float HitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005B2F RID: 23343
		// (get) Token: 0x06027FE6 RID: 163814 RVA: 0x009A1675 File Offset: 0x0099F875
		// (set) Token: 0x06027FE7 RID: 163815 RVA: 0x009A1685 File Offset: 0x0099F885
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005B30 RID: 23344
		// (get) Token: 0x06027FE8 RID: 163816 RVA: 0x009A1696 File Offset: 0x0099F896
		// (set) Token: 0x06027FE9 RID: 163817 RVA: 0x009A16AA File Offset: 0x0099F8AA
		public unsafe FVector LastWeaponPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005B31 RID: 23345
		// (get) Token: 0x06027FEA RID: 163818 RVA: 0x009A16BF File Offset: 0x0099F8BF
		// (set) Token: 0x06027FEB RID: 163819 RVA: 0x009A16CF File Offset: 0x0099F8CF
		public unsafe float CrackPointState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005B32 RID: 23346
		// (get) Token: 0x06027FEC RID: 163820 RVA: 0x009A16E0 File Offset: 0x0099F8E0
		// (set) Token: 0x06027FED RID: 163821 RVA: 0x009A1719 File Offset: 0x0099F919
		[Nullable(1)]
		public TArray<int> BitMask
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BitMask) == null)
				{
					result = (this._BitMask = new TArray<int>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_22, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BitMask.CopyAssign(value);
			}
		}

		// Token: 0x17005B33 RID: 23347
		// (get) Token: 0x06027FEE RID: 163822 RVA: 0x009A1727 File Offset: 0x0099F927
		// (set) Token: 0x06027FEF RID: 163823 RVA: 0x009A1737 File Offset: 0x0099F937
		public unsafe int FinalStateMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005B34 RID: 23348
		// (get) Token: 0x06027FF0 RID: 163824 RVA: 0x009A1748 File Offset: 0x0099F948
		// (set) Token: 0x06027FF1 RID: 163825 RVA: 0x009A1758 File Offset: 0x0099F958
		public unsafe float InteractRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005B35 RID: 23349
		// (get) Token: 0x06027FF2 RID: 163826 RVA: 0x009A1769 File Offset: 0x0099F969
		// (set) Token: 0x06027FF3 RID: 163827 RVA: 0x009A1779 File Offset: 0x0099F979
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B36 RID: 23350
		// (get) Token: 0x06027FF4 RID: 163828 RVA: 0x009A178A File Offset: 0x0099F98A
		// (set) Token: 0x06027FF5 RID: 163829 RVA: 0x009A179A File Offset: 0x0099F99A
		public unsafe bool LastPointUseAble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B37 RID: 23351
		// (get) Token: 0x06027FF6 RID: 163830 RVA: 0x009A17AB File Offset: 0x0099F9AB
		// (set) Token: 0x06027FF7 RID: 163831 RVA: 0x009A17BB File Offset: 0x0099F9BB
		public unsafe bool Option_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B38 RID: 23352
		// (get) Token: 0x06027FF8 RID: 163832 RVA: 0x009A17CC File Offset: 0x0099F9CC
		// (set) Token: 0x06027FF9 RID: 163833 RVA: 0x009A17DC File Offset: 0x0099F9DC
		public unsafe bool LeftBroken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B39 RID: 23353
		// (get) Token: 0x06027FFA RID: 163834 RVA: 0x009A17ED File Offset: 0x0099F9ED
		// (set) Token: 0x06027FFB RID: 163835 RVA: 0x009A17FD File Offset: 0x0099F9FD
		public unsafe bool RightBroken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B3A RID: 23354
		// (get) Token: 0x06027FFC RID: 163836 RVA: 0x009A1810 File Offset: 0x0099FA10
		// (set) Token: 0x06027FFD RID: 163837 RVA: 0x009A1849 File Offset: 0x0099FA49
		[Nullable(1)]
		public TMap<FName, int> TagDict
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._TagDict) == null)
				{
					result = (this._TagDict = new TMap<FName, int>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_30, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TagDict.CopyAssign(value);
			}
		}

		// Token: 0x17005B3B RID: 23355
		// (get) Token: 0x06027FFE RID: 163838 RVA: 0x009A1858 File Offset: 0x0099FA58
		// (set) Token: 0x06027FFF RID: 163839 RVA: 0x009A1891 File Offset: 0x0099FA91
		[Nullable(1)]
		public TMap<FName, int> TagIndex
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._TagIndex) == null)
				{
					result = (this._TagIndex = new TMap<FName, int>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_31, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TagIndex.CopyAssign(value);
			}
		}

		// Token: 0x17005B3C RID: 23356
		// (get) Token: 0x06028000 RID: 163840 RVA: 0x009A18A0 File Offset: 0x0099FAA0
		// (set) Token: 0x06028001 RID: 163841 RVA: 0x009A18D9 File Offset: 0x0099FAD9
		[Nullable(1)]
		public TArray<float> CustomTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomTime) == null)
				{
					result = (this._CustomTime = new TArray<float>(base.NativePtr + (IntPtr)BP_BrokenWindow_Car_2_C.__PropertyOffset_32, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomTime.CopyAssign(value);
			}
		}

		// Token: 0x06028002 RID: 163842 RVA: 0x009A18E7 File Offset: 0x0099FAE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_2_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06028003 RID: 163843 RVA: 0x009A18FB File Offset: 0x0099FAFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06028004 RID: 163844 RVA: 0x009A190F File Offset: 0x0099FB0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BrokenWindow_Car_2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028005 RID: 163845 RVA: 0x009A1924 File Offset: 0x0099FB24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BrokenWindow_Car_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BrokenWindow_Car_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BrokenWindow_Car_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_Car_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028006 RID: 163846 RVA: 0x009A196C File Offset: 0x0099FB6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BrokenWindow_Car_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BrokenWindow_Car_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BrokenWindow_Car_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_Car_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BrokenWindow_Car_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028007 RID: 163847 RVA: 0x009A19B4 File Offset: 0x0099FBB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_BrokenWindow_Car_2_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_BrokenWindow_Car_2_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BrokenWindow_Car_2_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_Car_2_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_Car_2_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028008 RID: 163848 RVA: 0x009A1A17 File Offset: 0x0099FC17
		protected BP_BrokenWindow_Car_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040144C5 RID: 83141
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow_Car_2.BP_BrokenWindow_Car_2_C";

		// Token: 0x040144C6 RID: 83142
		private static IntPtr _ClassPtr;

		// Token: 0x040144C7 RID: 83143
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040144C8 RID: 83144
		internal static int __PropertyOffset_1;

		// Token: 0x040144C9 RID: 83145
		internal static int __PropertyOffset_2;

		// Token: 0x040144CA RID: 83146
		internal static int __PropertyOffset_3;

		// Token: 0x040144CB RID: 83147
		internal static int __PropertyOffset_4;

		// Token: 0x040144CC RID: 83148
		internal static int __PropertyOffset_5;

		// Token: 0x040144CD RID: 83149
		internal static int __PropertyOffset_6;

		// Token: 0x040144CE RID: 83150
		internal static int __PropertyOffset_7;

		// Token: 0x040144CF RID: 83151
		internal static int __PropertyOffset_8;

		// Token: 0x040144D0 RID: 83152
		internal static int __PropertyOffset_9;

		// Token: 0x040144D1 RID: 83153
		internal static int __PropertyOffset_10;

		// Token: 0x040144D2 RID: 83154
		internal static int __PropertyOffset_11;

		// Token: 0x040144D3 RID: 83155
		internal static int __PropertyOffset_12;

		// Token: 0x040144D4 RID: 83156
		internal static int __PropertyOffset_13;

		// Token: 0x040144D5 RID: 83157
		internal static int __PropertyOffset_14;

		// Token: 0x040144D6 RID: 83158
		internal static int __PropertyOffset_15;

		// Token: 0x040144D7 RID: 83159
		internal static int __PropertyOffset_16;

		// Token: 0x040144D8 RID: 83160
		private TArray<FVector> _UVList;

		// Token: 0x040144D9 RID: 83161
		internal static int __PropertyOffset_17;

		// Token: 0x040144DA RID: 83162
		internal static int __PropertyOffset_18;

		// Token: 0x040144DB RID: 83163
		internal static int __PropertyOffset_19;

		// Token: 0x040144DC RID: 83164
		internal static int __PropertyOffset_20;

		// Token: 0x040144DD RID: 83165
		internal static int __PropertyOffset_21;

		// Token: 0x040144DE RID: 83166
		internal static int __PropertyOffset_22;

		// Token: 0x040144DF RID: 83167
		private TArray<int> _BitMask;

		// Token: 0x040144E0 RID: 83168
		internal static int __PropertyOffset_23;

		// Token: 0x040144E1 RID: 83169
		internal static int __PropertyOffset_24;

		// Token: 0x040144E2 RID: 83170
		internal static int __PropertyOffset_25;

		// Token: 0x040144E3 RID: 83171
		internal static int __PropertyOffset_26;

		// Token: 0x040144E4 RID: 83172
		internal static int __PropertyOffset_27;

		// Token: 0x040144E5 RID: 83173
		internal static int __PropertyOffset_28;

		// Token: 0x040144E6 RID: 83174
		internal static int __PropertyOffset_29;

		// Token: 0x040144E7 RID: 83175
		internal static int __PropertyOffset_30;

		// Token: 0x040144E8 RID: 83176
		private TMap<FName, int> _TagDict;

		// Token: 0x040144E9 RID: 83177
		internal static int __PropertyOffset_31;

		// Token: 0x040144EA RID: 83178
		private TMap<FName, int> _TagIndex;

		// Token: 0x040144EB RID: 83179
		internal static int __PropertyOffset_32;

		// Token: 0x040144EC RID: 83180
		private TArray<float> _CustomTime;

		// Token: 0x040144ED RID: 83181
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x040144EE RID: 83182
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040144EF RID: 83183
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040144F0 RID: 83184
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x0200A2BA RID: 41658
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FF3 RID: 204787
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2BB RID: 41659
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031FF4 RID: 204788
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031FF5 RID: 204789
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031FF6 RID: 204790
			[FieldOffset(32)]
			public int Id;
		}
	}
}
