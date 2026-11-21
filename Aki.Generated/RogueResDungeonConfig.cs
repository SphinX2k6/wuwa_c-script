using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E2 RID: 4322
	public struct RogueResDungeonConfig : IFlatbufferObject
	{
		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x0600C7E6 RID: 51174 RVA: 0x00306EA6 File Offset: 0x003050A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C7E7 RID: 51175 RVA: 0x00306EB3 File Offset: 0x003050B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x00306EBC File Offset: 0x003050BC
		public static RogueResDungeonConfig GetRootAsRogueResDungeonConfig(ByteBuffer _bb)
		{
			return RogueResDungeonConfig.GetRootAsRogueResDungeonConfig(_bb, default(RogueResDungeonConfig));
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x00306ED8 File Offset: 0x003050D8
		public static RogueResDungeonConfig GetRootAsRogueResDungeonConfig(ByteBuffer _bb, RogueResDungeonConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x00306EF5 File Offset: 0x003050F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7EB RID: 51179 RVA: 0x00306F04 File Offset: 0x00305104
		public RogueResDungeonConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x0600C7EC RID: 51180 RVA: 0x00306F14 File Offset: 0x00305114
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

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x0600C7ED RID: 51181 RVA: 0x00306F50 File Offset: 0x00305150
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

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x0600C7EE RID: 51182 RVA: 0x00306F8C File Offset: 0x0030518C
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

		// Token: 0x0600C7EF RID: 51183 RVA: 0x00306FC3 File Offset: 0x003051C3
		public Span<byte> GetIconFBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C7F0 RID: 51184 RVA: 0x00306FD2 File Offset: 0x003051D2
		public byte[] GetIconFArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0600C7F1 RID: 51185 RVA: 0x00306FEC File Offset: 0x003051EC
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

		// Token: 0x0600C7F2 RID: 51186 RVA: 0x00307024 File Offset: 0x00305224
		public Span<byte> GetIconMBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C7F3 RID: 51187 RVA: 0x00307034 File Offset: 0x00305234
		public byte[] GetIconMArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x0030704C File Offset: 0x0030524C
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

		// Token: 0x0600C7F5 RID: 51189 RVA: 0x00307084 File Offset: 0x00305284
		public Span<byte> GetCoverFBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C7F6 RID: 51190 RVA: 0x00307094 File Offset: 0x00305294
		public byte[] GetCoverFArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x0600C7F7 RID: 51191 RVA: 0x003070AC File Offset: 0x003052AC
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

		// Token: 0x0600C7F8 RID: 51192 RVA: 0x003070E4 File Offset: 0x003052E4
		public Span<byte> GetCoverMBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C7F9 RID: 51193 RVA: 0x003070F4 File Offset: 0x003052F4
		public byte[] GetCoverMArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0600C7FA RID: 51194 RVA: 0x0030710C File Offset: 0x0030530C
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

		// Token: 0x0600C7FB RID: 51195 RVA: 0x00307144 File Offset: 0x00305344
		public Span<byte> GetSpineAtlasFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C7FC RID: 51196 RVA: 0x00307154 File Offset: 0x00305354
		public byte[] GetSpineAtlasFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0600C7FD RID: 51197 RVA: 0x0030716C File Offset: 0x0030536C
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

		// Token: 0x0600C7FE RID: 51198 RVA: 0x003071A4 File Offset: 0x003053A4
		public Span<byte> GetSpineMainFBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C7FF RID: 51199 RVA: 0x003071B4 File Offset: 0x003053B4
		public byte[] GetSpineMainFArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0600C800 RID: 51200 RVA: 0x003071CC File Offset: 0x003053CC
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

		// Token: 0x0600C801 RID: 51201 RVA: 0x00307204 File Offset: 0x00305404
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C802 RID: 51202 RVA: 0x00307214 File Offset: 0x00305414
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0600C803 RID: 51203 RVA: 0x0030722C File Offset: 0x0030542C
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

		// Token: 0x0600C804 RID: 51204 RVA: 0x00307264 File Offset: 0x00305464
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C805 RID: 51205 RVA: 0x00307274 File Offset: 0x00305474
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0600C806 RID: 51206 RVA: 0x0030728C File Offset: 0x0030548C
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

		// Token: 0x040056CA RID: 22218
		private Table __p;
	}
}
