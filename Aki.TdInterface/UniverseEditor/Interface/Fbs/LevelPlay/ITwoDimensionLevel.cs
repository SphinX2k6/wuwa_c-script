using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A49 RID: 19017
	public struct ITwoDimensionLevel : IFlatbufferObject
	{
		// Token: 0x1700856D RID: 34157
		// (get) Token: 0x0601C916 RID: 117014 RVA: 0x00407FD4 File Offset: 0x004061D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C917 RID: 117015 RVA: 0x00407FE1 File Offset: 0x004061E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C918 RID: 117016 RVA: 0x00407FE8 File Offset: 0x004061E8
		public static ITwoDimensionLevel GetRootAsITwoDimensionLevel(ByteBuffer _bb)
		{
			return ITwoDimensionLevel.GetRootAsITwoDimensionLevel(_bb, default(ITwoDimensionLevel));
		}

		// Token: 0x0601C919 RID: 117017 RVA: 0x00408004 File Offset: 0x00406204
		public static ITwoDimensionLevel GetRootAsITwoDimensionLevel(ByteBuffer _bb, ITwoDimensionLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C91A RID: 117018 RVA: 0x00408021 File Offset: 0x00406221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C91B RID: 117019 RVA: 0x00408030 File Offset: 0x00406230
		public ITwoDimensionLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700856E RID: 34158
		// (get) Token: 0x0601C91C RID: 117020 RVA: 0x00408040 File Offset: 0x00406240
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

		// Token: 0x1700856F RID: 34159
		// (get) Token: 0x0601C91D RID: 117021 RVA: 0x0040807C File Offset: 0x0040627C
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

		// Token: 0x0601C91E RID: 117022 RVA: 0x004080B8 File Offset: 0x004062B8
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008570 RID: 34160
		// (get) Token: 0x0601C91F RID: 117023 RVA: 0x004080F8 File Offset: 0x004062F8
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

		// Token: 0x0601C920 RID: 117024 RVA: 0x00408123 File Offset: 0x00406323
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601C921 RID: 117025 RVA: 0x00408134 File Offset: 0x00406334
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

		// Token: 0x0601C922 RID: 117026 RVA: 0x004081A0 File Offset: 0x004063A0
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008571 RID: 34161
		// (get) Token: 0x0601C923 RID: 117027 RVA: 0x004081E8 File Offset: 0x004063E8
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

		// Token: 0x0601C924 RID: 117028 RVA: 0x00408214 File Offset: 0x00406414
		public static Offset<ITwoDimensionLevel> CreateITwoDimensionLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ITwoDimensionLevel.AddItemList(builder, ItemListOffset);
			ITwoDimensionLevel.AddItemListType(builder, ItemList_typeOffset);
			ITwoDimensionLevel.AddId(builder, Id);
			ITwoDimensionLevel.AddType(builder, Type);
			return ITwoDimensionLevel.EndITwoDimensionLevel(builder);
		}

		// Token: 0x0601C925 RID: 117029 RVA: 0x00408240 File Offset: 0x00406440
		public static void StartITwoDimensionLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C926 RID: 117030 RVA: 0x00408249 File Offset: 0x00406449
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C927 RID: 117031 RVA: 0x00408254 File Offset: 0x00406454
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601C928 RID: 117032 RVA: 0x0040825F File Offset: 0x0040645F
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601C929 RID: 117033 RVA: 0x00408270 File Offset: 0x00406470
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C92A RID: 117034 RVA: 0x004082A7 File Offset: 0x004064A7
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C92B RID: 117035 RVA: 0x004082C1 File Offset: 0x004064C1
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C92C RID: 117036 RVA: 0x004082DF File Offset: 0x004064DF
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C92D RID: 117037 RVA: 0x004082F8 File Offset: 0x004064F8
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C92E RID: 117038 RVA: 0x00408303 File Offset: 0x00406503
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601C92F RID: 117039 RVA: 0x00408314 File Offset: 0x00406514
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C930 RID: 117040 RVA: 0x0040834B File Offset: 0x0040654B
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C931 RID: 117041 RVA: 0x00408365 File Offset: 0x00406565
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C932 RID: 117042 RVA: 0x00408383 File Offset: 0x00406583
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C933 RID: 117043 RVA: 0x0040839C File Offset: 0x0040659C
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C934 RID: 117044 RVA: 0x004083A7 File Offset: 0x004065A7
		public static Offset<ITwoDimensionLevel> EndITwoDimensionLevel(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionLevel>(builder.EndTable());
		}

		// Token: 0x0601C935 RID: 117045 RVA: 0x004083B4 File Offset: 0x004065B4
		public ITwoDimensionLevelT UnPack()
		{
			ITwoDimensionLevelT twoDimensionLevelT = new ITwoDimensionLevelT();
			this.UnPackTo(twoDimensionLevelT);
			return twoDimensionLevelT;
		}

		// Token: 0x0601C936 RID: 117046 RVA: 0x004083D0 File Offset: 0x004065D0
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

		// Token: 0x0601C937 RID: 117047 RVA: 0x00408534 File Offset: 0x00406734
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

		// Token: 0x0400D0EF RID: 53487
		private Table __p;
	}
}
