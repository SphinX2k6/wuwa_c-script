using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003D9B RID: 15771
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C")]
	[UnrealStructLayout(2040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2040)]
	public class NinjaLiveGUI_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027178 RID: 160120 RVA: 0x00986FD7 File Offset: 0x009851D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLiveGUI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C");
			}
			return NinjaLiveGUI_C._ClassPtr;
		}

		// Token: 0x06027179 RID: 160121 RVA: 0x00986FFC File Offset: 0x009851FC
		public NinjaLiveGUI_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLiveGUI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602717A RID: 160122 RVA: 0x00987024 File Offset: 0x00985224
		[NullableContext(1)]
		public NinjaLiveGUI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLiveGUI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005648 RID: 22088
		// (get) Token: 0x0602717B RID: 160123 RVA: 0x00987057 File Offset: 0x00985257
		// (set) Token: 0x0602717C RID: 160124 RVA: 0x0098706B File Offset: 0x0098526B
		public unsafe UWidgetAnimation BlinkingText1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetAnimation>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005649 RID: 22089
		// (get) Token: 0x0602717D RID: 160125 RVA: 0x00987080 File Offset: 0x00985280
		// (set) Token: 0x0602717E RID: 160126 RVA: 0x00987094 File Offset: 0x00985294
		public unsafe USpinBox _001_SpinBox_BrushSize
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700564A RID: 22090
		// (get) Token: 0x0602717F RID: 160127 RVA: 0x009870A9 File Offset: 0x009852A9
		// (set) Token: 0x06027180 RID: 160128 RVA: 0x009870BD File Offset: 0x009852BD
		public unsafe USpinBox _002_SpinBox_BrushDensity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700564B RID: 22091
		// (get) Token: 0x06027181 RID: 160129 RVA: 0x009870D2 File Offset: 0x009852D2
		// (set) Token: 0x06027182 RID: 160130 RVA: 0x009870E6 File Offset: 0x009852E6
		public unsafe USpinBox _003_SpinBox_BrushHardness
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700564C RID: 22092
		// (get) Token: 0x06027183 RID: 160131 RVA: 0x009870FB File Offset: 0x009852FB
		// (set) Token: 0x06027184 RID: 160132 RVA: 0x0098710F File Offset: 0x0098530F
		public unsafe USpinBox _004_SpinBox_BrushNoise
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700564D RID: 22093
		// (get) Token: 0x06027185 RID: 160133 RVA: 0x00987124 File Offset: 0x00985324
		// (set) Token: 0x06027186 RID: 160134 RVA: 0x00987138 File Offset: 0x00985338
		public unsafe USpinBox _005_SpinBox_BrushRnd
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700564E RID: 22094
		// (get) Token: 0x06027187 RID: 160135 RVA: 0x0098714D File Offset: 0x0098534D
		// (set) Token: 0x06027188 RID: 160136 RVA: 0x00987161 File Offset: 0x00985361
		public unsafe USpinBox _006_SpinBox_BrushPersist
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700564F RID: 22095
		// (get) Token: 0x06027189 RID: 160137 RVA: 0x00987176 File Offset: 0x00985376
		// (set) Token: 0x0602718A RID: 160138 RVA: 0x0098718A File Offset: 0x0098538A
		public unsafe UCheckBox _007_Checkbox_BrushInvert
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCheckBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005650 RID: 22096
		// (get) Token: 0x0602718B RID: 160139 RVA: 0x0098719F File Offset: 0x0098539F
		// (set) Token: 0x0602718C RID: 160140 RVA: 0x009871B3 File Offset: 0x009853B3
		public unsafe USpinBox _008_SpinBox_BrushDrag
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005651 RID: 22097
		// (get) Token: 0x0602718D RID: 160141 RVA: 0x009871C8 File Offset: 0x009853C8
		// (set) Token: 0x0602718E RID: 160142 RVA: 0x009871DC File Offset: 0x009853DC
		public unsafe USpinBox _009_SpinBox_BrushPuncture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005652 RID: 22098
		// (get) Token: 0x0602718F RID: 160143 RVA: 0x009871F1 File Offset: 0x009853F1
		// (set) Token: 0x06027190 RID: 160144 RVA: 0x00987205 File Offset: 0x00985405
		public unsafe USpinBox _010_SpinBox_SimFeedback
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005653 RID: 22099
		// (get) Token: 0x06027191 RID: 160145 RVA: 0x0098721A File Offset: 0x0098541A
		// (set) Token: 0x06027192 RID: 160146 RVA: 0x0098722E File Offset: 0x0098542E
		public unsafe UButton _011_Button_SimClear
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005654 RID: 22100
		// (get) Token: 0x06027193 RID: 160147 RVA: 0x00987243 File Offset: 0x00985443
		// (set) Token: 0x06027194 RID: 160148 RVA: 0x00987257 File Offset: 0x00985457
		public unsafe USpinBox _012_SpinBox_SimSpeed
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005655 RID: 22101
		// (get) Token: 0x06027195 RID: 160149 RVA: 0x0098726C File Offset: 0x0098546C
		// (set) Token: 0x06027196 RID: 160150 RVA: 0x00987280 File Offset: 0x00985480
		public unsafe USpinBox _013_SpinBox_SimTurbulence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005656 RID: 22102
		// (get) Token: 0x06027197 RID: 160151 RVA: 0x00987295 File Offset: 0x00985495
		// (set) Token: 0x06027198 RID: 160152 RVA: 0x009872A9 File Offset: 0x009854A9
		public unsafe USpinBox _014_SpinBox_VeloAmp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17005657 RID: 22103
		// (get) Token: 0x06027199 RID: 160153 RVA: 0x009872BE File Offset: 0x009854BE
		// (set) Token: 0x0602719A RID: 160154 RVA: 0x009872D2 File Offset: 0x009854D2
		public unsafe USpinBox _015_SpinBox_VeloOffsetX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17005658 RID: 22104
		// (get) Token: 0x0602719B RID: 160155 RVA: 0x009872E7 File Offset: 0x009854E7
		// (set) Token: 0x0602719C RID: 160156 RVA: 0x009872FB File Offset: 0x009854FB
		public unsafe USpinBox _016_SpinBox_VeloOffsetY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17005659 RID: 22105
		// (get) Token: 0x0602719D RID: 160157 RVA: 0x00987310 File Offset: 0x00985510
		// (set) Token: 0x0602719E RID: 160158 RVA: 0x00987324 File Offset: 0x00985524
		public unsafe USpinBox _017_SpinBox_VeloAmpNoise
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700565A RID: 22106
		// (get) Token: 0x0602719F RID: 160159 RVA: 0x00987339 File Offset: 0x00985539
		// (set) Token: 0x060271A0 RID: 160160 RVA: 0x0098734D File Offset: 0x0098554D
		public unsafe USpinBox _018_SpinBox_VeloDirNoise
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x1700565B RID: 22107
		// (get) Token: 0x060271A1 RID: 160161 RVA: 0x00987362 File Offset: 0x00985562
		// (set) Token: 0x060271A2 RID: 160162 RVA: 0x00987376 File Offset: 0x00985576
		public unsafe USpinBox _019_SpinBox_VeloDirNoiseSize
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700565C RID: 22108
		// (get) Token: 0x060271A3 RID: 160163 RVA: 0x0098738B File Offset: 0x0098558B
		// (set) Token: 0x060271A4 RID: 160164 RVA: 0x0098739F File Offset: 0x0098559F
		public unsafe USpinBox _020_SpinBox_VeloDirNoiseOffs
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700565D RID: 22109
		// (get) Token: 0x060271A5 RID: 160165 RVA: 0x009873B4 File Offset: 0x009855B4
		// (set) Token: 0x060271A6 RID: 160166 RVA: 0x009873C8 File Offset: 0x009855C8
		public unsafe UComboBoxString _021_ComboBox_VeloFromBitmap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x1700565E RID: 22110
		// (get) Token: 0x060271A7 RID: 160167 RVA: 0x009873DD File Offset: 0x009855DD
		// (set) Token: 0x060271A8 RID: 160168 RVA: 0x009873F1 File Offset: 0x009855F1
		public unsafe USpinBox _022_SpinBox_VeloRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x1700565F RID: 22111
		// (get) Token: 0x060271A9 RID: 160169 RVA: 0x00987406 File Offset: 0x00985606
		// (set) Token: 0x060271AA RID: 160170 RVA: 0x0098741A File Offset: 0x0098561A
		public unsafe USpinBox _023_SpinBox_VeloOffset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17005660 RID: 22112
		// (get) Token: 0x060271AB RID: 160171 RVA: 0x0098742F File Offset: 0x0098562F
		// (set) Token: 0x060271AC RID: 160172 RVA: 0x00987443 File Offset: 0x00985643
		public unsafe USpinBox _024_SpinBox_VeloTile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17005661 RID: 22113
		// (get) Token: 0x060271AD RID: 160173 RVA: 0x00987458 File Offset: 0x00985658
		// (set) Token: 0x060271AE RID: 160174 RVA: 0x0098746C File Offset: 0x0098566C
		public unsafe UBorder _024b_Border_Warning_VelocityFromBitmap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBorder>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17005662 RID: 22114
		// (get) Token: 0x060271AF RID: 160175 RVA: 0x00987481 File Offset: 0x00985681
		// (set) Token: 0x060271B0 RID: 160176 RVA: 0x00987495 File Offset: 0x00985695
		public unsafe USpinBox _025_SimareaMoFx
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17005663 RID: 22115
		// (get) Token: 0x060271B1 RID: 160177 RVA: 0x009874AA File Offset: 0x009856AA
		// (set) Token: 0x060271B2 RID: 160178 RVA: 0x009874BE File Offset: 0x009856BE
		public unsafe USpinBox _025_SimareaMoOffset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17005664 RID: 22116
		// (get) Token: 0x060271B3 RID: 160179 RVA: 0x009874D3 File Offset: 0x009856D3
		// (set) Token: 0x060271B4 RID: 160180 RVA: 0x009874E7 File Offset: 0x009856E7
		public unsafe UComboBoxString _026_ComboBox_DensFromBitmap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17005665 RID: 22117
		// (get) Token: 0x060271B5 RID: 160181 RVA: 0x009874FC File Offset: 0x009856FC
		// (set) Token: 0x060271B6 RID: 160182 RVA: 0x00987510 File Offset: 0x00985710
		public unsafe UBorder _026b_Border_Warning_DensityFromBitmap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBorder>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17005666 RID: 22118
		// (get) Token: 0x060271B7 RID: 160183 RVA: 0x00987525 File Offset: 0x00985725
		// (set) Token: 0x060271B8 RID: 160184 RVA: 0x00987539 File Offset: 0x00985739
		public unsafe USpinBox _027_SpinBox_DensityOffsetX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17005667 RID: 22119
		// (get) Token: 0x060271B9 RID: 160185 RVA: 0x0098754E File Offset: 0x0098574E
		// (set) Token: 0x060271BA RID: 160186 RVA: 0x00987562 File Offset: 0x00985762
		public unsafe USpinBox _028_SpinBox_DensityOffsetY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17005668 RID: 22120
		// (get) Token: 0x060271BB RID: 160187 RVA: 0x00987577 File Offset: 0x00985777
		// (set) Token: 0x060271BC RID: 160188 RVA: 0x0098758B File Offset: 0x0098578B
		public unsafe USpinBox _029_SpinBox_DensityTile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17005669 RID: 22121
		// (get) Token: 0x060271BD RID: 160189 RVA: 0x009875A0 File Offset: 0x009857A0
		// (set) Token: 0x060271BE RID: 160190 RVA: 0x009875B4 File Offset: 0x009857B4
		public unsafe UComboBoxString _030_ComboBox_DensFromMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x1700566A RID: 22122
		// (get) Token: 0x060271BF RID: 160191 RVA: 0x009875C9 File Offset: 0x009857C9
		// (set) Token: 0x060271C0 RID: 160192 RVA: 0x009875DD File Offset: 0x009857DD
		public unsafe USpinBox _031_SpinBox_DensityFieldAmp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x1700566B RID: 22123
		// (get) Token: 0x060271C1 RID: 160193 RVA: 0x009875F2 File Offset: 0x009857F2
		// (set) Token: 0x060271C2 RID: 160194 RVA: 0x00987606 File Offset: 0x00985806
		public unsafe USpinBox _032_SpinBox_DensityFieldAmpNois
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x1700566C RID: 22124
		// (get) Token: 0x060271C3 RID: 160195 RVA: 0x0098761B File Offset: 0x0098581B
		// (set) Token: 0x060271C4 RID: 160196 RVA: 0x0098762F File Offset: 0x0098582F
		public unsafe USpinBox _033_SpinBox_DensityFieldAmpNoisOfs
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x1700566D RID: 22125
		// (get) Token: 0x060271C5 RID: 160197 RVA: 0x00987644 File Offset: 0x00985844
		// (set) Token: 0x060271C6 RID: 160198 RVA: 0x00987658 File Offset: 0x00985858
		public unsafe USpinBox _034_SpinBox_DensityFieldAmpNoisTile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x1700566E RID: 22126
		// (get) Token: 0x060271C7 RID: 160199 RVA: 0x0098766D File Offset: 0x0098586D
		// (set) Token: 0x060271C8 RID: 160200 RVA: 0x00987681 File Offset: 0x00985881
		public unsafe USpinBox _035_SpinBox_BouncyEdges
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x1700566F RID: 22127
		// (get) Token: 0x060271C9 RID: 160201 RVA: 0x00987696 File Offset: 0x00985896
		// (set) Token: 0x060271CA RID: 160202 RVA: 0x009876AA File Offset: 0x009858AA
		public unsafe USpinBox _036_SpinBox_SimEdgeFadePow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x17005670 RID: 22128
		// (get) Token: 0x060271CB RID: 160203 RVA: 0x009876BF File Offset: 0x009858BF
		// (set) Token: 0x060271CC RID: 160204 RVA: 0x009876D3 File Offset: 0x009858D3
		public unsafe USpinBox _037_SpinBox_SimEdgeFadeWidth
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpinBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17005671 RID: 22129
		// (get) Token: 0x060271CD RID: 160205 RVA: 0x009876E8 File Offset: 0x009858E8
		// (set) Token: 0x060271CE RID: 160206 RVA: 0x009876FC File Offset: 0x009858FC
		public unsafe UComboBoxString _038_ComboBox_OutputMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17005672 RID: 22130
		// (get) Token: 0x060271CF RID: 160207 RVA: 0x00987711 File Offset: 0x00985911
		// (set) Token: 0x060271D0 RID: 160208 RVA: 0x00987725 File Offset: 0x00985925
		public unsafe UButton _039_Button_SavePaintBuffer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x17005673 RID: 22131
		// (get) Token: 0x060271D1 RID: 160209 RVA: 0x0098773A File Offset: 0x0098593A
		// (set) Token: 0x060271D2 RID: 160210 RVA: 0x0098774E File Offset: 0x0098594E
		public unsafe UButton _040_Button_SaveSimBuffer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x17005674 RID: 22132
		// (get) Token: 0x060271D3 RID: 160211 RVA: 0x00987763 File Offset: 0x00985963
		// (set) Token: 0x060271D4 RID: 160212 RVA: 0x00987777 File Offset: 0x00985977
		public unsafe UTextBlock _041_TextBlock_MetaInfo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17005675 RID: 22133
		// (get) Token: 0x060271D5 RID: 160213 RVA: 0x0098778C File Offset: 0x0098598C
		// (set) Token: 0x060271D6 RID: 160214 RVA: 0x009877A0 File Offset: 0x009859A0
		public unsafe UBorder Border
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBorder>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x17005676 RID: 22134
		// (get) Token: 0x060271D7 RID: 160215 RVA: 0x009877B5 File Offset: 0x009859B5
		// (set) Token: 0x060271D8 RID: 160216 RVA: 0x009877C9 File Offset: 0x009859C9
		public unsafe UBorder Main0_StatusBorder
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBorder>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17005677 RID: 22135
		// (get) Token: 0x060271D9 RID: 160217 RVA: 0x009877DE File Offset: 0x009859DE
		// (set) Token: 0x060271DA RID: 160218 RVA: 0x009877F2 File Offset: 0x009859F2
		public unsafe UButton Main1_Button_Minimize
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x17005678 RID: 22136
		// (get) Token: 0x060271DB RID: 160219 RVA: 0x00987807 File Offset: 0x00985A07
		// (set) Token: 0x060271DC RID: 160220 RVA: 0x0098781B File Offset: 0x00985A1B
		public unsafe UCheckBox Main2_TooltipCheckBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCheckBox>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x17005679 RID: 22137
		// (get) Token: 0x060271DD RID: 160221 RVA: 0x00987830 File Offset: 0x00985A30
		// (set) Token: 0x060271DE RID: 160222 RVA: 0x00987844 File Offset: 0x00985A44
		public unsafe UButton Main3_Button_CloseProgram
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x1700567A RID: 22138
		// (get) Token: 0x060271DF RID: 160223 RVA: 0x00987859 File Offset: 0x00985A59
		// (set) Token: 0x060271E0 RID: 160224 RVA: 0x0098786D File Offset: 0x00985A6D
		public unsafe UComboBoxString Main4_ComboBox_MainMenu
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_51);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_51, value);
			}
		}

		// Token: 0x1700567B RID: 22139
		// (get) Token: 0x060271E1 RID: 160225 RVA: 0x00987882 File Offset: 0x00985A82
		// (set) Token: 0x060271E2 RID: 160226 RVA: 0x00987896 File Offset: 0x00985A96
		public unsafe UComboBoxString Main5_ComboBox_Presets
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_52);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x1700567C RID: 22140
		// (get) Token: 0x060271E3 RID: 160227 RVA: 0x009878AB File Offset: 0x00985AAB
		// (set) Token: 0x060271E4 RID: 160228 RVA: 0x009878BF File Offset: 0x00985ABF
		public unsafe UButton Main6_Button_OverWritePreset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_53);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_53, value);
			}
		}

		// Token: 0x1700567D RID: 22141
		// (get) Token: 0x060271E5 RID: 160229 RVA: 0x009878D4 File Offset: 0x00985AD4
		// (set) Token: 0x060271E6 RID: 160230 RVA: 0x009878E8 File Offset: 0x00985AE8
		public unsafe UButton Main7_Button_DuplicatePreset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x1700567E RID: 22142
		// (get) Token: 0x060271E7 RID: 160231 RVA: 0x009878FD File Offset: 0x00985AFD
		// (set) Token: 0x060271E8 RID: 160232 RVA: 0x00987911 File Offset: 0x00985B11
		public unsafe UButton Main8_Button_RemovePreset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_55);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x1700567F RID: 22143
		// (get) Token: 0x060271E9 RID: 160233 RVA: 0x00987926 File Offset: 0x00985B26
		// (set) Token: 0x060271EA RID: 160234 RVA: 0x0098793A File Offset: 0x00985B3A
		public unsafe UButton Main9_Button_AutoLoadPreset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x17005680 RID: 22144
		// (get) Token: 0x060271EB RID: 160235 RVA: 0x0098794F File Offset: 0x00985B4F
		// (set) Token: 0x060271EC RID: 160236 RVA: 0x00987963 File Offset: 0x00985B63
		public unsafe UImage MenuFrame1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17005681 RID: 22145
		// (get) Token: 0x060271ED RID: 160237 RVA: 0x00987978 File Offset: 0x00985B78
		// (set) Token: 0x060271EE RID: 160238 RVA: 0x0098798C File Offset: 0x00985B8C
		public unsafe UImage MenuFrame2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x17005682 RID: 22146
		// (get) Token: 0x060271EF RID: 160239 RVA: 0x009879A1 File Offset: 0x00985BA1
		// (set) Token: 0x060271F0 RID: 160240 RVA: 0x009879B5 File Offset: 0x00985BB5
		public unsafe UImage MenuFrame3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_59);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_59, value);
			}
		}

		// Token: 0x17005683 RID: 22147
		// (get) Token: 0x060271F1 RID: 160241 RVA: 0x009879CA File Offset: 0x00985BCA
		// (set) Token: 0x060271F2 RID: 160242 RVA: 0x009879DE File Offset: 0x00985BDE
		public unsafe UMultiLineEditableText MultiLineEditableText_MetaData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMultiLineEditableText>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x17005684 RID: 22148
		// (get) Token: 0x060271F3 RID: 160243 RVA: 0x009879F3 File Offset: 0x00985BF3
		// (set) Token: 0x060271F4 RID: 160244 RVA: 0x00987A07 File Offset: 0x00985C07
		public unsafe UNamedSlot NamedSlot_empty
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNamedSlot>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_61);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_61, value);
			}
		}

		// Token: 0x17005685 RID: 22149
		// (get) Token: 0x060271F5 RID: 160245 RVA: 0x00987A1C File Offset: 0x00985C1C
		// (set) Token: 0x060271F6 RID: 160246 RVA: 0x00987A30 File Offset: 0x00985C30
		public unsafe UNamedSlot NamedSlot_FluidNinja
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNamedSlot>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_62);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_62, value);
			}
		}

		// Token: 0x17005686 RID: 22150
		// (get) Token: 0x060271F7 RID: 160247 RVA: 0x00987A45 File Offset: 0x00985C45
		// (set) Token: 0x060271F8 RID: 160248 RVA: 0x00987A59 File Offset: 0x00985C59
		public unsafe UTextBlock TextBlock_BRUSH
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x17005687 RID: 22151
		// (get) Token: 0x060271F9 RID: 160249 RVA: 0x00987A6E File Offset: 0x00985C6E
		// (set) Token: 0x060271FA RID: 160250 RVA: 0x00987A82 File Offset: 0x00985C82
		public unsafe UTextBlock TextBlock_FIELDS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x17005688 RID: 22152
		// (get) Token: 0x060271FB RID: 160251 RVA: 0x00987A97 File Offset: 0x00985C97
		// (set) Token: 0x060271FC RID: 160252 RVA: 0x00987AAB File Offset: 0x00985CAB
		public unsafe UTextBlock TextBlock_SIM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x17005689 RID: 22153
		// (get) Token: 0x060271FD RID: 160253 RVA: 0x00987AC0 File Offset: 0x00985CC0
		// (set) Token: 0x060271FE RID: 160254 RVA: 0x00987AD4 File Offset: 0x00985CD4
		[Nullable(1)]
		public unsafe string SelectedProjectItem
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_66)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_66)), value);
			}
		}

		// Token: 0x1700568A RID: 22154
		// (get) Token: 0x060271FF RID: 160255 RVA: 0x00987AE9 File Offset: 0x00985CE9
		// (set) Token: 0x06027200 RID: 160256 RVA: 0x00987AFD File Offset: 0x00985CFD
		[Nullable(1)]
		public unsafe string SelectedPresetItem
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_67)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_67)), value);
			}
		}

		// Token: 0x1700568B RID: 22155
		// (get) Token: 0x06027201 RID: 160257 RVA: 0x00987B12 File Offset: 0x00985D12
		// (set) Token: 0x06027202 RID: 160258 RVA: 0x00987B26 File Offset: 0x00985D26
		[Nullable(1)]
		public unsafe string SelectedPresetItemTemp
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_68)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_68)), value);
			}
		}

		// Token: 0x1700568C RID: 22156
		// (get) Token: 0x06027203 RID: 160259 RVA: 0x00987B3B File Offset: 0x00985D3B
		// (set) Token: 0x06027204 RID: 160260 RVA: 0x00987B4F File Offset: 0x00985D4F
		[Nullable(1)]
		public unsafe string NullString
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_69)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_69)), value);
			}
		}

		// Token: 0x1700568D RID: 22157
		// (get) Token: 0x06027205 RID: 160261 RVA: 0x00987B64 File Offset: 0x00985D64
		// (set) Token: 0x06027206 RID: 160262 RVA: 0x00987B78 File Offset: 0x00985D78
		[Nullable(1)]
		public unsafe string DefaultSelection
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_70)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLiveGUI_C.__PropertyOffset_70)), value);
			}
		}

		// Token: 0x1700568E RID: 22158
		// (get) Token: 0x06027207 RID: 160263 RVA: 0x00987B90 File Offset: 0x00985D90
		// (set) Token: 0x06027208 RID: 160264 RVA: 0x00987BC9 File Offset: 0x00985DC9
		[Nullable(1)]
		public TArray<UNamedSlot> ArrayOfWidgets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UNamedSlot> result;
				if ((result = this._ArrayOfWidgets) == null)
				{
					result = (this._ArrayOfWidgets = new TArray<UNamedSlot>(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_71, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ArrayOfWidgets.CopyAssign(value);
			}
		}

		// Token: 0x1700568F RID: 22159
		// (get) Token: 0x06027209 RID: 160265 RVA: 0x00987BD7 File Offset: 0x00985DD7
		// (set) Token: 0x0602720A RID: 160266 RVA: 0x00987BE7 File Offset: 0x00985DE7
		public unsafe int Counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x17005690 RID: 22160
		// (get) Token: 0x0602720B RID: 160267 RVA: 0x00987BF8 File Offset: 0x00985DF8
		// (set) Token: 0x0602720C RID: 160268 RVA: 0x00987C08 File Offset: 0x00985E08
		public unsafe int SelectedActorIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x17005691 RID: 22161
		// (get) Token: 0x0602720D RID: 160269 RVA: 0x00987C19 File Offset: 0x00985E19
		// (set) Token: 0x0602720E RID: 160270 RVA: 0x00987C29 File Offset: 0x00985E29
		public unsafe bool PresetsDetected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_74) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_74) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005692 RID: 22162
		// (get) Token: 0x0602720F RID: 160271 RVA: 0x00987C3C File Offset: 0x00985E3C
		// (set) Token: 0x06027210 RID: 160272 RVA: 0x00987C75 File Offset: 0x00985E75
		[Nullable(1)]
		public OnSelectionChanged OnSelectionChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnSelectionChanged result;
				if ((result = this._OnSelectionChanged) == null)
				{
					result = (this._OnSelectionChanged = new OnSelectionChanged(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_75, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_75, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005693 RID: 22163
		// (get) Token: 0x06027211 RID: 160273 RVA: 0x00987C98 File Offset: 0x00985E98
		// (set) Token: 0x06027212 RID: 160274 RVA: 0x00987CD1 File Offset: 0x00985ED1
		[Nullable(1)]
		public OnPresetSelectionChanged OnPresetSelectionChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnPresetSelectionChanged result;
				if ((result = this._OnPresetSelectionChanged) == null)
				{
					result = (this._OnPresetSelectionChanged = new OnPresetSelectionChanged(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_76, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_76, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005694 RID: 22164
		// (get) Token: 0x06027213 RID: 160275 RVA: 0x00987CF4 File Offset: 0x00985EF4
		// (set) Token: 0x06027214 RID: 160276 RVA: 0x00987D2D File Offset: 0x00985F2D
		[Nullable(1)]
		public OnPresetSave OnPresetSave
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnPresetSave result;
				if ((result = this._OnPresetSave) == null)
				{
					result = (this._OnPresetSave = new OnPresetSave(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_77, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_77, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005695 RID: 22165
		// (get) Token: 0x06027215 RID: 160277 RVA: 0x00987D4E File Offset: 0x00985F4E
		// (set) Token: 0x06027216 RID: 160278 RVA: 0x00987D5E File Offset: 0x00985F5E
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x17005696 RID: 22166
		// (get) Token: 0x06027217 RID: 160279 RVA: 0x00987D6F File Offset: 0x00985F6F
		// (set) Token: 0x06027218 RID: 160280 RVA: 0x00987D7F File Offset: 0x00985F7F
		public unsafe float TimerTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_79);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_79) = value;
			}
		}

		// Token: 0x17005697 RID: 22167
		// (get) Token: 0x06027219 RID: 160281 RVA: 0x00987D90 File Offset: 0x00985F90
		// (set) Token: 0x0602721A RID: 160282 RVA: 0x00987DA0 File Offset: 0x00985FA0
		public unsafe bool NinjaBaseArraysConstructed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_80) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_80) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005698 RID: 22168
		// (get) Token: 0x0602721B RID: 160283 RVA: 0x00987DB1 File Offset: 0x00985FB1
		// (set) Token: 0x0602721C RID: 160284 RVA: 0x00987DC1 File Offset: 0x00985FC1
		public unsafe bool PresetSaveOverWriteFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_81) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_81) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005699 RID: 22169
		// (get) Token: 0x0602721D RID: 160285 RVA: 0x00987DD4 File Offset: 0x00985FD4
		// (set) Token: 0x0602721E RID: 160286 RVA: 0x00987E0D File Offset: 0x0098600D
		[Nullable(1)]
		public TArray<FName> TempVarOfParticleTemplatePackages
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempVarOfParticleTemplatePackages) == null)
				{
					result = (this._TempVarOfParticleTemplatePackages = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_82, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TempVarOfParticleTemplatePackages.CopyAssign(value);
			}
		}

		// Token: 0x1700569A RID: 22170
		// (get) Token: 0x0602721F RID: 160287 RVA: 0x00987E1C File Offset: 0x0098601C
		// (set) Token: 0x06027220 RID: 160288 RVA: 0x00987E55 File Offset: 0x00986055
		[Nullable(1)]
		public TArray<FName> TempVarOfDensityTemplatePackages
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempVarOfDensityTemplatePackages) == null)
				{
					result = (this._TempVarOfDensityTemplatePackages = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_83, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TempVarOfDensityTemplatePackages.CopyAssign(value);
			}
		}

		// Token: 0x1700569B RID: 22171
		// (get) Token: 0x06027221 RID: 160289 RVA: 0x00987E64 File Offset: 0x00986064
		// (set) Token: 0x06027222 RID: 160290 RVA: 0x00987E9D File Offset: 0x0098609D
		[Nullable(1)]
		public TArray<FName> TempVarOfVelocityTemplatePackages
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempVarOfVelocityTemplatePackages) == null)
				{
					result = (this._TempVarOfVelocityTemplatePackages = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_84, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TempVarOfVelocityTemplatePackages.CopyAssign(value);
			}
		}

		// Token: 0x1700569C RID: 22172
		// (get) Token: 0x06027223 RID: 160291 RVA: 0x00987EAC File Offset: 0x009860AC
		// (set) Token: 0x06027224 RID: 160292 RVA: 0x00987EE5 File Offset: 0x009860E5
		[Nullable(1)]
		public TArray<FName> TempVarOfOutputMaterials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TempVarOfOutputMaterials) == null)
				{
					result = (this._TempVarOfOutputMaterials = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_85, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TempVarOfOutputMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700569D RID: 22173
		// (get) Token: 0x06027225 RID: 160293 RVA: 0x00987EF4 File Offset: 0x009860F4
		// (set) Token: 0x06027226 RID: 160294 RVA: 0x00987F2D File Offset: 0x0098612D
		[Nullable(1)]
		public TArray<string> ArrayOfPresetNamesUnsorted
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ArrayOfPresetNamesUnsorted) == null)
				{
					result = (this._ArrayOfPresetNamesUnsorted = new TArray<string>(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_86, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ArrayOfPresetNamesUnsorted.CopyAssign(value);
			}
		}

		// Token: 0x1700569E RID: 22174
		// (get) Token: 0x06027227 RID: 160295 RVA: 0x00987F3C File Offset: 0x0098613C
		// (set) Token: 0x06027228 RID: 160296 RVA: 0x00987F75 File Offset: 0x00986175
		[Nullable(1)]
		public TArray<string> ArrayOfPresetNamesSorted
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ArrayOfPresetNamesSorted) == null)
				{
					result = (this._ArrayOfPresetNamesSorted = new TArray<string>(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_87, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ArrayOfPresetNamesSorted.CopyAssign(value);
			}
		}

		// Token: 0x1700569F RID: 22175
		// (get) Token: 0x06027229 RID: 160297 RVA: 0x00987F83 File Offset: 0x00986183
		// (set) Token: 0x0602722A RID: 160298 RVA: 0x00987F93 File Offset: 0x00986193
		public unsafe bool SaveBasicAtlasPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_88) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_88) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056A0 RID: 22176
		// (get) Token: 0x0602722B RID: 160299 RVA: 0x00987FA4 File Offset: 0x009861A4
		// (set) Token: 0x0602722C RID: 160300 RVA: 0x00987FB4 File Offset: 0x009861B4
		public unsafe bool SaveBasicFlowPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_89) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_89) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056A1 RID: 22177
		// (get) Token: 0x0602722D RID: 160301 RVA: 0x00987FC5 File Offset: 0x009861C5
		// (set) Token: 0x0602722E RID: 160302 RVA: 0x00987FD5 File Offset: 0x009861D5
		public unsafe bool NinjaViewPortToolsVisibilityFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_90) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_90) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056A2 RID: 22178
		// (get) Token: 0x0602722F RID: 160303 RVA: 0x00987FE8 File Offset: 0x009861E8
		// (set) Token: 0x06027230 RID: 160304 RVA: 0x00988021 File Offset: 0x00986221
		[Nullable(1)]
		public OnDensityMapSave OnDensityMapSave
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnDensityMapSave result;
				if ((result = this._OnDensityMapSave) == null)
				{
					result = (this._OnDensityMapSave = new OnDensityMapSave(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_91, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_91, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170056A3 RID: 22179
		// (get) Token: 0x06027231 RID: 160305 RVA: 0x00988042 File Offset: 0x00986242
		// (set) Token: 0x06027232 RID: 160306 RVA: 0x00988052 File Offset: 0x00986252
		public unsafe bool SystemOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_92) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_92) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056A4 RID: 22180
		// (get) Token: 0x06027233 RID: 160307 RVA: 0x00988063 File Offset: 0x00986263
		// (set) Token: 0x06027234 RID: 160308 RVA: 0x00988073 File Offset: 0x00986273
		public unsafe bool RecordingStarted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_93) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_93) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056A5 RID: 22181
		// (get) Token: 0x06027235 RID: 160309 RVA: 0x00988084 File Offset: 0x00986284
		// (set) Token: 0x06027236 RID: 160310 RVA: 0x00988094 File Offset: 0x00986294
		public unsafe int TempVecfieldIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x170056A6 RID: 22182
		// (get) Token: 0x06027237 RID: 160311 RVA: 0x009880A8 File Offset: 0x009862A8
		// (set) Token: 0x06027238 RID: 160312 RVA: 0x009880E1 File Offset: 0x009862E1
		[Nullable(1)]
		public OnPresetDuplicated OnPresetDuplicated
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnPresetDuplicated result;
				if ((result = this._OnPresetDuplicated) == null)
				{
					result = (this._OnPresetDuplicated = new OnPresetDuplicated(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_95, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_95, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170056A7 RID: 22183
		// (get) Token: 0x06027239 RID: 160313 RVA: 0x00988102 File Offset: 0x00986302
		// (set) Token: 0x0602723A RID: 160314 RVA: 0x00988112 File Offset: 0x00986312
		public unsafe bool ForcePreferredPreset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_96) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLiveGUI_C.__PropertyOffset_96) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056A8 RID: 22184
		// (get) Token: 0x0602723B RID: 160315 RVA: 0x00988123 File Offset: 0x00986323
		// (set) Token: 0x0602723C RID: 160316 RVA: 0x00988137 File Offset: 0x00986337
		public unsafe AActor SelectedActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_97);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_97, value);
			}
		}

		// Token: 0x170056A9 RID: 22185
		// (get) Token: 0x0602723D RID: 160317 RVA: 0x0098814C File Offset: 0x0098634C
		// (set) Token: 0x0602723E RID: 160318 RVA: 0x00988160 File Offset: 0x00986360
		public unsafe NinjaLiveComponent_C SelectedActorComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLiveComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_98);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLiveGUI_C.__PropertyOffset_98, value);
			}
		}

		// Token: 0x0602723F RID: 160319 RVA: 0x00988178 File Offset: 0x00986378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSelectedActor(int SelectedActorIndex, ref NinjaLive_C NinjaLiveActor)
		{
			NinjaLiveGUI_C.__GetSelectedActor_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__GetSelectedActor_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(NinjaLiveGUI_C.__GetSelectedActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__GetSelectedActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SelectedActorIndex = SelectedActorIndex;
			ref NinjaLiveGUI_C.__GetSelectedActor_FunctionParams ptr2 = ref *ptr;
			NinjaLive_C ninjaLive_C = NinjaLiveActor;
			ptr2.NinjaLiveActor = ((ninjaLive_C != null) ? ninjaLive_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__GetSelectedActor_NativeFunctionPtr, (void*)ptr);
			NinjaLiveActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<NinjaLive_C>(ptr->NinjaLiveActor);
		}

		// Token: 0x06027240 RID: 160320 RVA: 0x009881E4 File Offset: 0x009863E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCurrentLevelInfoGUI(ref FName LevelName, ref FName LevelPath)
		{
			NinjaLiveGUI_C.__GetCurrentLevelInfoGUI_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__GetCurrentLevelInfoGUI_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(NinjaLiveGUI_C.__GetCurrentLevelInfoGUI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__GetCurrentLevelInfoGUI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LevelName = LevelName;
			ptr->LevelPath = LevelPath;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__GetCurrentLevelInfoGUI_NativeFunctionPtr, (void*)ptr);
			LevelName = ptr->LevelName;
			LevelPath = ptr->LevelPath;
		}

		// Token: 0x06027241 RID: 160321 RVA: 0x00988256 File Offset: 0x00986456
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_2_OnOpeningEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_2_OnOpeningEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027242 RID: 160322 RVA: 0x0098826C File Offset: 0x0098646C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature(string SelectedItem, ESelectInfo SelectionType)
		{
			NinjaLiveGUI_C.__BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027243 RID: 160323 RVA: 0x009882D5 File Offset: 0x009864D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void Construct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x06027244 RID: 160324 RVA: 0x009882E9 File Offset: 0x009864E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void Construct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLiveGUI_C.__Construct_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027245 RID: 160325 RVA: 0x00988300 File Offset: 0x00986500
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void PreConstruct(bool IsDesignTime)
		{
			NinjaLiveGUI_C.__PreConstruct_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__PreConstruct_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(NinjaLiveGUI_C.__PreConstruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__PreConstruct_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDesignTime = IsDesignTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__PreConstruct_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027246 RID: 160326 RVA: 0x00988348 File Offset: 0x00986548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void PreConstruct_Implementation(bool IsDesignTime)
		{
			NinjaLiveGUI_C.__PreConstruct_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__PreConstruct_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(NinjaLiveGUI_C.__PreConstruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__PreConstruct_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDesignTime = IsDesignTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLiveGUI_C.__PreConstruct_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027247 RID: 160327 RVA: 0x00988390 File Offset: 0x00986590
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature(string SelectedItem, ESelectInfo SelectionType)
		{
			NinjaLiveGUI_C.__BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027248 RID: 160328 RVA: 0x009883F9 File Offset: 0x009865F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Button_SavePreset_K2Node_ComponentBoundEvent_36_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Button_SavePreset_K2Node_ComponentBoundEvent_36_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027249 RID: 160329 RVA: 0x0098840D File Offset: 0x0098660D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Button_DuplicatePreset_K2Node_ComponentBoundEvent_217_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Button_DuplicatePreset_K2Node_ComponentBoundEvent_217_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602724A RID: 160330 RVA: 0x00988424 File Offset: 0x00986624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnPresetDuplicationFinished(UDataTable DuplicatedPreset)
		{
			NinjaLiveGUI_C.__OnPresetDuplicationFinished_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__OnPresetDuplicationFinished_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__OnPresetDuplicationFinished_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__OnPresetDuplicationFinished_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DuplicatedPreset = ((DuplicatedPreset != null) ? DuplicatedPreset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__OnPresetDuplicationFinished_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602724B RID: 160331 RVA: 0x0098847C File Offset: 0x0098667C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature(bool bIsChecked)
		{
			NinjaLiveGUI_C.__BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsChecked = bIsChecked;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602724C RID: 160332 RVA: 0x009884C2 File Offset: 0x009866C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Main3_Button_Minimize_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Main3_Button_Minimize_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602724D RID: 160333 RVA: 0x009884D6 File Offset: 0x009866D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnInitialized()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__OnInitialized_NativeFunctionPtr, null);
		}

		// Token: 0x0602724E RID: 160334 RVA: 0x009884EA File Offset: 0x009866EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnInitialized_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLiveGUI_C.__OnInitialized_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602724F RID: 160335 RVA: 0x00988500 File Offset: 0x00986700
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			NinjaLiveGUI_C.__Tick_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(NinjaLiveGUI_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027250 RID: 160336 RVA: 0x00988568 File Offset: 0x00986768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			NinjaLiveGUI_C.__Tick_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(NinjaLiveGUI_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLiveGUI_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027251 RID: 160337 RVA: 0x009885D1 File Offset: 0x009867D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Button_152_K2Node_ComponentBoundEvent_13_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Button_152_K2Node_ComponentBoundEvent_13_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027252 RID: 160338 RVA: 0x009885E5 File Offset: 0x009867E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Button_RemovePreset_K2Node_ComponentBoundEvent_218_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Button_RemovePreset_K2Node_ComponentBoundEvent_218_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027253 RID: 160339 RVA: 0x009885FC File Offset: 0x009867FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027254 RID: 160340 RVA: 0x00988650 File Offset: 0x00986850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027255 RID: 160341 RVA: 0x009886A2 File Offset: 0x009868A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Button_ClearBuffers_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Button_ClearBuffers_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027256 RID: 160342 RVA: 0x009886B8 File Offset: 0x009868B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027257 RID: 160343 RVA: 0x0098870C File Offset: 0x0098690C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027258 RID: 160344 RVA: 0x00988754 File Offset: 0x00986954
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027259 RID: 160345 RVA: 0x009887A8 File Offset: 0x009869A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602725A RID: 160346 RVA: 0x009887FC File Offset: 0x009869FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602725B RID: 160347 RVA: 0x00988844 File Offset: 0x00986A44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602725C RID: 160348 RVA: 0x00988898 File Offset: 0x00986A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602725D RID: 160349 RVA: 0x009888E0 File Offset: 0x00986AE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602725E RID: 160350 RVA: 0x00988934 File Offset: 0x00986B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602725F RID: 160351 RVA: 0x0098897C File Offset: 0x00986B7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027260 RID: 160352 RVA: 0x009889D0 File Offset: 0x00986BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027261 RID: 160353 RVA: 0x00988A18 File Offset: 0x00986C18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027262 RID: 160354 RVA: 0x00988A60 File Offset: 0x00986C60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027263 RID: 160355 RVA: 0x00988AB4 File Offset: 0x00986CB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027264 RID: 160356 RVA: 0x00988AFC File Offset: 0x00986CFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027265 RID: 160357 RVA: 0x00988B4E File Offset: 0x00986D4E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027266 RID: 160358 RVA: 0x00988B64 File Offset: 0x00986D64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027267 RID: 160359 RVA: 0x00988BB8 File Offset: 0x00986DB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027268 RID: 160360 RVA: 0x00988C0C File Offset: 0x00986E0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027269 RID: 160361 RVA: 0x00988C60 File Offset: 0x00986E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602726A RID: 160362 RVA: 0x00988CB4 File Offset: 0x00986EB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602726B RID: 160363 RVA: 0x00988D08 File Offset: 0x00986F08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature(string SelectedItem, ESelectInfo SelectionType)
		{
			NinjaLiveGUI_C.__BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602726C RID: 160364 RVA: 0x00988D74 File Offset: 0x00986F74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602726D RID: 160365 RVA: 0x00988DBC File Offset: 0x00986FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602726E RID: 160366 RVA: 0x00988E10 File Offset: 0x00987010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602726F RID: 160367 RVA: 0x00988E64 File Offset: 0x00987064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027270 RID: 160368 RVA: 0x00988EAC File Offset: 0x009870AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027271 RID: 160369 RVA: 0x00988F00 File Offset: 0x00987100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature(bool bIsChecked)
		{
			NinjaLiveGUI_C.__BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsChecked = bIsChecked;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027272 RID: 160370 RVA: 0x00988F48 File Offset: 0x00987148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027273 RID: 160371 RVA: 0x00988F90 File Offset: 0x00987190
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027274 RID: 160372 RVA: 0x00988FD8 File Offset: 0x009871D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027275 RID: 160373 RVA: 0x00989020 File Offset: 0x00987220
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027276 RID: 160374 RVA: 0x00989068 File Offset: 0x00987268
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027277 RID: 160375 RVA: 0x009890B0 File Offset: 0x009872B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027278 RID: 160376 RVA: 0x009890F8 File Offset: 0x009872F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027279 RID: 160377 RVA: 0x00989140 File Offset: 0x00987340
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602727A RID: 160378 RVA: 0x00989188 File Offset: 0x00987388
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602727B RID: 160379 RVA: 0x009891D0 File Offset: 0x009873D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602727C RID: 160380 RVA: 0x00989218 File Offset: 0x00987418
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature(float InValue)
		{
			NinjaLiveGUI_C.__BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602727D RID: 160381 RVA: 0x00989260 File Offset: 0x00987460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602727E RID: 160382 RVA: 0x009892B4 File Offset: 0x009874B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602727F RID: 160383 RVA: 0x00989308 File Offset: 0x00987508
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature(in FText Text, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027280 RID: 160384 RVA: 0x00989378 File Offset: 0x00987578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027281 RID: 160385 RVA: 0x009893CA File Offset: 0x009875CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_224_OnOpeningEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_224_OnOpeningEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027282 RID: 160386 RVA: 0x009893E0 File Offset: 0x009875E0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature(string SelectedItem, ESelectInfo SelectionType)
		{
			NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027283 RID: 160387 RVA: 0x00989449 File Offset: 0x00987649
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_222_OnOpeningEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_222_OnOpeningEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027284 RID: 160388 RVA: 0x00989460 File Offset: 0x00987660
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature(string SelectedItem, ESelectInfo SelectionType)
		{
			NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027285 RID: 160389 RVA: 0x009894CC File Offset: 0x009876CC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature(string SelectedItem, ESelectInfo SelectionType)
		{
			NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027286 RID: 160390 RVA: 0x00989538 File Offset: 0x00987738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027287 RID: 160391 RVA: 0x0098958A File Offset: 0x0098778A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Button_14_K2Node_ComponentBoundEvent_123_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Button_14_K2Node_ComponentBoundEvent_123_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027288 RID: 160392 RVA: 0x009895A0 File Offset: 0x009877A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027289 RID: 160393 RVA: 0x009895F4 File Offset: 0x009877F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602728A RID: 160394 RVA: 0x00989648 File Offset: 0x00987848
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602728B RID: 160395 RVA: 0x0098969C File Offset: 0x0098789C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602728C RID: 160396 RVA: 0x009896F0 File Offset: 0x009878F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602728D RID: 160397 RVA: 0x00989744 File Offset: 0x00987944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602728E RID: 160398 RVA: 0x00989798 File Offset: 0x00987998
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602728F RID: 160399 RVA: 0x009897EC File Offset: 0x009879EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027290 RID: 160400 RVA: 0x00989840 File Offset: 0x00987A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027291 RID: 160401 RVA: 0x00989894 File Offset: 0x00987A94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027292 RID: 160402 RVA: 0x009898E8 File Offset: 0x00987AE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature(float InValue, ETextCommit CommitMethod)
		{
			NinjaLiveGUI_C.__BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams* ptr = stackalloc NinjaLiveGUI_C.__BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLiveGUI_C.__BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveGUI_C.__BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027293 RID: 160403 RVA: 0x0098993A File Offset: 0x00987B3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__Main9_Button_PreferredPreset_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLiveGUI_C.__BndEvt__Main9_Button_PreferredPreset_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027294 RID: 160404 RVA: 0x0098994E File Offset: 0x00987B4E
		protected NinjaLiveGUI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013B1A RID: 80666
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C";

		// Token: 0x04013B1B RID: 80667
		private static IntPtr _ClassPtr;

		// Token: 0x04013B1C RID: 80668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013B1D RID: 80669
		public static IntPtr __OnPresetDuplicated__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B1E RID: 80670
		public static IntPtr __OnDensityMapSave__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B1F RID: 80671
		public static IntPtr __OnPresetSave__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B20 RID: 80672
		public static IntPtr __OnPresetSelectionChanged__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B21 RID: 80673
		public static IntPtr __OnSelectionChanged__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B22 RID: 80674
		internal static int __PropertyOffset_1;

		// Token: 0x04013B23 RID: 80675
		internal static int __PropertyOffset_2;

		// Token: 0x04013B24 RID: 80676
		internal static int __PropertyOffset_3;

		// Token: 0x04013B25 RID: 80677
		internal static int __PropertyOffset_4;

		// Token: 0x04013B26 RID: 80678
		internal static int __PropertyOffset_5;

		// Token: 0x04013B27 RID: 80679
		internal static int __PropertyOffset_6;

		// Token: 0x04013B28 RID: 80680
		internal static int __PropertyOffset_7;

		// Token: 0x04013B29 RID: 80681
		internal static int __PropertyOffset_8;

		// Token: 0x04013B2A RID: 80682
		internal static int __PropertyOffset_9;

		// Token: 0x04013B2B RID: 80683
		internal static int __PropertyOffset_10;

		// Token: 0x04013B2C RID: 80684
		internal static int __PropertyOffset_11;

		// Token: 0x04013B2D RID: 80685
		internal static int __PropertyOffset_12;

		// Token: 0x04013B2E RID: 80686
		internal static int __PropertyOffset_13;

		// Token: 0x04013B2F RID: 80687
		internal static int __PropertyOffset_14;

		// Token: 0x04013B30 RID: 80688
		internal static int __PropertyOffset_15;

		// Token: 0x04013B31 RID: 80689
		internal static int __PropertyOffset_16;

		// Token: 0x04013B32 RID: 80690
		internal static int __PropertyOffset_17;

		// Token: 0x04013B33 RID: 80691
		internal static int __PropertyOffset_18;

		// Token: 0x04013B34 RID: 80692
		internal static int __PropertyOffset_19;

		// Token: 0x04013B35 RID: 80693
		internal static int __PropertyOffset_20;

		// Token: 0x04013B36 RID: 80694
		internal static int __PropertyOffset_21;

		// Token: 0x04013B37 RID: 80695
		internal static int __PropertyOffset_22;

		// Token: 0x04013B38 RID: 80696
		internal static int __PropertyOffset_23;

		// Token: 0x04013B39 RID: 80697
		internal static int __PropertyOffset_24;

		// Token: 0x04013B3A RID: 80698
		internal static int __PropertyOffset_25;

		// Token: 0x04013B3B RID: 80699
		internal static int __PropertyOffset_26;

		// Token: 0x04013B3C RID: 80700
		internal static int __PropertyOffset_27;

		// Token: 0x04013B3D RID: 80701
		internal static int __PropertyOffset_28;

		// Token: 0x04013B3E RID: 80702
		internal static int __PropertyOffset_29;

		// Token: 0x04013B3F RID: 80703
		internal static int __PropertyOffset_30;

		// Token: 0x04013B40 RID: 80704
		internal static int __PropertyOffset_31;

		// Token: 0x04013B41 RID: 80705
		internal static int __PropertyOffset_32;

		// Token: 0x04013B42 RID: 80706
		internal static int __PropertyOffset_33;

		// Token: 0x04013B43 RID: 80707
		internal static int __PropertyOffset_34;

		// Token: 0x04013B44 RID: 80708
		internal static int __PropertyOffset_35;

		// Token: 0x04013B45 RID: 80709
		internal static int __PropertyOffset_36;

		// Token: 0x04013B46 RID: 80710
		internal static int __PropertyOffset_37;

		// Token: 0x04013B47 RID: 80711
		internal static int __PropertyOffset_38;

		// Token: 0x04013B48 RID: 80712
		internal static int __PropertyOffset_39;

		// Token: 0x04013B49 RID: 80713
		internal static int __PropertyOffset_40;

		// Token: 0x04013B4A RID: 80714
		internal static int __PropertyOffset_41;

		// Token: 0x04013B4B RID: 80715
		internal static int __PropertyOffset_42;

		// Token: 0x04013B4C RID: 80716
		internal static int __PropertyOffset_43;

		// Token: 0x04013B4D RID: 80717
		internal static int __PropertyOffset_44;

		// Token: 0x04013B4E RID: 80718
		internal static int __PropertyOffset_45;

		// Token: 0x04013B4F RID: 80719
		internal static int __PropertyOffset_46;

		// Token: 0x04013B50 RID: 80720
		internal static int __PropertyOffset_47;

		// Token: 0x04013B51 RID: 80721
		internal static int __PropertyOffset_48;

		// Token: 0x04013B52 RID: 80722
		internal static int __PropertyOffset_49;

		// Token: 0x04013B53 RID: 80723
		internal static int __PropertyOffset_50;

		// Token: 0x04013B54 RID: 80724
		internal static int __PropertyOffset_51;

		// Token: 0x04013B55 RID: 80725
		internal static int __PropertyOffset_52;

		// Token: 0x04013B56 RID: 80726
		internal static int __PropertyOffset_53;

		// Token: 0x04013B57 RID: 80727
		internal static int __PropertyOffset_54;

		// Token: 0x04013B58 RID: 80728
		internal static int __PropertyOffset_55;

		// Token: 0x04013B59 RID: 80729
		internal static int __PropertyOffset_56;

		// Token: 0x04013B5A RID: 80730
		internal static int __PropertyOffset_57;

		// Token: 0x04013B5B RID: 80731
		internal static int __PropertyOffset_58;

		// Token: 0x04013B5C RID: 80732
		internal static int __PropertyOffset_59;

		// Token: 0x04013B5D RID: 80733
		internal static int __PropertyOffset_60;

		// Token: 0x04013B5E RID: 80734
		internal static int __PropertyOffset_61;

		// Token: 0x04013B5F RID: 80735
		internal static int __PropertyOffset_62;

		// Token: 0x04013B60 RID: 80736
		internal static int __PropertyOffset_63;

		// Token: 0x04013B61 RID: 80737
		internal static int __PropertyOffset_64;

		// Token: 0x04013B62 RID: 80738
		internal static int __PropertyOffset_65;

		// Token: 0x04013B63 RID: 80739
		internal static int __PropertyOffset_66;

		// Token: 0x04013B64 RID: 80740
		internal static int __PropertyOffset_67;

		// Token: 0x04013B65 RID: 80741
		internal static int __PropertyOffset_68;

		// Token: 0x04013B66 RID: 80742
		internal static int __PropertyOffset_69;

		// Token: 0x04013B67 RID: 80743
		internal static int __PropertyOffset_70;

		// Token: 0x04013B68 RID: 80744
		internal static int __PropertyOffset_71;

		// Token: 0x04013B69 RID: 80745
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNamedSlot> _ArrayOfWidgets;

		// Token: 0x04013B6A RID: 80746
		internal static int __PropertyOffset_72;

		// Token: 0x04013B6B RID: 80747
		internal static int __PropertyOffset_73;

		// Token: 0x04013B6C RID: 80748
		internal static int __PropertyOffset_74;

		// Token: 0x04013B6D RID: 80749
		internal static int __PropertyOffset_75;

		// Token: 0x04013B6E RID: 80750
		private OnSelectionChanged _OnSelectionChanged;

		// Token: 0x04013B6F RID: 80751
		internal static int __PropertyOffset_76;

		// Token: 0x04013B70 RID: 80752
		private OnPresetSelectionChanged _OnPresetSelectionChanged;

		// Token: 0x04013B71 RID: 80753
		internal static int __PropertyOffset_77;

		// Token: 0x04013B72 RID: 80754
		private OnPresetSave _OnPresetSave;

		// Token: 0x04013B73 RID: 80755
		internal static int __PropertyOffset_78;

		// Token: 0x04013B74 RID: 80756
		internal static int __PropertyOffset_79;

		// Token: 0x04013B75 RID: 80757
		internal static int __PropertyOffset_80;

		// Token: 0x04013B76 RID: 80758
		internal static int __PropertyOffset_81;

		// Token: 0x04013B77 RID: 80759
		internal static int __PropertyOffset_82;

		// Token: 0x04013B78 RID: 80760
		private TArray<FName> _TempVarOfParticleTemplatePackages;

		// Token: 0x04013B79 RID: 80761
		internal static int __PropertyOffset_83;

		// Token: 0x04013B7A RID: 80762
		private TArray<FName> _TempVarOfDensityTemplatePackages;

		// Token: 0x04013B7B RID: 80763
		internal static int __PropertyOffset_84;

		// Token: 0x04013B7C RID: 80764
		private TArray<FName> _TempVarOfVelocityTemplatePackages;

		// Token: 0x04013B7D RID: 80765
		internal static int __PropertyOffset_85;

		// Token: 0x04013B7E RID: 80766
		private TArray<FName> _TempVarOfOutputMaterials;

		// Token: 0x04013B7F RID: 80767
		internal static int __PropertyOffset_86;

		// Token: 0x04013B80 RID: 80768
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ArrayOfPresetNamesUnsorted;

		// Token: 0x04013B81 RID: 80769
		internal static int __PropertyOffset_87;

		// Token: 0x04013B82 RID: 80770
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ArrayOfPresetNamesSorted;

		// Token: 0x04013B83 RID: 80771
		internal static int __PropertyOffset_88;

		// Token: 0x04013B84 RID: 80772
		internal static int __PropertyOffset_89;

		// Token: 0x04013B85 RID: 80773
		internal static int __PropertyOffset_90;

		// Token: 0x04013B86 RID: 80774
		internal static int __PropertyOffset_91;

		// Token: 0x04013B87 RID: 80775
		private OnDensityMapSave _OnDensityMapSave;

		// Token: 0x04013B88 RID: 80776
		internal static int __PropertyOffset_92;

		// Token: 0x04013B89 RID: 80777
		internal static int __PropertyOffset_93;

		// Token: 0x04013B8A RID: 80778
		internal static int __PropertyOffset_94;

		// Token: 0x04013B8B RID: 80779
		internal static int __PropertyOffset_95;

		// Token: 0x04013B8C RID: 80780
		private OnPresetDuplicated _OnPresetDuplicated;

		// Token: 0x04013B8D RID: 80781
		internal static int __PropertyOffset_96;

		// Token: 0x04013B8E RID: 80782
		internal static int __PropertyOffset_97;

		// Token: 0x04013B8F RID: 80783
		internal static int __PropertyOffset_98;

		// Token: 0x04013B90 RID: 80784
		private static IntPtr __GetSelectedActor_NativeFunctionPtr;

		// Token: 0x04013B91 RID: 80785
		private static IntPtr __GetCurrentLevelInfoGUI_NativeFunctionPtr;

		// Token: 0x04013B92 RID: 80786
		private static IntPtr __BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_2_OnOpeningEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B93 RID: 80787
		private static IntPtr __BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B94 RID: 80788
		private static IntPtr __Construct_NativeFunctionPtr;

		// Token: 0x04013B95 RID: 80789
		private static IntPtr __PreConstruct_NativeFunctionPtr;

		// Token: 0x04013B96 RID: 80790
		private static IntPtr __BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B97 RID: 80791
		private static IntPtr __BndEvt__Button_SavePreset_K2Node_ComponentBoundEvent_36_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B98 RID: 80792
		private static IntPtr __BndEvt__Button_DuplicatePreset_K2Node_ComponentBoundEvent_217_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B99 RID: 80793
		private static IntPtr __OnPresetDuplicationFinished_NativeFunctionPtr;

		// Token: 0x04013B9A RID: 80794
		private static IntPtr __BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B9B RID: 80795
		private static IntPtr __BndEvt__Main3_Button_Minimize_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B9C RID: 80796
		private static IntPtr __OnInitialized_NativeFunctionPtr;

		// Token: 0x04013B9D RID: 80797
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04013B9E RID: 80798
		private static IntPtr __BndEvt__Button_152_K2Node_ComponentBoundEvent_13_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013B9F RID: 80799
		private static IntPtr __BndEvt__Button_RemovePreset_K2Node_ComponentBoundEvent_218_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA0 RID: 80800
		private static IntPtr __BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA1 RID: 80801
		private static IntPtr __BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA2 RID: 80802
		private static IntPtr __BndEvt__Button_ClearBuffers_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA3 RID: 80803
		private static IntPtr __BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA4 RID: 80804
		private static IntPtr __BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA5 RID: 80805
		private static IntPtr __BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA6 RID: 80806
		private static IntPtr __BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA7 RID: 80807
		private static IntPtr __BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA8 RID: 80808
		private static IntPtr __BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BA9 RID: 80809
		private static IntPtr __BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BAA RID: 80810
		private static IntPtr __BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BAB RID: 80811
		private static IntPtr __BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BAC RID: 80812
		private static IntPtr __BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BAD RID: 80813
		private static IntPtr __BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BAE RID: 80814
		private static IntPtr __BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BAF RID: 80815
		private static IntPtr __BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB0 RID: 80816
		private static IntPtr __BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB1 RID: 80817
		private static IntPtr __BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB2 RID: 80818
		private static IntPtr __BndEvt__Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB3 RID: 80819
		private static IntPtr __BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB4 RID: 80820
		private static IntPtr __BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB5 RID: 80821
		private static IntPtr __BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB6 RID: 80822
		private static IntPtr __BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB7 RID: 80823
		private static IntPtr __BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB8 RID: 80824
		private static IntPtr __BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BB9 RID: 80825
		private static IntPtr __BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BBA RID: 80826
		private static IntPtr __BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BBB RID: 80827
		private static IntPtr __BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BBC RID: 80828
		private static IntPtr __BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BBD RID: 80829
		private static IntPtr __BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BBE RID: 80830
		private static IntPtr __BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BBF RID: 80831
		private static IntPtr __BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC0 RID: 80832
		private static IntPtr __BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC1 RID: 80833
		private static IntPtr __BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC2 RID: 80834
		private static IntPtr __BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC3 RID: 80835
		private static IntPtr __BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC4 RID: 80836
		private static IntPtr __BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC5 RID: 80837
		private static IntPtr __BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC6 RID: 80838
		private static IntPtr __BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC7 RID: 80839
		private static IntPtr __BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC8 RID: 80840
		private static IntPtr __BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BC9 RID: 80841
		private static IntPtr __BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BCA RID: 80842
		private static IntPtr __BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BCB RID: 80843
		private static IntPtr __BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BCC RID: 80844
		private static IntPtr __BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BCD RID: 80845
		private static IntPtr __BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BCE RID: 80846
		private static IntPtr __BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_224_OnOpeningEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BCF RID: 80847
		private static IntPtr __BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD0 RID: 80848
		private static IntPtr __BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_222_OnOpeningEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD1 RID: 80849
		private static IntPtr __BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD2 RID: 80850
		private static IntPtr __BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD3 RID: 80851
		private static IntPtr __BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD4 RID: 80852
		private static IntPtr __BndEvt__Button_14_K2Node_ComponentBoundEvent_123_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD5 RID: 80853
		private static IntPtr __BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD6 RID: 80854
		private static IntPtr __BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD7 RID: 80855
		private static IntPtr __BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD8 RID: 80856
		private static IntPtr __BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BD9 RID: 80857
		private static IntPtr __BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BDA RID: 80858
		private static IntPtr __BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BDB RID: 80859
		private static IntPtr __BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BDC RID: 80860
		private static IntPtr __BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BDD RID: 80861
		private static IntPtr __BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BDE RID: 80862
		private static IntPtr __BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BDF RID: 80863
		private static IntPtr __BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013BE0 RID: 80864
		private static IntPtr __BndEvt__Main9_Button_PreferredPreset_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A19D RID: 41373
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetSelectedActor_FunctionParams
		{
			// Token: 0x04031DC3 RID: 204227
			[FieldOffset(0)]
			public int SelectedActorIndex;

			// Token: 0x04031DC4 RID: 204228
			[FieldOffset(8)]
			public IntPtr NinjaLiveActor;
		}

		// Token: 0x0200A19E RID: 41374
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __GetCurrentLevelInfoGUI_FunctionParams
		{
			// Token: 0x04031DC5 RID: 204229
			[FieldOffset(0)]
			public FName LevelName;

			// Token: 0x04031DC6 RID: 204230
			[FieldOffset(12)]
			public FName LevelPath;
		}

		// Token: 0x0200A19F RID: 41375
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__ComboBoxString_89_K2Node_ComponentBoundEvent_4_OnSelectionChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DC7 RID: 204231
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04031DC8 RID: 204232
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x0200A1A0 RID: 41376
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __PreConstruct_FunctionParams
		{
			// Token: 0x04031DC9 RID: 204233
			[FieldOffset(0)]
			public bool IsDesignTime;
		}

		// Token: 0x0200A1A1 RID: 41377
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__ComboBox_Presets_K2Node_ComponentBoundEvent_36_OnSelectionChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DCA RID: 204234
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04031DCB RID: 204235
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x0200A1A2 RID: 41378
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnPresetDuplicationFinished_FunctionParams
		{
			// Token: 0x04031DCC RID: 204236
			[FieldOffset(0)]
			public IntPtr DuplicatedPreset;
		}

		// Token: 0x0200A1A3 RID: 41379
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BndEvt__CheckBox_21_K2Node_ComponentBoundEvent_219_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DCD RID: 204237
			[FieldOffset(0)]
			public bool bIsChecked;
		}

		// Token: 0x0200A1A4 RID: 41380
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04031DCE RID: 204238
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031DCF RID: 204239
			[FieldOffset(56)]
			public float InDeltaTime;
		}

		// Token: 0x0200A1A5 RID: 41381
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__025_SimareaMoOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DD0 RID: 204240
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DD1 RID: 204241
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1A6 RID: 41382
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__50bSpinBox_BrushRnd_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DD2 RID: 204242
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DD3 RID: 204243
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1A7 RID: 41383
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DD4 RID: 204244
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DD5 RID: 204245
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1A8 RID: 41384
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__SpinBox_Divergence_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DD6 RID: 204246
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1A9 RID: 41385
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_Speed_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DD7 RID: 204247
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DD8 RID: 204248
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1AA RID: 41386
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DD9 RID: 204249
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DDA RID: 204250
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1AB RID: 41387
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__SpinBox_Feedback_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DDB RID: 204251
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1AC RID: 41388
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_7_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DDC RID: 204252
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DDD RID: 204253
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1AD RID: 41389
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__SpinBox_DensityNoiseSize_K2Node_ComponentBoundEvent_6_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DDE RID: 204254
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1AE RID: 41390
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_5_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DDF RID: 204255
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DE0 RID: 204256
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1AF RID: 41391
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__SpinBox_DensityNoiseOffset_K2Node_ComponentBoundEvent_3_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DE1 RID: 204257
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1B0 RID: 41392
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DE2 RID: 204258
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DE3 RID: 204259
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1B1 RID: 41393
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__SpinBox_DensityNoiseAmp_K2Node_ComponentBoundEvent_0_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DE4 RID: 204260
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1B2 RID: 41394
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DE5 RID: 204261
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1B3 RID: 41395
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__21cSpinBox_VeloOffset_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DE6 RID: 204262
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DE7 RID: 204263
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1B4 RID: 41396
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DE8 RID: 204264
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1B5 RID: 41397
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_0_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DE9 RID: 204265
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DEA RID: 204266
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1B6 RID: 41398
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__50SpinBox_BrushNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DEB RID: 204267
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DEC RID: 204268
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1B7 RID: 41399
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_Density2_K2Node_ComponentBoundEvent_3_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DED RID: 204269
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DEE RID: 204270
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1B8 RID: 41400
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_Density3_K2Node_ComponentBoundEvent_1_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DEF RID: 204271
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DF0 RID: 204272
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1B9 RID: 41401
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_Density4_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DF1 RID: 204273
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DF2 RID: 204274
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1BA RID: 41402
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__45SpinBox_VeloFromSimAreaMotion_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DF3 RID: 204275
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DF4 RID: 204276
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1BB RID: 41403
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__50ComboBox_NinjaOutputMaterial_K2Node_ComponentBoundEvent_0_OnSelectionChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DF5 RID: 204277
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04031DF6 RID: 204278
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x0200A1BC RID: 41404
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DF7 RID: 204279
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1BD RID: 41405
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__24SpinBox_DirNoise_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DF8 RID: 204280
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DF9 RID: 204281
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1BE RID: 41406
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__41SpinBox_BrushPuncture_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DFA RID: 204282
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DFB RID: 204283
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1BF RID: 41407
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_1_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DFC RID: 204284
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C0 RID: 41408
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_Add01_K2Node_ComponentBoundEvent_0_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DFD RID: 204285
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031DFE RID: 204286
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1C1 RID: 41409
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BndEvt__AddCheckBox1_K2Node_ComponentBoundEvent_0_OnCheckBoxComponentStateChanged__DelegateSignature_FunctionParams
		{
			// Token: 0x04031DFF RID: 204287
			[FieldOffset(0)]
			public bool bIsChecked;
		}

		// Token: 0x0200A1C2 RID: 41410
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__32SpinBox_DensSharpSize_K2Node_ComponentBoundEvent_41_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E00 RID: 204288
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C3 RID: 41411
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__31SpinBox_DensSharpen_K2Node_ComponentBoundEvent_40_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E01 RID: 204289
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C4 RID: 41412
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__29SpinBox_DensHue_K2Node_ComponentBoundEvent_38_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E02 RID: 204290
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C5 RID: 41413
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__28SpinBox_DensContrast_K2Node_ComponentBoundEvent_35_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E03 RID: 204291
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C6 RID: 41414
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__27SpinBox_DensShading_K2Node_ComponentBoundEvent_34_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E04 RID: 204292
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C7 RID: 41415
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__25SpinBox_DensInputWeight_K2Node_ComponentBoundEvent_32_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E05 RID: 204293
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C8 RID: 41416
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__24SpinBox_VeloNoise_K2Node_ComponentBoundEvent_31_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E06 RID: 204294
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1C9 RID: 41417
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__22SpinBox_VeloAmplify_K2Node_ComponentBoundEvent_15_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E07 RID: 204295
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1CA RID: 41418
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__21SpinBox_VeloRotate_K2Node_ComponentBoundEvent_13_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E08 RID: 204296
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1CB RID: 41419
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__20SpinBox_VeloOffsetY_K2Node_ComponentBoundEvent_12_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E09 RID: 204297
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1CC RID: 41420
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__19SpinBox_VeloOffsetX_K2Node_ComponentBoundEvent_10_OnSpinBoxValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E0A RID: 204298
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x0200A1CD RID: 41421
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_63_K2Node_ComponentBoundEvent_228_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E0B RID: 204299
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E0C RID: 204300
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1CE RID: 41422
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_62_K2Node_ComponentBoundEvent_121_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E0D RID: 204301
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E0E RID: 204302
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1CF RID: 41423
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__MultiLineEditableText_MetaData_K2Node_ComponentBoundEvent_26_OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E0F RID: 204303
			[FieldOffset(0)]
			public byte Text;

			// Token: 0x04031E10 RID: 204304
			[FieldOffset(24)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1D0 RID: 41424
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_60_K2Node_ComponentBoundEvent_225_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E11 RID: 204305
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E12 RID: 204306
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1D1 RID: 41425
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__ComboBox_NinjaTemplate3_K2Node_ComponentBoundEvent_223_OnSelectionChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E13 RID: 204307
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04031E14 RID: 204308
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x0200A1D2 RID: 41426
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__ComboBox_NinjaTemplate2_K2Node_ComponentBoundEvent_120_OnSelectionChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E15 RID: 204309
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04031E16 RID: 204310
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x0200A1D3 RID: 41427
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__ComboBox_NinjaTemplate1_K2Node_ComponentBoundEvent_220_OnSelectionChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E17 RID: 204311
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04031E18 RID: 204312
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x0200A1D4 RID: 41428
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_26_K2Node_ComponentBoundEvent_128_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E19 RID: 204313
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E1A RID: 204314
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1D5 RID: 41429
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_22_K2Node_ComponentBoundEvent_102_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E1B RID: 204315
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E1C RID: 204316
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1D6 RID: 41430
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_23_K2Node_ComponentBoundEvent_100_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E1D RID: 204317
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E1E RID: 204318
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1D7 RID: 41431
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_19_K2Node_ComponentBoundEvent_70_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E1F RID: 204319
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E20 RID: 204320
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1D8 RID: 41432
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_18_K2Node_ComponentBoundEvent_94_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E21 RID: 204321
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E22 RID: 204322
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1D9 RID: 41433
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_17_K2Node_ComponentBoundEvent_78_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E23 RID: 204323
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E24 RID: 204324
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1DA RID: 41434
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_16_K2Node_ComponentBoundEvent_76_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E25 RID: 204325
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E26 RID: 204326
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1DB RID: 41435
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_15_K2Node_ComponentBoundEvent_74_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E27 RID: 204327
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E28 RID: 204328
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1DC RID: 41436
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_14_K2Node_ComponentBoundEvent_72_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E29 RID: 204329
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E2A RID: 204330
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1DD RID: 41437
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_12_K2Node_ComponentBoundEvent_64_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E2B RID: 204331
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E2C RID: 204332
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1DE RID: 41438
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_11_K2Node_ComponentBoundEvent_60_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E2D RID: 204333
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E2E RID: 204334
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x0200A1DF RID: 41439
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BndEvt__SpinBox_10_K2Node_ComponentBoundEvent_55_OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E2F RID: 204335
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04031E30 RID: 204336
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}
	}
}
