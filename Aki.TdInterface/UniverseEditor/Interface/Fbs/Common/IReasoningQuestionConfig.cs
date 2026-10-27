using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E4B RID: 24139
	public struct IReasoningQuestionConfig : IFlatbufferObject
	{
		// Token: 0x1700B476 RID: 46198
		// (get) Token: 0x06029521 RID: 169249 RVA: 0x005AA428 File Offset: 0x005A8628
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029522 RID: 169250 RVA: 0x005AA435 File Offset: 0x005A8635
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029523 RID: 169251 RVA: 0x005AA43C File Offset: 0x005A863C
		public static IReasoningQuestionConfig GetRootAsIReasoningQuestionConfig(ByteBuffer _bb)
		{
			return IReasoningQuestionConfig.GetRootAsIReasoningQuestionConfig(_bb, default(IReasoningQuestionConfig));
		}

		// Token: 0x06029524 RID: 169252 RVA: 0x005AA458 File Offset: 0x005A8658
		public static IReasoningQuestionConfig GetRootAsIReasoningQuestionConfig(ByteBuffer _bb, IReasoningQuestionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029525 RID: 169253 RVA: 0x005AA475 File Offset: 0x005A8675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029526 RID: 169254 RVA: 0x005AA484 File Offset: 0x005A8684
		public IReasoningQuestionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B477 RID: 46199
		// (get) Token: 0x06029527 RID: 169255 RVA: 0x005AA494 File Offset: 0x005A8694
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

		// Token: 0x06029528 RID: 169256 RVA: 0x005AA4D0 File Offset: 0x005A86D0
		public IReasoningResultConfig? ResultConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IReasoningResultConfig?(default(IReasoningResultConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B478 RID: 46200
		// (get) Token: 0x06029529 RID: 169257 RVA: 0x005AA530 File Offset: 0x005A8730
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

		// Token: 0x0602952A RID: 169258 RVA: 0x005AA55B File Offset: 0x005A875B
		public static Offset<IReasoningQuestionConfig> CreateIReasoningQuestionConfig(FlatBufferBuilder builder, int QuestionId = 0, VectorOffset ResultConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IReasoningQuestionConfig.AddResultConfigs(builder, ResultConfigsOffset);
			IReasoningQuestionConfig.AddQuestionId(builder, QuestionId);
			return IReasoningQuestionConfig.EndIReasoningQuestionConfig(builder);
		}

		// Token: 0x0602952B RID: 169259 RVA: 0x005AA578 File Offset: 0x005A8778
		public static void StartIReasoningQuestionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602952C RID: 169260 RVA: 0x005AA581 File Offset: 0x005A8781
		public static void AddQuestionId(FlatBufferBuilder builder, int questionId)
		{
			builder.AddInt(0, questionId, 0);
		}

		// Token: 0x0602952D RID: 169261 RVA: 0x005AA58C File Offset: 0x005A878C
		public static void AddResultConfigs(FlatBufferBuilder builder, VectorOffset resultConfigsOffset)
		{
			builder.AddOffset(1, resultConfigsOffset.Value, 0);
		}

		// Token: 0x0602952E RID: 169262 RVA: 0x005AA59C File Offset: 0x005A879C
		public static VectorOffset CreateResultConfigsVector(FlatBufferBuilder builder, Offset<IReasoningResultConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602952F RID: 169263 RVA: 0x005AA5DC File Offset: 0x005A87DC
		public static VectorOffset CreateResultConfigsVectorBlock(FlatBufferBuilder builder, Offset<IReasoningResultConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IReasoningResultConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029530 RID: 169264 RVA: 0x005AA5F6 File Offset: 0x005A87F6
		public static VectorOffset CreateResultConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IReasoningResultConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IReasoningResultConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029531 RID: 169265 RVA: 0x005AA614 File Offset: 0x005A8814
		public static VectorOffset CreateResultConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IReasoningResultConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029532 RID: 169266 RVA: 0x005AA62D File Offset: 0x005A882D
		public static void StartResultConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029533 RID: 169267 RVA: 0x005AA638 File Offset: 0x005A8838
		public static Offset<IReasoningQuestionConfig> EndIReasoningQuestionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IReasoningQuestionConfig>(builder.EndTable());
		}

		// Token: 0x06029534 RID: 169268 RVA: 0x005AA648 File Offset: 0x005A8848
		public IReasoningQuestionConfigT UnPack()
		{
			IReasoningQuestionConfigT reasoningQuestionConfigT = new IReasoningQuestionConfigT();
			this.UnPackTo(reasoningQuestionConfigT);
			return reasoningQuestionConfigT;
		}

		// Token: 0x06029535 RID: 169269 RVA: 0x005AA664 File Offset: 0x005A8864
		public void UnPackTo(IReasoningQuestionConfigT _o)
		{
			_o.QuestionId = this.QuestionId;
			_o.ResultConfigs = new List<IReasoningResultConfigT>();
			for (int i = 0; i < this.ResultConfigsLength; i++)
			{
				_o.ResultConfigs.Add((this.ResultConfigs(i) != null) ? this.ResultConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029536 RID: 169270 RVA: 0x005AA6D0 File Offset: 0x005A88D0
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

		// Token: 0x0400F84E RID: 63566
		private Table __p;
	}
}
