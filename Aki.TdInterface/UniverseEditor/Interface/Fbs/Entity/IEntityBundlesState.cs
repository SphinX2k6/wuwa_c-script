using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BFE RID: 19454
	public struct IEntityBundlesState : IFlatbufferObject
	{
		// Token: 0x170089C0 RID: 35264
		// (get) Token: 0x0601DBAE RID: 121774 RVA: 0x0042BC7E File Offset: 0x00429E7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DBAF RID: 121775 RVA: 0x0042BC8B File Offset: 0x00429E8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DBB0 RID: 121776 RVA: 0x0042BC94 File Offset: 0x00429E94
		public static IEntityBundlesState GetRootAsIEntityBundlesState(ByteBuffer _bb)
		{
			return IEntityBundlesState.GetRootAsIEntityBundlesState(_bb, default(IEntityBundlesState));
		}

		// Token: 0x0601DBB1 RID: 121777 RVA: 0x0042BCB0 File Offset: 0x00429EB0
		public static IEntityBundlesState GetRootAsIEntityBundlesState(ByteBuffer _bb, IEntityBundlesState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DBB2 RID: 121778 RVA: 0x0042BCCD File Offset: 0x00429ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DBB3 RID: 121779 RVA: 0x0042BCDC File Offset: 0x00429EDC
		public IEntityBundlesState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DBB4 RID: 121780 RVA: 0x0042BCEC File Offset: 0x00429EEC
		public IEntityState? Entities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170089C1 RID: 35265
		// (get) Token: 0x0601DBB5 RID: 121781 RVA: 0x0042BD4C File Offset: 0x00429F4C
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

		// Token: 0x170089C2 RID: 35266
		// (get) Token: 0x0601DBB6 RID: 121782 RVA: 0x0042BD78 File Offset: 0x00429F78
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

		// Token: 0x170089C3 RID: 35267
		// (get) Token: 0x0601DBB7 RID: 121783 RVA: 0x0042BDB4 File Offset: 0x00429FB4
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

		// Token: 0x0601DBB8 RID: 121784 RVA: 0x0042BDF0 File Offset: 0x00429FF0
		public static Offset<IEntityBundlesState> CreateIEntityBundlesState(FlatBufferBuilder builder, VectorOffset EntitiesOffset = default(VectorOffset), int BundleId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntityBundlesState.AddBundleId(builder, BundleId);
			IEntityBundlesState.AddEntities(builder, EntitiesOffset);
			IEntityBundlesState.AddNullMask(builder, NullMask);
			return IEntityBundlesState.EndIEntityBundlesState(builder);
		}

		// Token: 0x0601DBB9 RID: 121785 RVA: 0x0042BE14 File Offset: 0x0042A014
		public static void StartIEntityBundlesState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DBBA RID: 121786 RVA: 0x0042BE1D File Offset: 0x0042A01D
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(0, entitiesOffset.Value, 0);
		}

		// Token: 0x0601DBBB RID: 121787 RVA: 0x0042BE30 File Offset: 0x0042A030
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DBBC RID: 121788 RVA: 0x0042BE70 File Offset: 0x0042A070
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DBBD RID: 121789 RVA: 0x0042BE8A File Offset: 0x0042A08A
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DBBE RID: 121790 RVA: 0x0042BEA8 File Offset: 0x0042A0A8
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DBBF RID: 121791 RVA: 0x0042BEC1 File Offset: 0x0042A0C1
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DBC0 RID: 121792 RVA: 0x0042BECC File Offset: 0x0042A0CC
		public static void AddBundleId(FlatBufferBuilder builder, int bundleId)
		{
			builder.AddInt(1, bundleId, 0);
		}

		// Token: 0x0601DBC1 RID: 121793 RVA: 0x0042BED7 File Offset: 0x0042A0D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601DBC2 RID: 121794 RVA: 0x0042BEE2 File Offset: 0x0042A0E2
		public static Offset<IEntityBundlesState> EndIEntityBundlesState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBundlesState>(builder.EndTable());
		}

		// Token: 0x0601DBC3 RID: 121795 RVA: 0x0042BEF0 File Offset: 0x0042A0F0
		public IEntityBundlesStateT UnPack()
		{
			IEntityBundlesStateT entityBundlesStateT = new IEntityBundlesStateT();
			this.UnPackTo(entityBundlesStateT);
			return entityBundlesStateT;
		}

		// Token: 0x0601DBC4 RID: 121796 RVA: 0x0042BF0C File Offset: 0x0042A10C
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

		// Token: 0x0601DBC5 RID: 121797 RVA: 0x0042BF84 File Offset: 0x0042A184
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

		// Token: 0x0400D63B RID: 54843
		private Table __p;
	}
}
