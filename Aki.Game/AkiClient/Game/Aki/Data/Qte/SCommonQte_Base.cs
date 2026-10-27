using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED9 RID: 16089
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Base.SCommonQte_Base")]
	[UnrealStructLayout(976, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 976)]
	public class SCommonQte_Base : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028B01 RID: 166657 RVA: 0x009B2464 File Offset: 0x009B0664
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Base._ScriptStructPtr != 0) ? SCommonQte_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Base.SCommonQte_Base", ref SCommonQte_Base._ScriptStructPtr);
		}

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x06028B02 RID: 166658 RVA: 0x009B2488 File Offset: 0x009B0688
		// (set) Token: 0x06028B03 RID: 166659 RVA: 0x009B249C File Offset: 0x009B069C
		[Nullable(0)]
		public unsafe TEnumAsByte<ECommonQteType> QteType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x06028B04 RID: 166660 RVA: 0x009B24B1 File Offset: 0x009B06B1
		// (set) Token: 0x06028B05 RID: 166661 RVA: 0x009B24C1 File Offset: 0x009B06C1
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x06028B06 RID: 166662 RVA: 0x009B24D2 File Offset: 0x009B06D2
		// (set) Token: 0x06028B07 RID: 166663 RVA: 0x009B24E2 File Offset: 0x009B06E2
		public unsafe float LeastDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x06028B08 RID: 166664 RVA: 0x009B24F3 File Offset: 0x009B06F3
		// (set) Token: 0x06028B09 RID: 166665 RVA: 0x009B2503 File Offset: 0x009B0703
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x06028B0A RID: 166666 RVA: 0x009B2514 File Offset: 0x009B0714
		// (set) Token: 0x06028B0B RID: 166667 RVA: 0x009B2557 File Offset: 0x009B0757
		public SCommonQte_SingleClick SingleClickConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_SingleClick result;
				if ((result = this._SingleClickConfig) == null)
				{
					result = (this._SingleClickConfig = new SCommonQte_SingleClick(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_SingleClick.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x06028B0C RID: 166668 RVA: 0x009B2578 File Offset: 0x009B0778
		// (set) Token: 0x06028B0D RID: 166669 RVA: 0x009B25BB File Offset: 0x009B07BB
		public SCommonQte_ContinuousClick ContinuousClickConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_ContinuousClick result;
				if ((result = this._ContinuousClickConfig) == null)
				{
					result = (this._ContinuousClickConfig = new SCommonQte_ContinuousClick(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_ContinuousClick.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x06028B0E RID: 166670 RVA: 0x009B25DC File Offset: 0x009B07DC
		// (set) Token: 0x06028B0F RID: 166671 RVA: 0x009B261F File Offset: 0x009B081F
		public SCommonQte_Drag DragConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Drag result;
				if ((result = this._DragConfig) == null)
				{
					result = (this._DragConfig = new SCommonQte_Drag(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Drag.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x06028B10 RID: 166672 RVA: 0x009B2640 File Offset: 0x009B0840
		// (set) Token: 0x06028B11 RID: 166673 RVA: 0x009B2683 File Offset: 0x009B0883
		public SCommonQte_LongPress LongPressConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_LongPress result;
				if ((result = this._LongPressConfig) == null)
				{
					result = (this._LongPressConfig = new SCommonQte_LongPress(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_LongPress.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F22 RID: 24354
		// (get) Token: 0x06028B12 RID: 166674 RVA: 0x009B26A4 File Offset: 0x009B08A4
		// (set) Token: 0x06028B13 RID: 166675 RVA: 0x009B26E7 File Offset: 0x009B08E7
		public SCommonQte_SelectOption SelectOptionConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_SelectOption result;
				if ((result = this._SelectOptionConfig) == null)
				{
					result = (this._SelectOptionConfig = new SCommonQte_SelectOption(base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_SelectOption.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_Base.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06028B14 RID: 166676 RVA: 0x009B2708 File Offset: 0x009B0908
		public SCommonQte_Base()
		{
		}

		// Token: 0x06028B15 RID: 166677 RVA: 0x009B2710 File Offset: 0x009B0910
		public SCommonQte_Base([Nullable(0)] TEnumAsByte<ECommonQteType> QteType, float Duration, float LeastDuration, float TimeDilation, SCommonQte_SingleClick SingleClickConfig, SCommonQte_ContinuousClick ContinuousClickConfig, SCommonQte_Drag DragConfig, SCommonQte_LongPress LongPressConfig, SCommonQte_SelectOption SelectOptionConfig)
		{
			this.QteType = QteType;
			this.Duration = Duration;
			this.LeastDuration = LeastDuration;
			this.TimeDilation = TimeDilation;
			this.SingleClickConfig = SingleClickConfig;
			this.ContinuousClickConfig = ContinuousClickConfig;
			this.DragConfig = DragConfig;
			this.LongPressConfig = LongPressConfig;
			this.SelectOptionConfig = SelectOptionConfig;
		}

		// Token: 0x06028B16 RID: 166678 RVA: 0x009B2768 File Offset: 0x009B0968
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Base.StaticStruct();
		}

		// Token: 0x06028B17 RID: 166679 RVA: 0x009B2774 File Offset: 0x009B0974
		[NullableContext(2)]
		public SCommonQte_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028B18 RID: 166680 RVA: 0x009B277E File Offset: 0x009B097E
		public SCommonQte_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028B19 RID: 166681 RVA: 0x009B2789 File Offset: 0x009B0989
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Base(Pointer, false, true);
		}

		// Token: 0x06028B1A RID: 166682 RVA: 0x009B2793 File Offset: 0x009B0993
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Base(Pointer, MemoryOwner);
		}

		// Token: 0x04014CC1 RID: 85185
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Base.SCommonQte_Base";

		// Token: 0x04014CC2 RID: 85186
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CC3 RID: 85187
		internal static int __PropertyOffset_0;

		// Token: 0x04014CC4 RID: 85188
		internal static int __PropertyOffset_1;

		// Token: 0x04014CC5 RID: 85189
		internal static int __PropertyOffset_2;

		// Token: 0x04014CC6 RID: 85190
		internal static int __PropertyOffset_3;

		// Token: 0x04014CC7 RID: 85191
		internal static int __PropertyOffset_4;

		// Token: 0x04014CC8 RID: 85192
		[Nullable(2)]
		private SCommonQte_SingleClick _SingleClickConfig;

		// Token: 0x04014CC9 RID: 85193
		internal static int __PropertyOffset_5;

		// Token: 0x04014CCA RID: 85194
		[Nullable(2)]
		private SCommonQte_ContinuousClick _ContinuousClickConfig;

		// Token: 0x04014CCB RID: 85195
		internal static int __PropertyOffset_6;

		// Token: 0x04014CCC RID: 85196
		[Nullable(2)]
		private SCommonQte_Drag _DragConfig;

		// Token: 0x04014CCD RID: 85197
		internal static int __PropertyOffset_7;

		// Token: 0x04014CCE RID: 85198
		[Nullable(2)]
		private SCommonQte_LongPress _LongPressConfig;

		// Token: 0x04014CCF RID: 85199
		internal static int __PropertyOffset_8;

		// Token: 0x04014CD0 RID: 85200
		[Nullable(2)]
		private SCommonQte_SelectOption _SelectOptionConfig;
	}
}
