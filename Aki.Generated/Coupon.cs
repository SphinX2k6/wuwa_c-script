using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8C RID: 3212
	public struct Coupon : IFlatbufferObject
	{
		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600604B RID: 24651 RVA: 0x00221D92 File Offset: 0x0021FF92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00221D9F File Offset: 0x0021FF9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x00221DA8 File Offset: 0x0021FFA8
		public static Coupon GetRootAsCoupon(ByteBuffer _bb)
		{
			return Coupon.GetRootAsCoupon(_bb, default(Coupon));
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x00221DC4 File Offset: 0x0021FFC4
		public static Coupon GetRootAsCoupon(ByteBuffer _bb, Coupon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x00221DE1 File Offset: 0x0021FFE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x00221DF0 File Offset: 0x0021FFF0
		public Coupon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x00221E00 File Offset: 0x00220000
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

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06006052 RID: 24658 RVA: 0x00221E3C File Offset: 0x0022003C
		public int Param
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

		// Token: 0x040051AF RID: 20911
		private Table __p;
	}
}
