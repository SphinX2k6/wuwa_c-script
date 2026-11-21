using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CEE RID: 19694
	public struct IMarbleLevel : IFlatbufferObject
	{
		// Token: 0x17008CF1 RID: 36081
		// (get) Token: 0x0601E75F RID: 124767 RVA: 0x00444410 File Offset: 0x00442610
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E760 RID: 124768 RVA: 0x0044441D File Offset: 0x0044261D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E761 RID: 124769 RVA: 0x00444424 File Offset: 0x00442624
		public static IMarbleLevel GetRootAsIMarbleLevel(ByteBuffer _bb)
		{
			return IMarbleLevel.GetRootAsIMarbleLevel(_bb, default(IMarbleLevel));
		}

		// Token: 0x0601E762 RID: 124770 RVA: 0x00444440 File Offset: 0x00442640
		public static IMarbleLevel GetRootAsIMarbleLevel(ByteBuffer _bb, IMarbleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E763 RID: 124771 RVA: 0x0044445D File Offset: 0x0044265D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E764 RID: 124772 RVA: 0x0044446C File Offset: 0x0044266C
		public IMarbleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CF2 RID: 36082
		// (get) Token: 0x0601E765 RID: 124773 RVA: 0x0044447C File Offset: 0x0044267C
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

		// Token: 0x17008CF3 RID: 36083
		// (get) Token: 0x0601E766 RID: 124774 RVA: 0x004444B8 File Offset: 0x004426B8
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

		// Token: 0x0601E767 RID: 124775 RVA: 0x004444F4 File Offset: 0x004426F4
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008CF4 RID: 36084
		// (get) Token: 0x0601E768 RID: 124776 RVA: 0x00444534 File Offset: 0x00442734
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

		// Token: 0x0601E769 RID: 124777 RVA: 0x0044455F File Offset: 0x0044275F
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601E76A RID: 124778 RVA: 0x00444570 File Offset: 0x00442770
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

		// Token: 0x0601E76B RID: 124779 RVA: 0x004445DC File Offset: 0x004427DC
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008CF5 RID: 36085
		// (get) Token: 0x0601E76C RID: 124780 RVA: 0x00444624 File Offset: 0x00442824
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

		// Token: 0x0601E76D RID: 124781 RVA: 0x00444650 File Offset: 0x00442850
		public static Offset<IMarbleLevel> CreateIMarbleLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IMarbleLevel.AddItemList(builder, ItemListOffset);
			IMarbleLevel.AddItemListType(builder, ItemList_typeOffset);
			IMarbleLevel.AddId(builder, Id);
			IMarbleLevel.AddType(builder, Type);
			return IMarbleLevel.EndIMarbleLevel(builder);
		}

		// Token: 0x0601E76E RID: 124782 RVA: 0x0044467C File Offset: 0x0044287C
		public static void StartIMarbleLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E76F RID: 124783 RVA: 0x00444685 File Offset: 0x00442885
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601E770 RID: 124784 RVA: 0x00444690 File Offset: 0x00442890
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601E771 RID: 124785 RVA: 0x0044469B File Offset: 0x0044289B
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601E772 RID: 124786 RVA: 0x004446AC File Offset: 0x004428AC
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E773 RID: 124787 RVA: 0x004446E3 File Offset: 0x004428E3
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E774 RID: 124788 RVA: 0x004446FD File Offset: 0x004428FD
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E775 RID: 124789 RVA: 0x0044471B File Offset: 0x0044291B
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E776 RID: 124790 RVA: 0x00444734 File Offset: 0x00442934
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601E777 RID: 124791 RVA: 0x0044473F File Offset: 0x0044293F
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601E778 RID: 124792 RVA: 0x00444750 File Offset: 0x00442950
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E779 RID: 124793 RVA: 0x00444787 File Offset: 0x00442987
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E77A RID: 124794 RVA: 0x004447A1 File Offset: 0x004429A1
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E77B RID: 124795 RVA: 0x004447BF File Offset: 0x004429BF
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E77C RID: 124796 RVA: 0x004447D8 File Offset: 0x004429D8
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E77D RID: 124797 RVA: 0x004447E3 File Offset: 0x004429E3
		public static Offset<IMarbleLevel> EndIMarbleLevel(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleLevel>(builder.EndTable());
		}

		// Token: 0x0601E77E RID: 124798 RVA: 0x004447F0 File Offset: 0x004429F0
		public IMarbleLevelT UnPack()
		{
			IMarbleLevelT marbleLevelT = new IMarbleLevelT();
			this.UnPackTo(marbleLevelT);
			return marbleLevelT;
		}

		// Token: 0x0601E77F RID: 124799 RVA: 0x0044480C File Offset: 0x00442A0C
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

		// Token: 0x0601E780 RID: 124800 RVA: 0x00444970 File Offset: 0x00442B70
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

		// Token: 0x0400D8A8 RID: 55464
		private Table __p;
	}
}
