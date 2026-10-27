using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107D RID: 4221
	public struct RoverRogueIns : IFlatbufferObject
	{
		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600CDE3 RID: 52707 RVA: 0x00306365 File Offset: 0x00304565
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDE4 RID: 52708 RVA: 0x00306372 File Offset: 0x00304572
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDE5 RID: 52709 RVA: 0x0030637C File Offset: 0x0030457C
		public static RoverRogueIns GetRootAsRoverRogueIns(ByteBuffer _bb)
		{
			return RoverRogueIns.GetRootAsRoverRogueIns(_bb, default(RoverRogueIns));
		}

		// Token: 0x0600CDE6 RID: 52710 RVA: 0x00306398 File Offset: 0x00304598
		public static RoverRogueIns GetRootAsRoverRogueIns(ByteBuffer _bb, RoverRogueIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDE7 RID: 52711 RVA: 0x003063B5 File Offset: 0x003045B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDE8 RID: 52712 RVA: 0x003063C4 File Offset: 0x003045C4
		public RoverRogueIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600CDE9 RID: 52713 RVA: 0x003063D4 File Offset: 0x003045D4
		public int InstId
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

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x00306410 File Offset: 0x00304610
		public int ActivityId
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

		// Token: 0x0600CDEB RID: 52715 RVA: 0x0030644C File Offset: 0x0030464C
		public int RoadTypeList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600CDEC RID: 52716 RVA: 0x0030648C File Offset: 0x0030468C
		public int RoadTypeListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CDED RID: 52717 RVA: 0x003064B7 File Offset: 0x003046B7
		public Span<int> GetRoadTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600CDEE RID: 52718 RVA: 0x003064C6 File Offset: 0x003046C6
		public int[] GetRoadTypeListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600CDEF RID: 52719 RVA: 0x003064E0 File Offset: 0x003046E0
		public int RoverList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600CDF0 RID: 52720 RVA: 0x00306520 File Offset: 0x00304720
		public int RoverListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CDF1 RID: 52721 RVA: 0x0030654C File Offset: 0x0030474C
		public Span<int> GetRoverListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CDF2 RID: 52722 RVA: 0x0030655C File Offset: 0x0030475C
		public int[] GetRoverListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600CDF3 RID: 52723 RVA: 0x00306574 File Offset: 0x00304774
		public int MaxLootNum
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x003065B4 File Offset: 0x003047B4
		public int BlessGroupNum
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CDF5 RID: 52725 RVA: 0x003065F4 File Offset: 0x003047F4
		public int BlessGroupTargetBlessRoleId(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600CDF6 RID: 52726 RVA: 0x00306634 File Offset: 0x00304834
		public int BlessGroupTargetBlessRoleIdLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CDF7 RID: 52727 RVA: 0x00306660 File Offset: 0x00304860
		public Span<int> GetBlessGroupTargetBlessRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600CDF8 RID: 52728 RVA: 0x00306670 File Offset: 0x00304870
		public int[] GetBlessGroupTargetBlessRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600CDF9 RID: 52729 RVA: 0x00306688 File Offset: 0x00304888
		public string Name
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

		// Token: 0x0600CDFA RID: 52730 RVA: 0x003066C0 File Offset: 0x003048C0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CDFB RID: 52731 RVA: 0x003066D0 File Offset: 0x003048D0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600CDFC RID: 52732 RVA: 0x003066E8 File Offset: 0x003048E8
		public int Difficulty
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

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600CDFD RID: 52733 RVA: 0x00306728 File Offset: 0x00304928
		public int SortId
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

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600CDFE RID: 52734 RVA: 0x00306768 File Offset: 0x00304968
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CDFF RID: 52735 RVA: 0x003067A0 File Offset: 0x003049A0
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600CE00 RID: 52736 RVA: 0x003067B0 File Offset: 0x003049B0
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600CE01 RID: 52737 RVA: 0x003067C8 File Offset: 0x003049C8
		public string LevelName
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

		// Token: 0x0600CE02 RID: 52738 RVA: 0x00306800 File Offset: 0x00304A00
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CE03 RID: 52739 RVA: 0x00306810 File Offset: 0x00304A10
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600CE04 RID: 52740 RVA: 0x00306828 File Offset: 0x00304A28
		public string LevelDesc
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

		// Token: 0x0600CE05 RID: 52741 RVA: 0x00306860 File Offset: 0x00304A60
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600CE06 RID: 52742 RVA: 0x00306870 File Offset: 0x00304A70
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600CE07 RID: 52743 RVA: 0x00306888 File Offset: 0x00304A88
		public string LevelRoomNumDesc
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CE08 RID: 52744 RVA: 0x003068C0 File Offset: 0x00304AC0
		public Span<byte> GetLevelRoomNumDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600CE09 RID: 52745 RVA: 0x003068D0 File Offset: 0x00304AD0
		public byte[] GetLevelRoomNumDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CE0A RID: 52746 RVA: 0x003068E8 File Offset: 0x00304AE8
		public int LevelRoomNumParam(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600CE0B RID: 52747 RVA: 0x00306928 File Offset: 0x00304B28
		public int LevelRoomNumParamLength
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

		// Token: 0x0600CE0C RID: 52748 RVA: 0x00306954 File Offset: 0x00304B54
		public Span<int> GetLevelRoomNumParamBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600CE0D RID: 52749 RVA: 0x00306964 File Offset: 0x00304B64
		public int[] GetLevelRoomNumParamArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600CE0E RID: 52750 RVA: 0x0030697C File Offset: 0x00304B7C
		public string LevelMonsterRateDesc
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

		// Token: 0x0600CE0F RID: 52751 RVA: 0x003069B4 File Offset: 0x00304BB4
		public Span<byte> GetLevelMonsterRateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600CE10 RID: 52752 RVA: 0x003069C4 File Offset: 0x00304BC4
		public byte[] GetLevelMonsterRateDescArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CE11 RID: 52753 RVA: 0x003069DC File Offset: 0x00304BDC
		public int LevelMonsterRateParam(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600CE12 RID: 52754 RVA: 0x00306A1C File Offset: 0x00304C1C
		public int LevelMonsterRateParamLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CE13 RID: 52755 RVA: 0x00306A48 File Offset: 0x00304C48
		public Span<int> GetLevelMonsterRateParamBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600CE14 RID: 52756 RVA: 0x00306A58 File Offset: 0x00304C58
		public int[] GetLevelMonsterRateParamArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600CE15 RID: 52757 RVA: 0x00306A70 File Offset: 0x00304C70
		public string LevelRewardRateDesc
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

		// Token: 0x0600CE16 RID: 52758 RVA: 0x00306AA8 File Offset: 0x00304CA8
		public Span<byte> GetLevelRewardRateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600CE17 RID: 52759 RVA: 0x00306AB8 File Offset: 0x00304CB8
		public byte[] GetLevelRewardRateDescArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CE18 RID: 52760 RVA: 0x00306AD0 File Offset: 0x00304CD0
		public int LevelRewardRateParam(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600CE19 RID: 52761 RVA: 0x00306B10 File Offset: 0x00304D10
		public int LevelRewardRateParamLength
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

		// Token: 0x0600CE1A RID: 52762 RVA: 0x00306B3C File Offset: 0x00304D3C
		public Span<int> GetLevelRewardRateParamBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600CE1B RID: 52763 RVA: 0x00306B4C File Offset: 0x00304D4C
		public int[] GetLevelRewardRateParamArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600CE1C RID: 52764 RVA: 0x00306B64 File Offset: 0x00304D64
		public string LevelDetailDesc(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600CE1D RID: 52765 RVA: 0x00306BA0 File Offset: 0x00304DA0
		public int LevelDetailDescLength
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

		// Token: 0x0600CE1E RID: 52766 RVA: 0x00306BCC File Offset: 0x00304DCC
		public IntArray? LevelDetailParam(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600CE1F RID: 52767 RVA: 0x00306C30 File Offset: 0x00304E30
		public int LevelDetailParamLength
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

		// Token: 0x0600CE20 RID: 52768 RVA: 0x00306C5C File Offset: 0x00304E5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlessGroupTargetBlessRoleIdIter()或GetBlessGroupTargetBlessRoleIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BlessGroupTargetBlessRoleId()
		{
			RoverRogueIns roverRogueIns = this;
			return roverRogueIns.GetBlessGroupTargetBlessRoleIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CE21 RID: 52769 RVA: 0x00306C80 File Offset: 0x00304E80
		[NullableContext(1)]
		public readonly IEnumerable<int> BlessGroupTargetBlessRoleIdIter()
		{
			RoverRogueIns.<BlessGroupTargetBlessRoleIdIter>d__85 <BlessGroupTargetBlessRoleIdIter>d__ = new RoverRogueIns.<BlessGroupTargetBlessRoleIdIter>d__85(-2);
			<BlessGroupTargetBlessRoleIdIter>d__.<>3__<>4__this = this;
			return <BlessGroupTargetBlessRoleIdIter>d__;
		}

		// Token: 0x0600CE22 RID: 52770 RVA: 0x00306C95 File Offset: 0x00304E95
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelDetailDescIter()或GetLevelDetailDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] LevelDetailDesc()
		{
			return this.LevelDetailDescIter().ToArray<string>();
		}

		// Token: 0x0600CE23 RID: 52771 RVA: 0x00306CA2 File Offset: 0x00304EA2
		[NullableContext(1)]
		public readonly IEnumerable<string> LevelDetailDescIter()
		{
			RoverRogueIns.<LevelDetailDescIter>d__87 <LevelDetailDescIter>d__ = new RoverRogueIns.<LevelDetailDescIter>d__87(-2);
			<LevelDetailDescIter>d__.<>3__<>4__this = this;
			return <LevelDetailDescIter>d__;
		}

		// Token: 0x0600CE24 RID: 52772 RVA: 0x00306CB7 File Offset: 0x00304EB7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelDetailParamIter()或GetLevelDetailParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] LevelDetailParam()
		{
			return this.LevelDetailParamIter().ToArray<IntArray>();
		}

		// Token: 0x0600CE25 RID: 52773 RVA: 0x00306CC4 File Offset: 0x00304EC4
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> LevelDetailParamIter()
		{
			RoverRogueIns.<LevelDetailParamIter>d__89 <LevelDetailParamIter>d__ = new RoverRogueIns.<LevelDetailParamIter>d__89(-2);
			<LevelDetailParamIter>d__.<>3__<>4__this = this;
			return <LevelDetailParamIter>d__;
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x00306CDC File Offset: 0x00304EDC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelMonsterRateParamIter()或GetLevelMonsterRateParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelMonsterRateParam()
		{
			RoverRogueIns roverRogueIns = this;
			return roverRogueIns.GetLevelMonsterRateParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x00306D00 File Offset: 0x00304F00
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelMonsterRateParamIter()
		{
			RoverRogueIns.<LevelMonsterRateParamIter>d__91 <LevelMonsterRateParamIter>d__ = new RoverRogueIns.<LevelMonsterRateParamIter>d__91(-2);
			<LevelMonsterRateParamIter>d__.<>3__<>4__this = this;
			return <LevelMonsterRateParamIter>d__;
		}

		// Token: 0x0600CE28 RID: 52776 RVA: 0x00306D18 File Offset: 0x00304F18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelRewardRateParamIter()或GetLevelRewardRateParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelRewardRateParam()
		{
			RoverRogueIns roverRogueIns = this;
			return roverRogueIns.GetLevelRewardRateParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CE29 RID: 52777 RVA: 0x00306D3C File Offset: 0x00304F3C
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelRewardRateParamIter()
		{
			RoverRogueIns.<LevelRewardRateParamIter>d__93 <LevelRewardRateParamIter>d__ = new RoverRogueIns.<LevelRewardRateParamIter>d__93(-2);
			<LevelRewardRateParamIter>d__.<>3__<>4__this = this;
			return <LevelRewardRateParamIter>d__;
		}

		// Token: 0x0600CE2A RID: 52778 RVA: 0x00306D54 File Offset: 0x00304F54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelRoomNumParamIter()或GetLevelRoomNumParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelRoomNumParam()
		{
			RoverRogueIns roverRogueIns = this;
			return roverRogueIns.GetLevelRoomNumParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CE2B RID: 52779 RVA: 0x00306D78 File Offset: 0x00304F78
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelRoomNumParamIter()
		{
			RoverRogueIns.<LevelRoomNumParamIter>d__95 <LevelRoomNumParamIter>d__ = new RoverRogueIns.<LevelRoomNumParamIter>d__95(-2);
			<LevelRoomNumParamIter>d__.<>3__<>4__this = this;
			return <LevelRoomNumParamIter>d__;
		}

		// Token: 0x0600CE2C RID: 52780 RVA: 0x00306D90 File Offset: 0x00304F90
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoadTypeListIter()或GetRoadTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoadTypeList()
		{
			RoverRogueIns roverRogueIns = this;
			return roverRogueIns.GetRoadTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CE2D RID: 52781 RVA: 0x00306DB4 File Offset: 0x00304FB4
		[NullableContext(1)]
		public readonly IEnumerable<int> RoadTypeListIter()
		{
			RoverRogueIns.<RoadTypeListIter>d__97 <RoadTypeListIter>d__ = new RoverRogueIns.<RoadTypeListIter>d__97(-2);
			<RoadTypeListIter>d__.<>3__<>4__this = this;
			return <RoadTypeListIter>d__;
		}

		// Token: 0x0600CE2E RID: 52782 RVA: 0x00306DCC File Offset: 0x00304FCC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoverListIter()或GetRoverListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoverList()
		{
			RoverRogueIns roverRogueIns = this;
			return roverRogueIns.GetRoverListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CE2F RID: 52783 RVA: 0x00306DF0 File Offset: 0x00304FF0
		[NullableContext(1)]
		public readonly IEnumerable<int> RoverListIter()
		{
			RoverRogueIns.<RoverListIter>d__99 <RoverListIter>d__ = new RoverRogueIns.<RoverListIter>d__99(-2);
			<RoverListIter>d__.<>3__<>4__this = this;
			return <RoverListIter>d__;
		}

		// Token: 0x04005187 RID: 20871
		private Table __p;
	}
}
