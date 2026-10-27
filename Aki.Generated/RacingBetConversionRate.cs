using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F83 RID: 3971
	public struct RacingBetConversionRate : IFlatbufferObject
	{
		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0600B7B6 RID: 47030 RVA: 0x002D46A5 File Offset: 0x002D28A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x002D46B2 File Offset: 0x002D28B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x002D46BC File Offset: 0x002D28BC
		public static RacingBetConversionRate GetRootAsRacingBetConversionRate(ByteBuffer _bb)
		{
			return RacingBetConversionRate.GetRootAsRacingBetConversionRate(_bb, default(RacingBetConversionRate));
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x002D46D8 File Offset: 0x002D28D8
		public static RacingBetConversionRate GetRootAsRacingBetConversionRate(ByteBuffer _bb, RacingBetConversionRate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x002D46F5 File Offset: 0x002D28F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x002D4704 File Offset: 0x002D2904
		public RacingBetConversionRate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0600B7BC RID: 47036 RVA: 0x002D4714 File Offset: 0x002D2914
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

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0600B7BD RID: 47037 RVA: 0x002D4750 File Offset: 0x002D2950
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

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x0600B7BE RID: 47038 RVA: 0x002D478C File Offset: 0x002D298C
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

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x0600B7BF RID: 47039 RVA: 0x002D47C8 File Offset: 0x002D29C8
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

		// Token: 0x04005051 RID: 20561
		private Table __p;
	}
}
