using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007067 RID: 28775
	public struct IItemData : IFlatbufferObject
	{
		// Token: 0x1700D2BF RID: 53951
		// (get) Token: 0x06031E5B RID: 204379 RVA: 0x006C105C File Offset: 0x006BF25C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E5C RID: 204380 RVA: 0x006C1069 File Offset: 0x006BF269
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E5D RID: 204381 RVA: 0x006C1070 File Offset: 0x006BF270
		public static IItemData GetRootAsIItemData(ByteBuffer _bb)
		{
			return IItemData.GetRootAsIItemData(_bb, default(IItemData));
		}

		// Token: 0x06031E5E RID: 204382 RVA: 0x006C108C File Offset: 0x006BF28C
		public static IItemData GetRootAsIItemData(ByteBuffer _bb, IItemData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E5F RID: 204383 RVA: 0x006C10A9 File Offset: 0x006BF2A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E60 RID: 204384 RVA: 0x006C10B8 File Offset: 0x006BF2B8
		public IItemData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2C0 RID: 53952
		// (get) Token: 0x06031E61 RID: 204385 RVA: 0x006C10C8 File Offset: 0x006BF2C8
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

		// Token: 0x1700D2C1 RID: 53953
		// (get) Token: 0x06031E62 RID: 204386 RVA: 0x006C1104 File Offset: 0x006BF304
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

		// Token: 0x06031E63 RID: 204387 RVA: 0x006C1140 File Offset: 0x006BF340
		public static Offset<IItemData> CreateIItemData(FlatBufferBuilder builder, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(2);
			IItemData.AddCount(builder, Count);
			IItemData.AddItemId(builder, ItemId);
			return IItemData.EndIItemData(builder);
		}

		// Token: 0x06031E64 RID: 204388 RVA: 0x006C115D File Offset: 0x006BF35D
		public static void StartIItemData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031E65 RID: 204389 RVA: 0x006C1166 File Offset: 0x006BF366
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x06031E66 RID: 204390 RVA: 0x006C1171 File Offset: 0x006BF371
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06031E67 RID: 204391 RVA: 0x006C117C File Offset: 0x006BF37C
		public static Offset<IItemData> EndIItemData(FlatBufferBuilder builder)
		{
			return new Offset<IItemData>(builder.EndTable());
		}

		// Token: 0x06031E68 RID: 204392 RVA: 0x006C118C File Offset: 0x006BF38C
		public IItemDataT UnPack()
		{
			IItemDataT itemDataT = new IItemDataT();
			this.UnPackTo(itemDataT);
			return itemDataT;
		}

		// Token: 0x06031E69 RID: 204393 RVA: 0x006C11A7 File Offset: 0x006BF3A7
		public void UnPackTo(IItemDataT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x06031E6A RID: 204394 RVA: 0x006C11C4 File Offset: 0x006BF3C4
		public static Offset<IItemData> Pack(FlatBufferBuilder builder, IItemDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemData>);
			}
			return IItemData.CreateIItemData(builder, _o.ItemId, _o.Count);
		}

		// Token: 0x04011FCF RID: 73679
		private Table __p;
	}
}
