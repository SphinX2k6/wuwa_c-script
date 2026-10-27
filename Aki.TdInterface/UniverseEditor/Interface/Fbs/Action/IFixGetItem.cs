using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D7 RID: 26583
	public struct IFixGetItem : IFlatbufferObject
	{
		// Token: 0x1700C554 RID: 50516
		// (get) Token: 0x0602E46A RID: 189546 RVA: 0x00651A62 File Offset: 0x0064FC62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E46B RID: 189547 RVA: 0x00651A6F File Offset: 0x0064FC6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E46C RID: 189548 RVA: 0x00651A78 File Offset: 0x0064FC78
		public static IFixGetItem GetRootAsIFixGetItem(ByteBuffer _bb)
		{
			return IFixGetItem.GetRootAsIFixGetItem(_bb, default(IFixGetItem));
		}

		// Token: 0x0602E46D RID: 189549 RVA: 0x00651A94 File Offset: 0x0064FC94
		public static IFixGetItem GetRootAsIFixGetItem(ByteBuffer _bb, IFixGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E46E RID: 189550 RVA: 0x00651AB1 File Offset: 0x0064FCB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E46F RID: 189551 RVA: 0x00651AC0 File Offset: 0x0064FCC0
		public IFixGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E470 RID: 189552 RVA: 0x00651AD0 File Offset: 0x0064FCD0
		public IItemData? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IItemData?(default(IItemData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C555 RID: 50517
		// (get) Token: 0x0602E471 RID: 189553 RVA: 0x00651B30 File Offset: 0x0064FD30
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602E472 RID: 189554 RVA: 0x00651B5B File Offset: 0x0064FD5B
		public static Offset<IFixGetItem> CreateIFixGetItem(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFixGetItem.AddItems(builder, ItemsOffset);
			return IFixGetItem.EndIFixGetItem(builder);
		}

		// Token: 0x0602E473 RID: 189555 RVA: 0x00651B71 File Offset: 0x0064FD71
		public static void StartIFixGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E474 RID: 189556 RVA: 0x00651B7A File Offset: 0x0064FD7A
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0602E475 RID: 189557 RVA: 0x00651B8C File Offset: 0x0064FD8C
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E476 RID: 189558 RVA: 0x00651BCC File Offset: 0x0064FDCC
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E477 RID: 189559 RVA: 0x00651BE6 File Offset: 0x0064FDE6
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E478 RID: 189560 RVA: 0x00651C04 File Offset: 0x0064FE04
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E479 RID: 189561 RVA: 0x00651C1D File Offset: 0x0064FE1D
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E47A RID: 189562 RVA: 0x00651C28 File Offset: 0x0064FE28
		public static Offset<IFixGetItem> EndIFixGetItem(FlatBufferBuilder builder)
		{
			return new Offset<IFixGetItem>(builder.EndTable());
		}

		// Token: 0x0602E47B RID: 189563 RVA: 0x00651C38 File Offset: 0x0064FE38
		public IFixGetItemT UnPack()
		{
			IFixGetItemT fixGetItemT = new IFixGetItemT();
			this.UnPackTo(fixGetItemT);
			return fixGetItemT;
		}

		// Token: 0x0602E47C RID: 189564 RVA: 0x00651C54 File Offset: 0x0064FE54
		public void UnPackTo(IFixGetItemT _o)
		{
			_o.Items = new List<IItemDataT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602E47D RID: 189565 RVA: 0x00651CB4 File Offset: 0x0064FEB4
		public static Offset<IFixGetItem> Pack(FlatBufferBuilder builder, IFixGetItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixGetItem>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IItemData>[] array = new Offset<IItemData>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IItemData.Pack(builder, _o.Items[i]);
				}
				itemsOffset = IFixGetItem.CreateItemsVector(builder, array);
			}
			return IFixGetItem.CreateIFixGetItem(builder, itemsOffset);
		}

		// Token: 0x04010EF3 RID: 69363
		private Table __p;
	}
}
