using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EDA RID: 16090
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_ContinuousClick.SCommonQte_ContinuousClick")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 228)]
	public class SCommonQte_ContinuousClick : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028B1B RID: 166683 RVA: 0x009B279C File Offset: 0x009B099C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_ContinuousClick._ScriptStructPtr != 0) ? SCommonQte_ContinuousClick._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_ContinuousClick.SCommonQte_ContinuousClick", ref SCommonQte_ContinuousClick._ScriptStructPtr);
		}

		// Token: 0x17005F23 RID: 24355
		// (get) Token: 0x06028B1C RID: 166684 RVA: 0x009B27C0 File Offset: 0x009B09C0
		// (set) Token: 0x06028B1D RID: 166685 RVA: 0x009B27D4 File Offset: 0x009B09D4
		public unsafe TEnumAsByte<ECommonQteViewType_SingleButtonContinuousClick> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x06028B1E RID: 166686 RVA: 0x009B27EC File Offset: 0x009B09EC
		// (set) Token: 0x06028B1F RID: 166687 RVA: 0x009B282F File Offset: 0x009B0A2F
		[Nullable(1)]
		public SCommonQteButton UIConfig
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCommonQteButton result;
				if ((result = this._UIConfig) == null)
				{
					result = (this._UIConfig = new SCommonQteButton(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQteButton.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x06028B20 RID: 166688 RVA: 0x009B2850 File Offset: 0x009B0A50
		// (set) Token: 0x06028B21 RID: 166689 RVA: 0x009B2864 File Offset: 0x009B0A64
		public unsafe TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x06028B22 RID: 166690 RVA: 0x009B2879 File Offset: 0x009B0A79
		// (set) Token: 0x06028B23 RID: 166691 RVA: 0x009B2889 File Offset: 0x009B0A89
		public unsafe bool IsShowBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x06028B24 RID: 166692 RVA: 0x009B289A File Offset: 0x009B0A9A
		// (set) Token: 0x06028B25 RID: 166693 RVA: 0x009B28AA File Offset: 0x009B0AAA
		public unsafe bool IsShowTip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x06028B26 RID: 166694 RVA: 0x009B28BB File Offset: 0x009B0ABB
		// (set) Token: 0x06028B27 RID: 166695 RVA: 0x009B28CF File Offset: 0x009B0ACF
		[Nullable(1)]
		public unsafe string TipTextId
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_5)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x06028B28 RID: 166696 RVA: 0x009B28E4 File Offset: 0x009B0AE4
		// (set) Token: 0x06028B29 RID: 166697 RVA: 0x009B28F4 File Offset: 0x009B0AF4
		public unsafe float InitialEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x06028B2A RID: 166698 RVA: 0x009B2905 File Offset: 0x009B0B05
		// (set) Token: 0x06028B2B RID: 166699 RVA: 0x009B2915 File Offset: 0x009B0B15
		public unsafe float TargetEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x06028B2C RID: 166700 RVA: 0x009B2926 File Offset: 0x009B0B26
		// (set) Token: 0x06028B2D RID: 166701 RVA: 0x009B2936 File Offset: 0x009B0B36
		public unsafe float DeltaEnergyPercentPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005F2C RID: 24364
		// (get) Token: 0x06028B2E RID: 166702 RVA: 0x009B2947 File Offset: 0x009B0B47
		// (set) Token: 0x06028B2F RID: 166703 RVA: 0x009B2957 File Offset: 0x009B0B57
		public unsafe float DeltaEnergyPercentPerClick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x06028B30 RID: 166704 RVA: 0x009B2968 File Offset: 0x009B0B68
		// (set) Token: 0x06028B31 RID: 166705 RVA: 0x009B2978 File Offset: 0x009B0B78
		public unsafe float PerformInterpSpeedForEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x06028B32 RID: 166706 RVA: 0x009B2989 File Offset: 0x009B0B89
		// (set) Token: 0x06028B33 RID: 166707 RVA: 0x009B2999 File Offset: 0x009B0B99
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x06028B34 RID: 166708 RVA: 0x009B29AA File Offset: 0x009B0BAA
		// (set) Token: 0x06028B35 RID: 166709 RVA: 0x009B29BE File Offset: 0x009B0BBE
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x06028B36 RID: 166710 RVA: 0x009B29D3 File Offset: 0x009B0BD3
		// (set) Token: 0x06028B37 RID: 166711 RVA: 0x009B29E3 File Offset: 0x009B0BE3
		public unsafe bool HideProgressBar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x06028B38 RID: 166712 RVA: 0x009B29F4 File Offset: 0x009B0BF4
		// (set) Token: 0x06028B39 RID: 166713 RVA: 0x009B2A04 File Offset: 0x009B0C04
		public unsafe bool ProgressOnBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x06028B3A RID: 166714 RVA: 0x009B2A15 File Offset: 0x009B0C15
		// (set) Token: 0x06028B3B RID: 166715 RVA: 0x009B2A25 File Offset: 0x009B0C25
		public unsafe float MaxComboInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x06028B3C RID: 166716 RVA: 0x009B2A36 File Offset: 0x009B0C36
		// (set) Token: 0x06028B3D RID: 166717 RVA: 0x009B2A46 File Offset: 0x009B0C46
		public unsafe float InterpSpeedForEnergyPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_ContinuousClick.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06028B3E RID: 166718 RVA: 0x009B2A57 File Offset: 0x009B0C57
		public SCommonQte_ContinuousClick()
		{
		}

		// Token: 0x06028B3F RID: 166719 RVA: 0x009B2A60 File Offset: 0x009B0C60
		public SCommonQte_ContinuousClick(TEnumAsByte<ECommonQteViewType_SingleButtonContinuousClick> ViewType, [Nullable(1)] SCommonQteButton UIConfig, TEnumAsByte<ECommonQteInteractiveTiming> InteractiveTiming, bool IsShowBorder, bool IsShowTip, [Nullable(1)] string TipTextId, float InitialEnergyPercent, float TargetEnergyPercent, float DeltaEnergyPercentPerSecond, float DeltaEnergyPercentPerClick, float PerformInterpSpeedForEnergyPercent, bool IsAttachToActor, SCommonQte_Attach AttachConfig, bool HideProgressBar, bool ProgressOnBegin, float MaxComboInterval, float InterpSpeedForEnergyPercent)
		{
			this.ViewType = ViewType;
			this.UIConfig = UIConfig;
			this.InteractiveTiming = InteractiveTiming;
			this.IsShowBorder = IsShowBorder;
			this.IsShowTip = IsShowTip;
			this.TipTextId = TipTextId;
			this.InitialEnergyPercent = InitialEnergyPercent;
			this.TargetEnergyPercent = TargetEnergyPercent;
			this.DeltaEnergyPercentPerSecond = DeltaEnergyPercentPerSecond;
			this.DeltaEnergyPercentPerClick = DeltaEnergyPercentPerClick;
			this.PerformInterpSpeedForEnergyPercent = PerformInterpSpeedForEnergyPercent;
			this.IsAttachToActor = IsAttachToActor;
			this.AttachConfig = AttachConfig;
			this.HideProgressBar = HideProgressBar;
			this.ProgressOnBegin = ProgressOnBegin;
			this.MaxComboInterval = MaxComboInterval;
			this.InterpSpeedForEnergyPercent = InterpSpeedForEnergyPercent;
		}

		// Token: 0x06028B40 RID: 166720 RVA: 0x009B2AF8 File Offset: 0x009B0CF8
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_ContinuousClick.StaticStruct();
		}

		// Token: 0x06028B41 RID: 166721 RVA: 0x009B2B04 File Offset: 0x009B0D04
		[NullableContext(2)]
		public SCommonQte_ContinuousClick(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028B42 RID: 166722 RVA: 0x009B2B0E File Offset: 0x009B0D0E
		public SCommonQte_ContinuousClick(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028B43 RID: 166723 RVA: 0x009B2B19 File Offset: 0x009B0D19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_ContinuousClick(Pointer, false, true);
		}

		// Token: 0x06028B44 RID: 166724 RVA: 0x009B2B23 File Offset: 0x009B0D23
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_ContinuousClick(Pointer, MemoryOwner);
		}

		// Token: 0x04014CD1 RID: 85201
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_ContinuousClick.SCommonQte_ContinuousClick";

		// Token: 0x04014CD2 RID: 85202
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CD3 RID: 85203
		internal static int __PropertyOffset_0;

		// Token: 0x04014CD4 RID: 85204
		internal static int __PropertyOffset_1;

		// Token: 0x04014CD5 RID: 85205
		[Nullable(2)]
		private SCommonQteButton _UIConfig;

		// Token: 0x04014CD6 RID: 85206
		internal static int __PropertyOffset_2;

		// Token: 0x04014CD7 RID: 85207
		internal static int __PropertyOffset_3;

		// Token: 0x04014CD8 RID: 85208
		internal static int __PropertyOffset_4;

		// Token: 0x04014CD9 RID: 85209
		internal static int __PropertyOffset_5;

		// Token: 0x04014CDA RID: 85210
		internal static int __PropertyOffset_6;

		// Token: 0x04014CDB RID: 85211
		internal static int __PropertyOffset_7;

		// Token: 0x04014CDC RID: 85212
		internal static int __PropertyOffset_8;

		// Token: 0x04014CDD RID: 85213
		internal static int __PropertyOffset_9;

		// Token: 0x04014CDE RID: 85214
		internal static int __PropertyOffset_10;

		// Token: 0x04014CDF RID: 85215
		internal static int __PropertyOffset_11;

		// Token: 0x04014CE0 RID: 85216
		internal static int __PropertyOffset_12;

		// Token: 0x04014CE1 RID: 85217
		internal static int __PropertyOffset_13;

		// Token: 0x04014CE2 RID: 85218
		internal static int __PropertyOffset_14;

		// Token: 0x04014CE3 RID: 85219
		internal static int __PropertyOffset_15;

		// Token: 0x04014CE4 RID: 85220
		internal static int __PropertyOffset_16;
	}
}
