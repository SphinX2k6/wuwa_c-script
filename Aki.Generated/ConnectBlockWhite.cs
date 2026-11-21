using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7A RID: 3194
	public struct ConnectBlockWhite : IFlatbufferObject
	{
		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06005ECC RID: 24268 RVA: 0x0021E897 File Offset: 0x0021CA97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x0021E8A4 File Offset: 0x0021CAA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x0021E8AC File Offset: 0x0021CAAC
		public static ConnectBlockWhite GetRootAsConnectBlockWhite(ByteBuffer _bb)
		{
			return ConnectBlockWhite.GetRootAsConnectBlockWhite(_bb, default(ConnectBlockWhite));
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x0021E8C8 File Offset: 0x0021CAC8
		public static ConnectBlockWhite GetRootAsConnectBlockWhite(ByteBuffer _bb, ConnectBlockWhite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x0021E8E5 File Offset: 0x0021CAE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x0021E8F4 File Offset: 0x0021CAF4
		public ConnectBlockWhite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06005ED2 RID: 24274 RVA: 0x0021E904 File Offset: 0x0021CB04
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x0021E940 File Offset: 0x0021CB40
		public int Type
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

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06005ED4 RID: 24276 RVA: 0x0021E97C File Offset: 0x0021CB7C
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x0021E9B8 File Offset: 0x0021CBB8
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400519B RID: 20891
		private Table __p;
	}
}
