using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D21 RID: 3361
	public struct H5CircumUrl : IFlatbufferObject
	{
		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x00252981 File Offset: 0x00250B81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x0025298E File Offset: 0x00250B8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x00252998 File Offset: 0x00250B98
		public static H5CircumUrl GetRootAsH5CircumUrl(ByteBuffer _bb)
		{
			return H5CircumUrl.GetRootAsH5CircumUrl(_bb, default(H5CircumUrl));
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x002529B4 File Offset: 0x00250BB4
		public static H5CircumUrl GetRootAsH5CircumUrl(ByteBuffer _bb, H5CircumUrl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x002529D1 File Offset: 0x00250BD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DCE RID: 32206 RVA: 0x002529E0 File Offset: 0x00250BE0
		public H5CircumUrl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06007DCF RID: 32207 RVA: 0x002529F0 File Offset: 0x00250BF0
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

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06007DD0 RID: 32208 RVA: 0x00252A2C File Offset: 0x00250C2C
		public string RootUrl
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

		// Token: 0x06007DD1 RID: 32209 RVA: 0x00252A63 File Offset: 0x00250C63
		public Span<byte> GetRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x00252A72 File Offset: 0x00250C72
		public byte[] GetRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06007DD3 RID: 32211 RVA: 0x00252A8C File Offset: 0x00250C8C
		public string OverseaRootUrl
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

		// Token: 0x06007DD4 RID: 32212 RVA: 0x00252AC3 File Offset: 0x00250CC3
		public Span<byte> GetOverseaRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x00252AD2 File Offset: 0x00250CD2
		public byte[] GetOverseaRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x00252AEC File Offset: 0x00250CEC
		public string Ps5RootUrl
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

		// Token: 0x06007DD7 RID: 32215 RVA: 0x00252B24 File Offset: 0x00250D24
		public Span<byte> GetPs5RootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x00252B34 File Offset: 0x00250D34
		public byte[] GetPs5RootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06007DD9 RID: 32217 RVA: 0x00252B4C File Offset: 0x00250D4C
		public bool IsInternalBrowser
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06007DDA RID: 32218 RVA: 0x00252B8C File Offset: 0x00250D8C
		public string ScoreText
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

		// Token: 0x06007DDB RID: 32219 RVA: 0x00252BC4 File Offset: 0x00250DC4
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x00252BD4 File Offset: 0x00250DD4
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06007DDD RID: 32221 RVA: 0x00252BEC File Offset: 0x00250DEC
		public string BgPath
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

		// Token: 0x06007DDE RID: 32222 RVA: 0x00252C24 File Offset: 0x00250E24
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x00252C34 File Offset: 0x00250E34
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D99 RID: 19865
		private Table __p;
	}
}
