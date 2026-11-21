using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D7 RID: 18903
	public struct IRollBlockGridGoal : IFlatbufferObject
	{
		// Token: 0x1700846F RID: 33903
		// (get) Token: 0x0601C4B0 RID: 115888 RVA: 0x003FF282 File Offset: 0x003FD482
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C4B1 RID: 115889 RVA: 0x003FF28F File Offset: 0x003FD48F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C4B2 RID: 115890 RVA: 0x003FF298 File Offset: 0x003FD498
		public static IRollBlockGridGoal GetRootAsIRollBlockGridGoal(ByteBuffer _bb)
		{
			return IRollBlockGridGoal.GetRootAsIRollBlockGridGoal(_bb, default(IRollBlockGridGoal));
		}

		// Token: 0x0601C4B3 RID: 115891 RVA: 0x003FF2B4 File Offset: 0x003FD4B4
		public static IRollBlockGridGoal GetRootAsIRollBlockGridGoal(ByteBuffer _bb, IRollBlockGridGoal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C4B4 RID: 115892 RVA: 0x003FF2D1 File Offset: 0x003FD4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C4B5 RID: 115893 RVA: 0x003FF2E0 File Offset: 0x003FD4E0
		public IRollBlockGridGoal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008470 RID: 33904
		// (get) Token: 0x0601C4B6 RID: 115894 RVA: 0x003FF2F0 File Offset: 0x003FD4F0
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

		// Token: 0x17008471 RID: 33905
		// (get) Token: 0x0601C4B7 RID: 115895 RVA: 0x003FF32C File Offset: 0x003FD52C
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

		// Token: 0x0601C4B8 RID: 115896 RVA: 0x003FF368 File Offset: 0x003FD568
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C4B9 RID: 115897 RVA: 0x003FF3AC File Offset: 0x003FD5AC
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C4BA RID: 115898 RVA: 0x003FF3C8 File Offset: 0x003FD5C8
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C4BB RID: 115899 RVA: 0x003FF3E4 File Offset: 0x003FD5E4
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008472 RID: 33906
		// (get) Token: 0x0601C4BC RID: 115900 RVA: 0x003FF424 File Offset: 0x003FD624
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

		// Token: 0x0601C4BD RID: 115901 RVA: 0x003FF450 File Offset: 0x003FD650
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C4BE RID: 115902 RVA: 0x003FF460 File Offset: 0x003FD660
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

		// Token: 0x0601C4BF RID: 115903 RVA: 0x003FF4CC File Offset: 0x003FD6CC
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008473 RID: 33907
		// (get) Token: 0x0601C4C0 RID: 115904 RVA: 0x003FF514 File Offset: 0x003FD714
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

		// Token: 0x17008474 RID: 33908
		// (get) Token: 0x0601C4C1 RID: 115905 RVA: 0x003FF540 File Offset: 0x003FD740
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

		// Token: 0x0601C4C2 RID: 115906 RVA: 0x003FF57D File Offset: 0x003FD77D
		public static Offset<IRollBlockGridGoal> CreateIRollBlockGridGoal(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRollBlockGridGoal.AddItems(builder, ItemsOffset);
			IRollBlockGridGoal.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridGoal.AddBlock(builder, BlockOffset);
			IRollBlockGridGoal.AddNullMask(builder, NullMask);
			IRollBlockGridGoal.AddBlockType(builder, Block_type);
			IRollBlockGridGoal.AddType(builder, Type);
			return IRollBlockGridGoal.EndIRollBlockGridGoal(builder);
		}

		// Token: 0x0601C4C3 RID: 115907 RVA: 0x003FF5B9 File Offset: 0x003FD7B9
		public static void StartIRollBlockGridGoal(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C4C4 RID: 115908 RVA: 0x003FF5C2 File Offset: 0x003FD7C2
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C4C5 RID: 115909 RVA: 0x003FF5CD File Offset: 0x003FD7CD
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C4C6 RID: 115910 RVA: 0x003FF5D8 File Offset: 0x003FD7D8
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C4C7 RID: 115911 RVA: 0x003FF5E3 File Offset: 0x003FD7E3
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C4C8 RID: 115912 RVA: 0x003FF5F4 File Offset: 0x003FD7F4
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C4C9 RID: 115913 RVA: 0x003FF62B File Offset: 0x003FD82B
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4CA RID: 115914 RVA: 0x003FF645 File Offset: 0x003FD845
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4CB RID: 115915 RVA: 0x003FF663 File Offset: 0x003FD863
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C4CC RID: 115916 RVA: 0x003FF67C File Offset: 0x003FD87C
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C4CD RID: 115917 RVA: 0x003FF687 File Offset: 0x003FD887
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C4CE RID: 115918 RVA: 0x003FF698 File Offset: 0x003FD898
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C4CF RID: 115919 RVA: 0x003FF6CF File Offset: 0x003FD8CF
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4D0 RID: 115920 RVA: 0x003FF6E9 File Offset: 0x003FD8E9
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4D1 RID: 115921 RVA: 0x003FF707 File Offset: 0x003FD907
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C4D2 RID: 115922 RVA: 0x003FF720 File Offset: 0x003FD920
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C4D3 RID: 115923 RVA: 0x003FF72B File Offset: 0x003FD92B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601C4D4 RID: 115924 RVA: 0x003FF736 File Offset: 0x003FD936
		public static Offset<IRollBlockGridGoal> EndIRollBlockGridGoal(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridGoal>(builder.EndTable());
		}

		// Token: 0x0601C4D5 RID: 115925 RVA: 0x003FF744 File Offset: 0x003FD944
		public IRollBlockGridGoalT UnPack()
		{
			IRollBlockGridGoalT rollBlockGridGoalT = new IRollBlockGridGoalT();
			this.UnPackTo(rollBlockGridGoalT);
			return rollBlockGridGoalT;
		}

		// Token: 0x0601C4D6 RID: 115926 RVA: 0x003FF760 File Offset: 0x003FD960
		public void UnPackTo(IRollBlockGridGoalT _o)
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

		// Token: 0x0601C4D7 RID: 115927 RVA: 0x003FF934 File Offset: 0x003FDB34
		public static Offset<IRollBlockGridGoal> Pack(FlatBufferBuilder builder, IRollBlockGridGoalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridGoal>);
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
				items_typeOffset = IRollBlockGridGoal.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridGoal.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridGoal.CreateIRollBlockGridGoal(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.NullMask);
		}

		// Token: 0x0400D044 RID: 53316
		private Table __p;
	}
}
