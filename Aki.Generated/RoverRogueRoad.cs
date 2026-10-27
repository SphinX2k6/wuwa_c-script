using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001083 RID: 4227
	public struct RoverRogueRoad : IFlatbufferObject
	{
		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600CEB0 RID: 52912 RVA: 0x00307FF5 File Offset: 0x003061F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CEB1 RID: 52913 RVA: 0x00308002 File Offset: 0x00306202
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CEB2 RID: 52914 RVA: 0x0030800C File Offset: 0x0030620C
		public static RoverRogueRoad GetRootAsRoverRogueRoad(ByteBuffer _bb)
		{
			return RoverRogueRoad.GetRootAsRoverRogueRoad(_bb, default(RoverRogueRoad));
		}

		// Token: 0x0600CEB3 RID: 52915 RVA: 0x00308028 File Offset: 0x00306228
		public static RoverRogueRoad GetRootAsRoverRogueRoad(ByteBuffer _bb, RoverRogueRoad obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEB4 RID: 52916 RVA: 0x00308045 File Offset: 0x00306245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEB5 RID: 52917 RVA: 0x00308054 File Offset: 0x00306254
		public RoverRogueRoad __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600CEB6 RID: 52918 RVA: 0x00308064 File Offset: 0x00306264
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

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600CEB7 RID: 52919 RVA: 0x003080A0 File Offset: 0x003062A0
		public int RoadType
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

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600CEB8 RID: 52920 RVA: 0x003080DC File Offset: 0x003062DC
		public int Layer
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

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600CEB9 RID: 52921 RVA: 0x00308118 File Offset: 0x00306318
		public int Floor
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

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600CEBA RID: 52922 RVA: 0x00308158 File Offset: 0x00306358
		public int LayerType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600CEBB RID: 52923 RVA: 0x00308198 File Offset: 0x00306398
		public int AiTeamLevel
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

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0600CEBC RID: 52924 RVA: 0x003081D8 File Offset: 0x003063D8
		public int FinishReward
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

		// Token: 0x0600CEBD RID: 52925 RVA: 0x00308218 File Offset: 0x00306418
		public DicIntInt? FinishRewardItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600CEBE RID: 52926 RVA: 0x0030827C File Offset: 0x0030647C
		public int FinishRewardItemLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CEBF RID: 52927 RVA: 0x003082A8 File Offset: 0x003064A8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FinishRewardItemFrozenDict()缓存字典，遍历请使用FinishRewardItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FinishRewardItem()
		{
			return this.FinishRewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CEC0 RID: 52928 RVA: 0x003082FE File Offset: 0x003064FE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FinishRewardItemIter()
		{
			RoverRogueRoad.<FinishRewardItemIter>d__26 <FinishRewardItemIter>d__ = new RoverRogueRoad.<FinishRewardItemIter>d__26(-2);
			<FinishRewardItemIter>d__.<>3__<>4__this = this;
			return <FinishRewardItemIter>d__;
		}

		// Token: 0x0600CEC1 RID: 52929 RVA: 0x00308314 File Offset: 0x00306514
		public int? GetFinishRewardItem(int key)
		{
			this.EnsureFinishRewardItemCacheIfNeeded();
			int value;
			if (!this.FinishRewardItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CEC2 RID: 52930 RVA: 0x00308348 File Offset: 0x00306548
		private void EnsureFinishRewardItemCacheIfNeeded()
		{
			if (this.FinishRewardItemCache != null)
			{
				return;
			}
			this.FinishRewardItemCache = this.FinishRewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CEC3 RID: 52931 RVA: 0x003083AE File Offset: 0x003065AE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFinishRewardItemFrozenDict(int key)
		{
			this.EnsureFinishRewardItemCacheIfNeeded();
			return this.FinishRewardItemCache;
		}

		// Token: 0x0400518E RID: 20878
		private Table __p;

		// Token: 0x0400518F RID: 20879
		[Nullable(2)]
		private FrozenDictionary<int, int> FinishRewardItemCache;
	}
}
