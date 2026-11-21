using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048DE RID: 18654
	public struct IDartMissJudge : IFlatbufferObject
	{
		// Token: 0x170081F2 RID: 33266
		// (get) Token: 0x0601B9D5 RID: 113109 RVA: 0x003E79F1 File Offset: 0x003E5BF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B9D6 RID: 113110 RVA: 0x003E79FE File Offset: 0x003E5BFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B9D7 RID: 113111 RVA: 0x003E7A08 File Offset: 0x003E5C08
		public static IDartMissJudge GetRootAsIDartMissJudge(ByteBuffer _bb)
		{
			return IDartMissJudge.GetRootAsIDartMissJudge(_bb, default(IDartMissJudge));
		}

		// Token: 0x0601B9D8 RID: 113112 RVA: 0x003E7A24 File Offset: 0x003E5C24
		public static IDartMissJudge GetRootAsIDartMissJudge(ByteBuffer _bb, IDartMissJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B9D9 RID: 113113 RVA: 0x003E7A41 File Offset: 0x003E5C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B9DA RID: 113114 RVA: 0x003E7A50 File Offset: 0x003E5C50
		public IDartMissJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081F3 RID: 33267
		// (get) Token: 0x0601B9DB RID: 113115 RVA: 0x003E7A60 File Offset: 0x003E5C60
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

		// Token: 0x170081F4 RID: 33268
		// (get) Token: 0x0601B9DC RID: 113116 RVA: 0x003E7A9C File Offset: 0x003E5C9C
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

		// Token: 0x0601B9DD RID: 113117 RVA: 0x003E7AD8 File Offset: 0x003E5CD8
		public static Offset<IDartMissJudge> CreateIDartMissJudge(FlatBufferBuilder builder, int Probability = 0, int Range = 0)
		{
			builder.StartTable(2);
			IDartMissJudge.AddRange(builder, Range);
			IDartMissJudge.AddProbability(builder, Probability);
			return IDartMissJudge.EndIDartMissJudge(builder);
		}

		// Token: 0x0601B9DE RID: 113118 RVA: 0x003E7AF5 File Offset: 0x003E5CF5
		public static void StartIDartMissJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B9DF RID: 113119 RVA: 0x003E7AFE File Offset: 0x003E5CFE
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601B9E0 RID: 113120 RVA: 0x003E7B09 File Offset: 0x003E5D09
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(1, range, 0);
		}

		// Token: 0x0601B9E1 RID: 113121 RVA: 0x003E7B14 File Offset: 0x003E5D14
		public static Offset<IDartMissJudge> EndIDartMissJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartMissJudge>(builder.EndTable());
		}

		// Token: 0x0601B9E2 RID: 113122 RVA: 0x003E7B24 File Offset: 0x003E5D24
		public IDartMissJudgeT UnPack()
		{
			IDartMissJudgeT dartMissJudgeT = new IDartMissJudgeT();
			this.UnPackTo(dartMissJudgeT);
			return dartMissJudgeT;
		}

		// Token: 0x0601B9E3 RID: 113123 RVA: 0x003E7B3F File Offset: 0x003E5D3F
		public void UnPackTo(IDartMissJudgeT _o)
		{
			_o.Probability = this.Probability;
			_o.Range = this.Range;
		}

		// Token: 0x0601B9E4 RID: 113124 RVA: 0x003E7B5C File Offset: 0x003E5D5C
		public static Offset<IDartMissJudge> Pack(FlatBufferBuilder builder, IDartMissJudgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartMissJudge>);
			}
			return IDartMissJudge.CreateIDartMissJudge(builder, _o.Probability, _o.Range);
		}

		// Token: 0x0400CE9A RID: 52890
		private Table __p;
	}
}
