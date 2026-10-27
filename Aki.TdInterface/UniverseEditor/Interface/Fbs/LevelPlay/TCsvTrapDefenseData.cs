using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F0 RID: 17904
	public struct TCsvTrapDefenseData : IFlatbufferObject
	{
		// Token: 0x17007F4C RID: 32588
		// (get) Token: 0x0601B1DF RID: 111071 RVA: 0x003DD520 File Offset: 0x003DB720
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B1E0 RID: 111072 RVA: 0x003DD52D File Offset: 0x003DB72D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B1E1 RID: 111073 RVA: 0x003DD534 File Offset: 0x003DB734
		public static TCsvTrapDefenseData GetRootAsTCsvTrapDefenseData(ByteBuffer _bb)
		{
			return TCsvTrapDefenseData.GetRootAsTCsvTrapDefenseData(_bb, default(TCsvTrapDefenseData));
		}

		// Token: 0x0601B1E2 RID: 111074 RVA: 0x003DD550 File Offset: 0x003DB750
		public static TCsvTrapDefenseData GetRootAsTCsvTrapDefenseData(ByteBuffer _bb, TCsvTrapDefenseData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B1E3 RID: 111075 RVA: 0x003DD56D File Offset: 0x003DB76D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B1E4 RID: 111076 RVA: 0x003DD57C File Offset: 0x003DB77C
		public TCsvTrapDefenseData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F4D RID: 32589
		// (get) Token: 0x0601B1E5 RID: 111077 RVA: 0x003DD58C File Offset: 0x003DB78C
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

		// Token: 0x0601B1E6 RID: 111078 RVA: 0x003DD5C8 File Offset: 0x003DB7C8
		public ITrapDefenseBatch? Batches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseBatch?(default(ITrapDefenseBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007F4E RID: 32590
		// (get) Token: 0x0601B1E7 RID: 111079 RVA: 0x003DD628 File Offset: 0x003DB828
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

		// Token: 0x0601B1E8 RID: 111080 RVA: 0x003DD653 File Offset: 0x003DB853
		public static Offset<TCsvTrapDefenseData> CreateTCsvTrapDefenseData(FlatBufferBuilder builder, int Id = 0, VectorOffset BatchesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			TCsvTrapDefenseData.AddBatches(builder, BatchesOffset);
			TCsvTrapDefenseData.AddId(builder, Id);
			return TCsvTrapDefenseData.EndTCsvTrapDefenseData(builder);
		}

		// Token: 0x0601B1E9 RID: 111081 RVA: 0x003DD670 File Offset: 0x003DB870
		public static void StartTCsvTrapDefenseData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B1EA RID: 111082 RVA: 0x003DD679 File Offset: 0x003DB879
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B1EB RID: 111083 RVA: 0x003DD684 File Offset: 0x003DB884
		public static void AddBatches(FlatBufferBuilder builder, VectorOffset batchesOffset)
		{
			builder.AddOffset(1, batchesOffset.Value, 0);
		}

		// Token: 0x0601B1EC RID: 111084 RVA: 0x003DD694 File Offset: 0x003DB894
		public static VectorOffset CreateBatchesVector(FlatBufferBuilder builder, Offset<ITrapDefenseBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1ED RID: 111085 RVA: 0x003DD6D4 File Offset: 0x003DB8D4
		public static VectorOffset CreateBatchesVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1EE RID: 111086 RVA: 0x003DD6EE File Offset: 0x003DB8EE
		public static VectorOffset CreateBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1EF RID: 111087 RVA: 0x003DD70C File Offset: 0x003DB90C
		public static VectorOffset CreateBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1F0 RID: 111088 RVA: 0x003DD725 File Offset: 0x003DB925
		public static void StartBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B1F1 RID: 111089 RVA: 0x003DD730 File Offset: 0x003DB930
		public static Offset<TCsvTrapDefenseData> EndTCsvTrapDefenseData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTrapDefenseData>(builder.EndTable());
		}

		// Token: 0x0601B1F2 RID: 111090 RVA: 0x003DD740 File Offset: 0x003DB940
		public TCsvTrapDefenseDataT UnPack()
		{
			TCsvTrapDefenseDataT tcsvTrapDefenseDataT = new TCsvTrapDefenseDataT();
			this.UnPackTo(tcsvTrapDefenseDataT);
			return tcsvTrapDefenseDataT;
		}

		// Token: 0x0601B1F3 RID: 111091 RVA: 0x003DD75C File Offset: 0x003DB95C
		public void UnPackTo(TCsvTrapDefenseDataT _o)
		{
			_o.Id = this.Id;
			_o.Batches = new List<ITrapDefenseBatchT>();
			for (int i = 0; i < this.BatchesLength; i++)
			{
				_o.Batches.Add((this.Batches(i) != null) ? this.Batches(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B1F4 RID: 111092 RVA: 0x003DD7C8 File Offset: 0x003DB9C8
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

		// Token: 0x0400C6D2 RID: 50898
		private Table __p;
	}
}
