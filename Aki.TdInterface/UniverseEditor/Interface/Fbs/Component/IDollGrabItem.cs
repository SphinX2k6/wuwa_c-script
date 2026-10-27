using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200509F RID: 20639
	public struct IDollGrabItem : IFlatbufferObject
	{
		// Token: 0x170095EC RID: 38380
		// (get) Token: 0x0602123B RID: 135739 RVA: 0x0049AD40 File Offset: 0x00498F40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602123C RID: 135740 RVA: 0x0049AD4D File Offset: 0x00498F4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602123D RID: 135741 RVA: 0x0049AD54 File Offset: 0x00498F54
		public static IDollGrabItem GetRootAsIDollGrabItem(ByteBuffer _bb)
		{
			return IDollGrabItem.GetRootAsIDollGrabItem(_bb, default(IDollGrabItem));
		}

		// Token: 0x0602123E RID: 135742 RVA: 0x0049AD70 File Offset: 0x00498F70
		public static IDollGrabItem GetRootAsIDollGrabItem(ByteBuffer _bb, IDollGrabItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602123F RID: 135743 RVA: 0x0049AD8D File Offset: 0x00498F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021240 RID: 135744 RVA: 0x0049AD9C File Offset: 0x00498F9C
		public IDollGrabItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095ED RID: 38381
		// (get) Token: 0x06021241 RID: 135745 RVA: 0x0049ADAC File Offset: 0x00498FAC
		public int Id
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

		// Token: 0x170095EE RID: 38382
		// (get) Token: 0x06021242 RID: 135746 RVA: 0x0049ADE8 File Offset: 0x00498FE8
		public int ItemId
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

		// Token: 0x06021243 RID: 135747 RVA: 0x0049AE24 File Offset: 0x00499024
		public static Offset<IDollGrabItem> CreateIDollGrabItem(FlatBufferBuilder builder, int Id = 0, int ItemId = 0)
		{
			builder.StartTable(2);
			IDollGrabItem.AddItemId(builder, ItemId);
			IDollGrabItem.AddId(builder, Id);
			return IDollGrabItem.EndIDollGrabItem(builder);
		}

		// Token: 0x06021244 RID: 135748 RVA: 0x0049AE41 File Offset: 0x00499041
		public static void StartIDollGrabItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021245 RID: 135749 RVA: 0x0049AE4A File Offset: 0x0049904A
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06021246 RID: 135750 RVA: 0x0049AE55 File Offset: 0x00499055
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x06021247 RID: 135751 RVA: 0x0049AE60 File Offset: 0x00499060
		public static Offset<IDollGrabItem> EndIDollGrabItem(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabItem>(builder.EndTable());
		}

		// Token: 0x06021248 RID: 135752 RVA: 0x0049AE70 File Offset: 0x00499070
		public IDollGrabItemT UnPack()
		{
			IDollGrabItemT dollGrabItemT = new IDollGrabItemT();
			this.UnPackTo(dollGrabItemT);
			return dollGrabItemT;
		}

		// Token: 0x06021249 RID: 135753 RVA: 0x0049AE8B File Offset: 0x0049908B
		public void UnPackTo(IDollGrabItemT _o)
		{
			_o.Id = this.Id;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x0602124A RID: 135754 RVA: 0x0049AEA8 File Offset: 0x004990A8
		public static Offset<IDollGrabItem> Pack(FlatBufferBuilder builder, IDollGrabItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabItem>);
			}
			return IDollGrabItem.CreateIDollGrabItem(builder, _o.Id, _o.ItemId);
		}

		// Token: 0x0400E0BD RID: 57533
		private Table __p;
	}
}
