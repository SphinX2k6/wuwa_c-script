using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200456C RID: 17772
	public struct IRollBlockGridFloor : IFlatbufferObject
	{
		// Token: 0x17007E24 RID: 32292
		// (get) Token: 0x0601ACA9 RID: 109737 RVA: 0x003D273E File Offset: 0x003D093E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ACAA RID: 109738 RVA: 0x003D274B File Offset: 0x003D094B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ACAB RID: 109739 RVA: 0x003D2754 File Offset: 0x003D0954
		public static IRollBlockGridFloor GetRootAsIRollBlockGridFloor(ByteBuffer _bb)
		{
			return IRollBlockGridFloor.GetRootAsIRollBlockGridFloor(_bb, default(IRollBlockGridFloor));
		}

		// Token: 0x0601ACAC RID: 109740 RVA: 0x003D2770 File Offset: 0x003D0970
		public static IRollBlockGridFloor GetRootAsIRollBlockGridFloor(ByteBuffer _bb, IRollBlockGridFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ACAD RID: 109741 RVA: 0x003D278D File Offset: 0x003D098D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ACAE RID: 109742 RVA: 0x003D279C File Offset: 0x003D099C
		public IRollBlockGridFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E25 RID: 32293
		// (get) Token: 0x0601ACAF RID: 109743 RVA: 0x003D27AC File Offset: 0x003D09AC
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

		// Token: 0x17007E26 RID: 32294
		// (get) Token: 0x0601ACB0 RID: 109744 RVA: 0x003D27E8 File Offset: 0x003D09E8
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

		// Token: 0x0601ACB1 RID: 109745 RVA: 0x003D2824 File Offset: 0x003D0A24
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601ACB2 RID: 109746 RVA: 0x003D2868 File Offset: 0x003D0A68
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601ACB3 RID: 109747 RVA: 0x003D2884 File Offset: 0x003D0A84
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601ACB4 RID: 109748 RVA: 0x003D28A0 File Offset: 0x003D0AA0
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E27 RID: 32295
		// (get) Token: 0x0601ACB5 RID: 109749 RVA: 0x003D28E0 File Offset: 0x003D0AE0
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

		// Token: 0x0601ACB6 RID: 109750 RVA: 0x003D290C File Offset: 0x003D0B0C
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601ACB7 RID: 109751 RVA: 0x003D291C File Offset: 0x003D0B1C
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

		// Token: 0x0601ACB8 RID: 109752 RVA: 0x003D2988 File Offset: 0x003D0B88
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E28 RID: 32296
		// (get) Token: 0x0601ACB9 RID: 109753 RVA: 0x003D29D0 File Offset: 0x003D0BD0
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

		// Token: 0x17007E29 RID: 32297
		// (get) Token: 0x0601ACBA RID: 109754 RVA: 0x003D29FC File Offset: 0x003D0BFC
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

		// Token: 0x0601ACBB RID: 109755 RVA: 0x003D2A39 File Offset: 0x003D0C39
		public static Offset<IRollBlockGridFloor> CreateIRollBlockGridFloor(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRollBlockGridFloor.AddItems(builder, ItemsOffset);
			IRollBlockGridFloor.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridFloor.AddBlock(builder, BlockOffset);
			IRollBlockGridFloor.AddNullMask(builder, NullMask);
			IRollBlockGridFloor.AddBlockType(builder, Block_type);
			IRollBlockGridFloor.AddType(builder, Type);
			return IRollBlockGridFloor.EndIRollBlockGridFloor(builder);
		}

		// Token: 0x0601ACBC RID: 109756 RVA: 0x003D2A75 File Offset: 0x003D0C75
		public static void StartIRollBlockGridFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601ACBD RID: 109757 RVA: 0x003D2A7E File Offset: 0x003D0C7E
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ACBE RID: 109758 RVA: 0x003D2A89 File Offset: 0x003D0C89
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601ACBF RID: 109759 RVA: 0x003D2A94 File Offset: 0x003D0C94
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601ACC0 RID: 109760 RVA: 0x003D2A9F File Offset: 0x003D0C9F
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601ACC1 RID: 109761 RVA: 0x003D2AB0 File Offset: 0x003D0CB0
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ACC2 RID: 109762 RVA: 0x003D2AE7 File Offset: 0x003D0CE7
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACC3 RID: 109763 RVA: 0x003D2B01 File Offset: 0x003D0D01
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACC4 RID: 109764 RVA: 0x003D2B1F File Offset: 0x003D0D1F
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ACC5 RID: 109765 RVA: 0x003D2B38 File Offset: 0x003D0D38
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601ACC6 RID: 109766 RVA: 0x003D2B43 File Offset: 0x003D0D43
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601ACC7 RID: 109767 RVA: 0x003D2B54 File Offset: 0x003D0D54
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ACC8 RID: 109768 RVA: 0x003D2B8B File Offset: 0x003D0D8B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACC9 RID: 109769 RVA: 0x003D2BA5 File Offset: 0x003D0DA5
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACCA RID: 109770 RVA: 0x003D2BC3 File Offset: 0x003D0DC3
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ACCB RID: 109771 RVA: 0x003D2BDC File Offset: 0x003D0DDC
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601ACCC RID: 109772 RVA: 0x003D2BE7 File Offset: 0x003D0DE7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601ACCD RID: 109773 RVA: 0x003D2BF2 File Offset: 0x003D0DF2
		public static Offset<IRollBlockGridFloor> EndIRollBlockGridFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridFloor>(builder.EndTable());
		}

		// Token: 0x0601ACCE RID: 109774 RVA: 0x003D2C00 File Offset: 0x003D0E00
		public IRollBlockGridFloorT UnPack()
		{
			IRollBlockGridFloorT rollBlockGridFloorT = new IRollBlockGridFloorT();
			this.UnPackTo(rollBlockGridFloorT);
			return rollBlockGridFloorT;
		}

		// Token: 0x0601ACCF RID: 109775 RVA: 0x003D2C1C File Offset: 0x003D0E1C
		public void UnPackTo(IRollBlockGridFloorT _o)
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

		// Token: 0x0601ACD0 RID: 109776 RVA: 0x003D2DF0 File Offset: 0x003D0FF0
		public static Offset<IRollBlockGridFloor> Pack(FlatBufferBuilder builder, IRollBlockGridFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridFloor>);
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
				items_typeOffset = IRollBlockGridFloor.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridFloor.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridFloor.CreateIRollBlockGridFloor(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.NullMask);
		}

		// Token: 0x0400C610 RID: 50704
		private Table __p;
	}
}
