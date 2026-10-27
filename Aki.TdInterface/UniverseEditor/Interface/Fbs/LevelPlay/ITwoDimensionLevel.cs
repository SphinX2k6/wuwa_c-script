using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E1 RID: 17889
	public struct ITwoDimensionLevel : IFlatbufferObject
	{
		// Token: 0x17007F2C RID: 32556
		// (get) Token: 0x0601B141 RID: 110913 RVA: 0x003DBD38 File Offset: 0x003D9F38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B142 RID: 110914 RVA: 0x003DBD45 File Offset: 0x003D9F45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B143 RID: 110915 RVA: 0x003DBD4C File Offset: 0x003D9F4C
		public static ITwoDimensionLevel GetRootAsITwoDimensionLevel(ByteBuffer _bb)
		{
			return ITwoDimensionLevel.GetRootAsITwoDimensionLevel(_bb, default(ITwoDimensionLevel));
		}

		// Token: 0x0601B144 RID: 110916 RVA: 0x003DBD68 File Offset: 0x003D9F68
		public static ITwoDimensionLevel GetRootAsITwoDimensionLevel(ByteBuffer _bb, ITwoDimensionLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B145 RID: 110917 RVA: 0x003DBD85 File Offset: 0x003D9F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B146 RID: 110918 RVA: 0x003DBD94 File Offset: 0x003D9F94
		public ITwoDimensionLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F2D RID: 32557
		// (get) Token: 0x0601B147 RID: 110919 RVA: 0x003DBDA4 File Offset: 0x003D9FA4
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

		// Token: 0x17007F2E RID: 32558
		// (get) Token: 0x0601B148 RID: 110920 RVA: 0x003DBDE0 File Offset: 0x003D9FE0
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

		// Token: 0x0601B149 RID: 110921 RVA: 0x003DBE1C File Offset: 0x003DA01C
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007F2F RID: 32559
		// (get) Token: 0x0601B14A RID: 110922 RVA: 0x003DBE5C File Offset: 0x003DA05C
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

		// Token: 0x0601B14B RID: 110923 RVA: 0x003DBE87 File Offset: 0x003DA087
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601B14C RID: 110924 RVA: 0x003DBE98 File Offset: 0x003DA098
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

		// Token: 0x0601B14D RID: 110925 RVA: 0x003DBF04 File Offset: 0x003DA104
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007F30 RID: 32560
		// (get) Token: 0x0601B14E RID: 110926 RVA: 0x003DBF4C File Offset: 0x003DA14C
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

		// Token: 0x0601B14F RID: 110927 RVA: 0x003DBF78 File Offset: 0x003DA178
		public static Offset<ITwoDimensionLevel> CreateITwoDimensionLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ITwoDimensionLevel.AddItemList(builder, ItemListOffset);
			ITwoDimensionLevel.AddItemListType(builder, ItemList_typeOffset);
			ITwoDimensionLevel.AddId(builder, Id);
			ITwoDimensionLevel.AddType(builder, Type);
			return ITwoDimensionLevel.EndITwoDimensionLevel(builder);
		}

		// Token: 0x0601B150 RID: 110928 RVA: 0x003DBFA4 File Offset: 0x003DA1A4
		public static void StartITwoDimensionLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B151 RID: 110929 RVA: 0x003DBFAD File Offset: 0x003DA1AD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B152 RID: 110930 RVA: 0x003DBFB8 File Offset: 0x003DA1B8
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601B153 RID: 110931 RVA: 0x003DBFC3 File Offset: 0x003DA1C3
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601B154 RID: 110932 RVA: 0x003DBFD4 File Offset: 0x003DA1D4
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B155 RID: 110933 RVA: 0x003DC00B File Offset: 0x003DA20B
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B156 RID: 110934 RVA: 0x003DC025 File Offset: 0x003DA225
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B157 RID: 110935 RVA: 0x003DC043 File Offset: 0x003DA243
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B158 RID: 110936 RVA: 0x003DC05C File Offset: 0x003DA25C
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B159 RID: 110937 RVA: 0x003DC067 File Offset: 0x003DA267
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601B15A RID: 110938 RVA: 0x003DC078 File Offset: 0x003DA278
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B15B RID: 110939 RVA: 0x003DC0AF File Offset: 0x003DA2AF
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B15C RID: 110940 RVA: 0x003DC0C9 File Offset: 0x003DA2C9
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B15D RID: 110941 RVA: 0x003DC0E7 File Offset: 0x003DA2E7
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B15E RID: 110942 RVA: 0x003DC100 File Offset: 0x003DA300
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B15F RID: 110943 RVA: 0x003DC10B File Offset: 0x003DA30B
		public static Offset<ITwoDimensionLevel> EndITwoDimensionLevel(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionLevel>(builder.EndTable());
		}

		// Token: 0x0601B160 RID: 110944 RVA: 0x003DC118 File Offset: 0x003DA318
		public ITwoDimensionLevelT UnPack()
		{
			ITwoDimensionLevelT twoDimensionLevelT = new ITwoDimensionLevelT();
			this.UnPackTo(twoDimensionLevelT);
			return twoDimensionLevelT;
		}

		// Token: 0x0601B161 RID: 110945 RVA: 0x003DC134 File Offset: 0x003DA334
		public void UnPackTo(ITwoDimensionLevelT _o)
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

		// Token: 0x0601B162 RID: 110946 RVA: 0x003DC298 File Offset: 0x003DA498
		public static Offset<ITwoDimensionLevel> Pack(FlatBufferBuilder builder, ITwoDimensionLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionLevel>);
			}
			VectorOffset itemList_typeOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				TTwoDimensionItem[] array = new TTwoDimensionItem[_o.ItemList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ItemList[i].Type;
				}
				itemList_typeOffset = ITwoDimensionLevel.CreateItemListTypeVector(builder, array);
			}
			VectorOffset itemListOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				int[] array2 = new int[_o.ItemList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTwoDimensionItemUnion.Pack(builder, _o.ItemList[j]);
				}
				itemListOffset = ITwoDimensionLevel.CreateItemListVector(builder, array2);
			}
			return ITwoDimensionLevel.CreateITwoDimensionLevel(builder, _o.Id, _o.Type, itemList_typeOffset, itemListOffset);
		}

		// Token: 0x0400C6C0 RID: 50880
		private Table __p;
	}
}
