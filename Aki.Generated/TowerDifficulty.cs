using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001140 RID: 4416
	public struct TowerDifficulty : IFlatbufferObject
	{
		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0600E040 RID: 57408 RVA: 0x0033107C File Offset: 0x0032F27C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E041 RID: 57409 RVA: 0x00331089 File Offset: 0x0032F289
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E042 RID: 57410 RVA: 0x00331090 File Offset: 0x0032F290
		public static TowerDifficulty GetRootAsTowerDifficulty(ByteBuffer _bb)
		{
			return TowerDifficulty.GetRootAsTowerDifficulty(_bb, default(TowerDifficulty));
		}

		// Token: 0x0600E043 RID: 57411 RVA: 0x003310AC File Offset: 0x0032F2AC
		public static TowerDifficulty GetRootAsTowerDifficulty(ByteBuffer _bb, TowerDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E044 RID: 57412 RVA: 0x003310C9 File Offset: 0x0032F2C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E045 RID: 57413 RVA: 0x003310D8 File Offset: 0x0032F2D8
		public TowerDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0600E046 RID: 57414 RVA: 0x003310E8 File Offset: 0x0032F2E8
		public int Difficulty
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

		// Token: 0x0600E047 RID: 57415 RVA: 0x00331124 File Offset: 0x0032F324
		public IntPair? Reward(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x0600E048 RID: 57416 RVA: 0x00331184 File Offset: 0x0032F384
		public int RewardLength
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

		// Token: 0x0600E049 RID: 57417 RVA: 0x003311AF File Offset: 0x0032F3AF
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardIter()或GetRewardBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] Reward()
		{
			return this.RewardIter().ToArray<IntPair>();
		}

		// Token: 0x0600E04A RID: 57418 RVA: 0x003311BC File Offset: 0x0032F3BC
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> RewardIter()
		{
			TowerDifficulty.<RewardIter>d__14 <RewardIter>d__ = new TowerDifficulty.<RewardIter>d__14(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x04005281 RID: 21121
		private Table __p;
	}
}
