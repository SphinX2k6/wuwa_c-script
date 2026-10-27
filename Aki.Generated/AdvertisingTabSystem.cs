using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADF RID: 2783
	public struct AdvertisingTabSystem : IFlatbufferObject
	{
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x001D125C File Offset: 0x001CF45C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x001D1269 File Offset: 0x001CF469
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x001D1270 File Offset: 0x001CF470
		public static AdvertisingTabSystem GetRootAsAdvertisingTabSystem(ByteBuffer _bb)
		{
			return AdvertisingTabSystem.GetRootAsAdvertisingTabSystem(_bb, default(AdvertisingTabSystem));
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x001D128C File Offset: 0x001CF48C
		public static AdvertisingTabSystem GetRootAsAdvertisingTabSystem(ByteBuffer _bb, AdvertisingTabSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x001D12A9 File Offset: 0x001CF4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x001D12B8 File Offset: 0x001CF4B8
		public AdvertisingTabSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x001D12C8 File Offset: 0x001CF4C8
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x001D1304 File Offset: 0x001CF504
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

		// Token: 0x060045C8 RID: 17864 RVA: 0x001D133B File Offset: 0x001CF53B
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x001D134A File Offset: 0x001CF54A
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x001D1364 File Offset: 0x001CF564
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

		// Token: 0x060045CB RID: 17867 RVA: 0x001D139B File Offset: 0x001CF59B
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x001D13AA File Offset: 0x001CF5AA
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x001D13C4 File Offset: 0x001CF5C4
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

		// Token: 0x060045CE RID: 17870 RVA: 0x001D13FC File Offset: 0x001CF5FC
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x001D140C File Offset: 0x001CF60C
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x001D1424 File Offset: 0x001CF624
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

		// Token: 0x060045D1 RID: 17873 RVA: 0x001D145C File Offset: 0x001CF65C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x001D146C File Offset: 0x001CF66C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x001D1484 File Offset: 0x001CF684
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

		// Token: 0x060045D4 RID: 17876 RVA: 0x001D14BC File Offset: 0x001CF6BC
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x001D14CC File Offset: 0x001CF6CC
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x001D14E4 File Offset: 0x001CF6E4
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

		// Token: 0x060045D7 RID: 17879 RVA: 0x001D151C File Offset: 0x001CF71C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x001D152C File Offset: 0x001CF72C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ABF RID: 19135
		private Table __p;
	}
}
