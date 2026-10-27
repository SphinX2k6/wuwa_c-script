using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.UI.Module.Common.View.Widget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI
{
	// Token: 0x02003D35 RID: 15669
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/BP_DebugGlobalGI.BP_DebugGlobalGI_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class BP_DebugGlobalGI_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026000 RID: 155648 RVA: 0x009689F4 File Offset: 0x00966BF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DebugGlobalGI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/BP_DebugGlobalGI.BP_DebugGlobalGI_C");
			}
			return BP_DebugGlobalGI_C._ClassPtr;
		}

		// Token: 0x06026001 RID: 155649 RVA: 0x00968A18 File Offset: 0x00966C18
		public BP_DebugGlobalGI_C() : this(BuiltinUtils.AllocNativeUObject(BP_DebugGlobalGI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026002 RID: 155650 RVA: 0x00968A40 File Offset: 0x00966C40
		[NullableContext(1)]
		public BP_DebugGlobalGI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DebugGlobalGI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x06026003 RID: 155651 RVA: 0x00968A73 File Offset: 0x00966C73
		// (set) Token: 0x06026004 RID: 155652 RVA: 0x00968A87 File Offset: 0x00966C87
		public unsafe UButton Btn_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x06026005 RID: 155653 RVA: 0x00968A9C File Offset: 0x00966C9C
		// (set) Token: 0x06026006 RID: 155654 RVA: 0x00968AB0 File Offset: 0x00966CB0
		public unsafe UButton Btn_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x06026007 RID: 155655 RVA: 0x00968AC5 File Offset: 0x00966CC5
		// (set) Token: 0x06026008 RID: 155656 RVA: 0x00968AD9 File Offset: 0x00966CD9
		public unsafe UButton Btn_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x06026009 RID: 155657 RVA: 0x00968AEE File Offset: 0x00966CEE
		// (set) Token: 0x0602600A RID: 155658 RVA: 0x00968B02 File Offset: 0x00966D02
		public unsafe UButton Btn_9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x0602600B RID: 155659 RVA: 0x00968B17 File Offset: 0x00966D17
		// (set) Token: 0x0602600C RID: 155660 RVA: 0x00968B2B File Offset: 0x00966D2B
		public unsafe UButton Btn_12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x0602600D RID: 155661 RVA: 0x00968B40 File Offset: 0x00966D40
		// (set) Token: 0x0602600E RID: 155662 RVA: 0x00968B54 File Offset: 0x00966D54
		public unsafe UButton Btn_15
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x0602600F RID: 155663 RVA: 0x00968B69 File Offset: 0x00966D69
		// (set) Token: 0x06026010 RID: 155664 RVA: 0x00968B7D File Offset: 0x00966D7D
		public unsafe UButton Btn_18
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x06026011 RID: 155665 RVA: 0x00968B92 File Offset: 0x00966D92
		// (set) Token: 0x06026012 RID: 155666 RVA: 0x00968BA6 File Offset: 0x00966DA6
		public unsafe UButton Btn_21
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004FF7 RID: 20471
		// (get) Token: 0x06026013 RID: 155667 RVA: 0x00968BBB File Offset: 0x00966DBB
		// (set) Token: 0x06026014 RID: 155668 RVA: 0x00968BCF File Offset: 0x00966DCF
		public unsafe UButton BtnClose
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004FF8 RID: 20472
		// (get) Token: 0x06026015 RID: 155669 RVA: 0x00968BE4 File Offset: 0x00966DE4
		// (set) Token: 0x06026016 RID: 155670 RVA: 0x00968BF8 File Offset: 0x00966DF8
		public unsafe UButton BtnCloseCloudMove
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004FF9 RID: 20473
		// (get) Token: 0x06026017 RID: 155671 RVA: 0x00968C0D File Offset: 0x00966E0D
		// (set) Token: 0x06026018 RID: 155672 RVA: 0x00968C21 File Offset: 0x00966E21
		public unsafe UButton BtnCloseLightFunction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004FFA RID: 20474
		// (get) Token: 0x06026019 RID: 155673 RVA: 0x00968C36 File Offset: 0x00966E36
		// (set) Token: 0x0602601A RID: 155674 RVA: 0x00968C4A File Offset: 0x00966E4A
		public unsafe UButton BtnCloseLightFunction_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004FFB RID: 20475
		// (get) Token: 0x0602601B RID: 155675 RVA: 0x00968C5F File Offset: 0x00966E5F
		// (set) Token: 0x0602601C RID: 155676 RVA: 0x00968C73 File Offset: 0x00966E73
		public unsafe UButton BtnCloseNewUiScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004FFC RID: 20476
		// (get) Token: 0x0602601D RID: 155677 RVA: 0x00968C88 File Offset: 0x00966E88
		// (set) Token: 0x0602601E RID: 155678 RVA: 0x00968C9C File Offset: 0x00966E9C
		public unsafe UButton BtnCloseStoneAo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004FFD RID: 20477
		// (get) Token: 0x0602601F RID: 155679 RVA: 0x00968CB1 File Offset: 0x00966EB1
		// (set) Token: 0x06026020 RID: 155680 RVA: 0x00968CC5 File Offset: 0x00966EC5
		public unsafe UButton BtnCloseStoneAo_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17004FFE RID: 20478
		// (get) Token: 0x06026021 RID: 155681 RVA: 0x00968CDA File Offset: 0x00966EDA
		// (set) Token: 0x06026022 RID: 155682 RVA: 0x00968CEE File Offset: 0x00966EEE
		public unsafe UButton BtnOpenCloudMove
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004FFF RID: 20479
		// (get) Token: 0x06026023 RID: 155683 RVA: 0x00968D03 File Offset: 0x00966F03
		// (set) Token: 0x06026024 RID: 155684 RVA: 0x00968D17 File Offset: 0x00966F17
		public unsafe UButton BtnOpenNewUiScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17005000 RID: 20480
		// (get) Token: 0x06026025 RID: 155685 RVA: 0x00968D2C File Offset: 0x00966F2C
		// (set) Token: 0x06026026 RID: 155686 RVA: 0x00968D40 File Offset: 0x00966F40
		public unsafe UButton BtnSetInterval
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17005001 RID: 20481
		// (get) Token: 0x06026027 RID: 155687 RVA: 0x00968D55 File Offset: 0x00966F55
		// (set) Token: 0x06026028 RID: 155688 RVA: 0x00968D69 File Offset: 0x00966F69
		public unsafe UButton BtnSetInterval_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17005002 RID: 20482
		// (get) Token: 0x06026029 RID: 155689 RVA: 0x00968D7E File Offset: 0x00966F7E
		// (set) Token: 0x0602602A RID: 155690 RVA: 0x00968D92 File Offset: 0x00966F92
		public unsafe UButton BtnSetInterval_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17005003 RID: 20483
		// (get) Token: 0x0602602B RID: 155691 RVA: 0x00968DA7 File Offset: 0x00966FA7
		// (set) Token: 0x0602602C RID: 155692 RVA: 0x00968DBB File Offset: 0x00966FBB
		public unsafe UButton BtnSetInterval_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005004 RID: 20484
		// (get) Token: 0x0602602D RID: 155693 RVA: 0x00968DD0 File Offset: 0x00966FD0
		// (set) Token: 0x0602602E RID: 155694 RVA: 0x00968DE4 File Offset: 0x00966FE4
		public unsafe UButton BtnSetTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17005005 RID: 20485
		// (get) Token: 0x0602602F RID: 155695 RVA: 0x00968DF9 File Offset: 0x00966FF9
		// (set) Token: 0x06026030 RID: 155696 RVA: 0x00968E0D File Offset: 0x0096700D
		public unsafe UButton BtnStart
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17005006 RID: 20486
		// (get) Token: 0x06026031 RID: 155697 RVA: 0x00968E22 File Offset: 0x00967022
		// (set) Token: 0x06026032 RID: 155698 RVA: 0x00968E36 File Offset: 0x00967036
		public unsafe UButton BtnStop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17005007 RID: 20487
		// (get) Token: 0x06026033 RID: 155699 RVA: 0x00968E4B File Offset: 0x0096704B
		// (set) Token: 0x06026034 RID: 155700 RVA: 0x00968E5F File Offset: 0x0096705F
		public unsafe UButton BtnTestUiScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17005008 RID: 20488
		// (get) Token: 0x06026035 RID: 155701 RVA: 0x00968E74 File Offset: 0x00967074
		// (set) Token: 0x06026036 RID: 155702 RVA: 0x00968E88 File Offset: 0x00967088
		public unsafe UButton BtnTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17005009 RID: 20489
		// (get) Token: 0x06026037 RID: 155703 RVA: 0x00968E9D File Offset: 0x0096709D
		// (set) Token: 0x06026038 RID: 155704 RVA: 0x00968EB1 File Offset: 0x009670B1
		public unsafe UButton BtnTime_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x1700500A RID: 20490
		// (get) Token: 0x06026039 RID: 155705 RVA: 0x00968EC6 File Offset: 0x009670C6
		// (set) Token: 0x0602603A RID: 155706 RVA: 0x00968EDA File Offset: 0x009670DA
		public unsafe UButton BtnTime_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x1700500B RID: 20491
		// (get) Token: 0x0602603B RID: 155707 RVA: 0x00968EEF File Offset: 0x009670EF
		// (set) Token: 0x0602603C RID: 155708 RVA: 0x00968F03 File Offset: 0x00967103
		public unsafe UButton BtnTime_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x1700500C RID: 20492
		// (get) Token: 0x0602603D RID: 155709 RVA: 0x00968F18 File Offset: 0x00967118
		// (set) Token: 0x0602603E RID: 155710 RVA: 0x00968F2C File Offset: 0x0096712C
		public unsafe UButton BtnTime_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x1700500D RID: 20493
		// (get) Token: 0x0602603F RID: 155711 RVA: 0x00968F41 File Offset: 0x00967141
		// (set) Token: 0x06026040 RID: 155712 RVA: 0x00968F55 File Offset: 0x00967155
		public unsafe UButton BtnTime_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x1700500E RID: 20494
		// (get) Token: 0x06026041 RID: 155713 RVA: 0x00968F6A File Offset: 0x0096716A
		// (set) Token: 0x06026042 RID: 155714 RVA: 0x00968F7E File Offset: 0x0096717E
		public unsafe UButton BtnTime_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x1700500F RID: 20495
		// (get) Token: 0x06026043 RID: 155715 RVA: 0x00968F93 File Offset: 0x00967193
		// (set) Token: 0x06026044 RID: 155716 RVA: 0x00968FA7 File Offset: 0x009671A7
		public unsafe UButton BtnTime_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17005010 RID: 20496
		// (get) Token: 0x06026045 RID: 155717 RVA: 0x00968FBC File Offset: 0x009671BC
		// (set) Token: 0x06026046 RID: 155718 RVA: 0x00968FD0 File Offset: 0x009671D0
		public unsafe UButton BtnTime_7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17005011 RID: 20497
		// (get) Token: 0x06026047 RID: 155719 RVA: 0x00968FE5 File Offset: 0x009671E5
		// (set) Token: 0x06026048 RID: 155720 RVA: 0x00968FF9 File Offset: 0x009671F9
		public unsafe UButton BtnTime_8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17005012 RID: 20498
		// (get) Token: 0x06026049 RID: 155721 RVA: 0x0096900E File Offset: 0x0096720E
		// (set) Token: 0x0602604A RID: 155722 RVA: 0x00969022 File Offset: 0x00967222
		public unsafe UButton BtnUpdate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17005013 RID: 20499
		// (get) Token: 0x0602604B RID: 155723 RVA: 0x00969037 File Offset: 0x00967237
		// (set) Token: 0x0602604C RID: 155724 RVA: 0x0096904B File Offset: 0x0096724B
		public unsafe KuroImage_C KuroImage_C_76
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17005014 RID: 20500
		// (get) Token: 0x0602604D RID: 155725 RVA: 0x00969060 File Offset: 0x00967260
		// (set) Token: 0x0602604E RID: 155726 RVA: 0x00969074 File Offset: 0x00967274
		public unsafe USlider Slider_CurTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x0602604F RID: 155727 RVA: 0x00969089 File Offset: 0x00967289
		// (set) Token: 0x06026050 RID: 155728 RVA: 0x0096909D File Offset: 0x0096729D
		public unsafe UTextBlock Text_CurTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x06026051 RID: 155729 RVA: 0x009690B2 File Offset: 0x009672B2
		// (set) Token: 0x06026052 RID: 155730 RVA: 0x009690C6 File Offset: 0x009672C6
		public unsafe UTextBlock Text_TimeHint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x06026053 RID: 155731 RVA: 0x009690DB File Offset: 0x009672DB
		// (set) Token: 0x06026054 RID: 155732 RVA: 0x009690EF File Offset: 0x009672EF
		public unsafe UEditableText TextInput_Time
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEditableText>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x06026055 RID: 155733 RVA: 0x00969104 File Offset: 0x00967304
		// (set) Token: 0x06026056 RID: 155734 RVA: 0x00969118 File Offset: 0x00967318
		public unsafe UEditableText TextInput_Time_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEditableText>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x06026057 RID: 155735 RVA: 0x0096912D File Offset: 0x0096732D
		// (set) Token: 0x06026058 RID: 155736 RVA: 0x00969141 File Offset: 0x00967341
		public unsafe UEditableText TextInput_TimeInterval
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEditableText>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugGlobalGI_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x06026059 RID: 155737 RVA: 0x00969156 File Offset: 0x00967356
		// (set) Token: 0x0602605A RID: 155738 RVA: 0x0096916B File Offset: 0x0096736B
		[Nullable(1)]
		public TSoftObjectPtr<BP_GlobalGI_C> BP_GlobalGI
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<BP_GlobalGI_C>(base.NativePtr + (IntPtr)BP_DebugGlobalGI_C.__PropertyOffset_44, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DebugGlobalGI_C.__PropertyOffset_44, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602605B RID: 155739 RVA: 0x00969190 File Offset: 0x00967390
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshTimeHint()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__RefreshTimeHint_NativeFunctionPtr, null);
		}

		// Token: 0x0602605C RID: 155740 RVA: 0x009691A4 File Offset: 0x009673A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetAutoPlay(bool AutoPlay)
		{
			BP_DebugGlobalGI_C.__SetAutoPlay_FunctionParams* ptr = stackalloc BP_DebugGlobalGI_C.__SetAutoPlay_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_DebugGlobalGI_C.__SetAutoPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DebugGlobalGI_C.__SetAutoPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AutoPlay = AutoPlay;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__SetAutoPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602605D RID: 155741 RVA: 0x009691EC File Offset: 0x009673EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetInterval(float Interval)
		{
			BP_DebugGlobalGI_C.__SetInterval_FunctionParams* ptr = stackalloc BP_DebugGlobalGI_C.__SetInterval_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_DebugGlobalGI_C.__SetInterval_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DebugGlobalGI_C.__SetInterval_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Interval = Interval;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__SetInterval_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602605E RID: 155742 RVA: 0x00969234 File Offset: 0x00967434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetTime(float Time)
		{
			BP_DebugGlobalGI_C.__SetTime_FunctionParams* ptr = stackalloc BP_DebugGlobalGI_C.__SetTime_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_DebugGlobalGI_C.__SetTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DebugGlobalGI_C.__SetTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__SetTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602605F RID: 155743 RVA: 0x0096927C File Offset: 0x0096747C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsGIValid(ref bool IsValid)
		{
			BP_DebugGlobalGI_C.__IsGIValid_FunctionParams* ptr = stackalloc BP_DebugGlobalGI_C.__IsGIValid_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_DebugGlobalGI_C.__IsGIValid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DebugGlobalGI_C.__IsGIValid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsValid = IsValid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__IsGIValid_NativeFunctionPtr, (void*)ptr);
			IsValid = ptr->IsValid;
		}

		// Token: 0x06026060 RID: 155744 RVA: 0x009692CB File Offset: 0x009674CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateGIInfo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__UpdateGIInfo_NativeFunctionPtr, null);
		}

		// Token: 0x06026061 RID: 155745 RVA: 0x009692DF File Offset: 0x009674DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FindGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__FindGI_NativeFunctionPtr, null);
		}

		// Token: 0x06026062 RID: 155746 RVA: 0x009692F3 File Offset: 0x009674F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnUpdate_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnUpdate_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026063 RID: 155747 RVA: 0x00969307 File Offset: 0x00967507
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_0_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_0_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026064 RID: 155748 RVA: 0x0096931B File Offset: 0x0096751B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_3_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_3_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026065 RID: 155749 RVA: 0x0096932F File Offset: 0x0096752F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_6_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_6_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026066 RID: 155750 RVA: 0x00969343 File Offset: 0x00967543
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_9_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_9_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026067 RID: 155751 RVA: 0x00969357 File Offset: 0x00967557
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_12_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_12_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026068 RID: 155752 RVA: 0x0096936B File Offset: 0x0096756B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_15_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_15_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026069 RID: 155753 RVA: 0x0096937F File Offset: 0x0096757F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_18_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_18_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602606A RID: 155754 RVA: 0x00969393 File Offset: 0x00967593
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_Btn_21_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_Btn_21_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602606B RID: 155755 RVA: 0x009693A7 File Offset: 0x009675A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnSetInterval_K2Node_ComponentBoundEvent_9_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnSetInterval_K2Node_ComponentBoundEvent_9_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602606C RID: 155756 RVA: 0x009693BB File Offset: 0x009675BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnSetTime_K2Node_ComponentBoundEvent_10_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnSetTime_K2Node_ComponentBoundEvent_10_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602606D RID: 155757 RVA: 0x009693CF File Offset: 0x009675CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnStart_K2Node_ComponentBoundEvent_11_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnStart_K2Node_ComponentBoundEvent_11_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602606E RID: 155758 RVA: 0x009693E3 File Offset: 0x009675E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnStop_K2Node_ComponentBoundEvent_12_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnStop_K2Node_ComponentBoundEvent_12_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602606F RID: 155759 RVA: 0x009693F8 File Offset: 0x009675F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			BP_DebugGlobalGI_C.__Tick_FunctionParams* ptr = stackalloc BP_DebugGlobalGI_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_DebugGlobalGI_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DebugGlobalGI_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026070 RID: 155760 RVA: 0x00969460 File Offset: 0x00967660
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			BP_DebugGlobalGI_C.__Tick_FunctionParams* ptr = stackalloc BP_DebugGlobalGI_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_DebugGlobalGI_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DebugGlobalGI_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DebugGlobalGI_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026071 RID: 155761 RVA: 0x009694C9 File Offset: 0x009676C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_0_K2Node_ComponentBoundEvent_13_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_0_K2Node_ComponentBoundEvent_13_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026072 RID: 155762 RVA: 0x009694DD File Offset: 0x009676DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_1_K2Node_ComponentBoundEvent_14_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_1_K2Node_ComponentBoundEvent_14_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026073 RID: 155763 RVA: 0x009694F1 File Offset: 0x009676F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_2_K2Node_ComponentBoundEvent_15_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_2_K2Node_ComponentBoundEvent_15_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026074 RID: 155764 RVA: 0x00969505 File Offset: 0x00967705
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_K2Node_ComponentBoundEvent_16_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_K2Node_ComponentBoundEvent_16_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026075 RID: 155765 RVA: 0x00969519 File Offset: 0x00967719
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_3_K2Node_ComponentBoundEvent_17_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_3_K2Node_ComponentBoundEvent_17_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026076 RID: 155766 RVA: 0x0096952D File Offset: 0x0096772D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_4_K2Node_ComponentBoundEvent_18_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_4_K2Node_ComponentBoundEvent_18_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026077 RID: 155767 RVA: 0x00969541 File Offset: 0x00967741
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnClose_K2Node_ComponentBoundEvent_19_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnClose_K2Node_ComponentBoundEvent_19_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026078 RID: 155768 RVA: 0x00969555 File Offset: 0x00967755
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_5_K2Node_ComponentBoundEvent_20_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_5_K2Node_ComponentBoundEvent_20_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026079 RID: 155769 RVA: 0x00969569 File Offset: 0x00967769
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_6_K2Node_ComponentBoundEvent_21_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_6_K2Node_ComponentBoundEvent_21_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602607A RID: 155770 RVA: 0x0096957D File Offset: 0x0096777D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_7_K2Node_ComponentBoundEvent_22_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_7_K2Node_ComponentBoundEvent_22_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602607B RID: 155771 RVA: 0x00969591 File Offset: 0x00967791
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTime_8_K2Node_ComponentBoundEvent_23_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTime_8_K2Node_ComponentBoundEvent_23_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602607C RID: 155772 RVA: 0x009695A5 File Offset: 0x009677A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnSetInterval_1_K2Node_ComponentBoundEvent_24_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnSetInterval_1_K2Node_ComponentBoundEvent_24_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602607D RID: 155773 RVA: 0x009695B9 File Offset: 0x009677B9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnSetInterval_2_K2Node_ComponentBoundEvent_25_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnSetInterval_2_K2Node_ComponentBoundEvent_25_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602607E RID: 155774 RVA: 0x009695CD File Offset: 0x009677CD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnSetInterval_3_K2Node_ComponentBoundEvent_26_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnSetInterval_3_K2Node_ComponentBoundEvent_26_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602607F RID: 155775 RVA: 0x009695E1 File Offset: 0x009677E1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__OnBegin_NativeFunctionPtr, null);
		}

		// Token: 0x06026080 RID: 155776 RVA: 0x009695F5 File Offset: 0x009677F5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnCloseLightFunction_K2Node_ComponentBoundEvent_27_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnCloseLightFunction_K2Node_ComponentBoundEvent_27_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026081 RID: 155777 RVA: 0x00969609 File Offset: 0x00967809
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnCloseLightFunction_1_K2Node_ComponentBoundEvent_28_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnCloseLightFunction_1_K2Node_ComponentBoundEvent_28_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026082 RID: 155778 RVA: 0x0096961D File Offset: 0x0096781D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnTestUiScene_K2Node_ComponentBoundEvent_29_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnTestUiScene_K2Node_ComponentBoundEvent_29_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026083 RID: 155779 RVA: 0x00969631 File Offset: 0x00967831
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnCloseStoneAo_K2Node_ComponentBoundEvent_30_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnCloseStoneAo_K2Node_ComponentBoundEvent_30_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026084 RID: 155780 RVA: 0x00969645 File Offset: 0x00967845
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnCloseStoneAo_1_K2Node_ComponentBoundEvent_31_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnCloseStoneAo_1_K2Node_ComponentBoundEvent_31_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026085 RID: 155781 RVA: 0x00969659 File Offset: 0x00967859
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnOpenNewUiScene_K2Node_ComponentBoundEvent_32_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnOpenNewUiScene_K2Node_ComponentBoundEvent_32_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026086 RID: 155782 RVA: 0x0096966D File Offset: 0x0096786D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnCloseNewUiScene_K2Node_ComponentBoundEvent_33_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnCloseNewUiScene_K2Node_ComponentBoundEvent_33_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026087 RID: 155783 RVA: 0x00969681 File Offset: 0x00967881
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnChangeCloudMove_K2Node_ComponentBoundEvent_34_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnChangeCloudMove_K2Node_ComponentBoundEvent_34_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026088 RID: 155784 RVA: 0x00969695 File Offset: 0x00967895
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugGlobalGI_BtnCloseCloudMove_K2Node_ComponentBoundEvent_35_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_BtnCloseCloudMove_K2Node_ComponentBoundEvent_35_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026089 RID: 155785 RVA: 0x009696AC File Offset: 0x009678AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature(in FText Text)
		{
			BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_DebugGlobalGI_C.__BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602608A RID: 155786 RVA: 0x0096970F File Offset: 0x0096790F
		protected BP_DebugGlobalGI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401302E RID: 77870
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/BP_DebugGlobalGI.BP_DebugGlobalGI_C";

		// Token: 0x0401302F RID: 77871
		private static IntPtr _ClassPtr;

		// Token: 0x04013030 RID: 77872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013031 RID: 77873
		internal static int __PropertyOffset_1;

		// Token: 0x04013032 RID: 77874
		internal static int __PropertyOffset_2;

		// Token: 0x04013033 RID: 77875
		internal static int __PropertyOffset_3;

		// Token: 0x04013034 RID: 77876
		internal static int __PropertyOffset_4;

		// Token: 0x04013035 RID: 77877
		internal static int __PropertyOffset_5;

		// Token: 0x04013036 RID: 77878
		internal static int __PropertyOffset_6;

		// Token: 0x04013037 RID: 77879
		internal static int __PropertyOffset_7;

		// Token: 0x04013038 RID: 77880
		internal static int __PropertyOffset_8;

		// Token: 0x04013039 RID: 77881
		internal static int __PropertyOffset_9;

		// Token: 0x0401303A RID: 77882
		internal static int __PropertyOffset_10;

		// Token: 0x0401303B RID: 77883
		internal static int __PropertyOffset_11;

		// Token: 0x0401303C RID: 77884
		internal static int __PropertyOffset_12;

		// Token: 0x0401303D RID: 77885
		internal static int __PropertyOffset_13;

		// Token: 0x0401303E RID: 77886
		internal static int __PropertyOffset_14;

		// Token: 0x0401303F RID: 77887
		internal static int __PropertyOffset_15;

		// Token: 0x04013040 RID: 77888
		internal static int __PropertyOffset_16;

		// Token: 0x04013041 RID: 77889
		internal static int __PropertyOffset_17;

		// Token: 0x04013042 RID: 77890
		internal static int __PropertyOffset_18;

		// Token: 0x04013043 RID: 77891
		internal static int __PropertyOffset_19;

		// Token: 0x04013044 RID: 77892
		internal static int __PropertyOffset_20;

		// Token: 0x04013045 RID: 77893
		internal static int __PropertyOffset_21;

		// Token: 0x04013046 RID: 77894
		internal static int __PropertyOffset_22;

		// Token: 0x04013047 RID: 77895
		internal static int __PropertyOffset_23;

		// Token: 0x04013048 RID: 77896
		internal static int __PropertyOffset_24;

		// Token: 0x04013049 RID: 77897
		internal static int __PropertyOffset_25;

		// Token: 0x0401304A RID: 77898
		internal static int __PropertyOffset_26;

		// Token: 0x0401304B RID: 77899
		internal static int __PropertyOffset_27;

		// Token: 0x0401304C RID: 77900
		internal static int __PropertyOffset_28;

		// Token: 0x0401304D RID: 77901
		internal static int __PropertyOffset_29;

		// Token: 0x0401304E RID: 77902
		internal static int __PropertyOffset_30;

		// Token: 0x0401304F RID: 77903
		internal static int __PropertyOffset_31;

		// Token: 0x04013050 RID: 77904
		internal static int __PropertyOffset_32;

		// Token: 0x04013051 RID: 77905
		internal static int __PropertyOffset_33;

		// Token: 0x04013052 RID: 77906
		internal static int __PropertyOffset_34;

		// Token: 0x04013053 RID: 77907
		internal static int __PropertyOffset_35;

		// Token: 0x04013054 RID: 77908
		internal static int __PropertyOffset_36;

		// Token: 0x04013055 RID: 77909
		internal static int __PropertyOffset_37;

		// Token: 0x04013056 RID: 77910
		internal static int __PropertyOffset_38;

		// Token: 0x04013057 RID: 77911
		internal static int __PropertyOffset_39;

		// Token: 0x04013058 RID: 77912
		internal static int __PropertyOffset_40;

		// Token: 0x04013059 RID: 77913
		internal static int __PropertyOffset_41;

		// Token: 0x0401305A RID: 77914
		internal static int __PropertyOffset_42;

		// Token: 0x0401305B RID: 77915
		internal static int __PropertyOffset_43;

		// Token: 0x0401305C RID: 77916
		internal static int __PropertyOffset_44;

		// Token: 0x0401305D RID: 77917
		private static IntPtr __RefreshTimeHint_NativeFunctionPtr;

		// Token: 0x0401305E RID: 77918
		private static IntPtr __SetAutoPlay_NativeFunctionPtr;

		// Token: 0x0401305F RID: 77919
		private static IntPtr __SetInterval_NativeFunctionPtr;

		// Token: 0x04013060 RID: 77920
		private static IntPtr __SetTime_NativeFunctionPtr;

		// Token: 0x04013061 RID: 77921
		private static IntPtr __IsGIValid_NativeFunctionPtr;

		// Token: 0x04013062 RID: 77922
		private static IntPtr __UpdateGIInfo_NativeFunctionPtr;

		// Token: 0x04013063 RID: 77923
		private static IntPtr __FindGI_NativeFunctionPtr;

		// Token: 0x04013064 RID: 77924
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnUpdate_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013065 RID: 77925
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_0_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013066 RID: 77926
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_3_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013067 RID: 77927
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_6_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013068 RID: 77928
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_9_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013069 RID: 77929
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_12_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401306A RID: 77930
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_15_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401306B RID: 77931
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_18_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401306C RID: 77932
		private static IntPtr __BndEvt__BP_DebugGlobalGI_Btn_21_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401306D RID: 77933
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnSetInterval_K2Node_ComponentBoundEvent_9_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401306E RID: 77934
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnSetTime_K2Node_ComponentBoundEvent_10_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401306F RID: 77935
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnStart_K2Node_ComponentBoundEvent_11_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013070 RID: 77936
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnStop_K2Node_ComponentBoundEvent_12_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013071 RID: 77937
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04013072 RID: 77938
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_0_K2Node_ComponentBoundEvent_13_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013073 RID: 77939
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_1_K2Node_ComponentBoundEvent_14_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013074 RID: 77940
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_2_K2Node_ComponentBoundEvent_15_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013075 RID: 77941
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_K2Node_ComponentBoundEvent_16_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013076 RID: 77942
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_3_K2Node_ComponentBoundEvent_17_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013077 RID: 77943
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_4_K2Node_ComponentBoundEvent_18_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013078 RID: 77944
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnClose_K2Node_ComponentBoundEvent_19_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013079 RID: 77945
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_5_K2Node_ComponentBoundEvent_20_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401307A RID: 77946
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_6_K2Node_ComponentBoundEvent_21_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401307B RID: 77947
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_7_K2Node_ComponentBoundEvent_22_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401307C RID: 77948
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTime_8_K2Node_ComponentBoundEvent_23_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401307D RID: 77949
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnSetInterval_1_K2Node_ComponentBoundEvent_24_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401307E RID: 77950
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnSetInterval_2_K2Node_ComponentBoundEvent_25_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401307F RID: 77951
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnSetInterval_3_K2Node_ComponentBoundEvent_26_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013080 RID: 77952
		private static IntPtr __OnBegin_NativeFunctionPtr;

		// Token: 0x04013081 RID: 77953
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnCloseLightFunction_K2Node_ComponentBoundEvent_27_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013082 RID: 77954
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnCloseLightFunction_1_K2Node_ComponentBoundEvent_28_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013083 RID: 77955
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnTestUiScene_K2Node_ComponentBoundEvent_29_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013084 RID: 77956
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnCloseStoneAo_K2Node_ComponentBoundEvent_30_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013085 RID: 77957
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnCloseStoneAo_1_K2Node_ComponentBoundEvent_31_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013086 RID: 77958
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnOpenNewUiScene_K2Node_ComponentBoundEvent_32_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013087 RID: 77959
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnCloseNewUiScene_K2Node_ComponentBoundEvent_33_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013088 RID: 77960
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnChangeCloudMove_K2Node_ComponentBoundEvent_34_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013089 RID: 77961
		private static IntPtr __BndEvt__BP_DebugGlobalGI_BtnCloseCloudMove_K2Node_ComponentBoundEvent_35_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401308A RID: 77962
		private static IntPtr __BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A083 RID: 41091
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetAutoPlay_FunctionParams
		{
			// Token: 0x04031B7B RID: 203643
			[FieldOffset(0)]
			public bool AutoPlay;
		}

		// Token: 0x0200A084 RID: 41092
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetInterval_FunctionParams
		{
			// Token: 0x04031B7C RID: 203644
			[FieldOffset(0)]
			public float Interval;
		}

		// Token: 0x0200A085 RID: 41093
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetTime_FunctionParams
		{
			// Token: 0x04031B7D RID: 203645
			[FieldOffset(0)]
			public float Time;
		}

		// Token: 0x0200A086 RID: 41094
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsGIValid_FunctionParams
		{
			// Token: 0x04031B7E RID: 203646
			[FieldOffset(0)]
			public bool IsValid;
		}

		// Token: 0x0200A087 RID: 41095
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04031B7F RID: 203647
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031B80 RID: 203648
			[FieldOffset(56)]
			public float InDeltaTime;
		}

		// Token: 0x0200A088 RID: 41096
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__BP_DebugGlobalGI_TextInput_Time_1_K2Node_ComponentBoundEvent_36_OnEditableTextChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031B81 RID: 203649
			[FieldOffset(0)]
			public byte Text;
		}
	}
}
