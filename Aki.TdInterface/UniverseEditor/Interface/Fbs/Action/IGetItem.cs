using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006882 RID: 26754
	public struct IGetItem : IFlatbufferObject
	{
		// Token: 0x1700C6AD RID: 50861
		// (get) Token: 0x0602EA83 RID: 191107 RVA: 0x0065CB99 File Offset: 0x0065AD99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA84 RID: 191108 RVA: 0x0065CBA6 File Offset: 0x0065ADA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA85 RID: 191109 RVA: 0x0065CBB0 File Offset: 0x0065ADB0
		public static IGetItem GetRootAsIGetItem(ByteBuffer _bb)
		{
			return IGetItem.GetRootAsIGetItem(_bb, default(IGetItem));
		}

		// Token: 0x0602EA86 RID: 191110 RVA: 0x0065CBCC File Offset: 0x0065ADCC
		public static IGetItem GetRootAsIGetItem(ByteBuffer _bb, IGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA87 RID: 191111 RVA: 0x0065CBE9 File Offset: 0x0065ADE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA88 RID: 191112 RVA: 0x0065CBF8 File Offset: 0x0065ADF8
		public IGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EA89 RID: 191113 RVA: 0x0065CC08 File Offset: 0x0065AE08
		public IItemData? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IItemData?(default(IItemData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C6AE RID: 50862
		// (get) Token: 0x0602EA8A RID: 191114 RVA: 0x0065CC68 File Offset: 0x0065AE68
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

		// Token: 0x1700C6AF RID: 50863
		// (get) Token: 0x0602EA8B RID: 191115 RVA: 0x0065CC94 File Offset: 0x0065AE94
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

		// Token: 0x1700C6B0 RID: 50864
		// (get) Token: 0x0602EA8C RID: 191116 RVA: 0x0065CCD0 File Offset: 0x0065AED0
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

		// Token: 0x1700C6B1 RID: 50865
		// (get) Token: 0x0602EA8D RID: 191117 RVA: 0x0065CD30 File Offset: 0x0065AF30
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

		// Token: 0x0602EA8E RID: 191118 RVA: 0x0065CD6D File Offset: 0x0065AF6D
		public static Offset<IGetItem> CreateIGetItem(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset), EItemGetUiType UiType = EItemGetUiType.None, Offset<IItemGetUiConfigSpecialQuest> UiConfigOffset = default(Offset<IItemGetUiConfigSpecialQuest>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IGetItem.AddUiConfig(builder, UiConfigOffset);
			IGetItem.AddItems(builder, ItemsOffset);
			IGetItem.AddNullMask(builder, NullMask);
			IGetItem.AddUiType(builder, UiType);
			return IGetItem.EndIGetItem(builder);
		}

		// Token: 0x0602EA8F RID: 191119 RVA: 0x0065CD99 File Offset: 0x0065AF99
		public static void StartIGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602EA90 RID: 191120 RVA: 0x0065CDA2 File Offset: 0x0065AFA2
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0602EA91 RID: 191121 RVA: 0x0065CDB4 File Offset: 0x0065AFB4
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EA92 RID: 191122 RVA: 0x0065CDF4 File Offset: 0x0065AFF4
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EA93 RID: 191123 RVA: 0x0065CE0E File Offset: 0x0065B00E
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EA94 RID: 191124 RVA: 0x0065CE2C File Offset: 0x0065B02C
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EA95 RID: 191125 RVA: 0x0065CE45 File Offset: 0x0065B045
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EA96 RID: 191126 RVA: 0x0065CE50 File Offset: 0x0065B050
		public static void AddUiType(FlatBufferBuilder builder, EItemGetUiType uiType)
		{
			builder.AddByte(1, (byte)uiType, 0);
		}

		// Token: 0x0602EA97 RID: 191127 RVA: 0x0065CE5B File Offset: 0x0065B05B
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IItemGetUiConfigSpecialQuest> uiConfigOffset)
		{
			builder.AddOffset(2, uiConfigOffset.Value, 0);
		}

		// Token: 0x0602EA98 RID: 191128 RVA: 0x0065CE6B File Offset: 0x0065B06B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602EA99 RID: 191129 RVA: 0x0065CE76 File Offset: 0x0065B076
		public static Offset<IGetItem> EndIGetItem(FlatBufferBuilder builder)
		{
			return new Offset<IGetItem>(builder.EndTable());
		}

		// Token: 0x0602EA9A RID: 191130 RVA: 0x0065CE84 File Offset: 0x0065B084
		public IGetItemT UnPack()
		{
			IGetItemT getItemT = new IGetItemT();
			this.UnPackTo(getItemT);
			return getItemT;
		}

		// Token: 0x0602EA9B RID: 191131 RVA: 0x0065CEA0 File Offset: 0x0065B0A0
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

		// Token: 0x0602EA9C RID: 191132 RVA: 0x0065CF48 File Offset: 0x0065B148
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

		// Token: 0x04010FD6 RID: 69590
		private Table __p;
	}
}
