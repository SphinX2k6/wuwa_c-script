using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB2 RID: 2994
	public struct AdvertisingTabActivity : IFlatbufferObject
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06004A17 RID: 18967 RVA: 0x001EEF39 File Offset: 0x001ED139
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x001EEF46 File Offset: 0x001ED146
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x001EEF50 File Offset: 0x001ED150
		public static AdvertisingTabActivity GetRootAsAdvertisingTabActivity(ByteBuffer _bb)
		{
			return AdvertisingTabActivity.GetRootAsAdvertisingTabActivity(_bb, default(AdvertisingTabActivity));
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x001EEF6C File Offset: 0x001ED16C
		public static AdvertisingTabActivity GetRootAsAdvertisingTabActivity(ByteBuffer _bb, AdvertisingTabActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x001EEF89 File Offset: 0x001ED189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x001EEF98 File Offset: 0x001ED198
		public AdvertisingTabActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x001EEFA8 File Offset: 0x001ED1A8
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06004A1E RID: 18974 RVA: 0x001EEFE4 File Offset: 0x001ED1E4
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

		// Token: 0x06004A1F RID: 18975 RVA: 0x001EF01B File Offset: 0x001ED21B
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x001EF02A File Offset: 0x001ED22A
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x001EF044 File Offset: 0x001ED244
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

		// Token: 0x06004A22 RID: 18978 RVA: 0x001EF07B File Offset: 0x001ED27B
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x001EF08A File Offset: 0x001ED28A
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06004A24 RID: 18980 RVA: 0x001EF0A4 File Offset: 0x001ED2A4
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

		// Token: 0x06004A25 RID: 18981 RVA: 0x001EF0DC File Offset: 0x001ED2DC
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x001EF0EC File Offset: 0x001ED2EC
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x001EF104 File Offset: 0x001ED304
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

		// Token: 0x06004A28 RID: 18984 RVA: 0x001EF13C File Offset: 0x001ED33C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x001EF14C File Offset: 0x001ED34C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06004A2A RID: 18986 RVA: 0x001EF164 File Offset: 0x001ED364
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

		// Token: 0x06004A2B RID: 18987 RVA: 0x001EF19C File Offset: 0x001ED39C
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x001EF1AC File Offset: 0x001ED3AC
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x001EF1C4 File Offset: 0x001ED3C4
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

		// Token: 0x06004A2E RID: 18990 RVA: 0x001EF1FC File Offset: 0x001ED3FC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x001EF20C File Offset: 0x001ED40C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005091 RID: 20625
		private Table __p;
	}
}
