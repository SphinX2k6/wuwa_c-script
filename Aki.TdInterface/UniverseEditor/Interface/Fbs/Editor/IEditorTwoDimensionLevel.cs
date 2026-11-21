using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD9 RID: 19673
	public struct IEditorTwoDimensionLevel : IFlatbufferObject
	{
		// Token: 0x17008C7F RID: 35967
		// (get) Token: 0x0601E607 RID: 124423 RVA: 0x004418CA File Offset: 0x0043FACA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E608 RID: 124424 RVA: 0x004418D7 File Offset: 0x0043FAD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E609 RID: 124425 RVA: 0x004418E0 File Offset: 0x0043FAE0
		public static IEditorTwoDimensionLevel GetRootAsIEditorTwoDimensionLevel(ByteBuffer _bb)
		{
			return IEditorTwoDimensionLevel.GetRootAsIEditorTwoDimensionLevel(_bb, default(IEditorTwoDimensionLevel));
		}

		// Token: 0x0601E60A RID: 124426 RVA: 0x004418FC File Offset: 0x0043FAFC
		public static IEditorTwoDimensionLevel GetRootAsIEditorTwoDimensionLevel(ByteBuffer _bb, IEditorTwoDimensionLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E60B RID: 124427 RVA: 0x00441919 File Offset: 0x0043FB19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E60C RID: 124428 RVA: 0x00441928 File Offset: 0x0043FB28
		public IEditorTwoDimensionLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C80 RID: 35968
		// (get) Token: 0x0601E60D RID: 124429 RVA: 0x00441938 File Offset: 0x0043FB38
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

		// Token: 0x17008C81 RID: 35969
		// (get) Token: 0x0601E60E RID: 124430 RVA: 0x00441974 File Offset: 0x0043FB74
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

		// Token: 0x0601E60F RID: 124431 RVA: 0x004419B0 File Offset: 0x0043FBB0
		public TTwoDimensionItem ItemListType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TTwoDimensionItem.NONE;
			}
			return (TTwoDimensionItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008C82 RID: 35970
		// (get) Token: 0x0601E610 RID: 124432 RVA: 0x004419F0 File Offset: 0x0043FBF0
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

		// Token: 0x0601E611 RID: 124433 RVA: 0x00441A1B File Offset: 0x0043FC1B
		public Span<TTwoDimensionItem> GetItemListTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionItem>(8, 1);
		}

		// Token: 0x0601E612 RID: 124434 RVA: 0x00441A2C File Offset: 0x0043FC2C
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

		// Token: 0x0601E613 RID: 124435 RVA: 0x00441A98 File Offset: 0x0043FC98
		public TTable? ItemList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008C83 RID: 35971
		// (get) Token: 0x0601E614 RID: 124436 RVA: 0x00441AE0 File Offset: 0x0043FCE0
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

		// Token: 0x0601E615 RID: 124437 RVA: 0x00441B0C File Offset: 0x0043FD0C
		public static Offset<IEditorTwoDimensionLevel> CreateIEditorTwoDimensionLevel(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, VectorOffset ItemList_typeOffset = default(VectorOffset), VectorOffset ItemListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IEditorTwoDimensionLevel.AddItemList(builder, ItemListOffset);
			IEditorTwoDimensionLevel.AddItemListType(builder, ItemList_typeOffset);
			IEditorTwoDimensionLevel.AddId(builder, Id);
			IEditorTwoDimensionLevel.AddType(builder, Type);
			return IEditorTwoDimensionLevel.EndIEditorTwoDimensionLevel(builder);
		}

		// Token: 0x0601E616 RID: 124438 RVA: 0x00441B38 File Offset: 0x0043FD38
		public static void StartIEditorTwoDimensionLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E617 RID: 124439 RVA: 0x00441B41 File Offset: 0x0043FD41
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601E618 RID: 124440 RVA: 0x00441B4C File Offset: 0x0043FD4C
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601E619 RID: 124441 RVA: 0x00441B57 File Offset: 0x0043FD57
		public static void AddItemListType(FlatBufferBuilder builder, VectorOffset itemListTypeOffset)
		{
			builder.AddOffset(2, itemListTypeOffset.Value, 0);
		}

		// Token: 0x0601E61A RID: 124442 RVA: 0x00441B68 File Offset: 0x0043FD68
		public static VectorOffset CreateItemListTypeVector(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E61B RID: 124443 RVA: 0x00441B9F File Offset: 0x0043FD9F
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E61C RID: 124444 RVA: 0x00441BB9 File Offset: 0x0043FDB9
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E61D RID: 124445 RVA: 0x00441BD7 File Offset: 0x0043FDD7
		public static VectorOffset CreateItemListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E61E RID: 124446 RVA: 0x00441BF0 File Offset: 0x0043FDF0
		public static void StartItemListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601E61F RID: 124447 RVA: 0x00441BFB File Offset: 0x0043FDFB
		public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset)
		{
			builder.AddOffset(3, itemListOffset.Value, 0);
		}

		// Token: 0x0601E620 RID: 124448 RVA: 0x00441C0C File Offset: 0x0043FE0C
		public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E621 RID: 124449 RVA: 0x00441C43 File Offset: 0x0043FE43
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E622 RID: 124450 RVA: 0x00441C5D File Offset: 0x0043FE5D
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E623 RID: 124451 RVA: 0x00441C7B File Offset: 0x0043FE7B
		public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E624 RID: 124452 RVA: 0x00441C94 File Offset: 0x0043FE94
		public static void StartItemListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E625 RID: 124453 RVA: 0x00441C9F File Offset: 0x0043FE9F
		public static Offset<IEditorTwoDimensionLevel> EndIEditorTwoDimensionLevel(FlatBufferBuilder builder)
		{
			return new Offset<IEditorTwoDimensionLevel>(builder.EndTable());
		}

		// Token: 0x0601E626 RID: 124454 RVA: 0x00441CAC File Offset: 0x0043FEAC
		public IEditorTwoDimensionLevelT UnPack()
		{
			IEditorTwoDimensionLevelT editorTwoDimensionLevelT = new IEditorTwoDimensionLevelT();
			this.UnPackTo(editorTwoDimensionLevelT);
			return editorTwoDimensionLevelT;
		}

		// Token: 0x0601E627 RID: 124455 RVA: 0x00441CC8 File Offset: 0x0043FEC8
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

		// Token: 0x0601E628 RID: 124456 RVA: 0x00441E2C File Offset: 0x0044002C
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

		// Token: 0x0400D86C RID: 55404
		private Table __p;
	}
}
