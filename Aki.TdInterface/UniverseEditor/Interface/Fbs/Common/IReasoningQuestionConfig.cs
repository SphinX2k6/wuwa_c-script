using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200648B RID: 25739
	public struct IReasoningQuestionConfig : IFlatbufferObject
	{
		// Token: 0x1700BDDF RID: 48607
		// (get) Token: 0x0602BBBD RID: 179133 RVA: 0x005F32D0 File Offset: 0x005F14D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BBBE RID: 179134 RVA: 0x005F32DD File Offset: 0x005F14DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BBBF RID: 179135 RVA: 0x005F32E4 File Offset: 0x005F14E4
		public static IReasoningQuestionConfig GetRootAsIReasoningQuestionConfig(ByteBuffer _bb)
		{
			return IReasoningQuestionConfig.GetRootAsIReasoningQuestionConfig(_bb, default(IReasoningQuestionConfig));
		}

		// Token: 0x0602BBC0 RID: 179136 RVA: 0x005F3300 File Offset: 0x005F1500
		public static IReasoningQuestionConfig GetRootAsIReasoningQuestionConfig(ByteBuffer _bb, IReasoningQuestionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BBC1 RID: 179137 RVA: 0x005F331D File Offset: 0x005F151D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BBC2 RID: 179138 RVA: 0x005F332C File Offset: 0x005F152C
		public IReasoningQuestionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDE0 RID: 48608
		// (get) Token: 0x0602BBC3 RID: 179139 RVA: 0x005F333C File Offset: 0x005F153C
		public int QuestionId
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

		// Token: 0x0602BBC4 RID: 179140 RVA: 0x005F3378 File Offset: 0x005F1578
		public IReasoningResultConfig? ResultConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IReasoningResultConfig?(default(IReasoningResultConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BDE1 RID: 48609
		// (get) Token: 0x0602BBC5 RID: 179141 RVA: 0x005F33D8 File Offset: 0x005F15D8
		public int ResultConfigsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602BBC6 RID: 179142 RVA: 0x005F3403 File Offset: 0x005F1603
		public static Offset<IReasoningQuestionConfig> CreateIReasoningQuestionConfig(FlatBufferBuilder builder, int QuestionId = 0, VectorOffset ResultConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IReasoningQuestionConfig.AddResultConfigs(builder, ResultConfigsOffset);
			IReasoningQuestionConfig.AddQuestionId(builder, QuestionId);
			return IReasoningQuestionConfig.EndIReasoningQuestionConfig(builder);
		}

		// Token: 0x0602BBC7 RID: 179143 RVA: 0x005F3420 File Offset: 0x005F1620
		public static void StartIReasoningQuestionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BBC8 RID: 179144 RVA: 0x005F3429 File Offset: 0x005F1629
		public static void AddQuestionId(FlatBufferBuilder builder, int questionId)
		{
			builder.AddInt(0, questionId, 0);
		}

		// Token: 0x0602BBC9 RID: 179145 RVA: 0x005F3434 File Offset: 0x005F1634
		public static void AddResultConfigs(FlatBufferBuilder builder, VectorOffset resultConfigsOffset)
		{
			builder.AddOffset(1, resultConfigsOffset.Value, 0);
		}

		// Token: 0x0602BBCA RID: 179146 RVA: 0x005F3444 File Offset: 0x005F1644
		public static VectorOffset CreateResultConfigsVector(FlatBufferBuilder builder, Offset<IReasoningResultConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BBCB RID: 179147 RVA: 0x005F3484 File Offset: 0x005F1684
		public static VectorOffset CreateResultConfigsVectorBlock(FlatBufferBuilder builder, Offset<IReasoningResultConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IReasoningResultConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBCC RID: 179148 RVA: 0x005F349E File Offset: 0x005F169E
		public static VectorOffset CreateResultConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IReasoningResultConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IReasoningResultConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBCD RID: 179149 RVA: 0x005F34BC File Offset: 0x005F16BC
		public static VectorOffset CreateResultConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IReasoningResultConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BBCE RID: 179150 RVA: 0x005F34D5 File Offset: 0x005F16D5
		public static void StartResultConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BBCF RID: 179151 RVA: 0x005F34E0 File Offset: 0x005F16E0
		public static Offset<IReasoningQuestionConfig> EndIReasoningQuestionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IReasoningQuestionConfig>(builder.EndTable());
		}

		// Token: 0x0602BBD0 RID: 179152 RVA: 0x005F34F0 File Offset: 0x005F16F0
		public IReasoningQuestionConfigT UnPack()
		{
			IReasoningQuestionConfigT reasoningQuestionConfigT = new IReasoningQuestionConfigT();
			this.UnPackTo(reasoningQuestionConfigT);
			return reasoningQuestionConfigT;
		}

		// Token: 0x0602BBD1 RID: 179153 RVA: 0x005F350C File Offset: 0x005F170C
		public void UnPackTo(IReasoningQuestionConfigT _o)
		{
			_o.QuestionId = this.QuestionId;
			_o.ResultConfigs = new List<IReasoningResultConfigT>();
			for (int i = 0; i < this.ResultConfigsLength; i++)
			{
				_o.ResultConfigs.Add((this.ResultConfigs(i) != null) ? this.ResultConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602BBD2 RID: 179154 RVA: 0x005F3578 File Offset: 0x005F1778
		public static Offset<IReasoningQuestionConfig> Pack(FlatBufferBuilder builder, IReasoningQuestionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReasoningQuestionConfig>);
			}
			VectorOffset resultConfigsOffset = default(VectorOffset);
			if (_o.ResultConfigs != null)
			{
				Offset<IReasoningResultConfig>[] array = new Offset<IReasoningResultConfig>[_o.ResultConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IReasoningResultConfig.Pack(builder, _o.ResultConfigs[i]);
				}
				resultConfigsOffset = IReasoningQuestionConfig.CreateResultConfigsVector(builder, array);
			}
			return IReasoningQuestionConfig.CreateIReasoningQuestionConfig(builder, _o.QuestionId, resultConfigsOffset);
		}

		// Token: 0x040105AB RID: 66987
		private Table __p;
	}
}
