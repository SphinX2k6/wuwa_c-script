using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F97 RID: 3991
	public struct PayShopDirectGoods : IFlatbufferObject
	{
		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x0600A93D RID: 43325 RVA: 0x002C3DD9 File Offset: 0x002C1FD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A93E RID: 43326 RVA: 0x002C3DE6 File Offset: 0x002C1FE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A93F RID: 43327 RVA: 0x002C3DF0 File Offset: 0x002C1FF0
		public static PayShopDirectGoods GetRootAsPayShopDirectGoods(ByteBuffer _bb)
		{
			return PayShopDirectGoods.GetRootAsPayShopDirectGoods(_bb, default(PayShopDirectGoods));
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x002C3E0C File Offset: 0x002C200C
		public static PayShopDirectGoods GetRootAsPayShopDirectGoods(ByteBuffer _bb, PayShopDirectGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x002C3E29 File Offset: 0x002C2029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x002C3E38 File Offset: 0x002C2038
		public PayShopDirectGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x0600A943 RID: 43331 RVA: 0x002C3E48 File Offset: 0x002C2048
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

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x0600A944 RID: 43332 RVA: 0x002C3E84 File Offset: 0x002C2084
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

		// Token: 0x0400554D RID: 21837
		private Table __p;
	}
}
