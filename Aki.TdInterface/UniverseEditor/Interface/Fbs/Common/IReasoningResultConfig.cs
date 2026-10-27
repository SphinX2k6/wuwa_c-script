using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E4E RID: 24142
	public struct IReasoningResultConfig : IFlatbufferObject
	{
		// Token: 0x1700B47B RID: 46203
		// (get) Token: 0x0602953D RID: 169277 RVA: 0x005AA7D4 File Offset: 0x005A89D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602953E RID: 169278 RVA: 0x005AA7E1 File Offset: 0x005A89E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602953F RID: 169279 RVA: 0x005AA7E8 File Offset: 0x005A89E8
		public static IReasoningResultConfig GetRootAsIReasoningResultConfig(ByteBuffer _bb)
		{
			return IReasoningResultConfig.GetRootAsIReasoningResultConfig(_bb, default(IReasoningResultConfig));
		}

		// Token: 0x06029540 RID: 169280 RVA: 0x005AA804 File Offset: 0x005A8A04
		public static IReasoningResultConfig GetRootAsIReasoningResultConfig(ByteBuffer _bb, IReasoningResultConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029541 RID: 169281 RVA: 0x005AA821 File Offset: 0x005A8A21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029542 RID: 169282 RVA: 0x005AA830 File Offset: 0x005A8A30
		public IReasoningResultConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029543 RID: 169283 RVA: 0x005AA840 File Offset: 0x005A8A40
		public int ClueCombination(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B47C RID: 46204
		// (get) Token: 0x06029544 RID: 169284 RVA: 0x005AA880 File Offset: 0x005A8A80
		public int ClueCombinationLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029545 RID: 169285 RVA: 0x005AA8AB File Offset: 0x005A8AAB
		public Span<int> GetClueCombinationBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06029546 RID: 169286 RVA: 0x005AA8BA File Offset: 0x005A8ABA
		public int[] GetClueCombinationArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06029547 RID: 169287 RVA: 0x005AA8C8 File Offset: 0x005A8AC8
		public string ReasoningStateId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B47D RID: 46205
		// (get) Token: 0x06029548 RID: 169288 RVA: 0x005AA904 File Offset: 0x005A8B04
		public int ReasoningStateIdLength
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

		// Token: 0x06029549 RID: 169289 RVA: 0x005AA930 File Offset: 0x005A8B30
		public string ResultDesc(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B47E RID: 46206
		// (get) Token: 0x0602954A RID: 169290 RVA: 0x005AA96C File Offset: 0x005A8B6C
		public int ResultDescLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B47F RID: 46207
		// (get) Token: 0x0602954B RID: 169291 RVA: 0x005AA998 File Offset: 0x005A8B98
		public int NextQuestionId
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

		// Token: 0x1700B480 RID: 46208
		// (get) Token: 0x0602954C RID: 169292 RVA: 0x005AA9D8 File Offset: 0x005A8BD8
		public int CaseProgressId
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

		// Token: 0x1700B481 RID: 46209
		// (get) Token: 0x0602954D RID: 169293 RVA: 0x005AAA18 File Offset: 0x005A8C18
		public int EndingId
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

		// Token: 0x1700B482 RID: 46210
		// (get) Token: 0x0602954E RID: 169294 RVA: 0x005AAA58 File Offset: 0x005A8C58
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602954F RID: 169295 RVA: 0x005AAA98 File Offset: 0x005A8C98
		public static Offset<IReasoningResultConfig> CreateIReasoningResultConfig(FlatBufferBuilder builder, VectorOffset ClueCombinationOffset = default(VectorOffset), VectorOffset ReasoningStateIdOffset = default(VectorOffset), VectorOffset ResultDescOffset = default(VectorOffset), int NextQuestionId = 0, int CaseProgressId = 0, int EndingId = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IReasoningResultConfig.AddEndingId(builder, EndingId);
			IReasoningResultConfig.AddCaseProgressId(builder, CaseProgressId);
			IReasoningResultConfig.AddNextQuestionId(builder, NextQuestionId);
			IReasoningResultConfig.AddResultDesc(builder, ResultDescOffset);
			IReasoningResultConfig.AddReasoningStateId(builder, ReasoningStateIdOffset);
			IReasoningResultConfig.AddClueCombination(builder, ClueCombinationOffset);
			IReasoningResultConfig.AddNullMask(builder, NullMask);
			return IReasoningResultConfig.EndIReasoningResultConfig(builder);
		}

		// Token: 0x06029550 RID: 169296 RVA: 0x005AAAE7 File Offset: 0x005A8CE7
		public static void StartIReasoningResultConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06029551 RID: 169297 RVA: 0x005AAAF0 File Offset: 0x005A8CF0
		public static void AddClueCombination(FlatBufferBuilder builder, VectorOffset clueCombinationOffset)
		{
			builder.AddOffset(0, clueCombinationOffset.Value, 0);
		}

		// Token: 0x06029552 RID: 169298 RVA: 0x005AAB00 File Offset: 0x005A8D00
		public static VectorOffset CreateClueCombinationVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029553 RID: 169299 RVA: 0x005AAB37 File Offset: 0x005A8D37
		public static VectorOffset CreateClueCombinationVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029554 RID: 169300 RVA: 0x005AAB51 File Offset: 0x005A8D51
		public static VectorOffset CreateClueCombinationVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029555 RID: 169301 RVA: 0x005AAB6F File Offset: 0x005A8D6F
		public static VectorOffset CreateClueCombinationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029556 RID: 169302 RVA: 0x005AAB88 File Offset: 0x005A8D88
		public static void StartClueCombinationVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029557 RID: 169303 RVA: 0x005AAB93 File Offset: 0x005A8D93
		public static void AddReasoningStateId(FlatBufferBuilder builder, VectorOffset reasoningStateIdOffset)
		{
			builder.AddOffset(1, reasoningStateIdOffset.Value, 0);
		}

		// Token: 0x06029558 RID: 169304 RVA: 0x005AABA4 File Offset: 0x005A8DA4
		public static VectorOffset CreateReasoningStateIdVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029559 RID: 169305 RVA: 0x005AABE4 File Offset: 0x005A8DE4
		public static VectorOffset CreateReasoningStateIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602955A RID: 169306 RVA: 0x005AABFE File Offset: 0x005A8DFE
		public static VectorOffset CreateReasoningStateIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602955B RID: 169307 RVA: 0x005AAC1C File Offset: 0x005A8E1C
		public static VectorOffset CreateReasoningStateIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602955C RID: 169308 RVA: 0x005AAC35 File Offset: 0x005A8E35
		public static void StartReasoningStateIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602955D RID: 169309 RVA: 0x005AAC40 File Offset: 0x005A8E40
		public static void AddResultDesc(FlatBufferBuilder builder, VectorOffset resultDescOffset)
		{
			builder.AddOffset(2, resultDescOffset.Value, 0);
		}

		// Token: 0x0602955E RID: 169310 RVA: 0x005AAC50 File Offset: 0x005A8E50
		public static VectorOffset CreateResultDescVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602955F RID: 169311 RVA: 0x005AAC90 File Offset: 0x005A8E90
		public static VectorOffset CreateResultDescVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06029560 RID: 169312 RVA: 0x005AACAA File Offset: 0x005A8EAA
		public static VectorOffset CreateResultDescVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06029561 RID: 169313 RVA: 0x005AACC8 File Offset: 0x005A8EC8
		public static VectorOffset CreateResultDescVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029562 RID: 169314 RVA: 0x005AACE1 File Offset: 0x005A8EE1
		public static void StartResultDescVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029563 RID: 169315 RVA: 0x005AACEC File Offset: 0x005A8EEC
		public static void AddNextQuestionId(FlatBufferBuilder builder, int nextQuestionId)
		{
			builder.AddInt(3, nextQuestionId, 0);
		}

		// Token: 0x06029564 RID: 169316 RVA: 0x005AACF7 File Offset: 0x005A8EF7
		public static void AddCaseProgressId(FlatBufferBuilder builder, int caseProgressId)
		{
			builder.AddInt(4, caseProgressId, 0);
		}

		// Token: 0x06029565 RID: 169317 RVA: 0x005AAD02 File Offset: 0x005A8F02
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(5, endingId, 0);
		}

		// Token: 0x06029566 RID: 169318 RVA: 0x005AAD0D File Offset: 0x005A8F0D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06029567 RID: 169319 RVA: 0x005AAD18 File Offset: 0x005A8F18
		public static Offset<IReasoningResultConfig> EndIReasoningResultConfig(FlatBufferBuilder builder)
		{
			return new Offset<IReasoningResultConfig>(builder.EndTable());
		}

		// Token: 0x06029568 RID: 169320 RVA: 0x005AAD28 File Offset: 0x005A8F28
		public IReasoningResultConfigT UnPack()
		{
			IReasoningResultConfigT reasoningResultConfigT = new IReasoningResultConfigT();
			this.UnPackTo(reasoningResultConfigT);
			return reasoningResultConfigT;
		}

		// Token: 0x06029569 RID: 169321 RVA: 0x005AAD44 File Offset: 0x005A8F44
		public void UnPackTo(IReasoningResultConfigT _o)
		{
			_o.ClueCombination = new List<int>();
			for (int i = 0; i < this.ClueCombinationLength; i++)
			{
				_o.ClueCombination.Add(this.ClueCombination(i));
			}
			_o.ReasoningStateId = new List<string>();
			for (int j = 0; j < this.ReasoningStateIdLength; j++)
			{
				_o.ReasoningStateId.Add(this.ReasoningStateId(j));
			}
			_o.ResultDesc = new List<string>();
			for (int k = 0; k < this.ResultDescLength; k++)
			{
				_o.ResultDesc.Add(this.ResultDesc(k));
			}
			_o.NextQuestionId = this.NextQuestionId;
			_o.CaseProgressId = this.CaseProgressId;
			_o.EndingId = this.EndingId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602956A RID: 169322 RVA: 0x005AAE0C File Offset: 0x005A900C
		public static Offset<IReasoningResultConfig> Pack(FlatBufferBuilder builder, IReasoningResultConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReasoningResultConfig>);
			}
			VectorOffset clueCombinationOffset = default(VectorOffset);
			if (_o.ClueCombination != null)
			{
				int[] data = _o.ClueCombination.ToArray();
				clueCombinationOffset = IReasoningResultConfig.CreateClueCombinationVector(builder, data);
			}
			VectorOffset reasoningStateIdOffset = default(VectorOffset);
			if (_o.ReasoningStateId != null)
			{
				StringOffset[] array = new StringOffset[_o.ReasoningStateId.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.ReasoningStateId[i]);
				}
				reasoningStateIdOffset = IReasoningResultConfig.CreateReasoningStateIdVector(builder, array);
			}
			VectorOffset resultDescOffset = default(VectorOffset);
			if (_o.ResultDesc != null)
			{
				StringOffset[] array2 = new StringOffset[_o.ResultDesc.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.ResultDesc[j]);
				}
				resultDescOffset = IReasoningResultConfig.CreateResultDescVector(builder, array2);
			}
			return IReasoningResultConfig.CreateIReasoningResultConfig(builder, clueCombinationOffset, reasoningStateIdOffset, resultDescOffset, _o.NextQuestionId, _o.CaseProgressId, _o.EndingId, _o.NullMask);
		}

		// Token: 0x0400F851 RID: 63569
		private Table __p;
	}
}
