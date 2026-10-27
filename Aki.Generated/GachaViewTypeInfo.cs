using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE6 RID: 3302
	public struct GachaViewTypeInfo : IFlatbufferObject
	{
		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x060078AB RID: 30891 RVA: 0x002470D1 File Offset: 0x002452D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x002470DE File Offset: 0x002452DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x002470E8 File Offset: 0x002452E8
		public static GachaViewTypeInfo GetRootAsGachaViewTypeInfo(ByteBuffer _bb)
		{
			return GachaViewTypeInfo.GetRootAsGachaViewTypeInfo(_bb, default(GachaViewTypeInfo));
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x00247104 File Offset: 0x00245304
		public static GachaViewTypeInfo GetRootAsGachaViewTypeInfo(ByteBuffer _bb, GachaViewTypeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00247121 File Offset: 0x00245321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00247130 File Offset: 0x00245330
		public GachaViewTypeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x00247140 File Offset: 0x00245340
		public int Type
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

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x060078B2 RID: 30898 RVA: 0x0024717C File Offset: 0x0024537C
		public string TagText
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

		// Token: 0x060078B3 RID: 30899 RVA: 0x002471B3 File Offset: 0x002453B3
		public Span<byte> GetTagTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x002471C2 File Offset: 0x002453C2
		public byte[] GetTagTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x060078B5 RID: 30901 RVA: 0x002471DC File Offset: 0x002453DC
		public string TagColor
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

		// Token: 0x060078B6 RID: 30902 RVA: 0x00247213 File Offset: 0x00245413
		public Span<byte> GetTagColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x00247222 File Offset: 0x00245422
		public byte[] GetTagColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x060078B8 RID: 30904 RVA: 0x0024723C File Offset: 0x0024543C
		public string TypeText
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

		// Token: 0x060078B9 RID: 30905 RVA: 0x00247274 File Offset: 0x00245474
		public Span<byte> GetTypeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00247284 File Offset: 0x00245484
		public byte[] GetTypeTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x060078BB RID: 30907 RVA: 0x0024729C File Offset: 0x0024549C
		public string OptionalTitle
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

		// Token: 0x060078BC RID: 30908 RVA: 0x002472D4 File Offset: 0x002454D4
		public Span<byte> GetOptionalTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x002472E4 File Offset: 0x002454E4
		public byte[] GetOptionalTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x060078BE RID: 30910 RVA: 0x002472FC File Offset: 0x002454FC
		public string OptionalDesc
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

		// Token: 0x060078BF RID: 30911 RVA: 0x00247334 File Offset: 0x00245534
		public Span<byte> GetOptionalDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x00247344 File Offset: 0x00245544
		public byte[] GetOptionalDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x060078C1 RID: 30913 RVA: 0x0024735C File Offset: 0x0024555C
		public string GachaButtonTip
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

		// Token: 0x060078C2 RID: 30914 RVA: 0x00247394 File Offset: 0x00245594
		public Span<byte> GetGachaButtonTipBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x002473A4 File Offset: 0x002455A4
		public byte[] GetGachaButtonTipArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060078C4 RID: 30916 RVA: 0x002473BC File Offset: 0x002455BC
		public string GachaLimitTip
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

		// Token: 0x060078C5 RID: 30917 RVA: 0x002473F4 File Offset: 0x002455F4
		public Span<byte> GetGachaLimitTipBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060078C6 RID: 30918 RVA: 0x00247404 File Offset: 0x00245604
		public byte[] GetGachaLimitTipArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060078C7 RID: 30919 RVA: 0x0024741C File Offset: 0x0024561C
		public bool WeaponUseGachaAnim
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004D57 RID: 19799
		private Table __p;
	}
}
