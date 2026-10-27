using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBC RID: 3516
	public struct LangImageResource : IFlatbufferObject
	{
		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06008CC8 RID: 36040 RVA: 0x002750C9 File Offset: 0x002732C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x002750D6 File Offset: 0x002732D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x002750E0 File Offset: 0x002732E0
		public static LangImageResource GetRootAsLangImageResource(ByteBuffer _bb)
		{
			return LangImageResource.GetRootAsLangImageResource(_bb, default(LangImageResource));
		}

		// Token: 0x06008CCB RID: 36043 RVA: 0x002750FC File Offset: 0x002732FC
		public static LangImageResource GetRootAsLangImageResource(ByteBuffer _bb, LangImageResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x00275119 File Offset: 0x00273319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x00275128 File Offset: 0x00273328
		public LangImageResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06008CCE RID: 36046 RVA: 0x00275138 File Offset: 0x00273338
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008CCF RID: 36047 RVA: 0x0027516F File Offset: 0x0027336F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x0027517E File Offset: 0x0027337E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06008CD1 RID: 36049 RVA: 0x00275198 File Offset: 0x00273398
		public string ZhHans
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

		// Token: 0x06008CD2 RID: 36050 RVA: 0x002751CF File Offset: 0x002733CF
		public Span<byte> GetZhHansBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008CD3 RID: 36051 RVA: 0x002751DE File Offset: 0x002733DE
		public byte[] GetZhHansArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06008CD4 RID: 36052 RVA: 0x002751F8 File Offset: 0x002733F8
		public string En
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

		// Token: 0x06008CD5 RID: 36053 RVA: 0x0027522F File Offset: 0x0027342F
		public Span<byte> GetEnBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x0027523E File Offset: 0x0027343E
		public byte[] GetEnArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x00275258 File Offset: 0x00273458
		public string Ja
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

		// Token: 0x06008CD8 RID: 36056 RVA: 0x00275290 File Offset: 0x00273490
		public Span<byte> GetJaBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008CD9 RID: 36057 RVA: 0x002752A0 File Offset: 0x002734A0
		public byte[] GetJaArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06008CDA RID: 36058 RVA: 0x002752B8 File Offset: 0x002734B8
		public string Ko
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

		// Token: 0x06008CDB RID: 36059 RVA: 0x002752F0 File Offset: 0x002734F0
		public Span<byte> GetKoBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008CDC RID: 36060 RVA: 0x00275300 File Offset: 0x00273500
		public byte[] GetKoArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x00275318 File Offset: 0x00273518
		public string Ru
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

		// Token: 0x06008CDE RID: 36062 RVA: 0x00275350 File Offset: 0x00273550
		public Span<byte> GetRuBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008CDF RID: 36063 RVA: 0x00275360 File Offset: 0x00273560
		public byte[] GetRuArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06008CE0 RID: 36064 RVA: 0x00275378 File Offset: 0x00273578
		public string ZhHant
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

		// Token: 0x06008CE1 RID: 36065 RVA: 0x002753B0 File Offset: 0x002735B0
		public Span<byte> GetZhHantBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008CE2 RID: 36066 RVA: 0x002753C0 File Offset: 0x002735C0
		public byte[] GetZhHantArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x002753D8 File Offset: 0x002735D8
		public string De
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

		// Token: 0x06008CE4 RID: 36068 RVA: 0x00275410 File Offset: 0x00273610
		public Span<byte> GetDeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x00275420 File Offset: 0x00273620
		public byte[] GetDeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06008CE6 RID: 36070 RVA: 0x00275438 File Offset: 0x00273638
		public string Es
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

		// Token: 0x06008CE7 RID: 36071 RVA: 0x00275470 File Offset: 0x00273670
		public Span<byte> GetEsBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x00275480 File Offset: 0x00273680
		public byte[] GetEsArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x00275498 File Offset: 0x00273698
		public string Pt
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

		// Token: 0x06008CEA RID: 36074 RVA: 0x002754D0 File Offset: 0x002736D0
		public Span<byte> GetPtBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x002754E0 File Offset: 0x002736E0
		public byte[] GetPtArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06008CEC RID: 36076 RVA: 0x002754F8 File Offset: 0x002736F8
		public string Idn
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x00275530 File Offset: 0x00273730
		public Span<byte> GetIdnBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x00275540 File Offset: 0x00273740
		public byte[] GetIdnArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06008CEF RID: 36079 RVA: 0x00275558 File Offset: 0x00273758
		public string Fr
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

		// Token: 0x06008CF0 RID: 36080 RVA: 0x00275590 File Offset: 0x00273790
		public Span<byte> GetFrBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x002755A0 File Offset: 0x002737A0
		public byte[] GetFrArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06008CF2 RID: 36082 RVA: 0x002755B8 File Offset: 0x002737B8
		public string Vi
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x002755F0 File Offset: 0x002737F0
		public Span<byte> GetViBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x00275600 File Offset: 0x00273800
		public byte[] GetViArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x00275618 File Offset: 0x00273818
		public string Th
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x00275650 File Offset: 0x00273850
		public Span<byte> GetThBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x00275660 File Offset: 0x00273860
		public byte[] GetThArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E52 RID: 20050
		private Table __p;
	}
}
