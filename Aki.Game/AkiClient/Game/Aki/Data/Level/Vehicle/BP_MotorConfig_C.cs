using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x02003EFB RID: 16123
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_MotorConfig.BP_MotorConfig_C")]
	[UnrealStructLayout(976, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 976)]
	public class BP_MotorConfig_C : BP_VehicleConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028DB6 RID: 167350 RVA: 0x009B607B File Offset: 0x009B427B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MotorConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_MotorConfig.BP_MotorConfig_C");
			}
			return BP_MotorConfig_C._ClassPtr;
		}

		// Token: 0x06028DB7 RID: 167351 RVA: 0x009B60A0 File Offset: 0x009B42A0
		public BP_MotorConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MotorConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028DB8 RID: 167352 RVA: 0x009B60C8 File Offset: 0x009B42C8
		public BP_MotorConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MotorConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FFC RID: 24572
		// (get) Token: 0x06028DB9 RID: 167353 RVA: 0x009B60FB File Offset: 0x009B42FB
		// (set) Token: 0x06028DBA RID: 167354 RVA: 0x009B610F File Offset: 0x009B430F
		[Nullable(2)]
		public unsafe UDataTable ConfigDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005FFD RID: 24573
		// (get) Token: 0x06028DBB RID: 167355 RVA: 0x009B6124 File Offset: 0x009B4324
		// (set) Token: 0x06028DBC RID: 167356 RVA: 0x009B615D File Offset: 0x009B435D
		public TArray<SFloatThresholdAndBuff> 非加速状态buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._非加速状态buff) == null)
				{
					result = (this._非加速状态buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.非加速状态buff.CopyAssign(value);
			}
		}

		// Token: 0x17005FFE RID: 24574
		// (get) Token: 0x06028DBD RID: 167357 RVA: 0x009B616C File Offset: 0x009B436C
		// (set) Token: 0x06028DBE RID: 167358 RVA: 0x009B61A5 File Offset: 0x009B43A5
		public TArray<SFloatThresholdAndBuff> 加速状态buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._加速状态buff) == null)
				{
					result = (this._加速状态buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.加速状态buff.CopyAssign(value);
			}
		}

		// Token: 0x17005FFF RID: 24575
		// (get) Token: 0x06028DBF RID: 167359 RVA: 0x009B61B4 File Offset: 0x009B43B4
		// (set) Token: 0x06028DC0 RID: 167360 RVA: 0x009B61ED File Offset: 0x009B43ED
		public TArray<SFloatThresholdAndBuff> 翱翔加速状态buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._翱翔加速状态buff) == null)
				{
					result = (this._翱翔加速状态buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.翱翔加速状态buff.CopyAssign(value);
			}
		}

		// Token: 0x17006000 RID: 24576
		// (get) Token: 0x06028DC1 RID: 167361 RVA: 0x009B61FB File Offset: 0x009B43FB
		// (set) Token: 0x06028DC2 RID: 167362 RVA: 0x009B620B File Offset: 0x009B440B
		public unsafe long 常驻buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006001 RID: 24577
		// (get) Token: 0x06028DC3 RID: 167363 RVA: 0x009B621C File Offset: 0x009B441C
		// (set) Token: 0x06028DC4 RID: 167364 RVA: 0x009B6255 File Offset: 0x009B4455
		public TArray<SFloatThresholdAndBuff> 时段buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndBuff> result;
				if ((result = this._时段buff) == null)
				{
					result = (this._时段buff = new TArray<SFloatThresholdAndBuff>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.时段buff.CopyAssign(value);
			}
		}

		// Token: 0x17006002 RID: 24578
		// (get) Token: 0x06028DC5 RID: 167365 RVA: 0x009B6263 File Offset: 0x009B4463
		// (set) Token: 0x06028DC6 RID: 167366 RVA: 0x009B6273 File Offset: 0x009B4473
		public unsafe long 漂移buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006003 RID: 24579
		// (get) Token: 0x06028DC7 RID: 167367 RVA: 0x009B6284 File Offset: 0x009B4484
		// (set) Token: 0x06028DC8 RID: 167368 RVA: 0x009B6294 File Offset: 0x009B4494
		public unsafe long 倒车buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006004 RID: 24580
		// (get) Token: 0x06028DC9 RID: 167369 RVA: 0x009B62A8 File Offset: 0x009B44A8
		// (set) Token: 0x06028DCA RID: 167370 RVA: 0x009B62E1 File Offset: 0x009B44E1
		public TMap<EMotorPart, long> 撞击buff
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EMotorPart, long> result;
				if ((result = this._撞击buff) == null)
				{
					result = (this._撞击buff = new TMap<EMotorPart, long>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.撞击buff.CopyAssign(value);
			}
		}

		// Token: 0x17006005 RID: 24581
		// (get) Token: 0x06028DCB RID: 167371 RVA: 0x009B62EF File Offset: 0x009B44EF
		// (set) Token: 0x06028DCC RID: 167372 RVA: 0x009B62FF File Offset: 0x009B44FF
		public unsafe float 叠加速度衰减时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006006 RID: 24582
		// (get) Token: 0x06028DCD RID: 167373 RVA: 0x009B6310 File Offset: 0x009B4510
		// (set) Token: 0x06028DCE RID: 167374 RVA: 0x009B6320 File Offset: 0x009B4520
		public unsafe float 载具速度叠加比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006007 RID: 24583
		// (get) Token: 0x06028DCF RID: 167375 RVA: 0x009B6331 File Offset: 0x009B4531
		// (set) Token: 0x06028DD0 RID: 167376 RVA: 0x009B6345 File Offset: 0x009B4545
		[Nullable(2)]
		public unsafe UCurveFloat 叠加速度衰减曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_11);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorConfig_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006008 RID: 24584
		// (get) Token: 0x06028DD1 RID: 167377 RVA: 0x009B635C File Offset: 0x009B455C
		// (set) Token: 0x06028DD2 RID: 167378 RVA: 0x009B6395 File Offset: 0x009B4595
		public TArray<long> 常驻buffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._常驻buffs) == null)
				{
					result = (this._常驻buffs = new TArray<long>(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.常驻buffs.CopyAssign(value);
			}
		}

		// Token: 0x17006009 RID: 24585
		// (get) Token: 0x06028DD3 RID: 167379 RVA: 0x009B63A3 File Offset: 0x009B45A3
		// (set) Token: 0x06028DD4 RID: 167380 RVA: 0x009B63B7 File Offset: 0x009B45B7
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
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_13);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700600A RID: 24586
		// (get) Token: 0x06028DD5 RID: 167381 RVA: 0x009B63CC File Offset: 0x009B45CC
		// (set) Token: 0x06028DD6 RID: 167382 RVA: 0x009B63DC File Offset: 0x009B45DC
		public unsafe long 和小物件重合时的特效Buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x06028DD7 RID: 167383 RVA: 0x009B63ED File Offset: 0x009B45ED
		protected BP_MotorConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E40 RID: 85568
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_MotorConfig.BP_MotorConfig_C";

		// Token: 0x04014E41 RID: 85569
		private static IntPtr _ClassPtr;

		// Token: 0x04014E42 RID: 85570
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E43 RID: 85571
		internal new static int __PropertyOffset_0;

		// Token: 0x04014E44 RID: 85572
		internal new static int __PropertyOffset_1;

		// Token: 0x04014E45 RID: 85573
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _非加速状态buff;

		// Token: 0x04014E46 RID: 85574
		internal new static int __PropertyOffset_2;

		// Token: 0x04014E47 RID: 85575
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _加速状态buff;

		// Token: 0x04014E48 RID: 85576
		internal new static int __PropertyOffset_3;

		// Token: 0x04014E49 RID: 85577
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _翱翔加速状态buff;

		// Token: 0x04014E4A RID: 85578
		internal new static int __PropertyOffset_4;

		// Token: 0x04014E4B RID: 85579
		internal new static int __PropertyOffset_5;

		// Token: 0x04014E4C RID: 85580
		[Nullable(2)]
		private TArray<SFloatThresholdAndBuff> _时段buff;

		// Token: 0x04014E4D RID: 85581
		internal new static int __PropertyOffset_6;

		// Token: 0x04014E4E RID: 85582
		internal new static int __PropertyOffset_7;

		// Token: 0x04014E4F RID: 85583
		internal new static int __PropertyOffset_8;

		// Token: 0x04014E50 RID: 85584
		[Nullable(2)]
		private TMap<EMotorPart, long> _撞击buff;

		// Token: 0x04014E51 RID: 85585
		internal new static int __PropertyOffset_9;

		// Token: 0x04014E52 RID: 85586
		internal new static int __PropertyOffset_10;

		// Token: 0x04014E53 RID: 85587
		internal new static int __PropertyOffset_11;

		// Token: 0x04014E54 RID: 85588
		internal new static int __PropertyOffset_12;

		// Token: 0x04014E55 RID: 85589
		[Nullable(2)]
		private TArray<long> _常驻buffs;

		// Token: 0x04014E56 RID: 85590
		internal new static int __PropertyOffset_13;

		// Token: 0x04014E57 RID: 85591
		internal new static int __PropertyOffset_14;
	}
}
