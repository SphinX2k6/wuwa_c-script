using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200400F RID: 16399
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataBase.SReBulletDataBase")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 508)]
	public class SReBulletDataBase : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029FDC RID: 171996 RVA: 0x009D2CAE File Offset: 0x009D0EAE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataBase._ScriptStructPtr != 0) ? SReBulletDataBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataBase.SReBulletDataBase", ref SReBulletDataBase._ScriptStructPtr);
		}

		// Token: 0x17006622 RID: 26146
		// (get) Token: 0x06029FDD RID: 171997 RVA: 0x009D2CD2 File Offset: 0x009D0ED2
		// (set) Token: 0x06029FDE RID: 171998 RVA: 0x009D2CE6 File Offset: 0x009D0EE6
		[Nullable(0)]
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletShape> 子弹形状
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006623 RID: 26147
		// (get) Token: 0x06029FDF RID: 171999 RVA: 0x009D2CFB File Offset: 0x009D0EFB
		// (set) Token: 0x06029FE0 RID: 172000 RVA: 0x009D2D0F File Offset: 0x009D0F0F
		public unsafe FVector 初始大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006624 RID: 26148
		// (get) Token: 0x06029FE1 RID: 172001 RVA: 0x009D2D24 File Offset: 0x009D0F24
		// (set) Token: 0x06029FE2 RID: 172002 RVA: 0x009D2D67 File Offset: 0x009D0F67
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
					result = (this._特殊参数 = new TMap<TEnumAsByte<EBulletBaseSpecificParam>, string>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_2, base.MemoryOwner ?? this));
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

		// Token: 0x17006625 RID: 26149
		// (get) Token: 0x06029FE3 RID: 172003 RVA: 0x009D2D75 File Offset: 0x009D0F75
		// (set) Token: 0x06029FE4 RID: 172004 RVA: 0x009D2D89 File Offset: 0x009D0F89
		[Nullable(0)]
		public unsafe TEnumAsByte<EPositionStandard> 出生位置基准
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006626 RID: 26150
		// (get) Token: 0x06029FE5 RID: 172005 RVA: 0x009D2D9E File Offset: 0x009D0F9E
		// (set) Token: 0x06029FE6 RID: 172006 RVA: 0x009D2DB2 File Offset: 0x009D0FB2
		public unsafe string 攻击者黑板Key值
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataBase.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataBase.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17006627 RID: 26151
		// (get) Token: 0x06029FE7 RID: 172007 RVA: 0x009D2DC7 File Offset: 0x009D0FC7
		// (set) Token: 0x06029FE8 RID: 172008 RVA: 0x009D2DDB File Offset: 0x009D0FDB
		public unsafe FVector 出生位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006628 RID: 26152
		// (get) Token: 0x06029FE9 RID: 172009 RVA: 0x009D2DF0 File Offset: 0x009D0FF0
		// (set) Token: 0x06029FEA RID: 172010 RVA: 0x009D2E04 File Offset: 0x009D1004
		public unsafe FVector 中心位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006629 RID: 26153
		// (get) Token: 0x06029FEB RID: 172011 RVA: 0x009D2E19 File Offset: 0x009D1019
		// (set) Token: 0x06029FEC RID: 172012 RVA: 0x009D2E2D File Offset: 0x009D102D
		public unsafe FVector 出生位置随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700662A RID: 26154
		// (get) Token: 0x06029FED RID: 172013 RVA: 0x009D2E42 File Offset: 0x009D1042
		// (set) Token: 0x06029FEE RID: 172014 RVA: 0x009D2E56 File Offset: 0x009D1056
		public unsafe FRotator 初始旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700662B RID: 26155
		// (get) Token: 0x06029FEF RID: 172015 RVA: 0x009D2E6B File Offset: 0x009D106B
		// (set) Token: 0x06029FF0 RID: 172016 RVA: 0x009D2E7F File Offset: 0x009D107F
		public unsafe FVector 限制生成距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700662C RID: 26156
		// (get) Token: 0x06029FF1 RID: 172017 RVA: 0x009D2E94 File Offset: 0x009D1094
		// (set) Token: 0x06029FF2 RID: 172018 RVA: 0x009D2EA4 File Offset: 0x009D10A4
		public unsafe float 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700662D RID: 26157
		// (get) Token: 0x06029FF3 RID: 172019 RVA: 0x009D2EB5 File Offset: 0x009D10B5
		// (set) Token: 0x06029FF4 RID: 172020 RVA: 0x009D2EC5 File Offset: 0x009D10C5
		public unsafe float 碰撞判定时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700662E RID: 26158
		// (get) Token: 0x06029FF5 RID: 172021 RVA: 0x009D2ED6 File Offset: 0x009D10D6
		// (set) Token: 0x06029FF6 RID: 172022 RVA: 0x009D2EE6 File Offset: 0x009D10E6
		public unsafe float 碰撞判定延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700662F RID: 26159
		// (get) Token: 0x06029FF7 RID: 172023 RVA: 0x009D2EF7 File Offset: 0x009D10F7
		// (set) Token: 0x06029FF8 RID: 172024 RVA: 0x009D2F0B File Offset: 0x009D110B
		[Nullable(0)]
		public unsafe TEnumAsByte<EHitType> 命中判定类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006630 RID: 26160
		// (get) Token: 0x06029FF9 RID: 172025 RVA: 0x009D2F20 File Offset: 0x009D1120
		// (set) Token: 0x06029FFA RID: 172026 RVA: 0x009D2F3F File Offset: 0x009D113F
		public TSoftObjectPtr<BulletCampType_C> 命中判定类型预设
		{
			get
			{
				return new TSoftObjectPtr<BulletCampType_C>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_14, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006631 RID: 26161
		// (get) Token: 0x06029FFB RID: 172027 RVA: 0x009D2F64 File Offset: 0x009D1164
		// (set) Token: 0x06029FFC RID: 172028 RVA: 0x009D2F78 File Offset: 0x009D1178
		public unsafe FGameplayTag 命中判定Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006632 RID: 26162
		// (get) Token: 0x06029FFD RID: 172029 RVA: 0x009D2F8D File Offset: 0x009D118D
		// (set) Token: 0x06029FFE RID: 172030 RVA: 0x009D2FA1 File Offset: 0x009D11A1
		public unsafe FGameplayTag 禁止命中Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006633 RID: 26163
		// (get) Token: 0x06029FFF RID: 172031 RVA: 0x009D2FB6 File Offset: 0x009D11B6
		// (set) Token: 0x0602A000 RID: 172032 RVA: 0x009D2FC6 File Offset: 0x009D11C6
		public unsafe bool IsRandomVictim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006634 RID: 26164
		// (get) Token: 0x0602A001 RID: 172033 RVA: 0x009D2FD7 File Offset: 0x009D11D7
		// (set) Token: 0x0602A002 RID: 172034 RVA: 0x009D2FE7 File Offset: 0x009D11E7
		public unsafe int 命中个数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006635 RID: 26165
		// (get) Token: 0x0602A003 RID: 172035 RVA: 0x009D2FF8 File Offset: 0x009D11F8
		// (set) Token: 0x0602A004 RID: 172036 RVA: 0x009D3008 File Offset: 0x009D1208
		public unsafe int 每个单位总作用次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006636 RID: 26166
		// (get) Token: 0x0602A005 RID: 172037 RVA: 0x009D3019 File Offset: 0x009D1219
		// (set) Token: 0x0602A006 RID: 172038 RVA: 0x009D3029 File Offset: 0x009D1229
		public unsafe int 总作用次数限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006637 RID: 26167
		// (get) Token: 0x0602A007 RID: 172039 RVA: 0x009D303A File Offset: 0x009D123A
		// (set) Token: 0x0602A008 RID: 172040 RVA: 0x009D304A File Offset: 0x009D124A
		public unsafe float 作用间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006638 RID: 26168
		// (get) Token: 0x0602A009 RID: 172041 RVA: 0x009D305B File Offset: 0x009D125B
		// (set) Token: 0x0602A00A RID: 172042 RVA: 0x009D306B File Offset: 0x009D126B
		public unsafe bool 作用间隔基于个体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006639 RID: 26169
		// (get) Token: 0x0602A00B RID: 172043 RVA: 0x009D307C File Offset: 0x009D127C
		// (set) Token: 0x0602A00C RID: 172044 RVA: 0x009D308C File Offset: 0x009D128C
		public unsafe bool 共享父子弹次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700663A RID: 26170
		// (get) Token: 0x0602A00D RID: 172045 RVA: 0x009D309D File Offset: 0x009D129D
		// (set) Token: 0x0602A00E RID: 172046 RVA: 0x009D30B1 File Offset: 0x009D12B1
		public unsafe FName 被击效果
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700663B RID: 26171
		// (get) Token: 0x0602A00F RID: 172047 RVA: 0x009D30C8 File Offset: 0x009D12C8
		// (set) Token: 0x0602A010 RID: 172048 RVA: 0x009D310B File Offset: 0x009D130B
		public TArray<FName> 多被击效果
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._多被击效果) == null)
				{
					result = (this._多被击效果 = new TArray<FName>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_25, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.多被击效果.CopyAssign(value);
			}
		}

		// Token: 0x1700663C RID: 26172
		// (get) Token: 0x0602A011 RID: 172049 RVA: 0x009D3119 File Offset: 0x009D1319
		// (set) Token: 0x0602A012 RID: 172050 RVA: 0x009D312D File Offset: 0x009D132D
		public unsafe FName 弱点被击效果
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700663D RID: 26173
		// (get) Token: 0x0602A013 RID: 172051 RVA: 0x009D3144 File Offset: 0x009D1344
		// (set) Token: 0x0602A014 RID: 172052 RVA: 0x009D3187 File Offset: 0x009D1387
		public TArray<FName> 多弱点被击效果
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._多弱点被击效果) == null)
				{
					result = (this._多弱点被击效果 = new TArray<FName>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_27, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.多弱点被击效果.CopyAssign(value);
			}
		}

		// Token: 0x1700663E RID: 26174
		// (get) Token: 0x0602A015 RID: 172053 RVA: 0x009D3195 File Offset: 0x009D1395
		// (set) Token: 0x0602A016 RID: 172054 RVA: 0x009D31A9 File Offset: 0x009D13A9
		[Nullable(0)]
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletRelativeDir> 子弹受击方向
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_28);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700663F RID: 26175
		// (get) Token: 0x0602A017 RID: 172055 RVA: 0x009D31BE File Offset: 0x009D13BE
		// (set) Token: 0x0602A018 RID: 172056 RVA: 0x009D31CE File Offset: 0x009D13CE
		public unsafe long 伤害ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17006640 RID: 26176
		// (get) Token: 0x0602A019 RID: 172057 RVA: 0x009D31E0 File Offset: 0x009D13E0
		// (set) Token: 0x0602A01A RID: 172058 RVA: 0x009D3223 File Offset: 0x009D1423
		public TArray<long> 多伤害ID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._多伤害ID) == null)
				{
					result = (this._多伤害ID = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_30, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.多伤害ID.CopyAssign(value);
			}
		}

		// Token: 0x17006641 RID: 26177
		// (get) Token: 0x0602A01B RID: 172059 RVA: 0x009D3231 File Offset: 0x009D1431
		// (set) Token: 0x0602A01C RID: 172060 RVA: 0x009D3245 File Offset: 0x009D1445
		public unsafe FRotator 子弹攻击方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17006642 RID: 26178
		// (get) Token: 0x0602A01D RID: 172061 RVA: 0x009D325A File Offset: 0x009D145A
		// (set) Token: 0x0602A01E RID: 172062 RVA: 0x009D326A File Offset: 0x009D146A
		public unsafe bool 技能结束是否销毁子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006643 RID: 26179
		// (get) Token: 0x0602A01F RID: 172063 RVA: 0x009D327C File Offset: 0x009D147C
		// (set) Token: 0x0602A020 RID: 172064 RVA: 0x009D32BF File Offset: 0x009D14BF
		public FGameplayTagContainer 子弹允许生成Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._子弹允许生成Tag) == null)
				{
					result = (this._子弹允许生成Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_33, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_33, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006644 RID: 26180
		// (get) Token: 0x0602A021 RID: 172065 RVA: 0x009D32E0 File Offset: 0x009D14E0
		// (set) Token: 0x0602A022 RID: 172066 RVA: 0x009D3323 File Offset: 0x009D1523
		public FGameplayTagContainer 子弹禁止生成Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._子弹禁止生成Tag) == null)
				{
					result = (this._子弹禁止生成Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_34, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_34, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006645 RID: 26181
		// (get) Token: 0x0602A023 RID: 172067 RVA: 0x009D3344 File Offset: 0x009D1544
		// (set) Token: 0x0602A024 RID: 172068 RVA: 0x009D3354 File Offset: 0x009D1554
		public unsafe bool 是否持续碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006646 RID: 26182
		// (get) Token: 0x0602A025 RID: 172069 RVA: 0x009D3365 File Offset: 0x009D1565
		// (set) Token: 0x0602A026 RID: 172070 RVA: 0x009D3375 File Offset: 0x009D1575
		public unsafe bool 是否贴地子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006647 RID: 26183
		// (get) Token: 0x0602A027 RID: 172071 RVA: 0x009D3386 File Offset: 0x009D1586
		// (set) Token: 0x0602A028 RID: 172072 RVA: 0x009D3396 File Offset: 0x009D1596
		public unsafe bool 是否贴水面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006648 RID: 26184
		// (get) Token: 0x0602A029 RID: 172073 RVA: 0x009D33A7 File Offset: 0x009D15A7
		// (set) Token: 0x0602A02A RID: 172074 RVA: 0x009D33B7 File Offset: 0x009D15B7
		public unsafe bool 不跟随移动平台
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006649 RID: 26185
		// (get) Token: 0x0602A02B RID: 172075 RVA: 0x009D33C8 File Offset: 0x009D15C8
		// (set) Token: 0x0602A02C RID: 172076 RVA: 0x009D33D8 File Offset: 0x009D15D8
		public unsafe bool 不适配坡度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700664A RID: 26186
		// (get) Token: 0x0602A02D RID: 172077 RVA: 0x009D33E9 File Offset: 0x009D15E9
		// (set) Token: 0x0602A02E RID: 172078 RVA: 0x009D33F9 File Offset: 0x009D15F9
		public unsafe float 贴地探测距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x1700664B RID: 26187
		// (get) Token: 0x0602A02F RID: 172079 RVA: 0x009D340A File Offset: 0x009D160A
		// (set) Token: 0x0602A030 RID: 172080 RVA: 0x009D341E File Offset: 0x009D161E
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletSyncType> 网络同步类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_41);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x1700664C RID: 26188
		// (get) Token: 0x0602A031 RID: 172081 RVA: 0x009D3433 File Offset: 0x009D1633
		// (set) Token: 0x0602A032 RID: 172082 RVA: 0x009D3447 File Offset: 0x009D1647
		public unsafe FGameplayTag 子弹标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x1700664D RID: 26189
		// (get) Token: 0x0602A033 RID: 172083 RVA: 0x009D345C File Offset: 0x009D165C
		// (set) Token: 0x0602A034 RID: 172084 RVA: 0x009D346C File Offset: 0x009D166C
		public unsafe bool 是否响应材质受击音效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700664E RID: 26190
		// (get) Token: 0x0602A035 RID: 172085 RVA: 0x009D347D File Offset: 0x009D167D
		// (set) Token: 0x0602A036 RID: 172086 RVA: 0x009D348D File Offset: 0x009D168D
		public unsafe bool Debug显示子弹进度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700664F RID: 26191
		// (get) Token: 0x0602A037 RID: 172087 RVA: 0x009D349E File Offset: 0x009D169E
		// (set) Token: 0x0602A038 RID: 172088 RVA: 0x009D34AE File Offset: 0x009D16AE
		public unsafe bool 大范围子弹对场景物件生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006650 RID: 26192
		// (get) Token: 0x0602A039 RID: 172089 RVA: 0x009D34BF File Offset: 0x009D16BF
		// (set) Token: 0x0602A03A RID: 172090 RVA: 0x009D34D3 File Offset: 0x009D16D3
		[Nullable(0)]
		public unsafe TEnumAsByte<EHitActorType> 命中实体类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_46);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17006651 RID: 26193
		// (get) Token: 0x0602A03B RID: 172091 RVA: 0x009D34E8 File Offset: 0x009D16E8
		// (set) Token: 0x0602A03C RID: 172092 RVA: 0x009D34F8 File Offset: 0x009D16F8
		public unsafe int 大范围子弹检测方式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x0602A03D RID: 172093 RVA: 0x009D3509 File Offset: 0x009D1709
		public SReBulletDataBase()
		{
		}

		// Token: 0x0602A03E RID: 172094 RVA: 0x009D3514 File Offset: 0x009D1714
		public SReBulletDataBase([Nullable(0)] TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletShape> 子弹形状, FVector 初始大小, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EBulletBaseSpecificParam>, string> 特殊参数, [Nullable(0)] TEnumAsByte<EPositionStandard> 出生位置基准, string 攻击者黑板Key值, FVector 出生位置偏移, FVector 中心位置偏移, FVector 出生位置随机, FRotator 初始旋转, FVector 限制生成距离, float 持续时间, float 碰撞判定时长, float 碰撞判定延迟, [Nullable(0)] TEnumAsByte<EHitType> 命中判定类型, TSoftObjectPtr<BulletCampType_C> 命中判定类型预设, FGameplayTag 命中判定Tag, FGameplayTag 禁止命中Tag, bool IsRandomVictim, int 命中个数, int 每个单位总作用次数, int 总作用次数限制, float 作用间隔, bool 作用间隔基于个体, bool 共享父子弹次数, FName 被击效果, TArray<FName> 多被击效果, FName 弱点被击效果, TArray<FName> 多弱点被击效果, [Nullable(0)] TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletRelativeDir> 子弹受击方向, long 伤害ID, TArray<long> 多伤害ID, FRotator 子弹攻击方向, bool 技能结束是否销毁子弹, FGameplayTagContainer 子弹允许生成Tag, FGameplayTagContainer 子弹禁止生成Tag, bool 是否持续碰撞, bool 是否贴地子弹, bool 是否贴水面, bool 不跟随移动平台, bool 不适配坡度, float 贴地探测距离, [Nullable(0)] TEnumAsByte<EBulletSyncType> 网络同步类型, FGameplayTag 子弹标签, bool 是否响应材质受击音效, bool Debug显示子弹进度, bool 大范围子弹对场景物件生效, [Nullable(0)] TEnumAsByte<EHitActorType> 命中实体类型, int 大范围子弹检测方式)
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
			this.持续时间 = 持续时间;
			this.碰撞判定时长 = 碰撞判定时长;
			this.碰撞判定延迟 = 碰撞判定延迟;
			this.命中判定类型 = 命中判定类型;
			this.命中判定类型预设 = 命中判定类型预设;
			this.命中判定Tag = 命中判定Tag;
			this.禁止命中Tag = 禁止命中Tag;
			this.IsRandomVictim = IsRandomVictim;
			this.命中个数 = 命中个数;
			this.每个单位总作用次数 = 每个单位总作用次数;
			this.总作用次数限制 = 总作用次数限制;
			this.作用间隔 = 作用间隔;
			this.作用间隔基于个体 = 作用间隔基于个体;
			this.共享父子弹次数 = 共享父子弹次数;
			this.被击效果 = 被击效果;
			this.多被击效果 = 多被击效果;
			this.弱点被击效果 = 弱点被击效果;
			this.多弱点被击效果 = 多弱点被击效果;
			this.子弹受击方向 = 子弹受击方向;
			this.伤害ID = 伤害ID;
			this.多伤害ID = 多伤害ID;
			this.子弹攻击方向 = 子弹攻击方向;
			this.技能结束是否销毁子弹 = 技能结束是否销毁子弹;
			this.子弹允许生成Tag = 子弹允许生成Tag;
			this.子弹禁止生成Tag = 子弹禁止生成Tag;
			this.是否持续碰撞 = 是否持续碰撞;
			this.是否贴地子弹 = 是否贴地子弹;
			this.是否贴水面 = 是否贴水面;
			this.不跟随移动平台 = 不跟随移动平台;
			this.不适配坡度 = 不适配坡度;
			this.贴地探测距离 = 贴地探测距离;
			this.网络同步类型 = 网络同步类型;
			this.子弹标签 = 子弹标签;
			this.是否响应材质受击音效 = 是否响应材质受击音效;
			this.Debug显示子弹进度 = Debug显示子弹进度;
			this.大范围子弹对场景物件生效 = 大范围子弹对场景物件生效;
			this.命中实体类型 = 命中实体类型;
			this.大范围子弹检测方式 = 大范围子弹检测方式;
		}

		// Token: 0x0602A03F RID: 172095 RVA: 0x009D36A4 File Offset: 0x009D18A4
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataBase.StaticStruct();
		}

		// Token: 0x0602A040 RID: 172096 RVA: 0x009D36B0 File Offset: 0x009D18B0
		[NullableContext(2)]
		public SReBulletDataBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A041 RID: 172097 RVA: 0x009D36BA File Offset: 0x009D18BA
		public SReBulletDataBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A042 RID: 172098 RVA: 0x009D36C5 File Offset: 0x009D18C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataBase(Pointer, false, true);
		}

		// Token: 0x0602A043 RID: 172099 RVA: 0x009D36CF File Offset: 0x009D18CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataBase(Pointer, MemoryOwner);
		}

		// Token: 0x040159FB RID: 88571
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataBase.SReBulletDataBase";

		// Token: 0x040159FC RID: 88572
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040159FD RID: 88573
		internal static int __PropertyOffset_0;

		// Token: 0x040159FE RID: 88574
		internal static int __PropertyOffset_1;

		// Token: 0x040159FF RID: 88575
		internal static int __PropertyOffset_2;

		// Token: 0x04015A00 RID: 88576
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EBulletBaseSpecificParam>, string> _特殊参数;

		// Token: 0x04015A01 RID: 88577
		internal static int __PropertyOffset_3;

		// Token: 0x04015A02 RID: 88578
		internal static int __PropertyOffset_4;

		// Token: 0x04015A03 RID: 88579
		internal static int __PropertyOffset_5;

		// Token: 0x04015A04 RID: 88580
		internal static int __PropertyOffset_6;

		// Token: 0x04015A05 RID: 88581
		internal static int __PropertyOffset_7;

		// Token: 0x04015A06 RID: 88582
		internal static int __PropertyOffset_8;

		// Token: 0x04015A07 RID: 88583
		internal static int __PropertyOffset_9;

		// Token: 0x04015A08 RID: 88584
		internal static int __PropertyOffset_10;

		// Token: 0x04015A09 RID: 88585
		internal static int __PropertyOffset_11;

		// Token: 0x04015A0A RID: 88586
		internal static int __PropertyOffset_12;

		// Token: 0x04015A0B RID: 88587
		internal static int __PropertyOffset_13;

		// Token: 0x04015A0C RID: 88588
		internal static int __PropertyOffset_14;

		// Token: 0x04015A0D RID: 88589
		internal static int __PropertyOffset_15;

		// Token: 0x04015A0E RID: 88590
		internal static int __PropertyOffset_16;

		// Token: 0x04015A0F RID: 88591
		internal static int __PropertyOffset_17;

		// Token: 0x04015A10 RID: 88592
		internal static int __PropertyOffset_18;

		// Token: 0x04015A11 RID: 88593
		internal static int __PropertyOffset_19;

		// Token: 0x04015A12 RID: 88594
		internal static int __PropertyOffset_20;

		// Token: 0x04015A13 RID: 88595
		internal static int __PropertyOffset_21;

		// Token: 0x04015A14 RID: 88596
		internal static int __PropertyOffset_22;

		// Token: 0x04015A15 RID: 88597
		internal static int __PropertyOffset_23;

		// Token: 0x04015A16 RID: 88598
		internal static int __PropertyOffset_24;

		// Token: 0x04015A17 RID: 88599
		internal static int __PropertyOffset_25;

		// Token: 0x04015A18 RID: 88600
		[Nullable(2)]
		private TArray<FName> _多被击效果;

		// Token: 0x04015A19 RID: 88601
		internal static int __PropertyOffset_26;

		// Token: 0x04015A1A RID: 88602
		internal static int __PropertyOffset_27;

		// Token: 0x04015A1B RID: 88603
		[Nullable(2)]
		private TArray<FName> _多弱点被击效果;

		// Token: 0x04015A1C RID: 88604
		internal static int __PropertyOffset_28;

		// Token: 0x04015A1D RID: 88605
		internal static int __PropertyOffset_29;

		// Token: 0x04015A1E RID: 88606
		internal static int __PropertyOffset_30;

		// Token: 0x04015A1F RID: 88607
		[Nullable(2)]
		private TArray<long> _多伤害ID;

		// Token: 0x04015A20 RID: 88608
		internal static int __PropertyOffset_31;

		// Token: 0x04015A21 RID: 88609
		internal static int __PropertyOffset_32;

		// Token: 0x04015A22 RID: 88610
		internal static int __PropertyOffset_33;

		// Token: 0x04015A23 RID: 88611
		[Nullable(2)]
		private FGameplayTagContainer _子弹允许生成Tag;

		// Token: 0x04015A24 RID: 88612
		internal static int __PropertyOffset_34;

		// Token: 0x04015A25 RID: 88613
		[Nullable(2)]
		private FGameplayTagContainer _子弹禁止生成Tag;

		// Token: 0x04015A26 RID: 88614
		internal static int __PropertyOffset_35;

		// Token: 0x04015A27 RID: 88615
		internal static int __PropertyOffset_36;

		// Token: 0x04015A28 RID: 88616
		internal static int __PropertyOffset_37;

		// Token: 0x04015A29 RID: 88617
		internal static int __PropertyOffset_38;

		// Token: 0x04015A2A RID: 88618
		internal static int __PropertyOffset_39;

		// Token: 0x04015A2B RID: 88619
		internal static int __PropertyOffset_40;

		// Token: 0x04015A2C RID: 88620
		internal static int __PropertyOffset_41;

		// Token: 0x04015A2D RID: 88621
		internal static int __PropertyOffset_42;

		// Token: 0x04015A2E RID: 88622
		internal static int __PropertyOffset_43;

		// Token: 0x04015A2F RID: 88623
		internal static int __PropertyOffset_44;

		// Token: 0x04015A30 RID: 88624
		internal static int __PropertyOffset_45;

		// Token: 0x04015A31 RID: 88625
		internal static int __PropertyOffset_46;

		// Token: 0x04015A32 RID: 88626
		internal static int __PropertyOffset_47;
	}
}
