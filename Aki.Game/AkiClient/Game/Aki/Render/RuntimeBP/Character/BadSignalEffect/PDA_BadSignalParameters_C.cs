using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.BadSignalEffect
{
	// Token: 0x02003E31 RID: 15921
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/BadSignalEffect/PDA_BadSignalParameters.PDA_BadSignalParameters_C")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class PDA_BadSignalParameters_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F16 RID: 163606 RVA: 0x009A01A3 File Offset: 0x0099E3A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_BadSignalParameters_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/BadSignalEffect/PDA_BadSignalParameters.PDA_BadSignalParameters_C");
			}
			return PDA_BadSignalParameters_C._ClassPtr;
		}

		// Token: 0x06027F17 RID: 163607 RVA: 0x009A01C8 File Offset: 0x0099E3C8
		public PDA_BadSignalParameters_C() : this(BuiltinUtils.AllocNativeUObject(PDA_BadSignalParameters_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F18 RID: 163608 RVA: 0x009A01F0 File Offset: 0x0099E3F0
		[NullableContext(1)]
		public PDA_BadSignalParameters_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_BadSignalParameters_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005ADC RID: 23260
		// (get) Token: 0x06027F19 RID: 163609 RVA: 0x009A0223 File Offset: 0x0099E423
		// (set) Token: 0x06027F1A RID: 163610 RVA: 0x009A0233 File Offset: 0x0099E433
		public unsafe float SignalBiasStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005ADD RID: 23261
		// (get) Token: 0x06027F1B RID: 163611 RVA: 0x009A0244 File Offset: 0x0099E444
		// (set) Token: 0x06027F1C RID: 163612 RVA: 0x009A0254 File Offset: 0x0099E454
		public unsafe float SignalBiasDirectionRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005ADE RID: 23262
		// (get) Token: 0x06027F1D RID: 163613 RVA: 0x009A0265 File Offset: 0x0099E465
		// (set) Token: 0x06027F1E RID: 163614 RVA: 0x009A0275 File Offset: 0x0099E475
		public unsafe float SignalBiasStrengthWiggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005ADF RID: 23263
		// (get) Token: 0x06027F1F RID: 163615 RVA: 0x009A0286 File Offset: 0x0099E486
		// (set) Token: 0x06027F20 RID: 163616 RVA: 0x009A0296 File Offset: 0x0099E496
		public unsafe float SignalBiasStrengthWiggleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005AE0 RID: 23264
		// (get) Token: 0x06027F21 RID: 163617 RVA: 0x009A02A7 File Offset: 0x0099E4A7
		// (set) Token: 0x06027F22 RID: 163618 RVA: 0x009A02B7 File Offset: 0x0099E4B7
		public unsafe float SignalBiasSubWiggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005AE1 RID: 23265
		// (get) Token: 0x06027F23 RID: 163619 RVA: 0x009A02C8 File Offset: 0x0099E4C8
		// (set) Token: 0x06027F24 RID: 163620 RVA: 0x009A02D8 File Offset: 0x0099E4D8
		public unsafe float SignalExplodeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005AE2 RID: 23266
		// (get) Token: 0x06027F25 RID: 163621 RVA: 0x009A02E9 File Offset: 0x0099E4E9
		// (set) Token: 0x06027F26 RID: 163622 RVA: 0x009A02F9 File Offset: 0x0099E4F9
		public unsafe float SignalExplodeHoldMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005AE3 RID: 23267
		// (get) Token: 0x06027F27 RID: 163623 RVA: 0x009A030A File Offset: 0x0099E50A
		// (set) Token: 0x06027F28 RID: 163624 RVA: 0x009A031A File Offset: 0x0099E51A
		public unsafe float SignalExplodeHoldMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005AE4 RID: 23268
		// (get) Token: 0x06027F29 RID: 163625 RVA: 0x009A032B File Offset: 0x0099E52B
		// (set) Token: 0x06027F2A RID: 163626 RVA: 0x009A033B File Offset: 0x0099E53B
		public unsafe float SignalBiasExplodeStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005AE5 RID: 23269
		// (get) Token: 0x06027F2B RID: 163627 RVA: 0x009A034C File Offset: 0x0099E54C
		// (set) Token: 0x06027F2C RID: 163628 RVA: 0x009A035C File Offset: 0x0099E55C
		public unsafe float SignalBiasExplodeSubWiggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005AE6 RID: 23270
		// (get) Token: 0x06027F2D RID: 163629 RVA: 0x009A036D File Offset: 0x0099E56D
		// (set) Token: 0x06027F2E RID: 163630 RVA: 0x009A037D File Offset: 0x0099E57D
		public unsafe float SignalExplodeAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005AE7 RID: 23271
		// (get) Token: 0x06027F2F RID: 163631 RVA: 0x009A038E File Offset: 0x0099E58E
		// (set) Token: 0x06027F30 RID: 163632 RVA: 0x009A039E File Offset: 0x0099E59E
		public unsafe float RimRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005AE8 RID: 23272
		// (get) Token: 0x06027F31 RID: 163633 RVA: 0x009A03AF File Offset: 0x0099E5AF
		// (set) Token: 0x06027F32 RID: 163634 RVA: 0x009A03C3 File Offset: 0x0099E5C3
		public unsafe FLinearColor RimColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005AE9 RID: 23273
		// (get) Token: 0x06027F33 RID: 163635 RVA: 0x009A03D8 File Offset: 0x0099E5D8
		// (set) Token: 0x06027F34 RID: 163636 RVA: 0x009A03E8 File Offset: 0x0099E5E8
		public unsafe float OutlineWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005AEA RID: 23274
		// (get) Token: 0x06027F35 RID: 163637 RVA: 0x009A03F9 File Offset: 0x0099E5F9
		// (set) Token: 0x06027F36 RID: 163638 RVA: 0x009A040D File Offset: 0x0099E60D
		public unsafe FLinearColor OutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005AEB RID: 23275
		// (get) Token: 0x06027F37 RID: 163639 RVA: 0x009A0422 File Offset: 0x0099E622
		// (set) Token: 0x06027F38 RID: 163640 RVA: 0x009A0436 File Offset: 0x0099E636
		public unsafe FLinearColor MainTexColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005AEC RID: 23276
		// (get) Token: 0x06027F39 RID: 163641 RVA: 0x009A044B File Offset: 0x0099E64B
		// (set) Token: 0x06027F3A RID: 163642 RVA: 0x009A045B File Offset: 0x0099E65B
		public unsafe float StripMaskProportionSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005AED RID: 23277
		// (get) Token: 0x06027F3B RID: 163643 RVA: 0x009A046C File Offset: 0x0099E66C
		// (set) Token: 0x06027F3C RID: 163644 RVA: 0x009A047C File Offset: 0x0099E67C
		public unsafe float StripMaskProportionCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005AEE RID: 23278
		// (get) Token: 0x06027F3D RID: 163645 RVA: 0x009A048D File Offset: 0x0099E68D
		// (set) Token: 0x06027F3E RID: 163646 RVA: 0x009A049D File Offset: 0x0099E69D
		public unsafe float StripMaskVScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005AEF RID: 23279
		// (get) Token: 0x06027F3F RID: 163647 RVA: 0x009A04AE File Offset: 0x0099E6AE
		// (set) Token: 0x06027F40 RID: 163648 RVA: 0x009A04BE File Offset: 0x0099E6BE
		public unsafe float StripMaskVSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005AF0 RID: 23280
		// (get) Token: 0x06027F41 RID: 163649 RVA: 0x009A04CF File Offset: 0x0099E6CF
		// (set) Token: 0x06027F42 RID: 163650 RVA: 0x009A04E3 File Offset: 0x0099E6E3
		[Nullable(2)]
		public unsafe UTexture2D DistortionMaskTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_BadSignalParameters_C.__PropertyOffset_20);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_BadSignalParameters_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17005AF1 RID: 23281
		// (get) Token: 0x06027F43 RID: 163651 RVA: 0x009A04F8 File Offset: 0x0099E6F8
		// (set) Token: 0x06027F44 RID: 163652 RVA: 0x009A0508 File Offset: 0x0099E708
		public unsafe float DistortionHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005AF2 RID: 23282
		// (get) Token: 0x06027F45 RID: 163653 RVA: 0x009A0519 File Offset: 0x0099E719
		// (set) Token: 0x06027F46 RID: 163654 RVA: 0x009A0529 File Offset: 0x0099E729
		public unsafe float DistortionUScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005AF3 RID: 23283
		// (get) Token: 0x06027F47 RID: 163655 RVA: 0x009A053A File Offset: 0x0099E73A
		// (set) Token: 0x06027F48 RID: 163656 RVA: 0x009A054A File Offset: 0x0099E74A
		public unsafe float DistortionVScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005AF4 RID: 23284
		// (get) Token: 0x06027F49 RID: 163657 RVA: 0x009A055B File Offset: 0x0099E75B
		// (set) Token: 0x06027F4A RID: 163658 RVA: 0x009A056B File Offset: 0x0099E76B
		public unsafe float DistortionProportion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005AF5 RID: 23285
		// (get) Token: 0x06027F4B RID: 163659 RVA: 0x009A057C File Offset: 0x0099E77C
		// (set) Token: 0x06027F4C RID: 163660 RVA: 0x009A058C File Offset: 0x0099E78C
		public unsafe float DistortionExplodeProportion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005AF6 RID: 23286
		// (get) Token: 0x06027F4D RID: 163661 RVA: 0x009A059D File Offset: 0x0099E79D
		// (set) Token: 0x06027F4E RID: 163662 RVA: 0x009A05AD File Offset: 0x0099E7AD
		public unsafe float WrapStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005AF7 RID: 23287
		// (get) Token: 0x06027F4F RID: 163663 RVA: 0x009A05BE File Offset: 0x0099E7BE
		// (set) Token: 0x06027F50 RID: 163664 RVA: 0x009A05CE File Offset: 0x0099E7CE
		public unsafe float WrapBiasSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005AF8 RID: 23288
		// (get) Token: 0x06027F51 RID: 163665 RVA: 0x009A05DF File Offset: 0x0099E7DF
		// (set) Token: 0x06027F52 RID: 163666 RVA: 0x009A05EF File Offset: 0x0099E7EF
		public unsafe float WrapFrequecy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_BadSignalParameters_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x06027F53 RID: 163667 RVA: 0x009A0600 File Offset: 0x0099E800
		protected PDA_BadSignalParameters_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014465 RID: 83045
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/BadSignalEffect/PDA_BadSignalParameters.PDA_BadSignalParameters_C";

		// Token: 0x04014466 RID: 83046
		private static IntPtr _ClassPtr;

		// Token: 0x04014467 RID: 83047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014468 RID: 83048
		internal static int __PropertyOffset_0;

		// Token: 0x04014469 RID: 83049
		internal static int __PropertyOffset_1;

		// Token: 0x0401446A RID: 83050
		internal static int __PropertyOffset_2;

		// Token: 0x0401446B RID: 83051
		internal static int __PropertyOffset_3;

		// Token: 0x0401446C RID: 83052
		internal static int __PropertyOffset_4;

		// Token: 0x0401446D RID: 83053
		internal static int __PropertyOffset_5;

		// Token: 0x0401446E RID: 83054
		internal static int __PropertyOffset_6;

		// Token: 0x0401446F RID: 83055
		internal static int __PropertyOffset_7;

		// Token: 0x04014470 RID: 83056
		internal static int __PropertyOffset_8;

		// Token: 0x04014471 RID: 83057
		internal static int __PropertyOffset_9;

		// Token: 0x04014472 RID: 83058
		internal static int __PropertyOffset_10;

		// Token: 0x04014473 RID: 83059
		internal static int __PropertyOffset_11;

		// Token: 0x04014474 RID: 83060
		internal static int __PropertyOffset_12;

		// Token: 0x04014475 RID: 83061
		internal static int __PropertyOffset_13;

		// Token: 0x04014476 RID: 83062
		internal static int __PropertyOffset_14;

		// Token: 0x04014477 RID: 83063
		internal static int __PropertyOffset_15;

		// Token: 0x04014478 RID: 83064
		internal static int __PropertyOffset_16;

		// Token: 0x04014479 RID: 83065
		internal static int __PropertyOffset_17;

		// Token: 0x0401447A RID: 83066
		internal static int __PropertyOffset_18;

		// Token: 0x0401447B RID: 83067
		internal static int __PropertyOffset_19;

		// Token: 0x0401447C RID: 83068
		internal static int __PropertyOffset_20;

		// Token: 0x0401447D RID: 83069
		internal static int __PropertyOffset_21;

		// Token: 0x0401447E RID: 83070
		internal static int __PropertyOffset_22;

		// Token: 0x0401447F RID: 83071
		internal static int __PropertyOffset_23;

		// Token: 0x04014480 RID: 83072
		internal static int __PropertyOffset_24;

		// Token: 0x04014481 RID: 83073
		internal static int __PropertyOffset_25;

		// Token: 0x04014482 RID: 83074
		internal static int __PropertyOffset_26;

		// Token: 0x04014483 RID: 83075
		internal static int __PropertyOffset_27;

		// Token: 0x04014484 RID: 83076
		internal static int __PropertyOffset_28;
	}
}
