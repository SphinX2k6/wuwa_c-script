using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E42 RID: 3650
	public struct InfoDisplay : IFlatbufferObject
	{
		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x060088E7 RID: 35047 RVA: 0x0027C03D File Offset: 0x0027A23D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x0027C04A File Offset: 0x0027A24A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x0027C054 File Offset: 0x0027A254
		public static InfoDisplay GetRootAsInfoDisplay(ByteBuffer _bb)
		{
			return InfoDisplay.GetRootAsInfoDisplay(_bb, default(InfoDisplay));
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x0027C070 File Offset: 0x0027A270
		public static InfoDisplay GetRootAsInfoDisplay(ByteBuffer _bb, InfoDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x0027C08D File Offset: 0x0027A28D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x0027C09C File Offset: 0x0027A29C
		public InfoDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x060088ED RID: 35053 RVA: 0x0027C0AC File Offset: 0x0027A2AC
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

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x060088EE RID: 35054 RVA: 0x0027C0E8 File Offset: 0x0027A2E8
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x060088EF RID: 35055 RVA: 0x0027C124 File Offset: 0x0027A324
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x060088F0 RID: 35056 RVA: 0x0027C160 File Offset: 0x0027A360
		public string Title
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

		// Token: 0x060088F1 RID: 35057 RVA: 0x0027C198 File Offset: 0x0027A398
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060088F2 RID: 35058 RVA: 0x0027C1A8 File Offset: 0x0027A3A8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x060088F3 RID: 35059 RVA: 0x0027C1C0 File Offset: 0x0027A3C0
		public string Text
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

		// Token: 0x060088F4 RID: 35060 RVA: 0x0027C1F8 File Offset: 0x0027A3F8
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060088F5 RID: 35061 RVA: 0x0027C208 File Offset: 0x0027A408
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x060088F6 RID: 35062 RVA: 0x0027C220 File Offset: 0x0027A420
		public string Picture
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

		// Token: 0x060088F7 RID: 35063 RVA: 0x0027C258 File Offset: 0x0027A458
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x0027C268 File Offset: 0x0027A468
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x060088F9 RID: 35065 RVA: 0x0027C280 File Offset: 0x0027A480
		public string Audio
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

		// Token: 0x060088FA RID: 35066 RVA: 0x0027C2B8 File Offset: 0x0027A4B8
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x0027C2C8 File Offset: 0x0027A4C8
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x060088FC RID: 35068 RVA: 0x0027C2E0 File Offset: 0x0027A4E0
		public string Background
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x0027C318 File Offset: 0x0027A518
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x0027C328 File Offset: 0x0027A528
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x060088FF RID: 35071 RVA: 0x0027C340 File Offset: 0x0027A540
		public string EntryAudio
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x0027C378 File Offset: 0x0027A578
		public Span<byte> GetEntryAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x0027C388 File Offset: 0x0027A588
		public byte[] GetEntryAudioArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06008902 RID: 35074 RVA: 0x0027C3A0 File Offset: 0x0027A5A0
		public string ExitAudio
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x0027C3D8 File Offset: 0x0027A5D8
		public Span<byte> GetExitAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x0027C3E8 File Offset: 0x0027A5E8
		public byte[] GetExitAudioArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x040053C1 RID: 21441
		private Table __p;
	}
}
