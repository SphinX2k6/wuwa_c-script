using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE5 RID: 24037
	public struct IRandomBatchPoolRefresh : IFlatbufferObject
	{
		// Token: 0x1700B125 RID: 45349
		// (get) Token: 0x060281C0 RID: 164288 RVA: 0x0057C67D File Offset: 0x0057A87D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060281C1 RID: 164289 RVA: 0x0057C68A File Offset: 0x0057A88A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060281C2 RID: 164290 RVA: 0x0057C694 File Offset: 0x0057A894
		public static IRandomBatchPoolRefresh GetRootAsIRandomBatchPoolRefresh(ByteBuffer _bb)
		{
			return IRandomBatchPoolRefresh.GetRootAsIRandomBatchPoolRefresh(_bb, default(IRandomBatchPoolRefresh));
		}

		// Token: 0x060281C3 RID: 164291 RVA: 0x0057C6B0 File Offset: 0x0057A8B0
		public static IRandomBatchPoolRefresh GetRootAsIRandomBatchPoolRefresh(ByteBuffer _bb, IRandomBatchPoolRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060281C4 RID: 164292 RVA: 0x0057C6CD File Offset: 0x0057A8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060281C5 RID: 164293 RVA: 0x0057C6DC File Offset: 0x0057A8DC
		public IRandomBatchPoolRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B126 RID: 45350
		// (get) Token: 0x060281C6 RID: 164294 RVA: 0x0057C6EC File Offset: 0x0057A8EC
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

		// Token: 0x060281C7 RID: 164295 RVA: 0x0057C728 File Offset: 0x0057A928
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B127 RID: 45351
		// (get) Token: 0x060281C8 RID: 164296 RVA: 0x0057C788 File Offset: 0x0057A988
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

		// Token: 0x1700B128 RID: 45352
		// (get) Token: 0x060281C9 RID: 164297 RVA: 0x0057C7B4 File Offset: 0x0057A9B4
		public bool IsRestartAfterAllBatchesFinished
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B129 RID: 45353
		// (get) Token: 0x060281CA RID: 164298 RVA: 0x0057C7F4 File Offset: 0x0057A9F4
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

		// Token: 0x060281CB RID: 164299 RVA: 0x0057C831 File Offset: 0x0057AA31
		public static Offset<IRandomBatchPoolRefresh> CreateIRandomBatchPoolRefresh(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset), bool IsRestartAfterAllBatchesFinished = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRandomBatchPoolRefresh.AddEntityBatches(builder, EntityBatchesOffset);
			IRandomBatchPoolRefresh.AddNullMask(builder, NullMask);
			IRandomBatchPoolRefresh.AddIsRestartAfterAllBatchesFinished(builder, IsRestartAfterAllBatchesFinished);
			IRandomBatchPoolRefresh.AddType(builder, Type);
			return IRandomBatchPoolRefresh.EndIRandomBatchPoolRefresh(builder);
		}

		// Token: 0x060281CC RID: 164300 RVA: 0x0057C85D File Offset: 0x0057AA5D
		public static void StartIRandomBatchPoolRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060281CD RID: 164301 RVA: 0x0057C866 File Offset: 0x0057AA66
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060281CE RID: 164302 RVA: 0x0057C871 File Offset: 0x0057AA71
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x060281CF RID: 164303 RVA: 0x0057C884 File Offset: 0x0057AA84
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060281D0 RID: 164304 RVA: 0x0057C8C4 File Offset: 0x0057AAC4
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281D1 RID: 164305 RVA: 0x0057C8DE File Offset: 0x0057AADE
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281D2 RID: 164306 RVA: 0x0057C8FC File Offset: 0x0057AAFC
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060281D3 RID: 164307 RVA: 0x0057C915 File Offset: 0x0057AB15
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060281D4 RID: 164308 RVA: 0x0057C920 File Offset: 0x0057AB20
		public static void AddIsRestartAfterAllBatchesFinished(FlatBufferBuilder builder, bool isRestartAfterAllBatchesFinished)
		{
			builder.AddBool(2, isRestartAfterAllBatchesFinished, false);
		}

		// Token: 0x060281D5 RID: 164309 RVA: 0x0057C92B File Offset: 0x0057AB2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060281D6 RID: 164310 RVA: 0x0057C936 File Offset: 0x0057AB36
		public static Offset<IRandomBatchPoolRefresh> EndIRandomBatchPoolRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IRandomBatchPoolRefresh>(builder.EndTable());
		}

		// Token: 0x060281D7 RID: 164311 RVA: 0x0057C944 File Offset: 0x0057AB44
		public IRandomBatchPoolRefreshT UnPack()
		{
			IRandomBatchPoolRefreshT randomBatchPoolRefreshT = new IRandomBatchPoolRefreshT();
			this.UnPackTo(randomBatchPoolRefreshT);
			return randomBatchPoolRefreshT;
		}

		// Token: 0x060281D8 RID: 164312 RVA: 0x0057C960 File Offset: 0x0057AB60
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

		// Token: 0x060281D9 RID: 164313 RVA: 0x0057C9E4 File Offset: 0x0057ABE4
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

		// Token: 0x0400F9B9 RID: 63929
		private Table __p;
	}
}
