using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001078 RID: 4216
	public struct RacingBetsRuleTextPool : IFlatbufferObject
	{
		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0600BEF0 RID: 48880 RVA: 0x002F3204 File Offset: 0x002F1404
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x002F3211 File Offset: 0x002F1411
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BEF2 RID: 48882 RVA: 0x002F3218 File Offset: 0x002F1418
		public static RacingBetsRuleTextPool GetRootAsRacingBetsRuleTextPool(ByteBuffer _bb)
		{
			return RacingBetsRuleTextPool.GetRootAsRacingBetsRuleTextPool(_bb, default(RacingBetsRuleTextPool));
		}

		// Token: 0x0600BEF3 RID: 48883 RVA: 0x002F3234 File Offset: 0x002F1434
		public static RacingBetsRuleTextPool GetRootAsRacingBetsRuleTextPool(ByteBuffer _bb, RacingBetsRuleTextPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x002F3251 File Offset: 0x002F1451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BEF5 RID: 48885 RVA: 0x002F3260 File Offset: 0x002F1460
		public RacingBetsRuleTextPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0600BEF6 RID: 48886 RVA: 0x002F3270 File Offset: 0x002F1470
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

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0600BEF7 RID: 48887 RVA: 0x002F32AC File Offset: 0x002F14AC
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

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0600BEF8 RID: 48888 RVA: 0x002F32E8 File Offset: 0x002F14E8
		public int LegMatchId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0600BEF9 RID: 48889 RVA: 0x002F3324 File Offset: 0x002F1524
		public int MatchState
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

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0600BEFA RID: 48890 RVA: 0x002F3364 File Offset: 0x002F1564
		public int Type
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

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0600BEFB RID: 48891 RVA: 0x002F33A4 File Offset: 0x002F15A4
		public string RuleText
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

		// Token: 0x0600BEFC RID: 48892 RVA: 0x002F33DC File Offset: 0x002F15DC
		public Span<byte> GetRuleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BEFD RID: 48893 RVA: 0x002F33EC File Offset: 0x002F15EC
		public byte[] GetRuleTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005648 RID: 22088
		private Table __p;
	}
}
