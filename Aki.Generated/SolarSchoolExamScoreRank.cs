using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E5 RID: 4581
	public struct SolarSchoolExamScoreRank : IFlatbufferObject
	{
		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600E127 RID: 57639 RVA: 0x0034054D File Offset: 0x0033E74D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E128 RID: 57640 RVA: 0x0034055A File Offset: 0x0033E75A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E129 RID: 57641 RVA: 0x00340564 File Offset: 0x0033E764
		public static SolarSchoolExamScoreRank GetRootAsSolarSchoolExamScoreRank(ByteBuffer _bb)
		{
			return SolarSchoolExamScoreRank.GetRootAsSolarSchoolExamScoreRank(_bb, default(SolarSchoolExamScoreRank));
		}

		// Token: 0x0600E12A RID: 57642 RVA: 0x00340580 File Offset: 0x0033E780
		public static SolarSchoolExamScoreRank GetRootAsSolarSchoolExamScoreRank(ByteBuffer _bb, SolarSchoolExamScoreRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E12B RID: 57643 RVA: 0x0034059D File Offset: 0x0033E79D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E12C RID: 57644 RVA: 0x003405AC File Offset: 0x0033E7AC
		public SolarSchoolExamScoreRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600E12D RID: 57645 RVA: 0x003405BC File Offset: 0x0033E7BC
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

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600E12E RID: 57646 RVA: 0x003405F8 File Offset: 0x0033E7F8
		public int GroupId
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

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600E12F RID: 57647 RVA: 0x00340634 File Offset: 0x0033E834
		public int ScoreMin
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

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600E130 RID: 57648 RVA: 0x00340670 File Offset: 0x0033E870
		public int ScoreMax
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

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600E131 RID: 57649 RVA: 0x003406B0 File Offset: 0x0033E8B0
		public int RankRandMax
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

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600E132 RID: 57650 RVA: 0x003406F0 File Offset: 0x0033E8F0
		public int RankRandMin
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600E133 RID: 57651 RVA: 0x00340730 File Offset: 0x0033E930
		public string RankIcon
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

		// Token: 0x0600E134 RID: 57652 RVA: 0x00340768 File Offset: 0x0033E968
		public Span<byte> GetRankIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E135 RID: 57653 RVA: 0x00340778 File Offset: 0x0033E978
		public byte[] GetRankIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005822 RID: 22562
		private Table __p;
	}
}
