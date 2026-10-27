using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001128 RID: 4392
	public struct TetrisShape : IFlatbufferObject
	{
		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x0032D05D File Offset: 0x0032B25D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE70 RID: 56944 RVA: 0x0032D06A File Offset: 0x0032B26A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE71 RID: 56945 RVA: 0x0032D074 File Offset: 0x0032B274
		public static TetrisShape GetRootAsTetrisShape(ByteBuffer _bb)
		{
			return TetrisShape.GetRootAsTetrisShape(_bb, default(TetrisShape));
		}

		// Token: 0x0600DE72 RID: 56946 RVA: 0x0032D090 File Offset: 0x0032B290
		public static TetrisShape GetRootAsTetrisShape(ByteBuffer _bb, TetrisShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE73 RID: 56947 RVA: 0x0032D0AD File Offset: 0x0032B2AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE74 RID: 56948 RVA: 0x0032D0BC File Offset: 0x0032B2BC
		public TetrisShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600DE75 RID: 56949 RVA: 0x0032D0CC File Offset: 0x0032B2CC
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

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600DE76 RID: 56950 RVA: 0x0032D108 File Offset: 0x0032B308
		public string Column1
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

		// Token: 0x0600DE77 RID: 56951 RVA: 0x0032D13F File Offset: 0x0032B33F
		public Span<byte> GetColumn1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DE78 RID: 56952 RVA: 0x0032D14E File Offset: 0x0032B34E
		public byte[] GetColumn1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x0032D168 File Offset: 0x0032B368
		public string Column2
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

		// Token: 0x0600DE7A RID: 56954 RVA: 0x0032D19F File Offset: 0x0032B39F
		public Span<byte> GetColumn2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DE7B RID: 56955 RVA: 0x0032D1AE File Offset: 0x0032B3AE
		public byte[] GetColumn2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x0032D1C8 File Offset: 0x0032B3C8
		public string Column3
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

		// Token: 0x0600DE7D RID: 56957 RVA: 0x0032D200 File Offset: 0x0032B400
		public Span<byte> GetColumn3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DE7E RID: 56958 RVA: 0x0032D210 File Offset: 0x0032B410
		public byte[] GetColumn3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0600DE7F RID: 56959 RVA: 0x0032D228 File Offset: 0x0032B428
		public string Column4
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

		// Token: 0x0600DE80 RID: 56960 RVA: 0x0032D260 File Offset: 0x0032B460
		public Span<byte> GetColumn4Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DE81 RID: 56961 RVA: 0x0032D270 File Offset: 0x0032B470
		public byte[] GetColumn4Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0600DE82 RID: 56962 RVA: 0x0032D288 File Offset: 0x0032B488
		public string Column5
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

		// Token: 0x0600DE83 RID: 56963 RVA: 0x0032D2C0 File Offset: 0x0032B4C0
		public Span<byte> GetColumn5Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DE84 RID: 56964 RVA: 0x0032D2D0 File Offset: 0x0032B4D0
		public byte[] GetColumn5Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x0600DE85 RID: 56965 RVA: 0x0032D2E8 File Offset: 0x0032B4E8
		public int Weight
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

		// Token: 0x04005266 RID: 21094
		private Table __p;
	}
}
