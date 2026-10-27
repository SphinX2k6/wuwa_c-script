using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3A RID: 28218
	public struct IRemoveBuffFromEntity : IFlatbufferObject
	{
		// Token: 0x1700D243 RID: 53827
		// (get) Token: 0x06031DB4 RID: 204212 RVA: 0x006BF5B1 File Offset: 0x006BD7B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031DB5 RID: 204213 RVA: 0x006BF5BE File Offset: 0x006BD7BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031DB6 RID: 204214 RVA: 0x006BF5C8 File Offset: 0x006BD7C8
		public static IRemoveBuffFromEntity GetRootAsIRemoveBuffFromEntity(ByteBuffer _bb)
		{
			return IRemoveBuffFromEntity.GetRootAsIRemoveBuffFromEntity(_bb, default(IRemoveBuffFromEntity));
		}

		// Token: 0x06031DB7 RID: 204215 RVA: 0x006BF5E4 File Offset: 0x006BD7E4
		public static IRemoveBuffFromEntity GetRootAsIRemoveBuffFromEntity(ByteBuffer _bb, IRemoveBuffFromEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031DB8 RID: 204216 RVA: 0x006BF601 File Offset: 0x006BD801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031DB9 RID: 204217 RVA: 0x006BF610 File Offset: 0x006BD810
		public IRemoveBuffFromEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D244 RID: 53828
		// (get) Token: 0x06031DBA RID: 204218 RVA: 0x006BF620 File Offset: 0x006BD820
		public int EntityId
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

		// Token: 0x06031DBB RID: 204219 RVA: 0x006BF65C File Offset: 0x006BD85C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D245 RID: 53829
		// (get) Token: 0x06031DBC RID: 204220 RVA: 0x006BF69C File Offset: 0x006BD89C
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

		// Token: 0x06031DBD RID: 204221 RVA: 0x006BF6C7 File Offset: 0x006BD8C7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031DBE RID: 204222 RVA: 0x006BF6D6 File Offset: 0x006BD8D6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06031DBF RID: 204223 RVA: 0x006BF6E4 File Offset: 0x006BD8E4
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700D246 RID: 53830
		// (get) Token: 0x06031DC0 RID: 204224 RVA: 0x006BF724 File Offset: 0x006BD924
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06031DC1 RID: 204225 RVA: 0x006BF74F File Offset: 0x006BD94F
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x06031DC2 RID: 204226 RVA: 0x006BF75E File Offset: 0x006BD95E
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(8);
		}

		// Token: 0x1700D247 RID: 53831
		// (get) Token: 0x06031DC3 RID: 204227 RVA: 0x006BF76C File Offset: 0x006BD96C
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

		// Token: 0x06031DC4 RID: 204228 RVA: 0x006BF7A9 File Offset: 0x006BD9A9
		public static Offset<IRemoveBuffFromEntity> CreateIRemoveBuffFromEntity(FlatBufferBuilder builder, int EntityId = 0, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset BuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IRemoveBuffFromEntity.AddBuffIds(builder, BuffIdsOffset);
			IRemoveBuffFromEntity.AddEntityIds(builder, EntityIdsOffset);
			IRemoveBuffFromEntity.AddEntityId(builder, EntityId);
			IRemoveBuffFromEntity.AddNullMask(builder, NullMask);
			return IRemoveBuffFromEntity.EndIRemoveBuffFromEntity(builder);
		}

		// Token: 0x06031DC5 RID: 204229 RVA: 0x006BF7D5 File Offset: 0x006BD9D5
		public static void StartIRemoveBuffFromEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031DC6 RID: 204230 RVA: 0x006BF7DE File Offset: 0x006BD9DE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06031DC7 RID: 204231 RVA: 0x006BF7E9 File Offset: 0x006BD9E9
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06031DC8 RID: 204232 RVA: 0x006BF7FC File Offset: 0x006BD9FC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031DC9 RID: 204233 RVA: 0x006BF833 File Offset: 0x006BDA33
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031DCA RID: 204234 RVA: 0x006BF84D File Offset: 0x006BDA4D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031DCB RID: 204235 RVA: 0x006BF86B File Offset: 0x006BDA6B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031DCC RID: 204236 RVA: 0x006BF884 File Offset: 0x006BDA84
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031DCD RID: 204237 RVA: 0x006BF88F File Offset: 0x006BDA8F
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(2, buffIdsOffset.Value, 0);
		}

		// Token: 0x06031DCE RID: 204238 RVA: 0x006BF8A0 File Offset: 0x006BDAA0
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031DCF RID: 204239 RVA: 0x006BF8D7 File Offset: 0x006BDAD7
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06031DD0 RID: 204240 RVA: 0x006BF8F1 File Offset: 0x006BDAF1
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06031DD1 RID: 204241 RVA: 0x006BF90F File Offset: 0x006BDB0F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031DD2 RID: 204242 RVA: 0x006BF928 File Offset: 0x006BDB28
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06031DD3 RID: 204243 RVA: 0x006BF933 File Offset: 0x006BDB33
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031DD4 RID: 204244 RVA: 0x006BF93E File Offset: 0x006BDB3E
		public static Offset<IRemoveBuffFromEntity> EndIRemoveBuffFromEntity(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveBuffFromEntity>(builder.EndTable());
		}

		// Token: 0x06031DD5 RID: 204245 RVA: 0x006BF94C File Offset: 0x006BDB4C
		public IRemoveBuffFromEntityT UnPack()
		{
			IRemoveBuffFromEntityT removeBuffFromEntityT = new IRemoveBuffFromEntityT();
			this.UnPackTo(removeBuffFromEntityT);
			return removeBuffFromEntityT;
		}

		// Token: 0x06031DD6 RID: 204246 RVA: 0x006BF968 File Offset: 0x006BDB68
		public void UnPackTo(IRemoveBuffFromEntityT _o)
		{
			_o.EntityId = this.EntityId;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.BuffIds = new List<long>();
			for (int j = 0; j < this.BuffIdsLength; j++)
			{
				_o.BuffIds.Add(this.BuffIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031DD7 RID: 204247 RVA: 0x006BF9EC File Offset: 0x006BDBEC
		public static Offset<IRemoveBuffFromEntity> Pack(FlatBufferBuilder builder, IRemoveBuffFromEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveBuffFromEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IRemoveBuffFromEntity.CreateEntityIdsVector(builder, data);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data2 = _o.BuffIds.ToArray();
				buffIdsOffset = IRemoveBuffFromEntity.CreateBuffIdsVector(builder, data2);
			}
			return IRemoveBuffFromEntity.CreateIRemoveBuffFromEntity(builder, _o.EntityId, entityIdsOffset, buffIdsOffset, _o.NullMask);
		}

		// Token: 0x0401181E RID: 71710
		private Table __p;
	}
}
