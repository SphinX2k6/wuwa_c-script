using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D71 RID: 15729
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WeatherData.WeatherData")]
	[UnrealStructLayout(108, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 108)]
	public class WeatherData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060269BF RID: 158143 RVA: 0x00979783 File Offset: 0x00977983
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (WeatherData._ScriptStructPtr != 0) ? WeatherData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WeatherData.WeatherData", ref WeatherData._ScriptStructPtr);
		}

		// Token: 0x17005338 RID: 21304
		// (get) Token: 0x060269C0 RID: 158144 RVA: 0x009797A7 File Offset: 0x009779A7
		// (set) Token: 0x060269C1 RID: 158145 RVA: 0x009797B7 File Offset: 0x009779B7
		public unsafe float CloudsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005339 RID: 21305
		// (get) Token: 0x060269C2 RID: 158146 RVA: 0x009797C8 File Offset: 0x009779C8
		// (set) Token: 0x060269C3 RID: 158147 RVA: 0x009797D8 File Offset: 0x009779D8
		public unsafe float CloudsDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700533A RID: 21306
		// (get) Token: 0x060269C4 RID: 158148 RVA: 0x009797E9 File Offset: 0x009779E9
		// (set) Token: 0x060269C5 RID: 158149 RVA: 0x009797F9 File Offset: 0x009779F9
		public unsafe float CloudsVertexDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700533B RID: 21307
		// (get) Token: 0x060269C6 RID: 158150 RVA: 0x0097980A File Offset: 0x00977A0A
		// (set) Token: 0x060269C7 RID: 158151 RVA: 0x0097981A File Offset: 0x00977A1A
		public unsafe float CloudsHarness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700533C RID: 21308
		// (get) Token: 0x060269C8 RID: 158152 RVA: 0x0097982B File Offset: 0x00977A2B
		// (set) Token: 0x060269C9 RID: 158153 RVA: 0x0097983B File Offset: 0x00977A3B
		public unsafe float CloudsTranslucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700533D RID: 21309
		// (get) Token: 0x060269CA RID: 158154 RVA: 0x0097984C File Offset: 0x00977A4C
		// (set) Token: 0x060269CB RID: 158155 RVA: 0x0097985C File Offset: 0x00977A5C
		public unsafe float CloudsBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700533E RID: 21310
		// (get) Token: 0x060269CC RID: 158156 RVA: 0x0097986D File Offset: 0x00977A6D
		// (set) Token: 0x060269CD RID: 158157 RVA: 0x0097987D File Offset: 0x00977A7D
		public unsafe float CloudsDistotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700533F RID: 21311
		// (get) Token: 0x060269CE RID: 158158 RVA: 0x0097988E File Offset: 0x00977A8E
		// (set) Token: 0x060269CF RID: 158159 RVA: 0x0097989E File Offset: 0x00977A9E
		public unsafe float CloudsScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005340 RID: 21312
		// (get) Token: 0x060269D0 RID: 158160 RVA: 0x009798AF File Offset: 0x00977AAF
		// (set) Token: 0x060269D1 RID: 158161 RVA: 0x009798BF File Offset: 0x00977ABF
		public unsafe float CloudsUpperBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005341 RID: 21313
		// (get) Token: 0x060269D2 RID: 158162 RVA: 0x009798D0 File Offset: 0x00977AD0
		// (set) Token: 0x060269D3 RID: 158163 RVA: 0x009798E0 File Offset: 0x00977AE0
		public unsafe float CloudsLowerBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005342 RID: 21314
		// (get) Token: 0x060269D4 RID: 158164 RVA: 0x009798F1 File Offset: 0x00977AF1
		// (set) Token: 0x060269D5 RID: 158165 RVA: 0x00979901 File Offset: 0x00977B01
		public unsafe float CloudsAmbient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005343 RID: 21315
		// (get) Token: 0x060269D6 RID: 158166 RVA: 0x00979912 File Offset: 0x00977B12
		// (set) Token: 0x060269D7 RID: 158167 RVA: 0x00979922 File Offset: 0x00977B22
		public unsafe float CloudsShadowSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005344 RID: 21316
		// (get) Token: 0x060269D8 RID: 158168 RVA: 0x00979933 File Offset: 0x00977B33
		// (set) Token: 0x060269D9 RID: 158169 RVA: 0x00979943 File Offset: 0x00977B43
		public unsafe float CloudsShadowSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005345 RID: 21317
		// (get) Token: 0x060269DA RID: 158170 RVA: 0x00979954 File Offset: 0x00977B54
		// (set) Token: 0x060269DB RID: 158171 RVA: 0x00979964 File Offset: 0x00977B64
		public unsafe float CloudsBackground
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005346 RID: 21318
		// (get) Token: 0x060269DC RID: 158172 RVA: 0x00979975 File Offset: 0x00977B75
		// (set) Token: 0x060269DD RID: 158173 RVA: 0x00979985 File Offset: 0x00977B85
		public unsafe float CloudsHorizonDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005347 RID: 21319
		// (get) Token: 0x060269DE RID: 158174 RVA: 0x00979996 File Offset: 0x00977B96
		// (set) Token: 0x060269DF RID: 158175 RVA: 0x009799A6 File Offset: 0x00977BA6
		public unsafe float CloudsHorizonAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005348 RID: 21320
		// (get) Token: 0x060269E0 RID: 158176 RVA: 0x009799B7 File Offset: 0x00977BB7
		// (set) Token: 0x060269E1 RID: 158177 RVA: 0x009799C7 File Offset: 0x00977BC7
		public unsafe float CloudsHorizonScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005349 RID: 21321
		// (get) Token: 0x060269E2 RID: 158178 RVA: 0x009799D8 File Offset: 0x00977BD8
		// (set) Token: 0x060269E3 RID: 158179 RVA: 0x009799E8 File Offset: 0x00977BE8
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700534A RID: 21322
		// (get) Token: 0x060269E4 RID: 158180 RVA: 0x009799F9 File Offset: 0x00977BF9
		// (set) Token: 0x060269E5 RID: 158181 RVA: 0x00979A09 File Offset: 0x00977C09
		public unsafe float WindForceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700534B RID: 21323
		// (get) Token: 0x060269E6 RID: 158182 RVA: 0x00979A1A File Offset: 0x00977C1A
		// (set) Token: 0x060269E7 RID: 158183 RVA: 0x00979A2A File Offset: 0x00977C2A
		public unsafe float WindDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700534C RID: 21324
		// (get) Token: 0x060269E8 RID: 158184 RVA: 0x00979A3B File Offset: 0x00977C3B
		// (set) Token: 0x060269E9 RID: 158185 RVA: 0x00979A4B File Offset: 0x00977C4B
		public unsafe float WindDispersing_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700534D RID: 21325
		// (get) Token: 0x060269EA RID: 158186 RVA: 0x00979A5C File Offset: 0x00977C5C
		// (set) Token: 0x060269EB RID: 158187 RVA: 0x00979A6C File Offset: 0x00977C6C
		public unsafe float SkylightBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700534E RID: 21326
		// (get) Token: 0x060269EC RID: 158188 RVA: 0x00979A7D File Offset: 0x00977C7D
		// (set) Token: 0x060269ED RID: 158189 RVA: 0x00979A8D File Offset: 0x00977C8D
		public unsafe float SecondLayerHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700534F RID: 21327
		// (get) Token: 0x060269EE RID: 158190 RVA: 0x00979A9E File Offset: 0x00977C9E
		// (set) Token: 0x060269EF RID: 158191 RVA: 0x00979AAE File Offset: 0x00977CAE
		public unsafe float SecondLayerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005350 RID: 21328
		// (get) Token: 0x060269F0 RID: 158192 RVA: 0x00979ABF File Offset: 0x00977CBF
		// (set) Token: 0x060269F1 RID: 158193 RVA: 0x00979ACF File Offset: 0x00977CCF
		public unsafe float SecondLayerAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005351 RID: 21329
		// (get) Token: 0x060269F2 RID: 158194 RVA: 0x00979AE0 File Offset: 0x00977CE0
		// (set) Token: 0x060269F3 RID: 158195 RVA: 0x00979AF0 File Offset: 0x00977CF0
		public unsafe float SecondLayerScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005352 RID: 21330
		// (get) Token: 0x060269F4 RID: 158196 RVA: 0x00979B01 File Offset: 0x00977D01
		// (set) Token: 0x060269F5 RID: 158197 RVA: 0x00979B11 File Offset: 0x00977D11
		public unsafe float SecondLayerWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WeatherData.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x060269F6 RID: 158198 RVA: 0x00979B22 File Offset: 0x00977D22
		public WeatherData()
		{
		}

		// Token: 0x060269F7 RID: 158199 RVA: 0x00979B2C File Offset: 0x00977D2C
		public WeatherData(float CloudsScale, float CloudsDensity, float CloudsVertexDensity, float CloudsHarness, float CloudsTranslucent, float CloudsBlend, float CloudsDistotion, float CloudsScattering, float CloudsUpperBrightness, float CloudsLowerBrightness, float CloudsAmbient, float CloudsShadowSize, float CloudsShadowSoft, float CloudsBackground, float CloudsHorizonDensity, float CloudsHorizonAlpha, float CloudsHorizonScattering, float HorizonFalloff, float WindForceScale, float WindDynamic, float WindDispersing_, float SkylightBrightness, float SecondLayerHardness, float SecondLayerColor, float SecondLayerAlpha, float SecondLayerScale, float SecondLayerWind)
		{
			this.CloudsScale = CloudsScale;
			this.CloudsDensity = CloudsDensity;
			this.CloudsVertexDensity = CloudsVertexDensity;
			this.CloudsHarness = CloudsHarness;
			this.CloudsTranslucent = CloudsTranslucent;
			this.CloudsBlend = CloudsBlend;
			this.CloudsDistotion = CloudsDistotion;
			this.CloudsScattering = CloudsScattering;
			this.CloudsUpperBrightness = CloudsUpperBrightness;
			this.CloudsLowerBrightness = CloudsLowerBrightness;
			this.CloudsAmbient = CloudsAmbient;
			this.CloudsShadowSize = CloudsShadowSize;
			this.CloudsShadowSoft = CloudsShadowSoft;
			this.CloudsBackground = CloudsBackground;
			this.CloudsHorizonDensity = CloudsHorizonDensity;
			this.CloudsHorizonAlpha = CloudsHorizonAlpha;
			this.CloudsHorizonScattering = CloudsHorizonScattering;
			this.HorizonFalloff = HorizonFalloff;
			this.WindForceScale = WindForceScale;
			this.WindDynamic = WindDynamic;
			this.WindDispersing_ = WindDispersing_;
			this.SkylightBrightness = SkylightBrightness;
			this.SecondLayerHardness = SecondLayerHardness;
			this.SecondLayerColor = SecondLayerColor;
			this.SecondLayerAlpha = SecondLayerAlpha;
			this.SecondLayerScale = SecondLayerScale;
			this.SecondLayerWind = SecondLayerWind;
		}

		// Token: 0x060269F8 RID: 158200 RVA: 0x00979C14 File Offset: 0x00977E14
		protected override IntPtr GetUStructPtr()
		{
			return WeatherData.StaticStruct();
		}

		// Token: 0x060269F9 RID: 158201 RVA: 0x00979C20 File Offset: 0x00977E20
		[NullableContext(2)]
		public WeatherData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060269FA RID: 158202 RVA: 0x00979C2A File Offset: 0x00977E2A
		public WeatherData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060269FB RID: 158203 RVA: 0x00979C35 File Offset: 0x00977E35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new WeatherData(Pointer, false, true);
		}

		// Token: 0x060269FC RID: 158204 RVA: 0x00979C3F File Offset: 0x00977E3F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new WeatherData(Pointer, MemoryOwner);
		}

		// Token: 0x04013673 RID: 79475
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WeatherData.WeatherData";

		// Token: 0x04013674 RID: 79476
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013675 RID: 79477
		internal static int __PropertyOffset_0;

		// Token: 0x04013676 RID: 79478
		internal static int __PropertyOffset_1;

		// Token: 0x04013677 RID: 79479
		internal static int __PropertyOffset_2;

		// Token: 0x04013678 RID: 79480
		internal static int __PropertyOffset_3;

		// Token: 0x04013679 RID: 79481
		internal static int __PropertyOffset_4;

		// Token: 0x0401367A RID: 79482
		internal static int __PropertyOffset_5;

		// Token: 0x0401367B RID: 79483
		internal static int __PropertyOffset_6;

		// Token: 0x0401367C RID: 79484
		internal static int __PropertyOffset_7;

		// Token: 0x0401367D RID: 79485
		internal static int __PropertyOffset_8;

		// Token: 0x0401367E RID: 79486
		internal static int __PropertyOffset_9;

		// Token: 0x0401367F RID: 79487
		internal static int __PropertyOffset_10;

		// Token: 0x04013680 RID: 79488
		internal static int __PropertyOffset_11;

		// Token: 0x04013681 RID: 79489
		internal static int __PropertyOffset_12;

		// Token: 0x04013682 RID: 79490
		internal static int __PropertyOffset_13;

		// Token: 0x04013683 RID: 79491
		internal static int __PropertyOffset_14;

		// Token: 0x04013684 RID: 79492
		internal static int __PropertyOffset_15;

		// Token: 0x04013685 RID: 79493
		internal static int __PropertyOffset_16;

		// Token: 0x04013686 RID: 79494
		internal static int __PropertyOffset_17;

		// Token: 0x04013687 RID: 79495
		internal static int __PropertyOffset_18;

		// Token: 0x04013688 RID: 79496
		internal static int __PropertyOffset_19;

		// Token: 0x04013689 RID: 79497
		internal static int __PropertyOffset_20;

		// Token: 0x0401368A RID: 79498
		internal static int __PropertyOffset_21;

		// Token: 0x0401368B RID: 79499
		internal static int __PropertyOffset_22;

		// Token: 0x0401368C RID: 79500
		internal static int __PropertyOffset_23;

		// Token: 0x0401368D RID: 79501
		internal static int __PropertyOffset_24;

		// Token: 0x0401368E RID: 79502
		internal static int __PropertyOffset_25;

		// Token: 0x0401368F RID: 79503
		internal static int __PropertyOffset_26;
	}
}
