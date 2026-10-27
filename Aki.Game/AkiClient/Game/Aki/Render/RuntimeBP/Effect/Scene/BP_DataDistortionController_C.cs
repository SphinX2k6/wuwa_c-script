using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DC7 RID: 15815
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_DataDistortionController.BP_DataDistortionController_C")]
	[UnrealStructLayout(2464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2460)]
	public class BP_DataDistortionController_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060275DA RID: 161242 RVA: 0x0098F334 File Offset: 0x0098D534
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DataDistortionController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_DataDistortionController.BP_DataDistortionController_C");
			}
			return BP_DataDistortionController_C._ClassPtr;
		}

		// Token: 0x060275DB RID: 161243 RVA: 0x0098F358 File Offset: 0x0098D558
		public BP_DataDistortionController_C() : this(BuiltinUtils.AllocNativeUObject(BP_DataDistortionController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060275DC RID: 161244 RVA: 0x0098F380 File Offset: 0x0098D580
		public BP_DataDistortionController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DataDistortionController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170057B9 RID: 22457
		// (get) Token: 0x060275DD RID: 161245 RVA: 0x0098F3B3 File Offset: 0x0098D5B3
		// (set) Token: 0x060275DE RID: 161246 RVA: 0x0098F3C7 File Offset: 0x0098D5C7
		[Nullable(2)]
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DataDistortionController_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DataDistortionController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170057BA RID: 22458
		// (get) Token: 0x060275DF RID: 161247 RVA: 0x0098F3DC File Offset: 0x0098D5DC
		// (set) Token: 0x060275E0 RID: 161248 RVA: 0x0098F3F0 File Offset: 0x0098D5F0
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DataDistortionController_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DataDistortionController_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170057BB RID: 22459
		// (get) Token: 0x060275E1 RID: 161249 RVA: 0x0098F405 File Offset: 0x0098D605
		// (set) Token: 0x060275E2 RID: 161250 RVA: 0x0098F415 File Offset: 0x0098D615
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170057BC RID: 22460
		// (get) Token: 0x060275E3 RID: 161251 RVA: 0x0098F426 File Offset: 0x0098D626
		// (set) Token: 0x060275E4 RID: 161252 RVA: 0x0098F436 File Offset: 0x0098D636
		public unsafe float Process
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170057BD RID: 22461
		// (get) Token: 0x060275E5 RID: 161253 RVA: 0x0098F447 File Offset: 0x0098D647
		// (set) Token: 0x060275E6 RID: 161254 RVA: 0x0098F457 File Offset: 0x0098D657
		public unsafe float WiggleAmpScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170057BE RID: 22462
		// (get) Token: 0x060275E7 RID: 161255 RVA: 0x0098F468 File Offset: 0x0098D668
		// (set) Token: 0x060275E8 RID: 161256 RVA: 0x0098F4A1 File Offset: 0x0098D6A1
		public TArray<FKuroCurveFloat> WiggleCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCurveFloat> result;
				if ((result = this._WiggleCurves) == null)
				{
					result = (this._WiggleCurves = new TArray<FKuroCurveFloat>(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.WiggleCurves.CopyAssign(value);
			}
		}

		// Token: 0x170057BF RID: 22463
		// (get) Token: 0x060275E9 RID: 161257 RVA: 0x0098F4B0 File Offset: 0x0098D6B0
		// (set) Token: 0x060275EA RID: 161258 RVA: 0x0098F4E9 File Offset: 0x0098D6E9
		public TArray<float> WiggleCurvePeriods
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._WiggleCurvePeriods) == null)
				{
					result = (this._WiggleCurvePeriods = new TArray<float>(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.WiggleCurvePeriods.CopyAssign(value);
			}
		}

		// Token: 0x170057C0 RID: 22464
		// (get) Token: 0x060275EB RID: 161259 RVA: 0x0098F4F7 File Offset: 0x0098D6F7
		// (set) Token: 0x060275EC RID: 161260 RVA: 0x0098F507 File Offset: 0x0098D707
		public unsafe float WiggleFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170057C1 RID: 22465
		// (get) Token: 0x060275ED RID: 161261 RVA: 0x0098F518 File Offset: 0x0098D718
		// (set) Token: 0x060275EE RID: 161262 RVA: 0x0098F528 File Offset: 0x0098D728
		public unsafe float WiggleYFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170057C2 RID: 22466
		// (get) Token: 0x060275EF RID: 161263 RVA: 0x0098F539 File Offset: 0x0098D739
		// (set) Token: 0x060275F0 RID: 161264 RVA: 0x0098F549 File Offset: 0x0098D749
		public unsafe float WiggleYAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170057C3 RID: 22467
		// (get) Token: 0x060275F1 RID: 161265 RVA: 0x0098F55C File Offset: 0x0098D75C
		// (set) Token: 0x060275F2 RID: 161266 RVA: 0x0098F595 File Offset: 0x0098D795
		public FKuroCurveLinearColor ColorCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._ColorCurve) == null)
				{
					result = (this._ColorCurve = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170057C4 RID: 22468
		// (get) Token: 0x060275F3 RID: 161267 RVA: 0x0098F5B8 File Offset: 0x0098D7B8
		// (set) Token: 0x060275F4 RID: 161268 RVA: 0x0098F5F1 File Offset: 0x0098D7F1
		public FKuroCurveFloat SignalCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SignalCurve) == null)
				{
					result = (this._SignalCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170057C5 RID: 22469
		// (get) Token: 0x060275F5 RID: 161269 RVA: 0x0098F614 File Offset: 0x0098D814
		// (set) Token: 0x060275F6 RID: 161270 RVA: 0x0098F64D File Offset: 0x0098D84D
		public FKuroCurveFloat SignalColorCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SignalColorCurve) == null)
				{
					result = (this._SignalColorCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170057C6 RID: 22470
		// (get) Token: 0x060275F7 RID: 161271 RVA: 0x0098F66E File Offset: 0x0098D86E
		// (set) Token: 0x060275F8 RID: 161272 RVA: 0x0098F67E File Offset: 0x0098D87E
		public unsafe float SignaPeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170057C7 RID: 22471
		// (get) Token: 0x060275F9 RID: 161273 RVA: 0x0098F68F File Offset: 0x0098D88F
		// (set) Token: 0x060275FA RID: 161274 RVA: 0x0098F69F File Offset: 0x0098D89F
		public unsafe float SignaFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170057C8 RID: 22472
		// (get) Token: 0x060275FB RID: 161275 RVA: 0x0098F6B0 File Offset: 0x0098D8B0
		// (set) Token: 0x060275FC RID: 161276 RVA: 0x0098F6C0 File Offset: 0x0098D8C0
		public unsafe float SignaSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170057C9 RID: 22473
		// (get) Token: 0x060275FD RID: 161277 RVA: 0x0098F6D1 File Offset: 0x0098D8D1
		// (set) Token: 0x060275FE RID: 161278 RVA: 0x0098F6E1 File Offset: 0x0098D8E1
		public unsafe float 抖动强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170057CA RID: 22474
		// (get) Token: 0x060275FF RID: 161279 RVA: 0x0098F6F2 File Offset: 0x0098D8F2
		// (set) Token: 0x06027600 RID: 161280 RVA: 0x0098F702 File Offset: 0x0098D902
		public unsafe float 抖动触发频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170057CB RID: 22475
		// (get) Token: 0x06027601 RID: 161281 RVA: 0x0098F713 File Offset: 0x0098D913
		// (set) Token: 0x06027602 RID: 161282 RVA: 0x0098F723 File Offset: 0x0098D923
		public unsafe float 抖动触发概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170057CC RID: 22476
		// (get) Token: 0x06027603 RID: 161283 RVA: 0x0098F734 File Offset: 0x0098D934
		// (set) Token: 0x06027604 RID: 161284 RVA: 0x0098F744 File Offset: 0x0098D944
		public unsafe float 每次抖动最小时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170057CD RID: 22477
		// (get) Token: 0x06027605 RID: 161285 RVA: 0x0098F755 File Offset: 0x0098D955
		// (set) Token: 0x06027606 RID: 161286 RVA: 0x0098F765 File Offset: 0x0098D965
		public unsafe float 每次抖动最大时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170057CE RID: 22478
		// (get) Token: 0x06027607 RID: 161287 RVA: 0x0098F776 File Offset: 0x0098D976
		// (set) Token: 0x06027608 RID: 161288 RVA: 0x0098F786 File Offset: 0x0098D986
		public unsafe float 扰动强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170057CF RID: 22479
		// (get) Token: 0x06027609 RID: 161289 RVA: 0x0098F797 File Offset: 0x0098D997
		// (set) Token: 0x0602760A RID: 161290 RVA: 0x0098F7A7 File Offset: 0x0098D9A7
		public unsafe float 扰动触发频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170057D0 RID: 22480
		// (get) Token: 0x0602760B RID: 161291 RVA: 0x0098F7B8 File Offset: 0x0098D9B8
		// (set) Token: 0x0602760C RID: 161292 RVA: 0x0098F7C8 File Offset: 0x0098D9C8
		public unsafe float 扰动触发概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170057D1 RID: 22481
		// (get) Token: 0x0602760D RID: 161293 RVA: 0x0098F7D9 File Offset: 0x0098D9D9
		// (set) Token: 0x0602760E RID: 161294 RVA: 0x0098F7E9 File Offset: 0x0098D9E9
		public unsafe int WiggleCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170057D2 RID: 22482
		// (get) Token: 0x0602760F RID: 161295 RVA: 0x0098F7FA File Offset: 0x0098D9FA
		// (set) Token: 0x06027610 RID: 161296 RVA: 0x0098F80A File Offset: 0x0098DA0A
		public unsafe int SignalCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170057D3 RID: 22483
		// (get) Token: 0x06027611 RID: 161297 RVA: 0x0098F81B File Offset: 0x0098DA1B
		// (set) Token: 0x06027612 RID: 161298 RVA: 0x0098F82B File Offset: 0x0098DA2B
		public unsafe float 每次扰动最小时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170057D4 RID: 22484
		// (get) Token: 0x06027613 RID: 161299 RVA: 0x0098F83C File Offset: 0x0098DA3C
		// (set) Token: 0x06027614 RID: 161300 RVA: 0x0098F84C File Offset: 0x0098DA4C
		public unsafe float 每次扰动最大时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170057D5 RID: 22485
		// (get) Token: 0x06027615 RID: 161301 RVA: 0x0098F85D File Offset: 0x0098DA5D
		// (set) Token: 0x06027616 RID: 161302 RVA: 0x0098F86D File Offset: 0x0098DA6D
		public unsafe float WiggleTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170057D6 RID: 22486
		// (get) Token: 0x06027617 RID: 161303 RVA: 0x0098F87E File Offset: 0x0098DA7E
		// (set) Token: 0x06027618 RID: 161304 RVA: 0x0098F88E File Offset: 0x0098DA8E
		public unsafe float SignalTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170057D7 RID: 22487
		// (get) Token: 0x06027619 RID: 161305 RVA: 0x0098F89F File Offset: 0x0098DA9F
		// (set) Token: 0x0602761A RID: 161306 RVA: 0x0098F8B3 File Offset: 0x0098DAB3
		public unsafe FVector WaveDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170057D8 RID: 22488
		// (get) Token: 0x0602761B RID: 161307 RVA: 0x0098F8C8 File Offset: 0x0098DAC8
		// (set) Token: 0x0602761C RID: 161308 RVA: 0x0098F8D8 File Offset: 0x0098DAD8
		public unsafe float Wave_Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170057D9 RID: 22489
		// (get) Token: 0x0602761D RID: 161309 RVA: 0x0098F8E9 File Offset: 0x0098DAE9
		// (set) Token: 0x0602761E RID: 161310 RVA: 0x0098F8F9 File Offset: 0x0098DAF9
		public unsafe float Wave_Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170057DA RID: 22490
		// (get) Token: 0x0602761F RID: 161311 RVA: 0x0098F90A File Offset: 0x0098DB0A
		// (set) Token: 0x06027620 RID: 161312 RVA: 0x0098F91A File Offset: 0x0098DB1A
		public unsafe float Wave_Phase_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DataDistortionController_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x06027621 RID: 161313 RVA: 0x0098F92B File Offset: 0x0098DB2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDataDistortionControl()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DataDistortionController_C.__UpdateDataDistortionControl_NativeFunctionPtr, null);
		}

		// Token: 0x06027622 RID: 161314 RVA: 0x0098F93F File Offset: 0x0098DB3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDataDistortion()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DataDistortionController_C.__UpdateDataDistortion_NativeFunctionPtr, null);
		}

		// Token: 0x06027623 RID: 161315 RVA: 0x0098F953 File Offset: 0x0098DB53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DataDistortionController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027624 RID: 161316 RVA: 0x0098F967 File Offset: 0x0098DB67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DataDistortionController_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027625 RID: 161317 RVA: 0x0098F97C File Offset: 0x0098DB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DataDistortionController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DataDistortionController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DataDistortionController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DataDistortionController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DataDistortionController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027626 RID: 161318 RVA: 0x0098F9C4 File Offset: 0x0098DBC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DataDistortionController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DataDistortionController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DataDistortionController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DataDistortionController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DataDistortionController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027627 RID: 161319 RVA: 0x0098FA0C File Offset: 0x0098DC0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_DataDistortionController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_DataDistortionController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DataDistortionController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DataDistortionController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DataDistortionController_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027628 RID: 161320 RVA: 0x0098FA54 File Offset: 0x0098DC54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_DataDistortionController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_DataDistortionController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DataDistortionController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DataDistortionController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DataDistortionController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027629 RID: 161321 RVA: 0x0098FA9B File Offset: 0x0098DC9B
		protected BP_DataDistortionController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013DEB RID: 81387
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_DataDistortionController.BP_DataDistortionController_C";

		// Token: 0x04013DEC RID: 81388
		private static IntPtr _ClassPtr;

		// Token: 0x04013DED RID: 81389
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013DEE RID: 81390
		internal static int __PropertyOffset_1;

		// Token: 0x04013DEF RID: 81391
		internal static int __PropertyOffset_2;

		// Token: 0x04013DF0 RID: 81392
		internal static int __PropertyOffset_3;

		// Token: 0x04013DF1 RID: 81393
		internal static int __PropertyOffset_4;

		// Token: 0x04013DF2 RID: 81394
		internal static int __PropertyOffset_5;

		// Token: 0x04013DF3 RID: 81395
		internal static int __PropertyOffset_6;

		// Token: 0x04013DF4 RID: 81396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCurveFloat> _WiggleCurves;

		// Token: 0x04013DF5 RID: 81397
		internal static int __PropertyOffset_7;

		// Token: 0x04013DF6 RID: 81398
		[Nullable(2)]
		private TArray<float> _WiggleCurvePeriods;

		// Token: 0x04013DF7 RID: 81399
		internal static int __PropertyOffset_8;

		// Token: 0x04013DF8 RID: 81400
		internal static int __PropertyOffset_9;

		// Token: 0x04013DF9 RID: 81401
		internal static int __PropertyOffset_10;

		// Token: 0x04013DFA RID: 81402
		internal static int __PropertyOffset_11;

		// Token: 0x04013DFB RID: 81403
		[Nullable(2)]
		private FKuroCurveLinearColor _ColorCurve;

		// Token: 0x04013DFC RID: 81404
		internal static int __PropertyOffset_12;

		// Token: 0x04013DFD RID: 81405
		[Nullable(2)]
		private FKuroCurveFloat _SignalCurve;

		// Token: 0x04013DFE RID: 81406
		internal static int __PropertyOffset_13;

		// Token: 0x04013DFF RID: 81407
		[Nullable(2)]
		private FKuroCurveFloat _SignalColorCurve;

		// Token: 0x04013E00 RID: 81408
		internal static int __PropertyOffset_14;

		// Token: 0x04013E01 RID: 81409
		internal static int __PropertyOffset_15;

		// Token: 0x04013E02 RID: 81410
		internal static int __PropertyOffset_16;

		// Token: 0x04013E03 RID: 81411
		internal static int __PropertyOffset_17;

		// Token: 0x04013E04 RID: 81412
		internal static int __PropertyOffset_18;

		// Token: 0x04013E05 RID: 81413
		internal static int __PropertyOffset_19;

		// Token: 0x04013E06 RID: 81414
		internal static int __PropertyOffset_20;

		// Token: 0x04013E07 RID: 81415
		internal static int __PropertyOffset_21;

		// Token: 0x04013E08 RID: 81416
		internal static int __PropertyOffset_22;

		// Token: 0x04013E09 RID: 81417
		internal static int __PropertyOffset_23;

		// Token: 0x04013E0A RID: 81418
		internal static int __PropertyOffset_24;

		// Token: 0x04013E0B RID: 81419
		internal static int __PropertyOffset_25;

		// Token: 0x04013E0C RID: 81420
		internal static int __PropertyOffset_26;

		// Token: 0x04013E0D RID: 81421
		internal static int __PropertyOffset_27;

		// Token: 0x04013E0E RID: 81422
		internal static int __PropertyOffset_28;

		// Token: 0x04013E0F RID: 81423
		internal static int __PropertyOffset_29;

		// Token: 0x04013E10 RID: 81424
		internal static int __PropertyOffset_30;

		// Token: 0x04013E11 RID: 81425
		internal static int __PropertyOffset_31;

		// Token: 0x04013E12 RID: 81426
		internal static int __PropertyOffset_32;

		// Token: 0x04013E13 RID: 81427
		internal static int __PropertyOffset_33;

		// Token: 0x04013E14 RID: 81428
		internal static int __PropertyOffset_34;

		// Token: 0x04013E15 RID: 81429
		private static IntPtr __UpdateDataDistortionControl_NativeFunctionPtr;

		// Token: 0x04013E16 RID: 81430
		private static IntPtr __UpdateDataDistortion_NativeFunctionPtr;

		// Token: 0x04013E17 RID: 81431
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013E18 RID: 81432
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013E19 RID: 81433
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A21C RID: 41500
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E86 RID: 204422
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A21D RID: 41501
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031E87 RID: 204423
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
