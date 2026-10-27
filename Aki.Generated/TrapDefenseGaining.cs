using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001161 RID: 4449
	public struct TrapDefenseGaining : IFlatbufferObject
	{
		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0600E378 RID: 58232 RVA: 0x00338611 File Offset: 0x00336811
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x0033861E File Offset: 0x0033681E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E37A RID: 58234 RVA: 0x00338628 File Offset: 0x00336828
		public static TrapDefenseGaining GetRootAsTrapDefenseGaining(ByteBuffer _bb)
		{
			return TrapDefenseGaining.GetRootAsTrapDefenseGaining(_bb, default(TrapDefenseGaining));
		}

		// Token: 0x0600E37B RID: 58235 RVA: 0x00338644 File Offset: 0x00336844
		public static TrapDefenseGaining GetRootAsTrapDefenseGaining(ByteBuffer _bb, TrapDefenseGaining obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E37C RID: 58236 RVA: 0x00338661 File Offset: 0x00336861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E37D RID: 58237 RVA: 0x00338670 File Offset: 0x00336870
		public TrapDefenseGaining __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0600E37E RID: 58238 RVA: 0x00338680 File Offset: 0x00336880
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

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0600E37F RID: 58239 RVA: 0x003386BC File Offset: 0x003368BC
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

		// Token: 0x0600E380 RID: 58240 RVA: 0x003386F8 File Offset: 0x003368F8
		public int Buffs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0600E381 RID: 58241 RVA: 0x00338738 File Offset: 0x00336938
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

		// Token: 0x0600E382 RID: 58242 RVA: 0x00338763 File Offset: 0x00336963
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x00338772 File Offset: 0x00336972
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x0033878C File Offset: 0x0033698C
		public int TowerTypeFilter(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0600E385 RID: 58245 RVA: 0x003387CC File Offset: 0x003369CC
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

		// Token: 0x0600E386 RID: 58246 RVA: 0x003387F8 File Offset: 0x003369F8
		public Span<int> GetTowerTypeFilterBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E387 RID: 58247 RVA: 0x00338808 File Offset: 0x00336A08
		public int[] GetTowerTypeFilterArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600E388 RID: 58248 RVA: 0x00338820 File Offset: 0x00336A20
		public int MonsterTypeFilter(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0600E389 RID: 58249 RVA: 0x00338860 File Offset: 0x00336A60
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

		// Token: 0x0600E38A RID: 58250 RVA: 0x0033888C File Offset: 0x00336A8C
		public Span<int> GetMonsterTypeFilterBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x0033889C File Offset: 0x00336A9C
		public int[] GetMonsterTypeFilterArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E38C RID: 58252 RVA: 0x003388B4 File Offset: 0x00336AB4
		public int Params(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0600E38D RID: 58253 RVA: 0x003388F4 File Offset: 0x00336AF4
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

		// Token: 0x0600E38E RID: 58254 RVA: 0x00338920 File Offset: 0x00336B20
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E38F RID: 58255 RVA: 0x00338930 File Offset: 0x00336B30
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600E390 RID: 58256 RVA: 0x00338948 File Offset: 0x00336B48
		public DicIntInt? MapParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0600E391 RID: 58257 RVA: 0x003389AC File Offset: 0x00336BAC
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

		// Token: 0x0600E392 RID: 58258 RVA: 0x003389D8 File Offset: 0x00336BD8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffsIter()或GetBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Buffs()
		{
			TrapDefenseGaining trapDefenseGaining = this;
			return trapDefenseGaining.GetBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E393 RID: 58259 RVA: 0x003389FC File Offset: 0x00336BFC
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffsIter()
		{
			TrapDefenseGaining.<BuffsIter>d__36 <BuffsIter>d__ = new TrapDefenseGaining.<BuffsIter>d__36(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x0600E394 RID: 58260 RVA: 0x00338A14 File Offset: 0x00336C14
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MapParamsFrozenDict()缓存字典，遍历请使用MapParamsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MapParams()
		{
			return this.MapParamsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E395 RID: 58261 RVA: 0x00338A6A File Offset: 0x00336C6A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MapParamsIter()
		{
			TrapDefenseGaining.<MapParamsIter>d__38 <MapParamsIter>d__ = new TrapDefenseGaining.<MapParamsIter>d__38(-2);
			<MapParamsIter>d__.<>3__<>4__this = this;
			return <MapParamsIter>d__;
		}

		// Token: 0x0600E396 RID: 58262 RVA: 0x00338A80 File Offset: 0x00336C80
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterTypeFilterIter()或GetMonsterTypeFilterBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterTypeFilter()
		{
			TrapDefenseGaining trapDefenseGaining = this;
			return trapDefenseGaining.GetMonsterTypeFilterArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x00338AA4 File Offset: 0x00336CA4
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterTypeFilterIter()
		{
			TrapDefenseGaining.<MonsterTypeFilterIter>d__40 <MonsterTypeFilterIter>d__ = new TrapDefenseGaining.<MonsterTypeFilterIter>d__40(-2);
			<MonsterTypeFilterIter>d__.<>3__<>4__this = this;
			return <MonsterTypeFilterIter>d__;
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x00338ABC File Offset: 0x00336CBC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			TrapDefenseGaining trapDefenseGaining = this;
			return trapDefenseGaining.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E399 RID: 58265 RVA: 0x00338AE0 File Offset: 0x00336CE0
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			TrapDefenseGaining.<ParamsIter>d__42 <ParamsIter>d__ = new TrapDefenseGaining.<ParamsIter>d__42(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0600E39A RID: 58266 RVA: 0x00338AF8 File Offset: 0x00336CF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TowerTypeFilterIter()或GetTowerTypeFilterBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TowerTypeFilter()
		{
			TrapDefenseGaining trapDefenseGaining = this;
			return trapDefenseGaining.GetTowerTypeFilterArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E39B RID: 58267 RVA: 0x00338B1C File Offset: 0x00336D1C
		[NullableContext(1)]
		public readonly IEnumerable<int> TowerTypeFilterIter()
		{
			TrapDefenseGaining.<TowerTypeFilterIter>d__44 <TowerTypeFilterIter>d__ = new TrapDefenseGaining.<TowerTypeFilterIter>d__44(-2);
			<TowerTypeFilterIter>d__.<>3__<>4__this = this;
			return <TowerTypeFilterIter>d__;
		}

		// Token: 0x0600E39C RID: 58268 RVA: 0x00338B34 File Offset: 0x00336D34
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

		// Token: 0x0600E39D RID: 58269 RVA: 0x00338B68 File Offset: 0x00336D68
		private void EnsureMapParamsCacheIfNeeded()
		{
			if (this.MapParamsCache != null)
			{
				return;
			}
			this.MapParamsCache = this.MapParamsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E39E RID: 58270 RVA: 0x00338BCE File Offset: 0x00336DCE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMapParamsFrozenDict(int key)
		{
			this.EnsureMapParamsCacheIfNeeded();
			return this.MapParamsCache;
		}

		// Token: 0x040052A6 RID: 21158
		private Table __p;

		// Token: 0x040052A7 RID: 21159
		[Nullable(2)]
		private FrozenDictionary<int, int> MapParamsCache;
	}
}
