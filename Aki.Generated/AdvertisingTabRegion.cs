using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB7 RID: 2999
	public struct AdvertisingTabRegion : IFlatbufferObject
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x001F0721 File Offset: 0x001EE921
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x001F072E File Offset: 0x001EE92E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x001F0738 File Offset: 0x001EE938
		public static AdvertisingTabRegion GetRootAsAdvertisingTabRegion(ByteBuffer _bb)
		{
			return AdvertisingTabRegion.GetRootAsAdvertisingTabRegion(_bb, default(AdvertisingTabRegion));
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x001F0754 File Offset: 0x001EE954
		public static AdvertisingTabRegion GetRootAsAdvertisingTabRegion(ByteBuffer _bb, AdvertisingTabRegion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x001F0771 File Offset: 0x001EE971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x001F0780 File Offset: 0x001EE980
		public AdvertisingTabRegion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06004ADB RID: 19163 RVA: 0x001F0790 File Offset: 0x001EE990
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06004ADC RID: 19164 RVA: 0x001F07CC File Offset: 0x001EE9CC
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

		// Token: 0x06004ADD RID: 19165 RVA: 0x001F0803 File Offset: 0x001EEA03
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x001F0812 File Offset: 0x001EEA12
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06004ADF RID: 19167 RVA: 0x001F082C File Offset: 0x001EEA2C
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

		// Token: 0x06004AE0 RID: 19168 RVA: 0x001F0863 File Offset: 0x001EEA63
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x001F0872 File Offset: 0x001EEA72
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x001F088C File Offset: 0x001EEA8C
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

		// Token: 0x06004AE3 RID: 19171 RVA: 0x001F08C4 File Offset: 0x001EEAC4
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x001F08D4 File Offset: 0x001EEAD4
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x001F08EC File Offset: 0x001EEAEC
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

		// Token: 0x06004AE6 RID: 19174 RVA: 0x001F0924 File Offset: 0x001EEB24
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x001F0934 File Offset: 0x001EEB34
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x001F094C File Offset: 0x001EEB4C
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

		// Token: 0x06004AE9 RID: 19177 RVA: 0x001F0984 File Offset: 0x001EEB84
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x001F0994 File Offset: 0x001EEB94
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06004AEB RID: 19179 RVA: 0x001F09AC File Offset: 0x001EEBAC
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

		// Token: 0x06004AEC RID: 19180 RVA: 0x001F09E4 File Offset: 0x001EEBE4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x001F09F4 File Offset: 0x001EEBF4
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005097 RID: 20631
		private Table __p;
	}
}
