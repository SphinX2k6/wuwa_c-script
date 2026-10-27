using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E8A RID: 16010
	public struct IHandInItem : IFlatbufferObject
	{
		// Token: 0x17006F15 RID: 28437
		// (get) Token: 0x0601693A RID: 92474 RVA: 0x003430FD File Offset: 0x003412FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601693B RID: 92475 RVA: 0x0034310A File Offset: 0x0034130A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601693C RID: 92476 RVA: 0x00343114 File Offset: 0x00341314
		public static IHandInItem GetRootAsIHandInItem(ByteBuffer _bb)
		{
			return IHandInItem.GetRootAsIHandInItem(_bb, default(IHandInItem));
		}

		// Token: 0x0601693D RID: 92477 RVA: 0x00343130 File Offset: 0x00341330
		public static IHandInItem GetRootAsIHandInItem(ByteBuffer _bb, IHandInItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601693E RID: 92478 RVA: 0x0034314D File Offset: 0x0034134D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601693F RID: 92479 RVA: 0x0034315C File Offset: 0x0034135C
		public IHandInItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F16 RID: 28438
		// (get) Token: 0x06016940 RID: 92480 RVA: 0x0034316C File Offset: 0x0034136C
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

		// Token: 0x06016941 RID: 92481 RVA: 0x003431A8 File Offset: 0x003413A8
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006F17 RID: 28439
		// (get) Token: 0x06016942 RID: 92482 RVA: 0x003431E8 File Offset: 0x003413E8
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

		// Token: 0x06016943 RID: 92483 RVA: 0x00343213 File Offset: 0x00341413
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06016944 RID: 92484 RVA: 0x00343222 File Offset: 0x00341422
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17006F18 RID: 28440
		// (get) Token: 0x06016945 RID: 92485 RVA: 0x00343230 File Offset: 0x00341430
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

		// Token: 0x06016946 RID: 92486 RVA: 0x0034326C File Offset: 0x0034146C
		public static Offset<IHandInItem> CreateIHandInItem(FlatBufferBuilder builder, EHandInItemType HandInType = EHandInItemType.ItemIds, VectorOffset ItemIdsOffset = default(VectorOffset), int Count = 0)
		{
			builder.StartTable(3);
			IHandInItem.AddCount(builder, Count);
			IHandInItem.AddItemIds(builder, ItemIdsOffset);
			IHandInItem.AddHandInType(builder, HandInType);
			return IHandInItem.EndIHandInItem(builder);
		}

		// Token: 0x06016947 RID: 92487 RVA: 0x00343290 File Offset: 0x00341490
		public static void StartIHandInItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016948 RID: 92488 RVA: 0x00343299 File Offset: 0x00341499
		public static void AddHandInType(FlatBufferBuilder builder, EHandInItemType handInType)
		{
			builder.AddByte(0, (byte)handInType, 0);
		}

		// Token: 0x06016949 RID: 92489 RVA: 0x003432A4 File Offset: 0x003414A4
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x0601694A RID: 92490 RVA: 0x003432B4 File Offset: 0x003414B4
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601694B RID: 92491 RVA: 0x003432EB File Offset: 0x003414EB
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601694C RID: 92492 RVA: 0x00343305 File Offset: 0x00341505
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601694D RID: 92493 RVA: 0x00343323 File Offset: 0x00341523
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601694E RID: 92494 RVA: 0x0034333C File Offset: 0x0034153C
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601694F RID: 92495 RVA: 0x00343347 File Offset: 0x00341547
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06016950 RID: 92496 RVA: 0x00343352 File Offset: 0x00341552
		public static Offset<IHandInItem> EndIHandInItem(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItem>(builder.EndTable());
		}

		// Token: 0x06016951 RID: 92497 RVA: 0x00343360 File Offset: 0x00341560
		public IHandInItemT UnPack()
		{
			IHandInItemT handInItemT = new IHandInItemT();
			this.UnPackTo(handInItemT);
			return handInItemT;
		}

		// Token: 0x06016952 RID: 92498 RVA: 0x0034337C File Offset: 0x0034157C
		public void UnPackTo(IHandInItemT _o)
		{
			_o.HandInType = this.HandInType;
			_o.ItemIds = new List<int>();
			for (int i = 0; i < this.ItemIdsLength; i++)
			{
				_o.ItemIds.Add(this.ItemIds(i));
			}
			_o.Count = this.Count;
		}

		// Token: 0x06016953 RID: 92499 RVA: 0x003433D0 File Offset: 0x003415D0
		public static Offset<IHandInItem> Pack(FlatBufferBuilder builder, IHandInItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInItem>);
			}
			VectorOffset itemIdsOffset = default(VectorOffset);
			if (_o.ItemIds != null)
			{
				int[] data = _o.ItemIds.ToArray();
				itemIdsOffset = IHandInItem.CreateItemIdsVector(builder, data);
			}
			return IHandInItem.CreateIHandInItem(builder, _o.HandInType, itemIdsOffset, _o.Count);
		}

		// Token: 0x0400B849 RID: 47177
		private Table __p;
	}
}
