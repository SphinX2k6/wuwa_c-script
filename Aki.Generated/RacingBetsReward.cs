using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001077 RID: 4215
	public struct RacingBetsReward : IFlatbufferObject
	{
		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0600BEDB RID: 48859 RVA: 0x002F2E60 File Offset: 0x002F1060
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BEDC RID: 48860 RVA: 0x002F2E6D File Offset: 0x002F106D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BEDD RID: 48861 RVA: 0x002F2E74 File Offset: 0x002F1074
		public static RacingBetsReward GetRootAsRacingBetsReward(ByteBuffer _bb)
		{
			return RacingBetsReward.GetRootAsRacingBetsReward(_bb, default(RacingBetsReward));
		}

		// Token: 0x0600BEDE RID: 48862 RVA: 0x002F2E90 File Offset: 0x002F1090
		public static RacingBetsReward GetRootAsRacingBetsReward(ByteBuffer _bb, RacingBetsReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BEDF RID: 48863 RVA: 0x002F2EAD File Offset: 0x002F10AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x002F2EBC File Offset: 0x002F10BC
		public RacingBetsReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0600BEE1 RID: 48865 RVA: 0x002F2ECC File Offset: 0x002F10CC
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

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0600BEE2 RID: 48866 RVA: 0x002F2F08 File Offset: 0x002F1108
		public int SeasonId
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

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x002F2F44 File Offset: 0x002F1144
		public int Index
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

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0600BEE4 RID: 48868 RVA: 0x002F2F80 File Offset: 0x002F1180
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BEE5 RID: 48869 RVA: 0x002F2FB8 File Offset: 0x002F11B8
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BEE6 RID: 48870 RVA: 0x002F2FC8 File Offset: 0x002F11C8
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0600BEE7 RID: 48871 RVA: 0x002F2FE0 File Offset: 0x002F11E0
		public int ResetType
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

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0600BEE8 RID: 48872 RVA: 0x002F3020 File Offset: 0x002F1220
		public int RewardType
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

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x002F3060 File Offset: 0x002F1260
		public DicIntInt? TargetReward(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0600BEEA RID: 48874 RVA: 0x002F30C4 File Offset: 0x002F12C4
		public int TargetRewardLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BEEB RID: 48875 RVA: 0x002F30F0 File Offset: 0x002F12F0
		[NullableContext(1)]
		public Dictionary<int, int> TargetReward()
		{
			return this.TargetRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600BEEC RID: 48876 RVA: 0x002F3146 File Offset: 0x002F1346
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TargetRewardIter()
		{
			RacingBetsReward.<TargetRewardIter>d__26 <TargetRewardIter>d__ = new RacingBetsReward.<TargetRewardIter>d__26(-2);
			<TargetRewardIter>d__.<>3__<>4__this = this;
			return <TargetRewardIter>d__;
		}

		// Token: 0x0600BEED RID: 48877 RVA: 0x002F315C File Offset: 0x002F135C
		public int? GetTargetReward(int key)
		{
			this.EnsureTargetRewardCacheIfNeeded();
			int value;
			if (!this.TargetRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x002F3190 File Offset: 0x002F1390
		private void EnsureTargetRewardCacheIfNeeded()
		{
			if (this.TargetRewardCache != null)
			{
				return;
			}
			this.TargetRewardCache = this.TargetRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x002F31F6 File Offset: 0x002F13F6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTargetRewardFrozenDict()
		{
			this.EnsureTargetRewardCacheIfNeeded();
			return this.TargetRewardCache;
		}

		// Token: 0x04005646 RID: 22086
		private Table __p;

		// Token: 0x04005647 RID: 22087
		[Nullable(2)]
		private FrozenDictionary<int, int> TargetRewardCache;
	}
}
