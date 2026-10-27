using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FA RID: 22778
	public struct ISequenceBatchRefresh : IFlatbufferObject
	{
		// Token: 0x1700AAB7 RID: 43703
		// (get) Token: 0x060267C4 RID: 157636 RVA: 0x0054D8AE File Offset: 0x0054BAAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060267C5 RID: 157637 RVA: 0x0054D8BB File Offset: 0x0054BABB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060267C6 RID: 157638 RVA: 0x0054D8C4 File Offset: 0x0054BAC4
		public static ISequenceBatchRefresh GetRootAsISequenceBatchRefresh(ByteBuffer _bb)
		{
			return ISequenceBatchRefresh.GetRootAsISequenceBatchRefresh(_bb, default(ISequenceBatchRefresh));
		}

		// Token: 0x060267C7 RID: 157639 RVA: 0x0054D8E0 File Offset: 0x0054BAE0
		public static ISequenceBatchRefresh GetRootAsISequenceBatchRefresh(ByteBuffer _bb, ISequenceBatchRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060267C8 RID: 157640 RVA: 0x0054D8FD File Offset: 0x0054BAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060267C9 RID: 157641 RVA: 0x0054D90C File Offset: 0x0054BB0C
		public ISequenceBatchRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAB8 RID: 43704
		// (get) Token: 0x060267CA RID: 157642 RVA: 0x0054D91C File Offset: 0x0054BB1C
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

		// Token: 0x060267CB RID: 157643 RVA: 0x0054D958 File Offset: 0x0054BB58
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AAB9 RID: 43705
		// (get) Token: 0x060267CC RID: 157644 RVA: 0x0054D9B8 File Offset: 0x0054BBB8
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

		// Token: 0x1700AABA RID: 43706
		// (get) Token: 0x060267CD RID: 157645 RVA: 0x0054D9E4 File Offset: 0x0054BBE4
		public bool IsRestartAfterAllBatchesFinished
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AABB RID: 43707
		// (get) Token: 0x060267CE RID: 157646 RVA: 0x0054DA24 File Offset: 0x0054BC24
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060267CF RID: 157647 RVA: 0x0054DA61 File Offset: 0x0054BC61
		public static Offset<ISequenceBatchRefresh> CreateISequenceBatchRefresh(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset), bool IsRestartAfterAllBatchesFinished = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISequenceBatchRefresh.AddEntityBatches(builder, EntityBatchesOffset);
			ISequenceBatchRefresh.AddNullMask(builder, NullMask);
			ISequenceBatchRefresh.AddIsRestartAfterAllBatchesFinished(builder, IsRestartAfterAllBatchesFinished);
			ISequenceBatchRefresh.AddType(builder, Type);
			return ISequenceBatchRefresh.EndISequenceBatchRefresh(builder);
		}

		// Token: 0x060267D0 RID: 157648 RVA: 0x0054DA8D File Offset: 0x0054BC8D
		public static void StartISequenceBatchRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060267D1 RID: 157649 RVA: 0x0054DA96 File Offset: 0x0054BC96
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060267D2 RID: 157650 RVA: 0x0054DAA1 File Offset: 0x0054BCA1
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x060267D3 RID: 157651 RVA: 0x0054DAB4 File Offset: 0x0054BCB4
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060267D4 RID: 157652 RVA: 0x0054DAF4 File Offset: 0x0054BCF4
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267D5 RID: 157653 RVA: 0x0054DB0E File Offset: 0x0054BD0E
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267D6 RID: 157654 RVA: 0x0054DB2C File Offset: 0x0054BD2C
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060267D7 RID: 157655 RVA: 0x0054DB45 File Offset: 0x0054BD45
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060267D8 RID: 157656 RVA: 0x0054DB50 File Offset: 0x0054BD50
		public static void AddIsRestartAfterAllBatchesFinished(FlatBufferBuilder builder, bool isRestartAfterAllBatchesFinished)
		{
			builder.AddBool(2, isRestartAfterAllBatchesFinished, false);
		}

		// Token: 0x060267D9 RID: 157657 RVA: 0x0054DB5B File Offset: 0x0054BD5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060267DA RID: 157658 RVA: 0x0054DB66 File Offset: 0x0054BD66
		public static Offset<ISequenceBatchRefresh> EndISequenceBatchRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceBatchRefresh>(builder.EndTable());
		}

		// Token: 0x060267DB RID: 157659 RVA: 0x0054DB74 File Offset: 0x0054BD74
		public ISequenceBatchRefreshT UnPack()
		{
			ISequenceBatchRefreshT sequenceBatchRefreshT = new ISequenceBatchRefreshT();
			this.UnPackTo(sequenceBatchRefreshT);
			return sequenceBatchRefreshT;
		}

		// Token: 0x060267DC RID: 157660 RVA: 0x0054DB90 File Offset: 0x0054BD90
		public void UnPackTo(ISequenceBatchRefreshT _o)
		{
			_o.Type = this.Type;
			_o.EntityBatches = new List<IEntityListBatchT>();
			for (int i = 0; i < this.EntityBatchesLength; i++)
			{
				_o.EntityBatches.Add((this.EntityBatches(i) != null) ? this.EntityBatches(i).Value.UnPack() : null);
			}
			_o.IsRestartAfterAllBatchesFinished = this.IsRestartAfterAllBatchesFinished;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060267DD RID: 157661 RVA: 0x0054DC14 File Offset: 0x0054BE14
		public static Offset<ISequenceBatchRefresh> Pack(FlatBufferBuilder builder, ISequenceBatchRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceBatchRefresh>);
			}
			VectorOffset entityBatchesOffset = default(VectorOffset);
			if (_o.EntityBatches != null)
			{
				Offset<IEntityListBatch>[] array = new Offset<IEntityListBatch>[_o.EntityBatches.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityListBatch.Pack(builder, _o.EntityBatches[i]);
				}
				entityBatchesOffset = ISequenceBatchRefresh.CreateEntityBatchesVector(builder, array);
			}
			return ISequenceBatchRefresh.CreateISequenceBatchRefresh(builder, _o.Type, entityBatchesOffset, _o.IsRestartAfterAllBatchesFinished, _o.NullMask);
		}

		// Token: 0x0400EE97 RID: 61079
		private Table __p;
	}
}
