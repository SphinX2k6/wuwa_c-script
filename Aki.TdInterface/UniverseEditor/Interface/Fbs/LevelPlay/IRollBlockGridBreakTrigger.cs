using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049CB RID: 18891
	public struct IRollBlockGridBreakTrigger : IFlatbufferObject
	{
		// Token: 0x17008445 RID: 33861
		// (get) Token: 0x0601C3E4 RID: 115684 RVA: 0x003FCF42 File Offset: 0x003FB142
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C3E5 RID: 115685 RVA: 0x003FCF4F File Offset: 0x003FB14F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C3E6 RID: 115686 RVA: 0x003FCF58 File Offset: 0x003FB158
		public static IRollBlockGridBreakTrigger GetRootAsIRollBlockGridBreakTrigger(ByteBuffer _bb)
		{
			return IRollBlockGridBreakTrigger.GetRootAsIRollBlockGridBreakTrigger(_bb, default(IRollBlockGridBreakTrigger));
		}

		// Token: 0x0601C3E7 RID: 115687 RVA: 0x003FCF74 File Offset: 0x003FB174
		public static IRollBlockGridBreakTrigger GetRootAsIRollBlockGridBreakTrigger(ByteBuffer _bb, IRollBlockGridBreakTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C3E8 RID: 115688 RVA: 0x003FCF91 File Offset: 0x003FB191
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C3E9 RID: 115689 RVA: 0x003FCFA0 File Offset: 0x003FB1A0
		public IRollBlockGridBreakTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008446 RID: 33862
		// (get) Token: 0x0601C3EA RID: 115690 RVA: 0x003FCFB0 File Offset: 0x003FB1B0
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

		// Token: 0x17008447 RID: 33863
		// (get) Token: 0x0601C3EB RID: 115691 RVA: 0x003FCFEC File Offset: 0x003FB1EC
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

		// Token: 0x0601C3EC RID: 115692 RVA: 0x003FD028 File Offset: 0x003FB228
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C3ED RID: 115693 RVA: 0x003FD06C File Offset: 0x003FB26C
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C3EE RID: 115694 RVA: 0x003FD088 File Offset: 0x003FB288
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C3EF RID: 115695 RVA: 0x003FD0A4 File Offset: 0x003FB2A4
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008448 RID: 33864
		// (get) Token: 0x0601C3F0 RID: 115696 RVA: 0x003FD0E4 File Offset: 0x003FB2E4
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

		// Token: 0x0601C3F1 RID: 115697 RVA: 0x003FD110 File Offset: 0x003FB310
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C3F2 RID: 115698 RVA: 0x003FD120 File Offset: 0x003FB320
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

		// Token: 0x0601C3F3 RID: 115699 RVA: 0x003FD18C File Offset: 0x003FB38C
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008449 RID: 33865
		// (get) Token: 0x0601C3F4 RID: 115700 RVA: 0x003FD1D4 File Offset: 0x003FB3D4
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

		// Token: 0x1700844A RID: 33866
		// (get) Token: 0x0601C3F5 RID: 115701 RVA: 0x003FD200 File Offset: 0x003FB400
		public int Key
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700844B RID: 33867
		// (get) Token: 0x0601C3F6 RID: 115702 RVA: 0x003FD240 File Offset: 0x003FB440
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

		// Token: 0x0601C3F7 RID: 115703 RVA: 0x003FD280 File Offset: 0x003FB480
		public static Offset<IRollBlockGridBreakTrigger> CreateIRollBlockGridBreakTrigger(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), int Key = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IRollBlockGridBreakTrigger.AddKey(builder, Key);
			IRollBlockGridBreakTrigger.AddItems(builder, ItemsOffset);
			IRollBlockGridBreakTrigger.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridBreakTrigger.AddBlock(builder, BlockOffset);
			IRollBlockGridBreakTrigger.AddNullMask(builder, NullMask);
			IRollBlockGridBreakTrigger.AddBlockType(builder, Block_type);
			IRollBlockGridBreakTrigger.AddType(builder, Type);
			return IRollBlockGridBreakTrigger.EndIRollBlockGridBreakTrigger(builder);
		}

		// Token: 0x0601C3F8 RID: 115704 RVA: 0x003FD2CF File Offset: 0x003FB4CF
		public static void StartIRollBlockGridBreakTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601C3F9 RID: 115705 RVA: 0x003FD2D8 File Offset: 0x003FB4D8
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C3FA RID: 115706 RVA: 0x003FD2E3 File Offset: 0x003FB4E3
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C3FB RID: 115707 RVA: 0x003FD2EE File Offset: 0x003FB4EE
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C3FC RID: 115708 RVA: 0x003FD2F9 File Offset: 0x003FB4F9
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C3FD RID: 115709 RVA: 0x003FD30C File Offset: 0x003FB50C
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C3FE RID: 115710 RVA: 0x003FD343 File Offset: 0x003FB543
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3FF RID: 115711 RVA: 0x003FD35D File Offset: 0x003FB55D
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C400 RID: 115712 RVA: 0x003FD37B File Offset: 0x003FB57B
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C401 RID: 115713 RVA: 0x003FD394 File Offset: 0x003FB594
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C402 RID: 115714 RVA: 0x003FD39F File Offset: 0x003FB59F
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C403 RID: 115715 RVA: 0x003FD3B0 File Offset: 0x003FB5B0
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C404 RID: 115716 RVA: 0x003FD3E7 File Offset: 0x003FB5E7
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C405 RID: 115717 RVA: 0x003FD401 File Offset: 0x003FB601
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C406 RID: 115718 RVA: 0x003FD41F File Offset: 0x003FB61F
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C407 RID: 115719 RVA: 0x003FD438 File Offset: 0x003FB638
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C408 RID: 115720 RVA: 0x003FD443 File Offset: 0x003FB643
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(5, key, 0);
		}

		// Token: 0x0601C409 RID: 115721 RVA: 0x003FD44E File Offset: 0x003FB64E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601C40A RID: 115722 RVA: 0x003FD459 File Offset: 0x003FB659
		public static Offset<IRollBlockGridBreakTrigger> EndIRollBlockGridBreakTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridBreakTrigger>(builder.EndTable());
		}

		// Token: 0x0601C40B RID: 115723 RVA: 0x003FD468 File Offset: 0x003FB668
		public IRollBlockGridBreakTriggerT UnPack()
		{
			IRollBlockGridBreakTriggerT rollBlockGridBreakTriggerT = new IRollBlockGridBreakTriggerT();
			this.UnPackTo(rollBlockGridBreakTriggerT);
			return rollBlockGridBreakTriggerT;
		}

		// Token: 0x0601C40C RID: 115724 RVA: 0x003FD484 File Offset: 0x003FB684
		public void UnPackTo(IRollBlockGridBreakTriggerT _o)
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
			_o.Key = this.Key;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C40D RID: 115725 RVA: 0x003FD664 File Offset: 0x003FB864
		public static Offset<IRollBlockGridBreakTrigger> Pack(FlatBufferBuilder builder, IRollBlockGridBreakTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridBreakTrigger>);
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
				items_typeOffset = IRollBlockGridBreakTrigger.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridBreakTrigger.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridBreakTrigger.CreateIRollBlockGridBreakTrigger(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.Key, _o.NullMask);
		}

		// Token: 0x0400D02F RID: 53295
		private Table __p;
	}
}
