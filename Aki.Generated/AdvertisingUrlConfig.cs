using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE0 RID: 2784
	public struct AdvertisingUrlConfig : IFlatbufferObject
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x001D1544 File Offset: 0x001CF744
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x001D1551 File Offset: 0x001CF751
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x001D1558 File Offset: 0x001CF758
		public static AdvertisingUrlConfig GetRootAsAdvertisingUrlConfig(ByteBuffer _bb)
		{
			return AdvertisingUrlConfig.GetRootAsAdvertisingUrlConfig(_bb, default(AdvertisingUrlConfig));
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x001D1574 File Offset: 0x001CF774
		public static AdvertisingUrlConfig GetRootAsAdvertisingUrlConfig(ByteBuffer _bb, AdvertisingUrlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x001D1591 File Offset: 0x001CF791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x001D15A0 File Offset: 0x001CF7A0
		public AdvertisingUrlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x001D15B0 File Offset: 0x001CF7B0
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x001D15EC File Offset: 0x001CF7EC
		public string LinkUrl
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x001D1623 File Offset: 0x001CF823
		public Span<byte> GetLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x001D1632 File Offset: 0x001CF832
		public byte[] GetLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x001D164C File Offset: 0x001CF84C
		public string GlobalLinkUrl
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x001D1683 File Offset: 0x001CF883
		public Span<byte> GetGlobalLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x001D1692 File Offset: 0x001CF892
		public byte[] GetGlobalLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AC0 RID: 19136
		private Table __p;
	}
}
