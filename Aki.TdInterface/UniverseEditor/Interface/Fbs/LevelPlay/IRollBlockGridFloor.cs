using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D4 RID: 18900
	public struct IRollBlockGridFloor : IFlatbufferObject
	{
		// Token: 0x17008465 RID: 33893
		// (get) Token: 0x0601C47E RID: 115838 RVA: 0x003FE9DA File Offset: 0x003FCBDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C47F RID: 115839 RVA: 0x003FE9E7 File Offset: 0x003FCBE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C480 RID: 115840 RVA: 0x003FE9F0 File Offset: 0x003FCBF0
		public static IRollBlockGridFloor GetRootAsIRollBlockGridFloor(ByteBuffer _bb)
		{
			return IRollBlockGridFloor.GetRootAsIRollBlockGridFloor(_bb, default(IRollBlockGridFloor));
		}

		// Token: 0x0601C481 RID: 115841 RVA: 0x003FEA0C File Offset: 0x003FCC0C
		public static IRollBlockGridFloor GetRootAsIRollBlockGridFloor(ByteBuffer _bb, IRollBlockGridFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C482 RID: 115842 RVA: 0x003FEA29 File Offset: 0x003FCC29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C483 RID: 115843 RVA: 0x003FEA38 File Offset: 0x003FCC38
		public IRollBlockGridFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008466 RID: 33894
		// (get) Token: 0x0601C484 RID: 115844 RVA: 0x003FEA48 File Offset: 0x003FCC48
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

		// Token: 0x17008467 RID: 33895
		// (get) Token: 0x0601C485 RID: 115845 RVA: 0x003FEA84 File Offset: 0x003FCC84
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

		// Token: 0x0601C486 RID: 115846 RVA: 0x003FEAC0 File Offset: 0x003FCCC0
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C487 RID: 115847 RVA: 0x003FEB04 File Offset: 0x003FCD04
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C488 RID: 115848 RVA: 0x003FEB20 File Offset: 0x003FCD20
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C489 RID: 115849 RVA: 0x003FEB3C File Offset: 0x003FCD3C
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008468 RID: 33896
		// (get) Token: 0x0601C48A RID: 115850 RVA: 0x003FEB7C File Offset: 0x003FCD7C
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

		// Token: 0x0601C48B RID: 115851 RVA: 0x003FEBA8 File Offset: 0x003FCDA8
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C48C RID: 115852 RVA: 0x003FEBB8 File Offset: 0x003FCDB8
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

		// Token: 0x0601C48D RID: 115853 RVA: 0x003FEC24 File Offset: 0x003FCE24
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008469 RID: 33897
		// (get) Token: 0x0601C48E RID: 115854 RVA: 0x003FEC6C File Offset: 0x003FCE6C
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

		// Token: 0x1700846A RID: 33898
		// (get) Token: 0x0601C48F RID: 115855 RVA: 0x003FEC98 File Offset: 0x003FCE98
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

		// Token: 0x0601C490 RID: 115856 RVA: 0x003FECD5 File Offset: 0x003FCED5
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

		// Token: 0x0601C491 RID: 115857 RVA: 0x003FED11 File Offset: 0x003FCF11
		public static void StartIRollBlockGridFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C492 RID: 115858 RVA: 0x003FED1A File Offset: 0x003FCF1A
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C493 RID: 115859 RVA: 0x003FED25 File Offset: 0x003FCF25
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C494 RID: 115860 RVA: 0x003FED30 File Offset: 0x003FCF30
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C495 RID: 115861 RVA: 0x003FED3B File Offset: 0x003FCF3B
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C496 RID: 115862 RVA: 0x003FED4C File Offset: 0x003FCF4C
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C497 RID: 115863 RVA: 0x003FED83 File Offset: 0x003FCF83
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C498 RID: 115864 RVA: 0x003FED9D File Offset: 0x003FCF9D
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C499 RID: 115865 RVA: 0x003FEDBB File Offset: 0x003FCFBB
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C49A RID: 115866 RVA: 0x003FEDD4 File Offset: 0x003FCFD4
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C49B RID: 115867 RVA: 0x003FEDDF File Offset: 0x003FCFDF
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C49C RID: 115868 RVA: 0x003FEDF0 File Offset: 0x003FCFF0
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C49D RID: 115869 RVA: 0x003FEE27 File Offset: 0x003FD027
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C49E RID: 115870 RVA: 0x003FEE41 File Offset: 0x003FD041
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C49F RID: 115871 RVA: 0x003FEE5F File Offset: 0x003FD05F
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C4A0 RID: 115872 RVA: 0x003FEE78 File Offset: 0x003FD078
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C4A1 RID: 115873 RVA: 0x003FEE83 File Offset: 0x003FD083
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601C4A2 RID: 115874 RVA: 0x003FEE8E File Offset: 0x003FD08E
		public static Offset<IRollBlockGridFloor> EndIRollBlockGridFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridFloor>(builder.EndTable());
		}

		// Token: 0x0601C4A3 RID: 115875 RVA: 0x003FEE9C File Offset: 0x003FD09C
		public IRollBlockGridFloorT UnPack()
		{
			IRollBlockGridFloorT rollBlockGridFloorT = new IRollBlockGridFloorT();
			this.UnPackTo(rollBlockGridFloorT);
			return rollBlockGridFloorT;
		}

		// Token: 0x0601C4A4 RID: 115876 RVA: 0x003FEEB8 File Offset: 0x003FD0B8
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

		// Token: 0x0601C4A5 RID: 115877 RVA: 0x003FF08C File Offset: 0x003FD28C
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

		// Token: 0x0400D03F RID: 53311
		private Table __p;
	}
}
