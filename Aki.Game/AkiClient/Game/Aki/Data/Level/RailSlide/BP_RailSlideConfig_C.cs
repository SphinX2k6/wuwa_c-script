using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.RailSlide
{
	// Token: 0x02003F08 RID: 16136
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/RailSlide/BP_RailSlideConfig.BP_RailSlideConfig_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 335)]
	public class BP_RailSlideConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E9B RID: 167579 RVA: 0x009B76BB File Offset: 0x009B58BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RailSlideConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/RailSlide/BP_RailSlideConfig.BP_RailSlideConfig_C");
			}
			return BP_RailSlideConfig_C._ClassPtr;
		}

		// Token: 0x06028E9C RID: 167580 RVA: 0x009B76E0 File Offset: 0x009B58E0
		public BP_RailSlideConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E9D RID: 167581 RVA: 0x009B7708 File Offset: 0x009B5908
		public BP_RailSlideConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700604F RID: 24655
		// (get) Token: 0x06028E9E RID: 167582 RVA: 0x009B773B File Offset: 0x009B593B
		// (set) Token: 0x06028E9F RID: 167583 RVA: 0x009B774B File Offset: 0x009B594B
		public unsafe int 初始速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006050 RID: 24656
		// (get) Token: 0x06028EA0 RID: 167584 RVA: 0x009B775C File Offset: 0x009B595C
		// (set) Token: 0x06028EA1 RID: 167585 RVA: 0x009B776C File Offset: 0x009B596C
		public unsafe int 基础目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006051 RID: 24657
		// (get) Token: 0x06028EA2 RID: 167586 RVA: 0x009B777D File Offset: 0x009B597D
		// (set) Token: 0x06028EA3 RID: 167587 RVA: 0x009B778D File Offset: 0x009B598D
		public unsafe int 基础加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006052 RID: 24658
		// (get) Token: 0x06028EA4 RID: 167588 RVA: 0x009B779E File Offset: 0x009B599E
		// (set) Token: 0x06028EA5 RID: 167589 RVA: 0x009B77AE File Offset: 0x009B59AE
		public unsafe int 上坡目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006053 RID: 24659
		// (get) Token: 0x06028EA6 RID: 167590 RVA: 0x009B77BF File Offset: 0x009B59BF
		// (set) Token: 0x06028EA7 RID: 167591 RVA: 0x009B77CF File Offset: 0x009B59CF
		public unsafe int 上坡加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006054 RID: 24660
		// (get) Token: 0x06028EA8 RID: 167592 RVA: 0x009B77E0 File Offset: 0x009B59E0
		// (set) Token: 0x06028EA9 RID: 167593 RVA: 0x009B77F0 File Offset: 0x009B59F0
		public unsafe int 下坡目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006055 RID: 24661
		// (get) Token: 0x06028EAA RID: 167594 RVA: 0x009B7801 File Offset: 0x009B5A01
		// (set) Token: 0x06028EAB RID: 167595 RVA: 0x009B7811 File Offset: 0x009B5A11
		public unsafe int 下坡加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006056 RID: 24662
		// (get) Token: 0x06028EAC RID: 167596 RVA: 0x009B7822 File Offset: 0x009B5A22
		// (set) Token: 0x06028EAD RID: 167597 RVA: 0x009B7832 File Offset: 0x009B5A32
		public unsafe int 基础跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006057 RID: 24663
		// (get) Token: 0x06028EAE RID: 167598 RVA: 0x009B7843 File Offset: 0x009B5A43
		// (set) Token: 0x06028EAF RID: 167599 RVA: 0x009B7853 File Offset: 0x009B5A53
		public unsafe float 基础跳远倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006058 RID: 24664
		// (get) Token: 0x06028EB0 RID: 167600 RVA: 0x009B7864 File Offset: 0x009B5A64
		// (set) Token: 0x06028EB1 RID: 167601 RVA: 0x009B7874 File Offset: 0x009B5A74
		public unsafe int 最大跳跃距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006059 RID: 24665
		// (get) Token: 0x06028EB2 RID: 167602 RVA: 0x009B7885 File Offset: 0x009B5A85
		// (set) Token: 0x06028EB3 RID: 167603 RVA: 0x009B7895 File Offset: 0x009B5A95
		public unsafe int 最大跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700605A RID: 24666
		// (get) Token: 0x06028EB4 RID: 167604 RVA: 0x009B78A6 File Offset: 0x009B5AA6
		// (set) Token: 0x06028EB5 RID: 167605 RVA: 0x009B78B6 File Offset: 0x009B5AB6
		public unsafe int 起跳加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700605B RID: 24667
		// (get) Token: 0x06028EB6 RID: 167606 RVA: 0x009B78C7 File Offset: 0x009B5AC7
		// (set) Token: 0x06028EB7 RID: 167607 RVA: 0x009B78D7 File Offset: 0x009B5AD7
		public unsafe int 起跳加速度_卡提西亚
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700605C RID: 24668
		// (get) Token: 0x06028EB8 RID: 167608 RVA: 0x009B78E8 File Offset: 0x009B5AE8
		// (set) Token: 0x06028EB9 RID: 167609 RVA: 0x009B78F8 File Offset: 0x009B5AF8
		public unsafe float 倾斜输入插值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700605D RID: 24669
		// (get) Token: 0x06028EBA RID: 167610 RVA: 0x009B7909 File Offset: 0x009B5B09
		// (set) Token: 0x06028EBB RID: 167611 RVA: 0x009B7919 File Offset: 0x009B5B19
		public unsafe int 最大倾斜角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700605E RID: 24670
		// (get) Token: 0x06028EBC RID: 167612 RVA: 0x009B792A File Offset: 0x009B5B2A
		// (set) Token: 0x06028EBD RID: 167613 RVA: 0x009B793A File Offset: 0x009B5B3A
		public unsafe int 初始进入轨道速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700605F RID: 24671
		// (get) Token: 0x06028EBE RID: 167614 RVA: 0x009B794B File Offset: 0x009B5B4B
		// (set) Token: 0x06028EBF RID: 167615 RVA: 0x009B795B File Offset: 0x009B5B5B
		public unsafe int 切换轨道CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006060 RID: 24672
		// (get) Token: 0x06028EC0 RID: 167616 RVA: 0x009B796C File Offset: 0x009B5B6C
		// (set) Token: 0x06028EC1 RID: 167617 RVA: 0x009B797C File Offset: 0x009B5B7C
		public unsafe int 切换轨道水平距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006061 RID: 24673
		// (get) Token: 0x06028EC2 RID: 167618 RVA: 0x009B798D File Offset: 0x009B5B8D
		// (set) Token: 0x06028EC3 RID: 167619 RVA: 0x009B799D File Offset: 0x009B5B9D
		public unsafe int 切换轨道垂直距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006062 RID: 24674
		// (get) Token: 0x06028EC4 RID: 167620 RVA: 0x009B79AE File Offset: 0x009B5BAE
		// (set) Token: 0x06028EC5 RID: 167621 RVA: 0x009B79BE File Offset: 0x009B5BBE
		public unsafe int 最大加速度角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006063 RID: 24675
		// (get) Token: 0x06028EC6 RID: 167622 RVA: 0x009B79CF File Offset: 0x009B5BCF
		// (set) Token: 0x06028EC7 RID: 167623 RVA: 0x009B79DF File Offset: 0x009B5BDF
		public unsafe int 起跳目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006064 RID: 24676
		// (get) Token: 0x06028EC8 RID: 167624 RVA: 0x009B79F0 File Offset: 0x009B5BF0
		// (set) Token: 0x06028EC9 RID: 167625 RVA: 0x009B7A00 File Offset: 0x009B5C00
		public unsafe int 切换轨道基速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006065 RID: 24677
		// (get) Token: 0x06028ECA RID: 167626 RVA: 0x009B7A14 File Offset: 0x009B5C14
		// (set) Token: 0x06028ECB RID: 167627 RVA: 0x009B7A4D File Offset: 0x009B5C4D
		public SFloatCurve 位移曲线
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._位移曲线) == null)
				{
					result = (this._位移曲线 = new SFloatCurve(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_22, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006066 RID: 24678
		// (get) Token: 0x06028ECC RID: 167628 RVA: 0x009B7A70 File Offset: 0x009B5C70
		// (set) Token: 0x06028ECD RID: 167629 RVA: 0x009B7AA9 File Offset: 0x009B5CA9
		public SFloatCurve 位移曲线_卡提西亚
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._位移曲线_卡提西亚) == null)
				{
					result = (this._位移曲线_卡提西亚 = new SFloatCurve(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_23, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006067 RID: 24679
		// (get) Token: 0x06028ECE RID: 167630 RVA: 0x009B7ACA File Offset: 0x009B5CCA
		// (set) Token: 0x06028ECF RID: 167631 RVA: 0x009B7ADA File Offset: 0x009B5CDA
		public unsafe int 限制输入角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006068 RID: 24680
		// (get) Token: 0x06028ED0 RID: 167632 RVA: 0x009B7AEC File Offset: 0x009B5CEC
		// (set) Token: 0x06028ED1 RID: 167633 RVA: 0x009B7B25 File Offset: 0x009B5D25
		public FGameplayTagContainer 期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._期间Tag) == null)
				{
					result = (this._期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_25, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006069 RID: 24681
		// (get) Token: 0x06028ED2 RID: 167634 RVA: 0x009B7B46 File Offset: 0x009B5D46
		// (set) Token: 0x06028ED3 RID: 167635 RVA: 0x009B7B56 File Offset: 0x009B5D56
		public unsafe int 落地最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700606A RID: 24682
		// (get) Token: 0x06028ED4 RID: 167636 RVA: 0x009B7B67 File Offset: 0x009B5D67
		// (set) Token: 0x06028ED5 RID: 167637 RVA: 0x009B7B77 File Offset: 0x009B5D77
		public unsafe int 落地最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700606B RID: 24683
		// (get) Token: 0x06028ED6 RID: 167638 RVA: 0x009B7B88 File Offset: 0x009B5D88
		// (set) Token: 0x06028ED7 RID: 167639 RVA: 0x009B7BC1 File Offset: 0x009B5DC1
		public TArray<int> 打断技能列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._打断技能列表) == null)
				{
					result = (this._打断技能列表 = new TArray<int>(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_28, this));
				}
				return result;
			}
			set
			{
				this.打断技能列表.CopyAssign(value);
			}
		}

		// Token: 0x1700606C RID: 24684
		// (get) Token: 0x06028ED8 RID: 167640 RVA: 0x009B7BCF File Offset: 0x009B5DCF
		// (set) Token: 0x06028ED9 RID: 167641 RVA: 0x009B7BDF File Offset: 0x009B5DDF
		public unsafe int 起跳时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700606D RID: 24685
		// (get) Token: 0x06028EDA RID: 167642 RVA: 0x009B7BF0 File Offset: 0x009B5DF0
		// (set) Token: 0x06028EDB RID: 167643 RVA: 0x009B7C00 File Offset: 0x009B5E00
		public unsafe int 起跳时长_卡提西亚
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700606E RID: 24686
		// (get) Token: 0x06028EDC RID: 167644 RVA: 0x009B7C11 File Offset: 0x009B5E11
		// (set) Token: 0x06028EDD RID: 167645 RVA: 0x009B7C21 File Offset: 0x009B5E21
		public unsafe int 落地时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700606F RID: 24687
		// (get) Token: 0x06028EDE RID: 167646 RVA: 0x009B7C32 File Offset: 0x009B5E32
		// (set) Token: 0x06028EDF RID: 167647 RVA: 0x009B7C42 File Offset: 0x009B5E42
		public unsafe int 落地时长_卡提西亚
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17006070 RID: 24688
		// (get) Token: 0x06028EE0 RID: 167648 RVA: 0x009B7C53 File Offset: 0x009B5E53
		// (set) Token: 0x06028EE1 RID: 167649 RVA: 0x009B7C63 File Offset: 0x009B5E63
		public unsafe int 跳跃空中总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17006071 RID: 24689
		// (get) Token: 0x06028EE2 RID: 167650 RVA: 0x009B7C74 File Offset: 0x009B5E74
		// (set) Token: 0x06028EE3 RID: 167651 RVA: 0x009B7C84 File Offset: 0x009B5E84
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006072 RID: 24690
		// (get) Token: 0x06028EE4 RID: 167652 RVA: 0x009B7C95 File Offset: 0x009B5E95
		// (set) Token: 0x06028EE5 RID: 167653 RVA: 0x009B7CA5 File Offset: 0x009B5EA5
		public unsafe int 前向基础跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17006073 RID: 24691
		// (get) Token: 0x06028EE6 RID: 167654 RVA: 0x009B7CB6 File Offset: 0x009B5EB6
		// (set) Token: 0x06028EE7 RID: 167655 RVA: 0x009B7CC6 File Offset: 0x009B5EC6
		public unsafe float 前向基础跳远倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17006074 RID: 24692
		// (get) Token: 0x06028EE8 RID: 167656 RVA: 0x009B7CD7 File Offset: 0x009B5ED7
		// (set) Token: 0x06028EE9 RID: 167657 RVA: 0x009B7CE7 File Offset: 0x009B5EE7
		public unsafe int 前向最大跳跃距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006075 RID: 24693
		// (get) Token: 0x06028EEA RID: 167658 RVA: 0x009B7CF8 File Offset: 0x009B5EF8
		// (set) Token: 0x06028EEB RID: 167659 RVA: 0x009B7D08 File Offset: 0x009B5F08
		public unsafe int 前向最大跳跃高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17006076 RID: 24694
		// (get) Token: 0x06028EEC RID: 167660 RVA: 0x009B7D19 File Offset: 0x009B5F19
		// (set) Token: 0x06028EED RID: 167661 RVA: 0x009B7D29 File Offset: 0x009B5F29
		public unsafe int 前向起跳加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17006077 RID: 24695
		// (get) Token: 0x06028EEE RID: 167662 RVA: 0x009B7D3A File Offset: 0x009B5F3A
		// (set) Token: 0x06028EEF RID: 167663 RVA: 0x009B7D4A File Offset: 0x009B5F4A
		public unsafe int 前向起跳目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17006078 RID: 24696
		// (get) Token: 0x06028EF0 RID: 167664 RVA: 0x009B7D5B File Offset: 0x009B5F5B
		// (set) Token: 0x06028EF1 RID: 167665 RVA: 0x009B7D6B File Offset: 0x009B5F6B
		public unsafe int 前向跳跃空中总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17006079 RID: 24697
		// (get) Token: 0x06028EF2 RID: 167666 RVA: 0x009B7D7C File Offset: 0x009B5F7C
		// (set) Token: 0x06028EF3 RID: 167667 RVA: 0x009B7D8C File Offset: 0x009B5F8C
		public unsafe int 前向起跳时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x1700607A RID: 24698
		// (get) Token: 0x06028EF4 RID: 167668 RVA: 0x009B7D9D File Offset: 0x009B5F9D
		// (set) Token: 0x06028EF5 RID: 167669 RVA: 0x009B7DAD File Offset: 0x009B5FAD
		public unsafe int 前向落地时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x1700607B RID: 24699
		// (get) Token: 0x06028EF6 RID: 167670 RVA: 0x009B7DBE File Offset: 0x009B5FBE
		// (set) Token: 0x06028EF7 RID: 167671 RVA: 0x009B7DCE File Offset: 0x009B5FCE
		public unsafe bool 是否有落地动画
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700607C RID: 24700
		// (get) Token: 0x06028EF8 RID: 167672 RVA: 0x009B7DDF File Offset: 0x009B5FDF
		// (set) Token: 0x06028EF9 RID: 167673 RVA: 0x009B7DEF File Offset: 0x009B5FEF
		public unsafe bool 是否启用定制动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700607D RID: 24701
		// (get) Token: 0x06028EFA RID: 167674 RVA: 0x009B7E00 File Offset: 0x009B6000
		// (set) Token: 0x06028EFB RID: 167675 RVA: 0x009B7E10 File Offset: 0x009B6010
		public unsafe bool DebugDraw_Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700607E RID: 24702
		// (get) Token: 0x06028EFC RID: 167676 RVA: 0x009B7E21 File Offset: 0x009B6021
		// (set) Token: 0x06028EFD RID: 167677 RVA: 0x009B7E35 File Offset: 0x009B6035
		public unsafe SRailSlideControlConfig 横向控制参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700607F RID: 24703
		// (get) Token: 0x06028EFE RID: 167678 RVA: 0x009B7E4A File Offset: 0x009B604A
		// (set) Token: 0x06028EFF RID: 167679 RVA: 0x009B7E5A File Offset: 0x009B605A
		public unsafe ERailSlideAnimType 滑轨动画类型
		{
			get
			{
				return (ERailSlideAnimType)(*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_48));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_48) = (byte)value;
			}
		}

		// Token: 0x17006080 RID: 24704
		// (get) Token: 0x06028F00 RID: 167680 RVA: 0x009B7E6B File Offset: 0x009B606B
		// (set) Token: 0x06028F01 RID: 167681 RVA: 0x009B7E7B File Offset: 0x009B607B
		public unsafe bool 禁止重力方向倾斜
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006081 RID: 24705
		// (get) Token: 0x06028F02 RID: 167682 RVA: 0x009B7E8C File Offset: 0x009B608C
		// (set) Token: 0x06028F03 RID: 167683 RVA: 0x009B7E9C File Offset: 0x009B609C
		public unsafe bool 禁止前后俯仰倾斜
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideConfig_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028F04 RID: 167684 RVA: 0x009B7EAD File Offset: 0x009B60AD
		protected BP_RailSlideConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014ECE RID: 85710
		public new const string __ObjectPath = "/Game/Aki/Data/Level/RailSlide/BP_RailSlideConfig.BP_RailSlideConfig_C";

		// Token: 0x04014ECF RID: 85711
		private static IntPtr _ClassPtr;

		// Token: 0x04014ED0 RID: 85712
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014ED1 RID: 85713
		internal static int __PropertyOffset_0;

		// Token: 0x04014ED2 RID: 85714
		internal static int __PropertyOffset_1;

		// Token: 0x04014ED3 RID: 85715
		internal static int __PropertyOffset_2;

		// Token: 0x04014ED4 RID: 85716
		internal static int __PropertyOffset_3;

		// Token: 0x04014ED5 RID: 85717
		internal static int __PropertyOffset_4;

		// Token: 0x04014ED6 RID: 85718
		internal static int __PropertyOffset_5;

		// Token: 0x04014ED7 RID: 85719
		internal static int __PropertyOffset_6;

		// Token: 0x04014ED8 RID: 85720
		internal static int __PropertyOffset_7;

		// Token: 0x04014ED9 RID: 85721
		internal static int __PropertyOffset_8;

		// Token: 0x04014EDA RID: 85722
		internal static int __PropertyOffset_9;

		// Token: 0x04014EDB RID: 85723
		internal static int __PropertyOffset_10;

		// Token: 0x04014EDC RID: 85724
		internal static int __PropertyOffset_11;

		// Token: 0x04014EDD RID: 85725
		internal static int __PropertyOffset_12;

		// Token: 0x04014EDE RID: 85726
		internal static int __PropertyOffset_13;

		// Token: 0x04014EDF RID: 85727
		internal static int __PropertyOffset_14;

		// Token: 0x04014EE0 RID: 85728
		internal static int __PropertyOffset_15;

		// Token: 0x04014EE1 RID: 85729
		internal static int __PropertyOffset_16;

		// Token: 0x04014EE2 RID: 85730
		internal static int __PropertyOffset_17;

		// Token: 0x04014EE3 RID: 85731
		internal static int __PropertyOffset_18;

		// Token: 0x04014EE4 RID: 85732
		internal static int __PropertyOffset_19;

		// Token: 0x04014EE5 RID: 85733
		internal static int __PropertyOffset_20;

		// Token: 0x04014EE6 RID: 85734
		internal static int __PropertyOffset_21;

		// Token: 0x04014EE7 RID: 85735
		internal static int __PropertyOffset_22;

		// Token: 0x04014EE8 RID: 85736
		[Nullable(2)]
		private SFloatCurve _位移曲线;

		// Token: 0x04014EE9 RID: 85737
		internal static int __PropertyOffset_23;

		// Token: 0x04014EEA RID: 85738
		[Nullable(2)]
		private SFloatCurve _位移曲线_卡提西亚;

		// Token: 0x04014EEB RID: 85739
		internal static int __PropertyOffset_24;

		// Token: 0x04014EEC RID: 85740
		internal static int __PropertyOffset_25;

		// Token: 0x04014EED RID: 85741
		[Nullable(2)]
		private FGameplayTagContainer _期间Tag;

		// Token: 0x04014EEE RID: 85742
		internal static int __PropertyOffset_26;

		// Token: 0x04014EEF RID: 85743
		internal static int __PropertyOffset_27;

		// Token: 0x04014EF0 RID: 85744
		internal static int __PropertyOffset_28;

		// Token: 0x04014EF1 RID: 85745
		[Nullable(2)]
		private TArray<int> _打断技能列表;

		// Token: 0x04014EF2 RID: 85746
		internal static int __PropertyOffset_29;

		// Token: 0x04014EF3 RID: 85747
		internal static int __PropertyOffset_30;

		// Token: 0x04014EF4 RID: 85748
		internal static int __PropertyOffset_31;

		// Token: 0x04014EF5 RID: 85749
		internal static int __PropertyOffset_32;

		// Token: 0x04014EF6 RID: 85750
		internal static int __PropertyOffset_33;

		// Token: 0x04014EF7 RID: 85751
		internal static int __PropertyOffset_34;

		// Token: 0x04014EF8 RID: 85752
		internal static int __PropertyOffset_35;

		// Token: 0x04014EF9 RID: 85753
		internal static int __PropertyOffset_36;

		// Token: 0x04014EFA RID: 85754
		internal static int __PropertyOffset_37;

		// Token: 0x04014EFB RID: 85755
		internal static int __PropertyOffset_38;

		// Token: 0x04014EFC RID: 85756
		internal static int __PropertyOffset_39;

		// Token: 0x04014EFD RID: 85757
		internal static int __PropertyOffset_40;

		// Token: 0x04014EFE RID: 85758
		internal static int __PropertyOffset_41;

		// Token: 0x04014EFF RID: 85759
		internal static int __PropertyOffset_42;

		// Token: 0x04014F00 RID: 85760
		internal static int __PropertyOffset_43;

		// Token: 0x04014F01 RID: 85761
		internal static int __PropertyOffset_44;

		// Token: 0x04014F02 RID: 85762
		internal static int __PropertyOffset_45;

		// Token: 0x04014F03 RID: 85763
		internal static int __PropertyOffset_46;

		// Token: 0x04014F04 RID: 85764
		internal static int __PropertyOffset_47;

		// Token: 0x04014F05 RID: 85765
		internal static int __PropertyOffset_48;

		// Token: 0x04014F06 RID: 85766
		internal static int __PropertyOffset_49;

		// Token: 0x04014F07 RID: 85767
		internal static int __PropertyOffset_50;
	}
}
