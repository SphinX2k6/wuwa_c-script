using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D1 RID: 18897
	public struct IRollBlockGridFallFloor : IFlatbufferObject
	{
		// Token: 0x1700845B RID: 33883
		// (get) Token: 0x0601C44C RID: 115788 RVA: 0x003FE132 File Offset: 0x003FC332
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C44D RID: 115789 RVA: 0x003FE13F File Offset: 0x003FC33F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C44E RID: 115790 RVA: 0x003FE148 File Offset: 0x003FC348
		public static IRollBlockGridFallFloor GetRootAsIRollBlockGridFallFloor(ByteBuffer _bb)
		{
			return IRollBlockGridFallFloor.GetRootAsIRollBlockGridFallFloor(_bb, default(IRollBlockGridFallFloor));
		}

		// Token: 0x0601C44F RID: 115791 RVA: 0x003FE164 File Offset: 0x003FC364
		public static IRollBlockGridFallFloor GetRootAsIRollBlockGridFallFloor(ByteBuffer _bb, IRollBlockGridFallFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C450 RID: 115792 RVA: 0x003FE181 File Offset: 0x003FC381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C451 RID: 115793 RVA: 0x003FE190 File Offset: 0x003FC390
		public IRollBlockGridFallFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700845C RID: 33884
		// (get) Token: 0x0601C452 RID: 115794 RVA: 0x003FE1A0 File Offset: 0x003FC3A0
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

		// Token: 0x1700845D RID: 33885
		// (get) Token: 0x0601C453 RID: 115795 RVA: 0x003FE1DC File Offset: 0x003FC3DC
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

		// Token: 0x0601C454 RID: 115796 RVA: 0x003FE218 File Offset: 0x003FC418
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C455 RID: 115797 RVA: 0x003FE25C File Offset: 0x003FC45C
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C456 RID: 115798 RVA: 0x003FE278 File Offset: 0x003FC478
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C457 RID: 115799 RVA: 0x003FE294 File Offset: 0x003FC494
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700845E RID: 33886
		// (get) Token: 0x0601C458 RID: 115800 RVA: 0x003FE2D4 File Offset: 0x003FC4D4
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

		// Token: 0x0601C459 RID: 115801 RVA: 0x003FE300 File Offset: 0x003FC500
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C45A RID: 115802 RVA: 0x003FE310 File Offset: 0x003FC510
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

		// Token: 0x0601C45B RID: 115803 RVA: 0x003FE37C File Offset: 0x003FC57C
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700845F RID: 33887
		// (get) Token: 0x0601C45C RID: 115804 RVA: 0x003FE3C4 File Offset: 0x003FC5C4
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

		// Token: 0x17008460 RID: 33888
		// (get) Token: 0x0601C45D RID: 115805 RVA: 0x003FE3F0 File Offset: 0x003FC5F0
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

		// Token: 0x0601C45E RID: 115806 RVA: 0x003FE42D File Offset: 0x003FC62D
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

		// Token: 0x0601C45F RID: 115807 RVA: 0x003FE469 File Offset: 0x003FC669
		public static void StartIRollBlockGridFallFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C460 RID: 115808 RVA: 0x003FE472 File Offset: 0x003FC672
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C461 RID: 115809 RVA: 0x003FE47D File Offset: 0x003FC67D
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C462 RID: 115810 RVA: 0x003FE488 File Offset: 0x003FC688
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C463 RID: 115811 RVA: 0x003FE493 File Offset: 0x003FC693
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C464 RID: 115812 RVA: 0x003FE4A4 File Offset: 0x003FC6A4
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C465 RID: 115813 RVA: 0x003FE4DB File Offset: 0x003FC6DB
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C466 RID: 115814 RVA: 0x003FE4F5 File Offset: 0x003FC6F5
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C467 RID: 115815 RVA: 0x003FE513 File Offset: 0x003FC713
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C468 RID: 115816 RVA: 0x003FE52C File Offset: 0x003FC72C
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C469 RID: 115817 RVA: 0x003FE537 File Offset: 0x003FC737
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C46A RID: 115818 RVA: 0x003FE548 File Offset: 0x003FC748
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C46B RID: 115819 RVA: 0x003FE57F File Offset: 0x003FC77F
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C46C RID: 115820 RVA: 0x003FE599 File Offset: 0x003FC799
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C46D RID: 115821 RVA: 0x003FE5B7 File Offset: 0x003FC7B7
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C46E RID: 115822 RVA: 0x003FE5D0 File Offset: 0x003FC7D0
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C46F RID: 115823 RVA: 0x003FE5DB File Offset: 0x003FC7DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601C470 RID: 115824 RVA: 0x003FE5E6 File Offset: 0x003FC7E6
		public static Offset<IRollBlockGridFallFloor> EndIRollBlockGridFallFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridFallFloor>(builder.EndTable());
		}

		// Token: 0x0601C471 RID: 115825 RVA: 0x003FE5F4 File Offset: 0x003FC7F4
		public IRollBlockGridFallFloorT UnPack()
		{
			IRollBlockGridFallFloorT rollBlockGridFallFloorT = new IRollBlockGridFallFloorT();
			this.UnPackTo(rollBlockGridFallFloorT);
			return rollBlockGridFallFloorT;
		}

		// Token: 0x0601C472 RID: 115826 RVA: 0x003FE610 File Offset: 0x003FC810
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

		// Token: 0x0601C473 RID: 115827 RVA: 0x003FE7E4 File Offset: 0x003FC9E4
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

		// Token: 0x0400D03A RID: 53306
		private Table __p;
	}
}
