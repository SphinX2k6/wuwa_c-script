using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C44 RID: 3140
	public struct CharacterAudioConfig : IFlatbufferObject
	{
		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600585C RID: 22620 RVA: 0x0020FAFC File Offset: 0x0020DCFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x0020FB09 File Offset: 0x0020DD09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x0020FB10 File Offset: 0x0020DD10
		public static CharacterAudioConfig GetRootAsCharacterAudioConfig(ByteBuffer _bb)
		{
			return CharacterAudioConfig.GetRootAsCharacterAudioConfig(_bb, default(CharacterAudioConfig));
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x0020FB2C File Offset: 0x0020DD2C
		public static CharacterAudioConfig GetRootAsCharacterAudioConfig(ByteBuffer _bb, CharacterAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x0020FB49 File Offset: 0x0020DD49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x0020FB58 File Offset: 0x0020DD58
		public CharacterAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06005862 RID: 22626 RVA: 0x0020FB68 File Offset: 0x0020DD68
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

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06005863 RID: 22627 RVA: 0x0020FBA4 File Offset: 0x0020DDA4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x0020FBDB File Offset: 0x0020DDDB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x0020FBEA File Offset: 0x0020DDEA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x0020FC04 File Offset: 0x0020DE04
		public DicIntString? HpLost(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0020FC64 File Offset: 0x0020DE64
		public int HpLostLength
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

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x0020FC90 File Offset: 0x0020DE90
		public string Chest
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

		// Token: 0x06005869 RID: 22633 RVA: 0x0020FCC8 File Offset: 0x0020DEC8
		public Span<byte> GetChestBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x0020FCD8 File Offset: 0x0020DED8
		public byte[] GetChestArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600586B RID: 22635 RVA: 0x0020FCF0 File Offset: 0x0020DEF0
		public string Effort
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x0020FD28 File Offset: 0x0020DF28
		public Span<byte> GetEffortBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x0020FD38 File Offset: 0x0020DF38
		public byte[] GetEffortArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600586E RID: 22638 RVA: 0x0020FD50 File Offset: 0x0020DF50
		public string EffortLow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x0020FD88 File Offset: 0x0020DF88
		public Span<byte> GetEffortLowBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x0020FD98 File Offset: 0x0020DF98
		public byte[] GetEffortLowArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06005871 RID: 22641 RVA: 0x0020FDB0 File Offset: 0x0020DFB0
		public float EffortCd
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x0020FDF4 File Offset: 0x0020DFF4
		public DicIntString? Rankup(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06005873 RID: 22643 RVA: 0x0020FE58 File Offset: 0x0020E058
		public int RankupLength
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

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x0020FE84 File Offset: 0x0020E084
		public string JoinTeam
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x0020FEBC File Offset: 0x0020E0BC
		public Span<byte> GetJoinTeamBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x0020FECC File Offset: 0x0020E0CC
		public byte[] GetJoinTeamArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06005877 RID: 22647 RVA: 0x0020FEE4 File Offset: 0x0020E0E4
		public string FirstGet
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0020FF1C File Offset: 0x0020E11C
		public Span<byte> GetFirstGetBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x0020FF2C File Offset: 0x0020E12C
		public byte[] GetFirstGetArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x0020FF44 File Offset: 0x0020E144
		public string MutantTransform
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x0020FF7C File Offset: 0x0020E17C
		public Span<byte> GetMutantTransformBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x0020FF8C File Offset: 0x0020E18C
		public byte[] GetMutantTransformArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600587D RID: 22653 RVA: 0x0020FFA4 File Offset: 0x0020E1A4
		public string MutantSummon
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x0020FFDC File Offset: 0x0020E1DC
		public Span<byte> GetMutantSummonBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x0020FFEC File Offset: 0x0020E1EC
		public byte[] GetMutantSummonArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x00210004 File Offset: 0x0020E204
		[NullableContext(1)]
		public Dictionary<int, string> HpLost()
		{
			return this.HpLostIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x0021005A File Offset: 0x0020E25A
		[NullableContext(1)]
		public IEnumerable<DicIntString> HpLostIter()
		{
			CharacterAudioConfig.<HpLostIter>d__51 <HpLostIter>d__ = new CharacterAudioConfig.<HpLostIter>d__51(-2);
			<HpLostIter>d__.<>3__<>4__this = this;
			return <HpLostIter>d__;
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x00210070 File Offset: 0x0020E270
		[NullableContext(1)]
		public Dictionary<int, string> Rankup()
		{
			return this.RankupIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x002100C6 File Offset: 0x0020E2C6
		[NullableContext(1)]
		public IEnumerable<DicIntString> RankupIter()
		{
			CharacterAudioConfig.<RankupIter>d__53 <RankupIter>d__ = new CharacterAudioConfig.<RankupIter>d__53(-2);
			<RankupIter>d__.<>3__<>4__this = this;
			return <RankupIter>d__;
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x002100DC File Offset: 0x0020E2DC
		[NullableContext(2)]
		public string GetHpLost(int key)
		{
			this.EnsureHpLostCacheIfNeeded();
			string result;
			if (!this.HpLostCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x00210104 File Offset: 0x0020E304
		[NullableContext(2)]
		public string GetRankup(int key)
		{
			this.EnsureRankupCacheIfNeeded();
			string result;
			if (!this.RankupCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x0021012C File Offset: 0x0020E32C
		private void EnsureHpLostCacheIfNeeded()
		{
			if (this.HpLostCache != null)
			{
				return;
			}
			this.HpLostCache = this.HpLostIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x00210194 File Offset: 0x0020E394
		private void EnsureRankupCacheIfNeeded()
		{
			if (this.RankupCache != null)
			{
				return;
			}
			this.RankupCache = this.RankupIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x002101FA File Offset: 0x0020E3FA
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetHpLostFrozenDict()
		{
			this.EnsureHpLostCacheIfNeeded();
			return this.HpLostCache;
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x00210208 File Offset: 0x0020E408
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetRankupFrozenDict()
		{
			this.EnsureRankupCacheIfNeeded();
			return this.RankupCache;
		}

		// Token: 0x04005144 RID: 20804
		private Table __p;

		// Token: 0x04005145 RID: 20805
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> HpLostCache;

		// Token: 0x04005146 RID: 20806
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> RankupCache;
	}
}
