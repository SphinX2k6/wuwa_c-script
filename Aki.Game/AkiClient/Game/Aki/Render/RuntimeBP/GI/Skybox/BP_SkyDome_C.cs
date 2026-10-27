using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Skybox
{
	// Token: 0x02003D45 RID: 15685
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C")]
	[UnrealStructLayout(2696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2692)]
	public class BP_SkyDome_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060261B0 RID: 156080 RVA: 0x0096BA88 File Offset: 0x00969C88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SkyDome_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C");
			}
			return BP_SkyDome_C._ClassPtr;
		}

		// Token: 0x060261B1 RID: 156081 RVA: 0x0096BAAC File Offset: 0x00969CAC
		public BP_SkyDome_C() : this(BuiltinUtils.AllocNativeUObject(BP_SkyDome_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060261B2 RID: 156082 RVA: 0x0096BAD4 File Offset: 0x00969CD4
		[NullableContext(1)]
		public BP_SkyDome_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SkyDome_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x060261B3 RID: 156083 RVA: 0x0096BB07 File Offset: 0x00969D07
		// (set) Token: 0x060261B4 RID: 156084 RVA: 0x0096BB1B File Offset: 0x00969D1B
		public unsafe UStaticMeshComponent Dummy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x060261B5 RID: 156085 RVA: 0x0096BB30 File Offset: 0x00969D30
		// (set) Token: 0x060261B6 RID: 156086 RVA: 0x0096BB44 File Offset: 0x00969D44
		public unsafe UStaticMeshComponent SkyMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x060261B7 RID: 156087 RVA: 0x0096BB59 File Offset: 0x00969D59
		// (set) Token: 0x060261B8 RID: 156088 RVA: 0x0096BB6D File Offset: 0x00969D6D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005074 RID: 20596
		// (get) Token: 0x060261B9 RID: 156089 RVA: 0x0096BB82 File Offset: 0x00969D82
		// (set) Token: 0x060261BA RID: 156090 RVA: 0x0096BB92 File Offset: 0x00969D92
		public unsafe float TimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005075 RID: 20597
		// (get) Token: 0x060261BB RID: 156091 RVA: 0x0096BBA3 File Offset: 0x00969DA3
		// (set) Token: 0x060261BC RID: 156092 RVA: 0x0096BBB3 File Offset: 0x00969DB3
		public unsafe float TimeChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005076 RID: 20598
		// (get) Token: 0x060261BD RID: 156093 RVA: 0x0096BBC4 File Offset: 0x00969DC4
		// (set) Token: 0x060261BE RID: 156094 RVA: 0x0096BBD4 File Offset: 0x00969DD4
		public unsafe float TimeCycleDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005077 RID: 20599
		// (get) Token: 0x060261BF RID: 156095 RVA: 0x0096BBE5 File Offset: 0x00969DE5
		// (set) Token: 0x060261C0 RID: 156096 RVA: 0x0096BBF5 File Offset: 0x00969DF5
		public unsafe bool UseTimeOfDayCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005078 RID: 20600
		// (get) Token: 0x060261C1 RID: 156097 RVA: 0x0096BC08 File Offset: 0x00969E08
		// (set) Token: 0x060261C2 RID: 156098 RVA: 0x0096BC41 File Offset: 0x00969E41
		[Nullable(1)]
		public TimeOfDayCurves TimeOfDayCurves
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TimeOfDayCurves result;
				if ((result = this._TimeOfDayCurves) == null)
				{
					result = (this._TimeOfDayCurves = new TimeOfDayCurves(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(TimeOfDayCurves.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005079 RID: 20601
		// (get) Token: 0x060261C3 RID: 156099 RVA: 0x0096BC64 File Offset: 0x00969E64
		// (set) Token: 0x060261C4 RID: 156100 RVA: 0x0096BC9D File Offset: 0x00969E9D
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<WeatherPreset_C>> WeatherPresetList
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<WeatherPreset_C>> result;
				if ((result = this._WeatherPresetList) == null)
				{
					result = (this._WeatherPresetList = new TArray<TSubclassOf<WeatherPreset_C>>(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.WeatherPresetList.CopyAssign(value);
			}
		}

		// Token: 0x1700507A RID: 20602
		// (get) Token: 0x060261C5 RID: 156101 RVA: 0x0096BCAB File Offset: 0x00969EAB
		// (set) Token: 0x060261C6 RID: 156102 RVA: 0x0096BCBB File Offset: 0x00969EBB
		public unsafe int SelectedWeatherPreset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700507B RID: 20603
		// (get) Token: 0x060261C7 RID: 156103 RVA: 0x0096BCCC File Offset: 0x00969ECC
		// (set) Token: 0x060261C8 RID: 156104 RVA: 0x0096BCE0 File Offset: 0x00969EE0
		[Nullable(0)]
		public unsafe TEnumAsByte<PresetSelection> WeatherChangeMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700507C RID: 20604
		// (get) Token: 0x060261C9 RID: 156105 RVA: 0x0096BCF5 File Offset: 0x00969EF5
		// (set) Token: 0x060261CA RID: 156106 RVA: 0x0096BD05 File Offset: 0x00969F05
		public unsafe float WeatherChangeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700507D RID: 20605
		// (get) Token: 0x060261CB RID: 156107 RVA: 0x0096BD16 File Offset: 0x00969F16
		// (set) Token: 0x060261CC RID: 156108 RVA: 0x0096BD2A File Offset: 0x00969F2A
		[Nullable(0)]
		public unsafe TEnumAsByte<EEasingFunc> WeatherChangeTransition
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x060261CD RID: 156109 RVA: 0x0096BD3F File Offset: 0x00969F3F
		// (set) Token: 0x060261CE RID: 156110 RVA: 0x0096BD4F File Offset: 0x00969F4F
		public unsafe float WeatherChangeAfterTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700507F RID: 20607
		// (get) Token: 0x060261CF RID: 156111 RVA: 0x0096BD60 File Offset: 0x00969F60
		// (set) Token: 0x060261D0 RID: 156112 RVA: 0x0096BD99 File Offset: 0x00969F99
		[Nullable(1)]
		public TimeOfDayData TimeOfDaySettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TimeOfDayData result;
				if ((result = this._TimeOfDaySettings) == null)
				{
					result = (this._TimeOfDaySettings = new TimeOfDayData(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(TimeOfDayData.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_15, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005080 RID: 20608
		// (get) Token: 0x060261D1 RID: 156113 RVA: 0x0096BDBC File Offset: 0x00969FBC
		// (set) Token: 0x060261D2 RID: 156114 RVA: 0x0096BDF5 File Offset: 0x00969FF5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<TimeOfDayPreset_C>> TimeOfDayPresetList
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<TimeOfDayPreset_C>> result;
				if ((result = this._TimeOfDayPresetList) == null)
				{
					result = (this._TimeOfDayPresetList = new TArray<TSubclassOf<TimeOfDayPreset_C>>(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.TimeOfDayPresetList.CopyAssign(value);
			}
		}

		// Token: 0x17005081 RID: 20609
		// (get) Token: 0x060261D3 RID: 156115 RVA: 0x0096BE04 File Offset: 0x0096A004
		// (set) Token: 0x060261D4 RID: 156116 RVA: 0x0096BE3D File Offset: 0x0096A03D
		[Nullable(1)]
		public PresetChangeInfo TimeOfDayPresetChange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				PresetChangeInfo result;
				if ((result = this._TimeOfDayPresetChange) == null)
				{
					result = (this._TimeOfDayPresetChange = new PresetChangeInfo(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_17, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PresetChangeInfo.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_17, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005082 RID: 20610
		// (get) Token: 0x060261D5 RID: 156117 RVA: 0x0096BE5E File Offset: 0x0096A05E
		// (set) Token: 0x060261D6 RID: 156118 RVA: 0x0096BE72 File Offset: 0x0096A072
		public unsafe FRotator MoonDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005083 RID: 20611
		// (get) Token: 0x060261D7 RID: 156119 RVA: 0x0096BE87 File Offset: 0x0096A087
		// (set) Token: 0x060261D8 RID: 156120 RVA: 0x0096BE97 File Offset: 0x0096A097
		public unsafe float SunHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005084 RID: 20612
		// (get) Token: 0x060261D9 RID: 156121 RVA: 0x0096BEA8 File Offset: 0x0096A0A8
		// (set) Token: 0x060261DA RID: 156122 RVA: 0x0096BEE1 File Offset: 0x0096A0E1
		[Nullable(1)]
		public WeatherData WeatherSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				WeatherData result;
				if ((result = this._WeatherSettings) == null)
				{
					result = (this._WeatherSettings = new WeatherData(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(WeatherData.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_20, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005085 RID: 20613
		// (get) Token: 0x060261DB RID: 156123 RVA: 0x0096BF02 File Offset: 0x0096A102
		// (set) Token: 0x060261DC RID: 156124 RVA: 0x0096BF16 File Offset: 0x0096A116
		public unsafe UMaterialInstanceDynamic SkyMaterialInst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005086 RID: 20614
		// (get) Token: 0x060261DD RID: 156125 RVA: 0x0096BF2B File Offset: 0x0096A12B
		// (set) Token: 0x060261DE RID: 156126 RVA: 0x0096BF3F File Offset: 0x0096A13F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<WeatherPreset_C> WeatherPresetTarget
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_22);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005087 RID: 20615
		// (get) Token: 0x060261DF RID: 156127 RVA: 0x0096BF54 File Offset: 0x0096A154
		// (set) Token: 0x060261E0 RID: 156128 RVA: 0x0096BF64 File Offset: 0x0096A164
		public unsafe float WeatherPresetInterp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005088 RID: 20616
		// (get) Token: 0x060261E1 RID: 156129 RVA: 0x0096BF75 File Offset: 0x0096A175
		// (set) Token: 0x060261E2 RID: 156130 RVA: 0x0096BF89 File Offset: 0x0096A189
		public unsafe UMaterialInstanceConstant SkyMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17005089 RID: 20617
		// (get) Token: 0x060261E3 RID: 156131 RVA: 0x0096BF9E File Offset: 0x0096A19E
		// (set) Token: 0x060261E4 RID: 156132 RVA: 0x0096BFB2 File Offset: 0x0096A1B2
		public unsafe UMaterialInstanceConstant SkyMaterialNight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x1700508A RID: 20618
		// (get) Token: 0x060261E5 RID: 156133 RVA: 0x0096BFC7 File Offset: 0x0096A1C7
		// (set) Token: 0x060261E6 RID: 156134 RVA: 0x0096BFDB File Offset: 0x0096A1DB
		public unsafe ADirectionalLight SunLightSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADirectionalLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x1700508B RID: 20619
		// (get) Token: 0x060261E7 RID: 156135 RVA: 0x0096BFF0 File Offset: 0x0096A1F0
		// (set) Token: 0x060261E8 RID: 156136 RVA: 0x0096C004 File Offset: 0x0096A204
		public unsafe ADirectionalLight MoonLightSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADirectionalLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x1700508C RID: 20620
		// (get) Token: 0x060261E9 RID: 156137 RVA: 0x0096C019 File Offset: 0x0096A219
		// (set) Token: 0x060261EA RID: 156138 RVA: 0x0096C02D File Offset: 0x0096A22D
		public unsafe AExponentialHeightFog HeightFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AExponentialHeightFog>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x1700508D RID: 20621
		// (get) Token: 0x060261EB RID: 156139 RVA: 0x0096C042 File Offset: 0x0096A242
		// (set) Token: 0x060261EC RID: 156140 RVA: 0x0096C056 File Offset: 0x0096A256
		public unsafe ASkyLight SkyLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkyLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x1700508E RID: 20622
		// (get) Token: 0x060261ED RID: 156141 RVA: 0x0096C06B File Offset: 0x0096A26B
		// (set) Token: 0x060261EE RID: 156142 RVA: 0x0096C07B File Offset: 0x0096A27B
		public unsafe float SkyLightRecaptureDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700508F RID: 20623
		// (get) Token: 0x060261EF RID: 156143 RVA: 0x0096C08C File Offset: 0x0096A28C
		// (set) Token: 0x060261F0 RID: 156144 RVA: 0x0096C0C5 File Offset: 0x0096A2C5
		[Nullable(1)]
		public TArray<UTextureCube> SkyLightStaticCubemaps
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTextureCube> result;
				if ((result = this._SkyLightStaticCubemaps) == null)
				{
					result = (this._SkyLightStaticCubemaps = new TArray<UTextureCube>(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_31, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkyLightStaticCubemaps.CopyAssign(value);
			}
		}

		// Token: 0x17005090 RID: 20624
		// (get) Token: 0x060261F1 RID: 156145 RVA: 0x0096C0D3 File Offset: 0x0096A2D3
		// (set) Token: 0x060261F2 RID: 156146 RVA: 0x0096C0E3 File Offset: 0x0096A2E3
		public unsafe bool SkyLightCubemapsTimeDriven
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005091 RID: 20625
		// (get) Token: 0x060261F3 RID: 156147 RVA: 0x0096C0F4 File Offset: 0x0096A2F4
		// (set) Token: 0x060261F4 RID: 156148 RVA: 0x0096C104 File Offset: 0x0096A304
		public unsafe float Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17005092 RID: 20626
		// (get) Token: 0x060261F5 RID: 156149 RVA: 0x0096C115 File Offset: 0x0096A315
		// (set) Token: 0x060261F6 RID: 156150 RVA: 0x0096C125 File Offset: 0x0096A325
		public unsafe float CloudsBloom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17005093 RID: 20627
		// (get) Token: 0x060261F7 RID: 156151 RVA: 0x0096C136 File Offset: 0x0096A336
		// (set) Token: 0x060261F8 RID: 156152 RVA: 0x0096C146 File Offset: 0x0096A346
		public unsafe float CloudsFluffy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17005094 RID: 20628
		// (get) Token: 0x060261F9 RID: 156153 RVA: 0x0096C157 File Offset: 0x0096A357
		// (set) Token: 0x060261FA RID: 156154 RVA: 0x0096C167 File Offset: 0x0096A367
		public unsafe float UVHorizonRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17005095 RID: 20629
		// (get) Token: 0x060261FB RID: 156155 RVA: 0x0096C178 File Offset: 0x0096A378
		// (set) Token: 0x060261FC RID: 156156 RVA: 0x0096C188 File Offset: 0x0096A388
		public unsafe float UVHorizonMapping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17005096 RID: 20630
		// (get) Token: 0x060261FD RID: 156157 RVA: 0x0096C199 File Offset: 0x0096A399
		// (set) Token: 0x060261FE RID: 156158 RVA: 0x0096C1A9 File Offset: 0x0096A3A9
		public unsafe float UVScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17005097 RID: 20631
		// (get) Token: 0x060261FF RID: 156159 RVA: 0x0096C1BA File Offset: 0x0096A3BA
		// (set) Token: 0x06026200 RID: 156160 RVA: 0x0096C1CA File Offset: 0x0096A3CA
		public unsafe float FogDirectionalInScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17005098 RID: 20632
		// (get) Token: 0x06026201 RID: 156161 RVA: 0x0096C1DB File Offset: 0x0096A3DB
		// (set) Token: 0x06026202 RID: 156162 RVA: 0x0096C1EB File Offset: 0x0096A3EB
		public unsafe float FogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17005099 RID: 20633
		// (get) Token: 0x06026203 RID: 156163 RVA: 0x0096C1FC File Offset: 0x0096A3FC
		// (set) Token: 0x06026204 RID: 156164 RVA: 0x0096C20C File Offset: 0x0096A40C
		public unsafe float HorizonTilt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x1700509A RID: 20634
		// (get) Token: 0x06026205 RID: 156165 RVA: 0x0096C21D File Offset: 0x0096A41D
		// (set) Token: 0x06026206 RID: 156166 RVA: 0x0096C231 File Offset: 0x0096A431
		public unsafe FLinearColor UVBaseLayerPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x1700509B RID: 20635
		// (get) Token: 0x06026207 RID: 156167 RVA: 0x0096C246 File Offset: 0x0096A446
		// (set) Token: 0x06026208 RID: 156168 RVA: 0x0096C25A File Offset: 0x0096A45A
		public unsafe FLinearColor UVBaseLayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x1700509C RID: 20636
		// (get) Token: 0x06026209 RID: 156169 RVA: 0x0096C26F File Offset: 0x0096A46F
		// (set) Token: 0x0602620A RID: 156170 RVA: 0x0096C283 File Offset: 0x0096A483
		public unsafe FLinearColor UVSecondLayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x1700509D RID: 20637
		// (get) Token: 0x0602620B RID: 156171 RVA: 0x0096C298 File Offset: 0x0096A498
		// (set) Token: 0x0602620C RID: 156172 RVA: 0x0096C2AC File Offset: 0x0096A4AC
		public unsafe FLinearColor UVSecondLayerPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x1700509E RID: 20638
		// (get) Token: 0x0602620D RID: 156173 RVA: 0x0096C2C1 File Offset: 0x0096A4C1
		// (set) Token: 0x0602620E RID: 156174 RVA: 0x0096C2D5 File Offset: 0x0096A4D5
		public unsafe UTexture CloudsLayer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x1700509F RID: 20639
		// (get) Token: 0x0602620F RID: 156175 RVA: 0x0096C2EA File Offset: 0x0096A4EA
		// (set) Token: 0x06026210 RID: 156176 RVA: 0x0096C2FE File Offset: 0x0096A4FE
		public unsafe UTexture CloudsLayer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x170050A0 RID: 20640
		// (get) Token: 0x06026211 RID: 156177 RVA: 0x0096C313 File Offset: 0x0096A513
		// (set) Token: 0x06026212 RID: 156178 RVA: 0x0096C327 File Offset: 0x0096A527
		public unsafe FVector2D WindForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170050A1 RID: 20641
		// (get) Token: 0x06026213 RID: 156179 RVA: 0x0096C33C File Offset: 0x0096A53C
		// (set) Token: 0x06026214 RID: 156180 RVA: 0x0096C34C File Offset: 0x0096A54C
		public unsafe float SunRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x170050A2 RID: 20642
		// (get) Token: 0x06026215 RID: 156181 RVA: 0x0096C35D File Offset: 0x0096A55D
		// (set) Token: 0x06026216 RID: 156182 RVA: 0x0096C36D File Offset: 0x0096A56D
		public unsafe float SunShine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x170050A3 RID: 20643
		// (get) Token: 0x06026217 RID: 156183 RVA: 0x0096C37E File Offset: 0x0096A57E
		// (set) Token: 0x06026218 RID: 156184 RVA: 0x0096C38E File Offset: 0x0096A58E
		public unsafe float SunSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x170050A4 RID: 20644
		// (get) Token: 0x06026219 RID: 156185 RVA: 0x0096C39F File Offset: 0x0096A59F
		// (set) Token: 0x0602621A RID: 156186 RVA: 0x0096C3AF File Offset: 0x0096A5AF
		public unsafe float SunMaxAltitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x170050A5 RID: 20645
		// (get) Token: 0x0602621B RID: 156187 RVA: 0x0096C3C0 File Offset: 0x0096A5C0
		// (set) Token: 0x0602621C RID: 156188 RVA: 0x0096C3D0 File Offset: 0x0096A5D0
		public unsafe float SunAzimuth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x170050A6 RID: 20646
		// (get) Token: 0x0602621D RID: 156189 RVA: 0x0096C3E1 File Offset: 0x0096A5E1
		// (set) Token: 0x0602621E RID: 156190 RVA: 0x0096C3F1 File Offset: 0x0096A5F1
		public unsafe float SunVisibleDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x170050A7 RID: 20647
		// (get) Token: 0x0602621F RID: 156191 RVA: 0x0096C402 File Offset: 0x0096A602
		// (set) Token: 0x06026220 RID: 156192 RVA: 0x0096C412 File Offset: 0x0096A612
		public unsafe bool SunDirectionTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x06026221 RID: 156193 RVA: 0x0096C423 File Offset: 0x0096A623
		// (set) Token: 0x06026222 RID: 156194 RVA: 0x0096C437 File Offset: 0x0096A637
		public unsafe FRotator SunDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x170050A9 RID: 20649
		// (get) Token: 0x06026223 RID: 156195 RVA: 0x0096C44C File Offset: 0x0096A64C
		// (set) Token: 0x06026224 RID: 156196 RVA: 0x0096C45C File Offset: 0x0096A65C
		public unsafe float StarsBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x170050AA RID: 20650
		// (get) Token: 0x06026225 RID: 156197 RVA: 0x0096C46D File Offset: 0x0096A66D
		// (set) Token: 0x06026226 RID: 156198 RVA: 0x0096C481 File Offset: 0x0096A681
		public unsafe UTexture MoonTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x170050AB RID: 20651
		// (get) Token: 0x06026227 RID: 156199 RVA: 0x0096C496 File Offset: 0x0096A696
		// (set) Token: 0x06026228 RID: 156200 RVA: 0x0096C4A6 File Offset: 0x0096A6A6
		public unsafe float MoonBightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x06026229 RID: 156201 RVA: 0x0096C4B7 File Offset: 0x0096A6B7
		// (set) Token: 0x0602622A RID: 156202 RVA: 0x0096C4C7 File Offset: 0x0096A6C7
		public unsafe float MoonRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x0602622B RID: 156203 RVA: 0x0096C4D8 File Offset: 0x0096A6D8
		// (set) Token: 0x0602622C RID: 156204 RVA: 0x0096C4E8 File Offset: 0x0096A6E8
		public unsafe float MoonClouds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x0602622D RID: 156205 RVA: 0x0096C4F9 File Offset: 0x0096A6F9
		// (set) Token: 0x0602622E RID: 156206 RVA: 0x0096C509 File Offset: 0x0096A709
		public unsafe float MoonShine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x170050AF RID: 20655
		// (get) Token: 0x0602622F RID: 156207 RVA: 0x0096C51A File Offset: 0x0096A71A
		// (set) Token: 0x06026230 RID: 156208 RVA: 0x0096C52A File Offset: 0x0096A72A
		public unsafe float MoonRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x170050B0 RID: 20656
		// (get) Token: 0x06026231 RID: 156209 RVA: 0x0096C53B File Offset: 0x0096A73B
		// (set) Token: 0x06026232 RID: 156210 RVA: 0x0096C54B File Offset: 0x0096A74B
		public unsafe float MoonVisibleDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x170050B1 RID: 20657
		// (get) Token: 0x06026233 RID: 156211 RVA: 0x0096C55C File Offset: 0x0096A75C
		// (set) Token: 0x06026234 RID: 156212 RVA: 0x0096C56C File Offset: 0x0096A76C
		public unsafe bool MoonSyncedToSun
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_65) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_65) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050B2 RID: 20658
		// (get) Token: 0x06026235 RID: 156213 RVA: 0x0096C57D File Offset: 0x0096A77D
		// (set) Token: 0x06026236 RID: 156214 RVA: 0x0096C591 File Offset: 0x0096A791
		public unsafe FRotator MoonRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x170050B3 RID: 20659
		// (get) Token: 0x06026237 RID: 156215 RVA: 0x0096C5A8 File Offset: 0x0096A7A8
		// (set) Token: 0x06026238 RID: 156216 RVA: 0x0096C5E1 File Offset: 0x0096A7E1
		[Nullable(1)]
		public WeatherData WeatherFrom
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				WeatherData result;
				if ((result = this._WeatherFrom) == null)
				{
					result = (this._WeatherFrom = new WeatherData(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_67, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(WeatherData.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_67, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050B4 RID: 20660
		// (get) Token: 0x06026239 RID: 156217 RVA: 0x0096C604 File Offset: 0x0096A804
		// (set) Token: 0x0602623A RID: 156218 RVA: 0x0096C63D File Offset: 0x0096A83D
		[Nullable(1)]
		public WeatherData WeatherTo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				WeatherData result;
				if ((result = this._WeatherTo) == null)
				{
					result = (this._WeatherTo = new WeatherData(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_68, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(WeatherData.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_68, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050B5 RID: 20661
		// (get) Token: 0x0602623B RID: 156219 RVA: 0x0096C65E File Offset: 0x0096A85E
		// (set) Token: 0x0602623C RID: 156220 RVA: 0x0096C672 File Offset: 0x0096A872
		public unsafe FRotator MoonChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x0602623D RID: 156221 RVA: 0x0096C687 File Offset: 0x0096A887
		// (set) Token: 0x0602623E RID: 156222 RVA: 0x0096C697 File Offset: 0x0096A897
		public unsafe float WorldRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x0602623F RID: 156223 RVA: 0x0096C6A8 File Offset: 0x0096A8A8
		// (set) Token: 0x06026240 RID: 156224 RVA: 0x0096C6B8 File Offset: 0x0096A8B8
		public unsafe float WorldRotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x06026241 RID: 156225 RVA: 0x0096C6C9 File Offset: 0x0096A8C9
		// (set) Token: 0x06026242 RID: 156226 RVA: 0x0096C6DD File Offset: 0x0096A8DD
		public unsafe UTexture WorldLayerTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_72);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_72, value);
			}
		}

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x06026243 RID: 156227 RVA: 0x0096C6F2 File Offset: 0x0096A8F2
		// (set) Token: 0x06026244 RID: 156228 RVA: 0x0096C702 File Offset: 0x0096A902
		public unsafe float WorldLayerFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x06026245 RID: 156229 RVA: 0x0096C713 File Offset: 0x0096A913
		// (set) Token: 0x06026246 RID: 156230 RVA: 0x0096C723 File Offset: 0x0096A923
		public unsafe float WorldLayerDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x06026247 RID: 156231 RVA: 0x0096C734 File Offset: 0x0096A934
		// (set) Token: 0x06026248 RID: 156232 RVA: 0x0096C748 File Offset: 0x0096A948
		public unsafe FLinearColor WorldLayerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x06026249 RID: 156233 RVA: 0x0096C75D File Offset: 0x0096A95D
		// (set) Token: 0x0602624A RID: 156234 RVA: 0x0096C76D File Offset: 0x0096A96D
		public unsafe float SkyLightRecaptureTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x0602624B RID: 156235 RVA: 0x0096C77E File Offset: 0x0096A97E
		// (set) Token: 0x0602624C RID: 156236 RVA: 0x0096C78E File Offset: 0x0096A98E
		public unsafe float TimeOfDayFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x170050BE RID: 20670
		// (get) Token: 0x0602624D RID: 156237 RVA: 0x0096C79F File Offset: 0x0096A99F
		// (set) Token: 0x0602624E RID: 156238 RVA: 0x0096C7AF File Offset: 0x0096A9AF
		public unsafe float TimeOfDayTo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x170050BF RID: 20671
		// (get) Token: 0x0602624F RID: 156239 RVA: 0x0096C7C0 File Offset: 0x0096A9C0
		// (set) Token: 0x06026250 RID: 156240 RVA: 0x0096C7D0 File Offset: 0x0096A9D0
		public unsafe float TimeOfDayTransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_79);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_79) = value;
			}
		}

		// Token: 0x170050C0 RID: 20672
		// (get) Token: 0x06026251 RID: 156241 RVA: 0x0096C7E1 File Offset: 0x0096A9E1
		// (set) Token: 0x06026252 RID: 156242 RVA: 0x0096C7F5 File Offset: 0x0096A9F5
		[Nullable(0)]
		public unsafe TEnumAsByte<EEasingFunc> TimeOfDayTransition
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_80);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_80) = value;
			}
		}

		// Token: 0x170050C1 RID: 20673
		// (get) Token: 0x06026253 RID: 156243 RVA: 0x0096C80A File Offset: 0x0096AA0A
		// (set) Token: 0x06026254 RID: 156244 RVA: 0x0096C81A File Offset: 0x0096AA1A
		public unsafe float TimeOfDayInterp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_81);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_81) = value;
			}
		}

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x06026255 RID: 156245 RVA: 0x0096C82B File Offset: 0x0096AA2B
		// (set) Token: 0x06026256 RID: 156246 RVA: 0x0096C83F File Offset: 0x0096AA3F
		public unsafe UMaterialInstanceConstant GroundShadowMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_82);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_82, value);
			}
		}

		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x06026257 RID: 156247 RVA: 0x0096C854 File Offset: 0x0096AA54
		// (set) Token: 0x06026258 RID: 156248 RVA: 0x0096C868 File Offset: 0x0096AA68
		public unsafe UMaterialInstanceDynamic GroundShadowMaterialInst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_83);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkyDome_C.__PropertyOffset_83, value);
			}
		}

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x06026259 RID: 156249 RVA: 0x0096C87D File Offset: 0x0096AA7D
		// (set) Token: 0x0602625A RID: 156250 RVA: 0x0096C88D File Offset: 0x0096AA8D
		public unsafe float GroundShadowScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x170050C5 RID: 20677
		// (get) Token: 0x0602625B RID: 156251 RVA: 0x0096C89E File Offset: 0x0096AA9E
		// (set) Token: 0x0602625C RID: 156252 RVA: 0x0096C8AE File Offset: 0x0096AAAE
		public unsafe float GroundShadowSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_85);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x0602625D RID: 156253 RVA: 0x0096C8BF File Offset: 0x0096AABF
		// (set) Token: 0x0602625E RID: 156254 RVA: 0x0096C8CF File Offset: 0x0096AACF
		public unsafe int Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_86);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_86) = value;
			}
		}

		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x0602625F RID: 156255 RVA: 0x0096C8E0 File Offset: 0x0096AAE0
		// (set) Token: 0x06026260 RID: 156256 RVA: 0x0096C919 File Offset: 0x0096AB19
		[Nullable(1)]
		public TimeOfDayData TimeOfDayDataFrom
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TimeOfDayData result;
				if ((result = this._TimeOfDayDataFrom) == null)
				{
					result = (this._TimeOfDayDataFrom = new TimeOfDayData(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_87, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(TimeOfDayData.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_87, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050C8 RID: 20680
		// (get) Token: 0x06026261 RID: 156257 RVA: 0x0096C93C File Offset: 0x0096AB3C
		// (set) Token: 0x06026262 RID: 156258 RVA: 0x0096C975 File Offset: 0x0096AB75
		[Nullable(1)]
		public TimeOfDayData TimeOfDayDataTo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TimeOfDayData result;
				if ((result = this._TimeOfDayDataTo) == null)
				{
					result = (this._TimeOfDayDataTo = new TimeOfDayData(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_88, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(TimeOfDayData.StaticStruct(), base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_88, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050C9 RID: 20681
		// (get) Token: 0x06026263 RID: 156259 RVA: 0x0096C996 File Offset: 0x0096AB96
		// (set) Token: 0x06026264 RID: 156260 RVA: 0x0096C9A6 File Offset: 0x0096ABA6
		public unsafe float TimeOfDayPresetInterp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_89);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_89) = value;
			}
		}

		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x06026265 RID: 156261 RVA: 0x0096C9B7 File Offset: 0x0096ABB7
		// (set) Token: 0x06026266 RID: 156262 RVA: 0x0096C9CB File Offset: 0x0096ABCB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<TimeOfDayPreset_C> TimeOfDayPresetTarget
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_90);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_90) = value;
			}
		}

		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x06026267 RID: 156263 RVA: 0x0096C9E0 File Offset: 0x0096ABE0
		// (set) Token: 0x06026268 RID: 156264 RVA: 0x0096C9F0 File Offset: 0x0096ABF0
		public unsafe float SkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_91);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_91) = value;
			}
		}

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x06026269 RID: 156265 RVA: 0x0096CA01 File Offset: 0x0096AC01
		// (set) Token: 0x0602626A RID: 156266 RVA: 0x0096CA11 File Offset: 0x0096AC11
		public unsafe float SkyLightLightning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x0602626B RID: 156267 RVA: 0x0096CA22 File Offset: 0x0096AC22
		// (set) Token: 0x0602626C RID: 156268 RVA: 0x0096CA32 File Offset: 0x0096AC32
		public unsafe bool UseWorldSpaceRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_93) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_93) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x0602626D RID: 156269 RVA: 0x0096CA43 File Offset: 0x0096AC43
		// (set) Token: 0x0602626E RID: 156270 RVA: 0x0096CA53 File Offset: 0x0096AC53
		public unsafe int DaysPassedBy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x0602626F RID: 156271 RVA: 0x0096CA64 File Offset: 0x0096AC64
		// (set) Token: 0x06026270 RID: 156272 RVA: 0x0096CA9D File Offset: 0x0096AC9D
		[Nullable(1)]
		public OnWeatherPresetChanged OnWeatherPresetChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnWeatherPresetChanged result;
				if ((result = this._OnWeatherPresetChanged) == null)
				{
					result = (this._OnWeatherPresetChanged = new OnWeatherPresetChanged(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_95, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_95, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x06026271 RID: 156273 RVA: 0x0096CAC0 File Offset: 0x0096ACC0
		// (set) Token: 0x06026272 RID: 156274 RVA: 0x0096CAF9 File Offset: 0x0096ACF9
		[Nullable(1)]
		public OnTimeOfDayPresetChanged OnTimeOfDayPresetChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnTimeOfDayPresetChanged result;
				if ((result = this._OnTimeOfDayPresetChanged) == null)
				{
					result = (this._OnTimeOfDayPresetChanged = new OnTimeOfDayPresetChanged(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_96, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_96, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x06026273 RID: 156275 RVA: 0x0096CB1C File Offset: 0x0096AD1C
		// (set) Token: 0x06026274 RID: 156276 RVA: 0x0096CB55 File Offset: 0x0096AD55
		[Nullable(1)]
		public OnHourPassedBy OnHourPassedBy
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnHourPassedBy result;
				if ((result = this._OnHourPassedBy) == null)
				{
					result = (this._OnHourPassedBy = new OnHourPassedBy(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_97, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_97, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x06026275 RID: 156277 RVA: 0x0096CB78 File Offset: 0x0096AD78
		// (set) Token: 0x06026276 RID: 156278 RVA: 0x0096CBB1 File Offset: 0x0096ADB1
		[Nullable(1)]
		public OnDayPassedBy OnDayPassedBy
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnDayPassedBy result;
				if ((result = this._OnDayPassedBy) == null)
				{
					result = (this._OnDayPassedBy = new OnDayPassedBy(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_98, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_98, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x06026277 RID: 156279 RVA: 0x0096CBD2 File Offset: 0x0096ADD2
		// (set) Token: 0x06026278 RID: 156280 RVA: 0x0096CBE2 File Offset: 0x0096ADE2
		public unsafe float MoonLightLightning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_99);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_99) = value;
			}
		}

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x06026279 RID: 156281 RVA: 0x0096CBF3 File Offset: 0x0096ADF3
		// (set) Token: 0x0602627A RID: 156282 RVA: 0x0096CC03 File Offset: 0x0096AE03
		public unsafe float ColorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x0602627B RID: 156283 RVA: 0x0096CC14 File Offset: 0x0096AE14
		// (set) Token: 0x0602627C RID: 156284 RVA: 0x0096CC24 File Offset: 0x0096AE24
		public unsafe int EngineVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x0602627D RID: 156285 RVA: 0x0096CC35 File Offset: 0x0096AE35
		// (set) Token: 0x0602627E RID: 156286 RVA: 0x0096CC45 File Offset: 0x0096AE45
		public unsafe float Curr_Time_Of_Day
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x0602627F RID: 156287 RVA: 0x0096CC56 File Offset: 0x0096AE56
		// (set) Token: 0x06026280 RID: 156288 RVA: 0x0096CC66 File Offset: 0x0096AE66
		public unsafe float BlueSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_103);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x06026281 RID: 156289 RVA: 0x0096CC77 File Offset: 0x0096AE77
		// (set) Token: 0x06026282 RID: 156290 RVA: 0x0096CC87 File Offset: 0x0096AE87
		public unsafe float SkyShineScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x06026283 RID: 156291 RVA: 0x0096CC98 File Offset: 0x0096AE98
		// (set) Token: 0x06026284 RID: 156292 RVA: 0x0096CCA8 File Offset: 0x0096AEA8
		public unsafe float Total_TODTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_105);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_105) = value;
			}
		}

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x06026285 RID: 156293 RVA: 0x0096CCB9 File Offset: 0x0096AEB9
		// (set) Token: 0x06026286 RID: 156294 RVA: 0x0096CCC9 File Offset: 0x0096AEC9
		public unsafe bool CloudsMoveWithTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_106) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_106) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050DB RID: 20699
		// (get) Token: 0x06026287 RID: 156295 RVA: 0x0096CCDA File Offset: 0x0096AEDA
		// (set) Token: 0x06026288 RID: 156296 RVA: 0x0096CCEA File Offset: 0x0096AEEA
		public unsafe float CloudsTODTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_107);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_107) = value;
			}
		}

		// Token: 0x170050DC RID: 20700
		// (get) Token: 0x06026289 RID: 156297 RVA: 0x0096CCFB File Offset: 0x0096AEFB
		// (set) Token: 0x0602628A RID: 156298 RVA: 0x0096CD0B File Offset: 0x0096AF0B
		public unsafe float Layer1Phase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_108);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_108) = value;
			}
		}

		// Token: 0x170050DD RID: 20701
		// (get) Token: 0x0602628B RID: 156299 RVA: 0x0096CD1C File Offset: 0x0096AF1C
		// (set) Token: 0x0602628C RID: 156300 RVA: 0x0096CD2C File Offset: 0x0096AF2C
		public unsafe float Layer2Phase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_109);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_109) = value;
			}
		}

		// Token: 0x170050DE RID: 20702
		// (get) Token: 0x0602628D RID: 156301 RVA: 0x0096CD3D File Offset: 0x0096AF3D
		// (set) Token: 0x0602628E RID: 156302 RVA: 0x0096CD4D File Offset: 0x0096AF4D
		public unsafe float MoonFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_110);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_110) = value;
			}
		}

		// Token: 0x170050DF RID: 20703
		// (get) Token: 0x0602628F RID: 156303 RVA: 0x0096CD5E File Offset: 0x0096AF5E
		// (set) Token: 0x06026290 RID: 156304 RVA: 0x0096CD6E File Offset: 0x0096AF6E
		public unsafe float CloudsBlendScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_111);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_111) = value;
			}
		}

		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x06026291 RID: 156305 RVA: 0x0096CD7F File Offset: 0x0096AF7F
		// (set) Token: 0x06026292 RID: 156306 RVA: 0x0096CD8F File Offset: 0x0096AF8F
		public unsafe float SunHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_112);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_112) = value;
			}
		}

		// Token: 0x170050E1 RID: 20705
		// (get) Token: 0x06026293 RID: 156307 RVA: 0x0096CDA0 File Offset: 0x0096AFA0
		// (set) Token: 0x06026294 RID: 156308 RVA: 0x0096CDB0 File Offset: 0x0096AFB0
		public unsafe float SkyLowerFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_113);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_113) = value;
			}
		}

		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x06026295 RID: 156309 RVA: 0x0096CDC1 File Offset: 0x0096AFC1
		// (set) Token: 0x06026296 RID: 156310 RVA: 0x0096CDD1 File Offset: 0x0096AFD1
		public unsafe float EclipseLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_114);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_114) = value;
			}
		}

		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x06026297 RID: 156311 RVA: 0x0096CDE2 File Offset: 0x0096AFE2
		// (set) Token: 0x06026298 RID: 156312 RVA: 0x0096CDF2 File Offset: 0x0096AFF2
		public unsafe float EclipseOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_115);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_115) = value;
			}
		}

		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x06026299 RID: 156313 RVA: 0x0096CE03 File Offset: 0x0096B003
		// (set) Token: 0x0602629A RID: 156314 RVA: 0x0096CE13 File Offset: 0x0096B013
		public unsafe float EclipseAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_116);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_116) = value;
			}
		}

		// Token: 0x170050E5 RID: 20709
		// (get) Token: 0x0602629B RID: 156315 RVA: 0x0096CE24 File Offset: 0x0096B024
		// (set) Token: 0x0602629C RID: 156316 RVA: 0x0096CE34 File Offset: 0x0096B034
		public unsafe float EclipseHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_117);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_117) = value;
			}
		}

		// Token: 0x170050E6 RID: 20710
		// (get) Token: 0x0602629D RID: 156317 RVA: 0x0096CE45 File Offset: 0x0096B045
		// (set) Token: 0x0602629E RID: 156318 RVA: 0x0096CE55 File Offset: 0x0096B055
		public unsafe bool bUseNightMtl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_118) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_118) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050E7 RID: 20711
		// (get) Token: 0x0602629F RID: 156319 RVA: 0x0096CE66 File Offset: 0x0096B066
		// (set) Token: 0x060262A0 RID: 156320 RVA: 0x0096CE76 File Offset: 0x0096B076
		public unsafe float UseFlowmapSkybox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_119);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkyDome_C.__PropertyOffset_119) = value;
			}
		}

		// Token: 0x060262A1 RID: 156321 RVA: 0x0096CE87 File Offset: 0x0096B087
		protected BP_SkyDome_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013141 RID: 78145
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C";

		// Token: 0x04013142 RID: 78146
		private static IntPtr _ClassPtr;

		// Token: 0x04013143 RID: 78147
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013144 RID: 78148
		public static IntPtr __OnDayPassedBy__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013145 RID: 78149
		public static IntPtr __OnHourPassedBy__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013146 RID: 78150
		public static IntPtr __OnTimeOfDayPresetChanged__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013147 RID: 78151
		public static IntPtr __OnWeatherPresetChanged__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013148 RID: 78152
		internal static int __PropertyOffset_1;

		// Token: 0x04013149 RID: 78153
		internal static int __PropertyOffset_2;

		// Token: 0x0401314A RID: 78154
		internal static int __PropertyOffset_3;

		// Token: 0x0401314B RID: 78155
		internal static int __PropertyOffset_4;

		// Token: 0x0401314C RID: 78156
		internal static int __PropertyOffset_5;

		// Token: 0x0401314D RID: 78157
		internal static int __PropertyOffset_6;

		// Token: 0x0401314E RID: 78158
		internal static int __PropertyOffset_7;

		// Token: 0x0401314F RID: 78159
		internal static int __PropertyOffset_8;

		// Token: 0x04013150 RID: 78160
		private TimeOfDayCurves _TimeOfDayCurves;

		// Token: 0x04013151 RID: 78161
		internal static int __PropertyOffset_9;

		// Token: 0x04013152 RID: 78162
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<WeatherPreset_C>> _WeatherPresetList;

		// Token: 0x04013153 RID: 78163
		internal static int __PropertyOffset_10;

		// Token: 0x04013154 RID: 78164
		internal static int __PropertyOffset_11;

		// Token: 0x04013155 RID: 78165
		internal static int __PropertyOffset_12;

		// Token: 0x04013156 RID: 78166
		internal static int __PropertyOffset_13;

		// Token: 0x04013157 RID: 78167
		internal static int __PropertyOffset_14;

		// Token: 0x04013158 RID: 78168
		internal static int __PropertyOffset_15;

		// Token: 0x04013159 RID: 78169
		private TimeOfDayData _TimeOfDaySettings;

		// Token: 0x0401315A RID: 78170
		internal static int __PropertyOffset_16;

		// Token: 0x0401315B RID: 78171
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<TimeOfDayPreset_C>> _TimeOfDayPresetList;

		// Token: 0x0401315C RID: 78172
		internal static int __PropertyOffset_17;

		// Token: 0x0401315D RID: 78173
		private PresetChangeInfo _TimeOfDayPresetChange;

		// Token: 0x0401315E RID: 78174
		internal static int __PropertyOffset_18;

		// Token: 0x0401315F RID: 78175
		internal static int __PropertyOffset_19;

		// Token: 0x04013160 RID: 78176
		internal static int __PropertyOffset_20;

		// Token: 0x04013161 RID: 78177
		private WeatherData _WeatherSettings;

		// Token: 0x04013162 RID: 78178
		internal static int __PropertyOffset_21;

		// Token: 0x04013163 RID: 78179
		internal static int __PropertyOffset_22;

		// Token: 0x04013164 RID: 78180
		internal static int __PropertyOffset_23;

		// Token: 0x04013165 RID: 78181
		internal static int __PropertyOffset_24;

		// Token: 0x04013166 RID: 78182
		internal static int __PropertyOffset_25;

		// Token: 0x04013167 RID: 78183
		internal static int __PropertyOffset_26;

		// Token: 0x04013168 RID: 78184
		internal static int __PropertyOffset_27;

		// Token: 0x04013169 RID: 78185
		internal static int __PropertyOffset_28;

		// Token: 0x0401316A RID: 78186
		internal static int __PropertyOffset_29;

		// Token: 0x0401316B RID: 78187
		internal static int __PropertyOffset_30;

		// Token: 0x0401316C RID: 78188
		internal static int __PropertyOffset_31;

		// Token: 0x0401316D RID: 78189
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTextureCube> _SkyLightStaticCubemaps;

		// Token: 0x0401316E RID: 78190
		internal static int __PropertyOffset_32;

		// Token: 0x0401316F RID: 78191
		internal static int __PropertyOffset_33;

		// Token: 0x04013170 RID: 78192
		internal static int __PropertyOffset_34;

		// Token: 0x04013171 RID: 78193
		internal static int __PropertyOffset_35;

		// Token: 0x04013172 RID: 78194
		internal static int __PropertyOffset_36;

		// Token: 0x04013173 RID: 78195
		internal static int __PropertyOffset_37;

		// Token: 0x04013174 RID: 78196
		internal static int __PropertyOffset_38;

		// Token: 0x04013175 RID: 78197
		internal static int __PropertyOffset_39;

		// Token: 0x04013176 RID: 78198
		internal static int __PropertyOffset_40;

		// Token: 0x04013177 RID: 78199
		internal static int __PropertyOffset_41;

		// Token: 0x04013178 RID: 78200
		internal static int __PropertyOffset_42;

		// Token: 0x04013179 RID: 78201
		internal static int __PropertyOffset_43;

		// Token: 0x0401317A RID: 78202
		internal static int __PropertyOffset_44;

		// Token: 0x0401317B RID: 78203
		internal static int __PropertyOffset_45;

		// Token: 0x0401317C RID: 78204
		internal static int __PropertyOffset_46;

		// Token: 0x0401317D RID: 78205
		internal static int __PropertyOffset_47;

		// Token: 0x0401317E RID: 78206
		internal static int __PropertyOffset_48;

		// Token: 0x0401317F RID: 78207
		internal static int __PropertyOffset_49;

		// Token: 0x04013180 RID: 78208
		internal static int __PropertyOffset_50;

		// Token: 0x04013181 RID: 78209
		internal static int __PropertyOffset_51;

		// Token: 0x04013182 RID: 78210
		internal static int __PropertyOffset_52;

		// Token: 0x04013183 RID: 78211
		internal static int __PropertyOffset_53;

		// Token: 0x04013184 RID: 78212
		internal static int __PropertyOffset_54;

		// Token: 0x04013185 RID: 78213
		internal static int __PropertyOffset_55;

		// Token: 0x04013186 RID: 78214
		internal static int __PropertyOffset_56;

		// Token: 0x04013187 RID: 78215
		internal static int __PropertyOffset_57;

		// Token: 0x04013188 RID: 78216
		internal static int __PropertyOffset_58;

		// Token: 0x04013189 RID: 78217
		internal static int __PropertyOffset_59;

		// Token: 0x0401318A RID: 78218
		internal static int __PropertyOffset_60;

		// Token: 0x0401318B RID: 78219
		internal static int __PropertyOffset_61;

		// Token: 0x0401318C RID: 78220
		internal static int __PropertyOffset_62;

		// Token: 0x0401318D RID: 78221
		internal static int __PropertyOffset_63;

		// Token: 0x0401318E RID: 78222
		internal static int __PropertyOffset_64;

		// Token: 0x0401318F RID: 78223
		internal static int __PropertyOffset_65;

		// Token: 0x04013190 RID: 78224
		internal static int __PropertyOffset_66;

		// Token: 0x04013191 RID: 78225
		internal static int __PropertyOffset_67;

		// Token: 0x04013192 RID: 78226
		private WeatherData _WeatherFrom;

		// Token: 0x04013193 RID: 78227
		internal static int __PropertyOffset_68;

		// Token: 0x04013194 RID: 78228
		private WeatherData _WeatherTo;

		// Token: 0x04013195 RID: 78229
		internal static int __PropertyOffset_69;

		// Token: 0x04013196 RID: 78230
		internal static int __PropertyOffset_70;

		// Token: 0x04013197 RID: 78231
		internal static int __PropertyOffset_71;

		// Token: 0x04013198 RID: 78232
		internal static int __PropertyOffset_72;

		// Token: 0x04013199 RID: 78233
		internal static int __PropertyOffset_73;

		// Token: 0x0401319A RID: 78234
		internal static int __PropertyOffset_74;

		// Token: 0x0401319B RID: 78235
		internal static int __PropertyOffset_75;

		// Token: 0x0401319C RID: 78236
		internal static int __PropertyOffset_76;

		// Token: 0x0401319D RID: 78237
		internal static int __PropertyOffset_77;

		// Token: 0x0401319E RID: 78238
		internal static int __PropertyOffset_78;

		// Token: 0x0401319F RID: 78239
		internal static int __PropertyOffset_79;

		// Token: 0x040131A0 RID: 78240
		internal static int __PropertyOffset_80;

		// Token: 0x040131A1 RID: 78241
		internal static int __PropertyOffset_81;

		// Token: 0x040131A2 RID: 78242
		internal static int __PropertyOffset_82;

		// Token: 0x040131A3 RID: 78243
		internal static int __PropertyOffset_83;

		// Token: 0x040131A4 RID: 78244
		internal static int __PropertyOffset_84;

		// Token: 0x040131A5 RID: 78245
		internal static int __PropertyOffset_85;

		// Token: 0x040131A6 RID: 78246
		internal static int __PropertyOffset_86;

		// Token: 0x040131A7 RID: 78247
		internal static int __PropertyOffset_87;

		// Token: 0x040131A8 RID: 78248
		private TimeOfDayData _TimeOfDayDataFrom;

		// Token: 0x040131A9 RID: 78249
		internal static int __PropertyOffset_88;

		// Token: 0x040131AA RID: 78250
		private TimeOfDayData _TimeOfDayDataTo;

		// Token: 0x040131AB RID: 78251
		internal static int __PropertyOffset_89;

		// Token: 0x040131AC RID: 78252
		internal static int __PropertyOffset_90;

		// Token: 0x040131AD RID: 78253
		internal static int __PropertyOffset_91;

		// Token: 0x040131AE RID: 78254
		internal static int __PropertyOffset_92;

		// Token: 0x040131AF RID: 78255
		internal static int __PropertyOffset_93;

		// Token: 0x040131B0 RID: 78256
		internal static int __PropertyOffset_94;

		// Token: 0x040131B1 RID: 78257
		internal static int __PropertyOffset_95;

		// Token: 0x040131B2 RID: 78258
		private OnWeatherPresetChanged _OnWeatherPresetChanged;

		// Token: 0x040131B3 RID: 78259
		internal static int __PropertyOffset_96;

		// Token: 0x040131B4 RID: 78260
		private OnTimeOfDayPresetChanged _OnTimeOfDayPresetChanged;

		// Token: 0x040131B5 RID: 78261
		internal static int __PropertyOffset_97;

		// Token: 0x040131B6 RID: 78262
		private OnHourPassedBy _OnHourPassedBy;

		// Token: 0x040131B7 RID: 78263
		internal static int __PropertyOffset_98;

		// Token: 0x040131B8 RID: 78264
		private OnDayPassedBy _OnDayPassedBy;

		// Token: 0x040131B9 RID: 78265
		internal static int __PropertyOffset_99;

		// Token: 0x040131BA RID: 78266
		internal static int __PropertyOffset_100;

		// Token: 0x040131BB RID: 78267
		internal static int __PropertyOffset_101;

		// Token: 0x040131BC RID: 78268
		internal static int __PropertyOffset_102;

		// Token: 0x040131BD RID: 78269
		internal static int __PropertyOffset_103;

		// Token: 0x040131BE RID: 78270
		internal static int __PropertyOffset_104;

		// Token: 0x040131BF RID: 78271
		internal static int __PropertyOffset_105;

		// Token: 0x040131C0 RID: 78272
		internal static int __PropertyOffset_106;

		// Token: 0x040131C1 RID: 78273
		internal static int __PropertyOffset_107;

		// Token: 0x040131C2 RID: 78274
		internal static int __PropertyOffset_108;

		// Token: 0x040131C3 RID: 78275
		internal static int __PropertyOffset_109;

		// Token: 0x040131C4 RID: 78276
		internal static int __PropertyOffset_110;

		// Token: 0x040131C5 RID: 78277
		internal static int __PropertyOffset_111;

		// Token: 0x040131C6 RID: 78278
		internal static int __PropertyOffset_112;

		// Token: 0x040131C7 RID: 78279
		internal static int __PropertyOffset_113;

		// Token: 0x040131C8 RID: 78280
		internal static int __PropertyOffset_114;

		// Token: 0x040131C9 RID: 78281
		internal static int __PropertyOffset_115;

		// Token: 0x040131CA RID: 78282
		internal static int __PropertyOffset_116;

		// Token: 0x040131CB RID: 78283
		internal static int __PropertyOffset_117;

		// Token: 0x040131CC RID: 78284
		internal static int __PropertyOffset_118;

		// Token: 0x040131CD RID: 78285
		internal static int __PropertyOffset_119;
	}
}
