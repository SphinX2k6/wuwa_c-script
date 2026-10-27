using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200656A RID: 25962
	public struct IDeliverItem : IFlatbufferObject
	{
		// Token: 0x1700C0EB RID: 49387
		// (get) Token: 0x0602D0A8 RID: 184488 RVA: 0x0062E3E8 File Offset: 0x0062C5E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D0A9 RID: 184489 RVA: 0x0062E3F5 File Offset: 0x0062C5F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D0AA RID: 184490 RVA: 0x0062E3FC File Offset: 0x0062C5FC
		public static IDeliverItem GetRootAsIDeliverItem(ByteBuffer _bb)
		{
			return IDeliverItem.GetRootAsIDeliverItem(_bb, default(IDeliverItem));
		}

		// Token: 0x0602D0AB RID: 184491 RVA: 0x0062E418 File Offset: 0x0062C618
		public static IDeliverItem GetRootAsIDeliverItem(ByteBuffer _bb, IDeliverItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D0AC RID: 184492 RVA: 0x0062E435 File Offset: 0x0062C635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D0AD RID: 184493 RVA: 0x0062E444 File Offset: 0x0062C644
		public IDeliverItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0EC RID: 49388
		// (get) Token: 0x0602D0AE RID: 184494 RVA: 0x0062E454 File Offset: 0x0062C654
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

		// Token: 0x1700C0ED RID: 49389
		// (get) Token: 0x0602D0AF RID: 184495 RVA: 0x0062E490 File Offset: 0x0062C690
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

		// Token: 0x0602D0B0 RID: 184496 RVA: 0x0062E4CC File Offset: 0x0062C6CC
		public static Offset<IDeliverItem> CreateIDeliverItem(FlatBufferBuilder builder, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(2);
			IDeliverItem.AddCount(builder, Count);
			IDeliverItem.AddItemId(builder, ItemId);
			return IDeliverItem.EndIDeliverItem(builder);
		}

		// Token: 0x0602D0B1 RID: 184497 RVA: 0x0062E4E9 File Offset: 0x0062C6E9
		public static void StartIDeliverItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D0B2 RID: 184498 RVA: 0x0062E4F2 File Offset: 0x0062C6F2
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0602D0B3 RID: 184499 RVA: 0x0062E4FD File Offset: 0x0062C6FD
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0602D0B4 RID: 184500 RVA: 0x0062E508 File Offset: 0x0062C708
		public static Offset<IDeliverItem> EndIDeliverItem(FlatBufferBuilder builder)
		{
			return new Offset<IDeliverItem>(builder.EndTable());
		}

		// Token: 0x0602D0B5 RID: 184501 RVA: 0x0062E518 File Offset: 0x0062C718
		public IDeliverItemT UnPack()
		{
			IDeliverItemT deliverItemT = new IDeliverItemT();
			this.UnPackTo(deliverItemT);
			return deliverItemT;
		}

		// Token: 0x0602D0B6 RID: 184502 RVA: 0x0062E533 File Offset: 0x0062C733
		public void UnPackTo(IDeliverItemT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x0602D0B7 RID: 184503 RVA: 0x0062E550 File Offset: 0x0062C750
		public static Offset<IDeliverItem> Pack(FlatBufferBuilder builder, IDeliverItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeliverItem>);
			}
			return IDeliverItem.CreateIDeliverItem(builder, _o.ItemId, _o.Count);
		}

		// Token: 0x04010BBF RID: 68543
		private Table __p;
	}
}
