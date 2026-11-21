using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E62 RID: 3682
	public struct ItemExchangeLimit : IFlatbufferObject
	{
		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06008C68 RID: 35944 RVA: 0x00283EEC File Offset: 0x002820EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x00283EF9 File Offset: 0x002820F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x00283F00 File Offset: 0x00282100
		public static ItemExchangeLimit GetRootAsItemExchangeLimit(ByteBuffer _bb)
		{
			return ItemExchangeLimit.GetRootAsItemExchangeLimit(_bb, default(ItemExchangeLimit));
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x00283F1C File Offset: 0x0028211C
		public static ItemExchangeLimit GetRootAsItemExchangeLimit(ByteBuffer _bb, ItemExchangeLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x00283F39 File Offset: 0x00282139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x00283F48 File Offset: 0x00282148
		public ItemExchangeLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06008C6E RID: 35950 RVA: 0x00283F58 File Offset: 0x00282158
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

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06008C6F RID: 35951 RVA: 0x00283F94 File Offset: 0x00282194
		public int AddBtnTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040053EB RID: 21483
		private Table __p;
	}
}
