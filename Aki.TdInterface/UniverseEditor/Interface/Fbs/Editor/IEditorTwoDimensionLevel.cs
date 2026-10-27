using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004874 RID: 18548
	public struct IEditorTwoDimensionLevel : IFlatbufferObject
	{
		// Token: 0x17008637 RID: 34359
		// (get) Token: 0x0601CE1A RID: 118298 RVA: 0x0041512F File Offset: 0x0041332F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE1B RID: 118299 RVA: 0x0041513C File Offset: 0x0041333C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE1C RID: 118300 RVA: 0x00415144 File Offset: 0x00413344
		public static IEditorTwoDimensionLevel GetRootAsIEditorTwoDimensionLevel(ByteBuffer _bb)
		{
			return IEditorTwoDimensionLevel.GetRootAsIEditorTwoDimensionLevel(_bb, default(IEditorTwoDimensionLevel));
		}

		// Token: 0x0601CE1D RID: 118301 RVA: 0x00415160 File Offset: 0x00413360
		public static IEditorTwoDimensionLevel GetRootAsIEditorTwoDimensionLevel(ByteBuffer _bb, IEditorTwoDimensionLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE1E RID: 118302 RVA: 0x0041517D File Offset: 0x0041337D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE1F RID: 118303 RVA: 0x0041518C File Offset: 0x0041338C
		public IEditorTwoDimensionLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008638 RID: 34360
		// (get) Token: 0x0601CE20 RID: 118304 RVA: 0x0041519C File Offset: 0x0041339C
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

		// Token: 0x17008639 RID: 34361
		// (get) Token: 0x0601CE21 RID: 118305 RVA: 0x004151D8 File Offset: 0x004133D8
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

		// Token: 0x0601CE22 RID: 118306 RVA: 0x00415214 File Offset: 0x00413414
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700863A RID: 34362
		// (get) Token: 0x0601CE23 RID: 118307 RVA: 0x00415254 File Offset: 0x00413454
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

		// Token: 0x0601CE24 RID: 118308 RVA: 0x0041527F File Offset: 0x0041347F
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601CE25 RID: 118309 RVA: 0x00415290 File Offset: 0x00413490
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

		// Token: 0x0601CE26 RID: 118310 RVA: 0x004152FC File Offset: 0x004134FC
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700863B RID: 34363
		// (get) Token: 0x0601CE27 RID: 118311 RVA: 0x00415344 File Offset: 0x00413544
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

		// Token: 0x0601CE28 RID: 118312 RVA: 0x00415370 File Offset: 0x00413570
		public static Offset<IEditorTwoDimensionLevel> CreateIEditorTwoDimensionLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IEditorTwoDimensionLevel.AddItemList(builder, ItemListOffset);
			IEditorTwoDimensionLevel.AddItemListType(builder, ItemList_typeOffset);
			IEditorTwoDimensionLevel.AddId(builder, Id);
			IEditorTwoDimensionLevel.AddType(builder, Type);
			return IEditorTwoDimensionLevel.EndIEditorTwoDimensionLevel(builder);
		}

		// Token: 0x0601CE29 RID: 118313 RVA: 0x0041539C File Offset: 0x0041359C
		public static void StartIEditorTwoDimensionLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CE2A RID: 118314 RVA: 0x004153A5 File Offset: 0x004135A5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601CE2B RID: 118315 RVA: 0x004153B0 File Offset: 0x004135B0
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601CE2C RID: 118316 RVA: 0x004153BB File Offset: 0x004135BB
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601CE2D RID: 118317 RVA: 0x004153CC File Offset: 0x004135CC
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CE2E RID: 118318 RVA: 0x00415403 File Offset: 0x00413603
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CE2F RID: 118319 RVA: 0x0041541D File Offset: 0x0041361D
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CE30 RID: 118320 RVA: 0x0041543B File Offset: 0x0041363B
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CE31 RID: 118321 RVA: 0x00415454 File Offset: 0x00413654
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601CE32 RID: 118322 RVA: 0x0041545F File Offset: 0x0041365F
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601CE33 RID: 118323 RVA: 0x00415470 File Offset: 0x00413670
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CE34 RID: 118324 RVA: 0x004154A7 File Offset: 0x004136A7
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CE35 RID: 118325 RVA: 0x004154C1 File Offset: 0x004136C1
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CE36 RID: 118326 RVA: 0x004154DF File Offset: 0x004136DF
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CE37 RID: 118327 RVA: 0x004154F8 File Offset: 0x004136F8
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CE38 RID: 118328 RVA: 0x00415503 File Offset: 0x00413703
		public static Offset<IEditorTwoDimensionLevel> EndIEditorTwoDimensionLevel(FlatBufferBuilder builder)
		{
			return new Offset<IEditorTwoDimensionLevel>(builder.EndTable());
		}

		// Token: 0x0601CE39 RID: 118329 RVA: 0x00415510 File Offset: 0x00413710
		public IEditorTwoDimensionLevelT UnPack()
		{
			IEditorTwoDimensionLevelT editorTwoDimensionLevelT = new IEditorTwoDimensionLevelT();
			this.UnPackTo(editorTwoDimensionLevelT);
			return editorTwoDimensionLevelT;
		}

		// Token: 0x0601CE3A RID: 118330 RVA: 0x0041552C File Offset: 0x0041372C
		public void UnPackTo(IEditorTwoDimensionLevelT _o)
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

		// Token: 0x0601CE3B RID: 118331 RVA: 0x00415690 File Offset: 0x00413890
		public static Offset<IEditorTwoDimensionLevel> Pack(FlatBufferBuilder builder, IEditorTwoDimensionLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorTwoDimensionLevel>);
			}
			VectorOffset itemList_typeOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				TTwoDimensionItem[] array = new TTwoDimensionItem[_o.ItemList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ItemList[i].Type;
				}
				itemList_typeOffset = IEditorTwoDimensionLevel.CreateItemListTypeVector(builder, array);
			}
			VectorOffset itemListOffset = default(VectorOffset);
			if (_o.ItemList != null)
			{
				int[] array2 = new int[_o.ItemList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTwoDimensionItemUnion.Pack(builder, _o.ItemList[j]);
				}
				itemListOffset = IEditorTwoDimensionLevel.CreateItemListVector(builder, array2);
			}
			return IEditorTwoDimensionLevel.CreateIEditorTwoDimensionLevel(builder, _o.Id, _o.Type, itemList_typeOffset, itemListOffset);
		}

		// Token: 0x0400CE33 RID: 52787
		private Table __p;
	}
}
