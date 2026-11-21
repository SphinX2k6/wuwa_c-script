using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001239 RID: 4665
	public struct SurvivorsRole : IFlatbufferObject
	{
		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600E868 RID: 59496 RVA: 0x00350768 File Offset: 0x0034E968
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E869 RID: 59497 RVA: 0x00350775 File Offset: 0x0034E975
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E86A RID: 59498 RVA: 0x0035077C File Offset: 0x0034E97C
		public static SurvivorsRole GetRootAsSurvivorsRole(ByteBuffer _bb)
		{
			return SurvivorsRole.GetRootAsSurvivorsRole(_bb, default(SurvivorsRole));
		}

		// Token: 0x0600E86B RID: 59499 RVA: 0x00350798 File Offset: 0x0034E998
		public static SurvivorsRole GetRootAsSurvivorsRole(ByteBuffer _bb, SurvivorsRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E86C RID: 59500 RVA: 0x003507B5 File Offset: 0x0034E9B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E86D RID: 59501 RVA: 0x003507C4 File Offset: 0x0034E9C4
		public SurvivorsRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600E86E RID: 59502 RVA: 0x003507D4 File Offset: 0x0034E9D4
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

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0600E86F RID: 59503 RVA: 0x00350810 File Offset: 0x0034EA10
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

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0600E870 RID: 59504 RVA: 0x0035084C File Offset: 0x0034EA4C
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

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0600E871 RID: 59505 RVA: 0x00350888 File Offset: 0x0034EA88
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

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0600E872 RID: 59506 RVA: 0x003508C8 File Offset: 0x0034EAC8
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

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0600E873 RID: 59507 RVA: 0x00350908 File Offset: 0x0034EB08
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

		// Token: 0x0600E874 RID: 59508 RVA: 0x00350948 File Offset: 0x0034EB48
		public DicIntInt? EvolveIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x0600E875 RID: 59509 RVA: 0x003509AC File Offset: 0x0034EBAC
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

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0600E876 RID: 59510 RVA: 0x003509D8 File Offset: 0x0034EBD8
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

		// Token: 0x0600E877 RID: 59511 RVA: 0x00350A18 File Offset: 0x0034EC18
		public int RecommendProperty(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0600E878 RID: 59512 RVA: 0x00350A58 File Offset: 0x0034EC58
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

		// Token: 0x0600E879 RID: 59513 RVA: 0x00350A84 File Offset: 0x0034EC84
		public Span<int> GetRecommendPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E87A RID: 59514 RVA: 0x00350A94 File Offset: 0x0034EC94
		public int[] GetRecommendPropertyArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E87B RID: 59515 RVA: 0x00350AAC File Offset: 0x0034ECAC
		public int PropertyList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600E87C RID: 59516 RVA: 0x00350AEC File Offset: 0x0034ECEC
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

		// Token: 0x0600E87D RID: 59517 RVA: 0x00350B18 File Offset: 0x0034ED18
		public Span<int> GetPropertyListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E87E RID: 59518 RVA: 0x00350B28 File Offset: 0x0034ED28
		public int[] GetPropertyListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0600E87F RID: 59519 RVA: 0x00350B40 File Offset: 0x0034ED40
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

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600E880 RID: 59520 RVA: 0x00350B80 File Offset: 0x0034ED80
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

		// Token: 0x0600E881 RID: 59521 RVA: 0x00350BC0 File Offset: 0x0034EDC0
		[NullableContext(1)]
		public Dictionary<int, int> EvolveIds()
		{
			return this.EvolveIdsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E882 RID: 59522 RVA: 0x00350C16 File Offset: 0x0034EE16
		[NullableContext(1)]
		public IEnumerable<DicIntInt> EvolveIdsIter()
		{
			SurvivorsRole.<EvolveIdsIter>d__40 <EvolveIdsIter>d__ = new SurvivorsRole.<EvolveIdsIter>d__40(-2);
			<EvolveIdsIter>d__.<>3__<>4__this = this;
			return <EvolveIdsIter>d__;
		}

		// Token: 0x0600E883 RID: 59523 RVA: 0x00350C2B File Offset: 0x0034EE2B
		[NullableContext(1)]
		public int[] PropertyList()
		{
			return this.GetPropertyListArray();
		}

		// Token: 0x0600E884 RID: 59524 RVA: 0x00350C33 File Offset: 0x0034EE33
		[NullableContext(1)]
		public IEnumerable<int> PropertyListIter()
		{
			SurvivorsRole.<PropertyListIter>d__42 <PropertyListIter>d__ = new SurvivorsRole.<PropertyListIter>d__42(-2);
			<PropertyListIter>d__.<>3__<>4__this = this;
			return <PropertyListIter>d__;
		}

		// Token: 0x0600E885 RID: 59525 RVA: 0x00350C48 File Offset: 0x0034EE48
		[NullableContext(1)]
		public int[] RecommendProperty()
		{
			return this.GetRecommendPropertyArray();
		}

		// Token: 0x0600E886 RID: 59526 RVA: 0x00350C50 File Offset: 0x0034EE50
		[NullableContext(1)]
		public IEnumerable<int> RecommendPropertyIter()
		{
			SurvivorsRole.<RecommendPropertyIter>d__44 <RecommendPropertyIter>d__ = new SurvivorsRole.<RecommendPropertyIter>d__44(-2);
			<RecommendPropertyIter>d__.<>3__<>4__this = this;
			return <RecommendPropertyIter>d__;
		}

		// Token: 0x0600E887 RID: 59527 RVA: 0x00350C68 File Offset: 0x0034EE68
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

		// Token: 0x0600E888 RID: 59528 RVA: 0x00350C9C File Offset: 0x0034EE9C
		private void EnsureEvolveIdsCacheIfNeeded()
		{
			if (this.EvolveIdsCache != null)
			{
				return;
			}
			this.EvolveIdsCache = this.EvolveIdsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E889 RID: 59529 RVA: 0x00350D02 File Offset: 0x0034EF02
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetEvolveIdsFrozenDict()
		{
			this.EnsureEvolveIdsCacheIfNeeded();
			return this.EvolveIdsCache;
		}

		// Token: 0x0400587E RID: 22654
		private Table __p;

		// Token: 0x0400587F RID: 22655
		[Nullable(2)]
		private FrozenDictionary<int, int> EvolveIdsCache;
	}
}
