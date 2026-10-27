using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004575 RID: 17781
	public struct IRollBlockGridLaser : IFlatbufferObject
	{
		// Token: 0x17007E44 RID: 32324
		// (get) Token: 0x0601AD43 RID: 109891 RVA: 0x003D41D6 File Offset: 0x003D23D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AD44 RID: 109892 RVA: 0x003D41E3 File Offset: 0x003D23E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AD45 RID: 109893 RVA: 0x003D41EC File Offset: 0x003D23EC
		public static IRollBlockGridLaser GetRootAsIRollBlockGridLaser(ByteBuffer _bb)
		{
			return IRollBlockGridLaser.GetRootAsIRollBlockGridLaser(_bb, default(IRollBlockGridLaser));
		}

		// Token: 0x0601AD46 RID: 109894 RVA: 0x003D4208 File Offset: 0x003D2408
		public static IRollBlockGridLaser GetRootAsIRollBlockGridLaser(ByteBuffer _bb, IRollBlockGridLaser obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AD47 RID: 109895 RVA: 0x003D4225 File Offset: 0x003D2425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AD48 RID: 109896 RVA: 0x003D4234 File Offset: 0x003D2434
		public IRollBlockGridLaser __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E45 RID: 32325
		// (get) Token: 0x0601AD49 RID: 109897 RVA: 0x003D4244 File Offset: 0x003D2444
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

		// Token: 0x17007E46 RID: 32326
		// (get) Token: 0x0601AD4A RID: 109898 RVA: 0x003D4280 File Offset: 0x003D2480
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

		// Token: 0x0601AD4B RID: 109899 RVA: 0x003D42BC File Offset: 0x003D24BC
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AD4C RID: 109900 RVA: 0x003D4300 File Offset: 0x003D2500
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601AD4D RID: 109901 RVA: 0x003D431C File Offset: 0x003D251C
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601AD4E RID: 109902 RVA: 0x003D4338 File Offset: 0x003D2538
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E47 RID: 32327
		// (get) Token: 0x0601AD4F RID: 109903 RVA: 0x003D4378 File Offset: 0x003D2578
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

		// Token: 0x0601AD50 RID: 109904 RVA: 0x003D43A4 File Offset: 0x003D25A4
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601AD51 RID: 109905 RVA: 0x003D43B4 File Offset: 0x003D25B4
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

		// Token: 0x0601AD52 RID: 109906 RVA: 0x003D4420 File Offset: 0x003D2620
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E48 RID: 32328
		// (get) Token: 0x0601AD53 RID: 109907 RVA: 0x003D4468 File Offset: 0x003D2668
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

		// Token: 0x17007E49 RID: 32329
		// (get) Token: 0x0601AD54 RID: 109908 RVA: 0x003D4494 File Offset: 0x003D2694
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

		// Token: 0x17007E4A RID: 32330
		// (get) Token: 0x0601AD55 RID: 109909 RVA: 0x003D44D4 File Offset: 0x003D26D4
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

		// Token: 0x17007E4B RID: 32331
		// (get) Token: 0x0601AD56 RID: 109910 RVA: 0x003D4514 File Offset: 0x003D2714
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

		// Token: 0x17007E4C RID: 32332
		// (get) Token: 0x0601AD57 RID: 109911 RVA: 0x003D4554 File Offset: 0x003D2754
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

		// Token: 0x0601AD58 RID: 109912 RVA: 0x003D4594 File Offset: 0x003D2794
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

		// Token: 0x0601AD59 RID: 109913 RVA: 0x003D45F4 File Offset: 0x003D27F4
		public static void StartIRollBlockGridLaser(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601AD5A RID: 109914 RVA: 0x003D45FE File Offset: 0x003D27FE
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AD5B RID: 109915 RVA: 0x003D4609 File Offset: 0x003D2809
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601AD5C RID: 109916 RVA: 0x003D4614 File Offset: 0x003D2814
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601AD5D RID: 109917 RVA: 0x003D461F File Offset: 0x003D281F
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601AD5E RID: 109918 RVA: 0x003D4630 File Offset: 0x003D2830
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AD5F RID: 109919 RVA: 0x003D4667 File Offset: 0x003D2867
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD60 RID: 109920 RVA: 0x003D4681 File Offset: 0x003D2881
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD61 RID: 109921 RVA: 0x003D469F File Offset: 0x003D289F
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AD62 RID: 109922 RVA: 0x003D46B8 File Offset: 0x003D28B8
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AD63 RID: 109923 RVA: 0x003D46C3 File Offset: 0x003D28C3
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601AD64 RID: 109924 RVA: 0x003D46D4 File Offset: 0x003D28D4
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AD65 RID: 109925 RVA: 0x003D470B File Offset: 0x003D290B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD66 RID: 109926 RVA: 0x003D4725 File Offset: 0x003D2925
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD67 RID: 109927 RVA: 0x003D4743 File Offset: 0x003D2943
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AD68 RID: 109928 RVA: 0x003D475C File Offset: 0x003D295C
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AD69 RID: 109929 RVA: 0x003D4767 File Offset: 0x003D2967
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(5, (byte)direction, 0);
		}

		// Token: 0x0601AD6A RID: 109930 RVA: 0x003D4772 File Offset: 0x003D2972
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(6, length, 0);
		}

		// Token: 0x0601AD6B RID: 109931 RVA: 0x003D477D File Offset: 0x003D297D
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(7, height, 0);
		}

		// Token: 0x0601AD6C RID: 109932 RVA: 0x003D4788 File Offset: 0x003D2988
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601AD6D RID: 109933 RVA: 0x003D4793 File Offset: 0x003D2993
		public static Offset<IRollBlockGridLaser> EndIRollBlockGridLaser(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridLaser>(builder.EndTable());
		}

		// Token: 0x0601AD6E RID: 109934 RVA: 0x003D47A0 File Offset: 0x003D29A0
		public IRollBlockGridLaserT UnPack()
		{
			IRollBlockGridLaserT rollBlockGridLaserT = new IRollBlockGridLaserT();
			this.UnPackTo(rollBlockGridLaserT);
			return rollBlockGridLaserT;
		}

		// Token: 0x0601AD6F RID: 109935 RVA: 0x003D47BC File Offset: 0x003D29BC
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

		// Token: 0x0601AD70 RID: 109936 RVA: 0x003D49B4 File Offset: 0x003D2BB4
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

		// Token: 0x0400C620 RID: 50720
		private Table __p;
	}
}
