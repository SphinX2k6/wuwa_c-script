using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.TeleControl
{
	// Token: 0x0200316C RID: 12652
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/TeleControl/BP_TeleControlConfig.BP_TeleControlConfig_C")]
	[UnrealStructLayout(792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 792)]
	public class BP_TeleControlConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F2FB RID: 127739 RVA: 0x009282CF File Offset: 0x009264CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TeleControlConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/TeleControl/BP_TeleControlConfig.BP_TeleControlConfig_C");
			}
			return BP_TeleControlConfig_C._ClassPtr;
		}

		// Token: 0x0601F2FC RID: 127740 RVA: 0x009282F4 File Offset: 0x009264F4
		public BP_TeleControlConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_TeleControlConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F2FD RID: 127741 RVA: 0x0092831C File Offset: 0x0092651C
		public BP_TeleControlConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TeleControlConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0601F2FE RID: 127742 RVA: 0x0092834F File Offset: 0x0092654F
		// (set) Token: 0x0601F2FF RID: 127743 RVA: 0x0092835F File Offset: 0x0092655F
		public unsafe float 读条时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_读条时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_读条时间) = value;
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0601F300 RID: 127744 RVA: 0x00928370 File Offset: 0x00926570
		// (set) Token: 0x0601F301 RID: 127745 RVA: 0x00928380 File Offset: 0x00926580
		public unsafe bool 未锁定目标时不可投掷
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_未锁定目标时不可投掷) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_未锁定目标时不可投掷) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0601F302 RID: 127746 RVA: 0x00928391 File Offset: 0x00926591
		// (set) Token: 0x0601F303 RID: 127747 RVA: 0x009283A1 File Offset: 0x009265A1
		public unsafe float 摆动频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_摆动频率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_摆动频率) = value;
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0601F304 RID: 127748 RVA: 0x009283B2 File Offset: 0x009265B2
		// (set) Token: 0x0601F305 RID: 127749 RVA: 0x009283C2 File Offset: 0x009265C2
		public unsafe float 吸取延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取延迟);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取延迟) = value;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0601F306 RID: 127750 RVA: 0x009283D3 File Offset: 0x009265D3
		// (set) Token: 0x0601F307 RID: 127751 RVA: 0x009283E3 File Offset: 0x009265E3
		public unsafe float 线性阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_线性阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_线性阻尼) = value;
			}
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0601F308 RID: 127752 RVA: 0x009283F4 File Offset: 0x009265F4
		// (set) Token: 0x0601F309 RID: 127753 RVA: 0x00928404 File Offset: 0x00926604
		public unsafe float 角刚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角刚度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角刚度) = value;
			}
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0601F30A RID: 127754 RVA: 0x00928415 File Offset: 0x00926615
		// (set) Token: 0x0601F30B RID: 127755 RVA: 0x00928425 File Offset: 0x00926625
		public unsafe float 线性刚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_线性刚度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_线性刚度) = value;
			}
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0601F30C RID: 127756 RVA: 0x00928436 File Offset: 0x00926636
		// (set) Token: 0x0601F30D RID: 127757 RVA: 0x00928446 File Offset: 0x00926646
		public unsafe float 角度阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角度阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角度阻尼) = value;
			}
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0601F30E RID: 127758 RVA: 0x00928457 File Offset: 0x00926657
		// (set) Token: 0x0601F30F RID: 127759 RVA: 0x00928467 File Offset: 0x00926667
		public unsafe float 吸取时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取时间) = value;
			}
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0601F310 RID: 127760 RVA: 0x00928478 File Offset: 0x00926678
		// (set) Token: 0x0601F311 RID: 127761 RVA: 0x00928488 File Offset: 0x00926688
		public unsafe float 对齐时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_对齐时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_对齐时间) = value;
			}
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0601F312 RID: 127762 RVA: 0x00928499 File Offset: 0x00926699
		// (set) Token: 0x0601F313 RID: 127763 RVA: 0x009284A9 File Offset: 0x009266A9
		public unsafe float 牵引高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_牵引高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_牵引高度) = value;
			}
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0601F314 RID: 127764 RVA: 0x009284BA File Offset: 0x009266BA
		// (set) Token: 0x0601F315 RID: 127765 RVA: 0x009284CA File Offset: 0x009266CA
		public unsafe float 角速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角速度) = value;
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0601F316 RID: 127766 RVA: 0x009284DB File Offset: 0x009266DB
		// (set) Token: 0x0601F317 RID: 127767 RVA: 0x009284EB File Offset: 0x009266EB
		public unsafe float 摆动范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_摆动范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_摆动范围) = value;
			}
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0601F318 RID: 127768 RVA: 0x009284FC File Offset: 0x009266FC
		// (set) Token: 0x0601F319 RID: 127769 RVA: 0x00928510 File Offset: 0x00926710
		public unsafe FVector 旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_旋转) = value;
			}
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0601F31A RID: 127770 RVA: 0x00928525 File Offset: 0x00926725
		// (set) Token: 0x0601F31B RID: 127771 RVA: 0x00928539 File Offset: 0x00926739
		public unsafe FVector 一级偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_一级偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_一级偏移) = value;
			}
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x0601F31C RID: 127772 RVA: 0x0092854E File Offset: 0x0092674E
		// (set) Token: 0x0601F31D RID: 127773 RVA: 0x00928562 File Offset: 0x00926762
		public unsafe FVector 二级偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_二级偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_二级偏移) = value;
			}
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x0601F31E RID: 127774 RVA: 0x00928577 File Offset: 0x00926777
		// (set) Token: 0x0601F31F RID: 127775 RVA: 0x0092858B File Offset: 0x0092678B
		public unsafe FGameplayTag 控物保持镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物保持镜头);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物保持镜头) = value;
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x0601F320 RID: 127776 RVA: 0x009285A0 File Offset: 0x009267A0
		// (set) Token: 0x0601F321 RID: 127777 RVA: 0x009285B4 File Offset: 0x009267B4
		public unsafe FGameplayTag 读条镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_读条镜头);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_读条镜头) = value;
			}
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0601F322 RID: 127778 RVA: 0x009285C9 File Offset: 0x009267C9
		// (set) Token: 0x0601F323 RID: 127779 RVA: 0x009285DD File Offset: 0x009267DD
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
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_读条震屏);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_读条震屏) = value;
			}
		}

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0601F324 RID: 127780 RVA: 0x009285F2 File Offset: 0x009267F2
		// (set) Token: 0x0601F325 RID: 127781 RVA: 0x00928602 File Offset: 0x00926802
		public unsafe float 被控制CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_被控制CD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_被控制CD) = value;
			}
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0601F326 RID: 127782 RVA: 0x00928613 File Offset: 0x00926813
		// (set) Token: 0x0601F327 RID: 127783 RVA: 0x00928627 File Offset: 0x00926827
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
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物保持震屏);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物保持震屏) = value;
			}
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0601F328 RID: 127784 RVA: 0x0092863C File Offset: 0x0092683C
		// (set) Token: 0x0601F329 RID: 127785 RVA: 0x00928650 File Offset: 0x00926850
		public unsafe FGameplayTag 吸取飞行镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取飞行镜头);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取飞行镜头) = value;
			}
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0601F32A RID: 127786 RVA: 0x00928665 File Offset: 0x00926865
		// (set) Token: 0x0601F32B RID: 127787 RVA: 0x00928679 File Offset: 0x00926879
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
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取飞行震屏);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取飞行震屏) = value;
			}
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0601F32C RID: 127788 RVA: 0x0092868E File Offset: 0x0092688E
		// (set) Token: 0x0601F32D RID: 127789 RVA: 0x0092869E File Offset: 0x0092689E
		public unsafe bool 打开速度Log
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_打开速度Log) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_打开速度Log) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0601F32E RID: 127790 RVA: 0x009286AF File Offset: 0x009268AF
		// (set) Token: 0x0601F32F RID: 127791 RVA: 0x009286BF File Offset: 0x009268BF
		public unsafe float 可再被控速度最小值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_可再被控速度最小值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_可再被控速度最小值) = value;
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0601F330 RID: 127792 RVA: 0x009286D0 File Offset: 0x009268D0
		// (set) Token: 0x0601F331 RID: 127793 RVA: 0x009286E0 File Offset: 0x009268E0
		public unsafe float 被感知范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_被感知范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_被感知范围) = value;
			}
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0601F332 RID: 127794 RVA: 0x009286F4 File Offset: 0x009268F4
		// (set) Token: 0x0601F333 RID: 127795 RVA: 0x0092872D File Offset: 0x0092692D
		public TMap<float, float> 被感知角度权重
		{
			get
			{
				base.FastCheckIsValid();
				TMap<float, float> result;
				if ((result = this._被感知角度权重) == null)
				{
					result = (this._被感知角度权重 = new TMap<float, float>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_被感知角度权重, this));
				}
				return result;
			}
			set
			{
				this.被感知角度权重.CopyAssign(value);
			}
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0601F334 RID: 127796 RVA: 0x0092873B File Offset: 0x0092693B
		// (set) Token: 0x0601F335 RID: 127797 RVA: 0x0092874F File Offset: 0x0092694F
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
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷震屏);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷震屏) = value;
			}
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0601F336 RID: 127798 RVA: 0x00928764 File Offset: 0x00926964
		// (set) Token: 0x0601F337 RID: 127799 RVA: 0x00928774 File Offset: 0x00926974
		public unsafe bool 随速度调整朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_随速度调整朝向) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_随速度调整朝向) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0601F338 RID: 127800 RVA: 0x00928785 File Offset: 0x00926985
		// (set) Token: 0x0601F339 RID: 127801 RVA: 0x00928795 File Offset: 0x00926995
		public unsafe bool 控物保持使用物理
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物保持使用物理) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物保持使用物理) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0601F33A RID: 127802 RVA: 0x009287A6 File Offset: 0x009269A6
		// (set) Token: 0x0601F33B RID: 127803 RVA: 0x009287B6 File Offset: 0x009269B6
		public unsafe float 无锁状态附加仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_无锁状态附加仰角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_无锁状态附加仰角) = value;
			}
		}

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0601F33C RID: 127804 RVA: 0x009287C8 File Offset: 0x009269C8
		// (set) Token: 0x0601F33D RID: 127805 RVA: 0x00928801 File Offset: 0x00926A01
		public TArray<FGameplayTag> 控物保持标签
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._控物保持标签) == null)
				{
					result = (this._控物保持标签 = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物保持标签, this));
				}
				return result;
			}
			set
			{
				this.控物保持标签.CopyAssign(value);
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0601F33E RID: 127806 RVA: 0x0092880F File Offset: 0x00926A0F
		// (set) Token: 0x0601F33F RID: 127807 RVA: 0x00928823 File Offset: 0x00926A23
		public unsafe FVector 被感知坐标偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_被感知坐标偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_被感知坐标偏移) = value;
			}
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0601F340 RID: 127808 RVA: 0x00928838 File Offset: 0x00926A38
		// (set) Token: 0x0601F341 RID: 127809 RVA: 0x00928848 File Offset: 0x00926A48
		public unsafe float 物体质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_物体质量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_物体质量) = value;
			}
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0601F342 RID: 127810 RVA: 0x00928859 File Offset: 0x00926A59
		// (set) Token: 0x0601F343 RID: 127811 RVA: 0x00928869 File Offset: 0x00926A69
		public unsafe float 物体线性阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_物体线性阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_物体线性阻尼) = value;
			}
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0601F344 RID: 127812 RVA: 0x0092887A File Offset: 0x00926A7A
		// (set) Token: 0x0601F345 RID: 127813 RVA: 0x0092888A File Offset: 0x00926A8A
		public unsafe float 物体角速度阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_物体角速度阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_物体角速度阻尼) = value;
			}
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0601F346 RID: 127814 RVA: 0x0092889B File Offset: 0x00926A9B
		// (set) Token: 0x0601F347 RID: 127815 RVA: 0x009288AF File Offset: 0x00926AAF
		public unsafe string 控物准星资源ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物准星资源ID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_TeleControlConfig_C.__PropertyOffset_控物准星资源ID)), value);
			}
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0601F348 RID: 127816 RVA: 0x009288C4 File Offset: 0x00926AC4
		// (set) Token: 0x0601F349 RID: 127817 RVA: 0x009288D4 File Offset: 0x00926AD4
		public unsafe bool 角色是否随相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角色是否随相机旋转) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_角色是否随相机旋转) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0601F34A RID: 127818 RVA: 0x009288E5 File Offset: 0x00926AE5
		// (set) Token: 0x0601F34B RID: 127819 RVA: 0x009288F9 File Offset: 0x00926AF9
		public unsafe FName 待机状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_待机状态碰撞预设);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_待机状态碰撞预设) = value;
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0601F34C RID: 127820 RVA: 0x0092890E File Offset: 0x00926B0E
		// (set) Token: 0x0601F34D RID: 127821 RVA: 0x00928922 File Offset: 0x00926B22
		public unsafe FName 吸取状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取状态碰撞预设);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取状态碰撞预设) = value;
			}
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0601F34E RID: 127822 RVA: 0x00928937 File Offset: 0x00926B37
		// (set) Token: 0x0601F34F RID: 127823 RVA: 0x0092894B File Offset: 0x00926B4B
		public unsafe FName 保持状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_保持状态碰撞预设);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_保持状态碰撞预设) = value;
			}
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0601F350 RID: 127824 RVA: 0x00928960 File Offset: 0x00926B60
		// (set) Token: 0x0601F351 RID: 127825 RVA: 0x00928974 File Offset: 0x00926B74
		public unsafe FName 投掷状态碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷状态碰撞预设);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷状态碰撞预设) = value;
			}
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0601F352 RID: 127826 RVA: 0x00928989 File Offset: 0x00926B89
		// (set) Token: 0x0601F353 RID: 127827 RVA: 0x0092899D File Offset: 0x00926B9D
		[Nullable(2)]
		public unsafe UCurveVector 投掷运动轨迹曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_投掷运动轨迹曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_投掷运动轨迹曲线, value);
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0601F354 RID: 127828 RVA: 0x009289B2 File Offset: 0x00926BB2
		// (set) Token: 0x0601F355 RID: 127829 RVA: 0x009289C2 File Offset: 0x00926BC2
		public unsafe bool 抛物瞄准射线Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准射线Debug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准射线Debug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0601F356 RID: 127830 RVA: 0x009289D3 File Offset: 0x00926BD3
		// (set) Token: 0x0601F357 RID: 127831 RVA: 0x009289E3 File Offset: 0x00926BE3
		public unsafe bool 抛物瞄准模式开关
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式开关) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式开关) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0601F358 RID: 127832 RVA: 0x009289F4 File Offset: 0x00926BF4
		// (set) Token: 0x0601F359 RID: 127833 RVA: 0x00928A04 File Offset: 0x00926C04
		public unsafe float 抛物瞄准模式仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式仰角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式仰角) = value;
			}
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0601F35A RID: 127834 RVA: 0x00928A15 File Offset: 0x00926C15
		// (set) Token: 0x0601F35B RID: 127835 RVA: 0x00928A25 File Offset: 0x00926C25
		public unsafe float 抛物瞄准模式初速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式初速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式初速度) = value;
			}
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0601F35C RID: 127836 RVA: 0x00928A36 File Offset: 0x00926C36
		// (set) Token: 0x0601F35D RID: 127837 RVA: 0x00928A46 File Offset: 0x00926C46
		public unsafe float 抛物瞄准射线检测半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准射线检测半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准射线检测半径) = value;
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0601F35E RID: 127838 RVA: 0x00928A57 File Offset: 0x00926C57
		// (set) Token: 0x0601F35F RID: 127839 RVA: 0x00928A6B File Offset: 0x00926C6B
		public unsafe FGameplayTag 抛物瞄准模式镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式镜头);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式镜头) = value;
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0601F360 RID: 127840 RVA: 0x00928A80 File Offset: 0x00926C80
		// (set) Token: 0x0601F361 RID: 127841 RVA: 0x00928AB9 File Offset: 0x00926CB9
		public FSoftObjectPath 抛物瞄准模式样条特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._抛物瞄准模式样条特效) == null)
				{
					result = (this._抛物瞄准模式样条特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式样条特效, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式样条特效, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0601F362 RID: 127842 RVA: 0x00928ADC File Offset: 0x00926CDC
		// (set) Token: 0x0601F363 RID: 127843 RVA: 0x00928B15 File Offset: 0x00926D15
		public FSoftObjectPath 抛物瞄准模式终点特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._抛物瞄准模式终点特效) == null)
				{
					result = (this._抛物瞄准模式终点特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式终点特效, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式终点特效, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0601F364 RID: 127844 RVA: 0x00928B36 File Offset: 0x00926D36
		// (set) Token: 0x0601F365 RID: 127845 RVA: 0x00928B46 File Offset: 0x00926D46
		public unsafe float 抛物瞄准模式重力加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式重力加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_抛物瞄准模式重力加速度) = value;
			}
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0601F366 RID: 127846 RVA: 0x00928B57 File Offset: 0x00926D57
		// (set) Token: 0x0601F367 RID: 127847 RVA: 0x00928B67 File Offset: 0x00926D67
		public unsafe float 投掷锁定范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷锁定范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷锁定范围) = value;
			}
		}

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0601F368 RID: 127848 RVA: 0x00928B78 File Offset: 0x00926D78
		// (set) Token: 0x0601F369 RID: 127849 RVA: 0x00928BB1 File Offset: 0x00926DB1
		public FSoftObjectPath 归位消失特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._归位消失特效) == null)
				{
					result = (this._归位消失特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_归位消失特效, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_归位消失特效, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0601F36A RID: 127850 RVA: 0x00928BD4 File Offset: 0x00926DD4
		// (set) Token: 0x0601F36B RID: 127851 RVA: 0x00928C0D File Offset: 0x00926E0D
		public TMap<int, float> 投掷状态CueId
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._投掷状态CueId) == null)
				{
					result = (this._投掷状态CueId = new TMap<int, float>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷状态CueId, this));
				}
				return result;
			}
			set
			{
				this.投掷状态CueId.CopyAssign(value);
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0601F36C RID: 127852 RVA: 0x00928C1B File Offset: 0x00926E1B
		// (set) Token: 0x0601F36D RID: 127853 RVA: 0x00928C2F File Offset: 0x00926E2F
		[Nullable(2)]
		public unsafe UPhysicalMaterial 物体物理材质
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_物体物理材质);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TeleControlConfig_C.__PropertyOffset_物体物理材质, value);
			}
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0601F36E RID: 127854 RVA: 0x00928C44 File Offset: 0x00926E44
		// (set) Token: 0x0601F36F RID: 127855 RVA: 0x00928C59 File Offset: 0x00926E59
		public TSoftObjectPtr<UKuroForceFeedbackEffect> 吸取飞行手柄震动
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取飞行手柄震动, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_吸取飞行手柄震动, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0601F370 RID: 127856 RVA: 0x00928C7E File Offset: 0x00926E7E
		// (set) Token: 0x0601F371 RID: 127857 RVA: 0x00928C93 File Offset: 0x00926E93
		public TSoftObjectPtr<UKuroForceFeedbackEffect> 投掷手柄震动
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷手柄震动, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_TeleControlConfig_C.__PropertyOffset_投掷手柄震动, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F372 RID: 127858 RVA: 0x00928CB8 File Offset: 0x00926EB8
		protected BP_TeleControlConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010AD2 RID: 68306
		public new const string __ObjectPath = "/Game/Aki/Data/TeleControl/BP_TeleControlConfig.BP_TeleControlConfig_C";

		// Token: 0x04010AD3 RID: 68307
		private static IntPtr _ClassPtr;

		// Token: 0x04010AD4 RID: 68308
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010AD5 RID: 68309
		internal static int __PropertyOffset_读条时间;

		// Token: 0x04010AD6 RID: 68310
		internal static int __PropertyOffset_未锁定目标时不可投掷;

		// Token: 0x04010AD7 RID: 68311
		internal static int __PropertyOffset_摆动频率;

		// Token: 0x04010AD8 RID: 68312
		internal static int __PropertyOffset_吸取延迟;

		// Token: 0x04010AD9 RID: 68313
		internal static int __PropertyOffset_线性阻尼;

		// Token: 0x04010ADA RID: 68314
		internal static int __PropertyOffset_角刚度;

		// Token: 0x04010ADB RID: 68315
		internal static int __PropertyOffset_线性刚度;

		// Token: 0x04010ADC RID: 68316
		internal static int __PropertyOffset_角度阻尼;

		// Token: 0x04010ADD RID: 68317
		internal static int __PropertyOffset_吸取时间;

		// Token: 0x04010ADE RID: 68318
		internal static int __PropertyOffset_对齐时间;

		// Token: 0x04010ADF RID: 68319
		internal static int __PropertyOffset_牵引高度;

		// Token: 0x04010AE0 RID: 68320
		internal static int __PropertyOffset_角速度;

		// Token: 0x04010AE1 RID: 68321
		internal static int __PropertyOffset_摆动范围;

		// Token: 0x04010AE2 RID: 68322
		internal static int __PropertyOffset_旋转;

		// Token: 0x04010AE3 RID: 68323
		internal static int __PropertyOffset_一级偏移;

		// Token: 0x04010AE4 RID: 68324
		internal static int __PropertyOffset_二级偏移;

		// Token: 0x04010AE5 RID: 68325
		internal static int __PropertyOffset_控物保持镜头;

		// Token: 0x04010AE6 RID: 68326
		internal static int __PropertyOffset_读条镜头;

		// Token: 0x04010AE7 RID: 68327
		internal static int __PropertyOffset_读条震屏;

		// Token: 0x04010AE8 RID: 68328
		internal static int __PropertyOffset_被控制CD;

		// Token: 0x04010AE9 RID: 68329
		internal static int __PropertyOffset_控物保持震屏;

		// Token: 0x04010AEA RID: 68330
		internal static int __PropertyOffset_吸取飞行镜头;

		// Token: 0x04010AEB RID: 68331
		internal static int __PropertyOffset_吸取飞行震屏;

		// Token: 0x04010AEC RID: 68332
		internal static int __PropertyOffset_打开速度Log;

		// Token: 0x04010AED RID: 68333
		internal static int __PropertyOffset_可再被控速度最小值;

		// Token: 0x04010AEE RID: 68334
		internal static int __PropertyOffset_被感知范围;

		// Token: 0x04010AEF RID: 68335
		internal static int __PropertyOffset_被感知角度权重;

		// Token: 0x04010AF0 RID: 68336
		[Nullable(2)]
		private TMap<float, float> _被感知角度权重;

		// Token: 0x04010AF1 RID: 68337
		internal static int __PropertyOffset_投掷震屏;

		// Token: 0x04010AF2 RID: 68338
		internal static int __PropertyOffset_随速度调整朝向;

		// Token: 0x04010AF3 RID: 68339
		internal static int __PropertyOffset_控物保持使用物理;

		// Token: 0x04010AF4 RID: 68340
		internal static int __PropertyOffset_无锁状态附加仰角;

		// Token: 0x04010AF5 RID: 68341
		internal static int __PropertyOffset_控物保持标签;

		// Token: 0x04010AF6 RID: 68342
		[Nullable(2)]
		private TArray<FGameplayTag> _控物保持标签;

		// Token: 0x04010AF7 RID: 68343
		internal static int __PropertyOffset_被感知坐标偏移;

		// Token: 0x04010AF8 RID: 68344
		internal static int __PropertyOffset_物体质量;

		// Token: 0x04010AF9 RID: 68345
		internal static int __PropertyOffset_物体线性阻尼;

		// Token: 0x04010AFA RID: 68346
		internal static int __PropertyOffset_物体角速度阻尼;

		// Token: 0x04010AFB RID: 68347
		internal static int __PropertyOffset_控物准星资源ID;

		// Token: 0x04010AFC RID: 68348
		internal static int __PropertyOffset_角色是否随相机旋转;

		// Token: 0x04010AFD RID: 68349
		internal static int __PropertyOffset_待机状态碰撞预设;

		// Token: 0x04010AFE RID: 68350
		internal static int __PropertyOffset_吸取状态碰撞预设;

		// Token: 0x04010AFF RID: 68351
		internal static int __PropertyOffset_保持状态碰撞预设;

		// Token: 0x04010B00 RID: 68352
		internal static int __PropertyOffset_投掷状态碰撞预设;

		// Token: 0x04010B01 RID: 68353
		internal static int __PropertyOffset_投掷运动轨迹曲线;

		// Token: 0x04010B02 RID: 68354
		internal static int __PropertyOffset_抛物瞄准射线Debug;

		// Token: 0x04010B03 RID: 68355
		internal static int __PropertyOffset_抛物瞄准模式开关;

		// Token: 0x04010B04 RID: 68356
		internal static int __PropertyOffset_抛物瞄准模式仰角;

		// Token: 0x04010B05 RID: 68357
		internal static int __PropertyOffset_抛物瞄准模式初速度;

		// Token: 0x04010B06 RID: 68358
		internal static int __PropertyOffset_抛物瞄准射线检测半径;

		// Token: 0x04010B07 RID: 68359
		internal static int __PropertyOffset_抛物瞄准模式镜头;

		// Token: 0x04010B08 RID: 68360
		internal static int __PropertyOffset_抛物瞄准模式样条特效;

		// Token: 0x04010B09 RID: 68361
		[Nullable(2)]
		private FSoftObjectPath _抛物瞄准模式样条特效;

		// Token: 0x04010B0A RID: 68362
		internal static int __PropertyOffset_抛物瞄准模式终点特效;

		// Token: 0x04010B0B RID: 68363
		[Nullable(2)]
		private FSoftObjectPath _抛物瞄准模式终点特效;

		// Token: 0x04010B0C RID: 68364
		internal static int __PropertyOffset_抛物瞄准模式重力加速度;

		// Token: 0x04010B0D RID: 68365
		internal static int __PropertyOffset_投掷锁定范围;

		// Token: 0x04010B0E RID: 68366
		internal static int __PropertyOffset_归位消失特效;

		// Token: 0x04010B0F RID: 68367
		[Nullable(2)]
		private FSoftObjectPath _归位消失特效;

		// Token: 0x04010B10 RID: 68368
		internal static int __PropertyOffset_投掷状态CueId;

		// Token: 0x04010B11 RID: 68369
		[Nullable(2)]
		private TMap<int, float> _投掷状态CueId;

		// Token: 0x04010B12 RID: 68370
		internal static int __PropertyOffset_物体物理材质;

		// Token: 0x04010B13 RID: 68371
		internal static int __PropertyOffset_吸取飞行手柄震动;

		// Token: 0x04010B14 RID: 68372
		internal static int __PropertyOffset_投掷手柄震动;
	}
}
