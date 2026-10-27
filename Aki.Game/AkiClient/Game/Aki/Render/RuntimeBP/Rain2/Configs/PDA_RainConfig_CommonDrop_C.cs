using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs
{
	// Token: 0x02003BC7 RID: 15303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfig_CommonDrop.PDA_RainConfig_CommonDrop_C")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class PDA_RainConfig_CommonDrop_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060224C5 RID: 140485 RVA: 0x00904EA7 File Offset: 0x009030A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_RainConfig_CommonDrop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfig_CommonDrop.PDA_RainConfig_CommonDrop_C");
			}
			return PDA_RainConfig_CommonDrop_C._ClassPtr;
		}

		// Token: 0x060224C6 RID: 140486 RVA: 0x00904ECC File Offset: 0x009030CC
		public PDA_RainConfig_CommonDrop_C() : this(BuiltinUtils.AllocNativeUObject(PDA_RainConfig_CommonDrop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224C7 RID: 140487 RVA: 0x00904EF4 File Offset: 0x009030F4
		public PDA_RainConfig_CommonDrop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_RainConfig_CommonDrop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x060224C8 RID: 140488 RVA: 0x00904F28 File Offset: 0x00903128
		// (set) Token: 0x060224C9 RID: 140489 RVA: 0x00904F61 File Offset: 0x00903161
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x060224CA RID: 140490 RVA: 0x00904F70 File Offset: 0x00903170
		// (set) Token: 0x060224CB RID: 140491 RVA: 0x00904FA9 File Offset: 0x009031A9
		public TArray<UStaticMesh> Meshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x060224CC RID: 140492 RVA: 0x00904FB8 File Offset: 0x009031B8
		// (set) Token: 0x060224CD RID: 140493 RVA: 0x00904FF1 File Offset: 0x009031F1
		public TArray<SCommonRainSpawnerConfig> Spawners
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCommonRainSpawnerConfig> result;
				if ((result = this._Spawners) == null)
				{
					result = (this._Spawners = new TArray<SCommonRainSpawnerConfig>(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.Spawners.CopyAssign(value);
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x060224CE RID: 140494 RVA: 0x00904FFF File Offset: 0x009031FF
		// (set) Token: 0x060224CF RID: 140495 RVA: 0x00905013 File Offset: 0x00903213
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x060224D0 RID: 140496 RVA: 0x00905028 File Offset: 0x00903228
		// (set) Token: 0x060224D1 RID: 140497 RVA: 0x0090503C File Offset: 0x0090323C
		public unsafe FVector Wind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x060224D2 RID: 140498 RVA: 0x00905051 File Offset: 0x00903251
		// (set) Token: 0x060224D3 RID: 140499 RVA: 0x00905061 File Offset: 0x00903261
		public unsafe float Drag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x060224D4 RID: 140500 RVA: 0x00905074 File Offset: 0x00903274
		// (set) Token: 0x060224D5 RID: 140501 RVA: 0x009050AD File Offset: 0x009032AD
		public FKuroCurveFloat OpacityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._OpacityCurve) == null)
				{
					result = (this._OpacityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x060224D6 RID: 140502 RVA: 0x009050D0 File Offset: 0x009032D0
		// (set) Token: 0x060224D7 RID: 140503 RVA: 0x00905109 File Offset: 0x00903309
		public FKuroCurveFloat StretchCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StretchCurve) == null)
				{
					result = (this._StretchCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x060224D8 RID: 140504 RVA: 0x0090512A File Offset: 0x0090332A
		// (set) Token: 0x060224D9 RID: 140505 RVA: 0x0090513A File Offset: 0x0090333A
		public unsafe float CycleBoxX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x060224DA RID: 140506 RVA: 0x0090514B File Offset: 0x0090334B
		// (set) Token: 0x060224DB RID: 140507 RVA: 0x0090515B File Offset: 0x0090335B
		public unsafe float CycleBoxY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x060224DC RID: 140508 RVA: 0x0090516C File Offset: 0x0090336C
		// (set) Token: 0x060224DD RID: 140509 RVA: 0x0090517C File Offset: 0x0090337C
		public unsafe float CycleBoxZ_Positive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x060224DE RID: 140510 RVA: 0x0090518D File Offset: 0x0090338D
		// (set) Token: 0x060224DF RID: 140511 RVA: 0x0090519D File Offset: 0x0090339D
		public unsafe float CycleBoxZ_Negative
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RainConfig_CommonDrop_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x060224E0 RID: 140512 RVA: 0x009051AE File Offset: 0x009033AE
		// (set) Token: 0x060224E1 RID: 140513 RVA: 0x009051C2 File Offset: 0x009033C2
		[Nullable(2)]
		public unsafe UNiagaraSystem Niagara
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonDrop_C.__PropertyOffset_12);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonDrop_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x060224E2 RID: 140514 RVA: 0x009051D7 File Offset: 0x009033D7
		// (set) Token: 0x060224E3 RID: 140515 RVA: 0x009051EB File Offset: 0x009033EB
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonDrop_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfig_CommonDrop_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x060224E4 RID: 140516 RVA: 0x00905200 File Offset: 0x00903400
		protected PDA_RainConfig_CommonDrop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D12 RID: 68882
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfig_CommonDrop.PDA_RainConfig_CommonDrop_C";

		// Token: 0x04010D13 RID: 68883
		private static IntPtr _ClassPtr;

		// Token: 0x04010D14 RID: 68884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D15 RID: 68885
		internal static int __PropertyOffset_0;

		// Token: 0x04010D16 RID: 68886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x04010D17 RID: 68887
		internal static int __PropertyOffset_1;

		// Token: 0x04010D18 RID: 68888
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _Meshes;

		// Token: 0x04010D19 RID: 68889
		internal static int __PropertyOffset_2;

		// Token: 0x04010D1A RID: 68890
		[Nullable(2)]
		private TArray<SCommonRainSpawnerConfig> _Spawners;

		// Token: 0x04010D1B RID: 68891
		internal static int __PropertyOffset_3;

		// Token: 0x04010D1C RID: 68892
		internal static int __PropertyOffset_4;

		// Token: 0x04010D1D RID: 68893
		internal static int __PropertyOffset_5;

		// Token: 0x04010D1E RID: 68894
		internal static int __PropertyOffset_6;

		// Token: 0x04010D1F RID: 68895
		[Nullable(2)]
		private FKuroCurveFloat _OpacityCurve;

		// Token: 0x04010D20 RID: 68896
		internal static int __PropertyOffset_7;

		// Token: 0x04010D21 RID: 68897
		[Nullable(2)]
		private FKuroCurveFloat _StretchCurve;

		// Token: 0x04010D22 RID: 68898
		internal static int __PropertyOffset_8;

		// Token: 0x04010D23 RID: 68899
		internal static int __PropertyOffset_9;

		// Token: 0x04010D24 RID: 68900
		internal static int __PropertyOffset_10;

		// Token: 0x04010D25 RID: 68901
		internal static int __PropertyOffset_11;

		// Token: 0x04010D26 RID: 68902
		internal static int __PropertyOffset_12;

		// Token: 0x04010D27 RID: 68903
		internal static int __PropertyOffset_13;
	}
}
