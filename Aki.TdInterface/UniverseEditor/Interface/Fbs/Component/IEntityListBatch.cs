using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005189 RID: 20873
	public struct IEntityListBatch : IFlatbufferObject
	{
		// Token: 0x1700987D RID: 39037
		// (get) Token: 0x06021C05 RID: 138245 RVA: 0x004AEDAB File Offset: 0x004ACFAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C06 RID: 138246 RVA: 0x004AEDB8 File Offset: 0x004ACFB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C07 RID: 138247 RVA: 0x004AEDC0 File Offset: 0x004ACFC0
		public static IEntityListBatch GetRootAsIEntityListBatch(ByteBuffer _bb)
		{
			return IEntityListBatch.GetRootAsIEntityListBatch(_bb, default(IEntityListBatch));
		}

		// Token: 0x06021C08 RID: 138248 RVA: 0x004AEDDC File Offset: 0x004ACFDC
		public static IEntityListBatch GetRootAsIEntityListBatch(ByteBuffer _bb, IEntityListBatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C09 RID: 138249 RVA: 0x004AEDF9 File Offset: 0x004ACFF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C0A RID: 138250 RVA: 0x004AEE08 File Offset: 0x004AD008
		public IEntityListBatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700987E RID: 39038
		// (get) Token: 0x06021C0B RID: 138251 RVA: 0x004AEE18 File Offset: 0x004AD018
		public EEntityBatchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityBatchType.EntityList;
				}
				return (EEntityBatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021C0C RID: 138252 RVA: 0x004AEE54 File Offset: 0x004AD054
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700987F RID: 39039
		// (get) Token: 0x06021C0D RID: 138253 RVA: 0x004AEE94 File Offset: 0x004AD094
		public int EntityIdsLength
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

		// Token: 0x06021C0E RID: 138254 RVA: 0x004AEEBF File Offset: 0x004AD0BF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06021C0F RID: 138255 RVA: 0x004AEECE File Offset: 0x004AD0CE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06021C10 RID: 138256 RVA: 0x004AEEDC File Offset: 0x004AD0DC
		public static Offset<IEntityListBatch> CreateIEntityListBatch(FlatBufferBuilder builder, EEntityBatchType Type = EEntityBatchType.EntityList, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityListBatch.AddEntityIds(builder, EntityIdsOffset);
			IEntityListBatch.AddType(builder, Type);
			return IEntityListBatch.EndIEntityListBatch(builder);
		}

		// Token: 0x06021C11 RID: 138257 RVA: 0x004AEEF9 File Offset: 0x004AD0F9
		public static void StartIEntityListBatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021C12 RID: 138258 RVA: 0x004AEF02 File Offset: 0x004AD102
		public static void AddType(FlatBufferBuilder builder, EEntityBatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021C13 RID: 138259 RVA: 0x004AEF0D File Offset: 0x004AD10D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06021C14 RID: 138260 RVA: 0x004AEF20 File Offset: 0x004AD120
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C15 RID: 138261 RVA: 0x004AEF57 File Offset: 0x004AD157
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C16 RID: 138262 RVA: 0x004AEF71 File Offset: 0x004AD171
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C17 RID: 138263 RVA: 0x004AEF8F File Offset: 0x004AD18F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C18 RID: 138264 RVA: 0x004AEFA8 File Offset: 0x004AD1A8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C19 RID: 138265 RVA: 0x004AEFB3 File Offset: 0x004AD1B3
		public static Offset<IEntityListBatch> EndIEntityListBatch(FlatBufferBuilder builder)
		{
			return new Offset<IEntityListBatch>(builder.EndTable());
		}

		// Token: 0x06021C1A RID: 138266 RVA: 0x004AEFC0 File Offset: 0x004AD1C0
		public IEntityListBatchT UnPack()
		{
			IEntityListBatchT entityListBatchT = new IEntityListBatchT();
			this.UnPackTo(entityListBatchT);
			return entityListBatchT;
		}

		// Token: 0x06021C1B RID: 138267 RVA: 0x004AEFDC File Offset: 0x004AD1DC
		public void UnPackTo(IEntityListBatchT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06021C1C RID: 138268 RVA: 0x004AF024 File Offset: 0x004AD224
		public static Offset<IEntityListBatch> Pack(FlatBufferBuilder builder, IEntityListBatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityListBatch>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEntityListBatch.CreateEntityIdsVector(builder, data);
			}
			return IEntityListBatch.CreateIEntityListBatch(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400E25C RID: 57948
		private Table __p;
	}
}
