using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B8 RID: 30136
	public struct IRemoveBuffFromEntity : IFlatbufferObject
	{
		// Token: 0x1700DD92 RID: 56722
		// (get) Token: 0x06034DCA RID: 216522 RVA: 0x0071AF39 File Offset: 0x00719139
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034DCB RID: 216523 RVA: 0x0071AF46 File Offset: 0x00719146
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034DCC RID: 216524 RVA: 0x0071AF50 File Offset: 0x00719150
		public static IRemoveBuffFromEntity GetRootAsIRemoveBuffFromEntity(ByteBuffer _bb)
		{
			return IRemoveBuffFromEntity.GetRootAsIRemoveBuffFromEntity(_bb, default(IRemoveBuffFromEntity));
		}

		// Token: 0x06034DCD RID: 216525 RVA: 0x0071AF6C File Offset: 0x0071916C
		public static IRemoveBuffFromEntity GetRootAsIRemoveBuffFromEntity(ByteBuffer _bb, IRemoveBuffFromEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034DCE RID: 216526 RVA: 0x0071AF89 File Offset: 0x00719189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034DCF RID: 216527 RVA: 0x0071AF98 File Offset: 0x00719198
		public IRemoveBuffFromEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD93 RID: 56723
		// (get) Token: 0x06034DD0 RID: 216528 RVA: 0x0071AFA8 File Offset: 0x007191A8
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

		// Token: 0x06034DD1 RID: 216529 RVA: 0x0071AFE4 File Offset: 0x007191E4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DD94 RID: 56724
		// (get) Token: 0x06034DD2 RID: 216530 RVA: 0x0071B024 File Offset: 0x00719224
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

		// Token: 0x06034DD3 RID: 216531 RVA: 0x0071B04F File Offset: 0x0071924F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06034DD4 RID: 216532 RVA: 0x0071B05E File Offset: 0x0071925E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06034DD5 RID: 216533 RVA: 0x0071B06C File Offset: 0x0071926C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700DD95 RID: 56725
		// (get) Token: 0x06034DD6 RID: 216534 RVA: 0x0071B0AC File Offset: 0x007192AC
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

		// Token: 0x06034DD7 RID: 216535 RVA: 0x0071B0D7 File Offset: 0x007192D7
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x06034DD8 RID: 216536 RVA: 0x0071B0E6 File Offset: 0x007192E6
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(8);
		}

		// Token: 0x1700DD96 RID: 56726
		// (get) Token: 0x06034DD9 RID: 216537 RVA: 0x0071B0F4 File Offset: 0x007192F4
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

		// Token: 0x06034DDA RID: 216538 RVA: 0x0071B131 File Offset: 0x00719331
		public static Offset<IRemoveBuffFromEntity> CreateIRemoveBuffFromEntity(FlatBufferBuilder builder, int EntityId = 0, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset BuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IRemoveBuffFromEntity.AddBuffIds(builder, BuffIdsOffset);
			IRemoveBuffFromEntity.AddEntityIds(builder, EntityIdsOffset);
			IRemoveBuffFromEntity.AddEntityId(builder, EntityId);
			IRemoveBuffFromEntity.AddNullMask(builder, NullMask);
			return IRemoveBuffFromEntity.EndIRemoveBuffFromEntity(builder);
		}

		// Token: 0x06034DDB RID: 216539 RVA: 0x0071B15D File Offset: 0x0071935D
		public static void StartIRemoveBuffFromEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034DDC RID: 216540 RVA: 0x0071B166 File Offset: 0x00719366
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06034DDD RID: 216541 RVA: 0x0071B171 File Offset: 0x00719371
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06034DDE RID: 216542 RVA: 0x0071B184 File Offset: 0x00719384
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DDF RID: 216543 RVA: 0x0071B1BB File Offset: 0x007193BB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DE0 RID: 216544 RVA: 0x0071B1D5 File Offset: 0x007193D5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DE1 RID: 216545 RVA: 0x0071B1F3 File Offset: 0x007193F3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DE2 RID: 216546 RVA: 0x0071B20C File Offset: 0x0071940C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DE3 RID: 216547 RVA: 0x0071B217 File Offset: 0x00719417
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(2, buffIdsOffset.Value, 0);
		}

		// Token: 0x06034DE4 RID: 216548 RVA: 0x0071B228 File Offset: 0x00719428
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DE5 RID: 216549 RVA: 0x0071B25F File Offset: 0x0071945F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DE6 RID: 216550 RVA: 0x0071B279 File Offset: 0x00719479
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DE7 RID: 216551 RVA: 0x0071B297 File Offset: 0x00719497
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DE8 RID: 216552 RVA: 0x0071B2B0 File Offset: 0x007194B0
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06034DE9 RID: 216553 RVA: 0x0071B2BB File Offset: 0x007194BB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06034DEA RID: 216554 RVA: 0x0071B2C6 File Offset: 0x007194C6
		public static Offset<IRemoveBuffFromEntity> EndIRemoveBuffFromEntity(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveBuffFromEntity>(builder.EndTable());
		}

		// Token: 0x06034DEB RID: 216555 RVA: 0x0071B2D4 File Offset: 0x007194D4
		public IRemoveBuffFromEntityT UnPack()
		{
			IRemoveBuffFromEntityT removeBuffFromEntityT = new IRemoveBuffFromEntityT();
			this.UnPackTo(removeBuffFromEntityT);
			return removeBuffFromEntityT;
		}

		// Token: 0x06034DEC RID: 216556 RVA: 0x0071B2F0 File Offset: 0x007194F0
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

		// Token: 0x06034DED RID: 216557 RVA: 0x0071B374 File Offset: 0x00719574
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

		// Token: 0x0401279E RID: 75678
		private Table __p;
	}
}
