using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004830 RID: 18480
	public struct ISilentAreaOccupationData : IFlatbufferObject
	{
		// Token: 0x170080F3 RID: 33011
		// (get) Token: 0x0601B5C3 RID: 112067 RVA: 0x003E011F File Offset: 0x003DE31F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B5C4 RID: 112068 RVA: 0x003E012C File Offset: 0x003DE32C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B5C5 RID: 112069 RVA: 0x003E0134 File Offset: 0x003DE334
		public static ISilentAreaOccupationData GetRootAsISilentAreaOccupationData(ByteBuffer _bb)
		{
			return ISilentAreaOccupationData.GetRootAsISilentAreaOccupationData(_bb, default(ISilentAreaOccupationData));
		}

		// Token: 0x0601B5C6 RID: 112070 RVA: 0x003E0150 File Offset: 0x003DE350
		public static ISilentAreaOccupationData GetRootAsISilentAreaOccupationData(ByteBuffer _bb, ISilentAreaOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B5C7 RID: 112071 RVA: 0x003E016D File Offset: 0x003DE36D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B5C8 RID: 112072 RVA: 0x003E017C File Offset: 0x003DE37C
		public ISilentAreaOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080F4 RID: 33012
		// (get) Token: 0x0601B5C9 RID: 112073 RVA: 0x003E018C File Offset: 0x003DE38C
		public EOccupationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOccupationType.Npc;
				}
				return (EOccupationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B5CA RID: 112074 RVA: 0x003E01C8 File Offset: 0x003DE3C8
		public int LevelPlayIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170080F5 RID: 33013
		// (get) Token: 0x0601B5CB RID: 112075 RVA: 0x003E0208 File Offset: 0x003DE408
		public int LevelPlayIdsLength
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

		// Token: 0x0601B5CC RID: 112076 RVA: 0x003E0233 File Offset: 0x003DE433
		public Span<int> GetLevelPlayIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601B5CD RID: 112077 RVA: 0x003E0242 File Offset: 0x003DE442
		public int[] GetLevelPlayIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601B5CE RID: 112078 RVA: 0x003E0250 File Offset: 0x003DE450
		public int AssociatedEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170080F6 RID: 33014
		// (get) Token: 0x0601B5CF RID: 112079 RVA: 0x003E0290 File Offset: 0x003DE490
		public int AssociatedEntitiesLength
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

		// Token: 0x0601B5D0 RID: 112080 RVA: 0x003E02BB File Offset: 0x003DE4BB
		public Span<int> GetAssociatedEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601B5D1 RID: 112081 RVA: 0x003E02CA File Offset: 0x003DE4CA
		public int[] GetAssociatedEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601B5D2 RID: 112082 RVA: 0x003E02D8 File Offset: 0x003DE4D8
		public static Offset<ISilentAreaOccupationData> CreateISilentAreaOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc, VectorOffset LevelPlayIdsOffset = default(VectorOffset), VectorOffset AssociatedEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISilentAreaOccupationData.AddAssociatedEntities(builder, AssociatedEntitiesOffset);
			ISilentAreaOccupationData.AddLevelPlayIds(builder, LevelPlayIdsOffset);
			ISilentAreaOccupationData.AddType(builder, Type);
			return ISilentAreaOccupationData.EndISilentAreaOccupationData(builder);
		}

		// Token: 0x0601B5D3 RID: 112083 RVA: 0x003E02FC File Offset: 0x003DE4FC
		public static void StartISilentAreaOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B5D4 RID: 112084 RVA: 0x003E0305 File Offset: 0x003DE505
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B5D5 RID: 112085 RVA: 0x003E0310 File Offset: 0x003DE510
		public static void AddLevelPlayIds(FlatBufferBuilder builder, VectorOffset levelPlayIdsOffset)
		{
			builder.AddOffset(1, levelPlayIdsOffset.Value, 0);
		}

		// Token: 0x0601B5D6 RID: 112086 RVA: 0x003E0320 File Offset: 0x003DE520
		public static VectorOffset CreateLevelPlayIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B5D7 RID: 112087 RVA: 0x003E0357 File Offset: 0x003DE557
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B5D8 RID: 112088 RVA: 0x003E0371 File Offset: 0x003DE571
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B5D9 RID: 112089 RVA: 0x003E038F File Offset: 0x003DE58F
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B5DA RID: 112090 RVA: 0x003E03A8 File Offset: 0x003DE5A8
		public static void StartLevelPlayIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B5DB RID: 112091 RVA: 0x003E03B3 File Offset: 0x003DE5B3
		public static void AddAssociatedEntities(FlatBufferBuilder builder, VectorOffset associatedEntitiesOffset)
		{
			builder.AddOffset(2, associatedEntitiesOffset.Value, 0);
		}

		// Token: 0x0601B5DC RID: 112092 RVA: 0x003E03C4 File Offset: 0x003DE5C4
		public static VectorOffset CreateAssociatedEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B5DD RID: 112093 RVA: 0x003E03FB File Offset: 0x003DE5FB
		public static VectorOffset CreateAssociatedEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B5DE RID: 112094 RVA: 0x003E0415 File Offset: 0x003DE615
		public static VectorOffset CreateAssociatedEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B5DF RID: 112095 RVA: 0x003E0433 File Offset: 0x003DE633
		public static VectorOffset CreateAssociatedEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B5E0 RID: 112096 RVA: 0x003E044C File Offset: 0x003DE64C
		public static void StartAssociatedEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B5E1 RID: 112097 RVA: 0x003E0457 File Offset: 0x003DE657
		public static Offset<ISilentAreaOccupationData> EndISilentAreaOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<ISilentAreaOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B5E2 RID: 112098 RVA: 0x003E0464 File Offset: 0x003DE664
		public ISilentAreaOccupationDataT UnPack()
		{
			ISilentAreaOccupationDataT silentAreaOccupationDataT = new ISilentAreaOccupationDataT();
			this.UnPackTo(silentAreaOccupationDataT);
			return silentAreaOccupationDataT;
		}

		// Token: 0x0601B5E3 RID: 112099 RVA: 0x003E0480 File Offset: 0x003DE680
		public void UnPackTo(ISilentAreaOccupationDataT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayIds = new List<int>();
			for (int i = 0; i < this.LevelPlayIdsLength; i++)
			{
				_o.LevelPlayIds.Add(this.LevelPlayIds(i));
			}
			_o.AssociatedEntities = new List<int>();
			for (int j = 0; j < this.AssociatedEntitiesLength; j++)
			{
				_o.AssociatedEntities.Add(this.AssociatedEntities(j));
			}
		}

		// Token: 0x0601B5E4 RID: 112100 RVA: 0x003E04F8 File Offset: 0x003DE6F8
		public static Offset<ISilentAreaOccupationData> Pack(FlatBufferBuilder builder, ISilentAreaOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISilentAreaOccupationData>);
			}
			VectorOffset levelPlayIdsOffset = default(VectorOffset);
			if (_o.LevelPlayIds != null)
			{
				int[] data = _o.LevelPlayIds.ToArray();
				levelPlayIdsOffset = ISilentAreaOccupationData.CreateLevelPlayIdsVector(builder, data);
			}
			VectorOffset associatedEntitiesOffset = default(VectorOffset);
			if (_o.AssociatedEntities != null)
			{
				int[] data2 = _o.AssociatedEntities.ToArray();
				associatedEntitiesOffset = ISilentAreaOccupationData.CreateAssociatedEntitiesVector(builder, data2);
			}
			return ISilentAreaOccupationData.CreateISilentAreaOccupationData(builder, _o.Type, levelPlayIdsOffset, associatedEntitiesOffset);
		}

		// Token: 0x0400CC3C RID: 52284
		private Table __p;
	}
}
