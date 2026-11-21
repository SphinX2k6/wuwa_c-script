using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001144 RID: 4420
	public struct RoleSkinAudio : IFlatbufferObject
	{
		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600D125 RID: 53541 RVA: 0x0031BCE4 File Offset: 0x00319EE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D126 RID: 53542 RVA: 0x0031BCF1 File Offset: 0x00319EF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D127 RID: 53543 RVA: 0x0031BCF8 File Offset: 0x00319EF8
		public static RoleSkinAudio GetRootAsRoleSkinAudio(ByteBuffer _bb)
		{
			return RoleSkinAudio.GetRootAsRoleSkinAudio(_bb, default(RoleSkinAudio));
		}

		// Token: 0x0600D128 RID: 53544 RVA: 0x0031BD14 File Offset: 0x00319F14
		public static RoleSkinAudio GetRootAsRoleSkinAudio(ByteBuffer _bb, RoleSkinAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D129 RID: 53545 RVA: 0x0031BD31 File Offset: 0x00319F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D12A RID: 53546 RVA: 0x0031BD40 File Offset: 0x00319F40
		public RoleSkinAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600D12B RID: 53547 RVA: 0x0031BD50 File Offset: 0x00319F50
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

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600D12C RID: 53548 RVA: 0x0031BD8C File Offset: 0x00319F8C
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

		// Token: 0x0600D12D RID: 53549 RVA: 0x0031BDC3 File Offset: 0x00319FC3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D12E RID: 53550 RVA: 0x0031BDD2 File Offset: 0x00319FD2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600D12F RID: 53551 RVA: 0x0031BDEC File Offset: 0x00319FEC
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

		// Token: 0x0600D130 RID: 53552 RVA: 0x0031BE23 File Offset: 0x0031A023
		public Span<byte> GetFootstepEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D131 RID: 53553 RVA: 0x0031BE32 File Offset: 0x0031A032
		public byte[] GetFootstepEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600D132 RID: 53554 RVA: 0x0031BE4C File Offset: 0x0031A04C
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

		// Token: 0x0600D133 RID: 53555 RVA: 0x0031BE84 File Offset: 0x0031A084
		public Span<byte> GetFoleyEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D134 RID: 53556 RVA: 0x0031BE94 File Offset: 0x0031A094
		public byte[] GetFoleyEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600D135 RID: 53557 RVA: 0x0031BEAC File Offset: 0x0031A0AC
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

		// Token: 0x0600D136 RID: 53558 RVA: 0x0031BEE4 File Offset: 0x0031A0E4
		public Span<byte> GetFastClimbEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D137 RID: 53559 RVA: 0x0031BEF4 File Offset: 0x0031A0F4
		public byte[] GetFastClimbEventArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600D138 RID: 53560 RVA: 0x0031BF0C File Offset: 0x0031A10C
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

		// Token: 0x0600D139 RID: 53561 RVA: 0x0031BF44 File Offset: 0x0031A144
		public Span<byte> GetVisionMorphEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D13A RID: 53562 RVA: 0x0031BF54 File Offset: 0x0031A154
		public byte[] GetVisionMorphEventArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600D13B RID: 53563 RVA: 0x0031BF6C File Offset: 0x0031A16C
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

		// Token: 0x0600D13C RID: 53564 RVA: 0x0031BFA4 File Offset: 0x0031A1A4
		public Span<byte> GetVisionSummonEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D13D RID: 53565 RVA: 0x0031BFB4 File Offset: 0x0031A1B4
		public byte[] GetVisionSummonEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600D13E RID: 53566 RVA: 0x0031BFCC File Offset: 0x0031A1CC
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

		// Token: 0x0600D13F RID: 53567 RVA: 0x0031C004 File Offset: 0x0031A204
		public Span<byte> GetOpenTreasureBoxEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D140 RID: 53568 RVA: 0x0031C014 File Offset: 0x0031A214
		public byte[] GetOpenTreasureBoxEventArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600D141 RID: 53569 RVA: 0x0031C02C File Offset: 0x0031A22C
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

		// Token: 0x0600D142 RID: 53570 RVA: 0x0031C064 File Offset: 0x0031A264
		public Span<byte> GetScanTreasureBoxEventBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x0031C074 File Offset: 0x0031A274
		public byte[] GetScanTreasureBoxEventArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600D144 RID: 53572 RVA: 0x0031C08C File Offset: 0x0031A28C
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

		// Token: 0x0600D145 RID: 53573 RVA: 0x0031C0C4 File Offset: 0x0031A2C4
		public Span<byte> GetJoinTeamEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D146 RID: 53574 RVA: 0x0031C0D4 File Offset: 0x0031A2D4
		public byte[] GetJoinTeamEventArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D147 RID: 53575 RVA: 0x0031C0EC File Offset: 0x0031A2EC
		public DicIntString? LostHealthEventMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600D148 RID: 53576 RVA: 0x0031C150 File Offset: 0x0031A350
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

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600D149 RID: 53577 RVA: 0x0031C17C File Offset: 0x0031A37C
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

		// Token: 0x0600D14A RID: 53578 RVA: 0x0031C1B4 File Offset: 0x0031A3B4
		public Span<byte> GetDeathEventBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D14B RID: 53579 RVA: 0x0031C1C4 File Offset: 0x0031A3C4
		public byte[] GetDeathEventArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600D14C RID: 53580 RVA: 0x0031C1DC File Offset: 0x0031A3DC
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

		// Token: 0x0600D14D RID: 53581 RVA: 0x0031C214 File Offset: 0x0031A414
		public Span<byte> GetLowStrengthEventBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D14E RID: 53582 RVA: 0x0031C224 File Offset: 0x0031A424
		public byte[] GetLowStrengthEventArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x0031C23C File Offset: 0x0031A43C
		public string BreakUpEventList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600D150 RID: 53584 RVA: 0x0031C278 File Offset: 0x0031A478
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

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600D151 RID: 53585 RVA: 0x0031C2A4 File Offset: 0x0031A4A4
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

		// Token: 0x0600D152 RID: 53586 RVA: 0x0031C2DC File Offset: 0x0031A4DC
		public Span<byte> GetExtremeDodgeEventBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D153 RID: 53587 RVA: 0x0031C2EC File Offset: 0x0031A4EC
		public byte[] GetExtremeDodgeEventArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600D154 RID: 53588 RVA: 0x0031C304 File Offset: 0x0031A504
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

		// Token: 0x0600D155 RID: 53589 RVA: 0x0031C33C File Offset: 0x0031A53C
		public Span<byte> GetParryEventBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D156 RID: 53590 RVA: 0x0031C34C File Offset: 0x0031A54C
		public byte[] GetParryEventArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600D157 RID: 53591 RVA: 0x0031C364 File Offset: 0x0031A564
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

		// Token: 0x0600D158 RID: 53592 RVA: 0x0031C39C File Offset: 0x0031A59C
		public Span<byte> GetEnterBattleEventBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600D159 RID: 53593 RVA: 0x0031C3AC File Offset: 0x0031A5AC
		public byte[] GetEnterBattleEventArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600D15A RID: 53594 RVA: 0x0031C3C4 File Offset: 0x0031A5C4
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

		// Token: 0x0600D15B RID: 53595 RVA: 0x0031C3FC File Offset: 0x0031A5FC
		public Span<byte> GetUnderAttackEventBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600D15C RID: 53596 RVA: 0x0031C40C File Offset: 0x0031A60C
		public byte[] GetUnderAttackEventArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600D15D RID: 53597 RVA: 0x0031C424 File Offset: 0x0031A624
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

		// Token: 0x0600D15E RID: 53598 RVA: 0x0031C45C File Offset: 0x0031A65C
		public Span<byte> GetKnockUpEventBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600D15F RID: 53599 RVA: 0x0031C46C File Offset: 0x0031A66C
		public byte[] GetKnockUpEventArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600D160 RID: 53600 RVA: 0x0031C484 File Offset: 0x0031A684
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

		// Token: 0x0600D161 RID: 53601 RVA: 0x0031C4BC File Offset: 0x0031A6BC
		public Span<byte> GetEnterGlideEventBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600D162 RID: 53602 RVA: 0x0031C4CC File Offset: 0x0031A6CC
		public byte[] GetEnterGlideEventArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600D163 RID: 53603 RVA: 0x0031C4E4 File Offset: 0x0031A6E4
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

		// Token: 0x0600D164 RID: 53604 RVA: 0x0031C51C File Offset: 0x0031A71C
		public Span<byte> GetUseExploreHookEventBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600D165 RID: 53605 RVA: 0x0031C52C File Offset: 0x0031A72C
		public byte[] GetUseExploreHookEventArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600D166 RID: 53606 RVA: 0x0031C544 File Offset: 0x0031A744
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

		// Token: 0x0600D167 RID: 53607 RVA: 0x0031C57C File Offset: 0x0031A77C
		public Span<byte> GetClimbLeapEventBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600D168 RID: 53608 RVA: 0x0031C58C File Offset: 0x0031A78C
		public byte[] GetClimbLeapEventArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600D169 RID: 53609 RVA: 0x0031C5A4 File Offset: 0x0031A7A4
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

		// Token: 0x0600D16A RID: 53610 RVA: 0x0031C5DC File Offset: 0x0031A7DC
		public Span<byte> GetAccelerateEventBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x0031C5EC File Offset: 0x0031A7EC
		public byte[] GetAccelerateEventArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x0031C604 File Offset: 0x0031A804
		[NullableContext(1)]
		public string[] BreakUpEventList()
		{
			return this.BreakUpEventListIter().ToArray<string>();
		}

		// Token: 0x0600D16D RID: 53613 RVA: 0x0031C611 File Offset: 0x0031A811
		[NullableContext(1)]
		public IEnumerable<string> BreakUpEventListIter()
		{
			RoleSkinAudio.<BreakUpEventListIter>d__97 <BreakUpEventListIter>d__ = new RoleSkinAudio.<BreakUpEventListIter>d__97(-2);
			<BreakUpEventListIter>d__.<>3__<>4__this = this;
			return <BreakUpEventListIter>d__;
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x0031C628 File Offset: 0x0031A828
		[NullableContext(1)]
		public Dictionary<int, string> LostHealthEventMap()
		{
			return this.LostHealthEventMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600D16F RID: 53615 RVA: 0x0031C67E File Offset: 0x0031A87E
		[NullableContext(1)]
		public IEnumerable<DicIntString> LostHealthEventMapIter()
		{
			RoleSkinAudio.<LostHealthEventMapIter>d__99 <LostHealthEventMapIter>d__ = new RoleSkinAudio.<LostHealthEventMapIter>d__99(-2);
			<LostHealthEventMapIter>d__.<>3__<>4__this = this;
			return <LostHealthEventMapIter>d__;
		}

		// Token: 0x0600D170 RID: 53616 RVA: 0x0031C694 File Offset: 0x0031A894
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

		// Token: 0x0600D171 RID: 53617 RVA: 0x0031C6BC File Offset: 0x0031A8BC
		private void EnsureLostHealthEventMapCacheIfNeeded()
		{
			if (this.LostHealthEventMapCache != null)
			{
				return;
			}
			this.LostHealthEventMapCache = this.LostHealthEventMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x0031C722 File Offset: 0x0031A922
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetLostHealthEventMapFrozenDict()
		{
			this.EnsureLostHealthEventMapCacheIfNeeded();
			return this.LostHealthEventMapCache;
		}

		// Token: 0x04005747 RID: 22343
		private Table __p;

		// Token: 0x04005748 RID: 22344
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LostHealthEventMapCache;
	}
}
