using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA1 RID: 3745
	public struct LangImageResource : IFlatbufferObject
	{
		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x060092E4 RID: 37604 RVA: 0x002937E2 File Offset: 0x002919E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060092E5 RID: 37605 RVA: 0x002937EF File Offset: 0x002919EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x002937F8 File Offset: 0x002919F8
		public static LangImageResource GetRootAsLangImageResource(ByteBuffer _bb)
		{
			return LangImageResource.GetRootAsLangImageResource(_bb, default(LangImageResource));
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x00293814 File Offset: 0x00291A14
		public static LangImageResource GetRootAsLangImageResource(ByteBuffer _bb, LangImageResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060092E8 RID: 37608 RVA: 0x00293831 File Offset: 0x00291A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060092E9 RID: 37609 RVA: 0x00293840 File Offset: 0x00291A40
		public LangImageResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x060092EA RID: 37610 RVA: 0x00293850 File Offset: 0x00291A50
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

		// Token: 0x060092EB RID: 37611 RVA: 0x00293887 File Offset: 0x00291A87
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x00293896 File Offset: 0x00291A96
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x060092ED RID: 37613 RVA: 0x002938B0 File Offset: 0x00291AB0
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

		// Token: 0x060092EE RID: 37614 RVA: 0x002938E7 File Offset: 0x00291AE7
		public Span<byte> GetZhHansBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x002938F6 File Offset: 0x00291AF6
		public byte[] GetZhHansArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x060092F0 RID: 37616 RVA: 0x00293910 File Offset: 0x00291B10
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

		// Token: 0x060092F1 RID: 37617 RVA: 0x00293947 File Offset: 0x00291B47
		public Span<byte> GetEnBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x00293956 File Offset: 0x00291B56
		public byte[] GetEnArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x060092F3 RID: 37619 RVA: 0x00293970 File Offset: 0x00291B70
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

		// Token: 0x060092F4 RID: 37620 RVA: 0x002939A8 File Offset: 0x00291BA8
		public Span<byte> GetJaBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060092F5 RID: 37621 RVA: 0x002939B8 File Offset: 0x00291BB8
		public byte[] GetJaArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x060092F6 RID: 37622 RVA: 0x002939D0 File Offset: 0x00291BD0
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

		// Token: 0x060092F7 RID: 37623 RVA: 0x00293A08 File Offset: 0x00291C08
		public Span<byte> GetKoBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060092F8 RID: 37624 RVA: 0x00293A18 File Offset: 0x00291C18
		public byte[] GetKoArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x060092F9 RID: 37625 RVA: 0x00293A30 File Offset: 0x00291C30
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

		// Token: 0x060092FA RID: 37626 RVA: 0x00293A68 File Offset: 0x00291C68
		public Span<byte> GetRuBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x00293A78 File Offset: 0x00291C78
		public byte[] GetRuArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x00293A90 File Offset: 0x00291C90
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

		// Token: 0x060092FD RID: 37629 RVA: 0x00293AC8 File Offset: 0x00291CC8
		public Span<byte> GetZhHantBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060092FE RID: 37630 RVA: 0x00293AD8 File Offset: 0x00291CD8
		public byte[] GetZhHantArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x00293AF0 File Offset: 0x00291CF0
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

		// Token: 0x06009300 RID: 37632 RVA: 0x00293B28 File Offset: 0x00291D28
		public Span<byte> GetDeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x00293B38 File Offset: 0x00291D38
		public byte[] GetDeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06009302 RID: 37634 RVA: 0x00293B50 File Offset: 0x00291D50
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

		// Token: 0x06009303 RID: 37635 RVA: 0x00293B88 File Offset: 0x00291D88
		public Span<byte> GetEsBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009304 RID: 37636 RVA: 0x00293B98 File Offset: 0x00291D98
		public byte[] GetEsArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06009305 RID: 37637 RVA: 0x00293BB0 File Offset: 0x00291DB0
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

		// Token: 0x06009306 RID: 37638 RVA: 0x00293BE8 File Offset: 0x00291DE8
		public Span<byte> GetPtBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x00293BF8 File Offset: 0x00291DF8
		public byte[] GetPtArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06009308 RID: 37640 RVA: 0x00293C10 File Offset: 0x00291E10
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

		// Token: 0x06009309 RID: 37641 RVA: 0x00293C48 File Offset: 0x00291E48
		public Span<byte> GetIdnBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x00293C58 File Offset: 0x00291E58
		public byte[] GetIdnArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x0600930B RID: 37643 RVA: 0x00293C70 File Offset: 0x00291E70
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

		// Token: 0x0600930C RID: 37644 RVA: 0x00293CA8 File Offset: 0x00291EA8
		public Span<byte> GetFrBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x00293CB8 File Offset: 0x00291EB8
		public byte[] GetFrArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x0600930E RID: 37646 RVA: 0x00293CD0 File Offset: 0x00291ED0
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

		// Token: 0x0600930F RID: 37647 RVA: 0x00293D08 File Offset: 0x00291F08
		public Span<byte> GetViBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009310 RID: 37648 RVA: 0x00293D18 File Offset: 0x00291F18
		public byte[] GetViArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06009311 RID: 37649 RVA: 0x00293D30 File Offset: 0x00291F30
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

		// Token: 0x06009312 RID: 37650 RVA: 0x00293D68 File Offset: 0x00291F68
		public Span<byte> GetThBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009313 RID: 37651 RVA: 0x00293D78 File Offset: 0x00291F78
		public byte[] GetThArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x04005437 RID: 21559
		private Table __p;
	}
}
