using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A9 RID: 17577
	public struct IEnrichmentItem : IFlatbufferObject
	{
		// Token: 0x17007C07 RID: 31751
		// (get) Token: 0x0601A3EC RID: 107500 RVA: 0x003BFDBB File Offset: 0x003BDFBB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A3ED RID: 107501 RVA: 0x003BFDC8 File Offset: 0x003BDFC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A3EE RID: 107502 RVA: 0x003BFDD0 File Offset: 0x003BDFD0
		public static IEnrichmentItem GetRootAsIEnrichmentItem(ByteBuffer _bb)
		{
			return IEnrichmentItem.GetRootAsIEnrichmentItem(_bb, default(IEnrichmentItem));
		}

		// Token: 0x0601A3EF RID: 107503 RVA: 0x003BFDEC File Offset: 0x003BDFEC
		public static IEnrichmentItem GetRootAsIEnrichmentItem(ByteBuffer _bb, IEnrichmentItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A3F0 RID: 107504 RVA: 0x003BFE09 File Offset: 0x003BE009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A3F1 RID: 107505 RVA: 0x003BFE18 File Offset: 0x003BE018
		public IEnrichmentItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C08 RID: 31752
		// (get) Token: 0x0601A3F2 RID: 107506 RVA: 0x003BFE28 File Offset: 0x003BE028
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

		// Token: 0x17007C09 RID: 31753
		// (get) Token: 0x0601A3F3 RID: 107507 RVA: 0x003BFE64 File Offset: 0x003BE064
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

		// Token: 0x17007C0A RID: 31754
		// (get) Token: 0x0601A3F4 RID: 107508 RVA: 0x003BFEA0 File Offset: 0x003BE0A0
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

		// Token: 0x17007C0B RID: 31755
		// (get) Token: 0x0601A3F5 RID: 107509 RVA: 0x003BFEDC File Offset: 0x003BE0DC
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

		// Token: 0x0601A3F6 RID: 107510 RVA: 0x003BFF1C File Offset: 0x003BE11C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C0C RID: 31756
		// (get) Token: 0x0601A3F7 RID: 107511 RVA: 0x003BFF5C File Offset: 0x003BE15C
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

		// Token: 0x0601A3F8 RID: 107512 RVA: 0x003BFF88 File Offset: 0x003BE188
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0601A3F9 RID: 107513 RVA: 0x003BFF98 File Offset: 0x003BE198
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x17007C0D RID: 31757
		// (get) Token: 0x0601A3FA RID: 107514 RVA: 0x003BFFA8 File Offset: 0x003BE1A8
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

		// Token: 0x0601A3FB RID: 107515 RVA: 0x003BFFE5 File Offset: 0x003BE1E5
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

		// Token: 0x0601A3FC RID: 107516 RVA: 0x003C0021 File Offset: 0x003BE221
		public static void StartIEnrichmentItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A3FD RID: 107517 RVA: 0x003C002A File Offset: 0x003BE22A
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0601A3FE RID: 107518 RVA: 0x003C0035 File Offset: 0x003BE235
		public static void AddEnrichmentAreaType(FlatBufferBuilder builder, EEnrichmentAreaType enrichmentAreaType)
		{
			builder.AddByte(1, (byte)enrichmentAreaType, 0);
		}

		// Token: 0x0601A3FF RID: 107519 RVA: 0x003C0040 File Offset: 0x003BE240
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(2, levelId, 0);
		}

		// Token: 0x0601A400 RID: 107520 RVA: 0x003C004B File Offset: 0x003BE24B
		public static void AddEnrichmentId(FlatBufferBuilder builder, int enrichmentId)
		{
			builder.AddInt(3, enrichmentId, 0);
		}

		// Token: 0x0601A401 RID: 107521 RVA: 0x003C0056 File Offset: 0x003BE256
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(4, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601A402 RID: 107522 RVA: 0x003C0068 File Offset: 0x003BE268
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A403 RID: 107523 RVA: 0x003C009F File Offset: 0x003BE29F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A404 RID: 107524 RVA: 0x003C00B9 File Offset: 0x003BE2B9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A405 RID: 107525 RVA: 0x003C00D7 File Offset: 0x003BE2D7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A406 RID: 107526 RVA: 0x003C00F0 File Offset: 0x003BE2F0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A407 RID: 107527 RVA: 0x003C00FB File Offset: 0x003BE2FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601A408 RID: 107528 RVA: 0x003C0106 File Offset: 0x003BE306
		public static Offset<IEnrichmentItem> EndIEnrichmentItem(FlatBufferBuilder builder)
		{
			return new Offset<IEnrichmentItem>(builder.EndTable());
		}

		// Token: 0x0601A409 RID: 107529 RVA: 0x003C0114 File Offset: 0x003BE314
		public IEnrichmentItemT UnPack()
		{
			IEnrichmentItemT enrichmentItemT = new IEnrichmentItemT();
			this.UnPackTo(enrichmentItemT);
			return enrichmentItemT;
		}

		// Token: 0x0601A40A RID: 107530 RVA: 0x003C0130 File Offset: 0x003BE330
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

		// Token: 0x0601A40B RID: 107531 RVA: 0x003C01A8 File Offset: 0x003BE3A8
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

		// Token: 0x0400C4B2 RID: 50354
		private Table __p;
	}
}
