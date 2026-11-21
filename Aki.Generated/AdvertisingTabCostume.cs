using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB4 RID: 2996
	public struct AdvertisingTabCostume : IFlatbufferObject
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x001EF864 File Offset: 0x001EDA64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x001EF871 File Offset: 0x001EDA71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x001EF878 File Offset: 0x001EDA78
		public static AdvertisingTabCostume GetRootAsAdvertisingTabCostume(ByteBuffer _bb)
		{
			return AdvertisingTabCostume.GetRootAsAdvertisingTabCostume(_bb, default(AdvertisingTabCostume));
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x001EF894 File Offset: 0x001EDA94
		public static AdvertisingTabCostume GetRootAsAdvertisingTabCostume(ByteBuffer _bb, AdvertisingTabCostume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x001EF8B1 File Offset: 0x001EDAB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x001EF8C0 File Offset: 0x001EDAC0
		public AdvertisingTabCostume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06004A67 RID: 19047 RVA: 0x001EF8D0 File Offset: 0x001EDAD0
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06004A68 RID: 19048 RVA: 0x001EF90C File Offset: 0x001EDB0C
		public string ThumbnailText
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

		// Token: 0x06004A69 RID: 19049 RVA: 0x001EF943 File Offset: 0x001EDB43
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x001EF952 File Offset: 0x001EDB52
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x001EF96C File Offset: 0x001EDB6C
		public string ThumbnailPic
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

		// Token: 0x06004A6C RID: 19052 RVA: 0x001EF9A3 File Offset: 0x001EDBA3
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x001EF9B2 File Offset: 0x001EDBB2
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06004A6E RID: 19054 RVA: 0x001EF9CC File Offset: 0x001EDBCC
		public string MainPic
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

		// Token: 0x06004A6F RID: 19055 RVA: 0x001EFA04 File Offset: 0x001EDC04
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x001EFA14 File Offset: 0x001EDC14
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06004A71 RID: 19057 RVA: 0x001EFA2C File Offset: 0x001EDC2C
		public string Title
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x001EFA64 File Offset: 0x001EDC64
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x001EFA74 File Offset: 0x001EDC74
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06004A74 RID: 19060 RVA: 0x001EFA8C File Offset: 0x001EDC8C
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x001EFAC4 File Offset: 0x001EDCC4
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x001EFAD4 File Offset: 0x001EDCD4
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x001EFAEC File Offset: 0x001EDCEC
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x001EFB24 File Offset: 0x001EDD24
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x001EFB34 File Offset: 0x001EDD34
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005093 RID: 20627
		private Table __p;
	}
}
