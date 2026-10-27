using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.KeepFollowing
{
	// Token: 0x02003F0D RID: 16141
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/KeepFollowing/BP_KeepFollowingConfig.BP_KeepFollowingConfig_C")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 348)]
	public class BP_KeepFollowingConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028F4B RID: 167755 RVA: 0x009B85A2 File Offset: 0x009B67A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KeepFollowingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/KeepFollowing/BP_KeepFollowingConfig.BP_KeepFollowingConfig_C");
			}
			return BP_KeepFollowingConfig_C._ClassPtr;
		}

		// Token: 0x06028F4C RID: 167756 RVA: 0x009B85C8 File Offset: 0x009B67C8
		public BP_KeepFollowingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_KeepFollowingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028F4D RID: 167757 RVA: 0x009B85F0 File Offset: 0x009B67F0
		public BP_KeepFollowingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KeepFollowingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700609A RID: 24730
		// (get) Token: 0x06028F4E RID: 167758 RVA: 0x009B8623 File Offset: 0x009B6823
		// (set) Token: 0x06028F4F RID: 167759 RVA: 0x009B8637 File Offset: 0x009B6837
		public unsafe FVector2D 步行跟随方位向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700609B RID: 24731
		// (get) Token: 0x06028F50 RID: 167760 RVA: 0x009B864C File Offset: 0x009B684C
		// (set) Token: 0x06028F51 RID: 167761 RVA: 0x009B8660 File Offset: 0x009B6860
		public unsafe FVector2D 跑步跟随方位向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700609C RID: 24732
		// (get) Token: 0x06028F52 RID: 167762 RVA: 0x009B8675 File Offset: 0x009B6875
		// (set) Token: 0x06028F53 RID: 167763 RVA: 0x009B8689 File Offset: 0x009B6889
		public unsafe FVector2D 跟随变速范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700609D RID: 24733
		// (get) Token: 0x06028F54 RID: 167764 RVA: 0x009B869E File Offset: 0x009B689E
		// (set) Token: 0x06028F55 RID: 167765 RVA: 0x009B86AE File Offset: 0x009B68AE
		public unsafe bool 是否启用位移修正
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700609E RID: 24734
		// (get) Token: 0x06028F56 RID: 167766 RVA: 0x009B86BF File Offset: 0x009B68BF
		// (set) Token: 0x06028F57 RID: 167767 RVA: 0x009B86CF File Offset: 0x009B68CF
		public unsafe int 位移修正距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700609F RID: 24735
		// (get) Token: 0x06028F58 RID: 167768 RVA: 0x009B86E0 File Offset: 0x009B68E0
		// (set) Token: 0x06028F59 RID: 167769 RVA: 0x009B86F0 File Offset: 0x009B68F0
		public unsafe int 保持站立距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170060A0 RID: 24736
		// (get) Token: 0x06028F5A RID: 167770 RVA: 0x009B8701 File Offset: 0x009B6901
		// (set) Token: 0x06028F5B RID: 167771 RVA: 0x009B8711 File Offset: 0x009B6911
		public unsafe int 走跑状态分界速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170060A1 RID: 24737
		// (get) Token: 0x06028F5C RID: 167772 RVA: 0x009B8722 File Offset: 0x009B6922
		// (set) Token: 0x06028F5D RID: 167773 RVA: 0x009B8732 File Offset: 0x009B6932
		public unsafe int 走跑分界速度浮动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170060A2 RID: 24738
		// (get) Token: 0x06028F5E RID: 167774 RVA: 0x009B8743 File Offset: 0x009B6943
		// (set) Token: 0x06028F5F RID: 167775 RVA: 0x009B8753 File Offset: 0x009B6953
		public unsafe int 跑冲刺分界速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170060A3 RID: 24739
		// (get) Token: 0x06028F60 RID: 167776 RVA: 0x009B8764 File Offset: 0x009B6964
		// (set) Token: 0x06028F61 RID: 167777 RVA: 0x009B8774 File Offset: 0x009B6974
		public unsafe int 跑冲刺分界速度浮动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170060A4 RID: 24740
		// (get) Token: 0x06028F62 RID: 167778 RVA: 0x009B8785 File Offset: 0x009B6985
		// (set) Token: 0x06028F63 RID: 167779 RVA: 0x009B8795 File Offset: 0x009B6995
		public unsafe int 跟随距离容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170060A5 RID: 24741
		// (get) Token: 0x06028F64 RID: 167780 RVA: 0x009B87A6 File Offset: 0x009B69A6
		// (set) Token: 0x06028F65 RID: 167781 RVA: 0x009B87B6 File Offset: 0x009B69B6
		public unsafe int 转向角度容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170060A6 RID: 24742
		// (get) Token: 0x06028F66 RID: 167782 RVA: 0x009B87C7 File Offset: 0x009B69C7
		// (set) Token: 0x06028F67 RID: 167783 RVA: 0x009B87D7 File Offset: 0x009B69D7
		public unsafe int 最大转向持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170060A7 RID: 24743
		// (get) Token: 0x06028F68 RID: 167784 RVA: 0x009B87E8 File Offset: 0x009B69E8
		// (set) Token: 0x06028F69 RID: 167785 RVA: 0x009B87F8 File Offset: 0x009B69F8
		public unsafe int 变速加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170060A8 RID: 24744
		// (get) Token: 0x06028F6A RID: 167786 RVA: 0x009B8809 File Offset: 0x009B6A09
		// (set) Token: 0x06028F6B RID: 167787 RVA: 0x009B8819 File Offset: 0x009B6A19
		public unsafe int 转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170060A9 RID: 24745
		// (get) Token: 0x06028F6C RID: 167788 RVA: 0x009B882A File Offset: 0x009B6A2A
		// (set) Token: 0x06028F6D RID: 167789 RVA: 0x009B883A File Offset: 0x009B6A3A
		public unsafe int 高低差允许范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170060AA RID: 24746
		// (get) Token: 0x06028F6E RID: 167790 RVA: 0x009B884B File Offset: 0x009B6A4B
		// (set) Token: 0x06028F6F RID: 167791 RVA: 0x009B885B File Offset: 0x009B6A5B
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060AB RID: 24747
		// (get) Token: 0x06028F70 RID: 167792 RVA: 0x009B886C File Offset: 0x009B6A6C
		// (set) Token: 0x06028F71 RID: 167793 RVA: 0x009B887C File Offset: 0x009B6A7C
		public unsafe int 位移修正速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170060AC RID: 24748
		// (get) Token: 0x06028F72 RID: 167794 RVA: 0x009B888D File Offset: 0x009B6A8D
		// (set) Token: 0x06028F73 RID: 167795 RVA: 0x009B889D File Offset: 0x009B6A9D
		public unsafe bool 是否启用超时传送
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060AD RID: 24749
		// (get) Token: 0x06028F74 RID: 167796 RVA: 0x009B88AE File Offset: 0x009B6AAE
		// (set) Token: 0x06028F75 RID: 167797 RVA: 0x009B88BE File Offset: 0x009B6ABE
		public unsafe int 异常距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170060AE RID: 24750
		// (get) Token: 0x06028F76 RID: 167798 RVA: 0x009B88CF File Offset: 0x009B6ACF
		// (set) Token: 0x06028F77 RID: 167799 RVA: 0x009B88DF File Offset: 0x009B6ADF
		public unsafe int 超时时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170060AF RID: 24751
		// (get) Token: 0x06028F78 RID: 167800 RVA: 0x009B88F0 File Offset: 0x009B6AF0
		// (set) Token: 0x06028F79 RID: 167801 RVA: 0x009B8929 File Offset: 0x009B6B29
		public TArray<int> 传送特效buffID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._传送特效buffID) == null)
				{
					result = (this._传送特效buffID = new TArray<int>(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				this.传送特效buffID.CopyAssign(value);
			}
		}

		// Token: 0x170060B0 RID: 24752
		// (get) Token: 0x06028F7A RID: 167802 RVA: 0x009B8937 File Offset: 0x009B6B37
		// (set) Token: 0x06028F7B RID: 167803 RVA: 0x009B8947 File Offset: 0x009B6B47
		public unsafe int 被阻挡触发传送时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170060B1 RID: 24753
		// (get) Token: 0x06028F7C RID: 167804 RVA: 0x009B8958 File Offset: 0x009B6B58
		// (set) Token: 0x06028F7D RID: 167805 RVA: 0x009B8968 File Offset: 0x009B6B68
		public unsafe int StandardWalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170060B2 RID: 24754
		// (get) Token: 0x06028F7E RID: 167806 RVA: 0x009B8979 File Offset: 0x009B6B79
		// (set) Token: 0x06028F7F RID: 167807 RVA: 0x009B8989 File Offset: 0x009B6B89
		public unsafe int StandardRunSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170060B3 RID: 24755
		// (get) Token: 0x06028F80 RID: 167808 RVA: 0x009B899A File Offset: 0x009B6B9A
		// (set) Token: 0x06028F81 RID: 167809 RVA: 0x009B89AA File Offset: 0x009B6BAA
		public unsafe int StandardSprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170060B4 RID: 24756
		// (get) Token: 0x06028F82 RID: 167810 RVA: 0x009B89BB File Offset: 0x009B6BBB
		// (set) Token: 0x06028F83 RID: 167811 RVA: 0x009B89CB File Offset: 0x009B6BCB
		public unsafe bool 只使用标准速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060B5 RID: 24757
		// (get) Token: 0x06028F84 RID: 167812 RVA: 0x009B89DC File Offset: 0x009B6BDC
		// (set) Token: 0x06028F85 RID: 167813 RVA: 0x009B89EC File Offset: 0x009B6BEC
		public unsafe int 保持站立角色距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170060B6 RID: 24758
		// (get) Token: 0x06028F86 RID: 167814 RVA: 0x009B89FD File Offset: 0x009B6BFD
		// (set) Token: 0x06028F87 RID: 167815 RVA: 0x009B8A0D File Offset: 0x009B6C0D
		public unsafe int 加速延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170060B7 RID: 24759
		// (get) Token: 0x06028F88 RID: 167816 RVA: 0x009B8A1E File Offset: 0x009B6C1E
		// (set) Token: 0x06028F89 RID: 167817 RVA: 0x009B8A2E File Offset: 0x009B6C2E
		public unsafe int 移动延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170060B8 RID: 24760
		// (get) Token: 0x06028F8A RID: 167818 RVA: 0x009B8A3F File Offset: 0x009B6C3F
		// (set) Token: 0x06028F8B RID: 167819 RVA: 0x009B8A4F File Offset: 0x009B6C4F
		public unsafe bool 自动转向目标
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060B9 RID: 24761
		// (get) Token: 0x06028F8C RID: 167820 RVA: 0x009B8A60 File Offset: 0x009B6C60
		// (set) Token: 0x06028F8D RID: 167821 RVA: 0x009B8A70 File Offset: 0x009B6C70
		public unsafe bool 非近距离同步跟随
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060BA RID: 24762
		// (get) Token: 0x06028F8E RID: 167822 RVA: 0x009B8A84 File Offset: 0x009B6C84
		// (set) Token: 0x06028F8F RID: 167823 RVA: 0x009B8ABD File Offset: 0x009B6CBD
		public TArray<FVector2D> 跑步跟随方位备选
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._跑步跟随方位备选) == null)
				{
					result = (this._跑步跟随方位备选 = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_32, this));
				}
				return result;
			}
			set
			{
				this.跑步跟随方位备选.CopyAssign(value);
			}
		}

		// Token: 0x170060BB RID: 24763
		// (get) Token: 0x06028F90 RID: 167824 RVA: 0x009B8ACC File Offset: 0x009B6CCC
		// (set) Token: 0x06028F91 RID: 167825 RVA: 0x009B8B05 File Offset: 0x009B6D05
		public TArray<FVector2D> 步行跟随方位备选
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._步行跟随方位备选) == null)
				{
					result = (this._步行跟随方位备选 = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_33, this));
				}
				return result;
			}
			set
			{
				this.步行跟随方位备选.CopyAssign(value);
			}
		}

		// Token: 0x170060BC RID: 24764
		// (get) Token: 0x06028F92 RID: 167826 RVA: 0x009B8B14 File Offset: 0x009B6D14
		// (set) Token: 0x06028F93 RID: 167827 RVA: 0x009B8B4D File Offset: 0x009B6D4D
		public SFreeFollowingConfig 自动跟随信息
		{
			get
			{
				base.FastCheckIsValid();
				SFreeFollowingConfig result;
				if ((result = this._自动跟随信息) == null)
				{
					result = (this._自动跟随信息 = new SFreeFollowingConfig(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_34, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFreeFollowingConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_34, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060BD RID: 24765
		// (get) Token: 0x06028F94 RID: 167828 RVA: 0x009B8B6E File Offset: 0x009B6D6E
		// (set) Token: 0x06028F95 RID: 167829 RVA: 0x009B8B82 File Offset: 0x009B6D82
		public unsafe SFollowSitConfig 跟随坐下信息
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x06028F96 RID: 167830 RVA: 0x009B8B97 File Offset: 0x009B6D97
		protected BP_KeepFollowingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F32 RID: 85810
		public new const string __ObjectPath = "/Game/Aki/Data/Level/KeepFollowing/BP_KeepFollowingConfig.BP_KeepFollowingConfig_C";

		// Token: 0x04014F33 RID: 85811
		private static IntPtr _ClassPtr;

		// Token: 0x04014F34 RID: 85812
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F35 RID: 85813
		internal static int __PropertyOffset_0;

		// Token: 0x04014F36 RID: 85814
		internal static int __PropertyOffset_1;

		// Token: 0x04014F37 RID: 85815
		internal static int __PropertyOffset_2;

		// Token: 0x04014F38 RID: 85816
		internal static int __PropertyOffset_3;

		// Token: 0x04014F39 RID: 85817
		internal static int __PropertyOffset_4;

		// Token: 0x04014F3A RID: 85818
		internal static int __PropertyOffset_5;

		// Token: 0x04014F3B RID: 85819
		internal static int __PropertyOffset_6;

		// Token: 0x04014F3C RID: 85820
		internal static int __PropertyOffset_7;

		// Token: 0x04014F3D RID: 85821
		internal static int __PropertyOffset_8;

		// Token: 0x04014F3E RID: 85822
		internal static int __PropertyOffset_9;

		// Token: 0x04014F3F RID: 85823
		internal static int __PropertyOffset_10;

		// Token: 0x04014F40 RID: 85824
		internal static int __PropertyOffset_11;

		// Token: 0x04014F41 RID: 85825
		internal static int __PropertyOffset_12;

		// Token: 0x04014F42 RID: 85826
		internal static int __PropertyOffset_13;

		// Token: 0x04014F43 RID: 85827
		internal static int __PropertyOffset_14;

		// Token: 0x04014F44 RID: 85828
		internal static int __PropertyOffset_15;

		// Token: 0x04014F45 RID: 85829
		internal static int __PropertyOffset_16;

		// Token: 0x04014F46 RID: 85830
		internal static int __PropertyOffset_17;

		// Token: 0x04014F47 RID: 85831
		internal static int __PropertyOffset_18;

		// Token: 0x04014F48 RID: 85832
		internal static int __PropertyOffset_19;

		// Token: 0x04014F49 RID: 85833
		internal static int __PropertyOffset_20;

		// Token: 0x04014F4A RID: 85834
		internal static int __PropertyOffset_21;

		// Token: 0x04014F4B RID: 85835
		[Nullable(2)]
		private TArray<int> _传送特效buffID;

		// Token: 0x04014F4C RID: 85836
		internal static int __PropertyOffset_22;

		// Token: 0x04014F4D RID: 85837
		internal static int __PropertyOffset_23;

		// Token: 0x04014F4E RID: 85838
		internal static int __PropertyOffset_24;

		// Token: 0x04014F4F RID: 85839
		internal static int __PropertyOffset_25;

		// Token: 0x04014F50 RID: 85840
		internal static int __PropertyOffset_26;

		// Token: 0x04014F51 RID: 85841
		internal static int __PropertyOffset_27;

		// Token: 0x04014F52 RID: 85842
		internal static int __PropertyOffset_28;

		// Token: 0x04014F53 RID: 85843
		internal static int __PropertyOffset_29;

		// Token: 0x04014F54 RID: 85844
		internal static int __PropertyOffset_30;

		// Token: 0x04014F55 RID: 85845
		internal static int __PropertyOffset_31;

		// Token: 0x04014F56 RID: 85846
		internal static int __PropertyOffset_32;

		// Token: 0x04014F57 RID: 85847
		[Nullable(2)]
		private TArray<FVector2D> _跑步跟随方位备选;

		// Token: 0x04014F58 RID: 85848
		internal static int __PropertyOffset_33;

		// Token: 0x04014F59 RID: 85849
		[Nullable(2)]
		private TArray<FVector2D> _步行跟随方位备选;

		// Token: 0x04014F5A RID: 85850
		internal static int __PropertyOffset_34;

		// Token: 0x04014F5B RID: 85851
		[Nullable(2)]
		private SFreeFollowingConfig _自动跟随信息;

		// Token: 0x04014F5C RID: 85852
		internal static int __PropertyOffset_35;
	}
}
