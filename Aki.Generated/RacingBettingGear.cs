using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107A RID: 4218
	public struct RacingBettingGear : IFlatbufferObject
	{
		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600BF2B RID: 48939 RVA: 0x002F3AE5 File Offset: 0x002F1CE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x002F3AF2 File Offset: 0x002F1CF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x002F3AFC File Offset: 0x002F1CFC
		public static RacingBettingGear GetRootAsRacingBettingGear(ByteBuffer _bb)
		{
			return RacingBettingGear.GetRootAsRacingBettingGear(_bb, default(RacingBettingGear));
		}

		// Token: 0x0600BF2E RID: 48942 RVA: 0x002F3B18 File Offset: 0x002F1D18
		public static RacingBettingGear GetRootAsRacingBettingGear(ByteBuffer _bb, RacingBettingGear obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF2F RID: 48943 RVA: 0x002F3B35 File Offset: 0x002F1D35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x002F3B44 File Offset: 0x002F1D44
		public RacingBettingGear __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0600BF31 RID: 48945 RVA: 0x002F3B54 File Offset: 0x002F1D54
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

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x0600BF32 RID: 48946 RVA: 0x002F3B90 File Offset: 0x002F1D90
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

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0600BF33 RID: 48947 RVA: 0x002F3BCC File Offset: 0x002F1DCC
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

		// Token: 0x0400564A RID: 22090
		private Table __p;
	}
}
