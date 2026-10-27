using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7D RID: 3453
	public struct ItemExchangeLimit : IFlatbufferObject
	{
		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x0600864D RID: 34381 RVA: 0x00265C5C File Offset: 0x00263E5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x00265C69 File Offset: 0x00263E69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x00265C70 File Offset: 0x00263E70
		public static ItemExchangeLimit GetRootAsItemExchangeLimit(ByteBuffer _bb)
		{
			return ItemExchangeLimit.GetRootAsItemExchangeLimit(_bb, default(ItemExchangeLimit));
		}

		// Token: 0x06008650 RID: 34384 RVA: 0x00265C8C File Offset: 0x00263E8C
		public static ItemExchangeLimit GetRootAsItemExchangeLimit(ByteBuffer _bb, ItemExchangeLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x00265CA9 File Offset: 0x00263EA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x00265CB8 File Offset: 0x00263EB8
		public ItemExchangeLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06008653 RID: 34387 RVA: 0x00265CC8 File Offset: 0x00263EC8
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

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06008654 RID: 34388 RVA: 0x00265D04 File Offset: 0x00263F04
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

		// Token: 0x04004E06 RID: 19974
		private Table __p;
	}
}
