using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004796 RID: 18326
	public struct IEntityBundlesState : IFlatbufferObject
	{
		// Token: 0x1700837F RID: 33663
		// (get) Token: 0x0601C3D9 RID: 115673 RVA: 0x003FF9E2 File Offset: 0x003FDBE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C3DA RID: 115674 RVA: 0x003FF9EF File Offset: 0x003FDBEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C3DB RID: 115675 RVA: 0x003FF9F8 File Offset: 0x003FDBF8
		public static IEntityBundlesState GetRootAsIEntityBundlesState(ByteBuffer _bb)
		{
			return IEntityBundlesState.GetRootAsIEntityBundlesState(_bb, default(IEntityBundlesState));
		}

		// Token: 0x0601C3DC RID: 115676 RVA: 0x003FFA14 File Offset: 0x003FDC14
		public static IEntityBundlesState GetRootAsIEntityBundlesState(ByteBuffer _bb, IEntityBundlesState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C3DD RID: 115677 RVA: 0x003FFA31 File Offset: 0x003FDC31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C3DE RID: 115678 RVA: 0x003FFA40 File Offset: 0x003FDC40
		public IEntityBundlesState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C3DF RID: 115679 RVA: 0x003FFA50 File Offset: 0x003FDC50
		public IEntityState? Entities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008380 RID: 33664
		// (get) Token: 0x0601C3E0 RID: 115680 RVA: 0x003FFAB0 File Offset: 0x003FDCB0
		public int EntitiesLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008381 RID: 33665
		// (get) Token: 0x0601C3E1 RID: 115681 RVA: 0x003FFADC File Offset: 0x003FDCDC
		public int BundleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008382 RID: 33666
		// (get) Token: 0x0601C3E2 RID: 115682 RVA: 0x003FFB18 File Offset: 0x003FDD18
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C3E3 RID: 115683 RVA: 0x003FFB54 File Offset: 0x003FDD54
		public static Offset<IEntityBundlesState> CreateIEntityBundlesState(FlatBufferBuilder builder, VectorOffset EntitiesOffset = default(VectorOffset), int BundleId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntityBundlesState.AddBundleId(builder, BundleId);
			IEntityBundlesState.AddEntities(builder, EntitiesOffset);
			IEntityBundlesState.AddNullMask(builder, NullMask);
			return IEntityBundlesState.EndIEntityBundlesState(builder);
		}

		// Token: 0x0601C3E4 RID: 115684 RVA: 0x003FFB78 File Offset: 0x003FDD78
		public static void StartIEntityBundlesState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C3E5 RID: 115685 RVA: 0x003FFB81 File Offset: 0x003FDD81
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(0, entitiesOffset.Value, 0);
		}

		// Token: 0x0601C3E6 RID: 115686 RVA: 0x003FFB94 File Offset: 0x003FDD94
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C3E7 RID: 115687 RVA: 0x003FFBD4 File Offset: 0x003FDDD4
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3E8 RID: 115688 RVA: 0x003FFBEE File Offset: 0x003FDDEE
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3E9 RID: 115689 RVA: 0x003FFC0C File Offset: 0x003FDE0C
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C3EA RID: 115690 RVA: 0x003FFC25 File Offset: 0x003FDE25
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C3EB RID: 115691 RVA: 0x003FFC30 File Offset: 0x003FDE30
		public static void AddBundleId(FlatBufferBuilder builder, int bundleId)
		{
			builder.AddInt(1, bundleId, 0);
		}

		// Token: 0x0601C3EC RID: 115692 RVA: 0x003FFC3B File Offset: 0x003FDE3B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C3ED RID: 115693 RVA: 0x003FFC46 File Offset: 0x003FDE46
		public static Offset<IEntityBundlesState> EndIEntityBundlesState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBundlesState>(builder.EndTable());
		}

		// Token: 0x0601C3EE RID: 115694 RVA: 0x003FFC54 File Offset: 0x003FDE54
		public IEntityBundlesStateT UnPack()
		{
			IEntityBundlesStateT entityBundlesStateT = new IEntityBundlesStateT();
			this.UnPackTo(entityBundlesStateT);
			return entityBundlesStateT;
		}

		// Token: 0x0601C3EF RID: 115695 RVA: 0x003FFC70 File Offset: 0x003FDE70
		public void UnPackTo(IEntityBundlesStateT _o)
		{
			_o.Entities = new List<IEntityStateT>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add((this.Entities(i) != null) ? this.Entities(i).Value.UnPack() : null);
			}
			_o.BundleId = this.BundleId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C3F0 RID: 115696 RVA: 0x003FFCE8 File Offset: 0x003FDEE8
		public static Offset<IEntityBundlesState> Pack(FlatBufferBuilder builder, IEntityBundlesStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBundlesState>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				Offset<IEntityState>[] array = new Offset<IEntityState>[_o.Entities.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityState.Pack(builder, _o.Entities[i]);
				}
				entitiesOffset = IEntityBundlesState.CreateEntitiesVector(builder, array);
			}
			return IEntityBundlesState.CreateIEntityBundlesState(builder, entitiesOffset, _o.BundleId, _o.NullMask);
		}

		// Token: 0x0400CC05 RID: 52229
		private Table __p;
	}
}
