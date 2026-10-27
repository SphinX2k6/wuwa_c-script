using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004479 RID: 17529
	public struct IDartPreciseJudge : IFlatbufferObject
	{
		// Token: 0x17007BB8 RID: 31672
		// (get) Token: 0x0601A21A RID: 107034 RVA: 0x003BB9E6 File Offset: 0x003B9BE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A21B RID: 107035 RVA: 0x003BB9F3 File Offset: 0x003B9BF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A21C RID: 107036 RVA: 0x003BB9FC File Offset: 0x003B9BFC
		public static IDartPreciseJudge GetRootAsIDartPreciseJudge(ByteBuffer _bb)
		{
			return IDartPreciseJudge.GetRootAsIDartPreciseJudge(_bb, default(IDartPreciseJudge));
		}

		// Token: 0x0601A21D RID: 107037 RVA: 0x003BBA18 File Offset: 0x003B9C18
		public static IDartPreciseJudge GetRootAsIDartPreciseJudge(ByteBuffer _bb, IDartPreciseJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A21E RID: 107038 RVA: 0x003BBA35 File Offset: 0x003B9C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A21F RID: 107039 RVA: 0x003BBA44 File Offset: 0x003B9C44
		public IDartPreciseJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BB9 RID: 31673
		// (get) Token: 0x0601A220 RID: 107040 RVA: 0x003BBA54 File Offset: 0x003B9C54
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

		// Token: 0x0601A221 RID: 107041 RVA: 0x003BBA90 File Offset: 0x003B9C90
		public static Offset<IDartPreciseJudge> CreateIDartPreciseJudge(FlatBufferBuilder builder, int Probability = 0)
		{
			builder.StartTable(1);
			IDartPreciseJudge.AddProbability(builder, Probability);
			return IDartPreciseJudge.EndIDartPreciseJudge(builder);
		}

		// Token: 0x0601A222 RID: 107042 RVA: 0x003BBAA6 File Offset: 0x003B9CA6
		public static void StartIDartPreciseJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A223 RID: 107043 RVA: 0x003BBAAF File Offset: 0x003B9CAF
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601A224 RID: 107044 RVA: 0x003BBABA File Offset: 0x003B9CBA
		public static Offset<IDartPreciseJudge> EndIDartPreciseJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartPreciseJudge>(builder.EndTable());
		}

		// Token: 0x0601A225 RID: 107045 RVA: 0x003BBAC8 File Offset: 0x003B9CC8
		public IDartPreciseJudgeT UnPack()
		{
			IDartPreciseJudgeT dartPreciseJudgeT = new IDartPreciseJudgeT();
			this.UnPackTo(dartPreciseJudgeT);
			return dartPreciseJudgeT;
		}

		// Token: 0x0601A226 RID: 107046 RVA: 0x003BBAE3 File Offset: 0x003B9CE3
		public void UnPackTo(IDartPreciseJudgeT _o)
		{
			_o.Probability = this.Probability;
		}

		// Token: 0x0601A227 RID: 107047 RVA: 0x003BBAF4 File Offset: 0x003B9CF4
		public static Offset<IDartPreciseJudge> Pack(FlatBufferBuilder builder, IDartPreciseJudgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartPreciseJudge>);
			}
			return IDartPreciseJudge.CreateIDartPreciseJudge(builder, _o.Probability);
		}

		// Token: 0x0400C46F RID: 50287
		private Table __p;
	}
}
