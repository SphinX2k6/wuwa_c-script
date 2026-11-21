using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F33 RID: 3891
	public struct MotorFightSubLevel : IFlatbufferObject
	{
		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06009F69 RID: 40809 RVA: 0x002AEA56 File Offset: 0x002ACC56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x002AEA63 File Offset: 0x002ACC63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x002AEA6C File Offset: 0x002ACC6C
		public static MotorFightSubLevel GetRootAsMotorFightSubLevel(ByteBuffer _bb)
		{
			return MotorFightSubLevel.GetRootAsMotorFightSubLevel(_bb, default(MotorFightSubLevel));
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x002AEA88 File Offset: 0x002ACC88
		public static MotorFightSubLevel GetRootAsMotorFightSubLevel(ByteBuffer _bb, MotorFightSubLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x002AEAA5 File Offset: 0x002ACCA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x002AEAB4 File Offset: 0x002ACCB4
		public MotorFightSubLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06009F6F RID: 40815 RVA: 0x002AEAC4 File Offset: 0x002ACCC4
		public int SubLevelId
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

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06009F70 RID: 40816 RVA: 0x002AEB00 File Offset: 0x002ACD00
		public int SubLevelType
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

		// Token: 0x06009F71 RID: 40817 RVA: 0x002AEB3C File Offset: 0x002ACD3C
		public int WaveGroupIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06009F72 RID: 40818 RVA: 0x002AEB7C File Offset: 0x002ACD7C
		public int WaveGroupIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009F73 RID: 40819 RVA: 0x002AEBA7 File Offset: 0x002ACDA7
		public Span<int> GetWaveGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009F74 RID: 40820 RVA: 0x002AEBB6 File Offset: 0x002ACDB6
		public int[] GetWaveGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06009F75 RID: 40821 RVA: 0x002AEBD0 File Offset: 0x002ACDD0
		public int PreSegmentId
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

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06009F76 RID: 40822 RVA: 0x002AEC10 File Offset: 0x002ACE10
		public int MobilePreSegmentId
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

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x002AEC50 File Offset: 0x002ACE50
		public int PreSegmentLength
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

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x002AEC90 File Offset: 0x002ACE90
		public int SegmentId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06009F79 RID: 40825 RVA: 0x002AECD0 File Offset: 0x002ACED0
		public int MobileSegmentId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06009F7A RID: 40826 RVA: 0x002AED10 File Offset: 0x002ACF10
		public float WorldSpeedMultiply
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06009F7B RID: 40827 RVA: 0x002AED54 File Offset: 0x002ACF54
		public float BornDistance
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06009F7C RID: 40828 RVA: 0x002AED98 File Offset: 0x002ACF98
		public float DistanceToNext
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x002AEDDC File Offset: 0x002ACFDC
		public int LevelAttrRate(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06009F7E RID: 40830 RVA: 0x002AEE1C File Offset: 0x002AD01C
		public int LevelAttrRateLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x002AEE48 File Offset: 0x002AD048
		public Span<int> GetLevelAttrRateBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x002AEE58 File Offset: 0x002AD058
		public int[] GetLevelAttrRateArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x002AEE70 File Offset: 0x002AD070
		[NullableContext(1)]
		public int[] LevelAttrRate()
		{
			return this.GetLevelAttrRateArray();
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x002AEE78 File Offset: 0x002AD078
		[NullableContext(1)]
		public IEnumerable<int> LevelAttrRateIter()
		{
			MotorFightSubLevel.<LevelAttrRateIter>d__39 <LevelAttrRateIter>d__ = new MotorFightSubLevel.<LevelAttrRateIter>d__39(-2);
			<LevelAttrRateIter>d__.<>3__<>4__this = this;
			return <LevelAttrRateIter>d__;
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x002AEE8D File Offset: 0x002AD08D
		[NullableContext(1)]
		public int[] WaveGroupIds()
		{
			return this.GetWaveGroupIdsArray();
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x002AEE95 File Offset: 0x002AD095
		[NullableContext(1)]
		public IEnumerable<int> WaveGroupIdsIter()
		{
			MotorFightSubLevel.<WaveGroupIdsIter>d__41 <WaveGroupIdsIter>d__ = new MotorFightSubLevel.<WaveGroupIdsIter>d__41(-2);
			<WaveGroupIdsIter>d__.<>3__<>4__this = this;
			return <WaveGroupIdsIter>d__;
		}

		// Token: 0x040054DC RID: 21724
		private Table __p;
	}
}
