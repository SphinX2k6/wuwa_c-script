using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC7 RID: 27335
	public struct ICommonBtClientOverrideData : IFlatbufferObject
	{
		// Token: 0x1700C8BA RID: 51386
		// (get) Token: 0x0602EEB1 RID: 192177 RVA: 0x00664214 File Offset: 0x00662414
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EEB2 RID: 192178 RVA: 0x00664221 File Offset: 0x00662421
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EEB3 RID: 192179 RVA: 0x00664228 File Offset: 0x00662428
		public static ICommonBtClientOverrideData GetRootAsICommonBtClientOverrideData(ByteBuffer _bb)
		{
			return ICommonBtClientOverrideData.GetRootAsICommonBtClientOverrideData(_bb, default(ICommonBtClientOverrideData));
		}

		// Token: 0x0602EEB4 RID: 192180 RVA: 0x00664244 File Offset: 0x00662444
		public static ICommonBtClientOverrideData GetRootAsICommonBtClientOverrideData(ByteBuffer _bb, ICommonBtClientOverrideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EEB5 RID: 192181 RVA: 0x00664261 File Offset: 0x00662461
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EEB6 RID: 192182 RVA: 0x00664270 File Offset: 0x00662470
		public ICommonBtClientOverrideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8BB RID: 51387
		// (get) Token: 0x0602EEB7 RID: 192183 RVA: 0x00664280 File Offset: 0x00662480
		public int TaskId
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

		// Token: 0x1700C8BC RID: 51388
		// (get) Token: 0x0602EEB8 RID: 192184 RVA: 0x006642BC File Offset: 0x006624BC
		public string Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EEB9 RID: 192185 RVA: 0x006642F3 File Offset: 0x006624F3
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602EEBA RID: 192186 RVA: 0x00664302 File Offset: 0x00662502
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602EEBB RID: 192187 RVA: 0x00664310 File Offset: 0x00662510
		public static Offset<ICommonBtClientOverrideData> CreateICommonBtClientOverrideData(FlatBufferBuilder builder, int TaskId = 0, StringOffset DataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonBtClientOverrideData.AddData(builder, DataOffset);
			ICommonBtClientOverrideData.AddTaskId(builder, TaskId);
			return ICommonBtClientOverrideData.EndICommonBtClientOverrideData(builder);
		}

		// Token: 0x0602EEBC RID: 192188 RVA: 0x0066432D File Offset: 0x0066252D
		public static void StartICommonBtClientOverrideData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EEBD RID: 192189 RVA: 0x00664336 File Offset: 0x00662536
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x0602EEBE RID: 192190 RVA: 0x00664341 File Offset: 0x00662541
		public static void AddData(FlatBufferBuilder builder, StringOffset dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0602EEBF RID: 192191 RVA: 0x00664351 File Offset: 0x00662551
		public static Offset<ICommonBtClientOverrideData> EndICommonBtClientOverrideData(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtClientOverrideData>(builder.EndTable());
		}

		// Token: 0x0602EEC0 RID: 192192 RVA: 0x00664360 File Offset: 0x00662560
		public ICommonBtClientOverrideDataT UnPack()
		{
			ICommonBtClientOverrideDataT commonBtClientOverrideDataT = new ICommonBtClientOverrideDataT();
			this.UnPackTo(commonBtClientOverrideDataT);
			return commonBtClientOverrideDataT;
		}

		// Token: 0x0602EEC1 RID: 192193 RVA: 0x0066437B File Offset: 0x0066257B
		public void UnPackTo(ICommonBtClientOverrideDataT _o)
		{
			_o.TaskId = this.TaskId;
			_o.Data = this.Data;
		}

		// Token: 0x0602EEC2 RID: 192194 RVA: 0x00664398 File Offset: 0x00662598
		public static Offset<ICommonBtClientOverrideData> Pack(FlatBufferBuilder builder, ICommonBtClientOverrideDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtClientOverrideData>);
			}
			StringOffset dataOffset = (_o.Data == null) ? default(StringOffset) : builder.CreateString(_o.Data);
			return ICommonBtClientOverrideData.CreateICommonBtClientOverrideData(builder, _o.TaskId, dataOffset);
		}

		// Token: 0x04011867 RID: 71783
		private Table __p;
	}
}
