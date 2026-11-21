using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBA RID: 3002
	public struct AdvertisingUrlConfig : IFlatbufferObject
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x001F0FDC File Offset: 0x001EF1DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x001F0FE9 File Offset: 0x001EF1E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x001F0FF0 File Offset: 0x001EF1F0
		public static AdvertisingUrlConfig GetRootAsAdvertisingUrlConfig(ByteBuffer _bb)
		{
			return AdvertisingUrlConfig.GetRootAsAdvertisingUrlConfig(_bb, default(AdvertisingUrlConfig));
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x001F100C File Offset: 0x001EF20C
		public static AdvertisingUrlConfig GetRootAsAdvertisingUrlConfig(ByteBuffer _bb, AdvertisingUrlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x001F1029 File Offset: 0x001EF229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x001F1038 File Offset: 0x001EF238
		public AdvertisingUrlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x001F1048 File Offset: 0x001EF248
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06004B27 RID: 19239 RVA: 0x001F1084 File Offset: 0x001EF284
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

		// Token: 0x06004B28 RID: 19240 RVA: 0x001F10BB File Offset: 0x001EF2BB
		public Span<byte> GetLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x001F10CA File Offset: 0x001EF2CA
		public byte[] GetLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x001F10E4 File Offset: 0x001EF2E4
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

		// Token: 0x06004B2B RID: 19243 RVA: 0x001F111B File Offset: 0x001EF31B
		public Span<byte> GetGlobalLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x001F112A File Offset: 0x001EF32A
		public byte[] GetGlobalLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509A RID: 20634
		private Table __p;
	}
}
