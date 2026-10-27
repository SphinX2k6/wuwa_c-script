using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004569 RID: 17769
	public struct IRollBlockGridFallFloor : IFlatbufferObject
	{
		// Token: 0x17007E1A RID: 32282
		// (get) Token: 0x0601AC77 RID: 109687 RVA: 0x003D1E96 File Offset: 0x003D0096
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AC78 RID: 109688 RVA: 0x003D1EA3 File Offset: 0x003D00A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AC79 RID: 109689 RVA: 0x003D1EAC File Offset: 0x003D00AC
		public static IRollBlockGridFallFloor GetRootAsIRollBlockGridFallFloor(ByteBuffer _bb)
		{
			return IRollBlockGridFallFloor.GetRootAsIRollBlockGridFallFloor(_bb, default(IRollBlockGridFallFloor));
		}

		// Token: 0x0601AC7A RID: 109690 RVA: 0x003D1EC8 File Offset: 0x003D00C8
		public static IRollBlockGridFallFloor GetRootAsIRollBlockGridFallFloor(ByteBuffer _bb, IRollBlockGridFallFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AC7B RID: 109691 RVA: 0x003D1EE5 File Offset: 0x003D00E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AC7C RID: 109692 RVA: 0x003D1EF4 File Offset: 0x003D00F4
		public IRollBlockGridFallFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E1B RID: 32283
		// (get) Token: 0x0601AC7D RID: 109693 RVA: 0x003D1F04 File Offset: 0x003D0104
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

		// Token: 0x17007E1C RID: 32284
		// (get) Token: 0x0601AC7E RID: 109694 RVA: 0x003D1F40 File Offset: 0x003D0140
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

		// Token: 0x0601AC7F RID: 109695 RVA: 0x003D1F7C File Offset: 0x003D017C
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AC80 RID: 109696 RVA: 0x003D1FC0 File Offset: 0x003D01C0
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601AC81 RID: 109697 RVA: 0x003D1FDC File Offset: 0x003D01DC
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601AC82 RID: 109698 RVA: 0x003D1FF8 File Offset: 0x003D01F8
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E1D RID: 32285
		// (get) Token: 0x0601AC83 RID: 109699 RVA: 0x003D2038 File Offset: 0x003D0238
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

		// Token: 0x0601AC84 RID: 109700 RVA: 0x003D2064 File Offset: 0x003D0264
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601AC85 RID: 109701 RVA: 0x003D2074 File Offset: 0x003D0274
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

		// Token: 0x0601AC86 RID: 109702 RVA: 0x003D20E0 File Offset: 0x003D02E0
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E1E RID: 32286
		// (get) Token: 0x0601AC87 RID: 109703 RVA: 0x003D2128 File Offset: 0x003D0328
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

		// Token: 0x17007E1F RID: 32287
		// (get) Token: 0x0601AC88 RID: 109704 RVA: 0x003D2154 File Offset: 0x003D0354
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

		// Token: 0x0601AC89 RID: 109705 RVA: 0x003D2191 File Offset: 0x003D0391
		public static Offset<IRollBlockGridFallFloor> CreateIRollBlockGridFallFloor(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRollBlockGridFallFloor.AddItems(builder, ItemsOffset);
			IRollBlockGridFallFloor.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridFallFloor.AddBlock(builder, BlockOffset);
			IRollBlockGridFallFloor.AddNullMask(builder, NullMask);
			IRollBlockGridFallFloor.AddBlockType(builder, Block_type);
			IRollBlockGridFallFloor.AddType(builder, Type);
			return IRollBlockGridFallFloor.EndIRollBlockGridFallFloor(builder);
		}

		// Token: 0x0601AC8A RID: 109706 RVA: 0x003D21CD File Offset: 0x003D03CD
		public static void StartIRollBlockGridFallFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601AC8B RID: 109707 RVA: 0x003D21D6 File Offset: 0x003D03D6
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AC8C RID: 109708 RVA: 0x003D21E1 File Offset: 0x003D03E1
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601AC8D RID: 109709 RVA: 0x003D21EC File Offset: 0x003D03EC
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601AC8E RID: 109710 RVA: 0x003D21F7 File Offset: 0x003D03F7
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601AC8F RID: 109711 RVA: 0x003D2208 File Offset: 0x003D0408
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AC90 RID: 109712 RVA: 0x003D223F File Offset: 0x003D043F
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC91 RID: 109713 RVA: 0x003D2259 File Offset: 0x003D0459
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC92 RID: 109714 RVA: 0x003D2277 File Offset: 0x003D0477
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AC93 RID: 109715 RVA: 0x003D2290 File Offset: 0x003D0490
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AC94 RID: 109716 RVA: 0x003D229B File Offset: 0x003D049B
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601AC95 RID: 109717 RVA: 0x003D22AC File Offset: 0x003D04AC
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AC96 RID: 109718 RVA: 0x003D22E3 File Offset: 0x003D04E3
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC97 RID: 109719 RVA: 0x003D22FD File Offset: 0x003D04FD
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC98 RID: 109720 RVA: 0x003D231B File Offset: 0x003D051B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AC99 RID: 109721 RVA: 0x003D2334 File Offset: 0x003D0534
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AC9A RID: 109722 RVA: 0x003D233F File Offset: 0x003D053F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601AC9B RID: 109723 RVA: 0x003D234A File Offset: 0x003D054A
		public static Offset<IRollBlockGridFallFloor> EndIRollBlockGridFallFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridFallFloor>(builder.EndTable());
		}

		// Token: 0x0601AC9C RID: 109724 RVA: 0x003D2358 File Offset: 0x003D0558
		public IRollBlockGridFallFloorT UnPack()
		{
			IRollBlockGridFallFloorT rollBlockGridFallFloorT = new IRollBlockGridFallFloorT();
			this.UnPackTo(rollBlockGridFallFloorT);
			return rollBlockGridFallFloorT;
		}

		// Token: 0x0601AC9D RID: 109725 RVA: 0x003D2374 File Offset: 0x003D0574
		public void UnPackTo(IRollBlockGridFallFloorT _o)
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

		// Token: 0x0601AC9E RID: 109726 RVA: 0x003D2548 File Offset: 0x003D0748
		public static Offset<IRollBlockGridFallFloor> Pack(FlatBufferBuilder builder, IRollBlockGridFallFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridFallFloor>);
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
				items_typeOffset = IRollBlockGridFallFloor.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridFallFloor.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridFallFloor.CreateIRollBlockGridFallFloor(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.NullMask);
		}

		// Token: 0x0400C60B RID: 50699
		private Table __p;
	}
}
