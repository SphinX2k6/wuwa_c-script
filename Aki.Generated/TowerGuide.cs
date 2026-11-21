using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001277 RID: 4727
	public struct TowerGuide : IFlatbufferObject
	{
		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600EDB9 RID: 60857 RVA: 0x0035C639 File Offset: 0x0035A839
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EDBA RID: 60858 RVA: 0x0035C646 File Offset: 0x0035A846
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EDBB RID: 60859 RVA: 0x0035C650 File Offset: 0x0035A850
		public static TowerGuide GetRootAsTowerGuide(ByteBuffer _bb)
		{
			return TowerGuide.GetRootAsTowerGuide(_bb, default(TowerGuide));
		}

		// Token: 0x0600EDBC RID: 60860 RVA: 0x0035C66C File Offset: 0x0035A86C
		public static TowerGuide GetRootAsTowerGuide(ByteBuffer _bb, TowerGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EDBD RID: 60861 RVA: 0x0035C689 File Offset: 0x0035A889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EDBE RID: 60862 RVA: 0x0035C698 File Offset: 0x0035A898
		public TowerGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600EDBF RID: 60863 RVA: 0x0035C6A8 File Offset: 0x0035A8A8
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

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0600EDC0 RID: 60864 RVA: 0x0035C6E4 File Offset: 0x0035A8E4
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

		// Token: 0x0600EDC1 RID: 60865 RVA: 0x0035C720 File Offset: 0x0035A920
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x0600EDC2 RID: 60866 RVA: 0x0035C780 File Offset: 0x0035A980
		public int RewardItemLength
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

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0600EDC3 RID: 60867 RVA: 0x0035C7AC File Offset: 0x0035A9AC
		public int TrialRoleId
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

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0600EDC4 RID: 60868 RVA: 0x0035C7EC File Offset: 0x0035A9EC
		public int MapMark
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

		// Token: 0x0600EDC5 RID: 60869 RVA: 0x0035C82C File Offset: 0x0035AA2C
		[NullableContext(1)]
		public Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EDC6 RID: 60870 RVA: 0x0035C882 File Offset: 0x0035AA82
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardItemIter()
		{
			TowerGuide.<RewardItemIter>d__20 <RewardItemIter>d__ = new TowerGuide.<RewardItemIter>d__20(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600EDC7 RID: 60871 RVA: 0x0035C898 File Offset: 0x0035AA98
		public int? GetRewardItem(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			int value;
			if (!this.RewardItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600EDC8 RID: 60872 RVA: 0x0035C8CC File Offset: 0x0035AACC
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EDC9 RID: 60873 RVA: 0x0035C932 File Offset: 0x0035AB32
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict()
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x040058C5 RID: 22725
		private Table __p;

		// Token: 0x040058C6 RID: 22726
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}
