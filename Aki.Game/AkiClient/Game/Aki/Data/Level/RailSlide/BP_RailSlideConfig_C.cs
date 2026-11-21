using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.RailSlide
{
	// Token: 0x020031C4 RID: 12740
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/RailSlide/BP_RailSlideConfig.BP_RailSlideConfig_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 335)]
	public class BP_RailSlideConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F82E RID: 129070 RVA: 0x0092F68F File Offset: 0x0092D88F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RailSlideConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/RailSlide/BP_RailSlideConfig.BP_RailSlideConfig_C");
			}
			return BP_RailSlideConfig_C._ClassPtr;
		}

		// Token: 0x0601F82F RID: 129071 RVA: 0x0092F6B4 File Offset: 0x0092D8B4
		public BP_RailSlideConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F830 RID: 129072 RVA: 0x0092F6DC File Offset: 0x0092D8DC
		public BP_RailSlideConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0601F831 RID: 129073 RVA: 0x0092F70F File Offset: 0x0092D90F
		// (set) Token: 0x0601F832 RID: 129074 RVA: 0x0092F71F File Offset: 0x0092D91F
		public unsafe int 初始速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_初始速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_初始速度) = value;
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0601F833 RID: 129075 RVA: 0x0092F730 File Offset: 0x0092D930
		// (set) Token: 0x0601F834 RID: 129076 RVA: 0x0092F740 File Offset: 0x0092D940
		public unsafe int 基础目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础目标速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础目标速度) = value;
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0601F835 RID: 129077 RVA: 0x0092F751 File Offset: 0x0092D951
		// (set) Token: 0x0601F836 RID: 129078 RVA: 0x0092F761 File Offset: 0x0092D961
		public unsafe int 基础加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础加速度) = value;
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0601F837 RID: 129079 RVA: 0x0092F772 File Offset: 0x0092D972
		// (set) Token: 0x0601F838 RID: 129080 RVA: 0x0092F782 File Offset: 0x0092D982
		public unsafe int 上坡目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_上坡目标速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_上坡目标速度) = value;
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0601F839 RID: 129081 RVA: 0x0092F793 File Offset: 0x0092D993
		// (set) Token: 0x0601F83A RID: 129082 RVA: 0x0092F7A3 File Offset: 0x0092D9A3
		public unsafe int 上坡加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_上坡加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_上坡加速度) = value;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0601F83B RID: 129083 RVA: 0x0092F7B4 File Offset: 0x0092D9B4
		// (set) Token: 0x0601F83C RID: 129084 RVA: 0x0092F7C4 File Offset: 0x0092D9C4
		public unsafe int 下坡目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_下坡目标速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_下坡目标速度) = value;
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0601F83D RID: 129085 RVA: 0x0092F7D5 File Offset: 0x0092D9D5
		// (set) Token: 0x0601F83E RID: 129086 RVA: 0x0092F7E5 File Offset: 0x0092D9E5
		public unsafe int 下坡加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_下坡加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_下坡加速度) = value;
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0601F83F RID: 129087 RVA: 0x0092F7F6 File Offset: 0x0092D9F6
		// (set) Token: 0x0601F840 RID: 129088 RVA: 0x0092F806 File Offset: 0x0092DA06
		public unsafe int 基础跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础跳跃高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础跳跃高度) = value;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0601F841 RID: 129089 RVA: 0x0092F817 File Offset: 0x0092DA17
		// (set) Token: 0x0601F842 RID: 129090 RVA: 0x0092F827 File Offset: 0x0092DA27
		public unsafe float 基础跳远倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础跳远倍率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_基础跳远倍率) = value;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0601F843 RID: 129091 RVA: 0x0092F838 File Offset: 0x0092DA38
		// (set) Token: 0x0601F844 RID: 129092 RVA: 0x0092F848 File Offset: 0x0092DA48
		public unsafe int 最大跳跃距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大跳跃距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大跳跃距离) = value;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0601F845 RID: 129093 RVA: 0x0092F859 File Offset: 0x0092DA59
		// (set) Token: 0x0601F846 RID: 129094 RVA: 0x0092F869 File Offset: 0x0092DA69
		public unsafe int 最大跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大跳跃高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大跳跃高度) = value;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0601F847 RID: 129095 RVA: 0x0092F87A File Offset: 0x0092DA7A
		// (set) Token: 0x0601F848 RID: 129096 RVA: 0x0092F88A File Offset: 0x0092DA8A
		public unsafe int 起跳加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳加速度) = value;
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0601F849 RID: 129097 RVA: 0x0092F89B File Offset: 0x0092DA9B
		// (set) Token: 0x0601F84A RID: 129098 RVA: 0x0092F8AB File Offset: 0x0092DAAB
		public unsafe int 起跳加速度_卡提西亚
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳加速度_卡提西亚);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳加速度_卡提西亚) = value;
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0601F84B RID: 129099 RVA: 0x0092F8BC File Offset: 0x0092DABC
		// (set) Token: 0x0601F84C RID: 129100 RVA: 0x0092F8CC File Offset: 0x0092DACC
		public unsafe float 倾斜输入插值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_倾斜输入插值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_倾斜输入插值) = value;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0601F84D RID: 129101 RVA: 0x0092F8DD File Offset: 0x0092DADD
		// (set) Token: 0x0601F84E RID: 129102 RVA: 0x0092F8ED File Offset: 0x0092DAED
		public unsafe int 最大倾斜角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大倾斜角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大倾斜角度) = value;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0601F84F RID: 129103 RVA: 0x0092F8FE File Offset: 0x0092DAFE
		// (set) Token: 0x0601F850 RID: 129104 RVA: 0x0092F90E File Offset: 0x0092DB0E
		public unsafe int 初始进入轨道速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_初始进入轨道速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_初始进入轨道速度) = value;
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0601F851 RID: 129105 RVA: 0x0092F91F File Offset: 0x0092DB1F
		// (set) Token: 0x0601F852 RID: 129106 RVA: 0x0092F92F File Offset: 0x0092DB2F
		public unsafe int 切换轨道CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道CD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道CD) = value;
			}
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0601F853 RID: 129107 RVA: 0x0092F940 File Offset: 0x0092DB40
		// (set) Token: 0x0601F854 RID: 129108 RVA: 0x0092F950 File Offset: 0x0092DB50
		public unsafe int 切换轨道水平距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道水平距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道水平距离) = value;
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0601F855 RID: 129109 RVA: 0x0092F961 File Offset: 0x0092DB61
		// (set) Token: 0x0601F856 RID: 129110 RVA: 0x0092F971 File Offset: 0x0092DB71
		public unsafe int 切换轨道垂直距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道垂直距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道垂直距离) = value;
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0601F857 RID: 129111 RVA: 0x0092F982 File Offset: 0x0092DB82
		// (set) Token: 0x0601F858 RID: 129112 RVA: 0x0092F992 File Offset: 0x0092DB92
		public unsafe int 最大加速度角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大加速度角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_最大加速度角度) = value;
			}
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0601F859 RID: 129113 RVA: 0x0092F9A3 File Offset: 0x0092DBA3
		// (set) Token: 0x0601F85A RID: 129114 RVA: 0x0092F9B3 File Offset: 0x0092DBB3
		public unsafe int 起跳目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳目标速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳目标速度) = value;
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0601F85B RID: 129115 RVA: 0x0092F9C4 File Offset: 0x0092DBC4
		// (set) Token: 0x0601F85C RID: 129116 RVA: 0x0092F9D4 File Offset: 0x0092DBD4
		public unsafe int 切换轨道基速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道基速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_切换轨道基速度) = value;
			}
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0601F85D RID: 129117 RVA: 0x0092F9E8 File Offset: 0x0092DBE8
		// (set) Token: 0x0601F85E RID: 129118 RVA: 0x0092FA21 File Offset: 0x0092DC21
		public SFloatCurve 位移曲线
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._位移曲线) == null)
				{
					result = (this._位移曲线 = new SFloatCurve(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_位移曲线, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_位移曲线, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0601F85F RID: 129119 RVA: 0x0092FA44 File Offset: 0x0092DC44
		// (set) Token: 0x0601F860 RID: 129120 RVA: 0x0092FA7D File Offset: 0x0092DC7D
		public SFloatCurve 位移曲线_卡提西亚
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._位移曲线_卡提西亚) == null)
				{
					result = (this._位移曲线_卡提西亚 = new SFloatCurve(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_位移曲线_卡提西亚, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_位移曲线_卡提西亚, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0601F861 RID: 129121 RVA: 0x0092FA9E File Offset: 0x0092DC9E
		// (set) Token: 0x0601F862 RID: 129122 RVA: 0x0092FAAE File Offset: 0x0092DCAE
		public unsafe int 限制输入角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_限制输入角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_限制输入角度) = value;
			}
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0601F863 RID: 129123 RVA: 0x0092FAC0 File Offset: 0x0092DCC0
		// (set) Token: 0x0601F864 RID: 129124 RVA: 0x0092FAF9 File Offset: 0x0092DCF9
		public FGameplayTagContainer 期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._期间Tag) == null)
				{
					result = (this._期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_期间Tag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_期间Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0601F865 RID: 129125 RVA: 0x0092FB1A File Offset: 0x0092DD1A
		// (set) Token: 0x0601F866 RID: 129126 RVA: 0x0092FB2A File Offset: 0x0092DD2A
		public unsafe int 落地最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地最大速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地最大速度) = value;
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0601F867 RID: 129127 RVA: 0x0092FB3B File Offset: 0x0092DD3B
		// (set) Token: 0x0601F868 RID: 129128 RVA: 0x0092FB4B File Offset: 0x0092DD4B
		public unsafe int 落地最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地最小速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地最小速度) = value;
			}
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0601F869 RID: 129129 RVA: 0x0092FB5C File Offset: 0x0092DD5C
		// (set) Token: 0x0601F86A RID: 129130 RVA: 0x0092FB95 File Offset: 0x0092DD95
		public TArray<int> 打断技能列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._打断技能列表) == null)
				{
					result = (this._打断技能列表 = new TArray<int>(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_打断技能列表, this));
				}
				return result;
			}
			set
			{
				this.打断技能列表.CopyAssign(value);
			}
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0601F86B RID: 129131 RVA: 0x0092FBA3 File Offset: 0x0092DDA3
		// (set) Token: 0x0601F86C RID: 129132 RVA: 0x0092FBB3 File Offset: 0x0092DDB3
		public unsafe int 起跳时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳时长) = value;
			}
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0601F86D RID: 129133 RVA: 0x0092FBC4 File Offset: 0x0092DDC4
		// (set) Token: 0x0601F86E RID: 129134 RVA: 0x0092FBD4 File Offset: 0x0092DDD4
		public unsafe int 起跳时长_卡提西亚
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳时长_卡提西亚);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_起跳时长_卡提西亚) = value;
			}
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0601F86F RID: 129135 RVA: 0x0092FBE5 File Offset: 0x0092DDE5
		// (set) Token: 0x0601F870 RID: 129136 RVA: 0x0092FBF5 File Offset: 0x0092DDF5
		public unsafe int 落地时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地时长) = value;
			}
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0601F871 RID: 129137 RVA: 0x0092FC06 File Offset: 0x0092DE06
		// (set) Token: 0x0601F872 RID: 129138 RVA: 0x0092FC16 File Offset: 0x0092DE16
		public unsafe int 落地时长_卡提西亚
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地时长_卡提西亚);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_落地时长_卡提西亚) = value;
			}
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0601F873 RID: 129139 RVA: 0x0092FC27 File Offset: 0x0092DE27
		// (set) Token: 0x0601F874 RID: 129140 RVA: 0x0092FC37 File Offset: 0x0092DE37
		public unsafe int 跳跃空中总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_跳跃空中总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_跳跃空中总时长) = value;
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0601F875 RID: 129141 RVA: 0x0092FC48 File Offset: 0x0092DE48
		// (set) Token: 0x0601F876 RID: 129142 RVA: 0x0092FC58 File Offset: 0x0092DE58
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_DebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0601F877 RID: 129143 RVA: 0x0092FC69 File Offset: 0x0092DE69
		// (set) Token: 0x0601F878 RID: 129144 RVA: 0x0092FC79 File Offset: 0x0092DE79
		public unsafe int 前向基础跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向基础跳跃高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向基础跳跃高度) = value;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0601F879 RID: 129145 RVA: 0x0092FC8A File Offset: 0x0092DE8A
		// (set) Token: 0x0601F87A RID: 129146 RVA: 0x0092FC9A File Offset: 0x0092DE9A
		public unsafe float 前向基础跳远倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向基础跳远倍率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向基础跳远倍率) = value;
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0601F87B RID: 129147 RVA: 0x0092FCAB File Offset: 0x0092DEAB
		// (set) Token: 0x0601F87C RID: 129148 RVA: 0x0092FCBB File Offset: 0x0092DEBB
		public unsafe int 前向最大跳跃距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向最大跳跃距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向最大跳跃距离) = value;
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0601F87D RID: 129149 RVA: 0x0092FCCC File Offset: 0x0092DECC
		// (set) Token: 0x0601F87E RID: 129150 RVA: 0x0092FCDC File Offset: 0x0092DEDC
		public unsafe int 前向最大跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向最大跳跃高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向最大跳跃高度) = value;
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0601F87F RID: 129151 RVA: 0x0092FCED File Offset: 0x0092DEED
		// (set) Token: 0x0601F880 RID: 129152 RVA: 0x0092FCFD File Offset: 0x0092DEFD
		public unsafe int 前向起跳加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向起跳加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向起跳加速度) = value;
			}
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0601F881 RID: 129153 RVA: 0x0092FD0E File Offset: 0x0092DF0E
		// (set) Token: 0x0601F882 RID: 129154 RVA: 0x0092FD1E File Offset: 0x0092DF1E
		public unsafe int 前向起跳目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向起跳目标速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向起跳目标速度) = value;
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0601F883 RID: 129155 RVA: 0x0092FD2F File Offset: 0x0092DF2F
		// (set) Token: 0x0601F884 RID: 129156 RVA: 0x0092FD3F File Offset: 0x0092DF3F
		public unsafe int 前向跳跃空中总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向跳跃空中总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向跳跃空中总时长) = value;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0601F885 RID: 129157 RVA: 0x0092FD50 File Offset: 0x0092DF50
		// (set) Token: 0x0601F886 RID: 129158 RVA: 0x0092FD60 File Offset: 0x0092DF60
		public unsafe int 前向起跳时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向起跳时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向起跳时长) = value;
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0601F887 RID: 129159 RVA: 0x0092FD71 File Offset: 0x0092DF71
		// (set) Token: 0x0601F888 RID: 129160 RVA: 0x0092FD81 File Offset: 0x0092DF81
		public unsafe int 前向落地时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向落地时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_前向落地时长) = value;
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0601F889 RID: 129161 RVA: 0x0092FD92 File Offset: 0x0092DF92
		// (set) Token: 0x0601F88A RID: 129162 RVA: 0x0092FDA2 File Offset: 0x0092DFA2
		public unsafe bool 是否有落地动画
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_是否有落地动画) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_是否有落地动画) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0601F88B RID: 129163 RVA: 0x0092FDB3 File Offset: 0x0092DFB3
		// (set) Token: 0x0601F88C RID: 129164 RVA: 0x0092FDC3 File Offset: 0x0092DFC3
		public unsafe bool 是否启用定制动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_是否启用定制动作) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_是否启用定制动作) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0601F88D RID: 129165 RVA: 0x0092FDD4 File Offset: 0x0092DFD4
		// (set) Token: 0x0601F88E RID: 129166 RVA: 0x0092FDE4 File Offset: 0x0092DFE4
		public unsafe bool DebugDraw_Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_DebugDraw_Control) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_DebugDraw_Control) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0601F88F RID: 129167 RVA: 0x0092FDF5 File Offset: 0x0092DFF5
		// (set) Token: 0x0601F890 RID: 129168 RVA: 0x0092FE09 File Offset: 0x0092E009
		public unsafe SRailSlideControlConfig 横向控制参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_横向控制参数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_横向控制参数) = value;
			}
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0601F891 RID: 129169 RVA: 0x0092FE1E File Offset: 0x0092E01E
		// (set) Token: 0x0601F892 RID: 129170 RVA: 0x0092FE2E File Offset: 0x0092E02E
		public unsafe ERailSlideAnimType 滑轨动画类型
		{
			get
			{
				return (ERailSlideAnimType)(*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_滑轨动画类型));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_滑轨动画类型) = (byte)value;
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0601F893 RID: 129171 RVA: 0x0092FE3F File Offset: 0x0092E03F
		// (set) Token: 0x0601F894 RID: 129172 RVA: 0x0092FE4F File Offset: 0x0092E04F
		public unsafe bool 禁止重力方向倾斜
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_禁止重力方向倾斜) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_禁止重力方向倾斜) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0601F895 RID: 129173 RVA: 0x0092FE60 File Offset: 0x0092E060
		// (set) Token: 0x0601F896 RID: 129174 RVA: 0x0092FE70 File Offset: 0x0092E070
		public unsafe bool 禁止前后俯仰倾斜
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_禁止前后俯仰倾斜) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_禁止前后俯仰倾斜) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F897 RID: 129175 RVA: 0x0092FE81 File Offset: 0x0092E081
		protected BP_RailSlideConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E6E RID: 69230
		public new const string __ObjectPath = "/Game/Aki/Data/Level/RailSlide/BP_RailSlideConfig.BP_RailSlideConfig_C";

		// Token: 0x04010E6F RID: 69231
		private static IntPtr _ClassPtr;

		// Token: 0x04010E70 RID: 69232
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E71 RID: 69233
		internal static int __PropertyOffset_初始速度;

		// Token: 0x04010E72 RID: 69234
		internal static int __PropertyOffset_基础目标速度;

		// Token: 0x04010E73 RID: 69235
		internal static int __PropertyOffset_基础加速度;

		// Token: 0x04010E74 RID: 69236
		internal static int __PropertyOffset_上坡目标速度;

		// Token: 0x04010E75 RID: 69237
		internal static int __PropertyOffset_上坡加速度;

		// Token: 0x04010E76 RID: 69238
		internal static int __PropertyOffset_下坡目标速度;

		// Token: 0x04010E77 RID: 69239
		internal static int __PropertyOffset_下坡加速度;

		// Token: 0x04010E78 RID: 69240
		internal static int __PropertyOffset_基础跳跃高度;

		// Token: 0x04010E79 RID: 69241
		internal static int __PropertyOffset_基础跳远倍率;

		// Token: 0x04010E7A RID: 69242
		internal static int __PropertyOffset_最大跳跃距离;

		// Token: 0x04010E7B RID: 69243
		internal static int __PropertyOffset_最大跳跃高度;

		// Token: 0x04010E7C RID: 69244
		internal static int __PropertyOffset_起跳加速度;

		// Token: 0x04010E7D RID: 69245
		internal static int __PropertyOffset_起跳加速度_卡提西亚;

		// Token: 0x04010E7E RID: 69246
		internal static int __PropertyOffset_倾斜输入插值;

		// Token: 0x04010E7F RID: 69247
		internal static int __PropertyOffset_最大倾斜角度;

		// Token: 0x04010E80 RID: 69248
		internal static int __PropertyOffset_初始进入轨道速度;

		// Token: 0x04010E81 RID: 69249
		internal static int __PropertyOffset_切换轨道CD;

		// Token: 0x04010E82 RID: 69250
		internal static int __PropertyOffset_切换轨道水平距离;

		// Token: 0x04010E83 RID: 69251
		internal static int __PropertyOffset_切换轨道垂直距离;

		// Token: 0x04010E84 RID: 69252
		internal static int __PropertyOffset_最大加速度角度;

		// Token: 0x04010E85 RID: 69253
		internal static int __PropertyOffset_起跳目标速度;

		// Token: 0x04010E86 RID: 69254
		internal static int __PropertyOffset_切换轨道基速度;

		// Token: 0x04010E87 RID: 69255
		internal static int __PropertyOffset_位移曲线;

		// Token: 0x04010E88 RID: 69256
		[Nullable(2)]
		private SFloatCurve _位移曲线;

		// Token: 0x04010E89 RID: 69257
		internal static int __PropertyOffset_位移曲线_卡提西亚;

		// Token: 0x04010E8A RID: 69258
		[Nullable(2)]
		private SFloatCurve _位移曲线_卡提西亚;

		// Token: 0x04010E8B RID: 69259
		internal static int __PropertyOffset_限制输入角度;

		// Token: 0x04010E8C RID: 69260
		internal static int __PropertyOffset_期间Tag;

		// Token: 0x04010E8D RID: 69261
		[Nullable(2)]
		private FGameplayTagContainer _期间Tag;

		// Token: 0x04010E8E RID: 69262
		internal static int __PropertyOffset_落地最大速度;

		// Token: 0x04010E8F RID: 69263
		internal static int __PropertyOffset_落地最小速度;

		// Token: 0x04010E90 RID: 69264
		internal static int __PropertyOffset_打断技能列表;

		// Token: 0x04010E91 RID: 69265
		[Nullable(2)]
		private TArray<int> _打断技能列表;

		// Token: 0x04010E92 RID: 69266
		internal static int __PropertyOffset_起跳时长;

		// Token: 0x04010E93 RID: 69267
		internal static int __PropertyOffset_起跳时长_卡提西亚;

		// Token: 0x04010E94 RID: 69268
		internal static int __PropertyOffset_落地时长;

		// Token: 0x04010E95 RID: 69269
		internal static int __PropertyOffset_落地时长_卡提西亚;

		// Token: 0x04010E96 RID: 69270
		internal static int __PropertyOffset_跳跃空中总时长;

		// Token: 0x04010E97 RID: 69271
		internal static int __PropertyOffset_DebugDraw;

		// Token: 0x04010E98 RID: 69272
		internal static int __PropertyOffset_前向基础跳跃高度;

		// Token: 0x04010E99 RID: 69273
		internal static int __PropertyOffset_前向基础跳远倍率;

		// Token: 0x04010E9A RID: 69274
		internal static int __PropertyOffset_前向最大跳跃距离;

		// Token: 0x04010E9B RID: 69275
		internal static int __PropertyOffset_前向最大跳跃高度;

		// Token: 0x04010E9C RID: 69276
		internal static int __PropertyOffset_前向起跳加速度;

		// Token: 0x04010E9D RID: 69277
		internal static int __PropertyOffset_前向起跳目标速度;

		// Token: 0x04010E9E RID: 69278
		internal static int __PropertyOffset_前向跳跃空中总时长;

		// Token: 0x04010E9F RID: 69279
		internal static int __PropertyOffset_前向起跳时长;

		// Token: 0x04010EA0 RID: 69280
		internal static int __PropertyOffset_前向落地时长;

		// Token: 0x04010EA1 RID: 69281
		internal static int __PropertyOffset_是否有落地动画;

		// Token: 0x04010EA2 RID: 69282
		internal static int __PropertyOffset_是否启用定制动作;

		// Token: 0x04010EA3 RID: 69283
		internal static int __PropertyOffset_DebugDraw_Control;

		// Token: 0x04010EA4 RID: 69284
		internal static int __PropertyOffset_横向控制参数;

		// Token: 0x04010EA5 RID: 69285
		internal static int __PropertyOffset_滑轨动画类型;

		// Token: 0x04010EA6 RID: 69286
		internal static int __PropertyOffset_禁止重力方向倾斜;

		// Token: 0x04010EA7 RID: 69287
		internal static int __PropertyOffset_禁止前后俯仰倾斜;
	}
}
