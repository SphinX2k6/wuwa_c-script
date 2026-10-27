using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110C RID: 4364
	public struct SurvivorsWeapon : IFlatbufferObject
	{
		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600DC11 RID: 56337 RVA: 0x0032796C File Offset: 0x00325B6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC12 RID: 56338 RVA: 0x00327979 File Offset: 0x00325B79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC13 RID: 56339 RVA: 0x00327980 File Offset: 0x00325B80
		public static SurvivorsWeapon GetRootAsSurvivorsWeapon(ByteBuffer _bb)
		{
			return SurvivorsWeapon.GetRootAsSurvivorsWeapon(_bb, default(SurvivorsWeapon));
		}

		// Token: 0x0600DC14 RID: 56340 RVA: 0x0032799C File Offset: 0x00325B9C
		public static SurvivorsWeapon GetRootAsSurvivorsWeapon(ByteBuffer _bb, SurvivorsWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC15 RID: 56341 RVA: 0x003279B9 File Offset: 0x00325BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC16 RID: 56342 RVA: 0x003279C8 File Offset: 0x00325BC8
		public SurvivorsWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600DC17 RID: 56343 RVA: 0x003279D8 File Offset: 0x00325BD8
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

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600DC18 RID: 56344 RVA: 0x00327A14 File Offset: 0x00325C14
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

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600DC19 RID: 56345 RVA: 0x00327A50 File Offset: 0x00325C50
		public int UnlockConditionId
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

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600DC1A RID: 56346 RVA: 0x00327A8C File Offset: 0x00325C8C
		public int Maxlevel
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

		// Token: 0x0600DC1B RID: 56347 RVA: 0x00327ACC File Offset: 0x00325CCC
		public int BindWeaponsId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600DC1C RID: 56348 RVA: 0x00327B0C File Offset: 0x00325D0C
		public int BindWeaponsIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC1D RID: 56349 RVA: 0x00327B38 File Offset: 0x00325D38
		public Span<int> GetBindWeaponsIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600DC1E RID: 56350 RVA: 0x00327B48 File Offset: 0x00325D48
		public int[] GetBindWeaponsIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC1F RID: 56351 RVA: 0x00327B60 File Offset: 0x00325D60
		public DicIntInt? EvolveIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600DC20 RID: 56352 RVA: 0x00327BC4 File Offset: 0x00325DC4
		public int EvolveIdsLength
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

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600DC21 RID: 56353 RVA: 0x00327BF0 File Offset: 0x00325DF0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC22 RID: 56354 RVA: 0x00327C28 File Offset: 0x00325E28
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DC23 RID: 56355 RVA: 0x00327C38 File Offset: 0x00325E38
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600DC24 RID: 56356 RVA: 0x00327C50 File Offset: 0x00325E50
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC25 RID: 56357 RVA: 0x00327C88 File Offset: 0x00325E88
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DC26 RID: 56358 RVA: 0x00327C98 File Offset: 0x00325E98
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600DC27 RID: 56359 RVA: 0x00327CB0 File Offset: 0x00325EB0
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC28 RID: 56360 RVA: 0x00327CF0 File Offset: 0x00325EF0
		public int RecommendProperty(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600DC29 RID: 56361 RVA: 0x00327D30 File Offset: 0x00325F30
		public int RecommendPropertyLength
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

		// Token: 0x0600DC2A RID: 56362 RVA: 0x00327D5C File Offset: 0x00325F5C
		public Span<int> GetRecommendPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x00327D6C File Offset: 0x00325F6C
		public int[] GetRecommendPropertyArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x00327D84 File Offset: 0x00325F84
		public int PropertyList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600DC2D RID: 56365 RVA: 0x00327DC4 File Offset: 0x00325FC4
		public int PropertyListLength
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

		// Token: 0x0600DC2E RID: 56366 RVA: 0x00327DF0 File Offset: 0x00325FF0
		public Span<int> GetPropertyListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600DC2F RID: 56367 RVA: 0x00327E00 File Offset: 0x00326000
		public int[] GetPropertyListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600DC30 RID: 56368 RVA: 0x00327E18 File Offset: 0x00326018
		public int TemplateId
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

		// Token: 0x0600DC31 RID: 56369 RVA: 0x00327E58 File Offset: 0x00326058
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BindWeaponsIdIter()或GetBindWeaponsIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BindWeaponsId()
		{
			SurvivorsWeapon survivorsWeapon = this;
			return survivorsWeapon.GetBindWeaponsIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DC32 RID: 56370 RVA: 0x00327E7C File Offset: 0x0032607C
		[NullableContext(1)]
		public readonly IEnumerable<int> BindWeaponsIdIter()
		{
			SurvivorsWeapon.<BindWeaponsIdIter>d__47 <BindWeaponsIdIter>d__ = new SurvivorsWeapon.<BindWeaponsIdIter>d__47(-2);
			<BindWeaponsIdIter>d__.<>3__<>4__this = this;
			return <BindWeaponsIdIter>d__;
		}

		// Token: 0x0600DC33 RID: 56371 RVA: 0x00327E94 File Offset: 0x00326094
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EvolveIdsFrozenDict()缓存字典，遍历请使用EvolveIdsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> EvolveIds()
		{
			return this.EvolveIdsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DC34 RID: 56372 RVA: 0x00327EEA File Offset: 0x003260EA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> EvolveIdsIter()
		{
			SurvivorsWeapon.<EvolveIdsIter>d__49 <EvolveIdsIter>d__ = new SurvivorsWeapon.<EvolveIdsIter>d__49(-2);
			<EvolveIdsIter>d__.<>3__<>4__this = this;
			return <EvolveIdsIter>d__;
		}

		// Token: 0x0600DC35 RID: 56373 RVA: 0x00327F00 File Offset: 0x00326100
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropertyListIter()或GetPropertyListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PropertyList()
		{
			SurvivorsWeapon survivorsWeapon = this;
			return survivorsWeapon.GetPropertyListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DC36 RID: 56374 RVA: 0x00327F24 File Offset: 0x00326124
		[NullableContext(1)]
		public readonly IEnumerable<int> PropertyListIter()
		{
			SurvivorsWeapon.<PropertyListIter>d__51 <PropertyListIter>d__ = new SurvivorsWeapon.<PropertyListIter>d__51(-2);
			<PropertyListIter>d__.<>3__<>4__this = this;
			return <PropertyListIter>d__;
		}

		// Token: 0x0600DC37 RID: 56375 RVA: 0x00327F3C File Offset: 0x0032613C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendPropertyIter()或GetRecommendPropertyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendProperty()
		{
			SurvivorsWeapon survivorsWeapon = this;
			return survivorsWeapon.GetRecommendPropertyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DC38 RID: 56376 RVA: 0x00327F60 File Offset: 0x00326160
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendPropertyIter()
		{
			SurvivorsWeapon.<RecommendPropertyIter>d__53 <RecommendPropertyIter>d__ = new SurvivorsWeapon.<RecommendPropertyIter>d__53(-2);
			<RecommendPropertyIter>d__.<>3__<>4__this = this;
			return <RecommendPropertyIter>d__;
		}

		// Token: 0x0600DC39 RID: 56377 RVA: 0x00327F78 File Offset: 0x00326178
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

		// Token: 0x0600DC3A RID: 56378 RVA: 0x00327FAC File Offset: 0x003261AC
		private void EnsureEvolveIdsCacheIfNeeded()
		{
			if (this.EvolveIdsCache != null)
			{
				return;
			}
			this.EvolveIdsCache = this.EvolveIdsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DC3B RID: 56379 RVA: 0x00328012 File Offset: 0x00326212
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetEvolveIdsFrozenDict(int key)
		{
			this.EnsureEvolveIdsCacheIfNeeded();
			return this.EvolveIdsCache;
		}

		// Token: 0x04005247 RID: 21063
		private Table __p;

		// Token: 0x04005248 RID: 21064
		[Nullable(2)]
		private FrozenDictionary<int, int> EvolveIdsCache;
	}
}
