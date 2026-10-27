using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF0 RID: 16368
	[UnrealObjectPath("/Game/Aki/Core/Fight/BulletLogicType.BulletLogicType_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 163)]
	public class BulletLogicType_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029F60 RID: 171872 RVA: 0x009D1F71 File Offset: 0x009D0171
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BulletLogicType_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BulletLogicType.BulletLogicType_C");
			}
			return BulletLogicType_C._ClassPtr;
		}

		// Token: 0x06029F61 RID: 171873 RVA: 0x009D1F98 File Offset: 0x009D0198
		public BulletLogicType_C() : this(BuiltinUtils.AllocNativeUObject(BulletLogicType_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029F62 RID: 171874 RVA: 0x009D1FC0 File Offset: 0x009D01C0
		[NullableContext(1)]
		public BulletLogicType_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletLogicType_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006601 RID: 26113
		// (get) Token: 0x06029F63 RID: 171875 RVA: 0x009D1FF3 File Offset: 0x009D01F3
		// (set) Token: 0x06029F64 RID: 171876 RVA: 0x009D2003 File Offset: 0x009D0203
		public unsafe bool 次数为0时销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006602 RID: 26114
		// (get) Token: 0x06029F65 RID: 171877 RVA: 0x009D2014 File Offset: 0x009D0214
		// (set) Token: 0x06029F66 RID: 171878 RVA: 0x009D2024 File Offset: 0x009D0224
		public unsafe bool 是否可以触发拼刀
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006603 RID: 26115
		// (get) Token: 0x06029F67 RID: 171879 RVA: 0x009D2035 File Offset: 0x009D0235
		// (set) Token: 0x06029F68 RID: 171880 RVA: 0x009D2045 File Offset: 0x009D0245
		public unsafe bool 是否可以触发极限闪避
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006604 RID: 26116
		// (get) Token: 0x06029F69 RID: 171881 RVA: 0x009D2056 File Offset: 0x009D0256
		// (set) Token: 0x06029F6A RID: 171882 RVA: 0x009D2066 File Offset: 0x009D0266
		public unsafe bool 拼刀忽略距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006605 RID: 26117
		// (get) Token: 0x06029F6B RID: 171883 RVA: 0x009D2077 File Offset: 0x009D0277
		// (set) Token: 0x06029F6C RID: 171884 RVA: 0x009D2087 File Offset: 0x009D0287
		public unsafe bool 拼刀忽略角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006606 RID: 26118
		// (get) Token: 0x06029F6D RID: 171885 RVA: 0x009D2098 File Offset: 0x009D0298
		// (set) Token: 0x06029F6E RID: 171886 RVA: 0x009D20A8 File Offset: 0x009D02A8
		public unsafe bool 触发前摇拼刀
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006607 RID: 26119
		// (get) Token: 0x06029F6F RID: 171887 RVA: 0x009D20B9 File Offset: 0x009D02B9
		// (set) Token: 0x06029F70 RID: 171888 RVA: 0x009D20C9 File Offset: 0x009D02C9
		public unsafe bool 是否可以触发对策
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006608 RID: 26120
		// (get) Token: 0x06029F71 RID: 171889 RVA: 0x009D20DA File Offset: 0x009D02DA
		// (set) Token: 0x06029F72 RID: 171890 RVA: 0x009D20EE File Offset: 0x009D02EE
		public unsafe FName 子弹碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006609 RID: 26121
		// (get) Token: 0x06029F73 RID: 171891 RVA: 0x009D2103 File Offset: 0x009D0303
		// (set) Token: 0x06029F74 RID: 171892 RVA: 0x009D2113 File Offset: 0x009D0313
		public unsafe bool 子弹碰撞障碍销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700660A RID: 26122
		// (get) Token: 0x06029F75 RID: 171893 RVA: 0x009D2124 File Offset: 0x009D0324
		// (set) Token: 0x06029F76 RID: 171894 RVA: 0x009D2134 File Offset: 0x009D0334
		public unsafe bool 子弹碰撞单位销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700660B RID: 26123
		// (get) Token: 0x06029F77 RID: 171895 RVA: 0x009D2145 File Offset: 0x009D0345
		// (set) Token: 0x06029F78 RID: 171896 RVA: 0x009D2159 File Offset: 0x009D0359
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletType> 子弹类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700660C RID: 26124
		// (get) Token: 0x06029F79 RID: 171897 RVA: 0x009D216E File Offset: 0x009D036E
		// (set) Token: 0x06029F7A RID: 171898 RVA: 0x009D2182 File Offset: 0x009D0382
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletHitDirectionType> 子弹受击类型角度判断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700660D RID: 26125
		// (get) Token: 0x06029F7B RID: 171899 RVA: 0x009D2197 File Offset: 0x009D0397
		// (set) Token: 0x06029F7C RID: 171900 RVA: 0x009D21A7 File Offset: 0x009D03A7
		public unsafe int 弹反通道
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700660E RID: 26126
		// (get) Token: 0x06029F7D RID: 171901 RVA: 0x009D21B8 File Offset: 0x009D03B8
		// (set) Token: 0x06029F7E RID: 171902 RVA: 0x009D21C8 File Offset: 0x009D03C8
		public unsafe bool 开启水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700660F RID: 26127
		// (get) Token: 0x06029F7F RID: 171903 RVA: 0x009D21DC File Offset: 0x009D03DC
		// (set) Token: 0x06029F80 RID: 171904 RVA: 0x009D2215 File Offset: 0x009D0415
		[Nullable(1)]
		public FGameplayTagContainer 预设标签
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._预设标签) == null)
				{
					result = (this._预设标签 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_14, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006610 RID: 26128
		// (get) Token: 0x06029F81 RID: 171905 RVA: 0x009D2236 File Offset: 0x009D0436
		// (set) Token: 0x06029F82 RID: 171906 RVA: 0x009D224A File Offset: 0x009D044A
		[Nullable(1)]
		public unsafe string 只碰撞胶囊体
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BulletLogicType_C.__PropertyOffset_15)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BulletLogicType_C.__PropertyOffset_15)), value);
			}
		}

		// Token: 0x17006611 RID: 26129
		// (get) Token: 0x06029F83 RID: 171907 RVA: 0x009D225F File Offset: 0x009D045F
		// (set) Token: 0x06029F84 RID: 171908 RVA: 0x009D226F File Offset: 0x009D046F
		public unsafe bool 忽略水体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006612 RID: 26130
		// (get) Token: 0x06029F85 RID: 171909 RVA: 0x009D2280 File Offset: 0x009D0480
		// (set) Token: 0x06029F86 RID: 171910 RVA: 0x009D2290 File Offset: 0x009D0490
		public unsafe bool 冰冻时销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006613 RID: 26131
		// (get) Token: 0x06029F87 RID: 171911 RVA: 0x009D22A1 File Offset: 0x009D04A1
		// (set) Token: 0x06029F88 RID: 171912 RVA: 0x009D22B1 File Offset: 0x009D04B1
		public unsafe bool 开启空气墙交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x06029F89 RID: 171913 RVA: 0x009D22C2 File Offset: 0x009D04C2
		protected BulletLogicType_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158FE RID: 88318
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BulletLogicType.BulletLogicType_C";

		// Token: 0x040158FF RID: 88319
		private static IntPtr _ClassPtr;

		// Token: 0x04015900 RID: 88320
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015901 RID: 88321
		internal static int __PropertyOffset_0;

		// Token: 0x04015902 RID: 88322
		internal static int __PropertyOffset_1;

		// Token: 0x04015903 RID: 88323
		internal static int __PropertyOffset_2;

		// Token: 0x04015904 RID: 88324
		internal static int __PropertyOffset_3;

		// Token: 0x04015905 RID: 88325
		internal static int __PropertyOffset_4;

		// Token: 0x04015906 RID: 88326
		internal static int __PropertyOffset_5;

		// Token: 0x04015907 RID: 88327
		internal static int __PropertyOffset_6;

		// Token: 0x04015908 RID: 88328
		internal static int __PropertyOffset_7;

		// Token: 0x04015909 RID: 88329
		internal static int __PropertyOffset_8;

		// Token: 0x0401590A RID: 88330
		internal static int __PropertyOffset_9;

		// Token: 0x0401590B RID: 88331
		internal static int __PropertyOffset_10;

		// Token: 0x0401590C RID: 88332
		internal static int __PropertyOffset_11;

		// Token: 0x0401590D RID: 88333
		internal static int __PropertyOffset_12;

		// Token: 0x0401590E RID: 88334
		internal static int __PropertyOffset_13;

		// Token: 0x0401590F RID: 88335
		internal static int __PropertyOffset_14;

		// Token: 0x04015910 RID: 88336
		[Nullable(2)]
		private FGameplayTagContainer _预设标签;

		// Token: 0x04015911 RID: 88337
		internal static int __PropertyOffset_15;

		// Token: 0x04015912 RID: 88338
		internal static int __PropertyOffset_16;

		// Token: 0x04015913 RID: 88339
		internal static int __PropertyOffset_17;

		// Token: 0x04015914 RID: 88340
		internal static int __PropertyOffset_18;
	}
}
