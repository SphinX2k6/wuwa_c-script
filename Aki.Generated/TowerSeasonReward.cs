using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001144 RID: 4420
	public struct TowerSeasonReward : IFlatbufferObject
	{
		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0600E073 RID: 57459 RVA: 0x0033178C File Offset: 0x0032F98C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x00331799 File Offset: 0x0032F999
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E075 RID: 57461 RVA: 0x003317A0 File Offset: 0x0032F9A0
		public static TowerSeasonReward GetRootAsTowerSeasonReward(ByteBuffer _bb)
		{
			return TowerSeasonReward.GetRootAsTowerSeasonReward(_bb, default(TowerSeasonReward));
		}

		// Token: 0x0600E076 RID: 57462 RVA: 0x003317BC File Offset: 0x0032F9BC
		public static TowerSeasonReward GetRootAsTowerSeasonReward(ByteBuffer _bb, TowerSeasonReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E077 RID: 57463 RVA: 0x003317D9 File Offset: 0x0032F9D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E078 RID: 57464 RVA: 0x003317E8 File Offset: 0x0032F9E8
		public TowerSeasonReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0600E079 RID: 57465 RVA: 0x003317F8 File Offset: 0x0032F9F8
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

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x0600E07A RID: 57466 RVA: 0x00331834 File Offset: 0x0032FA34
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

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0600E07B RID: 57467 RVA: 0x00331870 File Offset: 0x0032FA70
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

		// Token: 0x0600E07C RID: 57468 RVA: 0x003318AC File Offset: 0x0032FAAC
		public IntPair? Reward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0600E07D RID: 57469 RVA: 0x00331910 File Offset: 0x0032FB10
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

		// Token: 0x0600E07E RID: 57470 RVA: 0x0033193C File Offset: 0x0032FB3C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardIter()或GetRewardBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] Reward()
		{
			return this.RewardIter().ToArray<IntPair>();
		}

		// Token: 0x0600E07F RID: 57471 RVA: 0x00331949 File Offset: 0x0032FB49
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> RewardIter()
		{
			TowerSeasonReward.<RewardIter>d__18 <RewardIter>d__ = new TowerSeasonReward.<RewardIter>d__18(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x04005286 RID: 21126
		private Table __p;
	}
}
