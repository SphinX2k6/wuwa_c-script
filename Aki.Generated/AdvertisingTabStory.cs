using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADE RID: 2782
	public struct AdvertisingTabStory : IFlatbufferObject
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x001D0F74 File Offset: 0x001CF174
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x001D0F81 File Offset: 0x001CF181
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x001D0F88 File Offset: 0x001CF188
		public static AdvertisingTabStory GetRootAsAdvertisingTabStory(ByteBuffer _bb)
		{
			return AdvertisingTabStory.GetRootAsAdvertisingTabStory(_bb, default(AdvertisingTabStory));
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x001D0FA4 File Offset: 0x001CF1A4
		public static AdvertisingTabStory GetRootAsAdvertisingTabStory(ByteBuffer _bb, AdvertisingTabStory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x001D0FC1 File Offset: 0x001CF1C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x001D0FD0 File Offset: 0x001CF1D0
		public AdvertisingTabStory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x001D0FE0 File Offset: 0x001CF1E0
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x001D101C File Offset: 0x001CF21C
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

		// Token: 0x060045AF RID: 17839 RVA: 0x001D1053 File Offset: 0x001CF253
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x001D1062 File Offset: 0x001CF262
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x001D107C File Offset: 0x001CF27C
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

		// Token: 0x060045B2 RID: 17842 RVA: 0x001D10B3 File Offset: 0x001CF2B3
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x001D10C2 File Offset: 0x001CF2C2
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x001D10DC File Offset: 0x001CF2DC
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

		// Token: 0x060045B5 RID: 17845 RVA: 0x001D1114 File Offset: 0x001CF314
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x001D1124 File Offset: 0x001CF324
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x001D113C File Offset: 0x001CF33C
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

		// Token: 0x060045B8 RID: 17848 RVA: 0x001D1174 File Offset: 0x001CF374
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x001D1184 File Offset: 0x001CF384
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060045BA RID: 17850 RVA: 0x001D119C File Offset: 0x001CF39C
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

		// Token: 0x060045BB RID: 17851 RVA: 0x001D11D4 File Offset: 0x001CF3D4
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x001D11E4 File Offset: 0x001CF3E4
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x001D11FC File Offset: 0x001CF3FC
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

		// Token: 0x060045BE RID: 17854 RVA: 0x001D1234 File Offset: 0x001CF434
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x001D1244 File Offset: 0x001CF444
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ABE RID: 19134
		private Table __p;
	}
}
