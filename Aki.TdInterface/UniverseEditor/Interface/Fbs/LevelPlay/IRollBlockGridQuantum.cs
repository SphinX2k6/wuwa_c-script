using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200457B RID: 17787
	public struct IRollBlockGridQuantum : IFlatbufferObject
	{
		// Token: 0x17007E60 RID: 32352
		// (get) Token: 0x0601ADB7 RID: 110007 RVA: 0x003D5582 File Offset: 0x003D3782
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ADB8 RID: 110008 RVA: 0x003D558F File Offset: 0x003D378F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ADB9 RID: 110009 RVA: 0x003D5598 File Offset: 0x003D3798
		public static IRollBlockGridQuantum GetRootAsIRollBlockGridQuantum(ByteBuffer _bb)
		{
			return IRollBlockGridQuantum.GetRootAsIRollBlockGridQuantum(_bb, default(IRollBlockGridQuantum));
		}

		// Token: 0x0601ADBA RID: 110010 RVA: 0x003D55B4 File Offset: 0x003D37B4
		public static IRollBlockGridQuantum GetRootAsIRollBlockGridQuantum(ByteBuffer _bb, IRollBlockGridQuantum obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ADBB RID: 110011 RVA: 0x003D55D1 File Offset: 0x003D37D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ADBC RID: 110012 RVA: 0x003D55E0 File Offset: 0x003D37E0
		public IRollBlockGridQuantum __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E61 RID: 32353
		// (get) Token: 0x0601ADBD RID: 110013 RVA: 0x003D55F0 File Offset: 0x003D37F0
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

		// Token: 0x17007E62 RID: 32354
		// (get) Token: 0x0601ADBE RID: 110014 RVA: 0x003D562C File Offset: 0x003D382C
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

		// Token: 0x0601ADBF RID: 110015 RVA: 0x003D5668 File Offset: 0x003D3868
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601ADC0 RID: 110016 RVA: 0x003D56AC File Offset: 0x003D38AC
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601ADC1 RID: 110017 RVA: 0x003D56C8 File Offset: 0x003D38C8
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601ADC2 RID: 110018 RVA: 0x003D56E4 File Offset: 0x003D38E4
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E63 RID: 32355
		// (get) Token: 0x0601ADC3 RID: 110019 RVA: 0x003D5724 File Offset: 0x003D3924
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

		// Token: 0x0601ADC4 RID: 110020 RVA: 0x003D5750 File Offset: 0x003D3950
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601ADC5 RID: 110021 RVA: 0x003D5760 File Offset: 0x003D3960
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

		// Token: 0x0601ADC6 RID: 110022 RVA: 0x003D57CC File Offset: 0x003D39CC
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E64 RID: 32356
		// (get) Token: 0x0601ADC7 RID: 110023 RVA: 0x003D5814 File Offset: 0x003D3A14
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

		// Token: 0x17007E65 RID: 32357
		// (get) Token: 0x0601ADC8 RID: 110024 RVA: 0x003D5840 File Offset: 0x003D3A40
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

		// Token: 0x0601ADC9 RID: 110025 RVA: 0x003D587D File Offset: 0x003D3A7D
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

		// Token: 0x0601ADCA RID: 110026 RVA: 0x003D58B9 File Offset: 0x003D3AB9
		public static void StartIRollBlockGridQuantum(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601ADCB RID: 110027 RVA: 0x003D58C2 File Offset: 0x003D3AC2
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ADCC RID: 110028 RVA: 0x003D58CD File Offset: 0x003D3ACD
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601ADCD RID: 110029 RVA: 0x003D58D8 File Offset: 0x003D3AD8
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601ADCE RID: 110030 RVA: 0x003D58E3 File Offset: 0x003D3AE3
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601ADCF RID: 110031 RVA: 0x003D58F4 File Offset: 0x003D3AF4
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ADD0 RID: 110032 RVA: 0x003D592B File Offset: 0x003D3B2B
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ADD1 RID: 110033 RVA: 0x003D5945 File Offset: 0x003D3B45
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ADD2 RID: 110034 RVA: 0x003D5963 File Offset: 0x003D3B63
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ADD3 RID: 110035 RVA: 0x003D597C File Offset: 0x003D3B7C
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601ADD4 RID: 110036 RVA: 0x003D5987 File Offset: 0x003D3B87
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601ADD5 RID: 110037 RVA: 0x003D5998 File Offset: 0x003D3B98
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ADD6 RID: 110038 RVA: 0x003D59CF File Offset: 0x003D3BCF
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ADD7 RID: 110039 RVA: 0x003D59E9 File Offset: 0x003D3BE9
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ADD8 RID: 110040 RVA: 0x003D5A07 File Offset: 0x003D3C07
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ADD9 RID: 110041 RVA: 0x003D5A20 File Offset: 0x003D3C20
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601ADDA RID: 110042 RVA: 0x003D5A2B File Offset: 0x003D3C2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601ADDB RID: 110043 RVA: 0x003D5A36 File Offset: 0x003D3C36
		public static Offset<IRollBlockGridQuantum> EndIRollBlockGridQuantum(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridQuantum>(builder.EndTable());
		}

		// Token: 0x0601ADDC RID: 110044 RVA: 0x003D5A44 File Offset: 0x003D3C44
		public IRollBlockGridQuantumT UnPack()
		{
			IRollBlockGridQuantumT rollBlockGridQuantumT = new IRollBlockGridQuantumT();
			this.UnPackTo(rollBlockGridQuantumT);
			return rollBlockGridQuantumT;
		}

		// Token: 0x0601ADDD RID: 110045 RVA: 0x003D5A60 File Offset: 0x003D3C60
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

		// Token: 0x0601ADDE RID: 110046 RVA: 0x003D5C34 File Offset: 0x003D3E34
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

		// Token: 0x0400C62E RID: 50734
		private Table __p;
	}
}
