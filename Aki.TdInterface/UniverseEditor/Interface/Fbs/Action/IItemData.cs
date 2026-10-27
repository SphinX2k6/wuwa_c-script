using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B7 RID: 27063
	public struct IItemData : IFlatbufferObject
	{
		// Token: 0x1700C8BF RID: 51391
		// (get) Token: 0x0602F49B RID: 193691 RVA: 0x00670D04 File Offset: 0x0066EF04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F49C RID: 193692 RVA: 0x00670D11 File Offset: 0x0066EF11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F49D RID: 193693 RVA: 0x00670D18 File Offset: 0x0066EF18
		public static IItemData GetRootAsIItemData(ByteBuffer _bb)
		{
			return IItemData.GetRootAsIItemData(_bb, default(IItemData));
		}

		// Token: 0x0602F49E RID: 193694 RVA: 0x00670D34 File Offset: 0x0066EF34
		public static IItemData GetRootAsIItemData(ByteBuffer _bb, IItemData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F49F RID: 193695 RVA: 0x00670D51 File Offset: 0x0066EF51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4A0 RID: 193696 RVA: 0x00670D60 File Offset: 0x0066EF60
		public IItemData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8C0 RID: 51392
		// (get) Token: 0x0602F4A1 RID: 193697 RVA: 0x00670D70 File Offset: 0x0066EF70
		public int ItemId
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

		// Token: 0x1700C8C1 RID: 51393
		// (get) Token: 0x0602F4A2 RID: 193698 RVA: 0x00670DAC File Offset: 0x0066EFAC
		public int Count
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F4A3 RID: 193699 RVA: 0x00670DE8 File Offset: 0x0066EFE8
		public static Offset<IItemData> CreateIItemData(FlatBufferBuilder builder, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(2);
			IItemData.AddCount(builder, Count);
			IItemData.AddItemId(builder, ItemId);
			return IItemData.EndIItemData(builder);
		}

		// Token: 0x0602F4A4 RID: 193700 RVA: 0x00670E05 File Offset: 0x0066F005
		public static void StartIItemData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F4A5 RID: 193701 RVA: 0x00670E0E File Offset: 0x0066F00E
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0602F4A6 RID: 193702 RVA: 0x00670E19 File Offset: 0x0066F019
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0602F4A7 RID: 193703 RVA: 0x00670E24 File Offset: 0x0066F024
		public static Offset<IItemData> EndIItemData(FlatBufferBuilder builder)
		{
			return new Offset<IItemData>(builder.EndTable());
		}

		// Token: 0x0602F4A8 RID: 193704 RVA: 0x00670E34 File Offset: 0x0066F034
		public IItemDataT UnPack()
		{
			IItemDataT itemDataT = new IItemDataT();
			this.UnPackTo(itemDataT);
			return itemDataT;
		}

		// Token: 0x0602F4A9 RID: 193705 RVA: 0x00670E4F File Offset: 0x0066F04F
		public void UnPackTo(IItemDataT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x0602F4AA RID: 193706 RVA: 0x00670E6C File Offset: 0x0066F06C
		public static Offset<IItemData> Pack(FlatBufferBuilder builder, IItemDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemData>);
			}
			return IItemData.CreateIItemData(builder, _o.ItemId, _o.Count);
		}

		// Token: 0x04011165 RID: 69989
		private Table __p;
	}
}
