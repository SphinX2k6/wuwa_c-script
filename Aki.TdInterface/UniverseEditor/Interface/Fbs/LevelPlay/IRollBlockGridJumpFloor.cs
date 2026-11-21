using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049DA RID: 18906
	public struct IRollBlockGridJumpFloor : IFlatbufferObject
	{
		// Token: 0x17008479 RID: 33913
		// (get) Token: 0x0601C4E2 RID: 115938 RVA: 0x003FFB2A File Offset: 0x003FDD2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C4E3 RID: 115939 RVA: 0x003FFB37 File Offset: 0x003FDD37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C4E4 RID: 115940 RVA: 0x003FFB40 File Offset: 0x003FDD40
		public static IRollBlockGridJumpFloor GetRootAsIRollBlockGridJumpFloor(ByteBuffer _bb)
		{
			return IRollBlockGridJumpFloor.GetRootAsIRollBlockGridJumpFloor(_bb, default(IRollBlockGridJumpFloor));
		}

		// Token: 0x0601C4E5 RID: 115941 RVA: 0x003FFB5C File Offset: 0x003FDD5C
		public static IRollBlockGridJumpFloor GetRootAsIRollBlockGridJumpFloor(ByteBuffer _bb, IRollBlockGridJumpFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C4E6 RID: 115942 RVA: 0x003FFB79 File Offset: 0x003FDD79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C4E7 RID: 115943 RVA: 0x003FFB88 File Offset: 0x003FDD88
		public IRollBlockGridJumpFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700847A RID: 33914
		// (get) Token: 0x0601C4E8 RID: 115944 RVA: 0x003FFB98 File Offset: 0x003FDD98
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

		// Token: 0x1700847B RID: 33915
		// (get) Token: 0x0601C4E9 RID: 115945 RVA: 0x003FFBD4 File Offset: 0x003FDDD4
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

		// Token: 0x0601C4EA RID: 115946 RVA: 0x003FFC10 File Offset: 0x003FDE10
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C4EB RID: 115947 RVA: 0x003FFC54 File Offset: 0x003FDE54
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C4EC RID: 115948 RVA: 0x003FFC70 File Offset: 0x003FDE70
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C4ED RID: 115949 RVA: 0x003FFC8C File Offset: 0x003FDE8C
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700847C RID: 33916
		// (get) Token: 0x0601C4EE RID: 115950 RVA: 0x003FFCCC File Offset: 0x003FDECC
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

		// Token: 0x0601C4EF RID: 115951 RVA: 0x003FFCF8 File Offset: 0x003FDEF8
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C4F0 RID: 115952 RVA: 0x003FFD08 File Offset: 0x003FDF08
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

		// Token: 0x0601C4F1 RID: 115953 RVA: 0x003FFD74 File Offset: 0x003FDF74
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700847D RID: 33917
		// (get) Token: 0x0601C4F2 RID: 115954 RVA: 0x003FFDBC File Offset: 0x003FDFBC
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

		// Token: 0x1700847E RID: 33918
		// (get) Token: 0x0601C4F3 RID: 115955 RVA: 0x003FFDE8 File Offset: 0x003FDFE8
		public ERollBlockLayType JumpDirection
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ERollBlockLayType.Left;
				}
				return (ERollBlockLayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700847F RID: 33919
		// (get) Token: 0x0601C4F4 RID: 115956 RVA: 0x003FFE28 File Offset: 0x003FE028
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C4F5 RID: 115957 RVA: 0x003FFE68 File Offset: 0x003FE068
		public static Offset<IRollBlockGridJumpFloor> CreateIRollBlockGridJumpFloor(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), ERollBlockLayType JumpDirection = ERollBlockLayType.Left, byte NullMask = 0)
		{
			builder.StartTable(7);
			IRollBlockGridJumpFloor.AddItems(builder, ItemsOffset);
			IRollBlockGridJumpFloor.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridJumpFloor.AddBlock(builder, BlockOffset);
			IRollBlockGridJumpFloor.AddNullMask(builder, NullMask);
			IRollBlockGridJumpFloor.AddJumpDirection(builder, JumpDirection);
			IRollBlockGridJumpFloor.AddBlockType(builder, Block_type);
			IRollBlockGridJumpFloor.AddType(builder, Type);
			return IRollBlockGridJumpFloor.EndIRollBlockGridJumpFloor(builder);
		}

		// Token: 0x0601C4F6 RID: 115958 RVA: 0x003FFEB7 File Offset: 0x003FE0B7
		public static void StartIRollBlockGridJumpFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601C4F7 RID: 115959 RVA: 0x003FFEC0 File Offset: 0x003FE0C0
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C4F8 RID: 115960 RVA: 0x003FFECB File Offset: 0x003FE0CB
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C4F9 RID: 115961 RVA: 0x003FFED6 File Offset: 0x003FE0D6
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C4FA RID: 115962 RVA: 0x003FFEE1 File Offset: 0x003FE0E1
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C4FB RID: 115963 RVA: 0x003FFEF4 File Offset: 0x003FE0F4
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C4FC RID: 115964 RVA: 0x003FFF2B File Offset: 0x003FE12B
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4FD RID: 115965 RVA: 0x003FFF45 File Offset: 0x003FE145
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4FE RID: 115966 RVA: 0x003FFF63 File Offset: 0x003FE163
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C4FF RID: 115967 RVA: 0x003FFF7C File Offset: 0x003FE17C
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C500 RID: 115968 RVA: 0x003FFF87 File Offset: 0x003FE187
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C501 RID: 115969 RVA: 0x003FFF98 File Offset: 0x003FE198
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C502 RID: 115970 RVA: 0x003FFFCF File Offset: 0x003FE1CF
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C503 RID: 115971 RVA: 0x003FFFE9 File Offset: 0x003FE1E9
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C504 RID: 115972 RVA: 0x00400007 File Offset: 0x003FE207
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C505 RID: 115973 RVA: 0x00400020 File Offset: 0x003FE220
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C506 RID: 115974 RVA: 0x0040002B File Offset: 0x003FE22B
		public static void AddJumpDirection(FlatBufferBuilder builder, ERollBlockLayType jumpDirection)
		{
			builder.AddByte(5, (byte)jumpDirection, 0);
		}

		// Token: 0x0601C507 RID: 115975 RVA: 0x00400036 File Offset: 0x003FE236
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601C508 RID: 115976 RVA: 0x00400041 File Offset: 0x003FE241
		public static Offset<IRollBlockGridJumpFloor> EndIRollBlockGridJumpFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridJumpFloor>(builder.EndTable());
		}

		// Token: 0x0601C509 RID: 115977 RVA: 0x00400050 File Offset: 0x003FE250
		public IRollBlockGridJumpFloorT UnPack()
		{
			IRollBlockGridJumpFloorT rollBlockGridJumpFloorT = new IRollBlockGridJumpFloorT();
			this.UnPackTo(rollBlockGridJumpFloorT);
			return rollBlockGridJumpFloorT;
		}

		// Token: 0x0601C50A RID: 115978 RVA: 0x0040006C File Offset: 0x003FE26C
		public void UnPackTo(IRollBlockGridJumpFloorT _o)
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
			_o.JumpDirection = this.JumpDirection;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C50B RID: 115979 RVA: 0x0040024C File Offset: 0x003FE44C
		public static Offset<IRollBlockGridJumpFloor> Pack(FlatBufferBuilder builder, IRollBlockGridJumpFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridJumpFloor>);
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
				items_typeOffset = IRollBlockGridJumpFloor.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridJumpFloor.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridJumpFloor.CreateIRollBlockGridJumpFloor(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.JumpDirection, _o.NullMask);
		}

		// Token: 0x0400D049 RID: 53321
		private Table __p;
	}
}
