using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A58 RID: 19032
	public struct TCsvTrapDefenseData : IFlatbufferObject
	{
		// Token: 0x1700858D RID: 34189
		// (get) Token: 0x0601C9B4 RID: 117172 RVA: 0x004097BC File Offset: 0x004079BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C9B5 RID: 117173 RVA: 0x004097C9 File Offset: 0x004079C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C9B6 RID: 117174 RVA: 0x004097D0 File Offset: 0x004079D0
		public static TCsvTrapDefenseData GetRootAsTCsvTrapDefenseData(ByteBuffer _bb)
		{
			return TCsvTrapDefenseData.GetRootAsTCsvTrapDefenseData(_bb, default(TCsvTrapDefenseData));
		}

		// Token: 0x0601C9B7 RID: 117175 RVA: 0x004097EC File Offset: 0x004079EC
		public static TCsvTrapDefenseData GetRootAsTCsvTrapDefenseData(ByteBuffer _bb, TCsvTrapDefenseData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C9B8 RID: 117176 RVA: 0x00409809 File Offset: 0x00407A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C9B9 RID: 117177 RVA: 0x00409818 File Offset: 0x00407A18
		public TCsvTrapDefenseData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700858E RID: 34190
		// (get) Token: 0x0601C9BA RID: 117178 RVA: 0x00409828 File Offset: 0x00407A28
		public int Id
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

		// Token: 0x0601C9BB RID: 117179 RVA: 0x00409864 File Offset: 0x00407A64
		public ITrapDefenseBatch? Batches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseBatch?(default(ITrapDefenseBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700858F RID: 34191
		// (get) Token: 0x0601C9BC RID: 117180 RVA: 0x004098C4 File Offset: 0x00407AC4
		public int BatchesLength
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

		// Token: 0x0601C9BD RID: 117181 RVA: 0x004098EF File Offset: 0x00407AEF
		public static Offset<TCsvTrapDefenseData> CreateTCsvTrapDefenseData(FlatBufferBuilder builder, int Id = 0, VectorOffset BatchesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			TCsvTrapDefenseData.AddBatches(builder, BatchesOffset);
			TCsvTrapDefenseData.AddId(builder, Id);
			return TCsvTrapDefenseData.EndTCsvTrapDefenseData(builder);
		}

		// Token: 0x0601C9BE RID: 117182 RVA: 0x0040990C File Offset: 0x00407B0C
		public static void StartTCsvTrapDefenseData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C9BF RID: 117183 RVA: 0x00409915 File Offset: 0x00407B15
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C9C0 RID: 117184 RVA: 0x00409920 File Offset: 0x00407B20
		public static void AddBatches(FlatBufferBuilder builder, VectorOffset batchesOffset)
		{
			builder.AddOffset(1, batchesOffset.Value, 0);
		}

		// Token: 0x0601C9C1 RID: 117185 RVA: 0x00409930 File Offset: 0x00407B30
		public static VectorOffset CreateBatchesVector(FlatBufferBuilder builder, Offset<ITrapDefenseBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C9C2 RID: 117186 RVA: 0x00409970 File Offset: 0x00407B70
		public static VectorOffset CreateBatchesVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9C3 RID: 117187 RVA: 0x0040998A File Offset: 0x00407B8A
		public static VectorOffset CreateBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9C4 RID: 117188 RVA: 0x004099A8 File Offset: 0x00407BA8
		public static VectorOffset CreateBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C9C5 RID: 117189 RVA: 0x004099C1 File Offset: 0x00407BC1
		public static void StartBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C9C6 RID: 117190 RVA: 0x004099CC File Offset: 0x00407BCC
		public static Offset<TCsvTrapDefenseData> EndTCsvTrapDefenseData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTrapDefenseData>(builder.EndTable());
		}

		// Token: 0x0601C9C7 RID: 117191 RVA: 0x004099DC File Offset: 0x00407BDC
		public TCsvTrapDefenseDataT UnPack()
		{
			TCsvTrapDefenseDataT tcsvTrapDefenseDataT = new TCsvTrapDefenseDataT();
			this.UnPackTo(tcsvTrapDefenseDataT);
			return tcsvTrapDefenseDataT;
		}

		// Token: 0x0601C9C8 RID: 117192 RVA: 0x004099F8 File Offset: 0x00407BF8
		public void UnPackTo(TCsvTrapDefenseDataT _o)
		{
			_o.Id = this.Id;
			_o.Batches = new List<ITrapDefenseBatchT>();
			for (int i = 0; i < this.BatchesLength; i++)
			{
				_o.Batches.Add((this.Batches(i) != null) ? this.Batches(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C9C9 RID: 117193 RVA: 0x00409A64 File Offset: 0x00407C64
		public static Offset<TCsvTrapDefenseData> Pack(FlatBufferBuilder builder, TCsvTrapDefenseDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvTrapDefenseData>);
			}
			VectorOffset batchesOffset = default(VectorOffset);
			if (_o.Batches != null)
			{
				Offset<ITrapDefenseBatch>[] array = new Offset<ITrapDefenseBatch>[_o.Batches.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITrapDefenseBatch.Pack(builder, _o.Batches[i]);
				}
				batchesOffset = TCsvTrapDefenseData.CreateBatchesVector(builder, array);
			}
			return TCsvTrapDefenseData.CreateTCsvTrapDefenseData(builder, _o.Id, batchesOffset);
		}

		// Token: 0x0400D101 RID: 53505
		private Table __p;
	}
}
