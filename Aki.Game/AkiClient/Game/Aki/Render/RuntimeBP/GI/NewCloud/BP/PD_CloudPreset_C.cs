using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D63 RID: 15715
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPreset.PD_CloudPreset_C")]
	[UnrealStructLayout(5792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5792)]
	public class PD_CloudPreset_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060267D9 RID: 157657 RVA: 0x00976775 File Offset: 0x00974975
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CloudPreset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPreset.PD_CloudPreset_C");
			}
			return PD_CloudPreset_C._ClassPtr;
		}

		// Token: 0x060267DA RID: 157658 RVA: 0x0097679C File Offset: 0x0097499C
		public PD_CloudPreset_C() : this(BuiltinUtils.AllocNativeUObject(PD_CloudPreset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060267DB RID: 157659 RVA: 0x009767C4 File Offset: 0x009749C4
		public PD_CloudPreset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CloudPreset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005275 RID: 21109
		// (get) Token: 0x060267DC RID: 157660 RVA: 0x009767F7 File Offset: 0x009749F7
		// (set) Token: 0x060267DD RID: 157661 RVA: 0x0097680C File Offset: 0x00974A0C
		public TSoftObjectPtr<PD_CloudPrefab_C> 天城
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_0, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005276 RID: 21110
		// (get) Token: 0x060267DE RID: 157662 RVA: 0x00976831 File Offset: 0x00974A31
		// (set) Token: 0x060267DF RID: 157663 RVA: 0x00976846 File Offset: 0x00974A46
		public TSoftObjectPtr<PD_CloudPrefab_C> 遗落原乡
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_1, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005277 RID: 21111
		// (get) Token: 0x060267E0 RID: 157664 RVA: 0x0097686B File Offset: 0x00974A6B
		// (set) Token: 0x060267E1 RID: 157665 RVA: 0x00976880 File Offset: 0x00974A80
		public TSoftObjectPtr<PD_CloudPrefab_C> 无光之森
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_2, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005278 RID: 21112
		// (get) Token: 0x060267E2 RID: 157666 RVA: 0x009768A5 File Offset: 0x00974AA5
		// (set) Token: 0x060267E3 RID: 157667 RVA: 0x009768BA File Offset: 0x00974ABA
		public TSoftObjectPtr<PD_CloudPrefab_C> 中曲台地
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_3, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005279 RID: 21113
		// (get) Token: 0x060267E4 RID: 157668 RVA: 0x009768DF File Offset: 0x00974ADF
		// (set) Token: 0x060267E5 RID: 157669 RVA: 0x009768F4 File Offset: 0x00974AF4
		public TSoftObjectPtr<PD_CloudPrefab_C> 登录界面
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_4, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700527A RID: 21114
		// (get) Token: 0x060267E6 RID: 157670 RVA: 0x00976919 File Offset: 0x00974B19
		// (set) Token: 0x060267E7 RID: 157671 RVA: 0x0097692E File Offset: 0x00974B2E
		public TSoftObjectPtr<PD_CloudPrefab_C> 无音区沉寂态
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_5, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700527B RID: 21115
		// (get) Token: 0x060267E8 RID: 157672 RVA: 0x00976953 File Offset: 0x00974B53
		// (set) Token: 0x060267E9 RID: 157673 RVA: 0x00976968 File Offset: 0x00974B68
		public TSoftObjectPtr<PD_CloudPrefab_C> 无音区01
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_6, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700527C RID: 21116
		// (get) Token: 0x060267EA RID: 157674 RVA: 0x0097698D File Offset: 0x00974B8D
		// (set) Token: 0x060267EB RID: 157675 RVA: 0x009769A2 File Offset: 0x00974BA2
		public TSoftObjectPtr<PD_CloudPrefab_C> 怨鸟泽
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_7, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700527D RID: 21117
		// (get) Token: 0x060267EC RID: 157676 RVA: 0x009769C7 File Offset: 0x00974BC7
		// (set) Token: 0x060267ED RID: 157677 RVA: 0x009769DC File Offset: 0x00974BDC
		public TSoftObjectPtr<PD_CloudPrefab_C> 原画测试专用云
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_8, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700527E RID: 21118
		// (get) Token: 0x060267EE RID: 157678 RVA: 0x00976A01 File Offset: 0x00974C01
		// (set) Token: 0x060267EF RID: 157679 RVA: 0x00976A16 File Offset: 0x00974C16
		public TSoftObjectPtr<PD_CloudPrefab_C> 无音区02
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_9, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_9, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700527F RID: 21119
		// (get) Token: 0x060267F0 RID: 157680 RVA: 0x00976A3B File Offset: 0x00974C3B
		// (set) Token: 0x060267F1 RID: 157681 RVA: 0x00976A50 File Offset: 0x00974C50
		public TSoftObjectPtr<PD_CloudPrefab_C> 无音区03
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_10, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005280 RID: 21120
		// (get) Token: 0x060267F2 RID: 157682 RVA: 0x00976A75 File Offset: 0x00974C75
		// (set) Token: 0x060267F3 RID: 157683 RVA: 0x00976A8A File Offset: 0x00974C8A
		public TSoftObjectPtr<PD_CloudPrefab_C> 无音区04
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_11, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005281 RID: 21121
		// (get) Token: 0x060267F4 RID: 157684 RVA: 0x00976AAF File Offset: 0x00974CAF
		// (set) Token: 0x060267F5 RID: 157685 RVA: 0x00976AC4 File Offset: 0x00974CC4
		public TSoftObjectPtr<PD_CloudPrefab_C> 无音区05
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_12, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005282 RID: 21122
		// (get) Token: 0x060267F6 RID: 157686 RVA: 0x00976AE9 File Offset: 0x00974CE9
		// (set) Token: 0x060267F7 RID: 157687 RVA: 0x00976AFE File Offset: 0x00974CFE
		public TSoftObjectPtr<PD_CloudPrefab_C> 漩涡云
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_13, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_13, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005283 RID: 21123
		// (get) Token: 0x060267F8 RID: 157688 RVA: 0x00976B23 File Offset: 0x00974D23
		// (set) Token: 0x060267F9 RID: 157689 RVA: 0x00976B38 File Offset: 0x00974D38
		public TSoftObjectPtr<PD_CloudPrefab_C> 鸣潮天气
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_14, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005284 RID: 21124
		// (get) Token: 0x060267FA RID: 157690 RVA: 0x00976B5D File Offset: 0x00974D5D
		// (set) Token: 0x060267FB RID: 157691 RVA: 0x00976B72 File Offset: 0x00974D72
		public TSoftObjectPtr<PD_CloudPrefab_C> 阴天异象
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_15, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_15, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005285 RID: 21125
		// (get) Token: 0x060267FC RID: 157692 RVA: 0x00976B97 File Offset: 0x00974D97
		// (set) Token: 0x060267FD RID: 157693 RVA: 0x00976BAC File Offset: 0x00974DAC
		public TSoftObjectPtr<PD_CloudPrefab_C> 黄昏异象
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_16, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_16, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005286 RID: 21126
		// (get) Token: 0x060267FE RID: 157694 RVA: 0x00976BD1 File Offset: 0x00974DD1
		// (set) Token: 0x060267FF RID: 157695 RVA: 0x00976BE6 File Offset: 0x00974DE6
		public TSoftObjectPtr<PD_CloudPrefab_C> 夜晚异象
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_17, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_17, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005287 RID: 21127
		// (get) Token: 0x06026800 RID: 157696 RVA: 0x00976C0B File Offset: 0x00974E0B
		// (set) Token: 0x06026801 RID: 157697 RVA: 0x00976C20 File Offset: 0x00974E20
		public TSoftObjectPtr<PD_CloudPrefab_C> 乘宵山异象
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_18, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005288 RID: 21128
		// (get) Token: 0x06026802 RID: 157698 RVA: 0x00976C45 File Offset: 0x00974E45
		// (set) Token: 0x06026803 RID: 157699 RVA: 0x00976C5A File Offset: 0x00974E5A
		public TSoftObjectPtr<PD_CloudPrefab_C> 乘宵山
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_19, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_19, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005289 RID: 21129
		// (get) Token: 0x06026804 RID: 157700 RVA: 0x00976C7F File Offset: 0x00974E7F
		// (set) Token: 0x06026805 RID: 157701 RVA: 0x00976C94 File Offset: 0x00974E94
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑海岸上层
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_20, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_20, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700528A RID: 21130
		// (get) Token: 0x06026806 RID: 157702 RVA: 0x00976CB9 File Offset: 0x00974EB9
		// (set) Token: 0x06026807 RID: 157703 RVA: 0x00976CCE File Offset: 0x00974ECE
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑海岸下层
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_21, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_21, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700528B RID: 21131
		// (get) Token: 0x06026808 RID: 157704 RVA: 0x00976CF3 File Offset: 0x00974EF3
		// (set) Token: 0x06026809 RID: 157705 RVA: 0x00976D08 File Offset: 0x00974F08
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑海岸夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_22, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_22, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700528C RID: 21132
		// (get) Token: 0x0602680A RID: 157706 RVA: 0x00976D2D File Offset: 0x00974F2D
		// (set) Token: 0x0602680B RID: 157707 RVA: 0x00976D42 File Offset: 0x00974F42
		public TSoftObjectPtr<PD_CloudPrefab_C> 肉鸽月亮01
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_23, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_23, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700528D RID: 21133
		// (get) Token: 0x0602680C RID: 157708 RVA: 0x00976D67 File Offset: 0x00974F67
		// (set) Token: 0x0602680D RID: 157709 RVA: 0x00976D7C File Offset: 0x00974F7C
		public TSoftObjectPtr<PD_CloudPrefab_C> 肉鸽月亮02
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_24, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_24, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700528E RID: 21134
		// (get) Token: 0x0602680E RID: 157710 RVA: 0x00976DA1 File Offset: 0x00974FA1
		// (set) Token: 0x0602680F RID: 157711 RVA: 0x00976DB6 File Offset: 0x00974FB6
		public TSoftObjectPtr<PD_CloudPrefab_C> 肉鸽月亮03
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_25, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_25, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700528F RID: 21135
		// (get) Token: 0x06026810 RID: 157712 RVA: 0x00976DDB File Offset: 0x00974FDB
		// (set) Token: 0x06026811 RID: 157713 RVA: 0x00976DF0 File Offset: 0x00974FF0
		public TSoftObjectPtr<PD_CloudPrefab_C> 肉鸽月亮04
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_26, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_26, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005290 RID: 21136
		// (get) Token: 0x06026812 RID: 157714 RVA: 0x00976E15 File Offset: 0x00975015
		// (set) Token: 0x06026813 RID: 157715 RVA: 0x00976E2A File Offset: 0x0097502A
		public TSoftObjectPtr<PD_CloudPrefab_C> 黎娜汐塔
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_27, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_27, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005291 RID: 21137
		// (get) Token: 0x06026814 RID: 157716 RVA: 0x00976E4F File Offset: 0x0097504F
		// (set) Token: 0x06026815 RID: 157717 RVA: 0x00976E64 File Offset: 0x00975064
		public TSoftObjectPtr<PD_CloudPrefab_C> 帕尔米罗墓地
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_28, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_28, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005292 RID: 21138
		// (get) Token: 0x06026816 RID: 157718 RVA: 0x00976E89 File Offset: 0x00975089
		// (set) Token: 0x06026817 RID: 157719 RVA: 0x00976E9E File Offset: 0x0097509E
		public TSoftObjectPtr<PD_CloudPrefab_C> 槲生半岛
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_29, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_29, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005293 RID: 21139
		// (get) Token: 0x06026818 RID: 157720 RVA: 0x00976EC3 File Offset: 0x009750C3
		// (set) Token: 0x06026819 RID: 157721 RVA: 0x00976ED8 File Offset: 0x009750D8
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄萨莱海脊永夜解密前
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_30, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_30, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005294 RID: 21140
		// (get) Token: 0x0602681A RID: 157722 RVA: 0x00976EFD File Offset: 0x009750FD
		// (set) Token: 0x0602681B RID: 157723 RVA: 0x00976F12 File Offset: 0x00975112
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄萨莱海脊永夜解密后
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_31, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_31, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005295 RID: 21141
		// (get) Token: 0x0602681C RID: 157724 RVA: 0x00976F37 File Offset: 0x00975137
		// (set) Token: 0x0602681D RID: 157725 RVA: 0x00976F4C File Offset: 0x0097514C
		public TSoftObjectPtr<PD_CloudPrefab_C> 金库上层
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_32, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_32, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005296 RID: 21142
		// (get) Token: 0x0602681E RID: 157726 RVA: 0x00976F71 File Offset: 0x00975171
		// (set) Token: 0x0602681F RID: 157727 RVA: 0x00976F86 File Offset: 0x00975186
		public TSoftObjectPtr<PD_CloudPrefab_C> 肉鸽月亮05
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_33, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_33, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005297 RID: 21143
		// (get) Token: 0x06026820 RID: 157728 RVA: 0x00976FAB File Offset: 0x009751AB
		// (set) Token: 0x06026821 RID: 157729 RVA: 0x00976FC0 File Offset: 0x009751C0
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑海岸天气_阴
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_34, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_34, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005298 RID: 21144
		// (get) Token: 0x06026822 RID: 157730 RVA: 0x00976FE5 File Offset: 0x009751E5
		// (set) Token: 0x06026823 RID: 157731 RVA: 0x00976FFA File Offset: 0x009751FA
		public TSoftObjectPtr<PD_CloudPrefab_C> 狂欢节
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_35, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_35, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005299 RID: 21145
		// (get) Token: 0x06026824 RID: 157732 RVA: 0x0097701F File Offset: 0x0097521F
		// (set) Token: 0x06026825 RID: 157733 RVA: 0x00977034 File Offset: 0x00975234
		public TSoftObjectPtr<PD_CloudPrefab_C> 槲生半岛解密后
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_36, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_36, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700529A RID: 21146
		// (get) Token: 0x06026826 RID: 157734 RVA: 0x00977059 File Offset: 0x00975259
		// (set) Token: 0x06026827 RID: 157735 RVA: 0x0097706E File Offset: 0x0097526E
		public TSoftObjectPtr<PD_CloudPrefab_C> 云海区
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_37, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_37, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700529B RID: 21147
		// (get) Token: 0x06026828 RID: 157736 RVA: 0x00977093 File Offset: 0x00975293
		// (set) Token: 0x06026829 RID: 157737 RVA: 0x009770A8 File Offset: 0x009752A8
		public TSoftObjectPtr<PD_CloudPrefab_C> 罗墓岛夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_38, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_38, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700529C RID: 21148
		// (get) Token: 0x0602682A RID: 157738 RVA: 0x009770CD File Offset: 0x009752CD
		// (set) Token: 0x0602682B RID: 157739 RVA: 0x009770E2 File Offset: 0x009752E2
		public TSoftObjectPtr<PD_CloudPrefab_C> 黎娜汐塔阴
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_39, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_39, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700529D RID: 21149
		// (get) Token: 0x0602682C RID: 157740 RVA: 0x00977107 File Offset: 0x00975307
		// (set) Token: 0x0602682D RID: 157741 RVA: 0x0097711C File Offset: 0x0097531C
		public TSoftObjectPtr<PD_CloudPrefab_C> 金库上解密后
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_40, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_40, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700529E RID: 21150
		// (get) Token: 0x0602682E RID: 157742 RVA: 0x00977141 File Offset: 0x00975341
		// (set) Token: 0x0602682F RID: 157743 RVA: 0x00977156 File Offset: 0x00975356
		public TSoftObjectPtr<PD_CloudPrefab_C> 费洛洛出场
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_41, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_41, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700529F RID: 21151
		// (get) Token: 0x06026830 RID: 157744 RVA: 0x0097717B File Offset: 0x0097537B
		// (set) Token: 0x06026831 RID: 157745 RVA: 0x00977190 File Offset: 0x00975390
		public TSoftObjectPtr<PD_CloudPrefab_C> 彩虹天气
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_42, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_42, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A0 RID: 21152
		// (get) Token: 0x06026832 RID: 157746 RVA: 0x009771B5 File Offset: 0x009753B5
		// (set) Token: 0x06026833 RID: 157747 RVA: 0x009771CA File Offset: 0x009753CA
		public TSoftObjectPtr<PD_CloudPrefab_C> 颠倒塔白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_43, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_43, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A1 RID: 21153
		// (get) Token: 0x06026834 RID: 157748 RVA: 0x009771EF File Offset: 0x009753EF
		// (set) Token: 0x06026835 RID: 157749 RVA: 0x00977204 File Offset: 0x00975404
		public TSoftObjectPtr<PD_CloudPrefab_C> 颠倒塔夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_44, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_44, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A2 RID: 21154
		// (get) Token: 0x06026836 RID: 157750 RVA: 0x00977229 File Offset: 0x00975429
		// (set) Token: 0x06026837 RID: 157751 RVA: 0x0097723E File Offset: 0x0097543E
		public TSoftObjectPtr<PD_CloudPrefab_C> 颠倒塔流星
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_45, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_45, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A3 RID: 21155
		// (get) Token: 0x06026838 RID: 157752 RVA: 0x00977263 File Offset: 0x00975463
		// (set) Token: 0x06026839 RID: 157753 RVA: 0x00977278 File Offset: 0x00975478
		public TSoftObjectPtr<PD_CloudPrefab_C> 七丘
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_46, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_46, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A4 RID: 21156
		// (get) Token: 0x0602683A RID: 157754 RVA: 0x0097729D File Offset: 0x0097549D
		// (set) Token: 0x0602683B RID: 157755 RVA: 0x009772B2 File Offset: 0x009754B2
		public TSoftObjectPtr<PD_CloudPrefab_C> 七丘阴天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_47, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_47, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A5 RID: 21157
		// (get) Token: 0x0602683C RID: 157756 RVA: 0x009772D7 File Offset: 0x009754D7
		// (set) Token: 0x0602683D RID: 157757 RVA: 0x009772EC File Offset: 0x009754EC
		public TSoftObjectPtr<PD_CloudPrefab_C> 残破竞技场
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_48, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_48, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A6 RID: 21158
		// (get) Token: 0x0602683E RID: 157758 RVA: 0x00977311 File Offset: 0x00975511
		// (set) Token: 0x0602683F RID: 157759 RVA: 0x00977326 File Offset: 0x00975526
		public TSoftObjectPtr<PD_CloudPrefab_C> 尖刺山
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_49, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_49, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A7 RID: 21159
		// (get) Token: 0x06026840 RID: 157760 RVA: 0x0097734B File Offset: 0x0097554B
		// (set) Token: 0x06026841 RID: 157761 RVA: 0x00977360 File Offset: 0x00975560
		public TSoftObjectPtr<PD_CloudPrefab_C> 观测塔
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_50, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_50, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A8 RID: 21160
		// (get) Token: 0x06026842 RID: 157762 RVA: 0x00977385 File Offset: 0x00975585
		// (set) Token: 0x06026843 RID: 157763 RVA: 0x0097739A File Offset: 0x0097559A
		public TSoftObjectPtr<PD_CloudPrefab_C> 初见七丘
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_51, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_51, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052A9 RID: 21161
		// (get) Token: 0x06026844 RID: 157764 RVA: 0x009773BF File Offset: 0x009755BF
		// (set) Token: 0x06026845 RID: 157765 RVA: 0x009773D4 File Offset: 0x009755D4
		public TSoftObjectPtr<PD_CloudPrefab_C> 七丘夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_52, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_52, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052AA RID: 21162
		// (get) Token: 0x06026846 RID: 157766 RVA: 0x009773F9 File Offset: 0x009755F9
		// (set) Token: 0x06026847 RID: 157767 RVA: 0x0097740E File Offset: 0x0097560E
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄斯台地白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_53, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_53, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052AB RID: 21163
		// (get) Token: 0x06026848 RID: 157768 RVA: 0x00977433 File Offset: 0x00975633
		// (set) Token: 0x06026849 RID: 157769 RVA: 0x00977448 File Offset: 0x00975648
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄斯台地夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_54, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_54, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052AC RID: 21164
		// (get) Token: 0x0602684A RID: 157770 RVA: 0x0097746D File Offset: 0x0097566D
		// (set) Token: 0x0602684B RID: 157771 RVA: 0x00977482 File Offset: 0x00975682
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄斯台地日月同辉
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_55, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_55, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052AD RID: 21165
		// (get) Token: 0x0602684C RID: 157772 RVA: 0x009774A7 File Offset: 0x009756A7
		// (set) Token: 0x0602684D RID: 157773 RVA: 0x009774BC File Offset: 0x009756BC
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄斯台地烈日天空
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_56, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_56, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052AE RID: 21166
		// (get) Token: 0x0602684E RID: 157774 RVA: 0x009774E1 File Offset: 0x009756E1
		// (set) Token: 0x0602684F RID: 157775 RVA: 0x009774F6 File Offset: 0x009756F6
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄斯台地受蚀地
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_57, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_57, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052AF RID: 21167
		// (get) Token: 0x06026850 RID: 157776 RVA: 0x0097751B File Offset: 0x0097571B
		// (set) Token: 0x06026851 RID: 157777 RVA: 0x00977530 File Offset: 0x00975730
		public TSoftObjectPtr<PD_CloudPrefab_C> 狄斯台地月相
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_58, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_58, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B0 RID: 21168
		// (get) Token: 0x06026852 RID: 157778 RVA: 0x00977555 File Offset: 0x00975755
		// (set) Token: 0x06026853 RID: 157779 RVA: 0x0097756A File Offset: 0x0097576A
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑潮侵蚀
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_59, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_59, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B1 RID: 21169
		// (get) Token: 0x06026854 RID: 157780 RVA: 0x0097758F File Offset: 0x0097578F
		// (set) Token: 0x06026855 RID: 157781 RVA: 0x009775A4 File Offset: 0x009757A4
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑潮内表世界
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_60, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_60, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B2 RID: 21170
		// (get) Token: 0x06026856 RID: 157782 RVA: 0x009775C9 File Offset: 0x009757C9
		// (set) Token: 0x06026857 RID: 157783 RVA: 0x009775DE File Offset: 0x009757DE
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑潮内里世界
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_61, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_61, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B3 RID: 21171
		// (get) Token: 0x06026858 RID: 157784 RVA: 0x00977603 File Offset: 0x00975803
		// (set) Token: 0x06026859 RID: 157785 RVA: 0x00977618 File Offset: 0x00975818
		public TSoftObjectPtr<PD_CloudPrefab_C> 光路幻境
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_62, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_62, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B4 RID: 21172
		// (get) Token: 0x0602685A RID: 157786 RVA: 0x0097763D File Offset: 0x0097583D
		// (set) Token: 0x0602685B RID: 157787 RVA: 0x00977652 File Offset: 0x00975852
		public TSoftObjectPtr<PD_CloudPrefab_C> 巡游天国
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_63, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_63, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B5 RID: 21173
		// (get) Token: 0x0602685C RID: 157788 RVA: 0x00977677 File Offset: 0x00975877
		// (set) Token: 0x0602685D RID: 157789 RVA: 0x0097768C File Offset: 0x0097588C
		public TSoftObjectPtr<PD_CloudPrefab_C> 隐海试验场
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_64, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_64, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B6 RID: 21174
		// (get) Token: 0x0602685E RID: 157790 RVA: 0x009776B1 File Offset: 0x009758B1
		// (set) Token: 0x0602685F RID: 157791 RVA: 0x009776C6 File Offset: 0x009758C6
		public TSoftObjectPtr<PD_CloudPrefab_C> 失亡彼岸
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_65, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_65, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B7 RID: 21175
		// (get) Token: 0x06026860 RID: 157792 RVA: 0x009776EB File Offset: 0x009758EB
		// (set) Token: 0x06026861 RID: 157793 RVA: 0x00977700 File Offset: 0x00975900
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑潮风暴
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_66, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_66, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B8 RID: 21176
		// (get) Token: 0x06026862 RID: 157794 RVA: 0x00977725 File Offset: 0x00975925
		// (set) Token: 0x06026863 RID: 157795 RVA: 0x0097773A File Offset: 0x0097593A
		public TSoftObjectPtr<PD_CloudPrefab_C> 黑潮风暴加强
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_67, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_67, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052B9 RID: 21177
		// (get) Token: 0x06026864 RID: 157796 RVA: 0x0097775F File Offset: 0x0097595F
		// (set) Token: 0x06026865 RID: 157797 RVA: 0x00977774 File Offset: 0x00975974
		public TSoftObjectPtr<PD_CloudPrefab_C> 烈阳天气
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_68, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_68, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052BA RID: 21178
		// (get) Token: 0x06026866 RID: 157798 RVA: 0x00977799 File Offset: 0x00975999
		// (set) Token: 0x06026867 RID: 157799 RVA: 0x009777AE File Offset: 0x009759AE
		public TSoftObjectPtr<PD_CloudPrefab_C> 总督日月同辉
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_69, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_69, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052BB RID: 21179
		// (get) Token: 0x06026868 RID: 157800 RVA: 0x009777D3 File Offset: 0x009759D3
		// (set) Token: 0x06026869 RID: 157801 RVA: 0x009777E8 File Offset: 0x009759E8
		public TSoftObjectPtr<PD_CloudPrefab_C> 穗波白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_70, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_70, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052BC RID: 21180
		// (get) Token: 0x0602686A RID: 157802 RVA: 0x0097780D File Offset: 0x00975A0D
		// (set) Token: 0x0602686B RID: 157803 RVA: 0x00977822 File Offset: 0x00975A22
		public TSoftObjectPtr<PD_CloudPrefab_C> 穗波夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_71, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_71, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052BD RID: 21181
		// (get) Token: 0x0602686C RID: 157804 RVA: 0x00977847 File Offset: 0x00975A47
		// (set) Token: 0x0602686D RID: 157805 RVA: 0x0097785C File Offset: 0x00975A5C
		public TSoftObjectPtr<PD_CloudPrefab_C> 穗波枯山水
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_72, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_72, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052BE RID: 21182
		// (get) Token: 0x0602686E RID: 157806 RVA: 0x00977881 File Offset: 0x00975A81
		// (set) Token: 0x0602686F RID: 157807 RVA: 0x00977896 File Offset: 0x00975A96
		public TSoftObjectPtr<PD_CloudPrefab_C> 穗波阴天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_73, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_73, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052BF RID: 21183
		// (get) Token: 0x06026870 RID: 157808 RVA: 0x009778BB File Offset: 0x00975ABB
		// (set) Token: 0x06026871 RID: 157809 RVA: 0x009778D0 File Offset: 0x00975AD0
		public TSoftObjectPtr<PD_CloudPrefab_C> 安全点白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_74, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_74, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C0 RID: 21184
		// (get) Token: 0x06026872 RID: 157810 RVA: 0x009778F5 File Offset: 0x00975AF5
		// (set) Token: 0x06026873 RID: 157811 RVA: 0x0097790A File Offset: 0x00975B0A
		public TSoftObjectPtr<PD_CloudPrefab_C> 安全点夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_75, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_75, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C1 RID: 21185
		// (get) Token: 0x06026874 RID: 157812 RVA: 0x0097792F File Offset: 0x00975B2F
		// (set) Token: 0x06026875 RID: 157813 RVA: 0x00977944 File Offset: 0x00975B44
		public TSoftObjectPtr<PD_CloudPrefab_C> 拉海落白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_76, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_76, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C2 RID: 21186
		// (get) Token: 0x06026876 RID: 157814 RVA: 0x00977969 File Offset: 0x00975B69
		// (set) Token: 0x06026877 RID: 157815 RVA: 0x0097797E File Offset: 0x00975B7E
		public TSoftObjectPtr<PD_CloudPrefab_C> 拉海洛夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_77, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_77, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C3 RID: 21187
		// (get) Token: 0x06026878 RID: 157816 RVA: 0x009779A3 File Offset: 0x00975BA3
		// (set) Token: 0x06026879 RID: 157817 RVA: 0x009779B8 File Offset: 0x00975BB8
		public TSoftObjectPtr<PD_CloudPrefab_C> 磁暴前置
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_78, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_78, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C4 RID: 21188
		// (get) Token: 0x0602687A RID: 157818 RVA: 0x009779DD File Offset: 0x00975BDD
		// (set) Token: 0x0602687B RID: 157819 RVA: 0x009779F2 File Offset: 0x00975BF2
		public TSoftObjectPtr<PD_CloudPrefab_C> 磁暴后置
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_79, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_79, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C5 RID: 21189
		// (get) Token: 0x0602687C RID: 157820 RVA: 0x00977A17 File Offset: 0x00975C17
		// (set) Token: 0x0602687D RID: 157821 RVA: 0x00977A2C File Offset: 0x00975C2C
		public TSoftObjectPtr<PD_CloudPrefab_C> 星门Boss
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_80, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_80, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C6 RID: 21190
		// (get) Token: 0x0602687E RID: 157822 RVA: 0x00977A51 File Offset: 0x00975C51
		// (set) Token: 0x0602687F RID: 157823 RVA: 0x00977A66 File Offset: 0x00975C66
		public TSoftObjectPtr<PD_CloudPrefab_C> 坠落炉芯
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_81, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_81, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C7 RID: 21191
		// (get) Token: 0x06026880 RID: 157824 RVA: 0x00977A8B File Offset: 0x00975C8B
		// (set) Token: 0x06026881 RID: 157825 RVA: 0x00977AA0 File Offset: 0x00975CA0
		public TSoftObjectPtr<PD_CloudPrefab_C> 炉芯内部
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_82, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_82, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C8 RID: 21192
		// (get) Token: 0x06026882 RID: 157826 RVA: 0x00977AC5 File Offset: 0x00975CC5
		// (set) Token: 0x06026883 RID: 157827 RVA: 0x00977ADA File Offset: 0x00975CDA
		public TSoftObjectPtr<PD_CloudPrefab_C> 炉芯领主
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_83, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_83, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052C9 RID: 21193
		// (get) Token: 0x06026884 RID: 157828 RVA: 0x00977AFF File Offset: 0x00975CFF
		// (set) Token: 0x06026885 RID: 157829 RVA: 0x00977B14 File Offset: 0x00975D14
		public TSoftObjectPtr<PD_CloudPrefab_C> 浮光林白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_84, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_84, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052CA RID: 21194
		// (get) Token: 0x06026886 RID: 157830 RVA: 0x00977B39 File Offset: 0x00975D39
		// (set) Token: 0x06026887 RID: 157831 RVA: 0x00977B4E File Offset: 0x00975D4E
		public TSoftObjectPtr<PD_CloudPrefab_C> 浮光林夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_85, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_85, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052CB RID: 21195
		// (get) Token: 0x06026888 RID: 157832 RVA: 0x00977B73 File Offset: 0x00975D73
		// (set) Token: 0x06026889 RID: 157833 RVA: 0x00977B88 File Offset: 0x00975D88
		public TSoftObjectPtr<PD_CloudPrefab_C> 拉海洛阴天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_86, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_86, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052CC RID: 21196
		// (get) Token: 0x0602688A RID: 157834 RVA: 0x00977BAD File Offset: 0x00975DAD
		// (set) Token: 0x0602688B RID: 157835 RVA: 0x00977BC2 File Offset: 0x00975DC2
		public TSoftObjectPtr<PD_CloudPrefab_C> 梵高
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_87, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_87, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052CD RID: 21197
		// (get) Token: 0x0602688C RID: 157836 RVA: 0x00977BE7 File Offset: 0x00975DE7
		// (set) Token: 0x0602688D RID: 157837 RVA: 0x00977BFC File Offset: 0x00975DFC
		public TSoftObjectPtr<PD_CloudPrefab_C> 不渲染BP_Cloud控制的云
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_88, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_88, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052CE RID: 21198
		// (get) Token: 0x0602688E RID: 157838 RVA: 0x00977C21 File Offset: 0x00975E21
		// (set) Token: 0x0602688F RID: 157839 RVA: 0x00977C36 File Offset: 0x00975E36
		public TSoftObjectPtr<PD_CloudPrefab_C> 罗伊白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_89, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_89, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052CF RID: 21199
		// (get) Token: 0x06026890 RID: 157840 RVA: 0x00977C5B File Offset: 0x00975E5B
		// (set) Token: 0x06026891 RID: 157841 RVA: 0x00977C70 File Offset: 0x00975E70
		public TSoftObjectPtr<PD_CloudPrefab_C> 罗伊夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_90, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_90, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D0 RID: 21200
		// (get) Token: 0x06026892 RID: 157842 RVA: 0x00977C95 File Offset: 0x00975E95
		// (set) Token: 0x06026893 RID: 157843 RVA: 0x00977CAA File Offset: 0x00975EAA
		public TSoftObjectPtr<PD_CloudPrefab_C> 罗伊极光
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_91, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_91, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D1 RID: 21201
		// (get) Token: 0x06026894 RID: 157844 RVA: 0x00977CCF File Offset: 0x00975ECF
		// (set) Token: 0x06026895 RID: 157845 RVA: 0x00977CE4 File Offset: 0x00975EE4
		public TSoftObjectPtr<PD_CloudPrefab_C> 罗伊初见
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_92, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_92, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D2 RID: 21202
		// (get) Token: 0x06026896 RID: 157846 RVA: 0x00977D09 File Offset: 0x00975F09
		// (set) Token: 0x06026897 RID: 157847 RVA: 0x00977D1E File Offset: 0x00975F1E
		public TSoftObjectPtr<PD_CloudPrefab_C> 星海BOSS一阶
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_93, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_93, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D3 RID: 21203
		// (get) Token: 0x06026898 RID: 157848 RVA: 0x00977D43 File Offset: 0x00975F43
		// (set) Token: 0x06026899 RID: 157849 RVA: 0x00977D58 File Offset: 0x00975F58
		public TSoftObjectPtr<PD_CloudPrefab_C> 星海BOSS二阶
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_94, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_94, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D4 RID: 21204
		// (get) Token: 0x0602689A RID: 157850 RVA: 0x00977D7D File Offset: 0x00975F7D
		// (set) Token: 0x0602689B RID: 157851 RVA: 0x00977D92 File Offset: 0x00975F92
		public TSoftObjectPtr<PD_CloudPrefab_C> 拉海洛初见
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_95, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_95, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D5 RID: 21205
		// (get) Token: 0x0602689C RID: 157852 RVA: 0x00977DB7 File Offset: 0x00975FB7
		// (set) Token: 0x0602689D RID: 157853 RVA: 0x00977DCC File Offset: 0x00975FCC
		public TSoftObjectPtr<PD_CloudPrefab_C> 罗伊红色极光
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_96, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_96, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D6 RID: 21206
		// (get) Token: 0x0602689E RID: 157854 RVA: 0x00977DF1 File Offset: 0x00975FF1
		// (set) Token: 0x0602689F RID: 157855 RVA: 0x00977E06 File Offset: 0x00976006
		public TSoftObjectPtr<PD_CloudPrefab_C> 日灵棺解密前
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_97, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_97, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D7 RID: 21207
		// (get) Token: 0x060268A0 RID: 157856 RVA: 0x00977E2B File Offset: 0x0097602B
		// (set) Token: 0x060268A1 RID: 157857 RVA: 0x00977E40 File Offset: 0x00976040
		public TSoftObjectPtr<PD_CloudPrefab_C> 日灵棺解密后
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_98, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_98, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D8 RID: 21208
		// (get) Token: 0x060268A2 RID: 157858 RVA: 0x00977E65 File Offset: 0x00976065
		// (set) Token: 0x060268A3 RID: 157859 RVA: 0x00977E7A File Offset: 0x0097607A
		public TSoftObjectPtr<PD_CloudPrefab_C> 高达Boss一阶
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_99, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_99, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052D9 RID: 21209
		// (get) Token: 0x060268A4 RID: 157860 RVA: 0x00977E9F File Offset: 0x0097609F
		// (set) Token: 0x060268A5 RID: 157861 RVA: 0x00977EB4 File Offset: 0x009760B4
		public TSoftObjectPtr<PD_CloudPrefab_C> 高达Boss三阶
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_100, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_100, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052DA RID: 21210
		// (get) Token: 0x060268A6 RID: 157862 RVA: 0x00977ED9 File Offset: 0x009760D9
		// (set) Token: 0x060268A7 RID: 157863 RVA: 0x00977EEE File Offset: 0x009760EE
		public TSoftObjectPtr<PD_CloudPrefab_C> 梦州白天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_101, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_101, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052DB RID: 21211
		// (get) Token: 0x060268A8 RID: 157864 RVA: 0x00977F13 File Offset: 0x00976113
		// (set) Token: 0x060268A9 RID: 157865 RVA: 0x00977F28 File Offset: 0x00976128
		public TSoftObjectPtr<PD_CloudPrefab_C> 梦州夜晚
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_102, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_102, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052DC RID: 21212
		// (get) Token: 0x060268AA RID: 157866 RVA: 0x00977F4D File Offset: 0x0097614D
		// (set) Token: 0x060268AB RID: 157867 RVA: 0x00977F62 File Offset: 0x00976162
		public TSoftObjectPtr<PD_CloudPrefab_C> 梦州阴天
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_103, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_103, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052DD RID: 21213
		// (get) Token: 0x060268AC RID: 157868 RVA: 0x00977F87 File Offset: 0x00976187
		// (set) Token: 0x060268AD RID: 157869 RVA: 0x00977F9C File Offset: 0x0097619C
		public TSoftObjectPtr<PD_CloudPrefab_C> 梦州初见
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_104, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_104, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052DE RID: 21214
		// (get) Token: 0x060268AE RID: 157870 RVA: 0x00977FC1 File Offset: 0x009761C1
		// (set) Token: 0x060268AF RID: 157871 RVA: 0x00977FD6 File Offset: 0x009761D6
		public TSoftObjectPtr<PD_CloudPrefab_C> 宅邸解谜前
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_105, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_105, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052DF RID: 21215
		// (get) Token: 0x060268B0 RID: 157872 RVA: 0x00977FFB File Offset: 0x009761FB
		// (set) Token: 0x060268B1 RID: 157873 RVA: 0x00978010 File Offset: 0x00976210
		public TSoftObjectPtr<PD_CloudPrefab_C> 宅邸解谜后
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_106, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_106, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E0 RID: 21216
		// (get) Token: 0x060268B2 RID: 157874 RVA: 0x00978035 File Offset: 0x00976235
		// (set) Token: 0x060268B3 RID: 157875 RVA: 0x0097804A File Offset: 0x0097624A
		public TSoftObjectPtr<PD_CloudPrefab_C> 梦州特殊1
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_107, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_107, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E1 RID: 21217
		// (get) Token: 0x060268B4 RID: 157876 RVA: 0x0097806F File Offset: 0x0097626F
		// (set) Token: 0x060268B5 RID: 157877 RVA: 0x00978084 File Offset: 0x00976284
		public TSoftObjectPtr<PD_CloudPrefab_C> 梦州特殊2
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_108, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_108, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E2 RID: 21218
		// (get) Token: 0x060268B6 RID: 157878 RVA: 0x009780A9 File Offset: 0x009762A9
		// (set) Token: 0x060268B7 RID: 157879 RVA: 0x009780BE File Offset: 0x009762BE
		public TSoftObjectPtr<PD_CloudPrefab_C> 人境
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_109, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_109, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E3 RID: 21219
		// (get) Token: 0x060268B8 RID: 157880 RVA: 0x009780E3 File Offset: 0x009762E3
		// (set) Token: 0x060268B9 RID: 157881 RVA: 0x009780F8 File Offset: 0x009762F8
		public TSoftObjectPtr<PD_CloudPrefab_C> 地境
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_110, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_110, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E4 RID: 21220
		// (get) Token: 0x060268BA RID: 157882 RVA: 0x0097811D File Offset: 0x0097631D
		// (set) Token: 0x060268BB RID: 157883 RVA: 0x00978132 File Offset: 0x00976332
		public TSoftObjectPtr<PD_CloudPrefab_C> 天境
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_111, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_111, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E5 RID: 21221
		// (get) Token: 0x060268BC RID: 157884 RVA: 0x00978157 File Offset: 0x00976357
		// (set) Token: 0x060268BD RID: 157885 RVA: 0x0097816C File Offset: 0x0097636C
		public TSoftObjectPtr<PD_CloudPrefab_C> 心湖
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_112, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_112, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E6 RID: 21222
		// (get) Token: 0x060268BE RID: 157886 RVA: 0x00978191 File Offset: 0x00976391
		// (set) Token: 0x060268BF RID: 157887 RVA: 0x009781A6 File Offset: 0x009763A6
		public TSoftObjectPtr<PD_CloudPrefab_C> 火匣
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_113, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_113, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E7 RID: 21223
		// (get) Token: 0x060268C0 RID: 157888 RVA: 0x009781CB File Offset: 0x009763CB
		// (set) Token: 0x060268C1 RID: 157889 RVA: 0x009781E0 File Offset: 0x009763E0
		public TSoftObjectPtr<PD_CloudPrefab_C> 水匣
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_114, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_114, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E8 RID: 21224
		// (get) Token: 0x060268C2 RID: 157890 RVA: 0x00978205 File Offset: 0x00976405
		// (set) Token: 0x060268C3 RID: 157891 RVA: 0x0097821A File Offset: 0x0097641A
		public TSoftObjectPtr<PD_CloudPrefab_C> 金匣
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_115, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_115, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052E9 RID: 21225
		// (get) Token: 0x060268C4 RID: 157892 RVA: 0x0097823F File Offset: 0x0097643F
		// (set) Token: 0x060268C5 RID: 157893 RVA: 0x00978254 File Offset: 0x00976454
		public TSoftObjectPtr<PD_CloudPrefab_C> 天演幻心
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_116, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_116, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052EA RID: 21226
		// (get) Token: 0x060268C6 RID: 157894 RVA: 0x00978279 File Offset: 0x00976479
		// (set) Token: 0x060268C7 RID: 157895 RVA: 0x0097828E File Offset: 0x0097648E
		public TSoftObjectPtr<PD_CloudPrefab_C> 天演幻心二阶段
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_117, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_117, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170052EB RID: 21227
		// (get) Token: 0x060268C8 RID: 157896 RVA: 0x009782B3 File Offset: 0x009764B3
		// (set) Token: 0x060268C9 RID: 157897 RVA: 0x009782C8 File Offset: 0x009764C8
		public TSoftObjectPtr<PD_CloudPrefab_C> 金匣冷调
		{
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_118, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PD_CloudPreset_C.__PropertyOffset_118, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060268CA RID: 157898 RVA: 0x009782ED File Offset: 0x009764ED
		protected PD_CloudPreset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013584 RID: 79236
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPreset.PD_CloudPreset_C";

		// Token: 0x04013585 RID: 79237
		private static IntPtr _ClassPtr;

		// Token: 0x04013586 RID: 79238
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013587 RID: 79239
		internal static int __PropertyOffset_0;

		// Token: 0x04013588 RID: 79240
		internal static int __PropertyOffset_1;

		// Token: 0x04013589 RID: 79241
		internal static int __PropertyOffset_2;

		// Token: 0x0401358A RID: 79242
		internal static int __PropertyOffset_3;

		// Token: 0x0401358B RID: 79243
		internal static int __PropertyOffset_4;

		// Token: 0x0401358C RID: 79244
		internal static int __PropertyOffset_5;

		// Token: 0x0401358D RID: 79245
		internal static int __PropertyOffset_6;

		// Token: 0x0401358E RID: 79246
		internal static int __PropertyOffset_7;

		// Token: 0x0401358F RID: 79247
		internal static int __PropertyOffset_8;

		// Token: 0x04013590 RID: 79248
		internal static int __PropertyOffset_9;

		// Token: 0x04013591 RID: 79249
		internal static int __PropertyOffset_10;

		// Token: 0x04013592 RID: 79250
		internal static int __PropertyOffset_11;

		// Token: 0x04013593 RID: 79251
		internal static int __PropertyOffset_12;

		// Token: 0x04013594 RID: 79252
		internal static int __PropertyOffset_13;

		// Token: 0x04013595 RID: 79253
		internal static int __PropertyOffset_14;

		// Token: 0x04013596 RID: 79254
		internal static int __PropertyOffset_15;

		// Token: 0x04013597 RID: 79255
		internal static int __PropertyOffset_16;

		// Token: 0x04013598 RID: 79256
		internal static int __PropertyOffset_17;

		// Token: 0x04013599 RID: 79257
		internal static int __PropertyOffset_18;

		// Token: 0x0401359A RID: 79258
		internal static int __PropertyOffset_19;

		// Token: 0x0401359B RID: 79259
		internal static int __PropertyOffset_20;

		// Token: 0x0401359C RID: 79260
		internal static int __PropertyOffset_21;

		// Token: 0x0401359D RID: 79261
		internal static int __PropertyOffset_22;

		// Token: 0x0401359E RID: 79262
		internal static int __PropertyOffset_23;

		// Token: 0x0401359F RID: 79263
		internal static int __PropertyOffset_24;

		// Token: 0x040135A0 RID: 79264
		internal static int __PropertyOffset_25;

		// Token: 0x040135A1 RID: 79265
		internal static int __PropertyOffset_26;

		// Token: 0x040135A2 RID: 79266
		internal static int __PropertyOffset_27;

		// Token: 0x040135A3 RID: 79267
		internal static int __PropertyOffset_28;

		// Token: 0x040135A4 RID: 79268
		internal static int __PropertyOffset_29;

		// Token: 0x040135A5 RID: 79269
		internal static int __PropertyOffset_30;

		// Token: 0x040135A6 RID: 79270
		internal static int __PropertyOffset_31;

		// Token: 0x040135A7 RID: 79271
		internal static int __PropertyOffset_32;

		// Token: 0x040135A8 RID: 79272
		internal static int __PropertyOffset_33;

		// Token: 0x040135A9 RID: 79273
		internal static int __PropertyOffset_34;

		// Token: 0x040135AA RID: 79274
		internal static int __PropertyOffset_35;

		// Token: 0x040135AB RID: 79275
		internal static int __PropertyOffset_36;

		// Token: 0x040135AC RID: 79276
		internal static int __PropertyOffset_37;

		// Token: 0x040135AD RID: 79277
		internal static int __PropertyOffset_38;

		// Token: 0x040135AE RID: 79278
		internal static int __PropertyOffset_39;

		// Token: 0x040135AF RID: 79279
		internal static int __PropertyOffset_40;

		// Token: 0x040135B0 RID: 79280
		internal static int __PropertyOffset_41;

		// Token: 0x040135B1 RID: 79281
		internal static int __PropertyOffset_42;

		// Token: 0x040135B2 RID: 79282
		internal static int __PropertyOffset_43;

		// Token: 0x040135B3 RID: 79283
		internal static int __PropertyOffset_44;

		// Token: 0x040135B4 RID: 79284
		internal static int __PropertyOffset_45;

		// Token: 0x040135B5 RID: 79285
		internal static int __PropertyOffset_46;

		// Token: 0x040135B6 RID: 79286
		internal static int __PropertyOffset_47;

		// Token: 0x040135B7 RID: 79287
		internal static int __PropertyOffset_48;

		// Token: 0x040135B8 RID: 79288
		internal static int __PropertyOffset_49;

		// Token: 0x040135B9 RID: 79289
		internal static int __PropertyOffset_50;

		// Token: 0x040135BA RID: 79290
		internal static int __PropertyOffset_51;

		// Token: 0x040135BB RID: 79291
		internal static int __PropertyOffset_52;

		// Token: 0x040135BC RID: 79292
		internal static int __PropertyOffset_53;

		// Token: 0x040135BD RID: 79293
		internal static int __PropertyOffset_54;

		// Token: 0x040135BE RID: 79294
		internal static int __PropertyOffset_55;

		// Token: 0x040135BF RID: 79295
		internal static int __PropertyOffset_56;

		// Token: 0x040135C0 RID: 79296
		internal static int __PropertyOffset_57;

		// Token: 0x040135C1 RID: 79297
		internal static int __PropertyOffset_58;

		// Token: 0x040135C2 RID: 79298
		internal static int __PropertyOffset_59;

		// Token: 0x040135C3 RID: 79299
		internal static int __PropertyOffset_60;

		// Token: 0x040135C4 RID: 79300
		internal static int __PropertyOffset_61;

		// Token: 0x040135C5 RID: 79301
		internal static int __PropertyOffset_62;

		// Token: 0x040135C6 RID: 79302
		internal static int __PropertyOffset_63;

		// Token: 0x040135C7 RID: 79303
		internal static int __PropertyOffset_64;

		// Token: 0x040135C8 RID: 79304
		internal static int __PropertyOffset_65;

		// Token: 0x040135C9 RID: 79305
		internal static int __PropertyOffset_66;

		// Token: 0x040135CA RID: 79306
		internal static int __PropertyOffset_67;

		// Token: 0x040135CB RID: 79307
		internal static int __PropertyOffset_68;

		// Token: 0x040135CC RID: 79308
		internal static int __PropertyOffset_69;

		// Token: 0x040135CD RID: 79309
		internal static int __PropertyOffset_70;

		// Token: 0x040135CE RID: 79310
		internal static int __PropertyOffset_71;

		// Token: 0x040135CF RID: 79311
		internal static int __PropertyOffset_72;

		// Token: 0x040135D0 RID: 79312
		internal static int __PropertyOffset_73;

		// Token: 0x040135D1 RID: 79313
		internal static int __PropertyOffset_74;

		// Token: 0x040135D2 RID: 79314
		internal static int __PropertyOffset_75;

		// Token: 0x040135D3 RID: 79315
		internal static int __PropertyOffset_76;

		// Token: 0x040135D4 RID: 79316
		internal static int __PropertyOffset_77;

		// Token: 0x040135D5 RID: 79317
		internal static int __PropertyOffset_78;

		// Token: 0x040135D6 RID: 79318
		internal static int __PropertyOffset_79;

		// Token: 0x040135D7 RID: 79319
		internal static int __PropertyOffset_80;

		// Token: 0x040135D8 RID: 79320
		internal static int __PropertyOffset_81;

		// Token: 0x040135D9 RID: 79321
		internal static int __PropertyOffset_82;

		// Token: 0x040135DA RID: 79322
		internal static int __PropertyOffset_83;

		// Token: 0x040135DB RID: 79323
		internal static int __PropertyOffset_84;

		// Token: 0x040135DC RID: 79324
		internal static int __PropertyOffset_85;

		// Token: 0x040135DD RID: 79325
		internal static int __PropertyOffset_86;

		// Token: 0x040135DE RID: 79326
		internal static int __PropertyOffset_87;

		// Token: 0x040135DF RID: 79327
		internal static int __PropertyOffset_88;

		// Token: 0x040135E0 RID: 79328
		internal static int __PropertyOffset_89;

		// Token: 0x040135E1 RID: 79329
		internal static int __PropertyOffset_90;

		// Token: 0x040135E2 RID: 79330
		internal static int __PropertyOffset_91;

		// Token: 0x040135E3 RID: 79331
		internal static int __PropertyOffset_92;

		// Token: 0x040135E4 RID: 79332
		internal static int __PropertyOffset_93;

		// Token: 0x040135E5 RID: 79333
		internal static int __PropertyOffset_94;

		// Token: 0x040135E6 RID: 79334
		internal static int __PropertyOffset_95;

		// Token: 0x040135E7 RID: 79335
		internal static int __PropertyOffset_96;

		// Token: 0x040135E8 RID: 79336
		internal static int __PropertyOffset_97;

		// Token: 0x040135E9 RID: 79337
		internal static int __PropertyOffset_98;

		// Token: 0x040135EA RID: 79338
		internal static int __PropertyOffset_99;

		// Token: 0x040135EB RID: 79339
		internal static int __PropertyOffset_100;

		// Token: 0x040135EC RID: 79340
		internal static int __PropertyOffset_101;

		// Token: 0x040135ED RID: 79341
		internal static int __PropertyOffset_102;

		// Token: 0x040135EE RID: 79342
		internal static int __PropertyOffset_103;

		// Token: 0x040135EF RID: 79343
		internal static int __PropertyOffset_104;

		// Token: 0x040135F0 RID: 79344
		internal static int __PropertyOffset_105;

		// Token: 0x040135F1 RID: 79345
		internal static int __PropertyOffset_106;

		// Token: 0x040135F2 RID: 79346
		internal static int __PropertyOffset_107;

		// Token: 0x040135F3 RID: 79347
		internal static int __PropertyOffset_108;

		// Token: 0x040135F4 RID: 79348
		internal static int __PropertyOffset_109;

		// Token: 0x040135F5 RID: 79349
		internal static int __PropertyOffset_110;

		// Token: 0x040135F6 RID: 79350
		internal static int __PropertyOffset_111;

		// Token: 0x040135F7 RID: 79351
		internal static int __PropertyOffset_112;

		// Token: 0x040135F8 RID: 79352
		internal static int __PropertyOffset_113;

		// Token: 0x040135F9 RID: 79353
		internal static int __PropertyOffset_114;

		// Token: 0x040135FA RID: 79354
		internal static int __PropertyOffset_115;

		// Token: 0x040135FB RID: 79355
		internal static int __PropertyOffset_116;

		// Token: 0x040135FC RID: 79356
		internal static int __PropertyOffset_117;

		// Token: 0x040135FD RID: 79357
		internal static int __PropertyOffset_118;
	}
}
