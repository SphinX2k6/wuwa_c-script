using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005604 RID: 22020
	public struct IDollGrabItem : IFlatbufferObject
	{
		// Token: 0x17009DD9 RID: 40409
		// (get) Token: 0x0602318F RID: 143759 RVA: 0x004D4CCC File Offset: 0x004D2ECC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023190 RID: 143760 RVA: 0x004D4CD9 File Offset: 0x004D2ED9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023191 RID: 143761 RVA: 0x004D4CE0 File Offset: 0x004D2EE0
		public static IDollGrabItem GetRootAsIDollGrabItem(ByteBuffer _bb)
		{
			return IDollGrabItem.GetRootAsIDollGrabItem(_bb, default(IDollGrabItem));
		}

		// Token: 0x06023192 RID: 143762 RVA: 0x004D4CFC File Offset: 0x004D2EFC
		public static IDollGrabItem GetRootAsIDollGrabItem(ByteBuffer _bb, IDollGrabItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023193 RID: 143763 RVA: 0x004D4D19 File Offset: 0x004D2F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023194 RID: 143764 RVA: 0x004D4D28 File Offset: 0x004D2F28
		public IDollGrabItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DDA RID: 40410
		// (get) Token: 0x06023195 RID: 143765 RVA: 0x004D4D38 File Offset: 0x004D2F38
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

		// Token: 0x17009DDB RID: 40411
		// (get) Token: 0x06023196 RID: 143766 RVA: 0x004D4D74 File Offset: 0x004D2F74
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

		// Token: 0x06023197 RID: 143767 RVA: 0x004D4DB0 File Offset: 0x004D2FB0
		public static Offset<IDollGrabItem> CreateIDollGrabItem(FlatBufferBuilder builder, int Id = 0, int ItemId = 0)
		{
			builder.StartTable(2);
			IDollGrabItem.AddItemId(builder, ItemId);
			IDollGrabItem.AddId(builder, Id);
			return IDollGrabItem.EndIDollGrabItem(builder);
		}

		// Token: 0x06023198 RID: 143768 RVA: 0x004D4DCD File Offset: 0x004D2FCD
		public static void StartIDollGrabItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023199 RID: 143769 RVA: 0x004D4DD6 File Offset: 0x004D2FD6
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602319A RID: 143770 RVA: 0x004D4DE1 File Offset: 0x004D2FE1
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0602319B RID: 143771 RVA: 0x004D4DEC File Offset: 0x004D2FEC
		public static Offset<IDollGrabItem> EndIDollGrabItem(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabItem>(builder.EndTable());
		}

		// Token: 0x0602319C RID: 143772 RVA: 0x004D4DFC File Offset: 0x004D2FFC
		public IDollGrabItemT UnPack()
		{
			IDollGrabItemT dollGrabItemT = new IDollGrabItemT();
			this.UnPackTo(dollGrabItemT);
			return dollGrabItemT;
		}

		// Token: 0x0602319D RID: 143773 RVA: 0x004D4E17 File Offset: 0x004D3017
		public void UnPackTo(IDollGrabItemT _o)
		{
			_o.Id = this.Id;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x0602319E RID: 143774 RVA: 0x004D4E34 File Offset: 0x004D3034
		public static Offset<IDollGrabItem> Pack(FlatBufferBuilder builder, IDollGrabItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabItem>);
			}
			return IDollGrabItem.CreateIDollGrabItem(builder, _o.Id, _o.ItemId);
		}

		// Token: 0x0400ECBA RID: 60602
		private Table __p;
	}
}
