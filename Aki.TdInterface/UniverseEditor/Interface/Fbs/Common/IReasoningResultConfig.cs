using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200648E RID: 25742
	public struct IReasoningResultConfig : IFlatbufferObject
	{
		// Token: 0x1700BDE4 RID: 48612
		// (get) Token: 0x0602BBD9 RID: 179161 RVA: 0x005F367C File Offset: 0x005F187C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BBDA RID: 179162 RVA: 0x005F3689 File Offset: 0x005F1889
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BBDB RID: 179163 RVA: 0x005F3690 File Offset: 0x005F1890
		public static IReasoningResultConfig GetRootAsIReasoningResultConfig(ByteBuffer _bb)
		{
			return IReasoningResultConfig.GetRootAsIReasoningResultConfig(_bb, default(IReasoningResultConfig));
		}

		// Token: 0x0602BBDC RID: 179164 RVA: 0x005F36AC File Offset: 0x005F18AC
		public static IReasoningResultConfig GetRootAsIReasoningResultConfig(ByteBuffer _bb, IReasoningResultConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BBDD RID: 179165 RVA: 0x005F36C9 File Offset: 0x005F18C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BBDE RID: 179166 RVA: 0x005F36D8 File Offset: 0x005F18D8
		public IReasoningResultConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602BBDF RID: 179167 RVA: 0x005F36E8 File Offset: 0x005F18E8
		public int ClueCombination(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BDE5 RID: 48613
		// (get) Token: 0x0602BBE0 RID: 179168 RVA: 0x005F3728 File Offset: 0x005F1928
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

		// Token: 0x0602BBE1 RID: 179169 RVA: 0x005F3753 File Offset: 0x005F1953
		public Span<int> GetClueCombinationBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602BBE2 RID: 179170 RVA: 0x005F3762 File Offset: 0x005F1962
		public int[] GetClueCombinationArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602BBE3 RID: 179171 RVA: 0x005F3770 File Offset: 0x005F1970
		public string ReasoningStateId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BDE6 RID: 48614
		// (get) Token: 0x0602BBE4 RID: 179172 RVA: 0x005F37AC File Offset: 0x005F19AC
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

		// Token: 0x0602BBE5 RID: 179173 RVA: 0x005F37D8 File Offset: 0x005F19D8
		public string ResultDesc(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BDE7 RID: 48615
		// (get) Token: 0x0602BBE6 RID: 179174 RVA: 0x005F3814 File Offset: 0x005F1A14
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

		// Token: 0x1700BDE8 RID: 48616
		// (get) Token: 0x0602BBE7 RID: 179175 RVA: 0x005F3840 File Offset: 0x005F1A40
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

		// Token: 0x1700BDE9 RID: 48617
		// (get) Token: 0x0602BBE8 RID: 179176 RVA: 0x005F3880 File Offset: 0x005F1A80
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

		// Token: 0x1700BDEA RID: 48618
		// (get) Token: 0x0602BBE9 RID: 179177 RVA: 0x005F38C0 File Offset: 0x005F1AC0
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

		// Token: 0x1700BDEB RID: 48619
		// (get) Token: 0x0602BBEA RID: 179178 RVA: 0x005F3900 File Offset: 0x005F1B00
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

		// Token: 0x0602BBEB RID: 179179 RVA: 0x005F3940 File Offset: 0x005F1B40
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

		// Token: 0x0602BBEC RID: 179180 RVA: 0x005F398F File Offset: 0x005F1B8F
		public static void StartIReasoningResultConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602BBED RID: 179181 RVA: 0x005F3998 File Offset: 0x005F1B98
		public static void AddClueCombination(FlatBufferBuilder builder, VectorOffset clueCombinationOffset)
		{
			builder.AddOffset(0, clueCombinationOffset.Value, 0);
		}

		// Token: 0x0602BBEE RID: 179182 RVA: 0x005F39A8 File Offset: 0x005F1BA8
		public static VectorOffset CreateClueCombinationVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BBEF RID: 179183 RVA: 0x005F39DF File Offset: 0x005F1BDF
		public static VectorOffset CreateClueCombinationVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBF0 RID: 179184 RVA: 0x005F39F9 File Offset: 0x005F1BF9
		public static VectorOffset CreateClueCombinationVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBF1 RID: 179185 RVA: 0x005F3A17 File Offset: 0x005F1C17
		public static VectorOffset CreateClueCombinationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BBF2 RID: 179186 RVA: 0x005F3A30 File Offset: 0x005F1C30
		public static void StartClueCombinationVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BBF3 RID: 179187 RVA: 0x005F3A3B File Offset: 0x005F1C3B
		public static void AddReasoningStateId(FlatBufferBuilder builder, VectorOffset reasoningStateIdOffset)
		{
			builder.AddOffset(1, reasoningStateIdOffset.Value, 0);
		}

		// Token: 0x0602BBF4 RID: 179188 RVA: 0x005F3A4C File Offset: 0x005F1C4C
		public static VectorOffset CreateReasoningStateIdVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BBF5 RID: 179189 RVA: 0x005F3A8C File Offset: 0x005F1C8C
		public static VectorOffset CreateReasoningStateIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBF6 RID: 179190 RVA: 0x005F3AA6 File Offset: 0x005F1CA6
		public static VectorOffset CreateReasoningStateIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBF7 RID: 179191 RVA: 0x005F3AC4 File Offset: 0x005F1CC4
		public static VectorOffset CreateReasoningStateIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BBF8 RID: 179192 RVA: 0x005F3ADD File Offset: 0x005F1CDD
		public static void StartReasoningStateIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BBF9 RID: 179193 RVA: 0x005F3AE8 File Offset: 0x005F1CE8
		public static void AddResultDesc(FlatBufferBuilder builder, VectorOffset resultDescOffset)
		{
			builder.AddOffset(2, resultDescOffset.Value, 0);
		}

		// Token: 0x0602BBFA RID: 179194 RVA: 0x005F3AF8 File Offset: 0x005F1CF8
		public static VectorOffset CreateResultDescVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BBFB RID: 179195 RVA: 0x005F3B38 File Offset: 0x005F1D38
		public static VectorOffset CreateResultDescVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBFC RID: 179196 RVA: 0x005F3B52 File Offset: 0x005F1D52
		public static VectorOffset CreateResultDescVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BBFD RID: 179197 RVA: 0x005F3B70 File Offset: 0x005F1D70
		public static VectorOffset CreateResultDescVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BBFE RID: 179198 RVA: 0x005F3B89 File Offset: 0x005F1D89
		public static void StartResultDescVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BBFF RID: 179199 RVA: 0x005F3B94 File Offset: 0x005F1D94
		public static void AddNextQuestionId(FlatBufferBuilder builder, int nextQuestionId)
		{
			builder.AddInt(3, nextQuestionId, 0);
		}

		// Token: 0x0602BC00 RID: 179200 RVA: 0x005F3B9F File Offset: 0x005F1D9F
		public static void AddCaseProgressId(FlatBufferBuilder builder, int caseProgressId)
		{
			builder.AddInt(4, caseProgressId, 0);
		}

		// Token: 0x0602BC01 RID: 179201 RVA: 0x005F3BAA File Offset: 0x005F1DAA
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(5, endingId, 0);
		}

		// Token: 0x0602BC02 RID: 179202 RVA: 0x005F3BB5 File Offset: 0x005F1DB5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602BC03 RID: 179203 RVA: 0x005F3BC0 File Offset: 0x005F1DC0
		public static Offset<IReasoningResultConfig> EndIReasoningResultConfig(FlatBufferBuilder builder)
		{
			return new Offset<IReasoningResultConfig>(builder.EndTable());
		}

		// Token: 0x0602BC04 RID: 179204 RVA: 0x005F3BD0 File Offset: 0x005F1DD0
		public IReasoningResultConfigT UnPack()
		{
			IReasoningResultConfigT reasoningResultConfigT = new IReasoningResultConfigT();
			this.UnPackTo(reasoningResultConfigT);
			return reasoningResultConfigT;
		}

		// Token: 0x0602BC05 RID: 179205 RVA: 0x005F3BEC File Offset: 0x005F1DEC
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

		// Token: 0x0602BC06 RID: 179206 RVA: 0x005F3CB4 File Offset: 0x005F1EB4
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

		// Token: 0x040105AE RID: 66990
		private Table __p;
	}
}
