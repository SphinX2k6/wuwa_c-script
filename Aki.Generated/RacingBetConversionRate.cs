using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106A RID: 4202
	public struct RacingBetConversionRate : IFlatbufferObject
	{
		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x0600BDF3 RID: 48627 RVA: 0x002F1051 File Offset: 0x002EF251
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDF4 RID: 48628 RVA: 0x002F105E File Offset: 0x002EF25E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x002F1068 File Offset: 0x002EF268
		public static RacingBetConversionRate GetRootAsRacingBetConversionRate(ByteBuffer _bb)
		{
			return RacingBetConversionRate.GetRootAsRacingBetConversionRate(_bb, default(RacingBetConversionRate));
		}

		// Token: 0x0600BDF6 RID: 48630 RVA: 0x002F1084 File Offset: 0x002EF284
		public static RacingBetConversionRate GetRootAsRacingBetConversionRate(ByteBuffer _bb, RacingBetConversionRate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDF7 RID: 48631 RVA: 0x002F10A1 File Offset: 0x002EF2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDF8 RID: 48632 RVA: 0x002F10B0 File Offset: 0x002EF2B0
		public RacingBetConversionRate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x0600BDF9 RID: 48633 RVA: 0x002F10C0 File Offset: 0x002EF2C0
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

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x0600BDFA RID: 48634 RVA: 0x002F10FC File Offset: 0x002EF2FC
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

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x0600BDFB RID: 48635 RVA: 0x002F1138 File Offset: 0x002EF338
		public int Rank
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

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x0600BDFC RID: 48636 RVA: 0x002F1174 File Offset: 0x002EF374
		public int ConversionRate
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

		// Token: 0x04005638 RID: 22072
		private Table __p;
	}
}
