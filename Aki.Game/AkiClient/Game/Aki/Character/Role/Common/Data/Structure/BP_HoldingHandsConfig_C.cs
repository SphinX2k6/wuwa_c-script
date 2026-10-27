using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040AA RID: 16554
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_HoldingHandsConfig.BP_HoldingHandsConfig_C")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class BP_HoldingHandsConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ABC6 RID: 175046 RVA: 0x009EA378 File Offset: 0x009E8578
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HoldingHandsConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_HoldingHandsConfig.BP_HoldingHandsConfig_C");
			}
			return BP_HoldingHandsConfig_C._ClassPtr;
		}

		// Token: 0x0602ABC7 RID: 175047 RVA: 0x009EA39C File Offset: 0x009E859C
		public BP_HoldingHandsConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_HoldingHandsConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ABC8 RID: 175048 RVA: 0x009EA3C4 File Offset: 0x009E85C4
		public BP_HoldingHandsConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HoldingHandsConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006932 RID: 26930
		// (get) Token: 0x0602ABC9 RID: 175049 RVA: 0x009EA3F8 File Offset: 0x009E85F8
		// (set) Token: 0x0602ABCA RID: 175050 RVA: 0x009EA431 File Offset: 0x009E8631
		public FGameplayTagContainer 邀请中
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._邀请中) == null)
				{
					result = (this._邀请中 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006933 RID: 26931
		// (get) Token: 0x0602ABCB RID: 175051 RVA: 0x009EA454 File Offset: 0x009E8654
		// (set) Token: 0x0602ABCC RID: 175052 RVA: 0x009EA48D File Offset: 0x009E868D
		public FGameplayTagContainer 牵手中
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._牵手中) == null)
				{
					result = (this._牵手中 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006934 RID: 26932
		// (get) Token: 0x0602ABCD RID: 175053 RVA: 0x009EA4B0 File Offset: 0x009E86B0
		// (set) Token: 0x0602ABCE RID: 175054 RVA: 0x009EA4E9 File Offset: 0x009E86E9
		public FGameplayTagContainer 被牵手中
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._被牵手中) == null)
				{
					result = (this._被牵手中 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006935 RID: 26933
		// (get) Token: 0x0602ABCF RID: 175055 RVA: 0x009EA50A File Offset: 0x009E870A
		// (set) Token: 0x0602ABD0 RID: 175056 RVA: 0x009EA51E File Offset: 0x009E871E
		public unsafe FGameplayTag 牵手范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006936 RID: 26934
		// (get) Token: 0x0602ABD1 RID: 175057 RVA: 0x009EA534 File Offset: 0x009E8734
		// (set) Token: 0x0602ABD2 RID: 175058 RVA: 0x009EA56D File Offset: 0x009E876D
		public FGameplayTagContainer 牵手禁止
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._牵手禁止) == null)
				{
					result = (this._牵手禁止 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006937 RID: 26935
		// (get) Token: 0x0602ABD3 RID: 175059 RVA: 0x009EA58E File Offset: 0x009E878E
		// (set) Token: 0x0602ABD4 RID: 175060 RVA: 0x009EA59E File Offset: 0x009E879E
		public unsafe float 超时终止时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006938 RID: 26936
		// (get) Token: 0x0602ABD5 RID: 175061 RVA: 0x009EA5AF File Offset: 0x009E87AF
		// (set) Token: 0x0602ABD6 RID: 175062 RVA: 0x009EA5BF File Offset: 0x009E87BF
		public unsafe float 进出牵手阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006939 RID: 26937
		// (get) Token: 0x0602ABD7 RID: 175063 RVA: 0x009EA5D0 File Offset: 0x009E87D0
		// (set) Token: 0x0602ABD8 RID: 175064 RVA: 0x009EA5E0 File Offset: 0x009E87E0
		public unsafe float 跑步速度缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700693A RID: 26938
		// (get) Token: 0x0602ABD9 RID: 175065 RVA: 0x009EA5F1 File Offset: 0x009E87F1
		// (set) Token: 0x0602ABDA RID: 175066 RVA: 0x009EA601 File Offset: 0x009E8801
		public unsafe float 牵手点阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700693B RID: 26939
		// (get) Token: 0x0602ABDB RID: 175067 RVA: 0x009EA612 File Offset: 0x009E8812
		// (set) Token: 0x0602ABDC RID: 175068 RVA: 0x009EA622 File Offset: 0x009E8822
		public unsafe float 长按退出时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700693C RID: 26940
		// (get) Token: 0x0602ABDD RID: 175069 RVA: 0x009EA633 File Offset: 0x009E8833
		// (set) Token: 0x0602ABDE RID: 175070 RVA: 0x009EA647 File Offset: 0x009E8847
		public unsafe FFloatRange 牵手点偏转角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700693D RID: 26941
		// (get) Token: 0x0602ABDF RID: 175071 RVA: 0x009EA65C File Offset: 0x009E885C
		// (set) Token: 0x0602ABE0 RID: 175072 RVA: 0x009EA670 File Offset: 0x009E8870
		public unsafe FFloatRange 牵手点俯仰角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700693E RID: 26942
		// (get) Token: 0x0602ABE1 RID: 175073 RVA: 0x009EA685 File Offset: 0x009E8885
		// (set) Token: 0x0602ABE2 RID: 175074 RVA: 0x009EA699 File Offset: 0x009E8899
		public unsafe FFloatRange 肩部偏转角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700693F RID: 26943
		// (get) Token: 0x0602ABE3 RID: 175075 RVA: 0x009EA6AE File Offset: 0x009E88AE
		// (set) Token: 0x0602ABE4 RID: 175076 RVA: 0x009EA6C2 File Offset: 0x009E88C2
		public unsafe FFloatRange 肩部俯仰角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006940 RID: 26944
		// (get) Token: 0x0602ABE5 RID: 175077 RVA: 0x009EA6D7 File Offset: 0x009E88D7
		// (set) Token: 0x0602ABE6 RID: 175078 RVA: 0x009EA6E7 File Offset: 0x009E88E7
		public unsafe float 范围内额外角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006941 RID: 26945
		// (get) Token: 0x0602ABE7 RID: 175079 RVA: 0x009EA6F8 File Offset: 0x009E88F8
		// (set) Token: 0x0602ABE8 RID: 175080 RVA: 0x009EA708 File Offset: 0x009E8908
		public unsafe float 范围外可达距离缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006942 RID: 26946
		// (get) Token: 0x0602ABE9 RID: 175081 RVA: 0x009EA719 File Offset: 0x009E8919
		// (set) Token: 0x0602ABEA RID: 175082 RVA: 0x009EA729 File Offset: 0x009E8929
		public unsafe float 范围内可达距离缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006943 RID: 26947
		// (get) Token: 0x0602ABEB RID: 175083 RVA: 0x009EA73A File Offset: 0x009E893A
		// (set) Token: 0x0602ABEC RID: 175084 RVA: 0x009EA74A File Offset: 0x009E894A
		public unsafe float 范围外牵手点最大距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006944 RID: 26948
		// (get) Token: 0x0602ABED RID: 175085 RVA: 0x009EA75B File Offset: 0x009E895B
		// (set) Token: 0x0602ABEE RID: 175086 RVA: 0x009EA76B File Offset: 0x009E896B
		public unsafe float 范围内牵手点最大距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006945 RID: 26949
		// (get) Token: 0x0602ABEF RID: 175087 RVA: 0x009EA77C File Offset: 0x009E897C
		// (set) Token: 0x0602ABF0 RID: 175088 RVA: 0x009EA791 File Offset: 0x009E8991
		public TSoftObjectPtr<BP_KeepFollowingConfig_C> 跟随配置
		{
			get
			{
				return new TSoftObjectPtr<BP_KeepFollowingConfig_C>(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_19, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_19, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006946 RID: 26950
		// (get) Token: 0x0602ABF1 RID: 175089 RVA: 0x009EA7B6 File Offset: 0x009E89B6
		// (set) Token: 0x0602ABF2 RID: 175090 RVA: 0x009EA7C6 File Offset: 0x009E89C6
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006947 RID: 26951
		// (get) Token: 0x0602ABF3 RID: 175091 RVA: 0x009EA7D7 File Offset: 0x009E89D7
		// (set) Token: 0x0602ABF4 RID: 175092 RVA: 0x009EA7E7 File Offset: 0x009E89E7
		public unsafe float 跑步最大旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006948 RID: 26952
		// (get) Token: 0x0602ABF5 RID: 175093 RVA: 0x009EA7F8 File Offset: 0x009E89F8
		// (set) Token: 0x0602ABF6 RID: 175094 RVA: 0x009EA808 File Offset: 0x009E8A08
		public unsafe float 走路最大旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006949 RID: 26953
		// (get) Token: 0x0602ABF7 RID: 175095 RVA: 0x009EA819 File Offset: 0x009E8A19
		// (set) Token: 0x0602ABF8 RID: 175096 RVA: 0x009EA829 File Offset: 0x009E8A29
		public unsafe int 牵手者碰撞优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700694A RID: 26954
		// (get) Token: 0x0602ABF9 RID: 175097 RVA: 0x009EA83A File Offset: 0x009E8A3A
		// (set) Token: 0x0602ABFA RID: 175098 RVA: 0x009EA84A File Offset: 0x009E8A4A
		public unsafe int 被牵手者碰撞优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700694B RID: 26955
		// (get) Token: 0x0602ABFB RID: 175099 RVA: 0x009EA85B File Offset: 0x009E8A5B
		// (set) Token: 0x0602ABFC RID: 175100 RVA: 0x009EA86B File Offset: 0x009E8A6B
		public unsafe float 牵手者质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700694C RID: 26956
		// (get) Token: 0x0602ABFD RID: 175101 RVA: 0x009EA87C File Offset: 0x009E8A7C
		// (set) Token: 0x0602ABFE RID: 175102 RVA: 0x009EA88C File Offset: 0x009E8A8C
		public unsafe float 被牵手者质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700694D RID: 26957
		// (get) Token: 0x0602ABFF RID: 175103 RVA: 0x009EA89D File Offset: 0x009E8A9D
		// (set) Token: 0x0602AC00 RID: 175104 RVA: 0x009EA8AD File Offset: 0x009E8AAD
		public unsafe float 邀请距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700694E RID: 26958
		// (get) Token: 0x0602AC01 RID: 175105 RVA: 0x009EA8BE File Offset: 0x009E8ABE
		// (set) Token: 0x0602AC02 RID: 175106 RVA: 0x009EA8CE File Offset: 0x009E8ACE
		public unsafe float 邀请距离容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700694F RID: 26959
		// (get) Token: 0x0602AC03 RID: 175107 RVA: 0x009EA8DF File Offset: 0x009E8ADF
		// (set) Token: 0x0602AC04 RID: 175108 RVA: 0x009EA8EF File Offset: 0x009E8AEF
		public unsafe float 邀请结束距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17006950 RID: 26960
		// (get) Token: 0x0602AC05 RID: 175109 RVA: 0x009EA900 File Offset: 0x009E8B00
		// (set) Token: 0x0602AC06 RID: 175110 RVA: 0x009EA910 File Offset: 0x009E8B10
		public unsafe float 邀请结束距离容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17006951 RID: 26961
		// (get) Token: 0x0602AC07 RID: 175111 RVA: 0x009EA921 File Offset: 0x009E8B21
		// (set) Token: 0x0602AC08 RID: 175112 RVA: 0x009EA931 File Offset: 0x009E8B31
		public unsafe float 邀请结束移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17006952 RID: 26962
		// (get) Token: 0x0602AC09 RID: 175113 RVA: 0x009EA942 File Offset: 0x009E8B42
		// (set) Token: 0x0602AC0A RID: 175114 RVA: 0x009EA952 File Offset: 0x009E8B52
		public unsafe float 邀请旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17006953 RID: 26963
		// (get) Token: 0x0602AC0B RID: 175115 RVA: 0x009EA963 File Offset: 0x009E8B63
		// (set) Token: 0x0602AC0C RID: 175116 RVA: 0x009EA973 File Offset: 0x009E8B73
		public unsafe float 邀请时牵手点阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17006954 RID: 26964
		// (get) Token: 0x0602AC0D RID: 175117 RVA: 0x009EA984 File Offset: 0x009E8B84
		// (set) Token: 0x0602AC0E RID: 175118 RVA: 0x009EA994 File Offset: 0x009E8B94
		public unsafe float 手掌最小夹角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17006955 RID: 26965
		// (get) Token: 0x0602AC0F RID: 175119 RVA: 0x009EA9A5 File Offset: 0x009E8BA5
		// (set) Token: 0x0602AC10 RID: 175120 RVA: 0x009EA9B5 File Offset: 0x009E8BB5
		public unsafe float 牵手者牵手点位置缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17006956 RID: 26966
		// (get) Token: 0x0602AC11 RID: 175121 RVA: 0x009EA9C6 File Offset: 0x009E8BC6
		// (set) Token: 0x0602AC12 RID: 175122 RVA: 0x009EA9D6 File Offset: 0x009E8BD6
		public unsafe float 被牵手者牵手点位置缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17006957 RID: 26967
		// (get) Token: 0x0602AC13 RID: 175123 RVA: 0x009EA9E7 File Offset: 0x009E8BE7
		// (set) Token: 0x0602AC14 RID: 175124 RVA: 0x009EA9F7 File Offset: 0x009E8BF7
		public unsafe float 贴合距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006958 RID: 26968
		// (get) Token: 0x0602AC15 RID: 175125 RVA: 0x009EAA08 File Offset: 0x009E8C08
		// (set) Token: 0x0602AC16 RID: 175126 RVA: 0x009EAA18 File Offset: 0x009E8C18
		public unsafe float 范围外肩部最大高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17006959 RID: 26969
		// (get) Token: 0x0602AC17 RID: 175127 RVA: 0x009EAA29 File Offset: 0x009E8C29
		// (set) Token: 0x0602AC18 RID: 175128 RVA: 0x009EAA39 File Offset: 0x009E8C39
		public unsafe float 范围内肩部最大高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x0602AC19 RID: 175129 RVA: 0x009EAA4A File Offset: 0x009E8C4A
		protected BP_HoldingHandsConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040161E4 RID: 90596
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_HoldingHandsConfig.BP_HoldingHandsConfig_C";

		// Token: 0x040161E5 RID: 90597
		private static IntPtr _ClassPtr;

		// Token: 0x040161E6 RID: 90598
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040161E7 RID: 90599
		internal static int __PropertyOffset_0;

		// Token: 0x040161E8 RID: 90600
		[Nullable(2)]
		private FGameplayTagContainer _邀请中;

		// Token: 0x040161E9 RID: 90601
		internal static int __PropertyOffset_1;

		// Token: 0x040161EA RID: 90602
		[Nullable(2)]
		private FGameplayTagContainer _牵手中;

		// Token: 0x040161EB RID: 90603
		internal static int __PropertyOffset_2;

		// Token: 0x040161EC RID: 90604
		[Nullable(2)]
		private FGameplayTagContainer _被牵手中;

		// Token: 0x040161ED RID: 90605
		internal static int __PropertyOffset_3;

		// Token: 0x040161EE RID: 90606
		internal static int __PropertyOffset_4;

		// Token: 0x040161EF RID: 90607
		[Nullable(2)]
		private FGameplayTagContainer _牵手禁止;

		// Token: 0x040161F0 RID: 90608
		internal static int __PropertyOffset_5;

		// Token: 0x040161F1 RID: 90609
		internal static int __PropertyOffset_6;

		// Token: 0x040161F2 RID: 90610
		internal static int __PropertyOffset_7;

		// Token: 0x040161F3 RID: 90611
		internal static int __PropertyOffset_8;

		// Token: 0x040161F4 RID: 90612
		internal static int __PropertyOffset_9;

		// Token: 0x040161F5 RID: 90613
		internal static int __PropertyOffset_10;

		// Token: 0x040161F6 RID: 90614
		internal static int __PropertyOffset_11;

		// Token: 0x040161F7 RID: 90615
		internal static int __PropertyOffset_12;

		// Token: 0x040161F8 RID: 90616
		internal static int __PropertyOffset_13;

		// Token: 0x040161F9 RID: 90617
		internal static int __PropertyOffset_14;

		// Token: 0x040161FA RID: 90618
		internal static int __PropertyOffset_15;

		// Token: 0x040161FB RID: 90619
		internal static int __PropertyOffset_16;

		// Token: 0x040161FC RID: 90620
		internal static int __PropertyOffset_17;

		// Token: 0x040161FD RID: 90621
		internal static int __PropertyOffset_18;

		// Token: 0x040161FE RID: 90622
		internal static int __PropertyOffset_19;

		// Token: 0x040161FF RID: 90623
		internal static int __PropertyOffset_20;

		// Token: 0x04016200 RID: 90624
		internal static int __PropertyOffset_21;

		// Token: 0x04016201 RID: 90625
		internal static int __PropertyOffset_22;

		// Token: 0x04016202 RID: 90626
		internal static int __PropertyOffset_23;

		// Token: 0x04016203 RID: 90627
		internal static int __PropertyOffset_24;

		// Token: 0x04016204 RID: 90628
		internal static int __PropertyOffset_25;

		// Token: 0x04016205 RID: 90629
		internal static int __PropertyOffset_26;

		// Token: 0x04016206 RID: 90630
		internal static int __PropertyOffset_27;

		// Token: 0x04016207 RID: 90631
		internal static int __PropertyOffset_28;

		// Token: 0x04016208 RID: 90632
		internal static int __PropertyOffset_29;

		// Token: 0x04016209 RID: 90633
		internal static int __PropertyOffset_30;

		// Token: 0x0401620A RID: 90634
		internal static int __PropertyOffset_31;

		// Token: 0x0401620B RID: 90635
		internal static int __PropertyOffset_32;

		// Token: 0x0401620C RID: 90636
		internal static int __PropertyOffset_33;

		// Token: 0x0401620D RID: 90637
		internal static int __PropertyOffset_34;

		// Token: 0x0401620E RID: 90638
		internal static int __PropertyOffset_35;

		// Token: 0x0401620F RID: 90639
		internal static int __PropertyOffset_36;

		// Token: 0x04016210 RID: 90640
		internal static int __PropertyOffset_37;

		// Token: 0x04016211 RID: 90641
		internal static int __PropertyOffset_38;

		// Token: 0x04016212 RID: 90642
		internal static int __PropertyOffset_39;
	}
}
