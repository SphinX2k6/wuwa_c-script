using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049E3 RID: 18915
	public struct IRollBlockGridQuantum : IFlatbufferObject
	{
		// Token: 0x170084A1 RID: 33953
		// (get) Token: 0x0601C58C RID: 116108 RVA: 0x0040181E File Offset: 0x003FFA1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C58D RID: 116109 RVA: 0x0040182B File Offset: 0x003FFA2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C58E RID: 116110 RVA: 0x00401834 File Offset: 0x003FFA34
		public static IRollBlockGridQuantum GetRootAsIRollBlockGridQuantum(ByteBuffer _bb)
		{
			return IRollBlockGridQuantum.GetRootAsIRollBlockGridQuantum(_bb, default(IRollBlockGridQuantum));
		}

		// Token: 0x0601C58F RID: 116111 RVA: 0x00401850 File Offset: 0x003FFA50
		public static IRollBlockGridQuantum GetRootAsIRollBlockGridQuantum(ByteBuffer _bb, IRollBlockGridQuantum obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C590 RID: 116112 RVA: 0x0040186D File Offset: 0x003FFA6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C591 RID: 116113 RVA: 0x0040187C File Offset: 0x003FFA7C
		public IRollBlockGridQuantum __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084A2 RID: 33954
		// (get) Token: 0x0601C592 RID: 116114 RVA: 0x0040188C File Offset: 0x003FFA8C
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

		// Token: 0x170084A3 RID: 33955
		// (get) Token: 0x0601C593 RID: 116115 RVA: 0x004018C8 File Offset: 0x003FFAC8
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

		// Token: 0x0601C594 RID: 116116 RVA: 0x00401904 File Offset: 0x003FFB04
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C595 RID: 116117 RVA: 0x00401948 File Offset: 0x003FFB48
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C596 RID: 116118 RVA: 0x00401964 File Offset: 0x003FFB64
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C597 RID: 116119 RVA: 0x00401980 File Offset: 0x003FFB80
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170084A4 RID: 33956
		// (get) Token: 0x0601C598 RID: 116120 RVA: 0x004019C0 File Offset: 0x003FFBC0
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

		// Token: 0x0601C599 RID: 116121 RVA: 0x004019EC File Offset: 0x003FFBEC
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C59A RID: 116122 RVA: 0x004019FC File Offset: 0x003FFBFC
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

		// Token: 0x0601C59B RID: 116123 RVA: 0x00401A68 File Offset: 0x003FFC68
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170084A5 RID: 33957
		// (get) Token: 0x0601C59C RID: 116124 RVA: 0x00401AB0 File Offset: 0x003FFCB0
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

		// Token: 0x170084A6 RID: 33958
		// (get) Token: 0x0601C59D RID: 116125 RVA: 0x00401ADC File Offset: 0x003FFCDC
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

		// Token: 0x0601C59E RID: 116126 RVA: 0x00401B19 File Offset: 0x003FFD19
		public static Offset<IRollBlockGridQuantum> CreateIRollBlockGridQuantum(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRollBlockGridQuantum.AddItems(builder, ItemsOffset);
			IRollBlockGridQuantum.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridQuantum.AddBlock(builder, BlockOffset);
			IRollBlockGridQuantum.AddNullMask(builder, NullMask);
			IRollBlockGridQuantum.AddBlockType(builder, Block_type);
			IRollBlockGridQuantum.AddType(builder, Type);
			return IRollBlockGridQuantum.EndIRollBlockGridQuantum(builder);
		}

		// Token: 0x0601C59F RID: 116127 RVA: 0x00401B55 File Offset: 0x003FFD55
		public static void StartIRollBlockGridQuantum(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C5A0 RID: 116128 RVA: 0x00401B5E File Offset: 0x003FFD5E
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C5A1 RID: 116129 RVA: 0x00401B69 File Offset: 0x003FFD69
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C5A2 RID: 116130 RVA: 0x00401B74 File Offset: 0x003FFD74
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C5A3 RID: 116131 RVA: 0x00401B7F File Offset: 0x003FFD7F
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C5A4 RID: 116132 RVA: 0x00401B90 File Offset: 0x003FFD90
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C5A5 RID: 116133 RVA: 0x00401BC7 File Offset: 0x003FFDC7
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C5A6 RID: 116134 RVA: 0x00401BE1 File Offset: 0x003FFDE1
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C5A7 RID: 116135 RVA: 0x00401BFF File Offset: 0x003FFDFF
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C5A8 RID: 116136 RVA: 0x00401C18 File Offset: 0x003FFE18
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C5A9 RID: 116137 RVA: 0x00401C23 File Offset: 0x003FFE23
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C5AA RID: 116138 RVA: 0x00401C34 File Offset: 0x003FFE34
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C5AB RID: 116139 RVA: 0x00401C6B File Offset: 0x003FFE6B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C5AC RID: 116140 RVA: 0x00401C85 File Offset: 0x003FFE85
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C5AD RID: 116141 RVA: 0x00401CA3 File Offset: 0x003FFEA3
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C5AE RID: 116142 RVA: 0x00401CBC File Offset: 0x003FFEBC
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C5AF RID: 116143 RVA: 0x00401CC7 File Offset: 0x003FFEC7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601C5B0 RID: 116144 RVA: 0x00401CD2 File Offset: 0x003FFED2
		public static Offset<IRollBlockGridQuantum> EndIRollBlockGridQuantum(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridQuantum>(builder.EndTable());
		}

		// Token: 0x0601C5B1 RID: 116145 RVA: 0x00401CE0 File Offset: 0x003FFEE0
		public IRollBlockGridQuantumT UnPack()
		{
			IRollBlockGridQuantumT rollBlockGridQuantumT = new IRollBlockGridQuantumT();
			this.UnPackTo(rollBlockGridQuantumT);
			return rollBlockGridQuantumT;
		}

		// Token: 0x0601C5B2 RID: 116146 RVA: 0x00401CFC File Offset: 0x003FFEFC
		public void UnPackTo(IRollBlockGridQuantumT _o)
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

		// Token: 0x0601C5B3 RID: 116147 RVA: 0x00401ED0 File Offset: 0x004000D0
		public static Offset<IRollBlockGridQuantum> Pack(FlatBufferBuilder builder, IRollBlockGridQuantumT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridQuantum>);
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
				items_typeOffset = IRollBlockGridQuantum.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridQuantum.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridQuantum.CreateIRollBlockGridQuantum(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.NullMask);
		}

		// Token: 0x0400D05D RID: 53341
		private Table __p;
	}
}
