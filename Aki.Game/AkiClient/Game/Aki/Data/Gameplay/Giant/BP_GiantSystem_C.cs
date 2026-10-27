using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.Giant
{
	// Token: 0x02003F48 RID: 16200
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Giant/BP_GiantSystem.BP_GiantSystem_C")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class BP_GiantSystem_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060293A9 RID: 168873 RVA: 0x009BEF63 File Offset: 0x009BD163
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GiantSystem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/Giant/BP_GiantSystem.BP_GiantSystem_C");
			}
			return BP_GiantSystem_C._ClassPtr;
		}

		// Token: 0x060293AA RID: 168874 RVA: 0x009BEF88 File Offset: 0x009BD188
		public BP_GiantSystem_C() : this(BuiltinUtils.AllocNativeUObject(BP_GiantSystem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060293AB RID: 168875 RVA: 0x009BEFB0 File Offset: 0x009BD1B0
		public BP_GiantSystem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GiantSystem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006227 RID: 25127
		// (get) Token: 0x060293AC RID: 168876 RVA: 0x009BEFE3 File Offset: 0x009BD1E3
		// (set) Token: 0x060293AD RID: 168877 RVA: 0x009BEFF8 File Offset: 0x009BD1F8
		public TSoftClassPtr<AActor> GiantActorClass
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_0, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006228 RID: 25128
		// (get) Token: 0x060293AE RID: 168878 RVA: 0x009BF01D File Offset: 0x009BD21D
		// (set) Token: 0x060293AF RID: 168879 RVA: 0x009BF031 File Offset: 0x009BD231
		public unsafe FTransformDouble GiantActorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006229 RID: 25129
		// (get) Token: 0x060293B0 RID: 168880 RVA: 0x009BF048 File Offset: 0x009BD248
		// (set) Token: 0x060293B1 RID: 168881 RVA: 0x009BF081 File Offset: 0x009BD281
		public TMap<int, FName> SpecialBaseIdles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FName> result;
				if ((result = this._SpecialBaseIdles) == null)
				{
					result = (this._SpecialBaseIdles = new TMap<int, FName>(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.SpecialBaseIdles.CopyAssign(value);
			}
		}

		// Token: 0x1700622A RID: 25130
		// (get) Token: 0x060293B2 RID: 168882 RVA: 0x009BF08F File Offset: 0x009BD28F
		// (set) Token: 0x060293B3 RID: 168883 RVA: 0x009BF09F File Offset: 0x009BD29F
		public unsafe float RestLoopAnimSwitchTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700622B RID: 25131
		// (get) Token: 0x060293B4 RID: 168884 RVA: 0x009BF0B0 File Offset: 0x009BD2B0
		// (set) Token: 0x060293B5 RID: 168885 RVA: 0x009BF0C0 File Offset: 0x009BD2C0
		public unsafe float MainViewPicSwitchInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700622C RID: 25132
		// (get) Token: 0x060293B6 RID: 168886 RVA: 0x009BF0D1 File Offset: 0x009BD2D1
		// (set) Token: 0x060293B7 RID: 168887 RVA: 0x009BF0E1 File Offset: 0x009BD2E1
		public unsafe int InteractMarkId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700622D RID: 25133
		// (get) Token: 0x060293B8 RID: 168888 RVA: 0x009BF0F2 File Offset: 0x009BD2F2
		// (set) Token: 0x060293B9 RID: 168889 RVA: 0x009BF102 File Offset: 0x009BD302
		public unsafe int HelpId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700622E RID: 25134
		// (get) Token: 0x060293BA RID: 168890 RVA: 0x009BF113 File Offset: 0x009BD313
		// (set) Token: 0x060293BB RID: 168891 RVA: 0x009BF127 File Offset: 0x009BD327
		public unsafe FName TipsKeyPreMainlineWholeLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700622F RID: 25135
		// (get) Token: 0x060293BC RID: 168892 RVA: 0x009BF13C File Offset: 0x009BD33C
		// (set) Token: 0x060293BD RID: 168893 RVA: 0x009BF150 File Offset: 0x009BD350
		public unsafe FName TipsKeyHighQualityLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006230 RID: 25136
		// (get) Token: 0x060293BE RID: 168894 RVA: 0x009BF165 File Offset: 0x009BD365
		// (set) Token: 0x060293BF RID: 168895 RVA: 0x009BF179 File Offset: 0x009BD379
		public unsafe FName TipsKeyNoDeliverableItem
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006231 RID: 25137
		// (get) Token: 0x060293C0 RID: 168896 RVA: 0x009BF18E File Offset: 0x009BD38E
		// (set) Token: 0x060293C1 RID: 168897 RVA: 0x009BF1A2 File Offset: 0x009BD3A2
		public unsafe FName TipsKeyEcoMaxLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006232 RID: 25138
		// (get) Token: 0x060293C2 RID: 168898 RVA: 0x009BF1B7 File Offset: 0x009BD3B7
		// (set) Token: 0x060293C3 RID: 168899 RVA: 0x009BF1CB File Offset: 0x009BD3CB
		public unsafe FName TipsKeyNodeLockedInteract
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006233 RID: 25139
		// (get) Token: 0x060293C4 RID: 168900 RVA: 0x009BF1E0 File Offset: 0x009BD3E0
		// (set) Token: 0x060293C5 RID: 168901 RVA: 0x009BF1F4 File Offset: 0x009BD3F4
		public unsafe FName TipsKeyNodePendingActivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006234 RID: 25140
		// (get) Token: 0x060293C6 RID: 168902 RVA: 0x009BF209 File Offset: 0x009BD409
		// (set) Token: 0x060293C7 RID: 168903 RVA: 0x009BF21D File Offset: 0x009BD41D
		public unsafe FName TextKeyRewardTitleUpgrade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006235 RID: 25141
		// (get) Token: 0x060293C8 RID: 168904 RVA: 0x009BF232 File Offset: 0x009BD432
		// (set) Token: 0x060293C9 RID: 168905 RVA: 0x009BF246 File Offset: 0x009BD446
		public unsafe FName TextKeyRewardTitleOffering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006236 RID: 25142
		// (get) Token: 0x060293CA RID: 168906 RVA: 0x009BF25B File Offset: 0x009BD45B
		// (set) Token: 0x060293CB RID: 168907 RVA: 0x009BF26F File Offset: 0x009BD46F
		public unsafe FName TextKeyTraitTitleUpgrade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006237 RID: 25143
		// (get) Token: 0x060293CC RID: 168908 RVA: 0x009BF284 File Offset: 0x009BD484
		// (set) Token: 0x060293CD RID: 168909 RVA: 0x009BF298 File Offset: 0x009BD498
		public unsafe FName TextKeyTraitTitleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006238 RID: 25144
		// (get) Token: 0x060293CE RID: 168910 RVA: 0x009BF2AD File Offset: 0x009BD4AD
		// (set) Token: 0x060293CF RID: 168911 RVA: 0x009BF2C1 File Offset: 0x009BD4C1
		public unsafe FName TextKeyGoBtnNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006239 RID: 25145
		// (get) Token: 0x060293D0 RID: 168912 RVA: 0x009BF2D6 File Offset: 0x009BD4D6
		// (set) Token: 0x060293D1 RID: 168913 RVA: 0x009BF2EA File Offset: 0x009BD4EA
		public unsafe FName TextKeyGoBtnActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700623A RID: 25146
		// (get) Token: 0x060293D2 RID: 168914 RVA: 0x009BF2FF File Offset: 0x009BD4FF
		// (set) Token: 0x060293D3 RID: 168915 RVA: 0x009BF313 File Offset: 0x009BD513
		public unsafe FName TextKeyGiantTotalNodeAttitude0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700623B RID: 25147
		// (get) Token: 0x060293D4 RID: 168916 RVA: 0x009BF328 File Offset: 0x009BD528
		// (set) Token: 0x060293D5 RID: 168917 RVA: 0x009BF33C File Offset: 0x009BD53C
		public unsafe FName TextKeyGiantTotalNodeAssist0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700623C RID: 25148
		// (get) Token: 0x060293D6 RID: 168918 RVA: 0x009BF351 File Offset: 0x009BD551
		// (set) Token: 0x060293D7 RID: 168919 RVA: 0x009BF365 File Offset: 0x009BD565
		public unsafe FName TextKeyCollectAutoSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700623D RID: 25149
		// (get) Token: 0x060293D8 RID: 168920 RVA: 0x009BF37A File Offset: 0x009BD57A
		// (set) Token: 0x060293D9 RID: 168921 RVA: 0x009BF38E File Offset: 0x009BD58E
		public unsafe FName TextKeyCollectClearSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700623E RID: 25150
		// (get) Token: 0x060293DA RID: 168922 RVA: 0x009BF3A4 File Offset: 0x009BD5A4
		// (set) Token: 0x060293DB RID: 168923 RVA: 0x009BF3DD File Offset: 0x009BD5DD
		public TMap<int, FName> TipsKeyGiantNodeAttitudeByStage
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FName> result;
				if ((result = this._TipsKeyGiantNodeAttitudeByStage) == null)
				{
					result = (this._TipsKeyGiantNodeAttitudeByStage = new TMap<int, FName>(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				this.TipsKeyGiantNodeAttitudeByStage.CopyAssign(value);
			}
		}

		// Token: 0x060293DC RID: 168924 RVA: 0x009BF3EB File Offset: 0x009BD5EB
		protected BP_GiantSystem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040151D8 RID: 86488
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/Giant/BP_GiantSystem.BP_GiantSystem_C";

		// Token: 0x040151D9 RID: 86489
		private static IntPtr _ClassPtr;

		// Token: 0x040151DA RID: 86490
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040151DB RID: 86491
		internal static int __PropertyOffset_0;

		// Token: 0x040151DC RID: 86492
		internal static int __PropertyOffset_1;

		// Token: 0x040151DD RID: 86493
		internal static int __PropertyOffset_2;

		// Token: 0x040151DE RID: 86494
		[Nullable(2)]
		private TMap<int, FName> _SpecialBaseIdles;

		// Token: 0x040151DF RID: 86495
		internal static int __PropertyOffset_3;

		// Token: 0x040151E0 RID: 86496
		internal static int __PropertyOffset_4;

		// Token: 0x040151E1 RID: 86497
		internal static int __PropertyOffset_5;

		// Token: 0x040151E2 RID: 86498
		internal static int __PropertyOffset_6;

		// Token: 0x040151E3 RID: 86499
		internal static int __PropertyOffset_7;

		// Token: 0x040151E4 RID: 86500
		internal static int __PropertyOffset_8;

		// Token: 0x040151E5 RID: 86501
		internal static int __PropertyOffset_9;

		// Token: 0x040151E6 RID: 86502
		internal static int __PropertyOffset_10;

		// Token: 0x040151E7 RID: 86503
		internal static int __PropertyOffset_11;

		// Token: 0x040151E8 RID: 86504
		internal static int __PropertyOffset_12;

		// Token: 0x040151E9 RID: 86505
		internal static int __PropertyOffset_13;

		// Token: 0x040151EA RID: 86506
		internal static int __PropertyOffset_14;

		// Token: 0x040151EB RID: 86507
		internal static int __PropertyOffset_15;

		// Token: 0x040151EC RID: 86508
		internal static int __PropertyOffset_16;

		// Token: 0x040151ED RID: 86509
		internal static int __PropertyOffset_17;

		// Token: 0x040151EE RID: 86510
		internal static int __PropertyOffset_18;

		// Token: 0x040151EF RID: 86511
		internal static int __PropertyOffset_19;

		// Token: 0x040151F0 RID: 86512
		internal static int __PropertyOffset_20;

		// Token: 0x040151F1 RID: 86513
		internal static int __PropertyOffset_21;

		// Token: 0x040151F2 RID: 86514
		internal static int __PropertyOffset_22;

		// Token: 0x040151F3 RID: 86515
		internal static int __PropertyOffset_23;

		// Token: 0x040151F4 RID: 86516
		[Nullable(2)]
		private TMap<int, FName> _TipsKeyGiantNodeAttitudeByStage;
	}
}
