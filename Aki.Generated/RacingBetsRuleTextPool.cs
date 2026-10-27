using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F91 RID: 3985
	public struct RacingBetsRuleTextPool : IFlatbufferObject
	{
		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x0600B8B3 RID: 47283 RVA: 0x002D6954 File Offset: 0x002D4B54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x002D6961 File Offset: 0x002D4B61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x002D6968 File Offset: 0x002D4B68
		public static RacingBetsRuleTextPool GetRootAsRacingBetsRuleTextPool(ByteBuffer _bb)
		{
			return RacingBetsRuleTextPool.GetRootAsRacingBetsRuleTextPool(_bb, default(RacingBetsRuleTextPool));
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x002D6984 File Offset: 0x002D4B84
		public static RacingBetsRuleTextPool GetRootAsRacingBetsRuleTextPool(ByteBuffer _bb, RacingBetsRuleTextPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x002D69A1 File Offset: 0x002D4BA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x002D69B0 File Offset: 0x002D4BB0
		public RacingBetsRuleTextPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x0600B8B9 RID: 47289 RVA: 0x002D69C0 File Offset: 0x002D4BC0
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

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x0600B8BA RID: 47290 RVA: 0x002D69FC File Offset: 0x002D4BFC
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

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x002D6A38 File Offset: 0x002D4C38
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

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x0600B8BC RID: 47292 RVA: 0x002D6A74 File Offset: 0x002D4C74
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

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x002D6AB4 File Offset: 0x002D4CB4
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

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x0600B8BE RID: 47294 RVA: 0x002D6AF4 File Offset: 0x002D4CF4
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

		// Token: 0x0600B8BF RID: 47295 RVA: 0x002D6B2C File Offset: 0x002D4D2C
		public Span<byte> GetRuleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x002D6B3C File Offset: 0x002D4D3C
		public byte[] GetRuleTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005061 RID: 20577
		private Table __p;
	}
}
