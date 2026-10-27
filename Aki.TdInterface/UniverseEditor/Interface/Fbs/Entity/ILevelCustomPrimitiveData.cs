using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E4 RID: 18404
	public struct ILevelCustomPrimitiveData : IFlatbufferObject
	{
		// Token: 0x17008445 RID: 33861
		// (get) Token: 0x0601C744 RID: 116548 RVA: 0x004068C6 File Offset: 0x00404AC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C745 RID: 116549 RVA: 0x004068D3 File Offset: 0x00404AD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C746 RID: 116550 RVA: 0x004068DC File Offset: 0x00404ADC
		public static ILevelCustomPrimitiveData GetRootAsILevelCustomPrimitiveData(ByteBuffer _bb)
		{
			return ILevelCustomPrimitiveData.GetRootAsILevelCustomPrimitiveData(_bb, default(ILevelCustomPrimitiveData));
		}

		// Token: 0x0601C747 RID: 116551 RVA: 0x004068F8 File Offset: 0x00404AF8
		public static ILevelCustomPrimitiveData GetRootAsILevelCustomPrimitiveData(ByteBuffer _bb, ILevelCustomPrimitiveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C748 RID: 116552 RVA: 0x00406915 File Offset: 0x00404B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C749 RID: 116553 RVA: 0x00406924 File Offset: 0x00404B24
		public ILevelCustomPrimitiveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008446 RID: 33862
		// (get) Token: 0x0601C74A RID: 116554 RVA: 0x00406934 File Offset: 0x00404B34
		public int LevelId
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

		// Token: 0x0601C74B RID: 116555 RVA: 0x00406970 File Offset: 0x00404B70
		public IEntityCustomPrimitiveData? Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCustomPrimitiveData?(default(IEntityCustomPrimitiveData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008447 RID: 33863
		// (get) Token: 0x0601C74C RID: 116556 RVA: 0x004069D0 File Offset: 0x00404BD0
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

		// Token: 0x0601C74D RID: 116557 RVA: 0x004069FB File Offset: 0x00404BFB
		public static Offset<ILevelCustomPrimitiveData> CreateILevelCustomPrimitiveData(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelCustomPrimitiveData.AddEntities(builder, EntitiesOffset);
			ILevelCustomPrimitiveData.AddLevelId(builder, LevelId);
			return ILevelCustomPrimitiveData.EndILevelCustomPrimitiveData(builder);
		}

		// Token: 0x0601C74E RID: 116558 RVA: 0x00406A18 File Offset: 0x00404C18
		public static void StartILevelCustomPrimitiveData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C74F RID: 116559 RVA: 0x00406A21 File Offset: 0x00404C21
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601C750 RID: 116560 RVA: 0x00406A2C File Offset: 0x00404C2C
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0601C751 RID: 116561 RVA: 0x00406A3C File Offset: 0x00404C3C
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C752 RID: 116562 RVA: 0x00406A7C File Offset: 0x00404C7C
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C753 RID: 116563 RVA: 0x00406A96 File Offset: 0x00404C96
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCustomPrimitiveData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C754 RID: 116564 RVA: 0x00406AB4 File Offset: 0x00404CB4
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCustomPrimitiveData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C755 RID: 116565 RVA: 0x00406ACD File Offset: 0x00404CCD
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C756 RID: 116566 RVA: 0x00406AD8 File Offset: 0x00404CD8
		public static Offset<ILevelCustomPrimitiveData> EndILevelCustomPrimitiveData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelCustomPrimitiveData>(builder.EndTable());
		}

		// Token: 0x0601C757 RID: 116567 RVA: 0x00406AE8 File Offset: 0x00404CE8
		public ILevelCustomPrimitiveDataT UnPack()
		{
			ILevelCustomPrimitiveDataT levelCustomPrimitiveDataT = new ILevelCustomPrimitiveDataT();
			this.UnPackTo(levelCustomPrimitiveDataT);
			return levelCustomPrimitiveDataT;
		}

		// Token: 0x0601C758 RID: 116568 RVA: 0x00406B04 File Offset: 0x00404D04
		public void UnPackTo(ILevelCustomPrimitiveDataT _o)
		{
			_o.LevelId = this.LevelId;
			_o.Entities = new List<IEntityCustomPrimitiveDataT>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add((this.Entities(i) != null) ? this.Entities(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C759 RID: 116569 RVA: 0x00406B70 File Offset: 0x00404D70
		public static Offset<ILevelCustomPrimitiveData> Pack(FlatBufferBuilder builder, ILevelCustomPrimitiveDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelCustomPrimitiveData>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				Offset<IEntityCustomPrimitiveData>[] array = new Offset<IEntityCustomPrimitiveData>[_o.Entities.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityCustomPrimitiveData.Pack(builder, _o.Entities[i]);
				}
				entitiesOffset = ILevelCustomPrimitiveData.CreateEntitiesVector(builder, array);
			}
			return ILevelCustomPrimitiveData.CreateILevelCustomPrimitiveData(builder, _o.LevelId, entitiesOffset);
		}

		// Token: 0x0400CC7B RID: 52347
		private Table __p;
	}
}
