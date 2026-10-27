using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F73 RID: 16243
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SReBulletDataBase_ExcelTest.SReBulletDataBase_ExcelTest")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 482)]
	public class SReBulletDataBase_ExcelTest : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060296E0 RID: 169696 RVA: 0x009C3F19 File Offset: 0x009C2119
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataBase_ExcelTest._ScriptStructPtr != 0) ? SReBulletDataBase_ExcelTest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SReBulletDataBase_ExcelTest.SReBulletDataBase_ExcelTest", ref SReBulletDataBase_ExcelTest._ScriptStructPtr);
		}

		// Token: 0x1700632A RID: 25386
		// (get) Token: 0x060296E1 RID: 169697 RVA: 0x009C3F3D File Offset: 0x009C213D
		// (set) Token: 0x060296E2 RID: 169698 RVA: 0x009C3F51 File Offset: 0x009C2151
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletShape> 子弹形状
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700632B RID: 25387
		// (get) Token: 0x060296E3 RID: 169699 RVA: 0x009C3F66 File Offset: 0x009C2166
		// (set) Token: 0x060296E4 RID: 169700 RVA: 0x009C3F7A File Offset: 0x009C217A
		public unsafe FVector 初始大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700632C RID: 25388
		// (get) Token: 0x060296E5 RID: 169701 RVA: 0x009C3F90 File Offset: 0x009C2190
		// (set) Token: 0x060296E6 RID: 169702 RVA: 0x009C3FD3 File Offset: 0x009C21D3
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EBulletBaseSpecificParam>, string> 特殊参数
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EBulletBaseSpecificParam>, string> result;
				if ((result = this._特殊参数) == null)
				{
					result = (this._特殊参数 = new TMap<TEnumAsByte<EBulletBaseSpecificParam>, string>(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.特殊参数.CopyAssign(value);
			}
		}

		// Token: 0x1700632D RID: 25389
		// (get) Token: 0x060296E7 RID: 169703 RVA: 0x009C3FE1 File Offset: 0x009C21E1
		// (set) Token: 0x060296E8 RID: 169704 RVA: 0x009C3FF5 File Offset: 0x009C21F5
		public unsafe TEnumAsByte<EPositionStandard> 出生位置基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700632E RID: 25390
		// (get) Token: 0x060296E9 RID: 169705 RVA: 0x009C400A File Offset: 0x009C220A
		// (set) Token: 0x060296EA RID: 169706 RVA: 0x009C401E File Offset: 0x009C221E
		[Nullable(1)]
		public unsafe string 攻击者黑板Key值
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_4)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x1700632F RID: 25391
		// (get) Token: 0x060296EB RID: 169707 RVA: 0x009C4033 File Offset: 0x009C2233
		// (set) Token: 0x060296EC RID: 169708 RVA: 0x009C4047 File Offset: 0x009C2247
		public unsafe FVector 出生位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006330 RID: 25392
		// (get) Token: 0x060296ED RID: 169709 RVA: 0x009C405C File Offset: 0x009C225C
		// (set) Token: 0x060296EE RID: 169710 RVA: 0x009C4070 File Offset: 0x009C2270
		public unsafe FVector 中心位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006331 RID: 25393
		// (get) Token: 0x060296EF RID: 169711 RVA: 0x009C4085 File Offset: 0x009C2285
		// (set) Token: 0x060296F0 RID: 169712 RVA: 0x009C4099 File Offset: 0x009C2299
		public unsafe FVector 出生位置随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006332 RID: 25394
		// (get) Token: 0x060296F1 RID: 169713 RVA: 0x009C40AE File Offset: 0x009C22AE
		// (set) Token: 0x060296F2 RID: 169714 RVA: 0x009C40C2 File Offset: 0x009C22C2
		public unsafe FRotator 初始旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006333 RID: 25395
		// (get) Token: 0x060296F3 RID: 169715 RVA: 0x009C40D7 File Offset: 0x009C22D7
		// (set) Token: 0x060296F4 RID: 169716 RVA: 0x009C40EB File Offset: 0x009C22EB
		public unsafe FVector 限制生成距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006334 RID: 25396
		// (get) Token: 0x060296F5 RID: 169717 RVA: 0x009C4100 File Offset: 0x009C2300
		// (set) Token: 0x060296F6 RID: 169718 RVA: 0x009C4110 File Offset: 0x009C2310
		public unsafe float 持续时间字段改名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006335 RID: 25397
		// (get) Token: 0x060296F7 RID: 169719 RVA: 0x009C4121 File Offset: 0x009C2321
		// (set) Token: 0x060296F8 RID: 169720 RVA: 0x009C4131 File Offset: 0x009C2331
		public unsafe float 碰撞判定时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006336 RID: 25398
		// (get) Token: 0x060296F9 RID: 169721 RVA: 0x009C4142 File Offset: 0x009C2342
		// (set) Token: 0x060296FA RID: 169722 RVA: 0x009C4152 File Offset: 0x009C2352
		public unsafe float 碰撞判定延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006337 RID: 25399
		// (get) Token: 0x060296FB RID: 169723 RVA: 0x009C4163 File Offset: 0x009C2363
		// (set) Token: 0x060296FC RID: 169724 RVA: 0x009C4177 File Offset: 0x009C2377
		public unsafe TEnumAsByte<EHitType> 命中判定类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006338 RID: 25400
		// (get) Token: 0x060296FD RID: 169725 RVA: 0x009C418C File Offset: 0x009C238C
		// (set) Token: 0x060296FE RID: 169726 RVA: 0x009C41AB File Offset: 0x009C23AB
		[Nullable(1)]
		public TSoftObjectPtr<BulletCampType_C> 命中判定类型预设
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<BulletCampType_C>(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_14, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006339 RID: 25401
		// (get) Token: 0x060296FF RID: 169727 RVA: 0x009C41D0 File Offset: 0x009C23D0
		// (set) Token: 0x06029700 RID: 169728 RVA: 0x009C41E4 File Offset: 0x009C23E4
		public unsafe FGameplayTag 命中判定Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700633A RID: 25402
		// (get) Token: 0x06029701 RID: 169729 RVA: 0x009C41F9 File Offset: 0x009C23F9
		// (set) Token: 0x06029702 RID: 169730 RVA: 0x009C420D File Offset: 0x009C240D
		public unsafe FGameplayTag 禁止命中Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700633B RID: 25403
		// (get) Token: 0x06029703 RID: 169731 RVA: 0x009C4222 File Offset: 0x009C2422
		// (set) Token: 0x06029704 RID: 169732 RVA: 0x009C4232 File Offset: 0x009C2432
		public unsafe int 命中个数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700633C RID: 25404
		// (get) Token: 0x06029705 RID: 169733 RVA: 0x009C4243 File Offset: 0x009C2443
		// (set) Token: 0x06029706 RID: 169734 RVA: 0x009C4253 File Offset: 0x009C2453
		public unsafe int 每个单位总作用次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700633D RID: 25405
		// (get) Token: 0x06029707 RID: 169735 RVA: 0x009C4264 File Offset: 0x009C2464
		// (set) Token: 0x06029708 RID: 169736 RVA: 0x009C4274 File Offset: 0x009C2474
		public unsafe int 总作用次数限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700633E RID: 25406
		// (get) Token: 0x06029709 RID: 169737 RVA: 0x009C4285 File Offset: 0x009C2485
		// (set) Token: 0x0602970A RID: 169738 RVA: 0x009C4295 File Offset: 0x009C2495
		public unsafe float 作用间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700633F RID: 25407
		// (get) Token: 0x0602970B RID: 169739 RVA: 0x009C42A6 File Offset: 0x009C24A6
		// (set) Token: 0x0602970C RID: 169740 RVA: 0x009C42B6 File Offset: 0x009C24B6
		public unsafe bool 作用间隔基于个体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006340 RID: 25408
		// (get) Token: 0x0602970D RID: 169741 RVA: 0x009C42C7 File Offset: 0x009C24C7
		// (set) Token: 0x0602970E RID: 169742 RVA: 0x009C42D7 File Offset: 0x009C24D7
		public unsafe bool 共享父子弹次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006341 RID: 25409
		// (get) Token: 0x0602970F RID: 169743 RVA: 0x009C42E8 File Offset: 0x009C24E8
		// (set) Token: 0x06029710 RID: 169744 RVA: 0x009C42FC File Offset: 0x009C24FC
		public unsafe FName 被击效果
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006342 RID: 25410
		// (get) Token: 0x06029711 RID: 169745 RVA: 0x009C4311 File Offset: 0x009C2511
		// (set) Token: 0x06029712 RID: 169746 RVA: 0x009C4325 File Offset: 0x009C2525
		public unsafe FName 弱点被击效果
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006343 RID: 25411
		// (get) Token: 0x06029713 RID: 169747 RVA: 0x009C433A File Offset: 0x009C253A
		// (set) Token: 0x06029714 RID: 169748 RVA: 0x009C434E File Offset: 0x009C254E
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletRelativeDir> 子弹受击方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17006344 RID: 25412
		// (get) Token: 0x06029715 RID: 169749 RVA: 0x009C4363 File Offset: 0x009C2563
		// (set) Token: 0x06029716 RID: 169750 RVA: 0x009C4373 File Offset: 0x009C2573
		public unsafe long 伤害ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17006345 RID: 25413
		// (get) Token: 0x06029717 RID: 169751 RVA: 0x009C4384 File Offset: 0x009C2584
		// (set) Token: 0x06029718 RID: 169752 RVA: 0x009C4398 File Offset: 0x009C2598
		public unsafe FRotator 子弹攻击方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17006346 RID: 25414
		// (get) Token: 0x06029719 RID: 169753 RVA: 0x009C43AD File Offset: 0x009C25AD
		// (set) Token: 0x0602971A RID: 169754 RVA: 0x009C43BD File Offset: 0x009C25BD
		public unsafe bool 技能结束是否销毁子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006347 RID: 25415
		// (get) Token: 0x0602971B RID: 169755 RVA: 0x009C43D0 File Offset: 0x009C25D0
		// (set) Token: 0x0602971C RID: 169756 RVA: 0x009C4413 File Offset: 0x009C2613
		[Nullable(1)]
		public FGameplayTagContainer 子弹允许生成Tag
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._子弹允许生成Tag) == null)
				{
					result = (this._子弹允许生成Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_29, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_29, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006348 RID: 25416
		// (get) Token: 0x0602971D RID: 169757 RVA: 0x009C4434 File Offset: 0x009C2634
		// (set) Token: 0x0602971E RID: 169758 RVA: 0x009C4477 File Offset: 0x009C2677
		[Nullable(1)]
		public FGameplayTagContainer 子弹禁止生成Tag
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._子弹禁止生成Tag) == null)
				{
					result = (this._子弹禁止生成Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_30, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_30, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006349 RID: 25417
		// (get) Token: 0x0602971F RID: 169759 RVA: 0x009C4498 File Offset: 0x009C2698
		// (set) Token: 0x06029720 RID: 169760 RVA: 0x009C44A8 File Offset: 0x009C26A8
		public unsafe bool 是否持续碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700634A RID: 25418
		// (get) Token: 0x06029721 RID: 169761 RVA: 0x009C44B9 File Offset: 0x009C26B9
		// (set) Token: 0x06029722 RID: 169762 RVA: 0x009C44C9 File Offset: 0x009C26C9
		public unsafe bool 是否贴地子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700634B RID: 25419
		// (get) Token: 0x06029723 RID: 169763 RVA: 0x009C44DA File Offset: 0x009C26DA
		// (set) Token: 0x06029724 RID: 169764 RVA: 0x009C44EA File Offset: 0x009C26EA
		public unsafe bool 不适配坡度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700634C RID: 25420
		// (get) Token: 0x06029725 RID: 169765 RVA: 0x009C44FB File Offset: 0x009C26FB
		// (set) Token: 0x06029726 RID: 169766 RVA: 0x009C450B File Offset: 0x009C270B
		public unsafe float 贴地探测距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700634D RID: 25421
		// (get) Token: 0x06029727 RID: 169767 RVA: 0x009C451C File Offset: 0x009C271C
		// (set) Token: 0x06029728 RID: 169768 RVA: 0x009C4530 File Offset: 0x009C2730
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletSyncType> 网络同步类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x1700634E RID: 25422
		// (get) Token: 0x06029729 RID: 169769 RVA: 0x009C4545 File Offset: 0x009C2745
		// (set) Token: 0x0602972A RID: 169770 RVA: 0x009C4559 File Offset: 0x009C2759
		public unsafe FGameplayTag 子弹标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700634F RID: 25423
		// (get) Token: 0x0602972B RID: 169771 RVA: 0x009C456E File Offset: 0x009C276E
		// (set) Token: 0x0602972C RID: 169772 RVA: 0x009C457E File Offset: 0x009C277E
		public unsafe bool 是否响应材质受击音效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006350 RID: 25424
		// (get) Token: 0x0602972D RID: 169773 RVA: 0x009C4590 File Offset: 0x009C2790
		// (set) Token: 0x0602972E RID: 169774 RVA: 0x009C45D3 File Offset: 0x009C27D3
		[Nullable(1)]
		public SReBullDataBase_SubStructTest 新结构体
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SReBullDataBase_SubStructTest result;
				if ((result = this._新结构体) == null)
				{
					result = (this._新结构体 = new SReBullDataBase_SubStructTest(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_38, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBullDataBase_SubStructTest.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_38, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006351 RID: 25425
		// (get) Token: 0x0602972F RID: 169775 RVA: 0x009C45F4 File Offset: 0x009C27F4
		// (set) Token: 0x06029730 RID: 169776 RVA: 0x009C4604 File Offset: 0x009C2804
		public unsafe bool Debug显示子弹进度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006352 RID: 25426
		// (get) Token: 0x06029731 RID: 169777 RVA: 0x009C4615 File Offset: 0x009C2815
		// (set) Token: 0x06029732 RID: 169778 RVA: 0x009C4625 File Offset: 0x009C2825
		public unsafe bool 再新增一个布尔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase_ExcelTest.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x06029733 RID: 169779 RVA: 0x009C4636 File Offset: 0x009C2836
		public SReBulletDataBase_ExcelTest()
		{
		}

		// Token: 0x06029734 RID: 169780 RVA: 0x009C4640 File Offset: 0x009C2840
		public SReBulletDataBase_ExcelTest(TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletShape> 子弹形状, FVector 初始大小, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EBulletBaseSpecificParam>, string> 特殊参数, TEnumAsByte<EPositionStandard> 出生位置基准, [Nullable(1)] string 攻击者黑板Key值, FVector 出生位置偏移, FVector 中心位置偏移, FVector 出生位置随机, FRotator 初始旋转, FVector 限制生成距离, float 持续时间字段改名, float 碰撞判定时长, float 碰撞判定延迟, TEnumAsByte<EHitType> 命中判定类型, [Nullable(1)] TSoftObjectPtr<BulletCampType_C> 命中判定类型预设, FGameplayTag 命中判定Tag, FGameplayTag 禁止命中Tag, int 命中个数, int 每个单位总作用次数, int 总作用次数限制, float 作用间隔, bool 作用间隔基于个体, bool 共享父子弹次数, FName 被击效果, FName 弱点被击效果, TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletRelativeDir> 子弹受击方向, long 伤害ID, FRotator 子弹攻击方向, bool 技能结束是否销毁子弹, [Nullable(1)] FGameplayTagContainer 子弹允许生成Tag, [Nullable(1)] FGameplayTagContainer 子弹禁止生成Tag, bool 是否持续碰撞, bool 是否贴地子弹, bool 不适配坡度, float 贴地探测距离, TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletSyncType> 网络同步类型, FGameplayTag 子弹标签, bool 是否响应材质受击音效, [Nullable(1)] SReBullDataBase_SubStructTest 新结构体, bool Debug显示子弹进度, bool 再新增一个布尔)
		{
			this.子弹形状 = 子弹形状;
			this.初始大小 = 初始大小;
			this.特殊参数 = 特殊参数;
			this.出生位置基准 = 出生位置基准;
			this.攻击者黑板Key值 = 攻击者黑板Key值;
			this.出生位置偏移 = 出生位置偏移;
			this.中心位置偏移 = 中心位置偏移;
			this.出生位置随机 = 出生位置随机;
			this.初始旋转 = 初始旋转;
			this.限制生成距离 = 限制生成距离;
			this.持续时间字段改名 = 持续时间字段改名;
			this.碰撞判定时长 = 碰撞判定时长;
			this.碰撞判定延迟 = 碰撞判定延迟;
			this.命中判定类型 = 命中判定类型;
			this.命中判定类型预设 = 命中判定类型预设;
			this.命中判定Tag = 命中判定Tag;
			this.禁止命中Tag = 禁止命中Tag;
			this.命中个数 = 命中个数;
			this.每个单位总作用次数 = 每个单位总作用次数;
			this.总作用次数限制 = 总作用次数限制;
			this.作用间隔 = 作用间隔;
			this.作用间隔基于个体 = 作用间隔基于个体;
			this.共享父子弹次数 = 共享父子弹次数;
			this.被击效果 = 被击效果;
			this.弱点被击效果 = 弱点被击效果;
			this.子弹受击方向 = 子弹受击方向;
			this.伤害ID = 伤害ID;
			this.子弹攻击方向 = 子弹攻击方向;
			this.技能结束是否销毁子弹 = 技能结束是否销毁子弹;
			this.子弹允许生成Tag = 子弹允许生成Tag;
			this.子弹禁止生成Tag = 子弹禁止生成Tag;
			this.是否持续碰撞 = 是否持续碰撞;
			this.是否贴地子弹 = 是否贴地子弹;
			this.不适配坡度 = 不适配坡度;
			this.贴地探测距离 = 贴地探测距离;
			this.网络同步类型 = 网络同步类型;
			this.子弹标签 = 子弹标签;
			this.是否响应材质受击音效 = 是否响应材质受击音效;
			this.新结构体 = 新结构体;
			this.Debug显示子弹进度 = Debug显示子弹进度;
			this.再新增一个布尔 = 再新增一个布尔;
		}

		// Token: 0x06029735 RID: 169781 RVA: 0x009C4798 File Offset: 0x009C2998
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataBase_ExcelTest.StaticStruct();
		}

		// Token: 0x06029736 RID: 169782 RVA: 0x009C47A4 File Offset: 0x009C29A4
		[NullableContext(2)]
		public SReBulletDataBase_ExcelTest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029737 RID: 169783 RVA: 0x009C47AE File Offset: 0x009C29AE
		public SReBulletDataBase_ExcelTest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029738 RID: 169784 RVA: 0x009C47B9 File Offset: 0x009C29B9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataBase_ExcelTest(Pointer, false, true);
		}

		// Token: 0x06029739 RID: 169785 RVA: 0x009C47C3 File Offset: 0x009C29C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataBase_ExcelTest(Pointer, MemoryOwner);
		}

		// Token: 0x040153A0 RID: 86944
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SReBulletDataBase_ExcelTest.SReBulletDataBase_ExcelTest";

		// Token: 0x040153A1 RID: 86945
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040153A2 RID: 86946
		internal static int __PropertyOffset_0;

		// Token: 0x040153A3 RID: 86947
		internal static int __PropertyOffset_1;

		// Token: 0x040153A4 RID: 86948
		internal static int __PropertyOffset_2;

		// Token: 0x040153A5 RID: 86949
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EBulletBaseSpecificParam>, string> _特殊参数;

		// Token: 0x040153A6 RID: 86950
		internal static int __PropertyOffset_3;

		// Token: 0x040153A7 RID: 86951
		internal static int __PropertyOffset_4;

		// Token: 0x040153A8 RID: 86952
		internal static int __PropertyOffset_5;

		// Token: 0x040153A9 RID: 86953
		internal static int __PropertyOffset_6;

		// Token: 0x040153AA RID: 86954
		internal static int __PropertyOffset_7;

		// Token: 0x040153AB RID: 86955
		internal static int __PropertyOffset_8;

		// Token: 0x040153AC RID: 86956
		internal static int __PropertyOffset_9;

		// Token: 0x040153AD RID: 86957
		internal static int __PropertyOffset_10;

		// Token: 0x040153AE RID: 86958
		internal static int __PropertyOffset_11;

		// Token: 0x040153AF RID: 86959
		internal static int __PropertyOffset_12;

		// Token: 0x040153B0 RID: 86960
		internal static int __PropertyOffset_13;

		// Token: 0x040153B1 RID: 86961
		internal static int __PropertyOffset_14;

		// Token: 0x040153B2 RID: 86962
		internal static int __PropertyOffset_15;

		// Token: 0x040153B3 RID: 86963
		internal static int __PropertyOffset_16;

		// Token: 0x040153B4 RID: 86964
		internal static int __PropertyOffset_17;

		// Token: 0x040153B5 RID: 86965
		internal static int __PropertyOffset_18;

		// Token: 0x040153B6 RID: 86966
		internal static int __PropertyOffset_19;

		// Token: 0x040153B7 RID: 86967
		internal static int __PropertyOffset_20;

		// Token: 0x040153B8 RID: 86968
		internal static int __PropertyOffset_21;

		// Token: 0x040153B9 RID: 86969
		internal static int __PropertyOffset_22;

		// Token: 0x040153BA RID: 86970
		internal static int __PropertyOffset_23;

		// Token: 0x040153BB RID: 86971
		internal static int __PropertyOffset_24;

		// Token: 0x040153BC RID: 86972
		internal static int __PropertyOffset_25;

		// Token: 0x040153BD RID: 86973
		internal static int __PropertyOffset_26;

		// Token: 0x040153BE RID: 86974
		internal static int __PropertyOffset_27;

		// Token: 0x040153BF RID: 86975
		internal static int __PropertyOffset_28;

		// Token: 0x040153C0 RID: 86976
		internal static int __PropertyOffset_29;

		// Token: 0x040153C1 RID: 86977
		[Nullable(2)]
		private FGameplayTagContainer _子弹允许生成Tag;

		// Token: 0x040153C2 RID: 86978
		internal static int __PropertyOffset_30;

		// Token: 0x040153C3 RID: 86979
		[Nullable(2)]
		private FGameplayTagContainer _子弹禁止生成Tag;

		// Token: 0x040153C4 RID: 86980
		internal static int __PropertyOffset_31;

		// Token: 0x040153C5 RID: 86981
		internal static int __PropertyOffset_32;

		// Token: 0x040153C6 RID: 86982
		internal static int __PropertyOffset_33;

		// Token: 0x040153C7 RID: 86983
		internal static int __PropertyOffset_34;

		// Token: 0x040153C8 RID: 86984
		internal static int __PropertyOffset_35;

		// Token: 0x040153C9 RID: 86985
		internal static int __PropertyOffset_36;

		// Token: 0x040153CA RID: 86986
		internal static int __PropertyOffset_37;

		// Token: 0x040153CB RID: 86987
		internal static int __PropertyOffset_38;

		// Token: 0x040153CC RID: 86988
		[Nullable(2)]
		private SReBullDataBase_SubStructTest _新结构体;

		// Token: 0x040153CD RID: 86989
		internal static int __PropertyOffset_39;

		// Token: 0x040153CE RID: 86990
		internal static int __PropertyOffset_40;
	}
}
