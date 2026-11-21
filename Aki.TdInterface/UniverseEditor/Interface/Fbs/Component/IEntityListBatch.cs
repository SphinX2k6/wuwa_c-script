using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EE RID: 22254
	public struct IEntityListBatch : IFlatbufferObject
	{
		// Token: 0x1700A06C RID: 41068
		// (get) Token: 0x06023B5D RID: 146269 RVA: 0x004E8DCB File Offset: 0x004E6FCB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B5E RID: 146270 RVA: 0x004E8DD8 File Offset: 0x004E6FD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B5F RID: 146271 RVA: 0x004E8DE0 File Offset: 0x004E6FE0
		public static IEntityListBatch GetRootAsIEntityListBatch(ByteBuffer _bb)
		{
			return IEntityListBatch.GetRootAsIEntityListBatch(_bb, default(IEntityListBatch));
		}

		// Token: 0x06023B60 RID: 146272 RVA: 0x004E8DFC File Offset: 0x004E6FFC
		public static IEntityListBatch GetRootAsIEntityListBatch(ByteBuffer _bb, IEntityListBatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B61 RID: 146273 RVA: 0x004E8E19 File Offset: 0x004E7019
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B62 RID: 146274 RVA: 0x004E8E28 File Offset: 0x004E7028
		public IEntityListBatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A06D RID: 41069
		// (get) Token: 0x06023B63 RID: 146275 RVA: 0x004E8E38 File Offset: 0x004E7038
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

		// Token: 0x06023B64 RID: 146276 RVA: 0x004E8E74 File Offset: 0x004E7074
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A06E RID: 41070
		// (get) Token: 0x06023B65 RID: 146277 RVA: 0x004E8EB4 File Offset: 0x004E70B4
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

		// Token: 0x06023B66 RID: 146278 RVA: 0x004E8EDF File Offset: 0x004E70DF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06023B67 RID: 146279 RVA: 0x004E8EEE File Offset: 0x004E70EE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06023B68 RID: 146280 RVA: 0x004E8EFC File Offset: 0x004E70FC
		public static Offset<IEntityListBatch> CreateIEntityListBatch(FlatBufferBuilder builder, EEntityBatchType Type = EEntityBatchType.EntityList, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityListBatch.AddEntityIds(builder, EntityIdsOffset);
			IEntityListBatch.AddType(builder, Type);
			return IEntityListBatch.EndIEntityListBatch(builder);
		}

		// Token: 0x06023B69 RID: 146281 RVA: 0x004E8F19 File Offset: 0x004E7119
		public static void StartIEntityListBatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023B6A RID: 146282 RVA: 0x004E8F22 File Offset: 0x004E7122
		public static void AddType(FlatBufferBuilder builder, EEntityBatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023B6B RID: 146283 RVA: 0x004E8F2D File Offset: 0x004E712D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06023B6C RID: 146284 RVA: 0x004E8F40 File Offset: 0x004E7140
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023B6D RID: 146285 RVA: 0x004E8F77 File Offset: 0x004E7177
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B6E RID: 146286 RVA: 0x004E8F91 File Offset: 0x004E7191
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B6F RID: 146287 RVA: 0x004E8FAF File Offset: 0x004E71AF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023B70 RID: 146288 RVA: 0x004E8FC8 File Offset: 0x004E71C8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023B71 RID: 146289 RVA: 0x004E8FD3 File Offset: 0x004E71D3
		public static Offset<IEntityListBatch> EndIEntityListBatch(FlatBufferBuilder builder)
		{
			return new Offset<IEntityListBatch>(builder.EndTable());
		}

		// Token: 0x06023B72 RID: 146290 RVA: 0x004E8FE0 File Offset: 0x004E71E0
		public IEntityListBatchT UnPack()
		{
			IEntityListBatchT entityListBatchT = new IEntityListBatchT();
			this.UnPackTo(entityListBatchT);
			return entityListBatchT;
		}

		// Token: 0x06023B73 RID: 146291 RVA: 0x004E8FFC File Offset: 0x004E71FC
		public void UnPackTo(IEntityListBatchT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06023B74 RID: 146292 RVA: 0x004E9044 File Offset: 0x004E7244
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

		// Token: 0x0400EE5A RID: 61018
		private Table __p;
	}
}
