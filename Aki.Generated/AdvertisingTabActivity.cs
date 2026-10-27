using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD8 RID: 2776
	public struct AdvertisingTabActivity : IFlatbufferObject
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x001CF465 File Offset: 0x001CD665
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x001CF472 File Offset: 0x001CD672
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x001CF47C File Offset: 0x001CD67C
		public static AdvertisingTabActivity GetRootAsAdvertisingTabActivity(ByteBuffer _bb)
		{
			return AdvertisingTabActivity.GetRootAsAdvertisingTabActivity(_bb, default(AdvertisingTabActivity));
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x001CF498 File Offset: 0x001CD698
		public static AdvertisingTabActivity GetRootAsAdvertisingTabActivity(ByteBuffer _bb, AdvertisingTabActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x001CF4B5 File Offset: 0x001CD6B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x001CF4C4 File Offset: 0x001CD6C4
		public AdvertisingTabActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x001CF4D4 File Offset: 0x001CD6D4
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060044D7 RID: 17623 RVA: 0x001CF510 File Offset: 0x001CD710
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

		// Token: 0x060044D8 RID: 17624 RVA: 0x001CF547 File Offset: 0x001CD747
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x001CF556 File Offset: 0x001CD756
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x001CF570 File Offset: 0x001CD770
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

		// Token: 0x060044DB RID: 17627 RVA: 0x001CF5A7 File Offset: 0x001CD7A7
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x001CF5B6 File Offset: 0x001CD7B6
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060044DD RID: 17629 RVA: 0x001CF5D0 File Offset: 0x001CD7D0
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

		// Token: 0x060044DE RID: 17630 RVA: 0x001CF608 File Offset: 0x001CD808
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x001CF618 File Offset: 0x001CD818
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x001CF630 File Offset: 0x001CD830
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

		// Token: 0x060044E1 RID: 17633 RVA: 0x001CF668 File Offset: 0x001CD868
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x001CF678 File Offset: 0x001CD878
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x001CF690 File Offset: 0x001CD890
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

		// Token: 0x060044E4 RID: 17636 RVA: 0x001CF6C8 File Offset: 0x001CD8C8
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x001CF6D8 File Offset: 0x001CD8D8
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x001CF6F0 File Offset: 0x001CD8F0
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

		// Token: 0x060044E7 RID: 17639 RVA: 0x001CF728 File Offset: 0x001CD928
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001CF738 File Offset: 0x001CD938
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AB7 RID: 19127
		private Table __p;
	}
}
