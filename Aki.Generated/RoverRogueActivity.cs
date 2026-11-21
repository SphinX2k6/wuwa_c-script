using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116C RID: 4460
	[NullableContext(1)]
	[Nullable(0)]
	public struct RoverRogueActivity : IFlatbufferObject
	{
		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600D478 RID: 54392 RVA: 0x00322DAC File Offset: 0x00320FAC
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D479 RID: 54393 RVA: 0x00322DB9 File Offset: 0x00320FB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D47A RID: 54394 RVA: 0x00322DC0 File Offset: 0x00320FC0
		[NullableContext(0)]
		public static RoverRogueActivity GetRootAsRoverRogueActivity(ByteBuffer _bb)
		{
			return RoverRogueActivity.GetRootAsRoverRogueActivity(_bb, default(RoverRogueActivity));
		}

		// Token: 0x0600D47B RID: 54395 RVA: 0x00322DDC File Offset: 0x00320FDC
		[NullableContext(0)]
		public static RoverRogueActivity GetRootAsRoverRogueActivity(ByteBuffer _bb, RoverRogueActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D47C RID: 54396 RVA: 0x00322DF9 File Offset: 0x00320FF9
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x00322E08 File Offset: 0x00321008
		[NullableContext(0)]
		public RoverRogueActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600D47E RID: 54398 RVA: 0x00322E18 File Offset: 0x00321018
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

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600D47F RID: 54399 RVA: 0x00322E54 File Offset: 0x00321054
		public int InsideCurrencyItemId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600D480 RID: 54400 RVA: 0x00322E90 File Offset: 0x00321090
		public int TalentPointItemId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600D481 RID: 54401 RVA: 0x00322ECC File Offset: 0x003210CC
		public int TokenItemId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600D482 RID: 54402 RVA: 0x00322F0C File Offset: 0x0032110C
		public int ShopId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600D483 RID: 54403 RVA: 0x00322F4C File Offset: 0x0032114C
		public int ShopRedDotPrice
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600D484 RID: 54404 RVA: 0x00322F8C File Offset: 0x0032118C
		public int BlessRepeatSortId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600D485 RID: 54405 RVA: 0x00322FCC File Offset: 0x003211CC
		public int BaseRefreshBless
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600D486 RID: 54406 RVA: 0x0032300C File Offset: 0x0032120C
		public int BaseRefreshBlessGroup
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600D487 RID: 54407 RVA: 0x0032304C File Offset: 0x0032124C
		public int BaseRefreshRoleEnhance
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600D488 RID: 54408 RVA: 0x0032308C File Offset: 0x0032128C
		public int BaseRefreshShop
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D489 RID: 54409 RVA: 0x003230CC File Offset: 0x003212CC
		public int SettleLevel(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600D48A RID: 54410 RVA: 0x0032310C File Offset: 0x0032130C
		public int SettleLevelLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D48B RID: 54411 RVA: 0x00323138 File Offset: 0x00321338
		[NullableContext(0)]
		public Span<int> GetSettleLevelBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600D48C RID: 54412 RVA: 0x00323148 File Offset: 0x00321348
		[NullableContext(0)]
		public int[] GetSettleLevelArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600D48D RID: 54413 RVA: 0x00323160 File Offset: 0x00321360
		[NullableContext(0)]
		public string RoomTypeMonster(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600D48E RID: 54414 RVA: 0x0032319C File Offset: 0x0032139C
		public int RoomTypeMonsterLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D48F RID: 54415 RVA: 0x003231C8 File Offset: 0x003213C8
		[NullableContext(0)]
		public string RoomTypeEssence(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600D490 RID: 54416 RVA: 0x00323204 File Offset: 0x00321404
		public int RoomTypeEssenceLength
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

		// Token: 0x0600D491 RID: 54417 RVA: 0x00323230 File Offset: 0x00321430
		[NullableContext(0)]
		public string RoomTypeBoss(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600D492 RID: 54418 RVA: 0x0032326C File Offset: 0x0032146C
		public int RoomTypeBossLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D493 RID: 54419 RVA: 0x00323298 File Offset: 0x00321498
		public DicIntString? SettleLevelIcon(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600D494 RID: 54420 RVA: 0x003232FC File Offset: 0x003214FC
		public int SettleLevelIconLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600D495 RID: 54421 RVA: 0x00323328 File Offset: 0x00321528
		public int SafeguardRoomReward
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D496 RID: 54422 RVA: 0x00323368 File Offset: 0x00321568
		public int SlotList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600D497 RID: 54423 RVA: 0x003233A8 File Offset: 0x003215A8
		public int SlotListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D498 RID: 54424 RVA: 0x003233D4 File Offset: 0x003215D4
		[NullableContext(0)]
		public Span<int> GetSlotListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600D499 RID: 54425 RVA: 0x003233E4 File Offset: 0x003215E4
		[NullableContext(0)]
		public int[] GetSlotListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600D49A RID: 54426 RVA: 0x003233FC File Offset: 0x003215FC
		public DicIntString? SlotEmptyIcon(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600D49B RID: 54427 RVA: 0x00323460 File Offset: 0x00321660
		public int SlotEmptyIconLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x0032348C File Offset: 0x0032168C
		public DicIntString? SlotName(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600D49D RID: 54429 RVA: 0x003234F0 File Offset: 0x003216F0
		public int SlotNameLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D49E RID: 54430 RVA: 0x0032351C File Offset: 0x0032171C
		public int AttributeList(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600D49F RID: 54431 RVA: 0x0032355C File Offset: 0x0032175C
		public int AttributeListLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x00323588 File Offset: 0x00321788
		[NullableContext(0)]
		public Span<int> GetAttributeListBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x00323598 File Offset: 0x00321798
		[NullableContext(0)]
		public int[] GetAttributeListArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600D4A2 RID: 54434 RVA: 0x003235B0 File Offset: 0x003217B0
		public int BlessRoleInfoShowTime
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D4A3 RID: 54435 RVA: 0x003235F0 File Offset: 0x003217F0
		public DicIntString? AttributeName(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600D4A4 RID: 54436 RVA: 0x00323654 File Offset: 0x00321854
		public int AttributeNameLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x00323680 File Offset: 0x00321880
		[NullableContext(0)]
		public string IgnoreLoseEffectType(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600D4A6 RID: 54438 RVA: 0x003236BC File Offset: 0x003218BC
		public int IgnoreLoseEffectTypeLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600D4A7 RID: 54439 RVA: 0x003236E8 File Offset: 0x003218E8
		public int TaskCoreReward
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x00323728 File Offset: 0x00321928
		public long ReviveBuffIds(int j)
		{
			int num = this.__p.__offset(54);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600D4A9 RID: 54441 RVA: 0x00323774 File Offset: 0x00321974
		public int ReviveBuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x003237A0 File Offset: 0x003219A0
		[NullableContext(0)]
		public Span<long> GetReviveBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(54, 8));
		}

		// Token: 0x0600D4AB RID: 54443 RVA: 0x003237B5 File Offset: 0x003219B5
		[NullableContext(0)]
		public long[] GetReviveBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(54) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600D4AC RID: 54444 RVA: 0x003237F1 File Offset: 0x003219F1
		public int[] AttributeList()
		{
			return this.GetAttributeListArray();
		}

		// Token: 0x0600D4AD RID: 54445 RVA: 0x003237F9 File Offset: 0x003219F9
		public IEnumerable<int> AttributeListIter()
		{
			RoverRogueActivity.<AttributeListIter>d__81 <AttributeListIter>d__ = new RoverRogueActivity.<AttributeListIter>d__81(-2);
			<AttributeListIter>d__.<>3__<>4__this = this;
			return <AttributeListIter>d__;
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x00323810 File Offset: 0x00321A10
		public Dictionary<int, string> AttributeName()
		{
			return this.AttributeNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x00323866 File Offset: 0x00321A66
		public IEnumerable<DicIntString> AttributeNameIter()
		{
			RoverRogueActivity.<AttributeNameIter>d__83 <AttributeNameIter>d__ = new RoverRogueActivity.<AttributeNameIter>d__83(-2);
			<AttributeNameIter>d__.<>3__<>4__this = this;
			return <AttributeNameIter>d__;
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x0032387B File Offset: 0x00321A7B
		public string[] IgnoreLoseEffectType()
		{
			return this.IgnoreLoseEffectTypeIter().ToArray<string>();
		}

		// Token: 0x0600D4B1 RID: 54449 RVA: 0x00323888 File Offset: 0x00321A88
		public IEnumerable<string> IgnoreLoseEffectTypeIter()
		{
			RoverRogueActivity.<IgnoreLoseEffectTypeIter>d__85 <IgnoreLoseEffectTypeIter>d__ = new RoverRogueActivity.<IgnoreLoseEffectTypeIter>d__85(-2);
			<IgnoreLoseEffectTypeIter>d__.<>3__<>4__this = this;
			return <IgnoreLoseEffectTypeIter>d__;
		}

		// Token: 0x0600D4B2 RID: 54450 RVA: 0x0032389D File Offset: 0x00321A9D
		public long[] ReviveBuffIds()
		{
			return this.GetReviveBuffIdsArray();
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x003238A5 File Offset: 0x00321AA5
		public IEnumerable<long> ReviveBuffIdsIter()
		{
			RoverRogueActivity.<ReviveBuffIdsIter>d__87 <ReviveBuffIdsIter>d__ = new RoverRogueActivity.<ReviveBuffIdsIter>d__87(-2);
			<ReviveBuffIdsIter>d__.<>3__<>4__this = this;
			return <ReviveBuffIdsIter>d__;
		}

		// Token: 0x0600D4B4 RID: 54452 RVA: 0x003238BA File Offset: 0x00321ABA
		public string[] RoomTypeBoss()
		{
			return this.RoomTypeBossIter().ToArray<string>();
		}

		// Token: 0x0600D4B5 RID: 54453 RVA: 0x003238C7 File Offset: 0x00321AC7
		public IEnumerable<string> RoomTypeBossIter()
		{
			RoverRogueActivity.<RoomTypeBossIter>d__89 <RoomTypeBossIter>d__ = new RoverRogueActivity.<RoomTypeBossIter>d__89(-2);
			<RoomTypeBossIter>d__.<>3__<>4__this = this;
			return <RoomTypeBossIter>d__;
		}

		// Token: 0x0600D4B6 RID: 54454 RVA: 0x003238DC File Offset: 0x00321ADC
		public string[] RoomTypeEssence()
		{
			return this.RoomTypeEssenceIter().ToArray<string>();
		}

		// Token: 0x0600D4B7 RID: 54455 RVA: 0x003238E9 File Offset: 0x00321AE9
		public IEnumerable<string> RoomTypeEssenceIter()
		{
			RoverRogueActivity.<RoomTypeEssenceIter>d__91 <RoomTypeEssenceIter>d__ = new RoverRogueActivity.<RoomTypeEssenceIter>d__91(-2);
			<RoomTypeEssenceIter>d__.<>3__<>4__this = this;
			return <RoomTypeEssenceIter>d__;
		}

		// Token: 0x0600D4B8 RID: 54456 RVA: 0x003238FE File Offset: 0x00321AFE
		public string[] RoomTypeMonster()
		{
			return this.RoomTypeMonsterIter().ToArray<string>();
		}

		// Token: 0x0600D4B9 RID: 54457 RVA: 0x0032390B File Offset: 0x00321B0B
		public IEnumerable<string> RoomTypeMonsterIter()
		{
			RoverRogueActivity.<RoomTypeMonsterIter>d__93 <RoomTypeMonsterIter>d__ = new RoverRogueActivity.<RoomTypeMonsterIter>d__93(-2);
			<RoomTypeMonsterIter>d__.<>3__<>4__this = this;
			return <RoomTypeMonsterIter>d__;
		}

		// Token: 0x0600D4BA RID: 54458 RVA: 0x00323920 File Offset: 0x00321B20
		public int[] SettleLevel()
		{
			return this.GetSettleLevelArray();
		}

		// Token: 0x0600D4BB RID: 54459 RVA: 0x00323928 File Offset: 0x00321B28
		public IEnumerable<int> SettleLevelIter()
		{
			RoverRogueActivity.<SettleLevelIter>d__95 <SettleLevelIter>d__ = new RoverRogueActivity.<SettleLevelIter>d__95(-2);
			<SettleLevelIter>d__.<>3__<>4__this = this;
			return <SettleLevelIter>d__;
		}

		// Token: 0x0600D4BC RID: 54460 RVA: 0x00323940 File Offset: 0x00321B40
		public Dictionary<int, string> SettleLevelIcon()
		{
			return this.SettleLevelIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600D4BD RID: 54461 RVA: 0x00323996 File Offset: 0x00321B96
		public IEnumerable<DicIntString> SettleLevelIconIter()
		{
			RoverRogueActivity.<SettleLevelIconIter>d__97 <SettleLevelIconIter>d__ = new RoverRogueActivity.<SettleLevelIconIter>d__97(-2);
			<SettleLevelIconIter>d__.<>3__<>4__this = this;
			return <SettleLevelIconIter>d__;
		}

		// Token: 0x0600D4BE RID: 54462 RVA: 0x003239AC File Offset: 0x00321BAC
		public Dictionary<int, string> SlotEmptyIcon()
		{
			return this.SlotEmptyIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600D4BF RID: 54463 RVA: 0x00323A02 File Offset: 0x00321C02
		public IEnumerable<DicIntString> SlotEmptyIconIter()
		{
			RoverRogueActivity.<SlotEmptyIconIter>d__99 <SlotEmptyIconIter>d__ = new RoverRogueActivity.<SlotEmptyIconIter>d__99(-2);
			<SlotEmptyIconIter>d__.<>3__<>4__this = this;
			return <SlotEmptyIconIter>d__;
		}

		// Token: 0x0600D4C0 RID: 54464 RVA: 0x00323A17 File Offset: 0x00321C17
		public int[] SlotList()
		{
			return this.GetSlotListArray();
		}

		// Token: 0x0600D4C1 RID: 54465 RVA: 0x00323A1F File Offset: 0x00321C1F
		public IEnumerable<int> SlotListIter()
		{
			RoverRogueActivity.<SlotListIter>d__101 <SlotListIter>d__ = new RoverRogueActivity.<SlotListIter>d__101(-2);
			<SlotListIter>d__.<>3__<>4__this = this;
			return <SlotListIter>d__;
		}

		// Token: 0x0600D4C2 RID: 54466 RVA: 0x00323A34 File Offset: 0x00321C34
		public Dictionary<int, string> SlotName()
		{
			return this.SlotNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600D4C3 RID: 54467 RVA: 0x00323A8A File Offset: 0x00321C8A
		public IEnumerable<DicIntString> SlotNameIter()
		{
			RoverRogueActivity.<SlotNameIter>d__103 <SlotNameIter>d__ = new RoverRogueActivity.<SlotNameIter>d__103(-2);
			<SlotNameIter>d__.<>3__<>4__this = this;
			return <SlotNameIter>d__;
		}

		// Token: 0x0600D4C4 RID: 54468 RVA: 0x00323AA0 File Offset: 0x00321CA0
		[NullableContext(2)]
		public string GetAttributeName(int key)
		{
			this.EnsureAttributeNameCacheIfNeeded();
			string result;
			if (!this.AttributeNameCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x00323AC8 File Offset: 0x00321CC8
		[NullableContext(2)]
		public string GetSettleLevelIcon(int key)
		{
			this.EnsureSettleLevelIconCacheIfNeeded();
			string result;
			if (!this.SettleLevelIconCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600D4C6 RID: 54470 RVA: 0x00323AF0 File Offset: 0x00321CF0
		[NullableContext(2)]
		public string GetSlotEmptyIcon(int key)
		{
			this.EnsureSlotEmptyIconCacheIfNeeded();
			string result;
			if (!this.SlotEmptyIconCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600D4C7 RID: 54471 RVA: 0x00323B18 File Offset: 0x00321D18
		[NullableContext(2)]
		public string GetSlotName(int key)
		{
			this.EnsureSlotNameCacheIfNeeded();
			string result;
			if (!this.SlotNameCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x00323B40 File Offset: 0x00321D40
		private void EnsureAttributeNameCacheIfNeeded()
		{
			if (this.AttributeNameCache != null)
			{
				return;
			}
			this.AttributeNameCache = this.AttributeNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x00323BA8 File Offset: 0x00321DA8
		private void EnsureSettleLevelIconCacheIfNeeded()
		{
			if (this.SettleLevelIconCache != null)
			{
				return;
			}
			this.SettleLevelIconCache = this.SettleLevelIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D4CA RID: 54474 RVA: 0x00323C10 File Offset: 0x00321E10
		private void EnsureSlotEmptyIconCacheIfNeeded()
		{
			if (this.SlotEmptyIconCache != null)
			{
				return;
			}
			this.SlotEmptyIconCache = this.SlotEmptyIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x00323C78 File Offset: 0x00321E78
		private void EnsureSlotNameCacheIfNeeded()
		{
			if (this.SlotNameCache != null)
			{
				return;
			}
			this.SlotNameCache = this.SlotNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x00323CDE File Offset: 0x00321EDE
		public FrozenDictionary<int, string> GetAttributeNameFrozenDict()
		{
			this.EnsureAttributeNameCacheIfNeeded();
			return this.AttributeNameCache;
		}

		// Token: 0x0600D4CD RID: 54477 RVA: 0x00323CEC File Offset: 0x00321EEC
		public FrozenDictionary<int, string> GetSettleLevelIconFrozenDict()
		{
			this.EnsureSettleLevelIconCacheIfNeeded();
			return this.SettleLevelIconCache;
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x00323CFA File Offset: 0x00321EFA
		public FrozenDictionary<int, string> GetSlotEmptyIconFrozenDict()
		{
			this.EnsureSlotEmptyIconCacheIfNeeded();
			return this.SlotEmptyIconCache;
		}

		// Token: 0x0600D4CF RID: 54479 RVA: 0x00323D08 File Offset: 0x00321F08
		public FrozenDictionary<int, string> GetSlotNameFrozenDict()
		{
			this.EnsureSlotNameCacheIfNeeded();
			return this.SlotNameCache;
		}

		// Token: 0x04005775 RID: 22389
		private Table __p;

		// Token: 0x04005776 RID: 22390
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> AttributeNameCache;

		// Token: 0x04005777 RID: 22391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SettleLevelIconCache;

		// Token: 0x04005778 RID: 22392
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SlotEmptyIconCache;

		// Token: 0x04005779 RID: 22393
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SlotNameCache;
	}
}
