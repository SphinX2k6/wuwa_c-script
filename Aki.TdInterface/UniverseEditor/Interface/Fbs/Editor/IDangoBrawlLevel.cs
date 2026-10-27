using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200484A RID: 18506
	public struct IDangoBrawlLevel : IFlatbufferObject
	{
		// Token: 0x170084D8 RID: 34008
		// (get) Token: 0x0601C9FC RID: 117244 RVA: 0x0040BD77 File Offset: 0x00409F77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C9FD RID: 117245 RVA: 0x0040BD84 File Offset: 0x00409F84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C9FE RID: 117246 RVA: 0x0040BD8C File Offset: 0x00409F8C
		public static IDangoBrawlLevel GetRootAsIDangoBrawlLevel(ByteBuffer _bb)
		{
			return IDangoBrawlLevel.GetRootAsIDangoBrawlLevel(_bb, default(IDangoBrawlLevel));
		}

		// Token: 0x0601C9FF RID: 117247 RVA: 0x0040BDA8 File Offset: 0x00409FA8
		public static IDangoBrawlLevel GetRootAsIDangoBrawlLevel(ByteBuffer _bb, IDangoBrawlLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CA00 RID: 117248 RVA: 0x0040BDC5 File Offset: 0x00409FC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CA01 RID: 117249 RVA: 0x0040BDD4 File Offset: 0x00409FD4
		public IDangoBrawlLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084D9 RID: 34009
		// (get) Token: 0x0601CA02 RID: 117250 RVA: 0x0040BDE4 File Offset: 0x00409FE4
		public int Id
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

		// Token: 0x170084DA RID: 34010
		// (get) Token: 0x0601CA03 RID: 117251 RVA: 0x0040BE20 File Offset: 0x0040A020
		public ETwoDimensionLevelType Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETwoDimensionLevelType.Marble;
				}
				return (ETwoDimensionLevelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CA04 RID: 117252 RVA: 0x0040BE5C File Offset: 0x0040A05C
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170084DB RID: 34011
		// (get) Token: 0x0601CA05 RID: 117253 RVA: 0x0040BE9C File Offset: 0x0040A09C
		public int ItemListTypeLength
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

		// Token: 0x0601CA06 RID: 117254 RVA: 0x0040BEC7 File Offset: 0x0040A0C7
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601CA07 RID: 117255 RVA: 0x0040BED8 File Offset: 0x0040A0D8
		public TTwoDimensionItem[] GetItemListTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTwoDimensionItem[] array = new TTwoDimensionItem[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTwoDimensionItem)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601CA08 RID: 117256 RVA: 0x0040BF44 File Offset: 0x0040A144
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170084DC RID: 34012
		// (get) Token: 0x0601CA09 RID: 117257 RVA: 0x0040BF8C File Offset: 0x0040A18C
		public int ItemListLength
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

		// Token: 0x0601CA0A RID: 117258 RVA: 0x0040BFB8 File Offset: 0x0040A1B8
		public static Offset<IDangoBrawlLevel> CreateIDangoBrawlLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IDangoBrawlLevel.AddItemList(builder, ItemListOffset);
			IDangoBrawlLevel.AddItemListType(builder, ItemList_typeOffset);
			IDangoBrawlLevel.AddId(builder, Id);
			IDangoBrawlLevel.AddType(builder, Type);
			return IDangoBrawlLevel.EndIDangoBrawlLevel(builder);
		}

		// Token: 0x0601CA0B RID: 117259 RVA: 0x0040BFE4 File Offset: 0x0040A1E4
		public static void StartIDangoBrawlLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CA0C RID: 117260 RVA: 0x0040BFED File Offset: 0x0040A1ED
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601CA0D RID: 117261 RVA: 0x0040BFF8 File Offset: 0x0040A1F8
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601CA0E RID: 117262 RVA: 0x0040C003 File Offset: 0x0040A203
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601CA0F RID: 117263 RVA: 0x0040C014 File Offset: 0x0040A214
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CA10 RID: 117264 RVA: 0x0040C04B File Offset: 0x0040A24B
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA11 RID: 117265 RVA: 0x0040C065 File Offset: 0x0040A265
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA12 RID: 117266 RVA: 0x0040C083 File Offset: 0x0040A283
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CA13 RID: 117267 RVA: 0x0040C09C File Offset: 0x0040A29C
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601CA14 RID: 117268 RVA: 0x0040C0A7 File Offset: 0x0040A2A7
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601CA15 RID: 117269 RVA: 0x0040C0B8 File Offset: 0x0040A2B8
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CA16 RID: 117270 RVA: 0x0040C0EF File Offset: 0x0040A2EF
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA17 RID: 117271 RVA: 0x0040C109 File Offset: 0x0040A309
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA18 RID: 117272 RVA: 0x0040C127 File Offset: 0x0040A327
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CA19 RID: 117273 RVA: 0x0040C140 File Offset: 0x0040A340
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CA1A RID: 117274 RVA: 0x0040C14B File Offset: 0x0040A34B
		public static Offset<IDangoBrawlLevel> EndIDangoBrawlLevel(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlLevel>(builder.EndTable());
		}

		// Token: 0x0601CA1B RID: 117275 RVA: 0x0040C158 File Offset: 0x0040A358
		public IDangoBrawlLevelT UnPack()
		{
			IDangoBrawlLevelT dangoBrawlLevelT = new IDangoBrawlLevelT();
			this.UnPackTo(dangoBrawlLevelT);
			return dangoBrawlLevelT;
		}

		// Token: 0x0601CA1C RID: 117276 RVA: 0x0040C174 File Offset: 0x0040A374
		public void UnPackTo(IDangoBrawlLevelT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.ItemList = new List<TTwoDimensionItemUnion>();
			for (int i = 0; i < this.ItemListLength; i++)
			{
				TTwoDimensionItemUnion ttwoDimensionItemUnion = new TTwoDimensionItemUnion();
				ttwoDimensionItemUnion.Type = this.ItemListType(i);
				switch (this.ItemListType(i))
				{
				case TTwoDimensionItem.IDangoBrawlBag:
					ttwoDimensionItemUnion.Value = ((this.ItemList<IDangoBrawlBag>(i) != null) ? this.ItemList<IDangoBrawlBag>(i).Value.UnPack() : null);
					break;
				case TTwoDimensionItem.IDangoBrawlItem:
					ttwoDimensionItemUnion.Value = ((this.ItemList<IDangoBrawlItem>(i) != null) ? this.ItemList<IDangoBrawlItem>(i).Value.UnPack() : null);
					break;
				case TTwoDimensionItem.IMarbleCommonItem:
					ttwoDimensionItemUnion.Value = ((this.ItemList<IMarbleCommonItem>(i) != null) ? this.ItemList<IMarbleCommonItem>(i).Value.UnPack() : null);
					break;
				case TTwoDimensionItem.IMarbleSpawnPoint:
					ttwoDimensionItemUnion.Value = ((this.ItemList<IMarbleSpawnPoint>(i) != null) ? this.ItemList<IMarbleSpawnPoint>(i).Value.UnPack() : null);
					break;
				}
				_o.ItemList.Add(ttwoDimensionItemUnion);
			}
		}

		// Token: 0x0601CA1D RID: 117277 RVA: 0x0040C2D8 File Offset: 0x0040A4D8
		public static Offset<IDangoBrawlLevel> Pack(FlatBufferBuilder builder, IDangoBrawlLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlLevel>);
			}
			VectorOffset itemList_typeOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				TTwoDimensionItem[] array = new TTwoDimensionItem[_o.ItemList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ItemList[i].Type;
				}
				itemList_typeOffset = IDangoBrawlLevel.CreateItemListTypeVector(builder, array);
			}
			VectorOffset itemListOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				int[] array2 = new int[_o.ItemList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTwoDimensionItemUnion.Pack(builder, _o.ItemList[j]);
				}
				itemListOffset = IDangoBrawlLevel.CreateItemListVector(builder, array2);
			}
			return IDangoBrawlLevel.CreateIDangoBrawlLevel(builder, _o.Id, _o.Type, itemList_typeOffset, itemListOffset);
		}

		// Token: 0x0400CD7D RID: 52605
		private Table __p;
	}
}
