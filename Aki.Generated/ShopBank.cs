using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A9 RID: 4265
	public struct ShopBank : IFlatbufferObject
	{
		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600D1B1 RID: 53681 RVA: 0x0030E981 File Offset: 0x0030CB81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1B2 RID: 53682 RVA: 0x0030E98E File Offset: 0x0030CB8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x0030E998 File Offset: 0x0030CB98
		public static ShopBank GetRootAsShopBank(ByteBuffer _bb)
		{
			return ShopBank.GetRootAsShopBank(_bb, default(ShopBank));
		}

		// Token: 0x0600D1B4 RID: 53684 RVA: 0x0030E9B4 File Offset: 0x0030CBB4
		public static ShopBank GetRootAsShopBank(ByteBuffer _bb, ShopBank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1B5 RID: 53685 RVA: 0x0030E9D1 File Offset: 0x0030CBD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1B6 RID: 53686 RVA: 0x0030E9E0 File Offset: 0x0030CBE0
		public ShopBank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600D1B7 RID: 53687 RVA: 0x0030E9F0 File Offset: 0x0030CBF0
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

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600D1B8 RID: 53688 RVA: 0x0030EA2C File Offset: 0x0030CC2C
		public int CondId
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

		// Token: 0x040051B8 RID: 20920
		private Table __p;
	}
}
