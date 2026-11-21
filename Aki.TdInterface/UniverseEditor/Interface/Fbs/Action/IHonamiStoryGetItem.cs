using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD7 RID: 28631
	public struct IHonamiStoryGetItem : IFlatbufferObject
	{
		// Token: 0x1700D1B3 RID: 53683
		// (get) Token: 0x06031995 RID: 203157 RVA: 0x006B8585 File Offset: 0x006B6785
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031996 RID: 203158 RVA: 0x006B8592 File Offset: 0x006B6792
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031997 RID: 203159 RVA: 0x006B859C File Offset: 0x006B679C
		public static IHonamiStoryGetItem GetRootAsIHonamiStoryGetItem(ByteBuffer _bb)
		{
			return IHonamiStoryGetItem.GetRootAsIHonamiStoryGetItem(_bb, default(IHonamiStoryGetItem));
		}

		// Token: 0x06031998 RID: 203160 RVA: 0x006B85B8 File Offset: 0x006B67B8
		public static IHonamiStoryGetItem GetRootAsIHonamiStoryGetItem(ByteBuffer _bb, IHonamiStoryGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031999 RID: 203161 RVA: 0x006B85D5 File Offset: 0x006B67D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603199A RID: 203162 RVA: 0x006B85E4 File Offset: 0x006B67E4
		public IHonamiStoryGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1B4 RID: 53684
		// (get) Token: 0x0603199B RID: 203163 RVA: 0x006B85F4 File Offset: 0x006B67F4
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603199C RID: 203164 RVA: 0x006B8630 File Offset: 0x006B6830
		public int ItemId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D1B5 RID: 53685
		// (get) Token: 0x0603199D RID: 203165 RVA: 0x006B8670 File Offset: 0x006B6870
		public int ItemIdLength
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

		// Token: 0x0603199E RID: 203166 RVA: 0x006B869B File Offset: 0x006B689B
		public Span<int> GetItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603199F RID: 203167 RVA: 0x006B86AA File Offset: 0x006B68AA
		public int[] GetItemIdArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060319A0 RID: 203168 RVA: 0x006B86B8 File Offset: 0x006B68B8
		public static Offset<IHonamiStoryGetItem> CreateIHonamiStoryGetItem(FlatBufferBuilder builder, int ActivityId = 0, VectorOffset ItemIdOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHonamiStoryGetItem.AddItemId(builder, ItemIdOffset);
			IHonamiStoryGetItem.AddActivityId(builder, ActivityId);
			return IHonamiStoryGetItem.EndIHonamiStoryGetItem(builder);
		}

		// Token: 0x060319A1 RID: 203169 RVA: 0x006B86D5 File Offset: 0x006B68D5
		public static void StartIHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060319A2 RID: 203170 RVA: 0x006B86DE File Offset: 0x006B68DE
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(0, activityId, 0);
		}

		// Token: 0x060319A3 RID: 203171 RVA: 0x006B86E9 File Offset: 0x006B68E9
		public static void AddItemId(FlatBufferBuilder builder, VectorOffset itemIdOffset)
		{
			builder.AddOffset(1, itemIdOffset.Value, 0);
		}

		// Token: 0x060319A4 RID: 203172 RVA: 0x006B86FC File Offset: 0x006B68FC
		public static VectorOffset CreateItemIdVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060319A5 RID: 203173 RVA: 0x006B8733 File Offset: 0x006B6933
		public static VectorOffset CreateItemIdVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060319A6 RID: 203174 RVA: 0x006B874D File Offset: 0x006B694D
		public static VectorOffset CreateItemIdVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060319A7 RID: 203175 RVA: 0x006B876B File Offset: 0x006B696B
		public static VectorOffset CreateItemIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060319A8 RID: 203176 RVA: 0x006B8784 File Offset: 0x006B6984
		public static void StartItemIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060319A9 RID: 203177 RVA: 0x006B878F File Offset: 0x006B698F
		public static Offset<IHonamiStoryGetItem> EndIHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryGetItem>(builder.EndTable());
		}

		// Token: 0x060319AA RID: 203178 RVA: 0x006B879C File Offset: 0x006B699C
		public IHonamiStoryGetItemT UnPack()
		{
			IHonamiStoryGetItemT honamiStoryGetItemT = new IHonamiStoryGetItemT();
			this.UnPackTo(honamiStoryGetItemT);
			return honamiStoryGetItemT;
		}

		// Token: 0x060319AB RID: 203179 RVA: 0x006B87B8 File Offset: 0x006B69B8
		public void UnPackTo(IHonamiStoryGetItemT _o)
		{
			_o.ActivityId = this.ActivityId;
			_o.ItemId = new List<int>();
			for (int i = 0; i < this.ItemIdLength; i++)
			{
				_o.ItemId.Add(this.ItemId(i));
			}
		}

		// Token: 0x060319AC RID: 203180 RVA: 0x006B8800 File Offset: 0x006B6A00
		public static Offset<IHonamiStoryGetItem> Pack(FlatBufferBuilder builder, IHonamiStoryGetItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryGetItem>);
			}
			VectorOffset itemIdOffset = default(VectorOffset);
			if (_o.ItemId != null)
			{
				int[] data = _o.ItemId.ToArray();
				itemIdOffset = IHonamiStoryGetItem.CreateItemIdVector(builder, data);
			}
			return IHonamiStoryGetItem.CreateIHonamiStoryGetItem(builder, _o.ActivityId, itemIdOffset);
		}

		// Token: 0x04011F0A RID: 73482
		private Table __p;
	}
}
