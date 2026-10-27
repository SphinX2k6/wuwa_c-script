using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAA RID: 2986
	public struct Coupon : IFlatbufferObject
	{
		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06005A72 RID: 23154 RVA: 0x0020206D File Offset: 0x0020026D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x0020207A File Offset: 0x0020027A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00202084 File Offset: 0x00200284
		public static Coupon GetRootAsCoupon(ByteBuffer _bb)
		{
			return Coupon.GetRootAsCoupon(_bb, default(Coupon));
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x002020A0 File Offset: 0x002002A0
		public static Coupon GetRootAsCoupon(ByteBuffer _bb, Coupon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x002020BD File Offset: 0x002002BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x002020CC File Offset: 0x002002CC
		public Coupon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06005A78 RID: 23160 RVA: 0x002020DC File Offset: 0x002002DC
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06005A79 RID: 23161 RVA: 0x00202118 File Offset: 0x00200318
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

		// Token: 0x04004BCD RID: 19405
		private Table __p;
	}
}
