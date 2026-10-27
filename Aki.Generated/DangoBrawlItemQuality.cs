using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC3 RID: 3011
	public struct DangoBrawlItemQuality : IFlatbufferObject
	{
		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x0020A309 File Offset: 0x00208509
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x0020A316 File Offset: 0x00208516
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x0020A320 File Offset: 0x00208520
		public static DangoBrawlItemQuality GetRootAsDangoBrawlItemQuality(ByteBuffer _bb)
		{
			return DangoBrawlItemQuality.GetRootAsDangoBrawlItemQuality(_bb, default(DangoBrawlItemQuality));
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x0020A33C File Offset: 0x0020853C
		public static DangoBrawlItemQuality GetRootAsDangoBrawlItemQuality(ByteBuffer _bb, DangoBrawlItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x0020A359 File Offset: 0x00208559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x0020A368 File Offset: 0x00208568
		public DangoBrawlItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x0020A378 File Offset: 0x00208578
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

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x0020A3B4 File Offset: 0x002085B4
		public string HandBookItemIcon
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

		// Token: 0x06005DF1 RID: 24049 RVA: 0x0020A3EB File Offset: 0x002085EB
		public Span<byte> GetHandBookItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x0020A3FA File Offset: 0x002085FA
		public byte[] GetHandBookItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06005DF3 RID: 24051 RVA: 0x0020A414 File Offset: 0x00208614
		public string HandBookSmallItemIcon
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

		// Token: 0x06005DF4 RID: 24052 RVA: 0x0020A44B File Offset: 0x0020864B
		public Span<byte> GetHandBookSmallItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x0020A45A File Offset: 0x0020865A
		public byte[] GetHandBookSmallItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x0020A474 File Offset: 0x00208674
		public string HandBookBgIcon
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

		// Token: 0x06005DF7 RID: 24055 RVA: 0x0020A4AC File Offset: 0x002086AC
		public Span<byte> GetHandBookBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x0020A4BC File Offset: 0x002086BC
		public byte[] GetHandBookBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06005DF9 RID: 24057 RVA: 0x0020A4D4 File Offset: 0x002086D4
		public string TipsBgIcon
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

		// Token: 0x06005DFA RID: 24058 RVA: 0x0020A50C File Offset: 0x0020870C
		public Span<byte> GetTipsBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x0020A51C File Offset: 0x0020871C
		public byte[] GetTipsBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06005DFC RID: 24060 RVA: 0x0020A534 File Offset: 0x00208734
		public string ShopItemIcon
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

		// Token: 0x06005DFD RID: 24061 RVA: 0x0020A56C File Offset: 0x0020876C
		public Span<byte> GetShopItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x0020A57C File Offset: 0x0020877C
		public byte[] GetShopItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06005DFF RID: 24063 RVA: 0x0020A594 File Offset: 0x00208794
		public string CombineBgIcon
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

		// Token: 0x06005E00 RID: 24064 RVA: 0x0020A5CC File Offset: 0x002087CC
		public Span<byte> GetCombineBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x0020A5DC File Offset: 0x002087DC
		public byte[] GetCombineBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06005E02 RID: 24066 RVA: 0x0020A5F4 File Offset: 0x002087F4
		public string CombineAchievementBgIcon
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

		// Token: 0x06005E03 RID: 24067 RVA: 0x0020A62C File Offset: 0x0020882C
		public Span<byte> GetCombineAchievementBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x0020A63C File Offset: 0x0020883C
		public byte[] GetCombineAchievementBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x0020A654 File Offset: 0x00208854
		public string ShopBackgroundColor
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

		// Token: 0x06005E06 RID: 24070 RVA: 0x0020A68C File Offset: 0x0020888C
		public Span<byte> GetShopBackgroundColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x0020A69C File Offset: 0x0020889C
		public byte[] GetShopBackgroundColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06005E08 RID: 24072 RVA: 0x0020A6B4 File Offset: 0x002088B4
		public string UINiagaraPath
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

		// Token: 0x06005E09 RID: 24073 RVA: 0x0020A6EC File Offset: 0x002088EC
		public Span<byte> GetUINiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x0020A6FC File Offset: 0x002088FC
		public byte[] GetUINiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06005E0B RID: 24075 RVA: 0x0020A714 File Offset: 0x00208914
		public int UINiagaraSize
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06005E0C RID: 24076 RVA: 0x0020A754 File Offset: 0x00208954
		public string UINiagaraColor
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x0020A78C File Offset: 0x0020898C
		public Span<byte> GetUINiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x0020A79C File Offset: 0x0020899C
		public byte[] GetUINiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BEC RID: 19436
		private Table __p;
	}
}
