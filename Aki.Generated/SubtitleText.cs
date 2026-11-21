using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200122B RID: 4651
	public struct SubtitleText : IFlatbufferObject
	{
		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600E6F2 RID: 59122 RVA: 0x0034D2AD File Offset: 0x0034B4AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6F3 RID: 59123 RVA: 0x0034D2BA File Offset: 0x0034B4BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6F4 RID: 59124 RVA: 0x0034D2C4 File Offset: 0x0034B4C4
		public static SubtitleText GetRootAsSubtitleText(ByteBuffer _bb)
		{
			return SubtitleText.GetRootAsSubtitleText(_bb, default(SubtitleText));
		}

		// Token: 0x0600E6F5 RID: 59125 RVA: 0x0034D2E0 File Offset: 0x0034B4E0
		public static SubtitleText GetRootAsSubtitleText(ByteBuffer _bb, SubtitleText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6F6 RID: 59126 RVA: 0x0034D2FD File Offset: 0x0034B4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6F7 RID: 59127 RVA: 0x0034D30C File Offset: 0x0034B50C
		public SubtitleText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x0034D31C File Offset: 0x0034B51C
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

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0600E6F9 RID: 59129 RVA: 0x0034D358 File Offset: 0x0034B558
		public int RowName
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

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0600E6FA RID: 59130 RVA: 0x0034D394 File Offset: 0x0034B594
		public string DatatableName
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

		// Token: 0x0600E6FB RID: 59131 RVA: 0x0034D3CB File Offset: 0x0034B5CB
		public Span<byte> GetDatatableNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E6FC RID: 59132 RVA: 0x0034D3DA File Offset: 0x0034B5DA
		public byte[] GetDatatableNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0600E6FD RID: 59133 RVA: 0x0034D3F4 File Offset: 0x0034B5F4
		public int CharacterName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x0034D434 File Offset: 0x0034B634
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0600E6FF RID: 59135 RVA: 0x0034D474 File Offset: 0x0034B674
		public int Subtitles1
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0600E700 RID: 59136 RVA: 0x0034D4B4 File Offset: 0x0034B6B4
		public int Subtitles2
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600E701 RID: 59137 RVA: 0x0034D4F4 File Offset: 0x0034B6F4
		public int Subtitles3
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600E702 RID: 59138 RVA: 0x0034D534 File Offset: 0x0034B734
		public int Subtitles4
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600E703 RID: 59139 RVA: 0x0034D574 File Offset: 0x0034B774
		public int Subtitles5
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0600E704 RID: 59140 RVA: 0x0034D5B4 File Offset: 0x0034B7B4
		public int Option1
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x0600E705 RID: 59141 RVA: 0x0034D5F4 File Offset: 0x0034B7F4
		public int Option2
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0600E706 RID: 59142 RVA: 0x0034D634 File Offset: 0x0034B834
		public int Option3
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0600E707 RID: 59143 RVA: 0x0034D674 File Offset: 0x0034B874
		public int Option4
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0600E708 RID: 59144 RVA: 0x0034D6B4 File Offset: 0x0034B8B4
		public int Option5
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0600E709 RID: 59145 RVA: 0x0034D6F4 File Offset: 0x0034B8F4
		public string Audio1
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E70A RID: 59146 RVA: 0x0034D72C File Offset: 0x0034B92C
		public Span<byte> GetAudio1Bytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600E70B RID: 59147 RVA: 0x0034D73C File Offset: 0x0034B93C
		public byte[] GetAudio1Array()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600E70C RID: 59148 RVA: 0x0034D754 File Offset: 0x0034B954
		public string Audio2
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E70D RID: 59149 RVA: 0x0034D78C File Offset: 0x0034B98C
		public Span<byte> GetAudio2Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600E70E RID: 59150 RVA: 0x0034D79C File Offset: 0x0034B99C
		public byte[] GetAudio2Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600E70F RID: 59151 RVA: 0x0034D7B4 File Offset: 0x0034B9B4
		public string Audio3
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E710 RID: 59152 RVA: 0x0034D7EC File Offset: 0x0034B9EC
		public Span<byte> GetAudio3Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600E711 RID: 59153 RVA: 0x0034D7FC File Offset: 0x0034B9FC
		public byte[] GetAudio3Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600E712 RID: 59154 RVA: 0x0034D814 File Offset: 0x0034BA14
		public string Audio4
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E713 RID: 59155 RVA: 0x0034D84C File Offset: 0x0034BA4C
		public Span<byte> GetAudio4Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600E714 RID: 59156 RVA: 0x0034D85C File Offset: 0x0034BA5C
		public byte[] GetAudio4Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600E715 RID: 59157 RVA: 0x0034D874 File Offset: 0x0034BA74
		public string Audio5
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E716 RID: 59158 RVA: 0x0034D8AC File Offset: 0x0034BAAC
		public Span<byte> GetAudio5Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x0034D8BC File Offset: 0x0034BABC
		public byte[] GetAudio5Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0600E718 RID: 59160 RVA: 0x0034D8D4 File Offset: 0x0034BAD4
		public string OSList
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x0034D90C File Offset: 0x0034BB0C
		public Span<byte> GetOSListBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x0034D91C File Offset: 0x0034BB1C
		public byte[] GetOSListArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0400586C RID: 22636
		private Table __p;
	}
}
