using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105C RID: 4188
	public struct RoleSkinAudio : IFlatbufferObject
	{
		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600CACE RID: 51918 RVA: 0x002FF8CC File Offset: 0x002FDACC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CACF RID: 51919 RVA: 0x002FF8D9 File Offset: 0x002FDAD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CAD0 RID: 51920 RVA: 0x002FF8E0 File Offset: 0x002FDAE0
		public static RoleSkinAudio GetRootAsRoleSkinAudio(ByteBuffer _bb)
		{
			return RoleSkinAudio.GetRootAsRoleSkinAudio(_bb, default(RoleSkinAudio));
		}

		// Token: 0x0600CAD1 RID: 51921 RVA: 0x002FF8FC File Offset: 0x002FDAFC
		public static RoleSkinAudio GetRootAsRoleSkinAudio(ByteBuffer _bb, RoleSkinAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CAD2 RID: 51922 RVA: 0x002FF919 File Offset: 0x002FDB19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CAD3 RID: 51923 RVA: 0x002FF928 File Offset: 0x002FDB28
		public RoleSkinAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600CAD4 RID: 51924 RVA: 0x002FF938 File Offset: 0x002FDB38
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x002FF974 File Offset: 0x002FDB74
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x002FF9AB File Offset: 0x002FDBAB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x002FF9BA File Offset: 0x002FDBBA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600CAD8 RID: 51928 RVA: 0x002FF9D4 File Offset: 0x002FDBD4
		public string FootstepEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x002FFA0B File Offset: 0x002FDC0B
		public Span<byte> GetFootstepEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CADA RID: 51930 RVA: 0x002FFA1A File Offset: 0x002FDC1A
		public byte[] GetFootstepEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600CADB RID: 51931 RVA: 0x002FFA34 File Offset: 0x002FDC34
		public string FoleyEvent
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x002FFA6C File Offset: 0x002FDC6C
		public Span<byte> GetFoleyEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CADD RID: 51933 RVA: 0x002FFA7C File Offset: 0x002FDC7C
		public byte[] GetFoleyEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600CADE RID: 51934 RVA: 0x002FFA94 File Offset: 0x002FDC94
		public string FastClimbEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x002FFACC File Offset: 0x002FDCCC
		public Span<byte> GetFastClimbEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x002FFADC File Offset: 0x002FDCDC
		public byte[] GetFastClimbEventArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600CAE1 RID: 51937 RVA: 0x002FFAF4 File Offset: 0x002FDCF4
		public string VisionMorphEvent
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x002FFB2C File Offset: 0x002FDD2C
		public Span<byte> GetVisionMorphEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x002FFB3C File Offset: 0x002FDD3C
		public byte[] GetVisionMorphEventArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600CAE4 RID: 51940 RVA: 0x002FFB54 File Offset: 0x002FDD54
		public string VisionSummonEvent
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x002FFB8C File Offset: 0x002FDD8C
		public Span<byte> GetVisionSummonEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x002FFB9C File Offset: 0x002FDD9C
		public byte[] GetVisionSummonEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600CAE7 RID: 51943 RVA: 0x002FFBB4 File Offset: 0x002FDDB4
		public string OpenTreasureBoxEvent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x002FFBEC File Offset: 0x002FDDEC
		public Span<byte> GetOpenTreasureBoxEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x002FFBFC File Offset: 0x002FDDFC
		public byte[] GetOpenTreasureBoxEventArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600CAEA RID: 51946 RVA: 0x002FFC14 File Offset: 0x002FDE14
		public string ScanTreasureBoxEvent
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAEB RID: 51947 RVA: 0x002FFC4C File Offset: 0x002FDE4C
		public Span<byte> GetScanTreasureBoxEventBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CAEC RID: 51948 RVA: 0x002FFC5C File Offset: 0x002FDE5C
		public byte[] GetScanTreasureBoxEventArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600CAED RID: 51949 RVA: 0x002FFC74 File Offset: 0x002FDE74
		public string JoinTeamEvent
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x002FFCAC File Offset: 0x002FDEAC
		public Span<byte> GetJoinTeamEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x002FFCBC File Offset: 0x002FDEBC
		public byte[] GetJoinTeamEventArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x002FFCD4 File Offset: 0x002FDED4
		public DicIntString? LostHealthEventMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600CAF1 RID: 51953 RVA: 0x002FFD38 File Offset: 0x002FDF38
		public int LostHealthEventMapLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600CAF2 RID: 51954 RVA: 0x002FFD64 File Offset: 0x002FDF64
		public string DeathEvent
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAF3 RID: 51955 RVA: 0x002FFD9C File Offset: 0x002FDF9C
		public Span<byte> GetDeathEventBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CAF4 RID: 51956 RVA: 0x002FFDAC File Offset: 0x002FDFAC
		public byte[] GetDeathEventArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x002FFDC4 File Offset: 0x002FDFC4
		public string LowStrengthEvent
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAF6 RID: 51958 RVA: 0x002FFDFC File Offset: 0x002FDFFC
		public Span<byte> GetLowStrengthEventBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x002FFE0C File Offset: 0x002FE00C
		public byte[] GetLowStrengthEventArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CAF8 RID: 51960 RVA: 0x002FFE24 File Offset: 0x002FE024
		public string BreakUpEventList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600CAF9 RID: 51961 RVA: 0x002FFE60 File Offset: 0x002FE060
		public int BreakUpEventListLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600CAFA RID: 51962 RVA: 0x002FFE8C File Offset: 0x002FE08C
		public string ExtremeDodgeEvent
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAFB RID: 51963 RVA: 0x002FFEC4 File Offset: 0x002FE0C4
		public Span<byte> GetExtremeDodgeEventBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600CAFC RID: 51964 RVA: 0x002FFED4 File Offset: 0x002FE0D4
		public byte[] GetExtremeDodgeEventArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600CAFD RID: 51965 RVA: 0x002FFEEC File Offset: 0x002FE0EC
		public string ParryEvent
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAFE RID: 51966 RVA: 0x002FFF24 File Offset: 0x002FE124
		public Span<byte> GetParryEventBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600CAFF RID: 51967 RVA: 0x002FFF34 File Offset: 0x002FE134
		public byte[] GetParryEventArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600CB00 RID: 51968 RVA: 0x002FFF4C File Offset: 0x002FE14C
		public string EnterBattleEvent
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x002FFF84 File Offset: 0x002FE184
		public Span<byte> GetEnterBattleEventBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x002FFF94 File Offset: 0x002FE194
		public byte[] GetEnterBattleEventArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600CB03 RID: 51971 RVA: 0x002FFFAC File Offset: 0x002FE1AC
		public string UnderAttackEvent
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x002FFFE4 File Offset: 0x002FE1E4
		public Span<byte> GetUnderAttackEventBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x002FFFF4 File Offset: 0x002FE1F4
		public byte[] GetUnderAttackEventArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600CB06 RID: 51974 RVA: 0x0030000C File Offset: 0x002FE20C
		public string KnockUpEvent
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB07 RID: 51975 RVA: 0x00300044 File Offset: 0x002FE244
		public Span<byte> GetKnockUpEventBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600CB08 RID: 51976 RVA: 0x00300054 File Offset: 0x002FE254
		public byte[] GetKnockUpEventArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600CB09 RID: 51977 RVA: 0x0030006C File Offset: 0x002FE26C
		public string EnterGlideEvent
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB0A RID: 51978 RVA: 0x003000A4 File Offset: 0x002FE2A4
		public Span<byte> GetEnterGlideEventBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600CB0B RID: 51979 RVA: 0x003000B4 File Offset: 0x002FE2B4
		public byte[] GetEnterGlideEventArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600CB0C RID: 51980 RVA: 0x003000CC File Offset: 0x002FE2CC
		public string UseExploreHookEvent
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x00300104 File Offset: 0x002FE304
		public Span<byte> GetUseExploreHookEventBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x00300114 File Offset: 0x002FE314
		public byte[] GetUseExploreHookEventArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600CB0F RID: 51983 RVA: 0x0030012C File Offset: 0x002FE32C
		public string ClimbLeapEvent
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB10 RID: 51984 RVA: 0x00300164 File Offset: 0x002FE364
		public Span<byte> GetClimbLeapEventBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x00300174 File Offset: 0x002FE374
		public byte[] GetClimbLeapEventArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600CB12 RID: 51986 RVA: 0x0030018C File Offset: 0x002FE38C
		public string AccelerateEvent
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB13 RID: 51987 RVA: 0x003001C4 File Offset: 0x002FE3C4
		public Span<byte> GetAccelerateEventBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600CB14 RID: 51988 RVA: 0x003001D4 File Offset: 0x002FE3D4
		public byte[] GetAccelerateEventArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CB15 RID: 51989 RVA: 0x003001EC File Offset: 0x002FE3EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BreakUpEventListIter()或GetBreakUpEventListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BreakUpEventList()
		{
			return this.BreakUpEventListIter().ToArray<string>();
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x003001F9 File Offset: 0x002FE3F9
		[NullableContext(1)]
		public readonly IEnumerable<string> BreakUpEventListIter()
		{
			RoleSkinAudio.<BreakUpEventListIter>d__97 <BreakUpEventListIter>d__ = new RoleSkinAudio.<BreakUpEventListIter>d__97(-2);
			<BreakUpEventListIter>d__.<>3__<>4__this = this;
			return <BreakUpEventListIter>d__;
		}

		// Token: 0x0600CB17 RID: 51991 RVA: 0x00300210 File Offset: 0x002FE410
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LostHealthEventMapFrozenDict()缓存字典，遍历请使用LostHealthEventMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> LostHealthEventMap()
		{
			return this.LostHealthEventMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CB18 RID: 51992 RVA: 0x00300266 File Offset: 0x002FE466
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> LostHealthEventMapIter()
		{
			RoleSkinAudio.<LostHealthEventMapIter>d__99 <LostHealthEventMapIter>d__ = new RoleSkinAudio.<LostHealthEventMapIter>d__99(-2);
			<LostHealthEventMapIter>d__.<>3__<>4__this = this;
			return <LostHealthEventMapIter>d__;
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x0030027C File Offset: 0x002FE47C
		[NullableContext(2)]
		public string GetLostHealthEventMap(int key)
		{
			this.EnsureLostHealthEventMapCacheIfNeeded();
			string result;
			if (!this.LostHealthEventMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CB1A RID: 51994 RVA: 0x003002A4 File Offset: 0x002FE4A4
		private void EnsureLostHealthEventMapCacheIfNeeded()
		{
			if (this.LostHealthEventMapCache != null)
			{
				return;
			}
			this.LostHealthEventMapCache = this.LostHealthEventMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x0030030A File Offset: 0x002FE50A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetLostHealthEventMapFrozenDict(int key)
		{
			this.EnsureLostHealthEventMapCacheIfNeeded();
			return this.LostHealthEventMapCache;
		}

		// Token: 0x0400515F RID: 20831
		private Table __p;

		// Token: 0x04005160 RID: 20832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LostHealthEventMapCache;
	}
}
