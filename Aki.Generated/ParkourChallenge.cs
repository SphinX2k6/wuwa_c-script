using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F90 RID: 3984
	public struct ParkourChallenge : IFlatbufferObject
	{
		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x0600A89A RID: 43162 RVA: 0x002C26A4 File Offset: 0x002C08A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A89B RID: 43163 RVA: 0x002C26B1 File Offset: 0x002C08B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A89C RID: 43164 RVA: 0x002C26B8 File Offset: 0x002C08B8
		public static ParkourChallenge GetRootAsParkourChallenge(ByteBuffer _bb)
		{
			return ParkourChallenge.GetRootAsParkourChallenge(_bb, default(ParkourChallenge));
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x002C26D4 File Offset: 0x002C08D4
		public static ParkourChallenge GetRootAsParkourChallenge(ByteBuffer _bb, ParkourChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A89E RID: 43166 RVA: 0x002C26F1 File Offset: 0x002C08F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x002C2700 File Offset: 0x002C0900
		public ParkourChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x0600A8A0 RID: 43168 RVA: 0x002C2710 File Offset: 0x002C0910
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

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x002C274C File Offset: 0x002C094C
		public int MarkId
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

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x0600A8A2 RID: 43170 RVA: 0x002C2788 File Offset: 0x002C0988
		public string BackGroundTexture
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x002C27BF File Offset: 0x002C09BF
		public Span<byte> GetBackGroundTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x002C27CE File Offset: 0x002C09CE
		public byte[] GetBackGroundTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x0600A8A5 RID: 43173 RVA: 0x002C27E8 File Offset: 0x002C09E8
		public string Title
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

		// Token: 0x0600A8A6 RID: 43174 RVA: 0x002C2820 File Offset: 0x002C0A20
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A8A7 RID: 43175 RVA: 0x002C2830 File Offset: 0x002C0A30
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x002C2848 File Offset: 0x002C0A48
		public int LevelPlayId
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

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x002C2888 File Offset: 0x002C0A88
		public DicIntInt? Rewards(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x0600A8AA RID: 43178 RVA: 0x002C28EC File Offset: 0x002C0AEC
		public int RewardsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A8AB RID: 43179 RVA: 0x002C2918 File Offset: 0x002C0B18
		public IntPair? RewardList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x0600A8AC RID: 43180 RVA: 0x002C297C File Offset: 0x002C0B7C
		public int RewardListLength
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

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x002C29A8 File Offset: 0x002C0BA8
		public int LocationEntityConfigId
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

		// Token: 0x0600A8AE RID: 43182 RVA: 0x002C29E5 File Offset: 0x002C0BE5
		[NullableContext(1)]
		public IntPair[] RewardList()
		{
			return this.RewardListIter().ToArray<IntPair>();
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x002C29F2 File Offset: 0x002C0BF2
		[NullableContext(1)]
		public IEnumerable<IntPair> RewardListIter()
		{
			ParkourChallenge.<RewardListIter>d__31 <RewardListIter>d__ = new ParkourChallenge.<RewardListIter>d__31(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x002C2A08 File Offset: 0x002C0C08
		[NullableContext(1)]
		public Dictionary<int, int> Rewards()
		{
			return this.RewardsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x002C2A5E File Offset: 0x002C0C5E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardsIter()
		{
			ParkourChallenge.<RewardsIter>d__33 <RewardsIter>d__ = new ParkourChallenge.<RewardsIter>d__33(-2);
			<RewardsIter>d__.<>3__<>4__this = this;
			return <RewardsIter>d__;
		}

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x002C2A74 File Offset: 0x002C0C74
		public int? GetRewards(int key)
		{
			this.EnsureRewardsCacheIfNeeded();
			int value;
			if (!this.RewardsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x002C2AA8 File Offset: 0x002C0CA8
		private void EnsureRewardsCacheIfNeeded()
		{
			if (this.RewardsCache != null)
			{
				return;
			}
			this.RewardsCache = this.RewardsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x002C2B0E File Offset: 0x002C0D0E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardsFrozenDict()
		{
			this.EnsureRewardsCacheIfNeeded();
			return this.RewardsCache;
		}

		// Token: 0x04005545 RID: 21829
		private Table __p;

		// Token: 0x04005546 RID: 21830
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardsCache;
	}
}
