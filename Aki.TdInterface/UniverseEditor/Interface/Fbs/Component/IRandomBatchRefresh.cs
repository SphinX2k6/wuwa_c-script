using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E1 RID: 22497
	public struct IRandomBatchRefresh : IFlatbufferObject
	{
		// Token: 0x1700A80A RID: 43018
		// (get) Token: 0x06025CC4 RID: 154820 RVA: 0x005369B7 File Offset: 0x00534BB7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025CC5 RID: 154821 RVA: 0x005369C4 File Offset: 0x00534BC4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025CC6 RID: 154822 RVA: 0x005369CC File Offset: 0x00534BCC
		public static IRandomBatchRefresh GetRootAsIRandomBatchRefresh(ByteBuffer _bb)
		{
			return IRandomBatchRefresh.GetRootAsIRandomBatchRefresh(_bb, default(IRandomBatchRefresh));
		}

		// Token: 0x06025CC7 RID: 154823 RVA: 0x005369E8 File Offset: 0x00534BE8
		public static IRandomBatchRefresh GetRootAsIRandomBatchRefresh(ByteBuffer _bb, IRandomBatchRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025CC8 RID: 154824 RVA: 0x00536A05 File Offset: 0x00534C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025CC9 RID: 154825 RVA: 0x00536A14 File Offset: 0x00534C14
		public IRandomBatchRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A80B RID: 43019
		// (get) Token: 0x06025CCA RID: 154826 RVA: 0x00536A24 File Offset: 0x00534C24
		public EEntityBatchRefreshMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityBatchRefreshMode.SequenceBatch;
				}
				return (EEntityBatchRefreshMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025CCB RID: 154827 RVA: 0x00536A60 File Offset: 0x00534C60
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A80C RID: 43020
		// (get) Token: 0x06025CCC RID: 154828 RVA: 0x00536AC0 File Offset: 0x00534CC0
		public int EntityBatchesLength
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

		// Token: 0x06025CCD RID: 154829 RVA: 0x00536AEB File Offset: 0x00534CEB
		public static Offset<IRandomBatchRefresh> CreateIRandomBatchRefresh(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomBatchRefresh.AddEntityBatches(builder, EntityBatchesOffset);
			IRandomBatchRefresh.AddType(builder, Type);
			return IRandomBatchRefresh.EndIRandomBatchRefresh(builder);
		}

		// Token: 0x06025CCE RID: 154830 RVA: 0x00536B08 File Offset: 0x00534D08
		public static void StartIRandomBatchRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025CCF RID: 154831 RVA: 0x00536B11 File Offset: 0x00534D11
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025CD0 RID: 154832 RVA: 0x00536B1C File Offset: 0x00534D1C
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x06025CD1 RID: 154833 RVA: 0x00536B2C File Offset: 0x00534D2C
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025CD2 RID: 154834 RVA: 0x00536B6C File Offset: 0x00534D6C
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CD3 RID: 154835 RVA: 0x00536B86 File Offset: 0x00534D86
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CD4 RID: 154836 RVA: 0x00536BA4 File Offset: 0x00534DA4
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025CD5 RID: 154837 RVA: 0x00536BBD File Offset: 0x00534DBD
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025CD6 RID: 154838 RVA: 0x00536BC8 File Offset: 0x00534DC8
		public static Offset<IRandomBatchRefresh> EndIRandomBatchRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IRandomBatchRefresh>(builder.EndTable());
		}

		// Token: 0x06025CD7 RID: 154839 RVA: 0x00536BD8 File Offset: 0x00534DD8
		public IRandomBatchRefreshT UnPack()
		{
			IRandomBatchRefreshT randomBatchRefreshT = new IRandomBatchRefreshT();
			this.UnPackTo(randomBatchRefreshT);
			return randomBatchRefreshT;
		}

		// Token: 0x06025CD8 RID: 154840 RVA: 0x00536BF4 File Offset: 0x00534DF4
		public void UnPackTo(IRandomBatchRefreshT _o)
		{
			_o.Type = this.Type;
			_o.EntityBatches = new List<IEntityListBatchT>();
			for (int i = 0; i < this.EntityBatchesLength; i++)
			{
				_o.EntityBatches.Add((this.EntityBatches(i) != null) ? this.EntityBatches(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025CD9 RID: 154841 RVA: 0x00536C60 File Offset: 0x00534E60
		public static Offset<IRandomBatchRefresh> Pack(FlatBufferBuilder builder, IRandomBatchRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomBatchRefresh>);
			}
			VectorOffset entityBatchesOffset = default(VectorOffset);
			if (_o.EntityBatches != null)
			{
				Offset<IEntityListBatch>[] array = new Offset<IEntityListBatch>[_o.EntityBatches.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityListBatch.Pack(builder, _o.EntityBatches[i]);
				}
				entityBatchesOffset = IRandomBatchRefresh.CreateEntityBatchesVector(builder, array);
			}
			return IRandomBatchRefresh.CreateIRandomBatchRefresh(builder, _o.Type, entityBatchesOffset);
		}

		// Token: 0x0400ECD3 RID: 60627
		private Table __p;
	}
}
