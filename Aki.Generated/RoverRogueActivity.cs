using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001071 RID: 4209
	[NullableContext(1)]
	[Nullable(0)]
	public struct RoverRogueActivity : IFlatbufferObject
	{
		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600CCA5 RID: 52389 RVA: 0x00303554 File Offset: 0x00301754
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x00303561 File Offset: 0x00301761
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x00303568 File Offset: 0x00301768
		[NullableContext(0)]
		public static RoverRogueActivity GetRootAsRoverRogueActivity(ByteBuffer _bb)
		{
			return RoverRogueActivity.GetRootAsRoverRogueActivity(_bb, default(RoverRogueActivity));
		}

		// Token: 0x0600CCA8 RID: 52392 RVA: 0x00303584 File Offset: 0x00301784
		[NullableContext(0)]
		public static RoverRogueActivity GetRootAsRoverRogueActivity(ByteBuffer _bb, RoverRogueActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCA9 RID: 52393 RVA: 0x003035A1 File Offset: 0x003017A1
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCAA RID: 52394 RVA: 0x003035B0 File Offset: 0x003017B0
		[NullableContext(0)]
		public RoverRogueActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600CCAB RID: 52395 RVA: 0x003035C0 File Offset: 0x003017C0
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

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600CCAC RID: 52396 RVA: 0x003035FC File Offset: 0x003017FC
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

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600CCAD RID: 52397 RVA: 0x00303638 File Offset: 0x00301838
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

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600CCAE RID: 52398 RVA: 0x00303674 File Offset: 0x00301874
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

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600CCAF RID: 52399 RVA: 0x003036B4 File Offset: 0x003018B4
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

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600CCB0 RID: 52400 RVA: 0x003036F4 File Offset: 0x003018F4
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

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600CCB1 RID: 52401 RVA: 0x00303734 File Offset: 0x00301934
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

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600CCB2 RID: 52402 RVA: 0x00303774 File Offset: 0x00301974
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

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x003037B4 File Offset: 0x003019B4
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

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x003037F4 File Offset: 0x003019F4
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

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600CCB5 RID: 52405 RVA: 0x00303834 File Offset: 0x00301A34
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

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x00303874 File Offset: 0x00301A74
		public int SettleLevel(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600CCB7 RID: 52407 RVA: 0x003038B4 File Offset: 0x00301AB4
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

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x003038E0 File Offset: 0x00301AE0
		[NullableContext(0)]
		public Span<int> GetSettleLevelBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600CCB9 RID: 52409 RVA: 0x003038F0 File Offset: 0x00301AF0
		[NullableContext(0)]
		public int[] GetSettleLevelArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600CCBA RID: 52410 RVA: 0x00303908 File Offset: 0x00301B08
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

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600CCBB RID: 52411 RVA: 0x00303944 File Offset: 0x00301B44
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

		// Token: 0x0600CCBC RID: 52412 RVA: 0x00303970 File Offset: 0x00301B70
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

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x003039AC File Offset: 0x00301BAC
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

		// Token: 0x0600CCBE RID: 52414 RVA: 0x003039D8 File Offset: 0x00301BD8
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

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x00303A14 File Offset: 0x00301C14
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

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x00303A40 File Offset: 0x00301C40
		public DicIntString? SettleLevelIcon(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600CCC1 RID: 52417 RVA: 0x00303AA4 File Offset: 0x00301CA4
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

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600CCC2 RID: 52418 RVA: 0x00303AD0 File Offset: 0x00301CD0
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

		// Token: 0x0600CCC3 RID: 52419 RVA: 0x00303B10 File Offset: 0x00301D10
		public int SlotList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600CCC4 RID: 52420 RVA: 0x00303B50 File Offset: 0x00301D50
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

		// Token: 0x0600CCC5 RID: 52421 RVA: 0x00303B7C File Offset: 0x00301D7C
		[NullableContext(0)]
		public Span<int> GetSlotListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x00303B8C File Offset: 0x00301D8C
		[NullableContext(0)]
		public int[] GetSlotListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x00303BA4 File Offset: 0x00301DA4
		public DicIntString? SlotEmptyIcon(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600CCC8 RID: 52424 RVA: 0x00303C08 File Offset: 0x00301E08
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

		// Token: 0x0600CCC9 RID: 52425 RVA: 0x00303C34 File Offset: 0x00301E34
		public DicIntString? SlotName(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600CCCA RID: 52426 RVA: 0x00303C98 File Offset: 0x00301E98
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

		// Token: 0x0600CCCB RID: 52427 RVA: 0x00303CC4 File Offset: 0x00301EC4
		public int AttributeList(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x00303D04 File Offset: 0x00301F04
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

		// Token: 0x0600CCCD RID: 52429 RVA: 0x00303D30 File Offset: 0x00301F30
		[NullableContext(0)]
		public Span<int> GetAttributeListBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600CCCE RID: 52430 RVA: 0x00303D40 File Offset: 0x00301F40
		[NullableContext(0)]
		public int[] GetAttributeListArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600CCCF RID: 52431 RVA: 0x00303D58 File Offset: 0x00301F58
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

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x00303D98 File Offset: 0x00301F98
		public DicIntString? AttributeName(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600CCD1 RID: 52433 RVA: 0x00303DFC File Offset: 0x00301FFC
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

		// Token: 0x0600CCD2 RID: 52434 RVA: 0x00303E28 File Offset: 0x00302028
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

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600CCD3 RID: 52435 RVA: 0x00303E64 File Offset: 0x00302064
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

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600CCD4 RID: 52436 RVA: 0x00303E90 File Offset: 0x00302090
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

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x00303ED0 File Offset: 0x003020D0
		public long ReviveBuffIds(int j)
		{
			int num = this.__p.__offset(54);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x00303F1C File Offset: 0x0030211C
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

		// Token: 0x0600CCD7 RID: 52439 RVA: 0x00303F48 File Offset: 0x00302148
		[NullableContext(0)]
		public Span<long> GetReviveBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(54, 8));
		}

		// Token: 0x0600CCD8 RID: 52440 RVA: 0x00303F5D File Offset: 0x0030215D
		[NullableContext(0)]
		public long[] GetReviveBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(54) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600CCD9 RID: 52441 RVA: 0x00303F9C File Offset: 0x0030219C
		[Obsolete("本方法用于缓存,遍历请使用AttributeListIter()或GetAttributeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributeList()
		{
			RoverRogueActivity roverRogueActivity = this;
			return roverRogueActivity.GetAttributeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CCDA RID: 52442 RVA: 0x00303FC0 File Offset: 0x003021C0
		public readonly IEnumerable<int> AttributeListIter()
		{
			RoverRogueActivity.<AttributeListIter>d__81 <AttributeListIter>d__ = new RoverRogueActivity.<AttributeListIter>d__81(-2);
			<AttributeListIter>d__.<>3__<>4__this = this;
			return <AttributeListIter>d__;
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x00303FD8 File Offset: 0x003021D8
		[Obsolete("已废弃，请使用AttributeNameFrozenDict()缓存字典，遍历请使用AttributeNameIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> AttributeName()
		{
			return this.AttributeNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x0030402E File Offset: 0x0030222E
		public readonly IEnumerable<DicIntString> AttributeNameIter()
		{
			RoverRogueActivity.<AttributeNameIter>d__83 <AttributeNameIter>d__ = new RoverRogueActivity.<AttributeNameIter>d__83(-2);
			<AttributeNameIter>d__.<>3__<>4__this = this;
			return <AttributeNameIter>d__;
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x00304043 File Offset: 0x00302243
		[Obsolete("本方法用于缓存,遍历请使用IgnoreLoseEffectTypeIter()或GetIgnoreLoseEffectTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IgnoreLoseEffectType()
		{
			return this.IgnoreLoseEffectTypeIter().ToArray<string>();
		}

		// Token: 0x0600CCDE RID: 52446 RVA: 0x00304050 File Offset: 0x00302250
		public readonly IEnumerable<string> IgnoreLoseEffectTypeIter()
		{
			RoverRogueActivity.<IgnoreLoseEffectTypeIter>d__85 <IgnoreLoseEffectTypeIter>d__ = new RoverRogueActivity.<IgnoreLoseEffectTypeIter>d__85(-2);
			<IgnoreLoseEffectTypeIter>d__.<>3__<>4__this = this;
			return <IgnoreLoseEffectTypeIter>d__;
		}

		// Token: 0x0600CCDF RID: 52447 RVA: 0x00304068 File Offset: 0x00302268
		[Obsolete("本方法用于缓存,遍历请使用ReviveBuffIdsIter()或GetReviveBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] ReviveBuffIds()
		{
			RoverRogueActivity roverRogueActivity = this;
			return roverRogueActivity.GetReviveBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600CCE0 RID: 52448 RVA: 0x0030408C File Offset: 0x0030228C
		public readonly IEnumerable<long> ReviveBuffIdsIter()
		{
			RoverRogueActivity.<ReviveBuffIdsIter>d__87 <ReviveBuffIdsIter>d__ = new RoverRogueActivity.<ReviveBuffIdsIter>d__87(-2);
			<ReviveBuffIdsIter>d__.<>3__<>4__this = this;
			return <ReviveBuffIdsIter>d__;
		}

		// Token: 0x0600CCE1 RID: 52449 RVA: 0x003040A1 File Offset: 0x003022A1
		[Obsolete("本方法用于缓存,遍历请使用RoomTypeBossIter()或GetRoomTypeBossBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RoomTypeBoss()
		{
			return this.RoomTypeBossIter().ToArray<string>();
		}

		// Token: 0x0600CCE2 RID: 52450 RVA: 0x003040AE File Offset: 0x003022AE
		public readonly IEnumerable<string> RoomTypeBossIter()
		{
			RoverRogueActivity.<RoomTypeBossIter>d__89 <RoomTypeBossIter>d__ = new RoverRogueActivity.<RoomTypeBossIter>d__89(-2);
			<RoomTypeBossIter>d__.<>3__<>4__this = this;
			return <RoomTypeBossIter>d__;
		}

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x003040C3 File Offset: 0x003022C3
		[Obsolete("本方法用于缓存,遍历请使用RoomTypeEssenceIter()或GetRoomTypeEssenceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RoomTypeEssence()
		{
			return this.RoomTypeEssenceIter().ToArray<string>();
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x003040D0 File Offset: 0x003022D0
		public readonly IEnumerable<string> RoomTypeEssenceIter()
		{
			RoverRogueActivity.<RoomTypeEssenceIter>d__91 <RoomTypeEssenceIter>d__ = new RoverRogueActivity.<RoomTypeEssenceIter>d__91(-2);
			<RoomTypeEssenceIter>d__.<>3__<>4__this = this;
			return <RoomTypeEssenceIter>d__;
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x003040E5 File Offset: 0x003022E5
		[Obsolete("本方法用于缓存,遍历请使用RoomTypeMonsterIter()或GetRoomTypeMonsterBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RoomTypeMonster()
		{
			return this.RoomTypeMonsterIter().ToArray<string>();
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x003040F2 File Offset: 0x003022F2
		public readonly IEnumerable<string> RoomTypeMonsterIter()
		{
			RoverRogueActivity.<RoomTypeMonsterIter>d__93 <RoomTypeMonsterIter>d__ = new RoverRogueActivity.<RoomTypeMonsterIter>d__93(-2);
			<RoomTypeMonsterIter>d__.<>3__<>4__this = this;
			return <RoomTypeMonsterIter>d__;
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x00304108 File Offset: 0x00302308
		[Obsolete("本方法用于缓存,遍历请使用SettleLevelIter()或GetSettleLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SettleLevel()
		{
			RoverRogueActivity roverRogueActivity = this;
			return roverRogueActivity.GetSettleLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CCE8 RID: 52456 RVA: 0x0030412C File Offset: 0x0030232C
		public readonly IEnumerable<int> SettleLevelIter()
		{
			RoverRogueActivity.<SettleLevelIter>d__95 <SettleLevelIter>d__ = new RoverRogueActivity.<SettleLevelIter>d__95(-2);
			<SettleLevelIter>d__.<>3__<>4__this = this;
			return <SettleLevelIter>d__;
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x00304144 File Offset: 0x00302344
		[Obsolete("已废弃，请使用SettleLevelIconFrozenDict()缓存字典，遍历请使用SettleLevelIconIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> SettleLevelIcon()
		{
			return this.SettleLevelIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CCEA RID: 52458 RVA: 0x0030419A File Offset: 0x0030239A
		public readonly IEnumerable<DicIntString> SettleLevelIconIter()
		{
			RoverRogueActivity.<SettleLevelIconIter>d__97 <SettleLevelIconIter>d__ = new RoverRogueActivity.<SettleLevelIconIter>d__97(-2);
			<SettleLevelIconIter>d__.<>3__<>4__this = this;
			return <SettleLevelIconIter>d__;
		}

		// Token: 0x0600CCEB RID: 52459 RVA: 0x003041B0 File Offset: 0x003023B0
		[Obsolete("已废弃，请使用SlotEmptyIconFrozenDict()缓存字典，遍历请使用SlotEmptyIconIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> SlotEmptyIcon()
		{
			return this.SlotEmptyIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x00304206 File Offset: 0x00302406
		public readonly IEnumerable<DicIntString> SlotEmptyIconIter()
		{
			RoverRogueActivity.<SlotEmptyIconIter>d__99 <SlotEmptyIconIter>d__ = new RoverRogueActivity.<SlotEmptyIconIter>d__99(-2);
			<SlotEmptyIconIter>d__.<>3__<>4__this = this;
			return <SlotEmptyIconIter>d__;
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x0030421C File Offset: 0x0030241C
		[Obsolete("本方法用于缓存,遍历请使用SlotListIter()或GetSlotListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SlotList()
		{
			RoverRogueActivity roverRogueActivity = this;
			return roverRogueActivity.GetSlotListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CCEE RID: 52462 RVA: 0x00304240 File Offset: 0x00302440
		public readonly IEnumerable<int> SlotListIter()
		{
			RoverRogueActivity.<SlotListIter>d__101 <SlotListIter>d__ = new RoverRogueActivity.<SlotListIter>d__101(-2);
			<SlotListIter>d__.<>3__<>4__this = this;
			return <SlotListIter>d__;
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x00304258 File Offset: 0x00302458
		[Obsolete("已废弃，请使用SlotNameFrozenDict()缓存字典，遍历请使用SlotNameIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> SlotName()
		{
			return this.SlotNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x003042AE File Offset: 0x003024AE
		public readonly IEnumerable<DicIntString> SlotNameIter()
		{
			RoverRogueActivity.<SlotNameIter>d__103 <SlotNameIter>d__ = new RoverRogueActivity.<SlotNameIter>d__103(-2);
			<SlotNameIter>d__.<>3__<>4__this = this;
			return <SlotNameIter>d__;
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x003042C4 File Offset: 0x003024C4
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

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x003042EC File Offset: 0x003024EC
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

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x00304314 File Offset: 0x00302514
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

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x0030433C File Offset: 0x0030253C
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

		// Token: 0x0600CCF5 RID: 52469 RVA: 0x00304364 File Offset: 0x00302564
		private void EnsureAttributeNameCacheIfNeeded()
		{
			if (this.AttributeNameCache != null)
			{
				return;
			}
			this.AttributeNameCache = this.AttributeNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CCF6 RID: 52470 RVA: 0x003043CC File Offset: 0x003025CC
		private void EnsureSettleLevelIconCacheIfNeeded()
		{
			if (this.SettleLevelIconCache != null)
			{
				return;
			}
			this.SettleLevelIconCache = this.SettleLevelIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CCF7 RID: 52471 RVA: 0x00304434 File Offset: 0x00302634
		private void EnsureSlotEmptyIconCacheIfNeeded()
		{
			if (this.SlotEmptyIconCache != null)
			{
				return;
			}
			this.SlotEmptyIconCache = this.SlotEmptyIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CCF8 RID: 52472 RVA: 0x0030449C File Offset: 0x0030269C
		private void EnsureSlotNameCacheIfNeeded()
		{
			if (this.SlotNameCache != null)
			{
				return;
			}
			this.SlotNameCache = this.SlotNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x00304502 File Offset: 0x00302702
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetAttributeNameFrozenDict(int key)
		{
			this.EnsureAttributeNameCacheIfNeeded();
			return this.AttributeNameCache;
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x00304510 File Offset: 0x00302710
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetSettleLevelIconFrozenDict(int key)
		{
			this.EnsureSettleLevelIconCacheIfNeeded();
			return this.SettleLevelIconCache;
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x0030451E File Offset: 0x0030271E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetSlotEmptyIconFrozenDict(int key)
		{
			this.EnsureSlotEmptyIconCacheIfNeeded();
			return this.SlotEmptyIconCache;
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x0030452C File Offset: 0x0030272C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetSlotNameFrozenDict(int key)
		{
			this.EnsureSlotNameCacheIfNeeded();
			return this.SlotNameCache;
		}

		// Token: 0x04005176 RID: 20854
		private Table __p;

		// Token: 0x04005177 RID: 20855
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> AttributeNameCache;

		// Token: 0x04005178 RID: 20856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SettleLevelIconCache;

		// Token: 0x04005179 RID: 20857
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SlotEmptyIconCache;

		// Token: 0x0400517A RID: 20858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> SlotNameCache;
	}
}
