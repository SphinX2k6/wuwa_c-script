using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE8 RID: 24040
	public struct IRandomBatchRefresh : IFlatbufferObject
	{
		// Token: 0x1700B12E RID: 45358
		// (get) Token: 0x060281E4 RID: 164324 RVA: 0x0057CB43 File Offset: 0x0057AD43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060281E5 RID: 164325 RVA: 0x0057CB50 File Offset: 0x0057AD50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060281E6 RID: 164326 RVA: 0x0057CB58 File Offset: 0x0057AD58
		public static IRandomBatchRefresh GetRootAsIRandomBatchRefresh(ByteBuffer _bb)
		{
			return IRandomBatchRefresh.GetRootAsIRandomBatchRefresh(_bb, default(IRandomBatchRefresh));
		}

		// Token: 0x060281E7 RID: 164327 RVA: 0x0057CB74 File Offset: 0x0057AD74
		public static IRandomBatchRefresh GetRootAsIRandomBatchRefresh(ByteBuffer _bb, IRandomBatchRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060281E8 RID: 164328 RVA: 0x0057CB91 File Offset: 0x0057AD91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060281E9 RID: 164329 RVA: 0x0057CBA0 File Offset: 0x0057ADA0
		public IRandomBatchRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B12F RID: 45359
		// (get) Token: 0x060281EA RID: 164330 RVA: 0x0057CBB0 File Offset: 0x0057ADB0
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

		// Token: 0x060281EB RID: 164331 RVA: 0x0057CBEC File Offset: 0x0057ADEC
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B130 RID: 45360
		// (get) Token: 0x060281EC RID: 164332 RVA: 0x0057CC4C File Offset: 0x0057AE4C
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

		// Token: 0x060281ED RID: 164333 RVA: 0x0057CC77 File Offset: 0x0057AE77
		public static Offset<IRandomBatchRefresh> CreateIRandomBatchRefresh(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomBatchRefresh.AddEntityBatches(builder, EntityBatchesOffset);
			IRandomBatchRefresh.AddType(builder, Type);
			return IRandomBatchRefresh.EndIRandomBatchRefresh(builder);
		}

		// Token: 0x060281EE RID: 164334 RVA: 0x0057CC94 File Offset: 0x0057AE94
		public static void StartIRandomBatchRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060281EF RID: 164335 RVA: 0x0057CC9D File Offset: 0x0057AE9D
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060281F0 RID: 164336 RVA: 0x0057CCA8 File Offset: 0x0057AEA8
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x060281F1 RID: 164337 RVA: 0x0057CCB8 File Offset: 0x0057AEB8
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060281F2 RID: 164338 RVA: 0x0057CCF8 File Offset: 0x0057AEF8
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281F3 RID: 164339 RVA: 0x0057CD12 File Offset: 0x0057AF12
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281F4 RID: 164340 RVA: 0x0057CD30 File Offset: 0x0057AF30
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060281F5 RID: 164341 RVA: 0x0057CD49 File Offset: 0x0057AF49
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060281F6 RID: 164342 RVA: 0x0057CD54 File Offset: 0x0057AF54
		public static Offset<IRandomBatchRefresh> EndIRandomBatchRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IRandomBatchRefresh>(builder.EndTable());
		}

		// Token: 0x060281F7 RID: 164343 RVA: 0x0057CD64 File Offset: 0x0057AF64
		public IRandomBatchRefreshT UnPack()
		{
			IRandomBatchRefreshT randomBatchRefreshT = new IRandomBatchRefreshT();
			this.UnPackTo(randomBatchRefreshT);
			return randomBatchRefreshT;
		}

		// Token: 0x060281F8 RID: 164344 RVA: 0x0057CD80 File Offset: 0x0057AF80
		public void UnPackTo(IRandomBatchRefreshT _o)
		{
			_o.Type = this.Type;
			_o.EntityBatches = new List<IEntityListBatchT>();
			for (int i = 0; i < this.EntityBatchesLength; i++)
			{
				_o.EntityBatches.Add((this.EntityBatches(i) != null) ? this.EntityBatches(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060281F9 RID: 164345 RVA: 0x0057CDEC File Offset: 0x0057AFEC
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

		// Token: 0x0400F9BE RID: 63934
		private Table __p;
	}
}
