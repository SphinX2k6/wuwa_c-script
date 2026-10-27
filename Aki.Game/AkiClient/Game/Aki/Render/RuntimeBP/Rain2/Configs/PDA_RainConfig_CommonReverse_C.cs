using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs
{
	// Token: 0x02003BC8 RID: 15304
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfig_CommonReverse.PDA_RainConfig_CommonReverse_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class PDA_RainConfig_CommonReverse_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060224E5 RID: 140517 RVA: 0x00905209 File Offset: 0x00903409
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_RainConfig_CommonReverse_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfig_CommonReverse.PDA_RainConfig_CommonReverse_C");
			}
			return PDA_RainConfig_CommonReverse_C._ClassPtr;
		}

		// Token: 0x060224E6 RID: 140518 RVA: 0x00905230 File Offset: 0x00903430
		public PDA_RainConfig_CommonReverse_C() : this(BuiltinUtils.AllocNativeUObject(PDA_RainConfig_CommonReverse_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224E7 RID: 140519 RVA: 0x00905258 File Offset: 0x00903458
		public PDA_RainConfig_CommonReverse_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_RainConfig_CommonReverse_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x060224E8 RID: 140520 RVA: 0x0090528C File Offset: 0x0090348C
		// (set) Token: 0x060224E9 RID: 140521 RVA: 0x009052C5 File Offset: 0x009034C5
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x060224EA RID: 140522 RVA: 0x009052D4 File Offset: 0x009034D4
		// (set) Token: 0x060224EB RID: 140523 RVA: 0x0090530D File Offset: 0x0090350D
		public TArray<UStaticMesh> Meshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x060224EC RID: 140524 RVA: 0x0090531C File Offset: 0x0090351C
		// (set) Token: 0x060224ED RID: 140525 RVA: 0x00905355 File Offset: 0x00903555
		public TArray<SCommonRainSpawnerConfig> Spawners
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCommonRainSpawnerConfig> result;
				if ((result = this._Spawners) == null)
				{
					result = (this._Spawners = new TArray<SCommonRainSpawnerConfig>(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.Spawners.CopyAssign(value);
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x060224EE RID: 140526 RVA: 0x00905363 File Offset: 0x00903563
		// (set) Token: 0x060224EF RID: 140527 RVA: 0x00905377 File Offset: 0x00903577
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x060224F0 RID: 140528 RVA: 0x0090538C File Offset: 0x0090358C
		// (set) Token: 0x060224F1 RID: 140529 RVA: 0x009053A0 File Offset: 0x009035A0
		public unsafe FVector Wind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x060224F2 RID: 140530 RVA: 0x009053B5 File Offset: 0x009035B5
		// (set) Token: 0x060224F3 RID: 140531 RVA: 0x009053C5 File Offset: 0x009035C5
		public unsafe float Drag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x060224F4 RID: 140532 RVA: 0x009053D8 File Offset: 0x009035D8
		// (set) Token: 0x060224F5 RID: 140533 RVA: 0x00905411 File Offset: 0x00903611
		public FKuroCurveFloat OpacityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._OpacityCurve) == null)
				{
					result = (this._OpacityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x060224F6 RID: 140534 RVA: 0x00905434 File Offset: 0x00903634
		// (set) Token: 0x060224F7 RID: 140535 RVA: 0x0090546D File Offset: 0x0090366D
		public FKuroCurveFloat StretchCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StretchCurve) == null)
				{
					result = (this._StretchCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x060224F8 RID: 140536 RVA: 0x00905490 File Offset: 0x00903690
		// (set) Token: 0x060224F9 RID: 140537 RVA: 0x009054C9 File Offset: 0x009036C9
		public FKuroCurveFloat ShapeCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ShapeCurve) == null)
				{
					result = (this._ShapeCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x060224FA RID: 140538 RVA: 0x009054EA File Offset: 0x009036EA
		// (set) Token: 0x060224FB RID: 140539 RVA: 0x009054FA File Offset: 0x009036FA
		public unsafe float CycleBoxX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x060224FC RID: 140540 RVA: 0x0090550B File Offset: 0x0090370B
		// (set) Token: 0x060224FD RID: 140541 RVA: 0x0090551B File Offset: 0x0090371B
		public unsafe float CycleBoxY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x060224FE RID: 140542 RVA: 0x0090552C File Offset: 0x0090372C
		// (set) Token: 0x060224FF RID: 140543 RVA: 0x0090553C File Offset: 0x0090373C
		public unsafe float CycleBoxZ_Positive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x06022500 RID: 140544 RVA: 0x0090554D File Offset: 0x0090374D
		// (set) Token: 0x06022501 RID: 140545 RVA: 0x0090555D File Offset: 0x0090375D
		public unsafe float CycleBoxZ_Negative
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x06022502 RID: 140546 RVA: 0x00905570 File Offset: 0x00903770
		// (set) Token: 0x06022503 RID: 140547 RVA: 0x009055A9 File Offset: 0x009037A9
		public FKuroCurveFloat GravityPerformanceCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GravityPerformanceCurve) == null)
				{
					result = (this._GravityPerformanceCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x06022504 RID: 140548 RVA: 0x009055CC File Offset: 0x009037CC
		// (set) Token: 0x06022505 RID: 140549 RVA: 0x00905605 File Offset: 0x00903805
		public FKuroCurveFloat DragPerformanceCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DragPerformanceCurve) == null)
				{
					result = (this._DragPerformanceCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_14, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x06022506 RID: 140550 RVA: 0x00905628 File Offset: 0x00903828
		// (set) Token: 0x06022507 RID: 140551 RVA: 0x00905661 File Offset: 0x00903861
		public FKuroCurveFloat WindPerformanceCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WindPerformanceCurve) == null)
				{
					result = (this._WindPerformanceCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_15, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x06022508 RID: 140552 RVA: 0x00905684 File Offset: 0x00903884
		// (set) Token: 0x06022509 RID: 140553 RVA: 0x009056BD File Offset: 0x009038BD
		public FKuroCurveFloat SpawnPerformanceCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SpawnPerformanceCurve) == null)
				{
					result = (this._SpawnPerformanceCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0602250A RID: 140554 RVA: 0x009056E0 File Offset: 0x009038E0
		// (set) Token: 0x0602250B RID: 140555 RVA: 0x00905719 File Offset: 0x00903919
		public FKuroCurveFloat TimeDilationPerformanceCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TimeDilationPerformanceCurve) == null)
				{
					result = (this._TimeDilationPerformanceCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonReverse_C.__PropertyOffset_17, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0602250C RID: 140556 RVA: 0x0090573A File Offset: 0x0090393A
		// (set) Token: 0x0602250D RID: 140557 RVA: 0x0090574E File Offset: 0x0090394E
		[Nullable(2)]
		public unsafe UNiagaraSystem Niagara
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonReverse_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonReverse_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0602250E RID: 140558 RVA: 0x00905763 File Offset: 0x00903963
		// (set) Token: 0x0602250F RID: 140559 RVA: 0x00905777 File Offset: 0x00903977
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonReverse_C.__PropertyOffset_19);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonReverse_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x06022510 RID: 140560 RVA: 0x0090578C File Offset: 0x0090398C
		protected PDA_RainConfig_CommonReverse_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D28 RID: 68904
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfig_CommonReverse.PDA_RainConfig_CommonReverse_C";

		// Token: 0x04010D29 RID: 68905
		private static IntPtr _ClassPtr;

		// Token: 0x04010D2A RID: 68906
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D2B RID: 68907
		internal static int __PropertyOffset_0;

		// Token: 0x04010D2C RID: 68908
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x04010D2D RID: 68909
		internal static int __PropertyOffset_1;

		// Token: 0x04010D2E RID: 68910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _Meshes;

		// Token: 0x04010D2F RID: 68911
		internal static int __PropertyOffset_2;

		// Token: 0x04010D30 RID: 68912
		[Nullable(2)]
		private TArray<SCommonRainSpawnerConfig> _Spawners;

		// Token: 0x04010D31 RID: 68913
		internal static int __PropertyOffset_3;

		// Token: 0x04010D32 RID: 68914
		internal static int __PropertyOffset_4;

		// Token: 0x04010D33 RID: 68915
		internal static int __PropertyOffset_5;

		// Token: 0x04010D34 RID: 68916
		internal static int __PropertyOffset_6;

		// Token: 0x04010D35 RID: 68917
		[Nullable(2)]
		private FKuroCurveFloat _OpacityCurve;

		// Token: 0x04010D36 RID: 68918
		internal static int __PropertyOffset_7;

		// Token: 0x04010D37 RID: 68919
		[Nullable(2)]
		private FKuroCurveFloat _StretchCurve;

		// Token: 0x04010D38 RID: 68920
		internal static int __PropertyOffset_8;

		// Token: 0x04010D39 RID: 68921
		[Nullable(2)]
		private FKuroCurveFloat _ShapeCurve;

		// Token: 0x04010D3A RID: 68922
		internal static int __PropertyOffset_9;

		// Token: 0x04010D3B RID: 68923
		internal static int __PropertyOffset_10;

		// Token: 0x04010D3C RID: 68924
		internal static int __PropertyOffset_11;

		// Token: 0x04010D3D RID: 68925
		internal static int __PropertyOffset_12;

		// Token: 0x04010D3E RID: 68926
		internal static int __PropertyOffset_13;

		// Token: 0x04010D3F RID: 68927
		[Nullable(2)]
		private FKuroCurveFloat _GravityPerformanceCurve;

		// Token: 0x04010D40 RID: 68928
		internal static int __PropertyOffset_14;

		// Token: 0x04010D41 RID: 68929
		[Nullable(2)]
		private FKuroCurveFloat _DragPerformanceCurve;

		// Token: 0x04010D42 RID: 68930
		internal static int __PropertyOffset_15;

		// Token: 0x04010D43 RID: 68931
		[Nullable(2)]
		private FKuroCurveFloat _WindPerformanceCurve;

		// Token: 0x04010D44 RID: 68932
		internal static int __PropertyOffset_16;

		// Token: 0x04010D45 RID: 68933
		[Nullable(2)]
		private FKuroCurveFloat _SpawnPerformanceCurve;

		// Token: 0x04010D46 RID: 68934
		internal static int __PropertyOffset_17;

		// Token: 0x04010D47 RID: 68935
		[Nullable(2)]
		private FKuroCurveFloat _TimeDilationPerformanceCurve;

		// Token: 0x04010D48 RID: 68936
		internal static int __PropertyOffset_18;

		// Token: 0x04010D49 RID: 68937
		internal static int __PropertyOffset_19;
	}
}
