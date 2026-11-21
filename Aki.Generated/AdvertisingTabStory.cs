using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB8 RID: 3000
	public struct AdvertisingTabStory : IFlatbufferObject
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06004AEE RID: 19182 RVA: 0x001F0A0C File Offset: 0x001EEC0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x001F0A19 File Offset: 0x001EEC19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x001F0A20 File Offset: 0x001EEC20
		public static AdvertisingTabStory GetRootAsAdvertisingTabStory(ByteBuffer _bb)
		{
			return AdvertisingTabStory.GetRootAsAdvertisingTabStory(_bb, default(AdvertisingTabStory));
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x001F0A3C File Offset: 0x001EEC3C
		public static AdvertisingTabStory GetRootAsAdvertisingTabStory(ByteBuffer _bb, AdvertisingTabStory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x001F0A59 File Offset: 0x001EEC59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x001F0A68 File Offset: 0x001EEC68
		public AdvertisingTabStory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x001F0A78 File Offset: 0x001EEC78
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

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x001F0AB4 File Offset: 0x001EECB4
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

		// Token: 0x06004AF6 RID: 19190 RVA: 0x001F0AEB File Offset: 0x001EECEB
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x001F0AFA File Offset: 0x001EECFA
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x001F0B14 File Offset: 0x001EED14
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

		// Token: 0x06004AF9 RID: 19193 RVA: 0x001F0B4B File Offset: 0x001EED4B
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x001F0B5A File Offset: 0x001EED5A
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x001F0B74 File Offset: 0x001EED74
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

		// Token: 0x06004AFC RID: 19196 RVA: 0x001F0BAC File Offset: 0x001EEDAC
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x001F0BBC File Offset: 0x001EEDBC
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x001F0BD4 File Offset: 0x001EEDD4
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

		// Token: 0x06004AFF RID: 19199 RVA: 0x001F0C0C File Offset: 0x001EEE0C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x001F0C1C File Offset: 0x001EEE1C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06004B01 RID: 19201 RVA: 0x001F0C34 File Offset: 0x001EEE34
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

		// Token: 0x06004B02 RID: 19202 RVA: 0x001F0C6C File Offset: 0x001EEE6C
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x001F0C7C File Offset: 0x001EEE7C
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x001F0C94 File Offset: 0x001EEE94
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

		// Token: 0x06004B05 RID: 19205 RVA: 0x001F0CCC File Offset: 0x001EEECC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x001F0CDC File Offset: 0x001EEEDC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005098 RID: 20632
		private Table __p;
	}
}
