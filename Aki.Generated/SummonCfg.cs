using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F6 RID: 4342
	public struct SummonCfg : IFlatbufferObject
	{
		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600D9D0 RID: 55760 RVA: 0x003223CC File Offset: 0x003205CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x003223D9 File Offset: 0x003205D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x003223E0 File Offset: 0x003205E0
		public static SummonCfg GetRootAsSummonCfg(ByteBuffer _bb)
		{
			return SummonCfg.GetRootAsSummonCfg(_bb, default(SummonCfg));
		}

		// Token: 0x0600D9D3 RID: 55763 RVA: 0x003223FC File Offset: 0x003205FC
		public static SummonCfg GetRootAsSummonCfg(ByteBuffer _bb, SummonCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D9D4 RID: 55764 RVA: 0x00322419 File Offset: 0x00320619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D9D5 RID: 55765 RVA: 0x00322428 File Offset: 0x00320628
		public SummonCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600D9D6 RID: 55766 RVA: 0x00322438 File Offset: 0x00320638
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

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600D9D7 RID: 55767 RVA: 0x00322474 File Offset: 0x00320674
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

		// Token: 0x0600D9D8 RID: 55768 RVA: 0x003224AB File Offset: 0x003206AB
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D9D9 RID: 55769 RVA: 0x003224BA File Offset: 0x003206BA
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600D9DA RID: 55770 RVA: 0x003224D4 File Offset: 0x003206D4
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

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600D9DB RID: 55771 RVA: 0x00322510 File Offset: 0x00320710
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

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600D9DC RID: 55772 RVA: 0x00322550 File Offset: 0x00320750
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

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600D9DD RID: 55773 RVA: 0x00322590 File Offset: 0x00320790
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

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600D9DE RID: 55774 RVA: 0x003225D0 File Offset: 0x003207D0
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

		// Token: 0x0600D9DF RID: 55775 RVA: 0x00322610 File Offset: 0x00320810
		public DicIntIntArray? InheritSummonerAttribute(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600D9E0 RID: 55776 RVA: 0x00322674 File Offset: 0x00320874
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

		// Token: 0x0600D9E1 RID: 55777 RVA: 0x003226A0 File Offset: 0x003208A0
		public int UnCalculateBuffAttributes(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600D9E2 RID: 55778 RVA: 0x003226E0 File Offset: 0x003208E0
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

		// Token: 0x0600D9E3 RID: 55779 RVA: 0x0032270C File Offset: 0x0032090C
		public Span<int> GetUnCalculateBuffAttributesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D9E4 RID: 55780 RVA: 0x0032271C File Offset: 0x0032091C
		public int[] GetUnCalculateBuffAttributesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600D9E5 RID: 55781 RVA: 0x00322734 File Offset: 0x00320934
		public int FollowSummonerAttr(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600D9E6 RID: 55782 RVA: 0x00322774 File Offset: 0x00320974
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

		// Token: 0x0600D9E7 RID: 55783 RVA: 0x003227A0 File Offset: 0x003209A0
		public Span<int> GetFollowSummonerAttrBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600D9E8 RID: 55784 RVA: 0x003227B0 File Offset: 0x003209B0
		public int[] GetFollowSummonerAttrArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600D9E9 RID: 55785 RVA: 0x003227C8 File Offset: 0x003209C8
		public long BornBuffId(int j)
		{
			int num = this.__p.__offset(24);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600D9EA RID: 55786 RVA: 0x00322814 File Offset: 0x00320A14
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

		// Token: 0x0600D9EB RID: 55787 RVA: 0x00322840 File Offset: 0x00320A40
		public Span<long> GetBornBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(24, 8));
		}

		// Token: 0x0600D9EC RID: 55788 RVA: 0x00322855 File Offset: 0x00320A55
		public long[] GetBornBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(24) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600D9ED RID: 55789 RVA: 0x00322894 File Offset: 0x00320A94
		public bool ShareDamage
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600D9EE RID: 55790 RVA: 0x003228D4 File Offset: 0x00320AD4
		public bool InitVisiable
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D9EF RID: 55791 RVA: 0x00322914 File Offset: 0x00320B14
		public long BornSelectDamageAttributeTargetBuff(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600D9F0 RID: 55792 RVA: 0x00322960 File Offset: 0x00320B60
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

		// Token: 0x0600D9F1 RID: 55793 RVA: 0x0032298C File Offset: 0x00320B8C
		public Span<long> GetBornSelectDamageAttributeTargetBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x0600D9F2 RID: 55794 RVA: 0x003229A1 File Offset: 0x00320BA1
		public long[] GetBornSelectDamageAttributeTargetBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600D9F3 RID: 55795 RVA: 0x003229E0 File Offset: 0x00320BE0
		public string ShowWeaponSubMesh(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600D9F4 RID: 55796 RVA: 0x00322A1C File Offset: 0x00320C1C
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

		// Token: 0x0600D9F5 RID: 55797 RVA: 0x00322A48 File Offset: 0x00320C48
		public int ApplyTriggerRoles(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x00322A88 File Offset: 0x00320C88
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

		// Token: 0x0600D9F7 RID: 55799 RVA: 0x00322AB4 File Offset: 0x00320CB4
		public Span<int> GetApplyTriggerRolesBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600D9F8 RID: 55800 RVA: 0x00322AC4 File Offset: 0x00320CC4
		public int[] GetApplyTriggerRolesArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x0600D9F9 RID: 55801 RVA: 0x00322ADC File Offset: 0x00320CDC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ApplyTriggerRolesIter()或GetApplyTriggerRolesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ApplyTriggerRoles()
		{
			SummonCfg summonCfg = this;
			return summonCfg.GetApplyTriggerRolesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D9FA RID: 55802 RVA: 0x00322B00 File Offset: 0x00320D00
		[NullableContext(1)]
		public readonly IEnumerable<int> ApplyTriggerRolesIter()
		{
			SummonCfg.<ApplyTriggerRolesIter>d__60 <ApplyTriggerRolesIter>d__ = new SummonCfg.<ApplyTriggerRolesIter>d__60(-2);
			<ApplyTriggerRolesIter>d__.<>3__<>4__this = this;
			return <ApplyTriggerRolesIter>d__;
		}

		// Token: 0x0600D9FB RID: 55803 RVA: 0x00322B18 File Offset: 0x00320D18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornBuffIdIter()或GetBornBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BornBuffId()
		{
			SummonCfg summonCfg = this;
			return summonCfg.GetBornBuffIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600D9FC RID: 55804 RVA: 0x00322B3C File Offset: 0x00320D3C
		[NullableContext(1)]
		public readonly IEnumerable<long> BornBuffIdIter()
		{
			SummonCfg.<BornBuffIdIter>d__62 <BornBuffIdIter>d__ = new SummonCfg.<BornBuffIdIter>d__62(-2);
			<BornBuffIdIter>d__.<>3__<>4__this = this;
			return <BornBuffIdIter>d__;
		}

		// Token: 0x0600D9FD RID: 55805 RVA: 0x00322B54 File Offset: 0x00320D54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornSelectDamageAttributeTargetBuffIter()或GetBornSelectDamageAttributeTargetBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BornSelectDamageAttributeTargetBuff()
		{
			SummonCfg summonCfg = this;
			return summonCfg.GetBornSelectDamageAttributeTargetBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600D9FE RID: 55806 RVA: 0x00322B78 File Offset: 0x00320D78
		[NullableContext(1)]
		public readonly IEnumerable<long> BornSelectDamageAttributeTargetBuffIter()
		{
			SummonCfg.<BornSelectDamageAttributeTargetBuffIter>d__64 <BornSelectDamageAttributeTargetBuffIter>d__ = new SummonCfg.<BornSelectDamageAttributeTargetBuffIter>d__64(-2);
			<BornSelectDamageAttributeTargetBuffIter>d__.<>3__<>4__this = this;
			return <BornSelectDamageAttributeTargetBuffIter>d__;
		}

		// Token: 0x0600D9FF RID: 55807 RVA: 0x00322B90 File Offset: 0x00320D90
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FollowSummonerAttrIter()或GetFollowSummonerAttrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FollowSummonerAttr()
		{
			SummonCfg summonCfg = this;
			return summonCfg.GetFollowSummonerAttrArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA00 RID: 55808 RVA: 0x00322BB4 File Offset: 0x00320DB4
		[NullableContext(1)]
		public readonly IEnumerable<int> FollowSummonerAttrIter()
		{
			SummonCfg.<FollowSummonerAttrIter>d__66 <FollowSummonerAttrIter>d__ = new SummonCfg.<FollowSummonerAttrIter>d__66(-2);
			<FollowSummonerAttrIter>d__.<>3__<>4__this = this;
			return <FollowSummonerAttrIter>d__;
		}

		// Token: 0x0600DA01 RID: 55809 RVA: 0x00322BCC File Offset: 0x00320DCC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InheritSummonerAttributeFrozenDict()缓存字典，遍历请使用InheritSummonerAttributeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> InheritSummonerAttribute()
		{
			return this.InheritSummonerAttributeIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DA02 RID: 55810 RVA: 0x00322C22 File Offset: 0x00320E22
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> InheritSummonerAttributeIter()
		{
			SummonCfg.<InheritSummonerAttributeIter>d__68 <InheritSummonerAttributeIter>d__ = new SummonCfg.<InheritSummonerAttributeIter>d__68(-2);
			<InheritSummonerAttributeIter>d__.<>3__<>4__this = this;
			return <InheritSummonerAttributeIter>d__;
		}

		// Token: 0x0600DA03 RID: 55811 RVA: 0x00322C37 File Offset: 0x00320E37
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowWeaponSubMeshIter()或GetShowWeaponSubMeshBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ShowWeaponSubMesh()
		{
			return this.ShowWeaponSubMeshIter().ToArray<string>();
		}

		// Token: 0x0600DA04 RID: 55812 RVA: 0x00322C44 File Offset: 0x00320E44
		[NullableContext(1)]
		public readonly IEnumerable<string> ShowWeaponSubMeshIter()
		{
			SummonCfg.<ShowWeaponSubMeshIter>d__70 <ShowWeaponSubMeshIter>d__ = new SummonCfg.<ShowWeaponSubMeshIter>d__70(-2);
			<ShowWeaponSubMeshIter>d__.<>3__<>4__this = this;
			return <ShowWeaponSubMeshIter>d__;
		}

		// Token: 0x0600DA05 RID: 55813 RVA: 0x00322C5C File Offset: 0x00320E5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnCalculateBuffAttributesIter()或GetUnCalculateBuffAttributesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnCalculateBuffAttributes()
		{
			SummonCfg summonCfg = this;
			return summonCfg.GetUnCalculateBuffAttributesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA06 RID: 55814 RVA: 0x00322C80 File Offset: 0x00320E80
		[NullableContext(1)]
		public readonly IEnumerable<int> UnCalculateBuffAttributesIter()
		{
			SummonCfg.<UnCalculateBuffAttributesIter>d__72 <UnCalculateBuffAttributesIter>d__ = new SummonCfg.<UnCalculateBuffAttributesIter>d__72(-2);
			<UnCalculateBuffAttributesIter>d__.<>3__<>4__this = this;
			return <UnCalculateBuffAttributesIter>d__;
		}

		// Token: 0x0600DA07 RID: 55815 RVA: 0x00322C98 File Offset: 0x00320E98
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

		// Token: 0x0600DA08 RID: 55816 RVA: 0x00322CCC File Offset: 0x00320ECC
		private void EnsureInheritSummonerAttributeCacheIfNeeded()
		{
			if (this.InheritSummonerAttributeCache != null)
			{
				return;
			}
			this.InheritSummonerAttributeCache = this.InheritSummonerAttributeIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DA09 RID: 55817 RVA: 0x00322D32 File Offset: 0x00320F32
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetInheritSummonerAttributeFrozenDict(int key)
		{
			this.EnsureInheritSummonerAttributeCacheIfNeeded();
			return this.InheritSummonerAttributeCache;
		}

		// Token: 0x0400522A RID: 21034
		private Table __p;

		// Token: 0x0400522B RID: 21035
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> InheritSummonerAttributeCache;
	}
}
