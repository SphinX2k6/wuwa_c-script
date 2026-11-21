using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A4 RID: 4516
	public struct ShopBank : IFlatbufferObject
	{
		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600D987 RID: 55687 RVA: 0x0032DE55 File Offset: 0x0032C055
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D988 RID: 55688 RVA: 0x0032DE62 File Offset: 0x0032C062
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D989 RID: 55689 RVA: 0x0032DE6C File Offset: 0x0032C06C
		public static ShopBank GetRootAsShopBank(ByteBuffer _bb)
		{
			return ShopBank.GetRootAsShopBank(_bb, default(ShopBank));
		}

		// Token: 0x0600D98A RID: 55690 RVA: 0x0032DE88 File Offset: 0x0032C088
		public static ShopBank GetRootAsShopBank(ByteBuffer _bb, ShopBank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D98B RID: 55691 RVA: 0x0032DEA5 File Offset: 0x0032C0A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D98C RID: 55692 RVA: 0x0032DEB4 File Offset: 0x0032C0B4
		public ShopBank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600D98D RID: 55693 RVA: 0x0032DEC4 File Offset: 0x0032C0C4
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

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600D98E RID: 55694 RVA: 0x0032DF00 File Offset: 0x0032C100
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

		// Token: 0x040057B7 RID: 22455
		private Table __p;
	}
}
