using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Ski
{
	// Token: 0x02003F07 RID: 16135
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Ski/BP_SkiConfig.BP_SkiConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_SkiConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E7D RID: 167549 RVA: 0x009B744A File Offset: 0x009B564A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SkiConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Ski/BP_SkiConfig.BP_SkiConfig_C");
			}
			return BP_SkiConfig_C._ClassPtr;
		}

		// Token: 0x06028E7E RID: 167550 RVA: 0x009B7470 File Offset: 0x009B5670
		public BP_SkiConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SkiConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E7F RID: 167551 RVA: 0x009B7498 File Offset: 0x009B5698
		public BP_SkiConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SkiConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006042 RID: 24642
		// (get) Token: 0x06028E80 RID: 167552 RVA: 0x009B74CB File Offset: 0x009B56CB
		// (set) Token: 0x06028E81 RID: 167553 RVA: 0x009B74DB File Offset: 0x009B56DB
		public unsafe float 初始速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006043 RID: 24643
		// (get) Token: 0x06028E82 RID: 167554 RVA: 0x009B74EC File Offset: 0x009B56EC
		// (set) Token: 0x06028E83 RID: 167555 RVA: 0x009B74FC File Offset: 0x009B56FC
		public unsafe float 转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006044 RID: 24644
		// (get) Token: 0x06028E84 RID: 167556 RVA: 0x009B750D File Offset: 0x009B570D
		// (set) Token: 0x06028E85 RID: 167557 RVA: 0x009B751D File Offset: 0x009B571D
		public unsafe float 基础加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006045 RID: 24645
		// (get) Token: 0x06028E86 RID: 167558 RVA: 0x009B752E File Offset: 0x009B572E
		// (set) Token: 0x06028E87 RID: 167559 RVA: 0x009B753E File Offset: 0x009B573E
		public unsafe float 基础减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006046 RID: 24646
		// (get) Token: 0x06028E88 RID: 167560 RVA: 0x009B754F File Offset: 0x009B574F
		// (set) Token: 0x06028E89 RID: 167561 RVA: 0x009B755F File Offset: 0x009B575F
		public unsafe float 基础目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006047 RID: 24647
		// (get) Token: 0x06028E8A RID: 167562 RVA: 0x009B7570 File Offset: 0x009B5770
		// (set) Token: 0x06028E8B RID: 167563 RVA: 0x009B7580 File Offset: 0x009B5780
		public unsafe float 斜坡额外加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006048 RID: 24648
		// (get) Token: 0x06028E8C RID: 167564 RVA: 0x009B7591 File Offset: 0x009B5791
		// (set) Token: 0x06028E8D RID: 167565 RVA: 0x009B75A1 File Offset: 0x009B57A1
		public unsafe float 斜坡额外目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006049 RID: 24649
		// (get) Token: 0x06028E8E RID: 167566 RVA: 0x009B75B2 File Offset: 0x009B57B2
		// (set) Token: 0x06028E8F RID: 167567 RVA: 0x009B75C2 File Offset: 0x009B57C2
		public unsafe float 忽视阶梯高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700604A RID: 24650
		// (get) Token: 0x06028E90 RID: 167568 RVA: 0x009B75D3 File Offset: 0x009B57D3
		// (set) Token: 0x06028E91 RID: 167569 RVA: 0x009B75E3 File Offset: 0x009B57E3
		public unsafe float 跳跃转向速度系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700604B RID: 24651
		// (get) Token: 0x06028E92 RID: 167570 RVA: 0x009B75F4 File Offset: 0x009B57F4
		// (set) Token: 0x06028E93 RID: 167571 RVA: 0x009B7604 File Offset: 0x009B5804
		public unsafe float 跳跃滞空缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700604C RID: 24652
		// (get) Token: 0x06028E94 RID: 167572 RVA: 0x009B7615 File Offset: 0x009B5815
		// (set) Token: 0x06028E95 RID: 167573 RVA: 0x009B7625 File Offset: 0x009B5825
		public unsafe float 跳跃高度缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700604D RID: 24653
		// (get) Token: 0x06028E96 RID: 167574 RVA: 0x009B7636 File Offset: 0x009B5836
		// (set) Token: 0x06028E97 RID: 167575 RVA: 0x009B7646 File Offset: 0x009B5846
		public unsafe float 跳跃下落最大平面速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700604E RID: 24654
		// (get) Token: 0x06028E98 RID: 167576 RVA: 0x009B7658 File Offset: 0x009B5858
		// (set) Token: 0x06028E99 RID: 167577 RVA: 0x009B7691 File Offset: 0x009B5891
		public FGameplayTagContainer 期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._期间Tag) == null)
				{
					result = (this._期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06028E9A RID: 167578 RVA: 0x009B76B2 File Offset: 0x009B58B2
		protected BP_SkiConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014EBD RID: 85693
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Ski/BP_SkiConfig.BP_SkiConfig_C";

		// Token: 0x04014EBE RID: 85694
		private static IntPtr _ClassPtr;

		// Token: 0x04014EBF RID: 85695
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014EC0 RID: 85696
		internal static int __PropertyOffset_0;

		// Token: 0x04014EC1 RID: 85697
		internal static int __PropertyOffset_1;

		// Token: 0x04014EC2 RID: 85698
		internal static int __PropertyOffset_2;

		// Token: 0x04014EC3 RID: 85699
		internal static int __PropertyOffset_3;

		// Token: 0x04014EC4 RID: 85700
		internal static int __PropertyOffset_4;

		// Token: 0x04014EC5 RID: 85701
		internal static int __PropertyOffset_5;

		// Token: 0x04014EC6 RID: 85702
		internal static int __PropertyOffset_6;

		// Token: 0x04014EC7 RID: 85703
		internal static int __PropertyOffset_7;

		// Token: 0x04014EC8 RID: 85704
		internal static int __PropertyOffset_8;

		// Token: 0x04014EC9 RID: 85705
		internal static int __PropertyOffset_9;

		// Token: 0x04014ECA RID: 85706
		internal static int __PropertyOffset_10;

		// Token: 0x04014ECB RID: 85707
		internal static int __PropertyOffset_11;

		// Token: 0x04014ECC RID: 85708
		internal static int __PropertyOffset_12;

		// Token: 0x04014ECD RID: 85709
		[Nullable(2)]
		private FGameplayTagContainer _期间Tag;
	}
}
