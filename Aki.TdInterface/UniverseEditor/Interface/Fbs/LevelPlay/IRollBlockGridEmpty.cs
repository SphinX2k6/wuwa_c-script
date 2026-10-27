using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004566 RID: 17766
	public struct IRollBlockGridEmpty : IFlatbufferObject
	{
		// Token: 0x17007E10 RID: 32272
		// (get) Token: 0x0601AC45 RID: 109637 RVA: 0x003D15EE File Offset: 0x003CF7EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AC46 RID: 109638 RVA: 0x003D15FB File Offset: 0x003CF7FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AC47 RID: 109639 RVA: 0x003D1604 File Offset: 0x003CF804
		public static IRollBlockGridEmpty GetRootAsIRollBlockGridEmpty(ByteBuffer _bb)
		{
			return IRollBlockGridEmpty.GetRootAsIRollBlockGridEmpty(_bb, default(IRollBlockGridEmpty));
		}

		// Token: 0x0601AC48 RID: 109640 RVA: 0x003D1620 File Offset: 0x003CF820
		public static IRollBlockGridEmpty GetRootAsIRollBlockGridEmpty(ByteBuffer _bb, IRollBlockGridEmpty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AC49 RID: 109641 RVA: 0x003D163D File Offset: 0x003CF83D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AC4A RID: 109642 RVA: 0x003D164C File Offset: 0x003CF84C
		public IRollBlockGridEmpty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E11 RID: 32273
		// (get) Token: 0x0601AC4B RID: 109643 RVA: 0x003D165C File Offset: 0x003CF85C
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

		// Token: 0x17007E12 RID: 32274
		// (get) Token: 0x0601AC4C RID: 109644 RVA: 0x003D1698 File Offset: 0x003CF898
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

		// Token: 0x0601AC4D RID: 109645 RVA: 0x003D16D4 File Offset: 0x003CF8D4
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AC4E RID: 109646 RVA: 0x003D1718 File Offset: 0x003CF918
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601AC4F RID: 109647 RVA: 0x003D1734 File Offset: 0x003CF934
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601AC50 RID: 109648 RVA: 0x003D1750 File Offset: 0x003CF950
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E13 RID: 32275
		// (get) Token: 0x0601AC51 RID: 109649 RVA: 0x003D1790 File Offset: 0x003CF990
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

		// Token: 0x0601AC52 RID: 109650 RVA: 0x003D17BC File Offset: 0x003CF9BC
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601AC53 RID: 109651 RVA: 0x003D17CC File Offset: 0x003CF9CC
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

		// Token: 0x0601AC54 RID: 109652 RVA: 0x003D1838 File Offset: 0x003CFA38
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E14 RID: 32276
		// (get) Token: 0x0601AC55 RID: 109653 RVA: 0x003D1880 File Offset: 0x003CFA80
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

		// Token: 0x17007E15 RID: 32277
		// (get) Token: 0x0601AC56 RID: 109654 RVA: 0x003D18AC File Offset: 0x003CFAAC
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

		// Token: 0x0601AC57 RID: 109655 RVA: 0x003D18E9 File Offset: 0x003CFAE9
		public static Offset<IRollBlockGridEmpty> CreateIRollBlockGridEmpty(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRollBlockGridEmpty.AddItems(builder, ItemsOffset);
			IRollBlockGridEmpty.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridEmpty.AddBlock(builder, BlockOffset);
			IRollBlockGridEmpty.AddNullMask(builder, NullMask);
			IRollBlockGridEmpty.AddBlockType(builder, Block_type);
			IRollBlockGridEmpty.AddType(builder, Type);
			return IRollBlockGridEmpty.EndIRollBlockGridEmpty(builder);
		}

		// Token: 0x0601AC58 RID: 109656 RVA: 0x003D1925 File Offset: 0x003CFB25
		public static void StartIRollBlockGridEmpty(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601AC59 RID: 109657 RVA: 0x003D192E File Offset: 0x003CFB2E
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AC5A RID: 109658 RVA: 0x003D1939 File Offset: 0x003CFB39
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601AC5B RID: 109659 RVA: 0x003D1944 File Offset: 0x003CFB44
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601AC5C RID: 109660 RVA: 0x003D194F File Offset: 0x003CFB4F
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601AC5D RID: 109661 RVA: 0x003D1960 File Offset: 0x003CFB60
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AC5E RID: 109662 RVA: 0x003D1997 File Offset: 0x003CFB97
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC5F RID: 109663 RVA: 0x003D19B1 File Offset: 0x003CFBB1
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC60 RID: 109664 RVA: 0x003D19CF File Offset: 0x003CFBCF
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AC61 RID: 109665 RVA: 0x003D19E8 File Offset: 0x003CFBE8
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AC62 RID: 109666 RVA: 0x003D19F3 File Offset: 0x003CFBF3
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601AC63 RID: 109667 RVA: 0x003D1A04 File Offset: 0x003CFC04
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AC64 RID: 109668 RVA: 0x003D1A3B File Offset: 0x003CFC3B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC65 RID: 109669 RVA: 0x003D1A55 File Offset: 0x003CFC55
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AC66 RID: 109670 RVA: 0x003D1A73 File Offset: 0x003CFC73
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AC67 RID: 109671 RVA: 0x003D1A8C File Offset: 0x003CFC8C
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AC68 RID: 109672 RVA: 0x003D1A97 File Offset: 0x003CFC97
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601AC69 RID: 109673 RVA: 0x003D1AA2 File Offset: 0x003CFCA2
		public static Offset<IRollBlockGridEmpty> EndIRollBlockGridEmpty(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridEmpty>(builder.EndTable());
		}

		// Token: 0x0601AC6A RID: 109674 RVA: 0x003D1AB0 File Offset: 0x003CFCB0
		public IRollBlockGridEmptyT UnPack()
		{
			IRollBlockGridEmptyT rollBlockGridEmptyT = new IRollBlockGridEmptyT();
			this.UnPackTo(rollBlockGridEmptyT);
			return rollBlockGridEmptyT;
		}

		// Token: 0x0601AC6B RID: 109675 RVA: 0x003D1ACC File Offset: 0x003CFCCC
		public void UnPackTo(IRollBlockGridEmptyT _o)
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

		// Token: 0x0601AC6C RID: 109676 RVA: 0x003D1CA0 File Offset: 0x003CFEA0
		public static Offset<IRollBlockGridEmpty> Pack(FlatBufferBuilder builder, IRollBlockGridEmptyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridEmpty>);
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
				items_typeOffset = IRollBlockGridEmpty.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridEmpty.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridEmpty.CreateIRollBlockGridEmpty(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.NullMask);
		}

		// Token: 0x0400C606 RID: 50694
		private Table __p;
	}
}
