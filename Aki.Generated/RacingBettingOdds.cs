using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F94 RID: 3988
	public struct RacingBettingOdds : IFlatbufferObject
	{
		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x0600B8F7 RID: 47351 RVA: 0x002D73D4 File Offset: 0x002D55D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x002D73E1 File Offset: 0x002D55E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x002D73E8 File Offset: 0x002D55E8
		public static RacingBettingOdds GetRootAsRacingBettingOdds(ByteBuffer _bb)
		{
			return RacingBettingOdds.GetRootAsRacingBettingOdds(_bb, default(RacingBettingOdds));
		}

		// Token: 0x0600B8FA RID: 47354 RVA: 0x002D7404 File Offset: 0x002D5604
		public static RacingBettingOdds GetRootAsRacingBettingOdds(ByteBuffer _bb, RacingBettingOdds obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8FB RID: 47355 RVA: 0x002D7421 File Offset: 0x002D5621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8FC RID: 47356 RVA: 0x002D7430 File Offset: 0x002D5630
		public RacingBettingOdds __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x0600B8FD RID: 47357 RVA: 0x002D7440 File Offset: 0x002D5640
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

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x002D747C File Offset: 0x002D567C
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

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0600B8FF RID: 47359 RVA: 0x002D74B8 File Offset: 0x002D56B8
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

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x002D74F4 File Offset: 0x002D56F4
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

		// Token: 0x04005064 RID: 20580
		private Table __p;
	}
}
