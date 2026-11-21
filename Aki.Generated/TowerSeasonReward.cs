using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200127A RID: 4730
	public struct TowerSeasonReward : IFlatbufferObject
	{
		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600EDE1 RID: 60897 RVA: 0x0035CBF4 File Offset: 0x0035ADF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EDE2 RID: 60898 RVA: 0x0035CC01 File Offset: 0x0035AE01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EDE3 RID: 60899 RVA: 0x0035CC08 File Offset: 0x0035AE08
		public static TowerSeasonReward GetRootAsTowerSeasonReward(ByteBuffer _bb)
		{
			return TowerSeasonReward.GetRootAsTowerSeasonReward(_bb, default(TowerSeasonReward));
		}

		// Token: 0x0600EDE4 RID: 60900 RVA: 0x0035CC24 File Offset: 0x0035AE24
		public static TowerSeasonReward GetRootAsTowerSeasonReward(ByteBuffer _bb, TowerSeasonReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EDE5 RID: 60901 RVA: 0x0035CC41 File Offset: 0x0035AE41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EDE6 RID: 60902 RVA: 0x0035CC50 File Offset: 0x0035AE50
		public TowerSeasonReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x0600EDE7 RID: 60903 RVA: 0x0035CC60 File Offset: 0x0035AE60
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

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600EDE8 RID: 60904 RVA: 0x0035CC9C File Offset: 0x0035AE9C
		public int Difficulty
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

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600EDE9 RID: 60905 RVA: 0x0035CCD8 File Offset: 0x0035AED8
		public int RewardGroup
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

		// Token: 0x0600EDEA RID: 60906 RVA: 0x0035CD14 File Offset: 0x0035AF14
		public IntPair? Reward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600EDEB RID: 60907 RVA: 0x0035CD78 File Offset: 0x0035AF78
		public int RewardLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EDEC RID: 60908 RVA: 0x0035CDA4 File Offset: 0x0035AFA4
		[NullableContext(1)]
		public IntPair[] Reward()
		{
			return this.RewardIter().ToArray<IntPair>();
		}

		// Token: 0x0600EDED RID: 60909 RVA: 0x0035CDB1 File Offset: 0x0035AFB1
		[NullableContext(1)]
		public IEnumerable<IntPair> RewardIter()
		{
			TowerSeasonReward.<RewardIter>d__18 <RewardIter>d__ = new TowerSeasonReward.<RewardIter>d__18(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x040058C9 RID: 22729
		private Table __p;
	}
}
