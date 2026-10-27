using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200645F RID: 25695
	public struct ICommonBtClientOverrideData : IFlatbufferObject
	{
		// Token: 0x1700BF38 RID: 48952
		// (get) Token: 0x0602C76C RID: 182124 RVA: 0x00619148 File Offset: 0x00617348
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C76D RID: 182125 RVA: 0x00619155 File Offset: 0x00617355
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C76E RID: 182126 RVA: 0x0061915C File Offset: 0x0061735C
		public static ICommonBtClientOverrideData GetRootAsICommonBtClientOverrideData(ByteBuffer _bb)
		{
			return ICommonBtClientOverrideData.GetRootAsICommonBtClientOverrideData(_bb, default(ICommonBtClientOverrideData));
		}

		// Token: 0x0602C76F RID: 182127 RVA: 0x00619178 File Offset: 0x00617378
		public static ICommonBtClientOverrideData GetRootAsICommonBtClientOverrideData(ByteBuffer _bb, ICommonBtClientOverrideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C770 RID: 182128 RVA: 0x00619195 File Offset: 0x00617395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C771 RID: 182129 RVA: 0x006191A4 File Offset: 0x006173A4
		public ICommonBtClientOverrideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF39 RID: 48953
		// (get) Token: 0x0602C772 RID: 182130 RVA: 0x006191B4 File Offset: 0x006173B4
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

		// Token: 0x1700BF3A RID: 48954
		// (get) Token: 0x0602C773 RID: 182131 RVA: 0x006191F0 File Offset: 0x006173F0
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

		// Token: 0x0602C774 RID: 182132 RVA: 0x00619227 File Offset: 0x00617427
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C775 RID: 182133 RVA: 0x00619236 File Offset: 0x00617436
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C776 RID: 182134 RVA: 0x00619244 File Offset: 0x00617444
		public static Offset<ICommonBtClientOverrideData> CreateICommonBtClientOverrideData(FlatBufferBuilder builder, int TaskId = 0, StringOffset DataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonBtClientOverrideData.AddData(builder, DataOffset);
			ICommonBtClientOverrideData.AddTaskId(builder, TaskId);
			return ICommonBtClientOverrideData.EndICommonBtClientOverrideData(builder);
		}

		// Token: 0x0602C777 RID: 182135 RVA: 0x00619261 File Offset: 0x00617461
		public static void StartICommonBtClientOverrideData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C778 RID: 182136 RVA: 0x0061926A File Offset: 0x0061746A
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x0602C779 RID: 182137 RVA: 0x00619275 File Offset: 0x00617475
		public static void AddData(FlatBufferBuilder builder, StringOffset dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0602C77A RID: 182138 RVA: 0x00619285 File Offset: 0x00617485
		public static Offset<ICommonBtClientOverrideData> EndICommonBtClientOverrideData(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtClientOverrideData>(builder.EndTable());
		}

		// Token: 0x0602C77B RID: 182139 RVA: 0x00619294 File Offset: 0x00617494
		public ICommonBtClientOverrideDataT UnPack()
		{
			ICommonBtClientOverrideDataT commonBtClientOverrideDataT = new ICommonBtClientOverrideDataT();
			this.UnPackTo(commonBtClientOverrideDataT);
			return commonBtClientOverrideDataT;
		}

		// Token: 0x0602C77C RID: 182140 RVA: 0x006192AF File Offset: 0x006174AF
		public void UnPackTo(ICommonBtClientOverrideDataT _o)
		{
			_o.TaskId = this.TaskId;
			_o.Data = this.Data;
		}

		// Token: 0x0602C77D RID: 182141 RVA: 0x006192CC File Offset: 0x006174CC
		public static Offset<ICommonBtClientOverrideData> Pack(FlatBufferBuilder builder, ICommonBtClientOverrideDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtClientOverrideData>);
			}
			StringOffset dataOffset = (_o.Data == null) ? default(StringOffset) : builder.CreateString(_o.Data);
			return ICommonBtClientOverrideData.CreateICommonBtClientOverrideData(builder, _o.TaskId, dataOffset);
		}

		// Token: 0x04010A5C RID: 68188
		private Table __p;
	}
}
