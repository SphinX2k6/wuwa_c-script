using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004572 RID: 17778
	public struct IRollBlockGridJumpFloor : IFlatbufferObject
	{
		// Token: 0x17007E38 RID: 32312
		// (get) Token: 0x0601AD0D RID: 109837 RVA: 0x003D388E File Offset: 0x003D1A8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AD0E RID: 109838 RVA: 0x003D389B File Offset: 0x003D1A9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AD0F RID: 109839 RVA: 0x003D38A4 File Offset: 0x003D1AA4
		public static IRollBlockGridJumpFloor GetRootAsIRollBlockGridJumpFloor(ByteBuffer _bb)
		{
			return IRollBlockGridJumpFloor.GetRootAsIRollBlockGridJumpFloor(_bb, default(IRollBlockGridJumpFloor));
		}

		// Token: 0x0601AD10 RID: 109840 RVA: 0x003D38C0 File Offset: 0x003D1AC0
		public static IRollBlockGridJumpFloor GetRootAsIRollBlockGridJumpFloor(ByteBuffer _bb, IRollBlockGridJumpFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AD11 RID: 109841 RVA: 0x003D38DD File Offset: 0x003D1ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AD12 RID: 109842 RVA: 0x003D38EC File Offset: 0x003D1AEC
		public IRollBlockGridJumpFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E39 RID: 32313
		// (get) Token: 0x0601AD13 RID: 109843 RVA: 0x003D38FC File Offset: 0x003D1AFC
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

		// Token: 0x17007E3A RID: 32314
		// (get) Token: 0x0601AD14 RID: 109844 RVA: 0x003D3938 File Offset: 0x003D1B38
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

		// Token: 0x0601AD15 RID: 109845 RVA: 0x003D3974 File Offset: 0x003D1B74
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AD16 RID: 109846 RVA: 0x003D39B8 File Offset: 0x003D1BB8
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601AD17 RID: 109847 RVA: 0x003D39D4 File Offset: 0x003D1BD4
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601AD18 RID: 109848 RVA: 0x003D39F0 File Offset: 0x003D1BF0
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E3B RID: 32315
		// (get) Token: 0x0601AD19 RID: 109849 RVA: 0x003D3A30 File Offset: 0x003D1C30
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

		// Token: 0x0601AD1A RID: 109850 RVA: 0x003D3A5C File Offset: 0x003D1C5C
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601AD1B RID: 109851 RVA: 0x003D3A6C File Offset: 0x003D1C6C
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

		// Token: 0x0601AD1C RID: 109852 RVA: 0x003D3AD8 File Offset: 0x003D1CD8
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E3C RID: 32316
		// (get) Token: 0x0601AD1D RID: 109853 RVA: 0x003D3B20 File Offset: 0x003D1D20
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

		// Token: 0x17007E3D RID: 32317
		// (get) Token: 0x0601AD1E RID: 109854 RVA: 0x003D3B4C File Offset: 0x003D1D4C
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

		// Token: 0x17007E3E RID: 32318
		// (get) Token: 0x0601AD1F RID: 109855 RVA: 0x003D3B8C File Offset: 0x003D1D8C
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

		// Token: 0x0601AD20 RID: 109856 RVA: 0x003D3BCC File Offset: 0x003D1DCC
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

		// Token: 0x0601AD21 RID: 109857 RVA: 0x003D3C1B File Offset: 0x003D1E1B
		public static void StartIRollBlockGridJumpFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601AD22 RID: 109858 RVA: 0x003D3C24 File Offset: 0x003D1E24
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AD23 RID: 109859 RVA: 0x003D3C2F File Offset: 0x003D1E2F
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601AD24 RID: 109860 RVA: 0x003D3C3A File Offset: 0x003D1E3A
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601AD25 RID: 109861 RVA: 0x003D3C45 File Offset: 0x003D1E45
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601AD26 RID: 109862 RVA: 0x003D3C58 File Offset: 0x003D1E58
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AD27 RID: 109863 RVA: 0x003D3C8F File Offset: 0x003D1E8F
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD28 RID: 109864 RVA: 0x003D3CA9 File Offset: 0x003D1EA9
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD29 RID: 109865 RVA: 0x003D3CC7 File Offset: 0x003D1EC7
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AD2A RID: 109866 RVA: 0x003D3CE0 File Offset: 0x003D1EE0
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AD2B RID: 109867 RVA: 0x003D3CEB File Offset: 0x003D1EEB
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601AD2C RID: 109868 RVA: 0x003D3CFC File Offset: 0x003D1EFC
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AD2D RID: 109869 RVA: 0x003D3D33 File Offset: 0x003D1F33
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD2E RID: 109870 RVA: 0x003D3D4D File Offset: 0x003D1F4D
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD2F RID: 109871 RVA: 0x003D3D6B File Offset: 0x003D1F6B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AD30 RID: 109872 RVA: 0x003D3D84 File Offset: 0x003D1F84
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AD31 RID: 109873 RVA: 0x003D3D8F File Offset: 0x003D1F8F
		public static void AddJumpDirection(FlatBufferBuilder builder, ERollBlockLayType jumpDirection)
		{
			builder.AddByte(5, (byte)jumpDirection, 0);
		}

		// Token: 0x0601AD32 RID: 109874 RVA: 0x003D3D9A File Offset: 0x003D1F9A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601AD33 RID: 109875 RVA: 0x003D3DA5 File Offset: 0x003D1FA5
		public static Offset<IRollBlockGridJumpFloor> EndIRollBlockGridJumpFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridJumpFloor>(builder.EndTable());
		}

		// Token: 0x0601AD34 RID: 109876 RVA: 0x003D3DB4 File Offset: 0x003D1FB4
		public IRollBlockGridJumpFloorT UnPack()
		{
			IRollBlockGridJumpFloorT rollBlockGridJumpFloorT = new IRollBlockGridJumpFloorT();
			this.UnPackTo(rollBlockGridJumpFloorT);
			return rollBlockGridJumpFloorT;
		}

		// Token: 0x0601AD35 RID: 109877 RVA: 0x003D3DD0 File Offset: 0x003D1FD0
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

		// Token: 0x0601AD36 RID: 109878 RVA: 0x003D3FB0 File Offset: 0x003D21B0
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

		// Token: 0x0400C61A RID: 50714
		private Table __p;
	}
}
