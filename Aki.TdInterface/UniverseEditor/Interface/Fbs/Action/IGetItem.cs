using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F23 RID: 28451
	public struct IGetItem : IFlatbufferObject
	{
		// Token: 0x1700D093 RID: 53395
		// (get) Token: 0x060313BD RID: 201661 RVA: 0x006ABC19 File Offset: 0x006A9E19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313BE RID: 201662 RVA: 0x006ABC26 File Offset: 0x006A9E26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313BF RID: 201663 RVA: 0x006ABC30 File Offset: 0x006A9E30
		public static IGetItem GetRootAsIGetItem(ByteBuffer _bb)
		{
			return IGetItem.GetRootAsIGetItem(_bb, default(IGetItem));
		}

		// Token: 0x060313C0 RID: 201664 RVA: 0x006ABC4C File Offset: 0x006A9E4C
		public static IGetItem GetRootAsIGetItem(ByteBuffer _bb, IGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313C1 RID: 201665 RVA: 0x006ABC69 File Offset: 0x006A9E69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313C2 RID: 201666 RVA: 0x006ABC78 File Offset: 0x006A9E78
		public IGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060313C3 RID: 201667 RVA: 0x006ABC88 File Offset: 0x006A9E88
		public IItemData? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IItemData?(default(IItemData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D094 RID: 53396
		// (get) Token: 0x060313C4 RID: 201668 RVA: 0x006ABCE8 File Offset: 0x006A9EE8
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

		// Token: 0x1700D095 RID: 53397
		// (get) Token: 0x060313C5 RID: 201669 RVA: 0x006ABD14 File Offset: 0x006A9F14
		public EItemGetUiType UiType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EItemGetUiType.None;
				}
				return (EItemGetUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D096 RID: 53398
		// (get) Token: 0x060313C6 RID: 201670 RVA: 0x006ABD50 File Offset: 0x006A9F50
		public IItemGetUiConfigSpecialQuest? UiConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IItemGetUiConfigSpecialQuest?(default(IItemGetUiConfigSpecialQuest).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D097 RID: 53399
		// (get) Token: 0x060313C7 RID: 201671 RVA: 0x006ABDB0 File Offset: 0x006A9FB0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060313C8 RID: 201672 RVA: 0x006ABDED File Offset: 0x006A9FED
		public static Offset<IGetItem> CreateIGetItem(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset), EItemGetUiType UiType = EItemGetUiType.None, Offset<IItemGetUiConfigSpecialQuest> UiConfigOffset = default(Offset<IItemGetUiConfigSpecialQuest>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IGetItem.AddUiConfig(builder, UiConfigOffset);
			IGetItem.AddItems(builder, ItemsOffset);
			IGetItem.AddNullMask(builder, NullMask);
			IGetItem.AddUiType(builder, UiType);
			return IGetItem.EndIGetItem(builder);
		}

		// Token: 0x060313C9 RID: 201673 RVA: 0x006ABE19 File Offset: 0x006AA019
		public static void StartIGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060313CA RID: 201674 RVA: 0x006ABE22 File Offset: 0x006AA022
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x060313CB RID: 201675 RVA: 0x006ABE34 File Offset: 0x006AA034
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060313CC RID: 201676 RVA: 0x006ABE74 File Offset: 0x006AA074
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060313CD RID: 201677 RVA: 0x006ABE8E File Offset: 0x006AA08E
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060313CE RID: 201678 RVA: 0x006ABEAC File Offset: 0x006AA0AC
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060313CF RID: 201679 RVA: 0x006ABEC5 File Offset: 0x006AA0C5
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060313D0 RID: 201680 RVA: 0x006ABED0 File Offset: 0x006AA0D0
		public static void AddUiType(FlatBufferBuilder builder, EItemGetUiType uiType)
		{
			builder.AddByte(1, (byte)uiType, 0);
		}

		// Token: 0x060313D1 RID: 201681 RVA: 0x006ABEDB File Offset: 0x006AA0DB
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IItemGetUiConfigSpecialQuest> uiConfigOffset)
		{
			builder.AddOffset(2, uiConfigOffset.Value, 0);
		}

		// Token: 0x060313D2 RID: 201682 RVA: 0x006ABEEB File Offset: 0x006AA0EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060313D3 RID: 201683 RVA: 0x006ABEF6 File Offset: 0x006AA0F6
		public static Offset<IGetItem> EndIGetItem(FlatBufferBuilder builder)
		{
			return new Offset<IGetItem>(builder.EndTable());
		}

		// Token: 0x060313D4 RID: 201684 RVA: 0x006ABF04 File Offset: 0x006AA104
		public IGetItemT UnPack()
		{
			IGetItemT getItemT = new IGetItemT();
			this.UnPackTo(getItemT);
			return getItemT;
		}

		// Token: 0x060313D5 RID: 201685 RVA: 0x006ABF20 File Offset: 0x006AA120
		public void UnPackTo(IGetItemT _o)
		{
			_o.Items = new List<IItemDataT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
			_o.UiType = this.UiType;
			_o.UiConfig = ((this.UiConfig != null) ? this.UiConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060313D6 RID: 201686 RVA: 0x006ABFC8 File Offset: 0x006AA1C8
		public static Offset<IGetItem> Pack(FlatBufferBuilder builder, IGetItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetItem>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IItemData>[] array = new Offset<IItemData>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IItemData.Pack(builder, _o.Items[i]);
				}
				itemsOffset = IGetItem.CreateItemsVector(builder, array);
			}
			Offset<IItemGetUiConfigSpecialQuest> uiConfigOffset = (_o.UiConfig == null) ? default(Offset<IItemGetUiConfigSpecialQuest>) : IItemGetUiConfigSpecialQuest.Pack(builder, _o.UiConfig);
			return IGetItem.CreateIGetItem(builder, itemsOffset, _o.UiType, uiConfigOffset, _o.NullMask);
		}

		// Token: 0x04011E2B RID: 73259
		private Table __p;
	}
}
