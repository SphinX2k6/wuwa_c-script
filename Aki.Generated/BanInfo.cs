using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B26 RID: 2854
	public struct BanInfo : IFlatbufferObject
	{
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06004BAD RID: 19373 RVA: 0x001DEE79 File Offset: 0x001DD079
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x001DEE86 File Offset: 0x001DD086
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x001DEE90 File Offset: 0x001DD090
		public static BanInfo GetRootAsBanInfo(ByteBuffer _bb)
		{
			return BanInfo.GetRootAsBanInfo(_bb, default(BanInfo));
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x001DEEAC File Offset: 0x001DD0AC
		public static BanInfo GetRootAsBanInfo(ByteBuffer _bb, BanInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x001DEEC9 File Offset: 0x001DD0C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x001DEED8 File Offset: 0x001DD0D8
		public BanInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x001DEEE8 File Offset: 0x001DD0E8
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x001DEF24 File Offset: 0x001DD124
		public int BanType
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x001DEF60 File Offset: 0x001DD160
		public int BanReason
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x001DEF9C File Offset: 0x001DD19C
		public string BanDescribe
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x001DEFD4 File Offset: 0x001DD1D4
		public Span<byte> GetBanDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x001DEFE4 File Offset: 0x001DD1E4
		public byte[] GetBanDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B18 RID: 19224
		private Table __p;
	}
}
