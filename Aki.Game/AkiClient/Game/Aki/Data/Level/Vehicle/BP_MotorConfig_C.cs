using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x020031B8 RID: 12728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_MotorConfig.BP_MotorConfig_C")]
	[UnrealStructLayout(976, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 976)]
	public class BP_MotorConfig_C : BP_VehicleConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F753 RID: 128851 RVA: 0x0092E143 File Offset: 0x0092C343
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MotorConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_MotorConfig.BP_MotorConfig_C");
			}
			return BP_MotorConfig_C._ClassPtr;
		}

		// Token: 0x0601F754 RID: 128852 RVA: 0x0092E168 File Offset: 0x0092C368
		public BP_MotorConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MotorConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F755 RID: 128853 RVA: 0x0092E190 File Offset: 0x0092C390
		public BP_MotorConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MotorConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0601F756 RID: 128854 RVA: 0x0092E1C3 File Offset: 0x0092C3C3
		// (set) Token: 0x0601F757 RID: 128855 RVA: 0x0092E1D7 File Offset: 0x0092C3D7
		[Nullable(2)]
		public unsafe UDataTable ConfigDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_ConfigDataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_ConfigDataTable, value);
			}
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0601F758 RID: 128856 RVA: 0x0092E1EC File Offset: 0x0092C3EC
		// (set) Token: 0x0601F759 RID: 128857 RVA: 0x0092E225 File Offset: 0x0092C425
		public TArray<SFloatThresholdAndBuff> 非加速状态buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._非加速状态buff) == null)
				{
					result = (this._非加速状态buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_非加速状态buff, this));
				}
				return result;
			}
			set
			{
				this.非加速状态buff.CopyAssign(value);
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0601F75A RID: 128858 RVA: 0x0092E234 File Offset: 0x0092C434
		// (set) Token: 0x0601F75B RID: 128859 RVA: 0x0092E26D File Offset: 0x0092C46D
		public TArray<SFloatThresholdAndBuff> 加速状态buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._加速状态buff) == null)
				{
					result = (this._加速状态buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_加速状态buff, this));
				}
				return result;
			}
			set
			{
				this.加速状态buff.CopyAssign(value);
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0601F75C RID: 128860 RVA: 0x0092E27C File Offset: 0x0092C47C
		// (set) Token: 0x0601F75D RID: 128861 RVA: 0x0092E2B5 File Offset: 0x0092C4B5
		public TArray<SFloatThresholdAndBuff> 翱翔加速状态buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._翱翔加速状态buff) == null)
				{
					result = (this._翱翔加速状态buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_翱翔加速状态buff, this));
				}
				return result;
			}
			set
			{
				this.翱翔加速状态buff.CopyAssign(value);
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0601F75E RID: 128862 RVA: 0x0092E2C3 File Offset: 0x0092C4C3
		// (set) Token: 0x0601F75F RID: 128863 RVA: 0x0092E2D3 File Offset: 0x0092C4D3
		public unsafe long 常驻buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_常驻buff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_常驻buff) = value;
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0601F760 RID: 128864 RVA: 0x0092E2E4 File Offset: 0x0092C4E4
		// (set) Token: 0x0601F761 RID: 128865 RVA: 0x0092E31D File Offset: 0x0092C51D
		public TArray<SFloatThresholdAndBuff> 时段buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._时段buff) == null)
				{
					result = (this._时段buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_时段buff, this));
				}
				return result;
			}
			set
			{
				this.时段buff.CopyAssign(value);
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0601F762 RID: 128866 RVA: 0x0092E32B File Offset: 0x0092C52B
		// (set) Token: 0x0601F763 RID: 128867 RVA: 0x0092E33B File Offset: 0x0092C53B
		public unsafe long 漂移buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_漂移buff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_漂移buff) = value;
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0601F764 RID: 128868 RVA: 0x0092E34C File Offset: 0x0092C54C
		// (set) Token: 0x0601F765 RID: 128869 RVA: 0x0092E35C File Offset: 0x0092C55C
		public unsafe long 倒车buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_倒车buff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_倒车buff) = value;
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0601F766 RID: 128870 RVA: 0x0092E370 File Offset: 0x0092C570
		// (set) Token: 0x0601F767 RID: 128871 RVA: 0x0092E3A9 File Offset: 0x0092C5A9
		public TMap<EMotorPart, long> 撞击buff
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EMotorPart, long> result;
				if ((result = this._撞击buff) == null)
				{
					result = (this._撞击buff = new TMap<EMotorPart, long>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_撞击buff, this));
				}
				return result;
			}
			set
			{
				this.撞击buff.CopyAssign(value);
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0601F768 RID: 128872 RVA: 0x0092E3B7 File Offset: 0x0092C5B7
		// (set) Token: 0x0601F769 RID: 128873 RVA: 0x0092E3C7 File Offset: 0x0092C5C7
		public unsafe float 叠加速度衰减时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_叠加速度衰减时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_叠加速度衰减时间) = value;
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0601F76A RID: 128874 RVA: 0x0092E3D8 File Offset: 0x0092C5D8
		// (set) Token: 0x0601F76B RID: 128875 RVA: 0x0092E3E8 File Offset: 0x0092C5E8
		public unsafe float 载具速度叠加比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_载具速度叠加比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_载具速度叠加比例) = value;
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0601F76C RID: 128876 RVA: 0x0092E3F9 File Offset: 0x0092C5F9
		// (set) Token: 0x0601F76D RID: 128877 RVA: 0x0092E40D File Offset: 0x0092C60D
		[Nullable(2)]
		public unsafe UCurveFloat 叠加速度衰减曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_叠加速度衰减曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_叠加速度衰减曲线, value);
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0601F76E RID: 128878 RVA: 0x0092E424 File Offset: 0x0092C624
		// (set) Token: 0x0601F76F RID: 128879 RVA: 0x0092E45D File Offset: 0x0092C65D
		public TArray<long> 常驻buffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._常驻buffs) == null)
				{
					result = (this._常驻buffs = new TArray<long>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_常驻buffs, this));
				}
				return result;
			}
			set
			{
				this.常驻buffs.CopyAssign(value);
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0601F770 RID: 128880 RVA: 0x0092E46B File Offset: 0x0092C66B
		// (set) Token: 0x0601F771 RID: 128881 RVA: 0x0092E47F File Offset: 0x0092C67F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_CameraShakeAndForceFeedback_C> 冲刺震屏
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_冲刺震屏);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_冲刺震屏) = value;
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0601F772 RID: 128882 RVA: 0x0092E494 File Offset: 0x0092C694
		// (set) Token: 0x0601F773 RID: 128883 RVA: 0x0092E4A4 File Offset: 0x0092C6A4
		public unsafe long 和小物件重合时的特效Buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_和小物件重合时的特效Buff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_和小物件重合时的特效Buff) = value;
			}
		}

		// Token: 0x0601F774 RID: 128884 RVA: 0x0092E4B5 File Offset: 0x0092C6B5
		protected BP_MotorConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DE5 RID: 69093
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_MotorConfig.BP_MotorConfig_C";

		// Token: 0x04010DE6 RID: 69094
		private static IntPtr _ClassPtr;

		// Token: 0x04010DE7 RID: 69095
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DE8 RID: 69096
		internal static int __PropertyOffset_ConfigDataTable;

		// Token: 0x04010DE9 RID: 69097
		internal static int __PropertyOffset_非加速状态buff;

		// Token: 0x04010DEA RID: 69098
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _非加速状态buff;

		// Token: 0x04010DEB RID: 69099
		internal static int __PropertyOffset_加速状态buff;

		// Token: 0x04010DEC RID: 69100
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _加速状态buff;

		// Token: 0x04010DED RID: 69101
		internal static int __PropertyOffset_翱翔加速状态buff;

		// Token: 0x04010DEE RID: 69102
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _翱翔加速状态buff;

		// Token: 0x04010DEF RID: 69103
		internal static int __PropertyOffset_常驻buff;

		// Token: 0x04010DF0 RID: 69104
		internal static int __PropertyOffset_时段buff;

		// Token: 0x04010DF1 RID: 69105
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _时段buff;

		// Token: 0x04010DF2 RID: 69106
		internal static int __PropertyOffset_漂移buff;

		// Token: 0x04010DF3 RID: 69107
		internal static int __PropertyOffset_倒车buff;

		// Token: 0x04010DF4 RID: 69108
		internal static int __PropertyOffset_撞击buff;

		// Token: 0x04010DF5 RID: 69109
		[Nullable(2)]
		private TMap<EMotorPart, long> _撞击buff;

		// Token: 0x04010DF6 RID: 69110
		internal static int __PropertyOffset_叠加速度衰减时间;

		// Token: 0x04010DF7 RID: 69111
		internal static int __PropertyOffset_载具速度叠加比例;

		// Token: 0x04010DF8 RID: 69112
		internal static int __PropertyOffset_叠加速度衰减曲线;

		// Token: 0x04010DF9 RID: 69113
		internal static int __PropertyOffset_常驻buffs;

		// Token: 0x04010DFA RID: 69114
		[Nullable(2)]
		private TArray<long> _常驻buffs;

		// Token: 0x04010DFB RID: 69115
		internal static int __PropertyOffset_冲刺震屏;

		// Token: 0x04010DFC RID: 69116
		internal static int __PropertyOffset_和小物件重合时的特效Buff;
	}
}
