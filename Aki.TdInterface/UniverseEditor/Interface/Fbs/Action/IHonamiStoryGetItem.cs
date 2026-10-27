using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006924 RID: 26916
	public struct IHonamiStoryGetItem : IFlatbufferObject
	{
		// Token: 0x1700C7B0 RID: 51120
		// (get) Token: 0x0602EFC5 RID: 192453 RVA: 0x0066809D File Offset: 0x0066629D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EFC6 RID: 192454 RVA: 0x006680AA File Offset: 0x006662AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EFC7 RID: 192455 RVA: 0x006680B4 File Offset: 0x006662B4
		public static IHonamiStoryGetItem GetRootAsIHonamiStoryGetItem(ByteBuffer _bb)
		{
			return IHonamiStoryGetItem.GetRootAsIHonamiStoryGetItem(_bb, default(IHonamiStoryGetItem));
		}

		// Token: 0x0602EFC8 RID: 192456 RVA: 0x006680D0 File Offset: 0x006662D0
		public static IHonamiStoryGetItem GetRootAsIHonamiStoryGetItem(ByteBuffer _bb, IHonamiStoryGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EFC9 RID: 192457 RVA: 0x006680ED File Offset: 0x006662ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EFCA RID: 192458 RVA: 0x006680FC File Offset: 0x006662FC
		public IHonamiStoryGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7B1 RID: 51121
		// (get) Token: 0x0602EFCB RID: 192459 RVA: 0x0066810C File Offset: 0x0066630C
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

		// Token: 0x0602EFCC RID: 192460 RVA: 0x00668148 File Offset: 0x00666348
		public int ItemId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C7B2 RID: 51122
		// (get) Token: 0x0602EFCD RID: 192461 RVA: 0x00668188 File Offset: 0x00666388
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

		// Token: 0x0602EFCE RID: 192462 RVA: 0x006681B3 File Offset: 0x006663B3
		public Span<int> GetItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EFCF RID: 192463 RVA: 0x006681C2 File Offset: 0x006663C2
		public int[] GetItemIdArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602EFD0 RID: 192464 RVA: 0x006681D0 File Offset: 0x006663D0
		public static Offset<IHonamiStoryGetItem> CreateIHonamiStoryGetItem(FlatBufferBuilder builder, int ActivityId = 0, VectorOffset ItemIdOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHonamiStoryGetItem.AddItemId(builder, ItemIdOffset);
			IHonamiStoryGetItem.AddActivityId(builder, ActivityId);
			return IHonamiStoryGetItem.EndIHonamiStoryGetItem(builder);
		}

		// Token: 0x0602EFD1 RID: 192465 RVA: 0x006681ED File Offset: 0x006663ED
		public static void StartIHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EFD2 RID: 192466 RVA: 0x006681F6 File Offset: 0x006663F6
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(0, activityId, 0);
		}

		// Token: 0x0602EFD3 RID: 192467 RVA: 0x00668201 File Offset: 0x00666401
		public static void AddItemId(FlatBufferBuilder builder, VectorOffset itemIdOffset)
		{
			builder.AddOffset(1, itemIdOffset.Value, 0);
		}

		// Token: 0x0602EFD4 RID: 192468 RVA: 0x00668214 File Offset: 0x00666414
		public static VectorOffset CreateItemIdVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EFD5 RID: 192469 RVA: 0x0066824B File Offset: 0x0066644B
		public static VectorOffset CreateItemIdVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EFD6 RID: 192470 RVA: 0x00668265 File Offset: 0x00666465
		public static VectorOffset CreateItemIdVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EFD7 RID: 192471 RVA: 0x00668283 File Offset: 0x00666483
		public static VectorOffset CreateItemIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EFD8 RID: 192472 RVA: 0x0066829C File Offset: 0x0066649C
		public static void StartItemIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EFD9 RID: 192473 RVA: 0x006682A7 File Offset: 0x006664A7
		public static Offset<IHonamiStoryGetItem> EndIHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryGetItem>(builder.EndTable());
		}

		// Token: 0x0602EFDA RID: 192474 RVA: 0x006682B4 File Offset: 0x006664B4
		public IHonamiStoryGetItemT UnPack()
		{
			IHonamiStoryGetItemT honamiStoryGetItemT = new IHonamiStoryGetItemT();
			this.UnPackTo(honamiStoryGetItemT);
			return honamiStoryGetItemT;
		}

		// Token: 0x0602EFDB RID: 192475 RVA: 0x006682D0 File Offset: 0x006664D0
		public void UnPackTo(IHonamiStoryGetItemT _o)
		{
			_o.ActivityId = this.ActivityId;
			_o.ItemId = new List<int>();
			for (int i = 0; i < this.ItemIdLength; i++)
			{
				_o.ItemId.Add(this.ItemId(i));
			}
		}

		// Token: 0x0602EFDC RID: 192476 RVA: 0x00668318 File Offset: 0x00666518
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

		// Token: 0x0401109E RID: 69790
		private Table __p;
	}
}
