using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011FB RID: 4603
	public struct SolarSchoolRewards : IFlatbufferObject
	{
		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0600E31A RID: 58138 RVA: 0x00344C01 File Offset: 0x00342E01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E31B RID: 58139 RVA: 0x00344C0E File Offset: 0x00342E0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E31C RID: 58140 RVA: 0x00344C18 File Offset: 0x00342E18
		public static SolarSchoolRewards GetRootAsSolarSchoolRewards(ByteBuffer _bb)
		{
			return SolarSchoolRewards.GetRootAsSolarSchoolRewards(_bb, default(SolarSchoolRewards));
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x00344C34 File Offset: 0x00342E34
		public static SolarSchoolRewards GetRootAsSolarSchoolRewards(ByteBuffer _bb, SolarSchoolRewards obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E31E RID: 58142 RVA: 0x00344C51 File Offset: 0x00342E51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x00344C60 File Offset: 0x00342E60
		public SolarSchoolRewards __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0600E320 RID: 58144 RVA: 0x00344C70 File Offset: 0x00342E70
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

		// Token: 0x0600E321 RID: 58145 RVA: 0x00344CAC File Offset: 0x00342EAC
		public int RewardIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0600E322 RID: 58146 RVA: 0x00344CEC File Offset: 0x00342EEC
		public int RewardIdsLength
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

		// Token: 0x0600E323 RID: 58147 RVA: 0x00344D17 File Offset: 0x00342F17
		public Span<int> GetRewardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E324 RID: 58148 RVA: 0x00344D26 File Offset: 0x00342F26
		public int[] GetRewardIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600E325 RID: 58149 RVA: 0x00344D3D File Offset: 0x00342F3D
		[NullableContext(1)]
		public int[] RewardIds()
		{
			return this.GetRewardIdsArray();
		}

		// Token: 0x0600E326 RID: 58150 RVA: 0x00344D45 File Offset: 0x00342F45
		[NullableContext(1)]
		public IEnumerable<int> RewardIdsIter()
		{
			SolarSchoolRewards.<RewardIdsIter>d__16 <RewardIdsIter>d__ = new SolarSchoolRewards.<RewardIdsIter>d__16(-2);
			<RewardIdsIter>d__.<>3__<>4__this = this;
			return <RewardIdsIter>d__;
		}

		// Token: 0x04005839 RID: 22585
		private Table __p;
	}
}
