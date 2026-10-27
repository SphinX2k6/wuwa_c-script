using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B64 RID: 2916
	public struct CharacterAudioConfig : IFlatbufferObject
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600529A RID: 21146 RVA: 0x001EFD6C File Offset: 0x001EDF6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x001EFD79 File Offset: 0x001EDF79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x001EFD80 File Offset: 0x001EDF80
		public static CharacterAudioConfig GetRootAsCharacterAudioConfig(ByteBuffer _bb)
		{
			return CharacterAudioConfig.GetRootAsCharacterAudioConfig(_bb, default(CharacterAudioConfig));
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x001EFD9C File Offset: 0x001EDF9C
		public static CharacterAudioConfig GetRootAsCharacterAudioConfig(ByteBuffer _bb, CharacterAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x001EFDB9 File Offset: 0x001EDFB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x001EFDC8 File Offset: 0x001EDFC8
		public CharacterAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060052A0 RID: 21152 RVA: 0x001EFDD8 File Offset: 0x001EDFD8
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

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x001EFE14 File Offset: 0x001EE014
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

		// Token: 0x060052A2 RID: 21154 RVA: 0x001EFE4B File Offset: 0x001EE04B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x001EFE5A File Offset: 0x001EE05A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x001EFE74 File Offset: 0x001EE074
		public DicIntString? HpLost(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060052A5 RID: 21157 RVA: 0x001EFED4 File Offset: 0x001EE0D4
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

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060052A6 RID: 21158 RVA: 0x001EFF00 File Offset: 0x001EE100
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

		// Token: 0x060052A7 RID: 21159 RVA: 0x001EFF38 File Offset: 0x001EE138
		public Span<byte> GetChestBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x001EFF48 File Offset: 0x001EE148
		public byte[] GetChestArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060052A9 RID: 21161 RVA: 0x001EFF60 File Offset: 0x001EE160
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

		// Token: 0x060052AA RID: 21162 RVA: 0x001EFF98 File Offset: 0x001EE198
		public Span<byte> GetEffortBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x001EFFA8 File Offset: 0x001EE1A8
		public byte[] GetEffortArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x001EFFC0 File Offset: 0x001EE1C0
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

		// Token: 0x060052AD RID: 21165 RVA: 0x001EFFF8 File Offset: 0x001EE1F8
		public Span<byte> GetEffortLowBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x001F0008 File Offset: 0x001EE208
		public byte[] GetEffortLowArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x001F0020 File Offset: 0x001EE220
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

		// Token: 0x060052B0 RID: 21168 RVA: 0x001F0064 File Offset: 0x001EE264
		public DicIntString? Rankup(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x001F00C8 File Offset: 0x001EE2C8
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

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060052B2 RID: 21170 RVA: 0x001F00F4 File Offset: 0x001EE2F4
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

		// Token: 0x060052B3 RID: 21171 RVA: 0x001F012C File Offset: 0x001EE32C
		public Span<byte> GetJoinTeamBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x001F013C File Offset: 0x001EE33C
		public byte[] GetJoinTeamArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060052B5 RID: 21173 RVA: 0x001F0154 File Offset: 0x001EE354
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

		// Token: 0x060052B6 RID: 21174 RVA: 0x001F018C File Offset: 0x001EE38C
		public Span<byte> GetFirstGetBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x001F019C File Offset: 0x001EE39C
		public byte[] GetFirstGetArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060052B8 RID: 21176 RVA: 0x001F01B4 File Offset: 0x001EE3B4
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

		// Token: 0x060052B9 RID: 21177 RVA: 0x001F01EC File Offset: 0x001EE3EC
		public Span<byte> GetMutantTransformBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x001F01FC File Offset: 0x001EE3FC
		public byte[] GetMutantTransformArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x001F0214 File Offset: 0x001EE414
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

		// Token: 0x060052BC RID: 21180 RVA: 0x001F024C File Offset: 0x001EE44C
		public Span<byte> GetMutantSummonBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x001F025C File Offset: 0x001EE45C
		public byte[] GetMutantSummonArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x001F0274 File Offset: 0x001EE474
		[NullableContext(1)]
		[Obsolete("已废弃，请使用HpLostFrozenDict()缓存字典，遍历请使用HpLostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> HpLost()
		{
			return this.HpLostIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x001F02CA File Offset: 0x001EE4CA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> HpLostIter()
		{
			CharacterAudioConfig.<HpLostIter>d__51 <HpLostIter>d__ = new CharacterAudioConfig.<HpLostIter>d__51(-2);
			<HpLostIter>d__.<>3__<>4__this = this;
			return <HpLostIter>d__;
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x001F02E0 File Offset: 0x001EE4E0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RankupFrozenDict()缓存字典，遍历请使用RankupIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> Rankup()
		{
			return this.RankupIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x001F0336 File Offset: 0x001EE536
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> RankupIter()
		{
			CharacterAudioConfig.<RankupIter>d__53 <RankupIter>d__ = new CharacterAudioConfig.<RankupIter>d__53(-2);
			<RankupIter>d__.<>3__<>4__this = this;
			return <RankupIter>d__;
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x001F034C File Offset: 0x001EE54C
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

		// Token: 0x060052C3 RID: 21187 RVA: 0x001F0374 File Offset: 0x001EE574
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

		// Token: 0x060052C4 RID: 21188 RVA: 0x001F039C File Offset: 0x001EE59C
		private void EnsureHpLostCacheIfNeeded()
		{
			if (this.HpLostCache != null)
			{
				return;
			}
			this.HpLostCache = this.HpLostIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x001F0404 File Offset: 0x001EE604
		private void EnsureRankupCacheIfNeeded()
		{
			if (this.RankupCache != null)
			{
				return;
			}
			this.RankupCache = this.RankupIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x001F046A File Offset: 0x001EE66A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetHpLostFrozenDict(int key)
		{
			this.EnsureHpLostCacheIfNeeded();
			return this.HpLostCache;
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x001F0478 File Offset: 0x001EE678
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetRankupFrozenDict(int key)
		{
			this.EnsureRankupCacheIfNeeded();
			return this.RankupCache;
		}

		// Token: 0x04004B64 RID: 19300
		private Table __p;

		// Token: 0x04004B65 RID: 19301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> HpLostCache;

		// Token: 0x04004B66 RID: 19302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> RankupCache;
	}
}
