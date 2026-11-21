using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Vision
{
	// Token: 0x02003288 RID: 12936
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vision/SVisionData.SVisionData")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 145)]
	public class SVisionData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060205B4 RID: 132532 RVA: 0x00944427 File Offset: 0x00942627
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVisionData._ScriptStructPtr != 0) ? SVisionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Vision/SVisionData.SVisionData", ref SVisionData._ScriptStructPtr);
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x060205B5 RID: 132533 RVA: 0x0094444B File Offset: 0x0094264B
		// (set) Token: 0x060205B6 RID: 132534 RVA: 0x0094445B File Offset: 0x0094265B
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x060205B7 RID: 132535 RVA: 0x0094446C File Offset: 0x0094266C
		// (set) Token: 0x060205B8 RID: 132536 RVA: 0x00944480 File Offset: 0x00942680
		public unsafe string 说明
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVisionData.__PropertyOffset_说明)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVisionData.__PropertyOffset_说明)), value);
			}
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x060205B9 RID: 132537 RVA: 0x00944495 File Offset: 0x00942695
		// (set) Token: 0x060205BA RID: 132538 RVA: 0x009444A5 File Offset: 0x009426A5
		public unsafe int 实体配置表Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_实体配置表Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_实体配置表Id) = value;
			}
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x060205BB RID: 132539 RVA: 0x009444B6 File Offset: 0x009426B6
		// (set) Token: 0x060205BC RID: 132540 RVA: 0x009444CA File Offset: 0x009426CA
		[Nullable(0)]
		public unsafe TEnumAsByte<EVisionType> 类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_类型) = value;
			}
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x060205BD RID: 132541 RVA: 0x009444DF File Offset: 0x009426DF
		// (set) Token: 0x060205BE RID: 132542 RVA: 0x009444EF File Offset: 0x009426EF
		public unsafe int 技能ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_技能ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_技能ID) = value;
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x060205BF RID: 132543 RVA: 0x00944500 File Offset: 0x00942700
		// (set) Token: 0x060205C0 RID: 132544 RVA: 0x00944510 File Offset: 0x00942710
		public unsafe bool 空中能否释放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_空中能否释放) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_空中能否释放) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x060205C1 RID: 132545 RVA: 0x00944521 File Offset: 0x00942721
		// (set) Token: 0x060205C2 RID: 132546 RVA: 0x00944531 File Offset: 0x00942731
		public unsafe bool 出生隐藏
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_出生隐藏) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_出生隐藏) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x060205C3 RID: 132547 RVA: 0x00944544 File Offset: 0x00942744
		// (set) Token: 0x060205C4 RID: 132548 RVA: 0x00944587 File Offset: 0x00942787
		public TArray<long> 葫芦轨迹子弹列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._葫芦轨迹子弹列表) == null)
				{
					result = (this._葫芦轨迹子弹列表 = new TArray<long>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_葫芦轨迹子弹列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.葫芦轨迹子弹列表.CopyAssign(value);
			}
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x060205C5 RID: 132549 RVA: 0x00944595 File Offset: 0x00942795
		// (set) Token: 0x060205C6 RID: 132550 RVA: 0x009445A5 File Offset: 0x009427A5
		public unsafe bool 战时是否播放出生动画
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_战时是否播放出生动画) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_战时是否播放出生动画) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x060205C7 RID: 132551 RVA: 0x009445B8 File Offset: 0x009427B8
		// (set) Token: 0x060205C8 RID: 132552 RVA: 0x009445FB File Offset: 0x009427FB
		public TArray<FGameplayTagContainer> 生命中Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagContainer> result;
				if ((result = this._生命中Tag) == null)
				{
					result = (this._生命中Tag = new TArray<FGameplayTagContainer>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_生命中Tag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.生命中Tag.CopyAssign(value);
			}
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x060205C9 RID: 132553 RVA: 0x0094460C File Offset: 0x0094280C
		// (set) Token: 0x060205CA RID: 132554 RVA: 0x0094464F File Offset: 0x0094284F
		public TArray<int> 出生Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._出生Buff) == null)
				{
					result = (this._出生Buff = new TArray<int>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_出生Buff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.出生Buff.CopyAssign(value);
			}
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x060205CB RID: 132555 RVA: 0x00944660 File Offset: 0x00942860
		// (set) Token: 0x060205CC RID: 132556 RVA: 0x009446A3 File Offset: 0x009428A3
		public TArray<int> 出生时给召唤者Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._出生时给召唤者Buff) == null)
				{
					result = (this._出生时给召唤者Buff = new TArray<int>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_出生时给召唤者Buff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.出生时给召唤者Buff.CopyAssign(value);
			}
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x060205CD RID: 132557 RVA: 0x009446B1 File Offset: 0x009428B1
		// (set) Token: 0x060205CE RID: 132558 RVA: 0x009446C5 File Offset: 0x009428C5
		public unsafe FName 出生施放主动技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_出生施放主动技能);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_出生施放主动技能) = value;
			}
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x060205CF RID: 132559 RVA: 0x009446DC File Offset: 0x009428DC
		// (set) Token: 0x060205D0 RID: 132560 RVA: 0x0094471F File Offset: 0x0094291F
		public TArray<FGameplayTag> 同步Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._同步Tags) == null)
				{
					result = (this._同步Tags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_同步Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.同步Tags.CopyAssign(value);
			}
		}

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x060205D1 RID: 132561 RVA: 0x0094472D File Offset: 0x0094292D
		// (set) Token: 0x060205D2 RID: 132562 RVA: 0x0094473D File Offset: 0x0094293D
		public unsafe bool buff是否转移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_buff是否转移) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionData.__PropertyOffset_buff是否转移) = (value ? 1 : 0);
			}
		}

		// Token: 0x060205D3 RID: 132563 RVA: 0x0094474E File Offset: 0x0094294E
		public SVisionData()
		{
		}

		// Token: 0x060205D4 RID: 132564 RVA: 0x00944756 File Offset: 0x00942956
		protected override IntPtr GetUStructPtr()
		{
			return SVisionData.StaticStruct();
		}

		// Token: 0x060205D5 RID: 132565 RVA: 0x00944762 File Offset: 0x00942962
		[NullableContext(2)]
		public SVisionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060205D6 RID: 132566 RVA: 0x0094476C File Offset: 0x0094296C
		public SVisionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060205D7 RID: 132567 RVA: 0x00944777 File Offset: 0x00942977
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVisionData(Pointer, false, true);
		}

		// Token: 0x060205D8 RID: 132568 RVA: 0x00944781 File Offset: 0x00942981
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVisionData(Pointer, MemoryOwner);
		}

		// Token: 0x04011791 RID: 71569
		public const string __ObjectPath = "/Game/Aki/Character/Vision/SVisionData.SVisionData";

		// Token: 0x04011792 RID: 71570
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011793 RID: 71571
		internal static int __PropertyOffset_Id;

		// Token: 0x04011794 RID: 71572
		internal static int __PropertyOffset_说明;

		// Token: 0x04011795 RID: 71573
		internal static int __PropertyOffset_实体配置表Id;

		// Token: 0x04011796 RID: 71574
		internal static int __PropertyOffset_类型;

		// Token: 0x04011797 RID: 71575
		internal static int __PropertyOffset_技能ID;

		// Token: 0x04011798 RID: 71576
		internal static int __PropertyOffset_空中能否释放;

		// Token: 0x04011799 RID: 71577
		internal static int __PropertyOffset_出生隐藏;

		// Token: 0x0401179A RID: 71578
		internal static int __PropertyOffset_葫芦轨迹子弹列表;

		// Token: 0x0401179B RID: 71579
		[Nullable(2)]
		private TArray<long> _葫芦轨迹子弹列表;

		// Token: 0x0401179C RID: 71580
		internal static int __PropertyOffset_战时是否播放出生动画;

		// Token: 0x0401179D RID: 71581
		internal static int __PropertyOffset_生命中Tag;

		// Token: 0x0401179E RID: 71582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagContainer> _生命中Tag;

		// Token: 0x0401179F RID: 71583
		internal static int __PropertyOffset_出生Buff;

		// Token: 0x040117A0 RID: 71584
		[Nullable(2)]
		private TArray<int> _出生Buff;

		// Token: 0x040117A1 RID: 71585
		internal static int __PropertyOffset_出生时给召唤者Buff;

		// Token: 0x040117A2 RID: 71586
		[Nullable(2)]
		private TArray<int> _出生时给召唤者Buff;

		// Token: 0x040117A3 RID: 71587
		internal static int __PropertyOffset_出生施放主动技能;

		// Token: 0x040117A4 RID: 71588
		internal static int __PropertyOffset_同步Tags;

		// Token: 0x040117A5 RID: 71589
		[Nullable(2)]
		private TArray<FGameplayTag> _同步Tags;

		// Token: 0x040117A6 RID: 71590
		internal static int __PropertyOffset_buff是否转移;
	}
}
