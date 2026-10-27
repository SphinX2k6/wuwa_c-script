using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs
{
	// Token: 0x02003BC6 RID: 15302
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfigs.PDA_RainConfigs_C")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class PDA_RainConfigs_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060224AB RID: 140459 RVA: 0x00904AF7 File Offset: 0x00902CF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_RainConfigs_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfigs.PDA_RainConfigs_C");
			}
			return PDA_RainConfigs_C._ClassPtr;
		}

		// Token: 0x060224AC RID: 140460 RVA: 0x00904B1C File Offset: 0x00902D1C
		public PDA_RainConfigs_C() : this(BuiltinUtils.AllocNativeUObject(PDA_RainConfigs_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224AD RID: 140461 RVA: 0x00904B44 File Offset: 0x00902D44
		public PDA_RainConfigs_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_RainConfigs_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x060224AE RID: 140462 RVA: 0x00904B77 File Offset: 0x00902D77
		// (set) Token: 0x060224AF RID: 140463 RVA: 0x00904B8B File Offset: 0x00902D8B
		[Nullable(2)]
		public unsafe PDA_RainConfig_CommonReverse_C RainConfig_CommonReverse_Lively
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfig_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x060224B0 RID: 140464 RVA: 0x00904BA0 File Offset: 0x00902DA0
		// (set) Token: 0x060224B1 RID: 140465 RVA: 0x00904BB4 File Offset: 0x00902DB4
		[Nullable(2)]
		public unsafe PDA_RainConfig_CommonReverse_C RainConfig_CommonReverse_Stable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfig_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x060224B2 RID: 140466 RVA: 0x00904BC9 File Offset: 0x00902DC9
		// (set) Token: 0x060224B3 RID: 140467 RVA: 0x00904BDD File Offset: 0x00902DDD
		[Nullable(2)]
		public unsafe PDA_RainConfig_CommonReverse_C RainConfig_CommonReverse_Fast
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfig_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x060224B4 RID: 140468 RVA: 0x00904BF2 File Offset: 0x00902DF2
		// (set) Token: 0x060224B5 RID: 140469 RVA: 0x00904C06 File Offset: 0x00902E06
		[Nullable(2)]
		public unsafe PDA_RainConfig_CommonReverse_C RainConfig_CommonReverse_UrgentTurn
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfig_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RainConfigs_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x060224B6 RID: 140470 RVA: 0x00904C1C File Offset: 0x00902E1C
		// (set) Token: 0x060224B7 RID: 140471 RVA: 0x00904C55 File Offset: 0x00902E55
		public SWorldRainComb SnowConfig_CommonDrop
		{
			get
			{
				base.FastCheckIsValid();
				SWorldRainComb result;
				if ((result = this._SnowConfig_CommonDrop) == null)
				{
					result = (this._SnowConfig_CommonDrop = new SWorldRainComb(base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x060224B8 RID: 140472 RVA: 0x00904C78 File Offset: 0x00902E78
		// (set) Token: 0x060224B9 RID: 140473 RVA: 0x00904CB1 File Offset: 0x00902EB1
		public SWorldRainComb RainConfig_CommonDrop_1
		{
			get
			{
				base.FastCheckIsValid();
				SWorldRainComb result;
				if ((result = this._RainConfig_CommonDrop_1) == null)
				{
					result = (this._RainConfig_CommonDrop_1 = new SWorldRainComb(base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x060224BA RID: 140474 RVA: 0x00904CD4 File Offset: 0x00902ED4
		// (set) Token: 0x060224BB RID: 140475 RVA: 0x00904D0D File Offset: 0x00902F0D
		public SWorldRainComb SnowConfig_JinkuBoss
		{
			get
			{
				base.FastCheckIsValid();
				SWorldRainComb result;
				if ((result = this._SnowConfig_JinkuBoss) == null)
				{
					result = (this._SnowConfig_JinkuBoss = new SWorldRainComb(base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x060224BC RID: 140476 RVA: 0x00904D30 File Offset: 0x00902F30
		// (set) Token: 0x060224BD RID: 140477 RVA: 0x00904D69 File Offset: 0x00902F69
		public SWorldRainComb RainConfig_BlackWave
		{
			get
			{
				base.FastCheckIsValid();
				SWorldRainComb result;
				if ((result = this._RainConfig_BlackWave) == null)
				{
					result = (this._RainConfig_BlackWave = new SWorldRainComb(base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x060224BE RID: 140478 RVA: 0x00904D8C File Offset: 0x00902F8C
		// (set) Token: 0x060224BF RID: 140479 RVA: 0x00904DC5 File Offset: 0x00902FC5
		public SWorldRainComb SnowConfig_SnowStorm
		{
			get
			{
				base.FastCheckIsValid();
				SWorldRainComb result;
				if ((result = this._SnowConfig_SnowStorm) == null)
				{
					result = (this._SnowConfig_SnowStorm = new SWorldRainComb(base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x060224C0 RID: 140480 RVA: 0x00904DE8 File Offset: 0x00902FE8
		// (set) Token: 0x060224C1 RID: 140481 RVA: 0x00904E21 File Offset: 0x00903021
		public SWorldRainComb RainConfig_StormRain
		{
			get
			{
				base.FastCheckIsValid();
				SWorldRainComb result;
				if ((result = this._RainConfig_StormRain) == null)
				{
					result = (this._RainConfig_StormRain = new SWorldRainComb(base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x060224C2 RID: 140482 RVA: 0x00904E44 File Offset: 0x00903044
		// (set) Token: 0x060224C3 RID: 140483 RVA: 0x00904E7D File Offset: 0x0090307D
		public SWorldRainComb RainConfig_CyberRain
		{
			get
			{
				base.FastCheckIsValid();
				SWorldRainComb result;
				if ((result = this._RainConfig_CyberRain) == null)
				{
					result = (this._RainConfig_CyberRain = new SWorldRainComb(base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), base.NativePtr + (IntPtr)PDA_RainConfigs_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060224C4 RID: 140484 RVA: 0x00904E9E File Offset: 0x0090309E
		protected PDA_RainConfigs_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010CFD RID: 68861
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/Configs/PDA_RainConfigs.PDA_RainConfigs_C";

		// Token: 0x04010CFE RID: 68862
		private static IntPtr _ClassPtr;

		// Token: 0x04010CFF RID: 68863
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D00 RID: 68864
		internal static int __PropertyOffset_0;

		// Token: 0x04010D01 RID: 68865
		internal static int __PropertyOffset_1;

		// Token: 0x04010D02 RID: 68866
		internal static int __PropertyOffset_2;

		// Token: 0x04010D03 RID: 68867
		internal static int __PropertyOffset_3;

		// Token: 0x04010D04 RID: 68868
		internal static int __PropertyOffset_4;

		// Token: 0x04010D05 RID: 68869
		[Nullable(2)]
		private SWorldRainComb _SnowConfig_CommonDrop;

		// Token: 0x04010D06 RID: 68870
		internal static int __PropertyOffset_5;

		// Token: 0x04010D07 RID: 68871
		[Nullable(2)]
		private SWorldRainComb _RainConfig_CommonDrop_1;

		// Token: 0x04010D08 RID: 68872
		internal static int __PropertyOffset_6;

		// Token: 0x04010D09 RID: 68873
		[Nullable(2)]
		private SWorldRainComb _SnowConfig_JinkuBoss;

		// Token: 0x04010D0A RID: 68874
		internal static int __PropertyOffset_7;

		// Token: 0x04010D0B RID: 68875
		[Nullable(2)]
		private SWorldRainComb _RainConfig_BlackWave;

		// Token: 0x04010D0C RID: 68876
		internal static int __PropertyOffset_8;

		// Token: 0x04010D0D RID: 68877
		[Nullable(2)]
		private SWorldRainComb _SnowConfig_SnowStorm;

		// Token: 0x04010D0E RID: 68878
		internal static int __PropertyOffset_9;

		// Token: 0x04010D0F RID: 68879
		[Nullable(2)]
		private SWorldRainComb _RainConfig_StormRain;

		// Token: 0x04010D10 RID: 68880
		internal static int __PropertyOffset_10;

		// Token: 0x04010D11 RID: 68881
		[Nullable(2)]
		private SWorldRainComb _RainConfig_CyberRain;
	}
}
