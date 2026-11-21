using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001098 RID: 4248
	public struct RegressPayGift : IFlatbufferObject
	{
		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0600C159 RID: 49497 RVA: 0x002F8994 File Offset: 0x002F6B94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C15A RID: 49498 RVA: 0x002F89A1 File Offset: 0x002F6BA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x002F89A8 File Offset: 0x002F6BA8
		public static RegressPayGift GetRootAsRegressPayGift(ByteBuffer _bb)
		{
			return RegressPayGift.GetRootAsRegressPayGift(_bb, default(RegressPayGift));
		}

		// Token: 0x0600C15C RID: 49500 RVA: 0x002F89C4 File Offset: 0x002F6BC4
		public static RegressPayGift GetRootAsRegressPayGift(ByteBuffer _bb, RegressPayGift obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C15D RID: 49501 RVA: 0x002F89E1 File Offset: 0x002F6BE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C15E RID: 49502 RVA: 0x002F89F0 File Offset: 0x002F6BF0
		public RegressPayGift __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0600C15F RID: 49503 RVA: 0x002F8A00 File Offset: 0x002F6C00
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

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0600C160 RID: 49504 RVA: 0x002F8A3C File Offset: 0x002F6C3C
		public int ActivityId
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

		// Token: 0x04005671 RID: 22129
		private Table __p;
	}
}
