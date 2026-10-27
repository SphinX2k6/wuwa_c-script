using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004889 RID: 18569
	public struct IMarbleLevel : IFlatbufferObject
	{
		// Token: 0x170086A9 RID: 34473
		// (get) Token: 0x0601CF72 RID: 118642 RVA: 0x00417C74 File Offset: 0x00415E74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF73 RID: 118643 RVA: 0x00417C81 File Offset: 0x00415E81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF74 RID: 118644 RVA: 0x00417C88 File Offset: 0x00415E88
		public static IMarbleLevel GetRootAsIMarbleLevel(ByteBuffer _bb)
		{
			return IMarbleLevel.GetRootAsIMarbleLevel(_bb, default(IMarbleLevel));
		}

		// Token: 0x0601CF75 RID: 118645 RVA: 0x00417CA4 File Offset: 0x00415EA4
		public static IMarbleLevel GetRootAsIMarbleLevel(ByteBuffer _bb, IMarbleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF76 RID: 118646 RVA: 0x00417CC1 File Offset: 0x00415EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF77 RID: 118647 RVA: 0x00417CD0 File Offset: 0x00415ED0
		public IMarbleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086AA RID: 34474
		// (get) Token: 0x0601CF78 RID: 118648 RVA: 0x00417CE0 File Offset: 0x00415EE0
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

		// Token: 0x170086AB RID: 34475
		// (get) Token: 0x0601CF79 RID: 118649 RVA: 0x00417D1C File Offset: 0x00415F1C
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

		// Token: 0x0601CF7A RID: 118650 RVA: 0x00417D58 File Offset: 0x00415F58
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170086AC RID: 34476
		// (get) Token: 0x0601CF7B RID: 118651 RVA: 0x00417D98 File Offset: 0x00415F98
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

		// Token: 0x0601CF7C RID: 118652 RVA: 0x00417DC3 File Offset: 0x00415FC3
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601CF7D RID: 118653 RVA: 0x00417DD4 File Offset: 0x00415FD4
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

		// Token: 0x0601CF7E RID: 118654 RVA: 0x00417E40 File Offset: 0x00416040
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170086AD RID: 34477
		// (get) Token: 0x0601CF7F RID: 118655 RVA: 0x00417E88 File Offset: 0x00416088
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

		// Token: 0x0601CF80 RID: 118656 RVA: 0x00417EB4 File Offset: 0x004160B4
		public static Offset<IMarbleLevel> CreateIMarbleLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IMarbleLevel.AddItemList(builder, ItemListOffset);
			IMarbleLevel.AddItemListType(builder, ItemList_typeOffset);
			IMarbleLevel.AddId(builder, Id);
			IMarbleLevel.AddType(builder, Type);
			return IMarbleLevel.EndIMarbleLevel(builder);
		}

		// Token: 0x0601CF81 RID: 118657 RVA: 0x00417EE0 File Offset: 0x004160E0
		public static void StartIMarbleLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CF82 RID: 118658 RVA: 0x00417EE9 File Offset: 0x004160E9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601CF83 RID: 118659 RVA: 0x00417EF4 File Offset: 0x004160F4
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601CF84 RID: 118660 RVA: 0x00417EFF File Offset: 0x004160FF
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601CF85 RID: 118661 RVA: 0x00417F10 File Offset: 0x00416110
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CF86 RID: 118662 RVA: 0x00417F47 File Offset: 0x00416147
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CF87 RID: 118663 RVA: 0x00417F61 File Offset: 0x00416161
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CF88 RID: 118664 RVA: 0x00417F7F File Offset: 0x0041617F
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CF89 RID: 118665 RVA: 0x00417F98 File Offset: 0x00416198
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601CF8A RID: 118666 RVA: 0x00417FA3 File Offset: 0x004161A3
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601CF8B RID: 118667 RVA: 0x00417FB4 File Offset: 0x004161B4
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CF8C RID: 118668 RVA: 0x00417FEB File Offset: 0x004161EB
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CF8D RID: 118669 RVA: 0x00418005 File Offset: 0x00416205
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CF8E RID: 118670 RVA: 0x00418023 File Offset: 0x00416223
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CF8F RID: 118671 RVA: 0x0041803C File Offset: 0x0041623C
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CF90 RID: 118672 RVA: 0x00418047 File Offset: 0x00416247
		public static Offset<IMarbleLevel> EndIMarbleLevel(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleLevel>(builder.EndTable());
		}

		// Token: 0x0601CF91 RID: 118673 RVA: 0x00418054 File Offset: 0x00416254
		public IMarbleLevelT UnPack()
		{
			IMarbleLevelT marbleLevelT = new IMarbleLevelT();
			this.UnPackTo(marbleLevelT);
			return marbleLevelT;
		}

		// Token: 0x0601CF92 RID: 118674 RVA: 0x00418070 File Offset: 0x00416270
		public void UnPackTo(IMarbleLevelT _o)
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

		// Token: 0x0601CF93 RID: 118675 RVA: 0x004181D4 File Offset: 0x004163D4
		public static Offset<IMarbleLevel> Pack(FlatBufferBuilder builder, IMarbleLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarbleLevel>);
			}
			VectorOffset itemList_typeOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				TTwoDimensionItem[] array = new TTwoDimensionItem[_o.ItemList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ItemList[i].Type;
				}
				itemList_typeOffset = IMarbleLevel.CreateItemListTypeVector(builder, array);
			}
			VectorOffset itemListOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				int[] array2 = new int[_o.ItemList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTwoDimensionItemUnion.Pack(builder, _o.ItemList[j]);
				}
				itemListOffset = IMarbleLevel.CreateItemListVector(builder, array2);
			}
			return IMarbleLevel.CreateIMarbleLevel(builder, _o.Id, _o.Type, itemList_typeOffset, itemListOffset);
		}

		// Token: 0x0400CE6F RID: 52847
		private Table __p;
	}
}
