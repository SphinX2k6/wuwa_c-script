using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043CB RID: 17355
	public struct ISilentAreaOccupationData : IFlatbufferObject
	{
		// Token: 0x17007AB9 RID: 31417
		// (get) Token: 0x06019E16 RID: 106006 RVA: 0x003B430F File Offset: 0x003B250F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019E17 RID: 106007 RVA: 0x003B431C File Offset: 0x003B251C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019E18 RID: 106008 RVA: 0x003B4324 File Offset: 0x003B2524
		public static ISilentAreaOccupationData GetRootAsISilentAreaOccupationData(ByteBuffer _bb)
		{
			return ISilentAreaOccupationData.GetRootAsISilentAreaOccupationData(_bb, default(ISilentAreaOccupationData));
		}

		// Token: 0x06019E19 RID: 106009 RVA: 0x003B4340 File Offset: 0x003B2540
		public static ISilentAreaOccupationData GetRootAsISilentAreaOccupationData(ByteBuffer _bb, ISilentAreaOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019E1A RID: 106010 RVA: 0x003B435D File Offset: 0x003B255D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E1B RID: 106011 RVA: 0x003B436C File Offset: 0x003B256C
		public ISilentAreaOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007ABA RID: 31418
		// (get) Token: 0x06019E1C RID: 106012 RVA: 0x003B437C File Offset: 0x003B257C
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

		// Token: 0x06019E1D RID: 106013 RVA: 0x003B43B8 File Offset: 0x003B25B8
		public int LevelPlayIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007ABB RID: 31419
		// (get) Token: 0x06019E1E RID: 106014 RVA: 0x003B43F8 File Offset: 0x003B25F8
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

		// Token: 0x06019E1F RID: 106015 RVA: 0x003B4423 File Offset: 0x003B2623
		public Span<int> GetLevelPlayIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06019E20 RID: 106016 RVA: 0x003B4432 File Offset: 0x003B2632
		public int[] GetLevelPlayIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06019E21 RID: 106017 RVA: 0x003B4440 File Offset: 0x003B2640
		public int AssociatedEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007ABC RID: 31420
		// (get) Token: 0x06019E22 RID: 106018 RVA: 0x003B4480 File Offset: 0x003B2680
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

		// Token: 0x06019E23 RID: 106019 RVA: 0x003B44AB File Offset: 0x003B26AB
		public Span<int> GetAssociatedEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06019E24 RID: 106020 RVA: 0x003B44BA File Offset: 0x003B26BA
		public int[] GetAssociatedEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06019E25 RID: 106021 RVA: 0x003B44C8 File Offset: 0x003B26C8
		public static Offset<ISilentAreaOccupationData> CreateISilentAreaOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc, VectorOffset LevelPlayIdsOffset = default(VectorOffset), VectorOffset AssociatedEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISilentAreaOccupationData.AddAssociatedEntities(builder, AssociatedEntitiesOffset);
			ISilentAreaOccupationData.AddLevelPlayIds(builder, LevelPlayIdsOffset);
			ISilentAreaOccupationData.AddType(builder, Type);
			return ISilentAreaOccupationData.EndISilentAreaOccupationData(builder);
		}

		// Token: 0x06019E26 RID: 106022 RVA: 0x003B44EC File Offset: 0x003B26EC
		public static void StartISilentAreaOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019E27 RID: 106023 RVA: 0x003B44F5 File Offset: 0x003B26F5
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019E28 RID: 106024 RVA: 0x003B4500 File Offset: 0x003B2700
		public static void AddLevelPlayIds(FlatBufferBuilder builder, VectorOffset levelPlayIdsOffset)
		{
			builder.AddOffset(1, levelPlayIdsOffset.Value, 0);
		}

		// Token: 0x06019E29 RID: 106025 RVA: 0x003B4510 File Offset: 0x003B2710
		public static VectorOffset CreateLevelPlayIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019E2A RID: 106026 RVA: 0x003B4547 File Offset: 0x003B2747
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E2B RID: 106027 RVA: 0x003B4561 File Offset: 0x003B2761
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E2C RID: 106028 RVA: 0x003B457F File Offset: 0x003B277F
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019E2D RID: 106029 RVA: 0x003B4598 File Offset: 0x003B2798
		public static void StartLevelPlayIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019E2E RID: 106030 RVA: 0x003B45A3 File Offset: 0x003B27A3
		public static void AddAssociatedEntities(FlatBufferBuilder builder, VectorOffset associatedEntitiesOffset)
		{
			builder.AddOffset(2, associatedEntitiesOffset.Value, 0);
		}

		// Token: 0x06019E2F RID: 106031 RVA: 0x003B45B4 File Offset: 0x003B27B4
		public static VectorOffset CreateAssociatedEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019E30 RID: 106032 RVA: 0x003B45EB File Offset: 0x003B27EB
		public static VectorOffset CreateAssociatedEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E31 RID: 106033 RVA: 0x003B4605 File Offset: 0x003B2805
		public static VectorOffset CreateAssociatedEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E32 RID: 106034 RVA: 0x003B4623 File Offset: 0x003B2823
		public static VectorOffset CreateAssociatedEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019E33 RID: 106035 RVA: 0x003B463C File Offset: 0x003B283C
		public static void StartAssociatedEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019E34 RID: 106036 RVA: 0x003B4647 File Offset: 0x003B2847
		public static Offset<ISilentAreaOccupationData> EndISilentAreaOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<ISilentAreaOccupationData>(builder.EndTable());
		}

		// Token: 0x06019E35 RID: 106037 RVA: 0x003B4654 File Offset: 0x003B2854
		public ISilentAreaOccupationDataT UnPack()
		{
			ISilentAreaOccupationDataT silentAreaOccupationDataT = new ISilentAreaOccupationDataT();
			this.UnPackTo(silentAreaOccupationDataT);
			return silentAreaOccupationDataT;
		}

		// Token: 0x06019E36 RID: 106038 RVA: 0x003B4670 File Offset: 0x003B2870
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

		// Token: 0x06019E37 RID: 106039 RVA: 0x003B46E8 File Offset: 0x003B28E8
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

		// Token: 0x0400C219 RID: 49689
		private Table __p;
	}
}
