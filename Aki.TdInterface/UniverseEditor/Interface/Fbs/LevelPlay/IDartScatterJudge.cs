using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048E4 RID: 18660
	public struct IDartScatterJudge : IFlatbufferObject
	{
		// Token: 0x170081FA RID: 33274
		// (get) Token: 0x0601B9FD RID: 113149 RVA: 0x003E7D69 File Offset: 0x003E5F69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B9FE RID: 113150 RVA: 0x003E7D76 File Offset: 0x003E5F76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B9FF RID: 113151 RVA: 0x003E7D80 File Offset: 0x003E5F80
		public static IDartScatterJudge GetRootAsIDartScatterJudge(ByteBuffer _bb)
		{
			return IDartScatterJudge.GetRootAsIDartScatterJudge(_bb, default(IDartScatterJudge));
		}

		// Token: 0x0601BA00 RID: 113152 RVA: 0x003E7D9C File Offset: 0x003E5F9C
		public static IDartScatterJudge GetRootAsIDartScatterJudge(ByteBuffer _bb, IDartScatterJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BA01 RID: 113153 RVA: 0x003E7DB9 File Offset: 0x003E5FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BA02 RID: 113154 RVA: 0x003E7DC8 File Offset: 0x003E5FC8
		public IDartScatterJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081FB RID: 33275
		// (get) Token: 0x0601BA03 RID: 113155 RVA: 0x003E7DD8 File Offset: 0x003E5FD8
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

		// Token: 0x170081FC RID: 33276
		// (get) Token: 0x0601BA04 RID: 113156 RVA: 0x003E7E14 File Offset: 0x003E6014
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

		// Token: 0x0601BA05 RID: 113157 RVA: 0x003E7E50 File Offset: 0x003E6050
		public static Offset<IDartScatterJudge> CreateIDartScatterJudge(FlatBufferBuilder builder, int Probability = 0, int Range = 0)
		{
			builder.StartTable(2);
			IDartScatterJudge.AddRange(builder, Range);
			IDartScatterJudge.AddProbability(builder, Probability);
			return IDartScatterJudge.EndIDartScatterJudge(builder);
		}

		// Token: 0x0601BA06 RID: 113158 RVA: 0x003E7E6D File Offset: 0x003E606D
		public static void StartIDartScatterJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BA07 RID: 113159 RVA: 0x003E7E76 File Offset: 0x003E6076
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601BA08 RID: 113160 RVA: 0x003E7E81 File Offset: 0x003E6081
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(1, range, 0);
		}

		// Token: 0x0601BA09 RID: 113161 RVA: 0x003E7E8C File Offset: 0x003E608C
		public static Offset<IDartScatterJudge> EndIDartScatterJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartScatterJudge>(builder.EndTable());
		}

		// Token: 0x0601BA0A RID: 113162 RVA: 0x003E7E9C File Offset: 0x003E609C
		public IDartScatterJudgeT UnPack()
		{
			IDartScatterJudgeT dartScatterJudgeT = new IDartScatterJudgeT();
			this.UnPackTo(dartScatterJudgeT);
			return dartScatterJudgeT;
		}

		// Token: 0x0601BA0B RID: 113163 RVA: 0x003E7EB7 File Offset: 0x003E60B7
		public void UnPackTo(IDartScatterJudgeT _o)
		{
			_o.Probability = this.Probability;
			_o.Range = this.Range;
		}

		// Token: 0x0601BA0C RID: 113164 RVA: 0x003E7ED4 File Offset: 0x003E60D4
		public static Offset<IDartScatterJudge> Pack(FlatBufferBuilder builder, IDartScatterJudgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartScatterJudge>);
			}
			return IDartScatterJudge.CreateIDartScatterJudge(builder, _o.Probability, _o.Range);
		}

		// Token: 0x0400CE9F RID: 52895
		private Table __p;
	}
}
