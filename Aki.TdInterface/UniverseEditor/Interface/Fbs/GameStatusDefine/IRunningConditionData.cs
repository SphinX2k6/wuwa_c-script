using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B68 RID: 19304
	public struct IRunningConditionData : IFlatbufferObject
	{
		// Token: 0x1700884D RID: 34893
		// (get) Token: 0x0601D590 RID: 120208 RVA: 0x0041F1B0 File Offset: 0x0041D3B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D591 RID: 120209 RVA: 0x0041F1BD File Offset: 0x0041D3BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D592 RID: 120210 RVA: 0x0041F1C4 File Offset: 0x0041D3C4
		public static IRunningConditionData GetRootAsIRunningConditionData(ByteBuffer _bb)
		{
			return IRunningConditionData.GetRootAsIRunningConditionData(_bb, default(IRunningConditionData));
		}

		// Token: 0x0601D593 RID: 120211 RVA: 0x0041F1E0 File Offset: 0x0041D3E0
		public static IRunningConditionData GetRootAsIRunningConditionData(ByteBuffer _bb, IRunningConditionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D594 RID: 120212 RVA: 0x0041F1FD File Offset: 0x0041D3FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D595 RID: 120213 RVA: 0x0041F20C File Offset: 0x0041D40C
		public IRunningConditionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700884E RID: 34894
		// (get) Token: 0x0601D596 RID: 120214 RVA: 0x0041F21C File Offset: 0x0041D41C
		public int RequestId
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

		// Token: 0x0601D597 RID: 120215 RVA: 0x0041F258 File Offset: 0x0041D458
		public bool Result(int j)
		{
			int num = this.__p.__offset(6);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x1700884F RID: 34895
		// (get) Token: 0x0601D598 RID: 120216 RVA: 0x0041F298 File Offset: 0x0041D498
		public int ResultLength
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

		// Token: 0x0601D599 RID: 120217 RVA: 0x0041F2C3 File Offset: 0x0041D4C3
		public Span<bool> GetResultBytes()
		{
			return this.__p.__vector_as_span<bool>(6, 1);
		}

		// Token: 0x0601D59A RID: 120218 RVA: 0x0041F2D2 File Offset: 0x0041D4D2
		public bool[] GetResultArray()
		{
			return this.__p.__vector_as_array<bool>(6);
		}

		// Token: 0x0601D59B RID: 120219 RVA: 0x0041F2E0 File Offset: 0x0041D4E0
		public static Offset<IRunningConditionData> CreateIRunningConditionData(FlatBufferBuilder builder, int RequestId = 0, VectorOffset ResultOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRunningConditionData.AddResult(builder, ResultOffset);
			IRunningConditionData.AddRequestId(builder, RequestId);
			return IRunningConditionData.EndIRunningConditionData(builder);
		}

		// Token: 0x0601D59C RID: 120220 RVA: 0x0041F2FD File Offset: 0x0041D4FD
		public static void StartIRunningConditionData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D59D RID: 120221 RVA: 0x0041F306 File Offset: 0x0041D506
		public static void AddRequestId(FlatBufferBuilder builder, int requestId)
		{
			builder.AddInt(0, requestId, 0);
		}

		// Token: 0x0601D59E RID: 120222 RVA: 0x0041F311 File Offset: 0x0041D511
		public static void AddResult(FlatBufferBuilder builder, VectorOffset resultOffset)
		{
			builder.AddOffset(1, resultOffset.Value, 0);
		}

		// Token: 0x0601D59F RID: 120223 RVA: 0x0041F324 File Offset: 0x0041D524
		public static VectorOffset CreateResultVector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D5A0 RID: 120224 RVA: 0x0041F35B File Offset: 0x0041D55B
		public static VectorOffset CreateResultVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<bool>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D5A1 RID: 120225 RVA: 0x0041F375 File Offset: 0x0041D575
		public static VectorOffset CreateResultVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<bool>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D5A2 RID: 120226 RVA: 0x0041F393 File Offset: 0x0041D593
		public static VectorOffset CreateResultVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<bool>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D5A3 RID: 120227 RVA: 0x0041F3AC File Offset: 0x0041D5AC
		public static void StartResultVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601D5A4 RID: 120228 RVA: 0x0041F3B7 File Offset: 0x0041D5B7
		public static Offset<IRunningConditionData> EndIRunningConditionData(FlatBufferBuilder builder)
		{
			return new Offset<IRunningConditionData>(builder.EndTable());
		}

		// Token: 0x0601D5A5 RID: 120229 RVA: 0x0041F3C4 File Offset: 0x0041D5C4
		public IRunningConditionDataT UnPack()
		{
			IRunningConditionDataT runningConditionDataT = new IRunningConditionDataT();
			this.UnPackTo(runningConditionDataT);
			return runningConditionDataT;
		}

		// Token: 0x0601D5A6 RID: 120230 RVA: 0x0041F3E0 File Offset: 0x0041D5E0
		public void UnPackTo(IRunningConditionDataT _o)
		{
			_o.RequestId = this.RequestId;
			_o.Result = new List<bool>();
			for (int i = 0; i < this.ResultLength; i++)
			{
				_o.Result.Add(this.Result(i));
			}
		}

		// Token: 0x0601D5A7 RID: 120231 RVA: 0x0041F428 File Offset: 0x0041D628
		public static Offset<IRunningConditionData> Pack(FlatBufferBuilder builder, IRunningConditionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningConditionData>);
			}
			VectorOffset resultOffset = default(VectorOffset);
			if (_o.Result != null)
			{
				bool[] data = _o.Result.ToArray();
				resultOffset = IRunningConditionData.CreateResultVector(builder, data);
			}
			return IRunningConditionData.CreateIRunningConditionData(builder, _o.RequestId, resultOffset);
		}

		// Token: 0x0400D3E8 RID: 54248
		private Table __p;
	}
}
