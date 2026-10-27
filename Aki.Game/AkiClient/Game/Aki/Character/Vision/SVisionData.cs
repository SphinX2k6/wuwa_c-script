using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Vision
{
	// Token: 0x0200402D RID: 16429
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vision/SVisionData.SVisionData")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 145)]
	public class SVisionData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A243 RID: 172611 RVA: 0x009D73DC File Offset: 0x009D55DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVisionData._ScriptStructPtr != 0) ? SVisionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Vision/SVisionData.SVisionData", ref SVisionData._ScriptStructPtr);
		}

		// Token: 0x170066DE RID: 26334
		// (get) Token: 0x0602A244 RID: 172612 RVA: 0x009D7400 File Offset: 0x009D5600
		// (set) Token: 0x0602A245 RID: 172613 RVA: 0x009D7410 File Offset: 0x009D5610
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170066DF RID: 26335
		// (get) Token: 0x0602A246 RID: 172614 RVA: 0x009D7421 File Offset: 0x009D5621
		// (set) Token: 0x0602A247 RID: 172615 RVA: 0x009D7435 File Offset: 0x009D5635
		public unsafe string 说明
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVisionData.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVisionData.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x170066E0 RID: 26336
		// (get) Token: 0x0602A248 RID: 172616 RVA: 0x009D744A File Offset: 0x009D564A
		// (set) Token: 0x0602A249 RID: 172617 RVA: 0x009D745A File Offset: 0x009D565A
		public unsafe int 实体配置表Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170066E1 RID: 26337
		// (get) Token: 0x0602A24A RID: 172618 RVA: 0x009D746B File Offset: 0x009D566B
		// (set) Token: 0x0602A24B RID: 172619 RVA: 0x009D747F File Offset: 0x009D567F
		[Nullable(0)]
		public unsafe TEnumAsByte<EVisionType> 类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170066E2 RID: 26338
		// (get) Token: 0x0602A24C RID: 172620 RVA: 0x009D7494 File Offset: 0x009D5694
		// (set) Token: 0x0602A24D RID: 172621 RVA: 0x009D74A4 File Offset: 0x009D56A4
		public unsafe int 技能ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170066E3 RID: 26339
		// (get) Token: 0x0602A24E RID: 172622 RVA: 0x009D74B5 File Offset: 0x009D56B5
		// (set) Token: 0x0602A24F RID: 172623 RVA: 0x009D74C5 File Offset: 0x009D56C5
		public unsafe bool 空中能否释放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066E4 RID: 26340
		// (get) Token: 0x0602A250 RID: 172624 RVA: 0x009D74D6 File Offset: 0x009D56D6
		// (set) Token: 0x0602A251 RID: 172625 RVA: 0x009D74E6 File Offset: 0x009D56E6
		public unsafe bool 出生隐藏
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066E5 RID: 26341
		// (get) Token: 0x0602A252 RID: 172626 RVA: 0x009D74F8 File Offset: 0x009D56F8
		// (set) Token: 0x0602A253 RID: 172627 RVA: 0x009D753B File Offset: 0x009D573B
		public TArray<long> 葫芦轨迹子弹列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._葫芦轨迹子弹列表) == null)
				{
					result = (this._葫芦轨迹子弹列表 = new TArray<long>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.葫芦轨迹子弹列表.CopyAssign(value);
			}
		}

		// Token: 0x170066E6 RID: 26342
		// (get) Token: 0x0602A254 RID: 172628 RVA: 0x009D7549 File Offset: 0x009D5749
		// (set) Token: 0x0602A255 RID: 172629 RVA: 0x009D7559 File Offset: 0x009D5759
		public unsafe bool 战时是否播放出生动画
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066E7 RID: 26343
		// (get) Token: 0x0602A256 RID: 172630 RVA: 0x009D756C File Offset: 0x009D576C
		// (set) Token: 0x0602A257 RID: 172631 RVA: 0x009D75AF File Offset: 0x009D57AF
		public TArray<FGameplayTagContainer> 生命中Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagContainer> result;
				if ((result = this._生命中Tag) == null)
				{
					result = (this._生命中Tag = new TArray<FGameplayTagContainer>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.生命中Tag.CopyAssign(value);
			}
		}

		// Token: 0x170066E8 RID: 26344
		// (get) Token: 0x0602A258 RID: 172632 RVA: 0x009D75C0 File Offset: 0x009D57C0
		// (set) Token: 0x0602A259 RID: 172633 RVA: 0x009D7603 File Offset: 0x009D5803
		public TArray<int> 出生Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._出生Buff) == null)
				{
					result = (this._出生Buff = new TArray<int>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.出生Buff.CopyAssign(value);
			}
		}

		// Token: 0x170066E9 RID: 26345
		// (get) Token: 0x0602A25A RID: 172634 RVA: 0x009D7614 File Offset: 0x009D5814
		// (set) Token: 0x0602A25B RID: 172635 RVA: 0x009D7657 File Offset: 0x009D5857
		public TArray<int> 出生时给召唤者Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._出生时给召唤者Buff) == null)
				{
					result = (this._出生时给召唤者Buff = new TArray<int>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.出生时给召唤者Buff.CopyAssign(value);
			}
		}

		// Token: 0x170066EA RID: 26346
		// (get) Token: 0x0602A25C RID: 172636 RVA: 0x009D7665 File Offset: 0x009D5865
		// (set) Token: 0x0602A25D RID: 172637 RVA: 0x009D7679 File Offset: 0x009D5879
		public unsafe FName 出生施放主动技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170066EB RID: 26347
		// (get) Token: 0x0602A25E RID: 172638 RVA: 0x009D7690 File Offset: 0x009D5890
		// (set) Token: 0x0602A25F RID: 172639 RVA: 0x009D76D3 File Offset: 0x009D58D3
		public TArray<FGameplayTag> 同步Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._同步Tags) == null)
				{
					result = (this._同步Tags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.同步Tags.CopyAssign(value);
			}
		}

		// Token: 0x170066EC RID: 26348
		// (get) Token: 0x0602A260 RID: 172640 RVA: 0x009D76E1 File Offset: 0x009D58E1
		// (set) Token: 0x0602A261 RID: 172641 RVA: 0x009D76F1 File Offset: 0x009D58F1
		public unsafe bool buff是否转移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A262 RID: 172642 RVA: 0x009D7702 File Offset: 0x009D5902
		public SVisionData()
		{
		}

		// Token: 0x0602A263 RID: 172643 RVA: 0x009D770C File Offset: 0x009D590C
		public SVisionData(int Id, string 说明, int 实体配置表Id, [Nullable(0)] TEnumAsByte<EVisionType> 类型, int 技能ID, bool 空中能否释放, bool 出生隐藏, TArray<long> 葫芦轨迹子弹列表, bool 战时是否播放出生动画, TArray<FGameplayTagContainer> 生命中Tag, TArray<int> 出生Buff, TArray<int> 出生时给召唤者Buff, FName 出生施放主动技能, TArray<FGameplayTag> 同步Tags, bool buff是否转移)
		{
			this.Id = Id;
			this.说明 = 说明;
			this.实体配置表Id = 实体配置表Id;
			this.类型 = 类型;
			this.技能ID = 技能ID;
			this.空中能否释放 = 空中能否释放;
			this.出生隐藏 = 出生隐藏;
			this.葫芦轨迹子弹列表 = 葫芦轨迹子弹列表;
			this.战时是否播放出生动画 = 战时是否播放出生动画;
			this.生命中Tag = 生命中Tag;
			this.出生Buff = 出生Buff;
			this.出生时给召唤者Buff = 出生时给召唤者Buff;
			this.出生施放主动技能 = 出生施放主动技能;
			this.同步Tags = 同步Tags;
			this.buff是否转移 = buff是否转移;
		}

		// Token: 0x0602A264 RID: 172644 RVA: 0x009D7794 File Offset: 0x009D5994
		protected override IntPtr GetUStructPtr()
		{
			return SVisionData.StaticStruct();
		}

		// Token: 0x0602A265 RID: 172645 RVA: 0x009D77A0 File Offset: 0x009D59A0
		[NullableContext(2)]
		public SVisionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A266 RID: 172646 RVA: 0x009D77AA File Offset: 0x009D59AA
		public SVisionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A267 RID: 172647 RVA: 0x009D77B5 File Offset: 0x009D59B5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVisionData(Pointer, false, true);
		}

		// Token: 0x0602A268 RID: 172648 RVA: 0x009D77BF File Offset: 0x009D59BF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVisionData(Pointer, MemoryOwner);
		}

		// Token: 0x04015B78 RID: 88952
		public const string __ObjectPath = "/Game/Aki/Character/Vision/SVisionData.SVisionData";

		// Token: 0x04015B79 RID: 88953
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015B7A RID: 88954
		internal static int __PropertyOffset_0;

		// Token: 0x04015B7B RID: 88955
		internal static int __PropertyOffset_1;

		// Token: 0x04015B7C RID: 88956
		internal static int __PropertyOffset_2;

		// Token: 0x04015B7D RID: 88957
		internal static int __PropertyOffset_3;

		// Token: 0x04015B7E RID: 88958
		internal static int __PropertyOffset_4;

		// Token: 0x04015B7F RID: 88959
		internal static int __PropertyOffset_5;

		// Token: 0x04015B80 RID: 88960
		internal static int __PropertyOffset_6;

		// Token: 0x04015B81 RID: 88961
		internal static int __PropertyOffset_7;

		// Token: 0x04015B82 RID: 88962
		[Nullable(2)]
		private TArray<long> _葫芦轨迹子弹列表;

		// Token: 0x04015B83 RID: 88963
		internal static int __PropertyOffset_8;

		// Token: 0x04015B84 RID: 88964
		internal static int __PropertyOffset_9;

		// Token: 0x04015B85 RID: 88965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagContainer> _生命中Tag;

		// Token: 0x04015B86 RID: 88966
		internal static int __PropertyOffset_10;

		// Token: 0x04015B87 RID: 88967
		[Nullable(2)]
		private TArray<int> _出生Buff;

		// Token: 0x04015B88 RID: 88968
		internal static int __PropertyOffset_11;

		// Token: 0x04015B89 RID: 88969
		[Nullable(2)]
		private TArray<int> _出生时给召唤者Buff;

		// Token: 0x04015B8A RID: 88970
		internal static int __PropertyOffset_12;

		// Token: 0x04015B8B RID: 88971
		internal static int __PropertyOffset_13;

		// Token: 0x04015B8C RID: 88972
		[Nullable(2)]
		private TArray<FGameplayTag> _同步Tags;

		// Token: 0x04015B8D RID: 88973
		internal static int __PropertyOffset_14;
	}
}
