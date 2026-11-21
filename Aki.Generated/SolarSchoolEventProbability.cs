using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E1 RID: 4577
	public struct SolarSchoolEventProbability : IFlatbufferObject
	{
		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600E0E6 RID: 57574 RVA: 0x0033FCA5 File Offset: 0x0033DEA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x0033FCB2 File Offset: 0x0033DEB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0E8 RID: 57576 RVA: 0x0033FCBC File Offset: 0x0033DEBC
		public static SolarSchoolEventProbability GetRootAsSolarSchoolEventProbability(ByteBuffer _bb)
		{
			return SolarSchoolEventProbability.GetRootAsSolarSchoolEventProbability(_bb, default(SolarSchoolEventProbability));
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x0033FCD8 File Offset: 0x0033DED8
		public static SolarSchoolEventProbability GetRootAsSolarSchoolEventProbability(ByteBuffer _bb, SolarSchoolEventProbability obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x0033FCF5 File Offset: 0x0033DEF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x0033FD04 File Offset: 0x0033DF04
		public SolarSchoolEventProbability __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600E0EC RID: 57580 RVA: 0x0033FD14 File Offset: 0x0033DF14
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

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600E0ED RID: 57581 RVA: 0x0033FD50 File Offset: 0x0033DF50
		public int ProbabilityRangeMin
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

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600E0EE RID: 57582 RVA: 0x0033FD8C File Offset: 0x0033DF8C
		public int ProbabilityRangeMax
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

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600E0EF RID: 57583 RVA: 0x0033FDC8 File Offset: 0x0033DFC8
		public int ProbabilityMapping
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

		// Token: 0x0400581E RID: 22558
		private Table __p;
	}
}
