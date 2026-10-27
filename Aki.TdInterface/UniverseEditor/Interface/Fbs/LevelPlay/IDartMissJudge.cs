using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004476 RID: 17526
	public struct IDartMissJudge : IFlatbufferObject
	{
		// Token: 0x17007BB3 RID: 31667
		// (get) Token: 0x0601A204 RID: 107012 RVA: 0x003BB7E5 File Offset: 0x003B99E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A205 RID: 107013 RVA: 0x003BB7F2 File Offset: 0x003B99F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A206 RID: 107014 RVA: 0x003BB7FC File Offset: 0x003B99FC
		public static IDartMissJudge GetRootAsIDartMissJudge(ByteBuffer _bb)
		{
			return IDartMissJudge.GetRootAsIDartMissJudge(_bb, default(IDartMissJudge));
		}

		// Token: 0x0601A207 RID: 107015 RVA: 0x003BB818 File Offset: 0x003B9A18
		public static IDartMissJudge GetRootAsIDartMissJudge(ByteBuffer _bb, IDartMissJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A208 RID: 107016 RVA: 0x003BB835 File Offset: 0x003B9A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A209 RID: 107017 RVA: 0x003BB844 File Offset: 0x003B9A44
		public IDartMissJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BB4 RID: 31668
		// (get) Token: 0x0601A20A RID: 107018 RVA: 0x003BB854 File Offset: 0x003B9A54
		public int Probability
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

		// Token: 0x17007BB5 RID: 31669
		// (get) Token: 0x0601A20B RID: 107019 RVA: 0x003BB890 File Offset: 0x003B9A90
		public int Range
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

		// Token: 0x0601A20C RID: 107020 RVA: 0x003BB8CC File Offset: 0x003B9ACC
		public static Offset<IDartMissJudge> CreateIDartMissJudge(FlatBufferBuilder builder, int Probability = 0, int Range = 0)
		{
			builder.StartTable(2);
			IDartMissJudge.AddRange(builder, Range);
			IDartMissJudge.AddProbability(builder, Probability);
			return IDartMissJudge.EndIDartMissJudge(builder);
		}

		// Token: 0x0601A20D RID: 107021 RVA: 0x003BB8E9 File Offset: 0x003B9AE9
		public static void StartIDartMissJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A20E RID: 107022 RVA: 0x003BB8F2 File Offset: 0x003B9AF2
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601A20F RID: 107023 RVA: 0x003BB8FD File Offset: 0x003B9AFD
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(1, range, 0);
		}

		// Token: 0x0601A210 RID: 107024 RVA: 0x003BB908 File Offset: 0x003B9B08
		public static Offset<IDartMissJudge> EndIDartMissJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartMissJudge>(builder.EndTable());
		}

		// Token: 0x0601A211 RID: 107025 RVA: 0x003BB918 File Offset: 0x003B9B18
		public IDartMissJudgeT UnPack()
		{
			IDartMissJudgeT dartMissJudgeT = new IDartMissJudgeT();
			this.UnPackTo(dartMissJudgeT);
			return dartMissJudgeT;
		}

		// Token: 0x0601A212 RID: 107026 RVA: 0x003BB933 File Offset: 0x003B9B33
		public void UnPackTo(IDartMissJudgeT _o)
		{
			_o.Probability = this.Probability;
			_o.Range = this.Range;
		}

		// Token: 0x0601A213 RID: 107027 RVA: 0x003BB950 File Offset: 0x003B9B50
		public static Offset<IDartMissJudge> Pack(FlatBufferBuilder builder, IDartMissJudgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartMissJudge>);
			}
			return IDartMissJudge.CreateIDartMissJudge(builder, _o.Probability, _o.Range);
		}

		// Token: 0x0400C46C RID: 50284
		private Table __p;
	}
}
