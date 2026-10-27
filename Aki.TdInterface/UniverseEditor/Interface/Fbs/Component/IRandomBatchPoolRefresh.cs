using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DE RID: 22494
	public struct IRandomBatchPoolRefresh : IFlatbufferObject
	{
		// Token: 0x1700A801 RID: 43009
		// (get) Token: 0x06025CA0 RID: 154784 RVA: 0x005364F1 File Offset: 0x005346F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025CA1 RID: 154785 RVA: 0x005364FE File Offset: 0x005346FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025CA2 RID: 154786 RVA: 0x00536508 File Offset: 0x00534708
		public static IRandomBatchPoolRefresh GetRootAsIRandomBatchPoolRefresh(ByteBuffer _bb)
		{
			return IRandomBatchPoolRefresh.GetRootAsIRandomBatchPoolRefresh(_bb, default(IRandomBatchPoolRefresh));
		}

		// Token: 0x06025CA3 RID: 154787 RVA: 0x00536524 File Offset: 0x00534724
		public static IRandomBatchPoolRefresh GetRootAsIRandomBatchPoolRefresh(ByteBuffer _bb, IRandomBatchPoolRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025CA4 RID: 154788 RVA: 0x00536541 File Offset: 0x00534741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025CA5 RID: 154789 RVA: 0x00536550 File Offset: 0x00534750
		public IRandomBatchPoolRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A802 RID: 43010
		// (get) Token: 0x06025CA6 RID: 154790 RVA: 0x00536560 File Offset: 0x00534760
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

		// Token: 0x06025CA7 RID: 154791 RVA: 0x0053659C File Offset: 0x0053479C
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A803 RID: 43011
		// (get) Token: 0x06025CA8 RID: 154792 RVA: 0x005365FC File Offset: 0x005347FC
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

		// Token: 0x1700A804 RID: 43012
		// (get) Token: 0x06025CA9 RID: 154793 RVA: 0x00536628 File Offset: 0x00534828
		public bool IsRestartAfterAllBatchesFinished
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A805 RID: 43013
		// (get) Token: 0x06025CAA RID: 154794 RVA: 0x00536668 File Offset: 0x00534868
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

		// Token: 0x06025CAB RID: 154795 RVA: 0x005366A5 File Offset: 0x005348A5
		public static Offset<IRandomBatchPoolRefresh> CreateIRandomBatchPoolRefresh(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset), bool IsRestartAfterAllBatchesFinished = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRandomBatchPoolRefresh.AddEntityBatches(builder, EntityBatchesOffset);
			IRandomBatchPoolRefresh.AddNullMask(builder, NullMask);
			IRandomBatchPoolRefresh.AddIsRestartAfterAllBatchesFinished(builder, IsRestartAfterAllBatchesFinished);
			IRandomBatchPoolRefresh.AddType(builder, Type);
			return IRandomBatchPoolRefresh.EndIRandomBatchPoolRefresh(builder);
		}

		// Token: 0x06025CAC RID: 154796 RVA: 0x005366D1 File Offset: 0x005348D1
		public static void StartIRandomBatchPoolRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025CAD RID: 154797 RVA: 0x005366DA File Offset: 0x005348DA
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025CAE RID: 154798 RVA: 0x005366E5 File Offset: 0x005348E5
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x06025CAF RID: 154799 RVA: 0x005366F8 File Offset: 0x005348F8
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025CB0 RID: 154800 RVA: 0x00536738 File Offset: 0x00534938
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CB1 RID: 154801 RVA: 0x00536752 File Offset: 0x00534952
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CB2 RID: 154802 RVA: 0x00536770 File Offset: 0x00534970
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025CB3 RID: 154803 RVA: 0x00536789 File Offset: 0x00534989
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025CB4 RID: 154804 RVA: 0x00536794 File Offset: 0x00534994
		public static void AddIsRestartAfterAllBatchesFinished(FlatBufferBuilder builder, bool isRestartAfterAllBatchesFinished)
		{
			builder.AddBool(2, isRestartAfterAllBatchesFinished, false);
		}

		// Token: 0x06025CB5 RID: 154805 RVA: 0x0053679F File Offset: 0x0053499F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025CB6 RID: 154806 RVA: 0x005367AA File Offset: 0x005349AA
		public static Offset<IRandomBatchPoolRefresh> EndIRandomBatchPoolRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IRandomBatchPoolRefresh>(builder.EndTable());
		}

		// Token: 0x06025CB7 RID: 154807 RVA: 0x005367B8 File Offset: 0x005349B8
		public IRandomBatchPoolRefreshT UnPack()
		{
			IRandomBatchPoolRefreshT randomBatchPoolRefreshT = new IRandomBatchPoolRefreshT();
			this.UnPackTo(randomBatchPoolRefreshT);
			return randomBatchPoolRefreshT;
		}

		// Token: 0x06025CB8 RID: 154808 RVA: 0x005367D4 File Offset: 0x005349D4
		public void UnPackTo(IRandomBatchPoolRefreshT _o)
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

		// Token: 0x06025CB9 RID: 154809 RVA: 0x00536858 File Offset: 0x00534A58
		public static Offset<IRandomBatchPoolRefresh> Pack(FlatBufferBuilder builder, IRandomBatchPoolRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomBatchPoolRefresh>);
			}
			VectorOffset entityBatchesOffset = default(VectorOffset);
			if (_o.EntityBatches != null)
			{
				Offset<IEntityListBatch>[] array = new Offset<IEntityListBatch>[_o.EntityBatches.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityListBatch.Pack(builder, _o.EntityBatches[i]);
				}
				entityBatchesOffset = IRandomBatchPoolRefresh.CreateEntityBatchesVector(builder, array);
			}
			return IRandomBatchPoolRefresh.CreateIRandomBatchPoolRefresh(builder, _o.Type, entityBatchesOffset, _o.IsRestartAfterAllBatchesFinished, _o.NullMask);
		}

		// Token: 0x0400ECCE RID: 60622
		private Table __p;
	}
}
