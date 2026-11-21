using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005079 RID: 20601
	public struct ICompareDiceGameRankLevel : IFlatbufferObject
	{
		// Token: 0x17009371 RID: 37745
		// (get) Token: 0x06020370 RID: 131952 RVA: 0x004772BA File Offset: 0x004754BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020371 RID: 131953 RVA: 0x004772C7 File Offset: 0x004754C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020372 RID: 131954 RVA: 0x004772D0 File Offset: 0x004754D0
		public static ICompareDiceGameRankLevel GetRootAsICompareDiceGameRankLevel(ByteBuffer _bb)
		{
			return ICompareDiceGameRankLevel.GetRootAsICompareDiceGameRankLevel(_bb, default(ICompareDiceGameRankLevel));
		}

		// Token: 0x06020373 RID: 131955 RVA: 0x004772EC File Offset: 0x004754EC
		public static ICompareDiceGameRankLevel GetRootAsICompareDiceGameRankLevel(ByteBuffer _bb, ICompareDiceGameRankLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020374 RID: 131956 RVA: 0x00477309 File Offset: 0x00475509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020375 RID: 131957 RVA: 0x00477318 File Offset: 0x00475518
		public ICompareDiceGameRankLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009372 RID: 37746
		// (get) Token: 0x06020376 RID: 131958 RVA: 0x00477328 File Offset: 0x00475528
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009373 RID: 37747
		// (get) Token: 0x06020377 RID: 131959 RVA: 0x00477364 File Offset: 0x00475564
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

		// Token: 0x17009374 RID: 37748
		// (get) Token: 0x06020378 RID: 131960 RVA: 0x004773A0 File Offset: 0x004755A0
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009375 RID: 37749
		// (get) Token: 0x06020379 RID: 131961 RVA: 0x004773DC File Offset: 0x004755DC
		public int Rank
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

		// Token: 0x0602037A RID: 131962 RVA: 0x00477419 File Offset: 0x00475619
		public static Offset<ICompareDiceGameRankLevel> CreateICompareDiceGameRankLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ActivityId = 0, ECompare Compare = ECompare.Eq, int Rank = 0)
		{
			builder.StartTable(4);
			ICompareDiceGameRankLevel.AddRank(builder, Rank);
			ICompareDiceGameRankLevel.AddActivityId(builder, ActivityId);
			ICompareDiceGameRankLevel.AddCompare(builder, Compare);
			ICompareDiceGameRankLevel.AddType(builder, Type);
			return ICompareDiceGameRankLevel.EndICompareDiceGameRankLevel(builder);
		}

		// Token: 0x0602037B RID: 131963 RVA: 0x00477445 File Offset: 0x00475645
		public static void StartICompareDiceGameRankLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602037C RID: 131964 RVA: 0x0047744E File Offset: 0x0047564E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602037D RID: 131965 RVA: 0x00477459 File Offset: 0x00475659
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(1, activityId, 0);
		}

		// Token: 0x0602037E RID: 131966 RVA: 0x00477464 File Offset: 0x00475664
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0602037F RID: 131967 RVA: 0x0047746F File Offset: 0x0047566F
		public static void AddRank(FlatBufferBuilder builder, int rank)
		{
			builder.AddInt(3, rank, 0);
		}

		// Token: 0x06020380 RID: 131968 RVA: 0x0047747A File Offset: 0x0047567A
		public static Offset<ICompareDiceGameRankLevel> EndICompareDiceGameRankLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICompareDiceGameRankLevel>(builder.EndTable());
		}

		// Token: 0x06020381 RID: 131969 RVA: 0x00477488 File Offset: 0x00475688
		public ICompareDiceGameRankLevelT UnPack()
		{
			ICompareDiceGameRankLevelT compareDiceGameRankLevelT = new ICompareDiceGameRankLevelT();
			this.UnPackTo(compareDiceGameRankLevelT);
			return compareDiceGameRankLevelT;
		}

		// Token: 0x06020382 RID: 131970 RVA: 0x004774A3 File Offset: 0x004756A3
		public void UnPackTo(ICompareDiceGameRankLevelT _o)
		{
			_o.Type = this.Type;
			_o.ActivityId = this.ActivityId;
			_o.Compare = this.Compare;
			_o.Rank = this.Rank;
		}

		// Token: 0x06020383 RID: 131971 RVA: 0x004774D8 File Offset: 0x004756D8
		public static Offset<ICompareDiceGameRankLevel> Pack(FlatBufferBuilder builder, ICompareDiceGameRankLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareDiceGameRankLevel>);
			}
			return ICompareDiceGameRankLevel.CreateICompareDiceGameRankLevel(builder, _o.Type, _o.ActivityId, _o.Compare, _o.Rank);
		}

		// Token: 0x0400DF69 RID: 57193
		private Table __p;
	}
}
