using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B4 RID: 27060
	public struct IItemCellIndependentDeliverType : IFlatbufferObject
	{
		// Token: 0x1700C8BA RID: 51386
		// (get) Token: 0x0602F47F RID: 193663 RVA: 0x00670958 File Offset: 0x0066EB58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F480 RID: 193664 RVA: 0x00670965 File Offset: 0x0066EB65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F481 RID: 193665 RVA: 0x0067096C File Offset: 0x0066EB6C
		public static IItemCellIndependentDeliverType GetRootAsIItemCellIndependentDeliverType(ByteBuffer _bb)
		{
			return IItemCellIndependentDeliverType.GetRootAsIItemCellIndependentDeliverType(_bb, default(IItemCellIndependentDeliverType));
		}

		// Token: 0x0602F482 RID: 193666 RVA: 0x00670988 File Offset: 0x0066EB88
		public static IItemCellIndependentDeliverType GetRootAsIItemCellIndependentDeliverType(ByteBuffer _bb, IItemCellIndependentDeliverType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F483 RID: 193667 RVA: 0x006709A5 File Offset: 0x0066EBA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F484 RID: 193668 RVA: 0x006709B4 File Offset: 0x0066EBB4
		public IItemCellIndependentDeliverType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8BB RID: 51387
		// (get) Token: 0x0602F485 RID: 193669 RVA: 0x006709C4 File Offset: 0x0066EBC4
		public EDeliverType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDeliverType.ItemIdCellIndependent;
				}
				return (EDeliverType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F486 RID: 193670 RVA: 0x00670A00 File Offset: 0x0066EC00
		public IDeliverItem? DeliverItem(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDeliverItem?(default(IDeliverItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C8BC RID: 51388
		// (get) Token: 0x0602F487 RID: 193671 RVA: 0x00670A60 File Offset: 0x0066EC60
		public int DeliverItemLength
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

		// Token: 0x0602F488 RID: 193672 RVA: 0x00670A8B File Offset: 0x0066EC8B
		public static Offset<IItemCellIndependentDeliverType> CreateIItemCellIndependentDeliverType(FlatBufferBuilder builder, EDeliverType Type = EDeliverType.ItemIdCellIndependent, VectorOffset DeliverItemOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IItemCellIndependentDeliverType.AddDeliverItem(builder, DeliverItemOffset);
			IItemCellIndependentDeliverType.AddType(builder, Type);
			return IItemCellIndependentDeliverType.EndIItemCellIndependentDeliverType(builder);
		}

		// Token: 0x0602F489 RID: 193673 RVA: 0x00670AA8 File Offset: 0x0066ECA8
		public static void StartIItemCellIndependentDeliverType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F48A RID: 193674 RVA: 0x00670AB1 File Offset: 0x0066ECB1
		public static void AddType(FlatBufferBuilder builder, EDeliverType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F48B RID: 193675 RVA: 0x00670ABC File Offset: 0x0066ECBC
		public static void AddDeliverItem(FlatBufferBuilder builder, VectorOffset deliverItemOffset)
		{
			builder.AddOffset(1, deliverItemOffset.Value, 0);
		}

		// Token: 0x0602F48C RID: 193676 RVA: 0x00670ACC File Offset: 0x0066ECCC
		public static VectorOffset CreateDeliverItemVector(FlatBufferBuilder builder, Offset<IDeliverItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F48D RID: 193677 RVA: 0x00670B0C File Offset: 0x0066ED0C
		public static VectorOffset CreateDeliverItemVectorBlock(FlatBufferBuilder builder, Offset<IDeliverItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDeliverItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F48E RID: 193678 RVA: 0x00670B26 File Offset: 0x0066ED26
		public static VectorOffset CreateDeliverItemVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDeliverItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDeliverItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F48F RID: 193679 RVA: 0x00670B44 File Offset: 0x0066ED44
		public static VectorOffset CreateDeliverItemVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDeliverItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F490 RID: 193680 RVA: 0x00670B5D File Offset: 0x0066ED5D
		public static void StartDeliverItemVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F491 RID: 193681 RVA: 0x00670B68 File Offset: 0x0066ED68
		public static Offset<IItemCellIndependentDeliverType> EndIItemCellIndependentDeliverType(FlatBufferBuilder builder)
		{
			return new Offset<IItemCellIndependentDeliverType>(builder.EndTable());
		}

		// Token: 0x0602F492 RID: 193682 RVA: 0x00670B78 File Offset: 0x0066ED78
		public IItemCellIndependentDeliverTypeT UnPack()
		{
			IItemCellIndependentDeliverTypeT itemCellIndependentDeliverTypeT = new IItemCellIndependentDeliverTypeT();
			this.UnPackTo(itemCellIndependentDeliverTypeT);
			return itemCellIndependentDeliverTypeT;
		}

		// Token: 0x0602F493 RID: 193683 RVA: 0x00670B94 File Offset: 0x0066ED94
		public void UnPackTo(IItemCellIndependentDeliverTypeT _o)
		{
			_o.Type = this.Type;
			_o.DeliverItem = new List<IDeliverItemT>();
			for (int i = 0; i < this.DeliverItemLength; i++)
			{
				_o.DeliverItem.Add((this.DeliverItem(i) != null) ? this.DeliverItem(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602F494 RID: 193684 RVA: 0x00670C00 File Offset: 0x0066EE00
		public static Offset<IItemCellIndependentDeliverType> Pack(FlatBufferBuilder builder, IItemCellIndependentDeliverTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemCellIndependentDeliverType>);
			}
			VectorOffset deliverItemOffset = default(VectorOffset);
			if (_o.DeliverItem != null)
			{
				Offset<IDeliverItem>[] array = new Offset<IDeliverItem>[_o.DeliverItem.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDeliverItem.Pack(builder, _o.DeliverItem[i]);
				}
				deliverItemOffset = IItemCellIndependentDeliverType.CreateDeliverItemVector(builder, array);
			}
			return IItemCellIndependentDeliverType.CreateIItemCellIndependentDeliverType(builder, _o.Type, deliverItemOffset);
		}

		// Token: 0x04011162 RID: 69986
		private Table __p;
	}
}
