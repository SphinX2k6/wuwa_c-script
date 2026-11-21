using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB9 RID: 3001
	public struct AdvertisingTabSystem : IFlatbufferObject
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06004B07 RID: 19207 RVA: 0x001F0CF4 File Offset: 0x001EEEF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x001F0D01 File Offset: 0x001EEF01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x001F0D08 File Offset: 0x001EEF08
		public static AdvertisingTabSystem GetRootAsAdvertisingTabSystem(ByteBuffer _bb)
		{
			return AdvertisingTabSystem.GetRootAsAdvertisingTabSystem(_bb, default(AdvertisingTabSystem));
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x001F0D24 File Offset: 0x001EEF24
		public static AdvertisingTabSystem GetRootAsAdvertisingTabSystem(ByteBuffer _bb, AdvertisingTabSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x001F0D41 File Offset: 0x001EEF41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x001F0D50 File Offset: 0x001EEF50
		public AdvertisingTabSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x001F0D60 File Offset: 0x001EEF60
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x001F0D9C File Offset: 0x001EEF9C
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

		// Token: 0x06004B0F RID: 19215 RVA: 0x001F0DD3 File Offset: 0x001EEFD3
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x001F0DE2 File Offset: 0x001EEFE2
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x001F0DFC File Offset: 0x001EEFFC
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

		// Token: 0x06004B12 RID: 19218 RVA: 0x001F0E33 File Offset: 0x001EF033
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x001F0E42 File Offset: 0x001EF042
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x001F0E5C File Offset: 0x001EF05C
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

		// Token: 0x06004B15 RID: 19221 RVA: 0x001F0E94 File Offset: 0x001EF094
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x001F0EA4 File Offset: 0x001EF0A4
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x001F0EBC File Offset: 0x001EF0BC
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

		// Token: 0x06004B18 RID: 19224 RVA: 0x001F0EF4 File Offset: 0x001EF0F4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x001F0F04 File Offset: 0x001EF104
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x001F0F1C File Offset: 0x001EF11C
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

		// Token: 0x06004B1B RID: 19227 RVA: 0x001F0F54 File Offset: 0x001EF154
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x001F0F64 File Offset: 0x001EF164
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x001F0F7C File Offset: 0x001EF17C
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

		// Token: 0x06004B1E RID: 19230 RVA: 0x001F0FB4 File Offset: 0x001EF1B4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x001F0FC4 File Offset: 0x001EF1C4
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005099 RID: 20633
		private Table __p;
	}
}
