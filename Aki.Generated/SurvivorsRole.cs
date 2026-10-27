using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001103 RID: 4355
	public struct SurvivorsRole : IFlatbufferObject
	{
		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600DB1D RID: 56093 RVA: 0x00325430 File Offset: 0x00323630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB1E RID: 56094 RVA: 0x0032543D File Offset: 0x0032363D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x00325444 File Offset: 0x00323644
		public static SurvivorsRole GetRootAsSurvivorsRole(ByteBuffer _bb)
		{
			return SurvivorsRole.GetRootAsSurvivorsRole(_bb, default(SurvivorsRole));
		}

		// Token: 0x0600DB20 RID: 56096 RVA: 0x00325460 File Offset: 0x00323660
		public static SurvivorsRole GetRootAsSurvivorsRole(ByteBuffer _bb, SurvivorsRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x0032547D File Offset: 0x0032367D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x0032548C File Offset: 0x0032368C
		public SurvivorsRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600DB23 RID: 56099 RVA: 0x0032549C File Offset: 0x0032369C
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

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600DB24 RID: 56100 RVA: 0x003254D8 File Offset: 0x003236D8
		public int ActivityId
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

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600DB25 RID: 56101 RVA: 0x00325514 File Offset: 0x00323714
		public int InitWeapon
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

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600DB26 RID: 56102 RVA: 0x00325550 File Offset: 0x00323750
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

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600DB27 RID: 56103 RVA: 0x00325590 File Offset: 0x00323790
		public int UnlockConditionId
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

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600DB28 RID: 56104 RVA: 0x003255D0 File Offset: 0x003237D0
		public int Maxlevel
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

		// Token: 0x0600DB29 RID: 56105 RVA: 0x00325610 File Offset: 0x00323810
		public DicIntInt? EvolveIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x00325674 File Offset: 0x00323874
		public int EvolveIdsLength
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

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600DB2B RID: 56107 RVA: 0x003256A0 File Offset: 0x003238A0
		public int SortId
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

		// Token: 0x0600DB2C RID: 56108 RVA: 0x003256E0 File Offset: 0x003238E0
		public int RecommendProperty(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600DB2D RID: 56109 RVA: 0x00325720 File Offset: 0x00323920
		public int RecommendPropertyLength
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

		// Token: 0x0600DB2E RID: 56110 RVA: 0x0032574C File Offset: 0x0032394C
		public Span<int> GetRecommendPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DB2F RID: 56111 RVA: 0x0032575C File Offset: 0x0032395C
		public int[] GetRecommendPropertyArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00325774 File Offset: 0x00323974
		public int PropertyList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600DB31 RID: 56113 RVA: 0x003257B4 File Offset: 0x003239B4
		public int PropertyListLength
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

		// Token: 0x0600DB32 RID: 56114 RVA: 0x003257E0 File Offset: 0x003239E0
		public Span<int> GetPropertyListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DB33 RID: 56115 RVA: 0x003257F0 File Offset: 0x003239F0
		public int[] GetPropertyListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600DB34 RID: 56116 RVA: 0x00325808 File Offset: 0x00323A08
		public int TemplateId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600DB35 RID: 56117 RVA: 0x00325848 File Offset: 0x00323A48
		public int PropId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DB36 RID: 56118 RVA: 0x00325888 File Offset: 0x00323A88
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EvolveIdsFrozenDict()缓存字典，遍历请使用EvolveIdsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> EvolveIds()
		{
			return this.EvolveIdsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DB37 RID: 56119 RVA: 0x003258DE File Offset: 0x00323ADE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> EvolveIdsIter()
		{
			SurvivorsRole.<EvolveIdsIter>d__40 <EvolveIdsIter>d__ = new SurvivorsRole.<EvolveIdsIter>d__40(-2);
			<EvolveIdsIter>d__.<>3__<>4__this = this;
			return <EvolveIdsIter>d__;
		}

		// Token: 0x0600DB38 RID: 56120 RVA: 0x003258F4 File Offset: 0x00323AF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropertyListIter()或GetPropertyListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PropertyList()
		{
			SurvivorsRole survivorsRole = this;
			return survivorsRole.GetPropertyListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DB39 RID: 56121 RVA: 0x00325918 File Offset: 0x00323B18
		[NullableContext(1)]
		public readonly IEnumerable<int> PropertyListIter()
		{
			SurvivorsRole.<PropertyListIter>d__42 <PropertyListIter>d__ = new SurvivorsRole.<PropertyListIter>d__42(-2);
			<PropertyListIter>d__.<>3__<>4__this = this;
			return <PropertyListIter>d__;
		}

		// Token: 0x0600DB3A RID: 56122 RVA: 0x00325930 File Offset: 0x00323B30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendPropertyIter()或GetRecommendPropertyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendProperty()
		{
			SurvivorsRole survivorsRole = this;
			return survivorsRole.GetRecommendPropertyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DB3B RID: 56123 RVA: 0x00325954 File Offset: 0x00323B54
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendPropertyIter()
		{
			SurvivorsRole.<RecommendPropertyIter>d__44 <RecommendPropertyIter>d__ = new SurvivorsRole.<RecommendPropertyIter>d__44(-2);
			<RecommendPropertyIter>d__.<>3__<>4__this = this;
			return <RecommendPropertyIter>d__;
		}

		// Token: 0x0600DB3C RID: 56124 RVA: 0x0032596C File Offset: 0x00323B6C
		public int? GetEvolveIds(int key)
		{
			this.EnsureEvolveIdsCacheIfNeeded();
			int value;
			if (!this.EvolveIdsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x003259A0 File Offset: 0x00323BA0
		private void EnsureEvolveIdsCacheIfNeeded()
		{
			if (this.EvolveIdsCache != null)
			{
				return;
			}
			this.EvolveIdsCache = this.EvolveIdsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00325A06 File Offset: 0x00323C06
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetEvolveIdsFrozenDict(int key)
		{
			this.EnsureEvolveIdsCacheIfNeeded();
			return this.EvolveIdsCache;
		}

		// Token: 0x0400523B RID: 21051
		private Table __p;

		// Token: 0x0400523C RID: 21052
		[Nullable(2)]
		private FrozenDictionary<int, int> EvolveIdsCache;
	}
}
