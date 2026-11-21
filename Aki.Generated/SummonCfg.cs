using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200122C RID: 4652
	public struct SummonCfg : IFlatbufferObject
	{
		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0600E71B RID: 59163 RVA: 0x0034D934 File Offset: 0x0034BB34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x0034D941 File Offset: 0x0034BB41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E71D RID: 59165 RVA: 0x0034D948 File Offset: 0x0034BB48
		public static SummonCfg GetRootAsSummonCfg(ByteBuffer _bb)
		{
			return SummonCfg.GetRootAsSummonCfg(_bb, default(SummonCfg));
		}

		// Token: 0x0600E71E RID: 59166 RVA: 0x0034D964 File Offset: 0x0034BB64
		public static SummonCfg GetRootAsSummonCfg(ByteBuffer _bb, SummonCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E71F RID: 59167 RVA: 0x0034D981 File Offset: 0x0034BB81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E720 RID: 59168 RVA: 0x0034D990 File Offset: 0x0034BB90
		public SummonCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600E721 RID: 59169 RVA: 0x0034D9A0 File Offset: 0x0034BBA0
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

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0600E722 RID: 59170 RVA: 0x0034D9DC File Offset: 0x0034BBDC
		public string BlueprintType
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

		// Token: 0x0600E723 RID: 59171 RVA: 0x0034DA13 File Offset: 0x0034BC13
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x0034DA22 File Offset: 0x0034BC22
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0600E725 RID: 59173 RVA: 0x0034DA3C File Offset: 0x0034BC3C
		public int SurvivalTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0600E726 RID: 59174 RVA: 0x0034DA78 File Offset: 0x0034BC78
		public int InheritLevelType
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

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0600E727 RID: 59175 RVA: 0x0034DAB8 File Offset: 0x0034BCB8
		public int InheritLevelParam
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

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0600E728 RID: 59176 RVA: 0x0034DAF8 File Offset: 0x0034BCF8
		public int AttributeType
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

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x0600E729 RID: 59177 RVA: 0x0034DB38 File Offset: 0x0034BD38
		public int InheritAttributeBaseType
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

		// Token: 0x0600E72A RID: 59178 RVA: 0x0034DB78 File Offset: 0x0034BD78
		public DicIntIntArray? InheritSummonerAttribute(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0600E72B RID: 59179 RVA: 0x0034DBDC File Offset: 0x0034BDDC
		public int InheritSummonerAttributeLength
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

		// Token: 0x0600E72C RID: 59180 RVA: 0x0034DC08 File Offset: 0x0034BE08
		public int UnCalculateBuffAttributes(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0600E72D RID: 59181 RVA: 0x0034DC48 File Offset: 0x0034BE48
		public int UnCalculateBuffAttributesLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x0034DC74 File Offset: 0x0034BE74
		public Span<int> GetUnCalculateBuffAttributesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E72F RID: 59183 RVA: 0x0034DC84 File Offset: 0x0034BE84
		public int[] GetUnCalculateBuffAttributesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E730 RID: 59184 RVA: 0x0034DC9C File Offset: 0x0034BE9C
		public int FollowSummonerAttr(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0600E731 RID: 59185 RVA: 0x0034DCDC File Offset: 0x0034BEDC
		public int FollowSummonerAttrLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x0034DD08 File Offset: 0x0034BF08
		public Span<int> GetFollowSummonerAttrBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x0034DD18 File Offset: 0x0034BF18
		public int[] GetFollowSummonerAttrArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x0034DD30 File Offset: 0x0034BF30
		public long BornBuffId(int j)
		{
			int num = this.__p.__offset(24);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x0600E735 RID: 59189 RVA: 0x0034DD7C File Offset: 0x0034BF7C
		public int BornBuffIdLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x0034DDA8 File Offset: 0x0034BFA8
		public Span<long> GetBornBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(24, 8));
		}

		// Token: 0x0600E737 RID: 59191 RVA: 0x0034DDBD File Offset: 0x0034BFBD
		public long[] GetBornBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(24) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600E738 RID: 59192 RVA: 0x0034DDFC File Offset: 0x0034BFFC
		public bool ShareDamage
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600E739 RID: 59193 RVA: 0x0034DE3C File Offset: 0x0034C03C
		public bool InitVisiable
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E73A RID: 59194 RVA: 0x0034DE7C File Offset: 0x0034C07C
		public long BornSelectDamageAttributeTargetBuff(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600E73B RID: 59195 RVA: 0x0034DEC8 File Offset: 0x0034C0C8
		public int BornSelectDamageAttributeTargetBuffLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E73C RID: 59196 RVA: 0x0034DEF4 File Offset: 0x0034C0F4
		public Span<long> GetBornSelectDamageAttributeTargetBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x0600E73D RID: 59197 RVA: 0x0034DF09 File Offset: 0x0034C109
		public long[] GetBornSelectDamageAttributeTargetBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600E73E RID: 59198 RVA: 0x0034DF48 File Offset: 0x0034C148
		public string ShowWeaponSubMesh(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0600E73F RID: 59199 RVA: 0x0034DF84 File Offset: 0x0034C184
		public int ShowWeaponSubMeshLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E740 RID: 59200 RVA: 0x0034DFB0 File Offset: 0x0034C1B0
		public int ApplyTriggerRoles(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x0600E741 RID: 59201 RVA: 0x0034DFF0 File Offset: 0x0034C1F0
		public int ApplyTriggerRolesLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E742 RID: 59202 RVA: 0x0034E01C File Offset: 0x0034C21C
		public Span<int> GetApplyTriggerRolesBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600E743 RID: 59203 RVA: 0x0034E02C File Offset: 0x0034C22C
		public int[] GetApplyTriggerRolesArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x0600E744 RID: 59204 RVA: 0x0034E044 File Offset: 0x0034C244
		[NullableContext(1)]
		public int[] ApplyTriggerRoles()
		{
			return this.GetApplyTriggerRolesArray();
		}

		// Token: 0x0600E745 RID: 59205 RVA: 0x0034E04C File Offset: 0x0034C24C
		[NullableContext(1)]
		public IEnumerable<int> ApplyTriggerRolesIter()
		{
			SummonCfg.<ApplyTriggerRolesIter>d__60 <ApplyTriggerRolesIter>d__ = new SummonCfg.<ApplyTriggerRolesIter>d__60(-2);
			<ApplyTriggerRolesIter>d__.<>3__<>4__this = this;
			return <ApplyTriggerRolesIter>d__;
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x0034E061 File Offset: 0x0034C261
		[NullableContext(1)]
		public long[] BornBuffId()
		{
			return this.GetBornBuffIdArray();
		}

		// Token: 0x0600E747 RID: 59207 RVA: 0x0034E069 File Offset: 0x0034C269
		[NullableContext(1)]
		public IEnumerable<long> BornBuffIdIter()
		{
			SummonCfg.<BornBuffIdIter>d__62 <BornBuffIdIter>d__ = new SummonCfg.<BornBuffIdIter>d__62(-2);
			<BornBuffIdIter>d__.<>3__<>4__this = this;
			return <BornBuffIdIter>d__;
		}

		// Token: 0x0600E748 RID: 59208 RVA: 0x0034E07E File Offset: 0x0034C27E
		[NullableContext(1)]
		public long[] BornSelectDamageAttributeTargetBuff()
		{
			return this.GetBornSelectDamageAttributeTargetBuffArray();
		}

		// Token: 0x0600E749 RID: 59209 RVA: 0x0034E086 File Offset: 0x0034C286
		[NullableContext(1)]
		public IEnumerable<long> BornSelectDamageAttributeTargetBuffIter()
		{
			SummonCfg.<BornSelectDamageAttributeTargetBuffIter>d__64 <BornSelectDamageAttributeTargetBuffIter>d__ = new SummonCfg.<BornSelectDamageAttributeTargetBuffIter>d__64(-2);
			<BornSelectDamageAttributeTargetBuffIter>d__.<>3__<>4__this = this;
			return <BornSelectDamageAttributeTargetBuffIter>d__;
		}

		// Token: 0x0600E74A RID: 59210 RVA: 0x0034E09B File Offset: 0x0034C29B
		[NullableContext(1)]
		public int[] FollowSummonerAttr()
		{
			return this.GetFollowSummonerAttrArray();
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x0034E0A3 File Offset: 0x0034C2A3
		[NullableContext(1)]
		public IEnumerable<int> FollowSummonerAttrIter()
		{
			SummonCfg.<FollowSummonerAttrIter>d__66 <FollowSummonerAttrIter>d__ = new SummonCfg.<FollowSummonerAttrIter>d__66(-2);
			<FollowSummonerAttrIter>d__.<>3__<>4__this = this;
			return <FollowSummonerAttrIter>d__;
		}

		// Token: 0x0600E74C RID: 59212 RVA: 0x0034E0B8 File Offset: 0x0034C2B8
		[NullableContext(1)]
		public Dictionary<int, IntArray> InheritSummonerAttribute()
		{
			return this.InheritSummonerAttributeIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600E74D RID: 59213 RVA: 0x0034E10E File Offset: 0x0034C30E
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> InheritSummonerAttributeIter()
		{
			SummonCfg.<InheritSummonerAttributeIter>d__68 <InheritSummonerAttributeIter>d__ = new SummonCfg.<InheritSummonerAttributeIter>d__68(-2);
			<InheritSummonerAttributeIter>d__.<>3__<>4__this = this;
			return <InheritSummonerAttributeIter>d__;
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x0034E123 File Offset: 0x0034C323
		[NullableContext(1)]
		public string[] ShowWeaponSubMesh()
		{
			return this.ShowWeaponSubMeshIter().ToArray<string>();
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x0034E130 File Offset: 0x0034C330
		[NullableContext(1)]
		public IEnumerable<string> ShowWeaponSubMeshIter()
		{
			SummonCfg.<ShowWeaponSubMeshIter>d__70 <ShowWeaponSubMeshIter>d__ = new SummonCfg.<ShowWeaponSubMeshIter>d__70(-2);
			<ShowWeaponSubMeshIter>d__.<>3__<>4__this = this;
			return <ShowWeaponSubMeshIter>d__;
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x0034E145 File Offset: 0x0034C345
		[NullableContext(1)]
		public int[] UnCalculateBuffAttributes()
		{
			return this.GetUnCalculateBuffAttributesArray();
		}

		// Token: 0x0600E751 RID: 59217 RVA: 0x0034E14D File Offset: 0x0034C34D
		[NullableContext(1)]
		public IEnumerable<int> UnCalculateBuffAttributesIter()
		{
			SummonCfg.<UnCalculateBuffAttributesIter>d__72 <UnCalculateBuffAttributesIter>d__ = new SummonCfg.<UnCalculateBuffAttributesIter>d__72(-2);
			<UnCalculateBuffAttributesIter>d__.<>3__<>4__this = this;
			return <UnCalculateBuffAttributesIter>d__;
		}

		// Token: 0x0600E752 RID: 59218 RVA: 0x0034E164 File Offset: 0x0034C364
		public IntArray? GetInheritSummonerAttribute(int key)
		{
			this.EnsureInheritSummonerAttributeCacheIfNeeded();
			IntArray value;
			if (!this.InheritSummonerAttributeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600E753 RID: 59219 RVA: 0x0034E198 File Offset: 0x0034C398
		private void EnsureInheritSummonerAttributeCacheIfNeeded()
		{
			if (this.InheritSummonerAttributeCache != null)
			{
				return;
			}
			this.InheritSummonerAttributeCache = this.InheritSummonerAttributeIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x0034E1FE File Offset: 0x0034C3FE
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetInheritSummonerAttributeFrozenDict()
		{
			this.EnsureInheritSummonerAttributeCacheIfNeeded();
			return this.InheritSummonerAttributeCache;
		}

		// Token: 0x0400586D RID: 22637
		private Table __p;

		// Token: 0x0400586E RID: 22638
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> InheritSummonerAttributeCache;
	}
}
