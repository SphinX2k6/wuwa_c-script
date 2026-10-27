using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADD RID: 2781
	public struct AdvertisingTabRegion : IFlatbufferObject
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x001D0C89 File Offset: 0x001CEE89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x001D0C96 File Offset: 0x001CEE96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x001D0CA0 File Offset: 0x001CEEA0
		public static AdvertisingTabRegion GetRootAsAdvertisingTabRegion(ByteBuffer _bb)
		{
			return AdvertisingTabRegion.GetRootAsAdvertisingTabRegion(_bb, default(AdvertisingTabRegion));
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x001D0CBC File Offset: 0x001CEEBC
		public static AdvertisingTabRegion GetRootAsAdvertisingTabRegion(ByteBuffer _bb, AdvertisingTabRegion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x001D0CD9 File Offset: 0x001CEED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x001D0CE8 File Offset: 0x001CEEE8
		public AdvertisingTabRegion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x001D0CF8 File Offset: 0x001CEEF8
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x001D0D34 File Offset: 0x001CEF34
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

		// Token: 0x06004596 RID: 17814 RVA: 0x001D0D6B File Offset: 0x001CEF6B
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x001D0D7A File Offset: 0x001CEF7A
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x001D0D94 File Offset: 0x001CEF94
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

		// Token: 0x06004599 RID: 17817 RVA: 0x001D0DCB File Offset: 0x001CEFCB
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x001D0DDA File Offset: 0x001CEFDA
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x001D0DF4 File Offset: 0x001CEFF4
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

		// Token: 0x0600459C RID: 17820 RVA: 0x001D0E2C File Offset: 0x001CF02C
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x001D0E3C File Offset: 0x001CF03C
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x001D0E54 File Offset: 0x001CF054
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

		// Token: 0x0600459F RID: 17823 RVA: 0x001D0E8C File Offset: 0x001CF08C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x001D0E9C File Offset: 0x001CF09C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x001D0EB4 File Offset: 0x001CF0B4
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

		// Token: 0x060045A2 RID: 17826 RVA: 0x001D0EEC File Offset: 0x001CF0EC
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x001D0EFC File Offset: 0x001CF0FC
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x001D0F14 File Offset: 0x001CF114
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

		// Token: 0x060045A5 RID: 17829 RVA: 0x001D0F4C File Offset: 0x001CF14C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x001D0F5C File Offset: 0x001CF15C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ABD RID: 19133
		private Table __p;
	}
}
