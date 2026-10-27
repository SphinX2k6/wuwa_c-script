using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5D RID: 3421
	public struct InfoDisplay : IFlatbufferObject
	{
		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x060082CD RID: 33485 RVA: 0x0025D96D File Offset: 0x0025BB6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x0025D97A File Offset: 0x0025BB7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060082CF RID: 33487 RVA: 0x0025D984 File Offset: 0x0025BB84
		public static InfoDisplay GetRootAsInfoDisplay(ByteBuffer _bb)
		{
			return InfoDisplay.GetRootAsInfoDisplay(_bb, default(InfoDisplay));
		}

		// Token: 0x060082D0 RID: 33488 RVA: 0x0025D9A0 File Offset: 0x0025BBA0
		public static InfoDisplay GetRootAsInfoDisplay(ByteBuffer _bb, InfoDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060082D1 RID: 33489 RVA: 0x0025D9BD File Offset: 0x0025BBBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060082D2 RID: 33490 RVA: 0x0025D9CC File Offset: 0x0025BBCC
		public InfoDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x060082D3 RID: 33491 RVA: 0x0025D9DC File Offset: 0x0025BBDC
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

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x060082D4 RID: 33492 RVA: 0x0025DA18 File Offset: 0x0025BC18
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

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x0025DA54 File Offset: 0x0025BC54
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

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x060082D6 RID: 33494 RVA: 0x0025DA90 File Offset: 0x0025BC90
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

		// Token: 0x060082D7 RID: 33495 RVA: 0x0025DAC8 File Offset: 0x0025BCC8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x0025DAD8 File Offset: 0x0025BCD8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060082D9 RID: 33497 RVA: 0x0025DAF0 File Offset: 0x0025BCF0
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

		// Token: 0x060082DA RID: 33498 RVA: 0x0025DB28 File Offset: 0x0025BD28
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060082DB RID: 33499 RVA: 0x0025DB38 File Offset: 0x0025BD38
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060082DC RID: 33500 RVA: 0x0025DB50 File Offset: 0x0025BD50
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

		// Token: 0x060082DD RID: 33501 RVA: 0x0025DB88 File Offset: 0x0025BD88
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060082DE RID: 33502 RVA: 0x0025DB98 File Offset: 0x0025BD98
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060082DF RID: 33503 RVA: 0x0025DBB0 File Offset: 0x0025BDB0
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

		// Token: 0x060082E0 RID: 33504 RVA: 0x0025DBE8 File Offset: 0x0025BDE8
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060082E1 RID: 33505 RVA: 0x0025DBF8 File Offset: 0x0025BDF8
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x0025DC10 File Offset: 0x0025BE10
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

		// Token: 0x060082E3 RID: 33507 RVA: 0x0025DC48 File Offset: 0x0025BE48
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060082E4 RID: 33508 RVA: 0x0025DC58 File Offset: 0x0025BE58
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x060082E5 RID: 33509 RVA: 0x0025DC70 File Offset: 0x0025BE70
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

		// Token: 0x060082E6 RID: 33510 RVA: 0x0025DCA8 File Offset: 0x0025BEA8
		public Span<byte> GetEntryAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060082E7 RID: 33511 RVA: 0x0025DCB8 File Offset: 0x0025BEB8
		public byte[] GetEntryAudioArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060082E8 RID: 33512 RVA: 0x0025DCD0 File Offset: 0x0025BED0
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

		// Token: 0x060082E9 RID: 33513 RVA: 0x0025DD08 File Offset: 0x0025BF08
		public Span<byte> GetExitAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060082EA RID: 33514 RVA: 0x0025DD18 File Offset: 0x0025BF18
		public byte[] GetExitAudioArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DDC RID: 19932
		private Table __p;
	}
}
