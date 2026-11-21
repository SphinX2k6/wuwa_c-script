using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D73 RID: 3443
	public struct FlagArea : IFlatbufferObject
	{
		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060076DD RID: 30429 RVA: 0x00253D2E File Offset: 0x00251F2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x00253D3B File Offset: 0x00251F3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x00253D44 File Offset: 0x00251F44
		public static FlagArea GetRootAsFlagArea(ByteBuffer _bb)
		{
			return FlagArea.GetRootAsFlagArea(_bb, default(FlagArea));
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x00253D60 File Offset: 0x00251F60
		public static FlagArea GetRootAsFlagArea(ByteBuffer _bb, FlagArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x00253D7D File Offset: 0x00251F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x00253D8C File Offset: 0x00251F8C
		public FlagArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x00253D9C File Offset: 0x00251F9C
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

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x060076E4 RID: 30436 RVA: 0x00253DD8 File Offset: 0x00251FD8
		public int FlagEntityId
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

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x060076E5 RID: 30437 RVA: 0x00253E14 File Offset: 0x00252014
		public int FlagAreaId
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

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060076E6 RID: 30438 RVA: 0x00253E50 File Offset: 0x00252050
		public int MapId
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

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x060076E7 RID: 30439 RVA: 0x00253E90 File Offset: 0x00252090
		public int FlagType
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

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x00253ED0 File Offset: 0x002520D0
		public int MarkId
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

		// Token: 0x060076E9 RID: 30441 RVA: 0x00253F10 File Offset: 0x00252110
		public int TreasureBoxEntitys(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x060076EA RID: 30442 RVA: 0x00253F50 File Offset: 0x00252150
		public int TreasureBoxEntitysLength
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

		// Token: 0x060076EB RID: 30443 RVA: 0x00253F7C File Offset: 0x0025217C
		public Span<int> GetTreasureBoxEntitysBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00253F8C File Offset: 0x0025218C
		public int[] GetTreasureBoxEntitysArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x00253FA4 File Offset: 0x002521A4
		public string FlagName
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

		// Token: 0x060076EE RID: 30446 RVA: 0x00253FDC File Offset: 0x002521DC
		public Span<byte> GetFlagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00253FEC File Offset: 0x002521EC
		public byte[] GetFlagNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00254004 File Offset: 0x00252204
		public int FlagPlotList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x00254044 File Offset: 0x00252244
		public int FlagPlotListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x00254070 File Offset: 0x00252270
		public Span<int> GetFlagPlotListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x00254080 File Offset: 0x00252280
		public int[] GetFlagPlotListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x060076F4 RID: 30452 RVA: 0x00254098 File Offset: 0x00252298
		public int FlagPosPlotId
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

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x002540D8 File Offset: 0x002522D8
		public int MaxMonsterLv
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

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x060076F6 RID: 30454 RVA: 0x00254118 File Offset: 0x00252318
		public string MonsterIconPath
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

		// Token: 0x060076F7 RID: 30455 RVA: 0x00254150 File Offset: 0x00252350
		public Span<byte> GetMonsterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00254160 File Offset: 0x00252360
		public byte[] GetMonsterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x060076F9 RID: 30457 RVA: 0x00254178 File Offset: 0x00252378
		public string MonsterDesc
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

		// Token: 0x060076FA RID: 30458 RVA: 0x002541B0 File Offset: 0x002523B0
		public Span<byte> GetMonsterDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x002541C0 File Offset: 0x002523C0
		public byte[] GetMonsterDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x060076FC RID: 30460 RVA: 0x002541D8 File Offset: 0x002523D8
		public int BoxRewardId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x060076FD RID: 30461 RVA: 0x00254218 File Offset: 0x00252418
		public string Index
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

		// Token: 0x060076FE RID: 30462 RVA: 0x00254250 File Offset: 0x00252450
		public Span<byte> GetIndexBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x00254260 File Offset: 0x00252460
		public byte[] GetIndexArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00254278 File Offset: 0x00252478
		[NullableContext(1)]
		public int[] FlagPlotList()
		{
			return this.GetFlagPlotListArray();
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00254280 File Offset: 0x00252480
		[NullableContext(1)]
		public IEnumerable<int> FlagPlotListIter()
		{
			FlagArea.<FlagPlotListIter>d__53 <FlagPlotListIter>d__ = new FlagArea.<FlagPlotListIter>d__53(-2);
			<FlagPlotListIter>d__.<>3__<>4__this = this;
			return <FlagPlotListIter>d__;
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00254295 File Offset: 0x00252495
		[NullableContext(1)]
		public int[] TreasureBoxEntitys()
		{
			return this.GetTreasureBoxEntitysArray();
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x0025429D File Offset: 0x0025249D
		[NullableContext(1)]
		public IEnumerable<int> TreasureBoxEntitysIter()
		{
			FlagArea.<TreasureBoxEntitysIter>d__55 <TreasureBoxEntitysIter>d__ = new FlagArea.<TreasureBoxEntitysIter>d__55(-2);
			<TreasureBoxEntitysIter>d__.<>3__<>4__this = this;
			return <TreasureBoxEntitysIter>d__;
		}

		// Token: 0x040052CA RID: 21194
		private Table __p;
	}
}
