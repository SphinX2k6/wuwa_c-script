using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001242 RID: 4674
	public struct SurvivorsWeapon : IFlatbufferObject
	{
		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0600E95C RID: 59740 RVA: 0x00352B58 File Offset: 0x00350D58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x00352B65 File Offset: 0x00350D65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x00352B6C File Offset: 0x00350D6C
		public static SurvivorsWeapon GetRootAsSurvivorsWeapon(ByteBuffer _bb)
		{
			return SurvivorsWeapon.GetRootAsSurvivorsWeapon(_bb, default(SurvivorsWeapon));
		}

		// Token: 0x0600E95F RID: 59743 RVA: 0x00352B88 File Offset: 0x00350D88
		public static SurvivorsWeapon GetRootAsSurvivorsWeapon(ByteBuffer _bb, SurvivorsWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x00352BA5 File Offset: 0x00350DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E961 RID: 59745 RVA: 0x00352BB4 File Offset: 0x00350DB4
		public SurvivorsWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0600E962 RID: 59746 RVA: 0x00352BC4 File Offset: 0x00350DC4
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

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0600E963 RID: 59747 RVA: 0x00352C00 File Offset: 0x00350E00
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

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0600E964 RID: 59748 RVA: 0x00352C3C File Offset: 0x00350E3C
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

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0600E965 RID: 59749 RVA: 0x00352C78 File Offset: 0x00350E78
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

		// Token: 0x0600E966 RID: 59750 RVA: 0x00352CB8 File Offset: 0x00350EB8
		public int BindWeaponsId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0600E967 RID: 59751 RVA: 0x00352CF8 File Offset: 0x00350EF8
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

		// Token: 0x0600E968 RID: 59752 RVA: 0x00352D24 File Offset: 0x00350F24
		public Span<int> GetBindWeaponsIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x00352D34 File Offset: 0x00350F34
		public int[] GetBindWeaponsIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E96A RID: 59754 RVA: 0x00352D4C File Offset: 0x00350F4C
		public DicIntInt? EvolveIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0600E96B RID: 59755 RVA: 0x00352DB0 File Offset: 0x00350FB0
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

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0600E96C RID: 59756 RVA: 0x00352DDC File Offset: 0x00350FDC
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

		// Token: 0x0600E96D RID: 59757 RVA: 0x00352E14 File Offset: 0x00351014
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x00352E24 File Offset: 0x00351024
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x0600E96F RID: 59759 RVA: 0x00352E3C File Offset: 0x0035103C
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

		// Token: 0x0600E970 RID: 59760 RVA: 0x00352E74 File Offset: 0x00351074
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E971 RID: 59761 RVA: 0x00352E84 File Offset: 0x00351084
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x0600E972 RID: 59762 RVA: 0x00352E9C File Offset: 0x0035109C
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

		// Token: 0x0600E973 RID: 59763 RVA: 0x00352EDC File Offset: 0x003510DC
		public int RecommendProperty(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x0600E974 RID: 59764 RVA: 0x00352F1C File Offset: 0x0035111C
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

		// Token: 0x0600E975 RID: 59765 RVA: 0x00352F48 File Offset: 0x00351148
		public Span<int> GetRecommendPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x00352F58 File Offset: 0x00351158
		public int[] GetRecommendPropertyArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E977 RID: 59767 RVA: 0x00352F70 File Offset: 0x00351170
		public int PropertyList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0600E978 RID: 59768 RVA: 0x00352FB0 File Offset: 0x003511B0
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

		// Token: 0x0600E979 RID: 59769 RVA: 0x00352FDC File Offset: 0x003511DC
		public Span<int> GetPropertyListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600E97A RID: 59770 RVA: 0x00352FEC File Offset: 0x003511EC
		public int[] GetPropertyListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0600E97B RID: 59771 RVA: 0x00353004 File Offset: 0x00351204
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

		// Token: 0x0600E97C RID: 59772 RVA: 0x00353041 File Offset: 0x00351241
		[NullableContext(1)]
		public int[] BindWeaponsId()
		{
			return this.GetBindWeaponsIdArray();
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x00353049 File Offset: 0x00351249
		[NullableContext(1)]
		public IEnumerable<int> BindWeaponsIdIter()
		{
			SurvivorsWeapon.<BindWeaponsIdIter>d__47 <BindWeaponsIdIter>d__ = new SurvivorsWeapon.<BindWeaponsIdIter>d__47(-2);
			<BindWeaponsIdIter>d__.<>3__<>4__this = this;
			return <BindWeaponsIdIter>d__;
		}

		// Token: 0x0600E97E RID: 59774 RVA: 0x00353060 File Offset: 0x00351260
		[NullableContext(1)]
		public Dictionary<int, int> EvolveIds()
		{
			return this.EvolveIdsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E97F RID: 59775 RVA: 0x003530B6 File Offset: 0x003512B6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> EvolveIdsIter()
		{
			SurvivorsWeapon.<EvolveIdsIter>d__49 <EvolveIdsIter>d__ = new SurvivorsWeapon.<EvolveIdsIter>d__49(-2);
			<EvolveIdsIter>d__.<>3__<>4__this = this;
			return <EvolveIdsIter>d__;
		}

		// Token: 0x0600E980 RID: 59776 RVA: 0x003530CB File Offset: 0x003512CB
		[NullableContext(1)]
		public int[] PropertyList()
		{
			return this.GetPropertyListArray();
		}

		// Token: 0x0600E981 RID: 59777 RVA: 0x003530D3 File Offset: 0x003512D3
		[NullableContext(1)]
		public IEnumerable<int> PropertyListIter()
		{
			SurvivorsWeapon.<PropertyListIter>d__51 <PropertyListIter>d__ = new SurvivorsWeapon.<PropertyListIter>d__51(-2);
			<PropertyListIter>d__.<>3__<>4__this = this;
			return <PropertyListIter>d__;
		}

		// Token: 0x0600E982 RID: 59778 RVA: 0x003530E8 File Offset: 0x003512E8
		[NullableContext(1)]
		public int[] RecommendProperty()
		{
			return this.GetRecommendPropertyArray();
		}

		// Token: 0x0600E983 RID: 59779 RVA: 0x003530F0 File Offset: 0x003512F0
		[NullableContext(1)]
		public IEnumerable<int> RecommendPropertyIter()
		{
			SurvivorsWeapon.<RecommendPropertyIter>d__53 <RecommendPropertyIter>d__ = new SurvivorsWeapon.<RecommendPropertyIter>d__53(-2);
			<RecommendPropertyIter>d__.<>3__<>4__this = this;
			return <RecommendPropertyIter>d__;
		}

		// Token: 0x0600E984 RID: 59780 RVA: 0x00353108 File Offset: 0x00351308
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

		// Token: 0x0600E985 RID: 59781 RVA: 0x0035313C File Offset: 0x0035133C
		private void EnsureEvolveIdsCacheIfNeeded()
		{
			if (this.EvolveIdsCache != null)
			{
				return;
			}
			this.EvolveIdsCache = this.EvolveIdsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E986 RID: 59782 RVA: 0x003531A2 File Offset: 0x003513A2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetEvolveIdsFrozenDict()
		{
			this.EnsureEvolveIdsCacheIfNeeded();
			return this.EvolveIdsCache;
		}

		// Token: 0x0400588A RID: 22666
		private Table __p;

		// Token: 0x0400588B RID: 22667
		[Nullable(2)]
		private FrozenDictionary<int, int> EvolveIdsCache;
	}
}
