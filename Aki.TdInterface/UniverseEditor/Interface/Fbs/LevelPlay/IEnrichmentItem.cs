using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004911 RID: 18705
	public struct IEnrichmentItem : IFlatbufferObject
	{
		// Token: 0x17008246 RID: 33350
		// (get) Token: 0x0601BBBD RID: 113597 RVA: 0x003EBFC7 File Offset: 0x003EA1C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BBBE RID: 113598 RVA: 0x003EBFD4 File Offset: 0x003EA1D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BBBF RID: 113599 RVA: 0x003EBFDC File Offset: 0x003EA1DC
		public static IEnrichmentItem GetRootAsIEnrichmentItem(ByteBuffer _bb)
		{
			return IEnrichmentItem.GetRootAsIEnrichmentItem(_bb, default(IEnrichmentItem));
		}

		// Token: 0x0601BBC0 RID: 113600 RVA: 0x003EBFF8 File Offset: 0x003EA1F8
		public static IEnrichmentItem GetRootAsIEnrichmentItem(ByteBuffer _bb, IEnrichmentItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BBC1 RID: 113601 RVA: 0x003EC015 File Offset: 0x003EA215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BBC2 RID: 113602 RVA: 0x003EC024 File Offset: 0x003EA224
		public IEnrichmentItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008247 RID: 33351
		// (get) Token: 0x0601BBC3 RID: 113603 RVA: 0x003EC034 File Offset: 0x003EA234
		public int ItemId
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

		// Token: 0x17008248 RID: 33352
		// (get) Token: 0x0601BBC4 RID: 113604 RVA: 0x003EC070 File Offset: 0x003EA270
		public EEnrichmentAreaType EnrichmentAreaType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEnrichmentAreaType.BigWorld;
				}
				return (EEnrichmentAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008249 RID: 33353
		// (get) Token: 0x0601BBC5 RID: 113605 RVA: 0x003EC0AC File Offset: 0x003EA2AC
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700824A RID: 33354
		// (get) Token: 0x0601BBC6 RID: 113606 RVA: 0x003EC0E8 File Offset: 0x003EA2E8
		public int EnrichmentId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BBC7 RID: 113607 RVA: 0x003EC128 File Offset: 0x003EA328
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700824B RID: 33355
		// (get) Token: 0x0601BBC8 RID: 113608 RVA: 0x003EC168 File Offset: 0x003EA368
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BBC9 RID: 113609 RVA: 0x003EC194 File Offset: 0x003EA394
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0601BBCA RID: 113610 RVA: 0x003EC1A4 File Offset: 0x003EA3A4
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x1700824C RID: 33356
		// (get) Token: 0x0601BBCB RID: 113611 RVA: 0x003EC1B4 File Offset: 0x003EA3B4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BBCC RID: 113612 RVA: 0x003EC1F1 File Offset: 0x003EA3F1
		public static Offset<IEnrichmentItem> CreateIEnrichmentItem(FlatBufferBuilder builder, int ItemId = 0, EEnrichmentAreaType EnrichmentAreaType = EEnrichmentAreaType.BigWorld, int LevelId = 0, int EnrichmentId = 0, VectorOffset EntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IEnrichmentItem.AddEntityIds(builder, EntityIdsOffset);
			IEnrichmentItem.AddEnrichmentId(builder, EnrichmentId);
			IEnrichmentItem.AddLevelId(builder, LevelId);
			IEnrichmentItem.AddItemId(builder, ItemId);
			IEnrichmentItem.AddNullMask(builder, NullMask);
			IEnrichmentItem.AddEnrichmentAreaType(builder, EnrichmentAreaType);
			return IEnrichmentItem.EndIEnrichmentItem(builder);
		}

		// Token: 0x0601BBCD RID: 113613 RVA: 0x003EC22D File Offset: 0x003EA42D
		public static void StartIEnrichmentItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601BBCE RID: 113614 RVA: 0x003EC236 File Offset: 0x003EA436
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0601BBCF RID: 113615 RVA: 0x003EC241 File Offset: 0x003EA441
		public static void AddEnrichmentAreaType(FlatBufferBuilder builder, EEnrichmentAreaType enrichmentAreaType)
		{
			builder.AddByte(1, (byte)enrichmentAreaType, 0);
		}

		// Token: 0x0601BBD0 RID: 113616 RVA: 0x003EC24C File Offset: 0x003EA44C
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(2, levelId, 0);
		}

		// Token: 0x0601BBD1 RID: 113617 RVA: 0x003EC257 File Offset: 0x003EA457
		public static void AddEnrichmentId(FlatBufferBuilder builder, int enrichmentId)
		{
			builder.AddInt(3, enrichmentId, 0);
		}

		// Token: 0x0601BBD2 RID: 113618 RVA: 0x003EC262 File Offset: 0x003EA462
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(4, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601BBD3 RID: 113619 RVA: 0x003EC274 File Offset: 0x003EA474
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BBD4 RID: 113620 RVA: 0x003EC2AB File Offset: 0x003EA4AB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BBD5 RID: 113621 RVA: 0x003EC2C5 File Offset: 0x003EA4C5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BBD6 RID: 113622 RVA: 0x003EC2E3 File Offset: 0x003EA4E3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BBD7 RID: 113623 RVA: 0x003EC2FC File Offset: 0x003EA4FC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BBD8 RID: 113624 RVA: 0x003EC307 File Offset: 0x003EA507
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601BBD9 RID: 113625 RVA: 0x003EC312 File Offset: 0x003EA512
		public static Offset<IEnrichmentItem> EndIEnrichmentItem(FlatBufferBuilder builder)
		{
			return new Offset<IEnrichmentItem>(builder.EndTable());
		}

		// Token: 0x0601BBDA RID: 113626 RVA: 0x003EC320 File Offset: 0x003EA520
		public IEnrichmentItemT UnPack()
		{
			IEnrichmentItemT enrichmentItemT = new IEnrichmentItemT();
			this.UnPackTo(enrichmentItemT);
			return enrichmentItemT;
		}

		// Token: 0x0601BBDB RID: 113627 RVA: 0x003EC33C File Offset: 0x003EA53C
		public void UnPackTo(IEnrichmentItemT _o)
		{
			_o.ItemId = this.ItemId;
			_o.EnrichmentAreaType = this.EnrichmentAreaType;
			_o.LevelId = this.LevelId;
			_o.EnrichmentId = this.EnrichmentId;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BBDC RID: 113628 RVA: 0x003EC3B4 File Offset: 0x003EA5B4
		public static Offset<IEnrichmentItem> Pack(FlatBufferBuilder builder, IEnrichmentItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnrichmentItem>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEnrichmentItem.CreateEntityIdsVector(builder, data);
			}
			return IEnrichmentItem.CreateIEnrichmentItem(builder, _o.ItemId, _o.EnrichmentAreaType, _o.LevelId, _o.EnrichmentId, entityIdsOffset, _o.NullMask);
		}

		// Token: 0x0400CEE0 RID: 52960
		private Table __p;
	}
}
