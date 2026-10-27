using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001081 RID: 4225
	public struct RoverRogueRefresh : IFlatbufferObject
	{
		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600CE94 RID: 52884 RVA: 0x00307BB4 File Offset: 0x00305DB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x00307BC1 File Offset: 0x00305DC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x00307BC8 File Offset: 0x00305DC8
		public static RoverRogueRefresh GetRootAsRoverRogueRefresh(ByteBuffer _bb)
		{
			return RoverRogueRefresh.GetRootAsRoverRogueRefresh(_bb, default(RoverRogueRefresh));
		}

		// Token: 0x0600CE97 RID: 52887 RVA: 0x00307BE4 File Offset: 0x00305DE4
		public static RoverRogueRefresh GetRootAsRoverRogueRefresh(ByteBuffer _bb, RoverRogueRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x00307C01 File Offset: 0x00305E01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x00307C10 File Offset: 0x00305E10
		public RoverRogueRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600CE9A RID: 52890 RVA: 0x00307C20 File Offset: 0x00305E20
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

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600CE9B RID: 52891 RVA: 0x00307C5C File Offset: 0x00305E5C
		public int Cost
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CE9C RID: 52892 RVA: 0x00307C98 File Offset: 0x00305E98
		public DicIntInt? CostGrow(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600CE9D RID: 52893 RVA: 0x00307CF8 File Offset: 0x00305EF8
		public int CostGrowLength
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

		// Token: 0x0600CE9E RID: 52894 RVA: 0x00307D24 File Offset: 0x00305F24
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CostGrowFrozenDict()缓存字典，遍历请使用CostGrowIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CostGrow()
		{
			return this.CostGrowIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CE9F RID: 52895 RVA: 0x00307D7A File Offset: 0x00305F7A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CostGrowIter()
		{
			RoverRogueRefresh.<CostGrowIter>d__16 <CostGrowIter>d__ = new RoverRogueRefresh.<CostGrowIter>d__16(-2);
			<CostGrowIter>d__.<>3__<>4__this = this;
			return <CostGrowIter>d__;
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x00307D90 File Offset: 0x00305F90
		public int? GetCostGrow(int key)
		{
			this.EnsureCostGrowCacheIfNeeded();
			int value;
			if (!this.CostGrowCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x00307DC4 File Offset: 0x00305FC4
		private void EnsureCostGrowCacheIfNeeded()
		{
			if (this.CostGrowCache != null)
			{
				return;
			}
			this.CostGrowCache = this.CostGrowIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x00307E2A File Offset: 0x0030602A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCostGrowFrozenDict(int key)
		{
			this.EnsureCostGrowCacheIfNeeded();
			return this.CostGrowCache;
		}

		// Token: 0x0400518B RID: 20875
		private Table __p;

		// Token: 0x0400518C RID: 20876
		[Nullable(2)]
		private FrozenDictionary<int, int> CostGrowCache;
	}
}
