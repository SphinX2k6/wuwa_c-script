using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E87 RID: 16007
	public struct IHandInGroup : IFlatbufferObject
	{
		// Token: 0x17006F0A RID: 28426
		// (get) Token: 0x06016910 RID: 92432 RVA: 0x00342BA7 File Offset: 0x00340DA7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016911 RID: 92433 RVA: 0x00342BB4 File Offset: 0x00340DB4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016912 RID: 92434 RVA: 0x00342BBC File Offset: 0x00340DBC
		public static IHandInGroup GetRootAsIHandInGroup(ByteBuffer _bb)
		{
			return IHandInGroup.GetRootAsIHandInGroup(_bb, default(IHandInGroup));
		}

		// Token: 0x06016913 RID: 92435 RVA: 0x00342BD8 File Offset: 0x00340DD8
		public static IHandInGroup GetRootAsIHandInGroup(ByteBuffer _bb, IHandInGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016914 RID: 92436 RVA: 0x00342BF5 File Offset: 0x00340DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016915 RID: 92437 RVA: 0x00342C04 File Offset: 0x00340E04
		public IHandInGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F0B RID: 28427
		// (get) Token: 0x06016916 RID: 92438 RVA: 0x00342C14 File Offset: 0x00340E14
		public EHandInItemType HandInType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInItemType.ItemIds;
				}
				return (EHandInItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016917 RID: 92439 RVA: 0x00342C50 File Offset: 0x00340E50
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006F0C RID: 28428
		// (get) Token: 0x06016918 RID: 92440 RVA: 0x00342C90 File Offset: 0x00340E90
		public int ItemIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016919 RID: 92441 RVA: 0x00342CBB File Offset: 0x00340EBB
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601691A RID: 92442 RVA: 0x00342CCA File Offset: 0x00340ECA
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17006F0D RID: 28429
		// (get) Token: 0x0601691B RID: 92443 RVA: 0x00342CD8 File Offset: 0x00340ED8
		public int Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F0E RID: 28430
		// (get) Token: 0x0601691C RID: 92444 RVA: 0x00342D14 File Offset: 0x00340F14
		public int Slot
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F0F RID: 28431
		// (get) Token: 0x0601691D RID: 92445 RVA: 0x00342D54 File Offset: 0x00340F54
		public IHandInItemRange? ChoiceRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHandInItemRange?(default(IHandInItemRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601691E RID: 92446 RVA: 0x00342DB2 File Offset: 0x00340FB2
		public static Offset<IHandInGroup> CreateIHandInGroup(FlatBufferBuilder builder, EHandInItemType HandInType = EHandInItemType.ItemIds, VectorOffset ItemIdsOffset = default(VectorOffset), int Count = 0, int Slot = 0, Offset<IHandInItemRange> ChoiceRangeOffset = default(Offset<IHandInItemRange>))
		{
			builder.StartTable(5);
			IHandInGroup.AddChoiceRange(builder, ChoiceRangeOffset);
			IHandInGroup.AddSlot(builder, Slot);
			IHandInGroup.AddCount(builder, Count);
			IHandInGroup.AddItemIds(builder, ItemIdsOffset);
			IHandInGroup.AddHandInType(builder, HandInType);
			return IHandInGroup.EndIHandInGroup(builder);
		}

		// Token: 0x0601691F RID: 92447 RVA: 0x00342DE6 File Offset: 0x00340FE6
		public static void StartIHandInGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016920 RID: 92448 RVA: 0x00342DEF File Offset: 0x00340FEF
		public static void AddHandInType(FlatBufferBuilder builder, EHandInItemType handInType)
		{
			builder.AddByte(0, (byte)handInType, 0);
		}

		// Token: 0x06016921 RID: 92449 RVA: 0x00342DFA File Offset: 0x00340FFA
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x06016922 RID: 92450 RVA: 0x00342E0C File Offset: 0x0034100C
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016923 RID: 92451 RVA: 0x00342E43 File Offset: 0x00341043
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016924 RID: 92452 RVA: 0x00342E5D File Offset: 0x0034105D
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016925 RID: 92453 RVA: 0x00342E7B File Offset: 0x0034107B
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016926 RID: 92454 RVA: 0x00342E94 File Offset: 0x00341094
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016927 RID: 92455 RVA: 0x00342E9F File Offset: 0x0034109F
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06016928 RID: 92456 RVA: 0x00342EAA File Offset: 0x003410AA
		public static void AddSlot(FlatBufferBuilder builder, int slot)
		{
			builder.AddInt(3, slot, 0);
		}

		// Token: 0x06016929 RID: 92457 RVA: 0x00342EB5 File Offset: 0x003410B5
		public static void AddChoiceRange(FlatBufferBuilder builder, Offset<IHandInItemRange> choiceRangeOffset)
		{
			builder.AddOffset(4, choiceRangeOffset.Value, 0);
		}

		// Token: 0x0601692A RID: 92458 RVA: 0x00342EC5 File Offset: 0x003410C5
		public static Offset<IHandInGroup> EndIHandInGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHandInGroup>(builder.EndTable());
		}

		// Token: 0x0601692B RID: 92459 RVA: 0x00342ED4 File Offset: 0x003410D4
		public IHandInGroupT UnPack()
		{
			IHandInGroupT handInGroupT = new IHandInGroupT();
			this.UnPackTo(handInGroupT);
			return handInGroupT;
		}

		// Token: 0x0601692C RID: 92460 RVA: 0x00342EF0 File Offset: 0x003410F0
		public void UnPackTo(IHandInGroupT _o)
		{
			_o.HandInType = this.HandInType;
			_o.ItemIds = new List<int>();
			for (int i = 0; i < this.ItemIdsLength; i++)
			{
				_o.ItemIds.Add(this.ItemIds(i));
			}
			_o.Count = this.Count;
			_o.Slot = this.Slot;
			_o.ChoiceRange = ((this.ChoiceRange != null) ? this.ChoiceRange.Value.UnPack() : null);
		}

		// Token: 0x0601692D RID: 92461 RVA: 0x00342F80 File Offset: 0x00341180
		public static Offset<IHandInGroup> Pack(FlatBufferBuilder builder, IHandInGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInGroup>);
			}
			VectorOffset itemIdsOffset = default(VectorOffset);
			if (_o.ItemIds != null)
			{
				int[] data = _o.ItemIds.ToArray();
				itemIdsOffset = IHandInGroup.CreateItemIdsVector(builder, data);
			}
			Offset<IHandInItemRange> choiceRangeOffset = (_o.ChoiceRange == null) ? default(Offset<IHandInItemRange>) : IHandInItemRange.Pack(builder, _o.ChoiceRange);
			return IHandInGroup.CreateIHandInGroup(builder, _o.HandInType, itemIdsOffset, _o.Count, _o.Slot, choiceRangeOffset);
		}

		// Token: 0x0400B843 RID: 47171
		private Table __p;
	}
}
