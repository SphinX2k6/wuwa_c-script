using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049CE RID: 18894
	public struct IRollBlockGridEmpty : IFlatbufferObject
	{
		// Token: 0x17008451 RID: 33873
		// (get) Token: 0x0601C41A RID: 115738 RVA: 0x003FD88A File Offset: 0x003FBA8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C41B RID: 115739 RVA: 0x003FD897 File Offset: 0x003FBA97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C41C RID: 115740 RVA: 0x003FD8A0 File Offset: 0x003FBAA0
		public static IRollBlockGridEmpty GetRootAsIRollBlockGridEmpty(ByteBuffer _bb)
		{
			return IRollBlockGridEmpty.GetRootAsIRollBlockGridEmpty(_bb, default(IRollBlockGridEmpty));
		}

		// Token: 0x0601C41D RID: 115741 RVA: 0x003FD8BC File Offset: 0x003FBABC
		public static IRollBlockGridEmpty GetRootAsIRollBlockGridEmpty(ByteBuffer _bb, IRollBlockGridEmpty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C41E RID: 115742 RVA: 0x003FD8D9 File Offset: 0x003FBAD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C41F RID: 115743 RVA: 0x003FD8E8 File Offset: 0x003FBAE8
		public IRollBlockGridEmpty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008452 RID: 33874
		// (get) Token: 0x0601C420 RID: 115744 RVA: 0x003FD8F8 File Offset: 0x003FBAF8
		public ERollBlockGridType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockGridType.Empty;
				}
				return (ERollBlockGridType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008453 RID: 33875
		// (get) Token: 0x0601C421 RID: 115745 RVA: 0x003FD934 File Offset: 0x003FBB34
		public TRollBlock BlockType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TRollBlock.NONE;
				}
				return (TRollBlock)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C422 RID: 115746 RVA: 0x003FD970 File Offset: 0x003FBB70
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C423 RID: 115747 RVA: 0x003FD9B4 File Offset: 0x003FBBB4
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C424 RID: 115748 RVA: 0x003FD9D0 File Offset: 0x003FBBD0
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C425 RID: 115749 RVA: 0x003FD9EC File Offset: 0x003FBBEC
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008454 RID: 33876
		// (get) Token: 0x0601C426 RID: 115750 RVA: 0x003FDA2C File Offset: 0x003FBC2C
		public int ItemsTypeLength
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

		// Token: 0x0601C427 RID: 115751 RVA: 0x003FDA58 File Offset: 0x003FBC58
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C428 RID: 115752 RVA: 0x003FDA68 File Offset: 0x003FBC68
		public TRollBlockItem[] GetItemsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TRollBlockItem[] array = new TRollBlockItem[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TRollBlockItem)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601C429 RID: 115753 RVA: 0x003FDAD4 File Offset: 0x003FBCD4
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008455 RID: 33877
		// (get) Token: 0x0601C42A RID: 115754 RVA: 0x003FDB1C File Offset: 0x003FBD1C
		public int ItemsLength
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

		// Token: 0x17008456 RID: 33878
		// (get) Token: 0x0601C42B RID: 115755 RVA: 0x003FDB48 File Offset: 0x003FBD48
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

		// Token: 0x0601C42C RID: 115756 RVA: 0x003FDB85 File Offset: 0x003FBD85
		public static Offset<IRollBlockGridEmpty> CreateIRollBlockGridEmpty(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRollBlockGridEmpty.AddItems(builder, ItemsOffset);
			IRollBlockGridEmpty.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridEmpty.AddBlock(builder, BlockOffset);
			IRollBlockGridEmpty.AddNullMask(builder, NullMask);
			IRollBlockGridEmpty.AddBlockType(builder, Block_type);
			IRollBlockGridEmpty.AddType(builder, Type);
			return IRollBlockGridEmpty.EndIRollBlockGridEmpty(builder);
		}

		// Token: 0x0601C42D RID: 115757 RVA: 0x003FDBC1 File Offset: 0x003FBDC1
		public static void StartIRollBlockGridEmpty(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C42E RID: 115758 RVA: 0x003FDBCA File Offset: 0x003FBDCA
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C42F RID: 115759 RVA: 0x003FDBD5 File Offset: 0x003FBDD5
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C430 RID: 115760 RVA: 0x003FDBE0 File Offset: 0x003FBDE0
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C431 RID: 115761 RVA: 0x003FDBEB File Offset: 0x003FBDEB
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C432 RID: 115762 RVA: 0x003FDBFC File Offset: 0x003FBDFC
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C433 RID: 115763 RVA: 0x003FDC33 File Offset: 0x003FBE33
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C434 RID: 115764 RVA: 0x003FDC4D File Offset: 0x003FBE4D
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C435 RID: 115765 RVA: 0x003FDC6B File Offset: 0x003FBE6B
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C436 RID: 115766 RVA: 0x003FDC84 File Offset: 0x003FBE84
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C437 RID: 115767 RVA: 0x003FDC8F File Offset: 0x003FBE8F
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C438 RID: 115768 RVA: 0x003FDCA0 File Offset: 0x003FBEA0
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C439 RID: 115769 RVA: 0x003FDCD7 File Offset: 0x003FBED7
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C43A RID: 115770 RVA: 0x003FDCF1 File Offset: 0x003FBEF1
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C43B RID: 115771 RVA: 0x003FDD0F File Offset: 0x003FBF0F
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C43C RID: 115772 RVA: 0x003FDD28 File Offset: 0x003FBF28
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C43D RID: 115773 RVA: 0x003FDD33 File Offset: 0x003FBF33
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601C43E RID: 115774 RVA: 0x003FDD3E File Offset: 0x003FBF3E
		public static Offset<IRollBlockGridEmpty> EndIRollBlockGridEmpty(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridEmpty>(builder.EndTable());
		}

		// Token: 0x0601C43F RID: 115775 RVA: 0x003FDD4C File Offset: 0x003FBF4C
		public IRollBlockGridEmptyT UnPack()
		{
			IRollBlockGridEmptyT rollBlockGridEmptyT = new IRollBlockGridEmptyT();
			this.UnPackTo(rollBlockGridEmptyT);
			return rollBlockGridEmptyT;
		}

		// Token: 0x0601C440 RID: 115776 RVA: 0x003FDD68 File Offset: 0x003FBF68
		public void UnPackTo(IRollBlockGridEmptyT _o)
		{
			_o.Type = this.Type;
			_o.Block = new TRollBlockUnion();
			_o.Block.Type = this.BlockType;
			TRollBlock blockType = this.BlockType;
			if (blockType != TRollBlock.IRollBlock1)
			{
				if (blockType == TRollBlock.IRollBlock2)
				{
					_o.Block.Value = ((this.Block<IRollBlock2>() != null) ? this.Block<IRollBlock2>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Block.Value = ((this.Block<IRollBlock1>() != null) ? this.Block<IRollBlock1>().Value.UnPack() : null);
			}
			_o.Items = new List<TRollBlockItemUnion>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				TRollBlockItemUnion trollBlockItemUnion = new TRollBlockItemUnion();
				trollBlockItemUnion.Type = this.ItemsType(i);
				switch (this.ItemsType(i))
				{
				case TRollBlockItem.IRollBlockItemBreakableObstacle:
					trollBlockItemUnion.Value = ((this.Items<IRollBlockItemBreakableObstacle>(i) != null) ? this.Items<IRollBlockItemBreakableObstacle>(i).Value.UnPack() : null);
					break;
				case TRollBlockItem.IRollBlockItemLaserEmitter:
					trollBlockItemUnion.Value = ((this.Items<IRollBlockItemLaserEmitter>(i) != null) ? this.Items<IRollBlockItemLaserEmitter>(i).Value.UnPack() : null);
					break;
				case TRollBlockItem.IRollBlockItemQuantumObstacle:
					trollBlockItemUnion.Value = ((this.Items<IRollBlockItemQuantumObstacle>(i) != null) ? this.Items<IRollBlockItemQuantumObstacle>(i).Value.UnPack() : null);
					break;
				}
				_o.Items.Add(trollBlockItemUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C441 RID: 115777 RVA: 0x003FDF3C File Offset: 0x003FC13C
		public static Offset<IRollBlockGridEmpty> Pack(FlatBufferBuilder builder, IRollBlockGridEmptyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridEmpty>);
			}
			TRollBlock block_type = (_o.Block == null) ? TRollBlock.NONE : _o.Block.Type;
			int blockOffset = (_o.Block == null) ? 0 : TRollBlockUnion.Pack(builder, _o.Block);
			VectorOffset items_typeOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				TRollBlockItem[] array = new TRollBlockItem[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Items[i].Type;
				}
				items_typeOffset = IRollBlockGridEmpty.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridEmpty.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridEmpty.CreateIRollBlockGridEmpty(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.NullMask);
		}

		// Token: 0x0400D035 RID: 53301
		private Table __p;
	}
}
