using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107B RID: 4219
	public struct RacingBettingOdds : IFlatbufferObject
	{
		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0600BF34 RID: 48948 RVA: 0x002F3C08 File Offset: 0x002F1E08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x002F3C15 File Offset: 0x002F1E15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x002F3C1C File Offset: 0x002F1E1C
		public static RacingBettingOdds GetRootAsRacingBettingOdds(ByteBuffer _bb)
		{
			return RacingBettingOdds.GetRootAsRacingBettingOdds(_bb, default(RacingBettingOdds));
		}

		// Token: 0x0600BF37 RID: 48951 RVA: 0x002F3C38 File Offset: 0x002F1E38
		public static RacingBettingOdds GetRootAsRacingBettingOdds(ByteBuffer _bb, RacingBettingOdds obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x002F3C55 File Offset: 0x002F1E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF39 RID: 48953 RVA: 0x002F3C64 File Offset: 0x002F1E64
		public RacingBettingOdds __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600BF3A RID: 48954 RVA: 0x002F3C74 File Offset: 0x002F1E74
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

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600BF3B RID: 48955 RVA: 0x002F3CB0 File Offset: 0x002F1EB0
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

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600BF3C RID: 48956 RVA: 0x002F3CEC File Offset: 0x002F1EEC
		public int DangoId
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

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0600BF3D RID: 48957 RVA: 0x002F3D28 File Offset: 0x002F1F28
		public int Odds
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

		// Token: 0x0400564B RID: 22091
		private Table __p;
	}
}
