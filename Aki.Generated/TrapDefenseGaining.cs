using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001297 RID: 4759
	public struct TrapDefenseGaining : IFlatbufferObject
	{
		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x0600F0E6 RID: 61670 RVA: 0x0036366F File Offset: 0x0036186F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F0E7 RID: 61671 RVA: 0x0036367C File Offset: 0x0036187C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F0E8 RID: 61672 RVA: 0x00363684 File Offset: 0x00361884
		public static TrapDefenseGaining GetRootAsTrapDefenseGaining(ByteBuffer _bb)
		{
			return TrapDefenseGaining.GetRootAsTrapDefenseGaining(_bb, default(TrapDefenseGaining));
		}

		// Token: 0x0600F0E9 RID: 61673 RVA: 0x003636A0 File Offset: 0x003618A0
		public static TrapDefenseGaining GetRootAsTrapDefenseGaining(ByteBuffer _bb, TrapDefenseGaining obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F0EA RID: 61674 RVA: 0x003636BD File Offset: 0x003618BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F0EB RID: 61675 RVA: 0x003636CC File Offset: 0x003618CC
		public TrapDefenseGaining __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x0600F0EC RID: 61676 RVA: 0x003636DC File Offset: 0x003618DC
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

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x0600F0ED RID: 61677 RVA: 0x00363718 File Offset: 0x00361918
		public int GainingType
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

		// Token: 0x0600F0EE RID: 61678 RVA: 0x00363754 File Offset: 0x00361954
		public int Buffs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x0600F0EF RID: 61679 RVA: 0x00363794 File Offset: 0x00361994
		public int BuffsLength
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

		// Token: 0x0600F0F0 RID: 61680 RVA: 0x003637BF File Offset: 0x003619BF
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600F0F1 RID: 61681 RVA: 0x003637CE File Offset: 0x003619CE
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600F0F2 RID: 61682 RVA: 0x003637E8 File Offset: 0x003619E8
		public int TowerTypeFilter(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x0600F0F3 RID: 61683 RVA: 0x00363828 File Offset: 0x00361A28
		public int TowerTypeFilterLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F0F4 RID: 61684 RVA: 0x00363854 File Offset: 0x00361A54
		public Span<int> GetTowerTypeFilterBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600F0F5 RID: 61685 RVA: 0x00363864 File Offset: 0x00361A64
		public int[] GetTowerTypeFilterArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600F0F6 RID: 61686 RVA: 0x0036387C File Offset: 0x00361A7C
		public int MonsterTypeFilter(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x0600F0F7 RID: 61687 RVA: 0x003638BC File Offset: 0x00361ABC
		public int MonsterTypeFilterLength
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

		// Token: 0x0600F0F8 RID: 61688 RVA: 0x003638E8 File Offset: 0x00361AE8
		public Span<int> GetMonsterTypeFilterBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600F0F9 RID: 61689 RVA: 0x003638F8 File Offset: 0x00361AF8
		public int[] GetMonsterTypeFilterArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600F0FA RID: 61690 RVA: 0x00363910 File Offset: 0x00361B10
		public int Params(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x0600F0FB RID: 61691 RVA: 0x00363950 File Offset: 0x00361B50
		public int ParamsLength
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

		// Token: 0x0600F0FC RID: 61692 RVA: 0x0036397C File Offset: 0x00361B7C
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600F0FD RID: 61693 RVA: 0x0036398C File Offset: 0x00361B8C
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600F0FE RID: 61694 RVA: 0x003639A4 File Offset: 0x00361BA4
		public DicIntInt? MapParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x0600F0FF RID: 61695 RVA: 0x00363A08 File Offset: 0x00361C08
		public int MapParamsLength
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

		// Token: 0x0600F100 RID: 61696 RVA: 0x00363A34 File Offset: 0x00361C34
		[NullableContext(1)]
		public int[] Buffs()
		{
			return this.GetBuffsArray();
		}

		// Token: 0x0600F101 RID: 61697 RVA: 0x00363A3C File Offset: 0x00361C3C
		[NullableContext(1)]
		public IEnumerable<int> BuffsIter()
		{
			TrapDefenseGaining.<BuffsIter>d__36 <BuffsIter>d__ = new TrapDefenseGaining.<BuffsIter>d__36(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x0600F102 RID: 61698 RVA: 0x00363A54 File Offset: 0x00361C54
		[NullableContext(1)]
		public Dictionary<int, int> MapParams()
		{
			return this.MapParamsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600F103 RID: 61699 RVA: 0x00363AAA File Offset: 0x00361CAA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MapParamsIter()
		{
			TrapDefenseGaining.<MapParamsIter>d__38 <MapParamsIter>d__ = new TrapDefenseGaining.<MapParamsIter>d__38(-2);
			<MapParamsIter>d__.<>3__<>4__this = this;
			return <MapParamsIter>d__;
		}

		// Token: 0x0600F104 RID: 61700 RVA: 0x00363ABF File Offset: 0x00361CBF
		[NullableContext(1)]
		public int[] MonsterTypeFilter()
		{
			return this.GetMonsterTypeFilterArray();
		}

		// Token: 0x0600F105 RID: 61701 RVA: 0x00363AC7 File Offset: 0x00361CC7
		[NullableContext(1)]
		public IEnumerable<int> MonsterTypeFilterIter()
		{
			TrapDefenseGaining.<MonsterTypeFilterIter>d__40 <MonsterTypeFilterIter>d__ = new TrapDefenseGaining.<MonsterTypeFilterIter>d__40(-2);
			<MonsterTypeFilterIter>d__.<>3__<>4__this = this;
			return <MonsterTypeFilterIter>d__;
		}

		// Token: 0x0600F106 RID: 61702 RVA: 0x00363ADC File Offset: 0x00361CDC
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x0600F107 RID: 61703 RVA: 0x00363AE4 File Offset: 0x00361CE4
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			TrapDefenseGaining.<ParamsIter>d__42 <ParamsIter>d__ = new TrapDefenseGaining.<ParamsIter>d__42(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0600F108 RID: 61704 RVA: 0x00363AF9 File Offset: 0x00361CF9
		[NullableContext(1)]
		public int[] TowerTypeFilter()
		{
			return this.GetTowerTypeFilterArray();
		}

		// Token: 0x0600F109 RID: 61705 RVA: 0x00363B01 File Offset: 0x00361D01
		[NullableContext(1)]
		public IEnumerable<int> TowerTypeFilterIter()
		{
			TrapDefenseGaining.<TowerTypeFilterIter>d__44 <TowerTypeFilterIter>d__ = new TrapDefenseGaining.<TowerTypeFilterIter>d__44(-2);
			<TowerTypeFilterIter>d__.<>3__<>4__this = this;
			return <TowerTypeFilterIter>d__;
		}

		// Token: 0x0600F10A RID: 61706 RVA: 0x00363B18 File Offset: 0x00361D18
		public int? GetMapParams(int key)
		{
			this.EnsureMapParamsCacheIfNeeded();
			int value;
			if (!this.MapParamsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F10B RID: 61707 RVA: 0x00363B4C File Offset: 0x00361D4C
		private void EnsureMapParamsCacheIfNeeded()
		{
			if (this.MapParamsCache != null)
			{
				return;
			}
			this.MapParamsCache = this.MapParamsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F10C RID: 61708 RVA: 0x00363BB2 File Offset: 0x00361DB2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMapParamsFrozenDict()
		{
			this.EnsureMapParamsCacheIfNeeded();
			return this.MapParamsCache;
		}

		// Token: 0x040058E9 RID: 22761
		private Table __p;

		// Token: 0x040058EA RID: 22762
		[Nullable(2)]
		private FrozenDictionary<int, int> MapParamsCache;
	}
}
