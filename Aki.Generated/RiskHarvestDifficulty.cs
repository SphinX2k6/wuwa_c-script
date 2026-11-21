using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B5 RID: 4277
	public struct RiskHarvestDifficulty : IFlatbufferObject
	{
		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600C3AA RID: 50090 RVA: 0x002FD824 File Offset: 0x002FBA24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x002FD831 File Offset: 0x002FBA31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3AC RID: 50092 RVA: 0x002FD838 File Offset: 0x002FBA38
		public static RiskHarvestDifficulty GetRootAsRiskHarvestDifficulty(ByteBuffer _bb)
		{
			return RiskHarvestDifficulty.GetRootAsRiskHarvestDifficulty(_bb, default(RiskHarvestDifficulty));
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x002FD854 File Offset: 0x002FBA54
		public static RiskHarvestDifficulty GetRootAsRiskHarvestDifficulty(ByteBuffer _bb, RiskHarvestDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x002FD871 File Offset: 0x002FBA71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x002FD880 File Offset: 0x002FBA80
		public RiskHarvestDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600C3B0 RID: 50096 RVA: 0x002FD890 File Offset: 0x002FBA90
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

		// Token: 0x0600C3B1 RID: 50097 RVA: 0x002FD8CC File Offset: 0x002FBACC
		public int LevelGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600C3B2 RID: 50098 RVA: 0x002FD90C File Offset: 0x002FBB0C
		public int LevelGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x002FD937 File Offset: 0x002FBB37
		public Span<int> GetLevelGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C3B4 RID: 50100 RVA: 0x002FD946 File Offset: 0x002FBB46
		public int[] GetLevelGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0600C3B5 RID: 50101 RVA: 0x002FD960 File Offset: 0x002FBB60
		public int TimeRatio
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

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0600C3B6 RID: 50102 RVA: 0x002FD99C File Offset: 0x002FBB9C
		public int MonsterRatio
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

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x002FD9D9 File Offset: 0x002FBBD9
		[NullableContext(1)]
		public int[] LevelGroup()
		{
			return this.GetLevelGroupArray();
		}

		// Token: 0x0600C3B8 RID: 50104 RVA: 0x002FD9E1 File Offset: 0x002FBBE1
		[NullableContext(1)]
		public IEnumerable<int> LevelGroupIter()
		{
			RiskHarvestDifficulty.<LevelGroupIter>d__20 <LevelGroupIter>d__ = new RiskHarvestDifficulty.<LevelGroupIter>d__20(-2);
			<LevelGroupIter>d__.<>3__<>4__this = this;
			return <LevelGroupIter>d__;
		}

		// Token: 0x04005690 RID: 22160
		private Table __p;
	}
}
