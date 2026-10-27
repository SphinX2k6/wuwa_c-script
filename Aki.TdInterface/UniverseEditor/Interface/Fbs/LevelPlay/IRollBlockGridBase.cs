using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200455D RID: 17757
	public struct IRollBlockGridBase : IFlatbufferObject
	{
		// Token: 0x17007DF8 RID: 32248
		// (get) Token: 0x0601ABC1 RID: 109505 RVA: 0x003D00EB File Offset: 0x003CE2EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ABC2 RID: 109506 RVA: 0x003D00F8 File Offset: 0x003CE2F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ABC3 RID: 109507 RVA: 0x003D0100 File Offset: 0x003CE300
		public static IRollBlockGridBase GetRootAsIRollBlockGridBase(ByteBuffer _bb)
		{
			return IRollBlockGridBase.GetRootAsIRollBlockGridBase(_bb, default(IRollBlockGridBase));
		}

		// Token: 0x0601ABC4 RID: 109508 RVA: 0x003D011C File Offset: 0x003CE31C
		public static IRollBlockGridBase GetRootAsIRollBlockGridBase(ByteBuffer _bb, IRollBlockGridBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ABC5 RID: 109509 RVA: 0x003D0139 File Offset: 0x003CE339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ABC6 RID: 109510 RVA: 0x003D0148 File Offset: 0x003CE348
		public IRollBlockGridBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DF9 RID: 32249
		// (get) Token: 0x0601ABC7 RID: 109511 RVA: 0x003D0158 File Offset: 0x003CE358
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

		// Token: 0x17007DFA RID: 32250
		// (get) Token: 0x0601ABC8 RID: 109512 RVA: 0x003D0194 File Offset: 0x003CE394
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

		// Token: 0x0601ABC9 RID: 109513 RVA: 0x003D01D0 File Offset: 0x003CE3D0
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601ABCA RID: 109514 RVA: 0x003D0214 File Offset: 0x003CE414
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601ABCB RID: 109515 RVA: 0x003D0230 File Offset: 0x003CE430
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601ABCC RID: 109516 RVA: 0x003D024C File Offset: 0x003CE44C
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007DFB RID: 32251
		// (get) Token: 0x0601ABCD RID: 109517 RVA: 0x003D028C File Offset: 0x003CE48C
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

		// Token: 0x0601ABCE RID: 109518 RVA: 0x003D02B8 File Offset: 0x003CE4B8
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601ABCF RID: 109519 RVA: 0x003D02C8 File Offset: 0x003CE4C8
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

		// Token: 0x0601ABD0 RID: 109520 RVA: 0x003D0334 File Offset: 0x003CE534
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007DFC RID: 32252
		// (get) Token: 0x0601ABD1 RID: 109521 RVA: 0x003D037C File Offset: 0x003CE57C
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

		// Token: 0x17007DFD RID: 32253
		// (get) Token: 0x0601ABD2 RID: 109522 RVA: 0x003D03A8 File Offset: 0x003CE5A8
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

		// Token: 0x0601ABD3 RID: 109523 RVA: 0x003D03E5 File Offset: 0x003CE5E5
		public static Offset<IRollBlockGridBase> CreateIRollBlockGridBase(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRollBlockGridBase.AddItems(builder, ItemsOffset);
			IRollBlockGridBase.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridBase.AddBlock(builder, BlockOffset);
			IRollBlockGridBase.AddNullMask(builder, NullMask);
			IRollBlockGridBase.AddBlockType(builder, Block_type);
			IRollBlockGridBase.AddType(builder, Type);
			return IRollBlockGridBase.EndIRollBlockGridBase(builder);
		}

		// Token: 0x0601ABD4 RID: 109524 RVA: 0x003D0421 File Offset: 0x003CE621
		public static void StartIRollBlockGridBase(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601ABD5 RID: 109525 RVA: 0x003D042A File Offset: 0x003CE62A
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ABD6 RID: 109526 RVA: 0x003D0435 File Offset: 0x003CE635
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601ABD7 RID: 109527 RVA: 0x003D0440 File Offset: 0x003CE640
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601ABD8 RID: 109528 RVA: 0x003D044B File Offset: 0x003CE64B
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601ABD9 RID: 109529 RVA: 0x003D045C File Offset: 0x003CE65C
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ABDA RID: 109530 RVA: 0x003D0493 File Offset: 0x003CE693
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ABDB RID: 109531 RVA: 0x003D04AD File Offset: 0x003CE6AD
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ABDC RID: 109532 RVA: 0x003D04CB File Offset: 0x003CE6CB
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ABDD RID: 109533 RVA: 0x003D04E4 File Offset: 0x003CE6E4
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601ABDE RID: 109534 RVA: 0x003D04EF File Offset: 0x003CE6EF
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601ABDF RID: 109535 RVA: 0x003D0500 File Offset: 0x003CE700
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ABE0 RID: 109536 RVA: 0x003D0537 File Offset: 0x003CE737
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ABE1 RID: 109537 RVA: 0x003D0551 File Offset: 0x003CE751
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ABE2 RID: 109538 RVA: 0x003D056F File Offset: 0x003CE76F
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ABE3 RID: 109539 RVA: 0x003D0588 File Offset: 0x003CE788
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601ABE4 RID: 109540 RVA: 0x003D0593 File Offset: 0x003CE793
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601ABE5 RID: 109541 RVA: 0x003D059E File Offset: 0x003CE79E
		public static Offset<IRollBlockGridBase> EndIRollBlockGridBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridBase>(builder.EndTable());
		}

		// Token: 0x0601ABE6 RID: 109542 RVA: 0x003D05AC File Offset: 0x003CE7AC
		public IRollBlockGridBaseT UnPack()
		{
			IRollBlockGridBaseT rollBlockGridBaseT = new IRollBlockGridBaseT();
			this.UnPackTo(rollBlockGridBaseT);
			return rollBlockGridBaseT;
		}

		// Token: 0x0601ABE7 RID: 109543 RVA: 0x003D05C8 File Offset: 0x003CE7C8
		public void UnPackTo(IRollBlockGridBaseT _o)
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

		// Token: 0x0601ABE8 RID: 109544 RVA: 0x003D079C File Offset: 0x003CE99C
		public static Offset<IRollBlockGridBase> Pack(FlatBufferBuilder builder, IRollBlockGridBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridBase>);
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
				items_typeOffset = IRollBlockGridBase.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridBase.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridBase.CreateIRollBlockGridBase(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.NullMask);
		}

		// Token: 0x0400C5ED RID: 50669
		private Table __p;
	}
}
