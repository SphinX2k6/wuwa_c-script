using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.UI.Module.Common.View.Widget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics
{
	// Token: 0x02003DC3 RID: 15811
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Statistics/WBP_EffectStatisticsVisualize.WBP_EffectStatisticsVisualize_C")]
	[UnrealStructLayout(1720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1720)]
	public class WBP_EffectStatisticsVisualize_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027514 RID: 161044 RVA: 0x0098E00E File Offset: 0x0098C20E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_EffectStatisticsVisualize_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Statistics/WBP_EffectStatisticsVisualize.WBP_EffectStatisticsVisualize_C");
			}
			return WBP_EffectStatisticsVisualize_C._ClassPtr;
		}

		// Token: 0x06027515 RID: 161045 RVA: 0x0098E034 File Offset: 0x0098C234
		public WBP_EffectStatisticsVisualize_C() : this(BuiltinUtils.AllocNativeUObject(WBP_EffectStatisticsVisualize_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027516 RID: 161046 RVA: 0x0098E05C File Offset: 0x0098C25C
		[NullableContext(1)]
		public WBP_EffectStatisticsVisualize_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_EffectStatisticsVisualize_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700576A RID: 22378
		// (get) Token: 0x06027517 RID: 161047 RVA: 0x0098E08F File Offset: 0x0098C28F
		// (set) Token: 0x06027518 RID: 161048 RVA: 0x0098E0A3 File Offset: 0x0098C2A3
		public unsafe KuroImage_C BG
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700576B RID: 22379
		// (get) Token: 0x06027519 RID: 161049 RVA: 0x0098E0B8 File Offset: 0x0098C2B8
		// (set) Token: 0x0602751A RID: 161050 RVA: 0x0098E0CC File Offset: 0x0098C2CC
		public unsafe UButton Button
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700576C RID: 22380
		// (get) Token: 0x0602751B RID: 161051 RVA: 0x0098E0E1 File Offset: 0x0098C2E1
		// (set) Token: 0x0602751C RID: 161052 RVA: 0x0098E0F5 File Offset: 0x0098C2F5
		public unsafe UButton Button_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700576D RID: 22381
		// (get) Token: 0x0602751D RID: 161053 RVA: 0x0098E10A File Offset: 0x0098C30A
		// (set) Token: 0x0602751E RID: 161054 RVA: 0x0098E11E File Offset: 0x0098C31E
		public unsafe UButton Button_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700576E RID: 22382
		// (get) Token: 0x0602751F RID: 161055 RVA: 0x0098E133 File Offset: 0x0098C333
		// (set) Token: 0x06027520 RID: 161056 RVA: 0x0098E147 File Offset: 0x0098C347
		public unsafe UButton Button_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700576F RID: 22383
		// (get) Token: 0x06027521 RID: 161057 RVA: 0x0098E15C File Offset: 0x0098C35C
		// (set) Token: 0x06027522 RID: 161058 RVA: 0x0098E170 File Offset: 0x0098C370
		public unsafe UButton Button_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005770 RID: 22384
		// (get) Token: 0x06027523 RID: 161059 RVA: 0x0098E185 File Offset: 0x0098C385
		// (set) Token: 0x06027524 RID: 161060 RVA: 0x0098E199 File Offset: 0x0098C399
		public unsafe UButton Button_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005771 RID: 22385
		// (get) Token: 0x06027525 RID: 161061 RVA: 0x0098E1AE File Offset: 0x0098C3AE
		// (set) Token: 0x06027526 RID: 161062 RVA: 0x0098E1C2 File Offset: 0x0098C3C2
		public unsafe UButton Button_7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005772 RID: 22386
		// (get) Token: 0x06027527 RID: 161063 RVA: 0x0098E1D7 File Offset: 0x0098C3D7
		// (set) Token: 0x06027528 RID: 161064 RVA: 0x0098E1EB File Offset: 0x0098C3EB
		public unsafe UButton Button_46
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005773 RID: 22387
		// (get) Token: 0x06027529 RID: 161065 RVA: 0x0098E200 File Offset: 0x0098C400
		// (set) Token: 0x0602752A RID: 161066 RVA: 0x0098E214 File Offset: 0x0098C414
		public unsafe UComboBoxString ComboBoxString
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005774 RID: 22388
		// (get) Token: 0x0602752B RID: 161067 RVA: 0x0098E229 File Offset: 0x0098C429
		// (set) Token: 0x0602752C RID: 161068 RVA: 0x0098E23D File Offset: 0x0098C43D
		public unsafe UComboBoxString ComboBoxString_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005775 RID: 22389
		// (get) Token: 0x0602752D RID: 161069 RVA: 0x0098E252 File Offset: 0x0098C452
		// (set) Token: 0x0602752E RID: 161070 RVA: 0x0098E266 File Offset: 0x0098C466
		public unsafe UComboBoxString ComboBoxString_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005776 RID: 22390
		// (get) Token: 0x0602752F RID: 161071 RVA: 0x0098E27B File Offset: 0x0098C47B
		// (set) Token: 0x06027530 RID: 161072 RVA: 0x0098E28F File Offset: 0x0098C48F
		public unsafe UListView List
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UListView>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005777 RID: 22391
		// (get) Token: 0x06027531 RID: 161073 RVA: 0x0098E2A4 File Offset: 0x0098C4A4
		// (set) Token: 0x06027532 RID: 161074 RVA: 0x0098E2B8 File Offset: 0x0098C4B8
		public unsafe UTextBlock TextBlock_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005778 RID: 22392
		// (get) Token: 0x06027533 RID: 161075 RVA: 0x0098E2CD File Offset: 0x0098C4CD
		// (set) Token: 0x06027534 RID: 161076 RVA: 0x0098E2E1 File Offset: 0x0098C4E1
		public unsafe UTextBlock TextBlock_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005779 RID: 22393
		// (get) Token: 0x06027535 RID: 161077 RVA: 0x0098E2F6 File Offset: 0x0098C4F6
		// (set) Token: 0x06027536 RID: 161078 RVA: 0x0098E30A File Offset: 0x0098C50A
		public unsafe UTextBlock TextBlock_7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700577A RID: 22394
		// (get) Token: 0x06027537 RID: 161079 RVA: 0x0098E31F File Offset: 0x0098C51F
		// (set) Token: 0x06027538 RID: 161080 RVA: 0x0098E333 File Offset: 0x0098C533
		public unsafe UTextBlock TextBlock_8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700577B RID: 22395
		// (get) Token: 0x06027539 RID: 161081 RVA: 0x0098E348 File Offset: 0x0098C548
		// (set) Token: 0x0602753A RID: 161082 RVA: 0x0098E35C File Offset: 0x0098C55C
		public unsafe UTextBlock TextBlock_15
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700577C RID: 22396
		// (get) Token: 0x0602753B RID: 161083 RVA: 0x0098E371 File Offset: 0x0098C571
		// (set) Token: 0x0602753C RID: 161084 RVA: 0x0098E385 File Offset: 0x0098C585
		public unsafe KuroImage_C TitleBG
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700577D RID: 22397
		// (get) Token: 0x0602753D RID: 161085 RVA: 0x0098E39A File Offset: 0x0098C59A
		// (set) Token: 0x0602753E RID: 161086 RVA: 0x0098E3AE File Offset: 0x0098C5AE
		public unsafe UWidgetSwitcher WidgetSwitcher_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetSwitcher>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_EffectStatisticsVisualize_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x1700577E RID: 22398
		// (get) Token: 0x0602753F RID: 161087 RVA: 0x0098E3C3 File Offset: 0x0098C5C3
		// (set) Token: 0x06027540 RID: 161088 RVA: 0x0098E3D3 File Offset: 0x0098C5D3
		public unsafe float RefreshCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700577F RID: 22399
		// (get) Token: 0x06027541 RID: 161089 RVA: 0x0098E3E4 File Offset: 0x0098C5E4
		// (set) Token: 0x06027542 RID: 161090 RVA: 0x0098E3F4 File Offset: 0x0098C5F4
		public unsafe float RefreshInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005780 RID: 22400
		// (get) Token: 0x06027543 RID: 161091 RVA: 0x0098E405 File Offset: 0x0098C605
		// (set) Token: 0x06027544 RID: 161092 RVA: 0x0098E415 File Offset: 0x0098C615
		public unsafe int CurrentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005781 RID: 22401
		// (get) Token: 0x06027545 RID: 161093 RVA: 0x0098E426 File Offset: 0x0098C626
		// (set) Token: 0x06027546 RID: 161094 RVA: 0x0098E436 File Offset: 0x0098C636
		public unsafe int TickCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005782 RID: 22402
		// (get) Token: 0x06027547 RID: 161095 RVA: 0x0098E447 File Offset: 0x0098C647
		// (set) Token: 0x06027548 RID: 161096 RVA: 0x0098E457 File Offset: 0x0098C657
		public unsafe int RegisteredInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005783 RID: 22403
		// (get) Token: 0x06027549 RID: 161097 RVA: 0x0098E468 File Offset: 0x0098C668
		// (set) Token: 0x0602754A RID: 161098 RVA: 0x0098E478 File Offset: 0x0098C678
		public unsafe int ReleasedInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005784 RID: 22404
		// (get) Token: 0x0602754B RID: 161099 RVA: 0x0098E489 File Offset: 0x0098C689
		// (set) Token: 0x0602754C RID: 161100 RVA: 0x0098E49D File Offset: 0x0098C69D
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectStatisticsSortType> SortType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_26);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005785 RID: 22405
		// (get) Token: 0x0602754D RID: 161101 RVA: 0x0098E4B2 File Offset: 0x0098C6B2
		// (set) Token: 0x0602754E RID: 161102 RVA: 0x0098E4C2 File Offset: 0x0098C6C2
		public unsafe bool Ascending
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005786 RID: 22406
		// (get) Token: 0x0602754F RID: 161103 RVA: 0x0098E4D3 File Offset: 0x0098C6D3
		// (set) Token: 0x06027550 RID: 161104 RVA: 0x0098E4E3 File Offset: 0x0098C6E3
		public unsafe int TempIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17005787 RID: 22407
		// (get) Token: 0x06027551 RID: 161105 RVA: 0x0098E4F4 File Offset: 0x0098C6F4
		// (set) Token: 0x06027552 RID: 161106 RVA: 0x0098E504 File Offset: 0x0098C704
		public unsafe int FactoryFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17005788 RID: 22408
		// (get) Token: 0x06027553 RID: 161107 RVA: 0x0098E515 File Offset: 0x0098C715
		// (set) Token: 0x06027554 RID: 161108 RVA: 0x0098E525 File Offset: 0x0098C725
		public unsafe int CheckTypeFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17005789 RID: 22409
		// (get) Token: 0x06027555 RID: 161109 RVA: 0x0098E536 File Offset: 0x0098C736
		// (set) Token: 0x06027556 RID: 161110 RVA: 0x0098E546 File Offset: 0x0098C746
		public unsafe int ListLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700578A RID: 22410
		// (get) Token: 0x06027557 RID: 161111 RVA: 0x0098E557 File Offset: 0x0098C757
		// (set) Token: 0x06027558 RID: 161112 RVA: 0x0098E567 File Offset: 0x0098C767
		public unsafe int NiagaraStatisticsCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700578B RID: 22411
		// (get) Token: 0x06027559 RID: 161113 RVA: 0x0098E578 File Offset: 0x0098C778
		// (set) Token: 0x0602755A RID: 161114 RVA: 0x0098E588 File Offset: 0x0098C788
		public unsafe int Content
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700578C RID: 22412
		// (get) Token: 0x0602755B RID: 161115 RVA: 0x0098E59C File Offset: 0x0098C79C
		// (set) Token: 0x0602755C RID: 161116 RVA: 0x0098E5D5 File Offset: 0x0098C7D5
		[Nullable(1)]
		public FNiagaraDebugHUDSettingsData NiagaraDebugSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNiagaraDebugHUDSettingsData result;
				if ((result = this._NiagaraDebugSettings) == null)
				{
					result = (this._NiagaraDebugSettings = new FNiagaraDebugHUDSettingsData(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_34, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDebugHUDSettingsData.StaticStruct(), base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_34, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700578D RID: 22413
		// (get) Token: 0x0602755D RID: 161117 RVA: 0x0098E5F6 File Offset: 0x0098C7F6
		// (set) Token: 0x0602755E RID: 161118 RVA: 0x0098E606 File Offset: 0x0098C806
		public unsafe int TotalNiagaraSystems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x1700578E RID: 22414
		// (get) Token: 0x0602755F RID: 161119 RVA: 0x0098E617 File Offset: 0x0098C817
		// (set) Token: 0x06027560 RID: 161120 RVA: 0x0098E627 File Offset: 0x0098C827
		public unsafe int TotalNiagaraParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700578F RID: 22415
		// (get) Token: 0x06027561 RID: 161121 RVA: 0x0098E638 File Offset: 0x0098C838
		// (set) Token: 0x06027562 RID: 161122 RVA: 0x0098E648 File Offset: 0x0098C848
		public unsafe int TotalNiagaraEmitters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17005790 RID: 22416
		// (get) Token: 0x06027563 RID: 161123 RVA: 0x0098E659 File Offset: 0x0098C859
		// (set) Token: 0x06027564 RID: 161124 RVA: 0x0098E669 File Offset: 0x0098C869
		public unsafe int TotalNiagaraMemoryUsage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17005791 RID: 22417
		// (get) Token: 0x06027565 RID: 161125 RVA: 0x0098E67A File Offset: 0x0098C87A
		// (set) Token: 0x06027566 RID: 161126 RVA: 0x0098E68A File Offset: 0x0098C88A
		public unsafe int TotalNiagaraCulled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17005792 RID: 22418
		// (get) Token: 0x06027567 RID: 161127 RVA: 0x0098E69C File Offset: 0x0098C89C
		// (set) Token: 0x06027568 RID: 161128 RVA: 0x0098E6D5 File Offset: 0x0098C8D5
		[Nullable(1)]
		public SCharacterBodySpecifiedStruct NewVar_0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCharacterBodySpecifiedStruct result;
				if ((result = this._NewVar_0) == null)
				{
					result = (this._NewVar_0 = new SCharacterBodySpecifiedStruct(base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_40, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCharacterBodySpecifiedStruct.StaticStruct(), base.NativePtr + (IntPtr)WBP_EffectStatisticsVisualize_C.__PropertyOffset_40, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027569 RID: 161129 RVA: 0x0098E6F6 File Offset: 0x0098C8F6
		protected WBP_EffectStatisticsVisualize_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013D7D RID: 81277
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Statistics/WBP_EffectStatisticsVisualize.WBP_EffectStatisticsVisualize_C";

		// Token: 0x04013D7E RID: 81278
		private static IntPtr _ClassPtr;

		// Token: 0x04013D7F RID: 81279
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013D80 RID: 81280
		internal static int __PropertyOffset_0;

		// Token: 0x04013D81 RID: 81281
		internal static int __PropertyOffset_1;

		// Token: 0x04013D82 RID: 81282
		internal static int __PropertyOffset_2;

		// Token: 0x04013D83 RID: 81283
		internal static int __PropertyOffset_3;

		// Token: 0x04013D84 RID: 81284
		internal static int __PropertyOffset_4;

		// Token: 0x04013D85 RID: 81285
		internal static int __PropertyOffset_5;

		// Token: 0x04013D86 RID: 81286
		internal static int __PropertyOffset_6;

		// Token: 0x04013D87 RID: 81287
		internal static int __PropertyOffset_7;

		// Token: 0x04013D88 RID: 81288
		internal static int __PropertyOffset_8;

		// Token: 0x04013D89 RID: 81289
		internal static int __PropertyOffset_9;

		// Token: 0x04013D8A RID: 81290
		internal static int __PropertyOffset_10;

		// Token: 0x04013D8B RID: 81291
		internal static int __PropertyOffset_11;

		// Token: 0x04013D8C RID: 81292
		internal static int __PropertyOffset_12;

		// Token: 0x04013D8D RID: 81293
		internal static int __PropertyOffset_13;

		// Token: 0x04013D8E RID: 81294
		internal static int __PropertyOffset_14;

		// Token: 0x04013D8F RID: 81295
		internal static int __PropertyOffset_15;

		// Token: 0x04013D90 RID: 81296
		internal static int __PropertyOffset_16;

		// Token: 0x04013D91 RID: 81297
		internal static int __PropertyOffset_17;

		// Token: 0x04013D92 RID: 81298
		internal static int __PropertyOffset_18;

		// Token: 0x04013D93 RID: 81299
		internal static int __PropertyOffset_19;

		// Token: 0x04013D94 RID: 81300
		internal static int __PropertyOffset_20;

		// Token: 0x04013D95 RID: 81301
		internal static int __PropertyOffset_21;

		// Token: 0x04013D96 RID: 81302
		internal static int __PropertyOffset_22;

		// Token: 0x04013D97 RID: 81303
		internal static int __PropertyOffset_23;

		// Token: 0x04013D98 RID: 81304
		internal static int __PropertyOffset_24;

		// Token: 0x04013D99 RID: 81305
		internal static int __PropertyOffset_25;

		// Token: 0x04013D9A RID: 81306
		internal static int __PropertyOffset_26;

		// Token: 0x04013D9B RID: 81307
		internal static int __PropertyOffset_27;

		// Token: 0x04013D9C RID: 81308
		internal static int __PropertyOffset_28;

		// Token: 0x04013D9D RID: 81309
		internal static int __PropertyOffset_29;

		// Token: 0x04013D9E RID: 81310
		internal static int __PropertyOffset_30;

		// Token: 0x04013D9F RID: 81311
		internal static int __PropertyOffset_31;

		// Token: 0x04013DA0 RID: 81312
		internal static int __PropertyOffset_32;

		// Token: 0x04013DA1 RID: 81313
		internal static int __PropertyOffset_33;

		// Token: 0x04013DA2 RID: 81314
		internal static int __PropertyOffset_34;

		// Token: 0x04013DA3 RID: 81315
		private FNiagaraDebugHUDSettingsData _NiagaraDebugSettings;

		// Token: 0x04013DA4 RID: 81316
		internal static int __PropertyOffset_35;

		// Token: 0x04013DA5 RID: 81317
		internal static int __PropertyOffset_36;

		// Token: 0x04013DA6 RID: 81318
		internal static int __PropertyOffset_37;

		// Token: 0x04013DA7 RID: 81319
		internal static int __PropertyOffset_38;

		// Token: 0x04013DA8 RID: 81320
		internal static int __PropertyOffset_39;

		// Token: 0x04013DA9 RID: 81321
		internal static int __PropertyOffset_40;

		// Token: 0x04013DAA RID: 81322
		private SCharacterBodySpecifiedStruct _NewVar_0;
	}
}
