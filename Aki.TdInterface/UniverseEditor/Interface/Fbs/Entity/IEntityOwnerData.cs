using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B7 RID: 18359
	public struct IEntityOwnerData : IFlatbufferObject
	{
		// Token: 0x170083DC RID: 33756
		// (get) Token: 0x0601C56B RID: 116075 RVA: 0x00402D23 File Offset: 0x00400F23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C56C RID: 116076 RVA: 0x00402D30 File Offset: 0x00400F30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C56D RID: 116077 RVA: 0x00402D38 File Offset: 0x00400F38
		public static IEntityOwnerData GetRootAsIEntityOwnerData(ByteBuffer _bb)
		{
			return IEntityOwnerData.GetRootAsIEntityOwnerData(_bb, default(IEntityOwnerData));
		}

		// Token: 0x0601C56E RID: 116078 RVA: 0x00402D54 File Offset: 0x00400F54
		public static IEntityOwnerData GetRootAsIEntityOwnerData(ByteBuffer _bb, IEntityOwnerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C56F RID: 116079 RVA: 0x00402D71 File Offset: 0x00400F71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C570 RID: 116080 RVA: 0x00402D80 File Offset: 0x00400F80
		public IEntityOwnerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083DD RID: 33757
		// (get) Token: 0x0601C571 RID: 116081 RVA: 0x00402D90 File Offset: 0x00400F90
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

		// Token: 0x170083DE RID: 33758
		// (get) Token: 0x0601C572 RID: 116082 RVA: 0x00402DCC File Offset: 0x00400FCC
		public int EntityId
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

		// Token: 0x0601C573 RID: 116083 RVA: 0x00402E08 File Offset: 0x00401008
		public TEntityOwner OwnerType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TEntityOwner.NONE;
			}
			return (TEntityOwner)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170083DF RID: 33759
		// (get) Token: 0x0601C574 RID: 116084 RVA: 0x00402E48 File Offset: 0x00401048
		public int OwnerTypeLength
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

		// Token: 0x0601C575 RID: 116085 RVA: 0x00402E73 File Offset: 0x00401073
		public Span<TEntityOwner> GetOwnerTypeBytes()
		{
			return this.__p.__vector_as_span<TEntityOwner>(8, 1);
		}

		// Token: 0x0601C576 RID: 116086 RVA: 0x00402E84 File Offset: 0x00401084
		public TEntityOwner[] GetOwnerTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TEntityOwner[] array = new TEntityOwner[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TEntityOwner)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601C577 RID: 116087 RVA: 0x00402EF0 File Offset: 0x004010F0
		public TTable? Owner<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170083E0 RID: 33760
		// (get) Token: 0x0601C578 RID: 116088 RVA: 0x00402F38 File Offset: 0x00401138
		public int OwnerLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601C579 RID: 116089 RVA: 0x00402F64 File Offset: 0x00401164
		public static Offset<IEntityOwnerData> CreateIEntityOwnerData(FlatBufferBuilder builder, int LevelId = 0, int EntityId = 0, VectorOffset Owner_typeOffset = default(VectorOffset), VectorOffset OwnerOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IEntityOwnerData.AddOwner(builder, OwnerOffset);
			IEntityOwnerData.AddOwnerType(builder, Owner_typeOffset);
			IEntityOwnerData.AddEntityId(builder, EntityId);
			IEntityOwnerData.AddLevelId(builder, LevelId);
			return IEntityOwnerData.EndIEntityOwnerData(builder);
		}

		// Token: 0x0601C57A RID: 116090 RVA: 0x00402F90 File Offset: 0x00401190
		public static void StartIEntityOwnerData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C57B RID: 116091 RVA: 0x00402F99 File Offset: 0x00401199
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601C57C RID: 116092 RVA: 0x00402FA4 File Offset: 0x004011A4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601C57D RID: 116093 RVA: 0x00402FAF File Offset: 0x004011AF
		public static void AddOwnerType(FlatBufferBuilder builder, VectorOffset ownerTypeOffset)
		{
			builder.AddOffset(2, ownerTypeOffset.Value, 0);
		}

		// Token: 0x0601C57E RID: 116094 RVA: 0x00402FC0 File Offset: 0x004011C0
		public static VectorOffset CreateOwnerTypeVector(FlatBufferBuilder builder, TEntityOwner[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C57F RID: 116095 RVA: 0x00402FF7 File Offset: 0x004011F7
		public static VectorOffset CreateOwnerTypeVectorBlock(FlatBufferBuilder builder, TEntityOwner[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TEntityOwner>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C580 RID: 116096 RVA: 0x00403011 File Offset: 0x00401211
		public static VectorOffset CreateOwnerTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TEntityOwner> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TEntityOwner>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C581 RID: 116097 RVA: 0x0040302F File Offset: 0x0040122F
		public static VectorOffset CreateOwnerTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TEntityOwner>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C582 RID: 116098 RVA: 0x00403048 File Offset: 0x00401248
		public static void StartOwnerTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C583 RID: 116099 RVA: 0x00403053 File Offset: 0x00401253
		public static void AddOwner(FlatBufferBuilder builder, VectorOffset ownerOffset)
		{
			builder.AddOffset(3, ownerOffset.Value, 0);
		}

		// Token: 0x0601C584 RID: 116100 RVA: 0x00403064 File Offset: 0x00401264
		public static VectorOffset CreateOwnerVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C585 RID: 116101 RVA: 0x0040309B File Offset: 0x0040129B
		public static VectorOffset CreateOwnerVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C586 RID: 116102 RVA: 0x004030B5 File Offset: 0x004012B5
		public static VectorOffset CreateOwnerVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C587 RID: 116103 RVA: 0x004030D3 File Offset: 0x004012D3
		public static VectorOffset CreateOwnerVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C588 RID: 116104 RVA: 0x004030EC File Offset: 0x004012EC
		public static void StartOwnerVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C589 RID: 116105 RVA: 0x004030F7 File Offset: 0x004012F7
		public static Offset<IEntityOwnerData> EndIEntityOwnerData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerData>(builder.EndTable());
		}

		// Token: 0x0601C58A RID: 116106 RVA: 0x00403104 File Offset: 0x00401304
		public IEntityOwnerDataT UnPack()
		{
			IEntityOwnerDataT entityOwnerDataT = new IEntityOwnerDataT();
			this.UnPackTo(entityOwnerDataT);
			return entityOwnerDataT;
		}

		// Token: 0x0601C58B RID: 116107 RVA: 0x00403120 File Offset: 0x00401320
		public void UnPackTo(IEntityOwnerDataT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityId = this.EntityId;
			_o.Owner = new List<TEntityOwnerUnion>();
			for (int i = 0; i < this.OwnerLength; i++)
			{
				TEntityOwnerUnion tentityOwnerUnion = new TEntityOwnerUnion();
				tentityOwnerUnion.Type = this.OwnerType(i);
				switch (this.OwnerType(i))
				{
				case TEntityOwner.IEntityOwnerEntity:
					tentityOwnerUnion.Value = ((this.Owner<IEntityOwnerEntity>(i) != null) ? this.Owner<IEntityOwnerEntity>(i).Value.UnPack() : null);
					break;
				case TEntityOwner.IEntityOwnerLevelPlay:
					tentityOwnerUnion.Value = ((this.Owner<IEntityOwnerLevelPlay>(i) != null) ? this.Owner<IEntityOwnerLevelPlay>(i).Value.UnPack() : null);
					break;
				case TEntityOwner.IEntityOwnerQuest:
					tentityOwnerUnion.Value = ((this.Owner<IEntityOwnerQuest>(i) != null) ? this.Owner<IEntityOwnerQuest>(i).Value.UnPack() : null);
					break;
				}
				_o.Owner.Add(tentityOwnerUnion);
			}
		}

		// Token: 0x0601C58C RID: 116108 RVA: 0x00403248 File Offset: 0x00401448
		public static Offset<IEntityOwnerData> Pack(FlatBufferBuilder builder, IEntityOwnerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerData>);
			}
			VectorOffset owner_typeOffset = default(VectorOffset);
			if (_o.Owner != null)
			{
				TEntityOwner[] array = new TEntityOwner[_o.Owner.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Owner[i].Type;
				}
				owner_typeOffset = IEntityOwnerData.CreateOwnerTypeVector(builder, array);
			}
			VectorOffset ownerOffset = default(VectorOffset);
			if (_o.Owner != null)
			{
				int[] array2 = new int[_o.Owner.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TEntityOwnerUnion.Pack(builder, _o.Owner[j]);
				}
				ownerOffset = IEntityOwnerData.CreateOwnerVector(builder, array2);
			}
			return IEntityOwnerData.CreateIEntityOwnerData(builder, _o.LevelId, _o.EntityId, owner_typeOffset, ownerOffset);
		}

		// Token: 0x0400CC39 RID: 52281
		private Table __p;
	}
}
