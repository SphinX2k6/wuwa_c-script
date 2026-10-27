using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200447C RID: 17532
	public struct IDartScatterJudge : IFlatbufferObject
	{
		// Token: 0x17007BBB RID: 31675
		// (get) Token: 0x0601A22C RID: 107052 RVA: 0x003BBB5D File Offset: 0x003B9D5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A22D RID: 107053 RVA: 0x003BBB6A File Offset: 0x003B9D6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A22E RID: 107054 RVA: 0x003BBB74 File Offset: 0x003B9D74
		public static IDartScatterJudge GetRootAsIDartScatterJudge(ByteBuffer _bb)
		{
			return IDartScatterJudge.GetRootAsIDartScatterJudge(_bb, default(IDartScatterJudge));
		}

		// Token: 0x0601A22F RID: 107055 RVA: 0x003BBB90 File Offset: 0x003B9D90
		public static IDartScatterJudge GetRootAsIDartScatterJudge(ByteBuffer _bb, IDartScatterJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A230 RID: 107056 RVA: 0x003BBBAD File Offset: 0x003B9DAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A231 RID: 107057 RVA: 0x003BBBBC File Offset: 0x003B9DBC
		public IDartScatterJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BBC RID: 31676
		// (get) Token: 0x0601A232 RID: 107058 RVA: 0x003BBBCC File Offset: 0x003B9DCC
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

		// Token: 0x17007BBD RID: 31677
		// (get) Token: 0x0601A233 RID: 107059 RVA: 0x003BBC08 File Offset: 0x003B9E08
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

		// Token: 0x0601A234 RID: 107060 RVA: 0x003BBC44 File Offset: 0x003B9E44
		public static Offset<IDartScatterJudge> CreateIDartScatterJudge(FlatBufferBuilder builder, int Probability = 0, int Range = 0)
		{
			builder.StartTable(2);
			IDartScatterJudge.AddRange(builder, Range);
			IDartScatterJudge.AddProbability(builder, Probability);
			return IDartScatterJudge.EndIDartScatterJudge(builder);
		}

		// Token: 0x0601A235 RID: 107061 RVA: 0x003BBC61 File Offset: 0x003B9E61
		public static void StartIDartScatterJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A236 RID: 107062 RVA: 0x003BBC6A File Offset: 0x003B9E6A
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601A237 RID: 107063 RVA: 0x003BBC75 File Offset: 0x003B9E75
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(1, range, 0);
		}

		// Token: 0x0601A238 RID: 107064 RVA: 0x003BBC80 File Offset: 0x003B9E80
		public static Offset<IDartScatterJudge> EndIDartScatterJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartScatterJudge>(builder.EndTable());
		}

		// Token: 0x0601A239 RID: 107065 RVA: 0x003BBC90 File Offset: 0x003B9E90
		public IDartScatterJudgeT UnPack()
		{
			IDartScatterJudgeT dartScatterJudgeT = new IDartScatterJudgeT();
			this.UnPackTo(dartScatterJudgeT);
			return dartScatterJudgeT;
		}

		// Token: 0x0601A23A RID: 107066 RVA: 0x003BBCAB File Offset: 0x003B9EAB
		public void UnPackTo(IDartScatterJudgeT _o)
		{
			_o.Probability = this.Probability;
			_o.Range = this.Range;
		}

		// Token: 0x0601A23B RID: 107067 RVA: 0x003BBCC8 File Offset: 0x003B9EC8
		public static Offset<IDartScatterJudge> Pack(FlatBufferBuilder builder, IDartScatterJudgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartScatterJudge>);
			}
			return IDartScatterJudge.CreateIDartScatterJudge(builder, _o.Probability, _o.Range);
		}

		// Token: 0x0400C471 RID: 50289
		private Table __p;
	}
}
