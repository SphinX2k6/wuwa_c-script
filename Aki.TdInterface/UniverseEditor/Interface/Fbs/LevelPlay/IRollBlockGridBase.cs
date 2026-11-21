using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C5 RID: 18885
	public struct IRollBlockGridBase : IFlatbufferObject
	{
		// Token: 0x17008439 RID: 33849
		// (get) Token: 0x0601C396 RID: 115606 RVA: 0x003FC387 File Offset: 0x003FA587
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C397 RID: 115607 RVA: 0x003FC394 File Offset: 0x003FA594
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C398 RID: 115608 RVA: 0x003FC39C File Offset: 0x003FA59C
		public static IRollBlockGridBase GetRootAsIRollBlockGridBase(ByteBuffer _bb)
		{
			return IRollBlockGridBase.GetRootAsIRollBlockGridBase(_bb, default(IRollBlockGridBase));
		}

		// Token: 0x0601C399 RID: 115609 RVA: 0x003FC3B8 File Offset: 0x003FA5B8
		public static IRollBlockGridBase GetRootAsIRollBlockGridBase(ByteBuffer _bb, IRollBlockGridBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C39A RID: 115610 RVA: 0x003FC3D5 File Offset: 0x003FA5D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C39B RID: 115611 RVA: 0x003FC3E4 File Offset: 0x003FA5E4
		public IRollBlockGridBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700843A RID: 33850
		// (get) Token: 0x0601C39C RID: 115612 RVA: 0x003FC3F4 File Offset: 0x003FA5F4
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

		// Token: 0x1700843B RID: 33851
		// (get) Token: 0x0601C39D RID: 115613 RVA: 0x003FC430 File Offset: 0x003FA630
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

		// Token: 0x0601C39E RID: 115614 RVA: 0x003FC46C File Offset: 0x003FA66C
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C39F RID: 115615 RVA: 0x003FC4B0 File Offset: 0x003FA6B0
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C3A0 RID: 115616 RVA: 0x003FC4CC File Offset: 0x003FA6CC
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C3A1 RID: 115617 RVA: 0x003FC4E8 File Offset: 0x003FA6E8
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700843C RID: 33852
		// (get) Token: 0x0601C3A2 RID: 115618 RVA: 0x003FC528 File Offset: 0x003FA728
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

		// Token: 0x0601C3A3 RID: 115619 RVA: 0x003FC554 File Offset: 0x003FA754
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C3A4 RID: 115620 RVA: 0x003FC564 File Offset: 0x003FA764
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

		// Token: 0x0601C3A5 RID: 115621 RVA: 0x003FC5D0 File Offset: 0x003FA7D0
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700843D RID: 33853
		// (get) Token: 0x0601C3A6 RID: 115622 RVA: 0x003FC618 File Offset: 0x003FA818
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

		// Token: 0x1700843E RID: 33854
		// (get) Token: 0x0601C3A7 RID: 115623 RVA: 0x003FC644 File Offset: 0x003FA844
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

		// Token: 0x0601C3A8 RID: 115624 RVA: 0x003FC681 File Offset: 0x003FA881
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

		// Token: 0x0601C3A9 RID: 115625 RVA: 0x003FC6BD File Offset: 0x003FA8BD
		public static void StartIRollBlockGridBase(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C3AA RID: 115626 RVA: 0x003FC6C6 File Offset: 0x003FA8C6
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C3AB RID: 115627 RVA: 0x003FC6D1 File Offset: 0x003FA8D1
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C3AC RID: 115628 RVA: 0x003FC6DC File Offset: 0x003FA8DC
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C3AD RID: 115629 RVA: 0x003FC6E7 File Offset: 0x003FA8E7
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C3AE RID: 115630 RVA: 0x003FC6F8 File Offset: 0x003FA8F8
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C3AF RID: 115631 RVA: 0x003FC72F File Offset: 0x003FA92F
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B0 RID: 115632 RVA: 0x003FC749 File Offset: 0x003FA949
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B1 RID: 115633 RVA: 0x003FC767 File Offset: 0x003FA967
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C3B2 RID: 115634 RVA: 0x003FC780 File Offset: 0x003FA980
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C3B3 RID: 115635 RVA: 0x003FC78B File Offset: 0x003FA98B
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C3B4 RID: 115636 RVA: 0x003FC79C File Offset: 0x003FA99C
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C3B5 RID: 115637 RVA: 0x003FC7D3 File Offset: 0x003FA9D3
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B6 RID: 115638 RVA: 0x003FC7ED File Offset: 0x003FA9ED
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B7 RID: 115639 RVA: 0x003FC80B File Offset: 0x003FAA0B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C3B8 RID: 115640 RVA: 0x003FC824 File Offset: 0x003FAA24
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C3B9 RID: 115641 RVA: 0x003FC82F File Offset: 0x003FAA2F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601C3BA RID: 115642 RVA: 0x003FC83A File Offset: 0x003FAA3A
		public static Offset<IRollBlockGridBase> EndIRollBlockGridBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridBase>(builder.EndTable());
		}

		// Token: 0x0601C3BB RID: 115643 RVA: 0x003FC848 File Offset: 0x003FAA48
		public IRollBlockGridBaseT UnPack()
		{
			IRollBlockGridBaseT rollBlockGridBaseT = new IRollBlockGridBaseT();
			this.UnPackTo(rollBlockGridBaseT);
			return rollBlockGridBaseT;
		}

		// Token: 0x0601C3BC RID: 115644 RVA: 0x003FC864 File Offset: 0x003FAA64
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

		// Token: 0x0601C3BD RID: 115645 RVA: 0x003FCA38 File Offset: 0x003FAC38
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

		// Token: 0x0400D01C RID: 53276
		private Table __p;
	}
}
