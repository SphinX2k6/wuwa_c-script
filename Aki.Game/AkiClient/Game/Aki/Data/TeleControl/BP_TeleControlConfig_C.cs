using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.TeleControl
{
	// Token: 0x02003E95 RID: 16021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/TeleControl/BP_TeleControlConfig.BP_TeleControlConfig_C")]
	[UnrealStructLayout(792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 792)]
	public class BP_TeleControlConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602879B RID: 165787 RVA: 0x009AD579 File Offset: 0x009AB779
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TeleControlConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/TeleControl/BP_TeleControlConfig.BP_TeleControlConfig_C");
			}
			return BP_TeleControlConfig_C._ClassPtr;
		}

		// Token: 0x0602879C RID: 165788 RVA: 0x009AD5A0 File Offset: 0x009AB7A0
		public BP_TeleControlConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_TeleControlConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602879D RID: 165789 RVA: 0x009AD5C8 File Offset: 0x009AB7C8
		public BP_TeleControlConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TeleControlConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005DFE RID: 24062
		// (get) Token: 0x0602879E RID: 165790 RVA: 0x009AD5FB File Offset: 0x009AB7FB
		// (set) Token: 0x0602879F RID: 165791 RVA: 0x009AD60B File Offset: 0x009AB80B
		public unsafe float 读条时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005DFF RID: 24063
		// (get) Token: 0x060287A0 RID: 165792 RVA: 0x009AD61C File Offset: 0x009AB81C
		// (set) Token: 0x060287A1 RID: 165793 RVA: 0x009AD62C File Offset: 0x009AB82C
		public unsafe bool 未锁定目标时不可投掷
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E00 RID: 24064
		// (get) Token: 0x060287A2 RID: 165794 RVA: 0x009AD63D File Offset: 0x009AB83D
		// (set) Token: 0x060287A3 RID: 165795 RVA: 0x009AD64D File Offset: 0x009AB84D
		public unsafe float 摆动频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005E01 RID: 24065
		// (get) Token: 0x060287A4 RID: 165796 RVA: 0x009AD65E File Offset: 0x009AB85E
		// (set) Token: 0x060287A5 RID: 165797 RVA: 0x009AD66E File Offset: 0x009AB86E
		public unsafe float 吸取延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005E02 RID: 24066
		// (get) Token: 0x060287A6 RID: 165798 RVA: 0x009AD67F File Offset: 0x009AB87F
		// (set) Token: 0x060287A7 RID: 165799 RVA: 0x009AD68F File Offset: 0x009AB88F
		public unsafe float 线性阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005E03 RID: 24067
		// (get) Token: 0x060287A8 RID: 165800 RVA: 0x009AD6A0 File Offset: 0x009AB8A0
		// (set) Token: 0x060287A9 RID: 165801 RVA: 0x009AD6B0 File Offset: 0x009AB8B0
		public unsafe float 角刚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005E04 RID: 24068
		// (get) Token: 0x060287AA RID: 165802 RVA: 0x009AD6C1 File Offset: 0x009AB8C1
		// (set) Token: 0x060287AB RID: 165803 RVA: 0x009AD6D1 File Offset: 0x009AB8D1
		public unsafe float 线性刚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005E05 RID: 24069
		// (get) Token: 0x060287AC RID: 165804 RVA: 0x009AD6E2 File Offset: 0x009AB8E2
		// (set) Token: 0x060287AD RID: 165805 RVA: 0x009AD6F2 File Offset: 0x009AB8F2
		public unsafe float 角度阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005E06 RID: 24070
		// (get) Token: 0x060287AE RID: 165806 RVA: 0x009AD703 File Offset: 0x009AB903
		// (set) Token: 0x060287AF RID: 165807 RVA: 0x009AD713 File Offset: 0x009AB913
		public unsafe float 吸取时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005E07 RID: 24071
		// (get) Token: 0x060287B0 RID: 165808 RVA: 0x009AD724 File Offset: 0x009AB924
		// (set) Token: 0x060287B1 RID: 165809 RVA: 0x009AD734 File Offset: 0x009AB934
		public unsafe float 对齐时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005E08 RID: 24072
		// (get) Token: 0x060287B2 RID: 165810 RVA: 0x009AD745 File Offset: 0x009AB945
		// (set) Token: 0x060287B3 RID: 165811 RVA: 0x009AD755 File Offset: 0x009AB955
		public unsafe float 牵引高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005E09 RID: 24073
		// (get) Token: 0x060287B4 RID: 165812 RVA: 0x009AD766 File Offset: 0x009AB966
		// (set) Token: 0x060287B5 RID: 165813 RVA: 0x009AD776 File Offset: 0x009AB976
		public unsafe float 角速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005E0A RID: 24074
		// (get) Token: 0x060287B6 RID: 165814 RVA: 0x009AD787 File Offset: 0x009AB987
		// (set) Token: 0x060287B7 RID: 165815 RVA: 0x009AD797 File Offset: 0x009AB997
		public unsafe float 摆动范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005E0B RID: 24075
		// (get) Token: 0x060287B8 RID: 165816 RVA: 0x009AD7A8 File Offset: 0x009AB9A8
		// (set) Token: 0x060287B9 RID: 165817 RVA: 0x009AD7BC File Offset: 0x009AB9BC
		public unsafe FVector 旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005E0C RID: 24076
		// (get) Token: 0x060287BA RID: 165818 RVA: 0x009AD7D1 File Offset: 0x009AB9D1
		// (set) Token: 0x060287BB RID: 165819 RVA: 0x009AD7E5 File Offset: 0x009AB9E5
		public unsafe FVector 一级偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005E0D RID: 24077
		// (get) Token: 0x060287BC RID: 165820 RVA: 0x009AD7FA File Offset: 0x009AB9FA
		// (set) Token: 0x060287BD RID: 165821 RVA: 0x009AD80E File Offset: 0x009ABA0E
		public unsafe FVector 二级偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005E0E RID: 24078
		// (get) Token: 0x060287BE RID: 165822 RVA: 0x009AD823 File Offset: 0x009ABA23
		// (set) Token: 0x060287BF RID: 165823 RVA: 0x009AD837 File Offset: 0x009ABA37
		public unsafe FGameplayTag 控物保持镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005E0F RID: 24079
		// (get) Token: 0x060287C0 RID: 165824 RVA: 0x009AD84C File Offset: 0x009ABA4C
		// (set) Token: 0x060287C1 RID: 165825 RVA: 0x009AD860 File Offset: 0x009ABA60
		public unsafe FGameplayTag 读条镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005E10 RID: 24080
		// (get) Token: 0x060287C2 RID: 165826 RVA: 0x009AD875 File Offset: 0x009ABA75
		// (set) Token: 0x060287C3 RID: 165827 RVA: 0x009AD889 File Offset: 0x009ABA89
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> 读条震屏
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_18);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005E11 RID: 24081
		// (get) Token: 0x060287C4 RID: 165828 RVA: 0x009AD89E File Offset: 0x009ABA9E
		// (set) Token: 0x060287C5 RID: 165829 RVA: 0x009AD8AE File Offset: 0x009ABAAE
		public unsafe float 被控制CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005E12 RID: 24082
		// (get) Token: 0x060287C6 RID: 165830 RVA: 0x009AD8BF File Offset: 0x009ABABF
		// (set) Token: 0x060287C7 RID: 165831 RVA: 0x009AD8D3 File Offset: 0x009ABAD3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> 控物保持震屏
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_20);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005E13 RID: 24083
		// (get) Token: 0x060287C8 RID: 165832 RVA: 0x009AD8E8 File Offset: 0x009ABAE8
		// (set) Token: 0x060287C9 RID: 165833 RVA: 0x009AD8FC File Offset: 0x009ABAFC
		public unsafe FGameplayTag 吸取飞行镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005E14 RID: 24084
		// (get) Token: 0x060287CA RID: 165834 RVA: 0x009AD911 File Offset: 0x009ABB11
		// (set) Token: 0x060287CB RID: 165835 RVA: 0x009AD925 File Offset: 0x009ABB25
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> 吸取飞行震屏
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_22);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005E15 RID: 24085
		// (get) Token: 0x060287CC RID: 165836 RVA: 0x009AD93A File Offset: 0x009ABB3A
		// (set) Token: 0x060287CD RID: 165837 RVA: 0x009AD94A File Offset: 0x009ABB4A
		public unsafe bool 打开速度Log
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E16 RID: 24086
		// (get) Token: 0x060287CE RID: 165838 RVA: 0x009AD95B File Offset: 0x009ABB5B
		// (set) Token: 0x060287CF RID: 165839 RVA: 0x009AD96B File Offset: 0x009ABB6B
		public unsafe float 可再被控速度最小值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005E17 RID: 24087
		// (get) Token: 0x060287D0 RID: 165840 RVA: 0x009AD97C File Offset: 0x009ABB7C
		// (set) Token: 0x060287D1 RID: 165841 RVA: 0x009AD98C File Offset: 0x009ABB8C
		public unsafe float 被感知范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005E18 RID: 24088
		// (get) Token: 0x060287D2 RID: 165842 RVA: 0x009AD9A0 File Offset: 0x009ABBA0
		// (set) Token: 0x060287D3 RID: 165843 RVA: 0x009AD9D9 File Offset: 0x009ABBD9
		public TMap<float, float> 被感知角度权重
		{
			get
			{
				base.FastCheckIsValid();
				TMap<float, float> result;
				if ((result = this._被感知角度权重) == null)
				{
					result = (this._被感知角度权重 = new TMap<float, float>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_26, this));
				}
				return result;
			}
			set
			{
				this.被感知角度权重.CopyAssign(value);
			}
		}

		// Token: 0x17005E19 RID: 24089
		// (get) Token: 0x060287D4 RID: 165844 RVA: 0x009AD9E7 File Offset: 0x009ABBE7
		// (set) Token: 0x060287D5 RID: 165845 RVA: 0x009AD9FB File Offset: 0x009ABBFB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> 投掷震屏
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_27);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005E1A RID: 24090
		// (get) Token: 0x060287D6 RID: 165846 RVA: 0x009ADA10 File Offset: 0x009ABC10
		// (set) Token: 0x060287D7 RID: 165847 RVA: 0x009ADA20 File Offset: 0x009ABC20
		public unsafe bool 随速度调整朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E1B RID: 24091
		// (get) Token: 0x060287D8 RID: 165848 RVA: 0x009ADA31 File Offset: 0x009ABC31
		// (set) Token: 0x060287D9 RID: 165849 RVA: 0x009ADA41 File Offset: 0x009ABC41
		public unsafe bool 控物保持使用物理
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E1C RID: 24092
		// (get) Token: 0x060287DA RID: 165850 RVA: 0x009ADA52 File Offset: 0x009ABC52
		// (set) Token: 0x060287DB RID: 165851 RVA: 0x009ADA62 File Offset: 0x009ABC62
		public unsafe float 无锁状态附加仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17005E1D RID: 24093
		// (get) Token: 0x060287DC RID: 165852 RVA: 0x009ADA74 File Offset: 0x009ABC74
		// (set) Token: 0x060287DD RID: 165853 RVA: 0x009ADAAD File Offset: 0x009ABCAD
		public TArray<FGameplayTag> 控物保持标签
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._控物保持标签) == null)
				{
					result = (this._控物保持标签 = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_31, this));
				}
				return result;
			}
			set
			{
				this.控物保持标签.CopyAssign(value);
			}
		}

		// Token: 0x17005E1E RID: 24094
		// (get) Token: 0x060287DE RID: 165854 RVA: 0x009ADABB File Offset: 0x009ABCBB
		// (set) Token: 0x060287DF RID: 165855 RVA: 0x009ADACF File Offset: 0x009ABCCF
		public unsafe FVector 被感知坐标偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17005E1F RID: 24095
		// (get) Token: 0x060287E0 RID: 165856 RVA: 0x009ADAE4 File Offset: 0x009ABCE4
		// (set) Token: 0x060287E1 RID: 165857 RVA: 0x009ADAF4 File Offset: 0x009ABCF4
		public unsafe float 物体质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17005E20 RID: 24096
		// (get) Token: 0x060287E2 RID: 165858 RVA: 0x009ADB05 File Offset: 0x009ABD05
		// (set) Token: 0x060287E3 RID: 165859 RVA: 0x009ADB15 File Offset: 0x009ABD15
		public unsafe float 物体线性阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17005E21 RID: 24097
		// (get) Token: 0x060287E4 RID: 165860 RVA: 0x009ADB26 File Offset: 0x009ABD26
		// (set) Token: 0x060287E5 RID: 165861 RVA: 0x009ADB36 File Offset: 0x009ABD36
		public unsafe float 物体角速度阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17005E22 RID: 24098
		// (get) Token: 0x060287E6 RID: 165862 RVA: 0x009ADB47 File Offset: 0x009ABD47
		// (set) Token: 0x060287E7 RID: 165863 RVA: 0x009ADB5B File Offset: 0x009ABD5B
		public unsafe string 控物准星资源ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_TeleControlConfig_C.__PropertyOffset_36)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_TeleControlConfig_C.__PropertyOffset_36)), value);
			}
		}

		// Token: 0x17005E23 RID: 24099
		// (get) Token: 0x060287E8 RID: 165864 RVA: 0x009ADB70 File Offset: 0x009ABD70
		// (set) Token: 0x060287E9 RID: 165865 RVA: 0x009ADB80 File Offset: 0x009ABD80
		public unsafe bool 角色是否随相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E24 RID: 24100
		// (get) Token: 0x060287EA RID: 165866 RVA: 0x009ADB91 File Offset: 0x009ABD91
		// (set) Token: 0x060287EB RID: 165867 RVA: 0x009ADBA5 File Offset: 0x009ABDA5
		public unsafe FName 待机状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17005E25 RID: 24101
		// (get) Token: 0x060287EC RID: 165868 RVA: 0x009ADBBA File Offset: 0x009ABDBA
		// (set) Token: 0x060287ED RID: 165869 RVA: 0x009ADBCE File Offset: 0x009ABDCE
		public unsafe FName 吸取状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17005E26 RID: 24102
		// (get) Token: 0x060287EE RID: 165870 RVA: 0x009ADBE3 File Offset: 0x009ABDE3
		// (set) Token: 0x060287EF RID: 165871 RVA: 0x009ADBF7 File Offset: 0x009ABDF7
		public unsafe FName 保持状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17005E27 RID: 24103
		// (get) Token: 0x060287F0 RID: 165872 RVA: 0x009ADC0C File Offset: 0x009ABE0C
		// (set) Token: 0x060287F1 RID: 165873 RVA: 0x009ADC20 File Offset: 0x009ABE20
		public unsafe FName 投掷状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17005E28 RID: 24104
		// (get) Token: 0x060287F2 RID: 165874 RVA: 0x009ADC35 File Offset: 0x009ABE35
		// (set) Token: 0x060287F3 RID: 165875 RVA: 0x009ADC49 File Offset: 0x009ABE49
		[Nullable(2)]
		public unsafe UCurveVector 投掷运动轨迹曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_42);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17005E29 RID: 24105
		// (get) Token: 0x060287F4 RID: 165876 RVA: 0x009ADC5E File Offset: 0x009ABE5E
		// (set) Token: 0x060287F5 RID: 165877 RVA: 0x009ADC6E File Offset: 0x009ABE6E
		public unsafe bool 抛物瞄准射线Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E2A RID: 24106
		// (get) Token: 0x060287F6 RID: 165878 RVA: 0x009ADC7F File Offset: 0x009ABE7F
		// (set) Token: 0x060287F7 RID: 165879 RVA: 0x009ADC8F File Offset: 0x009ABE8F
		public unsafe bool 抛物瞄准模式开关
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E2B RID: 24107
		// (get) Token: 0x060287F8 RID: 165880 RVA: 0x009ADCA0 File Offset: 0x009ABEA0
		// (set) Token: 0x060287F9 RID: 165881 RVA: 0x009ADCB0 File Offset: 0x009ABEB0
		public unsafe float 抛物瞄准模式仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17005E2C RID: 24108
		// (get) Token: 0x060287FA RID: 165882 RVA: 0x009ADCC1 File Offset: 0x009ABEC1
		// (set) Token: 0x060287FB RID: 165883 RVA: 0x009ADCD1 File Offset: 0x009ABED1
		public unsafe float 抛物瞄准模式初速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17005E2D RID: 24109
		// (get) Token: 0x060287FC RID: 165884 RVA: 0x009ADCE2 File Offset: 0x009ABEE2
		// (set) Token: 0x060287FD RID: 165885 RVA: 0x009ADCF2 File Offset: 0x009ABEF2
		public unsafe float 抛物瞄准射线检测半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17005E2E RID: 24110
		// (get) Token: 0x060287FE RID: 165886 RVA: 0x009ADD03 File Offset: 0x009ABF03
		// (set) Token: 0x060287FF RID: 165887 RVA: 0x009ADD17 File Offset: 0x009ABF17
		public unsafe FGameplayTag 抛物瞄准模式镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17005E2F RID: 24111
		// (get) Token: 0x06028800 RID: 165888 RVA: 0x009ADD2C File Offset: 0x009ABF2C
		// (set) Token: 0x06028801 RID: 165889 RVA: 0x009ADD65 File Offset: 0x009ABF65
		public FSoftObjectPath 抛物瞄准模式样条特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._抛物瞄准模式样条特效) == null)
				{
					result = (this._抛物瞄准模式样条特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_49, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_49, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E30 RID: 24112
		// (get) Token: 0x06028802 RID: 165890 RVA: 0x009ADD88 File Offset: 0x009ABF88
		// (set) Token: 0x06028803 RID: 165891 RVA: 0x009ADDC1 File Offset: 0x009ABFC1
		public FSoftObjectPath 抛物瞄准模式终点特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._抛物瞄准模式终点特效) == null)
				{
					result = (this._抛物瞄准模式终点特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_50, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_50, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E31 RID: 24113
		// (get) Token: 0x06028804 RID: 165892 RVA: 0x009ADDE2 File Offset: 0x009ABFE2
		// (set) Token: 0x06028805 RID: 165893 RVA: 0x009ADDF2 File Offset: 0x009ABFF2
		public unsafe float 抛物瞄准模式重力加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17005E32 RID: 24114
		// (get) Token: 0x06028806 RID: 165894 RVA: 0x009ADE03 File Offset: 0x009AC003
		// (set) Token: 0x06028807 RID: 165895 RVA: 0x009ADE13 File Offset: 0x009AC013
		public unsafe float 投掷锁定范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17005E33 RID: 24115
		// (get) Token: 0x06028808 RID: 165896 RVA: 0x009ADE24 File Offset: 0x009AC024
		// (set) Token: 0x06028809 RID: 165897 RVA: 0x009ADE5D File Offset: 0x009AC05D
		public FSoftObjectPath 归位消失特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._归位消失特效) == null)
				{
					result = (this._归位消失特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_53, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_53, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E34 RID: 24116
		// (get) Token: 0x0602880A RID: 165898 RVA: 0x009ADE80 File Offset: 0x009AC080
		// (set) Token: 0x0602880B RID: 165899 RVA: 0x009ADEB9 File Offset: 0x009AC0B9
		public TMap<int, float> 投掷状态CueId
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._投掷状态CueId) == null)
				{
					result = (this._投掷状态CueId = new TMap<int, float>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_54, this));
				}
				return result;
			}
			set
			{
				this.投掷状态CueId.CopyAssign(value);
			}
		}

		// Token: 0x17005E35 RID: 24117
		// (get) Token: 0x0602880C RID: 165900 RVA: 0x009ADEC7 File Offset: 0x009AC0C7
		// (set) Token: 0x0602880D RID: 165901 RVA: 0x009ADEDB File Offset: 0x009AC0DB
		[Nullable(2)]
		public unsafe UPhysicalMaterial 物体物理材质
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_55);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x17005E36 RID: 24118
		// (get) Token: 0x0602880E RID: 165902 RVA: 0x009ADEF0 File Offset: 0x009AC0F0
		// (set) Token: 0x0602880F RID: 165903 RVA: 0x009ADF05 File Offset: 0x009AC105
		public TSoftObjectPtr<UKuroForceFeedbackEffect> 吸取飞行手柄震动
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_56, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_56, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E37 RID: 24119
		// (get) Token: 0x06028810 RID: 165904 RVA: 0x009ADF2A File Offset: 0x009AC12A
		// (set) Token: 0x06028811 RID: 165905 RVA: 0x009ADF3F File Offset: 0x009AC13F
		public TSoftObjectPtr<UKuroForceFeedbackEffect> 投掷手柄震动
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_57, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_57, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06028812 RID: 165906 RVA: 0x009ADF64 File Offset: 0x009AC164
		protected BP_TeleControlConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014A51 RID: 84561
		public new const string __ObjectPath = "/Game/Aki/Data/TeleControl/BP_TeleControlConfig.BP_TeleControlConfig_C";

		// Token: 0x04014A52 RID: 84562
		private static IntPtr _ClassPtr;

		// Token: 0x04014A53 RID: 84563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014A54 RID: 84564
		internal static int __PropertyOffset_0;

		// Token: 0x04014A55 RID: 84565
		internal static int __PropertyOffset_1;

		// Token: 0x04014A56 RID: 84566
		internal static int __PropertyOffset_2;

		// Token: 0x04014A57 RID: 84567
		internal static int __PropertyOffset_3;

		// Token: 0x04014A58 RID: 84568
		internal static int __PropertyOffset_4;

		// Token: 0x04014A59 RID: 84569
		internal static int __PropertyOffset_5;

		// Token: 0x04014A5A RID: 84570
		internal static int __PropertyOffset_6;

		// Token: 0x04014A5B RID: 84571
		internal static int __PropertyOffset_7;

		// Token: 0x04014A5C RID: 84572
		internal static int __PropertyOffset_8;

		// Token: 0x04014A5D RID: 84573
		internal static int __PropertyOffset_9;

		// Token: 0x04014A5E RID: 84574
		internal static int __PropertyOffset_10;

		// Token: 0x04014A5F RID: 84575
		internal static int __PropertyOffset_11;

		// Token: 0x04014A60 RID: 84576
		internal static int __PropertyOffset_12;

		// Token: 0x04014A61 RID: 84577
		internal static int __PropertyOffset_13;

		// Token: 0x04014A62 RID: 84578
		internal static int __PropertyOffset_14;

		// Token: 0x04014A63 RID: 84579
		internal static int __PropertyOffset_15;

		// Token: 0x04014A64 RID: 84580
		internal static int __PropertyOffset_16;

		// Token: 0x04014A65 RID: 84581
		internal static int __PropertyOffset_17;

		// Token: 0x04014A66 RID: 84582
		internal static int __PropertyOffset_18;

		// Token: 0x04014A67 RID: 84583
		internal static int __PropertyOffset_19;

		// Token: 0x04014A68 RID: 84584
		internal static int __PropertyOffset_20;

		// Token: 0x04014A69 RID: 84585
		internal static int __PropertyOffset_21;

		// Token: 0x04014A6A RID: 84586
		internal static int __PropertyOffset_22;

		// Token: 0x04014A6B RID: 84587
		internal static int __PropertyOffset_23;

		// Token: 0x04014A6C RID: 84588
		internal static int __PropertyOffset_24;

		// Token: 0x04014A6D RID: 84589
		internal static int __PropertyOffset_25;

		// Token: 0x04014A6E RID: 84590
		internal static int __PropertyOffset_26;

		// Token: 0x04014A6F RID: 84591
		[Nullable(2)]
		private TMap<float, float> _被感知角度权重;

		// Token: 0x04014A70 RID: 84592
		internal static int __PropertyOffset_27;

		// Token: 0x04014A71 RID: 84593
		internal static int __PropertyOffset_28;

		// Token: 0x04014A72 RID: 84594
		internal static int __PropertyOffset_29;

		// Token: 0x04014A73 RID: 84595
		internal static int __PropertyOffset_30;

		// Token: 0x04014A74 RID: 84596
		internal static int __PropertyOffset_31;

		// Token: 0x04014A75 RID: 84597
		[Nullable(2)]
		private TArray<FGameplayTag> _控物保持标签;

		// Token: 0x04014A76 RID: 84598
		internal static int __PropertyOffset_32;

		// Token: 0x04014A77 RID: 84599
		internal static int __PropertyOffset_33;

		// Token: 0x04014A78 RID: 84600
		internal static int __PropertyOffset_34;

		// Token: 0x04014A79 RID: 84601
		internal static int __PropertyOffset_35;

		// Token: 0x04014A7A RID: 84602
		internal static int __PropertyOffset_36;

		// Token: 0x04014A7B RID: 84603
		internal static int __PropertyOffset_37;

		// Token: 0x04014A7C RID: 84604
		internal static int __PropertyOffset_38;

		// Token: 0x04014A7D RID: 84605
		internal static int __PropertyOffset_39;

		// Token: 0x04014A7E RID: 84606
		internal static int __PropertyOffset_40;

		// Token: 0x04014A7F RID: 84607
		internal static int __PropertyOffset_41;

		// Token: 0x04014A80 RID: 84608
		internal static int __PropertyOffset_42;

		// Token: 0x04014A81 RID: 84609
		internal static int __PropertyOffset_43;

		// Token: 0x04014A82 RID: 84610
		internal static int __PropertyOffset_44;

		// Token: 0x04014A83 RID: 84611
		internal static int __PropertyOffset_45;

		// Token: 0x04014A84 RID: 84612
		internal static int __PropertyOffset_46;

		// Token: 0x04014A85 RID: 84613
		internal static int __PropertyOffset_47;

		// Token: 0x04014A86 RID: 84614
		internal static int __PropertyOffset_48;

		// Token: 0x04014A87 RID: 84615
		internal static int __PropertyOffset_49;

		// Token: 0x04014A88 RID: 84616
		[Nullable(2)]
		private FSoftObjectPath _抛物瞄准模式样条特效;

		// Token: 0x04014A89 RID: 84617
		internal static int __PropertyOffset_50;

		// Token: 0x04014A8A RID: 84618
		[Nullable(2)]
		private FSoftObjectPath _抛物瞄准模式终点特效;

		// Token: 0x04014A8B RID: 84619
		internal static int __PropertyOffset_51;

		// Token: 0x04014A8C RID: 84620
		internal static int __PropertyOffset_52;

		// Token: 0x04014A8D RID: 84621
		internal static int __PropertyOffset_53;

		// Token: 0x04014A8E RID: 84622
		[Nullable(2)]
		private FSoftObjectPath _归位消失特效;

		// Token: 0x04014A8F RID: 84623
		internal static int __PropertyOffset_54;

		// Token: 0x04014A90 RID: 84624
		[Nullable(2)]
		private TMap<int, float> _投掷状态CueId;

		// Token: 0x04014A91 RID: 84625
		internal static int __PropertyOffset_55;

		// Token: 0x04014A92 RID: 84626
		internal static int __PropertyOffset_56;

		// Token: 0x04014A93 RID: 84627
		internal static int __PropertyOffset_57;
	}
}
