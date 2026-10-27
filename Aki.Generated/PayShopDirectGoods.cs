using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB2 RID: 3762
	public struct PayShopDirectGoods : IFlatbufferObject
	{
		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x0600A31D RID: 41757 RVA: 0x002A6A7D File Offset: 0x002A4C7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x002A6A8A File Offset: 0x002A4C8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x002A6A94 File Offset: 0x002A4C94
		public static PayShopDirectGoods GetRootAsPayShopDirectGoods(ByteBuffer _bb)
		{
			return PayShopDirectGoods.GetRootAsPayShopDirectGoods(_bb, default(PayShopDirectGoods));
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x002A6AB0 File Offset: 0x002A4CB0
		public static PayShopDirectGoods GetRootAsPayShopDirectGoods(ByteBuffer _bb, PayShopDirectGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x002A6ACD File Offset: 0x002A4CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x002A6ADC File Offset: 0x002A4CDC
		public PayShopDirectGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x0600A323 RID: 41763 RVA: 0x002A6AEC File Offset: 0x002A4CEC
		public int GoodsId
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

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x0600A324 RID: 41764 RVA: 0x002A6B28 File Offset: 0x002A4D28
		public int PayId
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

		// Token: 0x04004F68 RID: 20328
		private Table __p;
	}
}
