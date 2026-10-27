using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004578 RID: 17784
	public struct IRollBlockGridLinkGoal : IFlatbufferObject
	{
		// Token: 0x17007E54 RID: 32340
		// (get) Token: 0x0601AD81 RID: 109953 RVA: 0x003D4C3C File Offset: 0x003D2E3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AD82 RID: 109954 RVA: 0x003D4C49 File Offset: 0x003D2E49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AD83 RID: 109955 RVA: 0x003D4C50 File Offset: 0x003D2E50
		public static IRollBlockGridLinkGoal GetRootAsIRollBlockGridLinkGoal(ByteBuffer _bb)
		{
			return IRollBlockGridLinkGoal.GetRootAsIRollBlockGridLinkGoal(_bb, default(IRollBlockGridLinkGoal));
		}

		// Token: 0x0601AD84 RID: 109956 RVA: 0x003D4C6C File Offset: 0x003D2E6C
		public static IRollBlockGridLinkGoal GetRootAsIRollBlockGridLinkGoal(ByteBuffer _bb, IRollBlockGridLinkGoal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AD85 RID: 109957 RVA: 0x003D4C89 File Offset: 0x003D2E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AD86 RID: 109958 RVA: 0x003D4C98 File Offset: 0x003D2E98
		public IRollBlockGridLinkGoal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E55 RID: 32341
		// (get) Token: 0x0601AD87 RID: 109959 RVA: 0x003D4CA8 File Offset: 0x003D2EA8
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

		// Token: 0x17007E56 RID: 32342
		// (get) Token: 0x0601AD88 RID: 109960 RVA: 0x003D4CE4 File Offset: 0x003D2EE4
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

		// Token: 0x0601AD89 RID: 109961 RVA: 0x003D4D20 File Offset: 0x003D2F20
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AD8A RID: 109962 RVA: 0x003D4D64 File Offset: 0x003D2F64
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601AD8B RID: 109963 RVA: 0x003D4D80 File Offset: 0x003D2F80
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601AD8C RID: 109964 RVA: 0x003D4D9C File Offset: 0x003D2F9C
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007E57 RID: 32343
		// (get) Token: 0x0601AD8D RID: 109965 RVA: 0x003D4DDC File Offset: 0x003D2FDC
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

		// Token: 0x0601AD8E RID: 109966 RVA: 0x003D4E08 File Offset: 0x003D3008
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601AD8F RID: 109967 RVA: 0x003D4E18 File Offset: 0x003D3018
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

		// Token: 0x0601AD90 RID: 109968 RVA: 0x003D4E84 File Offset: 0x003D3084
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007E58 RID: 32344
		// (get) Token: 0x0601AD91 RID: 109969 RVA: 0x003D4ECC File Offset: 0x003D30CC
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

		// Token: 0x17007E59 RID: 32345
		// (get) Token: 0x0601AD92 RID: 109970 RVA: 0x003D4EF8 File Offset: 0x003D30F8
		public ERollBlockLayType LinkDirection
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

		// Token: 0x17007E5A RID: 32346
		// (get) Token: 0x0601AD93 RID: 109971 RVA: 0x003D4F38 File Offset: 0x003D3138
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

		// Token: 0x0601AD94 RID: 109972 RVA: 0x003D4F78 File Offset: 0x003D3178
		public static Offset<IRollBlockGridLinkGoal> CreateIRollBlockGridLinkGoal(FlatBufferBuilder builder, ERollBlockGridType Type = ERollBlockGridType.Empty, TRollBlock Block_type = TRollBlock.NONE, int BlockOffset = 0, VectorOffset Items_typeOffset = default(VectorOffset), VectorOffset ItemsOffset = default(VectorOffset), ERollBlockLayType LinkDirection = ERollBlockLayType.Left, byte NullMask = 0)
		{
			builder.StartTable(7);
			IRollBlockGridLinkGoal.AddItems(builder, ItemsOffset);
			IRollBlockGridLinkGoal.AddItemsType(builder, Items_typeOffset);
			IRollBlockGridLinkGoal.AddBlock(builder, BlockOffset);
			IRollBlockGridLinkGoal.AddNullMask(builder, NullMask);
			IRollBlockGridLinkGoal.AddLinkDirection(builder, LinkDirection);
			IRollBlockGridLinkGoal.AddBlockType(builder, Block_type);
			IRollBlockGridLinkGoal.AddType(builder, Type);
			return IRollBlockGridLinkGoal.EndIRollBlockGridLinkGoal(builder);
		}

		// Token: 0x0601AD95 RID: 109973 RVA: 0x003D4FC7 File Offset: 0x003D31C7
		public static void StartIRollBlockGridLinkGoal(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601AD96 RID: 109974 RVA: 0x003D4FD0 File Offset: 0x003D31D0
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AD97 RID: 109975 RVA: 0x003D4FDB File Offset: 0x003D31DB
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601AD98 RID: 109976 RVA: 0x003D4FE6 File Offset: 0x003D31E6
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601AD99 RID: 109977 RVA: 0x003D4FF1 File Offset: 0x003D31F1
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601AD9A RID: 109978 RVA: 0x003D5004 File Offset: 0x003D3204
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AD9B RID: 109979 RVA: 0x003D503B File Offset: 0x003D323B
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD9C RID: 109980 RVA: 0x003D5055 File Offset: 0x003D3255
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AD9D RID: 109981 RVA: 0x003D5073 File Offset: 0x003D3273
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AD9E RID: 109982 RVA: 0x003D508C File Offset: 0x003D328C
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AD9F RID: 109983 RVA: 0x003D5097 File Offset: 0x003D3297
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601ADA0 RID: 109984 RVA: 0x003D50A8 File Offset: 0x003D32A8
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ADA1 RID: 109985 RVA: 0x003D50DF File Offset: 0x003D32DF
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ADA2 RID: 109986 RVA: 0x003D50F9 File Offset: 0x003D32F9
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ADA3 RID: 109987 RVA: 0x003D5117 File Offset: 0x003D3317
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ADA4 RID: 109988 RVA: 0x003D5130 File Offset: 0x003D3330
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601ADA5 RID: 109989 RVA: 0x003D513B File Offset: 0x003D333B
		public static void AddLinkDirection(FlatBufferBuilder builder, ERollBlockLayType linkDirection)
		{
			builder.AddByte(5, (byte)linkDirection, 0);
		}

		// Token: 0x0601ADA6 RID: 109990 RVA: 0x003D5146 File Offset: 0x003D3346
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601ADA7 RID: 109991 RVA: 0x003D5151 File Offset: 0x003D3351
		public static Offset<IRollBlockGridLinkGoal> EndIRollBlockGridLinkGoal(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridLinkGoal>(builder.EndTable());
		}

		// Token: 0x0601ADA8 RID: 109992 RVA: 0x003D5160 File Offset: 0x003D3360
		public IRollBlockGridLinkGoalT UnPack()
		{
			IRollBlockGridLinkGoalT rollBlockGridLinkGoalT = new IRollBlockGridLinkGoalT();
			this.UnPackTo(rollBlockGridLinkGoalT);
			return rollBlockGridLinkGoalT;
		}

		// Token: 0x0601ADA9 RID: 109993 RVA: 0x003D517C File Offset: 0x003D337C
		public void UnPackTo(IRollBlockGridLinkGoalT _o)
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
			_o.LinkDirection = this.LinkDirection;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601ADAA RID: 109994 RVA: 0x003D535C File Offset: 0x003D355C
		public static Offset<IRollBlockGridLinkGoal> Pack(FlatBufferBuilder builder, IRollBlockGridLinkGoalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridLinkGoal>);
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
				items_typeOffset = IRollBlockGridLinkGoal.CreateItemsTypeVector(builder, array);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] array2 = new int[_o.Items.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockItemUnion.Pack(builder, _o.Items[j]);
				}
				itemsOffset = IRollBlockGridLinkGoal.CreateItemsVector(builder, array2);
			}
			return IRollBlockGridLinkGoal.CreateIRollBlockGridLinkGoal(builder, _o.Type, block_type, blockOffset, items_typeOffset, itemsOffset, _o.LinkDirection, _o.NullMask);
		}

		// Token: 0x0400C628 RID: 50728
		private Table __p;
	}
}
