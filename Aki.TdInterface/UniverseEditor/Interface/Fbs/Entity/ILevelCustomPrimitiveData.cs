using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C4C RID: 19532
	public struct ILevelCustomPrimitiveData : IFlatbufferObject
	{
		// Token: 0x17008A90 RID: 35472
		// (get) Token: 0x0601DF41 RID: 122689 RVA: 0x00433216 File Offset: 0x00431416
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF42 RID: 122690 RVA: 0x00433223 File Offset: 0x00431423
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF43 RID: 122691 RVA: 0x0043322C File Offset: 0x0043142C
		public static ILevelCustomPrimitiveData GetRootAsILevelCustomPrimitiveData(ByteBuffer _bb)
		{
			return ILevelCustomPrimitiveData.GetRootAsILevelCustomPrimitiveData(_bb, default(ILevelCustomPrimitiveData));
		}

		// Token: 0x0601DF44 RID: 122692 RVA: 0x00433248 File Offset: 0x00431448
		public static ILevelCustomPrimitiveData GetRootAsILevelCustomPrimitiveData(ByteBuffer _bb, ILevelCustomPrimitiveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF45 RID: 122693 RVA: 0x00433265 File Offset: 0x00431465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF46 RID: 122694 RVA: 0x00433274 File Offset: 0x00431474
		public ILevelCustomPrimitiveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A91 RID: 35473
		// (get) Token: 0x0601DF47 RID: 122695 RVA: 0x00433284 File Offset: 0x00431484
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

		// Token: 0x0601DF48 RID: 122696 RVA: 0x004332C0 File Offset: 0x004314C0
		public IEntityCustomPrimitiveData? Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCustomPrimitiveData?(default(IEntityCustomPrimitiveData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A92 RID: 35474
		// (get) Token: 0x0601DF49 RID: 122697 RVA: 0x00433320 File Offset: 0x00431520
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

		// Token: 0x0601DF4A RID: 122698 RVA: 0x0043334B File Offset: 0x0043154B
		public static Offset<ILevelCustomPrimitiveData> CreateILevelCustomPrimitiveData(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelCustomPrimitiveData.AddEntities(builder, EntitiesOffset);
			ILevelCustomPrimitiveData.AddLevelId(builder, LevelId);
			return ILevelCustomPrimitiveData.EndILevelCustomPrimitiveData(builder);
		}

		// Token: 0x0601DF4B RID: 122699 RVA: 0x00433368 File Offset: 0x00431568
		public static void StartILevelCustomPrimitiveData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DF4C RID: 122700 RVA: 0x00433371 File Offset: 0x00431571
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601DF4D RID: 122701 RVA: 0x0043337C File Offset: 0x0043157C
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0601DF4E RID: 122702 RVA: 0x0043338C File Offset: 0x0043158C
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DF4F RID: 122703 RVA: 0x004333CC File Offset: 0x004315CC
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DF50 RID: 122704 RVA: 0x004333E6 File Offset: 0x004315E6
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCustomPrimitiveData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DF51 RID: 122705 RVA: 0x00433404 File Offset: 0x00431604
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCustomPrimitiveData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DF52 RID: 122706 RVA: 0x0043341D File Offset: 0x0043161D
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DF53 RID: 122707 RVA: 0x00433428 File Offset: 0x00431628
		public static Offset<ILevelCustomPrimitiveData> EndILevelCustomPrimitiveData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelCustomPrimitiveData>(builder.EndTable());
		}

		// Token: 0x0601DF54 RID: 122708 RVA: 0x00433438 File Offset: 0x00431638
		public ILevelCustomPrimitiveDataT UnPack()
		{
			ILevelCustomPrimitiveDataT levelCustomPrimitiveDataT = new ILevelCustomPrimitiveDataT();
			this.UnPackTo(levelCustomPrimitiveDataT);
			return levelCustomPrimitiveDataT;
		}

		// Token: 0x0601DF55 RID: 122709 RVA: 0x00433454 File Offset: 0x00431654
		public void UnPackTo(ILevelCustomPrimitiveDataT _o)
		{
			_o.LevelId = this.LevelId;
			_o.Entities = new List<IEntityCustomPrimitiveDataT>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add((this.Entities(i) != null) ? this.Entities(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DF56 RID: 122710 RVA: 0x004334C0 File Offset: 0x004316C0
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

		// Token: 0x0400D6B6 RID: 54966
		private Table __p;
	}
}
