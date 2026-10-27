using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110B RID: 4363
	public struct SurvivorsWave : IFlatbufferObject
	{
		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600DBEC RID: 56300 RVA: 0x00327375 File Offset: 0x00325575
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DBED RID: 56301 RVA: 0x00327382 File Offset: 0x00325582
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DBEE RID: 56302 RVA: 0x0032738C File Offset: 0x0032558C
		public static SurvivorsWave GetRootAsSurvivorsWave(ByteBuffer _bb)
		{
			return SurvivorsWave.GetRootAsSurvivorsWave(_bb, default(SurvivorsWave));
		}

		// Token: 0x0600DBEF RID: 56303 RVA: 0x003273A8 File Offset: 0x003255A8
		public static SurvivorsWave GetRootAsSurvivorsWave(ByteBuffer _bb, SurvivorsWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x003273C5 File Offset: 0x003255C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DBF1 RID: 56305 RVA: 0x003273D4 File Offset: 0x003255D4
		public SurvivorsWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600DBF2 RID: 56306 RVA: 0x003273E4 File Offset: 0x003255E4
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

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600DBF3 RID: 56307 RVA: 0x00327420 File Offset: 0x00325620
		public int Level
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

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600DBF4 RID: 56308 RVA: 0x0032745C File Offset: 0x0032565C
		public int Wave
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

		// Token: 0x0600DBF5 RID: 56309 RVA: 0x00327498 File Offset: 0x00325698
		public int WaveConditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600DBF6 RID: 56310 RVA: 0x003274D8 File Offset: 0x003256D8
		public int WaveConditionsLength
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

		// Token: 0x0600DBF7 RID: 56311 RVA: 0x00327504 File Offset: 0x00325704
		public Span<int> GetWaveConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600DBF8 RID: 56312 RVA: 0x00327514 File Offset: 0x00325714
		public int[] GetWaveConditionsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600DBF9 RID: 56313 RVA: 0x0032752C File Offset: 0x0032572C
		public int WaveTime
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

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x0032756C File Offset: 0x0032576C
		public int EndlessModeWaveTime
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

		// Token: 0x0600DBFB RID: 56315 RVA: 0x003275AC File Offset: 0x003257AC
		public int ConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x003275EC File Offset: 0x003257EC
		public int ConditionSpawnIdsLength
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

		// Token: 0x0600DBFD RID: 56317 RVA: 0x00327618 File Offset: 0x00325818
		public Span<int> GetConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600DBFE RID: 56318 RVA: 0x00327628 File Offset: 0x00325828
		public int[] GetConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600DBFF RID: 56319 RVA: 0x00327640 File Offset: 0x00325840
		public int EndlessModeConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600DC00 RID: 56320 RVA: 0x00327680 File Offset: 0x00325880
		public int EndlessModeConditionSpawnIdsLength
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

		// Token: 0x0600DC01 RID: 56321 RVA: 0x003276AC File Offset: 0x003258AC
		public Span<int> GetEndlessModeConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DC02 RID: 56322 RVA: 0x003276BC File Offset: 0x003258BC
		public int[] GetEndlessModeConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600DC03 RID: 56323 RVA: 0x003276D4 File Offset: 0x003258D4
		public int WaveType
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

		// Token: 0x0600DC04 RID: 56324 RVA: 0x00327714 File Offset: 0x00325914
		public DicStringInt? TreasurePool(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600DC05 RID: 56325 RVA: 0x00327778 File Offset: 0x00325978
		public int TreasurePoolLength
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

		// Token: 0x0600DC06 RID: 56326 RVA: 0x003277A4 File Offset: 0x003259A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionSpawnIdsIter()或GetConditionSpawnIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConditionSpawnIds()
		{
			SurvivorsWave survivorsWave = this;
			return survivorsWave.GetConditionSpawnIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DC07 RID: 56327 RVA: 0x003277C8 File Offset: 0x003259C8
		[NullableContext(1)]
		public readonly IEnumerable<int> ConditionSpawnIdsIter()
		{
			SurvivorsWave.<ConditionSpawnIdsIter>d__39 <ConditionSpawnIdsIter>d__ = new SurvivorsWave.<ConditionSpawnIdsIter>d__39(-2);
			<ConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <ConditionSpawnIdsIter>d__;
		}

		// Token: 0x0600DC08 RID: 56328 RVA: 0x003277E0 File Offset: 0x003259E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EndlessModeConditionSpawnIdsIter()或GetEndlessModeConditionSpawnIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EndlessModeConditionSpawnIds()
		{
			SurvivorsWave survivorsWave = this;
			return survivorsWave.GetEndlessModeConditionSpawnIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DC09 RID: 56329 RVA: 0x00327804 File Offset: 0x00325A04
		[NullableContext(1)]
		public readonly IEnumerable<int> EndlessModeConditionSpawnIdsIter()
		{
			SurvivorsWave.<EndlessModeConditionSpawnIdsIter>d__41 <EndlessModeConditionSpawnIdsIter>d__ = new SurvivorsWave.<EndlessModeConditionSpawnIdsIter>d__41(-2);
			<EndlessModeConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <EndlessModeConditionSpawnIdsIter>d__;
		}

		// Token: 0x0600DC0A RID: 56330 RVA: 0x0032781C File Offset: 0x00325A1C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TreasurePoolFrozenDict()缓存字典，遍历请使用TreasurePoolIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> TreasurePool()
		{
			return this.TreasurePoolIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600DC0B RID: 56331 RVA: 0x00327872 File Offset: 0x00325A72
		[NullableContext(1)]
		public readonly IEnumerable<DicStringInt> TreasurePoolIter()
		{
			SurvivorsWave.<TreasurePoolIter>d__43 <TreasurePoolIter>d__ = new SurvivorsWave.<TreasurePoolIter>d__43(-2);
			<TreasurePoolIter>d__.<>3__<>4__this = this;
			return <TreasurePoolIter>d__;
		}

		// Token: 0x0600DC0C RID: 56332 RVA: 0x00327888 File Offset: 0x00325A88
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaveConditionsIter()或GetWaveConditionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaveConditions()
		{
			SurvivorsWave survivorsWave = this;
			return survivorsWave.GetWaveConditionsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DC0D RID: 56333 RVA: 0x003278AC File Offset: 0x00325AAC
		[NullableContext(1)]
		public readonly IEnumerable<int> WaveConditionsIter()
		{
			SurvivorsWave.<WaveConditionsIter>d__45 <WaveConditionsIter>d__ = new SurvivorsWave.<WaveConditionsIter>d__45(-2);
			<WaveConditionsIter>d__.<>3__<>4__this = this;
			return <WaveConditionsIter>d__;
		}

		// Token: 0x0600DC0E RID: 56334 RVA: 0x003278C4 File Offset: 0x00325AC4
		[NullableContext(1)]
		public int? GetTreasurePool(string key)
		{
			this.EnsureTreasurePoolCacheIfNeeded();
			int value;
			if (!this.TreasurePoolCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DC0F RID: 56335 RVA: 0x003278F8 File Offset: 0x00325AF8
		private void EnsureTreasurePoolCacheIfNeeded()
		{
			if (this.TreasurePoolCache != null)
			{
				return;
			}
			this.TreasurePoolCache = this.TreasurePoolIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DC10 RID: 56336 RVA: 0x0032795E File Offset: 0x00325B5E
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetTreasurePoolFrozenDict(string key)
		{
			this.EnsureTreasurePoolCacheIfNeeded();
			return this.TreasurePoolCache;
		}

		// Token: 0x04005245 RID: 21061
		private Table __p;

		// Token: 0x04005246 RID: 21062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> TreasurePoolCache;
	}
}
