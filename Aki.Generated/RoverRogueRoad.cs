using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117E RID: 4478
	public struct RoverRogueRoad : IFlatbufferObject
	{
		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600D683 RID: 54915 RVA: 0x00327665 File Offset: 0x00325865
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x00327672 File Offset: 0x00325872
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D685 RID: 54917 RVA: 0x0032767C File Offset: 0x0032587C
		public static RoverRogueRoad GetRootAsRoverRogueRoad(ByteBuffer _bb)
		{
			return RoverRogueRoad.GetRootAsRoverRogueRoad(_bb, default(RoverRogueRoad));
		}

		// Token: 0x0600D686 RID: 54918 RVA: 0x00327698 File Offset: 0x00325898
		public static RoverRogueRoad GetRootAsRoverRogueRoad(ByteBuffer _bb, RoverRogueRoad obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D687 RID: 54919 RVA: 0x003276B5 File Offset: 0x003258B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D688 RID: 54920 RVA: 0x003276C4 File Offset: 0x003258C4
		public RoverRogueRoad __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600D689 RID: 54921 RVA: 0x003276D4 File Offset: 0x003258D4
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

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600D68A RID: 54922 RVA: 0x00327710 File Offset: 0x00325910
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

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600D68B RID: 54923 RVA: 0x0032774C File Offset: 0x0032594C
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

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600D68C RID: 54924 RVA: 0x00327788 File Offset: 0x00325988
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

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600D68D RID: 54925 RVA: 0x003277C8 File Offset: 0x003259C8
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

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600D68E RID: 54926 RVA: 0x00327808 File Offset: 0x00325A08
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

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600D68F RID: 54927 RVA: 0x00327848 File Offset: 0x00325A48
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

		// Token: 0x0600D690 RID: 54928 RVA: 0x00327888 File Offset: 0x00325A88
		public DicIntInt? FinishRewardItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600D691 RID: 54929 RVA: 0x003278EC File Offset: 0x00325AEC
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

		// Token: 0x0600D692 RID: 54930 RVA: 0x00327918 File Offset: 0x00325B18
		[NullableContext(1)]
		public Dictionary<int, int> FinishRewardItem()
		{
			return this.FinishRewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D693 RID: 54931 RVA: 0x0032796E File Offset: 0x00325B6E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FinishRewardItemIter()
		{
			RoverRogueRoad.<FinishRewardItemIter>d__26 <FinishRewardItemIter>d__ = new RoverRogueRoad.<FinishRewardItemIter>d__26(-2);
			<FinishRewardItemIter>d__.<>3__<>4__this = this;
			return <FinishRewardItemIter>d__;
		}

		// Token: 0x0600D694 RID: 54932 RVA: 0x00327984 File Offset: 0x00325B84
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

		// Token: 0x0600D695 RID: 54933 RVA: 0x003279B8 File Offset: 0x00325BB8
		private void EnsureFinishRewardItemCacheIfNeeded()
		{
			if (this.FinishRewardItemCache != null)
			{
				return;
			}
			this.FinishRewardItemCache = this.FinishRewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D696 RID: 54934 RVA: 0x00327A1E File Offset: 0x00325C1E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFinishRewardItemFrozenDict()
		{
			this.EnsureFinishRewardItemCacheIfNeeded();
			return this.FinishRewardItemCache;
		}

		// Token: 0x0400578D RID: 22413
		private Table __p;

		// Token: 0x0400578E RID: 22414
		[Nullable(2)]
		private FrozenDictionary<int, int> FinishRewardItemCache;
	}
}
