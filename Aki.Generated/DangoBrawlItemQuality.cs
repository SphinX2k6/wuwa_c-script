using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA5 RID: 3237
	public struct DangoBrawlItemQuality : IFlatbufferObject
	{
		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060063C2 RID: 25538 RVA: 0x00229ABE File Offset: 0x00227CBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x00229ACB File Offset: 0x00227CCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00229AD4 File Offset: 0x00227CD4
		public static DangoBrawlItemQuality GetRootAsDangoBrawlItemQuality(ByteBuffer _bb)
		{
			return DangoBrawlItemQuality.GetRootAsDangoBrawlItemQuality(_bb, default(DangoBrawlItemQuality));
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00229AF0 File Offset: 0x00227CF0
		public static DangoBrawlItemQuality GetRootAsDangoBrawlItemQuality(ByteBuffer _bb, DangoBrawlItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00229B0D File Offset: 0x00227D0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00229B1C File Offset: 0x00227D1C
		public DangoBrawlItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060063C8 RID: 25544 RVA: 0x00229B2C File Offset: 0x00227D2C
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

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060063C9 RID: 25545 RVA: 0x00229B68 File Offset: 0x00227D68
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

		// Token: 0x060063CA RID: 25546 RVA: 0x00229B9F File Offset: 0x00227D9F
		public Span<byte> GetHandBookItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x00229BAE File Offset: 0x00227DAE
		public byte[] GetHandBookItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x00229BC8 File Offset: 0x00227DC8
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

		// Token: 0x060063CD RID: 25549 RVA: 0x00229BFF File Offset: 0x00227DFF
		public Span<byte> GetHandBookSmallItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00229C0E File Offset: 0x00227E0E
		public byte[] GetHandBookSmallItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060063CF RID: 25551 RVA: 0x00229C28 File Offset: 0x00227E28
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

		// Token: 0x060063D0 RID: 25552 RVA: 0x00229C60 File Offset: 0x00227E60
		public Span<byte> GetHandBookBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x00229C70 File Offset: 0x00227E70
		public byte[] GetHandBookBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060063D2 RID: 25554 RVA: 0x00229C88 File Offset: 0x00227E88
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

		// Token: 0x060063D3 RID: 25555 RVA: 0x00229CC0 File Offset: 0x00227EC0
		public Span<byte> GetTipsBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x00229CD0 File Offset: 0x00227ED0
		public byte[] GetTipsBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060063D5 RID: 25557 RVA: 0x00229CE8 File Offset: 0x00227EE8
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

		// Token: 0x060063D6 RID: 25558 RVA: 0x00229D20 File Offset: 0x00227F20
		public Span<byte> GetShopItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00229D30 File Offset: 0x00227F30
		public byte[] GetShopItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x00229D48 File Offset: 0x00227F48
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

		// Token: 0x060063D9 RID: 25561 RVA: 0x00229D80 File Offset: 0x00227F80
		public Span<byte> GetCombineBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x00229D90 File Offset: 0x00227F90
		public byte[] GetCombineBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060063DB RID: 25563 RVA: 0x00229DA8 File Offset: 0x00227FA8
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

		// Token: 0x060063DC RID: 25564 RVA: 0x00229DE0 File Offset: 0x00227FE0
		public Span<byte> GetCombineAchievementBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x00229DF0 File Offset: 0x00227FF0
		public byte[] GetCombineAchievementBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x00229E08 File Offset: 0x00228008
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

		// Token: 0x060063DF RID: 25567 RVA: 0x00229E40 File Offset: 0x00228040
		public Span<byte> GetShopBackgroundColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00229E50 File Offset: 0x00228050
		public byte[] GetShopBackgroundColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060063E1 RID: 25569 RVA: 0x00229E68 File Offset: 0x00228068
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

		// Token: 0x060063E2 RID: 25570 RVA: 0x00229EA0 File Offset: 0x002280A0
		public Span<byte> GetUINiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x00229EB0 File Offset: 0x002280B0
		public byte[] GetUINiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x00229EC8 File Offset: 0x002280C8
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060063E5 RID: 25573 RVA: 0x00229F08 File Offset: 0x00228108
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

		// Token: 0x060063E6 RID: 25574 RVA: 0x00229F40 File Offset: 0x00228140
		public Span<byte> GetUINiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00229F50 File Offset: 0x00228150
		public byte[] GetUINiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x040051CE RID: 20942
		private Table __p;
	}
}
