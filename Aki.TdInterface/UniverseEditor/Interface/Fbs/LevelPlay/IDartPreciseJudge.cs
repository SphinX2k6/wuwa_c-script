using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048E1 RID: 18657
	public struct IDartPreciseJudge : IFlatbufferObject
	{
		// Token: 0x170081F7 RID: 33271
		// (get) Token: 0x0601B9EB RID: 113131 RVA: 0x003E7BF2 File Offset: 0x003E5DF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B9EC RID: 113132 RVA: 0x003E7BFF File Offset: 0x003E5DFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B9ED RID: 113133 RVA: 0x003E7C08 File Offset: 0x003E5E08
		public static IDartPreciseJudge GetRootAsIDartPreciseJudge(ByteBuffer _bb)
		{
			return IDartPreciseJudge.GetRootAsIDartPreciseJudge(_bb, default(IDartPreciseJudge));
		}

		// Token: 0x0601B9EE RID: 113134 RVA: 0x003E7C24 File Offset: 0x003E5E24
		public static IDartPreciseJudge GetRootAsIDartPreciseJudge(ByteBuffer _bb, IDartPreciseJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B9EF RID: 113135 RVA: 0x003E7C41 File Offset: 0x003E5E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B9F0 RID: 113136 RVA: 0x003E7C50 File Offset: 0x003E5E50
		public IDartPreciseJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081F8 RID: 33272
		// (get) Token: 0x0601B9F1 RID: 113137 RVA: 0x003E7C60 File Offset: 0x003E5E60
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

		// Token: 0x0601B9F2 RID: 113138 RVA: 0x003E7C9C File Offset: 0x003E5E9C
		public static Offset<IDartPreciseJudge> CreateIDartPreciseJudge(FlatBufferBuilder builder, int Probability = 0)
		{
			builder.StartTable(1);
			IDartPreciseJudge.AddProbability(builder, Probability);
			return IDartPreciseJudge.EndIDartPreciseJudge(builder);
		}

		// Token: 0x0601B9F3 RID: 113139 RVA: 0x003E7CB2 File Offset: 0x003E5EB2
		public static void StartIDartPreciseJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B9F4 RID: 113140 RVA: 0x003E7CBB File Offset: 0x003E5EBB
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601B9F5 RID: 113141 RVA: 0x003E7CC6 File Offset: 0x003E5EC6
		public static Offset<IDartPreciseJudge> EndIDartPreciseJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartPreciseJudge>(builder.EndTable());
		}

		// Token: 0x0601B9F6 RID: 113142 RVA: 0x003E7CD4 File Offset: 0x003E5ED4
		public IDartPreciseJudgeT UnPack()
		{
			IDartPreciseJudgeT dartPreciseJudgeT = new IDartPreciseJudgeT();
			this.UnPackTo(dartPreciseJudgeT);
			return dartPreciseJudgeT;
		}

		// Token: 0x0601B9F7 RID: 113143 RVA: 0x003E7CEF File Offset: 0x003E5EEF
		public void UnPackTo(IDartPreciseJudgeT _o)
		{
			_o.Probability = this.Probability;
		}

		// Token: 0x0601B9F8 RID: 113144 RVA: 0x003E7D00 File Offset: 0x003E5F00
		public static Offset<IDartPreciseJudge> Pack(FlatBufferBuilder builder, IDartPreciseJudgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartPreciseJudge>);
			}
			return IDartPreciseJudge.CreateIDartPreciseJudge(builder, _o.Probability);
		}

		// Token: 0x0400CE9D RID: 52893
		private Table __p;
	}
}
