using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F93 RID: 3987
	public struct RacingBettingGear : IFlatbufferObject
	{
		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x0600B8EE RID: 47342 RVA: 0x002D72B1 File Offset: 0x002D54B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8EF RID: 47343 RVA: 0x002D72BE File Offset: 0x002D54BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x002D72C8 File Offset: 0x002D54C8
		public static RacingBettingGear GetRootAsRacingBettingGear(ByteBuffer _bb)
		{
			return RacingBettingGear.GetRootAsRacingBettingGear(_bb, default(RacingBettingGear));
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x002D72E4 File Offset: 0x002D54E4
		public static RacingBettingGear GetRootAsRacingBettingGear(ByteBuffer _bb, RacingBettingGear obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x002D7301 File Offset: 0x002D5501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x002D7310 File Offset: 0x002D5510
		public RacingBettingGear __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x002D7320 File Offset: 0x002D5520
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

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x0600B8F5 RID: 47349 RVA: 0x002D735C File Offset: 0x002D555C
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

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x002D7398 File Offset: 0x002D5598
		public int Odds
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

		// Token: 0x04005063 RID: 20579
		private Table __p;
	}
}
