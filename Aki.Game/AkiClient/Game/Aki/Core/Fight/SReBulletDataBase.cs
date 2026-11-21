using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003270 RID: 12912
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataBase.SReBulletDataBase")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 512)]
	public class SReBulletDataBase : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602038D RID: 131981 RVA: 0x009406EA File Offset: 0x0093E8EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataBase._ScriptStructPtr != 0) ? SReBulletDataBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataBase.SReBulletDataBase", ref SReBulletDataBase._ScriptStructPtr);
		}

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x0602038E RID: 131982 RVA: 0x0094070E File Offset: 0x0093E90E
		// (set) Token: 0x0602038F RID: 131983 RVA: 0x00940722 File Offset: 0x0093E922
		[Nullable(0)]
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletShape> 子弹形状
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹形状);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹形状) = value;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x06020390 RID: 131984 RVA: 0x00940737 File Offset: 0x0093E937
		// (set) Token: 0x06020391 RID: 131985 RVA: 0x0094074B File Offset: 0x0093E94B
		public unsafe FVector 初始大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_初始大小);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_初始大小) = value;
			}
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x06020392 RID: 131986 RVA: 0x00940760 File Offset: 0x0093E960
		// (set) Token: 0x06020393 RID: 131987 RVA: 0x009407A3 File Offset: 0x0093E9A3
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
					result = (this._特殊参数 = new TMap<TEnumAsByte<EBulletBaseSpecificParam>, string>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_特殊参数, base.MemoryOwner ?? this));
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

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x06020394 RID: 131988 RVA: 0x009407B1 File Offset: 0x0093E9B1
		// (set) Token: 0x06020395 RID: 131989 RVA: 0x009407C5 File Offset: 0x0093E9C5
		[Nullable(0)]
		public unsafe TEnumAsByte<EPositionStandard> 出生位置基准
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_出生位置基准);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_出生位置基准) = value;
			}
		}

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x06020396 RID: 131990 RVA: 0x009407DA File Offset: 0x0093E9DA
		// (set) Token: 0x06020397 RID: 131991 RVA: 0x009407EE File Offset: 0x0093E9EE
		public unsafe string 攻击者黑板Key值
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataBase.__PropertyOffset_攻击者黑板Key值)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataBase.__PropertyOffset_攻击者黑板Key值)), value);
			}
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x06020398 RID: 131992 RVA: 0x00940803 File Offset: 0x0093EA03
		// (set) Token: 0x06020399 RID: 131993 RVA: 0x00940817 File Offset: 0x0093EA17
		public unsafe FVector 出生位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_出生位置偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_出生位置偏移) = value;
			}
		}

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0602039A RID: 131994 RVA: 0x0094082C File Offset: 0x0093EA2C
		// (set) Token: 0x0602039B RID: 131995 RVA: 0x00940840 File Offset: 0x0093EA40
		public unsafe FVector 中心位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_中心位置偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_中心位置偏移) = value;
			}
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0602039C RID: 131996 RVA: 0x00940855 File Offset: 0x0093EA55
		// (set) Token: 0x0602039D RID: 131997 RVA: 0x00940869 File Offset: 0x0093EA69
		public unsafe FVector 出生位置随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_出生位置随机);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_出生位置随机) = value;
			}
		}

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0602039E RID: 131998 RVA: 0x0094087E File Offset: 0x0093EA7E
		// (set) Token: 0x0602039F RID: 131999 RVA: 0x00940892 File Offset: 0x0093EA92
		public unsafe FRotator 初始旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_初始旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_初始旋转) = value;
			}
		}

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x060203A0 RID: 132000 RVA: 0x009408A7 File Offset: 0x0093EAA7
		// (set) Token: 0x060203A1 RID: 132001 RVA: 0x009408BB File Offset: 0x0093EABB
		public unsafe FVector 限制生成距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_限制生成距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_限制生成距离) = value;
			}
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x060203A2 RID: 132002 RVA: 0x009408D0 File Offset: 0x0093EAD0
		// (set) Token: 0x060203A3 RID: 132003 RVA: 0x009408E0 File Offset: 0x0093EAE0
		public unsafe float 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_持续时间) = value;
			}
		}

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x060203A4 RID: 132004 RVA: 0x009408F1 File Offset: 0x0093EAF1
		// (set) Token: 0x060203A5 RID: 132005 RVA: 0x00940901 File Offset: 0x0093EB01
		public unsafe float 碰撞判定时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_碰撞判定时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_碰撞判定时长) = value;
			}
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x060203A6 RID: 132006 RVA: 0x00940912 File Offset: 0x0093EB12
		// (set) Token: 0x060203A7 RID: 132007 RVA: 0x00940922 File Offset: 0x0093EB22
		public unsafe float 碰撞判定延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_碰撞判定延迟);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_碰撞判定延迟) = value;
			}
		}

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x060203A8 RID: 132008 RVA: 0x00940933 File Offset: 0x0093EB33
		// (set) Token: 0x060203A9 RID: 132009 RVA: 0x00940947 File Offset: 0x0093EB47
		[Nullable(0)]
		public unsafe TEnumAsByte<EHitType> 命中判定类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中判定类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中判定类型) = value;
			}
		}

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x060203AA RID: 132010 RVA: 0x0094095C File Offset: 0x0093EB5C
		// (set) Token: 0x060203AB RID: 132011 RVA: 0x0094097B File Offset: 0x0093EB7B
		public TSoftObjectPtr<BulletCampType_C> 命中判定类型预设
		{
			get
			{
				return new TSoftObjectPtr<BulletCampType_C>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中判定类型预设, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中判定类型预设, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x060203AC RID: 132012 RVA: 0x009409A0 File Offset: 0x0093EBA0
		// (set) Token: 0x060203AD RID: 132013 RVA: 0x009409B4 File Offset: 0x0093EBB4
		public unsafe FGameplayTag 命中判定Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中判定Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中判定Tag) = value;
			}
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x060203AE RID: 132014 RVA: 0x009409C9 File Offset: 0x0093EBC9
		// (set) Token: 0x060203AF RID: 132015 RVA: 0x009409DD File Offset: 0x0093EBDD
		public unsafe FGameplayTag 禁止命中Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_禁止命中Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_禁止命中Tag) = value;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x060203B0 RID: 132016 RVA: 0x009409F2 File Offset: 0x0093EBF2
		// (set) Token: 0x060203B1 RID: 132017 RVA: 0x00940A02 File Offset: 0x0093EC02
		public unsafe bool IsRandomVictim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_IsRandomVictim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_IsRandomVictim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x060203B2 RID: 132018 RVA: 0x00940A13 File Offset: 0x0093EC13
		// (set) Token: 0x060203B3 RID: 132019 RVA: 0x00940A23 File Offset: 0x0093EC23
		public unsafe int 命中个数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中个数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中个数) = value;
			}
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x060203B4 RID: 132020 RVA: 0x00940A34 File Offset: 0x0093EC34
		// (set) Token: 0x060203B5 RID: 132021 RVA: 0x00940A44 File Offset: 0x0093EC44
		public unsafe int 每个单位总作用次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_每个单位总作用次数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_每个单位总作用次数) = value;
			}
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x060203B6 RID: 132022 RVA: 0x00940A55 File Offset: 0x0093EC55
		// (set) Token: 0x060203B7 RID: 132023 RVA: 0x00940A65 File Offset: 0x0093EC65
		public unsafe int 总作用次数限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_总作用次数限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_总作用次数限制) = value;
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x060203B8 RID: 132024 RVA: 0x00940A76 File Offset: 0x0093EC76
		// (set) Token: 0x060203B9 RID: 132025 RVA: 0x00940A86 File Offset: 0x0093EC86
		public unsafe float 作用间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_作用间隔);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_作用间隔) = value;
			}
		}

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x060203BA RID: 132026 RVA: 0x00940A97 File Offset: 0x0093EC97
		// (set) Token: 0x060203BB RID: 132027 RVA: 0x00940AA7 File Offset: 0x0093ECA7
		public unsafe bool 作用间隔基于个体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_作用间隔基于个体) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_作用间隔基于个体) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x060203BC RID: 132028 RVA: 0x00940AB8 File Offset: 0x0093ECB8
		// (set) Token: 0x060203BD RID: 132029 RVA: 0x00940AC8 File Offset: 0x0093ECC8
		public unsafe bool 共享父子弹次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_共享父子弹次数) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_共享父子弹次数) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x060203BE RID: 132030 RVA: 0x00940AD9 File Offset: 0x0093ECD9
		// (set) Token: 0x060203BF RID: 132031 RVA: 0x00940AED File Offset: 0x0093ECED
		public unsafe FName 被击效果
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_被击效果);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_被击效果) = value;
			}
		}

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x060203C0 RID: 132032 RVA: 0x00940B04 File Offset: 0x0093ED04
		// (set) Token: 0x060203C1 RID: 132033 RVA: 0x00940B47 File Offset: 0x0093ED47
		public TArray<FName> 多被击效果
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._多被击效果) == null)
				{
					result = (this._多被击效果 = new TArray<FName>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_多被击效果, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.多被击效果.CopyAssign(value);
			}
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x060203C2 RID: 132034 RVA: 0x00940B55 File Offset: 0x0093ED55
		// (set) Token: 0x060203C3 RID: 132035 RVA: 0x00940B69 File Offset: 0x0093ED69
		public unsafe FName 弱点被击效果
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_弱点被击效果);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_弱点被击效果) = value;
			}
		}

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x060203C4 RID: 132036 RVA: 0x00940B80 File Offset: 0x0093ED80
		// (set) Token: 0x060203C5 RID: 132037 RVA: 0x00940BC3 File Offset: 0x0093EDC3
		public TArray<FName> 多弱点被击效果
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._多弱点被击效果) == null)
				{
					result = (this._多弱点被击效果 = new TArray<FName>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_多弱点被击效果, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.多弱点被击效果.CopyAssign(value);
			}
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x060203C6 RID: 132038 RVA: 0x00940BD1 File Offset: 0x0093EDD1
		// (set) Token: 0x060203C7 RID: 132039 RVA: 0x00940BE5 File Offset: 0x0093EDE5
		[Nullable(0)]
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletRelativeDir> 子弹受击方向
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹受击方向);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹受击方向) = value;
			}
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x060203C8 RID: 132040 RVA: 0x00940BFA File Offset: 0x0093EDFA
		// (set) Token: 0x060203C9 RID: 132041 RVA: 0x00940C0A File Offset: 0x0093EE0A
		public unsafe long 伤害ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_伤害ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_伤害ID) = value;
			}
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x060203CA RID: 132042 RVA: 0x00940C1C File Offset: 0x0093EE1C
		// (set) Token: 0x060203CB RID: 132043 RVA: 0x00940C5F File Offset: 0x0093EE5F
		public TArray<long> 多伤害ID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._多伤害ID) == null)
				{
					result = (this._多伤害ID = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_多伤害ID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.多伤害ID.CopyAssign(value);
			}
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x060203CC RID: 132044 RVA: 0x00940C6D File Offset: 0x0093EE6D
		// (set) Token: 0x060203CD RID: 132045 RVA: 0x00940C81 File Offset: 0x0093EE81
		public unsafe FRotator 子弹攻击方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹攻击方向);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹攻击方向) = value;
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x060203CE RID: 132046 RVA: 0x00940C96 File Offset: 0x0093EE96
		// (set) Token: 0x060203CF RID: 132047 RVA: 0x00940CA6 File Offset: 0x0093EEA6
		public unsafe bool 技能结束是否销毁子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_技能结束是否销毁子弹) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_技能结束是否销毁子弹) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x060203D0 RID: 132048 RVA: 0x00940CB8 File Offset: 0x0093EEB8
		// (set) Token: 0x060203D1 RID: 132049 RVA: 0x00940CFB File Offset: 0x0093EEFB
		public FGameplayTagContainer 子弹允许生成Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._子弹允许生成Tag) == null)
				{
					result = (this._子弹允许生成Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹允许生成Tag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹允许生成Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x060203D2 RID: 132050 RVA: 0x00940D1C File Offset: 0x0093EF1C
		// (set) Token: 0x060203D3 RID: 132051 RVA: 0x00940D5F File Offset: 0x0093EF5F
		public FGameplayTagContainer 子弹禁止生成Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._子弹禁止生成Tag) == null)
				{
					result = (this._子弹禁止生成Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹禁止生成Tag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹禁止生成Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x060203D4 RID: 132052 RVA: 0x00940D80 File Offset: 0x0093EF80
		// (set) Token: 0x060203D5 RID: 132053 RVA: 0x00940D90 File Offset: 0x0093EF90
		public unsafe bool 是否持续碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否持续碰撞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否持续碰撞) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x060203D6 RID: 132054 RVA: 0x00940DA1 File Offset: 0x0093EFA1
		// (set) Token: 0x060203D7 RID: 132055 RVA: 0x00940DB1 File Offset: 0x0093EFB1
		public unsafe bool 是否贴地子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否贴地子弹) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否贴地子弹) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x060203D8 RID: 132056 RVA: 0x00940DC2 File Offset: 0x0093EFC2
		// (set) Token: 0x060203D9 RID: 132057 RVA: 0x00940DD2 File Offset: 0x0093EFD2
		public unsafe bool 是否贴水面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否贴水面) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否贴水面) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x060203DA RID: 132058 RVA: 0x00940DE3 File Offset: 0x0093EFE3
		// (set) Token: 0x060203DB RID: 132059 RVA: 0x00940DF3 File Offset: 0x0093EFF3
		public unsafe bool 不跟随移动平台
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_不跟随移动平台) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_不跟随移动平台) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x060203DC RID: 132060 RVA: 0x00940E04 File Offset: 0x0093F004
		// (set) Token: 0x060203DD RID: 132061 RVA: 0x00940E14 File Offset: 0x0093F014
		public unsafe bool 不适配坡度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_不适配坡度) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_不适配坡度) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x060203DE RID: 132062 RVA: 0x00940E25 File Offset: 0x0093F025
		// (set) Token: 0x060203DF RID: 132063 RVA: 0x00940E35 File Offset: 0x0093F035
		public unsafe float 贴地角度限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_贴地角度限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_贴地角度限制) = value;
			}
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x060203E0 RID: 132064 RVA: 0x00940E46 File Offset: 0x0093F046
		// (set) Token: 0x060203E1 RID: 132065 RVA: 0x00940E56 File Offset: 0x0093F056
		public unsafe float 贴地探测距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_贴地探测距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_贴地探测距离) = value;
			}
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x060203E2 RID: 132066 RVA: 0x00940E67 File Offset: 0x0093F067
		// (set) Token: 0x060203E3 RID: 132067 RVA: 0x00940E7B File Offset: 0x0093F07B
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletSyncType> 网络同步类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_网络同步类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_网络同步类型) = value;
			}
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x060203E4 RID: 132068 RVA: 0x00940E90 File Offset: 0x0093F090
		// (set) Token: 0x060203E5 RID: 132069 RVA: 0x00940EA4 File Offset: 0x0093F0A4
		public unsafe FGameplayTag 子弹标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹标签);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_子弹标签) = value;
			}
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x060203E6 RID: 132070 RVA: 0x00940EB9 File Offset: 0x0093F0B9
		// (set) Token: 0x060203E7 RID: 132071 RVA: 0x00940EC9 File Offset: 0x0093F0C9
		public unsafe bool 是否响应材质受击音效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否响应材质受击音效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_是否响应材质受击音效) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x060203E8 RID: 132072 RVA: 0x00940EDA File Offset: 0x0093F0DA
		// (set) Token: 0x060203E9 RID: 132073 RVA: 0x00940EEA File Offset: 0x0093F0EA
		public unsafe bool Debug显示子弹进度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_Debug显示子弹进度) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_Debug显示子弹进度) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x060203EA RID: 132074 RVA: 0x00940EFB File Offset: 0x0093F0FB
		// (set) Token: 0x060203EB RID: 132075 RVA: 0x00940F0B File Offset: 0x0093F10B
		public unsafe bool 大范围子弹对场景物件生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_大范围子弹对场景物件生效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_大范围子弹对场景物件生效) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x060203EC RID: 132076 RVA: 0x00940F1C File Offset: 0x0093F11C
		// (set) Token: 0x060203ED RID: 132077 RVA: 0x00940F30 File Offset: 0x0093F130
		[Nullable(0)]
		public unsafe TEnumAsByte<EHitActorType> 命中实体类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中实体类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_命中实体类型) = value;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x060203EE RID: 132078 RVA: 0x00940F45 File Offset: 0x0093F145
		// (set) Token: 0x060203EF RID: 132079 RVA: 0x00940F55 File Offset: 0x0093F155
		public unsafe int 大范围子弹检测方式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_大范围子弹检测方式);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataBase.__PropertyOffset_大范围子弹检测方式) = value;
			}
		}

		// Token: 0x060203F0 RID: 132080 RVA: 0x00940F66 File Offset: 0x0093F166
		public SReBulletDataBase()
		{
		}

		// Token: 0x060203F1 RID: 132081 RVA: 0x00940F6E File Offset: 0x0093F16E
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataBase.StaticStruct();
		}

		// Token: 0x060203F2 RID: 132082 RVA: 0x00940F7A File Offset: 0x0093F17A
		[NullableContext(2)]
		public SReBulletDataBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060203F3 RID: 132083 RVA: 0x00940F84 File Offset: 0x0093F184
		public SReBulletDataBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060203F4 RID: 132084 RVA: 0x00940F8F File Offset: 0x0093F18F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataBase(Pointer, false, true);
		}

		// Token: 0x060203F5 RID: 132085 RVA: 0x00940F99 File Offset: 0x0093F199
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataBase(Pointer, MemoryOwner);
		}

		// Token: 0x0401164D RID: 71245
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataBase.SReBulletDataBase";

		// Token: 0x0401164E RID: 71246
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401164F RID: 71247
		internal static int __PropertyOffset_子弹形状;

		// Token: 0x04011650 RID: 71248
		internal static int __PropertyOffset_初始大小;

		// Token: 0x04011651 RID: 71249
		internal static int __PropertyOffset_特殊参数;

		// Token: 0x04011652 RID: 71250
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EBulletBaseSpecificParam>, string> _特殊参数;

		// Token: 0x04011653 RID: 71251
		internal static int __PropertyOffset_出生位置基准;

		// Token: 0x04011654 RID: 71252
		internal static int __PropertyOffset_攻击者黑板Key值;

		// Token: 0x04011655 RID: 71253
		internal static int __PropertyOffset_出生位置偏移;

		// Token: 0x04011656 RID: 71254
		internal static int __PropertyOffset_中心位置偏移;

		// Token: 0x04011657 RID: 71255
		internal static int __PropertyOffset_出生位置随机;

		// Token: 0x04011658 RID: 71256
		internal static int __PropertyOffset_初始旋转;

		// Token: 0x04011659 RID: 71257
		internal static int __PropertyOffset_限制生成距离;

		// Token: 0x0401165A RID: 71258
		internal static int __PropertyOffset_持续时间;

		// Token: 0x0401165B RID: 71259
		internal static int __PropertyOffset_碰撞判定时长;

		// Token: 0x0401165C RID: 71260
		internal static int __PropertyOffset_碰撞判定延迟;

		// Token: 0x0401165D RID: 71261
		internal static int __PropertyOffset_命中判定类型;

		// Token: 0x0401165E RID: 71262
		internal static int __PropertyOffset_命中判定类型预设;

		// Token: 0x0401165F RID: 71263
		internal static int __PropertyOffset_命中判定Tag;

		// Token: 0x04011660 RID: 71264
		internal static int __PropertyOffset_禁止命中Tag;

		// Token: 0x04011661 RID: 71265
		internal static int __PropertyOffset_IsRandomVictim;

		// Token: 0x04011662 RID: 71266
		internal static int __PropertyOffset_命中个数;

		// Token: 0x04011663 RID: 71267
		internal static int __PropertyOffset_每个单位总作用次数;

		// Token: 0x04011664 RID: 71268
		internal static int __PropertyOffset_总作用次数限制;

		// Token: 0x04011665 RID: 71269
		internal static int __PropertyOffset_作用间隔;

		// Token: 0x04011666 RID: 71270
		internal static int __PropertyOffset_作用间隔基于个体;

		// Token: 0x04011667 RID: 71271
		internal static int __PropertyOffset_共享父子弹次数;

		// Token: 0x04011668 RID: 71272
		internal static int __PropertyOffset_被击效果;

		// Token: 0x04011669 RID: 71273
		internal static int __PropertyOffset_多被击效果;

		// Token: 0x0401166A RID: 71274
		[Nullable(2)]
		private TArray<FName> _多被击效果;

		// Token: 0x0401166B RID: 71275
		internal static int __PropertyOffset_弱点被击效果;

		// Token: 0x0401166C RID: 71276
		internal static int __PropertyOffset_多弱点被击效果;

		// Token: 0x0401166D RID: 71277
		[Nullable(2)]
		private TArray<FName> _多弱点被击效果;

		// Token: 0x0401166E RID: 71278
		internal static int __PropertyOffset_子弹受击方向;

		// Token: 0x0401166F RID: 71279
		internal static int __PropertyOffset_伤害ID;

		// Token: 0x04011670 RID: 71280
		internal static int __PropertyOffset_多伤害ID;

		// Token: 0x04011671 RID: 71281
		[Nullable(2)]
		private TArray<long> _多伤害ID;

		// Token: 0x04011672 RID: 71282
		internal static int __PropertyOffset_子弹攻击方向;

		// Token: 0x04011673 RID: 71283
		internal static int __PropertyOffset_技能结束是否销毁子弹;

		// Token: 0x04011674 RID: 71284
		internal static int __PropertyOffset_子弹允许生成Tag;

		// Token: 0x04011675 RID: 71285
		[Nullable(2)]
		private FGameplayTagContainer _子弹允许生成Tag;

		// Token: 0x04011676 RID: 71286
		internal static int __PropertyOffset_子弹禁止生成Tag;

		// Token: 0x04011677 RID: 71287
		[Nullable(2)]
		private FGameplayTagContainer _子弹禁止生成Tag;

		// Token: 0x04011678 RID: 71288
		internal static int __PropertyOffset_是否持续碰撞;

		// Token: 0x04011679 RID: 71289
		internal static int __PropertyOffset_是否贴地子弹;

		// Token: 0x0401167A RID: 71290
		internal static int __PropertyOffset_是否贴水面;

		// Token: 0x0401167B RID: 71291
		internal static int __PropertyOffset_不跟随移动平台;

		// Token: 0x0401167C RID: 71292
		internal static int __PropertyOffset_不适配坡度;

		// Token: 0x0401167D RID: 71293
		internal static int __PropertyOffset_贴地角度限制;

		// Token: 0x0401167E RID: 71294
		internal static int __PropertyOffset_贴地探测距离;

		// Token: 0x0401167F RID: 71295
		internal static int __PropertyOffset_网络同步类型;

		// Token: 0x04011680 RID: 71296
		internal static int __PropertyOffset_子弹标签;

		// Token: 0x04011681 RID: 71297
		internal static int __PropertyOffset_是否响应材质受击音效;

		// Token: 0x04011682 RID: 71298
		internal static int __PropertyOffset_Debug显示子弹进度;

		// Token: 0x04011683 RID: 71299
		internal static int __PropertyOffset_大范围子弹对场景物件生效;

		// Token: 0x04011684 RID: 71300
		internal static int __PropertyOffset_命中实体类型;

		// Token: 0x04011685 RID: 71301
		internal static int __PropertyOffset_大范围子弹检测方式;
	}
}
