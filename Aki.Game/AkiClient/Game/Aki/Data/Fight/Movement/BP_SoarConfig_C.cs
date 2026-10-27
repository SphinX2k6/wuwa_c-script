using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Movement
{
	// Token: 0x02003F76 RID: 16246
	[UnrealObjectPath("/Game/Aki/Data/Fight/Movement/BP_SoarConfig.BP_SoarConfig_C")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 241)]
	public class BP_SoarConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602976E RID: 169838 RVA: 0x009C4E53 File Offset: 0x009C3053
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SoarConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/Movement/BP_SoarConfig.BP_SoarConfig_C");
			}
			return BP_SoarConfig_C._ClassPtr;
		}

		// Token: 0x0602976F RID: 169839 RVA: 0x009C4E78 File Offset: 0x009C3078
		public BP_SoarConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SoarConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029770 RID: 169840 RVA: 0x009C4EA0 File Offset: 0x009C30A0
		[NullableContext(1)]
		public BP_SoarConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SoarConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006365 RID: 25445
		// (get) Token: 0x06029771 RID: 169841 RVA: 0x009C4ED3 File Offset: 0x009C30D3
		// (set) Token: 0x06029772 RID: 169842 RVA: 0x009C4EE3 File Offset: 0x009C30E3
		public unsafe float 阻挡面角度极限最小值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006366 RID: 25446
		// (get) Token: 0x06029773 RID: 169843 RVA: 0x009C4EF4 File Offset: 0x009C30F4
		// (set) Token: 0x06029774 RID: 169844 RVA: 0x009C4F04 File Offset: 0x009C3104
		public unsafe float 阻挡面角度极限最大值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006367 RID: 25447
		// (get) Token: 0x06029775 RID: 169845 RVA: 0x009C4F15 File Offset: 0x009C3115
		// (set) Token: 0x06029776 RID: 169846 RVA: 0x009C4F25 File Offset: 0x009C3125
		public unsafe float 空气阻力面系数最小值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006368 RID: 25448
		// (get) Token: 0x06029777 RID: 169847 RVA: 0x009C4F36 File Offset: 0x009C3136
		// (set) Token: 0x06029778 RID: 169848 RVA: 0x009C4F46 File Offset: 0x009C3146
		public unsafe float 空气阻力面系数最大值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006369 RID: 25449
		// (get) Token: 0x06029779 RID: 169849 RVA: 0x009C4F57 File Offset: 0x009C3157
		// (set) Token: 0x0602977A RID: 169850 RVA: 0x009C4F67 File Offset: 0x009C3167
		public unsafe float 阻挡面最小值对应速度值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700636A RID: 25450
		// (get) Token: 0x0602977B RID: 169851 RVA: 0x009C4F78 File Offset: 0x009C3178
		// (set) Token: 0x0602977C RID: 169852 RVA: 0x009C4F8C File Offset: 0x009C318C
		public unsafe FVector 满抬升输入时平衡速度向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700636B RID: 25451
		// (get) Token: 0x0602977D RID: 169853 RVA: 0x009C4FA1 File Offset: 0x009C31A1
		// (set) Token: 0x0602977E RID: 169854 RVA: 0x009C4FB1 File Offset: 0x009C31B1
		public unsafe float 满抬升输入判定阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700636C RID: 25452
		// (get) Token: 0x0602977F RID: 169855 RVA: 0x009C4FC2 File Offset: 0x009C31C2
		// (set) Token: 0x06029780 RID: 169856 RVA: 0x009C4FD2 File Offset: 0x009C31D2
		public unsafe float 平衡用最小加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700636D RID: 25453
		// (get) Token: 0x06029781 RID: 169857 RVA: 0x009C4FE3 File Offset: 0x009C31E3
		// (set) Token: 0x06029782 RID: 169858 RVA: 0x009C4FF3 File Offset: 0x009C31F3
		public unsafe float 平衡用最大加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700636E RID: 25454
		// (get) Token: 0x06029783 RID: 169859 RVA: 0x009C5004 File Offset: 0x009C3204
		// (set) Token: 0x06029784 RID: 169860 RVA: 0x009C5014 File Offset: 0x009C3214
		public unsafe float 平衡使用最大值对应速度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700636F RID: 25455
		// (get) Token: 0x06029785 RID: 169861 RVA: 0x009C5025 File Offset: 0x009C3225
		// (set) Token: 0x06029786 RID: 169862 RVA: 0x009C5035 File Offset: 0x009C3235
		public unsafe float 满抬升输入平衡开启速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006370 RID: 25456
		// (get) Token: 0x06029787 RID: 169863 RVA: 0x009C5046 File Offset: 0x009C3246
		// (set) Token: 0x06029788 RID: 169864 RVA: 0x009C5056 File Offset: 0x009C3256
		public unsafe float 非满抬升输入平衡速度值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006371 RID: 25457
		// (get) Token: 0x06029789 RID: 169865 RVA: 0x009C5067 File Offset: 0x009C3267
		// (set) Token: 0x0602978A RID: 169866 RVA: 0x009C5077 File Offset: 0x009C3277
		public unsafe float 非满抬升输入平衡开启速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006372 RID: 25458
		// (get) Token: 0x0602978B RID: 169867 RVA: 0x009C5088 File Offset: 0x009C3288
		// (set) Token: 0x0602978C RID: 169868 RVA: 0x009C5098 File Offset: 0x009C3298
		public unsafe float 阻挡面转速第一段线性
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006373 RID: 25459
		// (get) Token: 0x0602978D RID: 169869 RVA: 0x009C50A9 File Offset: 0x009C32A9
		// (set) Token: 0x0602978E RID: 169870 RVA: 0x009C50B9 File Offset: 0x009C32B9
		public unsafe float 阻挡面转速第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006374 RID: 25460
		// (get) Token: 0x0602978F RID: 169871 RVA: 0x009C50CA File Offset: 0x009C32CA
		// (set) Token: 0x06029790 RID: 169872 RVA: 0x009C50DA File Offset: 0x009C32DA
		public unsafe float 面向转速第一段线性
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006375 RID: 25461
		// (get) Token: 0x06029791 RID: 169873 RVA: 0x009C50EB File Offset: 0x009C32EB
		// (set) Token: 0x06029792 RID: 169874 RVA: 0x009C50FB File Offset: 0x009C32FB
		public unsafe float 面向转速第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006376 RID: 25462
		// (get) Token: 0x06029793 RID: 169875 RVA: 0x009C510C File Offset: 0x009C330C
		// (set) Token: 0x06029794 RID: 169876 RVA: 0x009C511C File Offset: 0x009C331C
		public unsafe float 阻挡面最大值对应速度值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006377 RID: 25463
		// (get) Token: 0x06029795 RID: 169877 RVA: 0x009C512D File Offset: 0x009C332D
		// (set) Token: 0x06029796 RID: 169878 RVA: 0x009C513D File Offset: 0x009C333D
		public unsafe float 阻挡面最小角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006378 RID: 25464
		// (get) Token: 0x06029797 RID: 169879 RVA: 0x009C514E File Offset: 0x009C334E
		// (set) Token: 0x06029798 RID: 169880 RVA: 0x009C515E File Offset: 0x009C335E
		public unsafe float 阻挡面最大角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006379 RID: 25465
		// (get) Token: 0x06029799 RID: 169881 RVA: 0x009C516F File Offset: 0x009C336F
		// (set) Token: 0x0602979A RID: 169882 RVA: 0x009C517F File Offset: 0x009C337F
		public unsafe float 无输入时阻挡面转速
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700637A RID: 25466
		// (get) Token: 0x0602979B RID: 169883 RVA: 0x009C5190 File Offset: 0x009C3390
		// (set) Token: 0x0602979C RID: 169884 RVA: 0x009C51A0 File Offset: 0x009C33A0
		public unsafe float 空气阻力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700637B RID: 25467
		// (get) Token: 0x0602979D RID: 169885 RVA: 0x009C51B1 File Offset: 0x009C33B1
		// (set) Token: 0x0602979E RID: 169886 RVA: 0x009C51C1 File Offset: 0x009C33C1
		public unsafe float 最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700637C RID: 25468
		// (get) Token: 0x0602979F RID: 169887 RVA: 0x009C51D2 File Offset: 0x009C33D2
		// (set) Token: 0x060297A0 RID: 169888 RVA: 0x009C51E2 File Offset: 0x009C33E2
		public unsafe float Boost阻挡面转速第一段线性
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700637D RID: 25469
		// (get) Token: 0x060297A1 RID: 169889 RVA: 0x009C51F3 File Offset: 0x009C33F3
		// (set) Token: 0x060297A2 RID: 169890 RVA: 0x009C5203 File Offset: 0x009C3403
		public unsafe float Boost阻挡面转速第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700637E RID: 25470
		// (get) Token: 0x060297A3 RID: 169891 RVA: 0x009C5214 File Offset: 0x009C3414
		// (set) Token: 0x060297A4 RID: 169892 RVA: 0x009C5224 File Offset: 0x009C3424
		public unsafe float Boost加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700637F RID: 25471
		// (get) Token: 0x060297A5 RID: 169893 RVA: 0x009C5235 File Offset: 0x009C3435
		// (set) Token: 0x060297A6 RID: 169894 RVA: 0x009C5245 File Offset: 0x009C3445
		public unsafe float 重力加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17006380 RID: 25472
		// (get) Token: 0x060297A7 RID: 169895 RVA: 0x009C5256 File Offset: 0x009C3456
		// (set) Token: 0x060297A8 RID: 169896 RVA: 0x009C5266 File Offset: 0x009C3466
		public unsafe float 撞墙结束时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17006381 RID: 25473
		// (get) Token: 0x060297A9 RID: 169897 RVA: 0x009C5277 File Offset: 0x009C3477
		// (set) Token: 0x060297AA RID: 169898 RVA: 0x009C5287 File Offset: 0x009C3487
		public unsafe float 风道最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17006382 RID: 25474
		// (get) Token: 0x060297AB RID: 169899 RVA: 0x009C5298 File Offset: 0x009C3498
		// (set) Token: 0x060297AC RID: 169900 RVA: 0x009C52A8 File Offset: 0x009C34A8
		public unsafe float 风道最大加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17006383 RID: 25475
		// (get) Token: 0x060297AD RID: 169901 RVA: 0x009C52B9 File Offset: 0x009C34B9
		// (set) Token: 0x060297AE RID: 169902 RVA: 0x009C52C9 File Offset: 0x009C34C9
		public unsafe float 风道输入对应偏转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17006384 RID: 25476
		// (get) Token: 0x060297AF RID: 169903 RVA: 0x009C52DA File Offset: 0x009C34DA
		// (set) Token: 0x060297B0 RID: 169904 RVA: 0x009C52EA File Offset: 0x009C34EA
		public unsafe float 风道中线拉回最小速对应距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17006385 RID: 25477
		// (get) Token: 0x060297B1 RID: 169905 RVA: 0x009C52FB File Offset: 0x009C34FB
		// (set) Token: 0x060297B2 RID: 169906 RVA: 0x009C530B File Offset: 0x009C350B
		public unsafe float 风道中线拉回最大速对应距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17006386 RID: 25478
		// (get) Token: 0x060297B3 RID: 169907 RVA: 0x009C531C File Offset: 0x009C351C
		// (set) Token: 0x060297B4 RID: 169908 RVA: 0x009C532C File Offset: 0x009C352C
		public unsafe float 风道中线拉回最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17006387 RID: 25479
		// (get) Token: 0x060297B5 RID: 169909 RVA: 0x009C533D File Offset: 0x009C353D
		// (set) Token: 0x060297B6 RID: 169910 RVA: 0x009C534D File Offset: 0x009C354D
		public unsafe float 风道中线拉回最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17006388 RID: 25480
		// (get) Token: 0x060297B7 RID: 169911 RVA: 0x009C535E File Offset: 0x009C355E
		// (set) Token: 0x060297B8 RID: 169912 RVA: 0x009C536E File Offset: 0x009C356E
		public unsafe float 风道无输入面向修正速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17006389 RID: 25481
		// (get) Token: 0x060297B9 RID: 169913 RVA: 0x009C537F File Offset: 0x009C357F
		// (set) Token: 0x060297BA RID: 169914 RVA: 0x009C538F File Offset: 0x009C358F
		public unsafe float 风道有输入面向修正速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700638A RID: 25482
		// (get) Token: 0x060297BB RID: 169915 RVA: 0x009C53A0 File Offset: 0x009C35A0
		// (set) Token: 0x060297BC RID: 169916 RVA: 0x009C53B0 File Offset: 0x009C35B0
		public unsafe float 风道转向第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x1700638B RID: 25483
		// (get) Token: 0x060297BD RID: 169917 RVA: 0x009C53C1 File Offset: 0x009C35C1
		// (set) Token: 0x060297BE RID: 169918 RVA: 0x009C53D1 File Offset: 0x009C35D1
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x060297BF RID: 169919 RVA: 0x009C53E2 File Offset: 0x009C35E2
		protected BP_SoarConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040153EE RID: 87022
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/Movement/BP_SoarConfig.BP_SoarConfig_C";

		// Token: 0x040153EF RID: 87023
		private static IntPtr _ClassPtr;

		// Token: 0x040153F0 RID: 87024
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040153F1 RID: 87025
		internal static int __PropertyOffset_0;

		// Token: 0x040153F2 RID: 87026
		internal static int __PropertyOffset_1;

		// Token: 0x040153F3 RID: 87027
		internal static int __PropertyOffset_2;

		// Token: 0x040153F4 RID: 87028
		internal static int __PropertyOffset_3;

		// Token: 0x040153F5 RID: 87029
		internal static int __PropertyOffset_4;

		// Token: 0x040153F6 RID: 87030
		internal static int __PropertyOffset_5;

		// Token: 0x040153F7 RID: 87031
		internal static int __PropertyOffset_6;

		// Token: 0x040153F8 RID: 87032
		internal static int __PropertyOffset_7;

		// Token: 0x040153F9 RID: 87033
		internal static int __PropertyOffset_8;

		// Token: 0x040153FA RID: 87034
		internal static int __PropertyOffset_9;

		// Token: 0x040153FB RID: 87035
		internal static int __PropertyOffset_10;

		// Token: 0x040153FC RID: 87036
		internal static int __PropertyOffset_11;

		// Token: 0x040153FD RID: 87037
		internal static int __PropertyOffset_12;

		// Token: 0x040153FE RID: 87038
		internal static int __PropertyOffset_13;

		// Token: 0x040153FF RID: 87039
		internal static int __PropertyOffset_14;

		// Token: 0x04015400 RID: 87040
		internal static int __PropertyOffset_15;

		// Token: 0x04015401 RID: 87041
		internal static int __PropertyOffset_16;

		// Token: 0x04015402 RID: 87042
		internal static int __PropertyOffset_17;

		// Token: 0x04015403 RID: 87043
		internal static int __PropertyOffset_18;

		// Token: 0x04015404 RID: 87044
		internal static int __PropertyOffset_19;

		// Token: 0x04015405 RID: 87045
		internal static int __PropertyOffset_20;

		// Token: 0x04015406 RID: 87046
		internal static int __PropertyOffset_21;

		// Token: 0x04015407 RID: 87047
		internal static int __PropertyOffset_22;

		// Token: 0x04015408 RID: 87048
		internal static int __PropertyOffset_23;

		// Token: 0x04015409 RID: 87049
		internal static int __PropertyOffset_24;

		// Token: 0x0401540A RID: 87050
		internal static int __PropertyOffset_25;

		// Token: 0x0401540B RID: 87051
		internal static int __PropertyOffset_26;

		// Token: 0x0401540C RID: 87052
		internal static int __PropertyOffset_27;

		// Token: 0x0401540D RID: 87053
		internal static int __PropertyOffset_28;

		// Token: 0x0401540E RID: 87054
		internal static int __PropertyOffset_29;

		// Token: 0x0401540F RID: 87055
		internal static int __PropertyOffset_30;

		// Token: 0x04015410 RID: 87056
		internal static int __PropertyOffset_31;

		// Token: 0x04015411 RID: 87057
		internal static int __PropertyOffset_32;

		// Token: 0x04015412 RID: 87058
		internal static int __PropertyOffset_33;

		// Token: 0x04015413 RID: 87059
		internal static int __PropertyOffset_34;

		// Token: 0x04015414 RID: 87060
		internal static int __PropertyOffset_35;

		// Token: 0x04015415 RID: 87061
		internal static int __PropertyOffset_36;

		// Token: 0x04015416 RID: 87062
		internal static int __PropertyOffset_37;

		// Token: 0x04015417 RID: 87063
		internal static int __PropertyOffset_38;
	}
}
