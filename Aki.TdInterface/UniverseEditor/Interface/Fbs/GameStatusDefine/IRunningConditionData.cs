using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004700 RID: 18176
	public struct IRunningConditionData : IFlatbufferObject
	{
		// Token: 0x1700820C RID: 33292
		// (get) Token: 0x0601BDBB RID: 114107 RVA: 0x003F2F14 File Offset: 0x003F1114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BDBC RID: 114108 RVA: 0x003F2F21 File Offset: 0x003F1121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BDBD RID: 114109 RVA: 0x003F2F28 File Offset: 0x003F1128
		public static IRunningConditionData GetRootAsIRunningConditionData(ByteBuffer _bb)
		{
			return IRunningConditionData.GetRootAsIRunningConditionData(_bb, default(IRunningConditionData));
		}

		// Token: 0x0601BDBE RID: 114110 RVA: 0x003F2F44 File Offset: 0x003F1144
		public static IRunningConditionData GetRootAsIRunningConditionData(ByteBuffer _bb, IRunningConditionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BDBF RID: 114111 RVA: 0x003F2F61 File Offset: 0x003F1161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BDC0 RID: 114112 RVA: 0x003F2F70 File Offset: 0x003F1170
		public IRunningConditionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700820D RID: 33293
		// (get) Token: 0x0601BDC1 RID: 114113 RVA: 0x003F2F80 File Offset: 0x003F1180
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

		// Token: 0x0601BDC2 RID: 114114 RVA: 0x003F2FBC File Offset: 0x003F11BC
		public bool Result(int j)
		{
			int num = this.__p.__offset(6);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x1700820E RID: 33294
		// (get) Token: 0x0601BDC3 RID: 114115 RVA: 0x003F2FFC File Offset: 0x003F11FC
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

		// Token: 0x0601BDC4 RID: 114116 RVA: 0x003F3027 File Offset: 0x003F1227
		public Span<bool> GetResultBytes()
		{
			return this.__p.__vector_as_span<bool>(6, 1);
		}

		// Token: 0x0601BDC5 RID: 114117 RVA: 0x003F3036 File Offset: 0x003F1236
		public bool[] GetResultArray()
		{
			return this.__p.__vector_as_array<bool>(6);
		}

		// Token: 0x0601BDC6 RID: 114118 RVA: 0x003F3044 File Offset: 0x003F1244
		public static Offset<IRunningConditionData> CreateIRunningConditionData(FlatBufferBuilder builder, int RequestId = 0, VectorOffset ResultOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRunningConditionData.AddResult(builder, ResultOffset);
			IRunningConditionData.AddRequestId(builder, RequestId);
			return IRunningConditionData.EndIRunningConditionData(builder);
		}

		// Token: 0x0601BDC7 RID: 114119 RVA: 0x003F3061 File Offset: 0x003F1261
		public static void StartIRunningConditionData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BDC8 RID: 114120 RVA: 0x003F306A File Offset: 0x003F126A
		public static void AddRequestId(FlatBufferBuilder builder, int requestId)
		{
			builder.AddInt(0, requestId, 0);
		}

		// Token: 0x0601BDC9 RID: 114121 RVA: 0x003F3075 File Offset: 0x003F1275
		public static void AddResult(FlatBufferBuilder builder, VectorOffset resultOffset)
		{
			builder.AddOffset(1, resultOffset.Value, 0);
		}

		// Token: 0x0601BDCA RID: 114122 RVA: 0x003F3088 File Offset: 0x003F1288
		public static VectorOffset CreateResultVector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BDCB RID: 114123 RVA: 0x003F30BF File Offset: 0x003F12BF
		public static VectorOffset CreateResultVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<bool>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDCC RID: 114124 RVA: 0x003F30D9 File Offset: 0x003F12D9
		public static VectorOffset CreateResultVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<bool>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDCD RID: 114125 RVA: 0x003F30F7 File Offset: 0x003F12F7
		public static VectorOffset CreateResultVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<bool>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BDCE RID: 114126 RVA: 0x003F3110 File Offset: 0x003F1310
		public static void StartResultVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BDCF RID: 114127 RVA: 0x003F311B File Offset: 0x003F131B
		public static Offset<IRunningConditionData> EndIRunningConditionData(FlatBufferBuilder builder)
		{
			return new Offset<IRunningConditionData>(builder.EndTable());
		}

		// Token: 0x0601BDD0 RID: 114128 RVA: 0x003F3128 File Offset: 0x003F1328
		public IRunningConditionDataT UnPack()
		{
			IRunningConditionDataT runningConditionDataT = new IRunningConditionDataT();
			this.UnPackTo(runningConditionDataT);
			return runningConditionDataT;
		}

		// Token: 0x0601BDD1 RID: 114129 RVA: 0x003F3144 File Offset: 0x003F1344
		public void UnPackTo(IRunningConditionDataT _o)
		{
			_o.RequestId = this.RequestId;
			_o.Result = new List<bool>();
			for (int i = 0; i < this.ResultLength; i++)
			{
				_o.Result.Add(this.Result(i));
			}
		}

		// Token: 0x0601BDD2 RID: 114130 RVA: 0x003F318C File Offset: 0x003F138C
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

		// Token: 0x0400C9B9 RID: 51641
		private Table __p;
	}
}
