using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047AB RID: 18347
	public struct IEntityList : IFlatbufferObject
	{
		// Token: 0x170083C4 RID: 33732
		// (get) Token: 0x0601C4F1 RID: 115953 RVA: 0x00401E04 File Offset: 0x00400004
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C4F2 RID: 115954 RVA: 0x00401E11 File Offset: 0x00400011
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C4F3 RID: 115955 RVA: 0x00401E18 File Offset: 0x00400018
		public static IEntityList GetRootAsIEntityList(ByteBuffer _bb)
		{
			return IEntityList.GetRootAsIEntityList(_bb, default(IEntityList));
		}

		// Token: 0x0601C4F4 RID: 115956 RVA: 0x00401E34 File Offset: 0x00400034
		public static IEntityList GetRootAsIEntityList(ByteBuffer _bb, IEntityList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C4F5 RID: 115957 RVA: 0x00401E51 File Offset: 0x00400051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C4F6 RID: 115958 RVA: 0x00401E60 File Offset: 0x00400060
		public IEntityList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083C5 RID: 33733
		// (get) Token: 0x0601C4F7 RID: 115959 RVA: 0x00401E70 File Offset: 0x00400070
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

		// Token: 0x0601C4F8 RID: 115960 RVA: 0x00401EAC File Offset: 0x004000AC
		public IEntityListElement? Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListElement?(default(IEntityListElement).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170083C6 RID: 33734
		// (get) Token: 0x0601C4F9 RID: 115961 RVA: 0x00401F0C File Offset: 0x0040010C
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

		// Token: 0x0601C4FA RID: 115962 RVA: 0x00401F37 File Offset: 0x00400137
		public static Offset<IEntityList> CreateIEntityList(FlatBufferBuilder builder, int EntityListId = 0, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityList.AddEntities(builder, EntitiesOffset);
			IEntityList.AddEntityListId(builder, EntityListId);
			return IEntityList.EndIEntityList(builder);
		}

		// Token: 0x0601C4FB RID: 115963 RVA: 0x00401F54 File Offset: 0x00400154
		public static void StartIEntityList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C4FC RID: 115964 RVA: 0x00401F5D File Offset: 0x0040015D
		public static void AddEntityListId(FlatBufferBuilder builder, int entityListId)
		{
			builder.AddInt(0, entityListId, 0);
		}

		// Token: 0x0601C4FD RID: 115965 RVA: 0x00401F68 File Offset: 0x00400168
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0601C4FE RID: 115966 RVA: 0x00401F78 File Offset: 0x00400178
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityListElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C4FF RID: 115967 RVA: 0x00401FB8 File Offset: 0x004001B8
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C500 RID: 115968 RVA: 0x00401FD2 File Offset: 0x004001D2
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListElement>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C501 RID: 115969 RVA: 0x00401FF0 File Offset: 0x004001F0
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListElement>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C502 RID: 115970 RVA: 0x00402009 File Offset: 0x00400209
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C503 RID: 115971 RVA: 0x00402014 File Offset: 0x00400214
		public static Offset<IEntityList> EndIEntityList(FlatBufferBuilder builder)
		{
			return new Offset<IEntityList>(builder.EndTable());
		}

		// Token: 0x0601C504 RID: 115972 RVA: 0x00402024 File Offset: 0x00400224
		public IEntityListT UnPack()
		{
			IEntityListT entityListT = new IEntityListT();
			this.UnPackTo(entityListT);
			return entityListT;
		}

		// Token: 0x0601C505 RID: 115973 RVA: 0x00402040 File Offset: 0x00400240
		public void UnPackTo(IEntityListT _o)
		{
			_o.EntityListId = this.EntityListId;
			_o.Entities = new List<IEntityListElementT>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add((this.Entities(i) != null) ? this.Entities(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C506 RID: 115974 RVA: 0x004020AC File Offset: 0x004002AC
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

		// Token: 0x0400CC2B RID: 52267
		private Table __p;
	}
}
