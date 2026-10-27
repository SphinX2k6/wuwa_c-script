using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004563 RID: 17763
	public struct IRollBlockGridBreakTrigger : IFlatbufferObject
	{
		// Token: 0x17007E04 RID: 32260
		// (get) Token: 0x0601AC0F RID: 109583 RVA: 0x003D0CA6 File Offset: 0x003CEEA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AC10 RID: 109584 RVA: 0x003D0CB3 File Offset: 0x003CEEB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AC11 RID: 109585 RVA: 0x003D0CBC File Offset: 0x003CEEBC
		public static IRollBlockGridBreakTrigger GetRootAsIRollBlockGridBreakTrigger(ByteBuffer _bb)
		{
			return IRollBlockGridBreakTrigger.GetRootAsIRollBlockGridBreakTrigger(_bb, default(IRollBlockGridBreakTrigger));
		}

		// Token: 0x0601AC12 RID: 109586 RVA: 0x003D0CD8 File Offset: 0x003CEED8
		public static IRollBlockGridBreakTrigger GetRootAsIRollBlockGridBreakTrigger(ByteBuffer _bb, IRollBlockGridBreakTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AC13 RID: 109587 RVA: 0x003D0CF5 File Offset: 0x003CEEF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AC14 RID: 109588 RVA: 0x003D0D04 File Offset: 0x003CEF04
		public IRollBlockGridBreakTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E05 RID: 32261
		// (get) Token: 0x0601AC15 RID: 109589 RVA: 0x003D0D14 File Offset: 0x003CEF14
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

		// Token: 0x17007E06 RID: 32262
		// (get) Token: 0x0601AC16 RID: 109590 RVA: 0x003D0D50 File Offset: 0x003CEF50
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

		// Token: 0x0601AC17 RID: 109591 RVA: 0x003D0D8C File Offset: 0x003CEF8C
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AC18 RID: 109592 RVA: 0x003D0DD0 File Offset: 0x003CEFD0
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601AC19 RID: 109593 RVA: 0x003D0DEC File Offset: 0x003CEFEC
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601AC1A RID: 109594 RVA: 0x003D0E08 File Offset: 0x003CF008
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E07 RID: 32263
		// (get) Token: 0x0601AC1B RID: 109595 RVA: 0x003D0E48 File Offset: 0x003CF048
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

		// Token: 0x0601AC1C RID: 109596 RVA: 0x003D0E74 File Offset: 0x003CF074
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601AC1D RID: 109597 RVA: 0x003D0E84 File Offset: 0x003CF084
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

		// Token: 0x0601AC1E RID: 109598 RVA: 0x003D0EF0 File Offset: 0x003CF0F0
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E08 RID: 32264
		// (get) Token: 0x0601AC1F RID: 109599 RVA: 0x003D0F38 File Offset: 0x003CF138
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

		// Token: 0x17007E09 RID: 32265
		// (get) Token: 0x0601AC20 RID: 109600 RVA: 0x003D0F64 File Offset: 0x003CF164
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

		// Token: 0x17007E0A RID: 32266
		// (get) Token: 0x0601AC21 RID: 109601 RVA: 0x003D0FA4 File Offset: 0x003CF1A4
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

		// Token: 0x0601AC22 RID: 109602 RVA: 0x003D0FE4 File Offset: 0x003CF1E4
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

		// Token: 0x0601AC23 RID: 109603 RVA: 0x003D1033 File Offset: 0x003CF233
		public static void StartIRollBlockGridBreakTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601AC24 RID: 109604 RVA: 0x003D103C File Offset: 0x003CF23C
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AC25 RID: 109605 RVA: 0x003D1047 File Offset: 0x003CF247
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601AC26 RID: 109606 RVA: 0x003D1052 File Offset: 0x003CF252
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601AC27 RID: 109607 RVA: 0x003D105D File Offset: 0x003CF25D
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601AC28 RID: 109608 RVA: 0x003D1070 File Offset: 0x003CF270
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AC29 RID: 109609 RVA: 0x003D10A7 File Offset: 0x003CF2A7
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC2A RID: 109610 RVA: 0x003D10C1 File Offset: 0x003CF2C1
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC2B RID: 109611 RVA: 0x003D10DF File Offset: 0x003CF2DF
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AC2C RID: 109612 RVA: 0x003D10F8 File Offset: 0x003CF2F8
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AC2D RID: 109613 RVA: 0x003D1103 File Offset: 0x003CF303
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601AC2E RID: 109614 RVA: 0x003D1114 File Offset: 0x003CF314
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AC2F RID: 109615 RVA: 0x003D114B File Offset: 0x003CF34B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC30 RID: 109616 RVA: 0x003D1165 File Offset: 0x003CF365
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC31 RID: 109617 RVA: 0x003D1183 File Offset: 0x003CF383
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AC32 RID: 109618 RVA: 0x003D119C File Offset: 0x003CF39C
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AC33 RID: 109619 RVA: 0x003D11A7 File Offset: 0x003CF3A7
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(5, key, 0);
		}

		// Token: 0x0601AC34 RID: 109620 RVA: 0x003D11B2 File Offset: 0x003CF3B2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601AC35 RID: 109621 RVA: 0x003D11BD File Offset: 0x003CF3BD
		public static Offset<IRollBlockGridBreakTrigger> EndIRollBlockGridBreakTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridBreakTrigger>(builder.EndTable());
		}

		// Token: 0x0601AC36 RID: 109622 RVA: 0x003D11CC File Offset: 0x003CF3CC
		public IRollBlockGridBreakTriggerT UnPack()
		{
			IRollBlockGridBreakTriggerT rollBlockGridBreakTriggerT = new IRollBlockGridBreakTriggerT();
			this.UnPackTo(rollBlockGridBreakTriggerT);
			return rollBlockGridBreakTriggerT;
		}

		// Token: 0x0601AC37 RID: 109623 RVA: 0x003D11E8 File Offset: 0x003CF3E8
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

		// Token: 0x0601AC38 RID: 109624 RVA: 0x003D13C8 File Offset: 0x003CF5C8
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

		// Token: 0x0400C600 RID: 50688
		private Table __p;
	}
}
