using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Movement
{
	// Token: 0x02003213 RID: 12819
	[UnrealObjectPath("/Game/Aki/Data/Fight/Movement/BP_SoarConfig.BP_SoarConfig_C")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 241)]
	public class BP_SoarConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FF56 RID: 130902 RVA: 0x00939CAE File Offset: 0x00937EAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SoarConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/Movement/BP_SoarConfig.BP_SoarConfig_C");
			}
			return BP_SoarConfig_C._ClassPtr;
		}

		// Token: 0x0601FF57 RID: 130903 RVA: 0x00939CD4 File Offset: 0x00937ED4
		public BP_SoarConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SoarConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FF58 RID: 130904 RVA: 0x00939CFC File Offset: 0x00937EFC
		[NullableContext(1)]
		public BP_SoarConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SoarConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0601FF59 RID: 130905 RVA: 0x00939D2F File Offset: 0x00937F2F
		// (set) Token: 0x0601FF5A RID: 130906 RVA: 0x00939D3F File Offset: 0x00937F3F
		public unsafe float 阻挡面角度极限最小值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面角度极限最小值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面角度极限最小值) = value;
			}
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0601FF5B RID: 130907 RVA: 0x00939D50 File Offset: 0x00937F50
		// (set) Token: 0x0601FF5C RID: 130908 RVA: 0x00939D60 File Offset: 0x00937F60
		public unsafe float 阻挡面角度极限最大值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面角度极限最大值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面角度极限最大值) = value;
			}
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0601FF5D RID: 130909 RVA: 0x00939D71 File Offset: 0x00937F71
		// (set) Token: 0x0601FF5E RID: 130910 RVA: 0x00939D81 File Offset: 0x00937F81
		public unsafe float 空气阻力面系数最小值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_空气阻力面系数最小值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_空气阻力面系数最小值) = value;
			}
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0601FF5F RID: 130911 RVA: 0x00939D92 File Offset: 0x00937F92
		// (set) Token: 0x0601FF60 RID: 130912 RVA: 0x00939DA2 File Offset: 0x00937FA2
		public unsafe float 空气阻力面系数最大值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_空气阻力面系数最大值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_空气阻力面系数最大值) = value;
			}
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0601FF61 RID: 130913 RVA: 0x00939DB3 File Offset: 0x00937FB3
		// (set) Token: 0x0601FF62 RID: 130914 RVA: 0x00939DC3 File Offset: 0x00937FC3
		public unsafe float 阻挡面最小值对应速度值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最小值对应速度值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最小值对应速度值) = value;
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0601FF63 RID: 130915 RVA: 0x00939DD4 File Offset: 0x00937FD4
		// (set) Token: 0x0601FF64 RID: 130916 RVA: 0x00939DE8 File Offset: 0x00937FE8
		public unsafe FVector 满抬升输入时平衡速度向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_满抬升输入时平衡速度向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_满抬升输入时平衡速度向量) = value;
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0601FF65 RID: 130917 RVA: 0x00939DFD File Offset: 0x00937FFD
		// (set) Token: 0x0601FF66 RID: 130918 RVA: 0x00939E0D File Offset: 0x0093800D
		public unsafe float 满抬升输入判定阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_满抬升输入判定阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_满抬升输入判定阈值) = value;
			}
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0601FF67 RID: 130919 RVA: 0x00939E1E File Offset: 0x0093801E
		// (set) Token: 0x0601FF68 RID: 130920 RVA: 0x00939E2E File Offset: 0x0093802E
		public unsafe float 平衡用最小加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_平衡用最小加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_平衡用最小加速度) = value;
			}
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x0601FF69 RID: 130921 RVA: 0x00939E3F File Offset: 0x0093803F
		// (set) Token: 0x0601FF6A RID: 130922 RVA: 0x00939E4F File Offset: 0x0093804F
		public unsafe float 平衡用最大加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_平衡用最大加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_平衡用最大加速度) = value;
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0601FF6B RID: 130923 RVA: 0x00939E60 File Offset: 0x00938060
		// (set) Token: 0x0601FF6C RID: 130924 RVA: 0x00939E70 File Offset: 0x00938070
		public unsafe float 平衡使用最大值对应速度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_平衡使用最大值对应速度差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_平衡使用最大值对应速度差) = value;
			}
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0601FF6D RID: 130925 RVA: 0x00939E81 File Offset: 0x00938081
		// (set) Token: 0x0601FF6E RID: 130926 RVA: 0x00939E91 File Offset: 0x00938091
		public unsafe float 满抬升输入平衡开启速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_满抬升输入平衡开启速度阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_满抬升输入平衡开启速度阈值) = value;
			}
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0601FF6F RID: 130927 RVA: 0x00939EA2 File Offset: 0x009380A2
		// (set) Token: 0x0601FF70 RID: 130928 RVA: 0x00939EB2 File Offset: 0x009380B2
		public unsafe float 非满抬升输入平衡速度值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_非满抬升输入平衡速度值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_非满抬升输入平衡速度值) = value;
			}
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0601FF71 RID: 130929 RVA: 0x00939EC3 File Offset: 0x009380C3
		// (set) Token: 0x0601FF72 RID: 130930 RVA: 0x00939ED3 File Offset: 0x009380D3
		public unsafe float 非满抬升输入平衡开启速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_非满抬升输入平衡开启速度阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_非满抬升输入平衡开启速度阈值) = value;
			}
		}

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x0601FF73 RID: 130931 RVA: 0x00939EE4 File Offset: 0x009380E4
		// (set) Token: 0x0601FF74 RID: 130932 RVA: 0x00939EF4 File Offset: 0x009380F4
		public unsafe float 阻挡面转速第一段线性
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面转速第一段线性);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面转速第一段线性) = value;
			}
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x0601FF75 RID: 130933 RVA: 0x00939F05 File Offset: 0x00938105
		// (set) Token: 0x0601FF76 RID: 130934 RVA: 0x00939F15 File Offset: 0x00938115
		public unsafe float 阻挡面转速第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面转速第二段比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面转速第二段比例) = value;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x0601FF77 RID: 130935 RVA: 0x00939F26 File Offset: 0x00938126
		// (set) Token: 0x0601FF78 RID: 130936 RVA: 0x00939F36 File Offset: 0x00938136
		public unsafe float 面向转速第一段线性
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_面向转速第一段线性);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_面向转速第一段线性) = value;
			}
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0601FF79 RID: 130937 RVA: 0x00939F47 File Offset: 0x00938147
		// (set) Token: 0x0601FF7A RID: 130938 RVA: 0x00939F57 File Offset: 0x00938157
		public unsafe float 面向转速第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_面向转速第二段比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_面向转速第二段比例) = value;
			}
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0601FF7B RID: 130939 RVA: 0x00939F68 File Offset: 0x00938168
		// (set) Token: 0x0601FF7C RID: 130940 RVA: 0x00939F78 File Offset: 0x00938178
		public unsafe float 阻挡面最大值对应速度值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最大值对应速度值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最大值对应速度值) = value;
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0601FF7D RID: 130941 RVA: 0x00939F89 File Offset: 0x00938189
		// (set) Token: 0x0601FF7E RID: 130942 RVA: 0x00939F99 File Offset: 0x00938199
		public unsafe float 阻挡面最小角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最小角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最小角度) = value;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0601FF7F RID: 130943 RVA: 0x00939FAA File Offset: 0x009381AA
		// (set) Token: 0x0601FF80 RID: 130944 RVA: 0x00939FBA File Offset: 0x009381BA
		public unsafe float 阻挡面最大角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最大角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_阻挡面最大角度) = value;
			}
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0601FF81 RID: 130945 RVA: 0x00939FCB File Offset: 0x009381CB
		// (set) Token: 0x0601FF82 RID: 130946 RVA: 0x00939FDB File Offset: 0x009381DB
		public unsafe float 无输入时阻挡面转速
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_无输入时阻挡面转速);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_无输入时阻挡面转速) = value;
			}
		}

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0601FF83 RID: 130947 RVA: 0x00939FEC File Offset: 0x009381EC
		// (set) Token: 0x0601FF84 RID: 130948 RVA: 0x00939FFC File Offset: 0x009381FC
		public unsafe float 空气阻力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_空气阻力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_空气阻力) = value;
			}
		}

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0601FF85 RID: 130949 RVA: 0x0093A00D File Offset: 0x0093820D
		// (set) Token: 0x0601FF86 RID: 130950 RVA: 0x0093A01D File Offset: 0x0093821D
		public unsafe float 最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_最大速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_最大速度) = value;
			}
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0601FF87 RID: 130951 RVA: 0x0093A02E File Offset: 0x0093822E
		// (set) Token: 0x0601FF88 RID: 130952 RVA: 0x0093A03E File Offset: 0x0093823E
		public unsafe float Boost阻挡面转速第一段线性
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_Boost阻挡面转速第一段线性);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_Boost阻挡面转速第一段线性) = value;
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0601FF89 RID: 130953 RVA: 0x0093A04F File Offset: 0x0093824F
		// (set) Token: 0x0601FF8A RID: 130954 RVA: 0x0093A05F File Offset: 0x0093825F
		public unsafe float Boost阻挡面转速第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_Boost阻挡面转速第二段比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_Boost阻挡面转速第二段比例) = value;
			}
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0601FF8B RID: 130955 RVA: 0x0093A070 File Offset: 0x00938270
		// (set) Token: 0x0601FF8C RID: 130956 RVA: 0x0093A080 File Offset: 0x00938280
		public unsafe float Boost加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_Boost加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_Boost加速度) = value;
			}
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0601FF8D RID: 130957 RVA: 0x0093A091 File Offset: 0x00938291
		// (set) Token: 0x0601FF8E RID: 130958 RVA: 0x0093A0A1 File Offset: 0x009382A1
		public unsafe float 重力加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_重力加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_重力加速度) = value;
			}
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0601FF8F RID: 130959 RVA: 0x0093A0B2 File Offset: 0x009382B2
		// (set) Token: 0x0601FF90 RID: 130960 RVA: 0x0093A0C2 File Offset: 0x009382C2
		public unsafe float 撞墙结束时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_撞墙结束时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_撞墙结束时间) = value;
			}
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0601FF91 RID: 130961 RVA: 0x0093A0D3 File Offset: 0x009382D3
		// (set) Token: 0x0601FF92 RID: 130962 RVA: 0x0093A0E3 File Offset: 0x009382E3
		public unsafe float 风道最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道最小速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道最小速度) = value;
			}
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0601FF93 RID: 130963 RVA: 0x0093A0F4 File Offset: 0x009382F4
		// (set) Token: 0x0601FF94 RID: 130964 RVA: 0x0093A104 File Offset: 0x00938304
		public unsafe float 风道最大加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道最大加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道最大加速度) = value;
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0601FF95 RID: 130965 RVA: 0x0093A115 File Offset: 0x00938315
		// (set) Token: 0x0601FF96 RID: 130966 RVA: 0x0093A125 File Offset: 0x00938325
		public unsafe float 风道输入对应偏转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道输入对应偏转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道输入对应偏转) = value;
			}
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0601FF97 RID: 130967 RVA: 0x0093A136 File Offset: 0x00938336
		// (set) Token: 0x0601FF98 RID: 130968 RVA: 0x0093A146 File Offset: 0x00938346
		public unsafe float 风道中线拉回最小速对应距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最小速对应距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最小速对应距离) = value;
			}
		}

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0601FF99 RID: 130969 RVA: 0x0093A157 File Offset: 0x00938357
		// (set) Token: 0x0601FF9A RID: 130970 RVA: 0x0093A167 File Offset: 0x00938367
		public unsafe float 风道中线拉回最大速对应距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最大速对应距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最大速对应距离) = value;
			}
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0601FF9B RID: 130971 RVA: 0x0093A178 File Offset: 0x00938378
		// (set) Token: 0x0601FF9C RID: 130972 RVA: 0x0093A188 File Offset: 0x00938388
		public unsafe float 风道中线拉回最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最小速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最小速度) = value;
			}
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x0601FF9D RID: 130973 RVA: 0x0093A199 File Offset: 0x00938399
		// (set) Token: 0x0601FF9E RID: 130974 RVA: 0x0093A1A9 File Offset: 0x009383A9
		public unsafe float 风道中线拉回最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最大速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道中线拉回最大速度) = value;
			}
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x0601FF9F RID: 130975 RVA: 0x0093A1BA File Offset: 0x009383BA
		// (set) Token: 0x0601FFA0 RID: 130976 RVA: 0x0093A1CA File Offset: 0x009383CA
		public unsafe float 风道无输入面向修正速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道无输入面向修正速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道无输入面向修正速度) = value;
			}
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0601FFA1 RID: 130977 RVA: 0x0093A1DB File Offset: 0x009383DB
		// (set) Token: 0x0601FFA2 RID: 130978 RVA: 0x0093A1EB File Offset: 0x009383EB
		public unsafe float 风道有输入面向修正速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道有输入面向修正速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道有输入面向修正速度) = value;
			}
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0601FFA3 RID: 130979 RVA: 0x0093A1FC File Offset: 0x009383FC
		// (set) Token: 0x0601FFA4 RID: 130980 RVA: 0x0093A20C File Offset: 0x0093840C
		public unsafe float 风道转向第二段比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道转向第二段比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_风道转向第二段比例) = value;
			}
		}

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0601FFA5 RID: 130981 RVA: 0x0093A21D File Offset: 0x0093841D
		// (set) Token: 0x0601FFA6 RID: 130982 RVA: 0x0093A22D File Offset: 0x0093842D
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_DebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SoarConfig_C.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FFA7 RID: 130983 RVA: 0x0093A23E File Offset: 0x0093843E
		protected BP_SoarConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011291 RID: 70289
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/Movement/BP_SoarConfig.BP_SoarConfig_C";

		// Token: 0x04011292 RID: 70290
		private static IntPtr _ClassPtr;

		// Token: 0x04011293 RID: 70291
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011294 RID: 70292
		internal static int __PropertyOffset_阻挡面角度极限最小值;

		// Token: 0x04011295 RID: 70293
		internal static int __PropertyOffset_阻挡面角度极限最大值;

		// Token: 0x04011296 RID: 70294
		internal static int __PropertyOffset_空气阻力面系数最小值;

		// Token: 0x04011297 RID: 70295
		internal static int __PropertyOffset_空气阻力面系数最大值;

		// Token: 0x04011298 RID: 70296
		internal static int __PropertyOffset_阻挡面最小值对应速度值;

		// Token: 0x04011299 RID: 70297
		internal static int __PropertyOffset_满抬升输入时平衡速度向量;

		// Token: 0x0401129A RID: 70298
		internal static int __PropertyOffset_满抬升输入判定阈值;

		// Token: 0x0401129B RID: 70299
		internal static int __PropertyOffset_平衡用最小加速度;

		// Token: 0x0401129C RID: 70300
		internal static int __PropertyOffset_平衡用最大加速度;

		// Token: 0x0401129D RID: 70301
		internal static int __PropertyOffset_平衡使用最大值对应速度差;

		// Token: 0x0401129E RID: 70302
		internal static int __PropertyOffset_满抬升输入平衡开启速度阈值;

		// Token: 0x0401129F RID: 70303
		internal static int __PropertyOffset_非满抬升输入平衡速度值;

		// Token: 0x040112A0 RID: 70304
		internal static int __PropertyOffset_非满抬升输入平衡开启速度阈值;

		// Token: 0x040112A1 RID: 70305
		internal static int __PropertyOffset_阻挡面转速第一段线性;

		// Token: 0x040112A2 RID: 70306
		internal static int __PropertyOffset_阻挡面转速第二段比例;

		// Token: 0x040112A3 RID: 70307
		internal static int __PropertyOffset_面向转速第一段线性;

		// Token: 0x040112A4 RID: 70308
		internal static int __PropertyOffset_面向转速第二段比例;

		// Token: 0x040112A5 RID: 70309
		internal static int __PropertyOffset_阻挡面最大值对应速度值;

		// Token: 0x040112A6 RID: 70310
		internal static int __PropertyOffset_阻挡面最小角度;

		// Token: 0x040112A7 RID: 70311
		internal static int __PropertyOffset_阻挡面最大角度;

		// Token: 0x040112A8 RID: 70312
		internal static int __PropertyOffset_无输入时阻挡面转速;

		// Token: 0x040112A9 RID: 70313
		internal static int __PropertyOffset_空气阻力;

		// Token: 0x040112AA RID: 70314
		internal static int __PropertyOffset_最大速度;

		// Token: 0x040112AB RID: 70315
		internal static int __PropertyOffset_Boost阻挡面转速第一段线性;

		// Token: 0x040112AC RID: 70316
		internal static int __PropertyOffset_Boost阻挡面转速第二段比例;

		// Token: 0x040112AD RID: 70317
		internal static int __PropertyOffset_Boost加速度;

		// Token: 0x040112AE RID: 70318
		internal static int __PropertyOffset_重力加速度;

		// Token: 0x040112AF RID: 70319
		internal static int __PropertyOffset_撞墙结束时间;

		// Token: 0x040112B0 RID: 70320
		internal static int __PropertyOffset_风道最小速度;

		// Token: 0x040112B1 RID: 70321
		internal static int __PropertyOffset_风道最大加速度;

		// Token: 0x040112B2 RID: 70322
		internal static int __PropertyOffset_风道输入对应偏转;

		// Token: 0x040112B3 RID: 70323
		internal static int __PropertyOffset_风道中线拉回最小速对应距离;

		// Token: 0x040112B4 RID: 70324
		internal static int __PropertyOffset_风道中线拉回最大速对应距离;

		// Token: 0x040112B5 RID: 70325
		internal static int __PropertyOffset_风道中线拉回最小速度;

		// Token: 0x040112B6 RID: 70326
		internal static int __PropertyOffset_风道中线拉回最大速度;

		// Token: 0x040112B7 RID: 70327
		internal static int __PropertyOffset_风道无输入面向修正速度;

		// Token: 0x040112B8 RID: 70328
		internal static int __PropertyOffset_风道有输入面向修正速度;

		// Token: 0x040112B9 RID: 70329
		internal static int __PropertyOffset_风道转向第二段比例;

		// Token: 0x040112BA RID: 70330
		internal static int __PropertyOffset_DebugDraw;
	}
}
