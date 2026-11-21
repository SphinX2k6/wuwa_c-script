using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049DD RID: 18909
	public struct IRollBlockGridLaser : IFlatbufferObject
	{
		// Token: 0x17008485 RID: 33925
		// (get) Token: 0x0601C518 RID: 115992 RVA: 0x00400472 File Offset: 0x003FE672
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C519 RID: 115993 RVA: 0x0040047F File Offset: 0x003FE67F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C51A RID: 115994 RVA: 0x00400488 File Offset: 0x003FE688
		public static IRollBlockGridLaser GetRootAsIRollBlockGridLaser(ByteBuffer _bb)
		{
			return IRollBlockGridLaser.GetRootAsIRollBlockGridLaser(_bb, default(IRollBlockGridLaser));
		}

		// Token: 0x0601C51B RID: 115995 RVA: 0x004004A4 File Offset: 0x003FE6A4
		public static IRollBlockGridLaser GetRootAsIRollBlockGridLaser(ByteBuffer _bb, IRollBlockGridLaser obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C51C RID: 115996 RVA: 0x004004C1 File Offset: 0x003FE6C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C51D RID: 115997 RVA: 0x004004D0 File Offset: 0x003FE6D0
		public IRollBlockGridLaser __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008486 RID: 33926
		// (get) Token: 0x0601C51E RID: 115998 RVA: 0x004004E0 File Offset: 0x003FE6E0
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

		// Token: 0x17008487 RID: 33927
		// (get) Token: 0x0601C51F RID: 115999 RVA: 0x0040051C File Offset: 0x003FE71C
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

		// Token: 0x0601C520 RID: 116000 RVA: 0x00400558 File Offset: 0x003FE758
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C521 RID: 116001 RVA: 0x0040059C File Offset: 0x003FE79C
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C522 RID: 116002 RVA: 0x004005B8 File Offset: 0x003FE7B8
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C523 RID: 116003 RVA: 0x004005D4 File Offset: 0x003FE7D4
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008488 RID: 33928
		// (get) Token: 0x0601C524 RID: 116004 RVA: 0x00400614 File Offset: 0x003FE814
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

		// Token: 0x0601C525 RID: 116005 RVA: 0x00400640 File Offset: 0x003FE840
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C526 RID: 116006 RVA: 0x00400650 File Offset: 0x003FE850
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

		// Token: 0x0601C527 RID: 116007 RVA: 0x004006BC File Offset: 0x003FE8BC
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008489 RID: 33929
		// (get) Token: 0x0601C528 RID: 116008 RVA: 0x00400704 File Offset: 0x003FE904
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

		// Token: 0x1700848A RID: 33930
		// (get) Token: 0x0601C529 RID: 116009 RVA: 0x00400730 File Offset: 0x003FE930
		public ERollBlockLayType Direction
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

		// Token: 0x1700848B RID: 33931
		// (get) Token: 0x0601C52A RID: 116010 RVA: 0x00400770 File Offset: 0x003FE970
		public int Length
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700848C RID: 33932
		// (get) Token: 0x0601C52B RID: 116011 RVA: 0x004007B0 File Offset: 0x003FE9B0
		public int Height
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700848D RID: 33933
		// (get) Token: 0x0601C52C RID: 116012 RVA: 0x004007F0 File Offset: 0x003FE9F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C52D RID: 116013 RVA: 0x00400830 File Offset: 0x003FEA30
		public static Offset<IRollBlockGridLaser> CreateIRollBlockGridLaser(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), ERollBlockLayType Direction = ERollBlockLayType.Left, int Length = 0, int Height = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IRollBlockGridLaser.AddHeight(builder, Height);
			IRollBlockGridLaser.AddLength(builder, Length);
			IRollBlockGridLaser.AddItems(builder, ItemsOffset);
			IRollBlockGridLaser.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridLaser.AddBlock(builder, BlockOffset);
			IRollBlockGridLaser.AddNullMask(builder, NullMask);
			IRollBlockGridLaser.AddDirection(builder, Direction);
			IRollBlockGridLaser.AddBlockType(builder, Block_type);
			IRollBlockGridLaser.AddType(builder, Type);
			return IRollBlockGridLaser.EndIRollBlockGridLaser(builder);
		}

		// Token: 0x0601C52E RID: 116014 RVA: 0x00400890 File Offset: 0x003FEA90
		public static void StartIRollBlockGridLaser(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601C52F RID: 116015 RVA: 0x0040089A File Offset: 0x003FEA9A
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C530 RID: 116016 RVA: 0x004008A5 File Offset: 0x003FEAA5
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C531 RID: 116017 RVA: 0x004008B0 File Offset: 0x003FEAB0
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C532 RID: 116018 RVA: 0x004008BB File Offset: 0x003FEABB
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C533 RID: 116019 RVA: 0x004008CC File Offset: 0x003FEACC
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C534 RID: 116020 RVA: 0x00400903 File Offset: 0x003FEB03
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C535 RID: 116021 RVA: 0x0040091D File Offset: 0x003FEB1D
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C536 RID: 116022 RVA: 0x0040093B File Offset: 0x003FEB3B
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C537 RID: 116023 RVA: 0x00400954 File Offset: 0x003FEB54
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C538 RID: 116024 RVA: 0x0040095F File Offset: 0x003FEB5F
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C539 RID: 116025 RVA: 0x00400970 File Offset: 0x003FEB70
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C53A RID: 116026 RVA: 0x004009A7 File Offset: 0x003FEBA7
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C53B RID: 116027 RVA: 0x004009C1 File Offset: 0x003FEBC1
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C53C RID: 116028 RVA: 0x004009DF File Offset: 0x003FEBDF
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C53D RID: 116029 RVA: 0x004009F8 File Offset: 0x003FEBF8
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C53E RID: 116030 RVA: 0x00400A03 File Offset: 0x003FEC03
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(5, (byte)direction, 0);
		}

		// Token: 0x0601C53F RID: 116031 RVA: 0x00400A0E File Offset: 0x003FEC0E
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(6, length, 0);
		}

		// Token: 0x0601C540 RID: 116032 RVA: 0x00400A19 File Offset: 0x003FEC19
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(7, height, 0);
		}

		// Token: 0x0601C541 RID: 116033 RVA: 0x00400A24 File Offset: 0x003FEC24
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601C542 RID: 116034 RVA: 0x00400A2F File Offset: 0x003FEC2F
		public static Offset<IRollBlockGridLaser> EndIRollBlockGridLaser(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridLaser>(builder.EndTable());
		}

		// Token: 0x0601C543 RID: 116035 RVA: 0x00400A3C File Offset: 0x003FEC3C
		public IRollBlockGridLaserT UnPack()
		{
			IRollBlockGridLaserT rollBlockGridLaserT = new IRollBlockGridLaserT();
			this.UnPackTo(rollBlockGridLaserT);
			return rollBlockGridLaserT;
		}

		// Token: 0x0601C544 RID: 116036 RVA: 0x00400A58 File Offset: 0x003FEC58
		public void UnPackTo(IRollBlockGridLaserT _o)
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
			_o.Direction = this.Direction;
			_o.Length = this.Length;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C545 RID: 116037 RVA: 0x00400C50 File Offset: 0x003FEE50
		public static Offset<IRollBlockGridLaser> Pack(FlatBufferBuilder builder, IRollBlockGridLaserT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridLaser>);
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
				items_typeOffset = IRollBlockGridLaser.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridLaser.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridLaser.CreateIRollBlockGridLaser(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.Direction, _o.Length, _o.Height, _o.NullMask);
		}

		// Token: 0x0400D04F RID: 53327
		private Table __p;
	}
}
