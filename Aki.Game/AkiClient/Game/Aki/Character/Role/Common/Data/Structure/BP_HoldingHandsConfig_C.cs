using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A1 RID: 12961
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_HoldingHandsConfig.BP_HoldingHandsConfig_C")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class BP_HoldingHandsConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020943 RID: 133443 RVA: 0x0094A348 File Offset: 0x00948548
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HoldingHandsConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_HoldingHandsConfig.BP_HoldingHandsConfig_C");
			}
			return BP_HoldingHandsConfig_C._ClassPtr;
		}

		// Token: 0x06020944 RID: 133444 RVA: 0x0094A36C File Offset: 0x0094856C
		public BP_HoldingHandsConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_HoldingHandsConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020945 RID: 133445 RVA: 0x0094A394 File Offset: 0x00948594
		public BP_HoldingHandsConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HoldingHandsConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x06020946 RID: 133446 RVA: 0x0094A3C8 File Offset: 0x009485C8
		// (set) Token: 0x06020947 RID: 133447 RVA: 0x0094A401 File Offset: 0x00948601
		public FGameplayTagContainer 邀请中
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._邀请中) == null)
				{
					result = (this._邀请中 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请中, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请中, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x06020948 RID: 133448 RVA: 0x0094A424 File Offset: 0x00948624
		// (set) Token: 0x06020949 RID: 133449 RVA: 0x0094A45D File Offset: 0x0094865D
		public FGameplayTagContainer 牵手中
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._牵手中) == null)
				{
					result = (this._牵手中 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手中, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手中, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x0602094A RID: 133450 RVA: 0x0094A480 File Offset: 0x00948680
		// (set) Token: 0x0602094B RID: 133451 RVA: 0x0094A4B9 File Offset: 0x009486B9
		public FGameplayTagContainer 被牵手中
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._被牵手中) == null)
				{
					result = (this._被牵手中 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手中, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手中, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x0602094C RID: 133452 RVA: 0x0094A4DA File Offset: 0x009486DA
		// (set) Token: 0x0602094D RID: 133453 RVA: 0x0094A4EE File Offset: 0x009486EE
		public unsafe FGameplayTag 牵手范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手范围内);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手范围内) = value;
			}
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x0602094E RID: 133454 RVA: 0x0094A504 File Offset: 0x00948704
		// (set) Token: 0x0602094F RID: 133455 RVA: 0x0094A53D File Offset: 0x0094873D
		public FGameplayTagContainer 牵手禁止
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._牵手禁止) == null)
				{
					result = (this._牵手禁止 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手禁止, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手禁止, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x06020950 RID: 133456 RVA: 0x0094A55E File Offset: 0x0094875E
		// (set) Token: 0x06020951 RID: 133457 RVA: 0x0094A56E File Offset: 0x0094876E
		public unsafe float 超时终止时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_超时终止时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_超时终止时长) = value;
			}
		}

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x06020952 RID: 133458 RVA: 0x0094A57F File Offset: 0x0094877F
		// (set) Token: 0x06020953 RID: 133459 RVA: 0x0094A58F File Offset: 0x0094878F
		public unsafe float 进出牵手阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_进出牵手阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_进出牵手阻尼) = value;
			}
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x06020954 RID: 133460 RVA: 0x0094A5A0 File Offset: 0x009487A0
		// (set) Token: 0x06020955 RID: 133461 RVA: 0x0094A5B0 File Offset: 0x009487B0
		public unsafe float 跑步速度缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_跑步速度缩放);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_跑步速度缩放) = value;
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x06020956 RID: 133462 RVA: 0x0094A5C1 File Offset: 0x009487C1
		// (set) Token: 0x06020957 RID: 133463 RVA: 0x0094A5D1 File Offset: 0x009487D1
		public unsafe float 牵手点阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手点阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手点阻尼) = value;
			}
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x06020958 RID: 133464 RVA: 0x0094A5E2 File Offset: 0x009487E2
		// (set) Token: 0x06020959 RID: 133465 RVA: 0x0094A5F2 File Offset: 0x009487F2
		public unsafe float 长按退出时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_长按退出时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_长按退出时长) = value;
			}
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x0602095A RID: 133466 RVA: 0x0094A603 File Offset: 0x00948803
		// (set) Token: 0x0602095B RID: 133467 RVA: 0x0094A617 File Offset: 0x00948817
		public unsafe FFloatRange 牵手点偏转角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手点偏转角范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手点偏转角范围) = value;
			}
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x0602095C RID: 133468 RVA: 0x0094A62C File Offset: 0x0094882C
		// (set) Token: 0x0602095D RID: 133469 RVA: 0x0094A640 File Offset: 0x00948840
		public unsafe FFloatRange 牵手点俯仰角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手点俯仰角范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手点俯仰角范围) = value;
			}
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x0602095E RID: 133470 RVA: 0x0094A655 File Offset: 0x00948855
		// (set) Token: 0x0602095F RID: 133471 RVA: 0x0094A669 File Offset: 0x00948869
		public unsafe FFloatRange 肩部偏转角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_肩部偏转角范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_肩部偏转角范围) = value;
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x06020960 RID: 133472 RVA: 0x0094A67E File Offset: 0x0094887E
		// (set) Token: 0x06020961 RID: 133473 RVA: 0x0094A692 File Offset: 0x00948892
		public unsafe FFloatRange 肩部俯仰角范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_肩部俯仰角范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_肩部俯仰角范围) = value;
			}
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x06020962 RID: 133474 RVA: 0x0094A6A7 File Offset: 0x009488A7
		// (set) Token: 0x06020963 RID: 133475 RVA: 0x0094A6B7 File Offset: 0x009488B7
		public unsafe float 范围内额外角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内额外角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内额外角度) = value;
			}
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x06020964 RID: 133476 RVA: 0x0094A6C8 File Offset: 0x009488C8
		// (set) Token: 0x06020965 RID: 133477 RVA: 0x0094A6D8 File Offset: 0x009488D8
		public unsafe float 范围外可达距离缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围外可达距离缩放);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围外可达距离缩放) = value;
			}
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x06020966 RID: 133478 RVA: 0x0094A6E9 File Offset: 0x009488E9
		// (set) Token: 0x06020967 RID: 133479 RVA: 0x0094A6F9 File Offset: 0x009488F9
		public unsafe float 范围内可达距离缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内可达距离缩放);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内可达距离缩放) = value;
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x06020968 RID: 133480 RVA: 0x0094A70A File Offset: 0x0094890A
		// (set) Token: 0x06020969 RID: 133481 RVA: 0x0094A71A File Offset: 0x0094891A
		public unsafe float 范围外牵手点最大距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围外牵手点最大距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围外牵手点最大距离) = value;
			}
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x0602096A RID: 133482 RVA: 0x0094A72B File Offset: 0x0094892B
		// (set) Token: 0x0602096B RID: 133483 RVA: 0x0094A73B File Offset: 0x0094893B
		public unsafe float 范围内牵手点最大距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内牵手点最大距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内牵手点最大距离) = value;
			}
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x0602096C RID: 133484 RVA: 0x0094A74C File Offset: 0x0094894C
		// (set) Token: 0x0602096D RID: 133485 RVA: 0x0094A761 File Offset: 0x00948961
		public TSoftObjectPtr<BP_KeepFollowingConfig_C> 跟随配置
		{
			get
			{
				return new TSoftObjectPtr<BP_KeepFollowingConfig_C>(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_跟随配置, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_跟随配置, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x0602096E RID: 133486 RVA: 0x0094A786 File Offset: 0x00948986
		// (set) Token: 0x0602096F RID: 133487 RVA: 0x0094A796 File Offset: 0x00948996
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_Debug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_Debug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x06020970 RID: 133488 RVA: 0x0094A7A7 File Offset: 0x009489A7
		// (set) Token: 0x06020971 RID: 133489 RVA: 0x0094A7B7 File Offset: 0x009489B7
		public unsafe float 跑步最大旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_跑步最大旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_跑步最大旋转速度) = value;
			}
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x06020972 RID: 133490 RVA: 0x0094A7C8 File Offset: 0x009489C8
		// (set) Token: 0x06020973 RID: 133491 RVA: 0x0094A7D8 File Offset: 0x009489D8
		public unsafe float 走路最大旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_走路最大旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_走路最大旋转速度) = value;
			}
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x06020974 RID: 133492 RVA: 0x0094A7E9 File Offset: 0x009489E9
		// (set) Token: 0x06020975 RID: 133493 RVA: 0x0094A7F9 File Offset: 0x009489F9
		public unsafe int 牵手者碰撞优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手者碰撞优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手者碰撞优先级) = value;
			}
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x06020976 RID: 133494 RVA: 0x0094A80A File Offset: 0x00948A0A
		// (set) Token: 0x06020977 RID: 133495 RVA: 0x0094A81A File Offset: 0x00948A1A
		public unsafe int 被牵手者碰撞优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手者碰撞优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手者碰撞优先级) = value;
			}
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x06020978 RID: 133496 RVA: 0x0094A82B File Offset: 0x00948A2B
		// (set) Token: 0x06020979 RID: 133497 RVA: 0x0094A83B File Offset: 0x00948A3B
		public unsafe float 牵手者质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手者质量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手者质量) = value;
			}
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x0602097A RID: 133498 RVA: 0x0094A84C File Offset: 0x00948A4C
		// (set) Token: 0x0602097B RID: 133499 RVA: 0x0094A85C File Offset: 0x00948A5C
		public unsafe float 被牵手者质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手者质量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手者质量) = value;
			}
		}

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x0602097C RID: 133500 RVA: 0x0094A86D File Offset: 0x00948A6D
		// (set) Token: 0x0602097D RID: 133501 RVA: 0x0094A87D File Offset: 0x00948A7D
		public unsafe float 邀请距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请距离) = value;
			}
		}

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x0602097E RID: 133502 RVA: 0x0094A88E File Offset: 0x00948A8E
		// (set) Token: 0x0602097F RID: 133503 RVA: 0x0094A89E File Offset: 0x00948A9E
		public unsafe float 邀请距离容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请距离容差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请距离容差) = value;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x06020980 RID: 133504 RVA: 0x0094A8AF File Offset: 0x00948AAF
		// (set) Token: 0x06020981 RID: 133505 RVA: 0x0094A8BF File Offset: 0x00948ABF
		public unsafe float 邀请结束距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请结束距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请结束距离) = value;
			}
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x06020982 RID: 133506 RVA: 0x0094A8D0 File Offset: 0x00948AD0
		// (set) Token: 0x06020983 RID: 133507 RVA: 0x0094A8E0 File Offset: 0x00948AE0
		public unsafe float 邀请结束距离容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请结束距离容差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请结束距离容差) = value;
			}
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x06020984 RID: 133508 RVA: 0x0094A8F1 File Offset: 0x00948AF1
		// (set) Token: 0x06020985 RID: 133509 RVA: 0x0094A901 File Offset: 0x00948B01
		public unsafe float 邀请结束移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请结束移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请结束移动速度) = value;
			}
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x06020986 RID: 133510 RVA: 0x0094A912 File Offset: 0x00948B12
		// (set) Token: 0x06020987 RID: 133511 RVA: 0x0094A922 File Offset: 0x00948B22
		public unsafe float 邀请旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请旋转速度) = value;
			}
		}

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x06020988 RID: 133512 RVA: 0x0094A933 File Offset: 0x00948B33
		// (set) Token: 0x06020989 RID: 133513 RVA: 0x0094A943 File Offset: 0x00948B43
		public unsafe float 邀请时牵手点阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请时牵手点阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_邀请时牵手点阻尼) = value;
			}
		}

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x0602098A RID: 133514 RVA: 0x0094A954 File Offset: 0x00948B54
		// (set) Token: 0x0602098B RID: 133515 RVA: 0x0094A964 File Offset: 0x00948B64
		public unsafe float 手掌最小夹角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_手掌最小夹角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_手掌最小夹角) = value;
			}
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x0602098C RID: 133516 RVA: 0x0094A975 File Offset: 0x00948B75
		// (set) Token: 0x0602098D RID: 133517 RVA: 0x0094A985 File Offset: 0x00948B85
		public unsafe float 牵手者牵手点位置缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手者牵手点位置缩放);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_牵手者牵手点位置缩放) = value;
			}
		}

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x0602098E RID: 133518 RVA: 0x0094A996 File Offset: 0x00948B96
		// (set) Token: 0x0602098F RID: 133519 RVA: 0x0094A9A6 File Offset: 0x00948BA6
		public unsafe float 被牵手者牵手点位置缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手者牵手点位置缩放);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_被牵手者牵手点位置缩放) = value;
			}
		}

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x06020990 RID: 133520 RVA: 0x0094A9B7 File Offset: 0x00948BB7
		// (set) Token: 0x06020991 RID: 133521 RVA: 0x0094A9C7 File Offset: 0x00948BC7
		public unsafe float 贴合距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_贴合距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_贴合距离) = value;
			}
		}

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x06020992 RID: 133522 RVA: 0x0094A9D8 File Offset: 0x00948BD8
		// (set) Token: 0x06020993 RID: 133523 RVA: 0x0094A9E8 File Offset: 0x00948BE8
		public unsafe float 范围外肩部最大高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围外肩部最大高度差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围外肩部最大高度差) = value;
			}
		}

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x06020994 RID: 133524 RVA: 0x0094A9F9 File Offset: 0x00948BF9
		// (set) Token: 0x06020995 RID: 133525 RVA: 0x0094AA09 File Offset: 0x00948C09
		public unsafe float 范围内肩部最大高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内肩部最大高度差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoldingHandsConfig_C.__PropertyOffset_范围内肩部最大高度差) = value;
			}
		}

		// Token: 0x06020996 RID: 133526 RVA: 0x0094AA1A File Offset: 0x00948C1A
		protected BP_HoldingHandsConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119C2 RID: 72130
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_HoldingHandsConfig.BP_HoldingHandsConfig_C";

		// Token: 0x040119C3 RID: 72131
		private static IntPtr _ClassPtr;

		// Token: 0x040119C4 RID: 72132
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119C5 RID: 72133
		internal static int __PropertyOffset_邀请中;

		// Token: 0x040119C6 RID: 72134
		[Nullable(2)]
		private FGameplayTagContainer _邀请中;

		// Token: 0x040119C7 RID: 72135
		internal static int __PropertyOffset_牵手中;

		// Token: 0x040119C8 RID: 72136
		[Nullable(2)]
		private FGameplayTagContainer _牵手中;

		// Token: 0x040119C9 RID: 72137
		internal static int __PropertyOffset_被牵手中;

		// Token: 0x040119CA RID: 72138
		[Nullable(2)]
		private FGameplayTagContainer _被牵手中;

		// Token: 0x040119CB RID: 72139
		internal static int __PropertyOffset_牵手范围内;

		// Token: 0x040119CC RID: 72140
		internal static int __PropertyOffset_牵手禁止;

		// Token: 0x040119CD RID: 72141
		[Nullable(2)]
		private FGameplayTagContainer _牵手禁止;

		// Token: 0x040119CE RID: 72142
		internal static int __PropertyOffset_超时终止时长;

		// Token: 0x040119CF RID: 72143
		internal static int __PropertyOffset_进出牵手阻尼;

		// Token: 0x040119D0 RID: 72144
		internal static int __PropertyOffset_跑步速度缩放;

		// Token: 0x040119D1 RID: 72145
		internal static int __PropertyOffset_牵手点阻尼;

		// Token: 0x040119D2 RID: 72146
		internal static int __PropertyOffset_长按退出时长;

		// Token: 0x040119D3 RID: 72147
		internal static int __PropertyOffset_牵手点偏转角范围;

		// Token: 0x040119D4 RID: 72148
		internal static int __PropertyOffset_牵手点俯仰角范围;

		// Token: 0x040119D5 RID: 72149
		internal static int __PropertyOffset_肩部偏转角范围;

		// Token: 0x040119D6 RID: 72150
		internal static int __PropertyOffset_肩部俯仰角范围;

		// Token: 0x040119D7 RID: 72151
		internal static int __PropertyOffset_范围内额外角度;

		// Token: 0x040119D8 RID: 72152
		internal static int __PropertyOffset_范围外可达距离缩放;

		// Token: 0x040119D9 RID: 72153
		internal static int __PropertyOffset_范围内可达距离缩放;

		// Token: 0x040119DA RID: 72154
		internal static int __PropertyOffset_范围外牵手点最大距离;

		// Token: 0x040119DB RID: 72155
		internal static int __PropertyOffset_范围内牵手点最大距离;

		// Token: 0x040119DC RID: 72156
		internal static int __PropertyOffset_跟随配置;

		// Token: 0x040119DD RID: 72157
		internal static int __PropertyOffset_Debug;

		// Token: 0x040119DE RID: 72158
		internal static int __PropertyOffset_跑步最大旋转速度;

		// Token: 0x040119DF RID: 72159
		internal static int __PropertyOffset_走路最大旋转速度;

		// Token: 0x040119E0 RID: 72160
		internal static int __PropertyOffset_牵手者碰撞优先级;

		// Token: 0x040119E1 RID: 72161
		internal static int __PropertyOffset_被牵手者碰撞优先级;

		// Token: 0x040119E2 RID: 72162
		internal static int __PropertyOffset_牵手者质量;

		// Token: 0x040119E3 RID: 72163
		internal static int __PropertyOffset_被牵手者质量;

		// Token: 0x040119E4 RID: 72164
		internal static int __PropertyOffset_邀请距离;

		// Token: 0x040119E5 RID: 72165
		internal static int __PropertyOffset_邀请距离容差;

		// Token: 0x040119E6 RID: 72166
		internal static int __PropertyOffset_邀请结束距离;

		// Token: 0x040119E7 RID: 72167
		internal static int __PropertyOffset_邀请结束距离容差;

		// Token: 0x040119E8 RID: 72168
		internal static int __PropertyOffset_邀请结束移动速度;

		// Token: 0x040119E9 RID: 72169
		internal static int __PropertyOffset_邀请旋转速度;

		// Token: 0x040119EA RID: 72170
		internal static int __PropertyOffset_邀请时牵手点阻尼;

		// Token: 0x040119EB RID: 72171
		internal static int __PropertyOffset_手掌最小夹角;

		// Token: 0x040119EC RID: 72172
		internal static int __PropertyOffset_牵手者牵手点位置缩放;

		// Token: 0x040119ED RID: 72173
		internal static int __PropertyOffset_被牵手者牵手点位置缩放;

		// Token: 0x040119EE RID: 72174
		internal static int __PropertyOffset_贴合距离;

		// Token: 0x040119EF RID: 72175
		internal static int __PropertyOffset_范围外肩部最大高度差;

		// Token: 0x040119F0 RID: 72176
		internal static int __PropertyOffset_范围内肩部最大高度差;
	}
}
