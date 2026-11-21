using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F07 RID: 24327
	public struct ISequenceBatchRefresh : IFlatbufferObject
	{
		// Token: 0x1700B3EB RID: 46059
		// (get) Token: 0x06028D2E RID: 167214 RVA: 0x0059451A File Offset: 0x0059271A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D2F RID: 167215 RVA: 0x00594527 File Offset: 0x00592727
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D30 RID: 167216 RVA: 0x00594530 File Offset: 0x00592730
		public static ISequenceBatchRefresh GetRootAsISequenceBatchRefresh(ByteBuffer _bb)
		{
			return ISequenceBatchRefresh.GetRootAsISequenceBatchRefresh(_bb, default(ISequenceBatchRefresh));
		}

		// Token: 0x06028D31 RID: 167217 RVA: 0x0059454C File Offset: 0x0059274C
		public static ISequenceBatchRefresh GetRootAsISequenceBatchRefresh(ByteBuffer _bb, ISequenceBatchRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D32 RID: 167218 RVA: 0x00594569 File Offset: 0x00592769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D33 RID: 167219 RVA: 0x00594578 File Offset: 0x00592778
		public ISequenceBatchRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3EC RID: 46060
		// (get) Token: 0x06028D34 RID: 167220 RVA: 0x00594588 File Offset: 0x00592788
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

		// Token: 0x06028D35 RID: 167221 RVA: 0x005945C4 File Offset: 0x005927C4
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B3ED RID: 46061
		// (get) Token: 0x06028D36 RID: 167222 RVA: 0x00594624 File Offset: 0x00592824
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

		// Token: 0x1700B3EE RID: 46062
		// (get) Token: 0x06028D37 RID: 167223 RVA: 0x00594650 File Offset: 0x00592850
		public bool IsRestartAfterAllBatchesFinished
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B3EF RID: 46063
		// (get) Token: 0x06028D38 RID: 167224 RVA: 0x00594690 File Offset: 0x00592890
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

		// Token: 0x06028D39 RID: 167225 RVA: 0x005946CD File Offset: 0x005928CD
		public static Offset<ISequenceBatchRefresh> CreateISequenceBatchRefresh(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset), bool IsRestartAfterAllBatchesFinished = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISequenceBatchRefresh.AddEntityBatches(builder, EntityBatchesOffset);
			ISequenceBatchRefresh.AddNullMask(builder, NullMask);
			ISequenceBatchRefresh.AddIsRestartAfterAllBatchesFinished(builder, IsRestartAfterAllBatchesFinished);
			ISequenceBatchRefresh.AddType(builder, Type);
			return ISequenceBatchRefresh.EndISequenceBatchRefresh(builder);
		}

		// Token: 0x06028D3A RID: 167226 RVA: 0x005946F9 File Offset: 0x005928F9
		public static void StartISequenceBatchRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028D3B RID: 167227 RVA: 0x00594702 File Offset: 0x00592902
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028D3C RID: 167228 RVA: 0x0059470D File Offset: 0x0059290D
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x06028D3D RID: 167229 RVA: 0x00594720 File Offset: 0x00592920
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028D3E RID: 167230 RVA: 0x00594760 File Offset: 0x00592960
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D3F RID: 167231 RVA: 0x0059477A File Offset: 0x0059297A
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D40 RID: 167232 RVA: 0x00594798 File Offset: 0x00592998
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028D41 RID: 167233 RVA: 0x005947B1 File Offset: 0x005929B1
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028D42 RID: 167234 RVA: 0x005947BC File Offset: 0x005929BC
		public static void AddIsRestartAfterAllBatchesFinished(FlatBufferBuilder builder, bool isRestartAfterAllBatchesFinished)
		{
			builder.AddBool(2, isRestartAfterAllBatchesFinished, false);
		}

		// Token: 0x06028D43 RID: 167235 RVA: 0x005947C7 File Offset: 0x005929C7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028D44 RID: 167236 RVA: 0x005947D2 File Offset: 0x005929D2
		public static Offset<ISequenceBatchRefresh> EndISequenceBatchRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceBatchRefresh>(builder.EndTable());
		}

		// Token: 0x06028D45 RID: 167237 RVA: 0x005947E0 File Offset: 0x005929E0
		public ISequenceBatchRefreshT UnPack()
		{
			ISequenceBatchRefreshT sequenceBatchRefreshT = new ISequenceBatchRefreshT();
			this.UnPackTo(sequenceBatchRefreshT);
			return sequenceBatchRefreshT;
		}

		// Token: 0x06028D46 RID: 167238 RVA: 0x005947FC File Offset: 0x005929FC
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

		// Token: 0x06028D47 RID: 167239 RVA: 0x00594880 File Offset: 0x00592A80
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

		// Token: 0x0400FB8C RID: 64396
		private Table __p;
	}
}
