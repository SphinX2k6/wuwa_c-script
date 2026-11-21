using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049E0 RID: 18912
	public struct IRollBlockGridLinkGoal : IFlatbufferObject
	{
		// Token: 0x17008495 RID: 33941
		// (get) Token: 0x0601C556 RID: 116054 RVA: 0x00400ED8 File Offset: 0x003FF0D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C557 RID: 116055 RVA: 0x00400EE5 File Offset: 0x003FF0E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C558 RID: 116056 RVA: 0x00400EEC File Offset: 0x003FF0EC
		public static IRollBlockGridLinkGoal GetRootAsIRollBlockGridLinkGoal(ByteBuffer _bb)
		{
			return IRollBlockGridLinkGoal.GetRootAsIRollBlockGridLinkGoal(_bb, default(IRollBlockGridLinkGoal));
		}

		// Token: 0x0601C559 RID: 116057 RVA: 0x00400F08 File Offset: 0x003FF108
		public static IRollBlockGridLinkGoal GetRootAsIRollBlockGridLinkGoal(ByteBuffer _bb, IRollBlockGridLinkGoal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C55A RID: 116058 RVA: 0x00400F25 File Offset: 0x003FF125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C55B RID: 116059 RVA: 0x00400F34 File Offset: 0x003FF134
		public IRollBlockGridLinkGoal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008496 RID: 33942
		// (get) Token: 0x0601C55C RID: 116060 RVA: 0x00400F44 File Offset: 0x003FF144
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

		// Token: 0x17008497 RID: 33943
		// (get) Token: 0x0601C55D RID: 116061 RVA: 0x00400F80 File Offset: 0x003FF180
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

		// Token: 0x0601C55E RID: 116062 RVA: 0x00400FBC File Offset: 0x003FF1BC
		public TTable? Block<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C55F RID: 116063 RVA: 0x00401000 File Offset: 0x003FF200
		public IRollBlock1 BlockAsIRollBlock1()
		{
			return this.Block<IRollBlock1>().Value;
		}

		// Token: 0x0601C560 RID: 116064 RVA: 0x0040101C File Offset: 0x003FF21C
		public IRollBlock2 BlockAsIRollBlock2()
		{
			return this.Block<IRollBlock2>().Value;
		}

		// Token: 0x0601C561 RID: 116065 RVA: 0x00401038 File Offset: 0x003FF238
		public TRollBlockItem ItemsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TRollBlockItem.NONE;
			}
			return (TRollBlockItem)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008498 RID: 33944
		// (get) Token: 0x0601C562 RID: 116066 RVA: 0x00401078 File Offset: 0x003FF278
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

		// Token: 0x0601C563 RID: 116067 RVA: 0x004010A4 File Offset: 0x003FF2A4
		public Span<TRollBlockItem> GetItemsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockItem>(10, 1);
		}

		// Token: 0x0601C564 RID: 116068 RVA: 0x004010B4 File Offset: 0x003FF2B4
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

		// Token: 0x0601C565 RID: 116069 RVA: 0x00401120 File Offset: 0x003FF320
		public TTable? Items<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008499 RID: 33945
		// (get) Token: 0x0601C566 RID: 116070 RVA: 0x00401168 File Offset: 0x003FF368
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

		// Token: 0x1700849A RID: 33946
		// (get) Token: 0x0601C567 RID: 116071 RVA: 0x00401194 File Offset: 0x003FF394
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

		// Token: 0x1700849B RID: 33947
		// (get) Token: 0x0601C568 RID: 116072 RVA: 0x004011D4 File Offset: 0x003FF3D4
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

		// Token: 0x0601C569 RID: 116073 RVA: 0x00401214 File Offset: 0x003FF414
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

		// Token: 0x0601C56A RID: 116074 RVA: 0x00401263 File Offset: 0x003FF463
		public static void StartIRollBlockGridLinkGoal(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601C56B RID: 116075 RVA: 0x0040126C File Offset: 0x003FF46C
		public static void AddType(FlatBufferBuilder builder, ERollBlockGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C56C RID: 116076 RVA: 0x00401277 File Offset: 0x003FF477
		public static void AddBlockType(FlatBufferBuilder builder, TRollBlock blockType)
		{
			builder.AddByte(1, (byte)blockType, 0);
		}

		// Token: 0x0601C56D RID: 116077 RVA: 0x00401282 File Offset: 0x003FF482
		public static void AddBlock(FlatBufferBuilder builder, int blockOffset)
		{
			builder.AddOffset(2, blockOffset, 0);
		}

		// Token: 0x0601C56E RID: 116078 RVA: 0x0040128D File Offset: 0x003FF48D
		public static void AddItemsType(FlatBufferBuilder builder, VectorOffset itemsTypeOffset)
		{
			builder.AddOffset(3, itemsTypeOffset.Value, 0);
		}

		// Token: 0x0601C56F RID: 116079 RVA: 0x004012A0 File Offset: 0x003FF4A0
		public static VectorOffset CreateItemsTypeVector(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C570 RID: 116080 RVA: 0x004012D7 File Offset: 0x003FF4D7
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockItem[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C571 RID: 116081 RVA: 0x004012F1 File Offset: 0x003FF4F1
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockItem> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockItem>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C572 RID: 116082 RVA: 0x0040130F File Offset: 0x003FF50F
		public static VectorOffset CreateItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockItem>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C573 RID: 116083 RVA: 0x00401328 File Offset: 0x003FF528
		public static void StartItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C574 RID: 116084 RVA: 0x00401333 File Offset: 0x003FF533
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x0601C575 RID: 116085 RVA: 0x00401344 File Offset: 0x003FF544
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C576 RID: 116086 RVA: 0x0040137B File Offset: 0x003FF57B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C577 RID: 116087 RVA: 0x00401395 File Offset: 0x003FF595
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C578 RID: 116088 RVA: 0x004013B3 File Offset: 0x003FF5B3
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C579 RID: 116089 RVA: 0x004013CC File Offset: 0x003FF5CC
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C57A RID: 116090 RVA: 0x004013D7 File Offset: 0x003FF5D7
		public static void AddLinkDirection(FlatBufferBuilder builder, ERollBlockLayType linkDirection)
		{
			builder.AddByte(5, (byte)linkDirection, 0);
		}

		// Token: 0x0601C57B RID: 116091 RVA: 0x004013E2 File Offset: 0x003FF5E2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601C57C RID: 116092 RVA: 0x004013ED File Offset: 0x003FF5ED
		public static Offset<IRollBlockGridLinkGoal> EndIRollBlockGridLinkGoal(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridLinkGoal>(builder.EndTable());
		}

		// Token: 0x0601C57D RID: 116093 RVA: 0x004013FC File Offset: 0x003FF5FC
		public IRollBlockGridLinkGoalT UnPack()
		{
			IRollBlockGridLinkGoalT rollBlockGridLinkGoalT = new IRollBlockGridLinkGoalT();
			this.UnPackTo(rollBlockGridLinkGoalT);
			return rollBlockGridLinkGoalT;
		}

		// Token: 0x0601C57E RID: 116094 RVA: 0x00401418 File Offset: 0x003FF618
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

		// Token: 0x0601C57F RID: 116095 RVA: 0x004015F8 File Offset: 0x003FF7F8
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

		// Token: 0x0400D057 RID: 53335
		private Table __p;
	}
}
