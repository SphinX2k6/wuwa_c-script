using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB2 RID: 19634
	public struct IDangoBrawlLevel : IFlatbufferObject
	{
		// Token: 0x17008B23 RID: 35619
		// (get) Token: 0x0601E1F9 RID: 123385 RVA: 0x004386C7 File Offset: 0x004368C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E1FA RID: 123386 RVA: 0x004386D4 File Offset: 0x004368D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E1FB RID: 123387 RVA: 0x004386DC File Offset: 0x004368DC
		public static IDangoBrawlLevel GetRootAsIDangoBrawlLevel(ByteBuffer _bb)
		{
			return IDangoBrawlLevel.GetRootAsIDangoBrawlLevel(_bb, default(IDangoBrawlLevel));
		}

		// Token: 0x0601E1FC RID: 123388 RVA: 0x004386F8 File Offset: 0x004368F8
		public static IDangoBrawlLevel GetRootAsIDangoBrawlLevel(ByteBuffer _bb, IDangoBrawlLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E1FD RID: 123389 RVA: 0x00438715 File Offset: 0x00436915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E1FE RID: 123390 RVA: 0x00438724 File Offset: 0x00436924
		public IDangoBrawlLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B24 RID: 35620
		// (get) Token: 0x0601E1FF RID: 123391 RVA: 0x00438734 File Offset: 0x00436934
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

		// Token: 0x17008B25 RID: 35621
		// (get) Token: 0x0601E200 RID: 123392 RVA: 0x00438770 File Offset: 0x00436970
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

		// Token: 0x0601E201 RID: 123393 RVA: 0x004387AC File Offset: 0x004369AC
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008B26 RID: 35622
		// (get) Token: 0x0601E202 RID: 123394 RVA: 0x004387EC File Offset: 0x004369EC
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

		// Token: 0x0601E203 RID: 123395 RVA: 0x00438817 File Offset: 0x00436A17
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601E204 RID: 123396 RVA: 0x00438828 File Offset: 0x00436A28
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

		// Token: 0x0601E205 RID: 123397 RVA: 0x00438894 File Offset: 0x00436A94
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008B27 RID: 35623
		// (get) Token: 0x0601E206 RID: 123398 RVA: 0x004388DC File Offset: 0x00436ADC
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

		// Token: 0x0601E207 RID: 123399 RVA: 0x00438908 File Offset: 0x00436B08
		public static Offset<IDangoBrawlLevel> CreateIDangoBrawlLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IDangoBrawlLevel.AddItemList(builder, ItemListOffset);
			IDangoBrawlLevel.AddItemListType(builder, ItemList_typeOffset);
			IDangoBrawlLevel.AddId(builder, Id);
			IDangoBrawlLevel.AddType(builder, Type);
			return IDangoBrawlLevel.EndIDangoBrawlLevel(builder);
		}

		// Token: 0x0601E208 RID: 123400 RVA: 0x00438934 File Offset: 0x00436B34
		public static void StartIDangoBrawlLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E209 RID: 123401 RVA: 0x0043893D File Offset: 0x00436B3D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601E20A RID: 123402 RVA: 0x00438948 File Offset: 0x00436B48
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601E20B RID: 123403 RVA: 0x00438953 File Offset: 0x00436B53
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601E20C RID: 123404 RVA: 0x00438964 File Offset: 0x00436B64
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E20D RID: 123405 RVA: 0x0043899B File Offset: 0x00436B9B
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E20E RID: 123406 RVA: 0x004389B5 File Offset: 0x00436BB5
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E20F RID: 123407 RVA: 0x004389D3 File Offset: 0x00436BD3
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E210 RID: 123408 RVA: 0x004389EC File Offset: 0x00436BEC
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601E211 RID: 123409 RVA: 0x004389F7 File Offset: 0x00436BF7
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601E212 RID: 123410 RVA: 0x00438A08 File Offset: 0x00436C08
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E213 RID: 123411 RVA: 0x00438A3F File Offset: 0x00436C3F
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E214 RID: 123412 RVA: 0x00438A59 File Offset: 0x00436C59
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E215 RID: 123413 RVA: 0x00438A77 File Offset: 0x00436C77
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E216 RID: 123414 RVA: 0x00438A90 File Offset: 0x00436C90
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E217 RID: 123415 RVA: 0x00438A9B File Offset: 0x00436C9B
		public static Offset<IDangoBrawlLevel> EndIDangoBrawlLevel(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlLevel>(builder.EndTable());
		}

		// Token: 0x0601E218 RID: 123416 RVA: 0x00438AA8 File Offset: 0x00436CA8
		public IDangoBrawlLevelT UnPack()
		{
			IDangoBrawlLevelT dangoBrawlLevelT = new IDangoBrawlLevelT();
			this.UnPackTo(dangoBrawlLevelT);
			return dangoBrawlLevelT;
		}

		// Token: 0x0601E219 RID: 123417 RVA: 0x00438AC4 File Offset: 0x00436CC4
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

		// Token: 0x0601E21A RID: 123418 RVA: 0x00438C28 File Offset: 0x00436E28
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

		// Token: 0x0400D7B8 RID: 55224
		private Table __p;
	}
}
