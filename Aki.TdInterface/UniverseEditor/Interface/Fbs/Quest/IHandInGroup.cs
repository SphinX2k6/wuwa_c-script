using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C2 RID: 17090
	public struct IHandInGroup : IFlatbufferObject
	{
		// Token: 0x170074F2 RID: 29938
		// (get) Token: 0x06017F47 RID: 98119 RVA: 0x0036B92B File Offset: 0x00369B2B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F48 RID: 98120 RVA: 0x0036B938 File Offset: 0x00369B38
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F49 RID: 98121 RVA: 0x0036B940 File Offset: 0x00369B40
		public static IHandInGroup GetRootAsIHandInGroup(ByteBuffer _bb)
		{
			return IHandInGroup.GetRootAsIHandInGroup(_bb, default(IHandInGroup));
		}

		// Token: 0x06017F4A RID: 98122 RVA: 0x0036B95C File Offset: 0x00369B5C
		public static IHandInGroup GetRootAsIHandInGroup(ByteBuffer _bb, IHandInGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F4B RID: 98123 RVA: 0x0036B979 File Offset: 0x00369B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F4C RID: 98124 RVA: 0x0036B988 File Offset: 0x00369B88
		public IHandInGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074F3 RID: 29939
		// (get) Token: 0x06017F4D RID: 98125 RVA: 0x0036B998 File Offset: 0x00369B98
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

		// Token: 0x06017F4E RID: 98126 RVA: 0x0036B9D4 File Offset: 0x00369BD4
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074F4 RID: 29940
		// (get) Token: 0x06017F4F RID: 98127 RVA: 0x0036BA14 File Offset: 0x00369C14
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

		// Token: 0x06017F50 RID: 98128 RVA: 0x0036BA3F File Offset: 0x00369C3F
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06017F51 RID: 98129 RVA: 0x0036BA4E File Offset: 0x00369C4E
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170074F5 RID: 29941
		// (get) Token: 0x06017F52 RID: 98130 RVA: 0x0036BA5C File Offset: 0x00369C5C
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

		// Token: 0x170074F6 RID: 29942
		// (get) Token: 0x06017F53 RID: 98131 RVA: 0x0036BA98 File Offset: 0x00369C98
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

		// Token: 0x170074F7 RID: 29943
		// (get) Token: 0x06017F54 RID: 98132 RVA: 0x0036BAD8 File Offset: 0x00369CD8
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

		// Token: 0x06017F55 RID: 98133 RVA: 0x0036BB36 File Offset: 0x00369D36
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

		// Token: 0x06017F56 RID: 98134 RVA: 0x0036BB6A File Offset: 0x00369D6A
		public static void StartIHandInGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017F57 RID: 98135 RVA: 0x0036BB73 File Offset: 0x00369D73
		public static void AddHandInType(FlatBufferBuilder builder, EHandInItemType handInType)
		{
			builder.AddByte(0, (byte)handInType, 0);
		}

		// Token: 0x06017F58 RID: 98136 RVA: 0x0036BB7E File Offset: 0x00369D7E
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x06017F59 RID: 98137 RVA: 0x0036BB90 File Offset: 0x00369D90
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017F5A RID: 98138 RVA: 0x0036BBC7 File Offset: 0x00369DC7
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F5B RID: 98139 RVA: 0x0036BBE1 File Offset: 0x00369DE1
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F5C RID: 98140 RVA: 0x0036BBFF File Offset: 0x00369DFF
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F5D RID: 98141 RVA: 0x0036BC18 File Offset: 0x00369E18
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F5E RID: 98142 RVA: 0x0036BC23 File Offset: 0x00369E23
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06017F5F RID: 98143 RVA: 0x0036BC2E File Offset: 0x00369E2E
		public static void AddSlot(FlatBufferBuilder builder, int slot)
		{
			builder.AddInt(3, slot, 0);
		}

		// Token: 0x06017F60 RID: 98144 RVA: 0x0036BC39 File Offset: 0x00369E39
		public static void AddChoiceRange(FlatBufferBuilder builder, Offset<IHandInItemRange> choiceRangeOffset)
		{
			builder.AddOffset(4, choiceRangeOffset.Value, 0);
		}

		// Token: 0x06017F61 RID: 98145 RVA: 0x0036BC49 File Offset: 0x00369E49
		public static Offset<IHandInGroup> EndIHandInGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHandInGroup>(builder.EndTable());
		}

		// Token: 0x06017F62 RID: 98146 RVA: 0x0036BC58 File Offset: 0x00369E58
		public IHandInGroupT UnPack()
		{
			IHandInGroupT handInGroupT = new IHandInGroupT();
			this.UnPackTo(handInGroupT);
			return handInGroupT;
		}

		// Token: 0x06017F63 RID: 98147 RVA: 0x0036BC74 File Offset: 0x00369E74
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

		// Token: 0x06017F64 RID: 98148 RVA: 0x0036BD04 File Offset: 0x00369F04
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

		// Token: 0x0400C21C RID: 49692
		private Table __p;
	}
}
