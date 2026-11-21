using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C13 RID: 19475
	public struct IEntityList : IFlatbufferObject
	{
		// Token: 0x17008A05 RID: 35333
		// (get) Token: 0x0601DCC6 RID: 122054 RVA: 0x0042E0A0 File Offset: 0x0042C2A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCC7 RID: 122055 RVA: 0x0042E0AD File Offset: 0x0042C2AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCC8 RID: 122056 RVA: 0x0042E0B4 File Offset: 0x0042C2B4
		public static IEntityList GetRootAsIEntityList(ByteBuffer _bb)
		{
			return IEntityList.GetRootAsIEntityList(_bb, default(IEntityList));
		}

		// Token: 0x0601DCC9 RID: 122057 RVA: 0x0042E0D0 File Offset: 0x0042C2D0
		public static IEntityList GetRootAsIEntityList(ByteBuffer _bb, IEntityList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCCA RID: 122058 RVA: 0x0042E0ED File Offset: 0x0042C2ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCCB RID: 122059 RVA: 0x0042E0FC File Offset: 0x0042C2FC
		public IEntityList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A06 RID: 35334
		// (get) Token: 0x0601DCCC RID: 122060 RVA: 0x0042E10C File Offset: 0x0042C30C
		public int EntityListId
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

		// Token: 0x0601DCCD RID: 122061 RVA: 0x0042E148 File Offset: 0x0042C348
		public IEntityListElement? Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListElement?(default(IEntityListElement).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A07 RID: 35335
		// (get) Token: 0x0601DCCE RID: 122062 RVA: 0x0042E1A8 File Offset: 0x0042C3A8
		public int EntitiesLength
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

		// Token: 0x0601DCCF RID: 122063 RVA: 0x0042E1D3 File Offset: 0x0042C3D3
		public static Offset<IEntityList> CreateIEntityList(FlatBufferBuilder builder, int EntityListId = 0, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityList.AddEntities(builder, EntitiesOffset);
			IEntityList.AddEntityListId(builder, EntityListId);
			return IEntityList.EndIEntityList(builder);
		}

		// Token: 0x0601DCD0 RID: 122064 RVA: 0x0042E1F0 File Offset: 0x0042C3F0
		public static void StartIEntityList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DCD1 RID: 122065 RVA: 0x0042E1F9 File Offset: 0x0042C3F9
		public static void AddEntityListId(FlatBufferBuilder builder, int entityListId)
		{
			builder.AddInt(0, entityListId, 0);
		}

		// Token: 0x0601DCD2 RID: 122066 RVA: 0x0042E204 File Offset: 0x0042C404
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0601DCD3 RID: 122067 RVA: 0x0042E214 File Offset: 0x0042C414
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityListElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DCD4 RID: 122068 RVA: 0x0042E254 File Offset: 0x0042C454
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DCD5 RID: 122069 RVA: 0x0042E26E File Offset: 0x0042C46E
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListElement>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DCD6 RID: 122070 RVA: 0x0042E28C File Offset: 0x0042C48C
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListElement>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DCD7 RID: 122071 RVA: 0x0042E2A5 File Offset: 0x0042C4A5
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DCD8 RID: 122072 RVA: 0x0042E2B0 File Offset: 0x0042C4B0
		public static Offset<IEntityList> EndIEntityList(FlatBufferBuilder builder)
		{
			return new Offset<IEntityList>(builder.EndTable());
		}

		// Token: 0x0601DCD9 RID: 122073 RVA: 0x0042E2C0 File Offset: 0x0042C4C0
		public IEntityListT UnPack()
		{
			IEntityListT entityListT = new IEntityListT();
			this.UnPackTo(entityListT);
			return entityListT;
		}

		// Token: 0x0601DCDA RID: 122074 RVA: 0x0042E2DC File Offset: 0x0042C4DC
		public void UnPackTo(IEntityListT _o)
		{
			_o.EntityListId = this.EntityListId;
			_o.Entities = new List<IEntityListElementT>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add((this.Entities(i) != null) ? this.Entities(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DCDB RID: 122075 RVA: 0x0042E348 File Offset: 0x0042C548
		public static Offset<IEntityList> Pack(FlatBufferBuilder builder, IEntityListT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityList>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				Offset<IEntityListElement>[] array = new Offset<IEntityListElement>[_o.Entities.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityListElement.Pack(builder, _o.Entities[i]);
				}
				entitiesOffset = IEntityList.CreateEntitiesVector(builder, array);
			}
			return IEntityList.CreateIEntityList(builder, _o.EntityListId, entitiesOffset);
		}

		// Token: 0x0400D661 RID: 54881
		private Table __p;
	}
}
