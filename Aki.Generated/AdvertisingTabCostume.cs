using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADA RID: 2778
	public struct AdvertisingTabCostume : IFlatbufferObject
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x001CFD90 File Offset: 0x001CDF90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x001CFD9D File Offset: 0x001CDF9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x001CFDA4 File Offset: 0x001CDFA4
		public static AdvertisingTabCostume GetRootAsAdvertisingTabCostume(ByteBuffer _bb)
		{
			return AdvertisingTabCostume.GetRootAsAdvertisingTabCostume(_bb, default(AdvertisingTabCostume));
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x001CFDC0 File Offset: 0x001CDFC0
		public static AdvertisingTabCostume GetRootAsAdvertisingTabCostume(ByteBuffer _bb, AdvertisingTabCostume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x001CFDDD File Offset: 0x001CDFDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x001CFDEC File Offset: 0x001CDFEC
		public AdvertisingTabCostume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x001CFDFC File Offset: 0x001CDFFC
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x001CFE38 File Offset: 0x001CE038
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

		// Token: 0x06004522 RID: 17698 RVA: 0x001CFE6F File Offset: 0x001CE06F
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x001CFE7E File Offset: 0x001CE07E
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06004524 RID: 17700 RVA: 0x001CFE98 File Offset: 0x001CE098
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

		// Token: 0x06004525 RID: 17701 RVA: 0x001CFECF File Offset: 0x001CE0CF
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x001CFEDE File Offset: 0x001CE0DE
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x001CFEF8 File Offset: 0x001CE0F8
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

		// Token: 0x06004528 RID: 17704 RVA: 0x001CFF30 File Offset: 0x001CE130
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x001CFF40 File Offset: 0x001CE140
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x001CFF58 File Offset: 0x001CE158
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

		// Token: 0x0600452B RID: 17707 RVA: 0x001CFF90 File Offset: 0x001CE190
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x001CFFA0 File Offset: 0x001CE1A0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x001CFFB8 File Offset: 0x001CE1B8
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

		// Token: 0x0600452E RID: 17710 RVA: 0x001CFFF0 File Offset: 0x001CE1F0
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x001D0000 File Offset: 0x001CE200
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06004530 RID: 17712 RVA: 0x001D0018 File Offset: 0x001CE218
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

		// Token: 0x06004531 RID: 17713 RVA: 0x001D0050 File Offset: 0x001CE250
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x001D0060 File Offset: 0x001CE260
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AB9 RID: 19129
		private Table __p;
	}
}
