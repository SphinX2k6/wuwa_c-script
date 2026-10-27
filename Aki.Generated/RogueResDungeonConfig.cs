using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFA RID: 4090
	public struct RogueResDungeonConfig : IFlatbufferObject
	{
		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600C19C RID: 49564 RVA: 0x002EAC5D File Offset: 0x002E8E5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x002EAC6A File Offset: 0x002E8E6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C19E RID: 49566 RVA: 0x002EAC74 File Offset: 0x002E8E74
		public static RogueResDungeonConfig GetRootAsRogueResDungeonConfig(ByteBuffer _bb)
		{
			return RogueResDungeonConfig.GetRootAsRogueResDungeonConfig(_bb, default(RogueResDungeonConfig));
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x002EAC90 File Offset: 0x002E8E90
		public static RogueResDungeonConfig GetRootAsRogueResDungeonConfig(ByteBuffer _bb, RogueResDungeonConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x002EACAD File Offset: 0x002E8EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x002EACBC File Offset: 0x002E8EBC
		public RogueResDungeonConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0600C1A2 RID: 49570 RVA: 0x002EACCC File Offset: 0x002E8ECC
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

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x0600C1A3 RID: 49571 RVA: 0x002EAD08 File Offset: 0x002E8F08
		public int SeasonId
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

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600C1A4 RID: 49572 RVA: 0x002EAD44 File Offset: 0x002E8F44
		public string IconF
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

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x002EAD7B File Offset: 0x002E8F7B
		public Span<byte> GetIconFBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C1A6 RID: 49574 RVA: 0x002EAD8A File Offset: 0x002E8F8A
		public byte[] GetIconFArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x002EADA4 File Offset: 0x002E8FA4
		public string IconM
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

		// Token: 0x0600C1A8 RID: 49576 RVA: 0x002EADDC File Offset: 0x002E8FDC
		public Span<byte> GetIconMBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x002EADEC File Offset: 0x002E8FEC
		public byte[] GetIconMArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0600C1AA RID: 49578 RVA: 0x002EAE04 File Offset: 0x002E9004
		public string CoverF
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

		// Token: 0x0600C1AB RID: 49579 RVA: 0x002EAE3C File Offset: 0x002E903C
		public Span<byte> GetCoverFBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C1AC RID: 49580 RVA: 0x002EAE4C File Offset: 0x002E904C
		public byte[] GetCoverFArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0600C1AD RID: 49581 RVA: 0x002EAE64 File Offset: 0x002E9064
		public string CoverM
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

		// Token: 0x0600C1AE RID: 49582 RVA: 0x002EAE9C File Offset: 0x002E909C
		public Span<byte> GetCoverMBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C1AF RID: 49583 RVA: 0x002EAEAC File Offset: 0x002E90AC
		public byte[] GetCoverMArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0600C1B0 RID: 49584 RVA: 0x002EAEC4 File Offset: 0x002E90C4
		public string SpineAtlasF
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

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x002EAEFC File Offset: 0x002E90FC
		public Span<byte> GetSpineAtlasFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C1B2 RID: 49586 RVA: 0x002EAF0C File Offset: 0x002E910C
		public byte[] GetSpineAtlasFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x0600C1B3 RID: 49587 RVA: 0x002EAF24 File Offset: 0x002E9124
		public string SpineMainF
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

		// Token: 0x0600C1B4 RID: 49588 RVA: 0x002EAF5C File Offset: 0x002E915C
		public Span<byte> GetSpineMainFBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x002EAF6C File Offset: 0x002E916C
		public byte[] GetSpineMainFArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x0600C1B6 RID: 49590 RVA: 0x002EAF84 File Offset: 0x002E9184
		public string Title
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

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x002EAFBC File Offset: 0x002E91BC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C1B8 RID: 49592 RVA: 0x002EAFCC File Offset: 0x002E91CC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x0600C1B9 RID: 49593 RVA: 0x002EAFE4 File Offset: 0x002E91E4
		public string Desc
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

		// Token: 0x0600C1BA RID: 49594 RVA: 0x002EB01C File Offset: 0x002E921C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x002EB02C File Offset: 0x002E922C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x0600C1BC RID: 49596 RVA: 0x002EB044 File Offset: 0x002E9244
		public int RecommendLevel
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

		// Token: 0x040050E2 RID: 20706
		private Table __p;
	}
}
