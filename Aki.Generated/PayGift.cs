using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F93 RID: 3987
	public struct PayGift : IFlatbufferObject
	{
		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x0600A901 RID: 43265 RVA: 0x002C3600 File Offset: 0x002C1800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x002C360D File Offset: 0x002C180D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x002C3614 File Offset: 0x002C1814
		public static PayGift GetRootAsPayGift(ByteBuffer _bb)
		{
			return PayGift.GetRootAsPayGift(_bb, default(PayGift));
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x002C3630 File Offset: 0x002C1830
		public static PayGift GetRootAsPayGift(ByteBuffer _bb, PayGift obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x002C364D File Offset: 0x002C184D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x002C365C File Offset: 0x002C185C
		public PayGift __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x0600A907 RID: 43271 RVA: 0x002C366C File Offset: 0x002C186C
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

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x0600A908 RID: 43272 RVA: 0x002C36A8 File Offset: 0x002C18A8
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

		// Token: 0x04005549 RID: 21833
		private Table __p;
	}
}
