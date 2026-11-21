using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x020031B7 RID: 12727
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_GongduolaConfig.BP_GongduolaConfig_C")]
	[UnrealStructLayout(976, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 972)]
	public class BP_GongduolaConfig_C : BP_VehicleConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F6E1 RID: 128737 RVA: 0x0092D9A4 File Offset: 0x0092BBA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GongduolaConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_GongduolaConfig.BP_GongduolaConfig_C");
			}
			return BP_GongduolaConfig_C._ClassPtr;
		}

		// Token: 0x0601F6E2 RID: 128738 RVA: 0x0092D9C8 File Offset: 0x0092BBC8
		public BP_GongduolaConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_GongduolaConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F6E3 RID: 128739 RVA: 0x0092D9F0 File Offset: 0x0092BBF0
		[NullableContext(1)]
		public BP_GongduolaConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GongduolaConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0601F6E4 RID: 128740 RVA: 0x0092DA23 File Offset: 0x0092BC23
		// (set) Token: 0x0601F6E5 RID: 128741 RVA: 0x0092DA33 File Offset: 0x0092BC33
		public unsafe float 前进最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_前进最大移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_前进最大移动速度) = value;
			}
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0601F6E6 RID: 128742 RVA: 0x0092DA44 File Offset: 0x0092BC44
		// (set) Token: 0x0601F6E7 RID: 128743 RVA: 0x0092DA54 File Offset: 0x0092BC54
		public unsafe float 常态后退最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态后退最大移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态后退最大移动速度) = value;
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0601F6E8 RID: 128744 RVA: 0x0092DA65 File Offset: 0x0092BC65
		// (set) Token: 0x0601F6E9 RID: 128745 RVA: 0x0092DA75 File Offset: 0x0092BC75
		public unsafe float 常态前进加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态前进加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态前进加速度) = value;
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0601F6EA RID: 128746 RVA: 0x0092DA86 File Offset: 0x0092BC86
		// (set) Token: 0x0601F6EB RID: 128747 RVA: 0x0092DA96 File Offset: 0x0092BC96
		public unsafe float 常态后退加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态后退加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态后退加速度) = value;
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0601F6EC RID: 128748 RVA: 0x0092DAA7 File Offset: 0x0092BCA7
		// (set) Token: 0x0601F6ED RID: 128749 RVA: 0x0092DAB7 File Offset: 0x0092BCB7
		public unsafe float 常态刹车加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态刹车加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态刹车加速度) = value;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0601F6EE RID: 128750 RVA: 0x0092DAC8 File Offset: 0x0092BCC8
		// (set) Token: 0x0601F6EF RID: 128751 RVA: 0x0092DAD8 File Offset: 0x0092BCD8
		public unsafe float 常态最小加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最小加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最小加速度) = value;
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0601F6F0 RID: 128752 RVA: 0x0092DAE9 File Offset: 0x0092BCE9
		// (set) Token: 0x0601F6F1 RID: 128753 RVA: 0x0092DAF9 File Offset: 0x0092BCF9
		public unsafe float 常态最大转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大转向加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大转向加速度) = value;
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x0601F6F2 RID: 128754 RVA: 0x0092DB0A File Offset: 0x0092BD0A
		// (set) Token: 0x0601F6F3 RID: 128755 RVA: 0x0092DB1A File Offset: 0x0092BD1A
		public unsafe float 常态最小转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最小转向加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最小转向加速度) = value;
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0601F6F4 RID: 128756 RVA: 0x0092DB2B File Offset: 0x0092BD2B
		// (set) Token: 0x0601F6F5 RID: 128757 RVA: 0x0092DB3B File Offset: 0x0092BD3B
		public unsafe float 常态转向公式角度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向公式角度修正系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向公式角度修正系数) = value;
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0601F6F6 RID: 128758 RVA: 0x0092DB4C File Offset: 0x0092BD4C
		// (set) Token: 0x0601F6F7 RID: 128759 RVA: 0x0092DB5C File Offset: 0x0092BD5C
		public unsafe float 常态转向公式速度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向公式速度修正系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向公式速度修正系数) = value;
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0601F6F8 RID: 128760 RVA: 0x0092DB6D File Offset: 0x0092BD6D
		// (set) Token: 0x0601F6F9 RID: 128761 RVA: 0x0092DB7D File Offset: 0x0092BD7D
		public unsafe float 常态转向公式最终修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向公式最终修正系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向公式最终修正系数) = value;
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0601F6FA RID: 128762 RVA: 0x0092DB8E File Offset: 0x0092BD8E
		// (set) Token: 0x0601F6FB RID: 128763 RVA: 0x0092DB9E File Offset: 0x0092BD9E
		public unsafe float 常态径向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态径向运动摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态径向运动摩擦力) = value;
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0601F6FC RID: 128764 RVA: 0x0092DBAF File Offset: 0x0092BDAF
		// (set) Token: 0x0601F6FD RID: 128765 RVA: 0x0092DBBF File Offset: 0x0092BDBF
		public unsafe float 常态横向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态横向运动摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态横向运动摩擦力) = value;
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0601F6FE RID: 128766 RVA: 0x0092DBD0 File Offset: 0x0092BDD0
		// (set) Token: 0x0601F6FF RID: 128767 RVA: 0x0092DBE0 File Offset: 0x0092BDE0
		public unsafe float 常态最大转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大转向速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大转向速度) = value;
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0601F700 RID: 128768 RVA: 0x0092DBF1 File Offset: 0x0092BDF1
		// (set) Token: 0x0601F701 RID: 128769 RVA: 0x0092DC01 File Offset: 0x0092BE01
		public unsafe float 常态转向摩擦力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向摩擦力系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向摩擦力系数) = value;
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0601F702 RID: 128770 RVA: 0x0092DC12 File Offset: 0x0092BE12
		// (set) Token: 0x0601F703 RID: 128771 RVA: 0x0092DC22 File Offset: 0x0092BE22
		public unsafe float 常态转向静止摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向静止摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向静止摩擦力) = value;
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0601F704 RID: 128772 RVA: 0x0092DC33 File Offset: 0x0092BE33
		// (set) Token: 0x0601F705 RID: 128773 RVA: 0x0092DC43 File Offset: 0x0092BE43
		public unsafe float 冲刺超限持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺超限持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺超限持续时间) = value;
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0601F706 RID: 128774 RVA: 0x0092DC54 File Offset: 0x0092BE54
		// (set) Token: 0x0601F707 RID: 128775 RVA: 0x0092DC64 File Offset: 0x0092BE64
		public unsafe float 冲刺超限移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺超限移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺超限移动速度) = value;
			}
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0601F708 RID: 128776 RVA: 0x0092DC75 File Offset: 0x0092BE75
		// (set) Token: 0x0601F709 RID: 128777 RVA: 0x0092DC85 File Offset: 0x0092BE85
		public unsafe float 冲刺最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大移动速度) = value;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0601F70A RID: 128778 RVA: 0x0092DC96 File Offset: 0x0092BE96
		// (set) Token: 0x0601F70B RID: 128779 RVA: 0x0092DCA6 File Offset: 0x0092BEA6
		public unsafe float 冲刺后退最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺后退最大移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺后退最大移动速度) = value;
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0601F70C RID: 128780 RVA: 0x0092DCB7 File Offset: 0x0092BEB7
		// (set) Token: 0x0601F70D RID: 128781 RVA: 0x0092DCC7 File Offset: 0x0092BEC7
		public unsafe float 冲刺停止速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺停止速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺停止速度) = value;
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0601F70E RID: 128782 RVA: 0x0092DCD8 File Offset: 0x0092BED8
		// (set) Token: 0x0601F70F RID: 128783 RVA: 0x0092DCE8 File Offset: 0x0092BEE8
		public unsafe float 冲刺前进加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺前进加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺前进加速度) = value;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0601F710 RID: 128784 RVA: 0x0092DCF9 File Offset: 0x0092BEF9
		// (set) Token: 0x0601F711 RID: 128785 RVA: 0x0092DD09 File Offset: 0x0092BF09
		public unsafe float 冲刺刹车加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺刹车加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺刹车加速度) = value;
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0601F712 RID: 128786 RVA: 0x0092DD1A File Offset: 0x0092BF1A
		// (set) Token: 0x0601F713 RID: 128787 RVA: 0x0092DD2A File Offset: 0x0092BF2A
		public unsafe float 冲刺后退加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺后退加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺后退加速度) = value;
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0601F714 RID: 128788 RVA: 0x0092DD3B File Offset: 0x0092BF3B
		// (set) Token: 0x0601F715 RID: 128789 RVA: 0x0092DD4B File Offset: 0x0092BF4B
		public unsafe float 冲刺最小加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最小加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最小加速度) = value;
			}
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0601F716 RID: 128790 RVA: 0x0092DD5C File Offset: 0x0092BF5C
		// (set) Token: 0x0601F717 RID: 128791 RVA: 0x0092DD6C File Offset: 0x0092BF6C
		public unsafe float 冲刺最大转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大转向加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大转向加速度) = value;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0601F718 RID: 128792 RVA: 0x0092DD7D File Offset: 0x0092BF7D
		// (set) Token: 0x0601F719 RID: 128793 RVA: 0x0092DD8D File Offset: 0x0092BF8D
		public unsafe float 冲刺最小转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最小转向加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最小转向加速度) = value;
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0601F71A RID: 128794 RVA: 0x0092DD9E File Offset: 0x0092BF9E
		// (set) Token: 0x0601F71B RID: 128795 RVA: 0x0092DDAE File Offset: 0x0092BFAE
		public unsafe float 冲刺转向公式角度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向公式角度修正系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向公式角度修正系数) = value;
			}
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0601F71C RID: 128796 RVA: 0x0092DDBF File Offset: 0x0092BFBF
		// (set) Token: 0x0601F71D RID: 128797 RVA: 0x0092DDCF File Offset: 0x0092BFCF
		public unsafe float 冲刺转向公式速度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向公式速度修正系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向公式速度修正系数) = value;
			}
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0601F71E RID: 128798 RVA: 0x0092DDE0 File Offset: 0x0092BFE0
		// (set) Token: 0x0601F71F RID: 128799 RVA: 0x0092DDF0 File Offset: 0x0092BFF0
		public unsafe float 冲刺转向公式最终修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向公式最终修正系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向公式最终修正系数) = value;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0601F720 RID: 128800 RVA: 0x0092DE01 File Offset: 0x0092C001
		// (set) Token: 0x0601F721 RID: 128801 RVA: 0x0092DE11 File Offset: 0x0092C011
		public unsafe float 冲刺径向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺径向运动摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺径向运动摩擦力) = value;
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0601F722 RID: 128802 RVA: 0x0092DE22 File Offset: 0x0092C022
		// (set) Token: 0x0601F723 RID: 128803 RVA: 0x0092DE32 File Offset: 0x0092C032
		public unsafe float 冲刺横向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺横向运动摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺横向运动摩擦力) = value;
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0601F724 RID: 128804 RVA: 0x0092DE43 File Offset: 0x0092C043
		// (set) Token: 0x0601F725 RID: 128805 RVA: 0x0092DE53 File Offset: 0x0092C053
		public unsafe float 冲刺最大转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大转向速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大转向速度) = value;
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0601F726 RID: 128806 RVA: 0x0092DE64 File Offset: 0x0092C064
		// (set) Token: 0x0601F727 RID: 128807 RVA: 0x0092DE74 File Offset: 0x0092C074
		public unsafe float 冲刺转向摩擦力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向摩擦力系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向摩擦力系数) = value;
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0601F728 RID: 128808 RVA: 0x0092DE85 File Offset: 0x0092C085
		// (set) Token: 0x0601F729 RID: 128809 RVA: 0x0092DE95 File Offset: 0x0092C095
		public unsafe float 冲刺转向静止摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向静止摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向静止摩擦力) = value;
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0601F72A RID: 128810 RVA: 0x0092DEA6 File Offset: 0x0092C0A6
		// (set) Token: 0x0601F72B RID: 128811 RVA: 0x0092DEB6 File Offset: 0x0092C0B6
		public unsafe float 超出最大速度时的额外摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_超出最大速度时的额外摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_超出最大速度时的额外摩擦力) = value;
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0601F72C RID: 128812 RVA: 0x0092DEC7 File Offset: 0x0092C0C7
		// (set) Token: 0x0601F72D RID: 128813 RVA: 0x0092DED7 File Offset: 0x0092C0D7
		public unsafe float 冲刺固定前向输入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺固定前向输入时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺固定前向输入时间) = value;
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0601F72E RID: 128814 RVA: 0x0092DEE8 File Offset: 0x0092C0E8
		// (set) Token: 0x0601F72F RID: 128815 RVA: 0x0092DEF8 File Offset: 0x0092C0F8
		public unsafe float 最大上浮速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_最大上浮速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_最大上浮速度) = value;
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0601F730 RID: 128816 RVA: 0x0092DF09 File Offset: 0x0092C109
		// (set) Token: 0x0601F731 RID: 128817 RVA: 0x0092DF19 File Offset: 0x0092C119
		public unsafe float 浮力平衡位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_浮力平衡位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_浮力平衡位置) = value;
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0601F732 RID: 128818 RVA: 0x0092DF2A File Offset: 0x0092C12A
		// (set) Token: 0x0601F733 RID: 128819 RVA: 0x0092DF3A File Offset: 0x0092C13A
		public unsafe float 搁浅位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_搁浅位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_搁浅位置) = value;
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0601F734 RID: 128820 RVA: 0x0092DF4B File Offset: 0x0092C14B
		// (set) Token: 0x0601F735 RID: 128821 RVA: 0x0092DF5B File Offset: 0x0092C15B
		public unsafe float 漂浮阻力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_漂浮阻力系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_漂浮阻力系数) = value;
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0601F736 RID: 128822 RVA: 0x0092DF6C File Offset: 0x0092C16C
		// (set) Token: 0x0601F737 RID: 128823 RVA: 0x0092DF7C File Offset: 0x0092C17C
		public unsafe float 转动惯量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_转动惯量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_转动惯量) = value;
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0601F738 RID: 128824 RVA: 0x0092DF8D File Offset: 0x0092C18D
		// (set) Token: 0x0601F739 RID: 128825 RVA: 0x0092DF9D File Offset: 0x0092C19D
		public unsafe float 速度冲击力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_速度冲击力系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_速度冲击力系数) = value;
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0601F73A RID: 128826 RVA: 0x0092DFAE File Offset: 0x0092C1AE
		// (set) Token: 0x0601F73B RID: 128827 RVA: 0x0092DFBE File Offset: 0x0092C1BE
		public unsafe float 旋转冲击力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_旋转冲击力系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_旋转冲击力系数) = value;
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0601F73C RID: 128828 RVA: 0x0092DFCF File Offset: 0x0092C1CF
		// (set) Token: 0x0601F73D RID: 128829 RVA: 0x0092DFDF File Offset: 0x0092C1DF
		public unsafe float 常态转向强制前向输入系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向强制前向输入系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态转向强制前向输入系数) = value;
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0601F73E RID: 128830 RVA: 0x0092DFF0 File Offset: 0x0092C1F0
		// (set) Token: 0x0601F73F RID: 128831 RVA: 0x0092E000 File Offset: 0x0092C200
		public unsafe float 冲刺转向强制前向输入系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向强制前向输入系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺转向强制前向输入系数) = value;
			}
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0601F740 RID: 128832 RVA: 0x0092E011 File Offset: 0x0092C211
		// (set) Token: 0x0601F741 RID: 128833 RVA: 0x0092E021 File Offset: 0x0092C221
		public unsafe float 常态最大前后输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大前后输入阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大前后输入阈值) = value;
			}
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0601F742 RID: 128834 RVA: 0x0092E032 File Offset: 0x0092C232
		// (set) Token: 0x0601F743 RID: 128835 RVA: 0x0092E042 File Offset: 0x0092C242
		public unsafe float 常态最大左右输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大左右输入阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_常态最大左右输入阈值) = value;
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0601F744 RID: 128836 RVA: 0x0092E053 File Offset: 0x0092C253
		// (set) Token: 0x0601F745 RID: 128837 RVA: 0x0092E063 File Offset: 0x0092C263
		public unsafe float 冲刺最大前后输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大前后输入阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大前后输入阈值) = value;
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0601F746 RID: 128838 RVA: 0x0092E074 File Offset: 0x0092C274
		// (set) Token: 0x0601F747 RID: 128839 RVA: 0x0092E084 File Offset: 0x0092C284
		public unsafe float 冲刺最大左右输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大左右输入阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大左右输入阈值) = value;
			}
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0601F748 RID: 128840 RVA: 0x0092E095 File Offset: 0x0092C295
		// (set) Token: 0x0601F749 RID: 128841 RVA: 0x0092E0A5 File Offset: 0x0092C2A5
		public unsafe float 冲刺持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺持续时间) = value;
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0601F74A RID: 128842 RVA: 0x0092E0B6 File Offset: 0x0092C2B6
		// (set) Token: 0x0601F74B RID: 128843 RVA: 0x0092E0C6 File Offset: 0x0092C2C6
		public unsafe float 冲刺冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺冷却时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺冷却时间) = value;
			}
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0601F74C RID: 128844 RVA: 0x0092E0D7 File Offset: 0x0092C2D7
		// (set) Token: 0x0601F74D RID: 128845 RVA: 0x0092E0E7 File Offset: 0x0092C2E7
		public unsafe int 冲刺最大使用次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大使用次数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_冲刺最大使用次数) = value;
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0601F74E RID: 128846 RVA: 0x0092E0F8 File Offset: 0x0092C2F8
		// (set) Token: 0x0601F74F RID: 128847 RVA: 0x0092E108 File Offset: 0x0092C308
		public unsafe float 前向转弯最小X输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_前向转弯最小X输入);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_前向转弯最小X输入) = value;
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0601F750 RID: 128848 RVA: 0x0092E119 File Offset: 0x0092C319
		// (set) Token: 0x0601F751 RID: 128849 RVA: 0x0092E129 File Offset: 0x0092C329
		public unsafe float 后向转向最大X输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_后向转向最大X输入);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_后向转向最大X输入) = value;
			}
		}

		// Token: 0x0601F752 RID: 128850 RVA: 0x0092E13A File Offset: 0x0092C33A
		protected BP_GongduolaConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DAB RID: 69035
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_GongduolaConfig.BP_GongduolaConfig_C";

		// Token: 0x04010DAC RID: 69036
		private static IntPtr _ClassPtr;

		// Token: 0x04010DAD RID: 69037
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DAE RID: 69038
		internal static int __PropertyOffset_前进最大移动速度;

		// Token: 0x04010DAF RID: 69039
		internal static int __PropertyOffset_常态后退最大移动速度;

		// Token: 0x04010DB0 RID: 69040
		internal static int __PropertyOffset_常态前进加速度;

		// Token: 0x04010DB1 RID: 69041
		internal static int __PropertyOffset_常态后退加速度;

		// Token: 0x04010DB2 RID: 69042
		internal static int __PropertyOffset_常态刹车加速度;

		// Token: 0x04010DB3 RID: 69043
		internal static int __PropertyOffset_常态最小加速度;

		// Token: 0x04010DB4 RID: 69044
		internal static int __PropertyOffset_常态最大转向加速度;

		// Token: 0x04010DB5 RID: 69045
		internal static int __PropertyOffset_常态最小转向加速度;

		// Token: 0x04010DB6 RID: 69046
		internal static int __PropertyOffset_常态转向公式角度修正系数;

		// Token: 0x04010DB7 RID: 69047
		internal static int __PropertyOffset_常态转向公式速度修正系数;

		// Token: 0x04010DB8 RID: 69048
		internal static int __PropertyOffset_常态转向公式最终修正系数;

		// Token: 0x04010DB9 RID: 69049
		internal static int __PropertyOffset_常态径向运动摩擦力;

		// Token: 0x04010DBA RID: 69050
		internal static int __PropertyOffset_常态横向运动摩擦力;

		// Token: 0x04010DBB RID: 69051
		internal static int __PropertyOffset_常态最大转向速度;

		// Token: 0x04010DBC RID: 69052
		internal static int __PropertyOffset_常态转向摩擦力系数;

		// Token: 0x04010DBD RID: 69053
		internal static int __PropertyOffset_常态转向静止摩擦力;

		// Token: 0x04010DBE RID: 69054
		internal static int __PropertyOffset_冲刺超限持续时间;

		// Token: 0x04010DBF RID: 69055
		internal static int __PropertyOffset_冲刺超限移动速度;

		// Token: 0x04010DC0 RID: 69056
		internal static int __PropertyOffset_冲刺最大移动速度;

		// Token: 0x04010DC1 RID: 69057
		internal static int __PropertyOffset_冲刺后退最大移动速度;

		// Token: 0x04010DC2 RID: 69058
		internal static int __PropertyOffset_冲刺停止速度;

		// Token: 0x04010DC3 RID: 69059
		internal static int __PropertyOffset_冲刺前进加速度;

		// Token: 0x04010DC4 RID: 69060
		internal static int __PropertyOffset_冲刺刹车加速度;

		// Token: 0x04010DC5 RID: 69061
		internal static int __PropertyOffset_冲刺后退加速度;

		// Token: 0x04010DC6 RID: 69062
		internal static int __PropertyOffset_冲刺最小加速度;

		// Token: 0x04010DC7 RID: 69063
		internal static int __PropertyOffset_冲刺最大转向加速度;

		// Token: 0x04010DC8 RID: 69064
		internal static int __PropertyOffset_冲刺最小转向加速度;

		// Token: 0x04010DC9 RID: 69065
		internal static int __PropertyOffset_冲刺转向公式角度修正系数;

		// Token: 0x04010DCA RID: 69066
		internal static int __PropertyOffset_冲刺转向公式速度修正系数;

		// Token: 0x04010DCB RID: 69067
		internal static int __PropertyOffset_冲刺转向公式最终修正系数;

		// Token: 0x04010DCC RID: 69068
		internal static int __PropertyOffset_冲刺径向运动摩擦力;

		// Token: 0x04010DCD RID: 69069
		internal static int __PropertyOffset_冲刺横向运动摩擦力;

		// Token: 0x04010DCE RID: 69070
		internal static int __PropertyOffset_冲刺最大转向速度;

		// Token: 0x04010DCF RID: 69071
		internal static int __PropertyOffset_冲刺转向摩擦力系数;

		// Token: 0x04010DD0 RID: 69072
		internal static int __PropertyOffset_冲刺转向静止摩擦力;

		// Token: 0x04010DD1 RID: 69073
		internal static int __PropertyOffset_超出最大速度时的额外摩擦力;

		// Token: 0x04010DD2 RID: 69074
		internal static int __PropertyOffset_冲刺固定前向输入时间;

		// Token: 0x04010DD3 RID: 69075
		internal static int __PropertyOffset_最大上浮速度;

		// Token: 0x04010DD4 RID: 69076
		internal static int __PropertyOffset_浮力平衡位置;

		// Token: 0x04010DD5 RID: 69077
		internal static int __PropertyOffset_搁浅位置;

		// Token: 0x04010DD6 RID: 69078
		internal static int __PropertyOffset_漂浮阻力系数;

		// Token: 0x04010DD7 RID: 69079
		internal static int __PropertyOffset_转动惯量;

		// Token: 0x04010DD8 RID: 69080
		internal static int __PropertyOffset_速度冲击力系数;

		// Token: 0x04010DD9 RID: 69081
		internal static int __PropertyOffset_旋转冲击力系数;

		// Token: 0x04010DDA RID: 69082
		internal static int __PropertyOffset_常态转向强制前向输入系数;

		// Token: 0x04010DDB RID: 69083
		internal static int __PropertyOffset_冲刺转向强制前向输入系数;

		// Token: 0x04010DDC RID: 69084
		internal static int __PropertyOffset_常态最大前后输入阈值;

		// Token: 0x04010DDD RID: 69085
		internal static int __PropertyOffset_常态最大左右输入阈值;

		// Token: 0x04010DDE RID: 69086
		internal static int __PropertyOffset_冲刺最大前后输入阈值;

		// Token: 0x04010DDF RID: 69087
		internal static int __PropertyOffset_冲刺最大左右输入阈值;

		// Token: 0x04010DE0 RID: 69088
		internal static int __PropertyOffset_冲刺持续时间;

		// Token: 0x04010DE1 RID: 69089
		internal static int __PropertyOffset_冲刺冷却时间;

		// Token: 0x04010DE2 RID: 69090
		internal static int __PropertyOffset_冲刺最大使用次数;

		// Token: 0x04010DE3 RID: 69091
		internal static int __PropertyOffset_前向转弯最小X输入;

		// Token: 0x04010DE4 RID: 69092
		internal static int __PropertyOffset_后向转向最大X输入;
	}
}
