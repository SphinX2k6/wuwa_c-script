using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200456F RID: 17775
	public struct IRollBlockGridGoal : IFlatbufferObject
	{
		// Token: 0x17007E2E RID: 32302
		// (get) Token: 0x0601ACDB RID: 109787 RVA: 0x003D2FE6 File Offset: 0x003D11E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ACDC RID: 109788 RVA: 0x003D2FF3 File Offset: 0x003D11F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ACDD RID: 109789 RVA: 0x003D2FFC File Offset: 0x003D11FC
		public static IRollBlockGridGoal GetRootAsIRollBlockGridGoal(ByteBuffer _bb)
		{
			return IRollBlockGridGoal.GetRootAsIRollBlockGridGoal(_bb, default(IRollBlockGridGoal));
		}

		// Token: 0x0601ACDE RID: 109790 RVA: 0x003D3018 File Offset: 0x003D1218
		public static IRollBlockGridGoal GetRootAsIRollBlockGridGoal(ByteBuffer _bb, IRollBlockGridGoal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ACDF RID: 109791 RVA: 0x003D3035 File Offset: 0x003D1235
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ACE0 RID: 109792 RVA: 0x003D3044 File Offset: 0x003D1244
		public IRollBlockGridGoal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E2F RID: 32303
		// (get) Token: 0x0601ACE1 RID: 109793 RVA: 0x003D3054 File Offset: 0x003D1254
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

		// Token: 0x17007E30 RID: 32304
		// (get) Token: 0x0601ACE2 RID: 109794 RVA: 0x003D3090 File Offset: 0x003D1290
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

		// Token: 0x0601ACE3 RID: 109795 RVA: 0x003D30CC File Offset: 0x003D12CC
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601ACE4 RID: 109796 RVA: 0x003D3110 File Offset: 0x003D1310
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601ACE5 RID: 109797 RVA: 0x003D312C File Offset: 0x003D132C
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601ACE6 RID: 109798 RVA: 0x003D3148 File Offset: 0x003D1348
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E31 RID: 32305
		// (get) Token: 0x0601ACE7 RID: 109799 RVA: 0x003D3188 File Offset: 0x003D1388
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

		// Token: 0x0601ACE8 RID: 109800 RVA: 0x003D31B4 File Offset: 0x003D13B4
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601ACE9 RID: 109801 RVA: 0x003D31C4 File Offset: 0x003D13C4
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

		// Token: 0x0601ACEA RID: 109802 RVA: 0x003D3230 File Offset: 0x003D1430
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E32 RID: 32306
		// (get) Token: 0x0601ACEB RID: 109803 RVA: 0x003D3278 File Offset: 0x003D1478
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

		// Token: 0x17007E33 RID: 32307
		// (get) Token: 0x0601ACEC RID: 109804 RVA: 0x003D32A4 File Offset: 0x003D14A4
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

		// Token: 0x0601ACED RID: 109805 RVA: 0x003D32E1 File Offset: 0x003D14E1
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

		// Token: 0x0601ACEE RID: 109806 RVA: 0x003D331D File Offset: 0x003D151D
		public static void StartIRollBlockGridGoal(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601ACEF RID: 109807 RVA: 0x003D3326 File Offset: 0x003D1526
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ACF0 RID: 109808 RVA: 0x003D3331 File Offset: 0x003D1531
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601ACF1 RID: 109809 RVA: 0x003D333C File Offset: 0x003D153C
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601ACF2 RID: 109810 RVA: 0x003D3347 File Offset: 0x003D1547
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601ACF3 RID: 109811 RVA: 0x003D3358 File Offset: 0x003D1558
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ACF4 RID: 109812 RVA: 0x003D338F File Offset: 0x003D158F
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACF5 RID: 109813 RVA: 0x003D33A9 File Offset: 0x003D15A9
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACF6 RID: 109814 RVA: 0x003D33C7 File Offset: 0x003D15C7
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ACF7 RID: 109815 RVA: 0x003D33E0 File Offset: 0x003D15E0
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601ACF8 RID: 109816 RVA: 0x003D33EB File Offset: 0x003D15EB
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601ACF9 RID: 109817 RVA: 0x003D33FC File Offset: 0x003D15FC
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ACFA RID: 109818 RVA: 0x003D3433 File Offset: 0x003D1633
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACFB RID: 109819 RVA: 0x003D344D File Offset: 0x003D164D
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ACFC RID: 109820 RVA: 0x003D346B File Offset: 0x003D166B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ACFD RID: 109821 RVA: 0x003D3484 File Offset: 0x003D1684
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601ACFE RID: 109822 RVA: 0x003D348F File Offset: 0x003D168F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601ACFF RID: 109823 RVA: 0x003D349A File Offset: 0x003D169A
		public static Offset<IRollBlockGridGoal> EndIRollBlockGridGoal(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridGoal>(builder.EndTable());
		}

		// Token: 0x0601AD00 RID: 109824 RVA: 0x003D34A8 File Offset: 0x003D16A8
		public IRollBlockGridGoalT UnPack()
		{
			IRollBlockGridGoalT rollBlockGridGoalT = new IRollBlockGridGoalT();
			this.UnPackTo(rollBlockGridGoalT);
			return rollBlockGridGoalT;
		}

		// Token: 0x0601AD01 RID: 109825 RVA: 0x003D34C4 File Offset: 0x003D16C4
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

		// Token: 0x0601AD02 RID: 109826 RVA: 0x003D3698 File Offset: 0x003D1898
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

		// Token: 0x0400C615 RID: 50709
		private Table __p;
	}
}
